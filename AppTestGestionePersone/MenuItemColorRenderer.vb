Public Class MenuItemColorRenderer
    Inherits ToolStripProfessionalRenderer

    ' Colori per gli item
    Private itemHoverBackColor As Color = ColorTranslator.FromHtml("#C7E5FF")    ' Hover
    Private itemSelectedBackColor As Color = ColorTranslator.FromHtml("#FFFFF") ' Selezionato

    ' Colore di sfondo per le tendine
    Private dropDownBackColor As Color = Color.Transparent

    Private itemTextColor As Color = ColorTranslator.FromHtml("#413F45")                              ' Testo

    ' Sfondo dei singoli item
    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim rc As New Rectangle(Point.Empty, e.Item.Size)

        ' Mantieni trasparente lo sfondo del MenuStrip (così si vede il gradiente)
        If e.Item.Selected Then
            Using brush As New SolidBrush(itemHoverBackColor)
                e.Graphics.FillRectangle(brush, rc)
            End Using
        ElseIf e.Item.Pressed Then
            Using brush As New SolidBrush(itemSelectedBackColor)
                e.Graphics.FillRectangle(brush, rc)
            End Using
        Else
            ' Lascia trasparente → si vede il gradiente della barra
            Using brush As New SolidBrush(Color.Transparent)
                e.Graphics.FillRectangle(brush, rc)
            End Using
        End If
    End Sub

    ' Colore del testo
    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        e.TextColor = itemTextColor
        MyBase.OnRenderItemText(e)
    End Sub

    ' Sfondo generale dei ToolStrip (MenuStrip o DropDown)
    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        If TypeOf e.ToolStrip Is MenuStrip Then

        ElseIf TypeOf e.ToolStrip Is ToolStripDropDownMenu Then
            ' Sfondo dropdown intero
            Using brush As New SolidBrush(dropDownBackColor)
                e.Graphics.FillRectangle(brush, e.ToolStrip.ClientRectangle)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        ' Disabilita il bordo del dropdown
        ' oppure puoi colorarlo dello stesso colore dello sfondo
        If TypeOf e.ToolStrip Is ToolStripDropDownMenu Then
            Using brush As New SolidBrush(dropDownBackColor)
                e.Graphics.FillRectangle(brush, e.ToolStrip.ClientRectangle)
            End Using
        Else
            MyBase.OnRenderToolStripBorder(e)
        End If
    End Sub
End Class
