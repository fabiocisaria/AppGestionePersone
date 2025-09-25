Imports Syncfusion.WinForms.Controls

Friend NotInheritable Class ButtonThemer
    Public Shared Sub ApplyTheme(btn As SfButton, Optional radius As Integer = 5)

        Select Case btn.Tag?.ToString()
            Case ThemeTags.OkButton
                With btn.Style
                    .BackColor = Color.FromArgb(41, 128, 185)
                    .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
                    .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
                    .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
                    .ForeColor = Color.White
                    .HoverForeColor = Color.White
                    .PressedForeColor = Color.White
                    .FocusedForeColor = Color.White
                End With
                btn.Font = Theme.ButtonFont
                btn.Margin = New Padding(0, 7, 7, 7)

                Rounder.ApplyRounded(btn, radius)

            Case ThemeTags.SelectButton
                With btn.Style
                    .BackColor = Color.FromArgb(39, 174, 96)
                    .HoverBackColor = Color.FromArgb(30, 130, 70) ' colore hover
                    .PressedBackColor = Color.FromArgb(30, 130, 70) ' colore quando premuto
                    .FocusedBackColor = Color.FromArgb(30, 130, 70) ' mantiene il blu anche se focus
                    .ForeColor = Color.White
                    .HoverForeColor = Color.White
                    .PressedForeColor = Color.White
                    .FocusedForeColor = Color.White
                End With
                btn.Font = Theme.ButtonFont
                btn.Margin = New Padding(0, 7, 7, 7)

                Rounder.ApplyRounded(btn, radius)

            Case ThemeTags.CancelButton
                With btn.Style
                    .BackColor = Color.FromArgb(192, 57, 43)
                    .HoverBackColor = Color.FromArgb(150, 40, 35)    ' colore hover
                    .PressedBackColor = Color.FromArgb(150, 40, 35)   ' colore quando premuto
                    .FocusedBackColor = Color.FromArgb(150, 40, 35)   ' mantiene il blu anche se focus
                    .ForeColor = Color.White
                    .HoverForeColor = Color.White
                    .PressedForeColor = Color.White
                    .FocusedForeColor = Color.White
                End With
                btn.Font = Theme.ButtonFont
                btn.Margin = New Padding(0, 7, 7, 7)

                Rounder.ApplyRounded(btn, radius)

            Case ThemeTags.AddButton
                With btn.Style
                    .BackColor = Color.FromArgb(41, 128, 185)
                    .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
                    .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
                    .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
                    .ForeColor = Color.White
                    .HoverForeColor = Color.White
                    .PressedForeColor = Color.White
                    .FocusedForeColor = Color.White
                End With
                btn.Font = Theme.ButtonFont
                btn.Margin = New Padding(0, 7, 7, 7)
        End Select
    End Sub
End Class