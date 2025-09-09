Imports System.Runtime.InteropServices
Imports Microsoft.Data.SqlClient
Public Class UC_InserisciVisita
    Private _aggiornamentoInterno As Boolean = False
    Public Property IDVisita As Integer
    Public Property TipoVisita As String = ""
    Public Property DataVisita As Date? = Nothing
    Public Property IsHandlerAttached As Boolean = False

    Dim ucTipoVisita As String = ""

    ' Evento per comunicare alla MainForm il paziente selezionato
    Public Event NuovaVisitaInserita(IDVisita As Integer, TipoVisita As String, DataVisita As Date)

    Public Sub New(tipoVisita As String)
        InitializeComponent()
        ucTipoVisita = tipoVisita
    End Sub

    Private Sub UCInserisciVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerDataVisita.Format = DateTimePickerFormat.Short
        DateTimePickerDataVisita.Value = DateTime.Now.Date
        LabelTipoVisita.Text = ucTipoVisita
    End Sub

    Public Sub ImpostaTipoVisita(tipo As String)
        ucTipoVisita = tipo
        LabelTipoVisita.Text = tipo
    End Sub

    Private Function InserisciVisita() As (Successo As Boolean, NewID As Integer)
        Dim successo As Boolean = False

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idPaziente As Integer = main.IDPazienteSelezionato

        Dim idVisita As Integer = -1
        Dim dataVisita As Date? = Nothing

        Try
            If ucTipoVisita = "Prima visita" Then
                LabelTipoVisita.Text = "Prima visita"
                Dim queryPrimaVisita As String = "SELECT COUNT(*) FROM Visite WHERE ID_Anagrafica=@ID AND TipoVisita='Prima visita'"
                Dim paramPrimaVisita As New List(Of SqlParameter) From {
                    New SqlParameter("@ID", idPaziente)
                }

                If EseguiScalar(queryPrimaVisita, paramPrimaVisita) > 0 Then
                    MessageBox.Show("Esiste già una prima visita per questo paziente!")
                    Return (False, -1)
                End If
            ElseIf ucTipoVisita = "Controllo" Then
                LabelTipoVisita.Text = "Prima visita"
                Dim queryPrimaVisita As String = "SELECT ID, DataVisita FROM Visite WHERE ID_Anagrafica=@ID AND TipoVisita='Prima visita'"
                Dim paramControllo As New List(Of SqlParameter) From {
                    New SqlParameter("@ID", idPaziente)
                }
                Dim dt As DataTable = EseguiQuery(queryPrimaVisita, paramControllo)

                If dt.Rows.Count = 0 Then
                    main.MostraToast("Impossibile inserire un controllo: non esiste ancora una prima visita per questo paziente.")
                    Return (False, -2)
                Else
                    ' Verifica che la data del controllo sia successiva alla prima visita
                    Dim dataPrimaVisita As DateTime = Convert.ToDateTime(dt.Rows(0)("DataVisita"))
                    If DateTimePickerDataVisita.Value.Date <= dataPrimaVisita Then
                        main.MostraToast("La data del controllo deve essere successiva alla prima visita!")
                        Return (False, -3)
                    End If

                    ' Verifica che non ci sia già una visita per quel paziente nella stessa data
                    Dim visitaPresente As Integer = 0
                    Dim queryVisitaPresente As String = "SELECT COUNT(*) FROM Visite WHERE ID_Anagrafica = @ID_Anagrafica AND CAST(DataVisita AS DATE) = @DataVisita"
                    Dim parameterVisitaPresente As New List(Of SqlParameter) From {
                        New SqlParameter("@ID_Anagrafica", idPaziente),
                        New SqlParameter("@DataVisita", DateTimePickerDataVisita.Value.Date)
                    }

                    Dim dtVisitaPresente As DataTable = EseguiQuery(queryVisitaPresente, parameterVisitaPresente)
                    If dtVisitaPresente.Rows(0)(0) > 0 Then
                        main.MostraToast("Esiste già una visita per questo paziente nella stessa data!")
                        Return (False, -3)
                    End If
                End If
            End If

            ' Inserimento
            Dim query As String = "INSERT INTO Visite (ID_Anagrafica, DataVisita, TipoVisita, MotivoVisita) VALUES (@idAna, @data, @tipoVisita, @motivo)"
            Dim parametri As New List(Of SqlParameter) From {
                New SqlParameter("@idAna", main.IDPazienteSelezionato),
                New SqlParameter("@data", DateTimePickerDataVisita.Value.Date),
                New SqlParameter("@tipoVisita", ucTipoVisita),
                New SqlParameter("@motivo", TextBoxMotivo.Text.Trim())
            }

            If EseguiNonQuery(query, parametri) > 0 Then
                main.MostraToast("Visita salvata con successo.")
                successo = True
            Else
                Return (False, -4)
            End If

            ' Devo estrarre il codice univoco della visita appena inserita
            Dim queryIDVisita As String = "SELECT ID FROM Visite WHERE ID_Anagrafica = @IDAnagrafica AND DataVisita = @DataVisita"
            Dim parametriIDVisita As New List(Of SqlParameter) From {
                    New SqlParameter("@IDAnagrafica", main.IDPazienteSelezionato),
                    New SqlParameter("@DataVisita", DateTimePickerDataVisita.Value.Date)
            }

            ' Estraggo l'ID visita associato alla visita appena inserita
            Dim dtVisita As DataTable = EseguiQuery(queryIDVisita, parametriIDVisita)
            If dtVisita.Rows.Count > 0 Then
                idVisita = Convert.ToInt32(dtVisita.Rows(0)("ID"))
                Me.IDVisita = idVisita
                Me.DataVisita = DateTimePickerDataVisita.Value.Date
                Me.TipoVisita = ucTipoVisita
            End If

            PulisciCampi(DateTimePickerDataVisita, TextBoxMotivo)

            Return (successo, idVisita)
        Catch ex As Exception
            MessageBox.Show("Errore imprevisto: " & ex.Message)
            Return (False, -5)
        End Try
    End Function

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito = InserisciVisita()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

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
