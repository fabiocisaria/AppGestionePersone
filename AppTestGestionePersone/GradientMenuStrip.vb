Public Class GradientMenuStrip
    Inherits MenuStrip

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Definiamo i colori del gradiente
        Dim colori() As Color = {
        ColorTranslator.FromHtml("#A9C8E5"),
        ColorTranslator.FromHtml("#AFC5E5"),
        ColorTranslator.FromHtml("#B9C1E4"),
        ColorTranslator.FromHtml("#C2BDE3"),
        ColorTranslator.FromHtml("#CBC5E7")
    }

        Using brush As New Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.White, Color.White, Drawing2D.LinearGradientMode.Horizontal)
            Dim blend As New Drawing2D.ColorBlend()
            blend.Colors = colori
            blend.Positions = {0.0F, 0.25F, 0.5F, 0.75F, 1.0F}
            brush.InterpolationColors = blend

            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using

        ' Disegna i bordi e il testo normalmente
        MyBase.OnPaint(e)
    End Sub
End Class
