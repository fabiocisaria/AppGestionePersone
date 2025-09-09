Imports Microsoft.Data.SqlClient
Public Class UC_VisitaUrinocoltura
    Dim idVisita As Integer = -1
    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub New()
        InitializeComponent()

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

        ' ====================
        ' ComboBox
        ' ====================
        With ComboBoxEsito
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Negativo", "Positivo"}
            .SelectedIndex = -1

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With

        With DateTimePickerDataEsecuzione
            .Style.BackColor = Color.White
            .Style.BorderColor = Color.FromArgb(41, 128, 185)
            .Style.ForeColor = Color.Black
            .Dock = DockStyle.Top
        End With

        DateTimePickerDataEsecuzione.Value = Date.Now
    End Sub

    Public Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Sub FormVisitaUrinocoltura_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDPazienteSelezionato
            ' Cerco se esiste già l'anamnesi fisiologica per il paziente selezionato
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(ComboBoxEsito)
                DateTimePickerDataEsecuzione.Value = Date.Now
            End If
        End If
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim result = True

        If ComboBoxEsito.SelectedIndex = -1 Then
            HilightControls(True, ComboBoxEsito)
            result = False
        Else
            HilightControls(False, ComboBoxEsito)
        End If

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        If DateTimePickerDataEsecuzione.Value Is Nothing Then
            result = False
            HilightControls(True, DateTimePickerDataEsecuzione)
        ElseIf DateTimePickerDataEsecuzione.Value > main.DataVisitaSelezionata Then
            result = False
            HilightControls(True, DateTimePickerDataEsecuzione)
            main.MostraToast("La data di esecuzione non può essere successiva alla data della visita.")
        Else
            HilightControls(False, DateTimePickerDataEsecuzione)
        End If
        Return result
    End Function

    Private Function CercaVisita() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM VisitaUrinocoltura WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' RMN esistente per la visita selezionata

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)
            main.MostraToast("Esame urinocoltura esistente per la visita selezionata. Dati caricati.")

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            DateTimePickerDataEsecuzione.Value = CDate(dettagliVisita("DataUrinocoltura"))
            ComboBoxEsito.SelectedItem = dettagliVisita("EsitoUrinocoltura")

            Return esiste
        Else
            esiste = False
            PulisciCampi(ComboBoxEsito)
            DateTimePickerDataEsecuzione.Value = Date.Now
            Return esiste
        End If
    End Function

    Private Function SalvaDati() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            idVisita = main.IDVisitaSelezionata

            Dim successo As Boolean = False

            Dim dataEsecuzione As Date = DateTimePickerDataEsecuzione.Value
            Dim esitoUrinocoltura As Boolean
            If ComboBoxEsito.SelectedItem.ToString() = "Positivo" Then
                esitoUrinocoltura = True
            Else
                esitoUrinocoltura = False
            End If

            Try
                Dim queryUrinocoltura As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    queryUrinocoltura = "UPDATE VisitaUrinocoltura SET 
                                                          DataUrinocoltura = @dataUrinocoltura,
                                                          EsitoUrinocoltura = @esitoUrinocoltura
                                                          WHERE ID_Visita = @idVisita"
                Else
                    'Se non esiste, esegui l'VisitaUrinocoltura
                    queryUrinocoltura = "INSERT INTO VisitaUrinocoltura (
                                                    ID_Visita,
                                                    DataUrinocoltura,
                                                    EsitoUrinocoltura
                                                    ) VALUES (
                                                    @idVisita,
                                                    @dataUrinocoltura,
                                                    @esitoUrinocoltura,
                                                    @idCeppo)"
                End If

                Dim parametriUrinocoltura As New List(Of SqlParameter) From {
                    New SqlParameter("@idVisita", idVisita),
                    New SqlParameter("@dataUrinocoltura", dataEsecuzione),
                    New SqlParameter("@esitoUrinocoltura", esitoUrinocoltura)
                }

                If EseguiNonQuery(queryUrinocoltura, parametriUrinocoltura) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Esame urinocoltura aggiornato correttamente.")
                    Else
                        main.MostraToast("Esame urinocoltura salvato correttamente.")
                    End If
                Else
                    main.MostraToast("Errore imprevisto durante il salvataggio dei dati.")
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

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito As Boolean = SalvaDati()
        If esito Then
            appenaSalvati = True
            CercaVisita()
        End If
    End Sub
End Class
