Public Class GradientMenuStripRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        ' Sfondo della barra principale e dei dropdown
        If TypeOf e.ToolStrip Is MenuStrip Then
            ' Barra principale
            Using brush As New SolidBrush(Color.FromArgb(45, 45, 48))
                e.Graphics.FillRectangle(brush, e.AffectedBounds)
            End Using
        ElseIf TypeOf e.ToolStrip Is ToolStripDropDownMenu Then
            ' Dropdown
            Using brush As New SolidBrush(Color.FromArgb(37, 37, 38))
                e.Graphics.FillRectangle(brush, e.AffectedBounds)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim g As Graphics = e.Graphics
        Dim rect As Rectangle = New Rectangle(0, 0, e.Item.Width, e.Item.Height)

        ' Sfondo generale (copre tutto)
        Using brush As New SolidBrush(Color.FromArgb(37, 37, 38))
            g.FillRectangle(brush, rect)
        End Using

        ' Hover / Attivo
        Dim item As ToolStripMenuItem = TryCast(e.Item, ToolStripMenuItem)
        Dim isHovered As Boolean = e.Item.Selected
        Dim isActive As Boolean = (item IsNot Nothing AndAlso item.DropDown.Visible)

        If isActive Then
            Using brush As New SolidBrush(Color.FromArgb(50, 50, 55))
                g.FillRectangle(brush, rect)
            End Using
        ElseIf isHovered Then
            Using brush As New SolidBrush(Color.FromArgb(70, 70, 75))
                g.FillRectangle(brush, rect)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        ' Disegniamo il testo manualmente (non chiamiamo MyBase)
        Dim textColor As Color = If(e.Item.Enabled, Color.White, Color.Gray)

        TextRenderer.DrawText(
            e.Graphics,
            e.Text,
            e.TextFont,
            e.TextRectangle,
            textColor,
            TextFormatFlags.Left Or TextFormatFlags.VerticalCenter
        )
    End Sub
End Class