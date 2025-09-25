Friend NotInheritable Class UserControlThemer
    Public Shared Sub ApplyTheme(uc As UserControl)
        Dim radius As Integer = 7

        ' Applica colori e font di base
        uc.BackColor = Theme.UCBackgroundSecondColor
        uc.ForeColor = Theme.TextColor
        uc.Font = Theme.DefaultFont
        uc.Margin = New Padding(1)

        ' Arrotonda automaticamente
        Rounder.ApplyRounded(uc, radius)
    End Sub
End Class