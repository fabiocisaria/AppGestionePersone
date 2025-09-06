Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Public Class UC_VisitaDNATest
    Dim idVisita As Integer = -1

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Private dtCeppi As DataTable
    Private dtCeppiOriginale As DataTable
    Private isPopulating As Boolean = False
    Private WithEvents filtroTimer As New Timer()
    Private filtroPrecedente As String = ""
    Public Sub New()
        InitializeComponent()

        ' ====================
        ' SfButtons
        ' ====================
        With ButtonInserisci.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .ForeColor = Color.White
        End With

        ' ====================
        ' ComboBox
        ' ====================
        With ComboBoxEsito
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Negativo", "Positivo"}
            .SelectedIndex = -1

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With

        With ComboBoxCeppo
            ' Popola i ceppi dal database
            PopolaComboBoxCeppi()

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With

        With DateTimePickerDataEsecuzione
            .Style.BackColor = Color.White
            .Style.BorderColor = Color.FromArgb(41, 128, 185)
            .Style.ForeColor = Color.Black
            .Dock = DockStyle.Top
        End With

        DateTimePickerDataEsecuzione.Value = Date.Now
    End Sub

    Private Sub PopolaComboBoxCeppi()
        isPopulating = True ' ← Blocca TextChanged durante il popolamento

        Dim query As String = "SELECT ID, Ceppo, Rischio FROM HPVCeppi ORDER BY Ceppo"
        dtCeppiOriginale = EseguiQuery(query)

        If Not dtCeppiOriginale.Columns.Contains("Descrizione") Then
            dtCeppiOriginale.Columns.Add("Descrizione", GetType(String), "Ceppo + ' - ' + Rischio")
        End If

        ComboBoxCeppo.DataSource = dtCeppiOriginale
        ComboBoxCeppo.DisplayMember = "Descrizione"
        ComboBoxCeppo.ValueMember = "ID"
        ComboBoxCeppo.DropDownStyle = ComboBoxStyle.DropDown
        ComboBoxCeppo.SelectedIndex = -1

        ' Imposta timer debounce
        filtroTimer.Interval = 600

        isPopulating = False ' ← Sblocca TextChanged dopo il popolamento
    End Sub

    ' --- Evento TextChanged con debounce ---
    Private Sub ComboBoxCeppo_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxCeppo.TextChanged
        If isPopulating Then Return
        filtroTimer.Stop()
        filtroTimer.Start()
    End Sub

    ' --- Timer Tick: applica filtro quando l'utente ha smesso di digitare ---
    Private Sub filtroTimer_Tick(sender As Object, e As EventArgs) Handles filtroTimer.Tick
        filtroTimer.Stop()
        ApplicaFiltro()
    End Sub

    ' --- Metodo per filtrare la ComboBox ---
    Private Sub ApplicaFiltro()
        If dtCeppiOriginale Is Nothing Then Return

        Dim filtro As String = ComboBoxCeppo.Text.Trim().ToUpper()

        ' Se il filtro non è cambiato, non fare nulla
        If filtro = filtroPrecedente Then Return
        filtroPrecedente = filtro

        Dim dtFiltrata As DataTable = dtCeppiOriginale.Clone()

        For Each row As DataRow In dtCeppiOriginale.Rows
            If row("Descrizione").ToString().ToUpper().Contains(filtro) Then
                dtFiltrata.ImportRow(row)
            End If
        Next

        ' Salva testo e posizione cursore
        Dim txt As String = ComboBoxCeppo.Text
        Dim selStart As Integer = ComboBoxCeppo.SelectionStart

        ComboBoxCeppo.BeginUpdate()
        ComboBoxCeppo.DataSource = dtFiltrata
        ComboBoxCeppo.DisplayMember = "Descrizione"
        ComboBoxCeppo.ValueMember = "ID"
        ComboBoxCeppo.EndUpdate()

        ' Ripristina testo senza selezionare automaticamente il primo elemento
        ComboBoxCeppo.SelectedIndex = -1
        ComboBoxCeppo.Text = txt
        ComboBoxCeppo.SelectionStart = selStart
        ComboBoxCeppo.SelectionLength = 0

        UpdateDropDownHeight()

        ' Apri automaticamente il dropdown se ci sono elementi filtrati
        'If ComboBoxCeppo.Items.Count > 0 Then
        'ComboBoxCeppo.DroppedDown = True
        'End If
    End Sub

    ' --- Metodo per regolare altezza tendina ---
    Private Sub UpdateDropDownHeight()
        Dim itemCount As Integer = ComboBoxCeppo.Items.Count
        Dim maxVisible As Integer = 10
        If itemCount > maxVisible Then itemCount = maxVisible
        ComboBoxCeppo.DropDownHeight = (ComboBoxCeppo.ItemHeight * itemCount) + 2
    End Sub

    Public Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(ComboBoxCeppo, ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Sub FormVisitaDNATest_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDPazienteSelezionato
            ' Cerco se esiste già l'anamnesi fisiologica per il paziente selezionato
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(ComboBoxCeppo, ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Sub ComboBoxEsito_CheckedChanged(sender As Object, e As EventArgs) Handles ComboBoxEsito.SelectedIndexChanged
        ' Mostra i ceppi solo se "Positivo" è selezionato
        If ComboBoxEsito.SelectedIndex = -1 Then
            PulisciCampi(ComboBoxCeppo)
            SetControlsEnabled(False, ComboBoxCeppo)
        ElseIf ComboBoxEsito.SelectedItem.ToString() = "Positivo" Then
            SetControlsEnabled(True, ComboBoxCeppo)
        Else
            PulisciCampi(ComboBoxCeppo)
            SetControlsEnabled(False, ComboBoxCeppo)
        End If
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim result = True

        If ComboBoxEsito.SelectedIndex = -1 Then
            result = False
            HilightControls(True, ComboBoxEsito)
        Else
            HilightControls(False, ComboBoxEsito)
        End If

        If ComboBoxEsito.SelectedItem = "Positivo" AndAlso ComboBoxCeppo.SelectedIndex = -1 Then
            result = False
            HilightControls(True, ComboBoxCeppo)
        Else
            HilightControls(False, ComboBoxCeppo)
        End If

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        If DateTimePickerDataEsecuzione.Value Is Nothing Then
            result = False
            HilightControls(True, DateTimePickerDataEsecuzione)
        ElseIf DateTimePickerDataEsecuzione.Value > main.DataVisitaSelezionata Then
            result = False
            HilightControls(True, DateTimePickerDataEsecuzione)
            main.MostraToast("La data di esecuzione non può essere successiva alla data della visita.")
        Else
            HilightControls(False, DateTimePickerDataEsecuzione)
        End If
        Return result
    End Function

    Private Function CercaVisita() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM VisitaDNATest WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' RMN esistente per la visita selezionata

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)
            main.MostraToast("DNA test esistente per la visita selezionata. Dati caricati.")

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            DateTimePickerDataEsecuzione.Value = CDate(dettagliVisita("DataDNATest"))
            ComboBoxEsito.SelectedItem = dettagliVisita("EsitoDNATest")
            If dettagliVisita("EsitoDNATest") = True Then
                ComboBoxCeppo.SelectedValue = dettagliVisita("ID_Ceppo")
            Else
                ComboBoxCeppo.SelectedIndex = -1
            End If

            Return esiste
        Else
            esiste = False
            PulisciCampi(ComboBoxCeppo, ComboBoxEsito)
            DateTimePickerDataEsecuzione.Value = Date.Now
            Return esiste
        End If
    End Function

    Private Function SalvaDati() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            idVisita = main.IDVisitaSelezionata

            Dim successo As Boolean = False

            Dim dataEsecuzione As Date = DateTimePickerDataEsecuzione.Value
            Dim esitoDNATest As Boolean
            If ComboBoxEsito.SelectedItem.ToString() = "Positivo" Then
                esitoDNATest = True
            Else
                esitoDNATest = False
            End If

            Dim idCeppo As Object

            If ComboBoxEsito.SelectedItem.ToString() <> "Positivo" Then
                idCeppo = DBNull.Value
            Else
                idCeppo = CInt(ComboBoxCeppo.SelectedValue)
            End If

            Try
                Dim queryDNATest As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    queryDNATest = "UPDATE VisitaDNATest SET 
                                                          DataDNATest = @dataDNATest,
                                                          EsitoDNATest = @esitoDNATest,
                                                          ID_Ceppo = @idCeppo
                                                          WHERE ID_Visita = @idVisita"
                Else
                    'Se non esiste, esegui l'inserimento
                    queryDNATest = "INSERT INTO VisitaDNATest (
                                                    ID_Visita,
                                                    DataDNATest,
                                                    EsitoDNATest,
                                                    ID_Ceppo
                                                    ) VALUES (
                                                    @idVisita,
                                                    @dataDNATest,
                                                    @esitoDNATest,
                                                    @idCeppo)"
                End If

                Dim parametriDNATest As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@idVisita", idVisita),
                    New SqlClient.SqlParameter("@dataDNATest", dataEsecuzione),
                    New SqlClient.SqlParameter("@esitoDNATest", esitoDNATest),
                    New SqlClient.SqlParameter("@idCeppo", idCeppo)
                }

                If EseguiNonQuery(queryDNATest, parametriDNATest) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("DNA test aggiornato correttamente.")
                    Else
                        main.MostraToast("DNA test salvato correttamente.")
                    End If
                Else
                    main.MostraToast("Errore imprevisto durante il salvataggio dei dati.")
                    esito = False
                End If
            Catch ex As Exception
                MessageBox.Show("Errore imprevisto: " & ex.Message)
                esito = False
            End Try
        Else
            esito = False
        End If

        Return esito
    End Function

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito As Boolean = SalvaDati()
        If esito Then
            appenaSalvati = True
            CercaVisita()
        End If
    End Sub
End Class
