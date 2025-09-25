Friend NotInheritable Class PanelThemer

    Public Shared Sub ApplyTheme(pnl As Panel)
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
        End Select
    End Sub

    Public Shared Sub UpdateSecondaryPanelState(pnl As Panel, isActive As Boolean)
        pnl.BackColor = If(isActive, Theme.SecondaryPanelActiveBackgroundColor, Theme.SecondaryPanelInactiveBackgroundColor)

        If isActive Then
            BorderThemer.ApplyBorder(pnl, borderWidth:=2.5F)
        Else
            BorderThemer.ApplyBorder(pnl, borderWidth:=0F)
        End If

        ' Aggiorna anche lo sfondo dei controlli figli
        Dim childColor As Color = pnl.BackColor
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Panel Then
                ctrl.BackColor = childColor
            End If
        Next

        pnl.Invalidate()
    End Sub
End Class