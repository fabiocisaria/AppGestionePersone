Imports Microsoft.Data.SqlClient
Public Class UC_Anagrafica
    Public Property IDPaziente As Integer
    Public Property CodiceIdentificativoSelezionato As String
    Public Property Cognome As String
    Public Property Nome As String
    Public Property DataNascita As Date
    Public Property IsHandlerAttached As Boolean = False

    Private Shared ReadOnly ControlText As New Dictionary(Of Control, String)

    ' Evento per comunicare alla MainForm il paziente selezionato
    Public Event NuovoPazienteInserito(ID As Integer, CodiceIdentificativo As String, Cognome As String, Nome As String, DataNascita As Date)

    Public Sub New()
        InitializeComponent()

        DateTimePickerDataNascita.AllowNull = True
        DateTimePickerDataNascita.Value = Nothing

        ' ==================
        ' ComboBoxRelazione
        ' ==================
        With ComboBoxRelazione
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Coniugata", "Nessuna relazione", "Relazione stabile", "Relazione non stabile", "NA"}
            .SelectedIndex = -1
        End With

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo
    End Sub

    Private Sub FormAnagrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerDataNascita.Format = DateTimePickerFormat.Short
        ControlText(TextBoxCognome) = "Cognome"
        ControlText(TextBoxNome) = "Nome"
        ControlText(TextBoxProfessione) = "Professione"
        ControlText(TextBoxSport) = "Sport"
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    ' ====================
    ' Placeholder per TextBoxCognome
    ' ====================
    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBoxCognome.Enter, TextBoxNome.Enter, TextBoxProfessione.Enter, TextBoxSport.Enter
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ""
            ctrl.ForeColor = Theme.TextBoxForeColor
            ctrl.Font = Theme.TxtFont
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBoxCognome.Leave, TextBoxNome.Leave, TextBoxProfessione.Leave, TextBoxSport.Leave
        Dim ctrl As Control = DirectCast(sender, Control)
        If String.IsNullOrWhiteSpace(ctrl.Text) OrElse ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ControlText(ctrl)
            ctrl.ForeColor = Theme.FindColor
            ctrl.Font = Theme.TxtFontItalic
        End If
    End Sub

    Private Sub ResetUC()
        PulisciCampi(TextBoxCognome, TextBoxNome, TextBoxProfessione, TextBoxSport, ComboBoxRelazione, LabelCodiceID)
    End Sub

    Private Async Function SalvaDatiAsync() As Task(Of (Successo As Boolean, NewID As String))
        Dim successo As Boolean = False
        Dim newID As Integer = -1

        Nome = Utils.ToTitleCase(TextBoxNome.Text.Trim())
        Cognome = Utils.ToTitleCase(TextBoxCognome.Text.Trim())
        DataNascita = DateTimePickerDataNascita.Value

        Dim professione As Object = TextBoxProfessione.Text.Trim()
        Dim sportPraticati As Object = TextBoxSport.Text.Trim()
        Dim relazione As Object = ComboBoxRelazione.Text.Trim()
        Dim codiceID As String = ""

        Try
            ' Validazione semplice
            If String.IsNullOrEmpty(Nome) OrElse TextBoxNome.Text = ControlText(TextBoxNome) Then
                HilightControls(True, TextBoxNome)
                Return (False, -1)
            Else
                HilightControls(False, TextBoxNome)
            End If

            If String.IsNullOrEmpty(Cognome) OrElse TextBoxCognome.Text = ControlText(TextBoxCognome) Then
                HilightControls(True, TextBoxCognome)
                Return (False, -1)
            Else
                HilightControls(False, TextBoxCognome)
            End If

            ' Validazione nom ee cognome per generare codice identificativo
            If Nome.Length >= 2 AndAlso Cognome.Length >= 2 Then
                Dim parteCognome As String = Cognome.Substring(0, 2).ToUpper()
                Dim parteNome As String = Nome.Substring(0, 2).ToUpper()
                Dim parteData As String = DataNascita.ToString("ddMMyyyy")
                codiceID = parteCognome & parteNome & parteData
                HilightControls(False, TextBoxNome)
                HilightControls(False, TextBoxCognome)
            Else
                HilightControls(True, TextBoxNome)
                HilightControls(True, TextBoxCognome)
                DirectCast(Me.ParentForm, MainForm).MostraToast("Nome e cognome devono avere almeno 2 caratteri.")
                Return (False, -1)
            End If

            If DateTimePickerDataNascita.Value Is Nothing Or DateTimePickerDataNascita.Value >= Date.Today Then
                DirectCast(Me.ParentForm, MainForm).MostraToast("Data di nascita errata.")
                Return (False, -1)
            End If

            If String.IsNullOrEmpty(relazione) Or Not Utils.IsValidSelection(ComboBoxRelazione) Then
                HilightControls(True, ComboBoxRelazione)
                Return (False, -1)
            Else
                HilightControls(False, ComboBoxRelazione)
            End If

            If String.IsNullOrEmpty(professione) Or professione = ControlText(TextBoxProfessione) Then
                professione = DBNull.Value
            End If

            If String.IsNullOrEmpty(sportPraticati) Or sportPraticati = ControlText(TextBoxSport) Then
                sportPraticati = DBNull.Value
            End If

            If relazione = " NA" Then
                relazione = DBNull.Value
            End If

            ' Mostra CodiceID nella Label
            LabelCodiceID.Text = codiceID

            'Verifica se il CodiceIdentificativo esiste già
            Dim checkQuery As String = "SELECT COUNT(*) FROM Anagrafica WHERE CodiceIdentificativo = @CodiceID"

            Dim checkParam As New List(Of SqlParameter) From {
                New SqlParameter("@CodiceID", codiceID)
            }
            Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

            If dtCheck.Rows(0)(0) > 0 Then
                DirectCast(Me.ParentForm, MainForm).MostraToast("Attenzione: il Codice Identificativo esiste già!")
                Return (False, -1)
            End If

            'Se non esiste, esegui l'inserimento
            Dim queryAnagrafica As String = "INSERT INTO Anagrafica (Nome, Cognome, DataNascita, CodiceIdentificativo) VALUES (@Nome, @Cognome, @DataNascita, @CodiceID)"
            Dim parametriAnagrafica As New List(Of SqlParameter) From {
                New SqlParameter("@Nome", Nome),
                New SqlParameter("@Cognome", Cognome),
                New SqlParameter("@DataNascita", DataNascita),
                New SqlParameter("@CodiceID", codiceID)
            }

            If Await ConnessioneDB.EseguiNonQueryAsync(queryAnagrafica, parametriAnagrafica) > 0 Then
                CodiceIdentificativoSelezionato = codiceID
                Dim queryIDAnagrafica As String = "SELECT ID FROM Anagrafica WHERE CodiceIdentificativo = @CodiceID"
                Dim parametriIDAnagrafica As New List(Of SqlParameter) From {
                    New SqlParameter("@CodiceID", codiceID)
                }

                'Estraggo l'ID anagrafica associato al paziente appena inserito
                Dim dtIDAnagrafica As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryIDAnagrafica, parametriIDAnagrafica)
                If dtIDAnagrafica.Rows.Count > 0 Then
                    newID = Convert.ToInt32(dtIDAnagrafica.Rows(0)("ID"))

                    'Inserisco i dati dell'anamnesi sociale nella tabella AnamnesiSociale
                    Dim queryAnamnesiSociale As String = "INSERT INTO AnamnesiSociale (ID_Anagrafica, Professione, SportPraticati, Relazione) VALUES (@ID_Anagrafica, @Professione, @SportPraticati, @Relazione)"
                    Dim ParametriAnamnesiSociale As New List(Of SqlParameter) From {
                        New SqlParameter("@ID_Anagrafica", newID),
                        New SqlParameter("@Professione", professione),
                        New SqlParameter("@SportPraticati", sportPraticati),
                        New SqlParameter("@Relazione", relazione)
                    }
                    If Await ConnessioneDB.EseguiNonQueryAsync(queryAnamnesiSociale, ParametriAnamnesiSociale) > 0 Then
                        DirectCast(Me.ParentForm, MainForm).MostraToast("Paziente inserito correttamente.")
                        successo = True
                    End If
                End If
            End If
            Return (successo, newID)
        Catch ex As Exception
            MessageBox.Show("Errore imprevisto: " & ex.Message)
            Return (False, -2)
        End Try
    End Function

    Private Async Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        TableLayoutPanelUCAnagrafica.Enabled = False
        main.MostraToast("Salvataggio in corso ...")

        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelUCAnagrafica.Enabled = True
        If esito.Successo Then
            RaiseEvent NuovoPazienteInserito(esito.NewID, CodiceIdentificativoSelezionato, Cognome, Nome, DataNascita)
        End If
    End Sub
End Class
