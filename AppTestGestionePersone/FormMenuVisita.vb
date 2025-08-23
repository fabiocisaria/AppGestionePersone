Public Class FormMenuVisita

    Private Sub ButtonAnnulla_Click(sender As Object, e As EventArgs) Handles ButtonAnnulla.Click
        Me.Close()
    End Sub

    Private Sub ButtonNuovaVisita_Click(sender As Object, e As EventArgs) Handles ButtonNuovaVisita.Click
        Dim f As New FormInserisciVisita()
        f.ShowDialog() ' Modal: blocca il menu finché la form non è chiusa
    End Sub
End Class