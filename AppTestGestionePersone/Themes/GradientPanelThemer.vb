Imports Syncfusion.Windows.Forms.Tools

Friend NotInheritable Class GradientPanelThemer
    Public Shared Sub ApplyTheme(panel As GradientPanelExt, Optional title As String = "")
        panel.CornerRadius = 8
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.BorderColor = Color.FromArgb(200, 200, 200)
        panel.Padding = New Padding(12)

        If Not String.IsNullOrEmpty(title) Then
            Dim titleLabel As Label = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name = "PanelTitleLabel")
            If titleLabel Is Nothing Then
                titleLabel = New Label() With {.Name = "PanelTitleLabel"}
                panel.Controls.Add(titleLabel)
            End If

            titleLabel.Text = title
            titleLabel.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            titleLabel.ForeColor = Color.FromArgb(41, 128, 185)
            titleLabel.BackColor = Color.Transparent
            titleLabel.AutoSize = True
            titleLabel.Location = New Point(10, 5)
            titleLabel.BringToFront()
        End If
    End Sub
End Class