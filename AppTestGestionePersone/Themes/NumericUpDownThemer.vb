Friend NotInheritable Class NumericUpDownThemer
    Public Shared Sub ApplyTheme(num As NumericUpDown)
        num.BackColor = Color.White
        num.ForeColor = Theme.PrimaryColor
        num.Font = Theme.DefaultFont
    End Sub
End Class