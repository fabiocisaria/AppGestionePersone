Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums

Public Class FormSelezione

    Public Event OnSelezioneConfermata As Action(Of List(Of (ID As Integer, Nome As String)))
    ' ====================
    ' Costruttore
    ' ====================
    Public Sub New()
        InitializeComponent()
        ConfiguraDataGrid()

        With ButtonAnnulla.Style
            .BackColor = Color.FromArgb(192, 57, 43)
            .HoverBackColor = Color.FromArgb(150, 40, 35)    ' colore hover
            .PressedBackColor = Color.FromArgb(150, 40, 35)   ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(150, 40, 35)   ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With

        With ButtonSeleziona.Style
            .BackColor = Color.FromArgb(39, 174, 96)
            .HoverBackColor = Color.FromArgb(30, 130, 70) ' colore hover
            .PressedBackColor = Color.FromArgb(30, 130, 70) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(30, 130, 70) ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With
    End Sub

    ' ====================
    ' Configurazione SfDataGrid
    ' ====================
    Private Sub ConfiguraDataGrid()
        ' SfDataGrid di sola lettura
        dgvSelezione.AllowEditing = False
        dgvSelezione.AllowResizingColumns = True

        ' Selezione multipla con righe o colonna checkbox
        dgvSelezione.AutoGenerateColumns = False
        dgvSelezione.SelectionMode = GridSelectionMode.Multiple
        dgvSelezione.NavigationMode = NavigationMode.Row

        ' Opzionale: colonna checkbox iniziale
        If dgvSelezione.Columns("Seleziona") Is Nothing Then
            Dim chkCol As New GridCheckBoxColumn()
            chkCol.MappingName = "Seleziona"
            chkCol.HeaderText = "✔"
            chkCol.Width = 40
            dgvSelezione.Columns.Add(chkCol)
        End If

        'Nascondo la colonna ID
        If dgvSelezione.Columns("ID") Is Nothing Then
            Dim idCol As New Syncfusion.WinForms.DataGrid.GridTextColumn() With {
                .MappingName = "ID",
                .HeaderText = "ID",
                .Visible = False
            }
            dgvSelezione.Columns.Add(idCol)
        End If

        ' Colonna principale per nome farmaco/terapia
        ' Verrà aggiunta dinamicamente con PopolaGriglia()
    End Sub

    Public Sub PopolaGriglia(dt As DataTable, Optional colonneDaMostrare As List(Of String) = Nothing, Optional selezionati As List(Of Integer) = Nothing)
        ' Aggiungo la colonna checkbox se non presente
        'If Not dt.Columns.Contains("Seleziona") Then
        'dt.Columns.Add("Seleziona", GetType(Boolean))
        'End If

        'If selezionati IsNot Nothing Then
        ' Itero sul DefaultView del DataTable
        'For Each drv As DataRowView In dt.DefaultView
        'If dt.Columns.Contains("ID") AndAlso selezionati.Contains(Convert.ToInt32(drv("ID"))) Then
        'drv("Seleziona") = True
        'End If
        'Next
        'End If


        dgvSelezione.DataSource = dt
        dgvSelezione.AutoGenerateColumns = False
        dgvSelezione.Columns.Clear()

        ' Colonna checkbox iniziale
        'Dim chkCol As New Syncfusion.WinForms.DataGrid.GridCheckBoxColumn() With {
        '.MappingName = "Seleziona",
        '.HeaderText = "✔",
        '.Width = 40
        '}
        'dgvSelezione.Columns.Add(chkCol)

        ' Colonna ID nascosta
        If dt.Columns.Contains("ID") Then
            Dim idCol As New Syncfusion.WinForms.DataGrid.GridTextColumn() With {
            .MappingName = "ID",
            .HeaderText = "ID",
            .Visible = False
        }
            dgvSelezione.Columns.Add(idCol)
        End If

        ' Aggiungo le colonne visibili dinamicamente
        If colonneDaMostrare IsNot Nothing Then
            ' Aggiungo solo le colonne specificate
            For Each colName In colonneDaMostrare
                If dt.Columns.Contains(colName) Then
                    Dim txtCol As New Syncfusion.WinForms.DataGrid.GridTextColumn() With {
                .MappingName = colName,
                .HeaderText = colName,
                .AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
            }
                    dgvSelezione.Columns.Add(txtCol)
                End If
            Next
        Else
            ' Aggiungo tutte le colonne tranne ID e Seleziona
            For Each col As DataColumn In dt.Columns
                If col.ColumnName <> "ID" AndAlso col.ColumnName <> "Seleziona" Then
                    Dim txtCol As New Syncfusion.WinForms.DataGrid.GridTextColumn() With {
                .MappingName = col.ColumnName,
                .HeaderText = col.ColumnName,
                .AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
            }
                    dgvSelezione.Columns.Add(txtCol)
                End If
            Next
        End If

        ' Seleziono le righe già presenti (selezionati non Nothing)
        If selezionati IsNot Nothing AndAlso selezionati.Count > 0 Then
            dgvSelezione.SelectedItems.Clear()
            For Each drv As DataRowView In dt.DefaultView
                If Not IsDBNull(drv("ID")) AndAlso selezionati.Contains(Convert.ToInt32(drv("ID"))) Then
                    ' Aggiungo la DataRowView corrispondente alla selezione
                    dgvSelezione.SelectedItems.Add(drv)
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' Restituisce la lista di elementi selezionati nella griglia.
    ''' Ogni elemento è una tupla (ID, Nome) dove Nome è la prima colonna visibile diversa da Seleziona/ID.
    ''' </summary>
    Public Function GetSelezionati() As List(Of (ID As Integer, Nome As String))
        Dim lista As New List(Of (Integer, String))

        ' Verifica che la griglia abbia righe selezionate
        If dgvSelezione.SelectedItems Is Nothing OrElse dgvSelezione.SelectedItems.Count = 0 Then
            Return lista
        End If

        Dim dt As DataTable = TryCast(dgvSelezione.DataSource, DataTable)

        If dt Is Nothing Then Return lista

        ' Trovo la prima colonna visibile diversa da ID e Seleziona
        'Dim nomeColonna As String = dt.Columns.Cast(Of DataColumn)() _
        '.Where(Function(c) c.ColumnName <> "ID" AndAlso c.ColumnName <> "Seleziona") _
        '.Select(Function(c) c.ColumnName).FirstOrDefault()
        'If String.IsNullOrEmpty(nomeColonna) Then Return lista

        Dim nomeColonna As String = dt.Columns.Cast(Of DataColumn)() _
                                .Where(Function(c) c.ColumnName <> "ID") _
                                .Select(Function(c) c.ColumnName) _
                                .FirstOrDefault()
        If String.IsNullOrEmpty(nomeColonna) Then Return lista

        ' Itero su DataRowView se DataSource è un DataTable
        'For Each drv As DataRowView In dt.DefaultView
        'Dim selezionato As Boolean = False
        'If dt.Columns.Contains("Seleziona") AndAlso drv("Seleziona") IsNot Nothing AndAlso Not IsDBNull(drv("Seleziona")) Then
        'selezionato = Convert.ToBoolean(drv("Seleziona"))
        'End If

        'If selezionato Then
        'Dim id As Integer = -1
        'If dt.Columns.Contains("ID") AndAlso drv("ID") IsNot Nothing AndAlso Not IsDBNull(drv("ID")) Then
        'id = Convert.ToInt32(drv("ID"))
        'End If

        'Dim nome As String = If(drv(nomeColonna) IsNot Nothing AndAlso Not IsDBNull(drv(nomeColonna)), drv(nomeColonna).ToString(), "")
        'lista.Add((id, nome))
        'End If
        'Next

        ' Itero sugli elementi selezionati
        For Each obj In dgvSelezione.SelectedItems
            Dim drv As DataRowView = TryCast(obj, DataRowView)
            If drv IsNot Nothing Then
                Dim id As Integer = If(IsDBNull(drv("ID")), -1, Convert.ToInt32(drv("ID")))
                Dim nome As String = If(IsDBNull(drv(nomeColonna)), "", drv(nomeColonna).ToString())
                lista.Add((id, nome))
            End If
        Next

        Return lista
    End Function

    Private Sub ButtonAnnulla_Click(sender As Object, e As EventArgs) Handles ButtonAnnulla.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ' Conferma la selezione e chiude
    Private Sub ButtonSeleziona_Click(sender As Object, e As EventArgs) Handles ButtonSeleziona.Click
        Dim selezionati = GetSelezionati() ' Lista di (ID, Nome)

        ' Sollevo l'evento
        RaiseEvent OnSelezioneConfermata(selezionati)

        ' Chiudo la Form
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class