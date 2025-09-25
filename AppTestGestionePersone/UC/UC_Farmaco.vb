Imports Microsoft.Data.SqlClient
Public Class UC_Farmaco
    ' Variabili gestione ComboBox Classi
    Private isPopulatingClassi As Boolean = False
    Private dtClassi As DataTable
    Private dtClassiOriginale As DataTable
    Private WithEvents filtroTimerClassi As New Timer()
    Private filtroPrecedenteClassi As String = ""

    'Variabili gestione ComboBox Vie somministrazione
    Private isPopulatingSomministrazione As Boolean = False
    Private dtSomministrazione As DataTable
    Private dtSomministrazioneOriginale As DataTable
    Private WithEvents filtroTimerSomministrazione As New Timer()
    Private filtroPrecedenteSomministrazione As String = ""

    Private Shared ReadOnly ControlText As New Dictionary(Of Control, String)

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo

        With ComboBoxViaSomministrazione
            ' Imposta i dati
            PopolaComboBoxVieSomministrazioneAsync()
            .Dock = DockStyle.Top
        End With

        With ComboBoxClasse
            ' Popola i ceppi dal database
            PopolaComboBoxClasseAsync()
            .Dock = DockStyle.Top
        End With
    End Sub

    Private Sub FormClasseFarmaco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PulisciCampi(TextBoxNomeCommerciale, TextBoxPrincipioAttivo, ComboBoxClasse, ComboBoxViaSomministrazione)

        ControlText(TextBoxNomeCommerciale) = "Nome commerciale"
        TextBoxNomeCommerciale.Text = ControlText(TextBoxNomeCommerciale)

        ControlText(TextBoxPrincipioAttivo) = "Principio attivo"
        TextBoxPrincipioAttivo.Text = ControlText(TextBoxPrincipioAttivo)

        HilightControls(False, TextBoxNomeCommerciale)
        HilightControls(False, TextBoxPrincipioAttivo)
        HilightControls(False, ComboBoxClasse)
        HilightControls(False, ComboBoxViaSomministrazione)
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBoxNomeCommerciale.Enter, TextBoxPrincipioAttivo.Enter
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ""
            ctrl.ForeColor = Theme.TextBoxForeColor
            ctrl.Font = Theme.TxtFont
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBoxNomeCommerciale.Leave, TextBoxPrincipioAttivo.Leave
        Dim ctrl As Control = DirectCast(sender, Control)
        If String.IsNullOrWhiteSpace(ctrl.Text) Then
            ctrl.Text = ControlText(ctrl)
            ctrl.ForeColor = Theme.FindColor
            ctrl.Font = Theme.TxtFontItalic
        End If
    End Sub

    Private Async Sub PopolaComboBoxClasseAsync()
        Dim query As String = "SELECT ID, Classe FROM ClassiFarmaci ORDER BY Classe"
        dtClassiOriginale = Await ConnessioneDB.EseguiQueryAsync(query)

        ComboBoxClasse.DataSource = dtClassiOriginale
        ComboBoxClasse.DisplayMember = "Classe"
        ComboBoxClasse.ValueMember = "ID"
        ComboBoxClasse.SelectedIndex = -1
    End Sub

    Private Async Sub PopolaComboBoxVieSomministrazioneAsync()
        Dim query As String = "SELECT ID, Categoria, Sottocategoria 
                               FROM FarmacoVieSomministrazione 
                               ORDER BY Categoria, Sottocategoria"

        dtSomministrazioneOriginale = Await ConnessioneDB.EseguiQueryAsync(query)

        If Not dtSomministrazioneOriginale.Columns.Contains("Descrizione") Then
            dtSomministrazioneOriginale.Columns.Add("Descrizione", GetType(String), "Categoria + ' - ' + Sottocategoria")
        End If

        ComboBoxViaSomministrazione.DataSource = dtSomministrazioneOriginale
        ComboBoxViaSomministrazione.DisplayMember = "Descrizione"
        ComboBoxViaSomministrazione.ValueMember = "ID"
        ComboBoxViaSomministrazione.SelectedIndex = -1
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True

        ' Verifico se il campo Nome commerciale è stato compilato
        If String.IsNullOrWhiteSpace(TextBoxNomeCommerciale.Text.Trim()) OrElse TextBoxNomeCommerciale.Text.Trim() = ControlText(TextBoxNomeCommerciale) Then
            esito = False
            HilightControls(True, TextBoxNomeCommerciale)
        Else
            HilightControls(False, TextBoxNomeCommerciale)
        End If

        ' Verifico se il campo Principio attivo è stato compilato
        If String.IsNullOrWhiteSpace(TextBoxPrincipioAttivo.Text.Trim()) OrElse TextBoxPrincipioAttivo.Text.Trim() = ControlText(TextBoxPrincipioAttivo) Then
            esito = False
            HilightControls(True, TextBoxPrincipioAttivo)
        Else
            HilightControls(False, TextBoxPrincipioAttivo)
        End If

        ' Verifico se il campo Classe è stato compilato
        If ComboBoxClasse.SelectedIndex > -1 OrElse Not Utils.IsValidSelection(ComboBoxClasse) Then
            HilightControls(False, ComboBoxClasse)
        Else
            HilightControls(True, ComboBoxClasse)
            esito = False
        End If

        ' Verifico se il campo Via di somministrazione è stato compilato
        If ComboBoxViaSomministrazione.SelectedIndex > -1 OrElse Not Utils.IsValidSelection(ComboBoxViaSomministrazione) Then
            HilightControls(False, ComboBoxViaSomministrazione)
        Else
            HilightControls(True, ComboBoxViaSomministrazione)
            esito = False
        End If

        Return esito
    End Function

    Private Async Function CercaFarmacoAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim esiste As Boolean = False

        'Verifica che la classe inserita non esistà già
        Dim checkQuery As String = "SELECT * FROM Farmaci WHERE NomeCommerciale = @nomeCommerciale AND ID_VieSomministrazione = @idVieSomministrazione"

        Dim nomeCommerciale As String = TextBoxNomeCommerciale.Text.Trim()
        Dim principioAttivo As String = TextBoxPrincipioAttivo.Text.Trim()
        Dim idVieSomministrazione As Integer = CInt(ComboBoxViaSomministrazione.SelectedValue)

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@nomeCommerciale", nomeCommerciale),
            New SqlParameter("@idVieSomministrazione", idVieSomministrazione)
        }

        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count <> 0 Then
            esiste = True ' Farmaco già presente
        Else
            esiste = False
        End If

        Return esiste
    End Function

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

            Dim successo As Boolean = True

            Dim nomeCommerciale As String = TextBoxNomeCommerciale.Text.Trim()
            Dim principioAttivo As String = TextBoxPrincipioAttivo.Text.Trim()
            Dim idClasse As Integer = CInt(ComboBoxClasse.SelectedValue)
            Dim idVieSomministrazione As String = CInt(ComboBoxViaSomministrazione.SelectedValue)

            ' TODO
            Try
                Dim queryFarmaco As String = ""
                Dim esiste As Boolean = Await CercaFarmacoAsync()

                If Not esiste Then
                    queryFarmaco = "INSERT INTO Farmaci (
                                                        NomeCommerciale,
                                                        PrincipioAttivo,
                                                        ID_Classe,
                                                        ID_VieSomministrazione
                                                        ) VALUES (
                                                        @nomeCommerciale,
                                                        @principioAttivo,
                                                        @idClasse,
                                                        @idVieSomministrazione)"

                    Dim parametriFarmaco As New List(Of SqlParameter) From {
                        New SqlParameter("@nomeCommerciale", nomeCommerciale),
                        New SqlParameter("@principioAttivo", principioAttivo),
                        New SqlParameter("@idClasse", idClasse),
                        New SqlParameter("@idVieSomministrazione", idVieSomministrazione)
                    }

                    If Await ConnessioneDB.EseguiNonQueryAsync(queryFarmaco, parametriFarmaco) > 0 Then
                        successo = True
                    End If

                    If successo Then
                        main.MostraToast("Farmaco aggiunto correttamente.")
                    End If
                Else
                    main.MostraToast("Farmaco già esistente.")
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
        TableLayoutPanelFarmaco.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelFarmaco.Enabled = True
        If esito Then
            PulisciCampi(TextBoxNomeCommerciale, TextBoxPrincipioAttivo, ComboBoxClasse, ComboBoxViaSomministrazione)
        End If
    End Sub
End Class
