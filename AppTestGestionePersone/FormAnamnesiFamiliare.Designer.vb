<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnamnesiFamiliare
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
        Me.GroupBoxAnamnesi = New System.Windows.Forms.GroupBox()
        Me.LabelParentela = New System.Windows.Forms.Label()
        Me.ComboBoxParentela = New System.Windows.Forms.ComboBox()
        Me.LabelPatologie = New System.Windows.Forms.Label()
        Me.ButtonSalva = New System.Windows.Forms.Button()
        Me.TextPatologie = New System.Windows.Forms.TextBox()
        Me.GroupBoxRicercaPaziente.SuspendLayout()
        Me.GroupBoxAnamnesi.SuspendLayout()
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
        Me.GroupBoxRicercaPaziente.TabIndex = 0
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
        Me.ButtonCercaPaziente.Location = New System.Drawing.Point(210, 91)
        Me.ButtonCercaPaziente.Name = "ButtonCercaPaziente"
        Me.ButtonCercaPaziente.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCercaPaziente.TabIndex = 3
        Me.ButtonCercaPaziente.Text = "Cerca"
        Me.ButtonCercaPaziente.UseVisualStyleBackColor = True
        '
        'TextBoxCodiceID
        '
        Me.TextBoxCodiceID.Location = New System.Drawing.Point(140, 65)
        Me.TextBoxCodiceID.Name = "TextBoxCodiceID"
        Me.TextBoxCodiceID.Size = New System.Drawing.Size(145, 20)
        Me.TextBoxCodiceID.TabIndex = 1
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Location = New System.Drawing.Point(90, 39)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(195, 20)
        Me.TextBoxCognome.TabIndex = 0
        '
        'GroupBoxAnamnesi
        '
        Me.GroupBoxAnamnesi.Controls.Add(Me.LabelParentela)
        Me.GroupBoxAnamnesi.Controls.Add(Me.ComboBoxParentela)
        Me.GroupBoxAnamnesi.Controls.Add(Me.LabelPatologie)
        Me.GroupBoxAnamnesi.Controls.Add(Me.ButtonSalva)
        Me.GroupBoxAnamnesi.Controls.Add(Me.TextPatologie)
        Me.GroupBoxAnamnesi.Location = New System.Drawing.Point(12, 145)
        Me.GroupBoxAnamnesi.Name = "GroupBoxAnamnesi"
        Me.GroupBoxAnamnesi.Size = New System.Drawing.Size(319, 127)
        Me.GroupBoxAnamnesi.TabIndex = 3
        Me.GroupBoxAnamnesi.TabStop = False
        Me.GroupBoxAnamnesi.Text = "Dati anamnesi"
        '
        'LabelParentela
        '
        Me.LabelParentela.AutoSize = True
        Me.LabelParentela.Location = New System.Drawing.Point(32, 41)
        Me.LabelParentela.Name = "LabelParentela"
        Me.LabelParentela.Size = New System.Drawing.Size(52, 13)
        Me.LabelParentela.TabIndex = 5
        Me.LabelParentela.Text = "Parentela"
        '
        'ComboBoxParentela
        '
        Me.ComboBoxParentela.FormattingEnabled = True
        Me.ComboBoxParentela.Location = New System.Drawing.Point(90, 38)
        Me.ComboBoxParentela.Name = "ComboBoxParentela"
        Me.ComboBoxParentela.Size = New System.Drawing.Size(195, 21)
        Me.ComboBoxParentela.TabIndex = 4
        '
        'LabelPatologie
        '
        Me.LabelPatologie.AutoSize = True
        Me.LabelPatologie.Location = New System.Drawing.Point(32, 68)
        Me.LabelPatologie.Name = "LabelPatologie"
        Me.LabelPatologie.Size = New System.Drawing.Size(51, 13)
        Me.LabelPatologie.TabIndex = 2
        Me.LabelPatologie.Text = "Patologie"
        '
        'ButtonSalva
        '
        Me.ButtonSalva.Location = New System.Drawing.Point(210, 91)
        Me.ButtonSalva.Name = "ButtonSalva"
        Me.ButtonSalva.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalva.TabIndex = 6
        Me.ButtonSalva.Text = "Salva"
        Me.ButtonSalva.UseVisualStyleBackColor = True
        '
        'TextPatologie
        '
        Me.TextPatologie.Location = New System.Drawing.Point(90, 65)
        Me.TextPatologie.Name = "TextPatologie"
        Me.TextPatologie.Size = New System.Drawing.Size(195, 20)
        Me.TextPatologie.TabIndex = 5
        '
        'FormAnamnesiFamiliare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 286)
        Me.Controls.Add(Me.GroupBoxAnamnesi)
        Me.Controls.Add(Me.GroupBoxRicercaPaziente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormAnamnesiFamiliare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anamnesi familiare"
        Me.GroupBoxRicercaPaziente.ResumeLayout(False)
        Me.GroupBoxRicercaPaziente.PerformLayout()
        Me.GroupBoxAnamnesi.ResumeLayout(False)
        Me.GroupBoxAnamnesi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxRicercaPaziente As GroupBox
    Friend WithEvents LabelIDAnagrafica As Label
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents LabelCognome As Label
    Friend WithEvents ButtonCercaPaziente As Button
    Friend WithEvents TextBoxCodiceID As TextBox
    Friend WithEvents TextBoxCognome As TextBox
    Friend WithEvents GroupBoxAnamnesi As GroupBox
    Friend WithEvents LabelPatologie As Label
    Friend WithEvents ButtonSalva As Button
    Friend WithEvents TextPatologie As TextBox
    Friend WithEvents LabelParentela As Label
    Friend WithEvents ComboBoxParentela As ComboBox
End Class
