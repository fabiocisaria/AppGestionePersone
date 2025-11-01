Imports Microsoft.Data.SqlClient
Public Class UC_AnamnesiFisiologica
    Private _bmi As Double = 0
    Dim idPaziente As Integer = -1

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Private Shared ReadOnly ControlText As New Dictionary(Of Control, String)

    Public Sub New()
        InitializeComponent()

        ControlText(TextBoxAllergie) = "Allergie"
        ControlText(TextBoxAltezza) = "0"
        ControlText(TextBoxPeso) = "0"
        ControlText(TextBoxIntolleranze) = "Intolleranze"
        ControlText(TextBoxBMI) = "0"

        ' ========
        ' ComboBox
        ' ========
        With ComboBoxQuantita
            ' Imposta i dati
            .DataSource = New List(Of String) From {"No", "< 5gg", "> 5gg"}
            .SelectedIndex = -1
        End With

        With ComboBoxTipo
            ' Imposta i dati
            .DataSource = New List(Of String) From {"Tradizionale", "IQOS", "Elettronica"}
            .SelectedIndex = -1
        End With

        With ComboBoxIdratazione
            ' Imposta i dati
            .DataSource = New List(Of String) From {"< 1.0 l", "1.0 - 1.5 l", "1.5 - 2.0 l", "2.0 - 3.0 l", "> 3.0 l"}
            .SelectedIndex = -1
        End With

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo
    End Sub

    Public Async Sub AggiornaDatiAsync()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idPaziente = main.IDPazienteSelezionato

            TableLayoutPanelAnamnesiFisiologica.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaAnamnesiAsync()
            TableLayoutPanelAnamnesiFisiologica.Enabled = True
            If Not esiste Then
                ResetUC()
            End If
        End If
    End Sub
    Private Async Sub FormAnamnesiFisiologica_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idPaziente = main.IDPazienteSelezionato

            TableLayoutPanelAnamnesiFisiologica.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaAnamnesiAsync()
            TableLayoutPanelAnamnesiFisiologica.Enabled = True

            If Not esiste Then
                ResetUC()
            End If
        End If
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBoxAllergie.Enter, TextBoxAltezza.Enter, TextBoxPeso.Enter, TextBoxIntolleranze.Enter
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ""
            ctrl.ForeColor = Theme.TextBoxForeColor
            ctrl.Font = Theme.TxtFont
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBoxAllergie.Leave, TextBoxPeso.Leave, TextBoxAltezza.Leave, TextBoxIntolleranze.Leave
        Dim ctrl As Control = DirectCast(sender, Control)
        If String.IsNullOrWhiteSpace(ctrl.Text) OrElse ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ControlText(ctrl)
            ctrl.ForeColor = Theme.FindColor
            ctrl.Font = Theme.TxtFontItalic
        End If
    End Sub

    Private Sub ComboBoxQuantita_CheckedChanged(sender As Object, e As EventArgs) Handles ComboBoxQuantita.SelectedIndexChanged
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
        TextBoxAltezza.Text = ControlText(TextBoxAltezza)
        TextBoxPeso.Text = ControlText(TextBoxPeso)
        TextBoxBMI.Text = ControlText(TextBoxBMI)
        TextBoxAllergie.Text = ControlText(TextBoxAllergie)
        TextBoxIntolleranze.Text = ControlText(TextBoxIntolleranze)

        SetControlsEnabled(False, ComboBoxTipo)
    End Sub

    Private Sub TextBoxAltezzaPeso_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAltezza.TextChanged, TextBoxPeso.TextChanged
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

        If TextBoxAltezza.Text.Trim() = 0 Then
            HilightControls(True, TextBoxAltezza)
            successo = False
        Else
            HilightControls(False, TextBoxAltezza)
        End If

        If TextBoxPeso.Text.Trim() = 0 Then
            HilightControls(True, TextBoxPeso)
            successo = False
        Else
            HilightControls(False, TextBoxPeso)
        End If

        If ComboBoxIdratazione.SelectedItem Is Nothing OrElse Not Utils.IsValidSelection(ComboBoxIdratazione) Then
            HilightControls(True, ComboBoxIdratazione)
            successo = False
        Else
            HilightControls(False, ComboBoxIdratazione)
        End If



        If ComboBoxQuantita.SelectedItem Is Nothing OrElse Not Utils.IsValidSelection(ComboBoxQuantita) Then
            HilightControls(True, ComboBoxQuantita)
            successo = False
        Else
            HilightControls(False, ComboBoxQuantita)
        End If

        If ComboBoxQuantita.SelectedItem IsNot Nothing Then
            If ComboBoxQuantita.SelectedItem.ToString() <> "No" Then
                If ComboBoxTipo.SelectedItem Is Nothing OrElse Not Utils.IsValidSelection(ComboBoxTipo) Then
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
            peso = Double.TryParse(TextBoxPeso.Text, peso)
            bmi = Double.TryParse(TextBoxBMI.Text, bmi)
            idratazione = ComboBoxIdratazione.SelectedItem.ToString()
            intolleranze = TextBoxIntolleranze.Text
            allergie = TextBoxAllergie.Text
            fumoQuantita = ComboBoxQuantita.SelectedItem.ToString()

            ' Inserisco valori null se i campi non obbligatori sono vuoti
            ' Intolleranza
            If String.IsNullOrWhiteSpace(TextBoxIntolleranze.Text.Trim()) OrElse TextBoxIntolleranze.Text.Trim() = ControlText(TextBoxIntolleranze) Then
                intolleranze = DBNull.Value
            Else
                intolleranze = TextBoxIntolleranze.Text
            End If

            'Allergie
            If String.IsNullOrWhiteSpace(TextBoxAllergie.Text.Trim()) OrElse TextBoxAllergie.Text.Trim() = ControlText(TextBoxAllergie) Then
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
    Private Async Function CercaAnamnesiAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idPaziente = main.IDPazienteSelezionato

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM AnamnesiFisiologica WHERE ID_Anagrafica = @idAnagrafica"

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@idAnagrafica", idPaziente)
        }
        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' anamnesi fisiologica esistente

            Dim dettagliAnamnesi As DataRow = dtCheck.Rows(0)
            If Not appenaSalvati Then
                main.MostraToast("Anamnesi fisiologica esistente per il paziente selezionato. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            TextBoxPeso.Text = dettagliAnamnesi("Peso")
            TextBoxPeso.ForeColor = Theme.TextBoxForeColor
            TextBoxPeso.Font = Theme.TxtFont

            TextBoxAltezza.Text = dettagliAnamnesi("Altezza")
            TextBoxAltezza.ForeColor = Theme.TextBoxForeColor
            TextBoxAltezza.Font = Theme.TxtFont

            TextBoxBMI.Text = dettagliAnamnesi("BMI")
            ComboBoxIdratazione.SelectedItem = dettagliAnamnesi("Idratazione").ToString()

            If IsDBNull(dettagliAnamnesi("Intolleranze")) Then
                TextBoxIntolleranze.Text = ControlText(TextBoxIntolleranze)
            Else
                TextBoxIntolleranze.Text = dettagliAnamnesi("Intolleranze").ToString()
                TextBoxIntolleranze.ForeColor = Theme.TextBoxForeColor
                TextBoxIntolleranze.Font = Theme.TxtFont
            End If

            If IsDBNull(dettagliAnamnesi("Allergie")) Then
                TextBoxAllergie.Text = ControlText(TextBoxAllergie)
            Else
                TextBoxAllergie.Text = dettagliAnamnesi("Allergie").ToString()
                TextBoxAllergie.ForeColor = Theme.TextBoxForeColor
                TextBoxAllergie.Font = Theme.TxtFont
            End If

            ' TextBoxIntolleranze.Text = If(IsDBNull(dettagliAnamnesi("Intolleranze")), ControlText(TextBoxIntolleranze), dettagliAnamnesi("Intolleranze").ToString())

            ' TextBoxAllergie.Text = If(IsDBNull(dettagliAnamnesi("Allergie")), ControlText(TextBoxAllergie), dettagliAnamnesi("Allergie").ToString())
            ComboBoxQuantita.SelectedItem = dettagliAnamnesi("FumoQuantita").ToString()
            ComboBoxTipo.SelectedItem = dettagliAnamnesi("TipoSigaretta").ToString()
        Else
            esiste = False
            PulisciCampi(TableLayoutPanelAnamnesiFisiologica)
        End If

        Return esiste
    End Function

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idPaziente = main.IDPazienteSelezionato

            Dim successo As Boolean = True

            Dim altezza As Double
            Dim peso As Double
            Dim bmi As Double = Math.Round(_bmi, 1)
            Dim idratazione As String = ComboBoxIdratazione.SelectedItem.ToString()
            Dim intolleranze As Object

            If String.IsNullOrWhiteSpace(TextBoxIntolleranze.Text) OrElse TextBoxIntolleranze.Text.Trim() = ControlText(TextBoxIntolleranze) Then
                intolleranze = DBNull.Value
            Else
                intolleranze = TextBoxIntolleranze.Text
            End If

            Dim allergie As Object
            If String.IsNullOrWhiteSpace(TextBoxAllergie.Text) OrElse TextBoxAllergie.Text.Trim() = ControlText(TextBoxAllergie) Then
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

                Dim parametriAnamnesiFisio As New List(Of SqlParameter) From {
                        New SqlParameter("@IDAnagrafica", idPaziente),
                        New SqlParameter("@Altezza", altezza),
                        New SqlParameter("@Peso", peso),
                        New SqlParameter("@BMI", bmi),
                        New SqlParameter("@Idratazione", idratazione),
                        New SqlParameter("@Intolleranze", intolleranze),
                        New SqlParameter("@Allergie", allergie),
                        New SqlParameter("@FumoQuantita", fumoQuantita),
                        New SqlParameter("@TipoSigaretta", fumoTipo)
                    }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryAnamnesiFisio, parametriAnamnesiFisio) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Anamnesi fisiologica aggiornata correttamente.")
                    Else
                        main.MostraToast("Anamnesi fisiologica salvata correttamente.")
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

    Private Async Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Disabilito tutti i controlli
        TableLayoutPanelAnamnesiFisiologica.Enabled = False

        main.MostraToast("Salvataggio in corso ...")

        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelAnamnesiFisiologica.Enabled = True

        If esito Then
            appenaSalvati = True
            TableLayoutPanelAnamnesiFisiologica.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            Dim resultAnamnesi = Await CercaAnamnesiAsync()
            TableLayoutPanelAnamnesiFisiologica.Enabled = True
        End If
        'If esito Then
        'ResetUC() ' Pulisci e resetta i campi
        'End If
    End Sub

End Class