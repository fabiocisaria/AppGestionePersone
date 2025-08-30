Public Class FormAnamnesiFisiologicaSequenza

    Private idPaziente As Integer
    Private _bmi As Double = 0

    Public Sub New(idAnagrafica As Integer)
        InitializeComponent()
        idPaziente = idAnagrafica
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

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim altezza As Double
        Dim peso As Double
        Dim bmi As Double = Math.Round(_bmi, 1)
        Dim idratazione As String = ""
        Dim intolleranze As Object
        Dim allergie As Object
        Dim fumoQuantita As String = ""
        Dim fumoTipo As String = ""

        Double.TryParse(TextBoxAltezza.Text, altezza)
        Double.TryParse(TextBoxPeso.Text, peso)

        If altezza = 0 Then
            HilightControls(True, TextBoxAltezza)
            Exit Sub
        Else
            HilightControls(False, TextBoxAltezza)
        End If

        If peso = 0 Then
            HilightControls(True, TextBoxPeso)
            Exit Sub
        Else
            HilightControls(False, TextBoxPeso)
        End If

        If ComboBoxIdratazione.SelectedItem Is Nothing Then
            HilightControls(True, ComboBoxIdratazione)
            Exit Sub
        Else
            idratazione = ComboBoxIdratazione.SelectedItem.ToString()
            HilightControls(False, ComboBoxIdratazione)
        End If

        If String.IsNullOrWhiteSpace(TextBoxIntolleranze.Text) Then
            intolleranze = DBNull.Value
            Exit Sub
        Else
            intolleranze = TextBoxIntolleranze.Text
        End If

        If String.IsNullOrWhiteSpace(TextBoxAllergie.Text) Then
            allergie = DBNull.Value
            Exit Sub
        Else
            allergie = TextBoxAllergie.Text
        End If

        If ComboBoxQuantita.SelectedItem Is Nothing Then
            HilightControls(True, ComboBoxQuantita)
            Exit Sub
        Else
            fumoQuantita = ComboBoxIdratazione.SelectedItem.ToString()
            HilightControls(False, ComboBoxQuantita)
        End If

        If ComboBoxTipo.SelectedItem Is Nothing Then
            HilightControls(True, ComboBoxTipo)
            Exit Sub
        Else
            fumoTipo = ComboBoxIdratazione.SelectedItem.ToString()
            HilightControls(False, ComboBoxTipo)
        End If

        Dim idCheck As String = "SELECT COUNT(*) FROM AnamnesiFisiologica WHERE ID_Anagrafica = @ID_Anagrafica"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@ID_Anagrafica", idPaziente)
        }

        Dim dtCheck As DataTable = EseguiQuery(idCheck, checkParam)

        If dtCheck.Rows(0)(0) > 0 Then
            MessageBox.Show("L'anamnesi fisiologica per questo paziente esiste già.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
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
            MessageBox.Show("Dati salvati correttamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class