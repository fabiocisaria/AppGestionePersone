Public Class UC_VisitaSintomi
    Dim idVisita As Integer = -1

    Private Sub FormVisitaSintomi_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        PulisciCampi(TableLayoutPanelVisitaSintomi)
        RadioAutoCheck(True, TableLayoutPanelVisitaSintomi)
        ResetAndDisableControls(False, GroupBoxVVDDettagli)
        ResetAndDisableControls(False, GroupBoxAlvoDettagli)
        ResetAndDisableControls(False, GroupBoxDispLoc)
    End Sub

    Private Sub RadioButtonVVDSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonVVDSi.CheckedChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        ResetAndDisableControls(RadioButtonVVDSi.Checked, GroupBoxVVDDettagli)
    End Sub

    Private Sub RadioButtonVVDNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonVVDNo.CheckedChanged
        ' Nasconde i dettagli se "No" è selezionato
        ResetAndDisableControls(Not RadioButtonVVDNo.Checked, GroupBoxVVDDettagli)
    End Sub

    Private Sub RadioButtonAlvoSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAlvoSi.CheckedChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        ResetAndDisableControls(RadioButtonAlvoSi.Checked, GroupBoxAlvoDettagli)
    End Sub

    Private Sub RadioButtonAlvoNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAlvoNo.CheckedChanged
        ' Nasconde i dettagli solo se "No" è selezionato
        ResetAndDisableControls(Not RadioButtonAlvoNo.Checked, GroupBoxAlvoDettagli)
    End Sub

    Private Sub RadioButtonDispMarin0_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDispMarin0.CheckedChanged
        ' Nasconde i dettagli solo se viene selezionato 0
        ResetAndDisableControls(RadioButtonDispMarin1.Checked Or RadioButtonDispMarin2.Checked Or RadioButtonDispMarin3.Checked, GroupBoxDispLoc)
    End Sub

    Private Sub RadioButtonDispMarinNot0_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDispMarin1.CheckedChanged, RadioButtonDispMarin2.CheckedChanged, RadioButtonDispMarin3.CheckedChanged
        ' Mostra il GroupBox dei dettagli solo se uno dei tre è selezionato
        ResetAndDisableControls(RadioButtonDispMarin1.Checked Or RadioButtonDispMarin2.Checked Or RadioButtonDispMarin3.Checked, GroupBoxDispLoc)
    End Sub

    ' Da verificare (la quesry non si avvia se non ho selezionato tutto)
    Private Function CheckSelezione() As Boolean
        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelVisitaSintomi)

        ' Verifico se sono state effettuate tutte le scelte
        Dim result = ValidateMultipleGroups(TableLayoutPanelVisitaSintomi)

        Dim invalidGroups = result.InvalidGroups

        ' Se "Presenza VVD = No", rimuovo i gruppi collegati dai controlli obbligatori
        If RadioButtonVVDNo.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelVVDInsorg OrElse
                                                          gb Is TableLayoutPanelVVDAndam OrElse
                                                          gb Is TableLayoutPanelVVDDistr)).ToList()
        End If

        ' Se "Disp Marinof = 0", rimuovo i gruppi collegati dai controlli obbligatori
        If RadioButtonDispMarin0.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) gb IsNot GroupBoxDispLoc).ToList()
        End If

        ' Se "Presenza Alvo = No", rimuovo i gruppi collegati dai controlli obbligatori
        If RadioButtonAlvoNo.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelAlveoStipsi OrElse
                                                          gb Is TableLayoutPanelAlvoColonIrr OrElse
                                                          gb Is TableLayoutPanelAlvoAlterno OrElse
                                                          gb Is TableLayoutPanelAlvoDiarr)).ToList()
        End If

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HighlightInvalidGroups(invalidGroups.ToArray())
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SalvaDati()
        Dim selezioneOK As Boolean = CheckSelezione()

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idVisita = main.IDVisitaSelezionata

            Dim successo As Boolean = False

            Dim vvdPres As Boolean = RadioButtonVVDSi.Checked
            Dim vvdMod As String = GetSelectedRadioText(GroupBoxVVDModInsorg)
            Dim vvdAnd As String = GetSelectedRadioText(GroupBoxVVDAndam)
            Dim vvdDistr As String = GetSelectedRadioText(GroupBoxVVDDistr)

            Dim vagRic As Boolean = RadioButtonVaginSi.Checked

            Dim CistRic As Boolean = RadioButtonCistSi.Checked

            Dim dispMar As Integer? = GetSelectedRadioNumber(GroupBoxDispMarinoff)
            Dim dispLoc As String = GetSelectedRadioText(GroupBoxDispLoc)

            Dim alvoPres As Boolean = RadioButtonAlvoSi.Checked
            Dim alvoStipsi As String = RadioButtonAlvoStipsiSi.Checked
            Dim alvoColonIrr As String = RadioButtonAlvoColonIrrSi.Checked
            Dim alvoAltrn As String = RadioButtonAlvoAltrnSi.Checked
            Dim alvoDiarr As String = RadioButtonAlvoDiarrSi.Checked

            Dim luts As String = GetSelectedRadioText(GroupBoxLuts)

            Dim dolVesc As String = GetSelectedRadioText(GroupBoxDolVes)

            Try
                'Verifica che non esista già la descrizione dei sintomi per quella visita
                Dim checkQuery As String = "SELECT COUNT(*) FROM VisitaSintomi WHERE ID_Visita = @idVisita"

                Dim checkParam As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@idVisita", idVisita)
                }
                Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

                If dtCheck.Rows(0)(0) > 0 Then
                    main.MostraToast("Attenzione: per questa visita sono già stati inseriti i sintomi")
                    Exit Sub
                End If

                'Se non esiste, esegui l'inserimento
                Dim querySintomi As String = "INSERT INTO VisitaSintomi (
                                                    ID_Visita,
                                                    VulvodiniaPresente,
                                                    VulvodiniaModalita,
                                                    VulvodiniaAndamento,
                                                    VulvodiniaDistrib,
                                                    VaginitiRicorr,
                                                    CistitiRicorr,
                                                    DispareuniaMarinoff,
                                                    DispareuniaLoc,
                                                    AlvoPresenza,
                                                    AlvoStipsi,
                                                    AlvoColonIrr,
                                                    AlvoAlterno,
                                                    AlvoDiarroico,
                                                    LUTS,
                                                    DoloreVescicale
                                                    ) VALUES (
                                                    @idVisita,
                                                    @vvdPres,
                                                    @vvdMod,
                                                    @vvdAnd,
                                                    @vvdDistr,
                                                    @vagRic,
                                                    @cistRic,
                                                    @dispMar,
                                                    @dispLoc,
                                                    @alvoPres,
                                                    @alvoStipsi,
                                                    @alvoColonIrr,
                                                    @alvoAltrn,
                                                    @alvoDiarr,
                                                    @luts,
                                                    @dolVesc)"

                Dim parametriSintomi As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@idVisita", idVisita),
                    New SqlClient.SqlParameter("@vvdPres", vvdPres),
                    New SqlClient.SqlParameter("@vvdMod", vvdMod),
                    New SqlClient.SqlParameter("@vvdAnd", vvdAnd),
                    New SqlClient.SqlParameter("@vvdDistr", vvdDistr),
                    New SqlClient.SqlParameter("@vagRic", vagRic),
                    New SqlClient.SqlParameter("@cistRic", CistRic),
                    New SqlClient.SqlParameter("@dispMar", dispMar),
                    New SqlClient.SqlParameter("@dispLoc", dispLoc),
                    New SqlClient.SqlParameter("@alvoPres", alvoPres),
                    New SqlClient.SqlParameter("@alvoStipsi", alvoStipsi),
                    New SqlClient.SqlParameter("@alvoColonIrr", alvoColonIrr),
                    New SqlClient.SqlParameter("@alvoAltrn", alvoAltrn),
                    New SqlClient.SqlParameter("@alvoDiarr", alvoDiarr),
                    New SqlClient.SqlParameter("@luts", luts),
                    New SqlClient.SqlParameter("@dolVesc", dolVesc)
                }

                If EseguiNonQuery(querySintomi, parametriSintomi) > 0 Then
                    successo = True
                    main.MostraToast("Sintomi inseriti correttamente.")
                End If
            Catch ex As Exception
                MessageBox.Show("Errore imprevisto: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Inserici_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        SalvaDati()
    End Sub
End Class
