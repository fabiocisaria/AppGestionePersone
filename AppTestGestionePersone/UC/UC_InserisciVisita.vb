Imports System.Runtime.InteropServices
Imports Microsoft.Data.SqlClient
Public Class UC_InserisciVisita
    Private _aggiornamentoInterno As Boolean = False
    Public Property IDVisita As Integer
    Public Property TipoVisita As String = ""
    Public Property DataVisita As Date? = Nothing
    Public Property IsHandlerAttached As Boolean = False

    Private Shared ReadOnly ControlText As New Dictionary(Of Control, String)

    Dim ucTipoVisita As String = ""

    ' Evento per comunicare alla MainForm il paziente selezionato
    Public Event NuovaVisitaInserita(IDVisita As Integer, TipoVisita As String, DataVisita As Date)

    Public Sub New(tipoVisita As String)
        InitializeComponent()

        ucTipoVisita = tipoVisita

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo
    End Sub

    Private Sub UCInserisciVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerDataVisita.Value = DateTime.Now.Date

        LabelTipoVisita.Text = ucTipoVisita

        ControlText(TextBoxMotivo) = "Motivo"
        TextBoxMotivo.Text = ControlText(TextBoxMotivo)
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBoxMotivo.Enter
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ""
            ctrl.ForeColor = Theme.TextBoxForeColor
            ctrl.Font = Theme.TxtFont
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBoxMotivo.Leave
        Dim ctrl As Control = DirectCast(sender, Control)
        If String.IsNullOrWhiteSpace(ctrl.Text) Then
            ctrl.Text = ControlText(ctrl)
            ctrl.ForeColor = Theme.FindColor
            ctrl.Font = Theme.TxtFontItalic
        End If
    End Sub

    Public Sub ImpostaTipoVisita(tipo As String)
        ucTipoVisita = tipo
        LabelTipoVisita.Text = tipo
    End Sub

    Private Async Function InserisciVisitaAsync() As Task(Of (Successo As Boolean, NewID As Integer))
        Dim successo As Boolean = False

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idPaziente As Integer = main.IDPazienteSelezionato

        Dim idVisita As Integer = -1
        Dim dataVisita As Date? = Nothing

        Dim motivo As Object

        Try
            If ucTipoVisita = "Prima visita" Then
                LabelTipoVisita.Text = "Prima visita"
                Dim queryPrimaVisita As String = "SELECT COUNT(*) FROM Visite WHERE ID_Anagrafica=@ID AND TipoVisita='Prima visita'"
                Dim paramPrimaVisita As New List(Of SqlParameter) From {
                    New SqlParameter("@ID", idPaziente)
                }

                If Await ConnessioneDB.EseguiScalarAsync(queryPrimaVisita, paramPrimaVisita) > 0 Then
                    MessageBox.Show("Esiste già una prima visita per questo paziente!")
                    Return (False, -1)
                End If
            ElseIf ucTipoVisita = "Controllo" Then
                LabelTipoVisita.Text = "Prima visita"
                Dim queryPrimaVisita As String = "SELECT ID, DataVisita FROM Visite WHERE ID_Anagrafica=@ID AND TipoVisita='Prima visita'"
                Dim paramControllo As New List(Of SqlParameter) From {
                    New SqlParameter("@ID", idPaziente)
                }
                Dim dt As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryPrimaVisita, paramControllo)

                If dt.Rows.Count = 0 Then
                    main.MostraToast("Impossibile inserire un controllo: non esiste ancora una prima visita per questo paziente.")
                    Return (False, -2)
                Else
                    ' Verifica che la data del controllo sia successiva alla prima visita
                    Dim dataPrimaVisita As DateTime = Convert.ToDateTime(dt.Rows(0)("DataVisita"))
                    If DateTimePickerDataVisita.Value <= dataPrimaVisita Then
                        main.MostraToast("La data del controllo deve essere successiva alla prima visita!")
                        Return (False, -3)
                    End If

                    ' Verifica che non ci sia già una visita per quel paziente nella stessa data
                    Dim visitaPresente As Integer = 0
                    Dim queryVisitaPresente As String = "SELECT COUNT(*) FROM Visite WHERE ID_Anagrafica = @ID_Anagrafica AND CAST(DataVisita AS DATE) = @DataVisita"
                    Dim parameterVisitaPresente As New List(Of SqlParameter) From {
                        New SqlParameter("@ID_Anagrafica", idPaziente),
                        New SqlParameter("@DataVisita", DateTimePickerDataVisita.Value)
                    }

                    Dim dtVisitaPresente As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryVisitaPresente, parameterVisitaPresente)
                    If dtVisitaPresente.Rows(0)(0) > 0 Then
                        main.MostraToast("Esiste già una visita per questo paziente nella stessa data!")
                        Return (False, -3)
                    End If
                End If
            End If

            ' Inserimento

            If String.IsNullOrWhiteSpace(TextBoxMotivo.Text.Trim()) OrElse TextBoxMotivo.Text.Trim() = ControlText(TextBoxMotivo) Then
                motivo = DBNull.Value
            Else
                motivo = TextBoxMotivo.Text.Trim()
            End If

            Dim query As String = "INSERT INTO Visite (ID_Anagrafica, DataVisita, TipoVisita, MotivoVisita) VALUES (@idAna, @data, @tipoVisita, @motivo)"
            Dim parametri As New List(Of SqlParameter) From {
                New SqlParameter("@idAna", main.IDPazienteSelezionato),
                New SqlParameter("@data", DateTimePickerDataVisita.Value),
                New SqlParameter("@tipoVisita", ucTipoVisita),
                New SqlParameter("@motivo", motivo)
            }

            If Await ConnessioneDB.EseguiNonQueryAsync(query, parametri) > 0 Then
                main.MostraToast("Visita salvata con successo.")
                successo = True
            Else
                Return (False, -4)
            End If

            ' Devo estrarre il codice univoco della visita appena inserita
            Dim queryIDVisita As String = "SELECT ID FROM Visite WHERE ID_Anagrafica = @IDAnagrafica AND DataVisita = @DataVisita"
            Dim parametriIDVisita As New List(Of SqlParameter) From {
                    New SqlParameter("@IDAnagrafica", main.IDPazienteSelezionato),
                    New SqlParameter("@DataVisita", DateTimePickerDataVisita.Value)
            }

            ' Estraggo l'ID visita associato alla visita appena inserita
            Dim dtVisita As DataTable = Await ConnessioneDB.EseguiQueryAsync(queryIDVisita, parametriIDVisita)
            If dtVisita.Rows.Count > 0 Then
                idVisita = Convert.ToInt32(dtVisita.Rows(0)("ID"))
                Me.IDVisita = idVisita
                Me.DataVisita = DateTimePickerDataVisita.Value
                Me.TipoVisita = ucTipoVisita
            End If

            PulisciCampi(DateTimePickerDataVisita, TextBoxMotivo)

            Return (successo, idVisita)
        Catch ex As Exception
            MessageBox.Show("Errore imprevisto: " & ex.Message)
            Return (False, -5)
        End Try
    End Function

    Private Async Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Disabilito tutti i controlli
        TableLayoutPanel1.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await InserisciVisitaAsync()

        TableLayoutPanel1.Enabled = True

        If esito.Successo Then
            RaiseEvent NuovaVisitaInserita(IDVisita, TipoVisita, DataVisita)
        Else
            Select Case esito.NewID
                Case -1
                    ' Prima visita già esistente
                    If MessageBox.Show("Esiste già una prima visita. Vuoi inserire un controllo?",
                                       "Prima visita già presente",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) = DialogResult.Yes Then

                        Me.ImpostaTipoVisita("Controllo")
                    End If


                Case -2
                    ' Nessuna prima visita esistente
                    If MessageBox.Show("Impossibile inserire un controllo per il paziente selezionato.",
                                       "Inserire una prima una prima visita?",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) = DialogResult.Yes Then

                        Me.ImpostaTipoVisita("Prima Visita")
                    End If
                Case -3
                    ' Data controllo non valida o visita già esistente nella stessa data
                Case -4
                    main.MostraToast("Errore durante il salvataggio della visita.")
                Case -5
                    ' Errore imprevisto
            End Select
        End If
    End Sub
End Class
