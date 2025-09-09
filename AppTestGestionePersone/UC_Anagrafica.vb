Imports Microsoft.Data.SqlClient
Public Class UC_Anagrafica
    Public Property IDPaziente As Integer
    Public Property CodiceIdentificativoSelezionato As String
    Public Property Cognome As String
    Public Property Nome As String
    Public Property DataNascita As Date

    Public Property IsHandlerAttached As Boolean = False

    ' Evento per comunicare alla MainForm il paziente selezionato
    Public Event NuovoPazienteInserito(ID As Integer, CodiceIdentificativo As String, Cognome As String, Nome As String, DataNascita As Date)
    Private Sub FormAnagrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerDataNascita.Format = DateTimePickerFormat.Short
        DateTimePickerDataNascita.Value = DateTime.Now.Date
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ResetUC()
        PulisciCampi(TextBoxCognome, TextBoxNome, TextBoxProfessione, TextBoxSport, ComboBoxRelazione, LabelCodiceID)
    End Sub

    Private Function SalvaDati() As (Successo As Boolean, NewID As String)
        Dim successo As Boolean = False
        Dim newID As Integer = -1

        Nome = TextBoxNome.Text.Trim()
        Cognome = TextBoxCognome.Text.Trim()
        DataNascita = DateTimePickerDataNascita.Value

        Dim professione As String = TextBoxProfessione.Text.Trim()
        Dim sportPraticati As String = TextBoxSport.Text.Trim()
        Dim relazione As String = ComboBoxRelazione.Text.Trim()
        Dim codiceID As String = ""

        Try
            ' Validazione semplice
            If String.IsNullOrEmpty(Nome) OrElse String.IsNullOrEmpty(Cognome) Then
                HilightControls(True, TextBoxNome)
                HilightControls(True, TextBoxCognome)
                Return (False, -1)
            Else
                HilightControls(False, TextBoxNome)
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

            If DateTimePickerDataNascita.Value.Date >= Date.Today Then
                DirectCast(Me.ParentForm, MainForm).MostraToast("Data di nascita errata.")
                Return (False, -1)
            End If

            If String.IsNullOrEmpty(relazione) Then
                HilightControls(True, ComboBoxRelazione)
                Return (False, -1)
            End If

            ' Mostra CodiceID nella Label
            LabelCodiceID.Text = codiceID

            'Verifica se il CodiceIdentificativo esiste già
            Dim checkQuery As String = "SELECT COUNT(*) FROM Anagrafica WHERE CodiceIdentificativo = @CodiceID"

            Dim checkParam As New List(Of SqlParameter) From {
                New SqlParameter("@CodiceID", codiceID)
            }
            Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

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

            If EseguiNonQuery(queryAnagrafica, parametriAnagrafica) > 0 Then
                CodiceIdentificativoSelezionato = codiceID
                Dim queryIDAnagrafica As String = "SELECT ID FROM Anagrafica WHERE CodiceIdentificativo = @CodiceID"
                Dim parametriIDAnagrafica As New List(Of SqlParameter) From {
                    New SqlParameter("@CodiceID", codiceID)
                }

                'Estraggo l'ID anagrafica associato al paziente appena inserito
                Dim dtIDAnagrafica As DataTable = EseguiQuery(queryIDAnagrafica, parametriIDAnagrafica)
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
                    If EseguiNonQuery(queryAnamnesiSociale, ParametriAnamnesiSociale) > 0 Then
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

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito = SalvaDati()
        If esito.Successo Then
            RaiseEvent NuovoPazienteInserito(esito.NewID, CodiceIdentificativoSelezionato, Cognome, Nome, DataNascita)
        End If
    End Sub
End Class
