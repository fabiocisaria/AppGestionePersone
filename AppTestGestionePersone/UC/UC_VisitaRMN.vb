Imports Microsoft.Data.SqlClient
Public Class UC_VisitaRMN
    Dim idVisita As Integer = -1

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

        ' ========
        ' ComboBox
        ' ========
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

    Private Async Sub FormVisitaRMN_Shown(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDPazienteSelezionato

            ' Cerco se esiste già una RMN per la visita selezionata
            TableLayoutPanelRmn.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelRmn.Enabled = True

            PulisciCampi(TableLayoutPanelNuovaRMN, ComboBoxEsito)

            ResetAndDisableControls(False, TableLayoutPanelDettEsito)
            ResetAndDisableControls(False, TableLayoutPanelEndom)
            ResetAndDisableControls(False, TableLayoutPanelEndomLoc)

            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDettEsito, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelEndom, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelEndomLoc, False)

            DateTimePickerDataEsecuzione.Value = Date.Now


        End If
    End Sub

    Public Async Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata

            ' Cerco se esiste già una RMN per la visita selezionata
            TableLayoutPanelRmn.Enabled = False

            If Not appenaSalvati Then
                main.MostraToast("Caricamento in corso ...")
            End If

            esiste = Await CercaVisitaAsync()

            TableLayoutPanelRmn.Enabled = True

            If Not esiste Then
                PulisciCampi(TableLayoutPanelNuovaRMN, ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Sub ComboBoxEsito_CheckedChanged(sender As Object, e As EventArgs) Handles ComboBoxEsito.SelectedIndexChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        If ComboBoxEsito.SelectedIndex = -1 OrElse Not Utils.IsValidSelection(ComboBoxEsito) OrElse ComboBoxEsito.SelectedItem.ToString() = "Negativo" Then
            PulisciCampi(TableLayoutPanelDettEsito)
            SetControlsEnabled(False, TableLayoutPanelDettEsito)
            SetControlsEnabled(False, TableLayoutPanelEndom)
            SetControlsEnabled(False, TableLayoutPanelEndomLoc)

            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDettEsito, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelEndom, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelEndomLoc, False)

        ElseIf ComboBoxEsito.SelectedItem.ToString() = "Positivo" Then
            SetControlsEnabled(True, TableLayoutPanelDettEsito)
            SetControlsEnabled(True, TableLayoutPanelEndom)
            SetControlsEnabled(False, TableLayoutPanelEndomLoc)

            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDettEsito, True)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelEndom, True)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelEndomLoc, False)
        End If
    End Sub

    Private Sub MetroToggleEndomSiNo_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggleEndomSiNo.CheckedChanged
        SetControlsEnabled(MetroToggleEndomSiNo.Checked, TableLayoutPanelEndomLoc)

        ThemeManager.SetSecondaryPanelState(TableLayoutPanelEndomLoc, MetroToggleEndomSiNo.Checked)
    End Sub



    Private Function CheckSelezione() As Boolean
        Dim result = True

        If ComboBoxEsito.SelectedIndex = -1 OrElse Not Utils.IsValidSelection(ComboBoxEsito) Then
            result = False
            HilightControls(True, ComboBoxEsito)
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
        Dim checkQuery As String = "SELECT * FROM VisitaRMN WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' RMN esistente per la visita selezionata

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)

            If Not appenaSalvati Then
                main.MostraToast("RMN esistente per la visita selezionata. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            DateTimePickerDataEsecuzione.Value = CDate(dettagliVisita("DataRMN"))

            If dettagliVisita("EsitoRMN") Then
                ComboBoxEsito.SelectedItem = "Positivo"

                MetroToggleNevPudSiNo.Checked = dettagliVisita("NevralgiaPudendo")
                MetroToggleEndomSiNo.Checked = dettagliVisita("Endometriosi")

                If MetroToggleEndomSiNo.Checked Then
                    MetroToggleLusTorusSiNo.Checked = dettagliVisita("EndomLusTorus")
                    MetroToggleVescicSiNo.Checked = dettagliVisita("EndomVescicale")
                    MetroToggleRettoVagSiNo.Checked = dettagliVisita("EndomRettoVaginale")
                    MetroTogglePeritSiNo.Checked = dettagliVisita("EndomPeritoneale")
                    MetroToggleOvarSiNo.Checked = dettagliVisita("EndomOvarico")
                End If
            Else
                ComboBoxEsito.SelectedItem = "Negativo"
            End If

            Return esiste
        Else
            esiste = False
            PulisciCampi(TableLayoutPanelNuovaRMN, ComboBoxEsito)
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
            Dim esitoRMN As Boolean = ComboBoxEsito.SelectedItem.ToString() = "Positivo"
            Dim endometriosi As Object
            Dim nevralgiaPudendo As Object
            Dim endomLusTorus As Object
            Dim endomVescicale As Object
            Dim endomRettoVag As Object
            Dim endomPeritoneale As Object
            Dim endomOvarico As Object

            If ComboBoxEsito.SelectedItem.ToString() <> "Positivo" Then
                endometriosi = DBNull.Value
                nevralgiaPudendo = DBNull.Value
                endomLusTorus = DBNull.Value
                endomVescicale = DBNull.Value
                endomRettoVag = DBNull.Value
                endomPeritoneale = DBNull.Value
                endomOvarico = DBNull.Value
            Else
                endometriosi = MetroToggleEndomSiNo.Checked
                nevralgiaPudendo = MetroToggleNevPudSiNo.Checked

                If endometriosi Then
                    endomLusTorus = MetroToggleLusTorusSiNo.Checked
                    endomVescicale = MetroToggleVescicSiNo.Checked
                    endomRettoVag = MetroToggleRettoVagSiNo.Checked
                    endomPeritoneale = MetroTogglePeritSiNo.Checked
                    endomOvarico = MetroToggleOvarSiNo.Checked
                Else
                    endomLusTorus = DBNull.Value
                    endomVescicale = DBNull.Value
                    endomRettoVag = DBNull.Value
                    endomPeritoneale = DBNull.Value
                    endomOvarico = DBNull.Value
                End If
            End If

            Try
                Dim queryRMN As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    queryRMN = "UPDATE VisitaRMN SET 
                                                          DataRMN = @dataRMN,
                                                          EsitoRMN = @esitoRMN,
                                                          NevralgiaPudendo = @nevralgiaPudendo,
                                                          Endometriosi = @endometriosi,
                                                          EndomLusTorus = @endomLusTorus,
                                                          EndomVescicale = @endomVescicale,
                                                          EndomRettoVaginale = @endomRettoVag,
                                                          EndomPeritoneale = @endomPeritoneale,
                                                          EndomOvarico = @endomOvarico
                                                          WHERE ID_Visita = @idVisita"
                Else
                    'Se non esiste, esegui l'inserimento
                    queryRMN = "INSERT INTO VisitaRMN (
                                                    ID_Visita,
                                                    DataRMN,
                                                    EsitoRMN,
                                                    NevralgiaPudendo,
                                                    Endometriosi,
                                                    EndomLusTorus,
                                                    EndomVescicale,
                                                    EndomRettoVaginale,
                                                    EndomPeritoneale,
                                                    EndomOvarico
                                                    ) VALUES (
                                                    @idVisita,
                                                    @dataRMN,
                                                    @esitoRMN,
                                                    @nevralgiaPudendo,
                                                    @endometriosi,
                                                    @endomLusTorus,
                                                    @endomVescicale,
                                                    @endomRettoVag,
                                                    @endomPeritoneale,
                                                    @endomOvarico)"
                End If

                Dim parametriRMN As New List(Of SqlParameter) From {
                    New SqlParameter("@idVisita", idVisita),
                    New SqlParameter("@dataRMN", dataEsecuzione),
                    New SqlParameter("@esitoRMN", esitoRMN),
                    New SqlParameter("@nevralgiaPudendo", nevralgiaPudendo),
                    New SqlParameter("@endometriosi", endometriosi),
                    New SqlParameter("@endomLusTorus", endomLusTorus),
                    New SqlParameter("@endomVescicale", endomVescicale),
                    New SqlParameter("@endomRettoVag", endomRettoVag),
                    New SqlParameter("@endomPeritoneale", endomPeritoneale),
                    New SqlParameter("@endomOvarico", endomOvarico)
                }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryRMN, parametriRMN) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("RMN aggiornata correttamente.")
                    Else
                        main.MostraToast("RMN salvata correttamente.")
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
        TableLayoutPanelRmn.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelRmn.Enabled = True
        If esito Then
            appenaSalvati = True
            TableLayoutPanelRmn.Enabled = False

            'main.MostraToast("Caricamento in corso ...")
            Dim result = Await CercaVisitaAsync()
            TableLayoutPanelRmn.Enabled = True
        End If
    End Sub
End Class
