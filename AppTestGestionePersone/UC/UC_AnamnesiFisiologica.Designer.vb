<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AnamnesiFisiologica
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
        Me.TableLayoutPanelAnamnesiFisiologica = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelAnFisio = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelAnamnesiFisio = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxBMI = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxPeso = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxAltezza = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelAltezza = New System.Windows.Forms.Label()
        Me.LabelPeso = New System.Windows.Forms.Label()
        Me.LabelBMI = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxIdratazione = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.LabelIdratazione = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxIntolleranze = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelIntollerazne = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxAllergie = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelAllergie = New System.Windows.Forms.Label()
        Me.TableLayoutPanelFumo = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxTipo = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.ComboBoxQuantita = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.LabelTipoSigarette = New System.Windows.Forms.Label()
        Me.LabelQuantita = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelAnamnesiFisiologica.SuspendLayout()
        Me.TableLayoutPanelAnFisio.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TextBoxBMI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxAltezza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ComboBoxIdratazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.TextBoxIntolleranze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.TextBoxAllergie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelFumo.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.ComboBoxTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxQuantita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelAnamnesiFisiologica
        '
        Me.TableLayoutPanelAnamnesiFisiologica.ColumnCount = 1
        Me.TableLayoutPanelAnamnesiFisiologica.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.TableLayoutPanelAnFisio, 0, 0)
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.TableLayoutPanelFumo, 0, 1)
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.ButtonInserisci, 0, 2)
        Me.TableLayoutPanelAnamnesiFisiologica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAnamnesiFisiologica.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelAnamnesiFisiologica.Name = "TableLayoutPanelAnamnesiFisiologica"
        Me.TableLayoutPanelAnamnesiFisiologica.RowCount = 3
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelAnamnesiFisiologica.TabIndex = 12
        '
        'TableLayoutPanelAnFisio
        '
        Me.TableLayoutPanelAnFisio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelAnFisio.ColumnCount = 1
        Me.TableLayoutPanelAnFisio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnFisio.Controls.Add(Me.LabelAnamnesiFisio, 0, 0)
        Me.TableLayoutPanelAnFisio.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelAnFisio.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanelAnFisio.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanelAnFisio.Controls.Add(Me.TableLayoutPanel5, 0, 4)
        Me.TableLayoutPanelAnFisio.Location = New System.Drawing.Point(133, 12)
        Me.TableLayoutPanelAnFisio.Name = "TableLayoutPanelAnFisio"
        Me.TableLayoutPanelAnFisio.RowCount = 5
        Me.TableLayoutPanelAnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelAnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelAnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelAnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelAnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelAnFisio.Size = New System.Drawing.Size(500, 285)
        Me.TableLayoutPanelAnFisio.TabIndex = 22
        Me.TableLayoutPanelAnFisio.Tag = "PrimaryPanel"
        '
        'LabelAnamnesiFisio
        '
        Me.LabelAnamnesiFisio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAnamnesiFisio.AutoSize = True
        Me.LabelAnamnesiFisio.Location = New System.Drawing.Point(3, 8)
        Me.LabelAnamnesiFisio.Name = "LabelAnamnesiFisio"
        Me.LabelAnamnesiFisio.Size = New System.Drawing.Size(88, 13)
        Me.LabelAnamnesiFisio.TabIndex = 16
        Me.LabelAnamnesiFisio.Tag = "PrimaryTitle"
        Me.LabelAnamnesiFisio.Text = "Dettagli fisiologici"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxBMI, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxPeso, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxAltezza, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelAltezza, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPeso, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelBMI, 4, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(40, 41)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(420, 40)
        Me.TableLayoutPanel2.TabIndex = 0
        Me.TableLayoutPanel2.Tag = "SecondaryPanel"
        '
        'TextBoxBMI
        '
        Me.TextBoxBMI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxBMI.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxBMI.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxBMI.Enabled = False
        Me.TextBoxBMI.Location = New System.Drawing.Point(306, 10)
        Me.TextBoxBMI.Name = "TextBoxBMI"
        Me.TextBoxBMI.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxBMI.TabIndex = 24
        Me.TextBoxBMI.Tag = "Find"
        Me.TextBoxBMI.Text = "0"
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxPeso.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxPeso.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxPeso.Location = New System.Drawing.Point(194, 10)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxPeso.TabIndex = 23
        Me.TextBoxPeso.Tag = "Find"
        Me.TextBoxPeso.Text = "0"
        '
        'TextBoxAltezza
        '
        Me.TextBoxAltezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxAltezza.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxAltezza.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxAltezza.Location = New System.Drawing.Point(61, 10)
        Me.TextBoxAltezza.Name = "TextBoxAltezza"
        Me.TextBoxAltezza.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxAltezza.TabIndex = 22
        Me.TextBoxAltezza.Tag = "Find"
        Me.TextBoxAltezza.Text = "0"
        '
        'LabelAltezza
        '
        Me.LabelAltezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAltezza.AutoSize = True
        Me.LabelAltezza.Location = New System.Drawing.Point(3, 7)
        Me.LabelAltezza.Name = "LabelAltezza"
        Me.LabelAltezza.Size = New System.Drawing.Size(44, 26)
        Me.LabelAltezza.TabIndex = 0
        Me.LabelAltezza.Text = "Altezza (cm)"
        '
        'LabelPeso
        '
        Me.LabelPeso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPeso.AutoSize = True
        Me.LabelPeso.Location = New System.Drawing.Point(136, 7)
        Me.LabelPeso.Name = "LabelPeso"
        Me.LabelPeso.Size = New System.Drawing.Size(34, 26)
        Me.LabelPeso.TabIndex = 4
        Me.LabelPeso.Text = "Peso (km)"
        '
        'LabelBMI
        '
        Me.LabelBMI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelBMI.AutoSize = True
        Me.LabelBMI.Location = New System.Drawing.Point(269, 13)
        Me.LabelBMI.Name = "LabelBMI"
        Me.LabelBMI.Size = New System.Drawing.Size(26, 13)
        Me.LabelBMI.TabIndex = 2
        Me.LabelBMI.Text = "BMI"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxIdratazione, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelIdratazione, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(40, 104)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(420, 40)
        Me.TableLayoutPanel3.TabIndex = 1
        Me.TableLayoutPanel3.Tag = "SecondaryPanel"
        '
        'ComboBoxIdratazione
        '
        Me.ComboBoxIdratazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxIdratazione.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxIdratazione.AutoCompleteSuggestDelay = 1
        Me.ComboBoxIdratazione.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxIdratazione.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxIdratazione.Location = New System.Drawing.Point(83, 9)
        Me.ComboBoxIdratazione.Name = "ComboBoxIdratazione"
        Me.ComboBoxIdratazione.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxIdratazione.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxIdratazione.TabIndex = 29
        Me.ComboBoxIdratazione.TabStop = False
        Me.ComboBoxIdratazione.Tag = "Find"
        '
        'LabelIdratazione
        '
        Me.LabelIdratazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIdratazione.AutoSize = True
        Me.LabelIdratazione.Location = New System.Drawing.Point(3, 13)
        Me.LabelIdratazione.Name = "LabelIdratazione"
        Me.LabelIdratazione.Size = New System.Drawing.Size(59, 13)
        Me.LabelIdratazione.TabIndex = 6
        Me.LabelIdratazione.Text = "Idratazione"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxIntolleranze, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelIntollerazne, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(40, 167)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(420, 40)
        Me.TableLayoutPanel4.TabIndex = 2
        Me.TableLayoutPanel4.Tag = "SecondaryPanel"
        '
        'TextBoxIntolleranze
        '
        Me.TextBoxIntolleranze.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxIntolleranze.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxIntolleranze.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxIntolleranze.Location = New System.Drawing.Point(83, 10)
        Me.TextBoxIntolleranze.Name = "TextBoxIntolleranze"
        Me.TextBoxIntolleranze.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxIntolleranze.TabIndex = 22
        Me.TextBoxIntolleranze.Tag = "Find"
        Me.TextBoxIntolleranze.Text = "Intolleranze"
        '
        'LabelIntollerazne
        '
        Me.LabelIntollerazne.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIntollerazne.AutoSize = True
        Me.LabelIntollerazne.Location = New System.Drawing.Point(3, 13)
        Me.LabelIntollerazne.Name = "LabelIntollerazne"
        Me.LabelIntollerazne.Size = New System.Drawing.Size(61, 13)
        Me.LabelIntollerazne.TabIndex = 8
        Me.LabelIntollerazne.Text = "Intolleranze"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxAllergie, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelAllergie, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(40, 232)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(420, 40)
        Me.TableLayoutPanel5.TabIndex = 3
        Me.TableLayoutPanel5.Tag = "SecondaryPanel"
        '
        'TextBoxAllergie
        '
        Me.TextBoxAllergie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxAllergie.BeforeTouchSize = New System.Drawing.Size(241, 20)
        Me.TextBoxAllergie.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxAllergie.Location = New System.Drawing.Point(83, 10)
        Me.TextBoxAllergie.Name = "TextBoxAllergie"
        Me.TextBoxAllergie.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxAllergie.TabIndex = 23
        Me.TextBoxAllergie.Tag = "Find"
        Me.TextBoxAllergie.Text = "Allergie"
        '
        'LabelAllergie
        '
        Me.LabelAllergie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAllergie.AutoSize = True
        Me.LabelAllergie.Location = New System.Drawing.Point(3, 13)
        Me.LabelAllergie.Name = "LabelAllergie"
        Me.LabelAllergie.Size = New System.Drawing.Size(41, 13)
        Me.LabelAllergie.TabIndex = 10
        Me.LabelAllergie.Text = "Allergie"
        '
        'TableLayoutPanelFumo
        '
        Me.TableLayoutPanelFumo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelFumo.ColumnCount = 1
        Me.TableLayoutPanelFumo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelFumo.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanelFumo.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanelFumo.Location = New System.Drawing.Point(133, 322)
        Me.TableLayoutPanelFumo.Name = "TableLayoutPanelFumo"
        Me.TableLayoutPanelFumo.RowCount = 2
        Me.TableLayoutPanelFumo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelFumo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelFumo.Size = New System.Drawing.Size(500, 140)
        Me.TableLayoutPanelFumo.TabIndex = 21
        Me.TableLayoutPanelFumo.Tag = "PrimaryPanel"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxTipo, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxQuantita, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelTipoSigarette, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelQuantita, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(40, 45)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(420, 80)
        Me.TableLayoutPanel6.TabIndex = 0
        Me.TableLayoutPanel6.Tag = "SecondaryPanel"
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxTipo.AutoCompleteSuggestDelay = 1
        Me.ComboBoxTipo.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxTipo.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxTipo.Location = New System.Drawing.Point(83, 49)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxTipo.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ComboBoxTipo.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxTipo.TabIndex = 29
        Me.ComboBoxTipo.TabStop = False
        Me.ComboBoxTipo.Tag = "Find"
        '
        'ComboBoxQuantita
        '
        Me.ComboBoxQuantita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxQuantita.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxQuantita.AutoCompleteSuggestDelay = 1
        Me.ComboBoxQuantita.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxQuantita.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxQuantita.Location = New System.Drawing.Point(83, 9)
        Me.ComboBoxQuantita.Name = "ComboBoxQuantita"
        Me.ComboBoxQuantita.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxQuantita.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxQuantita.TabIndex = 28
        Me.ComboBoxQuantita.TabStop = False
        Me.ComboBoxQuantita.Tag = "Find"
        '
        'LabelTipoSigarette
        '
        Me.LabelTipoSigarette.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTipoSigarette.AutoSize = True
        Me.LabelTipoSigarette.Location = New System.Drawing.Point(3, 53)
        Me.LabelTipoSigarette.Name = "LabelTipoSigarette"
        Me.LabelTipoSigarette.Size = New System.Drawing.Size(71, 13)
        Me.LabelTipoSigarette.TabIndex = 26
        Me.LabelTipoSigarette.Text = "Tipo sigarette"
        '
        'LabelQuantita
        '
        Me.LabelQuantita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelQuantita.AutoSize = True
        Me.LabelQuantita.Location = New System.Drawing.Point(3, 13)
        Me.LabelQuantita.Name = "LabelQuantita"
        Me.LabelQuantita.Size = New System.Drawing.Size(47, 13)
        Me.LabelQuantita.TabIndex = 24
        Me.LabelQuantita.Text = "Quantità"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Tag = "PrimaryTitle"
        Me.Label1.Text = "Fumo"
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 3
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_AnamnesiFisiologica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelAnamnesiFisiologica)
        Me.Name = "UC_AnamnesiFisiologica"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelAnamnesiFisiologica.ResumeLayout(False)
        Me.TableLayoutPanelAnFisio.ResumeLayout(False)
        Me.TableLayoutPanelAnFisio.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TextBoxBMI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxAltezza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ComboBoxIdratazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.TextBoxIntolleranze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.TextBoxAllergie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelFumo.ResumeLayout(False)
        Me.TableLayoutPanelFumo.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.ComboBoxTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxQuantita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelAnamnesiFisiologica As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents LabelTipoSigarette As Label
    Friend WithEvents LabelQuantita As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents LabelAllergie As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents LabelIntollerazne As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LabelIdratazione As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelAltezza As Label
    Friend WithEvents LabelPeso As Label
    Friend WithEvents LabelBMI As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelFumo As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanelAnFisio As TableLayoutPanel
    Friend WithEvents LabelAnamnesiFisio As Label
    Friend WithEvents TextBoxBMI As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxPeso As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxAltezza As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxIntolleranze As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxAllergie As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents ComboBoxQuantita As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents ComboBoxTipo As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents ComboBoxIdratazione As Syncfusion.WinForms.ListView.SfComboBox
End Class
