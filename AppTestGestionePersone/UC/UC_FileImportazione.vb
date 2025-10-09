Imports System.IO
Imports System.Windows.Documents
Imports Microsoft.Data.SqlClient
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid.Interactivity
Imports Syncfusion.WinForms.Input
Imports Syncfusion.WinForms.ListView.Styles

Public Class UC_FileImportazione
    Inherits UserControl

    ' ====================
    ' Variabili e proprietà
    ' ====================
    Private _nomeFile As String = ""
    Private _selezionato As Boolean = False

    Private Shared ReadOnly ControlText As New Dictionary(Of Control, String)

    Public Property _tabellaDestinazione = ""

    ' ====================
    ' Costruttore
    ' ====================
    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo

        TextBoxNomeFile.Enabled = False

        ' ==========
        ' SfDataGrid 
        ' ==========
        ConfiguraDataGrid()
    End Sub

    Private Async Sub UC_FileImportazione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await CaricaTabelle()

        ControlText(TextBoxNomeFile) = "Seleziona un file"
    End Sub

    ' ====================
    ' Configurazione SfDataGrid
    ' ====================
    Private Sub ConfiguraDataGrid()
        ' SfDataGrid: colonne generate manualmente
        dgvAnteprima.AutoGenerateColumns = True

        ' Impostazioni generali
        dgvAnteprima.AllowEditing = False
        dgvAnteprima.AllowResizingColumns = True
        dgvAnteprima.SelectionMode = GridSelectionMode.Multiple
        dgvAnteprima.NavigationMode = NavigationMode.Row

        ' Controllo colonna Seleziona
        If dgvAnteprima.Columns.Any(Function(c) c.MappingName = "Seleziona") = False Then
            Dim chkCol As New GridCheckBoxSelectorColumn() With {
            .MappingName = "Seleziona",
            .HeaderText = "✔",
            .Width = 40,
            .AllowEditing = True, ' 🔑 questa colonna è modificabile
            .AllowCheckBoxOnHeader = True ' ✅ Attiva checkbox nell'intestazione
        }
            dgvAnteprima.Columns.Insert(0, chkCol)
        Else
            ' Se esiste già, mi assicuro che sia editabile
            Dim col = TryCast(dgvAnteprima.Columns("Seleziona"), GridCheckBoxColumn)
            If col IsNot Nothing Then col.AllowEditing = True
        End If
    End Sub

    ' Carico l'elenco tabelle dal DB
    Private Async Function CaricaTabelle() As Task

        ComboBoxTabelle.Enabled = False
        Try
            Dim query As String = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME"
            Dim dtStruct As DataTable = Await ConnessioneDB.EseguiQueryAsync(query)

            ComboBoxTabelle.DataSource = dtStruct
            ComboBoxTabelle.DisplayMember = "TABLE_NAME"
            ComboBoxTabelle.ValueMember = "TABLE_NAME"

            If dtStruct.Rows.Count = 0 Then
                Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
                main.MostraToast("Nessuna tabella trovata nel database.")
                Logs.WriteLog("Tabella non trovata.", "INFO")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Errore nel caricamento della lista tabelle: " & ex.Message)
            Logs.WriteLog("Errore nel caricamento della lista tabelle: " & ex.Message, "ERROR")
        Finally
            ComboBoxTabelle.Enabled = True
        End Try
    End Function

    Private Sub ButtonSfoglia_Click(sender As Object, e As EventArgs) Handles ButtonSfoglia.Click
        ' Creo il dialogo di apertura file
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Seleziona un file da importare"
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|Tutti i file (*.*)|*.*"
            openFileDialog.FilterIndex = 2 ' Imposta Excel come filtro predefinito (1=CSV, 2=Excel, 3=Tutti i file)
            openFileDialog.Multiselect = False ' uno alla volta

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Mostro il percorso nel textbox (se ne hai uno) oppure lo memorizzo
                TextBoxNomeFile.Text = openFileDialog.FileName
            End If
        End Using
    End Sub

    Private Sub SfButtonCarica_Click(sender As Object, e As EventArgs) Handles SfButtonCarica.Click
        Try
            Dim filePath As String = TextBoxNomeFile.Text.Trim()

            If String.IsNullOrEmpty(filePath) OrElse Not File.Exists(filePath) Then
                MessageBox.Show("Seleziona un file valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Logs.WriteLog("Seleziona un file valido.", "INFO")
                Return
            End If

            ' Uso ImportUtils per caricare il file (sceglie CSV/Excel in base all'estensione)
            Dim dt As DataTable = ImportUtils.LeggiFile(filePath)

            ' Popolo la SfDataGrid
            dgvAnteprima.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Errore durante il caricamento: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Logs.WriteLog("Errore durante il caricamento: " & ex.Message, "ERROR")
        End Try
    End Sub

    ' Estraggo la lista ed il tipo delle colonne dalla tabella selezionata
    Private Async Function OttieniSchemaTabella(nomeTabella As String) As Task(Of Dictionary(Of String, String))
        Dim query As String = $"SELECT COLUMN_NAME, DATA_TYPE 
                            FROM INFORMATION_SCHEMA.COLUMNS 
                            WHERE TABLE_NAME = @NomeTabella
                              AND COLUMN_NAME <> 'ID'"

        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@NomeTabella", nomeTabella)
        }

        Dim schema As DataTable = Await ConnessioneDB.EseguiQueryAsync(query, param)

        Dim columnTypes As New Dictionary(Of String, String)

        For Each r As System.Data.DataRow In schema.Rows
            columnTypes.Add(r("COLUMN_NAME").ToString(), r("DATA_TYPE").ToString())
        Next

        Select Case nomeTabella
            Case "AnamnesiSociale"
                columnTypes.Add("CodiceIdentificativo", "varchar")
        End Select

        Return columnTypes
    End Function

    Private Function CheckSelezione() As Boolean
        Dim dt As DataTable = TryCast(dgvAnteprima.DataSource, DataTable)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            main.MostraToast("Nessun dato da importare.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(ComboBoxTabelle.SelectedValue?.ToString()) Then
            main.MostraToast("Seleziona una tabella di destinazione.")
            Return False
        End If

        If Not Utils.IsValidSelection(ComboBoxTabelle) Then
            main.MostraToast("La tabella non esiste nel DB.")
            Return False
        End If

        If dgvAnteprima.SelectedItems Is Nothing OrElse dgvAnteprima.SelectedItems.Count = 0 Then
            main.MostraToast("Selezionare almeno una riga da importare.")
            Return False
        End If

        Return True
    End Function

    Private Async Function ImportaRigheConParametri(nomeTabella As String) As Task(Of Boolean)

        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True
        If selezioneOK Then
            Try
                Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

                'If String.IsNullOrWhiteSpace(nomeTabella) Then
                '    MessageBox.Show("Seleziona una tabella.")
                '    Return
                'End If

                Dim schema As Dictionary(Of String, String) = Await OttieniSchemaTabella(nomeTabella)

                If schema.Count = 0 Then
                    esito = False
                    main.MostraToast("Tabella non trovata.")
                    Return esito
                End If

                Dim colonne As New List(Of String)

                For Each colonnaNome As String In schema.Keys
                    colonne.Add(colonnaNome)
                Next

                Dim righeImportate As Integer = 0

                Dim dt As DataTable = CType(dgvAnteprima.DataSource, DataTable)

                For Each obj In dgvAnteprima.SelectedItems
                    Dim drv As DataRowView = TryCast(obj, DataRowView)
                    Dim paramList As New List(Of SqlParameter)

                    Dim esiste As Boolean = False

                    If drv IsNot Nothing Then
                        For Each col In colonne
                            If col <> "Seleziona" And col <> "ID_Anagrafica" Then
                                Dim valore = drv(col)
                                Dim valoreCast As Object = DBNull.Value
                                If Not IsDBNull(valore) Then
                                    Select Case schema(col).ToLower()
                                        Case "int", "bigint", "smallint"
                                            valoreCast = Convert.ToInt32(valore)
                                        Case "decimal", "numeric", "money"
                                            valoreCast = Convert.ToDecimal(valore)
                                        Case "float", "real"
                                            valoreCast = Convert.ToDouble(valore)
                                        Case "bit"
                                            valoreCast = Convert.ToBoolean(valore)
                                        Case "datetime", "smalldatetime", "date", "datetime2"
                                            valoreCast = Convert.ToDateTime(valore)
                                        Case Else
                                            valoreCast = Convert.ToString(valore)
                                    End Select
                                End If

                                Dim valoreFinale As Object

                                If valoreCast Is Nothing OrElse (TypeOf valore Is String AndAlso String.IsNullOrWhiteSpace(CStr(valore))) Then
                                    valoreFinale = DBNull.Value
                                ElseIf IsDBNull(valoreCast) Then
                                    valoreFinale = DBNull.Value
                                Else
                                    valoreFinale = valoreCast
                                End If

                                paramList.Add(New SqlParameter("@" & col, valoreFinale))

                                'paramList.Add(New SqlParameter("@" & col, If(IsDBNull(valore), DBNull.Value, valoreCast)))
                            End If
                        Next
                    End If



                    Select Case nomeTabella
                        Case "Anagrafica"
                            Dim codiceIDParam = paramList.FirstOrDefault(Function(p) p.ParameterName = "@CodiceIdentificativo")

                            Dim codiceID As Object = Nothing

                            If codiceIDParam IsNot Nothing Then
                                codiceID = codiceIDParam.Value
                            End If

                            Dim checkQuery As String = "SELECT COUNT(*) FROM Anagrafica
                                                        WHERE CodiceIdentificativo = @CodiceID"

                            Dim checkParam As New List(Of SqlParameter) From {
                                   New SqlParameter("@CodiceID", codiceID)
                                }

                            esiste = Await ConnessioneDB.EseguiScalarAsync(checkQuery, checkParam) > 0

                            If esiste Then
                                Logs.WriteLog($"Anagrafica con CodiceIdentificativo '{codiceID}' già esistente. Riga non importata.", "WARNING")
                            End If
                        Case "Visite"
                            'TODO
                        Case "TipoParente"
                            'TODO
                        Case "AnamnesiSociale"
                            Dim codiceIDParam = paramList.FirstOrDefault(Function(p) p.ParameterName = "@CodiceIdentificativo")

                            Dim codiceID As Object = Nothing

                            If codiceIDParam IsNot Nothing Then
                                codiceID = codiceIDParam.Value
                            End If

                            Dim checkQuery As String = "SELECT ID FROM Anagrafica
                                                        WHERE CodiceIdentificativo = @CodiceID"

                            Dim checkParam As New List(Of SqlParameter) From {
                                   New SqlParameter("@CodiceID", codiceID)
                                }

                            Dim dtId As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

                            If dtId.Rows.Count > 0 Then
                                Dim idAnagrafica As Integer = Convert.ToInt32(dtId.Rows(0)("ID"))
                                paramList.Insert(0, New SqlParameter("@ID_Anagrafica", idAnagrafica))

                                Dim checkQuery2 As String = "SELECT COUNT(*) FROM AnamnesiSociale
                                                             WHERE ID_Anagrafica = @IDAnagrafica"
                                Dim checkParam2 As New List(Of SqlParameter) From {
                                   New SqlParameter("@IDAnagrafica", idAnagrafica)
                                }
                                esiste = Await ConnessioneDB.EseguiScalarAsync(checkQuery2, checkParam2) > 0
                                If esiste Then
                                    Logs.WriteLog($"Anamnesi sociale con CodiceIdentificativo '{codiceID}' già esistente. Riga non importata.", "WARNING")
                                End If
                            Else
                                esito = False
                                main.MostraToast($"Anagrafica con CodiceIdentificativo '{codiceID}' non trovata. Righe correlate non importate.")
                                Logs.WriteLog($"Anagrafica con CodiceIdentificativo '{codiceID}' non trovata. Righe correlate non importate.", "WARNING")
                                Return esito
                            End If
                        Case "TerapieRiabilitative"
                            'TODO
                        Case "Farmaci"
                            'TODO
                        Case "FarmacoVieSomministrazione"
                            'TODO
                        Case "ClassiFarmaci"
                            'TODO
                    End Select

                    If Not esiste Then
                        If nomeTabella <> "Anagrafica" Then
                            paramList.RemoveAll(Function(p) String.Equals(p.ParameterName, "@CodiceIdentificativo", StringComparison.OrdinalIgnoreCase))
                        End If
                        Dim columnNames = paramList.Select(Function(p) p.ParameterName.Substring(1)).ToList()
                        Dim paramPlaceholders = paramList.Select(Function(p) p.ParameterName).ToList()

                        Dim query As String = $"INSERT INTO {nomeTabella} ({String.Join(", ", columnNames)}) VALUES ({String.Join(", ", paramPlaceholders)})"

                        Try
                            Await ConnessioneDB.EseguiNonQueryAsync(query, paramList)
                            righeImportate += 1

                            ' --- Crea una stringa con tutti i parametri e i valori ---
                            Dim parametriDettaglio As String =
                            String.Join(", ", paramList.Select(Function(p)
                                                                   Dim valore = If(p.Value Is DBNull.Value, "NULL", p.Value.ToString())
                                                                   Return $"{p.ParameterName}={valore}"
                                                               End Function))
                            ' --- Scrivi nel log ---
                            Logs.WriteLog($"Riga {righeImportate} importata in '{nomeTabella}'. Parametri: {parametriDettaglio}", "OK")
                            Logs.WriteLog($"Parametri: {parametriDettaglio}", "OK")
                        Catch ex As Exception
                            Logs.WriteLog($"Errore durante l'importazione della riga {righeImportate + 1} in '{nomeTabella}': {ex.Message}", "ERROR")
                        End Try
                    End If
                Next

                main.MostraToast($"Importazione completata! Righe importate: {righeImportate}")
                Logs.WriteLog($"Importazione completata! Righe importate: {righeImportate}.", "OK")

                Return esito
            Catch ex As Exception
                MessageBox.Show("Errore importazione: " & ex.Message)
                Logs.WriteLog("Errore importazione: " & ex.Message, "ERROR")
            End Try
        Else
            esito = False
        End If

        Return esito
    End Function

    Private Sub ButtonAnnulla_Click(sender As Object, e As EventArgs) Handles ButtonAnnulla.Click
        PulisciCampi()
        dgvAnteprima.DataSource = Nothing
    End Sub

    Private Async Sub ButtonImporta_Click(sender As Object, e As EventArgs) Handles ButtonImporta.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Disabilito tutti i controlli
        TableLayoutPanelImport.Enabled = False

        main.MostraToast("Salvataggio in corso ...")

        Dim nomeTabella As String = ComboBoxTabelle.Text ' o SelectedValue se impostato

        Dim esito = Await ImportaRigheConParametri(nomeTabella)

        TableLayoutPanelImport.Enabled = True
        If esito Then
            PulisciCampi()
        End If
    End Sub
End Class
