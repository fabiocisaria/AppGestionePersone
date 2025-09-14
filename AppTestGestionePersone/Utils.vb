Imports System.ComponentModel
Imports Microsoft.Data.SqlClient
Imports Syncfusion.WinForms.Input
Imports Syncfusion.WinForms.ListView

Module Utils

    '-----------------------------
    ' Pulisce i campi
    '-----------------------------
    Public Sub PulisciCampi(ParamArray controls() As Control)
        PulisciCampi(False, controls)
    End Sub

    Public Sub PulisciCampi(pulisciLabel As Boolean, ParamArray controls() As Control)
        For Each ctrl In controls
            Select Case True
                Case TypeOf ctrl Is TextBox
                    DirectCast(ctrl, TextBox).Clear()
                Case TypeOf ctrl Is ComboBox
                    DirectCast(ctrl, ComboBox).SelectedIndex = -1
                Case TypeOf ctrl Is Label
                    If pulisciLabel Then
                        DirectCast(ctrl, Label).Text = ""
                    End If
                Case TypeOf ctrl Is CheckBox
                    DirectCast(ctrl, CheckBox).Checked = False
                Case TypeOf ctrl Is RadioButton
                    DirectCast(ctrl, RadioButton).Checked = False
                Case TypeOf ctrl Is DateTimePicker
                    DirectCast(ctrl, DateTimePicker).Value = DateTime.Now.Date
            End Select

            If ctrl.HasChildren Then
                PulisciCampi(pulisciLabel, ctrl.Controls.Cast(Of Control).ToArray())
            End If
        Next
    End Sub

    '-----------------------------
    ' Ripristina AutoCheck Radio button
    '-----------------------------
    Public Sub RadioAutoCheck(value As Boolean, ParamArray controls() As Control)
        For Each ctrl In controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).AutoCheck = value
            End If

            If ctrl.HasChildren Then
                RadioAutoCheck(value, ctrl.Controls.Cast(Of Control).ToArray())
            End If
        Next
    End Sub

    '-----------------------------
    ' Gestisce abilitazione campi
    '-----------------------------
    Public Sub SetControlsEnabled(enabled As Boolean, ParamArray controls() As Control)
        For Each ctrl In controls
            ctrl.Enabled = enabled

            If ctrl.HasChildren Then
                SetControlsEnabled(enabled, ctrl.Controls.Cast(Of Control)().ToArray())
            End If
        Next
    End Sub

    '-----------------------------
    ' Pulisce e gestisce abilitazione campi
    '-----------------------------
    Public Sub ResetAndDisableControls(enabled As Boolean, ParamArray controls() As Control)
        SetControlsEnabled(enabled, controls)
        PulisciCampi(controls)
    End Sub

    '-----------------------------
    ' Gestisce visibilità campi
    '-----------------------------
    Public Sub VisibilitàBox(visibility As Boolean, ParamArray controlli() As Control)
        For Each ctrl As Control In controlli
            ctrl.Visible = visibility

            '-----------------------------
            ' Se il contenitore diventa invisibile, resetta tutti i controlli figli
            '-----------------------------
            If Not visibility Then
                If TypeOf ctrl Is GroupBox OrElse TypeOf ctrl Is TableLayoutPanel OrElse TypeOf ctrl Is Panel Then
                    PulisciCampi(ctrl)
                End If
            End If
        Next
    End Sub

    '-----------------------------
    ' Controlla che almeno un radio button sia selezionato nel gruppo
    '-----------------------------
    Public Function CheckRadioSelection(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                Return True
            End If
        Next
        Return False
    End Function

    '-----------------------------
    ' Restituisce il testo del RadioButton selezionato in un contenitore (il radio button deve essere direttamente figlio del contenitore che viene passato).
    ' Se nessun radiobutton è selezionato restituisce DBNull.Value
    '-----------------------------
    Public Function GetSelectedRadioText(container As Control) As Object
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                Return DirectCast(ctrl, RadioButton).Text
            End If

            ' Ricorsione sui controlli figli
            If ctrl.HasChildren Then
                Dim result As Object = GetSelectedRadioText(ctrl)
                If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Return result
                End If
            End If
        Next

        ' Nessun RadioButton selezionato → restituisco DBNull
        Return DBNull.Value
    End Function

    '-----------------------------
    ' Restituisce il valore numerico del RadioButton selezionato in un contenitore (il radio button deve essere direttamente figlio del contenitore che viene passato)
    '-----------------------------
    Public Function GetSelectedRadioNumber(container As Control) As Integer?
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                Dim testo As String = DirectCast(ctrl, RadioButton).Text
                Dim numero As Integer
                If Integer.TryParse(testo, numero) Then
                    Return numero
                End If
            End If

            If ctrl.HasChildren Then
                Dim result As String = GetSelectedRadioNumber(ctrl)
                If Not String.IsNullOrEmpty(result) Then
                    Return result
                End If
            End If
        Next
        ' Nessuna selezione o testo non numerico
        Return Nothing
    End Function

    '-----------------------------
    ' Verifica se c'è un radio button selezionato nel contenitore ricorsivamente
    '-----------------------------
    Public Function IsGroupBoxSelectionValidRecursive(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                Return True
            End If
            If ctrl.HasChildren AndAlso IsGroupBoxSelectionValidRecursive(ctrl) Then
                Return True
            End If
        Next
        Return False
    End Function

    '-----------------------------
    ' Verifica se in ogni gruppo di radiobutton è stata effettuata una selezione, altrimenti aggiunge il GroupBox padre alla lista
    '-----------------------------
    'Public Function ValidateMultipleGroups(ParamArray containers() As Control) As (IsValid As Boolean, InvalidGroups As List(Of GroupBox))
    '   Dim invalidList As New List(Of GroupBox)
    '
    '   For Each container In containers
    '       If TypeOf container Is GroupBox Then
    '           Dim group = DirectCast(container, GroupBox)
    '
    '          ' Lo valido solo se contiene effettivamente RadioButton
    '           If ContainsRadioButtons(group) Then
    '               If Not IsGroupBoxSelectionValidRecursive(group) Then
    '                   invalidList.Add(group)
    '               End If
    '           End If
    '       End If
    '
    '       ' Ricorsione: controllo anche i figli
    '       If container.HasChildren Then
    '           Dim childResult = ValidateMultipleGroups(container.Controls.Cast(Of Control).ToArray())
    '           invalidList.AddRange(childResult.InvalidGroups)
    '       End If
    '   Next
    '
    '   Return (invalidList.Count = 0, invalidList)
    'End Function

    ' Valido solo i contenitori che hanno RadioButton DIRETTI
    Public Function ValidateMultipleGroups(ParamArray containers() As Control) As (IsValid As Boolean, InvalidGroups As List(Of Control))
        Dim invalidList As New List(Of Control)

        For Each container In containers
            ' Valido solo i contenitori che hanno RadioButton DIRETTI
            If ContainsDirectRadioButtons(container) Then
                If Not IsGroupBoxSelectionValidRecursive(container) Then
                    invalidList.Add(container)   ' aggiungo il contenitore diretto (può essere GroupBox o TableLayoutPanel)
                End If
            End If

            ' Ricorsione: controllo anche i figli
            If container.HasChildren Then
                Dim childResult = ValidateMultipleGroups(container.Controls.Cast(Of Control).ToArray())
                invalidList.AddRange(childResult.InvalidGroups)
            End If
        Next

        Return (invalidList.Count = 0, invalidList)
    End Function

    '-----------------------------
    ' Verifica se un GroupBox ha radio button come figli diretti
    '-----------------------------
    Private Function GroupBoxContainsRadioButtons(ctrl As Control) As Boolean
        If TypeOf ctrl Is RadioButton Then Return True
        For Each child As Control In ctrl.Controls
            If GroupBoxContainsRadioButtons(child) Then Return True
        Next
        Return False
    End Function

    '-----------------------------
    ' Verifica se un Contenitore generico ha radio button come figli diretti
    '-----------------------------
    Private Function ContainsDirectRadioButtons(container As Control) As Boolean
        Return container.Controls.OfType(Of RadioButton)().Any()
    End Function

    '-----------------------------
    ' Resetta il colore dei radiobutton appena viene effettuata una selezione nel gruppo
    '-----------------------------
    Public Sub ResetRadioButtonGroupTextOnSelection(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = DirectCast(ctrl, RadioButton)
                AddHandler rb.CheckedChanged,
            Sub(sender As Object, e As EventArgs)
                Dim radio = DirectCast(sender, RadioButton)
                If radio.Checked Then
                    ' Trova il GroupBox genitore più vicino
                    Dim parentGroup As Control = radio.Parent
                    While parentGroup IsNot Nothing AndAlso Not TypeOf parentGroup Is GroupBox
                        parentGroup = parentGroup.Parent
                    End While

                    ' Resetta ricorsivamente il colore del testo di tutti i RadioButton nel GroupBox
                    If parentGroup IsNot Nothing Then
                        HilightRadioText(parentGroup, SystemColors.ControlText)
                    End If
                End If
            End Sub
            End If

            ' Ricorsione per eventuali contenitori figli
            If ctrl.HasChildren Then
                ResetRadioButtonGroupTextOnSelection(ctrl)
            End If
        Next
    End Sub

    '-----------------------------
    '  Colora i testi dei radiobutton nei contenitori specificati di un colore di default rosso
    '-----------------------------
    Public Sub HilightInvalidGroups(ParamArray containers() As Control)
        HilightRadioGroups(Color.Red, containers)
    End Sub

    '-----------------------------
    ' Colora i testi dei radiobutton nei contenitori specificati. Colore parametrizzabile. Se non parametrizzatousa il rosso
    '-----------------------------
    Public Sub HilightRadioGroups(highlightColor As Color, ParamArray containers() As Control)
        For Each ctrl In containers
            ' Se contiene RadioButton, richiama la funzione per evidenziare il testo
            If ContainsDirectRadioButtons(ctrl) Then
                HilightRadioText(ctrl, highlightColor)
            End If

            ' Ricorsione sui figli
            If ctrl.HasChildren Then
                HilightRadioGroups(highlightColor, ctrl.Controls.Cast(Of Control).ToArray())
            End If
        Next
    End Sub

    '-----------------------------
    ' Colora i text ed i combo box obbligatori con colore predefinito (light yellow).
    '-----------------------------
    Public Sub HilightControls(condition As Boolean, ParamArray controls() As Control)
        HilightControls(condition, Color.LightYellow, controls)
    End Sub

    '-----------------------------
    ' Colora i text ed i combo box obbligatori con colore personalizzato
    '-----------------------------
    Public Sub HilightControls(condition As Boolean, highlightColor As Color, ParamArray controls() As Control)
        For Each ctrl In controls
            If TypeOf ctrl Is TextBox Then
                Dim tb = DirectCast(ctrl, TextBox)
                If condition Then
                    tb.BackColor = highlightColor
                Else
                    tb.BackColor = SystemColors.Window
                End If
            ElseIf TypeOf ctrl Is Syncfusion.Windows.Forms.Tools.TextBoxExt Then
                Dim sfTb = DirectCast(ctrl, Syncfusion.Windows.Forms.Tools.TextBoxExt)
                If condition Then
                    sfTb.BackColor = highlightColor
                Else
                    sfTb.BackColor = Color.White
                End If

            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cb = DirectCast(ctrl, ComboBox)
                If condition Then
                    cb.BackColor = highlightColor
                Else
                    cb.BackColor = SystemColors.Window
                End If
            ElseIf TypeOf ctrl Is Syncfusion.WinForms.ListView.SfComboBox Then
                Dim sfCb = DirectCast(ctrl, Syncfusion.WinForms.ListView.SfComboBox)
                If condition Then
                    sfCb.Style.EditorStyle.BackColor = highlightColor
                    sfCb.Style.ToolTipStyle.BackColor = highlightColor
                Else
                    sfCb.Style.EditorStyle.BackColor = Color.White
                    sfCb.Style.ToolTipStyle.BackColor = Color.White
                End If

            ElseIf TypeOf ctrl Is DateTimePicker Then
                Dim dt = DirectCast(ctrl, DateTimePicker)
                ' Esempio: data di nascita non può essere >= oggi
                If condition Then
                    dt.ForeColor = Color.Red   ' evidenzio il testo
                Else
                    dt.ForeColor = SystemColors.WindowText
                End If
            ElseIf TypeOf ctrl Is Syncfusion.WinForms.Input.SfDateTimeEdit Then
                Dim sfDt = DirectCast(ctrl, Syncfusion.WinForms.Input.SfDateTimeEdit)
                If condition Then
                    sfDt.Style.ForeColor = Color.Red
                Else
                    sfDt.Style.ForeColor = Color.Black
                End If

            ElseIf TypeOf ctrl Is NumericUpDown Then
                Dim nud = DirectCast(ctrl, NumericUpDown)
                If condition Then
                    nud.BackColor = highlightColor
                Else
                    nud.BackColor = SystemColors.Window
                End If
            ElseIf TypeOf ctrl Is Syncfusion.Windows.Forms.Tools.NumericUpDownExt Then
                Dim sfNud = DirectCast(ctrl, Syncfusion.Windows.Forms.Tools.NumericUpDownExt)
                If condition Then
                    sfNud.BackColor = highlightColor
                Else
                    sfNud.BackColor = Color.White
                End If
            End If
        Next
    End Sub

    '-----------------------------
    ' Colora i testi dei radiobutton di colore rosso
    '-----------------------------
    Public Sub HilightRadioText(container As Control)
        HilightRadioText(container, Color.Red)
    End Sub

    '-----------------------------
    ' Colora i testi dei radiobutton del colore passato come parametro
    '-----------------------------
    Public Sub HilightRadioText(container As Control, highlightColor As Color)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = DirectCast(ctrl, RadioButton)
                rb.ForeColor = highlightColor
            End If

            ' Ricorsione sui figli
            If ctrl.HasChildren Then
                HilightRadioText(ctrl, highlightColor)
            End If
        Next
    End Sub

    '-----------------------------
    ' Ricerca paziente
    '-----------------------------
    'Public Function CercaPaziente(codiceID As String, cognome As String) As (ID As Integer, Codice As String)
    '   Dim query As String
    '  Dim parametri As New List(Of SqlParameter)
    '
    '  If Not String.IsNullOrWhiteSpace(codiceID) Then
    '      query = "SELECT ID, CodiceIdentificativo, Nome, Cognome 
    '               FROM Anagrafica 
    '               WHERE CodiceIdentificativo LIKE @codice"
    '      parametri.Add(New SqlParameter("@codice", "%" & codiceID.Trim() & "%"))
    '  Else
    '      query = "SELECT ID, CodiceIdentificativo, Nome, Cognome 
    '               FROM Anagrafica 
    '               WHERE Cognome LIKE @cognome"
    '      parametri.Add(New SqlParameter("@cognome", "%" & cognome.Trim() & "%"))
    'End If
    '
    '    Dim risultato As DataTable = EseguiQuery(query, parametri)
    '
    '    If risultato.Rows.Count > 0 Then
    '    Dim f As New FormSelezionePaziente(risultato)
    '    If f.ShowDialog() = DialogResult.OK Then
    '    Return (f.IDSelezionato, f.CodiceIdentificativoSelezionato)
    '    End If
    '    End If
    '
    '    Return (0, Nothing) ' se nessun paziente selezionato
    '    End Function

    '-----------------------------
    ' Ricerca paziente per user control
    '-----------------------------
    Public Async Function CercaPazienteUCAsync(codiceID As String, cognome As String) As Task(Of DataTable)
        Dim query As String
        Dim parametri As New List(Of SqlParameter)

        If Not String.IsNullOrWhiteSpace(codiceID) Then
            query = "SELECT ID, CodiceIdentificativo, Nome, Cognome, DataNascita
                     FROM Anagrafica 
                     WHERE CodiceIdentificativo COLLATE Latin1_General_CI_AI LIKE @codice"
            parametri.Add(New SqlParameter("@codice", "%" & codiceID.Trim() & "%"))
        Else
            query = "SELECT ID, CodiceIdentificativo, Nome, Cognome, DataNascita
                     FROM Anagrafica 
                     WHERE Cognome COLLATE Latin1_General_CI_AI LIKE @cognome"
            parametri.Add(New SqlParameter("@cognome", "%" & cognome.Trim() & "%"))
        End If

        Dim risultato As DataTable = Await ConnessioneDB.EseguiQueryAsync(query, parametri)

        Return risultato ' se nessun paziente selezionato
    End Function

    '-----------------------------
    ' Ricerca visita per user control (paziente già selezionato)
    '-----------------------------
    Public Async Function CercaVisiteUCAsync(idPaziente As Integer, dataVisita As Date?, Optional tipoVisita As String = Nothing) As Task(Of DataTable)
        Dim query As String = ""
        Dim parametri As New List(Of SqlParameter)

        If dataVisita.HasValue Then
            If Not String.IsNullOrEmpty(tipoVisita) Then
                ' Cerco la visita con idPaziente, Data visita e Tipo visita
                query = "SELECT ID, DataVisita, TipoVisita
                         FROM Visite 
                         WHERE ID_Anagrafica = @codice AND DataVisita = @dataVisita AND TipoVisita = @tipoVisita"
                parametri.AddRange(New List(Of SqlParameter) From {
                             New SqlParameter("@codice", idPaziente),
                             New SqlParameter("@dataVisita", dataVisita.Value),
                             New SqlParameter("@tipoVisita", tipoVisita)
                })
            Else
                ' Cerco la visita con idPaziente, Data visita
                query = "SELECT ID, DataVisita, TipoVisita
                         FROM Visite 
                         WHERE ID_Anagrafica = @codice AND DataVisita = @dataVisita"
                parametri.AddRange(New List(Of SqlParameter) From {
                             New SqlParameter("@codice", idPaziente),
                             New SqlParameter("@dataVisita", dataVisita.Value)
                             })
            End If
        ElseIf Not String.IsNullOrEmpty(tipoVisita) Then
            ' Cerco la visita con idPaziente e Tipo visita
            query = "SELECT ID, DataVisita, TipoVisita
                     FROM Visite 
                     WHERE ID_Anagrafica = @codice AND TipoVisita = @tipoVisita"
            parametri.AddRange(New List(Of SqlParameter) From {
                             New SqlParameter("@codice", idPaziente),
                             New SqlParameter("@tipoVisita", tipoVisita)
                })
        Else
            ' Cerco la visita con idPaziente
            query = "SELECT ID, DataVisita, TipoVisita
                         FROM Visite 
                         WHERE ID_Anagrafica = @codice"
            parametri.Add(New SqlParameter("@codice", idPaziente))
        End If

        Dim risultato As DataTable = Await ConnessioneDB.EseguiQueryAsync(query, parametri)

        Return risultato ' se nessun paziente selezionato
    End Function

End Module