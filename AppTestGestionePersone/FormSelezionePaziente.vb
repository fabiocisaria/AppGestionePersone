Public Class FormSelezionePaziente

    Private _dt As DataTable
    Public Property IDSelezionato As Integer
    Public Property CodiceIdentificativoSelezionato As String

    ' Costruttore che riceve i dati
    Public Sub New(dt As DataTable)
        InitializeComponent()
        _dt = dt
    End Sub

    ' Quando la form si carica → carico i dati nel DataGridView
    Private Sub FormSelezionePaziente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSelezionePaziente.DataSource = _dt
        dgvSelezionePaziente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Rende la griglia di sola lettura
        dgvSelezionePaziente.ReadOnly = True
        ' Impedisce all'utente di aggiungere o cancellare righe
        dgvSelezionePaziente.AllowUserToAddRows = False
        dgvSelezionePaziente.AllowUserToDeleteRows = False
        ' Facoltativo: impedisce di ridimensionare righe/colonne
        dgvSelezionePaziente.AllowUserToResizeRows = False
        dgvSelezionePaziente.AllowUserToResizeColumns = True
    End Sub

    ' Doppio click su una riga → seleziona il paziente
    Private Sub dgvSelezionePaziente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelezionePaziente.CellDoubleClick
        SelezionaPaziente()
    End Sub

    ' Bottone seleziona → prendo l’ID
    Private Sub ButtonSeleziona_Click(sender As Object, e As EventArgs) Handles ButtonSeleziona.Click
        SelezionaPaziente()
    End Sub

    Private Sub SelezionaPaziente()
        If dgvSelezionePaziente.CurrentRow IsNot Nothing Then
            IDSelezionato = Convert.ToInt32(dgvSelezionePaziente.CurrentRow.Cells("ID").Value)
            CodiceIdentificativoSelezionato = dgvSelezionePaziente.CurrentRow.Cells("CodiceIdentificativo").Value
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    ' Bottone annulla
    Private Sub ButtonAnnulla_Click(sender As Object, e As EventArgs) Handles ButtonAnnulla.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class