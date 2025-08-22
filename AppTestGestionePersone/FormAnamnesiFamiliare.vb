Public Class FormAnamnesiFamiliare

    Private _aggiornamentoInterno As Boolean = False

    Private Sub FormAnamnesiFamiliare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaParentela()
        SetControlsEnabled(False, ComboBoxParentela, TextPatologie, ButtonSalva)
    End Sub

    ' 🔹 Carica lista parentela dal DB
    Private Sub CaricaParentela()
        Dim query As String = "SELECT ID, Parentela FROM TipoParente ORDER BY Parentela"
        Dim dt As DataTable = EseguiQuery(query)
        ComboBoxParentela.DataSource = dt
        ComboBoxParentela.DisplayMember = "Parentela"
        ComboBoxParentela.ValueMember = "ID"
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

    ' 🔹 Cerca paziente
    Private Sub btnCercaPaziente_Click(sender As Object, e As EventArgs) Handles ButtonCercaPaziente.Click
        Dim pazientiTrovati = Utils.CercaPaziente(TextBoxCodiceID.Text, TextBoxCognome.Text)

        If pazientiTrovati.ID > 0 Then
            _aggiornamentoInterno = True

            LabelIDAnagrafica.Text = pazientiTrovati.ID.ToString()
            TextBoxCodiceID.Text = pazientiTrovati.Codice

            MessageBox.Show("Hai selezionato il paziente: " & pazientiTrovati.Codice)
            SetControlsEnabled(True, ComboBoxParentela, TextPatologie, ButtonSalva)
        Else
            MessageBox.Show("Nessun paziente trovato.")
            SetControlsEnabled(False, ComboBoxParentela, TextPatologie, ButtonSalva)
        End If
    End Sub

    ' 🔹 Salva anamnesi
    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles ButtonSalva.Click
        Dim patologie As Object

        If LabelIDAnagrafica.Text = "" Then
            MessageBox.Show("Seleziona prima un paziente.")
            Exit Sub
        End If

        Dim valoriConsentiti As New List(Of String) From {"Madre", "Padre", "Nonna materna", "Nonna paterna", "Nonno materno", "Nonno paterno"}

        ' Controllo duplicato se il parente selezionato deve essere univoco (Padre, madre, etc)
        If valoriConsentiti.Contains(ComboBoxParentela.Text) Then
            Dim checkQuery As String = "SELECT COUNT(*) FROM AnamnesiFamiliare WHERE ID_Anagrafica = @idAna AND ID_Parente = @idParente"
            Dim checkParam As New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@idAna", LabelIDAnagrafica.Text),
                New SqlClient.SqlParameter("@idParente", ComboBoxParentela.SelectedValue)
            }
            Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

            If dtCheck.Rows(0)(0) > 0 Then
                MessageBox.Show("Questo parente è già stato inserito per il paziente selezionato.")
                Exit Sub
            End If
        End If

        If String.IsNullOrWhiteSpace(TextPatologie.Text) Then
            patologie = DBNull.Value
            Exit Sub
        Else
            patologie = TextPatologie.Text
        End If

        ' Inserimento
        Dim query As String = "INSERT INTO AnamnesiFamiliare (ID_Anagrafica, ID_Parente, Patologie) VALUES (@idAna, @idParente, @patologie)"
        Dim parametri As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idAna", LabelIDAnagrafica.Text),
            New SqlClient.SqlParameter("@idParente", ComboBoxParentela.SelectedValue),
            New SqlClient.SqlParameter("@patologie", patologie)
        }

        If EseguiNonQuery(query, parametri) > 0 Then
            MessageBox.Show("Visita inserita con successo.")
            PulisciCampi(GroupBoxAnamnesi)
        End If
    End Sub

End Class