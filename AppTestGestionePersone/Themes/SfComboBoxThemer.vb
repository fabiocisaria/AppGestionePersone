Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.ListView

Friend NotInheritable Class SfComboBoxThemer
    Public Shared Sub ApplyTheme(cb As SfComboBox)
        With cb
            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDown

            .ThemeName = "Default"                   ' Disattiva stili Syncfusion predefiniti
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSuggestDelay = 1
            .AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
            .ShowClearButton = True

            .BackColor = Theme.ComboBoxBackColor                ' Sfondo della textbox
            '.ForeColor = Theme.ComboBoxForeColor                ' Colore testo

            ' Bordo
            ' Sfondo e testo
            '.Style.EditorStyle.BackColor = Theme.ComboBoxEditorStyleBackColor
            '.Style.EditorStyle.ForeColor = Theme.ComboBoxEditorStyleForeColor
            '.Style.EditorStyle.FocusedBorderColor = Theme.ComboBoxEditorStyleFocusedBorderColor
            .Style.EditorStyle.BorderColor = Theme.ComboBoxBorderColor

            ' Bottone a discesa
            .Style.DropDownButtonStyle.BackColor = Theme.ComboBoxDropDownButtonBackColor
            .Style.DropDownButtonStyle.DisabledBackColor = Color.White
            .Style.DropDownButtonStyle.DisabledForeColor = Theme.ComboBoxDropDownButtonDisabledForeColor
            .Style.DropDownButtonStyle.FocusedBackColor = Theme.ComboBoxDropDownButtonStyleFocusedBackColor
            .Style.DropDownButtonStyle.FocusedForeColor = Theme.ComboBoxDropDownButtonStyleFocusedForeColor
            .Style.DropDownButtonStyle.ForeColor = Theme.ComboBoxDropDownButtonStyleForeColor
            .Style.DropDownButtonStyle.HoverBackColor = Color.White
            .Style.DropDownButtonStyle.HoverForeColor = Theme.ComboBoxDropDownButtonStyleHoverForeColor
            .Style.DropDownButtonStyle.PressedBackColor = Theme.ComboBoxDropDownButtonStylePressedBackColor
            .Style.DropDownButtonStyle.PressedForeColor = Theme.ComboBoxDropDownButtonStylePressedForeColor

            ' Clear button
            .Style.ClearButtonStyle.BackColor = Theme.ComboBoxClearButtonBackColor
            .Style.ClearButtonStyle.DisabledBackColor = Color.White
            .Style.ClearButtonStyle.DisabledForeColor = Theme.ComboBoxClearButtonDisabledForeColor
            .Style.ClearButtonStyle.FocusedBackColor = Theme.ComboBoxClearButtonStyleFocusedBackColor
            .Style.ClearButtonStyle.FocusedForeColor = Theme.ComboBoxClearButtonStyleFocusedForeColor
            .Style.ClearButtonStyle.ForeColor = Theme.ComboBoxClearButtonStyleForeColor
            .Style.ClearButtonStyle.HoverBackColor = Color.White
            .Style.ClearButtonStyle.HoverForeColor = Theme.ComboBoxClearButtonStyleHoverForeColor
            .Style.ClearButtonStyle.PressedBackColor = Theme.ComboBoxClearButtonStylePressedBackColor
            .Style.ClearButtonStyle.PressedForeColor = Theme.ComboBoxClearButtonStylePressedForeColor

            ' Drop down style
            '.Style.DropDownStyle.BorderColor = Theme.ComboBoxDropDownStyleBorderColor

            ' Bordo
            '.BorderStyle = BorderStyle.FixedSingle

            .Font = Theme.TxtFont
        End With
    End Sub
End Class
