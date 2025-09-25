Friend NotInheritable Class RadioButtonThemer
    Public Shared Sub ApplyTheme(rb As RadioButton)
        rb.ForeColor = Theme.PrimaryColor
        rb.Font = Theme.DefaultFont
    End Sub
End Class