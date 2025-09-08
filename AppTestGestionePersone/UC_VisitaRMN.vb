Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity
Imports Syncfusion.WinForms.Input
Imports Syncfusion.WinForms.ListView.Styles
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles
Public Class UC_VisitaRMN
    Dim idVisita As Integer = -1

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

        ' ====================
        ' SfButtons
        ' ====================
        With ButtonInserisci.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
            .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With

        ' ====================
        ' ComboBox
        ' ====================
        With ComboBoxEsito
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Negativo", "Neuropatia pudendo", "Endometriosi"}
            .SelectedIndex = -1

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With

        With ComboBoxEndometriosi
            ' Imposta i dati
            .DataSource = New List(Of String) From {"LUS - Torus", "Vescicale/setto RV", "Peritoneale", "Ovarico"}
            .SelectedIndex = -1

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

    Public Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(ComboBoxEndometriosi, ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Sub FormVisitaRMN_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDPazienteSelezionato
            ' Cerco se esiste già l'anamnesi fisiologica per il paziente selezionato
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(ComboBoxEndometriosi, ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Sub ComboBoxEsito_CheckedChanged(sender As Object, e As EventArgs) Handles ComboBoxEsito.SelectedIndexChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        If ComboBoxEsito.SelectedIndex = -1 Then
            PulisciCampi(ComboBoxEndometriosi)
            SetControlsEnabled(False, ComboBoxEndometriosi)
        ElseIf ComboBoxEsito.SelectedItem.ToString() = "Endometriosi" Then
            SetControlsEnabled(True, ComboBoxEndometriosi)
        Else
            PulisciCampi(ComboBoxEndometriosi)
            SetControlsEnabled(False, ComboBoxEndometriosi)
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

        If ComboBoxEsito.SelectedItem = "Endometriosi" AndAlso ComboBoxEndometriosi.SelectedIndex = -1 Then
            result = False
            HilightControls(True, ComboBoxEndometriosi)
        Else
            HilightControls(False, ComboBoxEndometriosi)
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
        Dim checkQuery As String = "SELECT * FROM VisitaRMN WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' RMN esistente per la visita selezionata

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)
            main.MostraToast("RMN esistente per la visita selezionata. Dati caricati.")

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            DateTimePickerDataEsecuzione.Value = CDate(dettagliVisita("DataRMN"))
            ComboBoxEsito.SelectedItem = dettagliVisita("EsitoRMN")
            If dettagliVisita("EsitoRMN") = "Endometriosi" Then
                ComboBoxEndometriosi.SelectedItem = dettagliVisita("TipoEndometriosi")
            Else
                ComboBoxEndometriosi.SelectedIndex = -1
            End If

            Return esiste
        Else
            esiste = False
            PulisciCampi(ComboBoxEndometriosi, ComboBoxEsito)
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
            Dim esitoRMN As String = ComboBoxEsito.SelectedItem.ToString()
            Dim dettagliEndometriosi As Object

            If ComboBoxEsito.SelectedItem.ToString() <> "Endometriosi" Then
                dettagliEndometriosi = DBNull.Value
            Else
                dettagliEndometriosi = ComboBoxEndometriosi.SelectedItem.ToString()
            End If

            Try
                Dim queryRMN As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    queryRMN = "UPDATE VisitaRMN SET 
                                                          DataRMN = @dataRMN,
                                                          EsitoRMN = @esitoRMN,
                                                          DettagliEndometriosi = @dettagliEndometriosi
                                                          WHERE ID_Visita = @idVisita"
                Else
                    'Se non esiste, esegui l'inserimento
                    queryRMN = "INSERT INTO VisitaRMN (
                                                    ID_Visita,
                                                    DataRMN,
                                                    EsitoRMN,
                                                    DettagliEndometriosi
                                                    ) VALUES (
                                                    @idVisita,
                                                    @dataRMN,
                                                    @esitoRMN,
                                                    @dettagliEndometriosi)"
                End If

                Dim parametriRMN As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@idVisita", idVisita),
                    New SqlClient.SqlParameter("@dataRMN", dataEsecuzione),
                    New SqlClient.SqlParameter("@esitoRMN", esitoRMN),
                    New SqlClient.SqlParameter("@dettagliEndometriosi", dettagliEndometriosi)
                }

                If EseguiNonQuery(queryRMN, parametriRMN) > 0 Then
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

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito As Boolean = SalvaDati()
        If esito Then
            appenaSalvati = True
            CercaVisita()
        End If
    End Sub
End Class
