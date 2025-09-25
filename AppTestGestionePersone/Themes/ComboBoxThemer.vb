Imports System.Drawing
Imports System.Windows.Forms

Friend NotInheritable Class ComboBoxThemer

    Public Shared Sub ApplyTheme(cmb As ComboBox)
        ' Imposta disegno owner-drawn
        cmb.DrawMode = DrawMode.OwnerDrawFixed
        cmb.FlatStyle = FlatStyle.Flat

        ' Gestione disegno degli item
        AddHandler cmb.DrawItem, AddressOf DrawItemHandler

        ' Gestione del bordo
        AddHandler cmb.Paint, AddressOf PaintBorderHandler
        AddHandler cmb.GotFocus, Sub() cmb.Invalidate()
        AddHandler cmb.LostFocus, Sub() cmb.Invalidate()
        AddHandler cmb.MouseEnter, Sub() cmb.Invalidate()
        AddHandler cmb.MouseLeave, Sub() cmb.Invalidate()
    End Sub

    Private Shared Sub DrawItemHandler(sender As Object, e As DrawItemEventArgs)
        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        If e.Index < 0 Then Return

        Dim g = e.Graphics
        Dim text As String = cmb.Items(e.Index).ToString()

        ' Sfondi
        Dim backColor As Color
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            backColor = Theme.ComboBoxItemSelectedBackColor
        ElseIf (e.State And DrawItemState.HotLight) = DrawItemState.HotLight Then
            backColor = Theme.ComboBoxItemHoverBackColor
        Else
            backColor = Theme.ComboBoxItemBackColor
        End If

        ' Disegna sfondo
        Using b As New SolidBrush(backColor)
            g.FillRectangle(b, e.Bounds)
        End Using

        ' Testo
        TextRenderer.DrawText(g, text, cmb.Font, e.Bounds, Theme.ComboBoxItemForeColor, TextFormatFlags.Left)
    End Sub

    Private Shared Sub PaintBorderHandler(sender As Object, e As PaintEventArgs)
        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        Dim g = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim borderColor As Color

        If cmb.Focused Then
            borderColor = Theme.ComboBoxFocusedBorderColor
        ElseIf cmb.ClientRectangle.Contains(cmb.PointToClient(Cursor.Position)) Then
            borderColor = Theme.ComboBoxHoveredBorderColor
        Else
            borderColor = Theme.ComboBoxBorderColor
        End If

        Using p As New Pen(borderColor, 2)
            g.DrawRectangle(p, 0, 0, cmb.Width - 1, cmb.Height - 1)
        End Using
    End Sub

End Class