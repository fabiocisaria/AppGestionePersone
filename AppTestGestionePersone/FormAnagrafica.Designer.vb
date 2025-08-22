<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnagrafica
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
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.TextBoxCognome = New System.Windows.Forms.TextBox()
        Me.ButtonInserisci = New System.Windows.Forms.Button()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.LabelDataNascita = New System.Windows.Forms.Label()
        Me.LabelCodiceID = New System.Windows.Forms.Label()
        Me.GroupBoxAnagrafica = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerDataNascita = New System.Windows.Forms.DateTimePicker()
        Me.GroupBoxAnamnesiSociale = New System.Windows.Forms.GroupBox()
        Me.ComboBoxRelazione = New System.Windows.Forms.ComboBox()
        Me.TextBoxProfessione = New System.Windows.Forms.TextBox()
        Me.LabelProfessione = New System.Windows.Forms.Label()
        Me.LabelSportPraticati = New System.Windows.Forms.Label()
        Me.LabelRelazione = New System.Windows.Forms.Label()
        Me.TextBoxSport = New System.Windows.Forms.TextBox()
        Me.ButtonAnamnesiFisiologica = New System.Windows.Forms.Button()
        Me.GroupBoxAnagrafica.SuspendLayout()
        Me.GroupBoxAnamnesiSociale.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(63, 19)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(244, 20)
        Me.TextBoxNome.TabIndex = 0
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Location = New System.Drawing.Point(84, 45)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(223, 20)
        Me.TextBoxCognome.TabIndex = 1
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Location = New System.Drawing.Point(265, 241)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInserisci.TabIndex = 5
        Me.ButtonInserisci.Text = "Inserisci"
        Me.ButtonInserisci.UseVisualStyleBackColor = True
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(22, 22)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(35, 13)
        Me.LabelNome.TabIndex = 2
        Me.LabelNome.Text = "Nome"
        '
        'LabelCognome
        '
        Me.LabelCognome.AutoSize = True
        Me.LabelCognome.Location = New System.Drawing.Point(22, 48)
        Me.LabelCognome.Name = "LabelCognome"
        Me.LabelCognome.Size = New System.Drawing.Size(52, 13)
        Me.LabelCognome.TabIndex = 2
        Me.LabelCognome.Text = "Cognome"
        '
        'LabelDataNascita
        '
        Me.LabelDataNascita.AutoSize = True
        Me.LabelDataNascita.Location = New System.Drawing.Point(22, 76)
        Me.LabelDataNascita.Name = "LabelDataNascita"
        Me.LabelDataNascita.Size = New System.Drawing.Size(78, 13)
        Me.LabelDataNascita.TabIndex = 2
        Me.LabelDataNascita.Text = "Data di nascita"
        '
        'LabelCodiceID
        '
        Me.LabelCodiceID.AutoSize = True
        Me.LabelCodiceID.Location = New System.Drawing.Point(35, 251)
        Me.LabelCodiceID.Name = "LabelCodiceID"
        Me.LabelCodiceID.Size = New System.Drawing.Size(103, 13)
        Me.LabelCodiceID.TabIndex = 2
        Me.LabelCodiceID.Text = "Codice Identificativo"
        '
        'GroupBoxAnagrafica
        '
        Me.GroupBoxAnagrafica.Controls.Add(Me.DateTimePickerDataNascita)
        Me.GroupBoxAnagrafica.Controls.Add(Me.TextBoxNome)
        Me.GroupBoxAnagrafica.Controls.Add(Me.LabelNome)
        Me.GroupBoxAnagrafica.Controls.Add(Me.LabelCognome)
        Me.GroupBoxAnagrafica.Controls.Add(Me.LabelDataNascita)
        Me.GroupBoxAnagrafica.Controls.Add(Me.TextBoxCognome)
        Me.GroupBoxAnagrafica.Location = New System.Drawing.Point(13, 12)
        Me.GroupBoxAnagrafica.Name = "GroupBoxAnagrafica"
        Me.GroupBoxAnagrafica.Size = New System.Drawing.Size(327, 108)
        Me.GroupBoxAnagrafica.TabIndex = 6
        Me.GroupBoxAnagrafica.TabStop = False
        Me.GroupBoxAnagrafica.Text = "Anagrafica"
        '
        'DateTimePickerDataNascita
        '
        Me.DateTimePickerDataNascita.Location = New System.Drawing.Point(107, 72)
        Me.DateTimePickerDataNascita.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerDataNascita.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerDataNascita.Name = "DateTimePickerDataNascita"
        Me.DateTimePickerDataNascita.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDataNascita.TabIndex = 3
        '
        'GroupBoxAnamnesiSociale
        '
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.ComboBoxRelazione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.TextBoxProfessione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.LabelProfessione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.LabelSportPraticati)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.LabelRelazione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.TextBoxSport)
        Me.GroupBoxAnamnesiSociale.Location = New System.Drawing.Point(13, 127)
        Me.GroupBoxAnamnesiSociale.Name = "GroupBoxAnamnesiSociale"
        Me.GroupBoxAnamnesiSociale.Size = New System.Drawing.Size(327, 108)
        Me.GroupBoxAnamnesiSociale.TabIndex = 7
        Me.GroupBoxAnamnesiSociale.TabStop = False
        Me.GroupBoxAnamnesiSociale.Text = "AnamnesiSociale"
        '
        'ComboBoxRelazione
        '
        Me.ComboBoxRelazione.FormattingEnabled = True
        Me.ComboBoxRelazione.Items.AddRange(New Object() {"Coniugata", "Relazione stabile", "Nessuna relazione", "NA"})
        Me.ComboBoxRelazione.Location = New System.Drawing.Point(94, 71)
        Me.ComboBoxRelazione.Name = "ComboBoxRelazione"
        Me.ComboBoxRelazione.Size = New System.Drawing.Size(213, 21)
        Me.ComboBoxRelazione.TabIndex = 3
        '
        'TextBoxProfessione
        '
        Me.TextBoxProfessione.Location = New System.Drawing.Point(94, 19)
        Me.TextBoxProfessione.Name = "TextBoxProfessione"
        Me.TextBoxProfessione.Size = New System.Drawing.Size(213, 20)
        Me.TextBoxProfessione.TabIndex = 0
        '
        'LabelProfessione
        '
        Me.LabelProfessione.AutoSize = True
        Me.LabelProfessione.Location = New System.Drawing.Point(22, 22)
        Me.LabelProfessione.Name = "LabelProfessione"
        Me.LabelProfessione.Size = New System.Drawing.Size(62, 13)
        Me.LabelProfessione.TabIndex = 2
        Me.LabelProfessione.Text = "Professione"
        '
        'LabelSportPraticati
        '
        Me.LabelSportPraticati.AutoSize = True
        Me.LabelSportPraticati.Location = New System.Drawing.Point(22, 48)
        Me.LabelSportPraticati.Name = "LabelSportPraticati"
        Me.LabelSportPraticati.Size = New System.Drawing.Size(70, 13)
        Me.LabelSportPraticati.TabIndex = 2
        Me.LabelSportPraticati.Text = "SportPraticati"
        '
        'LabelRelazione
        '
        Me.LabelRelazione.AutoSize = True
        Me.LabelRelazione.Location = New System.Drawing.Point(22, 76)
        Me.LabelRelazione.Name = "LabelRelazione"
        Me.LabelRelazione.Size = New System.Drawing.Size(54, 13)
        Me.LabelRelazione.TabIndex = 2
        Me.LabelRelazione.Text = "Relazione"
        '
        'TextBoxSport
        '
        Me.TextBoxSport.Location = New System.Drawing.Point(94, 45)
        Me.TextBoxSport.Name = "TextBoxSport"
        Me.TextBoxSport.Size = New System.Drawing.Size(213, 20)
        Me.TextBoxSport.TabIndex = 1
        '
        'ButtonAnamnesiFisiologica
        '
        Me.ButtonAnamnesiFisiologica.Location = New System.Drawing.Point(174, 241)
        Me.ButtonAnamnesiFisiologica.Name = "ButtonAnamnesiFisiologica"
        Me.ButtonAnamnesiFisiologica.Size = New System.Drawing.Size(85, 23)
        Me.ButtonAnamnesiFisiologica.TabIndex = 8
        Me.ButtonAnamnesiFisiologica.Text = "An. fisiologica"
        Me.ButtonAnamnesiFisiologica.UseVisualStyleBackColor = True
        '
        'FormAnagrafica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 283)
        Me.Controls.Add(Me.ButtonAnamnesiFisiologica)
        Me.Controls.Add(Me.GroupBoxAnamnesiSociale)
        Me.Controls.Add(Me.GroupBoxAnagrafica)
        Me.Controls.Add(Me.LabelCodiceID)
        Me.Controls.Add(Me.ButtonInserisci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAnagrafica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuova anagrafica"
        Me.GroupBoxAnagrafica.ResumeLayout(False)
        Me.GroupBoxAnagrafica.PerformLayout()
        Me.GroupBoxAnamnesiSociale.ResumeLayout(False)
        Me.GroupBoxAnamnesiSociale.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents TextBoxCognome As TextBox
    Friend WithEvents ButtonInserisci As Button
    Friend WithEvents LabelNome As Label
    Friend WithEvents LabelCognome As Label
    Friend WithEvents LabelDataNascita As Label
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents GroupBoxAnagrafica As GroupBox
    Friend WithEvents GroupBoxAnamnesiSociale As GroupBox
    Friend WithEvents TextBoxProfessione As TextBox
    Friend WithEvents LabelProfessione As Label
    Friend WithEvents LabelSportPraticati As Label
    Friend WithEvents LabelRelazione As Label
    Friend WithEvents TextBoxSport As TextBox
    Friend WithEvents ComboBoxRelazione As ComboBox
    Friend WithEvents ButtonAnamnesiFisiologica As Button
    Friend WithEvents DateTimePickerDataNascita As DateTimePicker
End Class
