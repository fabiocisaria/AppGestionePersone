Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.Data.SqlClient
Public Class VisitaSintomiNew
    Dim idVisita As Integer = -1
    Dim tipoVisita As String = ""

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

    Private Async Sub FormVisitaSintomi_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioAutoCheck(True, TableLayoutPanelVisitaSintomi)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata

            ' Cerco se esistono già sintomi per la visita selezionata
            TableLayoutPanelVisitaSintomi.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelVisitaSintomi.Enabled = True

            'If Not esiste Then
            PulisciCampi(TableLayoutPanelVisitaSintomi)
            ResetAndDisableControls(False, TableLayoutPanelVVDModInsor)
            ResetAndDisableControls(False, TableLayoutPanelVVDAndam)
            ResetAndDisableControls(False, TableLayoutPanelVVDDistrib)

            ResetAndDisableControls(False, TableLayoutPanelAlvoStipsi)
            ResetAndDisableControls(False, TableLayoutPnlAlvoDiarr)
            ResetAndDisableControls(False, TableLayoutPanelAlvoAltrn)

            ResetAndDisableControls(False, TableLayoutPanelDispLoc)

            ThemeManager.SetSecondaryPanelState(TableLayoutPanelVVDModInsor, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelVVDAndam, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelVVDDistrib, False)

            'PanelModInsorg.Invalidate()
            'PanelVVDAndam.Invalidate()
            'PanelVVDDistr.Invalidate()

            ThemeManager.SetSecondaryPanelState(TableLayoutPanelAlvoStipsi, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPanelAlvoAltrn, False)
            ThemeManager.SetSecondaryPanelState(TableLayoutPnlAlvoDiarr, False)

            ThemeManager.SetSecondaryPanelState(TableLayoutPanelDisp, False)
            'End If
        End If
    End Sub

    Public Async Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata

            ' Cerco se esistono già sintomi per la visita selezionata
            TableLayoutPanelVisitaSintomi.Enabled = False

            If Not appenaSalvati Then
                main.MostraToast("Caricamento in corso ...")
            End If

            esiste = Await CercaVisitaAsync()

            TableLayoutPanelVisitaSintomi.Enabled = True

            If Not esiste Then
                PulisciCampi(TableLayoutPanelVisitaSintomi)
            End If
        End If
    End Sub

    Private Sub RadioButtonVVDSi_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggleVVDSiNo.CheckedChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        ResetAndDisableControls(MetroToggleVVDSiNo.Checked, TableLayoutPanelVVDModInsor)
        ResetAndDisableControls(MetroToggleVVDSiNo.Checked, TableLayoutPanelVVDAndam)
        ResetAndDisableControls(MetroToggleVVDSiNo.Checked, TableLayoutPanelVVDDistrib)

        ThemeManager.SetSecondaryPanelState(TableLayoutPanelVVDModInsor, MetroToggleVVDSiNo.Checked)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelVVDAndam, MetroToggleVVDSiNo.Checked)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelVVDDistrib, MetroToggleVVDSiNo.Checked)
    End Sub

    Private Sub RadioButtonAlvoSi_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggleAlvoSiNo.CheckedChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        ResetAndDisableControls(MetroToggleAlvoSiNo.Checked, TableLayoutPanelAlvoStipsi)
        ResetAndDisableControls(MetroToggleAlvoSiNo.Checked, TableLayoutPnlAlvoDiarr)
        ResetAndDisableControls(MetroToggleAlvoSiNo.Checked, TableLayoutPanelAlvoAltrn)

        ThemeManager.SetSecondaryPanelState(TableLayoutPanelAlvoStipsi, MetroToggleAlvoSiNo.Checked)
        ThemeManager.SetSecondaryPanelState(TableLayoutPnlAlvoDiarr, MetroToggleAlvoSiNo.Checked)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelAlvoAltrn, MetroToggleAlvoSiNo.Checked)
    End Sub

    Private Sub MetroToggleAttSess_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggleAttSess.CheckedChanged
        ResetAndDisableControls(MetroToggleAttSess.Checked, TableLayoutPanelDisp)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelDisp, MetroToggleAttSess.Checked)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelDispMarinoff, MetroToggleAttSess.Checked)

        ' Lascio disattiva la selezione della localizzazione perché non è ancora stato selezionato Marinoff
        ResetAndDisableControls(False, TableLayoutPanelDispLoc)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelDispLoc, False)
    End Sub

    Private Sub RadioButtonDispMarin0_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDispMarin0.CheckedChanged
        ' Nasconde i dettagli solo se viene selezionato 0
        ResetAndDisableControls(RadioButtonDispMarin1.Checked Or RadioButtonDispMarin2.Checked Or RadioButtonDispMarin3.Checked, TableLayoutPanelDispLoc)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelDispLoc, False)
    End Sub

    Private Sub RadioButtonDispMarinNot0_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDispMarin1.CheckedChanged, RadioButtonDispMarin2.CheckedChanged, RadioButtonDispMarin3.CheckedChanged
        ' Mostra il GroupBox dei dettagli solo se uno dei tre è selezionato
        ResetAndDisableControls(RadioButtonDispMarin1.Checked Or RadioButtonDispMarin2.Checked Or RadioButtonDispMarin3.Checked, TableLayoutPanelDispLoc)
        ThemeManager.SetSecondaryPanelState(TableLayoutPanelDispLoc, True)
    End Sub

    ' Da verificare (la quesry non si avvia se non ho selezionato tutto)
    Private Function CheckSelezione() As Boolean
        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelVisitaSintomi)

        ' Verifico se sono state effettuate tutte le scelte
        Dim result = ValidateMultipleGroups(TableLayoutPanelVisitaSintomi)

        Dim invalidGroups = result.InvalidGroups

        ' Se "Presenza VVD = No", rimuovo i gruppi collegati dai controlli obbligatori
        If Not MetroToggleVVDSiNo.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelVVDModInsor OrElse
                                                            gb Is TableLayoutPanelVVDInsorg OrElse
                                                            gb Is TableLayoutPanelVVDAndam OrElse
                                                            gb Is TableLayoutPanelVVDAndamSiNo OrElse
                                                            gb Is TableLayoutPanelVVDDistrib OrElse
                                                            gb Is TableLayoutPanelVVDDistr)).ToList()
        End If

        If Not MetroToggleAttSess.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelDisp OrElse
                                                            gb Is TableLayoutPanelDispMarinoff OrElse
                                                            gb Is TableLayoutPanelDispMarin OrElse
                                                            gb Is TableLayoutPanelDispLoc)).ToList()
        ElseIf RadioButtonDispMarin0.Checked Then
            ' Se "Disp Marinof = 0", rimuovo i gruppi collegati dai controlli obbligatori
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelDispLoc)).ToList()
        End If



        ' Se "Presenza Alvo = No", rimuovo i gruppi collegati dai controlli obbligatori
        If Not MetroToggleAlvoSiNo.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelAlvoStipsi OrElse
                                                            gb Is TableLayoutPanelAlveoStipsi OrElse
                                                            gb Is TableLayoutPanelAlvoAltrn OrElse
                                                            gb Is TableLayoutPanelAlvoAlterno OrElse
                                                            gb Is TableLayoutPnlAlvoDiarr OrElse
                                                            gb Is TableLayoutPanelAlvoDiarr)).ToList()
        End If

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HilightInvalidGroups(invalidGroups.ToArray())
            Return False
        Else
            Return True
        End If
    End Function

    Private Async Function CercaVisitaAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata
        tipoVisita = main.TipoVisitaSelezionata

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM VisitaSintomi WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' sintomi esistenti per la visita selezionata

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)
            If Not appenaSalvati Then
                main.MostraToast("Sintomi esistenti per la visita selezionata. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            ' Vulvodinia
            If dettagliVisita("VulvodiniaPresente") Then
                MetroToggleVVDSiNo.Checked = True
            Else
                MetroToggleVVDSiNo.Checked = False
            End If

            If MetroToggleVVDSiNo.Checked Then
                ' Modalità insorgenza
                If dettagliVisita("VulvodiniaModalita") = "Spontanea" Then
                    RadioButtonVVDSpont.Checked = True
                ElseIf dettagliVisita("VulvodiniaModalita") = "Provocata" Then
                    RadioButtonVVDProv.Checked = True
                End If

                ' Andamento
                If dettagliVisita("VulvodiniaAndamento") = "Continua" Then
                    RadioButtonVVDCont.Checked = True
                ElseIf dettagliVisita("VulvodiniaAndamento") = "Intermittente" Then
                    RadioButtonVVDInterm.Checked = True
                End If

                ' Distribuzione
                If dettagliVisita("VulvodiniaDistrib") = "Generalizzata" Then
                    RadioButtonVVDGener.Checked = True
                ElseIf dettagliVisita("VulvodiniaDistrib") = "Localizzata" Then
                    RadioButtonVVDLoc.Checked = True
                End If
            End If

            ' LUTS
            If dettagliVisita("LUTS") = "No" Then
                RadioButtonLutsNo.Checked = True
            ElseIf dettagliVisita("LUTS") = "A volte" Then
                RadioButtonLutsAVolte.Checked = True
            ElseIf dettagliVisita("LUTS") = "Sempre" Then
                RadioButtonLutsSempre.Checked = True
            End If

            ' Vaginiti ricorrenti
            If dettagliVisita("VaginitiRicorr") Then
                MetroToggleVaginitiSiNo.Checked = True
            Else
                MetroToggleVaginitiSiNo.Checked = False
            End If

            ' Cistiti ricorrenti
            If dettagliVisita("CistitiRicorr") Then
                MetroToggleCistRic.Checked = True
            Else
                MetroToggleCistRic.Checked = False
            End If

            ' Attività sessuale
            If dettagliVisita("SessualmenteAttiva") Then
                MetroToggleAttSess.Checked = True
            Else
                MetroToggleAttSess.Checked = False
            End If

            If MetroToggleAttSess.Checked Then
                ' Disparenuria
                ' Marinoff
                Select Case dettagliVisita("DispareuniaMarinoff")
                    Case 0
                        RadioButtonDispMarin0.Checked = True
                    Case 1
                        RadioButtonDispMarin1.Checked = True
                    Case 2
                        RadioButtonDispMarin2.Checked = True
                    Case 3
                        RadioButtonDispMarin3.Checked = True
                End Select

                If Not RadioButtonDispMarin0.Checked Then
                    ' Localizzazione
                    If dettagliVisita("DispareuniaLoc") = "Superficiale" Then
                        RadioButtonDispLocS.Checked = True
                    ElseIf dettagliVisita("DispareuniaLoc") = "Profonda" Then
                        RadioButtonDispLocP.Checked = True
                    ElseIf dettagliVisita("DispareuniaLoc") = "Superficiale + Profonda" Then
                        RadioButtonDispLocSP.Checked = True
                    End If
                End If
            End If

            ' Alvo
            ' Presenza
            If dettagliVisita("AlvoPresenza") Then
                    MetroToggleAlvoSiNo.Checked = True
                Else
                    MetroToggleAlvoSiNo.Checked = False
                End If

                If MetroToggleAlvoSiNo.Checked Then
                    ' Stipsi
                    If dettagliVisita("AlvoStipsi") Then
                        RadioButtonAlvoStipsiSi.Checked = True
                    Else
                        RadioButtonAlvoStipsiNo.Checked = True
                    End If

                    ' Alvo alterno
                    If dettagliVisita("AlvoAlterno") Then
                        RadioButtonAlvoAltrnSi.Checked = True
                    Else
                        RadioButtonAlvoAltrnNo.Checked = True
                    End If

                    ' Alvo diarreico
                    If dettagliVisita("AlvoDiarroico") Then
                        RadioButtonAlvoDiarrSi.Checked = True
                    Else
                        RadioButtonAlvoDiarrNo.Checked = True
                    End If
                End If

                '  Dolore vescicale
                If dettagliVisita("DoloreVescicale") = "No" Then
                    RadioButtonDolVescNo.Checked = True
                ElseIf dettagliVisita("DoloreVescicale") = "A volte" Then
                    RadioButtonDolVescAvolte.Checked = True
                ElseIf dettagliVisita("DoloreVescicale") = "Sempre" Then
                    RadioButtonDolVescSempre.Checked = True
                End If

                Return esiste
            Else
                esiste = False
            PulisciCampi(TableLayoutPanelVisitaSintomi)
            Return esiste
        End If
    End Function


    ' Modificare Salva Dati per poter ricaricare la cartella se già esistente
    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idVisita = main.IDVisitaSelezionata

            Dim successo As Boolean = False

            Dim vvdPres As Boolean = MetroToggleVVDSiNo.Checked

            Dim vvdMod As Object = GetSelectedRadioText(TableLayoutPanelVVDModInsor)
            Dim vvdAnd As Object = GetSelectedRadioText(TableLayoutPanelVVDAndam)
            Dim vvdDistr As Object = GetSelectedRadioText(TableLayoutPanelVVDDistrib)

            Dim vagRic As Boolean = MetroToggleVaginitiSiNo.Checked

            Dim CistRic As Boolean = MetroToggleCistRic.Checked

            Dim sessAtt As Boolean = MetroToggleAttSess.Checked

            Dim dispMar As Object
            Dim dispLoc As Object

            If Not sessAtt Then
                ' Se non è sessualmente attiva, assegno DBNull ai campi relativi alla dispareunia
                dispMar = DBNull.Value
                dispLoc = DBNull.Value
            Else
                dispMar = GetSelectedRadioNumber(TableLayoutPanelDispMarin)
                dispLoc = GetSelectedRadioText(TableLayoutPanelDispLoc)
            End If

            Dim alvoPres As Boolean = MetroToggleAlvoSiNo.Checked

            Dim alvoStipsi As Object
            Dim alvoAltrn As Object
            Dim alvoDiarr As Object

            If Not alvoPres Then
                alvoStipsi = DBNull.Value
                alvoAltrn = DBNull.Value
                alvoDiarr = DBNull.Value
            Else
                alvoStipsi = RadioButtonAlvoStipsiSi.Checked
                alvoAltrn = RadioButtonAlvoAltrnSi.Checked
                alvoDiarr = RadioButtonAlvoDiarrSi.Checked
            End If

            Dim luts As String = GetSelectedRadioText(TableLayoutPanelLUTSDettagli)

            Dim dolVesc As String = GetSelectedRadioText(TableLayoutPanelDolVesc)

            Try
                Dim querySintomi As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    querySintomi = "UPDATE VisitaSintomi SET 
                                                           VulvodiniaPresente = @vvdPres,
                                                           VulvodiniaModalita = @vvdMod,
                                                           VulvodiniaAndamento = @vvdAnd,
                                                           VulvodiniaDistrib = @vvdDistr,
                                                           VaginitiRicorr = @vagRic,
                                                           CistitiRicorr = @cistRic,
                                                           SessualmenteAttiva = @sessAtt,
                                                           DispareuniaMarinoff = @dispMar,
                                                           DispareuniaLoc = @dispLoc,
                                                           AlvoPresenza = @alvoPres,
                                                           AlvoStipsi = @alvoStipsi,
                                                           AlvoAlterno = @alvoAltrn,
                                                           AlvoDiarroico = @alvoDiarr,
                                                           LUTS = @luts,
                                                           DoloreVescicale = @dolVesc
                                                           WHERE ID_Visita = @idVisita"
                Else
                    'Se non esiste, esegui l'inserimento
                    querySintomi = "INSERT INTO VisitaSintomi (
                                                    ID_Visita,
                                                    VulvodiniaPresente,
                                                    VulvodiniaModalita,
                                                    VulvodiniaAndamento,
                                                    VulvodiniaDistrib,
                                                    VaginitiRicorr,
                                                    CistitiRicorr,
                                                    SessualmenteAttiva,
                                                    DispareuniaMarinoff,
                                                    DispareuniaLoc,
                                                    AlvoPresenza,
                                                    AlvoStipsi,
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
                                                    @sessAtt,
                                                    @dispMar,
                                                    @dispLoc,
                                                    @alvoPres,
                                                    @alvoStipsi,
                                                    @alvoAltrn,
                                                    @alvoDiarr,
                                                    @luts,
                                                    @dolVesc)"
                End If

                Dim parametriSintomi As New List(Of SqlParameter) From {
                    New SqlParameter("@idVisita", idVisita),
                    New SqlParameter("@vvdPres", vvdPres),
                    New SqlParameter("@vvdMod", vvdMod),
                    New SqlParameter("@vvdAnd", vvdAnd),
                    New SqlParameter("@vvdDistr", vvdDistr),
                    New SqlParameter("@vagRic", vagRic),
                    New SqlParameter("@cistRic", CistRic),
                    New SqlParameter("@sessAtt", sessAtt),
                    New SqlParameter("@dispMar", dispMar),
                    New SqlParameter("@dispLoc", dispLoc),
                    New SqlParameter("@alvoPres", alvoPres),
                    New SqlParameter("@alvoStipsi", alvoStipsi),
                    New SqlParameter("@alvoAltrn", alvoAltrn),
                    New SqlParameter("@alvoDiarr", alvoDiarr),
                    New SqlParameter("@luts", luts),
                    New SqlParameter("@dolVesc", dolVesc)
                }

                If Await ConnessioneDB.EseguiNonQueryAsync(querySintomi, parametriSintomi) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Sintomi aggiornati correttamente.")
                    Else
                        main.MostraToast("Sintomi salvati correttamente.")
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

    Private Async Sub Inserici_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Disabilito tutti i controlli
        TableLayoutPanelVisitaSintomi.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelVisitaSintomi.Enabled = True
        If esito Then
            appenaSalvati = True
            TableLayoutPanelVisitaSintomi.Enabled = False

            'main.MostraToast("Caricamento in corso ...")
            Dim result = Await CercaVisitaAsync()
            TableLayoutPanelVisitaSintomi.Enabled = True
        Else
            appenaSalvati = False
            main.MostraToast("Errore durante il salvataggio ..." & vbCrLf & "Compila correttamente tutti i campi")
        End If
    End Sub

End Class
