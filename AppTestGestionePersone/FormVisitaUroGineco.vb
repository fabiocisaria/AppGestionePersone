Public Class FormVisitaUroGineco
    Dim idVisita As Integer = -1

    Public Sub New(visita As Integer)
        InitializeComponent()
        idVisita = visita
    End Sub

    ' Controllo se la visita è prima visita o controllo
    Private Function VerificaTipoVisita(numVisita As Integer) As Integer
        Dim checkQuery As String = "SELECT(*) FROM Visite WHERE ID = @idVisita"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idVisita", numVisita)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows(0)(0) > 0 Then
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

    Private Function CheckSelezione(tipoVisita As Integer) As Boolean
        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelVisitaUroGineco)

        ' Verifico se sono state effettuate tutte le scelte
        Dim result = ValidateMultipleGroups(TableLayoutPanelVisitaUroGineco)

        Dim invalidGroups = result.InvalidGroups

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HighlightInvalidGroups(invalidGroups.ToArray())
            Return False
        Else
            Return True
        End If
    End Function

    Private Function SalvaDati() As (Successo As Boolean, idVisita As Integer)

        Dim tipoVisita As Integer = VerificaTipoVisita(idVisita)
        Dim selezioneOK As Boolean = CheckSelezione(tipoVisita)

        If selezioneOK Then
            ' Se tutte le scelte sono state effettuate procedo con l'inderimento nel DB
            Dim successo As Boolean = False

            Dim swabClit As Integer = CInt(NumericUpDownClit.Value)
            Dim swabVestDx As Integer = CInt(NumericUpDownVestDx.Value)
            Dim swabVestSx As Integer = CInt(NumericUpDownVestSx.Value)
            Dim swabSubr As Integer = CInt(NumericUpDownSubr.Value)
            Dim swabForc As Integer = CInt(NumericUpDownForc.Value)

            Dim vgStato As String = GetSelectedRadioText(TableLayoutPanelVagStato)
            Dim vgLichen As String = RadioButtonLicSi.Checked
            Dim vgCicRef As Boolean = RadioButtonCicSi.Checked

            Dim ipercontrattilita As String = GetSelectedRadioText(GroupBoxIperContr)

            Dim cistProv As Boolean = RadioButtonCitProSi.Checked

            Dim aderTp As Object = DBNull.Value
            Dim miglioramento As Object = DBNull.Value

            'TODO
            Try
                'Verifica che non esista già la parte uro - ginecologica per quella visita
                Dim checkQuery As String = "SELECT COUNT(*) FROM VisitaUroGineco WHERE ID_Visita = @idVisita"

                Dim checkParam As New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@idVisita", idVisita)
                }
                Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

                If dtCheck.Rows(0)(0) > 0 Then
                    MessageBox.Show("Attenzione: per questa visita è già stata inserita la parte di uro - ginecologia")
                    Return (False, -1)
                End If

                'Se non esiste, esegui l'inserimento
                Dim querySwabTest As String = "INSERT INTO VisitaSwabTest (
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
                    Dim queryVisitaUroGineco As String = "INSERT INTO VisitaSwabTest (
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

                    Dim parametriVisitaUroGineco As New List(Of SqlClient.SqlParameter) From {
                        New SqlClient.SqlParameter("@idVisita", idVisita),
                        New SqlClient.SqlParameter("@vgStato", vgStato),
                        New SqlClient.SqlParameter("@vgLichen", vgLichen),
                        New SqlClient.SqlParameter("@vgCicRef", vgCicRef),
                        New SqlClient.SqlParameter("@ipercontrattilita", ipercontrattilita),
                        New SqlClient.SqlParameter("@cistProv", cistProv)
                    }

                    If EseguiNonQuery(queryVisitaUroGineco, parametriVisitaUroGineco) <= 0 Then
                        successo = False
                    End If
                End If

                Return (successo, idVisita)
            Catch ex As Exception
                MessageBox.Show("Errore imprevisto: " & ex.Message)
                Return (False, -2)
            End Try
        End If
    End Function

    Private Sub Inserici_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito As Object

        esito = SalvaDati()
        If esito.Successo Then
            'Dim formVisitaUroGineco As New FormVisitaUroGineco(esito.idVisita)
            'FormVisitaUroGineco.Show()
            'Me.Hide()
        End If
    End Sub
End Class