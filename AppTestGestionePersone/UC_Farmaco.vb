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

    Public Sub New()
        InitializeComponent()

        Me.BackColor = Theme.BackgroundColor
        TableLayoutPanelDatiFarmaco.BackColor = Theme.BackgroundColor
        TableLayoutPanelFarmaco.BackColor = Theme.BackgroundColor

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

        With ComboBoxViaSomministrazione
            ' Imposta i dati
            PopolaComboBoxVieSomministrazioneAsync()

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With

        With ComboBoxClasse
            ' Popola i ceppi dal database
            PopolaComboBoxClasseAsync()

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With
    End Sub

    ' --- Metodo per regolare altezza tendina ---
    Private Sub UpdateDropDownHeight(ByVal cb As ComboBox)
        Dim itemCount As Integer = cb.Items.Count
        Dim maxVisible As Integer = 10
        If itemCount > maxVisible Then itemCount = maxVisible
        cb.DropDownHeight = (cb.ItemHeight * itemCount) + 2
    End Sub

    'TODO
    Private Async Sub PopolaComboBoxClasseAsync()
        isPopulatingClassi = True ' ← Blocca TextChanged durante il popolamento

        Dim query As String = "SELECT ID, Classe FROM ClassiFarmaci ORDER BY Classe"
        dtClassiOriginale = Await ConnessioneDB.EseguiQueryAsync(query)

        ComboBoxClasse.DataSource = dtClassiOriginale
        ComboBoxClasse.DisplayMember = "Classe"
        ComboBoxClasse.ValueMember = "ID"
        ComboBoxClasse.DropDownStyle = ComboBoxStyle.DropDown
        ComboBoxClasse.SelectedIndex = -1

        ' Imposta timer debounce
        filtroTimerClassi.Interval = 600

        isPopulatingClassi = False ' ← Sblocca TextChanged dopo il popolamento
    End Sub

    Private Async Sub PopolaComboBoxVieSomministrazioneAsync()
        isPopulatingSomministrazione = True ' ← Blocca TextChanged durante il popolamento

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
        ComboBoxViaSomministrazione.DropDownStyle = ComboBoxStyle.DropDown
        ComboBoxViaSomministrazione.SelectedIndex = -1

        ' Imposta timer debounce
        filtroTimerSomministrazione.Interval = 600

        isPopulatingSomministrazione = False ' ← Sblocca TextChanged dopo il popolamento
    End Sub

    Private Sub ComboBoxClasse_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxClasse.TextChanged
        If isPopulatingClassi Then Return
        filtroTimerClassi.Stop()
        filtroTimerClassi.Start()
    End Sub

    Private Sub ComboBoxVieSomministrazione_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxViaSomministrazione.TextChanged
        If isPopulatingSomministrazione Then Return
        filtroTimerSomministrazione.Stop()
        filtroTimerSomministrazione.Start()
    End Sub

    Private Sub filtroTimerClassi_Tick(sender As Object, e As EventArgs) Handles filtroTimerClassi.Tick
        filtroTimerClassi.Stop()
        ApplicaFiltroClasse()
    End Sub

    Private Sub filtroTimerSomministrazione_Tick(sender As Object, e As EventArgs) Handles filtroTimerSomministrazione.Tick
        filtroTimerSomministrazione.Stop()
        ApplicaFiltroSomministrazione()
    End Sub

    ' --- Metodo per filtrare la ComboBox ---
    Private Sub ApplicaFiltroClasse()
        If dtClassiOriginale Is Nothing Then Return

        Dim filtro As String = ComboBoxClasse.Text.Trim().ToUpper()

        ' Se il filtro non è cambiato, non fare nulla
        If filtro = filtroPrecedenteClassi Then Return
        filtroPrecedenteClassi = filtro

        Dim dtFiltrata As DataTable = dtClassiOriginale.Clone()

        For Each row As DataRow In dtClassiOriginale.Rows
            If row("Classe").ToString().ToUpper().Contains(filtro) Then
                dtFiltrata.ImportRow(row)
            End If
        Next

        ' Salva testo e posizione cursore
        Dim txt As String = ComboBoxClasse.Text
        Dim selStart As Integer = ComboBoxClasse.SelectionStart

        ComboBoxClasse.BeginUpdate()
        ComboBoxClasse.DataSource = dtFiltrata
        ComboBoxClasse.DisplayMember = "Classe"
        ComboBoxClasse.ValueMember = "ID"
        ComboBoxClasse.EndUpdate()

        ' Ripristina testo senza selezionare automaticamente il primo elemento
        ComboBoxClasse.SelectedIndex = -1
        ComboBoxClasse.Text = txt
        ComboBoxClasse.SelectionStart = selStart
        ComboBoxClasse.SelectionLength = 0

        UpdateDropDownHeight(ComboBoxClasse)

        ' Apri automaticamente il dropdown se ci sono elementi filtrati
        'If ComboBoxCeppo.Items.Count > 0 Then
        'ComboBoxCeppo.DroppedDown = True
        'End If
    End Sub

    Private Sub ApplicaFiltroSomministrazione()
        If dtSomministrazioneOriginale Is Nothing Then Return

        Dim filtro As String = ComboBoxViaSomministrazione.Text.Trim().ToUpper()

        ' Se il filtro non è cambiato, non fare nulla
        If filtro = filtroPrecedenteSomministrazione Then Return
        filtroPrecedenteSomministrazione = filtro

        Dim dtFiltrata As DataTable = dtSomministrazioneOriginale.Clone()

        For Each row As DataRow In dtSomministrazioneOriginale.Rows
            If row("Descrizione").ToString().ToUpper().Contains(filtro) Then
                dtFiltrata.ImportRow(row)
            End If
        Next

        ' Salva testo e posizione cursore
        Dim txt As String = ComboBoxViaSomministrazione.Text
        Dim selStart As Integer = ComboBoxViaSomministrazione.SelectionStart

        ComboBoxViaSomministrazione.BeginUpdate()
        ComboBoxViaSomministrazione.DataSource = dtFiltrata
        ComboBoxViaSomministrazione.DisplayMember = "Descrizione"
        ComboBoxViaSomministrazione.ValueMember = "ID"
        ComboBoxViaSomministrazione.EndUpdate()

        ' Ripristina testo senza selezionare automaticamente il primo elemento
        ComboBoxViaSomministrazione.SelectedIndex = -1
        ComboBoxViaSomministrazione.Text = txt
        ComboBoxViaSomministrazione.SelectionStart = selStart
        ComboBoxViaSomministrazione.SelectionLength = 0

        UpdateDropDownHeight(ComboBoxViaSomministrazione)

        ' Apri automaticamente il dropdown se ci sono elementi filtrati
        'If ComboBoxCeppo.Items.Count > 0 Then
        'ComboBoxCeppo.DroppedDown = True
        'End If
    End Sub

    Private Sub FormClasseFarmaco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PulisciCampi(TextBoxNomeCommerciale, TextBoxPrincipioAttivo, ComboBoxClasse, ComboBoxViaSomministrazione)
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True

        ' Verifico se il campo Nome commerciale è stato compilato
        If String.IsNullOrWhiteSpace(TextBoxNomeCommerciale.Text.Trim()) Then
            esito = False
            HilightControls(True, TextBoxNomeCommerciale)
        Else
            HilightControls(False, TextBoxNomeCommerciale)
        End If

        ' Verifico se il campo Principio attivo è stato compilato
        If String.IsNullOrWhiteSpace(TextBoxPrincipioAttivo.Text.Trim()) Then
            esito = False
            HilightControls(True, TextBoxPrincipioAttivo)
        Else
            HilightControls(False, TextBoxPrincipioAttivo)
        End If

        ' Verifico se il campo Classe è stato compilato
        If ComboBoxClasse.SelectedIndex > -1 Then
            HilightControls(False, ComboBoxClasse)
        Else
            HilightControls(True, ComboBoxClasse)
            esito = False
        End If

        ' Verifico se il campo Via di somministrazione è stato compilato
        If ComboBoxViaSomministrazione.SelectedIndex > -1 Then
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
