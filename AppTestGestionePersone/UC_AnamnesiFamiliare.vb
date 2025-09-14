Imports Microsoft.Data.SqlClient

Public Class UC_AnamnesiFamiliare
    Private _aggiornamentoInterno As Boolean = False

    Private Sub ResetUC()
        PulisciCampi(ComboBoxParentela, TextPatologie)
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.BackColor = Theme.BackgroundColor
        TableLayoutPanel1.BackColor = Theme.BackgroundColor
        TableLayoutPanel2.BackColor = Theme.BackgroundColor
        TableLayoutPanel3.BackColor = Theme.BackgroundColor

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
    End Sub

    Private Sub UC_AnamnesiFamiliare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaParentelaAsync()
    End Sub

    ' 🔹 Carica lista parentela dal DB
    Private Async Sub CaricaParentelaAsync()
        ComboBoxParentela.Enabled = False
        Try
            Dim query As String = "SELECT ID, Parentela FROM TipoParente ORDER BY Parentela"
            Dim dt As DataTable = Await ConnessioneDB.EseguiQueryAsync(query)
            ComboBoxParentela.DataSource = dt
            ComboBoxParentela.DisplayMember = "Parentela"
            ComboBoxParentela.ValueMember = "ID"
        Catch ex As Exception
            MessageBox.Show("Errore nel caricamento della lista parentela: " & ex.Message)
        Finally
            ComboBoxParentela.Enabled = True
        End Try
    End Sub

    ' 🔹 Salva anamnesi

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim patologie As Object

        Dim successo As Boolean = True

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idSelezionato As Integer = main.IDPazienteSelezionato

        Dim valoriConsentiti As New List(Of String) From {"Madre", "Padre", "Nonna materna", "Nonna paterna", "Nonno materno", "Nonno paterno"}

        If ComboBoxParentela.SelectedIndex = -1 Then
            main.MostraToast("Seleziona la parentela.")
            HilightControls(True, ComboBoxParentela)
            successo = False
        ElseIf valoriConsentiti.Contains(ComboBoxParentela.Text) Then
            ' Controllo duplicato se il parente selezionato deve essere univoco (Padre, madre, etc)
            Dim checkQuery As String = "SELECT COUNT(*) FROM AnamnesiFamiliare WHERE ID_Anagrafica = @idAna AND ID_Parente = @idParente"
            Dim checkParam As New List(Of SqlParameter) From {
                New SqlParameter("@idAna", idSelezionato),
                New SqlParameter("@idParente", ComboBoxParentela.SelectedValue)
            }
            Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

            If dtCheck.Rows(0)(0) > 0 Then
                main.MostraToast("Anamnesi parente già presente per il paziente selezionato.")
                successo = False
            End If
        Else
            HilightControls(False, ComboBoxParentela)
        End If

        If String.IsNullOrWhiteSpace(TextPatologie.Text) Then
            patologie = DBNull.Value
        Else
            patologie = TextPatologie.Text
        End If

        If successo Then
            ' Inserimento
            Dim query As String = "INSERT INTO AnamnesiFamiliare (ID_Anagrafica, ID_Parente, Patologie) VALUES (@idAna, @idParente, @patologie)"
            Dim parametri As New List(Of SqlParameter) From {
                New SqlParameter("@idAna", idSelezionato),
                New SqlParameter("@idParente", ComboBoxParentela.SelectedValue),
                New SqlParameter("@patologie", patologie)
            }

            If Await ConnessioneDB.EseguiNonQueryAsync(query, parametri) > 0 Then
                main.MostraToast("Anamnesi familiare inserita con successo.")
                successo = True
            End If
        End If

        Return successo
    End Function
    Private Async Sub btnSalva_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        TableLayoutPanel2.Enabled = False
        main.MostraToast("Salvataggio in corso ...")

        Dim esito = Await SalvaDatiAsync()
        TableLayoutPanel2.Enabled = True
        If esito Then
            ResetUC() ' Pulisci e resetta i campi
        End If
    End Sub
End Class