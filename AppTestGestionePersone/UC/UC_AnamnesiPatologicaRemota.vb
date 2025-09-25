Imports Microsoft.Data.SqlClient
Public Class UC_AnamnesiPatologicaRemota
    Dim idPaziente As Integer = -1

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo
    End Sub

    Public Async Sub AggiornaDatiAsync()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idPaziente = main.IDPazienteSelezionato

            TableLayoutPanelAnPatRem.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaAnamnesiAsync()

            TableLayoutPanelAnPatRem.Enabled = True
            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnPatRem)
            End If
        End If
    End Sub

    Private Async Sub FormAnamnesiPatologicaRemota_Shown(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioAutoCheck(True, TableLayoutPanelAnPatRem)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idPaziente = main.IDPazienteSelezionato

            TableLayoutPanelAnPatRem.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaAnamnesiAsync()

            TableLayoutPanelAnPatRem.Enabled = True

            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnPatRem)
            End If
        End If

        'AddHandler Me.Resize, Sub() Utils.RoundControl(Me, 5)
    End Sub

    Private Sub RadioButtonDM1Si_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDM1Si.CheckedChanged, RadioButtonDM1No.CheckedChanged
        If RadioButtonDM1Si.Checked Then
            ' Mostra i dettagli solo se "Sì" è selezionato
            TableLayoutPanelDM2.Enabled = False
            TableLayoutPanelDM2.BackColor = Theme.SecondaryPanelInactiveBackgroundColor
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDM2, False)
            RadioButtonDM2No.Checked = True
        ElseIf RadioButtonDM1No.Checked And RadioButtonDM2Si.Checked = False Then
            TableLayoutPanelDM2.Enabled = True
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDM2, True)
        End If
    End Sub

    Private Sub RadioButtonDM2Si_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDM2Si.CheckedChanged, RadioButtonDM2No.CheckedChanged
        If RadioButtonDM2Si.Checked Then
            ' Mostra i dettagli solo se "Sì" è selezionato
            TableLayoutPanelDM1.Enabled = False
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDM1, False)
            RadioButtonDM1No.Checked = True
        ElseIf RadioButtonDM2No.Checked And RadioButtonDM1Si.Checked = False Then
            TableLayoutPanelDM1.Enabled = True
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDM1, True)
        End If
    End Sub

    'Private Sub RadioButtonDM1No_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDM1No.CheckedChanged
    ' Mostra i dettagli solo se "Sì" è selezionato
    '   ResetAndDisableControls(RadioButtonDM1Si.Checked, TableLayoutPanelDM2)
    '   TableLayoutPanelDM2.BackColor = Theme.SecondaryPanelActiveBackgroundColor
    'End Sub

    'Private Sub RadioButtonDM2No_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDM2No.CheckedChanged
    ' Mostra i dettagli solo se "Sì" è selezionato
    '    ResetAndDisableControls(RadioButtonDM2Si.Checked, TableLayoutPanelDM1)
    '    TableLayoutPanelDM1.BackColor = Theme.SecondaryPanelActiveBackgroundColor
    'End Sub

    ' Gestione abilitazione campi diabete
    '  Private Sub RadioButtonDiabete_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDM1Si.CheckedChanged, RadioButtonDM2Si.CheckedChanged
    '      ' Sì su DM1 o DM2 forza la selezione No sull'altro
    '      If RadioButtonDM1Si.Checked Then
    '
    '        End If
    '
    '        If RadioButtonDM2Si.Checked Then
    '            RadioButtonDM1No.Checked = True
    '    End If
    '    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True
        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelAnPatRem)

        ' Verifico se sono state effettuate tutte le
        ' Ambito ginecologico
        Dim result = ValidateMultipleGroups(TableLayoutPanelAnPatRem)

        Dim invalidGroups = result.InvalidGroups

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HilightInvalidGroups(invalidGroups.ToArray())
            esito = False
        End If

        Return esito
    End Function

    Private Async Function CercaAnamnesiAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idPaziente = main.IDPazienteSelezionato

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM AnamnesiPatologicaRemota WHERE ID_Anagrafica = @idAnagrafica"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idAnagrafica", idPaziente)
        }
        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' anamnesi patologica remota esistente

            Dim dettagliAnamnesi As DataRow = dtCheck.Rows(0)

            If Not appenaSalvati Then
                main.MostraToast("Anamnesi patologica remota esistente per il paziente selezionato. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            ' Endometriosi
            If dettagliAnamnesi("Endometriosi") Then
                MetroToggleEndometriosi.Checked = True
            Else
                MetroToggleEndometriosi.Checked = False
            End If

            'Fibromialgie
            If dettagliAnamnesi("Fibromialgie") Then
                MetroToggleFibromialgie.Checked = True
            Else
                MetroToggleFibromialgie.Checked = False
            End If

            'Colon irritabile
            If dettagliAnamnesi("ColonIrritabile") Then
                MetroToggleColonIrr.Checked = True
            Else
                MetroToggleColonIrr.Checked = False
            End If

            'Vescica iperattiva
            If dettagliAnamnesi("VescicaIperattiva") Then
                MetroToggleVescIperatt.Checked = True
            Else
                MetroToggleVescIperatt.Checked = False
            End If

            'Vescica dolorosa
            If dettagliAnamnesi("SindromeVescicaDolorosa") Then
                MetroToggleVescDol.Checked = True
            Else
                MetroToggleVescDol.Checked = False
            End If

            'IVU
            If dettagliAnamnesi("IVU") Then
                MetroToggleIVU.Checked = True
            Else
                MetroToggleIVU.Checked = False
            End If

            'Celiachia
            If dettagliAnamnesi("Celiachia") Then
                RadioButtonCeliachiaSi.Checked = True
            Else
                RadioButtonCeliachiaNo.Checked = True
            End If

            'Intolleranza al lattosio
            If dettagliAnamnesi("IntolleranzaLattosio") Then
                RadioButtonIntollLattSi.Checked = True
            Else
                RadioButtonIntollLattNo.Checked = True
            End If

            'Diabete mellito 1
            If dettagliAnamnesi("DM1") Then
                RadioButtonDM1Si.Checked = True
            Else
                RadioButtonDM1No.Checked = True
            End If

            'Diabete mellito 2
            If dettagliAnamnesi("DM2") Then
                RadioButtonDM2Si.Checked = True
            Else
                RadioButtonDM2No.Checked = True
            End If
        Else
            esiste = False
            PulisciCampi(TableLayoutPanelAnPatRem)
        End If

        Return esiste
    End Function

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idPaziente = main.IDPazienteSelezionato

            Dim successo As Boolean = True

            Dim endometriosi As Boolean = MetroToggleEndometriosi.Checked
            Dim fibromialgie As Boolean = MetroToggleFibromialgie.Checked
            Dim colonIrr As Boolean = MetroToggleColonIrr.Checked
            Dim vescicaIperatt As Boolean = MetroToggleVescIperatt.Checked
            Dim ivu As Boolean = MetroToggleIVU.Checked
            Dim sindromeVescDol As Boolean = MetroToggleVescDol.Checked
            Dim celiachia As Boolean = RadioButtonCeliachiaSi.Checked
            Dim intollLattosio As Boolean = RadioButtonIntollLattSi.Checked
            Dim dm1 As Boolean = RadioButtonDM1Si.Checked
            Dim dm2 As Boolean = RadioButtonDM2Si.Checked

            ' TODO
            Try
                Dim queryAnamnesiPatRem As String = ""

                If esiste Then
                    queryAnamnesiPatRem = "UPDATE AnamnesiPatologicaRemota SET 
                                                          Endometriosi = @endometriosi,
                                                          Fibromialgie = @fibromialgie,
                                                          ColonIrritabile = @colonIrr,
                                                          VescicaIperattiva = @vescicaIperatt,
                                                          IVU = @ivu,
                                                          SindromeVescicaDolorosa = @sindromeVescDol,
                                                          Celiachia = @celiachia,
                                                          IntolleranzaLattosio = @intollLattosio,
                                                          DM1 = @dm1,
                                                          DM2 = @dm2
                                                          WHERE ID_Anagrafica = @IDAnagrafica"
                Else
                    queryAnamnesiPatRem = "INSERT INTO AnamnesiPatologicaRemota (
                                                        ID_Anagrafica,
                                                        Endometriosi,
                                                        Fibromialgie,
                                                        ColonIrritabile,
                                                        VescicaIperattiva,
                                                        IVU,
                                                        SindromeVescicaDolorosa,
                                                        Celiachia,
                                                        IntolleranzaLattosio,
                                                        DM1,
                                                        DM2
                                                        ) VALUES (
                                                        @IDAnagrafica,
                                                        @endometriosi,
                                                        @fibromialgie,
                                                        @colonIrr,
                                                        @vescicaIperatt,
                                                        @ivu,
                                                        @sindromeVescDol,
                                                        @celiachia,
                                                        @intollLattosio,
                                                        @dm1,
                                                        @dm2)"
                End If

                Dim parametriAnamnesiPatRem As New List(Of SqlParameter) From {
                New SqlParameter("@IDAnagrafica", idPaziente),
                New SqlParameter("@endometriosi", endometriosi),
                New SqlParameter("@fibromialgie", fibromialgie),
                New SqlParameter("@colonIrr", colonIrr),
                New SqlParameter("@vescicaIperatt", vescicaIperatt),
                New SqlParameter("@ivu", ivu),
                New SqlParameter("@sindromeVescDol", sindromeVescDol),
                New SqlParameter("@celiachia", celiachia),
                New SqlParameter("@intollLattosio", intollLattosio),
                New SqlParameter("@dm1", dm1),
                New SqlParameter("@dm2", dm2)
            }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryAnamnesiPatRem, parametriAnamnesiPatRem) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Anamnesi patologica remota aggiornata correttamente.")
                    Else
                        main.MostraToast("Anamnesi patologica remota salvata correttamente.")
                    End If
                Else
                    main.MostraToast("Errore imprevisto durante il salvataggio dei dati.")
                    esito = False
                End If
            Catch ex As Exception
                MessageBox.Show("Errore imprevisto: " & ex.Message)
                esito = False
            End Try
        Else
            esito = False
        End If

        Return esito
    End Function

    Private Async Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Disabilito tutti i controlli
        TableLayoutPanelAnPatRem.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelAnPatRem.Enabled = True
        If esito Then
            appenaSalvati = True

            TableLayoutPanelAnPatRem.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            Dim result = Await CercaAnamnesiAsync()

            TableLayoutPanelAnPatRem.Enabled = True
        End If
    End Sub
End Class
