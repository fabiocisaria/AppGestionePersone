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
        Me.TableLayoutPanelDiabete = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelDM2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelDM2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonDM2No = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDM2Si = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelDM1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonDM1No = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDM1Si = New System.Windows.Forms.RadioButton()
        Me.LabelDM1 = New System.Windows.Forms.Label()
        Me.LabelDiabete = New System.Windows.Forms.Label()
        Me.TableLayoutPanelIntoll = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelVg = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelLattosio = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelIntollLatt = New System.Windows.Forms.Label()
        Me.TableLayoutPanelVagLichen = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonIntollLattNo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIntollLattSi = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanelCeliachia2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonCeliachiaNo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCeliachiaSi = New System.Windows.Forms.RadioButton()
        Me.LabelCeliachia = New System.Windows.Forms.Label()
        Me.LabelIntoll = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelVescDol = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelVescDol = New System.Windows.Forms.Label()
        Me.MetroToggleVescDol = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanelIVU = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelIVU = New System.Windows.Forms.Label()
        Me.MetroToggleIVU = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanelVescIperatt = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelVescIperatt = New System.Windows.Forms.Label()
        Me.MetroToggleVescIperatt = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelColonIrr = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelColonIrr = New System.Windows.Forms.Label()
        Me.MetroToggleColonIrr = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanelFibromialgie = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroToggleFibromialgie = New MetroFramework.Controls.MetroToggle()
        Me.LabelFibromialgie = New System.Windows.Forms.Label()
        Me.TableLayoutPanelEndometriosi = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEndometriosi = New System.Windows.Forms.Label()
        Me.MetroToggleEndometriosi = New MetroFramework.Controls.MetroToggle()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelAnPatRem.SuspendLayout()
        Me.TableLayoutPanelDiabete.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanelDM2.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanelDM1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanelIntoll.SuspendLayout()
        Me.TableLayoutPanelVg.SuspendLayout()
        Me.TableLayoutPanelLattosio.SuspendLayout()
        Me.TableLayoutPanelVagLichen.SuspendLayout()
        Me.TableLayoutPanelCeliachia2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanelVescDol.SuspendLayout()
        Me.TableLayoutPanelIVU.SuspendLayout()
        Me.TableLayoutPanelVescIperatt.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanelColonIrr.SuspendLayout()
        Me.TableLayoutPanelFibromialgie.SuspendLayout()
        Me.TableLayoutPanelEndometriosi.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelAnPatRem
        '
        Me.TableLayoutPanelAnPatRem.ColumnCount = 2
        Me.TableLayoutPanelAnPatRem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelAnPatRem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.TableLayoutPanelDiabete, 1, 1)
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.TableLayoutPanelIntoll, 0, 1)
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.TableLayoutPanel11, 1, 0)
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanelAnPatRem.Controls.Add(Me.ButtonInserisci, 1, 2)
        Me.TableLayoutPanelAnPatRem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAnPatRem.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelAnPatRem.Name = "TableLayoutPanelAnPatRem"
        Me.TableLayoutPanelAnPatRem.RowCount = 3
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelAnPatRem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelAnPatRem.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelAnPatRem.TabIndex = 2
        '
        'TableLayoutPanelDiabete
        '
        Me.TableLayoutPanelDiabete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDiabete.ColumnCount = 1
        Me.TableLayoutPanelDiabete.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDiabete.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanelDiabete.Controls.Add(Me.LabelDiabete, 0, 0)
        Me.TableLayoutPanelDiabete.Location = New System.Drawing.Point(414, 253)
        Me.TableLayoutPanelDiabete.Name = "TableLayoutPanelDiabete"
        Me.TableLayoutPanelDiabete.RowCount = 2
        Me.TableLayoutPanelDiabete.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDiabete.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDiabete.Size = New System.Drawing.Size(320, 196)
        Me.TableLayoutPanelDiabete.TabIndex = 27
        Me.TableLayoutPanelDiabete.Tag = "PrimaryPanel"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanelDM2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanelDM1, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(17, 33)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(285, 160)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'TableLayoutPanelDM2
        '
        Me.TableLayoutPanelDM2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDM2.ColumnCount = 1
        Me.TableLayoutPanelDM2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM2.Controls.Add(Me.LabelDM2, 0, 0)
        Me.TableLayoutPanelDM2.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanelDM2.Location = New System.Drawing.Point(27, 93)
        Me.TableLayoutPanelDM2.Name = "TableLayoutPanelDM2"
        Me.TableLayoutPanelDM2.RowCount = 2
        Me.TableLayoutPanelDM2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM2.Size = New System.Drawing.Size(230, 54)
        Me.TableLayoutPanelDM2.TabIndex = 5
        Me.TableLayoutPanelDM2.Tag = "SecondaryPanel"
        '
        'LabelDM2
        '
        Me.LabelDM2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDM2.AutoSize = True
        Me.LabelDM2.Location = New System.Drawing.Point(3, 7)
        Me.LabelDM2.Name = "LabelDM2"
        Me.LabelDM2.Size = New System.Drawing.Size(105, 13)
        Me.LabelDM2.TabIndex = 3
        Me.LabelDM2.Tag = "ThirdTitle"
        Me.LabelDM2.Text = "Diabete mellito tipo 2"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.RadioButtonDM2No, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.RadioButtonDM2Si, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 30)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(224, 21)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'RadioButtonDM2No
        '
        Me.RadioButtonDM2No.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM2No.AutoSize = True
        Me.RadioButtonDM2No.Location = New System.Drawing.Point(115, 3)
        Me.RadioButtonDM2No.Name = "RadioButtonDM2No"
        Me.RadioButtonDM2No.Size = New System.Drawing.Size(39, 15)
        Me.RadioButtonDM2No.TabIndex = 11
        Me.RadioButtonDM2No.TabStop = True
        Me.RadioButtonDM2No.Text = "No"
        Me.RadioButtonDM2No.UseVisualStyleBackColor = True
        '
        'RadioButtonDM2Si
        '
        Me.RadioButtonDM2Si.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM2Si.AutoSize = True
        Me.RadioButtonDM2Si.Location = New System.Drawing.Point(3, 3)
        Me.RadioButtonDM2Si.Name = "RadioButtonDM2Si"
        Me.RadioButtonDM2Si.Size = New System.Drawing.Size(34, 15)
        Me.RadioButtonDM2Si.TabIndex = 10
        Me.RadioButtonDM2Si.TabStop = True
        Me.RadioButtonDM2Si.Text = "Sì"
        Me.RadioButtonDM2Si.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelDM1
        '
        Me.TableLayoutPanelDM1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDM1.ColumnCount = 1
        Me.TableLayoutPanelDM1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM1.Controls.Add(Me.TableLayoutPanel9, 0, 1)
        Me.TableLayoutPanelDM1.Controls.Add(Me.LabelDM1, 0, 0)
        Me.TableLayoutPanelDM1.Location = New System.Drawing.Point(27, 13)
        Me.TableLayoutPanelDM1.Name = "TableLayoutPanelDM1"
        Me.TableLayoutPanelDM1.RowCount = 2
        Me.TableLayoutPanelDM1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelDM1.Size = New System.Drawing.Size(230, 54)
        Me.TableLayoutPanelDM1.TabIndex = 4
        Me.TableLayoutPanelDM1.Tag = "SecondaryPanel"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.RadioButtonDM1No, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RadioButtonDM1Si, 0, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 30)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(224, 21)
        Me.TableLayoutPanel9.TabIndex = 5
        '
        'RadioButtonDM1No
        '
        Me.RadioButtonDM1No.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM1No.AutoSize = True
        Me.RadioButtonDM1No.Location = New System.Drawing.Point(115, 3)
        Me.RadioButtonDM1No.Name = "RadioButtonDM1No"
        Me.RadioButtonDM1No.Size = New System.Drawing.Size(39, 15)
        Me.RadioButtonDM1No.TabIndex = 11
        Me.RadioButtonDM1No.TabStop = True
        Me.RadioButtonDM1No.Text = "No"
        Me.RadioButtonDM1No.UseVisualStyleBackColor = True
        '
        'RadioButtonDM1Si
        '
        Me.RadioButtonDM1Si.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonDM1Si.AutoSize = True
        Me.RadioButtonDM1Si.Location = New System.Drawing.Point(3, 3)
        Me.RadioButtonDM1Si.Name = "RadioButtonDM1Si"
        Me.RadioButtonDM1Si.Size = New System.Drawing.Size(34, 15)
        Me.RadioButtonDM1Si.TabIndex = 10
        Me.RadioButtonDM1Si.TabStop = True
        Me.RadioButtonDM1Si.Text = "Sì"
        Me.RadioButtonDM1Si.UseVisualStyleBackColor = True
        '
        'LabelDM1
        '
        Me.LabelDM1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDM1.AutoSize = True
        Me.LabelDM1.Location = New System.Drawing.Point(3, 7)
        Me.LabelDM1.Name = "LabelDM1"
        Me.LabelDM1.Size = New System.Drawing.Size(105, 13)
        Me.LabelDM1.TabIndex = 4
        Me.LabelDM1.Tag = "ThirdTitle"
        Me.LabelDM1.Text = "Diabete mellito tipo 1"
        '
        'LabelDiabete
        '
        Me.LabelDiabete.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDiabete.AutoSize = True
        Me.LabelDiabete.Location = New System.Drawing.Point(3, 8)
        Me.LabelDiabete.Name = "LabelDiabete"
        Me.LabelDiabete.Size = New System.Drawing.Size(44, 13)
        Me.LabelDiabete.TabIndex = 16
        Me.LabelDiabete.Tag = "PrimaryTitle"
        Me.LabelDiabete.Text = "Diabete"
        '
        'TableLayoutPanelIntoll
        '
        Me.TableLayoutPanelIntoll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelIntoll.ColumnCount = 1
        Me.TableLayoutPanelIntoll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIntoll.Controls.Add(Me.TableLayoutPanelVg, 0, 1)
        Me.TableLayoutPanelIntoll.Controls.Add(Me.LabelIntoll, 0, 0)
        Me.TableLayoutPanelIntoll.Location = New System.Drawing.Point(31, 253)
        Me.TableLayoutPanelIntoll.Name = "TableLayoutPanelIntoll"
        Me.TableLayoutPanelIntoll.RowCount = 2
        Me.TableLayoutPanelIntoll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelIntoll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIntoll.Size = New System.Drawing.Size(320, 196)
        Me.TableLayoutPanelIntoll.TabIndex = 26
        Me.TableLayoutPanelIntoll.Tag = "PrimaryPanel"
        '
        'TableLayoutPanelVg
        '
        Me.TableLayoutPanelVg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelVg.ColumnCount = 1
        Me.TableLayoutPanelVg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVg.Controls.Add(Me.TableLayoutPanelLattosio, 0, 1)
        Me.TableLayoutPanelVg.Controls.Add(Me.TableLayoutPanelCeliachia2, 0, 0)
        Me.TableLayoutPanelVg.Location = New System.Drawing.Point(17, 33)
        Me.TableLayoutPanelVg.Name = "TableLayoutPanelVg"
        Me.TableLayoutPanelVg.RowCount = 2
        Me.TableLayoutPanelVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelVg.Size = New System.Drawing.Size(285, 160)
        Me.TableLayoutPanelVg.TabIndex = 0
        '
        'TableLayoutPanelLattosio
        '
        Me.TableLayoutPanelLattosio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelLattosio.ColumnCount = 1
        Me.TableLayoutPanelLattosio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelLattosio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelLattosio.Controls.Add(Me.LabelIntollLatt, 0, 0)
        Me.TableLayoutPanelLattosio.Controls.Add(Me.TableLayoutPanelVagLichen, 0, 1)
        Me.TableLayoutPanelLattosio.Location = New System.Drawing.Point(27, 93)
        Me.TableLayoutPanelLattosio.Name = "TableLayoutPanelLattosio"
        Me.TableLayoutPanelLattosio.RowCount = 2
        Me.TableLayoutPanelLattosio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelLattosio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelLattosio.Size = New System.Drawing.Size(230, 54)
        Me.TableLayoutPanelLattosio.TabIndex = 5
        Me.TableLayoutPanelLattosio.Tag = "SecondaryPanel"
        '
        'LabelIntollLatt
        '
        Me.LabelIntollLatt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIntollLatt.AutoSize = True
        Me.LabelIntollLatt.Location = New System.Drawing.Point(3, 7)
        Me.LabelIntollLatt.Name = "LabelIntollLatt"
        Me.LabelIntollLatt.Size = New System.Drawing.Size(108, 13)
        Me.LabelIntollLatt.TabIndex = 3
        Me.LabelIntollLatt.Tag = "ThirdTitle"
        Me.LabelIntollLatt.Text = "Intolleranza al lattosio"
        '
        'TableLayoutPanelVagLichen
        '
        Me.TableLayoutPanelVagLichen.ColumnCount = 2
        Me.TableLayoutPanelVagLichen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelVagLichen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelVagLichen.Controls.Add(Me.RadioButtonIntollLattNo, 1, 0)
        Me.TableLayoutPanelVagLichen.Controls.Add(Me.RadioButtonIntollLattSi, 0, 0)
        Me.TableLayoutPanelVagLichen.Location = New System.Drawing.Point(3, 30)
        Me.TableLayoutPanelVagLichen.Name = "TableLayoutPanelVagLichen"
        Me.TableLayoutPanelVagLichen.RowCount = 1
        Me.TableLayoutPanelVagLichen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVagLichen.Size = New System.Drawing.Size(224, 21)
        Me.TableLayoutPanelVagLichen.TabIndex = 1
        '
        'RadioButtonIntollLattNo
        '
        Me.RadioButtonIntollLattNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonIntollLattNo.AutoSize = True
        Me.RadioButtonIntollLattNo.Location = New System.Drawing.Point(115, 3)
        Me.RadioButtonIntollLattNo.Name = "RadioButtonIntollLattNo"
        Me.RadioButtonIntollLattNo.Size = New System.Drawing.Size(39, 15)
        Me.RadioButtonIntollLattNo.TabIndex = 9
        Me.RadioButtonIntollLattNo.TabStop = True
        Me.RadioButtonIntollLattNo.Text = "No"
        Me.RadioButtonIntollLattNo.UseVisualStyleBackColor = True
        '
        'RadioButtonIntollLattSi
        '
        Me.RadioButtonIntollLattSi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonIntollLattSi.AutoSize = True
        Me.RadioButtonIntollLattSi.Location = New System.Drawing.Point(39, 3)
        Me.RadioButtonIntollLattSi.Name = "RadioButtonIntollLattSi"
        Me.RadioButtonIntollLattSi.Size = New System.Drawing.Size(34, 15)
        Me.RadioButtonIntollLattSi.TabIndex = 8
        Me.RadioButtonIntollLattSi.TabStop = True
        Me.RadioButtonIntollLattSi.Text = "Sì"
        Me.RadioButtonIntollLattSi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelCeliachia2
        '
        Me.TableLayoutPanelCeliachia2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelCeliachia2.ColumnCount = 1
        Me.TableLayoutPanelCeliachia2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCeliachia2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCeliachia2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanelCeliachia2.Controls.Add(Me.LabelCeliachia, 0, 0)
        Me.TableLayoutPanelCeliachia2.Location = New System.Drawing.Point(27, 13)
        Me.TableLayoutPanelCeliachia2.Name = "TableLayoutPanelCeliachia2"
        Me.TableLayoutPanelCeliachia2.RowCount = 2
        Me.TableLayoutPanelCeliachia2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCeliachia2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelCeliachia2.Size = New System.Drawing.Size(230, 54)
        Me.TableLayoutPanelCeliachia2.TabIndex = 4
        Me.TableLayoutPanelCeliachia2.Tag = "SecondaryPanel"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButtonCeliachiaNo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButtonCeliachiaSi, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 30)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(224, 21)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'RadioButtonCeliachiaNo
        '
        Me.RadioButtonCeliachiaNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonCeliachiaNo.AutoSize = True
        Me.RadioButtonCeliachiaNo.Location = New System.Drawing.Point(115, 3)
        Me.RadioButtonCeliachiaNo.Name = "RadioButtonCeliachiaNo"
        Me.RadioButtonCeliachiaNo.Size = New System.Drawing.Size(39, 15)
        Me.RadioButtonCeliachiaNo.TabIndex = 9
        Me.RadioButtonCeliachiaNo.TabStop = True
        Me.RadioButtonCeliachiaNo.Text = "No"
        Me.RadioButtonCeliachiaNo.UseVisualStyleBackColor = True
        '
        'RadioButtonCeliachiaSi
        '
        Me.RadioButtonCeliachiaSi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonCeliachiaSi.AutoSize = True
        Me.RadioButtonCeliachiaSi.Location = New System.Drawing.Point(39, 3)
        Me.RadioButtonCeliachiaSi.Name = "RadioButtonCeliachiaSi"
        Me.RadioButtonCeliachiaSi.Size = New System.Drawing.Size(34, 15)
        Me.RadioButtonCeliachiaSi.TabIndex = 8
        Me.RadioButtonCeliachiaSi.TabStop = True
        Me.RadioButtonCeliachiaSi.Text = "Sì"
        Me.RadioButtonCeliachiaSi.UseVisualStyleBackColor = True
        '
        'LabelCeliachia
        '
        Me.LabelCeliachia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCeliachia.AutoSize = True
        Me.LabelCeliachia.Location = New System.Drawing.Point(3, 7)
        Me.LabelCeliachia.Name = "LabelCeliachia"
        Me.LabelCeliachia.Size = New System.Drawing.Size(50, 13)
        Me.LabelCeliachia.TabIndex = 4
        Me.LabelCeliachia.Tag = "ThirdTitle"
        Me.LabelCeliachia.Text = "Celiachia"
        '
        'LabelIntoll
        '
        Me.LabelIntoll.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIntoll.AutoSize = True
        Me.LabelIntoll.Location = New System.Drawing.Point(3, 8)
        Me.LabelIntoll.Name = "LabelIntoll"
        Me.LabelIntoll.Size = New System.Drawing.Size(61, 13)
        Me.LabelIntoll.TabIndex = 16
        Me.LabelIntoll.Tag = "PrimaryTitle"
        Me.LabelIntoll.Text = "Intolleranze"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanelVescDol, 0, 2)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanelIVU, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanelVescIperatt, 0, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(414, 13)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 3
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(320, 200)
        Me.TableLayoutPanel11.TabIndex = 8
        '
        'TableLayoutPanelVescDol
        '
        Me.TableLayoutPanelVescDol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelVescDol.ColumnCount = 2
        Me.TableLayoutPanelVescDol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanelVescDol.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescDol.Controls.Add(Me.LabelVescDol, 1, 0)
        Me.TableLayoutPanelVescDol.Controls.Add(Me.MetroToggleVescDol, 0, 0)
        Me.TableLayoutPanelVescDol.Location = New System.Drawing.Point(3, 146)
        Me.TableLayoutPanelVescDol.Name = "TableLayoutPanelVescDol"
        Me.TableLayoutPanelVescDol.RowCount = 1
        Me.TableLayoutPanelVescDol.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescDol.Size = New System.Drawing.Size(314, 40)
        Me.TableLayoutPanelVescDol.TabIndex = 26
        Me.TableLayoutPanelVescDol.Tag = "PrimaryPanel"
        '
        'LabelVescDol
        '
        Me.LabelVescDol.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVescDol.Location = New System.Drawing.Point(93, 11)
        Me.LabelVescDol.Name = "LabelVescDol"
        Me.LabelVescDol.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelVescDol.Size = New System.Drawing.Size(172, 18)
        Me.LabelVescDol.TabIndex = 1
        Me.LabelVescDol.Text = "Sindrome della vescica dolorosa"
        Me.LabelVescDol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroToggleVescDol
        '
        Me.MetroToggleVescDol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleVescDol.AutoSize = True
        Me.MetroToggleVescDol.DisplayStatus = False
        Me.MetroToggleVescDol.Location = New System.Drawing.Point(20, 11)
        Me.MetroToggleVescDol.Name = "MetroToggleVescDol"
        Me.MetroToggleVescDol.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleVescDol.TabIndex = 2
        Me.MetroToggleVescDol.Text = "Off"
        Me.MetroToggleVescDol.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelIVU
        '
        Me.TableLayoutPanelIVU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelIVU.ColumnCount = 2
        Me.TableLayoutPanelIVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanelIVU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIVU.Controls.Add(Me.LabelIVU, 1, 0)
        Me.TableLayoutPanelIVU.Controls.Add(Me.MetroToggleIVU, 0, 0)
        Me.TableLayoutPanelIVU.Location = New System.Drawing.Point(3, 79)
        Me.TableLayoutPanelIVU.Name = "TableLayoutPanelIVU"
        Me.TableLayoutPanelIVU.RowCount = 1
        Me.TableLayoutPanelIVU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIVU.Size = New System.Drawing.Size(314, 40)
        Me.TableLayoutPanelIVU.TabIndex = 25
        Me.TableLayoutPanelIVU.Tag = "PrimaryPanel"
        '
        'LabelIVU
        '
        Me.LabelIVU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIVU.Location = New System.Drawing.Point(93, 11)
        Me.LabelIVU.Name = "LabelIVU"
        Me.LabelIVU.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelIVU.Size = New System.Drawing.Size(139, 18)
        Me.LabelIVU.TabIndex = 1
        Me.LabelIVU.Text = "Infezione delle vie urinarie"
        Me.LabelIVU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroToggleIVU
        '
        Me.MetroToggleIVU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleIVU.AutoSize = True
        Me.MetroToggleIVU.DisplayStatus = False
        Me.MetroToggleIVU.Location = New System.Drawing.Point(20, 11)
        Me.MetroToggleIVU.Name = "MetroToggleIVU"
        Me.MetroToggleIVU.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleIVU.TabIndex = 2
        Me.MetroToggleIVU.Text = "Off"
        Me.MetroToggleIVU.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelVescIperatt
        '
        Me.TableLayoutPanelVescIperatt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelVescIperatt.ColumnCount = 2
        Me.TableLayoutPanelVescIperatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanelVescIperatt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescIperatt.Controls.Add(Me.LabelVescIperatt, 1, 0)
        Me.TableLayoutPanelVescIperatt.Controls.Add(Me.MetroToggleVescIperatt, 0, 0)
        Me.TableLayoutPanelVescIperatt.Location = New System.Drawing.Point(3, 13)
        Me.TableLayoutPanelVescIperatt.Name = "TableLayoutPanelVescIperatt"
        Me.TableLayoutPanelVescIperatt.RowCount = 1
        Me.TableLayoutPanelVescIperatt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescIperatt.Size = New System.Drawing.Size(314, 40)
        Me.TableLayoutPanelVescIperatt.TabIndex = 24
        Me.TableLayoutPanelVescIperatt.Tag = "PrimaryPanel"
        '
        'LabelVescIperatt
        '
        Me.LabelVescIperatt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVescIperatt.Location = New System.Drawing.Point(93, 11)
        Me.LabelVescIperatt.Name = "LabelVescIperatt"
        Me.LabelVescIperatt.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelVescIperatt.Size = New System.Drawing.Size(102, 18)
        Me.LabelVescIperatt.TabIndex = 1
        Me.LabelVescIperatt.Text = "Vescica iperattiva"
        Me.LabelVescIperatt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroToggleVescIperatt
        '
        Me.MetroToggleVescIperatt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleVescIperatt.AutoSize = True
        Me.MetroToggleVescIperatt.DisplayStatus = False
        Me.MetroToggleVescIperatt.Location = New System.Drawing.Point(20, 11)
        Me.MetroToggleVescIperatt.Name = "MetroToggleVescIperatt"
        Me.MetroToggleVescIperatt.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleVescIperatt.TabIndex = 2
        Me.MetroToggleVescIperatt.Text = "Off"
        Me.MetroToggleVescIperatt.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanelColonIrr, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanelFibromialgie, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanelEndometriosi, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(31, 13)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(320, 200)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'TableLayoutPanelColonIrr
        '
        Me.TableLayoutPanelColonIrr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelColonIrr.ColumnCount = 2
        Me.TableLayoutPanelColonIrr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanelColonIrr.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelColonIrr.Controls.Add(Me.LabelColonIrr, 1, 0)
        Me.TableLayoutPanelColonIrr.Controls.Add(Me.MetroToggleColonIrr, 0, 0)
        Me.TableLayoutPanelColonIrr.Location = New System.Drawing.Point(3, 146)
        Me.TableLayoutPanelColonIrr.Name = "TableLayoutPanelColonIrr"
        Me.TableLayoutPanelColonIrr.RowCount = 1
        Me.TableLayoutPanelColonIrr.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelColonIrr.Size = New System.Drawing.Size(314, 40)
        Me.TableLayoutPanelColonIrr.TabIndex = 26
        Me.TableLayoutPanelColonIrr.Tag = "PrimaryPanel"
        '
        'LabelColonIrr
        '
        Me.LabelColonIrr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelColonIrr.Location = New System.Drawing.Point(93, 11)
        Me.LabelColonIrr.Name = "LabelColonIrr"
        Me.LabelColonIrr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelColonIrr.Size = New System.Drawing.Size(83, 18)
        Me.LabelColonIrr.TabIndex = 1
        Me.LabelColonIrr.Text = "Colon irritabile"
        Me.LabelColonIrr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroToggleColonIrr
        '
        Me.MetroToggleColonIrr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleColonIrr.AutoSize = True
        Me.MetroToggleColonIrr.DisplayStatus = False
        Me.MetroToggleColonIrr.Location = New System.Drawing.Point(20, 11)
        Me.MetroToggleColonIrr.Name = "MetroToggleColonIrr"
        Me.MetroToggleColonIrr.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleColonIrr.TabIndex = 2
        Me.MetroToggleColonIrr.Text = "Off"
        Me.MetroToggleColonIrr.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelFibromialgie
        '
        Me.TableLayoutPanelFibromialgie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelFibromialgie.ColumnCount = 2
        Me.TableLayoutPanelFibromialgie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanelFibromialgie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelFibromialgie.Controls.Add(Me.MetroToggleFibromialgie, 0, 0)
        Me.TableLayoutPanelFibromialgie.Controls.Add(Me.LabelFibromialgie, 1, 0)
        Me.TableLayoutPanelFibromialgie.Location = New System.Drawing.Point(3, 79)
        Me.TableLayoutPanelFibromialgie.Name = "TableLayoutPanelFibromialgie"
        Me.TableLayoutPanelFibromialgie.RowCount = 1
        Me.TableLayoutPanelFibromialgie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelFibromialgie.Size = New System.Drawing.Size(314, 40)
        Me.TableLayoutPanelFibromialgie.TabIndex = 25
        Me.TableLayoutPanelFibromialgie.Tag = "PrimaryPanel"
        '
        'MetroToggleFibromialgie
        '
        Me.MetroToggleFibromialgie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleFibromialgie.AutoSize = True
        Me.MetroToggleFibromialgie.DisplayStatus = False
        Me.MetroToggleFibromialgie.Location = New System.Drawing.Point(20, 11)
        Me.MetroToggleFibromialgie.Name = "MetroToggleFibromialgie"
        Me.MetroToggleFibromialgie.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleFibromialgie.TabIndex = 2
        Me.MetroToggleFibromialgie.Text = "Off"
        Me.MetroToggleFibromialgie.UseVisualStyleBackColor = True
        '
        'LabelFibromialgie
        '
        Me.LabelFibromialgie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelFibromialgie.Location = New System.Drawing.Point(93, 11)
        Me.LabelFibromialgie.Name = "LabelFibromialgie"
        Me.LabelFibromialgie.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelFibromialgie.Size = New System.Drawing.Size(83, 18)
        Me.LabelFibromialgie.TabIndex = 1
        Me.LabelFibromialgie.Text = "Fibromialgie"
        Me.LabelFibromialgie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanelEndometriosi
        '
        Me.TableLayoutPanelEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelEndometriosi.ColumnCount = 2
        Me.TableLayoutPanelEndometriosi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanelEndometriosi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndometriosi.Controls.Add(Me.LabelEndometriosi, 1, 0)
        Me.TableLayoutPanelEndometriosi.Controls.Add(Me.MetroToggleEndometriosi, 0, 0)
        Me.TableLayoutPanelEndometriosi.Location = New System.Drawing.Point(3, 13)
        Me.TableLayoutPanelEndometriosi.Name = "TableLayoutPanelEndometriosi"
        Me.TableLayoutPanelEndometriosi.RowCount = 1
        Me.TableLayoutPanelEndometriosi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndometriosi.Size = New System.Drawing.Size(314, 40)
        Me.TableLayoutPanelEndometriosi.TabIndex = 24
        Me.TableLayoutPanelEndometriosi.Tag = "PrimaryPanel"
        '
        'LabelEndometriosi
        '
        Me.LabelEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndometriosi.Location = New System.Drawing.Point(93, 11)
        Me.LabelEndometriosi.Name = "LabelEndometriosi"
        Me.LabelEndometriosi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelEndometriosi.Size = New System.Drawing.Size(83, 18)
        Me.LabelEndometriosi.TabIndex = 1
        Me.LabelEndometriosi.Text = "Endometriosi"
        Me.LabelEndometriosi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroToggleEndometriosi
        '
        Me.MetroToggleEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleEndometriosi.AutoSize = True
        Me.MetroToggleEndometriosi.DisplayStatus = False
        Me.MetroToggleEndometriosi.Location = New System.Drawing.Point(20, 11)
        Me.MetroToggleEndometriosi.Name = "MetroToggleEndometriosi"
        Me.MetroToggleEndometriosi.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleEndometriosi.TabIndex = 2
        Me.MetroToggleEndometriosi.Text = "Off"
        Me.MetroToggleEndometriosi.UseVisualStyleBackColor = True
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(665, 481)
        Me.ButtonInserisci.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_AnamnesiPatologicaRemota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelAnPatRem)
        Me.Name = "UC_AnamnesiPatologicaRemota"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelAnPatRem.ResumeLayout(False)
        Me.TableLayoutPanelDiabete.ResumeLayout(False)
        Me.TableLayoutPanelDiabete.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanelDM2.ResumeLayout(False)
        Me.TableLayoutPanelDM2.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanelDM1.ResumeLayout(False)
        Me.TableLayoutPanelDM1.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanelIntoll.ResumeLayout(False)
        Me.TableLayoutPanelIntoll.PerformLayout()
        Me.TableLayoutPanelVg.ResumeLayout(False)
        Me.TableLayoutPanelLattosio.ResumeLayout(False)
        Me.TableLayoutPanelLattosio.PerformLayout()
        Me.TableLayoutPanelVagLichen.ResumeLayout(False)
        Me.TableLayoutPanelVagLichen.PerformLayout()
        Me.TableLayoutPanelCeliachia2.ResumeLayout(False)
        Me.TableLayoutPanelCeliachia2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanelVescDol.ResumeLayout(False)
        Me.TableLayoutPanelVescDol.PerformLayout()
        Me.TableLayoutPanelIVU.ResumeLayout(False)
        Me.TableLayoutPanelIVU.PerformLayout()
        Me.TableLayoutPanelVescIperatt.ResumeLayout(False)
        Me.TableLayoutPanelVescIperatt.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanelColonIrr.ResumeLayout(False)
        Me.TableLayoutPanelColonIrr.PerformLayout()
        Me.TableLayoutPanelFibromialgie.ResumeLayout(False)
        Me.TableLayoutPanelFibromialgie.PerformLayout()
        Me.TableLayoutPanelEndometriosi.ResumeLayout(False)
        Me.TableLayoutPanelEndometriosi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelAnPatRem As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelVescDol As TableLayoutPanel
    Friend WithEvents LabelVescDol As Label
    Friend WithEvents MetroToggleVescDol As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelIVU As TableLayoutPanel
    Friend WithEvents LabelIVU As Label
    Friend WithEvents MetroToggleIVU As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelVescIperatt As TableLayoutPanel
    Friend WithEvents LabelVescIperatt As Label
    Friend WithEvents MetroToggleVescIperatt As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelColonIrr As TableLayoutPanel
    Friend WithEvents LabelColonIrr As Label
    Friend WithEvents MetroToggleColonIrr As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelFibromialgie As TableLayoutPanel
    Friend WithEvents LabelFibromialgie As Label
    Friend WithEvents MetroToggleFibromialgie As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelEndometriosi As TableLayoutPanel
    Friend WithEvents LabelEndometriosi As Label
    Friend WithEvents MetroToggleEndometriosi As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelIntoll As TableLayoutPanel
    Friend WithEvents TableLayoutPanelVg As TableLayoutPanel
    Friend WithEvents LabelIntoll As Label
    Friend WithEvents TableLayoutPanelDiabete As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDM2 As TableLayoutPanel
    Friend WithEvents LabelDM2 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDM1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents LabelDM1 As Label
    Friend WithEvents LabelDiabete As Label
    Friend WithEvents TableLayoutPanelLattosio As TableLayoutPanel
    Friend WithEvents LabelIntollLatt As Label
    Friend WithEvents TableLayoutPanelVagLichen As TableLayoutPanel
    Friend WithEvents RadioButtonIntollLattNo As RadioButton
    Friend WithEvents RadioButtonIntollLattSi As RadioButton
    Friend WithEvents TableLayoutPanelCeliachia2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RadioButtonCeliachiaNo As RadioButton
    Friend WithEvents RadioButtonCeliachiaSi As RadioButton
    Friend WithEvents LabelCeliachia As Label
    Friend WithEvents RadioButtonDM2No As RadioButton
    Friend WithEvents RadioButtonDM2Si As RadioButton
    Friend WithEvents RadioButtonDM1No As RadioButton
    Friend WithEvents RadioButtonDM1Si As RadioButton
End Class
