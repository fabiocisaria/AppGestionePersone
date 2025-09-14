Imports System.Security.Authentication.ExtendedProtection
Imports System.Web.UI.Design
Imports Microsoft.Data.SqlClient

Public Class UC_VisitaAnamnesiOstrGineco
    Dim idVisita As Integer = -1
    Dim tipoVisita As String = ""
    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Async Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata

            ' Cerco se esiste già un'anamnesi ostetrico - ginecologica per la visita selezionata
            TableLayoutPanelAnOstrGineco.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelAnOstrGineco.Enabled = True
            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnOstrGineco)
            End If
        End If
    End Sub

    Private Async Sub FormVisitaAnamnesiOstrGineco_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDownGravidanze.Minimum = 0
        NumericUpDownGravidanze.Maximum = 20
        NumericUpDownPartiCesarei.Minimum = 0
        NumericUpDownPartiCesarei.Maximum = 20
        NumericUpDownPartiNaturali.Minimum = 0
        NumericUpDownPartiNaturali.Maximum = 20

        NumericUpDownGravidanze.Text = ""
        NumericUpDownPartiCesarei.Text = ""
        NumericUpDownPartiNaturali.Text = ""

        RadioAutoCheck(True, TableLayoutPanelAnOstrGineco)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata

            ResetAndDisableControls(False, TableLayoutPanelTipoContracc)
            ResetAndDisableControls(False, TableLayoutPanelEstrogeno)
            ResetAndDisableControls(False, TableLayoutPanelDismenorrea)
            ResetAndDisableControls(False, TableLayoutPanelMenopausa)
            ResetAndDisableControls(False, TableLayoutPanelParti)
            ResetAndDisableControls(False, TableLayoutPanelPartiOperativi)
            ResetAndDisableControls(False, TableLayoutPanelLacerazioni)
            ResetAndDisableControls(False, TableLayoutPanelEpisiotomia)
            ResetAndDisableControls(False, TableLayoutPanelLacEpis)
            ResetAndDisableControls(False, TableLayoutPanelTipo)

            ' Cerco se esiste già un'anamnesi ostetrico - ginecologica per la visita selezionata
            TableLayoutPanelAnOstrGineco.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            esiste = Await CercaVisitaAsync()

            TableLayoutPanelAnOstrGineco.Enabled = True
            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnOstrGineco)
                'ResetAndDisableControls(False, TableLayoutPanelTipoContracc)
                'ResetAndDisableControls(False, TableLayoutPanelEstrogeno)
                'ResetAndDisableControls(False, TableLayoutPanelDismenorrea)
                'ResetAndDisableControls(False, TableLayoutPanelMenopausa)
                'ResetAndDisableControls(False, TableLayoutPanelParti)
                'ResetAndDisableControls(False, TableLayoutPanelPartiOperativi)
                'ResetAndDisableControls(False, TableLayoutPanelLacerazioni)
                'ResetAndDisableControls(False, TableLayoutPanelEpisiotomia)
                'ResetAndDisableControls(False, TableLayoutPanelLacEpis)
                'ResetAndDisableControls(False, TableLayoutPanelTipo)
            End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()

        Me.BackColor = Theme.BackgroundColor
        TableLayoutPanel2.BackColor = Theme.BackgroundColor
        TableLayoutPanel3.BackColor = Theme.BackgroundColor
        TableLayoutPanel5.BackColor = Theme.BackgroundColor
        TableLayoutPanel6.BackColor = Theme.BackgroundColor
        TableLayoutPanelAmenorrea.BackColor = Theme.BackgroundColor
        TableLayoutPanelAnOstrGineco.BackColor = Theme.BackgroundColor
        TableLayoutPanelCiclo.BackColor = Theme.BackgroundColor
        TableLayoutPanelContracc.BackColor = Theme.BackgroundColor
        TableLayoutPanelContraccSiNo.BackColor = Theme.BackgroundColor
        TableLayoutPanelDienogestSiNo.BackColor = Theme.BackgroundColor
        TableLayoutPanelDierogest.BackColor = Theme.BackgroundColor
        TableLayoutPanelDismenorrea.BackColor = Theme.BackgroundColor
        TableLayoutPanelEpisiotomia.BackColor = Theme.BackgroundColor
        TableLayoutPanelEstrogeno.BackColor = Theme.BackgroundColor
        TableLayoutPanelEstrogSiNo.BackColor = Theme.BackgroundColor
        TableLayoutPanelLacEpis.BackColor = Theme.BackgroundColor
        TableLayoutPanelLacerazioni.BackColor = Theme.BackgroundColor
        TableLayoutPanelMenopausa.BackColor = Theme.BackgroundColor
        TableLayoutPanelParti.BackColor = Theme.BackgroundColor
        TableLayoutPanelPartiOperativi.BackColor = Theme.BackgroundColor
        TableLayoutPanelPartiOperativiSiNo.BackColor = Theme.BackgroundColor
        TableLayoutPanelSwab.BackColor = Theme.BackgroundColor
        TableLayoutPanelTipo.BackColor = Theme.BackgroundColor
        TableLayoutPanelTipoContracc.BackColor = Theme.BackgroundColor

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
        With ComboBoxMenopausa
            ' Imposta i dati
            .SelectedIndex = -1

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With

        With ComboBoxPartiOperativiTipo
            ' Imposta i dati
            .SelectedIndex = -1

            ' Stile
            .DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
            .BackColor = Color.White                ' Sfondo della textbox
            .ForeColor = Color.Black                ' Colore testo

            .Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .Dock = DockStyle.Top
        End With
    End Sub

    ' Gestione abilitazione campi ginecologici
    Private Sub RadioButtonUsoContraccSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUsoContraccSi.CheckedChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        ResetAndDisableControls(RadioButtonUsoContraccSi.Checked, TableLayoutPanelTipoContracc)
    End Sub

    Private Sub RadioButtonUsoContraccNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUsoContraccNo.CheckedChanged
        ' Nasconde i dettagli se "No" è selezionato
        ResetAndDisableControls(Not RadioButtonUsoContraccNo.Checked, TableLayoutPanelTipoContracc)
    End Sub

    Private Sub RadioButtonUsoDienogestSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUsoDienogestSi.CheckedChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        ResetAndDisableControls(RadioButtonUsoDienogestSi.Checked, TableLayoutPanelEstrogeno)
    End Sub

    Private Sub RadioButtonUsoDienogestNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUsoDienogestNo.CheckedChanged
        ' Nasconde i dettagli se "No" è selezionato
        ResetAndDisableControls(Not RadioButtonUsoDienogestNo.Checked, TableLayoutPanelEstrogeno)
    End Sub

    Private Sub RadioButtonAmenorreaSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAmenorreaSi.CheckedChanged
        ' Mostra i dettagli solo se "Sì" è selezionato
        ResetAndDisableControls(RadioButtonAmenorreaSi.Checked, TableLayoutPanelMenopausa)
        ResetAndDisableControls(Not RadioButtonAmenorreaSi.Checked, TableLayoutPanelDismenorrea)
    End Sub

    Private Sub RadioButtonAmenorreaNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAmenorreaNo.CheckedChanged
        ' Nasconde i dettagli se "No" è selezionato
        ResetAndDisableControls(Not RadioButtonAmenorreaNo.Checked, TableLayoutPanelMenopausa)
        ResetAndDisableControls(RadioButtonAmenorreaNo.Checked, TableLayoutPanelDismenorrea)
    End Sub

    ' Gestione abilitazione campi ostetrici
    Private Sub RadioButtonPartiOperativiSi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPartiOperativiSi.CheckedChanged
        ' Nasconde i dettagli se "No" è selezionato
        ResetAndDisableControls(RadioButtonPartiOperativiSi.Checked, TableLayoutPanelTipo)
    End Sub
    Private Sub RadioButtonPartiOperativiNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPartiOperativiNo.CheckedChanged
        ' Nasconde i dettagli se "No" è selezionato
        ResetAndDisableControls(Not RadioButtonPartiOperativiNo.Checked, TableLayoutPanelTipo)
    End Sub
    Private Sub NumericUpDownGravidanze_NumChanged(sender As Object, e As EventArgs) Handles NumericUpDownGravidanze.ValueChanged
        If NumericUpDownGravidanze.Value > 0 Then
            ResetAndDisableControls(True, TableLayoutPanelParti)
        Else
            ResetAndDisableControls(False, TableLayoutPanelParti)
        End If
    End Sub

    Private Sub ComboBoxTipoContracc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoContracc.SelectedIndexChanged, RadioButtonUsoDienogestNo.CheckedChanged, RadioButtonUsoDienogestSi.CheckedChanged, RadioButtonUsoContraccSi.CheckedChanged, RadioButtonUsoContraccNo.CheckedChanged
        Dim selectedTipo As String = ""
        If ComboBoxTipoContracc.SelectedItem IsNot Nothing Then
            selectedTipo = ComboBoxTipoContracc.SelectedItem.ToString()
        End If

        ' Se il tipo di contraccettivo selezionato contiene "Estro", disabilito l'opzione di associare estrogeni e forzo la selezione su "Sì"
        If selectedTipo.Contains("Estro") And RadioButtonUsoDienogestSi.Checked Then
            RadioButtonAssocEstroSi.Checked = True
            TableLayoutPanelEstrogeno.Enabled = False
        ElseIf Not RadioButtonUsoDienogestSi.Checked And Not RadioButtonUsoDienogestNo.Checked Then
            ResetAndDisableControls(False, TableLayoutPanelEstrogeno)
        ElseIf RadioButtonUsoDienogestSi.Checked Then
            ResetAndDisableControls(True, TableLayoutPanelEstrogeno)
        ElseIf RadioButtonUsoDienogestNo.Checked Then
            ResetAndDisableControls(False, TableLayoutPanelEstrogeno)
        End If
    End Sub

    Private Sub NumericUpDownParti_NumChanged(sender As Object, e As EventArgs) Handles NumericUpDownPartiNaturali.ValueChanged, NumericUpDownPartiCesarei.ValueChanged
        If NumericUpDownPartiNaturali.Value > 0 Or NumericUpDownPartiCesarei.Value > 0 Then
            ResetAndDisableControls(True, TableLayoutPanelPartiOperativi)
            ResetAndDisableControls(True, TableLayoutPanelLacerazioni)
            ResetAndDisableControls(True, TableLayoutPanelEpisiotomia)
            ResetAndDisableControls(True, TableLayoutPanelLacEpis)
        Else
            ResetAndDisableControls(False, TableLayoutPanelPartiOperativi)
            ResetAndDisableControls(False, TableLayoutPanelLacerazioni)
            ResetAndDisableControls(False, TableLayoutPanelEpisiotomia)
            ResetAndDisableControls(False, TableLayoutPanelLacEpis)
            ResetAndDisableControls(False, TableLayoutPanelTipo)
        End If
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True
        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelAnOstrGineco)

        ' Verifico se sono state effettuate tutte le
        ' Ambito ginecologico
        Dim result = ValidateMultipleGroups(TableLayoutPanelAnOstrGineco)

        Dim invalidGroups = result.InvalidGroups

        '=====================
        ' Verifica RadioButton
        '=====================
        '-------
        ' Gineco
        '-------
        ' Se "Uso Dienogest = No", rimuovo i gruppi collegati dai controlli obbligatori
        If RadioButtonUsoDienogestNo.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) Not gb Is TableLayoutPanelEstrogSiNo).ToList()
        End If

        ' Se "Amenorrea", rimuovo i gruppi collegati dai controlli obbligatori
        If RadioButtonAmenorreaSi.Checked Then
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelDismenorrea)).ToList()
        End If

        '----------
        ' Ostetrico
        '----------
        ' Se "Parti = 0", rimuovo i gruppi collegati dai controlli obbligatori
        If (NumericUpDownGravidanze.Value = 0) Or ((NumericUpDownPartiNaturali.Value = 0) And (NumericUpDownPartiCesarei.Value = 0)) Then
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelPartiOperativiSiNo OrElse
                                                          gb Is TableLayoutPanelLacerazioni OrElse
                                                          gb Is TableLayoutPanelEpisiotomia)).ToList()
        End If

        '==================
        ' Verifica ComboBox
        '==================
        '-------
        ' Gineco
        '-------
        ' Se "Amenorrea", verifico che sia stato selezionato un elemento del campo menopausa
        If RadioButtonAmenorreaSi.Checked Then
            If ComboBoxMenopausa.SelectedIndex = -1 Then
                HilightControls(True, ComboBoxMenopausa)
                esito = False
            Else
                HilightControls(False, ComboBoxMenopausa)
            End If
            invalidGroups = invalidGroups.Where(Function(gb) Not (gb Is TableLayoutPanelDismenorrea)).ToList()
        End If

        ' Se "Uso Contraccettivi", verifico che sia stato selezionato un elemento del campo tipo contraccettivo
        If RadioButtonUsoContraccSi.Checked Then
            If ComboBoxTipoContracc.SelectedIndex = -1 Then
                HilightControls(True, ComboBoxTipoContracc)
                esito = False
            Else
                HilightControls(False, ComboBoxTipoContracc)
            End If
        End If

        '----------
        ' Ostetrico
        '----------
        ' Verifico che sia stato inserito un numero di gravidanze
        If String.IsNullOrWhiteSpace(NumericUpDownGravidanze.Text) Then
            HilightControls(True, NumericUpDownGravidanze)
            esito = False
        Else
            HilightControls(False, NumericUpDownGravidanze)
        End If

        ' Verifico che, se ci sono gravidanze, siano stati inseriti anche i parti
        If NumericUpDownGravidanze.Value > 0 Then
            If String.IsNullOrWhiteSpace(NumericUpDownPartiNaturali.Text) Then
                HilightControls(True, NumericUpDownPartiNaturali)
                esito = False
            Else
                HilightControls(False, NumericUpDownPartiNaturali)
            End If
            If String.IsNullOrWhiteSpace(NumericUpDownPartiCesarei.Text) Then
                HilightControls(True, NumericUpDownPartiCesarei)
                esito = False
            Else
                HilightControls(False, NumericUpDownPartiCesarei)
            End If
        End If

        ' Verifico che, se ci sono parti operativi, sia stato selezionato un tipo
        If RadioButtonPartiOperativiSi.Checked Then
            If ComboBoxPartiOperativiTipo.SelectedIndex = -1 Then
                HilightControls(True, ComboBoxPartiOperativiTipo)
                esito = False
            Else
                HilightControls(False, ComboBoxPartiOperativiTipo)
            End If
        End If

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HilightInvalidGroups(invalidGroups.ToArray())
            esito = False
        End If

        Return esito
    End Function

    Private Async Function CercaVisitaAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata
        tipoVisita = main.TipoVisitaSelezionata

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQueryGineco As String = "SELECT * FROM VisitaAnamnesiGinecologica WHERE ID_Visita = @idVisita"

        Dim checkParamGineco As New List(Of SqlParameter) From {
            New SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheckGineco As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQueryGineco, checkParamGineco)
        Dim checkQueryOstetrico As String = "SELECT * FROM VisitaAnamnesiOstetrica WHERE ID_Visita = @idVisita"

        Dim checkParamOstetrico As New List(Of SqlParameter) From {
                New SqlParameter("@idVisita", idVisita)
            }
        Dim dtCheckOstetrico As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQueryOstetrico, checkParamOstetrico)

        If dtCheckGineco.Rows.Count = 1 And dtCheckOstetrico.Rows.Count = 1 Then
            esiste = True ' Anamnesi ostetrico-ginecologica esistente per la visita selezionata

            Dim dettagliVisitaGineco As DataRow = dtCheckGineco.Rows(0)
            Dim dettagliVisitaOstetrico As DataRow = dtCheckOstetrico.Rows(0)
            If Not appenaSalvati Then
                main.MostraToast("Anamnesi esistente per la visita selezionata. Dati caricati.")
            End If

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            '======
            'GINECO
            '======
            ' Contraccettivi
            If dettagliVisitaGineco("Contraccettivi") Then
                RadioButtonUsoContraccSi.Checked = True
            Else
                RadioButtonUsoContraccNo.Checked = True
            End If

            If RadioButtonUsoContraccSi.Checked Then
                ' Tipo contraccettivo
                ComboBoxTipoContracc.SelectedItem = dettagliVisitaGineco("TipoContraccettivo")
            Else
                ComboBoxTipoContracc.SelectedIndex = -1
            End If

            ' Uso di Dienogest/Estrogeni
            If dettagliVisitaGineco("Dienogest") Then
                RadioButtonUsoDienogestSi.Checked = True
                If dettagliVisitaGineco("Estrogeno") Then
                    RadioButtonAssocEstroSi.Checked = True
                Else
                    RadioButtonAssocEstroNo.Checked = True
                End If
            Else
                RadioButtonUsoDienogestNo.Checked = True
            End If

            If RadioButtonUsoDienogestSi.Checked Then

            End If

            If dettagliVisitaGineco("Amenorrea") Then
                RadioButtonAmenorreaSi.Checked = True
            Else
                RadioButtonAmenorreaNo.Checked = True
            End If

            If RadioButtonAmenorreaNo.Checked Then
                ' Dismenorrea
                Select Case dettagliVisitaGineco("Dismenorrea")
                    Case 0
                        RadioButtonDismenorrea0.Checked = True
                    Case 1
                        RadioButtonDismenorrea1.Checked = True
                    Case 2
                        RadioButtonDismenorrea2.Checked = True
                    Case 3
                        RadioButtonDismenorrea3.Checked = True
                End Select
            End If

            'If dettagliVisitaGineco("Menopausa") <> DBNull.Value Then
            ComboBoxMenopausa.SelectedItem = dettagliVisitaGineco("Menopausa")
            'End If

            '=========
            'OSTETRICO
            '=========
            ' Gravidanze
            If IsDBNull(dettagliVisitaOstetrico("Gravidanze")) Then
                NumericUpDownGravidanze.Text = ""
            Else
                NumericUpDownGravidanze.Value = CDec(dettagliVisitaOstetrico("Gravidanze"))
                NumericUpDownGravidanze.Text = NumericUpDownGravidanze.Value.ToString()
            End If

            ' Parti naturali
            If IsDBNull(dettagliVisitaOstetrico("PartiNaturali")) Then
                NumericUpDownPartiNaturali.Text = ""
            Else
                NumericUpDownPartiNaturali.Value = CDec(dettagliVisitaOstetrico("PartiNaturali"))
                NumericUpDownPartiNaturali.Text = NumericUpDownPartiNaturali.Value.ToString()
            End If


            ' Cesarei
            If IsDBNull(dettagliVisitaOstetrico("TagliCesarei")) Then
                NumericUpDownPartiCesarei.Text = ""
            Else
                NumericUpDownPartiCesarei.Value = CDec(dettagliVisitaOstetrico("TagliCesarei"))
                NumericUpDownPartiCesarei.Text = NumericUpDownPartiCesarei.Value.ToString()
            End If

            If IsDBNull(dettagliVisitaOstetrico("PartiOperativi")) Then
                RadioButtonPartiOperativiSi.Checked = False
                RadioButtonPartiOperativiNo.Checked = False
            ElseIf Not dettagliVisitaOstetrico("PartiOperativi") Then
                RadioButtonPartiOperativiNo.Checked = True
            ElseIf dettagliVisitaOstetrico("PartiOperativi") Then
                RadioButtonPartiOperativiSi.Checked = True
            End If

            If IsDBNull(dettagliVisitaOstetrico("VentosaOstetrica")) And IsDBNull(dettagliVisitaOstetrico("Kristeller")) Then
                ComboBoxPartiOperativiTipo.SelectedIndex = -1
            Else
                If dettagliVisitaOstetrico("VentosaOstetrica") And dettagliVisitaOstetrico("Kristeller") Then
                    ComboBoxPartiOperativiTipo.SelectedIndex = 2
                ElseIf dettagliVisitaOstetrico("VentosaOstetrica") And Not dettagliVisitaOstetrico("Kristeller") Then
                    ComboBoxPartiOperativiTipo.SelectedIndex = 0
                ElseIf Not dettagliVisitaOstetrico("VentosaOstetrica") And dettagliVisitaOstetrico("Kristeller") Then
                    ComboBoxPartiOperativiTipo.SelectedValue = 1
                End If
            End If

            If IsDBNull(dettagliVisitaOstetrico("Lacerazioni")) Then
                RadioButtonLacerazioniSi.Checked = False
                RadioButtonLacerazioniNo.Checked = False
            Else
                If dettagliVisitaOstetrico("Lacerazioni") Then
                    RadioButtonLacerazioniSi.Checked = True
                ElseIf Not dettagliVisitaOstetrico("Lacerazioni") Then
                    RadioButtonLacerazioniNo.Checked = True
                End If
            End If

            If IsDBNull(dettagliVisitaOstetrico("Episiotomia")) Then
                RadioButtonEpisiotomiaSi.Checked = False
                RadioButtonEpisiotomiaNo.Checked = False
            Else
                If dettagliVisitaOstetrico("Episiotomia") Then
                    RadioButtonEpisiotomiaSi.Checked = True
                ElseIf Not dettagliVisitaOstetrico("Episiotomia") Then
                    RadioButtonEpisiotomiaNo.Checked = True
                End If
            End If

            Return esiste
        Else
            esiste = False
            PulisciCampi(TableLayoutPanelAnOstrGineco)
            Return esiste
        End If
    End Function

    ' TODO
    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
            idVisita = main.IDVisitaSelezionata

            Dim successo As Boolean = False

            'Gineco
            Dim usoContracc As Boolean = RadioButtonUsoContraccSi.Checked

            Dim TipoContraccettivo As Object

            Dim estrogeno As Object = False
            Dim progesterone As Object = False

            If ComboBoxTipoContracc.SelectedIndex = -1 Then
                TipoContraccettivo = DBNull.Value
            Else
                TipoContraccettivo = ComboBoxTipoContracc.SelectedItem
                Select Case TipoContraccettivo
                    Case "Estroprogestinico orale"
                        estrogeno = True
                        progesterone = True
                    Case "Estroprogestinico vaginale"
                        estrogeno = True
                        progesterone = True
                    Case "Progesterone IUD"
                        estrogeno = False
                        progesterone = True
                    Case "Progesterone orale"
                        estrogeno = False
                        progesterone = True
                    Case "Progesterone sottocutaneo"
                        estrogeno = False
                        progesterone = True
                End Select
            End If

            Dim usoDienogest As Boolean = RadioButtonUsoDienogestSi.Checked
            Dim usoEstrogeno As Object

            If usoDienogest Then
                progesterone = True
                If IsDBNull(TipoContraccettivo) Then
                    usoEstrogeno = RadioButtonAssocEstroSi.Checked
                    If usoEstrogeno Then
                        estrogeno = True
                    Else
                        estrogeno = False
                    End If
                Else
                    usoEstrogeno = DBNull.Value
                End If
            End If

            Dim amenorrea As Boolean = RadioButtonAmenorreaSi.Checked
            Dim dismenorrea As Object
            Dim menopausa As String

            If amenorrea Then
                menopausa = ComboBoxMenopausa.SelectedItem
            Else
                menopausa = "No"
            End If

            If Not amenorrea Then
                dismenorrea = GetSelectedRadioNumber(TableLayoutPanelDismenorrea)
            Else
                dismenorrea = DBNull.Value
            End If

            ' Ostetrico
            Dim gravidanze As Integer = CInt(NumericUpDownGravidanze.Value)
            Dim partiNaturali As Object = CInt(NumericUpDownPartiNaturali.Value)
            Dim partiCesarei As Object = CInt(NumericUpDownPartiCesarei.Value)

            Dim partiOperativi As Object

            Dim ventosaOstetrica As Object
            Dim kristeller As Object

            Dim lacerazioni As Object
            Dim episiotomia As Object

            If gravidanze = 0 Then
                partiCesarei = DBNull.Value
                partiNaturali = DBNull.Value
                ventosaOstetrica = DBNull.Value
                kristeller = DBNull.Value
                partiOperativi = DBNull.Value
                lacerazioni = DBNull.Value
                episiotomia = DBNull.Value
            Else
                If partiCesarei > 0 Or partiNaturali > 0 Then
                    If RadioButtonPartiOperativiSi.Checked Then
                        If ComboBoxPartiOperativiTipo.SelectedIndex = 0 Then
                            ventosaOstetrica = True
                            kristeller = False
                        ElseIf ComboBoxPartiOperativiTipo.SelectedIndex = 1 Then
                            ventosaOstetrica = False
                            kristeller = True
                        ElseIf ComboBoxPartiOperativiTipo.SelectedIndex = 2 Then
                            ventosaOstetrica = True
                            kristeller = True
                        End If
                    Else
                        ventosaOstetrica = DBNull.Value
                        kristeller = DBNull.Value
                    End If
                Else
                    ventosaOstetrica = DBNull.Value
                    kristeller = DBNull.Value
                End If

                If partiCesarei > 0 Or partiNaturali > 0 Then
                    partiOperativi = RadioButtonPartiOperativiSi.Checked
                Else
                    partiOperativi = DBNull.Value
                End If

                If partiNaturali > 0 Or partiCesarei > 0 Then
                    lacerazioni = RadioButtonLacerazioniSi.Checked
                    episiotomia = RadioButtonEpisiotomiaSi.Checked
                Else
                    lacerazioni = DBNull.Value
                    episiotomia = DBNull.Value
                End If
            End If

            Try
                Dim queryAnGineco As String = ""
                Dim queryAnOstetrico As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    queryAnGineco = "UPDATE VisitaAnamnesiGinecologica SET 
                                                           Contraccettivi = @usoContracc,
                                                           Dienogest = @usoDienogest,
                                                           Estrogeno = @estrogeno,
                                                           Progesterone = @progesterone,
                                                           Amenorrea = @amenorrea,
                                                           Dismenorrea = @dismenorrea,
                                                           Menopausa = @menopausa,
                                                           TipoContraccettivo = @tipoContraccettivo
                                                           WHERE ID_Visita = @idVisita"
                    queryAnOstetrico = "UPDATE VisitaAnamnesiOstetrica SET 
                                                           Gravidanze = @gravidanze,
                                                           PartiNaturali = @partiNaturali,
                                                           TagliCesarei = @partiCesarei,
                                                           PartiOperativi = @partiOperativi,
                                                           VentosaOstetrica = @ventosaOstetrica,
                                                           Kristeller = @kristeller,
                                                           Lacerazioni = @lacerazioni,
                                                           Episiotomia = @episiotomia
                                                           WHERE ID_Visita = @idVisita"
                Else
                    'Se non esiste, esegui l'inserimento
                    queryAnGineco = "INSERT INTO VisitaAnamnesiGinecologica (
                                                    ID_Visita,
                                                    Contraccettivi,
                                                    Dienogest,
                                                    Estrogeno,
                                                    Progesterone,
                                                    Amenorrea,
                                                    Dismenorrea,
                                                    Menopausa,
                                                    TipoContraccettivo
                                                    ) VALUES (
                                                    @idVisita,
                                                    @usoContracc,
                                                    @usoDienogest,
                                                    @estrogeno,
                                                    @progesterone,
                                                    @amenorrea,
                                                    @dismenorrea,
                                                    @menopausa,
                                                    @tipoContraccettivo)"
                    queryAnOstetrico = "INSERT INTO VisitaAnamnesiOstetrica (
                                                    ID_Visita,
                                                    Gravidanze,
                                                    PartiNaturali,
                                                    TagliCesarei,
                                                    PartiOperativi,
                                                    VentosaOstetrica,
                                                    Kristeller,
                                                    Lacerazioni,
                                                    Episiotomia
                                                    ) VALUES (
                                                    @idVisita,
                                                    @gravidanze,
                                                    @partiNaturali,
                                                    @partiCesarei,
                                                    @partiOperativi,
                                                    @ventosaOstetrica,
                                                    @kristeller,
                                                    @lacerazioni,
                                                    @episiotomia)"
                End If

                Dim parametriAnGineco As New List(Of SqlParameter) From {
                            New SqlParameter("@idVisita", idVisita),
                            New SqlParameter("@usoContracc", usoContracc),
                            New SqlParameter("@usoDienogest", usoDienogest),
                            New SqlParameter("@estrogeno", estrogeno),
                            New SqlParameter("@progesterone", progesterone),
                            New SqlParameter("@amenorrea", amenorrea),
                            New SqlParameter("@dismenorrea", dismenorrea),
                            New SqlParameter("@menopausa", menopausa),
                            New SqlParameter("@tipoContraccettivo", TipoContraccettivo)
                        }

                Dim parametriAnOstetrico As New List(Of SqlParameter) From {
                            New SqlParameter("@idVisita", idVisita),
                            New SqlParameter("@gravidanze", gravidanze),
                            New SqlParameter("@partiNaturali", partiNaturali),
                            New SqlParameter("@partiCesarei", partiCesarei),
                            New SqlParameter("@partiOperativi", partiOperativi),
                            New SqlParameter("@ventosaOstetrica", ventosaOstetrica),
                            New SqlParameter("@kristeller", kristeller),
                            New SqlParameter("@lacerazioni", lacerazioni),
                            New SqlParameter("@episiotomia", episiotomia)
                        }

                If Await ConnessioneDB.EseguiNonQueryAsync(queryAnGineco, parametriAnGineco) > 0 And Await ConnessioneDB.EseguiNonQueryAsync(queryAnOstetrico, parametriAnOstetrico) > 0 Then
                    successo = True
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Anamnesi ostetrico - ginecologica aggiornata correttamente.")
                    Else
                        main.MostraToast("Anamnesi ostetrico - ginecologica salvata correttamente.")
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
        TableLayoutPanelAnOstrGineco.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelAnOstrGineco.Enabled = True
        If esito Then
            appenaSalvati = True
            TableLayoutPanelAnOstrGineco.Enabled = False

            main.MostraToast("Caricamento in corso ...")
            Dim result = Await CercaVisitaAsync()
            TableLayoutPanelAnOstrGineco.Enabled = True
        End If
    End Sub
End Class
