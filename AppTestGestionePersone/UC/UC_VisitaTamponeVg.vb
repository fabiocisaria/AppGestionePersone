Imports Microsoft.Data.SqlClient
Public Class UC_VisitaTamponeVg
    Dim idVisita As Integer = -1

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

        ThemeManager_old.ApplyThemeToControls(Me)

        ' ====================
        ' ComboBox
        ' ====================
        With ComboBoxEsito
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Negativo", "Positivo"}
            .SelectedIndex = -1
        End With

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo

        DateTimePickerDataEsecuzione.Value = Date.Now
    End Sub

    Private Async Sub FormVisitaTamponeVg_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDPazienteSelezionato

            ' Cerco se esiste già un tampone vaginale per la visita selezionata
            TableLayoutPanelTamponeVg.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelTamponeVg.Enabled = True

            If Not esiste Then
                PulisciCampi(ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Public Async Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata

            ' Cerco se esiste già un tampone vaginale per la visita selezionata
            TableLayoutPanelTamponeVg.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelTamponeVg.Enabled = True

            If Not esiste Then
                PulisciCampi(ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim result = True

        If ComboBoxEsito.SelectedIndex = -1 OrElse Not Utils.IsValidSelection(ComboBoxEsito) Then
            HilightControls(True, ComboBoxEsito)
            result = False
        Else
            HilightControls(False, ComboBoxEsito)
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
        Dim checkQuery As String = "SELECT * FROM VisitaTamponeVg WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlParameter) From {
        New SqlParameter("@idVisita", idVisita)
    }
        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' RMN esistente per la visita selezionata

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)

            If Not appenaSalvati Then
                main.MostraToast("Tampone vaginale esistente per la visita selezionata. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            DateTimePickerDataEsecuzione.Value = CDate(dettagliVisita("DataTamponeVg"))
            ComboBoxEsito.SelectedItem = dettagliVisita("EsitoTamponeVg")

            Return esiste
        Else
            esiste = False
            PulisciCampi(ComboBoxEsito)
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
            Dim esitoTamponeVg As Boolean
            If ComboBoxEsito.SelectedItem.ToString() = "Positivo" Then
                esitoTamponeVg = True
            Else
                esitoTamponeVg = False
            End If

            Try
                Dim queryTamponeVg As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    queryTamponeVg = "UPDATE VisitaTamponeVg SET 
                                                          DataTamponeVg = @dataTamponeVg,
                                                          EsitoTamponeVg = @esitoTamponeVg
                                                          WHERE ID_Visita = @idVisita"
                Else
                    'Se non esiste, esegui l'VisitaTamponeVg
                    queryTamponeVg = "INSERT INTO VisitaTamponeVg (
                                                    ID_Visita,
                                                    DataTamponeVg,
                                                    EsitoTamponeVg
                                                    ) VALUES (
                                                    @idVisita,
                                                    @dataTamponeVg,
                                                    @esitoTamponeVg)"
                End If

                Dim parametriTamponeVg As New List(Of SqlParameter) From {
                New SqlParameter("@idVisita", idVisita),
                New SqlParameter("@dataTamponeVg", dataEsecuzione),
                New SqlParameter("@esitoTamponeVg", esitoTamponeVg)
            }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryTamponeVg, parametriTamponeVg) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Tampone vaginale aggiornato correttamente.")
                    Else
                        main.MostraToast("Tampone vaginale salvato correttamente.")
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
        TableLayoutPanelTamponeVg.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelTamponeVg.Enabled = True
        If esito Then
            appenaSalvati = True
            TableLayoutPanelTamponeVg.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            Dim result = Await CercaVisitaAsync()
            TableLayoutPanelTamponeVg.Enabled = True
        End If
    End Sub
End Class
