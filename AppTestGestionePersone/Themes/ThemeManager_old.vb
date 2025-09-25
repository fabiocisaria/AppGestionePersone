Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Media.Imaging
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class ThemeManager_old

    Public Class RoundedFormParams
        Public Property Radius As Integer
        Public Property TopOffset As Integer
        Public Property BorderColor As Color
    End Class


    Private Shared RoundedFormData As New Dictionary(Of Form, RoundedFormParams)

    Private Shared ReadOnly PanelPaintRegistry As New Dictionary(Of Panel, Boolean)

    ' Applica tema a tutti i controlli di una UserControl
    Public Shared Sub ApplyThemeToControls(ctrl As Control)
        If TypeOf ctrl Is UserControl Then
            Dim uc As UserControl = CType(ctrl, UserControl)

            If uc.Tag IsNot Nothing Then
                Select Case uc.Tag.ToString()
                    Case "Dati"
                        uc.BackColor = Theme.PrimaryPanelBackgroundColor
                        uc.ForeColor = Theme.TextColor
                        uc.Font = Theme.DefaultFont
                    Case Else
                        uc.BackColor = Theme.BackgroundPrimaryColor
                        uc.ForeColor = Theme.TextColor
                        uc.Font = Theme.DefaultFont
                End Select
            Else
                uc.BackColor = Theme.BackgroundPrimaryColor
                uc.ForeColor = Theme.TextColor
                uc.Font = Theme.DefaultFont
                uc.Margin = New Padding(10)
                Utils.RoundControl(uc, 5)
            End If
        Else
            ctrl.BackColor = Theme.BackgroundPrimaryColor
            ctrl.ForeColor = Theme.TextColor
            ctrl.Font = Theme.DefaultFont
        End If

        For Each c As Control In ctrl.Controls
            ApplyThemeToControl(c)
        Next
    End Sub

    ' Applica stile specifico a un singolo controllo
    Public Shared Sub ApplyThemeToControl(ctrl As Control, Optional title As String = "")
        Select Case True
            Case TypeOf ctrl Is GroupBox
                Dim gb As GroupBox = CType(ctrl, GroupBox)
                gb.BackColor = Theme.PrimaryPanelBackgroundColor
                gb.ForeColor = Theme.PrimaryColor
                gb.Font = Theme.TitlePrimaryFont

            Case TypeOf ctrl Is Panel
                Dim pnl As Panel = CType(ctrl, Panel)

                pnl.Update()

                If pnl.Tag IsNot Nothing Then
                    Select Case pnl.Tag.ToString()
                        Case "PrimaryPanel"
                            pnl.BackColor = Theme.PrimaryPanelBackgroundColor
                            Utils.RoundControl(pnl, 5)
                        Case "SecondaryPanel"
                            Utils.RoundControl(pnl, 5)

                            If pnl.Enabled = True Then
                                pnl.BackColor = Theme.SecondaryPanelActiveBackgroundColor
                            ElseIf pnl.Enabled = False Then
                                pnl.BackColor = Theme.SecondaryPanelInactiveBackgroundColor
                            End If

                            RemoveHandler pnl.Paint, AddressOf PanelRoundedPaint
                            AddHandler pnl.Paint, AddressOf PanelRoundedPaint

                            pnl.Invalidate() ' forza il ridisegno e fa partire subito il Paint
                    End Select
                End If

            Case TypeOf ctrl Is TableLayoutPanel
                Dim pnl As TableLayoutPanel = CType(ctrl, TableLayoutPanel)

                If pnl.Tag IsNot Nothing Then
                    Select Case pnl.Tag.ToString()
                        Case "PrimaryPanel"
                            pnl.BackColor = Theme.PrimaryPanelBackgroundColor
                            Utils.RoundControl(pnl, 5)
                        Case "SecondaryPanel"
                            Utils.RoundControl(pnl, 5)

                            If pnl.Enabled Then
                                pnl.BackColor = Theme.SecondaryPanelActiveBackgroundColor
                            Else
                                pnl.BackColor = Theme.SecondaryPanelInactiveBackgroundColor
                            End If
                        Case "Dati"
                            pnl.BackColor = Color.White
                    End Select
                End If

            Case TypeOf ctrl Is Label
                Dim lbl As Label = CType(ctrl, Label)

                If lbl.Tag IsNot Nothing Then
                    Select Case lbl.Tag.ToString()
                        Case "TitlePaziente"
                            lbl.ForeColor = Theme.TitlePazienteColor
                            lbl.Font = Theme.TitlePazienteFont
                        Case "TitleVisita"
                            lbl.ForeColor = Theme.PrimaryColor
                            lbl.Font = Theme.TitleVisitaFont
                        Case "Code"
                            lbl.ForeColor = Theme.CodeColor
                            lbl.Font = Theme.CodeFont
                        Case "PrimaryTitle"
                            lbl.ForeColor = Theme.PrimaryColor
                            lbl.Font = Theme.TitlePrimaryFont
                        Case "SecondaryTitle"
                            lbl.ForeColor = Theme.SecondaryColor
                            lbl.Font = Theme.TitlePrimaryFont
                        Case "ThirdTitle"
                            lbl.ForeColor = Theme.SecondaryColor
                            lbl.Font = Theme.TitleThirdFont
                        Case Else
                            lbl.ForeColor = Theme.LabelColor
                            lbl.Font = Theme.DefaultFont
                    End Select
                End If

            Case TypeOf ctrl Is NumericUpDown
                Dim num As NumericUpDown = CType(ctrl, NumericUpDown)
                num.BackColor = Color.White
                num.ForeColor = Theme.PrimaryColor
                num.Font = Theme.DefaultFont

            Case TypeOf ctrl Is RadioButton
                Dim rb As RadioButton = CType(ctrl, RadioButton)
                rb.ForeColor = Theme.PrimaryColor
                rb.Font = Theme.DefaultFont

            Case TypeOf ctrl Is Button
                Dim btn As Button = CType(ctrl, Button)
                btn.BackColor = Theme.PrimaryColor
                btn.ForeColor = Color.White
                btn.Font = Theme.ButtonFont
                btn.Margin = New Padding(left:=0, top:=0, right:=7, bottom:=7)
                Utils.RoundControl(btn, 5)

            Case TypeOf ctrl Is TextBox
                Dim txt As TextBox = CType(ctrl, TextBox)

                If txt.Tag IsNot Nothing Then
                    Select Case txt.Tag.ToString()
                        Case "Code"
                            txt.Font = Theme.CodeFont
                            txt.ForeColor = Theme.CodeColor
                        Case "Find"
                            txt.Font = Theme.TxtFontItalic
                            txt.ForeColor = Theme.FindColor
                        Case Else
                            txt.Font = Theme.TxtFont
                            txt.ForeColor = Theme.TextColor
                    End Select
                End If

            Case TypeOf ctrl Is Syncfusion.Windows.Forms.Tools.GradientPanelExt
                Dim panel As Syncfusion.Windows.Forms.Tools.GradientPanelExt = CType(ctrl, Syncfusion.Windows.Forms.Tools.GradientPanelExt)
                ApplyModernStyle(panel, title)
        End Select

        ' Applica ricorsivamente anche ai figli
        For Each child As Control In ctrl.Controls
            ApplyThemeToControl(child)
        Next
    End Sub

    Public Shared Sub ApplyRoundedForm(frm As Form, Optional radius As Integer = 10, Optional topOffset As Integer = 0, Optional borderColor As Color = Nothing)
        ' Rimuovo handler precedente per evitare duplicati
        RemoveHandler frm.Paint, AddressOf FormRoundedPaint

        ' Imposto FormBorderStyle
        frm.FormBorderStyle = FormBorderStyle.None

        ' Memorizzo parametri nel dizionario
        RoundedFormData(frm) = New RoundedFormParams With {
            .Radius = radius,
            .TopOffset = topOffset,
            .BorderColor = borderColor
        }

        ' Aggiungo handler
        AddHandler frm.Paint, AddressOf FormRoundedPaint
    End Sub

    Private Shared Sub FormRoundedPaint(sender As Object, e As PaintEventArgs)
        Dim frm As Form = DirectCast(sender, Form)
        If RoundedFormData.ContainsKey(frm) Then
            Dim data = RoundedFormData(frm)
            Utils.Control_Paint(sender, e, data.Radius, data.TopOffset, 1, data.BorderColor)
        End If
    End Sub

    ''' <summary>
    ''' Imposta bordo arrotondato + Paint handler per ridisegno
    ''' </summary>
    Private Shared Sub ApplyRoundedPanel(ctrl As Control)
        ' Arrotonda angoli
        Utils.RoundControl(ctrl, 5)

        ' Se è Panel o TableLayoutPanel, aggiungi Paint handler
        Dim pnl As Panel = TryCast(ctrl, Panel)
        If pnl IsNot Nothing Then
            ' Evita duplicati
            If Not PanelPaintRegistry.ContainsKey(pnl) Then
                AddHandler pnl.Paint, AddressOf PanelRoundedPaint
                PanelPaintRegistry(pnl) = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Paint handler per disegnare il bordo arrotondato
    ''' </summary>
    Private Shared Sub PanelRoundedPaint(sender As Object, e As PaintEventArgs)
        Dim pnl As Panel = TryCast(sender, Panel)
        If pnl Is Nothing Then Exit Sub

        ' Scegli il colore del bordo a seconda dello stato
        Dim borderColor As Color = If(pnl.Enabled, Theme.SecondaryPanelActiveBorder, Theme.SecondaryPanelInactiveBorder)

        Utils.Control_Paint(pnl, e, radius:=5, topOffset:=0, borderColor:=borderColor)
    End Sub

    ' Esempio di colori moderni
    Private Shared ReadOnly PanelGradientStart As Color = Color.FromArgb(245, 245, 245) ' grigio chiaro
    Private Shared ReadOnly PanelGradientEnd As Color = Color.FromArgb(230, 230, 230)   ' grigio più scuro
    Private Shared ReadOnly PanelBorderColor As Color = Color.FromArgb(200, 200, 200)   ' bordo delicato
    Private Shared ReadOnly PanelTitleColor As Color = Color.FromArgb(41, 128, 185)    ' blu titolo
    Private Shared ReadOnly PanelTitleFont As New Font("Segoe UI", 10, FontStyle.Bold)

    ''' <summary>
    ''' Applica lo stile moderno a un GradientPanelExt
    ''' </summary>
    Public Shared Sub ApplyModernStyle(panel As Syncfusion.Windows.Forms.Tools.GradientPanelExt, Optional title As String = "")
        If panel Is Nothing Then Return

        ' Bordo arrotondato e colore bordo
        panel.CornerRadius = 8
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.BorderColor = PanelBorderColor

        ' Padding interno per contenuti
        panel.Padding = New Padding(12)

        ' Titolo del pannello (opzionale)
        If Not String.IsNullOrEmpty(title) Then
            ' Cerca se già esiste un'etichetta titolo
            Dim titleLabel As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name = "PanelTitleLabel")
            If titleLabel Is Nothing Then
                titleLabel = New Label()
                titleLabel.Name = "PanelTitleLabel"
                panel.Controls.Add(titleLabel)
            End If

            titleLabel.Text = title
            titleLabel.Font = PanelTitleFont
            titleLabel.ForeColor = PanelTitleColor
            titleLabel.BackColor = Color.Transparent
            titleLabel.AutoSize = True
            titleLabel.Location = New Point(10, 5)
            titleLabel.BringToFront()
        End If
    End Sub

End Class
