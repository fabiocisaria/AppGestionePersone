Imports Microsoft.Data.SqlClient
Imports Syncfusion.Windows.Forms.Tools

Public Class UC_AnamnesiFamiliare
    Private _aggiornamentoInterno As Boolean = False

    Private Shared ReadOnly ControlText As New Dictionary(Of Control, String)

    Private Sub ResetUC()
        PulisciCampi(ComboBoxParentela, TextPatologie)
    End Sub

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo
    End Sub

    Private Sub UC_AnamnesiFamiliare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaParentelaAsync()

        ControlText(TextPatologie) = "Patologie"
    End Sub

    ' ====================
    ' Placeholder per TextBox
    ' ====================
    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextPatologie.Enter
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ""
            ctrl.ForeColor = Theme.TextBoxForeColor
            ctrl.Font = Theme.TxtFont
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextPatologie.Leave
        Dim ctrl As Control = DirectCast(sender, Control)
        If String.IsNullOrWhiteSpace(ctrl.Text) OrElse ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ControlText(ctrl)
            ctrl.ForeColor = Theme.FindColor
            ctrl.Font = Theme.TxtFontItalic
        End If
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
            main.MostraToast("Seleziona il grado di parentela.")
            HilightControls(True, ComboBoxParentela)
            successo = False
        ElseIf Not Utils.IsValidSelection(ComboBoxParentela) Then
            main.MostraToast("Inserire un grado di parentela corretto.")
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

        If String.IsNullOrWhiteSpace(TextPatologie.Text.Trim()) OrElse TextPatologie.Text.Trim() = ControlText(TextPatologie) Then
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