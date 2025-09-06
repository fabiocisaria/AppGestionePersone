Public Class UC_VisitaUroGineco
    Dim idVisita As Integer = -1
    Dim tipoVisita As String = ""

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(TableLayoutPanelVisitaUroGineco)
            End If
        End If
    End Sub

    Private Sub UC_VisitaUroGineco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Imposto i valori minimi e massimi per gli NumericUpDown dello Swab Test
        NumericUpDownClit.Minimum = 0
        NumericUpDownClit.Maximum = 10
        NumericUpDownVestDx.Minimum = 0
        NumericUpDownVestDx.Maximum = 10
        NumericUpDownVestSx.Minimum = 0
        NumericUpDownVestSx.Maximum = 10
        NumericUpDownSubr.Minimum = 0
        NumericUpDownSubr.Maximum = 10
        NumericUpDownForc.Minimum = 0
        NumericUpDownForc.Maximum = 10

        NumericUpDownClit.ResetText()
        NumericUpDownVestDx.ResetText()
        NumericUpDownVestSx.ResetText()
        NumericUpDownSubr.ResetText()
        NumericUpDownForc.ResetText()

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idVisita = main.IDVisitaSelezionata
            tipoVisita = main.TipoVisitaSelezionata
            ' Cerco se esiste già una visita uro-ginecologica per la visita selezionata
            esiste = CercaVisita()
            If Not esiste Then
                PulisciCampi(TableLayoutPanelVisitaUroGineco)
            End If
        End If
    End Sub

    ' Controllo se la visita è prima visita o controllo (non usato perché il tipo visita è salvato nel MainForm)
    Private Function VerificaTipoVisita(numVisita As Integer) As Integer
        Dim checkQuery As String = "SELECT * FROM Visite WHERE ID = @idVisita"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idVisita", numVisita)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows.Count > 0 Then
            Dim tipoVisita As String = dtCheck.Rows(0)("TipoVisita").ToString()
            If tipoVisita = "Prima visita" Then
                Return 0
            Else
                Return 1
            End If
        Else
            MessageBox.Show("Errore imprevisto. Visita non trovata.")
            Return -1
        End If
    End Function

    ' Gestisco l'abilitazione dei GroupBox in base al tipo visita in fase di caricamento in memoria della form
    Private Sub FormVisitaUroGineco_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numVisita As Integer = idVisita
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True

        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelVisitaUroGineco)
        If String.IsNullOrWhiteSpace(NumericUpDownClit.Text) Then
            HilightControls(True, NumericUpDownClit)
            esito = False
        Else
            HilightControls(False, NumericUpDownClit)
        End If

        If String.IsNullOrWhiteSpace(NumericUpDownVestDx.Text) Then
            HilightControls(True, NumericUpDownVestDx)
            esito = False
        Else
            HilightControls(False, NumericUpDownVestDx)
        End If

        If String.IsNullOrWhiteSpace(NumericUpDownVestSx.Text) Then
            HilightControls(True, NumericUpDownVestSx)
            esito = False
        Else
            HilightControls(False, NumericUpDownVestSx)
        End If

        If String.IsNullOrWhiteSpace(NumericUpDownSubr.Text) Then
            HilightControls(True, NumericUpDownSubr)
            esito = False
        Else
            HilightControls(False, NumericUpDownSubr)
        End If

        If String.IsNullOrWhiteSpace(NumericUpDownForc.Text) Then
            HilightControls(True, NumericUpDownForc)
            esito = False
        Else
            HilightControls(False, NumericUpDownForc)
        End If

        ' Verifico se sono state effettuate tutte le scelte
        Dim result = ValidateMultipleGroups(TableLayoutPanelVisitaUroGineco)

        Dim invalidGroups = result.InvalidGroups

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HilightInvalidGroups(invalidGroups.ToArray())
            esito = False
        End If

        Return esito
    End Function

    Private Function CercaVisita() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata
        tipoVisita = main.TipoVisitaSelezionata

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM VisitaUroGineco WHERE ID_Visita = @idVisita"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idVisita", idVisita)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        Dim checkSwabQuery As String = "SELECT * FROM VisitaSwabTest WHERE ID_Visita = @idVisita"

        Dim checkSwabParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idVisita", idVisita)
        }
        Dim dtSwabCheck As DataTable = EseguiQuery(checkSwabQuery, checkSwabParam)

        If dtCheck.Rows.Count = 1 And dtSwabCheck.Rows.Count = 1 Then
            esiste = True ' visita uro - ginecologica esistente

            Dim dettagliVisita As DataRow = dtCheck.Rows(0)
            main.MostraToast("Visita uro-ginecologica esistente. Dati caricati.")

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            ' Vagina stato
            If dettagliVisita("Stato") = "Regolare" Then
                RadioButtonStReg.Checked = True
            ElseIf dettagliVisita("Stato") = "Distrofica" Then
                RadioButtonStDistr.Checked = True
            ElseIf dettagliVisita("Stato") = "Atrofica" Then
                RadioButtonStAtr.Checked = True
            End If

            ' Lichen Sì/No
            If dettagliVisita("Lichen") = True Then
                RadioButtonLicSi.Checked = True
            Else
                RadioButtonLicNo.Checked = True
            End If

            ' Cicatrice retraente
            If dettagliVisita("CicatriceRetraente") Then
                RadioButtonCicSi.Checked = True
            Else
                RadioButtonCicNo.Checked = True
            End If

            ' Ipercontrattilità
            If dettagliVisita("Ipercontrattilita") = "Lieve" Then
                RadioButtonContrL.Checked = True
            ElseIf dettagliVisita("Ipercontrattilita") = "Moderata" Then
                RadioButtonContrM.Checked = True
            ElseIf dettagliVisita("Ipercontrattilita") = "Severa" Then
                RadioButtonContrS.Checked = True
            End If

            ' Cistalgie provocate
            If dettagliVisita("CitalgiaProvocata") = True Then
                RadioButtonCitProSi.Checked = True
            Else
                RadioButtonCitProNo.Checked = True
            End If

            Dim dettagliSwab As DataRow = dtSwabCheck.Rows(0)

            '--------------------------------------------
            ' Carico i dati Swab test esistenti nei campi
            '--------------------------------------------
            NumericUpDownClit.Value = Convert.ToInt32(dettagliSwab("Clitoride"))
            NumericUpDownVestDx.Value = Convert.ToInt32(dettagliSwab("VestiboloDx"))
            NumericUpDownVestSx.Value = Convert.ToInt32(dettagliSwab("VestiboloSx"))
            NumericUpDownSubr.Value = Convert.ToInt32(dettagliSwab("Subretrale"))
            NumericUpDownForc.Value = Convert.ToInt32(dettagliSwab("Forchetta"))

            Return esiste
        Else
            esiste = False
            PulisciCampi(TableLayoutPanelVisitaUroGineco)
            Return esiste
        End If
    End Function

    Private Function SalvaDati() As Boolean

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        ' Carico i parametri della visita selezionata
        idVisita = main.IDVisitaSelezionata
        tipoVisita = main.TipoVisitaSelezionata

        Dim selezioneOK As Boolean = CheckSelezione()

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            Dim successo As Boolean = False

            Dim swabClit As Integer = CInt(NumericUpDownClit.Value)
            Dim swabVestDx As Integer = CInt(NumericUpDownVestDx.Value)
            Dim swabVestSx As Integer = CInt(NumericUpDownVestSx.Value)
            Dim swabSubr As Integer = CInt(NumericUpDownSubr.Value)
            Dim swabForc As Integer = CInt(NumericUpDownForc.Value)

            Dim vgStato As String = GetSelectedRadioText(TableLayoutPanelVagStato)
            Dim vgLichen As Boolean = RadioButtonLicSi.Checked
            Dim vgCicRef As Boolean = RadioButtonCicSi.Checked

            Dim ipercontrattilita As String = GetSelectedRadioText(GroupBoxIperContr)

            Dim cistProv As Boolean = RadioButtonCitProSi.Checked

            Dim aderTp As Object = DBNull.Value
            Dim miglioramento As Object = DBNull.Value

            'TODO
            Try
                Dim queryVisitaUroGineco As String = ""
                Dim querySwabTest As String = ""
                If esiste Then
                    ' Query di aggiornamento se la visita esiste già
                    queryVisitaUroGineco = "UPDATE VisitaUroGineco SET 
                                                          Stato = @vgStato,
                                                          Lichen = @vgLichen,
                                                          CicatriceRetraente = @vgCicRef,
                                                          Ipercontrattilita = @ipercontrattilita,
                                                          CitalgiaProvocata = @cistProv
                                                          WHERE ID_Visita = @idVisita"

                    querySwabTest = "UPDATE VisitaSwabTest SET
                                                    Clitoride = @swabClit,
                                                    VestiboloDx = @swabVestDx,
                                                    VestiboloSx = @swabVestSx,
                                                    Subretrale = @swabSubr,
                                                    Forchetta = @swabForc
                                                    WHERE ID_Visita = @idVisita"

                Else
                    ' Query di inserimento se la visita non esiste già
                    querySwabTest = "INSERT INTO VisitaSwabTest (
                                                    ID_Visita,
                                                    Clitoride,
                                                    VestiboloDx,
                                                    VestiboloSx,
                                                    Subretrale,
                                                    Forchetta
                                                    ) VALUES (
                                                    @idVisita,
                                                    @swabClit,
                                                    @swabVestDx,
                                                    @swabVestSx,
                                                    @swabSubr,
                                                    @swabForc
                                                    )"
                    queryVisitaUroGineco = "INSERT INTO VisitaUroGineco (
                                                        ID_Visita,
                                                        Stato,
                                                        Lichen,
                                                        CicatriceRetraente,
                                                        Ipercontrattilita,
                                                        CitalgiaProvocata
                                                        ) VALUES (
                                                        @idVisita,
                                                        @vgStato,
                                                        @vgLichen,
                                                        @vgCicRef,
                                                        @ipercontrattilita,
                                                        @cistProv
                                                        )"
                End If

                Dim parametriSwabTest As New List(Of SqlClient.SqlParameter) From {
                        New SqlClient.SqlParameter("@idVisita", idVisita),
                        New SqlClient.SqlParameter("@swabClit", swabClit),
                        New SqlClient.SqlParameter("@swabVestDx", swabVestDx),
                        New SqlClient.SqlParameter("@swabVestSx", swabVestSx),
                        New SqlClient.SqlParameter("@swabSubr", swabSubr),
                        New SqlClient.SqlParameter("@swabForc", swabForc)
                    }

                If EseguiNonQuery(querySwabTest, parametriSwabTest) > 0 Then
                    successo = True
                End If

                If successo = True Then

                    Dim parametriVisitaUroGineco As New List(Of SqlClient.SqlParameter) From {
                        New SqlClient.SqlParameter("@idVisita", idVisita),
                        New SqlClient.SqlParameter("@vgStato", vgStato),
                        New SqlClient.SqlParameter("@vgLichen", vgLichen),
                        New SqlClient.SqlParameter("@vgCicRef", vgCicRef),
                        New SqlClient.SqlParameter("@ipercontrattilita", ipercontrattilita),
                        New SqlClient.SqlParameter("@cistProv", cistProv)
                    }

                    If EseguiNonQuery(queryVisitaUroGineco, parametriVisitaUroGineco) > 0 Then
                        successo = True
                    Else
                        successo = False
                    End If
                End If

                If successo Then
                    If esiste Then
                        main.MostraToast("Dati visita aggiornati correttamente.")
                    Else
                        main.MostraToast("Dati visita salvati correttamente.")
                    End If
                Else
                    main.MostraToast("Errore imprevisto durante il salvataggio dei dati.")
                End If
                Return successo
            Catch ex As Exception
                MessageBox.Show("Errore imprevisto: " & ex.Message)
                Return False
            End Try
        End If
    End Function

    Private Sub Inserici_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito As Boolean = SalvaDati()
        If esito Then
            appenaSalvati = True
            CercaVisita()
        End If
    End Sub
End Class
