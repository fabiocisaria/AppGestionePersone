Public Class FormAnagrafica

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

    Private Function SalvaDati() As (Successo As Boolean, NewID As String)
        Dim successo As Boolean = False
        Dim newID As Integer = -1

        Dim nome As String = TextBoxNome.Text.Trim()
        Dim cognome As String = TextBoxCognome.Text.Trim()
        Dim professione As String = TextBoxProfessione.Text.Trim()
        Dim sportPraticati As String = TextBoxSport.Text.Trim()
        Dim relazione As String = ComboBoxRelazione.Text.Trim()
        Dim dataNascita As Date = DateTimePickerDataNascita.Value
        Dim codiceID As String = ""

        Try
            ' Validazione semplice
            If String.IsNullOrEmpty(nome) OrElse String.IsNullOrEmpty(cognome) Then
                HighlightControls(True, TextBoxNome)
                HighlightControls(True, TextBoxCognome)
                Return (False, -1)
            Else
                HighlightControls(False, TextBoxNome)
                HighlightControls(False, TextBoxCognome)
            End If

            ' Validazione nom ee cognome per generare codice identificativo
            If nome.Length >= 2 AndAlso cognome.Length >= 2 Then
                Dim parteCognome As String = cognome.Substring(0, 2).ToUpper()
                Dim parteNome As String = nome.Substring(0, 2).ToUpper()
                Dim parteData As String = dataNascita.ToString("ddMMyyyy")
                codiceID = parteCognome & parteNome & parteData
                HighlightControls(False, TextBoxNome)
                HighlightControls(False, TextBoxCognome)
            Else
                HighlightControls(True, TextBoxNome)
                HighlightControls(True, TextBoxCognome)
                MessageBox.Show("Nome e cognome devono avere almeno 2 caratteri.")
                Return (False, -1)
            End If

            If DateTimePickerDataNascita.Value.Date >= Date.Today Then
                MessageBox.Show("Data di nascita errata.")
                Return (False, -1)
            End If

            If String.IsNullOrEmpty(relazione) Then
                HighlightControls(True, ComboBoxRelazione)
                Return (False, -1)
            End If

            ' Mostra CodiceID nella Label
            LabelCodiceID.Text = "Codice ID generato: " & codiceID

            'Verifica se il CodiceIdentificativo esiste già
            Dim checkQuery As String = "SELECT COUNT(*) FROM Anagrafica WHERE CodiceIdentificativo = @CodiceID"

            Dim checkParam As New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@CodiceID", codiceID)
            }
            Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

            If dtCheck.Rows(0)(0) > 0 Then
                MessageBox.Show("Attenzione: il Codice Identificativo esiste già!")
                Return (False, -1)
            End If

            'Se non esiste, esegui l'inserimento
            Dim queryAnagrafica As String = "INSERT INTO Anagrafica (Nome, Cognome, DataNascita, CodiceIdentificativo) VALUES (@Nome, @Cognome, @DataNascita, @CodiceID)"
            Dim parametriAnagrafica As New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@Nome", nome),
                New SqlClient.SqlParameter("@Cognome", cognome),
                New SqlClient.SqlParameter("@DataNascita", dataNascita),
                New SqlClient.SqlParameter("@CodiceID", codiceID)
            }

            If EseguiNonQuery(queryAnagrafica, parametriAnagrafica) > 0 Then
                Dim queryIDAnagrafica As String = "SELECT ID FROM Anagrafica WHERE CodiceIdentificativo = @CodiceID"
                Dim parametriIDAnagrafica As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@CodiceID", codiceID)
                }

                'Estraggo l'ID anagrafica associato al paziente appena inserito
                Dim dtIDAnagrafica As DataTable = EseguiQuery(queryIDAnagrafica, parametriIDAnagrafica)
                If dtIDAnagrafica.Rows.Count > 0 Then
                    newID = Convert.ToInt32(dtIDAnagrafica.Rows(0)("ID"))

                    'Inserisco i dati dell'anamnesi sociale nella tabella AnamnesiSociale
                    Dim queryAnamnesiSociale As String = "INSERT INTO AnamnesiSociale (ID_Anagrafica, Professione, SportPraticati, Relazione) VALUES (@ID_Anagrafica, @Professione, @SportPraticati, @Relazione)"
                    Dim ParametriAnamnesiSociale As New List(Of SqlClient.SqlParameter) From {
                        New SqlClient.SqlParameter("@ID_Anagrafica", newID),
                        New SqlClient.SqlParameter("@Professione", professione),
                        New SqlClient.SqlParameter("@SportPraticati", sportPraticati),
                        New SqlClient.SqlParameter("@Relazione", relazione)
                    }
                    If EseguiNonQuery(queryAnamnesiSociale, ParametriAnamnesiSociale) > 0 Then
                        PulisciCampi(GroupBoxAnagrafica, GroupBoxAnamnesiSociale, LabelCodiceID)
                        MessageBox.Show("Paziente inserito correttamente.")
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
    End Sub

    Private Sub ButtonAnamnesiFisiologica_Click(sender As Object, e As EventArgs) Handles ButtonAnamnesiFisiologica.Click
        Dim esito = SalvaDati()
        If esito.Successo = True Then
            Dim formAnamnesiFisio As New FormAnamnesiFisiologicaSequenza(esito.NewID)
            formAnamnesiFisio.ShowDialog()
        End If
    End Sub

End Class