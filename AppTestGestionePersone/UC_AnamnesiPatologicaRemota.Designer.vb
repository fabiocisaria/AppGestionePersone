<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AnamnesiPatologicaRemota
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
        Me.TableLayoutPanelAnPatRem = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelEndometriosi = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonEndometriosiNo = New System.Windows.Forms.RadioButton()
        Me.LabelEndometriosi = New System.Windows.Forms.Label()
        Me.RadioButtonEndometriosiSi = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelFibromialgie = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonFibromialgieNo = New System.Windows.Forms.RadioButton()
        Me.LabelFibromialgie = New System.Windows.Forms.Label()
        Me.RadioButtonFibromialgieSi = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelColonIrr = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonColonIrrNo = New System.Windows.Forms.RadioButton()
        Me.LabelColonIrr = New System.Windows.Forms.Label()
        Me.RadioButtonColonIrrSi = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelIVU = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonIVUNo = New System.Windows.Forms.RadioButton()
        Me.LabelIVU = New System.Windows.Forms.Label()
        Me.RadioButtonIVUSi = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelVescIperatt = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonVescIperattNo = New System.Windows.Forms.RadioButton()
        Me.LabelVescIperatt = New System.Windows.Forms.Label()
        Me.RadioButtonVescIperattSi = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelVescDol = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonVescDolNo = New System.Windows.Forms.RadioButton()
        Me.LabelVescDol = New System.Windows.Forms.Label()
        Me.RadioButtonVescDolSi = New System.Windows.Forms.RadioButton()
        Me.GroupBoxIntolleranze = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelCeliachia = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonCeliachiaNo = New System.Windows.Forms.RadioButton()
        Me.LabelCeliachia = New System.Windows.Forms.Label()
        Me.RadioButtonCeliachiaSi = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelIntollLatt = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonIntollLattNo = New System.Windows.Forms.RadioButton()
        Me.LabelIntollLatt = New System.Windows.Forms.Label()
        Me.RadioButtonIntollLattSi = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDiabete = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelDM2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonDM2No = New System.Windows.Forms.RadioButton()
        Me.LabelDM2 = New System.Windows.Forms.Label()
        Me.RadioButtonDM2Si = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelDM1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonDM1No = New System.Windows.Forms.RadioButton()
        Me.LabelDM1 = New System.Windows.Forms.Label()
        Me.RadioButtonDM1Si = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelAnPatRem.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanelEndometriosi.SuspendLayout()
        Me.TableLayoutPanelFibromialgie.SuspendLayout()
        Me.TableLayoutPanelColonIrr.SuspendLayout()
        Me.TableLayoutPanelIVU.SuspendLayout()
        Me.TableLayoutPanelVescIperatt.SuspendLayout()
        Me.TableLayoutPanelVescDol.SuspendLayout()
        Me.GroupBoxIntolleranze.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanelCeliachia.SuspendLayout()
        Me.TableLayoutPanelIntollLatt.SuspendLayout()
        Me.GroupBoxDiabete.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanelDM2.SuspendLayout()
        Me.TableLayoutPanelDM1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelAnPatRem
        '
        Me.TableLayoutPanelAnPatRem.ColumnCount = 1
        Me.TableLayoutPanelAnPatRem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.GroupBoxDiabete, 0, 2)
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.ButtonInserisci, 0, 3)
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.GroupBoxIntolleranze, 0, 1)
        Me.TableLayoutPanelAnPatRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAnPatRem.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelAnPatRem.Name = "TableLayoutPanelAnPatRem"
        Me.TableLayoutPanelAnPatRem.RowCount = 4
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelAnPatRem.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelAnPatRem.TabIndex = 2
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelVescIperatt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelFibromialgie, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelEndometriosi, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelColonIrr, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelIVU, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelVescDol, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(760, 230)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanelEndometriosi
        '
        Me.TableLayoutPanelEndometriosi.ColumnCount = 3
        Me.TableLayoutPanelEndometriosi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelEndometriosi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelEndometriosi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelEndometriosi.Controls.Add(Me.RadioButtonEndometriosiNo, 2, 0)
        Me.TableLayoutPanelEndometriosi.Controls.Add(Me.LabelEndometriosi, 0, 0)
        Me.TableLayoutPanelEndometriosi.Controls.Add(Me.RadioButtonEndometriosiSi, 1, 0)
        Me.TableLayoutPanelEndometriosi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelEndometriosi.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelEndometriosi.Name = "TableLayoutPanelEndometriosi"
        Me.TableLayoutPanelEndometriosi.RowCount = 1
        Me.TableLayoutPanelEndometriosi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndometriosi.Size = New System.Drawing.Size(374, 70)
        Me.TableLayoutPanelEndometriosi.TabIndex = 18
        '
        'RadioButtonEndometriosiNo
        '
        Me.RadioButtonEndometriosiNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonEndometriosiNo.AutoSize = True
        Me.RadioButtonEndometriosiNo.Location = New System.Drawing.Point(156, 26)
        Me.RadioButtonEndometriosiNo.Name = "RadioButtonEndometriosiNo"
        Me.RadioButtonEndometriosiNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonEndometriosiNo.TabIndex = 8
        Me.RadioButtonEndometriosiNo.TabStop = True
        Me.RadioButtonEndometriosiNo.Text = "No"
        Me.RadioButtonEndometriosiNo.UseVisualStyleBackColor = True
        '
        'LabelEndometriosi
        '
        Me.LabelEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndometriosi.AutoSize = True
        Me.LabelEndometriosi.Location = New System.Drawing.Point(3, 28)
        Me.LabelEndometriosi.Name = "LabelEndometriosi"
        Me.LabelEndometriosi.Size = New System.Drawing.Size(67, 13)
        Me.LabelEndometriosi.TabIndex = 5
        Me.LabelEndometriosi.Text = "Endometriosi"
        '
        'RadioButtonEndometriosiSi
        '
        Me.RadioButtonEndometriosiSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonEndometriosiSi.AutoSize = True
        Me.RadioButtonEndometriosiSi.Location = New System.Drawing.Point(83, 26)
        Me.RadioButtonEndometriosiSi.Name = "RadioButtonEndometriosiSi"
        Me.RadioButtonEndometriosiSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonEndometriosiSi.TabIndex = 7
        Me.RadioButtonEndometriosiSi.TabStop = True
        Me.RadioButtonEndometriosiSi.Text = "Sì"
        Me.RadioButtonEndometriosiSi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelFibromialgie
        '
        Me.TableLayoutPanelFibromialgie.ColumnCount = 3
        Me.TableLayoutPanelFibromialgie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelFibromialgie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelFibromialgie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelFibromialgie.Controls.Add(Me.RadioButtonFibromialgieNo, 2, 0)
        Me.TableLayoutPanelFibromialgie.Controls.Add(Me.LabelFibromialgie, 0, 0)
        Me.TableLayoutPanelFibromialgie.Controls.Add(Me.RadioButtonFibromialgieSi, 1, 0)
        Me.TableLayoutPanelFibromialgie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelFibromialgie.Location = New System.Drawing.Point(3, 79)
        Me.TableLayoutPanelFibromialgie.Name = "TableLayoutPanelFibromialgie"
        Me.TableLayoutPanelFibromialgie.RowCount = 1
        Me.TableLayoutPanelFibromialgie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelFibromialgie.Size = New System.Drawing.Size(374, 70)
        Me.TableLayoutPanelFibromialgie.TabIndex = 20
        '
        'RadioButtonFibromialgieNo
        '
        Me.RadioButtonFibromialgieNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonFibromialgieNo.AutoSize = True
        Me.RadioButtonFibromialgieNo.Location = New System.Drawing.Point(156, 26)
        Me.RadioButtonFibromialgieNo.Name = "RadioButtonFibromialgieNo"
        Me.RadioButtonFibromialgieNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonFibromialgieNo.TabIndex = 8
        Me.RadioButtonFibromialgieNo.TabStop = True
        Me.RadioButtonFibromialgieNo.Text = "No"
        Me.RadioButtonFibromialgieNo.UseVisualStyleBackColor = True
        '
        'LabelFibromialgie
        '
        Me.LabelFibromialgie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelFibromialgie.AutoSize = True
        Me.LabelFibromialgie.Location = New System.Drawing.Point(3, 28)
        Me.LabelFibromialgie.Name = "LabelFibromialgie"
        Me.LabelFibromialgie.Size = New System.Drawing.Size(62, 13)
        Me.LabelFibromialgie.TabIndex = 5
        Me.LabelFibromialgie.Text = "Fibromialgie"
        '
        'RadioButtonFibromialgieSi
        '
        Me.RadioButtonFibromialgieSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonFibromialgieSi.AutoSize = True
        Me.RadioButtonFibromialgieSi.Location = New System.Drawing.Point(83, 26)
        Me.RadioButtonFibromialgieSi.Name = "RadioButtonFibromialgieSi"
        Me.RadioButtonFibromialgieSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonFibromialgieSi.TabIndex = 7
        Me.RadioButtonFibromialgieSi.TabStop = True
        Me.RadioButtonFibromialgieSi.Text = "Sì"
        Me.RadioButtonFibromialgieSi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelColonIrr
        '
        Me.TableLayoutPanelColonIrr.ColumnCount = 3
        Me.TableLayoutPanelColonIrr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelColonIrr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelColonIrr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelColonIrr.Controls.Add(Me.RadioButtonColonIrrNo, 2, 0)
        Me.TableLayoutPanelColonIrr.Controls.Add(Me.LabelColonIrr, 0, 0)
        Me.TableLayoutPanelColonIrr.Controls.Add(Me.RadioButtonColonIrrSi, 1, 0)
        Me.TableLayoutPanelColonIrr.Location = New System.Drawing.Point(3, 155)
        Me.TableLayoutPanelColonIrr.Name = "TableLayoutPanelColonIrr"
        Me.TableLayoutPanelColonIrr.RowCount = 1
        Me.TableLayoutPanelColonIrr.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelColonIrr.Size = New System.Drawing.Size(374, 72)
        Me.TableLayoutPanelColonIrr.TabIndex = 22
        '
        'RadioButtonColonIrrNo
        '
        Me.RadioButtonColonIrrNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonColonIrrNo.AutoSize = True
        Me.RadioButtonColonIrrNo.Location = New System.Drawing.Point(156, 27)
        Me.RadioButtonColonIrrNo.Name = "RadioButtonColonIrrNo"
        Me.RadioButtonColonIrrNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonColonIrrNo.TabIndex = 8
        Me.RadioButtonColonIrrNo.TabStop = True
        Me.RadioButtonColonIrrNo.Text = "No"
        Me.RadioButtonColonIrrNo.UseVisualStyleBackColor = True
        '
        'LabelColonIrr
        '
        Me.LabelColonIrr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelColonIrr.AutoSize = True
        Me.LabelColonIrr.Location = New System.Drawing.Point(3, 29)
        Me.LabelColonIrr.Name = "LabelColonIrr"
        Me.LabelColonIrr.Size = New System.Drawing.Size(72, 13)
        Me.LabelColonIrr.TabIndex = 5
        Me.LabelColonIrr.Text = "Colon irritabile"
        '
        'RadioButtonColonIrrSi
        '
        Me.RadioButtonColonIrrSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonColonIrrSi.AutoSize = True
        Me.RadioButtonColonIrrSi.Location = New System.Drawing.Point(83, 27)
        Me.RadioButtonColonIrrSi.Name = "RadioButtonColonIrrSi"
        Me.RadioButtonColonIrrSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonColonIrrSi.TabIndex = 7
        Me.RadioButtonColonIrrSi.TabStop = True
        Me.RadioButtonColonIrrSi.Text = "Sì"
        Me.RadioButtonColonIrrSi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelIVU
        '
        Me.TableLayoutPanelIVU.ColumnCount = 3
        Me.TableLayoutPanelIVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelIVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelIVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelIVU.Controls.Add(Me.RadioButtonIVUNo, 2, 0)
        Me.TableLayoutPanelIVU.Controls.Add(Me.LabelIVU, 0, 0)
        Me.TableLayoutPanelIVU.Controls.Add(Me.RadioButtonIVUSi, 1, 0)
        Me.TableLayoutPanelIVU.Location = New System.Drawing.Point(383, 79)
        Me.TableLayoutPanelIVU.Name = "TableLayoutPanelIVU"
        Me.TableLayoutPanelIVU.RowCount = 1
        Me.TableLayoutPanelIVU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIVU.Size = New System.Drawing.Size(374, 70)
        Me.TableLayoutPanelIVU.TabIndex = 24
        '
        'RadioButtonIVUNo
        '
        Me.RadioButtonIVUNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonIVUNo.AutoSize = True
        Me.RadioButtonIVUNo.Location = New System.Drawing.Point(156, 26)
        Me.RadioButtonIVUNo.Name = "RadioButtonIVUNo"
        Me.RadioButtonIVUNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonIVUNo.TabIndex = 8
        Me.RadioButtonIVUNo.TabStop = True
        Me.RadioButtonIVUNo.Text = "No"
        Me.RadioButtonIVUNo.UseVisualStyleBackColor = True
        '
        'LabelIVU
        '
        Me.LabelIVU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIVU.AutoSize = True
        Me.LabelIVU.Location = New System.Drawing.Point(3, 22)
        Me.LabelIVU.Name = "LabelIVU"
        Me.LabelIVU.Size = New System.Drawing.Size(70, 26)
        Me.LabelIVU.TabIndex = 5
        Me.LabelIVU.Text = "Infezione vie urinarie"
        '
        'RadioButtonIVUSi
        '
        Me.RadioButtonIVUSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonIVUSi.AutoSize = True
        Me.RadioButtonIVUSi.Location = New System.Drawing.Point(83, 26)
        Me.RadioButtonIVUSi.Name = "RadioButtonIVUSi"
        Me.RadioButtonIVUSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonIVUSi.TabIndex = 7
        Me.RadioButtonIVUSi.TabStop = True
        Me.RadioButtonIVUSi.Text = "Sì"
        Me.RadioButtonIVUSi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelVescIperatt
        '
        Me.TableLayoutPanelVescIperatt.ColumnCount = 3
        Me.TableLayoutPanelVescIperatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelVescIperatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelVescIperatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelVescIperatt.Controls.Add(Me.RadioButtonVescIperattNo, 2, 0)
        Me.TableLayoutPanelVescIperatt.Controls.Add(Me.LabelVescIperatt, 0, 0)
        Me.TableLayoutPanelVescIperatt.Controls.Add(Me.RadioButtonVescIperattSi, 1, 0)
        Me.TableLayoutPanelVescIperatt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelVescIperatt.Location = New System.Drawing.Point(383, 3)
        Me.TableLayoutPanelVescIperatt.Name = "TableLayoutPanelVescIperatt"
        Me.TableLayoutPanelVescIperatt.RowCount = 1
        Me.TableLayoutPanelVescIperatt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescIperatt.Size = New System.Drawing.Size(374, 70)
        Me.TableLayoutPanelVescIperatt.TabIndex = 28
        '
        'RadioButtonVescIperattNo
        '
        Me.RadioButtonVescIperattNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonVescIperattNo.AutoSize = True
        Me.RadioButtonVescIperattNo.Location = New System.Drawing.Point(156, 26)
        Me.RadioButtonVescIperattNo.Name = "RadioButtonVescIperattNo"
        Me.RadioButtonVescIperattNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonVescIperattNo.TabIndex = 8
        Me.RadioButtonVescIperattNo.TabStop = True
        Me.RadioButtonVescIperattNo.Text = "No"
        Me.RadioButtonVescIperattNo.UseVisualStyleBackColor = True
        '
        'LabelVescIperatt
        '
        Me.LabelVescIperatt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVescIperatt.AutoSize = True
        Me.LabelVescIperatt.Location = New System.Drawing.Point(3, 22)
        Me.LabelVescIperatt.Name = "LabelVescIperatt"
        Me.LabelVescIperatt.Size = New System.Drawing.Size(50, 26)
        Me.LabelVescIperatt.TabIndex = 5
        Me.LabelVescIperatt.Text = "Vescica iperattiva"
        '
        'RadioButtonVescIperattSi
        '
        Me.RadioButtonVescIperattSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonVescIperattSi.AutoSize = True
        Me.RadioButtonVescIperattSi.Location = New System.Drawing.Point(83, 26)
        Me.RadioButtonVescIperattSi.Name = "RadioButtonVescIperattSi"
        Me.RadioButtonVescIperattSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonVescIperattSi.TabIndex = 7
        Me.RadioButtonVescIperattSi.TabStop = True
        Me.RadioButtonVescIperattSi.Text = "Sì"
        Me.RadioButtonVescIperattSi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelVescDol
        '
        Me.TableLayoutPanelVescDol.ColumnCount = 3
        Me.TableLayoutPanelVescDol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelVescDol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelVescDol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelVescDol.Controls.Add(Me.RadioButtonVescDolNo, 2, 0)
        Me.TableLayoutPanelVescDol.Controls.Add(Me.LabelVescDol, 0, 0)
        Me.TableLayoutPanelVescDol.Controls.Add(Me.RadioButtonVescDolSi, 1, 0)
        Me.TableLayoutPanelVescDol.Location = New System.Drawing.Point(383, 155)
        Me.TableLayoutPanelVescDol.Name = "TableLayoutPanelVescDol"
        Me.TableLayoutPanelVescDol.RowCount = 1
        Me.TableLayoutPanelVescDol.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescDol.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelVescDol.Size = New System.Drawing.Size(374, 72)
        Me.TableLayoutPanelVescDol.TabIndex = 29
        '
        'RadioButtonVescDolNo
        '
        Me.RadioButtonVescDolNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonVescDolNo.AutoSize = True
        Me.RadioButtonVescDolNo.Location = New System.Drawing.Point(156, 27)
        Me.RadioButtonVescDolNo.Name = "RadioButtonVescDolNo"
        Me.RadioButtonVescDolNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonVescDolNo.TabIndex = 8
        Me.RadioButtonVescDolNo.TabStop = True
        Me.RadioButtonVescDolNo.Text = "No"
        Me.RadioButtonVescDolNo.UseVisualStyleBackColor = True
        '
        'LabelVescDol
        '
        Me.LabelVescDol.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVescDol.AutoSize = True
        Me.LabelVescDol.Location = New System.Drawing.Point(3, 16)
        Me.LabelVescDol.Name = "LabelVescDol"
        Me.LabelVescDol.Size = New System.Drawing.Size(54, 39)
        Me.LabelVescDol.TabIndex = 5
        Me.LabelVescDol.Text = "Sindrome vescica dolorosa"
        '
        'RadioButtonVescDolSi
        '
        Me.RadioButtonVescDolSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonVescDolSi.AutoSize = True
        Me.RadioButtonVescDolSi.Location = New System.Drawing.Point(83, 27)
        Me.RadioButtonVescDolSi.Name = "RadioButtonVescDolSi"
        Me.RadioButtonVescDolSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonVescDolSi.TabIndex = 7
        Me.RadioButtonVescDolSi.TabStop = True
        Me.RadioButtonVescDolSi.Text = "Sì"
        Me.RadioButtonVescDolSi.UseVisualStyleBackColor = True
        '
        'GroupBoxIntolleranze
        '
        Me.GroupBoxIntolleranze.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxIntolleranze.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxIntolleranze.Location = New System.Drawing.Point(122, 246)
        Me.GroupBoxIntolleranze.Name = "GroupBoxIntolleranze"
        Me.GroupBoxIntolleranze.Size = New System.Drawing.Size(521, 100)
        Me.GroupBoxIntolleranze.TabIndex = 4
        Me.GroupBoxIntolleranze.TabStop = False
        Me.GroupBoxIntolleranze.Text = "Intolleranze"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanelIntollLatt, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanelCeliachia, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(515, 81)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanelCeliachia
        '
        Me.TableLayoutPanelCeliachia.ColumnCount = 3
        Me.TableLayoutPanelCeliachia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelCeliachia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelCeliachia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelCeliachia.Controls.Add(Me.RadioButtonCeliachiaNo, 2, 0)
        Me.TableLayoutPanelCeliachia.Controls.Add(Me.LabelCeliachia, 0, 0)
        Me.TableLayoutPanelCeliachia.Controls.Add(Me.RadioButtonCeliachiaSi, 1, 0)
        Me.TableLayoutPanelCeliachia.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelCeliachia.Name = "TableLayoutPanelCeliachia"
        Me.TableLayoutPanelCeliachia.RowCount = 1
        Me.TableLayoutPanelCeliachia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelCeliachia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelCeliachia.Size = New System.Drawing.Size(251, 72)
        Me.TableLayoutPanelCeliachia.TabIndex = 23
        '
        'RadioButtonCeliachiaNo
        '
        Me.RadioButtonCeliachiaNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonCeliachiaNo.AutoSize = True
        Me.RadioButtonCeliachiaNo.Location = New System.Drawing.Point(125, 27)
        Me.RadioButtonCeliachiaNo.Name = "RadioButtonCeliachiaNo"
        Me.RadioButtonCeliachiaNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonCeliachiaNo.TabIndex = 8
        Me.RadioButtonCeliachiaNo.TabStop = True
        Me.RadioButtonCeliachiaNo.Text = "No"
        Me.RadioButtonCeliachiaNo.UseVisualStyleBackColor = True
        '
        'LabelCeliachia
        '
        Me.LabelCeliachia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCeliachia.AutoSize = True
        Me.LabelCeliachia.Location = New System.Drawing.Point(3, 29)
        Me.LabelCeliachia.Name = "LabelCeliachia"
        Me.LabelCeliachia.Size = New System.Drawing.Size(50, 13)
        Me.LabelCeliachia.TabIndex = 5
        Me.LabelCeliachia.Text = "Celiachia"
        '
        'RadioButtonCeliachiaSi
        '
        Me.RadioButtonCeliachiaSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonCeliachiaSi.AutoSize = True
        Me.RadioButtonCeliachiaSi.Location = New System.Drawing.Point(83, 27)
        Me.RadioButtonCeliachiaSi.Name = "RadioButtonCeliachiaSi"
        Me.RadioButtonCeliachiaSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonCeliachiaSi.TabIndex = 7
        Me.RadioButtonCeliachiaSi.TabStop = True
        Me.RadioButtonCeliachiaSi.Text = "Sì"
        Me.RadioButtonCeliachiaSi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelIntollLatt
        '
        Me.TableLayoutPanelIntollLatt.ColumnCount = 3
        Me.TableLayoutPanelIntollLatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelIntollLatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelIntollLatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelIntollLatt.Controls.Add(Me.RadioButtonIntollLattNo, 2, 0)
        Me.TableLayoutPanelIntollLatt.Controls.Add(Me.LabelIntollLatt, 0, 0)
        Me.TableLayoutPanelIntollLatt.Controls.Add(Me.RadioButtonIntollLattSi, 1, 0)
        Me.TableLayoutPanelIntollLatt.Location = New System.Drawing.Point(260, 3)
        Me.TableLayoutPanelIntollLatt.Name = "TableLayoutPanelIntollLatt"
        Me.TableLayoutPanelIntollLatt.RowCount = 1
        Me.TableLayoutPanelIntollLatt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIntollLatt.Size = New System.Drawing.Size(252, 72)
        Me.TableLayoutPanelIntollLatt.TabIndex = 24
        '
        'RadioButtonIntollLattNo
        '
        Me.RadioButtonIntollLattNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonIntollLattNo.AutoSize = True
        Me.RadioButtonIntollLattNo.Location = New System.Drawing.Point(126, 27)
        Me.RadioButtonIntollLattNo.Name = "RadioButtonIntollLattNo"
        Me.RadioButtonIntollLattNo.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonIntollLattNo.TabIndex = 8
        Me.RadioButtonIntollLattNo.TabStop = True
        Me.RadioButtonIntollLattNo.Text = "No"
        Me.RadioButtonIntollLattNo.UseVisualStyleBackColor = True
        '
        'LabelIntollLatt
        '
        Me.LabelIntollLatt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIntollLatt.AutoSize = True
        Me.LabelIntollLatt.Location = New System.Drawing.Point(3, 23)
        Me.LabelIntollLatt.Name = "LabelIntollLatt"
        Me.LabelIntollLatt.Size = New System.Drawing.Size(64, 26)
        Me.LabelIntollLatt.TabIndex = 5
        Me.LabelIntollLatt.Text = "Intolleranza lattosio"
        '
        'RadioButtonIntollLattSi
        '
        Me.RadioButtonIntollLattSi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonIntollLattSi.AutoSize = True
        Me.RadioButtonIntollLattSi.Location = New System.Drawing.Point(83, 27)
        Me.RadioButtonIntollLattSi.Name = "RadioButtonIntollLattSi"
        Me.RadioButtonIntollLattSi.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonIntollLattSi.TabIndex = 7
        Me.RadioButtonIntollLattSi.TabStop = True
        Me.RadioButtonIntollLattSi.Text = "Sì"
        Me.RadioButtonIntollLattSi.UseVisualStyleBackColor = True
        '
        'GroupBoxDiabete
        '
        Me.GroupBoxDiabete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxDiabete.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBoxDiabete.Location = New System.Drawing.Point(122, 366)
        Me.GroupBoxDiabete.Name = "GroupBoxDiabete"
        Me.GroupBoxDiabete.Size = New System.Drawing.Size(521, 100)
        Me.GroupBoxDiabete.TabIndex = 5
        Me.GroupBoxDiabete.TabStop = False
        Me.GroupBoxDiabete.Text = "Diabete"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanelDM2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanelDM1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(515, 81)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanelDM2
        '
        Me.TableLayoutPanelDM2.ColumnCount = 3
        Me.TableLayoutPanelDM2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelDM2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDM2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelDM2.Controls.Add(Me.RadioButtonDM2No, 2, 0)
        Me.TableLayoutPanelDM2.Controls.Add(Me.LabelDM2, 0, 0)
        Me.TableLayoutPanelDM2.Controls.Add(Me.RadioButtonDM2Si, 1, 0)
        Me.TableLayoutPanelDM2.Location = New System.Drawing.Point(260, 3)
        Me.TableLayoutPanelDM2.Name = "TableLayoutPanelDM2"
        Me.TableLayoutPanelDM2.RowCount = 1
        Me.TableLayoutPanelDM2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDM2.Size = New System.Drawing.Size(252, 72)
        Me.TableLayoutPanelDM2.TabIndex = 24
        '
        'RadioButtonDM2No
        '
        Me.RadioButtonDM2No.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM2No.AutoSize = True
        Me.RadioButtonDM2No.Location = New System.Drawing.Point(126, 27)
        Me.RadioButtonDM2No.Name = "RadioButtonDM2No"
        Me.RadioButtonDM2No.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonDM2No.TabIndex = 8
        Me.RadioButtonDM2No.TabStop = True
        Me.RadioButtonDM2No.Text = "No"
        Me.RadioButtonDM2No.UseVisualStyleBackColor = True
        '
        'LabelDM2
        '
        Me.LabelDM2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDM2.AutoSize = True
        Me.LabelDM2.Location = New System.Drawing.Point(3, 23)
        Me.LabelDM2.Name = "LabelDM2"
        Me.LabelDM2.Size = New System.Drawing.Size(47, 26)
        Me.LabelDM2.TabIndex = 5
        Me.LabelDM2.Text = "Diabete mellito 2"
        '
        'RadioButtonDM2Si
        '
        Me.RadioButtonDM2Si.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM2Si.AutoSize = True
        Me.RadioButtonDM2Si.Location = New System.Drawing.Point(83, 27)
        Me.RadioButtonDM2Si.Name = "RadioButtonDM2Si"
        Me.RadioButtonDM2Si.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonDM2Si.TabIndex = 7
        Me.RadioButtonDM2Si.TabStop = True
        Me.RadioButtonDM2Si.Text = "Sì"
        Me.RadioButtonDM2Si.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelDM1
        '
        Me.TableLayoutPanelDM1.ColumnCount = 3
        Me.TableLayoutPanelDM1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanelDM1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDM1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelDM1.Controls.Add(Me.RadioButtonDM1No, 2, 0)
        Me.TableLayoutPanelDM1.Controls.Add(Me.LabelDM1, 0, 0)
        Me.TableLayoutPanelDM1.Controls.Add(Me.RadioButtonDM1Si, 1, 0)
        Me.TableLayoutPanelDM1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelDM1.Name = "TableLayoutPanelDM1"
        Me.TableLayoutPanelDM1.RowCount = 1
        Me.TableLayoutPanelDM1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDM1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelDM1.Size = New System.Drawing.Size(251, 72)
        Me.TableLayoutPanelDM1.TabIndex = 23
        '
        'RadioButtonDM1No
        '
        Me.RadioButtonDM1No.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM1No.AutoSize = True
        Me.RadioButtonDM1No.Location = New System.Drawing.Point(125, 27)
        Me.RadioButtonDM1No.Name = "RadioButtonDM1No"
        Me.RadioButtonDM1No.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonDM1No.TabIndex = 8
        Me.RadioButtonDM1No.TabStop = True
        Me.RadioButtonDM1No.Text = "No"
        Me.RadioButtonDM1No.UseVisualStyleBackColor = True
        '
        'LabelDM1
        '
        Me.LabelDM1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDM1.AutoSize = True
        Me.LabelDM1.Location = New System.Drawing.Point(3, 23)
        Me.LabelDM1.Name = "LabelDM1"
        Me.LabelDM1.Size = New System.Drawing.Size(47, 26)
        Me.LabelDM1.TabIndex = 5
        Me.LabelDM1.Text = "Diabete mellito 1"
        '
        'RadioButtonDM1Si
        '
        Me.RadioButtonDM1Si.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM1Si.AutoSize = True
        Me.RadioButtonDM1Si.Location = New System.Drawing.Point(83, 27)
        Me.RadioButtonDM1Si.Name = "RadioButtonDM1Si"
        Me.RadioButtonDM1Si.Size = New System.Drawing.Size(34, 17)
        Me.RadioButtonDM1Si.TabIndex = 7
        Me.RadioButtonDM1Si.TabStop = True
        Me.RadioButtonDM1Si.Text = "Sì"
        Me.RadioButtonDM1Si.UseVisualStyleBackColor = True
        '
        'UC_AnamnesiPatologicaRemota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelAnPatRem)
        Me.Name = "UC_AnamnesiPatologicaRemota"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelAnPatRem.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanelEndometriosi.ResumeLayout(False)
        Me.TableLayoutPanelEndometriosi.PerformLayout()
        Me.TableLayoutPanelFibromialgie.ResumeLayout(False)
        Me.TableLayoutPanelFibromialgie.PerformLayout()
        Me.TableLayoutPanelColonIrr.ResumeLayout(False)
        Me.TableLayoutPanelColonIrr.PerformLayout()
        Me.TableLayoutPanelIVU.ResumeLayout(False)
        Me.TableLayoutPanelIVU.PerformLayout()
        Me.TableLayoutPanelVescIperatt.ResumeLayout(False)
        Me.TableLayoutPanelVescIperatt.PerformLayout()
        Me.TableLayoutPanelVescDol.ResumeLayout(False)
        Me.TableLayoutPanelVescDol.PerformLayout()
        Me.GroupBoxIntolleranze.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanelCeliachia.ResumeLayout(False)
        Me.TableLayoutPanelCeliachia.PerformLayout()
        Me.TableLayoutPanelIntollLatt.ResumeLayout(False)
        Me.TableLayoutPanelIntollLatt.PerformLayout()
        Me.GroupBoxDiabete.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanelDM2.ResumeLayout(False)
        Me.TableLayoutPanelDM2.PerformLayout()
        Me.TableLayoutPanelDM1.ResumeLayout(False)
        Me.TableLayoutPanelDM1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelAnPatRem As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelVescIperatt As TableLayoutPanel
    Friend WithEvents RadioButtonVescIperattNo As RadioButton
    Friend WithEvents LabelVescIperatt As Label
    Friend WithEvents RadioButtonVescIperattSi As RadioButton
    Friend WithEvents TableLayoutPanelIVU As TableLayoutPanel
    Friend WithEvents RadioButtonIVUNo As RadioButton
    Friend WithEvents LabelIVU As Label
    Friend WithEvents RadioButtonIVUSi As RadioButton
    Friend WithEvents TableLayoutPanelColonIrr As TableLayoutPanel
    Friend WithEvents RadioButtonColonIrrNo As RadioButton
    Friend WithEvents LabelColonIrr As Label
    Friend WithEvents RadioButtonColonIrrSi As RadioButton
    Friend WithEvents TableLayoutPanelFibromialgie As TableLayoutPanel
    Friend WithEvents RadioButtonFibromialgieNo As RadioButton
    Friend WithEvents LabelFibromialgie As Label
    Friend WithEvents RadioButtonFibromialgieSi As RadioButton
    Friend WithEvents TableLayoutPanelEndometriosi As TableLayoutPanel
    Friend WithEvents RadioButtonEndometriosiNo As RadioButton
    Friend WithEvents LabelEndometriosi As Label
    Friend WithEvents RadioButtonEndometriosiSi As RadioButton
    Friend WithEvents TableLayoutPanelVescDol As TableLayoutPanel
    Friend WithEvents RadioButtonVescDolNo As RadioButton
    Friend WithEvents LabelVescDol As Label
    Friend WithEvents RadioButtonVescDolSi As RadioButton
    Friend WithEvents GroupBoxIntolleranze As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelIntollLatt As TableLayoutPanel
    Friend WithEvents RadioButtonIntollLattNo As RadioButton
    Friend WithEvents LabelIntollLatt As Label
    Friend WithEvents RadioButtonIntollLattSi As RadioButton
    Friend WithEvents TableLayoutPanelCeliachia As TableLayoutPanel
    Friend WithEvents RadioButtonCeliachiaNo As RadioButton
    Friend WithEvents LabelCeliachia As Label
    Friend WithEvents RadioButtonCeliachiaSi As RadioButton
    Friend WithEvents GroupBoxDiabete As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDM2 As TableLayoutPanel
    Friend WithEvents RadioButtonDM2No As RadioButton
    Friend WithEvents LabelDM2 As Label
    Friend WithEvents RadioButtonDM2Si As RadioButton
    Friend WithEvents TableLayoutPanelDM1 As TableLayoutPanel
    Friend WithEvents RadioButtonDM1No As RadioButton
    Friend WithEvents LabelDM1 As Label
    Friend WithEvents RadioButtonDM1Si As RadioButton
End Class
