Friend NotInheritable Class GradientBackgroundThemer

    Private Shared ReadOnly StartColors As New Dictionary(Of Control, Color)
    Private Shared ReadOnly EndColors As New Dictionary(Of Control, Color)
    Private Shared ReadOnly HasHandler As New Dictionary(Of Control, Boolean)
    Private Shared ReadOnly Angles As New Dictionary(Of Control, Single)

    ''' <summary>
    ''' Applica gradiente a un controllo
    ''' </summary>
    Public Shared Sub ApplyGradient(ctrl As Control, colorStart As Color, colorEnd As Color, Optional angle As Single = 90.0F)
        StartColors(ctrl) = colorStart
        EndColors(ctrl) = colorEnd
        Angles(ctrl) = angle

        ' Evita duplicati
        If HasHandler.ContainsKey(ctrl) Then Return

        AddHandler ctrl.Paint, AddressOf GradientPaintHandler
        HasHandler(ctrl) = True

        ' Ridisegna subito
        ctrl.Invalidate()
    End Sub

    ''' <summary>
    ''' Ridisegna il gradiente (utile se colori cambiano)
    ''' </summary>
    Public Shared Sub UpdateGradient(ctrl As Control)
        ctrl.Invalidate()
    End Sub

    ''' <summary>
    ''' Handler Paint per il gradiente
    ''' </summary>
    Private Shared Sub GradientPaintHandler(sender As Object, e As PaintEventArgs)
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl Is Nothing Then Exit Sub

        Dim startColor As Color = If(StartColors.ContainsKey(ctrl), StartColors(ctrl), ctrl.BackColor)
        Dim endColor As Color = If(EndColors.ContainsKey(ctrl), EndColors(ctrl), ctrl.BackColor)
        Dim angle As Single = If(Angles.ContainsKey(ctrl), Angles(ctrl), 90.0F)

        Using brush As New Drawing2D.LinearGradientBrush(ctrl.ClientRectangle, startColor, endColor, angle)
            e.Graphics.FillRectangle(brush, ctrl.ClientRectangle)
        End Using
    End Sub
End Class