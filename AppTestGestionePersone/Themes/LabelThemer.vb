Friend NotInheritable Class LabelThemer
    Public Shared Sub ApplyTheme(lbl As Label)
        Select Case lbl.Tag?.ToString()
            Case ThemeTags.TitlePaziente
                lbl.ForeColor = Theme.TitlePazienteColor
                lbl.Font = Theme.TitlePazienteFont
            Case ThemeTags.TitleVisita
                lbl.ForeColor = Theme.PrimaryColor
                lbl.Font = Theme.TitleVisitaFont
            Case ThemeTags.Code
                lbl.ForeColor = Theme.CodeColor
                lbl.Font = Theme.CodeFont
            Case ThemeTags.PrimaryTitle
                lbl.ForeColor = Theme.PrimaryColor
                lbl.Font = Theme.TitlePrimaryFont
            Case ThemeTags.SecondaryTitle
                lbl.ForeColor = Theme.SecondaryColor
                lbl.Font = Theme.TitlePrimaryFont
            Case ThemeTags.ThirdTitle
                lbl.ForeColor = Theme.SecondaryColor
                lbl.Font = Theme.TitleThirdFont
            Case Else
                lbl.ForeColor = Theme.LabelColor
                lbl.Font = Theme.DefaultFont
        End Select
    End Sub
End Class