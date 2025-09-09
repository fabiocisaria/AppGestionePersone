Imports Syncfusion.WinForms.Controls
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity
Imports Syncfusion.WinForms.Input
Imports Microsoft.Data.SqlClient

Public Class UC_CercaPaziente
    Inherits UserControl

    ' ====================
    ' Variabili e proprietà
    ' ====================
    Private _aggiornamentoInterno As Boolean = False
    Public Property IDSelezionato As Integer
    Public Property CodiceIdentificativoSelezionato As String
    Public Property CognomeSelezionato As String
    Public Property NomeSelezionato As String
    Public Property DataNascitaSelezionato As Date
    Public Property IsHandlerAttached As Boolean = False

    ' Evento per comunicare alla MainForm il paziente selezionato
    Public Event PazienteSelezionato(ID As Integer, CodiceIdentificativo As String, Cognome As String, Nome As String, DataNascita As Date)

    ' ====================
    ' Costruttore
    ' ====================
    Public Sub New()
        InitializeComponent()
        ConfiguraDataGrid()
        ' Se vuoi puoi personalizzare subito lo stile dei Syncfusion controls
        TextBoxCognome.ForeColor = Color.Gray
        TextBoxCodiceID.ForeColor = Color.Gray
        TextBoxCognome.BorderColor = Color.FromArgb(41, 128, 185)
        TextBoxCodiceID.BorderColor = Color.FromArgb(41, 128, 185)

        With ButtonCercaPaziente.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
            .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
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
        dgvSelezionePaziente.AllowEditing = False
        dgvSelezionePaziente.AllowResizingColumns = True
        dgvSelezionePaziente.SelectionMode = GridSelectionMode.Single
        dgvSelezionePaziente.AutoGenerateColumns = True

        ' Eventi
        AddHandler dgvSelezionePaziente.CellDoubleClick, AddressOf dgvSelezionePaziente_CellDoubleClick
    End Sub

    ' ====================
    ' Eventi TextBox
    ' ====================
    Private Sub txtCognome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCognome.TextChanged
        If TextBoxCognome.Text = "Cognome" Then
            _aggiornamentoInterno = False
        End If

        If _aggiornamentoInterno Then Return

        If ((TextBoxCognome.Text.Trim().Length > 0) And (TextBoxCognome.Text <> "Cognome")) Then
            SetControlsEnabled(False, TextBoxCodiceID)
        Else
            SetControlsEnabled(True, TextBoxCodiceID)
        End If
    End Sub

    ' Quando scrivo nel CodiceID, disabilito la ricerca per Cognome
    Private Sub txtCodiceID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodiceID.TextChanged
        If TextBoxCodiceID.Text = "Codice identificativo" Then
            _aggiornamentoInterno = False
        End If

        If _aggiornamentoInterno Then Return

        If ((TextBoxCodiceID.Text.Trim().Length > 0) And (TextBoxCodiceID.Text <> "Codice identificativo")) Then
            SetControlsEnabled(False, TextBoxCognome)
        Else
            SetControlsEnabled(True, TextBoxCognome)
        End If
    End Sub

    ' ====================
    ' Placeholder per TextBoxCognome
    ' ====================
    Private Sub TextBoxCognome_Enter(sender As Object, e As EventArgs) Handles TextBoxCognome.Enter
        If TextBoxCognome.Text = "Cognome" Then
            TextBoxCognome.Text = ""
            TextBoxCognome.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxCognome_Leave(sender As Object, e As EventArgs) Handles TextBoxCognome.Leave
        If String.IsNullOrWhiteSpace(TextBoxCognome.Text) Then
            TextBoxCognome.Text = "Cognome"
            TextBoxCognome.ForeColor = Color.Gray
        End If
    End Sub

    ' ====================
    ' Placeholder per TextBoxCodiceID
    ' ====================
    Private Sub TextBoxCodiceID_Enter(sender As Object, e As EventArgs) Handles TextBoxCodiceID.Enter
        If TextBoxCodiceID.Text = "Codice identificativo" Then
            TextBoxCodiceID.Text = ""
            TextBoxCodiceID.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxCodiceID_Leave(sender As Object, e As EventArgs) Handles TextBoxCodiceID.Leave
        If String.IsNullOrWhiteSpace(TextBoxCodiceID.Text) Then
            TextBoxCodiceID.Text = "Codice identificativo"
            TextBoxCodiceID.ForeColor = Color.Gray
        End If
    End Sub

    ' ====================
    ' Evidenzia riga relativa al paziente selezionato
    ' ====================
    Private Sub EvidenziaSelezione()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idSelezionatoMemorizzato As Integer = main.IDPazienteSelezionato

        ' Usa l'evento QueryCellStyle per colorare le righe
        AddHandler dgvSelezionePaziente.QueryCellStyle, Sub(sender As Object, e As Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs)
                                                            If e.RowIndex >= 0 Then
                                                                Dim record As Object = dgvSelezionePaziente.GetRecordAtRowIndex(e.RowIndex)
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

        dgvSelezionePaziente.Refresh()
    End Sub

    ' ====================
    ' Eventi pulsanti
    ' ====================
    Private Sub ButtonCercaPaziente_Click(sender As Object, e As EventArgs) Handles ButtonCercaPaziente.Click
        Dim cognome As String = ""
        Dim codiceID As String = ""

        If TextBoxCognome.Text <> "Cognome" Then
            cognome = TextBoxCognome.Text.Trim()
        End If

        If TextBoxCodiceID.Text <> "Codice identificativo" Then
            codiceID = TextBoxCodiceID.Text.Trim()
        End If

        Dim pazientiTrovati = Utils.CercaPazienteUC(codiceID, cognome)

        If pazientiTrovati.Rows.Count > 0 Then
            dgvSelezionePaziente.DataSource = pazientiTrovati
            DirectCast(Me.ParentForm, MainForm).MostraToast("Trovati " & pazientiTrovati.Rows.Count & " pazienti.")
        Else
            dgvSelezionePaziente.DataSource = Nothing
            DirectCast(Me.ParentForm, MainForm).MostraToast("Nessun paziente trovato.")
        End If
    End Sub

    Private Sub ButtonSeleziona_Click(sender As Object, e As EventArgs) Handles ButtonSeleziona.Click
        SelezionaPaziente(dgvSelezionePaziente.SelectedItem)
    End Sub

    Private Sub ButtonAnnulla_Click(sender As Object, e As EventArgs) Handles ButtonAnnulla.Click
        IDSelezionato = 0
        CodiceIdentificativoSelezionato = ""
        dgvSelezionePaziente.DataSource = Nothing
        TextBoxCognome.Text = ""
        TextBoxCodiceID.Text = ""
    End Sub

    ' ====================
    ' Doppio click su DataGridView per selezionare il paziente
    ' ====================
    Private Sub dgvSelezionePaziente_CellDoubleClick(sender As Object, e As CellClickEventArgs)
        ' Recupera il record selezionato tramite SelectedItem
        Dim record = dgvSelezionePaziente.SelectedItem
        If record IsNot Nothing Then
            SelezionaPaziente(record)
        End If
    End Sub

    ' ====================
    ' Metodi logica per selezionare il paziente
    ' ====================
    Private Sub SelezionaPaziente(dataRow As Object)
        Dim drv As DataRowView = TryCast(dataRow, DataRowView)
        If drv IsNot Nothing Then
            IDSelezionato = Convert.ToInt32(drv("ID"))
            CodiceIdentificativoSelezionato = drv("CodiceIdentificativo").ToString()
            CognomeSelezionato = drv("Cognome").ToString()
            NomeSelezionato = drv("Nome").ToString()
            DataNascitaSelezionato = Convert.ToDateTime(drv("DataNascita"))

            ' Solleva l'evento verso la MainForm
            RaiseEvent PazienteSelezionato(IDSelezionato, CodiceIdentificativoSelezionato, CognomeSelezionato, NomeSelezionato, DataNascitaSelezionato)

            ' Evidenzia la riga corrispondente al paziente selezionato
            EvidenziaSelezione()
        End If
    End Sub
End Class
