Public Class UC_AnamnesiPatologicaRemota
    Dim idPaziente As Integer = -1

    Dim esiste As Boolean = False
    Dim appenaSalvati As Boolean = False

    Public Sub AggiornaDati()
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            idPaziente = main.IDPazienteSelezionato

            esiste = CercaAnamnesi()
            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnPatRem)
            End If
        End If
    End Sub

    Private Sub FormAnamnesiPatologicaRemota_Shown(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioAutoCheck(True, TableLayoutPanelAnPatRem)

        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        If main IsNot Nothing Then
            ' Carico i parametri della visita selezionata
            idPaziente = main.IDPazienteSelezionato

            esiste = CercaAnamnesi()
            If Not esiste Then
                PulisciCampi(TableLayoutPanelAnPatRem)
            End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()

        ' ====================
        ' SfButtons
        ' ====================
        With ButtonInserisci.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .ForeColor = Color.White
        End With
    End Sub

    ' Gestione abilitazione campi diabete
    Private Sub RadioButtonDiabete_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDM1Si.CheckedChanged, RadioButtonDM1No.CheckedChanged, RadioButtonDM2Si.CheckedChanged, RadioButtonDM2No.CheckedChanged
        ' Sì su DM1 o DM2 forza la selezione No sull'altro
        If RadioButtonDM1Si.Checked Then
            RadioButtonDM2No.Checked = True
        End If

        If RadioButtonDM2Si.Checked Then
            RadioButtonDM1No.Checked = True
        End If
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True
        ResetRadioButtonGroupTextOnSelection(TableLayoutPanelAnPatRem)

        ' Verifico se sono state effettuate tutte le
        ' Ambito ginecologico
        Dim result = ValidateMultipleGroups(TableLayoutPanelAnPatRem)

        Dim invalidGroups = result.InvalidGroups

        ' Evidenzio tutti i campi obbligatori non compilati corretamente
        If invalidGroups.Any() Then
            ' Evidenzio i groupbox rimasti non validi
            HilightInvalidGroups(invalidGroups.ToArray())
            esito = False
        End If

        Return esito
    End Function

    Private Function CercaAnamnesi() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Carico i parametri della visita selezionata
        idPaziente = main.IDPazienteSelezionato

        'Verifica che non esista già la parte uro - ginecologica per quella visita
        Dim checkQuery As String = "SELECT * FROM AnamnesiPatologicaRemota WHERE ID_Anagrafica = @idAnagrafica"

        Dim checkParam As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@idAnagrafica", idPaziente)
        }
        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows.Count = 1 Then
            esiste = True ' anamnesi patologica remota esistente

            Dim dettagliAnamnesi As DataRow = dtCheck.Rows(0)
            main.MostraToast("Anamnesi patologica remota esistente per il paziente selezionato. Dati caricati.")

            '----------------------------------
            ' Carico i dati esistenti nei campi
            '----------------------------------
            ' Endometriosi
            If dettagliAnamnesi("Endometriosi") Then
                RadioButtonEndometriosiSi.Checked = True
            Else
                RadioButtonEndometriosiNo.Checked = True
            End If

            'Fibromialgie
            If dettagliAnamnesi("Fibromialgie") Then
                RadioButtonFibromialgieSi.Checked = True
            Else
                RadioButtonFibromialgieNo.Checked = True
            End If

            'Colon irritabile
            If dettagliAnamnesi("ColonIrritabile") Then
                RadioButtonColonIrrSi.Checked = True
            Else
                RadioButtonColonIrrNo.Checked = True
            End If

            'Vescica iperattiva
            If dettagliAnamnesi("VescicaIperattiva") Then
                RadioButtonVescIperattSi.Checked = True
            Else
                RadioButtonVescIperattNo.Checked = True
            End If

            'Vescica dolorosa
            If dettagliAnamnesi("VescicaDolorosaa") Then
                RadioButtonVescDolSi.Checked = True
            Else
                RadioButtonVescDolNo.Checked = True
            End If

            'IVU
            If dettagliAnamnesi("IVU") Then
                RadioButtonIVUSi.Checked = True
            Else
                RadioButtonIVUNo.Checked = True
            End If

            'Celiachia
            If dettagliAnamnesi("Celiachia") Then
                RadioButtonCeliachiaSi.Checked = True
            Else
                RadioButtonCeliachiaNo.Checked = True
            End If

            'Intolleranza al lattosio
            If dettagliAnamnesi("IntolleranzaLattosio") Then
                RadioButtonIntollLattSi.Checked = True
            Else
                RadioButtonIntollLattNo.Checked = True
            End If

            'Diabete mellito 1
            If dettagliAnamnesi("DM1") Then
                RadioButtonDM1Si.Checked = True
            Else
                RadioButtonDM1No.Checked = True
            End If

            'Diabete mellito 2
            If dettagliAnamnesi("DM2") Then
                RadioButtonDM2Si.Checked = True
            Else
                RadioButtonDM2No.Checked = True
            End If
        Else
            esiste = False
            PulisciCampi(TableLayoutPanelAnPatRem)
        End If

        Return esiste
    End Function

End Class
