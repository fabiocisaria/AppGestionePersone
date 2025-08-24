Public Class UC_AnamnesiFisiologica
    Private _bmi As Double = 0
    Private Sub ResetUC()
        PulisciCampi(TextBoxAltezza, TextBoxPeso, TextBoxAllergie, TextBoxIntolleranze, ComboBoxIdratazione, ComboBoxQuantita, ComboBoxTipo)
    End Sub

    Public Sub New()
        InitializeComponent()
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

    Private Function SalvaDati() As Boolean

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim idPaziente As Integer = main.IDPazienteSelezionato

        Dim altezza As Double
        Dim peso As Double
        Dim bmi As Double = Math.Round(_bmi, 1)
        Dim idratazione As String = ""
        Dim intolleranze As Object
        Dim allergie As Object
        Dim fumoQuantita As String = ""
        Dim fumoTipo As String = ""

        Dim successo As Boolean = True

        Double.TryParse(TextBoxAltezza.Text, altezza)
        Double.TryParse(TextBoxPeso.Text, peso)
        Try
            If altezza = 0 Then
                HighlightControls(True, TextBoxAltezza)
                successo = False
            Else
                HighlightControls(False, TextBoxAltezza)
            End If

            If peso = 0 Then
                HighlightControls(True, TextBoxPeso)
                successo = False
            Else
                HighlightControls(False, TextBoxPeso)
            End If

            If ComboBoxIdratazione.SelectedItem Is Nothing Then
                HighlightControls(True, ComboBoxIdratazione)
                successo = False
            Else
                idratazione = ComboBoxIdratazione.SelectedItem.ToString()
                HighlightControls(False, ComboBoxIdratazione)
            End If

            If String.IsNullOrWhiteSpace(TextBoxIntolleranze.Text) Then
                intolleranze = DBNull.Value
            Else
                intolleranze = TextBoxIntolleranze.Text
            End If

            If String.IsNullOrWhiteSpace(TextBoxAllergie.Text) Then
                allergie = DBNull.Value
            Else
                allergie = TextBoxAllergie.Text
            End If

            If ComboBoxQuantita.SelectedItem Is Nothing Then
                HighlightControls(True, ComboBoxQuantita)
                successo = False
            Else
                fumoQuantita = ComboBoxIdratazione.SelectedItem.ToString()
                HighlightControls(False, ComboBoxQuantita)
            End If

            If ComboBoxTipo.SelectedItem Is Nothing Then
                HighlightControls(True, ComboBoxTipo)
                successo = False
            Else
                fumoTipo = ComboBoxIdratazione.SelectedItem.ToString()
                HighlightControls(False, ComboBoxTipo)
            End If

            If successo = False Then
                main.MostraToast("Compilare tutti i campi obbligatori.")
                Return False
            Else
                Dim idCheck As String = "SELECT COUNT(*) FROM AnamnesiFisiologica WHERE ID_Anagrafica = @ID_Anagrafica"

                Dim checkParam As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@ID_Anagrafica", idPaziente)
                }

                Dim dtCheck As DataTable = EseguiQuery(idCheck, checkParam)

                If dtCheck.Rows(0)(0) > 0 Then
                    main.MostraToast("L'anamnesi fisiologica per questo paziente esiste già.")
                    Return False
                End If

                Dim queryAnamnesiFisio As String = "INSERT INTO AnamnesiFisiologica (ID_Anagrafica, Altezza, Peso, BMI, Idratazione, Intolleranze, Allergie, FumoQuantita, TipoSigaretta) VALUES (@IDAnagrafica, @Altezza, @Peso, @BMI, @Idratazione, @Intolleranze, @Allergie, @fumoQuantita, @tipoSigaretta)"
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
                    main.MostraToast("Dati salvati correttamente")
                    successo = True
                    Return successo
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Errore imprevisto: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito = SalvaDati()
        If esito Then
            ResetUC() ' Pulisci e resetta i campi
        End If
    End Sub
End Class
