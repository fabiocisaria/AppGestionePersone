<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVisitaUroGineco
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxSwabTest = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelSwab = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelClit = New System.Windows.Forms.Label()
        Me.LabelVest = New System.Windows.Forms.Label()
        Me.LabelSubr = New System.Windows.Forms.Label()
        Me.LabelForc = New System.Windows.Forms.Label()
        Me.LabelVestDx = New System.Windows.Forms.Label()
        Me.LabelVestSx = New System.Windows.Forms.Label()
        Me.NumericUpDownClit = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownVestDx = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownVestSx = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownSubr = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownForc = New System.Windows.Forms.NumericUpDown()
        Me.GroupBoxMiglioramento = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonMiglMo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMiglLieve = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMiglNotevole = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMiglAsintomatico = New System.Windows.Forms.RadioButton()
        Me.GroupBoxVg = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelVg = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelStato = New System.Windows.Forms.Label()
        Me.LabelLichen = New System.Windows.Forms.Label()
        Me.LabelCicatrice = New System.Windows.Forms.Label()
        Me.RadioButtonStReg = New System.Windows.Forms.RadioButton()
        Me.RadioButtonStDistr = New System.Windows.Forms.RadioButton()
        Me.RadioButtonStAtr = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLicSi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLicNo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCicSi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCicNo = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelAltriDettagli = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxIperContr = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCistProv = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonContrL = New System.Windows.Forms.RadioButton()
        Me.RadioButtonContrM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonContrS = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCitProSi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCitProNo = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxAderTp = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelAderTp = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonAderTpSi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAderTpNo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAderTpPar = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxSwabTest.SuspendLayout()
        Me.TableLayoutPanelSwab.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.NumericUpDownClit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVestDx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVestSx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSubr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownForc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMiglioramento.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBoxVg.SuspendLayout()
        Me.TableLayoutPanelVg.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanelAltriDettagli.SuspendLayout()
        Me.GroupBoxIperContr.SuspendLayout()
        Me.GroupBoxCistProv.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBoxAderTp.SuspendLayout()
        Me.TableLayoutPanelAderTp.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxVg, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelAltriDettagli, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxSwabTest, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxSwabTest
        '
        Me.GroupBoxSwabTest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxSwabTest.Controls.Add(Me.TableLayoutPanelSwab)
        Me.GroupBoxSwabTest.Location = New System.Drawing.Point(14, 20)
        Me.GroupBoxSwabTest.Name = "GroupBoxSwabTest"
        Me.GroupBoxSwabTest.Size = New System.Drawing.Size(372, 158)
        Me.GroupBoxSwabTest.TabIndex = 0
        Me.GroupBoxSwabTest.TabStop = False
        Me.GroupBoxSwabTest.Text = "Swab test"
        '
        'TableLayoutPanelSwab
        '
        Me.TableLayoutPanelSwab.ColumnCount = 2
        Me.TableLayoutPanelSwab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.36082!))
        Me.TableLayoutPanelSwab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.63918!))
        Me.TableLayoutPanelSwab.Controls.Add(Me.NumericUpDownForc, 1, 3)
        Me.TableLayoutPanelSwab.Controls.Add(Me.NumericUpDownSubr, 1, 2)
        Me.TableLayoutPanelSwab.Controls.Add(Me.LabelForc, 0, 3)
        Me.TableLayoutPanelSwab.Controls.Add(Me.NumericUpDownClit, 1, 0)
        Me.TableLayoutPanelSwab.Controls.Add(Me.LabelSubr, 0, 2)
        Me.TableLayoutPanelSwab.Controls.Add(Me.LabelVest, 0, 1)
        Me.TableLayoutPanelSwab.Controls.Add(Me.LabelClit, 0, 0)
        Me.TableLayoutPanelSwab.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanelSwab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSwab.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelSwab.Name = "TableLayoutPanelSwab"
        Me.TableLayoutPanelSwab.RowCount = 4
        Me.TableLayoutPanelSwab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelSwab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelSwab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelSwab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelSwab.Size = New System.Drawing.Size(366, 139)
        Me.TableLayoutPanelSwab.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.NumericUpDownVestSx, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumericUpDownVestDx, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelVestSx, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelVestDx, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(77, 37)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(286, 28)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'LabelClit
        '
        Me.LabelClit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelClit.AutoSize = True
        Me.LabelClit.Location = New System.Drawing.Point(3, 10)
        Me.LabelClit.Name = "LabelClit"
        Me.LabelClit.Size = New System.Drawing.Size(44, 13)
        Me.LabelClit.TabIndex = 1
        Me.LabelClit.Text = "Clitoride"
        '
        'LabelVest
        '
        Me.LabelVest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVest.AutoSize = True
        Me.LabelVest.Location = New System.Drawing.Point(3, 44)
        Me.LabelVest.Name = "LabelVest"
        Me.LabelVest.Size = New System.Drawing.Size(50, 13)
        Me.LabelVest.TabIndex = 2
        Me.LabelVest.Text = "Vestibolo"
        '
        'LabelSubr
        '
        Me.LabelSubr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelSubr.AutoSize = True
        Me.LabelSubr.Location = New System.Drawing.Point(3, 78)
        Me.LabelSubr.Name = "LabelSubr"
        Me.LabelSubr.Size = New System.Drawing.Size(55, 13)
        Me.LabelSubr.TabIndex = 4
        Me.LabelSubr.Text = "Subretrale"
        '
        'LabelForc
        '
        Me.LabelForc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelForc.AutoSize = True
        Me.LabelForc.Location = New System.Drawing.Point(3, 114)
        Me.LabelForc.Name = "LabelForc"
        Me.LabelForc.Size = New System.Drawing.Size(52, 13)
        Me.LabelForc.TabIndex = 6
        Me.LabelForc.Text = "Forchetta"
        '
        'LabelVestDx
        '
        Me.LabelVestDx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelVestDx.AutoSize = True
        Me.LabelVestDx.Location = New System.Drawing.Point(16, 7)
        Me.LabelVestDx.Name = "LabelVestDx"
        Me.LabelVestDx.Size = New System.Drawing.Size(38, 13)
        Me.LabelVestDx.TabIndex = 3
        Me.LabelVestDx.Text = "Destro"
        '
        'LabelVestSx
        '
        Me.LabelVestSx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelVestSx.AutoSize = True
        Me.LabelVestSx.Location = New System.Drawing.Point(156, 7)
        Me.LabelVestSx.Name = "LabelVestSx"
        Me.LabelVestSx.Size = New System.Drawing.Size(43, 13)
        Me.LabelVestSx.TabIndex = 5
        Me.LabelVestSx.Text = "Simistro"
        '
        'NumericUpDownClit
        '
        Me.NumericUpDownClit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDownClit.Location = New System.Drawing.Point(77, 7)
        Me.NumericUpDownClit.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownClit.Name = "NumericUpDownClit"
        Me.NumericUpDownClit.Size = New System.Drawing.Size(69, 20)
        Me.NumericUpDownClit.TabIndex = 1
        '
        'NumericUpDownVestDx
        '
        Me.NumericUpDownVestDx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDownVestDx.Location = New System.Drawing.Point(74, 4)
        Me.NumericUpDownVestDx.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownVestDx.Name = "NumericUpDownVestDx"
        Me.NumericUpDownVestDx.Size = New System.Drawing.Size(65, 20)
        Me.NumericUpDownVestDx.TabIndex = 6
        '
        'NumericUpDownVestSx
        '
        Me.NumericUpDownVestSx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDownVestSx.Location = New System.Drawing.Point(216, 4)
        Me.NumericUpDownVestSx.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownVestSx.Name = "NumericUpDownVestSx"
        Me.NumericUpDownVestSx.Size = New System.Drawing.Size(67, 20)
        Me.NumericUpDownVestSx.TabIndex = 7
        '
        'NumericUpDownSubr
        '
        Me.NumericUpDownSubr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDownSubr.Location = New System.Drawing.Point(77, 75)
        Me.NumericUpDownSubr.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownSubr.Name = "NumericUpDownSubr"
        Me.NumericUpDownSubr.Size = New System.Drawing.Size(69, 20)
        Me.NumericUpDownSubr.TabIndex = 7
        '
        'NumericUpDownForc
        '
        Me.NumericUpDownForc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumericUpDownForc.Location = New System.Drawing.Point(77, 110)
        Me.NumericUpDownForc.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownForc.Name = "NumericUpDownForc"
        Me.NumericUpDownForc.Size = New System.Drawing.Size(69, 20)
        Me.NumericUpDownForc.TabIndex = 8
        '
        'GroupBoxMiglioramento
        '
        Me.GroupBoxMiglioramento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxMiglioramento.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxMiglioramento.Location = New System.Drawing.Point(221, 9)
        Me.GroupBoxMiglioramento.Name = "GroupBoxMiglioramento"
        Me.GroupBoxMiglioramento.Size = New System.Drawing.Size(149, 191)
        Me.GroupBoxMiglioramento.TabIndex = 1
        Me.GroupBoxMiglioramento.TabStop = False
        Me.GroupBoxMiglioramento.Text = "Miglioramento soggettivo"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButtonMiglAsintomatico, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButtonMiglNotevole, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButtonMiglLieve, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButtonMiglMo, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(143, 172)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'RadioButtonMiglMo
        '
        Me.RadioButtonMiglMo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonMiglMo.AutoSize = True
        Me.RadioButtonMiglMo.Location = New System.Drawing.Point(3, 13)
        Me.RadioButtonMiglMo.Name = "RadioButtonMiglMo"
        Me.RadioButtonMiglMo.Size = New System.Drawing.Size(49, 17)
        Me.RadioButtonMiglMo.TabIndex = 0
        Me.RadioButtonMiglMo.TabStop = True
        Me.RadioButtonMiglMo.Text = "Nullo"
        Me.RadioButtonMiglMo.UseVisualStyleBackColor = True
        '
        'RadioButtonMiglLieve
        '
        Me.RadioButtonMiglLieve.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonMiglLieve.AutoSize = True
        Me.RadioButtonMiglLieve.Location = New System.Drawing.Point(3, 56)
        Me.RadioButtonMiglLieve.Name = "RadioButtonMiglLieve"
        Me.RadioButtonMiglLieve.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonMiglLieve.TabIndex = 1
        Me.RadioButtonMiglLieve.TabStop = True
        Me.RadioButtonMiglLieve.Text = "Lieve"
        Me.RadioButtonMiglLieve.UseVisualStyleBackColor = True
        '
        'RadioButtonMiglNotevole
        '
        Me.RadioButtonMiglNotevole.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonMiglNotevole.AutoSize = True
        Me.RadioButtonMiglNotevole.Location = New System.Drawing.Point(3, 99)
        Me.RadioButtonMiglNotevole.Name = "RadioButtonMiglNotevole"
        Me.RadioButtonMiglNotevole.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonMiglNotevole.TabIndex = 2
        Me.RadioButtonMiglNotevole.TabStop = True
        Me.RadioButtonMiglNotevole.Text = "Notevole"
        Me.RadioButtonMiglNotevole.UseVisualStyleBackColor = True
        '
        'RadioButtonMiglAsintomatico
        '
        Me.RadioButtonMiglAsintomatico.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonMiglAsintomatico.AutoSize = True
        Me.RadioButtonMiglAsintomatico.Location = New System.Drawing.Point(3, 142)
        Me.RadioButtonMiglAsintomatico.Name = "RadioButtonMiglAsintomatico"
        Me.RadioButtonMiglAsintomatico.Size = New System.Drawing.Size(85, 17)
        Me.RadioButtonMiglAsintomatico.TabIndex = 3
        Me.RadioButtonMiglAsintomatico.TabStop = True
        Me.RadioButtonMiglAsintomatico.Text = "Asintomatico"
        Me.RadioButtonMiglAsintomatico.UseVisualStyleBackColor = True
        '
        'GroupBoxVg
        '
        Me.GroupBoxVg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxVg.Controls.Add(Me.TableLayoutPanelVg)
        Me.GroupBoxVg.Location = New System.Drawing.Point(434, 17)
        Me.GroupBoxVg.Name = "GroupBoxVg"
        Me.GroupBoxVg.Size = New System.Drawing.Size(332, 164)
        Me.GroupBoxVg.TabIndex = 2
        Me.GroupBoxVg.TabStop = False
        Me.GroupBoxVg.Text = "Vagina"
        '
        'TableLayoutPanelVg
        '
        Me.TableLayoutPanelVg.ColumnCount = 1
        Me.TableLayoutPanelVg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVg.Controls.Add(Me.TableLayoutPanel6, 0, 2)
        Me.TableLayoutPanelVg.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanelVg.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanelVg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelVg.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelVg.Name = "TableLayoutPanelVg"
        Me.TableLayoutPanelVg.RowCount = 3
        Me.TableLayoutPanelVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelVg.Size = New System.Drawing.Size(326, 145)
        Me.TableLayoutPanelVg.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.8125!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.1875!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.25!))
        Me.TableLayoutPanel4.Controls.Add(Me.RadioButtonStAtr, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.RadioButtonStDistr, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.RadioButtonStReg, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelStato, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(320, 42)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.75!))
        Me.TableLayoutPanel5.Controls.Add(Me.RadioButtonLicNo, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RadioButtonLicSi, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelLichen, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 51)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(320, 42)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.125!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.125!))
        Me.TableLayoutPanel6.Controls.Add(Me.RadioButtonCicNo, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.RadioButtonCicSi, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCicatrice, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 99)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(320, 43)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'LabelStato
        '
        Me.LabelStato.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelStato.AutoSize = True
        Me.LabelStato.Location = New System.Drawing.Point(3, 14)
        Me.LabelStato.Name = "LabelStato"
        Me.LabelStato.Size = New System.Drawing.Size(32, 13)
        Me.LabelStato.TabIndex = 2
        Me.LabelStato.Text = "Stato"
        '
        'LabelLichen
        '
        Me.LabelLichen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelLichen.AutoSize = True
        Me.LabelLichen.Location = New System.Drawing.Point(3, 14)
        Me.LabelLichen.Name = "LabelLichen"
        Me.LabelLichen.Size = New System.Drawing.Size(39, 13)
        Me.LabelLichen.TabIndex = 2
        Me.LabelLichen.Text = "Lichen"
        '
        'LabelCicatrice
        '
        Me.LabelCicatrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCicatrice.AutoSize = True
        Me.LabelCicatrice.Location = New System.Drawing.Point(3, 8)
        Me.LabelCicatrice.Name = "LabelCicatrice"
        Me.LabelCicatrice.Size = New System.Drawing.Size(51, 26)
        Me.LabelCicatrice.TabIndex = 2
        Me.LabelCicatrice.Text = "Cicatrice retraente"
        '
        'RadioButtonStReg
        '
        Me.RadioButtonStReg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonStReg.AutoSize = True
        Me.RadioButtonStReg.Location = New System.Drawing.Point(70, 12)
        Me.RadioButtonStReg.Name = "RadioButtonStReg"
        Me.RadioButtonStReg.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonStReg.TabIndex = 3
        Me.RadioButtonStReg.TabStop = True
        Me.RadioButtonStReg.Text = "Regolare"
        Me.RadioButtonStReg.UseVisualStyleBackColor = True
        '
        'RadioButtonStDistr
        '
        Me.RadioButtonStDistr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonStDistr.AutoSize = True
        Me.RadioButtonStDistr.Location = New System.Drawing.Point(158, 12)
        Me.RadioButtonStDistr.Name = "RadioButtonStDistr"
        Me.RadioButtonStDistr.Size = New System.Drawing.Size(69, 17)
        Me.RadioButtonStDistr.TabIndex = 4
        Me.RadioButtonStDistr.TabStop = True
        Me.RadioButtonStDistr.Text = "Distrofica"
        Me.RadioButtonStDistr.UseVisualStyleBackColor = True
        '
        'RadioButtonStAtr
        '
        Me.RadioButtonStAtr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonStAtr.AutoSize = True
        Me.RadioButtonStAtr.Location = New System.Drawing.Point(247, 12)
        Me.RadioButtonStAtr.Name = "RadioButtonStAtr"
        Me.RadioButtonStAtr.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonStAtr.TabIndex = 5
        Me.RadioButtonStAtr.TabStop = True
        Me.RadioButtonStAtr.Text = "Atrofica"
        Me.RadioButtonStAtr.UseVisualStyleBackColor = True
        '
        'RadioButtonLicSi
        '
        Me.RadioButtonLicSi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonLicSi.AutoSize = True
        Me.RadioButtonLicSi.Location = New System.Drawing.Point(71, 12)
        Me.RadioButtonLicSi.Name = "RadioButtonLicSi"
        Me.RadioButtonLicSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonLicSi.TabIndex = 3
        Me.RadioButtonLicSi.TabStop = True
        Me.RadioButtonLicSi.Text = "Sì"
        Me.RadioButtonLicSi.UseVisualStyleBackColor = True
        '
        'RadioButtonLicNo
        '
        Me.RadioButtonLicNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonLicNo.AutoSize = True
        Me.RadioButtonLicNo.Location = New System.Drawing.Point(119, 12)
        Me.RadioButtonLicNo.Name = "RadioButtonLicNo"
        Me.RadioButtonLicNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonLicNo.TabIndex = 4
        Me.RadioButtonLicNo.TabStop = True
        Me.RadioButtonLicNo.Text = "No"
        Me.RadioButtonLicNo.UseVisualStyleBackColor = True
        '
        'RadioButtonCicSi
        '
        Me.RadioButtonCicSi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonCicSi.AutoSize = True
        Me.RadioButtonCicSi.Location = New System.Drawing.Point(72, 13)
        Me.RadioButtonCicSi.Name = "RadioButtonCicSi"
        Me.RadioButtonCicSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonCicSi.TabIndex = 3
        Me.RadioButtonCicSi.TabStop = True
        Me.RadioButtonCicSi.Text = "Sì"
        Me.RadioButtonCicSi.UseVisualStyleBackColor = True
        '
        'RadioButtonCicNo
        '
        Me.RadioButtonCicNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonCicNo.AutoSize = True
        Me.RadioButtonCicNo.Location = New System.Drawing.Point(121, 13)
        Me.RadioButtonCicNo.Name = "RadioButtonCicNo"
        Me.RadioButtonCicNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonCicNo.TabIndex = 4
        Me.RadioButtonCicNo.TabStop = True
        Me.RadioButtonCicNo.Text = "No"
        Me.RadioButtonCicNo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelAltriDettagli
        '
        Me.TableLayoutPanelAltriDettagli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelAltriDettagli.ColumnCount = 1
        Me.TableLayoutPanelAltriDettagli.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelAltriDettagli.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelAltriDettagli.Controls.Add(Me.GroupBoxCistProv, 0, 1)
        Me.TableLayoutPanelAltriDettagli.Controls.Add(Me.GroupBoxIperContr, 0, 0)
        Me.TableLayoutPanelAltriDettagli.Location = New System.Drawing.Point(22, 250)
        Me.TableLayoutPanelAltriDettagli.Name = "TableLayoutPanelAltriDettagli"
        Me.TableLayoutPanelAltriDettagli.RowCount = 2
        Me.TableLayoutPanelAltriDettagli.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelAltriDettagli.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelAltriDettagli.Size = New System.Drawing.Size(356, 112)
        Me.TableLayoutPanelAltriDettagli.TabIndex = 3
        '
        'GroupBoxIperContr
        '
        Me.GroupBoxIperContr.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBoxIperContr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxIperContr.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxIperContr.Name = "GroupBoxIperContr"
        Me.GroupBoxIperContr.Size = New System.Drawing.Size(350, 50)
        Me.GroupBoxIperContr.TabIndex = 0
        Me.GroupBoxIperContr.TabStop = False
        Me.GroupBoxIperContr.Text = "Ipercontrattilità"
        '
        'GroupBoxCistProv
        '
        Me.GroupBoxCistProv.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBoxCistProv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxCistProv.Location = New System.Drawing.Point(3, 59)
        Me.GroupBoxCistProv.Name = "GroupBoxCistProv"
        Me.GroupBoxCistProv.Size = New System.Drawing.Size(350, 50)
        Me.GroupBoxCistProv.TabIndex = 1
        Me.GroupBoxCistProv.TabStop = False
        Me.GroupBoxCistProv.Text = "Cistalgie provocate"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.Controls.Add(Me.RadioButtonContrS, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.RadioButtonContrM, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.RadioButtonContrL, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(344, 31)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.RadioButtonCitProNo, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RadioButtonCitProSi, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(344, 31)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'RadioButtonContrL
        '
        Me.RadioButtonContrL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonContrL.AutoSize = True
        Me.RadioButtonContrL.Location = New System.Drawing.Point(31, 7)
        Me.RadioButtonContrL.Name = "RadioButtonContrL"
        Me.RadioButtonContrL.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonContrL.TabIndex = 1
        Me.RadioButtonContrL.TabStop = True
        Me.RadioButtonContrL.Text = "Lieve"
        Me.RadioButtonContrL.UseVisualStyleBackColor = True
        '
        'RadioButtonContrM
        '
        Me.RadioButtonContrM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonContrM.AutoSize = True
        Me.RadioButtonContrM.Location = New System.Drawing.Point(136, 7)
        Me.RadioButtonContrM.Name = "RadioButtonContrM"
        Me.RadioButtonContrM.Size = New System.Drawing.Size(70, 17)
        Me.RadioButtonContrM.TabIndex = 2
        Me.RadioButtonContrM.TabStop = True
        Me.RadioButtonContrM.Text = "Moderata"
        Me.RadioButtonContrM.UseVisualStyleBackColor = True
        '
        'RadioButtonContrS
        '
        Me.RadioButtonContrS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonContrS.AutoSize = True
        Me.RadioButtonContrS.Location = New System.Drawing.Point(256, 7)
        Me.RadioButtonContrS.Name = "RadioButtonContrS"
        Me.RadioButtonContrS.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonContrS.TabIndex = 3
        Me.RadioButtonContrS.TabStop = True
        Me.RadioButtonContrS.Text = "Severa"
        Me.RadioButtonContrS.UseVisualStyleBackColor = True
        '
        'RadioButtonCitProSi
        '
        Me.RadioButtonCitProSi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonCitProSi.AutoSize = True
        Me.RadioButtonCitProSi.Location = New System.Drawing.Point(69, 7)
        Me.RadioButtonCitProSi.Name = "RadioButtonCitProSi"
        Me.RadioButtonCitProSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonCitProSi.TabIndex = 4
        Me.RadioButtonCitProSi.TabStop = True
        Me.RadioButtonCitProSi.Text = "Sì"
        Me.RadioButtonCitProSi.UseVisualStyleBackColor = True
        '
        'RadioButtonCitProNo
        '
        Me.RadioButtonCitProNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonCitProNo.AutoSize = True
        Me.RadioButtonCitProNo.Location = New System.Drawing.Point(238, 7)
        Me.RadioButtonCitProNo.Name = "RadioButtonCitProNo"
        Me.RadioButtonCitProNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonCitProNo.TabIndex = 5
        Me.RadioButtonCitProNo.TabStop = True
        Me.RadioButtonCitProNo.Text = "No"
        Me.RadioButtonCitProNo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBoxMiglioramento, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBoxAderTp, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(403, 201)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(394, 210)
        Me.TableLayoutPanel7.TabIndex = 4
        '
        'GroupBoxAderTp
        '
        Me.GroupBoxAderTp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxAderTp.Controls.Add(Me.TableLayoutPanelAderTp)
        Me.GroupBoxAderTp.Location = New System.Drawing.Point(3, 55)
        Me.GroupBoxAderTp.Name = "GroupBoxAderTp"
        Me.GroupBoxAderTp.Size = New System.Drawing.Size(191, 100)
        Me.GroupBoxAderTp.TabIndex = 2
        Me.GroupBoxAderTp.TabStop = False
        Me.GroupBoxAderTp.Text = "Aderenza alla terapia"
        '
        'TableLayoutPanelAderTp
        '
        Me.TableLayoutPanelAderTp.ColumnCount = 1
        Me.TableLayoutPanelAderTp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAderTp.Controls.Add(Me.RadioButtonAderTpPar, 0, 2)
        Me.TableLayoutPanelAderTp.Controls.Add(Me.RadioButtonAderTpNo, 0, 1)
        Me.TableLayoutPanelAderTp.Controls.Add(Me.RadioButtonAderTpSi, 0, 0)
        Me.TableLayoutPanelAderTp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAderTp.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelAderTp.Name = "TableLayoutPanelAderTp"
        Me.TableLayoutPanelAderTp.RowCount = 3
        Me.TableLayoutPanelAderTp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelAderTp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelAderTp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelAderTp.Size = New System.Drawing.Size(185, 81)
        Me.TableLayoutPanelAderTp.TabIndex = 0
        '
        'RadioButtonAderTpSi
        '
        Me.RadioButtonAderTpSi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonAderTpSi.AutoSize = True
        Me.RadioButtonAderTpSi.Location = New System.Drawing.Point(75, 5)
        Me.RadioButtonAderTpSi.Name = "RadioButtonAderTpSi"
        Me.RadioButtonAderTpSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonAderTpSi.TabIndex = 5
        Me.RadioButtonAderTpSi.TabStop = True
        Me.RadioButtonAderTpSi.Text = "Sì"
        Me.RadioButtonAderTpSi.UseVisualStyleBackColor = True
        '
        'RadioButtonAderTpNo
        '
        Me.RadioButtonAderTpNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonAderTpNo.AutoSize = True
        Me.RadioButtonAderTpNo.Location = New System.Drawing.Point(73, 32)
        Me.RadioButtonAderTpNo.Name = "RadioButtonAderTpNo"
        Me.RadioButtonAderTpNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonAderTpNo.TabIndex = 6
        Me.RadioButtonAderTpNo.TabStop = True
        Me.RadioButtonAderTpNo.Text = "No"
        Me.RadioButtonAderTpNo.UseVisualStyleBackColor = True
        '
        'RadioButtonAderTpPar
        '
        Me.RadioButtonAderTpPar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonAderTpPar.AutoSize = True
        Me.RadioButtonAderTpPar.Location = New System.Drawing.Point(62, 59)
        Me.RadioButtonAderTpPar.Name = "RadioButtonAderTpPar"
        Me.RadioButtonAderTpPar.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonAderTpPar.TabIndex = 7
        Me.RadioButtonAderTpPar.TabStop = True
        Me.RadioButtonAderTpPar.Text = "Parzizle"
        Me.RadioButtonAderTpPar.UseVisualStyleBackColor = True
        '
        'FormVisitaUroGineco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormVisitaUroGineco"
        Me.Text = "Visita uro - ginecologica"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxSwabTest.ResumeLayout(False)
        Me.TableLayoutPanelSwab.ResumeLayout(False)
        Me.TableLayoutPanelSwab.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.NumericUpDownClit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVestDx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVestSx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSubr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownForc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMiglioramento.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBoxVg.ResumeLayout(False)
        Me.TableLayoutPanelVg.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanelAltriDettagli.ResumeLayout(False)
        Me.GroupBoxIperContr.ResumeLayout(False)
        Me.GroupBoxCistProv.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.GroupBoxAderTp.ResumeLayout(False)
        Me.TableLayoutPanelAderTp.ResumeLayout(False)
        Me.TableLayoutPanelAderTp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxSwabTest As GroupBox
    Friend WithEvents TableLayoutPanelSwab As TableLayoutPanel
    Friend WithEvents LabelSubr As Label
    Friend WithEvents LabelVest As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LabelClit As Label
    Friend WithEvents LabelForc As Label
    Friend WithEvents LabelVestSx As Label
    Friend WithEvents LabelVestDx As Label
    Friend WithEvents NumericUpDownClit As NumericUpDown
    Friend WithEvents NumericUpDownForc As NumericUpDown
    Friend WithEvents NumericUpDownSubr As NumericUpDown
    Friend WithEvents NumericUpDownVestSx As NumericUpDown
    Friend WithEvents NumericUpDownVestDx As NumericUpDown
    Friend WithEvents GroupBoxMiglioramento As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RadioButtonMiglAsintomatico As RadioButton
    Friend WithEvents RadioButtonMiglNotevole As RadioButton
    Friend WithEvents RadioButtonMiglLieve As RadioButton
    Friend WithEvents RadioButtonMiglMo As RadioButton
    Friend WithEvents GroupBoxVg As GroupBox
    Friend WithEvents TableLayoutPanelVg As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents RadioButtonCicNo As RadioButton
    Friend WithEvents RadioButtonCicSi As RadioButton
    Friend WithEvents LabelCicatrice As Label
    Friend WithEvents RadioButtonStAtr As RadioButton
    Friend WithEvents RadioButtonStDistr As RadioButton
    Friend WithEvents RadioButtonStReg As RadioButton
    Friend WithEvents LabelStato As Label
    Friend WithEvents RadioButtonLicNo As RadioButton
    Friend WithEvents RadioButtonLicSi As RadioButton
    Friend WithEvents LabelLichen As Label
    Friend WithEvents TableLayoutPanelAltriDettagli As TableLayoutPanel
    Friend WithEvents GroupBoxCistProv As GroupBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents GroupBoxIperContr As GroupBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents RadioButtonCitProNo As RadioButton
    Friend WithEvents RadioButtonCitProSi As RadioButton
    Friend WithEvents RadioButtonContrS As RadioButton
    Friend WithEvents RadioButtonContrM As RadioButton
    Friend WithEvents RadioButtonContrL As RadioButton
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents GroupBoxAderTp As GroupBox
    Friend WithEvents TableLayoutPanelAderTp As TableLayoutPanel
    Friend WithEvents RadioButtonAderTpPar As RadioButton
    Friend WithEvents RadioButtonAderTpNo As RadioButton
    Friend WithEvents RadioButtonAderTpSi As RadioButton
End Class
