Public Class FormMenuPrincipale
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Gestione Persone - Menu principale"
    End Sub

    Private Sub ButtonNuovoPaziente_Click(sender As Object, e As EventArgs) Handles ButtonNuovoPaziente.Click
        Dim f As New FormAnagrafica()
        f.ShowDialog(Me) ' Modal: blocca il menu finché la form non è chiusa
    End Sub

    Private Sub ButtonAnamnesiFamiliare_Click(sender As Object, e As EventArgs) Handles ButtonAnamnesiFamiliare.Click
        Dim f As New FormAnamnesiFamiliare()
        f.ShowDialog(Me) ' Modal: blocca il menu finché la form non è chiusa
    End Sub

    Private Sub ButtonAnamnesiFisiologica_Click(sender As Object, e As EventArgs) Handles ButtonAnamnesiFisiologica.Click
        Dim f As New FormAnamnesiFisiologicaRicPaziente()
        f.ShowDialog(Me) ' Modal: blocca il menu finché la form non è chiusa
    End Sub

    Private Sub ButtonVisita_Click(sender As Object, e As EventArgs) Handles ButtonVisita.Click
        Dim f As New FormMenuVisita()
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub
End Class