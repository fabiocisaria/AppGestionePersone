Public Class FormInserisciVisita

    Private _aggiornamentoInterno As Boolean = False

    Private Sub FormInserisciVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerDataVisita.Format = DateTimePickerFormat.Short
        DateTimePickerDataVisita.Value = DateTime.Now.Date
        SetControlsEnabled(False, ComboBoxTipoVisita, DateTimePickerDataVisita, TextBoxMotivo)
    End Sub

    Private Sub txtCognome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCognome.TextChanged
        If TextBoxCognome.Text = "" Then
            _aggiornamentoInterno = False
            TextBoxCodiceID.Text = ""
        End If

        If _aggiornamentoInterno Then Return

        If TextBoxCognome.Text.Trim().Length > 0 Then
            SetControlsEnabled(False, TextBoxCodiceID)
        Else
            SetControlsEnabled(True, TextBoxCodiceID)
        End If
    End Sub

    ' Quando scrivo nel CodiceID, disabilito la ricerca per Cognome
    Private Sub txtCodiceID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodiceID.TextChanged
        If TextBoxCodiceID.Text = "" Then
            _aggiornamentoInterno = False
            TextBoxCognome.Text = ""
        End If

        If _aggiornamentoInterno Then Return

        If TextBoxCodiceID.Text.Trim().Length > 0 Then
            SetControlsEnabled(False, TextBoxCognome)
        Else
            SetControlsEnabled(True, TextBoxCognome)
        End If
    End Sub

    Private Sub ButtonCercaPaziente_Click(sender As Object, e As EventArgs) Handles ButtonCercaPaziente.Click
        Dim pazientiTrovati = Utils.CercaPaziente(TextBoxCodiceID.Text, TextBoxCognome.Text)

        If pazientiTrovati.ID > 0 Then
            _aggiornamentoInterno = True

            LabelIDAnagrafica.Text = pazientiTrovati.ID.ToString()
            TextBoxCodiceID.Text = pazientiTrovati.Codice

            MessageBox.Show("Hai selezionato il paziente: " & pazientiTrovati.Codice)
            SetControlsEnabled(True, ComboBoxTipoVisita, DateTimePickerDataVisita, TextBoxMotivo)
        Else
            MessageBox.Show("Nessun paziente trovato.")
            SetControlsEnabled(False, ComboBoxTipoVisita, DateTimePickerDataVisita, TextBoxMotivo)
        End If
    End Sub

    Private Function InserisciVisita() As (Successo As Boolean, NewID As Integer)
        Dim successo As Boolean = False
        Dim idVisita As Integer = -1

        Dim tipoVisita As String = ""

        Dim idPaziente As String = ""

        Try
            If String.IsNullOrEmpty(LabelIDAnagrafica.Text) Then
                'MessageBox.Show("Seleziona prima un paziente.")
                HilightControls(True, TextBoxCognome)
                HilightControls(True, TextBoxCodiceID)
                Return (False, -1)
            Else
                idPaziente = LabelIDAnagrafica.Text
                HilightControls(False, TextBoxCognome)
                HilightControls(False, TextBoxCodiceID)
            End If

            If ComboBoxTipoVisita.SelectedItem Is Nothing Then
                HilightControls(True, ComboBoxTipoVisita)
                'MessageBox.Show("Seleziona un tipo di visita.")
                Return (False, -1)
            Else
                tipoVisita = ComboBoxTipoVisita.SelectedItem.ToString()
                HilightControls(False, ComboBoxTipoVisita)
            End If

            If tipoVisita = "Prima visita" Then
                Dim queryPrimaVisita As String = "SELECT COUNT(*) FROM Visite WHERE ID_Anagrafica=@ID AND TipoVisita='Prima visita'"
                Dim paramPrimaVisita As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@ID", idPaziente)
                }

                If EseguiScalar(queryPrimaVisita, paramPrimaVisita) > 0 Then
                    MessageBox.Show("Esiste già una prima visita per questo paziente!")
                    Return (False, -1)
                End If
            ElseIf tipoVisita = "Controllo" Then
                Dim queryPrimaVisita As String = "SELECT ID, DataVisita FROM Visite WHERE ID_Anagrafica=@ID AND TipoVisita='Prima visita'"
                Dim paramControllo As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@ID", idPaziente)
                }
                Dim dt As DataTable = EseguiQuery(queryPrimaVisita, paramControllo)

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("Impossibile inserire un controllo: non esiste ancora una prima visita per questo paziente.")
                    Return (False, -1)
                Else
                    ' Verifica che la data del controllo sia successiva alla prima visita
                    Dim dataPrimaVisita As DateTime = Convert.ToDateTime(dt.Rows(0)("DataVisita"))
                    If DateTimePickerDataVisita.Value.Date <= dataPrimaVisita Then
                        MessageBox.Show("La data del controllo deve essere successiva alla prima visita!")
                        Return (False, -1)
                    End If

                    ' Verifica che non ci sia già una visita per quel paziente nella stessa data
                    Dim visitaPresente As Integer = 0
                    Dim queryVisitaPresente As String = "SELECT COUNT(*) FROM Visite WHERE ID_Anagrafica = @ID_Anagrafica AND CAST(DataVisita AS DATE) = @DataVisita"
                    Dim parameterVisitaPresente As New List(Of SqlClient.SqlParameter) From {
                        New SqlClient.SqlParameter("@ID_Anagrafica", idPaziente),
                        New SqlClient.SqlParameter("@DataVisita", DateTimePickerDataVisita.Value.Date)
                    }

                    Dim dtVisitaPresente As DataTable = EseguiQuery(queryVisitaPresente, parameterVisitaPresente)
                    If dtVisitaPresente.Rows(0)(0) > 0 Then
                        MessageBox.Show("Esiste già una visita per questo paziente nella stessa data!")
                        Return (False, -1)
                    End If
                End If
            End If

            ' Inserimento
            Dim query As String = "INSERT INTO Visite (ID_Anagrafica, DataVisita, TipoVisita, MotivoVisita) VALUES (@idAna, @data, @tipoVisita, @motivo)"
            Dim parametri As New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@idAna", LabelIDAnagrafica.Text),
                New SqlClient.SqlParameter("@data", DateTimePickerDataVisita.Value.Date),
                New SqlClient.SqlParameter("@tipoVisita", ComboBoxTipoVisita.SelectedItem.ToString()),
                New SqlClient.SqlParameter("@motivo", TextBoxMotivo.Text.Trim())
            }

            If EseguiNonQuery(query, parametri) > 0 Then
                MessageBox.Show("Visita salvata con successo.")
                successo = True
            Else
                Return (False, -1)
            End If

            ' Devo estrarre il codice univoco della visita appena inserita
            Dim queryIDVisita As String = "SELECT ID FROM Visite WHERE ID_Anagrafica = @IDAnagrafica AND DataVisita = @DataVisita"
            Dim parametriIDVisita As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@IDAnagrafica", LabelIDAnagrafica.Text),
                    New SqlClient.SqlParameter("@DataVisita", DateTimePickerDataVisita.Value.Date)
            }

            ' Estraggo l'ID visita associato alla visita appena inserita
            Dim dtVisita As DataTable = EseguiQuery(queryIDVisita, parametriIDVisita)
            If dtVisita.Rows.Count > 0 Then
                idVisita = Convert.ToInt32(dtVisita.Rows(0)("ID"))
            End If

            PulisciCampi(GroupBoxTipoVisita)

            Return (successo, idVisita)
        Catch ex As Exception
            MessageBox.Show("Errore imprevisto: " & ex.Message)
            Return (False, -2)
        End Try
    End Function

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito = InserisciVisita()
    End Sub

    Private Sub ButtonVisitaGineco_Click(sender As Object, e As EventArgs) Handles ButtonSintomi.Click
        Dim esito = InserisciVisita()
        If esito.Successo Then
            Dim formVisitaSintomi As New FormVisitaSintomi(esito.NewID)
            formVisitaSintomi.Show()
            Me.Hide()
        End If
    End Sub
End Class