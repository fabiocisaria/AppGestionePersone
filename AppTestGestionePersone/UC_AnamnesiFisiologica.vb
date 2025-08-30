Public Class UC_AnamnesiFisiologica
    Private _bmi As Double = 0
    Dim idPaziente As Integer = -1
    Dim esiste As Boolean = False
    Public Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idPaziente = main.IDPazienteSelezionato
            esiste = CercaAnamnesi()
            If Not esiste Then
                ResetUC()
            End If
        End If
    End Sub
    Private Sub FormAnamnesiFisiologica_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idPaziente = main.IDPazienteSelezionato
            ' Cerco se esiste già l'anamnesi fisiologica per il paziente selezionato
            esiste = CercaAnamnesi()
            If Not esiste Then
                ResetUC()
                'PulisciCampi(TableLayoutPanelAnamnesiFisiologica)
            End If
        End If
    End Sub

    Private Sub ComboBoxQuantita_CheckedChanged(sender As Object, e As EventArgs) Handles ComboBoxQuantita.SelectedIndexChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        If ComboBoxQuantita.SelectedItem Is Nothing Then
            PulisciCampi(ComboBoxTipo)
            SetControlsEnabled(False, ComboBoxTipo)
        ElseIf ComboBoxQuantita.SelectedItem.ToString() = "No" Then
            PulisciCampi(ComboBoxTipo)
            SetControlsEnabled(False, ComboBoxTipo)
        Else
            SetControlsEnabled(True, ComboBoxTipo)
        End If
    End Sub

    Private Sub ResetUC()
        PulisciCampi(TextBoxAltezza, TextBoxPeso, TextBoxAllergie, TextBoxIntolleranze, ComboBoxIdratazione, ComboBoxQuantita, ComboBoxTipo)
        SetControlsEnabled(False, ComboBoxTipo)
    End Sub

    Public Sub New()
        InitializeComponent()
        SetControlsEnabled(False, ComboBoxTipo)
    End Sub

    Private Sub TextBoxAltezza_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAltezza.TextChanged, TextBoxPeso.TextChanged
        CalcolaBMI()
    End Sub

    Private Function CalcolaBMI() As Double
        Dim altezza As Double
        Dim peso As Double

        If Double.TryParse(TextBoxAltezza.Text, altezza) AndAlso Double.TryParse(TextBoxPeso.Text, peso) Then
            ' Altezza in metri per formula BMI
            Dim altezzaMetri As Double = altezza / 100
            If altezzaMetri > 0 Then
                _bmi = peso / (altezzaMetri * altezzaMetri)
                TextBoxBMI.Text = Math.Round(_bmi, 1).ToString()
            End If
        Else
            TextBoxBMI.Text = ""
            _bmi = 0
        End If
        Return _bmi
    End Function

    Private Function CheckSelezione() As Boolean
        Dim successo As Boolean = True

        Dim altezza As Double
        Dim peso As Double
        Dim bmi As Double = Math.Round(_bmi, 1)
        Dim idratazione As String = ""
        Dim intolleranze As Object
        Dim allergie As Object
        Dim fumoQuantita As String = ""
        Dim fumoTipo As Object

        If TextBoxAltezza.Text = 0 Then
            HilightControls(True, TextBoxAltezza)
            successo = False
        Else
            HilightControls(False, TextBoxAltezza)
        End If

        If TextBoxPeso.Text = 0 Then
            HilightControls(True, TextBoxPeso)
            successo = False
        Else
            HilightControls(False, TextBoxPeso)
        End If

        If ComboBoxIdratazione.SelectedItem Is Nothing Then
            HilightControls(True, ComboBoxIdratazione)
            successo = False
        Else
            HilightControls(False, ComboBoxIdratazione)
        End If



        If ComboBoxQuantita.SelectedItem Is Nothing Then
            HilightControls(True, ComboBoxQuantita)
            successo = False
        Else
            HilightControls(False, ComboBoxQuantita)
        End If

        If ComboBoxQuantita.SelectedItem IsNot Nothing Then
            If ComboBoxQuantita.SelectedItem.ToString() <> "No" Then
                If ComboBoxTipo.SelectedItem Is Nothing Then
                    HilightControls(True, ComboBoxTipo)
                    successo = False
                Else
                    HilightControls(False, ComboBoxTipo)
                End If
            End If
        End If

        If successo = False Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            main.MostraToast("Compilare tutti i campi obbligatori.")
        Else
            altezza = Double.TryParse(TextBoxAltezza.Text, altezza)
            peso = Double.TryParse(TextBoxPeso.Text, altezza)
            bmi = Double.TryParse(TextBoxBMI.Text, altezza)
            idratazione = ComboBoxIdratazione.SelectedItem.ToString()
            intolleranze = TextBoxIntolleranze.Text
            allergie = TextBoxAllergie.Text
            fumoQuantita = ComboBoxQuantita.SelectedItem.ToString()

            ' Inserisco valori null se i campi non obbligatori sono vuoti
            ' Intolleranza
            If String.IsNullOrWhiteSpace(TextBoxIntolleranze.Text) Then
                intolleranze = DBNull.Value
            Else
                intolleranze = TextBoxIntolleranze.Text
            End If

            'Allergie
            If String.IsNullOrWhiteSpace(TextBoxAllergie.Text) Then
                allergie = DBNull.Value
            Else
                allergie = TextBoxAllergie.Text
            End If

            'Tipo sigaretta (se la persona non è fumatrice)
            If ComboBoxTipo.SelectedItem Is Nothing Then
                fumoTipo = DBNull.Value
            Else
                fumoTipo = ComboBoxTipo.SelectedItem.ToString()
            End If
        End If

        Return successo
    End Function

    ' TODO
    Private Function CercaAnamnesi() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idPaziente = main.IDPazienteSelezionato

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM AnamnesiFisiologica WHERE ID_Anagrafica = @idAnagrafica"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idAnagrafica", idPaziente)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' anamnesi fisiologica esistente

            Dim dettagliAnamnesi As DataRow = dtCheck.Rows(0)
            main.MostraToast("Anamnesi fisiologica esistente per il paziente selezionato. Dati caricati.")

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            TextBoxPeso.Text = dettagliAnamnesi("Peso")
            TextBoxAltezza.Text = dettagliAnamnesi("Altezza")
            TextBoxBMI.Text = dettagliAnamnesi("BMI")
            ComboBoxIdratazione.SelectedItem = dettagliAnamnesi("Idratazione").ToString()
            TextBoxIntolleranze.Text = If(IsDBNull(dettagliAnamnesi("Intolleranze")), "", dettagliAnamnesi("Intolleranze").ToString())
            TextBoxAllergie.Text = If(IsDBNull(dettagliAnamnesi("Allergie")), "", dettagliAnamnesi("Allergie").ToString())
            ComboBoxQuantita.SelectedItem = dettagliAnamnesi("FumoQuantita").ToString()
            ComboBoxTipo.SelectedItem = dettagliAnamnesi("TipoSigaretta").ToString()
        Else
            esiste = False
            PulisciCampi(TableLayoutPanelAnamnesiFisiologica)
        End If

        Return esiste
    End Function

    Private Function SalvaDati() As Boolean
        Dim selezioneOK As Boolean = CheckSelezione()

        If selezioneOK Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idPaziente = main.IDPazienteSelezionato

            Dim successo As Boolean = True

            Dim altezza As Double
            Dim peso As Double
            Dim bmi As Double = Math.Round(_bmi, 1)
            Dim idratazione As String = ComboBoxIdratazione.SelectedItem.ToString()
            Dim intolleranze As Object
            If String.IsNullOrWhiteSpace(TextBoxIntolleranze.Text) Then
                intolleranze = DBNull.Value
            Else
                intolleranze = TextBoxIntolleranze.Text
            End If

            Dim allergie As Object
            If String.IsNullOrWhiteSpace(TextBoxAllergie.Text) Then
                allergie = DBNull.Value
            Else
                allergie = TextBoxAllergie.Text
            End If

            Dim fumoQuantita As String = ComboBoxQuantita.SelectedItem.ToString()
            Dim fumoTipo As Object
            If ComboBoxTipo.SelectedItem Is Nothing Then
                fumoTipo = DBNull.Value
            Else
                fumoTipo = ComboBoxTipo.SelectedItem.ToString()
            End If

            Double.TryParse(TextBoxAltezza.Text, altezza)
                Double.TryParse(TextBoxPeso.Text, peso)
                Double.TryParse(TextBoxBMI.Text, bmi)

                ' TODO
                Try
                    Dim queryAnamnesiFisio As String = ""

                    If esiste Then
                        queryAnamnesiFisio = "UPDATE AnamnesiFisiologica SET 
                                                          Altezza = @altezza,
                                                          Peso = @peso,
                                                          BMI = @bmi,
                                                          Idratazione = @idratazione,
                                                          Intolleranze = @intolleranze,
                                                          Allergie = @allergie,
                                                          FumoQuantita = @fumoQuantita,
                                                          TipoSigaretta = @tipoSigaretta
                                                          WHERE ID_Anagrafica = @IDAnagrafica"
                    Else
                        queryAnamnesiFisio = "INSERT INTO AnamnesiFisiologica (
                                                        ID_Anagrafica,
                                                        Altezza,
                                                        Peso,
                                                        BMI,
                                                        Idratazione,
                                                        Intolleranze,
                                                        Allergie,
                                                        FumoQuantita,
                                                        TipoSigaretta
                                                        ) VALUES (
                                                        @IDAnagrafica,
                                                        @Altezza,
                                                        @Peso,
                                                        @BMI,
                                                        @Idratazione,
                                                        @Intolleranze,
                                                        @Allergie,
                                                        @fumoQuantita,
                                                        @tipoSigaretta)"
                    End If

                    Dim parametriAnamnesiFisio As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@IDAnagrafica", idPaziente),
                    New SqlClient.SqlParameter("@Altezza", altezza),
                    New SqlClient.SqlParameter("@Peso", peso),
                    New SqlClient.SqlParameter("@BMI", bmi),
                    New SqlClient.SqlParameter("@Idratazione", idratazione),
                    New SqlClient.SqlParameter("@Intolleranze", intolleranze),
                    New SqlClient.SqlParameter("@Allergie", allergie),
                    New SqlClient.SqlParameter("@FumoQuantita", fumoQuantita),
                    New SqlClient.SqlParameter("@TipoSigaretta", fumoTipo)
                }

                    If EseguiNonQuery(queryAnamnesiFisio, parametriAnamnesiFisio) > 0 Then
                        successo = True
                    End If

                    If successo Then
                        If esiste Then
                            main.MostraToast("Anamnesi fisiologica aggiornati correttamente.")
                        Else
                            main.MostraToast("Anamnesi fisiologica salvati correttamente.")
                        End If
                    Else
                        main.MostraToast("Errore imprevisto durante il salvataggio dei dati.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Errore imprevisto: " & ex.Message)
                End Try
            End If
    End Function

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito = SalvaDati()
        If esito Then
            ResetUC() ' Pulisci e resetta i campi
        End If
    End Sub
End Class