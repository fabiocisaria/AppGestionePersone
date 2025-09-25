Imports System.Diagnostics.Eventing
Imports Microsoft.Data.SqlClient
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
        ' ComboBox
        ' ====================
        With ComboBoxEsito
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Negativo", "Positivo"}
            .SelectedIndex = -1
        End With

        With ComboBoxCeppo
            ' Popola i ceppi dal database
            PopolaComboBoxCeppiAsync()
        End With

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo

        DateTimePickerDataEsecuzione.Value = Date.Now
    End Sub

    Private Async Sub FormVisitaDNATest_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDPazienteSelezionato
            ' Cerco se esiste già l'anamnesi fisiologica per il paziente selezionato
            TableLayoutPanelDNA.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelDNA.Enabled = True
            If Not esiste Then
                PulisciCampi(ComboBoxCeppo, ComboBoxEsito)
                SetControlsEnabled(False, ComboBoxCeppo)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Async Sub PopolaComboBoxCeppiAsync()
        Dim query As String = "SELECT ID, Ceppo, Rischio FROM HPVCeppi ORDER BY Ceppo"

        dtCeppiOriginale = Await ConnessioneDB.EseguiQueryAsync(query)

        If Not dtCeppiOriginale.Columns.Contains("Descrizione") Then
            dtCeppiOriginale.Columns.Add("Descrizione", GetType(String), "Ceppo + ' - ' + Rischio")
        End If

        ComboBoxCeppo.DataSource = dtCeppiOriginale
        ComboBoxCeppo.DisplayMember = "Descrizione"
        ComboBoxCeppo.ValueMember = "ID"
        ComboBoxCeppo.SelectedIndex = -1
    End Sub
    Public Async Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata

            TableLayoutPanelDNA.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelDNA.Enabled = True

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

        If ComboBoxEsito.SelectedIndex = -1 OrElse Not Utils.IsValidSelection(ComboBoxEsito) Then
            result = False
            HilightControls(True, ComboBoxEsito)
        Else
            HilightControls(False, ComboBoxEsito)
        End If

        If ComboBoxEsito.SelectedItem = "Positivo" AndAlso (ComboBoxCeppo.SelectedIndex = -1 OrElse Not Utils.IsValidSelection(ComboBoxCeppo)) Then
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

    Private Async Function CercaVisitaAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM VisitaDNATest WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' RMN esistente per la visita selezionata

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)

            If Not appenaSalvati Then
                main.MostraToast("DNA test esistente per la visita selezionata. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            DateTimePickerDataEsecuzione.Value = CDate(dettagliVisita("DataDNATest"))

            Dim esito As Boolean = Convert.ToBoolean(dettagliVisita("EsitoDNATest"))

            If esito Then
                ComboBoxEsito.SelectedItem = "Positivo"
            Else
                ComboBoxEsito.SelectedItem = "Negativo"
            End If

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

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
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

                Dim parametriDNATest As New List(Of SqlParameter) From {
                    New SqlParameter("@idVisita", idVisita),
                    New SqlParameter("@dataDNATest", dataEsecuzione),
                    New SqlParameter("@esitoDNATest", esitoDNATest),
                    New SqlParameter("@idCeppo", idCeppo)
                }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryDNATest, parametriDNATest) > 0 Then
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

    Private Async Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Disabilito tutti i controlli
        TableLayoutPanelDNA.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelDNA.Enabled = True
        If esito Then
            appenaSalvati = True
            TableLayoutPanelDNA.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            Dim result = Await CercaVisitaAsync()
            TableLayoutPanelDNA.Enabled = True
        End If
    End Sub
End Class
