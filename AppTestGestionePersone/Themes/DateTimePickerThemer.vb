
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.Input

Friend NotInheritable Class DateTimePickerThemer
    Public Shared Sub ApplyTheme(dte As SfDateTimeEdit)
        With dte
            .Format = DateTimePickerFormat.Long
            .Style.BackColor = Theme.DteBackColor
            .Style.BorderColor = Theme.DteBorderColor
            .Style.DisabledBackColor = Theme.DteDisabledBackColor
            .Style.DisabledForeColor = Theme.DteDisabledForeColor

            .Style.FocusedBorderColor = Theme.DteFcusedBorderColor

            .Style.ForeColor = Theme.DteForeColor
            .Style.HoverBorderColor = Theme.DteHoverBorderColor

            .Style.UpDownBackColor = Theme.DteUpDownBackColor
            .Style.UpDownForeColor = Theme.DteUpDownForeColor
            .Style.UpDownHoverBackColor = Theme.DteUpDownHoverBackColor
            .Style.UpDownHoverForeColor = Theme.DteUpDownHoverForeColor
            .Style.WatermarkForeColor = Theme.DteWatermarkForeColor

            ' DropDown
            .Style.DropDown.BackColor = Theme.DteDropDownBackColor
            .Style.DropDown.ForeColor = Theme.DteDropDownForeColor
            .Style.DropDown.HoverBackColor = Theme.DteDropDownHoverBackColor
            .Style.DropDown.HoverForeColor = Theme.DteDropDownHoverForeColor
            .Style.DropDown.PressedBackColor = Theme.DteDropDownPressedBackColor
            .Style.DropDown.PressedForeColor = Theme.DteDropDownPressedForeColor



        End With

        dte.Font = Theme.TxtFont
    End Sub
End Class