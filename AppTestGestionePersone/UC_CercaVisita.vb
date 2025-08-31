Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity
Imports Syncfusion.WinForms.Input
Imports Syncfusion.WinForms.ListView.Styles

Public Class UC_CercaVisita
    Inherits UserControl

    ' ====================
    ' Variabili e proprietà
    ' ====================
    Private _aggiornamentoInterno As Boolean = False
    Public Property IDVisitaSelezionata As Integer
    Public Property TipoVisitaSelezionata As String
    Public Property DataVisitaSelezionata As Date?
    Public Property IsHandlerAttached As Boolean = False

    ' Evento per comunicare alla MainForm il paziente selezionato
    Public Event VisitaSelezionata(IDVisita As Integer, TipoVisita As String, DataVisita As Date)

    ' ====================
    ' Costruttore
    ' ====================
    Public Sub New()
        InitializeComponent()

        ' ====================
        ' SfButtons
        ' ====================
        With ButtonCercaVisita.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .ForeColor = Color.White
        End With

        With ButtonSeleziona.Style
            .BackColor = Color.FromArgb(39, 174, 96)
            .ForeColor = Color.White
        End With

        With ButtonAnnulla.Style
            .BackColor = Color.FromArgb(192, 57, 43)
            .ForeColor = Color.White
        End With

        With DateTimePickerDataVisita
            .Style.BackColor = Color.White
            .Style.BorderColor = Color.FromArgb(41, 128, 185)
            .Style.ForeColor = Color.Black
            .Dock = DockStyle.Top
            .AllowNull = True
            .Value = Nothing
        End With

        ' ====================
        ' ComboBoxTipoVisita
        ' ====================
        With ComboBoxTipoVisita
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Prima visita", "Controllo", "Qualsiasi"}
            .SelectedIndex = -1

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo
            ' Bordo
            ' Sfondo e testo
            .Style.EditorStyle.BackColor = Color.White
            .Style.EditorStyle.ForeColor = Color.Black
            .Style.EditorStyle.FocusedBorderColor = Color.FromArgb(41, 128, 185)

            ' Bottone a discesa
            .Style.DropDownButtonStyle.BackColor = Color.White
            .Style.DropDownButtonStyle.DisabledBackColor = Color.White
            .Style.DropDownButtonStyle.DisabledForeColor = Color.Black

            ' Bordo
            .BorderStyle = BorderStyle.FixedSingle

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With

        With DateTimePickerDataVisita
            .Style.BackColor = Color.White
            .Style.BorderColor = Color.FromArgb(41, 128, 185)
            .Style.ForeColor = Color.Black
            .Dock = DockStyle.Top
        End With

        DateTimePickerDataVisita.AllowNull = True
        DateTimePickerDataVisita.Value = Nothing
        ' ====================
        ' SfDataGrid (se presente)
        ' ====================
        ConfiguraDataGrid()
    End Sub

    ' ====================
    ' Configurazione SfDataGrid
    ' ====================
    Private Sub ConfiguraDataGrid()
        ' SfDataGrid di sola lettura
        dgvSelezioneVisita.AllowEditing = False
        dgvSelezioneVisita.AllowResizingColumns = True
        dgvSelezioneVisita.SelectionMode = GridSelectionMode.Single
        dgvSelezioneVisita.AutoGenerateColumns = True

        ' Eventi
        AddHandler dgvSelezioneVisita.CellDoubleClick, AddressOf dgvSelezioneVisita_CellDoubleClick
    End Sub

    ' ====================
    ' Evidenzia riga relativa alla visita selezionata
    ' ====================
    Private Sub EvidenziaSelezione()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idSelezionatoMemorizzato As Integer = main.IDVisitaSelezionata

        ' Usa l'evento QueryCellStyle per colorare le righe
        AddHandler dgvSelezioneVisita.QueryCellStyle, Sub(sender As Object, e As Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs)
                                                          If e.RowIndex >= 0 Then
                                                              Dim record As Object = dgvSelezioneVisita.GetRecordAtRowIndex(e.RowIndex)
                                                              Dim riga As DataRowView = TryCast(record, DataRowView)
                                                              If riga IsNot Nothing Then
                                                                  If Convert.ToInt32(riga("ID")) = idSelezionatoMemorizzato Then
                                                                      e.Style.BackColor = Color.LightGreen
                                                                      e.Style.TextColor = Color.Black
                                                                  Else
                                                                      e.Style.BackColor = Color.White
                                                                      e.Style.TextColor = Color.Black
                                                                  End If
                                                              End If
                                                          End If
                                                      End Sub

        dgvSelezioneVisita.Refresh()
    End Sub

    ' ====================
    ' Eventi pulsanti
    ' ====================
    Private Sub ButtonCercaVisita_Click(sender As Object, e As EventArgs) Handles ButtonCercaVisita.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        Dim idPaziente As Integer = main.IDPazienteSelezionato
        Dim dataVisita As Date? = Nothing
        Dim tipoVisita As String = ""

        If DateTimePickerDataVisita.Value IsNot Nothing Then
            dataVisita = DateTimePickerDataVisita.Value
        End If

        If (Not String.IsNullOrWhiteSpace(ComboBoxTipoVisita.SelectedItem)) And Not (ComboBoxTipoVisita.SelectedItem = "Qualsiasi") Then
            tipoVisita = ComboBoxTipoVisita.SelectedItem
        End If

        Dim visiteTrovate = Utils.CercaVisiteUC(idPaziente, dataVisita, tipoVisita)

        If visiteTrovate.Rows.Count > 0 Then
            dgvSelezioneVisita.DataSource = visiteTrovate
            DirectCast(Me.ParentForm, MainForm).MostraToast("Trovate " & visiteTrovate.Rows.Count & " visite.")
        Else
            dgvSelezioneVisita.DataSource = Nothing
            DirectCast(Me.ParentForm, MainForm).MostraToast("Nessuna visita trovata.")
        End If
    End Sub

    Private Sub ButtonSeleziona_Click(sender As Object, e As EventArgs) Handles ButtonSeleziona.Click
        SelezionaVisita(dgvSelezioneVisita.SelectedItem)
    End Sub

    Private Sub ButtonAnnulla_Click(sender As Object, e As EventArgs) Handles ButtonAnnulla.Click
        IDVisitaSelezionata = 0
        TipoVisitaSelezionata = ""
        DataVisitaSelezionata = Nothing
        dgvSelezioneVisita.DataSource = Nothing
    End Sub

    ' ====================
    ' Doppio click su DataGridView per selezionare il paziente
    ' ====================
    Private Sub dgvSelezioneVisita_CellDoubleClick(sender As Object, e As CellClickEventArgs)
        ' Recupera il record selezionato tramite SelectedItem
        Dim record = dgvSelezioneVisita.SelectedItem
        If record IsNot Nothing Then
            SelezionaVisita(record)
        End If
    End Sub

    ' ====================
    ' Metodi logica per selezionare il paziente
    ' ====================
    Private Sub SelezionaVisita(dataRow As Object)
        Dim drv As DataRowView = TryCast(dataRow, DataRowView)
        If drv IsNot Nothing Then
            IDVisitaSelezionata = Convert.ToInt32(drv("ID"))
            TipoVisitaSelezionata = drv("TipoVisita").ToString()
            DataVisitaSelezionata = Convert.ToDateTime(drv("DataVisita"))

            ' Solleva l'evento verso la MainForm
            RaiseEvent VisitaSelezionata(IDVisitaSelezionata, TipoVisitaSelezionata, DataVisitaSelezionata)

            ' Evidenzia la riga corrispondente al paziente selezionato
            EvidenziaSelezione()
        End If
    End Sub
End Class
