Imports System.IO
Imports System.Runtime.CompilerServices
Imports Microsoft.Data.SqlClient

Public Class UC_Terapia
    Private menuFarmaco As ContextMenuStrip
    Private menuTerapiaRiabilitativa As ContextMenuStrip

    Dim idVisita As Integer = -1
    Dim tipoVisita As String = ""
    Dim idTerapia As Integer = -1
    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

        Me.BackColor = Theme.BackgroundColor
        TableLayoutPanel2.BackColor = Theme.BackgroundColor
        TableLayoutPanel3.BackColor = Theme.BackgroundColor
        TableLayoutPanelMiglioramenti.BackColor = Theme.BackgroundColor
        TableLayoutPanelTerapia.BackColor = Theme.BackgroundColor

        ' ====================
        ' SfButtons
        ' ====================
        With ButtonInserisci.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
            .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With

        With SfButtonAggiungiFarmaco.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
            .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With

        With SfButtonAggiungiTerapiaRiabilitativa.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
            .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With

        FlowLayoutPanelFarmaci.BackColor = Color.White
        FlowLayoutPanelFarmaci.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanelFarmaci.Padding = New Padding(5)

        FlowLayoutPanelTerapieRiabilitative.BackColor = Color.White
        FlowLayoutPanelTerapieRiabilitative.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanelTerapieRiabilitative.Padding = New Padding(5)

        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single

        ' Inizializza context menu
        InizializzaContextMenuFarmaco()
        InizializzaContextMenuTerapiaRiabilitativa()
        ' Associa pulsanti
    End Sub

    Private Async Sub FormTerapia_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata
            ' Cerco se esiste già una visita uro-ginecologica per la visita selezionata
            TableLayoutPanelTerapia.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelTerapia.Enabled = True

            If Not esiste Then
                PulisciCampi(TableLayoutPanelMiglioramenti)
            End If
        End If
    End Sub

    Public Async Sub AggiornaDatiAsync()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata

            TableLayoutPanelTerapia.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelTerapia.Enabled = True
            If Not esiste Then
                PulisciCampi(TableLayoutPanelMiglioramenti)
            End If
        End If
    End Sub

    Private Async Function CercaFarmaciAsync(idVisita As Integer) As Task(Of List(Of (ID As Integer, Nome As String)))
        Dim sql As String = "SELECT f.ID, f.NomeCommerciale 
                         FROM TerapiaFarmaci tf
                         INNER JOIN Farmaci f ON tf.ID_Farmaco = f.ID
                         WHERE tf.ID_Terapia = @IDTerapia"

        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@IDTerapia", idVisita)
        }

        Dim dt As DataTable = Await ConnessioneDB.EseguiQueryAsync(sql, param)
        Dim lista As New List(Of (Integer, String))
        For Each row As DataRow In dt.Rows
            lista.Add((CInt(row("ID")), row("NomeCommerciale").ToString()))
        Next

        Return lista
    End Function

    Private Async Function CercaTerapieRiabilitativeAsync(idVisita As Integer) As Task(Of List(Of (ID As Integer, Nome As String)))
        Dim sql As String = "SELECT tr.ID, tr.NomeTerapia 
                         FROM TerapiaTerapieRiabilitative ttr
                         INNER JOIN TerapieRiabilitative tr ON ttr.ID_TerapiaRiabilitativa = tr.ID
                         WHERE ttr.ID_Terapia = @IDTerapia"

        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@IDTerapia", idVisita)
        }

        Dim dt As DataTable = Await ConnessioneDB.EseguiQueryAsync(sql, param)
        Dim lista As New List(Of (Integer, String))
        For Each row As DataRow In dt.Rows
            lista.Add((CInt(row("ID")), row("NomeTerapia").ToString()))
        Next

        Return lista
    End Function

    Private Async Function CercaVisitaAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata
        tipoVisita = main.TipoVisitaSelezionata

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQueryTerapia As String = "SELECT * FROM Terapia WHERE ID_Visita = @idVisita"

        Dim checkParamTerapia As New List(Of SqlParameter) From {
            New SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheckTerapia As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQueryTerapia, checkParamTerapia)

        Dim dettagliTerapia As DataRow

        'Se esiste già una terapia carico i dati'
        If dtCheckTerapia.Rows.Count = 1 Then
            esiste = True ' Terapia esistente per la visita selezionata

            dettagliTerapia = dtCheckTerapia.Rows(0)
            idTerapia = dettagliTerapia("ID")

            If Not IsDBNull(dettagliTerapia("Miglioramenti")) Then
                Select Case dettagliTerapia("Miglioramenti")
                    Case "Nullo"
                        RadioButtonNullo.Checked = True
                    Case "Lieve"
                        RadioButtonLieve.Checked = True
                    Case "Notevole"
                        RadioButtonNotevole.Checked = True
                    Case "Asintomatico"
                        RadioButtonAsintomatico.Checked = True
                End Select
            End If

            If Not appenaSalvati Then
                main.MostraToast("Terapia esistente per la visita selezionata. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            '=======
            'Farmaci
            '=======
            FlowLayoutPanelFarmaci.Enabled = False
            Dim farmaci As List(Of (ID As Integer, Nome As String)) = Await CercaFarmaciAsync(idVisita)
            FlowLayoutPanelFarmaci.Enabled = True

            For Each f In farmaci
                CaricaFarmacoPanel(f.ID, f.Nome)
            Next

            '=====================
            'Terapie riabilitative
            '=====================
            FlowLayoutPanelTerapieRiabilitative.Enabled = False
            Dim terapie As List(Of (ID As Integer, Nome As String)) = Await CercaTerapieRiabilitativeAsync(idVisita)
            FlowLayoutPanelTerapieRiabilitative.Enabled = True

            For Each t In terapie
                CaricaTerapiaRiabilitativaPanel(t.ID, t.Nome)
            Next
            ' Se non esiste già una terapia la creo
        Else
            esiste = False
            Dim insertQuery As String = "INSERT INTO Terapia (ID_Visita) VALUES (@idVisita)"
            Dim insertParam As New List(Of SqlParameter) From {
                New SqlParameter("@idVisita", idVisita),
                New SqlParameter("Miglioramenti", DBNull.Value)
            }
            Dim dtInsertTerapia As DataTable = Await ConnessioneDB.EseguiQueryAsync(insertQuery, insertParam)
            If dtInsertTerapia.Rows.Count = 1 Then
                esiste = True
                dettagliTerapia = dtInsertTerapia.Rows(0)
                idTerapia = dettagliTerapia("ID")
            End If
            main.MostraToast("Terapia creata correttamente per la visita corrente.")
        End If
        Return esiste
    End Function

    Private Sub CaricaFarmacoPanel(id As Integer, nomeFarmaco As String)
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelFarmaci.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then Return
        Next

        Dim lbl As New Label With {
            .Text = nomeFarmaco, ' Mostra solo il nome del farmaco
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .AutoSize = True,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .MaximumSize = New Size(140, 0),
            .Anchor = AnchorStyles.None
        }

        Dim panel As New Panel With {
            .Size = New Size(180, 50),
            .Tag = id,
            .Margin = New Padding(3),
            .BackColor = Color.FromArgb(243, 156, 18), ' arancione chiaro
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
            .BackColor = Color.FromArgb(192, 57, 43),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Anchor = AnchorStyles.None
        }
        btnX.FlatAppearance.BorderSize = 0

        AddHandler btnX.Click, Sub(s, e)
                                   ' Rimuovo dalla UI
                                   FlowLayoutPanelFarmaci.Controls.Remove(panel)
                                   panel.Dispose()
                                   ' Rimuovo dal DB
                                   RimuoviFarmacoAsync(id)
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
        AddHandler panel.MouseEnter, Sub() panel.BackColor = Color.FromArgb(211, 84, 0)
        AddHandler panel.MouseLeave, Sub() panel.BackColor = Color.FromArgb(243, 156, 18)
        AddHandler lbl.MouseEnter, Sub() panel.BackColor = Color.FromArgb(211, 84, 0)
        AddHandler lbl.MouseLeave, Sub() panel.BackColor = Color.FromArgb(243, 156, 18)

        'Click con il destro
        AddHandler panel.MouseDown, AddressOf Farmaco_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) Farmaco_RightClick(panel, e)

        FlowLayoutPanelFarmaci.Controls.Add(panel)
    End Sub

    Private Sub CaricaTerapiaRiabilitativaPanel(id As Integer, nomeTerapiaRiabilitativa As String)
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelTerapieRiabilitative.Controls
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
            .Size = New Size(180, 50),
            .Tag = id,
            .Margin = New Padding(3),
            .BackColor = Color.FromArgb(46, 204, 113), ' verde chiaro
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
            .BackColor = Color.FromArgb(192, 57, 43),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Anchor = AnchorStyles.None
        }
        btnX.FlatAppearance.BorderSize = 0

        AddHandler btnX.Click, Sub(s, e)
                                   ' Rimuovo dalla UI
                                   FlowLayoutPanelTerapieRiabilitative.Controls.Remove(panel)
                                   panel.Dispose()
                                   ' Rimuovo dal DB
                                   RimuoviTerapiaRiabilitativa(id)
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
        AddHandler panel.MouseEnter, Sub() panel.BackColor = Color.FromArgb(39, 174, 96)
        AddHandler panel.MouseLeave, Sub() panel.BackColor = Color.FromArgb(46, 204, 113)
        AddHandler lbl.MouseEnter, Sub() panel.BackColor = Color.FromArgb(39, 174, 96)
        AddHandler lbl.MouseLeave, Sub() panel.BackColor = Color.FromArgb(46, 204, 113)

        'Click con il destro
        AddHandler panel.MouseDown, AddressOf TerapiaRiabilitativa_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) TerapiaRiabilitativa_RightClick(panel, e)

        FlowLayoutPanelTerapieRiabilitative.Controls.Add(panel)
    End Sub

    Private Async Sub AggiungiFarmacoAsync(id As Integer, nomeFarmaco As String)
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelFarmaci.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then Return
        Next

        Dim lbl As New Label With {
            .Text = nomeFarmaco, ' Mostra solo il nome del farmaco
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .AutoSize = True,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .MaximumSize = New Size(140, 0),
            .Anchor = AnchorStyles.None
        }

        Dim panel As New Panel With {
            .Size = New Size(180, 50),
            .Tag = id,
            .Margin = New Padding(3),
            .BackColor = Color.FromArgb(243, 156, 18), ' arancione chiaro
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
            .BackColor = Color.FromArgb(192, 57, 43),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Anchor = AnchorStyles.None
        }
        btnX.FlatAppearance.BorderSize = 0

        AddHandler btnX.Click, Sub(s, e)
                                   ' Rimuovo dalla UI
                                   FlowLayoutPanelFarmaci.Controls.Remove(panel)
                                   panel.Dispose()
                                   ' Rimuovo dal DB
                                   RimuoviFarmacoAsync(id)
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
        AddHandler panel.MouseEnter, Sub() panel.BackColor = Color.FromArgb(211, 84, 0)
        AddHandler panel.MouseLeave, Sub() panel.BackColor = Color.FromArgb(243, 156, 18)
        AddHandler lbl.MouseEnter, Sub() panel.BackColor = Color.FromArgb(211, 84, 0)
        AddHandler lbl.MouseLeave, Sub() panel.BackColor = Color.FromArgb(243, 156, 18)

        'Click con il destro
        AddHandler panel.MouseDown, AddressOf Farmaco_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) Farmaco_RightClick(panel, e)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        Dim insertQuery As String = "INSERT INTO TerapiaFarmaci (
                                                    ID_Terapia,
                                                    ID_Farmaco) VALUES(
                                                    @idTerapia,
                                                    @idFarmaco)"
        Dim insertParam As New List(Of SqlParameter) From {
            New SqlParameter("@idTerapia", idTerapia),
            New SqlParameter("@idFarmaco", id)
        }
        Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(insertQuery, insertParam)

        If esito Then
            main.MostraToast("Farmaco aggiunto correttamente dalla terapia.")
            FlowLayoutPanelFarmaci.Controls.Add(panel)
        Else
            main.MostraToast("Errore nell'aggiunta del farmaco.")
        End If
    End Sub

    Private Async Sub AggiungiTerapiaRiabilitativaAsync(id As Integer, nomeTerapiaRiabilitativa As String)
        ' Controllo duplicati
        For Each pnl As Panel In FlowLayoutPanelTerapieRiabilitative.Controls
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
            .Size = New Size(180, 50),
            .Tag = id,
            .Margin = New Padding(3),
            .BackColor = Color.FromArgb(46, 204, 113), ' verde chiaro
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
            .BackColor = Color.FromArgb(192, 57, 43),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Anchor = AnchorStyles.None
        }
        btnX.FlatAppearance.BorderSize = 0

        AddHandler btnX.Click, Sub(s, e)
                                   ' Rimuovo dalla UI
                                   FlowLayoutPanelTerapieRiabilitative.Controls.Remove(panel)
                                   panel.Dispose()
                                   ' Rimuovo dal DB
                                   RimuoviTerapiaRiabilitativa(id)
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
        AddHandler panel.MouseEnter, Sub() panel.BackColor = Color.FromArgb(39, 174, 96)
        AddHandler panel.MouseLeave, Sub() panel.BackColor = Color.FromArgb(46, 204, 113)
        AddHandler lbl.MouseEnter, Sub() panel.BackColor = Color.FromArgb(39, 174, 96)
        AddHandler lbl.MouseLeave, Sub() panel.BackColor = Color.FromArgb(46, 204, 113)

        'Click con il destro
        AddHandler panel.MouseDown, AddressOf TerapiaRiabilitativa_RightClick
        AddHandler lbl.MouseDown, Sub(s, e) TerapiaRiabilitativa_RightClick(panel, e)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        Dim insertQuery As String = "INSERT INTO TerapiaTerapieRiabilitative (
                                                    ID_Terapia,
                                                    ID_TerapiaRiabilitativa) VALUES(
                                                    @idTerapia,
                                                    @idTerapiaRiabilitativa)"
        Dim insertParam As New List(Of SqlParameter) From {
            New SqlParameter("@idTerapia", idTerapia),
            New SqlParameter("@idTerapiaRiabilitativa", id)
        }
        Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(insertQuery, insertParam)

        If esito Then
            main.MostraToast("Terapia riabilitativa aggiunta correttamente dalla terapia.")
            FlowLayoutPanelTerapieRiabilitative.Controls.Add(panel)
        Else
            main.MostraToast("Errore nell'aggiunta della terapia riabilitativa.")
        End If
    End Sub

    'Da finire
    Private Async Sub RimuoviFarmacoAsync(idFarmaco As Integer)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        Dim removeQuery As String = "DELETE FROM TerapiaFarmaci WHERE ID_Farmaco = @idFarmaco AND ID_Terapia = @idTerapia"
        Dim removeParam As New List(Of SqlParameter) From {
            New SqlParameter("@idTerapia", idTerapia),
            New SqlParameter("@idFarmaco", idFarmaco)
        }
        Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(removeQuery, removeParam)

        If esito Then
            main.MostraToast("Farmaco rimosso correttamente dalla terapia.")
        End If
    End Sub

    Private Async Sub RimuoviTerapiaRiabilitativa(idTerapiaRiabilitativa As Integer)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        Dim removeQuery As String = "DELETE FROM TerapiaTerapieRiabilitative WHERE ID_TerapiaRiabilitativa = @idTerapiaRiabilitativa AND ID_Terapia = @idTerapia"
        Dim removeParam As New List(Of SqlParameter) From {
            New SqlParameter("@idTerapia", idTerapia),
            New SqlParameter("@idTerapiaRiabilitativa", idTerapiaRiabilitativa)
        }
        Dim esito As Boolean = Await ConnessioneDB.EseguiNonQueryAsync(removeQuery, removeParam)

        If esito Then
            main.MostraToast("Terapia riabilitativa rimossa correttamente dalla terapia.")
        End If
    End Sub

    Private Sub RimuoviFarmacoDalFlowPanel(id As Integer)
        For Each pnl As Panel In FlowLayoutPanelFarmaci.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then
                FlowLayoutPanelFarmaci.Controls.Remove(pnl)
                pnl.Dispose()
                Exit For
            End If
        Next
    End Sub

    Private Sub RimuoviTerapiaRiabilitativaDalFlowPanel(id As Integer)
        For Each pnl As Panel In FlowLayoutPanelTerapieRiabilitative.Controls
            If pnl.Tag IsNot Nothing AndAlso CInt(pnl.Tag) = id Then
                FlowLayoutPanelTerapieRiabilitative.Controls.Remove(pnl)
                pnl.Dispose()
                Exit For
            End If
        Next
    End Sub

    Private Sub InizializzaContextMenuFarmaco()
        menuFarmaco = New ContextMenuStrip()
        Dim itemRimuovi As New ToolStripMenuItem("Rimuovi")
        AddHandler itemRimuovi.Click, AddressOf RimuoviFarmaco_Click
        menuFarmaco.Items.Add(itemRimuovi)
    End Sub

    Private Sub InizializzaContextMenuTerapiaRiabilitativa()
        menuTerapiaRiabilitativa = New ContextMenuStrip()
        Dim itemRimuovi As New ToolStripMenuItem("Rimuovi")
        AddHandler itemRimuovi.Click, AddressOf RimuoviTerapiaRiabilitativa_Click
        menuTerapiaRiabilitativa.Items.Add(itemRimuovi)
    End Sub

    Private Sub Farmaco_RightClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim panel As Panel = CType(sender, Panel)
            ' Mostra il menu contestuale sulla label
            menuFarmaco.Tag = panel ' memorizzo il pannello da rimuovere
            menuFarmaco.Show(panel, e.Location)
        End If
    End Sub

    Private Sub TerapiaRiabilitativa_RightClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim panel As Panel = CType(sender, Panel)
            ' Mostra il menu contestuale
            menuTerapiaRiabilitativa.Tag = panel ' memorizzo il pannello da rimuovere
            menuTerapiaRiabilitativa.Show(panel, e.Location)
        End If
    End Sub

    Private Sub RimuoviFarmaco_Click(sender As Object, e As EventArgs)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim menu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim menuStrip As ContextMenuStrip = CType(menu.Owner, ContextMenuStrip)
        Dim panel As Panel = CType(menuStrip.Tag, Panel)

        Dim idFarmaco As Integer = CInt(panel.Tag)

        If panel.Tag Is Nothing Then
            main.MostraToast("Errore durante la rimozione del farmaco.")
        Else
            Try
                ' Rimuovo il farmaco dalla UI
                FlowLayoutPanelFarmaci.Controls.Remove(panel)
                panel.Dispose()

                ' Rimuovo il farmaco dal DB
                RimuoviFarmacoAsync(idFarmaco)
            Catch ex As Exception
                main.MostraToast("Errore durante la rimozione dal database: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub RimuoviTerapiaRiabilitativa_Click(sender As Object, e As EventArgs)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim menu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim menuStrip As ContextMenuStrip = CType(menu.Owner, ContextMenuStrip)
        Dim panel As Panel = CType(menuStrip.Tag, Panel)

        Dim idTerapiaRiabilitativa As Integer = CInt(panel.Tag)

        If panel.Tag Is Nothing Then
            main.MostraToast("Errore durante la rimozione della terapia riabilitativa.")
        Else
            Try
                ' Rimuovo la terapia riabilitativa dalla UI
                FlowLayoutPanelFarmaci.Controls.Remove(panel)
                panel.Dispose()

                ' Rimuovo la terapia riabilitativa dal DB
                RimuoviTerapiaRiabilitativa(idTerapiaRiabilitativa)
            Catch ex As Exception
                main.MostraToast("Errore durante la rimozione dal database: " & ex.Message)
            End Try
        End If
    End Sub

    Private Async Sub ButtonAggiungiFarmaco_Click(sender As Object, e As EventArgs) Handles SfButtonAggiungiFarmaco.Click
        ' Creo la form
        Dim frm As New FormSelezione()

        ' Estraggo la lista di farmaci
        Dim queryFarmaci As String = "SELECT * FROM Farmaci ORDER BY NomeCommerciale"
        Dim dtFarmaci As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryFarmaci)

        ' Estraggo i farmaci già associati alla presente terapia
        Dim queryFarmaciTerapia As String = "SELECT ID_Farmaco FROM TerapiaFarmaci WHERE ID_Terapia = @idTerapia"
        Dim paramFarmaciTerapia As New List(Of SqlParameter) From {
            New SqlParameter("@idTerapia", idTerapia)
        }
        Dim dtFarmaciTerapia As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryFarmaciTerapia, paramFarmaciTerapia)

        Dim selezionatiOld As New List(Of Integer)

        For Each row As DataRow In dtFarmaciTerapia.Rows
            If row("ID_Farmaco") IsNot DBNull.Value Then
                selezionatiOld.Add(Convert.ToInt32(row("ID_Farmaco")))
            End If
        Next


        ' Recupero farmaci dal DB
        frm.PopolaGriglia(dtFarmaci, New List(Of String) From {"NomeCommerciale"}, selezionatiOld)

        ' Gestisco la selezione confermata
        AddHandler frm.OnSelezioneConfermata, Sub(farmaciSelezionati)
                                                  ' -------------------------------
                                                  ' Rimuovo quelli che erano presenti ma ora deselezionati
                                                  ' -------------------------------
                                                  For Each idIniziale In selezionatiOld
                                                      If Not farmaciSelezionati.Any(Function(f) f.ID = idIniziale) Then
                                                          ' Rimuovo dal DB
                                                          RimuoviFarmacoAsync(idIniziale)
                                                          ' Rimuovo dal FlowPanel
                                                          RimuoviFarmacoDalFlowPanel(idIniziale)
                                                      End If
                                                  Next

                                                  ' -------------------------------
                                                  ' Aggiungo quelli nuovi
                                                  ' -------------------------------
                                                  For Each f In farmaciSelezionati
                                                      If Not selezionatiOld.Contains(f.ID) Then
                                                          AggiungiFarmacoAsync(f.ID, f.Nome)
                                                      End If
                                                  Next
                                              End Sub
        ' Mostro la form come dialog
        frm.ShowDialog()

        ' Forzo il focus su un controllo neutro (può essere il form)
        Me.ActiveControl = Nothing
    End Sub

    Private Async Sub ButtonAggiungiTerapiaRiabilitativa_Click(sender As Object, e As EventArgs) Handles SfButtonAggiungiTerapiaRiabilitativa.Click
        ' Creo la form
        Dim frm As New FormSelezione()

        ' Estraggo la lista di farmaci
        Dim queryTerapieRiabilitative As String = "SELECT * FROM TerapieRiabilitative ORDER BY NomeTerapia"
        Dim dtTerapieRiabilitative As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryTerapieRiabilitative)

        ' Estraggo i farmaci già associati alla presente terapia
        Dim queryTerapiaTerapieRiabilitative As String = "SELECT ID_TerapiaRiabilitativa FROM TerapiaTerapieRiabilitative WHERE ID_Terapia = @idTerapia"
        Dim paramTerapiaTerapieRiabilitative As New List(Of SqlParameter) From {
            New SqlParameter("@idTerapia", idTerapia)
        }
        Dim dtTerapiaTerapieRiabilitative As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryTerapiaTerapieRiabilitative, paramTerapiaTerapieRiabilitative)

        Dim selezionatiOld As New List(Of Integer)

        For Each row As DataRow In dtTerapiaTerapieRiabilitative.Rows
            If row("ID_TerapiaRiabilitativa") IsNot DBNull.Value Then
                selezionatiOld.Add(Convert.ToInt32(row("ID_TerapiaRiabilitativa")))
            End If
        Next


        ' Recupero farmaci dal DB
        frm.PopolaGriglia(dtTerapieRiabilitative, New List(Of String) From {"NomeTerapia"}, selezionatiOld)

        ' Gestisco la selezione confermata
        AddHandler frm.OnSelezioneConfermata, Sub(terapieRiabilitativeSelezionati)
                                                  ' -------------------------------
                                                  ' Rimuovo quelle che erano presenti ma ora deselezionate
                                                  ' -------------------------------
                                                  For Each idIniziale In selezionatiOld
                                                      If Not terapieRiabilitativeSelezionati.Any(Function(f) f.ID = idIniziale) Then
                                                          ' Rimuovo dal DB
                                                          RimuoviTerapiaRiabilitativa(idIniziale)
                                                          ' Rimuovo dal FlowPanel
                                                          RimuoviTerapiaRiabilitativaDalFlowPanel(idIniziale)
                                                      End If
                                                  Next

                                                  ' -------------------------------
                                                  ' Aggiungo quelle nuove
                                                  ' -------------------------------
                                                  For Each f In terapieRiabilitativeSelezionati
                                                      If Not selezionatiOld.Contains(f.ID) Then
                                                          AggiungiTerapiaRiabilitativaAsync(f.ID, f.Nome)
                                                      End If
                                                  Next
                                              End Sub
        ' Mostro la form come dialog
        frm.ShowDialog()

        ' Forzo il focus su un controllo neutro (può essere il form)
        Me.ActiveControl = Nothing
    End Sub

    Private Function CheckSelezione() As Boolean
        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelMiglioramenti)

        ' Verifico se sono state effettuate tutte le scelte
        Dim result = ValidateMultipleGroups(TableLayoutPanelMiglioramenti)

        Dim invalidGroups = result.InvalidGroups

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HilightInvalidGroups(invalidGroups.ToArray())
            Return False
        Else
            Return True
        End If
    End Function

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idVisita = main.IDVisitaSelezionata

            Dim successo As Boolean = False

            Dim miglioramenti As Object = GetSelectedRadioText(TableLayoutPanelMiglioramenti)

            Try
                Dim queryTerapia As String = "UPDATE Terapia SET 
                                                                Miglioramenti = @miglioramenti
                                                                WHERE ID_Visita = @idVisita"

                Dim paramTerapia As New List(Of SqlParameter) From {
                    New SqlParameter("@idVisita", idVisita),
                    New SqlParameter("@miglioramenti", miglioramenti)
                }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryTerapia, paramTerapia) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Terapia aggiornata correttamente.")
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
        TableLayoutPanelTerapia.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelTerapia.Enabled = True

        If esito Then
            appenaSalvati = True
            TableLayoutPanelTerapia.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            Dim result = Await CercaVisitaAsync()
            TableLayoutPanelTerapia.Enabled = True
        End If

        ' Forzo il focus su un controllo neutro (può essere il form)
        Me.ActiveControl = Nothing
    End Sub
End Class
