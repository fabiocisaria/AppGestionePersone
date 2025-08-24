Public Class UC_AnamnesiFamiliare
    Private _aggiornamentoInterno As Boolean = False

    Private Sub ResetUC()
        PulisciCampi(ComboBoxParentela, TextPatologie)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UC_AnamnesiFamiliare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaParentela()
    End Sub

    ' 🔹 Carica lista parentela dal DB
    Private Sub CaricaParentela()
        Dim query As String = "SELECT ID, Parentela FROM TipoParente ORDER BY Parentela"
        Dim dt As DataTable = EseguiQuery(query)
        ComboBoxParentela.DataSource = dt
        ComboBoxParentela.DisplayMember = "Parentela"
        ComboBoxParentela.ValueMember = "ID"
    End Sub

    ' 🔹 Salva anamnesi

    Private Function SalvaDati() As Boolean
        Dim patologie As Object

        Dim successo As Boolean = True

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idSelezionato As Integer = main.IDPazienteSelezionato

        Dim valoriConsentiti As New List(Of String) From {"Madre", "Padre", "Nonna materna", "Nonna paterna", "Nonno materno", "Nonno paterno"}

        If ComboBoxParentela.SelectedIndex = -1 Then
            main.MostraToast("Seleziona la parentela.")
            HighlightControls(True, ComboBoxParentela)
            successo = False
        ElseIf valoriConsentiti.Contains(ComboBoxParentela.Text) Then
            ' Controllo duplicato se il parente selezionato deve essere univoco (Padre, madre, etc)
            Dim checkQuery As String = "SELECT COUNT(*) FROM AnamnesiFamiliare WHERE ID_Anagrafica = @idAna AND ID_Parente = @idParente"
            Dim checkParam As New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@idAna", idSelezionato),
                New SqlClient.SqlParameter("@idParente", ComboBoxParentela.SelectedValue)
            }
            Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

            If dtCheck.Rows(0)(0) > 0 Then
                main.MostraToast("Anamnesi parente già presente per il paziente selezionato.")
                successo = False
            End If
        Else
            HighlightControls(False, ComboBoxParentela)
        End If

        If String.IsNullOrWhiteSpace(TextPatologie.Text) Then
            patologie = DBNull.Value
        Else
            patologie = TextPatologie.Text
        End If

        If successo Then
            ' Inserimento
            Dim query As String = "INSERT INTO AnamnesiFamiliare (ID_Anagrafica, ID_Parente, Patologie) VALUES (@idAna, @idParente, @patologie)"
            Dim parametri As New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@idAna", idSelezionato),
                New SqlClient.SqlParameter("@idParente", ComboBoxParentela.SelectedValue),
                New SqlClient.SqlParameter("@patologie", patologie)
            }

            If EseguiNonQuery(query, parametri) > 0 Then
                main.MostraToast("Anamnesi familiare inserita con successo.")
                successo = True
            End If
        End If

        Return successo
    End Function
    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles ButtonSalva.Click
        Dim esito = SalvaDati()
        If esito Then
            ResetUC() ' Pulisci e resetta i campi
        End If
    End Sub
End Class
