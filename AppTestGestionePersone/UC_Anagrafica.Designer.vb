<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Anagrafica
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.ComboBoxRelazione = New System.Windows.Forms.ComboBox()
        Me.TextBoxProfessione = New System.Windows.Forms.TextBox()
        Me.LabelProfessione = New System.Windows.Forms.Label()
        Me.LabelSportPraticati = New System.Windows.Forms.Label()
        Me.LabelRelazione = New System.Windows.Forms.Label()
        Me.GroupBoxAnamnesiSociale = New System.Windows.Forms.GroupBox()
        Me.TextBoxSport = New System.Windows.Forms.TextBox()
        Me.DateTimePickerDataNascita = New System.Windows.Forms.DateTimePicker()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.LabelDataNascita = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.TextBoxCognome = New System.Windows.Forms.TextBox()
        Me.GroupBoxAnagrafica = New System.Windows.Forms.GroupBox()
        Me.LabelCodiceID = New System.Windows.Forms.Label()
        Me.TableLayoutPanelUCAnagrafica = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCodiceGenerato = New System.Windows.Forms.Label()
        Me.GroupBoxAnamnesiSociale.SuspendLayout()
        Me.GroupBoxAnagrafica.SuspendLayout()
        Me.TableLayoutPanelUCAnagrafica.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBoxAnamnesiSociale
        '
        Me.GroupBoxAnamnesiSociale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.ComboBoxRelazione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.TextBoxProfessione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.LabelProfessione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.LabelSportPraticati)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.LabelRelazione)
        Me.GroupBoxAnamnesiSociale.Controls.Add(Me.TextBoxSport)
        Me.GroupBoxAnamnesiSociale.Location = New System.Drawing.Point(224, 222)
        Me.GroupBoxAnamnesiSociale.Name = "GroupBoxAnamnesiSociale"
        Me.GroupBoxAnamnesiSociale.Size = New System.Drawing.Size(318, 107)
        Me.GroupBoxAnamnesiSociale.TabIndex = 12
        Me.GroupBoxAnamnesiSociale.TabStop = False
        Me.GroupBoxAnamnesiSociale.Text = "AnamnesiSociale"
        '
        'TextBoxSport
        '
        Me.TextBoxSport.Location = New System.Drawing.Point(94, 45)
        Me.TextBoxSport.Name = "TextBoxSport"
        Me.TextBoxSport.Size = New System.Drawing.Size(213, 20)
        Me.TextBoxSport.TabIndex = 1
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
        'GroupBoxAnagrafica
        '
        Me.GroupBoxAnagrafica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxAnagrafica.Controls.Add(Me.DateTimePickerDataNascita)
        Me.GroupBoxAnagrafica.Controls.Add(Me.TextBoxNome)
        Me.GroupBoxAnagrafica.Controls.Add(Me.LabelNome)
        Me.GroupBoxAnagrafica.Controls.Add(Me.LabelCognome)
        Me.GroupBoxAnagrafica.Controls.Add(Me.LabelDataNascita)
        Me.GroupBoxAnagrafica.Controls.Add(Me.TextBoxCognome)
        Me.GroupBoxAnagrafica.Location = New System.Drawing.Point(220, 37)
        Me.GroupBoxAnagrafica.Name = "GroupBoxAnagrafica"
        Me.GroupBoxAnagrafica.Size = New System.Drawing.Size(326, 110)
        Me.GroupBoxAnagrafica.TabIndex = 11
        Me.GroupBoxAnagrafica.TabStop = False
        Me.GroupBoxAnagrafica.Text = "Anagrafica"
        '
        'LabelCodiceID
        '
        Me.LabelCodiceID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCodiceID.AutoSize = True
        Me.LabelCodiceID.Location = New System.Drawing.Point(118, 25)
        Me.LabelCodiceID.Name = "LabelCodiceID"
        Me.LabelCodiceID.Size = New System.Drawing.Size(103, 13)
        Me.LabelCodiceID.TabIndex = 9
        Me.LabelCodiceID.Text = "Codice Identificativo"
        '
        'TableLayoutPanelUCAnagrafica
        '
        Me.TableLayoutPanelUCAnagrafica.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanelUCAnagrafica.ColumnCount = 1
        Me.TableLayoutPanelUCAnagrafica.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUCAnagrafica.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.ButtonInserisci, 0, 3)
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.GroupBoxAnagrafica, 0, 0)
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.GroupBoxAnamnesiSociale, 0, 1)
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanelUCAnagrafica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelUCAnagrafica.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelUCAnagrafica.Name = "TableLayoutPanelUCAnagrafica"
        Me.TableLayoutPanelUCAnagrafica.RowCount = 4
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelUCAnagrafica.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelUCAnagrafica.TabIndex = 13
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 463)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 14
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.1453!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.8547!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCodiceGenerato, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCodiceID, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 371)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(234, 63)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'LabelCodiceGenerato
        '
        Me.LabelCodiceGenerato.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCodiceGenerato.AutoSize = True
        Me.LabelCodiceGenerato.Location = New System.Drawing.Point(3, 25)
        Me.LabelCodiceGenerato.Name = "LabelCodiceGenerato"
        Me.LabelCodiceGenerato.Size = New System.Drawing.Size(105, 13)
        Me.LabelCodiceGenerato.TabIndex = 10
        Me.LabelCodiceGenerato.Text = "Codice ID generato: "
        '
        'UC_Anagrafica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelUCAnagrafica)
        Me.Name = "UC_Anagrafica"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.GroupBoxAnamnesiSociale.ResumeLayout(False)
        Me.GroupBoxAnamnesiSociale.PerformLayout()
        Me.GroupBoxAnagrafica.ResumeLayout(False)
        Me.GroupBoxAnagrafica.PerformLayout()
        Me.TableLayoutPanelUCAnagrafica.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxRelazione As ComboBox
    Friend WithEvents TextBoxProfessione As TextBox
    Friend WithEvents LabelProfessione As Label
    Friend WithEvents LabelSportPraticati As Label
    Friend WithEvents LabelRelazione As Label
    Friend WithEvents GroupBoxAnamnesiSociale As GroupBox
    Friend WithEvents TextBoxSport As TextBox
    Friend WithEvents DateTimePickerDataNascita As DateTimePicker
    Friend WithEvents LabelNome As Label
    Friend WithEvents LabelCognome As Label
    Friend WithEvents LabelDataNascita As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents TextBoxCognome As TextBox
    Friend WithEvents GroupBoxAnagrafica As GroupBox
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents TableLayoutPanelUCAnagrafica As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelCodiceGenerato As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
