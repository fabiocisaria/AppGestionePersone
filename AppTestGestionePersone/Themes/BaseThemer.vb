Friend NotInheritable Class BaseThemer
    Public Shared Sub ApplyTheme(ctrl As Control)
        ctrl.BackColor = Theme.BackgroundPrimaryColor
        ctrl.ForeColor = Theme.TextColor
        ctrl.Font = Theme.DefaultFont
    End Sub
End Class
