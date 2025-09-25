Imports Syncfusion.Windows.Forms.Tools
Friend NotInheritable Class TextBoxThemer
    Public Shared Sub ApplyTheme(txt As TextBoxExt)
        Select Case txt.Tag?.ToString()
            Case ThemeTags.Code
                txt.Font = Theme.CodeFont
                txt.ForeColor = Theme.TextBoxForeColor
                txt.BorderStyle = BorderStyle.None

            Case ThemeTags.Find
                txt.BorderStyle = BorderStyle.None          ' Bordo liscio
                txt.ThemeName = "Default"                   ' Disattiva stili Syncfusion predefiniti
                txt.Style = TextBoxExt.theme.Metro          ' Stile che supporti i colori

                txt.Font = Theme.TxtFontItalic
                txt.BorderColor = Theme.TextBoxBorderColor
                txt.ForeColor = Theme.FindColor
                txt.FocusBorderColor = Theme.TextBoxFocusBorderColor
                txt.BackColor = Theme.TextBoxBackColor
                txt.Metrocolor = Theme.TextBoxBorderColor

            Case Else
                txt.BorderStyle = BorderStyle.None          ' Bordo liscio
                txt.ThemeName = "Default"                   ' Disattiva stili Syncfusion predefiniti
                txt.Style = TextBoxExt.theme.Metro          ' Stile che supporti i colori

                txt.Font = Theme.TxtFont
                txt.BorderColor = Theme.TextBoxBorderColor
                txt.ForeColor = Theme.TextBoxForeColor
                txt.FocusBorderColor = Theme.TextBoxFocusBorderColor
                txt.BackColor = Theme.TextBoxBackColor
                txt.Metrocolor = Theme.TextBoxBorderColor
        End Select
    End Sub
End Class