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
        Me.LabelProfessione = New System.Windows.Forms.Label()
        Me.LabelSportPraticati = New System.Windows.Forms.Label()
        Me.LabelRelazione = New System.Windows.Forms.Label()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.LabelDataNascita = New System.Windows.Forms.Label()
        Me.LabelCodiceID = New System.Windows.Forms.Label()
        Me.TableLayoutPanelUCAnagrafica = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelAnagrafica = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimePickerDataNascita = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.TextBoxCognome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxNome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCodiceGenerato = New System.Windows.Forms.Label()
        Me.TableLayoutPanelAnmSoc = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxRelazione = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.TextBoxSport = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxProfessione = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TableLayoutPanelUCAnagrafica.SuspendLayout()
        Me.TableLayoutPanelAnagrafica.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.TextBoxCognome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxNome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanelAnmSoc.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ComboBoxRelazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxSport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxProfessione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProfessione
        '
        Me.LabelProfessione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelProfessione.AutoSize = True
        Me.LabelProfessione.Location = New System.Drawing.Point(3, 12)
        Me.LabelProfessione.Name = "LabelProfessione"
        Me.LabelProfessione.Size = New System.Drawing.Size(62, 13)
        Me.LabelProfessione.TabIndex = 2
        Me.LabelProfessione.Text = "Professione"
        '
        'LabelSportPraticati
        '
        Me.LabelSportPraticati.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelSportPraticati.AutoSize = True
        Me.LabelSportPraticati.Location = New System.Drawing.Point(3, 49)
        Me.LabelSportPraticati.Name = "LabelSportPraticati"
        Me.LabelSportPraticati.Size = New System.Drawing.Size(70, 13)
        Me.LabelSportPraticati.TabIndex = 2
        Me.LabelSportPraticati.Text = "SportPraticati"
        '
        'LabelRelazione
        '
        Me.LabelRelazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelRelazione.AutoSize = True
        Me.LabelRelazione.Location = New System.Drawing.Point(3, 88)
        Me.LabelRelazione.Name = "LabelRelazione"
        Me.LabelRelazione.Size = New System.Drawing.Size(54, 13)
        Me.LabelRelazione.TabIndex = 2
        Me.LabelRelazione.Text = "Relazione"
        '
        'LabelNome
        '
        Me.LabelNome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(3, 12)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(35, 13)
        Me.LabelNome.TabIndex = 2
        Me.LabelNome.Text = "Nome"
        '
        'LabelCognome
        '
        Me.LabelCognome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCognome.AutoSize = True
        Me.LabelCognome.Location = New System.Drawing.Point(3, 50)
        Me.LabelCognome.Name = "LabelCognome"
        Me.LabelCognome.Size = New System.Drawing.Size(52, 13)
        Me.LabelCognome.TabIndex = 2
        Me.LabelCognome.Text = "Cognome"
        '
        'LabelDataNascita
        '
        Me.LabelDataNascita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDataNascita.AutoSize = True
        Me.LabelDataNascita.Location = New System.Drawing.Point(3, 88)
        Me.LabelDataNascita.Name = "LabelDataNascita"
        Me.LabelDataNascita.Size = New System.Drawing.Size(78, 13)
        Me.LabelDataNascita.TabIndex = 2
        Me.LabelDataNascita.Text = "Data di nascita"
        '
        'LabelCodiceID
        '
        Me.LabelCodiceID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCodiceID.AutoSize = True
        Me.LabelCodiceID.Location = New System.Drawing.Point(118, 15)
        Me.LabelCodiceID.Name = "LabelCodiceID"
        Me.LabelCodiceID.Size = New System.Drawing.Size(103, 13)
        Me.LabelCodiceID.TabIndex = 9
        Me.LabelCodiceID.Tag = "Code"
        Me.LabelCodiceID.Text = "Codice Identificativo"
        '
        'TableLayoutPanelUCAnagrafica
        '
        Me.TableLayoutPanelUCAnagrafica.ColumnCount = 1
        Me.TableLayoutPanelUCAnagrafica.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.TableLayoutPanelAnagrafica, 0, 1)
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.ButtonInserisci, 0, 5)
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanelUCAnagrafica.Controls.Add(Me.TableLayoutPanelAnmSoc, 0, 3)
        Me.TableLayoutPanelUCAnagrafica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelUCAnagrafica.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelUCAnagrafica.Name = "TableLayoutPanelUCAnagrafica"
        Me.TableLayoutPanelUCAnagrafica.RowCount = 6
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelUCAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelUCAnagrafica.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelUCAnagrafica.TabIndex = 13
        '
        'TableLayoutPanelAnagrafica
        '
        Me.TableLayoutPanelAnagrafica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelAnagrafica.ColumnCount = 1
        Me.TableLayoutPanelAnagrafica.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnagrafica.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanelAnagrafica.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanelAnagrafica.Location = New System.Drawing.Point(203, 46)
        Me.TableLayoutPanelAnagrafica.Name = "TableLayoutPanelAnagrafica"
        Me.TableLayoutPanelAnagrafica.RowCount = 2
        Me.TableLayoutPanelAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelAnagrafica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnagrafica.Size = New System.Drawing.Size(360, 150)
        Me.TableLayoutPanelAnagrafica.TabIndex = 20
        Me.TableLayoutPanelAnagrafica.Tag = "PrimaryPanel"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Tag = "PrimaryTitle"
        Me.Label1.Text = "Anagrafica"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68354!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31645!))
        Me.TableLayoutPanel3.Controls.Add(Me.DateTimePickerDataNascita, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxCognome, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelNome, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelCognome, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelDataNascita, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxNome, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(354, 114)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'DateTimePickerDataNascita
        '
        Me.DateTimePickerDataNascita.AllowNull = True
        Me.DateTimePickerDataNascita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataNascita.DateTimeIcon = Nothing
        Me.DateTimePickerDataNascita.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataNascita.Location = New System.Drawing.Point(90, 84)
        Me.DateTimePickerDataNascita.Name = "DateTimePickerDataNascita"
        Me.DateTimePickerDataNascita.Size = New System.Drawing.Size(181, 21)
        Me.DateTimePickerDataNascita.TabIndex = 21
        Me.DateTimePickerDataNascita.ToolTipText = ""
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxCognome.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxCognome.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxCognome.Location = New System.Drawing.Point(90, 47)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxCognome.TabIndex = 21
        Me.TextBoxCognome.Tag = "Find"
        Me.TextBoxCognome.Text = "Cognome"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNome.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxNome.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNome.Location = New System.Drawing.Point(90, 9)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxNome.TabIndex = 21
        Me.TextBoxNome.Tag = "Find"
        Me.TextBoxNome.Text = "Nome"
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(665, 481)
        Me.ButtonInserisci.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 14
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.1453!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.8547!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCodiceGenerato, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCodiceID, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 429)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(234, 44)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'LabelCodiceGenerato
        '
        Me.LabelCodiceGenerato.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCodiceGenerato.AutoSize = True
        Me.LabelCodiceGenerato.Location = New System.Drawing.Point(3, 15)
        Me.LabelCodiceGenerato.Name = "LabelCodiceGenerato"
        Me.LabelCodiceGenerato.Size = New System.Drawing.Size(105, 13)
        Me.LabelCodiceGenerato.TabIndex = 10
        Me.LabelCodiceGenerato.Tag = "Code"
        Me.LabelCodiceGenerato.Text = "Codice ID generato: "
        '
        'TableLayoutPanelAnmSoc
        '
        Me.TableLayoutPanelAnmSoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelAnmSoc.ColumnCount = 1
        Me.TableLayoutPanelAnmSoc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnmSoc.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanelAnmSoc.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanelAnmSoc.Location = New System.Drawing.Point(203, 259)
        Me.TableLayoutPanelAnmSoc.Name = "TableLayoutPanelAnmSoc"
        Me.TableLayoutPanelAnmSoc.RowCount = 2
        Me.TableLayoutPanelAnmSoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelAnmSoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnmSoc.Size = New System.Drawing.Size(360, 150)
        Me.TableLayoutPanelAnmSoc.TabIndex = 19
        Me.TableLayoutPanelAnmSoc.Tag = "PrimaryPanel"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Tag = "PrimaryTitle"
        Me.Label2.Text = "Anamnesi sociale"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68354!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31646!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxRelazione, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxSport, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxProfessione, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelProfessione, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelSportPraticati, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelRelazione, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(354, 114)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'ComboBoxRelazione
        '
        Me.ComboBoxRelazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxRelazione.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxRelazione.AutoCompleteSuggestDelay = 1
        Me.ComboBoxRelazione.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxRelazione.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxRelazione.Location = New System.Drawing.Point(90, 84)
        Me.ComboBoxRelazione.Name = "ComboBoxRelazione"
        Me.ComboBoxRelazione.Size = New System.Drawing.Size(181, 21)
        Me.ComboBoxRelazione.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxRelazione.TabIndex = 21
        Me.ComboBoxRelazione.TabStop = False
        Me.ComboBoxRelazione.Tag = "Find"
        '
        'TextBoxSport
        '
        Me.TextBoxSport.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxSport.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxSport.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxSport.Location = New System.Drawing.Point(90, 46)
        Me.TextBoxSport.Name = "TextBoxSport"
        Me.TextBoxSport.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxSport.TabIndex = 22
        Me.TextBoxSport.Tag = "Find"
        Me.TextBoxSport.Text = "Sport"
        '
        'TextBoxProfessione
        '
        Me.TextBoxProfessione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxProfessione.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxProfessione.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxProfessione.Location = New System.Drawing.Point(90, 8)
        Me.TextBoxProfessione.Name = "TextBoxProfessione"
        Me.TextBoxProfessione.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxProfessione.TabIndex = 23
        Me.TextBoxProfessione.Tag = "Find"
        Me.TextBoxProfessione.Text = "Professione"
        '
        'UC_Anagrafica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelUCAnagrafica)
        Me.Name = "UC_Anagrafica"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelUCAnagrafica.ResumeLayout(False)
        Me.TableLayoutPanelAnagrafica.ResumeLayout(False)
        Me.TableLayoutPanelAnagrafica.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.TextBoxCognome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxNome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanelAnmSoc.ResumeLayout(False)
        Me.TableLayoutPanelAnmSoc.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ComboBoxRelazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxSport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxProfessione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelProfessione As Label
    Friend WithEvents LabelSportPraticati As Label
    Friend WithEvents LabelRelazione As Label
    Friend WithEvents LabelNome As Label
    Friend WithEvents LabelCognome As Label
    Friend WithEvents LabelDataNascita As Label
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents TableLayoutPanelUCAnagrafica As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelCodiceGenerato As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelAnmSoc As TableLayoutPanel
    Friend WithEvents TableLayoutPanelAnagrafica As TableLayoutPanel
    Friend WithEvents TextBoxNome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxCognome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxSport As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxProfessione As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents DateTimePickerDataNascita As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents ComboBoxRelazione As Syncfusion.WinForms.ListView.SfComboBox
End Class
