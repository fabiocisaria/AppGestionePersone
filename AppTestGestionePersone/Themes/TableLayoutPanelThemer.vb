Friend NotInheritable Class TableLayoutPanelThemer
    Public Shared Sub ApplyTheme(pnl As TableLayoutPanel)
        Dim radius As Integer = 5

        Select Case pnl.Tag?.ToString()
            Case ThemeTags.SecondaryPanel
                UpdateSecondaryPanelState(pnl, pnl.Enabled)
                Rounder.ApplyRounded(pnl, radius)
                BorderThemer.ApplyBorder(pnl, borderWidth:=2.5F)

            Case ThemeTags.PrimaryPanel
                pnl.BackColor = Theme.PrimaryPanelBackgroundColor
                Rounder.ApplyRounded(pnl, radius)
                BorderThemer.ApplyBorder(pnl, borderWidth:=2.5F)

            Case ThemeTags.DatiPaziente
                GradientBackgroundThemer.ApplyGradient(pnl, Theme.UCBackgroundFirstColor, Theme.UCBackgroundSecondColor, 90)
            Case ThemeTags.DatiVisita
                pnl.BackColor = Color.White
            Case ThemeTags.Selection
                pnl.BackColor = Theme.BackgroundPrimaryColor
            Case Else
                pnl.BackColor = Theme.BackgroundPrimaryColor
        End Select
    End Sub

    Public Shared Sub UpdateSecondaryPanelState(pnl As TableLayoutPanel, isActive As Boolean)
        pnl.BackColor = If(isActive, Theme.SecondaryPanelActiveBackgroundColor, Theme.SecondaryPanelInactiveBackgroundColor)

        If isActive Then
            BorderThemer.ApplyBorder(pnl, borderWidth:=2.5F)
        Else
            BorderThemer.ApplyBorder(pnl, borderWidth:=0F)
        End If

        UpdateChildTableLayoutBackColor(pnl, pnl.BackColor)

        '' Aggiorna anche lo sfondo dei controlli figli
        'Dim childColor As Color = pnl.BackColor
        'For Each ctrl As Control In pnl.Controls
        '    If TypeOf ctrl Is TableLayoutPanel Then
        '        ctrl.BackColor = childColor
        '    End If
        'Next

        pnl.Invalidate()
    End Sub

    Private Shared Sub UpdateChildTableLayoutBackColor(parent As Control, color As Color)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TableLayoutPanel Then
                ctrl.BackColor = color
                UpdateChildTableLayoutBackColor(ctrl, color) ' Ricorsione
            End If
        Next
    End Sub
End Class