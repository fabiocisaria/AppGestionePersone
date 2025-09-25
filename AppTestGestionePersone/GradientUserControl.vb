Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class GradientUserControl
    Inherits UserControl

    ' Proprietà per impostare i colori dello sfondo dal Designer
    Private _colors() As Color = {Color.Red, Color.Yellow, Color.Blue}
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Property GradientColors() As Color()
        Get
            Return _colors
        End Get
        Set(value As Color())
            _colors = value
            Me.Invalidate() ' Ridisegna il controllo
        End Set
    End Property

    ' Proprietà per impostare l'angolo dello sfumato
    Private _angle As Single = 45.0F
    Public Property GradientAngle() As Single
        Get
            Return _angle
        End Get
        Set(value As Single)
            _angle = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        Using brush As New LinearGradientBrush(rect, Theme.UCBackgroundFirstColor, Theme.UCBackgroundSecondColor, _angle)
            ' ColorBlend permette sfumature multi-colore
            Dim cb As New ColorBlend()
            cb.Colors = _colors

            ' Distribuisce i colori uniformemente se non specificato
            Dim positions(_colors.Length - 1) As Single
            For i As Integer = 0 To positions.Length - 1
                positions(i) = i / (positions.Length - 1)
            Next
            cb.Positions = positions

            brush.InterpolationColors = cb
            e.Graphics.FillRectangle(brush, rect)
        End Using
    End Sub
End Class
