Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.Input
Imports Syncfusion.WinForms.ListView

Public Class ThemeManager

    ' Applica tema a un controllo e ai suoi figli
    Public Shared Sub ApplyThemeToControls(ctrl As Control)
        ApplyThemeToControl(ctrl)

        For Each c As Control In ctrl.Controls
            ApplyThemeToControls(c)
        Next
    End Sub

    ' Applica tema a un singolo controllo
    Public Shared Sub ApplyThemeToControl(ctrl As Control, Optional title As String = "")
        If TypeOf ctrl Is GroupBox Then
            GroupBoxThemer.ApplyTheme(DirectCast(ctrl, GroupBox))
        ElseIf TypeOf ctrl Is TableLayoutPanel Then
            TableLayoutPanelThemer.ApplyTheme(DirectCast(ctrl, TableLayoutPanel))
        ElseIf TypeOf ctrl Is Panel Then
            PanelThemer.ApplyTheme(DirectCast(ctrl, Panel))
        ElseIf TypeOf ctrl Is Label Then
            LabelThemer.ApplyTheme(DirectCast(ctrl, Label))
        ElseIf TypeOf ctrl Is NumericUpDown Then
            NumericUpDownThemer.ApplyTheme(DirectCast(ctrl, NumericUpDown))
        ElseIf TypeOf ctrl Is RadioButton Then
            RadioButtonThemer.ApplyTheme(DirectCast(ctrl, RadioButton))
        ElseIf TypeOf ctrl Is SfDateTimeEdit Then
            DateTimePickerThemer.ApplyTheme(DirectCast(ctrl, SfDateTimeEdit))
        ElseIf TypeOf ctrl Is SfComboBox Then
            SfComboBoxThemer.ApplyTheme(DirectCast(ctrl, SfComboBox))
        ElseIf TypeOf ctrl Is ComboBox Then
            ComboBoxThemer.ApplyTheme(DirectCast(ctrl, ComboBox))
        ElseIf TypeOf ctrl Is SfButton Then
            ButtonThemer.ApplyTheme(DirectCast(ctrl, SfButton))
        ElseIf TypeOf ctrl Is TextBoxExt Then
            TextBoxThemer.ApplyTheme(DirectCast(ctrl, TextBoxExt))
        ElseIf TypeOf ctrl Is GradientPanelExt Then
            GradientPanelThemer.ApplyTheme(DirectCast(ctrl, GradientPanelExt), title)
        ElseIf TypeOf ctrl Is UserControl Then
            UserControlThemer.ApplyTheme(DirectCast(ctrl, UserControl))
        Else
            BaseThemer.ApplyTheme(ctrl)
        End If
    End Sub

    ' Cambia stato dei SecondaryPanel (Panel o TableLayoutPanel)
    Public Shared Sub SetSecondaryPanelState(ctrl As Control, isActive As Boolean)
        If TypeOf ctrl Is Panel Then
            PanelThemer.UpdateSecondaryPanelState(DirectCast(ctrl, Panel), isActive)
        ElseIf TypeOf ctrl Is TableLayoutPanel Then
            TableLayoutPanelThemer.UpdateSecondaryPanelState(DirectCast(ctrl, TableLayoutPanel), isActive)
        End If
    End Sub
End Class