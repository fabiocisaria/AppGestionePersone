Friend NotInheritable Class GroupBoxThemer
    Public Shared Sub ApplyTheme(gb As GroupBox)
        gb.BackColor = Theme.PrimaryPanelBackgroundColor
        gb.ForeColor = Theme.PrimaryColor
        gb.Font = Theme.TitlePrimaryFont
    End Sub
End Class