Public Class UC_CercaPaziente
    Inherits UserControl

    ' ====================
    ' Variabili e proprietà
    ' ====================
    Private _aggiornamentoInterno As Boolean = False

    Public Property IDSelezionato As Integer
    Public Property CodiceIdentificativoSelezionato As String

    ' Evento per comunicare alla MainForm il paziente selezionato
    Public Event PazienteSelezionato(ID As Integer, CodiceIdentificativo As String)

    ' ====================
    ' Costruttore
    ' ====================
    Public Sub New()
        InitializeComponent()
    End Sub

    ' ====================
    ' Eventi TextBox
    ' ====================
    Private Sub TextBoxCognome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCognome.TextChanged
        If TextBoxCognome.Text = "" Then
            _aggiornamentoInterno = False
            TextBoxCodiceID.Text = ""
        End If

        If _aggiornamentoInterno Then Return

        TextBoxCodiceID.Enabled = TextBoxCognome.Text.Trim().Length = 0
    End Sub

    Private Sub TextBoxCodiceID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodiceID.TextChanged
        If TextBoxCodiceID.Text = "" Then
            _aggiornamentoInterno = False
            TextBoxCognome.Text = ""
        End If

        If _aggiornamentoInterno Then Return

        TextBoxCognome.Enabled = TextBoxCodiceID.Text.Trim().Length = 0
    End Sub

    ' ====================
    ' Evidenzia riga relativa al paziente selezionato
    ' ====================
    Private Sub EvidenziaSelezione()
        ' Recupero l'ID salvato nella MainForm
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idSelezionato As Integer = main.IDPazienteSelezionato

        For Each row As DataGridViewRow In dgvSelezionePaziente.Rows
            If Convert.ToInt32(row.Cells("ID").Value) = idSelezionato Then
                row.DefaultCellStyle.BackColor = Color.LightGreen ' evidenziata
                row.DefaultCellStyle.SelectionBackColor = Color.LightYellow
                row.DefaultCellStyle.SelectionForeColor = Color.DarkGray
            Else
                row.DefaultCellStyle.BackColor = Color.White ' normale
                row.DefaultCellStyle.SelectionBackColor = Color.LightBlue
                row.DefaultCellStyle.SelectionForeColor = Color.DarkGray
            End If
        Next
    End Sub

    ' ====================
    ' Eventi pulsanti
    ' ====================
    Private Sub ButtonCercaPaziente_Click(sender As Object, e As EventArgs) Handles ButtonCercaPaziente.Click
        Dim pazientiTrovati = Utils.CercaPazienteUC(TextBoxCodiceID.Text, TextBoxCognome.Text)

        If pazientiTrovati.Rows.Count > 0 Then
            dgvSelezionePaziente.DataSource = pazientiTrovati
            DirectCast(Me.ParentForm, MainForm).MostraToast("Trovati " & pazientiTrovati.Rows.Count & " pazienti.")
        Else
            dgvSelezionePaziente.DataSource = Nothing
            DirectCast(Me.ParentForm, MainForm).MostraToast("Nessun paziente trovato.")
        End If
    End Sub

    Private Sub ButtonSeleziona_Click(sender As Object, e As EventArgs) Handles ButtonSeleziona.Click
        SelezionaPaziente()
    End Sub

    Private Sub ButtonAnnulla_Click(sender As Object, e As EventArgs) Handles ButtonAnnulla.Click
        IDSelezionato = 0
        CodiceIdentificativoSelezionato = ""
        dgvSelezionePaziente.DataSource = Nothing
        TextBoxCognome.Text = ""
        TextBoxCodiceID.Text = ""
    End Sub

    ' ====================
    ' Eventi DataGridView
    ' ====================
    Private Sub dgvSelezionePaziente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelezionePaziente.CellDoubleClick
        SelezionaPaziente()
    End Sub

    ' ====================
    ' Metodi logica
    ' ====================
    Private Sub SelezionaPaziente()
        If dgvSelezionePaziente.CurrentRow IsNot Nothing Then
            IDSelezionato = Convert.ToInt32(dgvSelezionePaziente.CurrentRow.Cells("ID").Value)
            CodiceIdentificativoSelezionato = dgvSelezionePaziente.CurrentRow.Cells("CodiceIdentificativo").Value.ToString()

            ' Solleva l'evento verso la MainForm
            RaiseEvent PazienteSelezionato(IDSelezionato, CodiceIdentificativoSelezionato)

            ' Evidenzio la riga selezionata
            EvidenziaSelezione()
        End If
    End Sub
End Class