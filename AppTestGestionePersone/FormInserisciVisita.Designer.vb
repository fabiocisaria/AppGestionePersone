<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInserisciVisita
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxRicercaPaziente = New System.Windows.Forms.GroupBox()
        Me.LabelIDAnagrafica = New System.Windows.Forms.Label()
        Me.LabelCodiceID = New System.Windows.Forms.Label()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.ButtonCercaPaziente = New System.Windows.Forms.Button()
        Me.TextBoxCodiceID = New System.Windows.Forms.TextBox()
        Me.TextBoxCognome = New System.Windows.Forms.TextBox()
        Me.GroupBoxTipoVisita = New System.Windows.Forms.GroupBox()
        Me.ButtonSintomi = New System.Windows.Forms.Button()
        Me.DateTimePickerDataVisita = New System.Windows.Forms.DateTimePicker()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New System.Windows.Forms.Button()
        Me.TextBoxMotivo = New System.Windows.Forms.TextBox()
        Me.LabelMotivoVisita = New System.Windows.Forms.Label()
        Me.ComboBoxTipoVisita = New System.Windows.Forms.ComboBox()
        Me.LabelTipoVisita = New System.Windows.Forms.Label()
        Me.GroupBoxRicercaPaziente.SuspendLayout()
        Me.GroupBoxTipoVisita.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRicercaPaziente
        '
        Me.GroupBoxRicercaPaziente.Controls.Add(Me.LabelIDAnagrafica)
        Me.GroupBoxRicercaPaziente.Controls.Add(Me.LabelCodiceID)
        Me.GroupBoxRicercaPaziente.Controls.Add(Me.LabelCognome)
        Me.GroupBoxRicercaPaziente.Controls.Add(Me.ButtonCercaPaziente)
        Me.GroupBoxRicercaPaziente.Controls.Add(Me.TextBoxCodiceID)
        Me.GroupBoxRicercaPaziente.Controls.Add(Me.TextBoxCognome)
        Me.GroupBoxRicercaPaziente.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxRicercaPaziente.Name = "GroupBoxRicercaPaziente"
        Me.GroupBoxRicercaPaziente.Size = New System.Drawing.Size(319, 127)
        Me.GroupBoxRicercaPaziente.TabIndex = 1
        Me.GroupBoxRicercaPaziente.TabStop = False
        Me.GroupBoxRicercaPaziente.Text = "Ricerca paziente"
        '
        'LabelIDAnagrafica
        '
        Me.LabelIDAnagrafica.AutoSize = True
        Me.LabelIDAnagrafica.Location = New System.Drawing.Point(32, 96)
        Me.LabelIDAnagrafica.Name = "LabelIDAnagrafica"
        Me.LabelIDAnagrafica.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDAnagrafica.TabIndex = 1
        Me.LabelIDAnagrafica.Visible = False
        '
        'LabelCodiceID
        '
        Me.LabelCodiceID.AutoSize = True
        Me.LabelCodiceID.Location = New System.Drawing.Point(32, 68)
        Me.LabelCodiceID.Name = "LabelCodiceID"
        Me.LabelCodiceID.Size = New System.Drawing.Size(102, 13)
        Me.LabelCodiceID.TabIndex = 2
        Me.LabelCodiceID.Text = "Codice identificativo"
        '
        'LabelCognome
        '
        Me.LabelCognome.AutoSize = True
        Me.LabelCognome.Location = New System.Drawing.Point(32, 42)
        Me.LabelCognome.Name = "LabelCognome"
        Me.LabelCognome.Size = New System.Drawing.Size(52, 13)
        Me.LabelCognome.TabIndex = 2
        Me.LabelCognome.Text = "Cognome"
        '
        'ButtonCercaPaziente
        '
        Me.ButtonCercaPaziente.Location = New System.Drawing.Point(219, 91)
        Me.ButtonCercaPaziente.Name = "ButtonCercaPaziente"
        Me.ButtonCercaPaziente.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCercaPaziente.TabIndex = 2
        Me.ButtonCercaPaziente.Text = "Cerca"
        Me.ButtonCercaPaziente.UseVisualStyleBackColor = True
        '
        'TextBoxCodiceID
        '
        Me.TextBoxCodiceID.Location = New System.Drawing.Point(140, 65)
        Me.TextBoxCodiceID.Name = "TextBoxCodiceID"
        Me.TextBoxCodiceID.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxCodiceID.TabIndex = 1
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Location = New System.Drawing.Point(90, 39)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxCognome.TabIndex = 0
        '
        'GroupBoxTipoVisita
        '
        Me.GroupBoxTipoVisita.Controls.Add(Me.ButtonSintomi)
        Me.GroupBoxTipoVisita.Controls.Add(Me.DateTimePickerDataVisita)
        Me.GroupBoxTipoVisita.Controls.Add(Me.LabelData)
        Me.GroupBoxTipoVisita.Controls.Add(Me.ButtonInserisci)
        Me.GroupBoxTipoVisita.Controls.Add(Me.TextBoxMotivo)
        Me.GroupBoxTipoVisita.Controls.Add(Me.LabelMotivoVisita)
        Me.GroupBoxTipoVisita.Controls.Add(Me.ComboBoxTipoVisita)
        Me.GroupBoxTipoVisita.Controls.Add(Me.LabelTipoVisita)
        Me.GroupBoxTipoVisita.Location = New System.Drawing.Point(12, 145)
        Me.GroupBoxTipoVisita.Name = "GroupBoxTipoVisita"
        Me.GroupBoxTipoVisita.Size = New System.Drawing.Size(319, 127)
        Me.GroupBoxTipoVisita.TabIndex = 2
        Me.GroupBoxTipoVisita.TabStop = False
        Me.GroupBoxTipoVisita.Text = "Tipologia visita"
        '
        'ButtonSintomi
        '
        Me.ButtonSintomi.Location = New System.Drawing.Point(35, 96)
        Me.ButtonSintomi.Name = "ButtonSintomi"
        Me.ButtonSintomi.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSintomi.TabIndex = 9
        Me.ButtonSintomi.Text = "Sintomi"
        Me.ButtonSintomi.UseVisualStyleBackColor = True
        '
        'DateTimePickerDataVisita
        '
        Me.DateTimePickerDataVisita.Location = New System.Drawing.Point(94, 44)
        Me.DateTimePickerDataVisita.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerDataVisita.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerDataVisita.Name = "DateTimePickerDataVisita"
        Me.DateTimePickerDataVisita.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDataVisita.TabIndex = 4
        Me.DateTimePickerDataVisita.Value = New Date(2025, 8, 19, 1, 36, 7, 0)
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(33, 50)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 8
        Me.LabelData.Text = "Data"
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Location = New System.Drawing.Point(219, 96)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInserisci.TabIndex = 6
        Me.ButtonInserisci.Text = "Inserisci"
        Me.ButtonInserisci.UseVisualStyleBackColor = True
        '
        'TextBoxMotivo
        '
        Me.TextBoxMotivo.Location = New System.Drawing.Point(94, 70)
        Me.TextBoxMotivo.Name = "TextBoxMotivo"
        Me.TextBoxMotivo.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxMotivo.TabIndex = 5
        '
        'LabelMotivoVisita
        '
        Me.LabelMotivoVisita.AutoSize = True
        Me.LabelMotivoVisita.Location = New System.Drawing.Point(33, 73)
        Me.LabelMotivoVisita.Name = "LabelMotivoVisita"
        Me.LabelMotivoVisita.Size = New System.Drawing.Size(39, 13)
        Me.LabelMotivoVisita.TabIndex = 6
        Me.LabelMotivoVisita.Text = "Motivo"
        '
        'ComboBoxTipoVisita
        '
        Me.ComboBoxTipoVisita.FormattingEnabled = True
        Me.ComboBoxTipoVisita.Items.AddRange(New Object() {"Prima visita", "Controllo"})
        Me.ComboBoxTipoVisita.Location = New System.Drawing.Point(94, 17)
        Me.ComboBoxTipoVisita.Name = "ComboBoxTipoVisita"
        Me.ComboBoxTipoVisita.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxTipoVisita.TabIndex = 3
        '
        'LabelTipoVisita
        '
        Me.LabelTipoVisita.AutoSize = True
        Me.LabelTipoVisita.Location = New System.Drawing.Point(33, 20)
        Me.LabelTipoVisita.Name = "LabelTipoVisita"
        Me.LabelTipoVisita.Size = New System.Drawing.Size(55, 13)
        Me.LabelTipoVisita.TabIndex = 4
        Me.LabelTipoVisita.Text = "Tipo visita"
        '
        'FormInserisciVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 284)
        Me.Controls.Add(Me.GroupBoxTipoVisita)
        Me.Controls.Add(Me.GroupBoxRicercaPaziente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormInserisciVisita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuova visita"
        Me.GroupBoxRicercaPaziente.ResumeLayout(False)
        Me.GroupBoxRicercaPaziente.PerformLayout()
        Me.GroupBoxTipoVisita.ResumeLayout(False)
        Me.GroupBoxTipoVisita.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxRicercaPaziente As GroupBox
    Friend WithEvents LabelIDAnagrafica As Label
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents LabelCognome As Label
    Friend WithEvents ButtonCercaPaziente As Button
    Friend WithEvents TextBoxCodiceID As TextBox
    Friend WithEvents TextBoxCognome As TextBox
    Friend WithEvents GroupBoxTipoVisita As GroupBox
    Friend WithEvents TextBoxMotivo As TextBox
    Friend WithEvents LabelMotivoVisita As Label
    Friend WithEvents ComboBoxTipoVisita As ComboBox
    Friend WithEvents LabelTipoVisita As Label
    Friend WithEvents ButtonInserisci As Button
    Friend WithEvents LabelData As Label
    Friend WithEvents DateTimePickerDataVisita As DateTimePicker
    Friend WithEvents ButtonSintomi As Button
End Class
