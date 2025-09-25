Friend NotInheritable Class BorderThemer

    Private Shared ReadOnly PaintedControls As New Dictionary(Of Control, Boolean)
    Private Shared ReadOnly ChangedControls As New Dictionary(Of Control, Boolean)
    Private Shared ReadOnly ControlRadius As New Dictionary(Of Control, Integer)
    Private Shared ReadOnly ControlBorderColor As New Dictionary(Of Control, Color)
    Private Shared ReadOnly ControlTopOffset As New Dictionary(Of Control, Integer)
    Private Shared ReadOnly ControlBorderWidth As New Dictionary(Of Control, Single)

    ''' <summary>
    ''' Applica bordo colorato a un controllo (Form, Panel, TableLayoutPanel)
    ''' </summary>
    Public Shared Sub ApplyBorder(ctrl As Control, Optional radius As Integer = 5, Optional topOffset As Integer = 0, Optional borderColor As Color = Nothing, Optional borderWidth As Single = 1.5F)
        ' Salva il raggio
        ControlRadius(ctrl) = radius
        ControlTopOffset(ctrl) = topOffset
        ControlBorderWidth(ctrl) = borderWidth
        If borderColor <> Nothing Then ControlBorderColor(ctrl) = borderColor

        ' Evita duplicati
        If PaintedControls.ContainsKey(ctrl) Then Return

        ' Aggiunge handler per Paint
        AddHandler ctrl.Paint, AddressOf ControlPaintHandler
        AddHandler ctrl.EnabledChanged, Sub() ctrl.Invalidate()
        PaintedControls(ctrl) = True
        ChangedControls(ctrl) = True

        ctrl.Invalidate()
    End Sub

    ''' <summary>
    ''' Aggiorna il bordo (utile se cambiano colori in base a Enabled)
    ''' </summary>
    Public Shared Sub UpdateBorder(ctrl As Control)
        ctrl.Invalidate()
    End Sub

    ''' <summary>
    ''' Disegna il bordo arrotondato
    ''' </summary>
    Private Shared Sub ControlPaintHandler(sender As Object, e As PaintEventArgs)
        Dim ctrl As Control = DirectCast(sender, Control)

        If ctrl Is Nothing Then Exit Sub

        ' Spessore dinamico
        Dim penWidth As Single = If(ControlBorderWidth.ContainsKey(ctrl), ControlBorderWidth(ctrl), 1.5F)

        ' Colore dinamico
        Dim topOffset As Integer = If(ControlTopOffset.ContainsKey(ctrl), ControlTopOffset(ctrl), 0)
        Dim borderColor As Color = If(ControlBorderColor.ContainsKey(ctrl), ControlBorderColor(ctrl), If(ctrl.Enabled, Theme.SecondaryPanelActiveBorder, Theme.SecondaryPanelInactiveBorder))

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim radius As Integer = If(ControlRadius.ContainsKey(ctrl), ControlRadius(ctrl), 5)

        Dim rect As New Rectangle(0, 0, ctrl.Width - 1, ctrl.Height - 1)

        Using path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            path.AddArc(rect.Left, rect.Top + topOffset, radius * 2, radius * 2, 180, 90)
            path.AddArc(rect.Right - radius * 2, rect.Top + topOffset, radius * 2, radius * 2, 270, 90)
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
            path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
            path.CloseFigure()

            Using pen As New Pen(borderColor, penWidth)
                g.DrawPath(pen, path)
            End Using
        End Using
    End Sub
End Class