Imports Microsoft.Data.SqlClient
Public Class UC_AnamnesiPatologicaRemota
    Private menuMalattiaAutoimm As ContextMenuStrip

    Dim idPaziente As Integer = -1
    Dim idAnamnesi As Integer = -1
    Dim malattieAutoimmPresenti As Boolean = False
    Dim malattieAutoimmPresenti_old As Boolean = False

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo

        FlowLayoutPanelMalattieAutoimmuni.BackColor = Color.White
        FlowLayoutPanelMalattieAutoimmuni.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanelMalattieAutoimmuni.Padding = New Padding(5)

        TableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single

        ' Inizializza context menu
        InizializzaContextMenuMalattiaAutoimm()
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

    Private Async Function CercaMalattieAutoimmAsync(idAnamnesi As Integer) As Task(Of List(Of (ID As Integer, Nome As String)))
        Dim sql As String = "SELECT ma.ID, ma.NomeMalattia 
                         FROM AnamnesiPatRemMalattieAutoimm aprma
                         INNER JOIN MalattieAutoimmuni ma ON aprma.ID_Malattia = ma.ID
                         WHERE aprma.ID_Anamnesi = @IDAnamnesi"

        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@IDAnamnesi", idAnamnesi)
        }

        Dim dt As DataTable = Await ConnessioneDB.EseguiQueryAsync(sql, param)
        Dim lista As New List(Of (Integer, String))
        For Each row As DataRow In dt.Rows
            lista.Add((CInt(row("ID")), row("NomeMalattia").ToString()))
        Next

        Return lista
    End Function

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

        Dim dettagliAnamnesi As DataRow

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' anamnesi patologica remota esistente

            dettagliAnamnesi = dtCheck.Rows(0)
            idAnamnesi = CInt(dettagliAnamnesi("ID"))

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

            'Nevralgia del pudendo
            If dettagliAnamnesi("NevralgiaPudendo") Then
                MetroToggleNevPudendo.Checked = True
            Else
                MetroToggleNevPudendo.Checked = False
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

            'Distiroidismo
            If dettagliAnamnesi("Distiroidismo") Then
                MetroToggleDistiroidismo.Checked = True
            Else
                MetroToggleDistiroidismo.Checked = False
            End If

            'PatPsicologicaPsichiatrica
            If dettagliAnamnesi("PatPsicologicaPsichiatrica") Then
                MetroTogglePatPsic.Checked = True
            Else
                MetroTogglePatPsic.Checked = False
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

            If dettagliAnamnesi("PresenzaMalattieAutoimmuni") Then
                malattieAutoimmPresenti = True
                malattieAutoimmPresenti_old = True
            Else
                malattieAutoimmPresenti = False
                malattieAutoimmPresenti_old = False
            End If

            '===================
            'Malattie autoimmuni
            '===================
            FlowLayoutPanelMalattieAutoimmuni.Enabled = False
            Dim malattie As List(Of (ID As Integer, Nome As String)) = Await CercaMalattieAutoimmAsync(idAnamnesi)
            FlowLayoutPanelMalattieAutoimmuni.Enabled = True

            If malattie IsNot Nothing AndAlso malattie.Count > 0 Then
                malattieAutoimmPresenti = True

                ' Carico le malattie nel flow panel
                For Each t In malattie
                    CaricaMalattiaAutoimmPanel(t.ID, t.Nome)
                Next
            End If
        Else
            esiste = False

            malattieAutoimmPresenti = False
            malattieAutoimmPresenti_old = False

            Dim insertQuery As String = "INSERT INTO AnamnesiPatologicaRemota ( ID_Anagrafica,
                                                                                Endometriosi,
                                                                                Fibromialgie,
                                                                                ColonIrritabile,
                                                                                VescicaIperattiva,
                                                                                PatPsicologicaPsichiatrica,
                                                                                Distiroidismo,
                                                                                Celiachia,
                                                                                IntolleranzaLattosio,
                                                                                DM1,
                                                                                DM2,
                                                                                PresenzaMalattieAutoimmuni,
                                                                                NevralgiaPudendo) VALUES (
                                                                                @idPaziente,
                                                                                @Endometriosi,
                                                                                @Fibromialgie,
                                                                                @ColonIrritabile,
                                                                                @VescicaIperattiva,
                                                                                @patPsicologicaPsichiatrica,
                                                                                @distiroidismo,
                                                                                @Celiachia,
                                                                                @IntolleranzaLattosio,
                                                                                @dm1,
                                                                                @dm2,
                                                                                @malattieAutoimmPresenti,
                                                                                @nevralgiaPudendo)"
            Dim insertParam As New List(Of SqlParameter) From {
                New SqlParameter("@idPaziente", idPaziente),
                New SqlParameter("@endometriosi", False),
                New SqlParameter("@fibromialgie", False),
                New SqlParameter("@colonIrritabile", False),
                New SqlParameter("@vescicaIperattiva", False),
                New SqlParameter("@patPsicologicaPsichiatrica", False),
                New SqlParameter("@distiroidismo", False),
                New SqlParameter("@celiachia", False),
                New SqlParameter("@intolleranzaLattosio", False),
                New SqlParameter("@dm1", False),
                New SqlParameter("@dm2", False),
                New SqlParameter("@malattieAutoimmPresenti", False),
                New SqlParameter("@nevralgiaPudendo", False)
            }
            Dim dtInsertAnmPatRem As DataTable = Await ConnessioneDB.EseguiQueryAsync(insertQuery, insertParam)
            If dtInsertAnmPatRem.Rows.Count = 1 Then
                esiste = True
                dettagliAnamnesi = dtInsertAnmPatRem.Rows(0)
                idAnamnesi = dettagliAnamnesi("ID")
            End If
            main.MostraToast("Anamnesi creata correttamente per la visita corrente.")

            PulisciCampi(TableLayoutPanelAnPatRem)
        End If

        Return esiste
    End Function

    Private Sub CaricaMalattiaAutoimmPanel(id As Integer, nomeTerapiaRiabilitativa As String)
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelMalattieAutoimmuni.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then Return
        Next

        Dim lbl As New Label With {
            .Text = nomeTerapiaRiabilitativa, ' Mostro solo il nome della terapia
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .AutoSize = True,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Size = New Size(155, 45),
            .Anchor = AnchorStyles.None
        }

        Dim panel As New Panel With {
            .Size = New Size(195, 50),
            .Tag = id,
            .Margin = New Padding(3),
            .BackColor = Theme.MalattieAutoimmPanelBackColor, ' verde chiaro
            .Cursor = Cursors.Hand,
            .BorderStyle = BorderStyle.FixedSingle,
            .Padding = New Padding(5)
        }

        ' Creo il TableLayoutPanel
        Dim tlp As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 2,
            .RowCount = 1
        }
        tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))  ' Label occupa tutto lo spazio
        tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))  ' Pulsante fisso 25px
        tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100))

        Dim btnX As New Button() With {
            .Text = "X",
            .Font = New Font("Segoe UI", 8, FontStyle.Bold),
            .Size = New Size(25, 25),
            .ForeColor = Theme.MalattieAutoimmPanelForeColor,
            .BackColor = Theme.MalattieAutoimmPanelBackColor,
            .FlatStyle = FlatStyle.Flat,
            .Anchor = AnchorStyles.None
        }
        '.BackColor = Color.FromArgb(192, 57, 43),
        btnX.FlatAppearance.BorderSize = 0
        btnX.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnX.FlatAppearance.MouseDownBackColor = Color.Transparent

        AddHandler btnX.Click, Async Sub(s, e)
                                   Try
                                       ' Rimuovo dalla UI
                                       FlowLayoutPanelMalattieAutoimmuni.Controls.Remove(panel)
                                       panel.Dispose()
                                       ' Rimuovo dal DB
                                       Await RimuoviMalattiaAutoimm(id)
                                   Catch ex As Exception
                                       MessageBox.Show("Errore durante la rimozione: " & ex.Message)
                                   End Try
                               End Sub

        ' Aggiungo i controlli al TableLayoutPanel
        tlp.Controls.Add(lbl, 0, 0)
        tlp.Controls.Add(btnX, 1, 0)

        'panel.Controls.Add(btnX)
        'panel.Controls.Add(lbl)
        panel.Controls.Add(tlp)

        'lbl.AutoSize = False
        'lbl.Dock = DockStyle.Fill

        ' Effetto hover
        AddHandler tlp.MouseEnter, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelHoveredForeColor
                                   End Sub
        AddHandler tlp.MouseLeave, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                   End Sub
        AddHandler btnX.MouseEnter, Sub()
                                        lbl.ForeColor = Theme.MalattieAutoimmPanelHoveredForeColor
                                        btnX.ForeColor = Theme.MalattieAutoimmPanelDeleteForeColor

                                    End Sub
        AddHandler btnX.MouseLeave, Sub()
                                        lbl.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                        btnX.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                    End Sub
        AddHandler lbl.MouseEnter, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelHoveredForeColor
                                   End Sub
        AddHandler lbl.MouseLeave, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                   End Sub

        'Click con il destro
        AddHandler tlp.MouseDown, AddressOf MalattiaAutoimm_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) MalattiaAutoimm_RightClick(panel, e)

        FlowLayoutPanelMalattieAutoimmuni.Controls.Add(panel)
    End Sub

    Private Async Function AggiungiMalattiaAutoimmAsync(id As Integer, nomeMalattiaAutoimm As String) As Task
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelMalattieAutoimmuni.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then Return
        Next

        Dim lbl As New Label With {
            .Text = nomeMalattiaAutoimm, ' Mostro solo il nome della terapia
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .AutoSize = True,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Size = New Size(155, 45),
            .Anchor = AnchorStyles.None
        }

        Dim panel As New Panel With {
            .Size = New Size(195, 50),
            .Tag = id,
            .Margin = New Padding(3),
            .BackColor = Theme.MalattieAutoimmPanelBackColor, ' azzurro
            .Cursor = Cursors.Hand,
            .BorderStyle = BorderStyle.FixedSingle,
            .Padding = New Padding(5)
        }

        ' Creo il TableLayoutPanel
        Dim tlp As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .ColumnCount = 2,
            .RowCount = 1
        }
        tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))  ' Label occupa tutto lo spazio
        tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25))  ' Pulsante fisso 25px
        tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100))

        Dim btnX As New Button() With {
            .Text = "X",
            .Font = New Font("Segoe UI", 8, FontStyle.Bold),
            .Size = New Size(25, 25),
            .ForeColor = Theme.MalattieAutoimmPanelForeColor,
            .BackColor = Theme.MalattieAutoimmPanelBackColor,
            .FlatStyle = FlatStyle.Flat,
            .Anchor = AnchorStyles.None
        }
        '.BackColor = Color.FromArgb(192, 57, 43),
        btnX.FlatAppearance.BorderSize = 0
        btnX.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnX.FlatAppearance.MouseDownBackColor = Color.Transparent

        AddHandler btnX.Click, Async Sub(s, e)
                                   Try
                                       ' Rimuovo dalla UI
                                       FlowLayoutPanelMalattieAutoimmuni.Controls.Remove(panel)
                                       panel.Dispose()
                                       ' Rimuovo dal DB
                                       Await RimuoviMalattiaAutoimm(id)
                                   Catch ex As Exception
                                       MessageBox.Show("Errore durante la rimozione: " & ex.Message)
                                   End Try
                               End Sub

        ' Aggiungo i controlli al TableLayoutPanel
        tlp.Controls.Add(lbl, 0, 0)
        tlp.Controls.Add(btnX, 1, 0)

        'panel.Controls.Add(btnX)
        'panel.Controls.Add(lbl)
        panel.Controls.Add(tlp)

        'lbl.AutoSize = False
        'lbl.Dock = DockStyle.Fill

        ' Effetto hover
        AddHandler tlp.MouseEnter, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelHoveredForeColor
                                   End Sub
        AddHandler tlp.MouseLeave, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                   End Sub
        AddHandler btnX.MouseEnter, Sub()
                                        lbl.ForeColor = Theme.MalattieAutoimmPanelHoveredForeColor
                                        btnX.ForeColor = Theme.MalattieAutoimmPanelDeleteForeColor

                                    End Sub
        AddHandler btnX.MouseLeave, Sub()
                                        lbl.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                        btnX.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                    End Sub
        AddHandler lbl.MouseEnter, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelHoveredForeColor
                                   End Sub
        AddHandler lbl.MouseLeave, Sub()
                                       lbl.ForeColor = Theme.MalattieAutoimmPanelForeColor
                                   End Sub

        'Click con il destro
        AddHandler tlp.MouseDown, AddressOf MalattiaAutoimm_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) MalattiaAutoimm_RightClick(panel, e)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        Dim insertQuery As String = "INSERT INTO AnamnesiPatRemMalattieAutoimm (
                                                    ID_Anamnesi,
                                                    ID_Malattia) VALUES(
                                                    @idAnamnesi,
                                                    @idMalattiaAutoimm)"
        Dim insertParam As New List(Of SqlParameter) From {
            New SqlParameter("@idAnamnesi", idAnamnesi),
            New SqlParameter("@idMalattiaAutoimm", id)
        }
        Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(insertQuery, insertParam)

        If esito Then
            main.MostraToast("Malattia autoimmune aggiunta correttamente all'anamnesi patologica remota.")
            FlowLayoutPanelMalattieAutoimmuni.Controls.Add(panel)
        Else
            main.MostraToast("Errore nell'aggiunta della terapia riabilitativa.")
        End If
    End Function

    Private Async Function RimuoviMalattiaAutoimm(idMalattiaAutoimm As Integer) As Task
        Try
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

            Dim removeQuery As String = "DELETE FROM AnamnesiPatRemMalattieAutoimm
                                         WHERE ID_Malattia = @idMalattiaAutoimm
                                         AND ID_Anamnesi = @idAnamnesi"

            Dim removeParam As New List(Of SqlParameter) From {
                New SqlParameter("@idAnamnesi", idAnamnesi),
                New SqlParameter("@idMalattiaAutoimm", idMalattiaAutoimm)
            }
            Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(removeQuery, removeParam)

            If esito Then
                main.MostraToast("Malattia autoimmune rimossa correttamente dall'anamnesi patologica remota.")
            End If
        Catch ex As Exception
            MessageBox.Show("Errore nella rimozione della malattia autoimmune: " & ex.Message)
        End Try
    End Function

    Private Sub RimuoviMalattiaAutoimmDalFlowPanel(id As Integer)
        For Each pnl As Panel In FlowLayoutPanelMalattieAutoimmuni.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then
                FlowLayoutPanelMalattieAutoimmuni.Controls.Remove(pnl)
                pnl.Dispose()
                Exit For
            End If
        Next
    End Sub

    Private Sub MalattiaAutoimm_RightClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Or e.Button = MouseButtons.Left Then
            Dim panel As Panel = CType(sender, Panel)
            ' Mostra il menu contestuale
            menuMalattiaAutoimm.Tag = panel ' memorizzo il pannello da rimuovere
            menuMalattiaAutoimm.Show(panel, e.Location)
        End If
    End Sub

    Private Sub InizializzaContextMenuMalattiaAutoimm()
        menuMalattiaAutoimm = New ContextMenuStrip()
        Dim itemRimuovi As New ToolStripMenuItem("Rimuovi")
        AddHandler itemRimuovi.Click, AddressOf RimuoviMalattiaAutoimm_Click
        menuMalattiaAutoimm.Items.Add(itemRimuovi)
    End Sub

    Private Async Sub RimuoviMalattiaAutoimm_Click(sender As Object, e As EventArgs)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim menu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim menuStrip As ContextMenuStrip = CType(menu.Owner, ContextMenuStrip)
        Dim panel As Panel = CType(menuStrip.Tag, Panel)

        Dim idMalattia As Integer = CInt(panel.Tag)

        If panel.Tag Is Nothing Then
            main.MostraToast("Errore durante la rimozione della malattia autoimmune.")
        Else
            Try
                ' Rimuovo la terapia riabilitativa dalla UI
                FlowLayoutPanelMalattieAutoimmuni.Controls.Remove(panel)
                panel.Dispose()

                ' Rimuovo la terapia riabilitativa dal DB
                Await RimuoviMalattiaAutoimm(idMalattia)
            Catch ex As Exception
                main.MostraToast("Errore durante la rimozione dal database: " & ex.Message)
            End Try
        End If
    End Sub

    Private Async Sub SfButtonAggiungiMalattieAutoimmuni_Click(sender As Object, e As EventArgs) Handles SfButtonAggiungiMalattieAutoimmuni.Click
        ' Creo la form
        Dim frm As New FormSelezione()

        frm.Visible = False

        ' Estraggo la lista di farmaci
        Dim queryMalattiaAutoimm As String = "SELECT * FROM MalattieAutoimmuni ORDER BY NomeMalattia"
        Dim dtMalattiaAutoimm As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryMalattiaAutoimm)

        ' Estraggo i farmaci già associati alla presente terapia
        Dim queryAnmPatRemMalAutoimm As String = "SELECT ID_Malattia FROM AnamnesiPatRemMalattieAutoimm
                                                  WHERE ID_Anamnesi = @idAnamnesi"
        Dim paramAnmPatRemMalAutoimm As New List(Of SqlParameter) From {
            New SqlParameter("@idAnamnesi", idAnamnesi)
        }
        Dim dtAnmPatRemMalAutoimm As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryAnmPatRemMalAutoimm, paramAnmPatRemMalAutoimm)

        Dim selezionatiOld As New List(Of Integer)

        For Each row As DataRow In dtAnmPatRemMalAutoimm.Rows
            If row("ID_Malattia") IsNot DBNull.Value Then
                selezionatiOld.Add(Convert.ToInt32(row("ID_Malattia")))
            End If
        Next


        ' Recupero farmaci dal DB
        frm.PopolaGriglia(dtMalattiaAutoimm, New List(Of String) From {"NomeMalattia"}, selezionatiOld)

        ' Gestisco la selezione confermata
        AddHandler frm.OnSelezioneConfermata, Async Sub(malattieSelezionate)
                                                  ' -------------------------------
                                                  ' Rimuovo quelli che erano presenti ma ora deselezionati
                                                  ' -------------------------------
                                                  For Each idIniziale In selezionatiOld
                                                      If Not malattieSelezionate.Any(Function(f) f.ID = idIniziale) Then
                                                          Try
                                                              ' Rimuovo dal DB
                                                              Await RimuoviMalattiaAutoimm(idIniziale)
                                                              ' Rimuovo dal FlowPanel
                                                              RimuoviMalattiaAutoimmDalFlowPanel(idIniziale)
                                                          Catch ex As Exception
                                                              MessageBox.Show($"Errore rimuovendo malattia ID {idIniziale}: {ex.Message}")
                                                          End Try
                                                      End If
                                                  Next

                                                  ' -------------------------------
                                                  ' Aggiungo quelli nuovi
                                                  ' -------------------------------
                                                  For Each f In malattieSelezionate
                                                      If Not selezionatiOld.Contains(f.ID) Then
                                                          Await AggiungiMalattiaAutoimmAsync(f.ID, f.Nome)
                                                      End If
                                                  Next

                                                  checkMalattieAutoimmPresenti()

                                                  If malattieAutoimmPresenti <> malattieAutoimmPresenti_old Then
                                                      Try
                                                          Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

                                                          Dim queryAnamnesiPatRem As String = "UPDATE AnamnesiPatologicaRemota
                                                                                                SET PresenzaMalattieAutoimmuni = @malattieAutoimmPresenti
                                                                                                WHERE ID_Anagrafica = @idAnagrafica;"

                                                          Dim parametriAnamnesiPatRem As New List(Of SqlParameter) From {
                                                                New SqlParameter("@idAnagrafica", idPaziente),
                                                                New SqlParameter("@malattieAutoimmPresenti", malattieAutoimmPresenti)
                                                          }

                                                          If Await ConnessioneDB.EseguiNonQueryAsync(queryAnamnesiPatRem, parametriAnamnesiPatRem) > 0 Then
                                                              main.MostraToast("Malattie autoimmuni aggiornate correttamente")
                                                          End If

                                                          malattieAutoimmPresenti_old = malattieAutoimmPresenti
                                                      Catch ex As Exception
                                                          MessageBox.Show("Errore imprevisto: " & ex.Message)
                                                      End Try
                                                  End If
                                              End Sub

        ' Mostro la form come dialog
        frm.ShowDialog()

        ' Forzo il focus su un controllo neutro (può essere il form)
        Me.ActiveControl = Nothing
    End Sub

    Public Async Sub checkMalattieAutoimmPresenti()
        ' Controllo se ci sono malattie autoimmuni associate
        Dim malattie As List(Of (ID As Integer, Nome As String)) = Await CercaMalattieAutoimmAsync(idAnamnesi)
        If malattie Is Nothing OrElse malattie.Count = 0 Then
            malattieAutoimmPresenti = False
        Else
            malattieAutoimmPresenti = True
        End If
    End Sub

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            'aggiorno la presenza di malattie autoimmuni
            checkMalattieAutoimmPresenti()

            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idPaziente = main.IDPazienteSelezionato

            Dim successo As Boolean = True

            Dim endometriosi As Boolean = MetroToggleEndometriosi.Checked
            Dim fibromialgie As Boolean = MetroToggleFibromialgie.Checked
            Dim colonIrr As Boolean = MetroToggleColonIrr.Checked
            Dim vescicaIperatt As Boolean = MetroToggleVescIperatt.Checked
            Dim patPsicologicaPsichiatrica As Boolean = MetroTogglePatPsic.Checked
            Dim sindromeVescDol As Boolean = MetroToggleDistiroidismo.Checked
            Dim celiachia As Boolean = RadioButtonCeliachiaSi.Checked
            Dim intollLattosio As Boolean = RadioButtonIntollLattSi.Checked
            Dim dm1 As Boolean = RadioButtonDM1Si.Checked
            Dim dm2 As Boolean = RadioButtonDM2Si.Checked
            Dim nevralgiaPudendo As Boolean = MetroToggleNevPudendo.Checked

            ' TODO
            Try
                Dim queryAnamnesiPatRem As String = ""

                If esiste Then
                    queryAnamnesiPatRem = "UPDATE AnamnesiPatologicaRemota SET 
                                                          Endometriosi = @endometriosi,
                                                          Fibromialgie = @fibromialgie,
                                                          ColonIrritabile = @colonIrr,
                                                          VescicaIperattiva = @vescicaIperatt,
                                                          PatPsicologicaPsichiatrica = @patPsicologicaPsichiatrica,
                                                          Distiroidismo = @distiroidismo,
                                                          Celiachia = @celiachia,
                                                          IntolleranzaLattosio = @intollLattosio,
                                                          DM1 = @dm1,
                                                          DM2 = @dm2,
                                                          PresenzaMalattieAutoimmuni = @malattieAutoimmPresenti,
                                                          NevralgiaPudendo = @nevralgiaPudendo
                                                          WHERE ID_Anagrafica = @idAnagrafica"
                Else
                    queryAnamnesiPatRem = "INSERT INTO AnamnesiPatologicaRemota (
                                                        ID_Anagrafica,
                                                        Endometriosi,
                                                        Fibromialgie,
                                                        ColonIrritabile,
                                                        VescicaIperattiva,
                                                        PatPsicologicaPsichiatrica,
                                                        Distiroidismo,
                                                        Celiachia,
                                                        IntolleranzaLattosio,
                                                        DM1,
                                                        DM2,
                                                        PresenzaMalattieAutoimmuni,
                                                        NevralgiaPudendo
                                                        ) VALUES (
                                                        @idAnagrafica,
                                                        @endometriosi,
                                                        @fibromialgie,
                                                        @colonIrr,
                                                        @vescicaIperatt,
                                                        @patPsicologicaPsichiatrica,
                                                        @distiroidismo,
                                                        @celiachia,
                                                        @intollLattosio,
                                                        @dm1,
                                                        @dm2,
                                                        @malattieAutoimmPresenti,
                                                        @nevralgiaPudendo)"
                End If

                Dim parametriAnamnesiPatRem As New List(Of SqlParameter) From {
                    New SqlParameter("@idAnagrafica", idPaziente),
                    New SqlParameter("@endometriosi", endometriosi),
                    New SqlParameter("@fibromialgie", fibromialgie),
                    New SqlParameter("@colonIrr", colonIrr),
                    New SqlParameter("@vescicaIperatt", vescicaIperatt),
                    New SqlParameter("@patPsicologicaPsichiatrica", patPsicologicaPsichiatrica),
                    New SqlParameter("@sindromeVescDol", sindromeVescDol),
                    New SqlParameter("@celiachia", celiachia),
                    New SqlParameter("@intollLattosio", intollLattosio),
                    New SqlParameter("@dm1", dm1),
                    New SqlParameter("@dm2", dm2),
                    New SqlParameter("@malattieAutoimmPresenti", malattieAutoimmPresenti),
                    New SqlParameter("@malattieAutoimmPresenti", nevralgiaPudendo)
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
