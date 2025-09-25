Public Class CloseButton
    Inherits Panel

    Public Event CloseClicked As EventHandler

    Private isHovered As Boolean = False

    Public Sub New()
        Me.Size = New Size(45, 30) ' Dimensioni tipiche pulsante X
        Me.BackColor = Theme.StripMenuPrimaryColor
        Me.DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        isHovered = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        isHovered = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Me.BackColor = Theme.StripMenuHoveredColor
        'Color.FromArgb(200, 232, 17, 35) ' Rosso scuro cliccato
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        Me.BackColor = Color.Transparent
        Me.Invalidate()
        RaiseEvent CloseClicked(Me, EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' Colore sfondo hover
        If isHovered Then
            Using brush As New SolidBrush(Theme.StripMenuHoveredColor)
                g.FillRectangle(brush, Me.ClientRectangle)
            End Using
        End If
        ' Quadrato massimo in cui disegnare la X
        Dim squareSize As Integer = Math.Min(Me.Width, Me.Height) * 0.3 ' 60% della min dimension
        Dim offsetX As Integer = (Me.Width - squareSize) \ 2
        Dim offsetY As Integer = (Me.Height - squareSize) \ 2

        ' Coordinate della X
        Dim x1 As New Point(offsetX, offsetY)
        Dim x2 As New Point(offsetX + squareSize, offsetY + squareSize)
        Dim x3 As New Point(offsetX + squareSize, offsetY)
        Dim x4 As New Point(offsetX, offsetY + squareSize)

        ' Disegna la X
        Using pen As New Pen(Color.White, 1)
            g.DrawLine(pen, x1, x2)
            g.DrawLine(pen, x3, x4)
        End Using
    End Sub
End Class
