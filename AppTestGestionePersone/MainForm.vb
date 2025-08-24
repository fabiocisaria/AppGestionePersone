Public Class MainForm
    Inherits Form

    ' ====================
    ' Variabili e UC
    ' ====================
    Private _ucCercaPaziente As UC_CercaPaziente
    Private _ucAnagrafica As UC_Anagrafica
    Private _ucAnamnesiFisiologica As UC_AnamnesiFisiologica
    Private _ucAnamnesiFamiliare As UC_AnamnesiFamiliare

    ' Stato paziente selezionato
    Public Property IDPazienteSelezionato As Integer
    Public Property CodicePazienteSelezionato As String

    ' ====================
    ' Handler evento paziente selezionato
    ' ====================
    Private Sub PazienteSelezionatoHandler(ID As Integer, CodiceIdentificativo As String)
        Me.IDPazienteSelezionato = ID
        Me.CodicePazienteSelezionato = CodiceIdentificativo

        ' Aggiorna eventuale label globale (opzionale)
        ' LabelPazienteSelezionato.Text = "Paziente: " & CodiceIdentificativo

        ' Mostra toast
        MostraToast("Paziente selezionato: " & CodiceIdentificativo)
    End Sub

    ' ====================
    ' Caricamento UC in TableLayoutPanelMain
    ' ====================
    Private Sub CaricaControllo(ctrl As UserControl)
        TableLayoutPanelMain.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        TableLayoutPanelMain.Controls.Add(ctrl, 0, 0)
    End Sub

    ' ====================
    ' Toast animato
    ' ====================
    Private _toastAttivo As Boolean = False

    Public Sub MostraToast(messaggio As String)
        If _toastAttivo Then Return ' evita sovrapposizione
        _toastAttivo = True

        Dim toast As New Form()
        toast.FormBorderStyle = FormBorderStyle.None
        toast.StartPosition = FormStartPosition.Manual
        toast.BackColor = Color.FromArgb(50, 50, 50)
        toast.ForeColor = Color.White
        toast.Size = New Size(300, 60)
        toast.TopMost = True
        toast.ShowInTaskbar = False
        toast.Location = New Point(Me.Left + Me.Width - toast.Width - 10, Me.Top + Me.Height - toast.Height - 10)

        Dim lbl As New Label() With {
            .Text = messaggio,
            .ForeColor = Color.White,
            .BackColor = Color.Transparent,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }
        toast.Controls.Add(lbl)
        toast.Opacity = 0
        toast.Show()

        ' Fade-in
        Dim fadeIn As New Timer() With {.Interval = 30}
        AddHandler fadeIn.Tick, Sub()
                                    If toast.Opacity < 1 Then
                                        toast.Opacity += 0.1
                                    Else
                                        fadeIn.Stop()
                                    End If
                                End Sub
        fadeIn.Start()

        ' Timer chiusura con fade-out
        Dim closeTimer As New Timer() With {.Interval = 3000}
        AddHandler closeTimer.Tick, Sub()
                                        closeTimer.Stop()
                                        Dim fadeOut As New Timer() With {.Interval = 30}
                                        AddHandler fadeOut.Tick, Sub()
                                                                     If toast.Opacity > 0 Then
                                                                         toast.Opacity -= 0.1
                                                                     Else
                                                                         toast.Close()
                                                                         fadeOut.Stop()
                                                                         _toastAttivo = False
                                                                     End If
                                                                 End Sub
                                        fadeOut.Start()
                                    End Sub
        closeTimer.Start()
    End Sub

    ' ====================
    ' Menu Nuovo Paziente
    ' ====================
    Private Sub NuovoPazienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuovoPazienteToolStripMenuItem.Click
        If _ucAnagrafica Is Nothing Then
            _ucAnagrafica = New UC_Anagrafica()
        End If
        CaricaControllo(_ucAnagrafica)
    End Sub

    ' ====================
    ' Menu Cerca Paziente
    ' ====================
    Private Sub PazienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PazienteToolStripMenuItem.Click
        If _ucCercaPaziente Is Nothing Then
            _ucCercaPaziente = New UC_CercaPaziente()
            AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
        End If
        CaricaControllo(_ucCercaPaziente)
    End Sub

    Private Sub FisiologicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FisiologicaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If
            CaricaControllo(_ucCercaPaziente)
            Return
        End If
        _ucAnamnesiFisiologica = New UC_AnamnesiFisiologica()
        CaricaControllo(_ucAnamnesiFisiologica)
    End Sub

    Private Sub FamiliareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliareToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If
            CaricaControllo(_ucCercaPaziente)
            Return
        End If
        _ucAnamnesiFamiliare = New UC_AnamnesiFamiliare()
        CaricaControllo(_ucAnamnesiFamiliare)
    End Sub
End Class