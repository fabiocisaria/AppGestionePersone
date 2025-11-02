Imports Microsoft.Data.SqlClient

Public Class UC_AnamnesiFamiliare
    Public Property idParenteSelezionato As Integer
    Public Property idAnamnesiFamiliareSelezionata As Integer

    Private menuPatologie As ContextMenuStrip

    Private _aggiornamentoInterno As Boolean = False

    Dim idPaziente As Integer = -1
    'Dim idParente As Integer = -1
    'Dim idAnamnesi As Integer = -1
    Dim patologiePresenti As Boolean = False
    Dim patologiePresenti_old As Boolean = False

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo

        FlowLayoutPanelPatologie.BackColor = Color.White
        FlowLayoutPanelPatologie.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanelPatologie.Padding = New Padding(5)

        TableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single

        ' Inizializza context menu
        InizializzaContextMenuPatologia()
    End Sub

    Private Async Sub UC_AnamnesiFamiliare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idPaziente = main.IDPazienteSelezionato

            TableLayoutPanelAnmFam.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaAnamnesiAsync()

            TableLayoutPanelAnmFam.Enabled = True

            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnmFam)
            End If
        End If
    End Sub

    Public Async Sub AggiornaDatiAsync()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idPaziente = main.IDPazienteSelezionato

            TableLayoutPanelAnmFam.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaAnamnesiAsync()

            TableLayoutPanelAnmFam.Enabled = True
            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnmFam)
            End If
        End If
    End Sub

    Private Async Function CercaPatologieAsync() As Task(Of List(Of (ID As Integer, Nome As String)))
        Dim sql As String = "SELECT p.ID, p.NomePatologia 
                         FROM AnamnesiFamiliarePatologie afp
                         INNER JOIN Patologie p ON afp.ID_Patologia = p.ID
                         WHERE afp.ID_AnamnesiFamiliare = @idAnamnesiFamiliare"

        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@idAnamnesiFamiliare", idAnamnesiFamiliareSelezionata)
        }

        Dim dt As DataTable = Await ConnessioneDB.EseguiQueryAsync(sql, param)
        Dim lista As New List(Of (Integer, String))
        For Each row As DataRow In dt.Rows
            lista.Add((CInt(row("ID")), row("NomePatologia").ToString()))
        Next

        Return lista
    End Function

    Private Async Function CercaAnamnesiAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri del paziente e del familiare selezionati
        idPaziente = main.IDPazienteSelezionato

        'Verifica che non esista già l'anamnesi familiare per il parente selezionato
        Dim checkQuery As String = "SELECT * FROM AnamnesiFamiliare WHERE ID = @idAnamnesiFamiliareSelezionata"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idAnamnesiFamiliareSelezionata", idAnamnesiFamiliareSelezionata)
        }
        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        Dim dettagliAnamnesi As DataRow

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' anamnesi patologica remota esistente

            dettagliAnamnesi = dtCheck.Rows(0)

            If dettagliAnamnesi("PresenzaPatologie") Then
                patologiePresenti = True
                patologiePresenti_old = True
            Else
                patologiePresenti = False
                patologiePresenti_old = False
            End If

            '===================
            'Patologie
            '===================
            FlowLayoutPanelPatologie.Enabled = False
            Dim patologie As List(Of (ID As Integer, Nome As String)) = Await CercaPatologieAsync()
            FlowLayoutPanelPatologie.Enabled = True

            If patologie IsNot Nothing AndAlso patologie.Count > 0 Then
                patologiePresenti = True

                ' Carico le malattie nel flow panel
                For Each t In patologie
                    CaricaPatologiePanel(t.ID, t.Nome)
                Next
            End If
        End If

        Return esiste
    End Function

    Private Sub CaricaPatologiePanel(id As Integer, nomePatologia As String)
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelPatologie.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then Return
        Next

        Dim lbl As New Label With {
            .Text = nomePatologia, ' Mostro solo il nome della patologia
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
                                       FlowLayoutPanelPatologie.Controls.Remove(panel)
                                       panel.Dispose()
                                       ' Rimuovo dal DB
                                       Await RimuoviPatologia(id)
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
        AddHandler tlp.MouseDown, AddressOf Patologia_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) Patologia_RightClick(panel, e)

        FlowLayoutPanelPatologie.Controls.Add(panel)
    End Sub

    Private Async Function AggiungiPatologiaAsync(id As Integer, nomePatologia As String) As Task
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelPatologie.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then Return
        Next

        Dim lbl As New Label With {
            .Text = nomePatologia, ' Mostro solo il nome della terapia
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
                                       FlowLayoutPanelPatologie.Controls.Remove(panel)
                                       panel.Dispose()
                                       ' Rimuovo dal DB
                                       Await RimuoviPatologia(id)
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
        AddHandler tlp.MouseDown, AddressOf Patologia_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) Patologia_RightClick(panel, e)

        Try
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

            Dim insertQuery As String = "INSERT INTO AnamnesiFamiliarePatologie (
                                                    ID_AnamnesiFamiliare,
                                                    ID_Patologia) VALUES(
                                                    @idAnamnesi,
                                                    @idPatologia)"
            Dim insertParam As New List(Of SqlParameter) From {
                New SqlParameter("@idAnamnesi", idAnamnesiFamiliareSelezionata),
                New SqlParameter("@idPatologia", id)
            }
            Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(insertQuery, insertParam)

            If esito Then
                main.MostraToast("Patologia aggiunta correttamente all'anamnesi familiare.")
                FlowLayoutPanelPatologie.Controls.Add(panel)
            Else
                main.MostraToast("Errore nell'aggiunta della patologia.")
            End If

            Await UpdatePatologiePresenti()
        Catch ex As Exception
            MessageBox.Show("Errore durante l'aggiunta della patologia: " & ex.Message)
        End Try
    End Function

    Private Async Function RimuoviPatologia(idPatologia As Integer) As Task
        Try
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

            Dim removeQuery As String = "DELETE FROM AnamnesiFamiliarePatologie
                                         WHERE ID_Patologia = @idPatologia
                                         AND ID_AnamnesiFamiliare = @idAnamnesi"

            Dim removeParam As New List(Of SqlParameter) From {
                New SqlParameter("@idAnamnesi", idAnamnesiFamiliareSelezionata),
                New SqlParameter("@idPatologia", idPatologia)
            }
            Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(removeQuery, removeParam)

            If esito Then
                main.MostraToast("Patologia rimossa correttamente dall'anamnesi familiare.")
            Else
                main.MostraToast("Errore nella rimozione della patologia.")
            End If

            Await UpdatePatologiePresenti()
        Catch ex As Exception
            MessageBox.Show("Errore nella rimozione della patologia: " & ex.Message)
        End Try
    End Function

    Private Sub RimuoviPatologiaDalFlowPanel(id As Integer)
        For Each pnl As Panel In FlowLayoutPanelPatologie.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then
                FlowLayoutPanelPatologie.Controls.Remove(pnl)
                pnl.Dispose()
                Exit For
            End If
        Next
    End Sub

    Private Sub Patologia_RightClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Or e.Button = MouseButtons.Left Then
            Dim panel As Panel = CType(sender, Panel)
            ' Mostra il menu contestuale
            menuPatologie.Tag = panel ' memorizzo il pannello da rimuovere
            menuPatologie.Show(panel, e.Location)
        End If
    End Sub

    Private Sub InizializzaContextMenuPatologia()
        menuPatologie = New ContextMenuStrip()
        Dim itemRimuovi As New ToolStripMenuItem("Rimuovi")
        AddHandler itemRimuovi.Click, AddressOf RimuoviPatologia_Click
        menuPatologie.Items.Add(itemRimuovi)
    End Sub

    Private Async Sub RimuoviPatologia_Click(sender As Object, e As EventArgs)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim menu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim menuStrip As ContextMenuStrip = CType(menu.Owner, ContextMenuStrip)
        Dim panel As Panel = CType(menuStrip.Tag, Panel)

        Dim idPatologia As Integer = CInt(panel.Tag)

        If panel.Tag Is Nothing Then
            main.MostraToast("Errore durante la rimozione della patologia.")
        Else
            Try
                ' Rimuovo la terapia riabilitativa dalla UI
                FlowLayoutPanelPatologie.Controls.Remove(panel)
                panel.Dispose()

                ' Rimuovo la terapia riabilitativa dal DB
                Await RimuoviPatologia(idPatologia)
            Catch ex As Exception
                main.MostraToast("Errore durante la rimozione dal database: " & ex.Message)
            End Try
        End If
    End Sub

    Private Async Sub SfButtonAggiungiPatologie_Click(sender As Object, e As EventArgs) Handles SfButtonAggiungiPatologie.Click
        ' Creo la form
        Dim frm As New FormSelezione()

        frm.Visible = False

        ' Estraggo la lista di farmaci
        Dim queryPatologie As String = "SELECT * FROM Patologie ORDER BY NomePatologia"
        Dim dtPatologie As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryPatologie)

        ' Estraggo i farmaci già associati alla presente terapia
        Dim queryAnamnesiFamiliarePatologie As String = "SELECT ID_Patologia FROM AnamnesiFamiliarePatologie
                                                  WHERE ID_AnamnesiFamiliare = @idAnamnesi"
        Dim paramAnamnesiFamiliarePatologie As New List(Of SqlParameter) From {
            New SqlParameter("@idAnamnesi", idAnamnesiFamiliareSelezionata)
        }
        Dim dtAnamnesiFamiliarePatologie As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryAnamnesiFamiliarePatologie, paramAnamnesiFamiliarePatologie)

        Dim selezionatiOld As New List(Of Integer)

        For Each row As DataRow In dtAnamnesiFamiliarePatologie.Rows
            If row("ID_Patologia") IsNot DBNull.Value Then
                selezionatiOld.Add(Convert.ToInt32(row("ID_Patologia")))
            End If
        Next


        ' Recupero farmaci dal DB
        frm.PopolaGriglia(dtPatologie, New List(Of String) From {"NomePatologia"}, selezionatiOld)

        ' Gestisco la selezione confermata
        AddHandler frm.OnSelezioneConfermata, Async Sub(patologieSelezionate)
                                                  ' -------------------------------
                                                  ' Rimuovo quelli che erano presenti ma ora deselezionati
                                                  ' -------------------------------
                                                  For Each idIniziale In selezionatiOld
                                                      If Not patologieSelezionate.Any(Function(f) f.ID = idIniziale) Then
                                                          Try
                                                              ' Rimuovo dal DB
                                                              Await RimuoviPatologia(idIniziale)
                                                              ' Rimuovo dal FlowPanel
                                                              RimuoviPatologiaDalFlowPanel(idIniziale)
                                                          Catch ex As Exception
                                                              MessageBox.Show($"Errore rimuovendo la patologia ID {idIniziale}: {ex.Message}")
                                                          End Try
                                                      End If
                                                  Next

                                                  ' -------------------------------
                                                  ' Aggiungo quelli nuovi
                                                  ' -------------------------------
                                                  For Each f In patologieSelezionate
                                                      If Not selezionatiOld.Contains(f.ID) Then
                                                          Await AggiungiPatologiaAsync(f.ID, f.Nome)
                                                      End If
                                                  Next
                                              End Sub
        ' Mostro la form come dialog
        frm.ShowDialog()

        ' Forzo il focus su un controllo neutro (può essere il form)
        Me.ActiveControl = Nothing
    End Sub

    Public Async Function CheckPatologiePresenti() As Task
        ' Controllo se ci sono malattie autoimmuni associate
        Dim malattie As List(Of (ID As Integer, Nome As String)) = Await CercaPatologieAsync()
        If malattie Is Nothing OrElse malattie.Count = 0 Then
            patologiePresenti = False
        Else
            patologiePresenti = True
        End If
    End Function

    Public Async Function UpdatePatologiePresenti() As Task
        Await CheckPatologiePresenti()

        If patologiePresenti <> patologiePresenti_old Then
            Try
                Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

                Dim queryAnamnesiFamiliare As String = "UPDATE AnamnesiFamiliare
                                                        SET PresenzaPatologie = @presenzaPatologie
                                                        WHERE ID = @idAnamnesiSelezionata;"

                Dim parametriAnamnesiFamiliare As New List(Of SqlParameter) From {
                      New SqlParameter("@idAnamnesiSelezionata", idAnamnesiFamiliareSelezionata),
                      New SqlParameter("@presenzaPatologie", patologiePresenti)
                }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryAnamnesiFamiliare, parametriAnamnesiFamiliare) > 0 Then
                    main.MostraToast("Patologie aggiornate correttamente")
                End If

                patologiePresenti_old = patologiePresenti
            Catch ex As Exception
                MessageBox.Show("Errore imprevisto: " & ex.Message)
            End Try
        End If
    End Function

    ' 🔹 Salva anamnesi
    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        'Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        'If selezioneOK Then
        'aggiorno la presenza di malattie autoimmuni
        Await CheckPatologiePresenti()

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        idPaziente = main.IDPazienteSelezionato

        Dim successo As Boolean = True

        Try
            Dim queryAnamnesiFamiliare As String = ""

            queryAnamnesiFamiliare = "UPDATE AnamnesiFamiliare SET 
                                      PresenzaPatologie = @presenzaPatologie
                                      WHERE ID = @idAnamnesiSelezionata"


            Dim parametriAnamnesiFamiliare As New List(Of SqlParameter) From {
                    New SqlParameter("@idAnamnesiSelezionata", idAnamnesiFamiliareSelezionata),
                    New SqlParameter("@presenzaPatologie", patologiePresenti)
                }

            If Await ConnessioneDB.EseguiNonQueryAsync(queryAnamnesiFamiliare, parametriAnamnesiFamiliare) > 0 Then
                successo = True
            End If

            If successo Then

                main.MostraToast("Anamnesi familiare aggiornata correttamente.")
            Else
                main.MostraToast("Errore imprevisto durante il salvataggio dei dati.")
                esito = False
            End If
        Catch ex As Exception
            MessageBox.Show("Errore imprevisto: " & ex.Message)
            esito = False
        End Try

        'Else
        'esito = False
        'End If

        Return esito
    End Function

    Private Async Sub btnSalva_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        TableLayoutPanel1.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanel1.Enabled = True

        If esito Then
            appenaSalvati = True

            TableLayoutPanel1.Enabled = True
            Dim result = Await CercaAnamnesiAsync()

            TableLayoutPanel1.Enabled = True
        End If
    End Sub
End Class