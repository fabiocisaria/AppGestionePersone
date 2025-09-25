Friend NotInheritable Class Rounder

    Private Shared ReadOnly ControlRadius As New Dictionary(Of Control, Integer)

    ' Arrotonda qualsiasi controllo e gestisce il Resize
    Public Shared Sub ApplyRounded(ctrl As Control, Optional radius As Integer = 5)
        ControlRadius(ctrl) = radius

        ' Disegna subito il rounding
        DrawRounded(ctrl, radius)

        ' Rimuove handler precedente per evitare duplicati
        RemoveHandler ctrl.Resize, AddressOf ResizeHandler
        ' Aggiunge handler per aggiornare il rounding ad ogni resize
        AddHandler ctrl.Resize, AddressOf ResizeHandler
    End Sub

    Private Shared Sub ResizeHandler(sender As Object, e As EventArgs)
        Dim ctrl As Control = DirectCast(sender, Control)
        Dim radius As Integer = If(ControlRadius.ContainsKey(ctrl), ControlRadius(ctrl), 5)
        DrawRounded(ctrl, radius)
    End Sub

    Private Shared Sub DrawRounded(ctrl As Control, radius As Integer)
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(ctrl.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(ctrl.Width - radius * 2, ctrl.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddArc(0, ctrl.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        path.CloseAllFigures()
        ctrl.Region = New Region(path)
    End Sub
End Class