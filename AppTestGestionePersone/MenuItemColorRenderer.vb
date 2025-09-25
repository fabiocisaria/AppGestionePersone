Public Class MenuItemColorRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        ' Sfondo della barra principale e dei dropdown
        If TypeOf e.ToolStrip Is MenuStrip Then
            ' Barra principale
            Using brush As New SolidBrush(Theme.StripMenuPrimaryColor)
                e.Graphics.FillRectangle(brush, e.AffectedBounds)
            End Using
        ElseIf TypeOf e.ToolStrip Is ToolStripDropDownMenu Then
            ' Dropdown
            Using brush As New SolidBrush(Theme.StripMenuPrimaryColor)
                e.Graphics.FillRectangle(brush, e.AffectedBounds)
            End Using
        End If
    End Sub

    ' Sfondo dei singoli item
    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim g As Graphics = e.Graphics
        Dim rc As Rectangle = New Rectangle(0, 0, e.Item.Width, e.Item.Height)

        Dim item As ToolStripMenuItem = TryCast(e.Item, ToolStripMenuItem)
        Dim isActive As Boolean = (item IsNot Nothing AndAlso item.DropDown.Visible)
        Dim isHovered As Boolean = e.Item.Selected

        ' Sfondo generale (copre tutto)
        Using brush As New SolidBrush(Theme.StripMenuPrimaryColor)
            g.FillRectangle(brush, rc)
        End Using

        ' Mantieni trasparente lo sfondo del MenuStrip (così si vede il gradiente)
        If isActive Then
            ' Menu aperto → colore più scuro
            Using brush As New SolidBrush(Theme.StripMenuActiveColor)
                g.FillRectangle(brush, rc)
            End Using

            Using pen As New Pen(Theme.StripMenuBorderActiveColor, 1)
                g.DrawLine(pen, rc.Left, rc.Top, rc.Right - 1, rc.Top)
                g.DrawLine(pen, rc.Left, rc.Top, rc.Left, rc.Bottom - 1)
                g.DrawLine(pen, rc.Right - 1, rc.Top, rc.Right - 1, rc.Bottom - 1)
            End Using
        ElseIf isHovered Then
            ' Colore interno (hover)
            Using brush As New SolidBrush(Theme.StripMenuHoveredColor)
                g.FillRectangle(brush, rc)
            End Using

            ' Bordo chiaro
            Using pen As New Pen(Theme.StripMenuBorderHoveredColor, 0.5)
                g.DrawRectangle(pen, rc.X, rc.Y, rc.Width - 1, rc.Height - 1)
            End Using

            'Else
            ' Lascia trasparente → si vede il gradiente della barra
            '    Using brush As New SolidBrush(Color.Transparent)
            '    e.Graphics.FillRectangle(brush, rc)
            '    End Using
        End If
    End Sub

    ' Colore del testo
    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)

        ' Se è un dropdown, forzo comunque bianco
        Dim textColor As Color = Theme.StripMenuTextPrimaryColor

        ' Se è disabilitato → grigio
        If Not e.Item.Enabled Then
            textColor = Color.Gray
        End If

        ' Disegna il testo manualmente
        TextRenderer.DrawText(
            e.Graphics,
            e.Text,
            e.TextFont,
            e.TextRectangle,
            textColor,
            TextFormatFlags.VerticalCenter Or TextFormatFlags.Left
        )
        'MyBase.OnRenderItemText(e)
    End Sub
End Class
