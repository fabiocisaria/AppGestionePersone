Imports Microsoft.Data.SqlClient
Imports OfficeOpenXml.RichData.RichValues
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity


' NOTA: devo fare in modo di visualizzare solo il nome dei parenti, ma non l'id anagrafica nel dgv, mentre nel datatable devo mantenere anche l'id
' dell'anamnesi familiare per poterlo passare alla mainform. In sostanza faccio la join tra AnamnesiFamiliare e TipoParente per visualizzare il 
' nome del parente nel dgv, ma nel datatable mantengo anche l'id dell'anamnesi familiare.
Public Class UC_AnamnesiFamiliareSelezione

    Dim idPaziente As Integer = 0
    Dim esiste As Boolean = False

    Dim parentiUnici As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
        "mamma",
        "papà",
        "padre",
        "madre",
        "nonna materna",
        "nonna paterna",
        "nonno materno",
        "nonno paterno"
    }

    ' Evento per comunicare alla MainForm il parente selezionato
    Public Event ParenteSelezionato(idParente As Integer, idAnamnesi As Integer)

    Public Sub New()
        InitializeComponent()
        ConfiguraDataGrid()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo
    End Sub

    Private Async Sub FormAnamnesiFamiliareSelezione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await CaricaParentelaAsync()

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idPaziente = main.IDPazienteSelezionato

            main.MostraToast("Caricamento in corso ...")

            Await CaricaParentiPaziente()
        End If
    End Sub

    ' ====================
    ' Configurazione SfDataGrid
    ' ====================
    Private Sub ConfiguraDataGrid()
        ' SfDataGrid di sola lettura
        dgvSelezioneParente.AllowEditing = False
        dgvSelezioneParente.AllowResizingColumns = True
        dgvSelezioneParente.SelectionMode = GridSelectionMode.Single
        dgvSelezioneParente.AutoGenerateColumns = True

        ' Eventi TODO (Devo aggiungere l'evento del doubleclick che mi carica l'anamnesi familiare per quel parente)
        AddHandler dgvSelezioneParente.CellDoubleClick, AddressOf dgvSelezionePaziente_CellDoubleClick
    End Sub

    ' 🔹 Carica lista parentela dal DB
    Private Async Function CaricaParentelaAsync() As Task
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
    End Function

    Private Async Function CaricaParentiPaziente() As Task
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        Dim parentiPzQuery As String = "SELECT
                                        af.ID AS ID_AnamnesiFamiliare,
                                        tp.ID AS ID_Parente,
                                        tp.Parentela AS Parentela
                                        FROM AnamnesiFamiliare af
                                        INNER JOIN TipoParente tp ON af.ID_Parente = tp.ID
                                        WHERE af.ID_Anagrafica = @idPaziente;"
        Dim parentiPzParam As New List(Of SqlParameter) From {
            New SqlParameter("@idPaziente", idPaziente)
        }

        ' Cerco i pazienti in base ai filtri
        TableLayoutPanel1.Enabled = False

        main.MostraToast("Caricamento in corso ...")

        Dim dtParentiTrovati As DataTable = Await ConnessioneDB.EseguiQueryAsync(parentiPzQuery, parentiPzParam)

        TableLayoutPanel1.Enabled = True

        If dtParentiTrovati.Rows.Count > 0 Then
            dgvSelezioneParente.DataSource = dtParentiTrovati

            Dim colonneNascoste As New List(Of String) From {
                "ID_AnamnesiFamiliare",
                "ID_Parente"
            }

            For Each nomeCol In colonneNascoste
                ' 👇 Nascondo la colonna ID nel grid
                If dgvSelezioneParente.Columns(nomeCol) IsNot Nothing Then
                    dgvSelezioneParente.Columns(nomeCol).Visible = False
                End If
            Next

            main.MostraToast("Trovati " & dtParentiTrovati.Rows.Count & " parenti per il paziente selezionato.")
        Else
            dgvSelezioneParente.DataSource = Nothing
            main.MostraToast("Nessun parente trovato per il paziente selezionato.")
        End If
    End Function

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True
        Dim parentela As String = ComboBoxParentela.Text.Trim()

        ' Verifico se il campo Nome classe è stato compilato
        If String.IsNullOrEmpty(parentela) OrElse Not Utils.IsValidSelection(ComboBoxParentela) OrElse ComboBoxParentela.SelectedIndex = -1 Then
            esito = False
            HilightControls(True, ComboBoxParentela)
        Else
            HilightControls(False, ComboBoxParentela)
        End If

        Return esito
    End Function

    Private Async Function VerificaPresenzaParentela(idParente As Integer) As Task(Of Boolean)
        ' TODO --> devo verificare che, per alcuni parenti (es. madre, padre), non esista già un record per quel paziente

        Dim esiste As Boolean = False
        'Verifico che il parente selezionato non esista già per il paziente (solo se grado parentela è madre, padre, nonno paterno, nonno materno, nonna paterna, nonna materna
        Dim checkQuery As String = "SELECT COUNT (*) FROM AnamnesiFamiliare WHERE ID_Anagrafica = @idPaziente AND ID_Parente = @idParente"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idPaziente", idPaziente),
            New SqlParameter("@idParente", idParente)
        }
        Dim parenteCheck As Integer = CInt(Await ConnessioneDB.EseguiScalarAsync(checkQuery, checkParam))
        If parenteCheck > 0 Then
            esiste = True ' Parente già esistente
        Else
            esiste = False
        End If

        Return esiste
    End Function

    Private Async Function AggiungiParente() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

            Dim successo As Boolean = True

            Dim idParente As Integer = ComboBoxParentela.SelectedValue

            Dim esiste As Boolean = False

            ' TODO
            Try
                Dim queryClassiFarmaci As String = ""
                Dim parentelaSelezionata As String = ComboBoxParentela.Text.Trim()

                ' Verifico che non esista già un parente dello stesso tipo per il paziente selezionato,
                ' solo se il parente selezionato è nella lista di quelli univoci
                If parentiUnici.Contains(parentelaSelezionata.Trim()) Then
                    esiste = Await VerificaPresenzaParentela(idParente)
                End If

                If Not esiste Then
                    Dim insertQuery As String = "INSERT INTO AnamnesiFamiliare (ID_Anagrafica,
                                                                            ID_Parente,
                                                                            PresenzaPatologie) VALUES(
                                                                            @idPaziente,
                                                                            @idParente,
                                                                            @presenzaPatologie);"
                    Dim insertParams As New List(Of SqlParameter) From {
                        New SqlParameter("@idPaziente", idPaziente),
                        New SqlParameter("@idParente", idParente),
                        New SqlParameter("@presenzaPatologie", False)
                    }

                    If Await ConnessioneDB.EseguiNonQueryAsync(insertQuery, insertParams) > 0 Then
                        successo = True
                    Else
                        successo = False
                    End If

                    If successo Then
                        main.MostraToast("Parente aggiunto per il paziente selezionato.")
                        Await CaricaParentiPaziente()
                    End If
                Else
                    main.MostraToast("Parente già presente per il paziente selezionato.")
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

    Private Async Sub ButtonAggiungi_Click(sender As Object, e As EventArgs) Handles ButtonAggiungi.Click
        ButtonAggiungi.Enabled = False
        ComboBoxParentela.Enabled = False

        Await AggiungiParente()

        ButtonAggiungi.Enabled = True
        ComboBoxParentela.Enabled = True
    End Sub

    Private Sub ButtonSeleziona_Click(sender As Object, e As EventArgs) Handles ButtonSeleziona.Click
        SelezionaParente(dgvSelezioneParente.SelectedItem)
    End Sub

    ' ====================
    ' Doppio click su DataGridView per selezionare il paziente
    ' ====================
    Private Sub dgvSelezionePaziente_CellDoubleClick(sender As Object, e As CellClickEventArgs)
        ' Recupera il record selezionato tramite SelectedItem
        Dim record = dgvSelezioneParente.SelectedItem
        If record IsNot Nothing Then
            SelezionaParente(record)
        End If
    End Sub

    ' ====================
    ' Metodi logica per selezionare il paziente
    ' ====================
    Private Sub SelezionaParente(dataRow As Object)
        Dim drv As DataRowView = TryCast(dataRow, DataRowView)
        ' Nel datarow non ho l'ID del parente, quindi devo fare una query per recuperarlo
        If drv IsNot Nothing Then

            Dim idParenteSelezionato As Integer = Convert.ToInt32(drv("ID_Parente"))
            Dim idAnamnesiSelezionata As Integer = Convert.ToInt32(drv("ID_AnamnesiFamiliare"))

            RaiseEvent ParenteSelezionato(idParenteSelezionato, idAnamnesiSelezionata)

        End If
    End Sub
End Class