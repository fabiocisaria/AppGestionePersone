<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_VisitaRMN
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
        Me.TableLayoutPanelRmn = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelNuovaRMN = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelDettEsito = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelNevPud = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelNevPudSiNo = New System.Windows.Forms.Label()
        Me.MetroToggleNevPudSiNo = New MetroFramework.Controls.MetroToggle()
        Me.LabelRMNDettagliEsito = New System.Windows.Forms.Label()
        Me.TableLayoutPanelEndom = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelEndomSiNo = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEndomSiNo = New System.Windows.Forms.Label()
        Me.MetroToggleEndomSiNo = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanelEndomLoc = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelRettoVag = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEndomRettoVag = New System.Windows.Forms.Label()
        Me.MetroToggleRettoVagSiNo = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanelVescic = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEndomVesc = New System.Windows.Forms.Label()
        Me.MetroToggleVescicSiNo = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanelLusTorus = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEndomLusTorus = New System.Windows.Forms.Label()
        Me.MetroToggleLusTorusSiNo = New MetroFramework.Controls.MetroToggle()
        Me.LabelEndomLoc = New System.Windows.Forms.Label()
        Me.TableLayoutPanelOvar = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEndomOvar = New System.Windows.Forms.Label()
        Me.MetroToggleOvarSiNo = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanelPerit = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEndomPerit = New System.Windows.Forms.Label()
        Me.MetroTogglePeritSiNo = New MetroFramework.Controls.MetroToggle()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxEsito = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.LabelEsito = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimePickerDataEsecuzione = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelDataEsecuzione = New System.Windows.Forms.Label()
        Me.TableLayoutPanelRmn.SuspendLayout()
        Me.TableLayoutPanelNuovaRMN.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanelDettEsito.SuspendLayout()
        Me.TableLayoutPanelNevPud.SuspendLayout()
        Me.TableLayoutPanelEndom.SuspendLayout()
        Me.TableLayoutPanelEndomSiNo.SuspendLayout()
        Me.TableLayoutPanelEndomLoc.SuspendLayout()
        Me.TableLayoutPanelRettoVag.SuspendLayout()
        Me.TableLayoutPanelVescic.SuspendLayout()
        Me.TableLayoutPanelLusTorus.SuspendLayout()
        Me.TableLayoutPanelOvar.SuspendLayout()
        Me.TableLayoutPanelPerit.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelRmn
        '
        Me.TableLayoutPanelRmn.ColumnCount = 1
        Me.TableLayoutPanelRmn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelRmn.Controls.Add(Me.TableLayoutPanelNuovaRMN, 0, 0)
        Me.TableLayoutPanelRmn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRmn.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelRmn.Name = "TableLayoutPanelRmn"
        Me.TableLayoutPanelRmn.RowCount = 2
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelRmn.Size = New System.Drawing.Size(800, 600)
        Me.TableLayoutPanelRmn.TabIndex = 1
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(701, 566)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanelNuovaRMN
        '
        Me.TableLayoutPanelNuovaRMN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaRMN.ColumnCount = 1
        Me.TableLayoutPanelNuovaRMN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaRMN.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaRMN.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanelNuovaRMN.Location = New System.Drawing.Point(123, 27)
        Me.TableLayoutPanelNuovaRMN.Name = "TableLayoutPanelNuovaRMN"
        Me.TableLayoutPanelNuovaRMN.RowCount = 2
        Me.TableLayoutPanelNuovaRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaRMN.Size = New System.Drawing.Size(554, 505)
        Me.TableLayoutPanelNuovaRMN.TabIndex = 24
        Me.TableLayoutPanelNuovaRMN.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(109, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Risonanza magnetica"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelDettEsito, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(548, 469)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'TableLayoutPanelDettEsito
        '
        Me.TableLayoutPanelDettEsito.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDettEsito.ColumnCount = 1
        Me.TableLayoutPanelDettEsito.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDettEsito.Controls.Add(Me.TableLayoutPanelNevPud, 0, 1)
        Me.TableLayoutPanelDettEsito.Controls.Add(Me.LabelRMNDettagliEsito, 0, 0)
        Me.TableLayoutPanelDettEsito.Controls.Add(Me.TableLayoutPanelEndom, 0, 2)
        Me.TableLayoutPanelDettEsito.Location = New System.Drawing.Point(92, 93)
        Me.TableLayoutPanelDettEsito.Name = "TableLayoutPanelDettEsito"
        Me.TableLayoutPanelDettEsito.RowCount = 3
        Me.TableLayoutPanelDettEsito.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelDettEsito.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanelDettEsito.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDettEsito.Size = New System.Drawing.Size(364, 363)
        Me.TableLayoutPanelDettEsito.TabIndex = 10
        Me.TableLayoutPanelDettEsito.Tag = "PrimaryPanel"
        '
        'TableLayoutPanelNevPud
        '
        Me.TableLayoutPanelNevPud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNevPud.ColumnCount = 2
        Me.TableLayoutPanelNevPud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelNevPud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNevPud.Controls.Add(Me.LabelNevPudSiNo, 1, 0)
        Me.TableLayoutPanelNevPud.Controls.Add(Me.MetroToggleNevPudSiNo, 0, 0)
        Me.TableLayoutPanelNevPud.Location = New System.Drawing.Point(52, 33)
        Me.TableLayoutPanelNevPud.Name = "TableLayoutPanelNevPud"
        Me.TableLayoutPanelNevPud.RowCount = 1
        Me.TableLayoutPanelNevPud.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNevPud.Size = New System.Drawing.Size(260, 39)
        Me.TableLayoutPanelNevPud.TabIndex = 4
        '
        'LabelNevPudSiNo
        '
        Me.LabelNevPudSiNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNevPudSiNo.AutoSize = True
        Me.LabelNevPudSiNo.Location = New System.Drawing.Point(73, 13)
        Me.LabelNevPudSiNo.Name = "LabelNevPudSiNo"
        Me.LabelNevPudSiNo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelNevPudSiNo.Size = New System.Drawing.Size(119, 13)
        Me.LabelNevPudSiNo.TabIndex = 1
        Me.LabelNevPudSiNo.Text = "Nevralgia del pudendo"
        '
        'MetroToggleNevPudSiNo
        '
        Me.MetroToggleNevPudSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleNevPudSiNo.AutoSize = True
        Me.MetroToggleNevPudSiNo.DisplayStatus = False
        Me.MetroToggleNevPudSiNo.Location = New System.Drawing.Point(10, 11)
        Me.MetroToggleNevPudSiNo.Name = "MetroToggleNevPudSiNo"
        Me.MetroToggleNevPudSiNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroToggleNevPudSiNo.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleNevPudSiNo.TabIndex = 2
        Me.MetroToggleNevPudSiNo.Text = "Off"
        Me.MetroToggleNevPudSiNo.UseVisualStyleBackColor = True
        '
        'LabelRMNDettagliEsito
        '
        Me.LabelRMNDettagliEsito.AutoSize = True
        Me.LabelRMNDettagliEsito.Location = New System.Drawing.Point(10, 5)
        Me.LabelRMNDettagliEsito.Margin = New System.Windows.Forms.Padding(10, 5, 3, 0)
        Me.LabelRMNDettagliEsito.Name = "LabelRMNDettagliEsito"
        Me.LabelRMNDettagliEsito.Padding = New System.Windows.Forms.Padding(1)
        Me.LabelRMNDettagliEsito.Size = New System.Drawing.Size(71, 15)
        Me.LabelRMNDettagliEsito.TabIndex = 3
        Me.LabelRMNDettagliEsito.Tag = "SecondaryTitle"
        Me.LabelRMNDettagliEsito.Text = "Dettagli Esito"
        '
        'TableLayoutPanelEndom
        '
        Me.TableLayoutPanelEndom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelEndom.ColumnCount = 1
        Me.TableLayoutPanelEndom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndom.Controls.Add(Me.TableLayoutPanelEndomSiNo, 0, 0)
        Me.TableLayoutPanelEndom.Controls.Add(Me.TableLayoutPanelEndomLoc, 0, 1)
        Me.TableLayoutPanelEndom.Location = New System.Drawing.Point(25, 85)
        Me.TableLayoutPanelEndom.Name = "TableLayoutPanelEndom"
        Me.TableLayoutPanelEndom.RowCount = 2
        Me.TableLayoutPanelEndom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanelEndom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndom.Size = New System.Drawing.Size(314, 267)
        Me.TableLayoutPanelEndom.TabIndex = 5
        Me.TableLayoutPanelEndom.Tag = "SecondaryPanel"
        '
        'TableLayoutPanelEndomSiNo
        '
        Me.TableLayoutPanelEndomSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelEndomSiNo.ColumnCount = 2
        Me.TableLayoutPanelEndomSiNo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelEndomSiNo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndomSiNo.Controls.Add(Me.LabelEndomSiNo, 1, 0)
        Me.TableLayoutPanelEndomSiNo.Controls.Add(Me.MetroToggleEndomSiNo, 0, 0)
        Me.TableLayoutPanelEndomSiNo.Location = New System.Drawing.Point(27, 3)
        Me.TableLayoutPanelEndomSiNo.Name = "TableLayoutPanelEndomSiNo"
        Me.TableLayoutPanelEndomSiNo.RowCount = 1
        Me.TableLayoutPanelEndomSiNo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndomSiNo.Size = New System.Drawing.Size(260, 39)
        Me.TableLayoutPanelEndomSiNo.TabIndex = 5
        '
        'LabelEndomSiNo
        '
        Me.LabelEndomSiNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndomSiNo.AutoSize = True
        Me.LabelEndomSiNo.Location = New System.Drawing.Point(73, 13)
        Me.LabelEndomSiNo.Name = "LabelEndomSiNo"
        Me.LabelEndomSiNo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelEndomSiNo.Size = New System.Drawing.Size(72, 13)
        Me.LabelEndomSiNo.TabIndex = 1
        Me.LabelEndomSiNo.Text = "Endometriosi"
        '
        'MetroToggleEndomSiNo
        '
        Me.MetroToggleEndomSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleEndomSiNo.AutoSize = True
        Me.MetroToggleEndomSiNo.DisplayStatus = False
        Me.MetroToggleEndomSiNo.Location = New System.Drawing.Point(10, 11)
        Me.MetroToggleEndomSiNo.Name = "MetroToggleEndomSiNo"
        Me.MetroToggleEndomSiNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroToggleEndomSiNo.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleEndomSiNo.TabIndex = 2
        Me.MetroToggleEndomSiNo.Text = "Off"
        Me.MetroToggleEndomSiNo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelEndomLoc
        '
        Me.TableLayoutPanelEndomLoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelEndomLoc.ColumnCount = 1
        Me.TableLayoutPanelEndomLoc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndomLoc.Controls.Add(Me.TableLayoutPanelRettoVag, 0, 3)
        Me.TableLayoutPanelEndomLoc.Controls.Add(Me.TableLayoutPanelVescic, 0, 2)
        Me.TableLayoutPanelEndomLoc.Controls.Add(Me.TableLayoutPanelLusTorus, 0, 1)
        Me.TableLayoutPanelEndomLoc.Controls.Add(Me.LabelEndomLoc, 0, 0)
        Me.TableLayoutPanelEndomLoc.Controls.Add(Me.TableLayoutPanelOvar, 0, 5)
        Me.TableLayoutPanelEndomLoc.Controls.Add(Me.TableLayoutPanelPerit, 0, 4)
        Me.TableLayoutPanelEndomLoc.Location = New System.Drawing.Point(32, 54)
        Me.TableLayoutPanelEndomLoc.Name = "TableLayoutPanelEndomLoc"
        Me.TableLayoutPanelEndomLoc.RowCount = 6
        Me.TableLayoutPanelEndomLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelEndomLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanelEndomLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanelEndomLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanelEndomLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanelEndomLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanelEndomLoc.Size = New System.Drawing.Size(250, 203)
        Me.TableLayoutPanelEndomLoc.TabIndex = 6
        Me.TableLayoutPanelEndomLoc.Tag = "SecondaryPanel"
        '
        'TableLayoutPanelRettoVag
        '
        Me.TableLayoutPanelRettoVag.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelRettoVag.ColumnCount = 2
        Me.TableLayoutPanelRettoVag.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelRettoVag.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRettoVag.Controls.Add(Me.LabelEndomRettoVag, 1, 0)
        Me.TableLayoutPanelRettoVag.Controls.Add(Me.MetroToggleRettoVagSiNo, 0, 0)
        Me.TableLayoutPanelRettoVag.Location = New System.Drawing.Point(25, 101)
        Me.TableLayoutPanelRettoVag.Name = "TableLayoutPanelRettoVag"
        Me.TableLayoutPanelRettoVag.RowCount = 1
        Me.TableLayoutPanelRettoVag.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRettoVag.Size = New System.Drawing.Size(200, 28)
        Me.TableLayoutPanelRettoVag.TabIndex = 11
        '
        'LabelEndomRettoVag
        '
        Me.LabelEndomRettoVag.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndomRettoVag.AutoSize = True
        Me.LabelEndomRettoVag.Location = New System.Drawing.Point(73, 7)
        Me.LabelEndomRettoVag.Name = "LabelEndomRettoVag"
        Me.LabelEndomRettoVag.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelEndomRettoVag.Size = New System.Drawing.Size(81, 13)
        Me.LabelEndomRettoVag.TabIndex = 1
        Me.LabelEndomRettoVag.Text = "Retto vaginale"
        '
        'MetroToggleRettoVagSiNo
        '
        Me.MetroToggleRettoVagSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleRettoVagSiNo.AutoSize = True
        Me.MetroToggleRettoVagSiNo.DisplayStatus = False
        Me.MetroToggleRettoVagSiNo.Location = New System.Drawing.Point(10, 5)
        Me.MetroToggleRettoVagSiNo.Name = "MetroToggleRettoVagSiNo"
        Me.MetroToggleRettoVagSiNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroToggleRettoVagSiNo.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleRettoVagSiNo.TabIndex = 2
        Me.MetroToggleRettoVagSiNo.Text = "Off"
        Me.MetroToggleRettoVagSiNo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelVescic
        '
        Me.TableLayoutPanelVescic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelVescic.ColumnCount = 2
        Me.TableLayoutPanelVescic.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelVescic.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescic.Controls.Add(Me.LabelEndomVesc, 1, 0)
        Me.TableLayoutPanelVescic.Controls.Add(Me.MetroToggleVescicSiNo, 0, 0)
        Me.TableLayoutPanelVescic.Location = New System.Drawing.Point(25, 67)
        Me.TableLayoutPanelVescic.Name = "TableLayoutPanelVescic"
        Me.TableLayoutPanelVescic.RowCount = 1
        Me.TableLayoutPanelVescic.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelVescic.Size = New System.Drawing.Size(200, 28)
        Me.TableLayoutPanelVescic.TabIndex = 8
        '
        'LabelEndomVesc
        '
        Me.LabelEndomVesc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndomVesc.AutoSize = True
        Me.LabelEndomVesc.Location = New System.Drawing.Point(73, 7)
        Me.LabelEndomVesc.Name = "LabelEndomVesc"
        Me.LabelEndomVesc.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelEndomVesc.Size = New System.Drawing.Size(58, 13)
        Me.LabelEndomVesc.TabIndex = 1
        Me.LabelEndomVesc.Text = "Vescicale"
        '
        'MetroToggleVescicSiNo
        '
        Me.MetroToggleVescicSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleVescicSiNo.AutoSize = True
        Me.MetroToggleVescicSiNo.DisplayStatus = False
        Me.MetroToggleVescicSiNo.Location = New System.Drawing.Point(10, 5)
        Me.MetroToggleVescicSiNo.Name = "MetroToggleVescicSiNo"
        Me.MetroToggleVescicSiNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroToggleVescicSiNo.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleVescicSiNo.TabIndex = 2
        Me.MetroToggleVescicSiNo.Text = "Off"
        Me.MetroToggleVescicSiNo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelLusTorus
        '
        Me.TableLayoutPanelLusTorus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelLusTorus.ColumnCount = 2
        Me.TableLayoutPanelLusTorus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelLusTorus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelLusTorus.Controls.Add(Me.LabelEndomLusTorus, 1, 0)
        Me.TableLayoutPanelLusTorus.Controls.Add(Me.MetroToggleLusTorusSiNo, 0, 0)
        Me.TableLayoutPanelLusTorus.Location = New System.Drawing.Point(25, 33)
        Me.TableLayoutPanelLusTorus.Name = "TableLayoutPanelLusTorus"
        Me.TableLayoutPanelLusTorus.RowCount = 1
        Me.TableLayoutPanelLusTorus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelLusTorus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanelLusTorus.Size = New System.Drawing.Size(200, 28)
        Me.TableLayoutPanelLusTorus.TabIndex = 7
        '
        'LabelEndomLusTorus
        '
        Me.LabelEndomLusTorus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndomLusTorus.AutoSize = True
        Me.LabelEndomLusTorus.Location = New System.Drawing.Point(73, 7)
        Me.LabelEndomLusTorus.Name = "LabelEndomLusTorus"
        Me.LabelEndomLusTorus.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelEndomLusTorus.Size = New System.Drawing.Size(69, 13)
        Me.LabelEndomLusTorus.TabIndex = 1
        Me.LabelEndomLusTorus.Text = "LUS - Torus"
        '
        'MetroToggleLusTorusSiNo
        '
        Me.MetroToggleLusTorusSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleLusTorusSiNo.AutoSize = True
        Me.MetroToggleLusTorusSiNo.DisplayStatus = False
        Me.MetroToggleLusTorusSiNo.Location = New System.Drawing.Point(10, 5)
        Me.MetroToggleLusTorusSiNo.Name = "MetroToggleLusTorusSiNo"
        Me.MetroToggleLusTorusSiNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroToggleLusTorusSiNo.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleLusTorusSiNo.TabIndex = 2
        Me.MetroToggleLusTorusSiNo.Text = "Off"
        Me.MetroToggleLusTorusSiNo.UseVisualStyleBackColor = True
        '
        'LabelEndomLoc
        '
        Me.LabelEndomLoc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndomLoc.AutoSize = True
        Me.LabelEndomLoc.Location = New System.Drawing.Point(3, 8)
        Me.LabelEndomLoc.Name = "LabelEndomLoc"
        Me.LabelEndomLoc.Size = New System.Drawing.Size(138, 13)
        Me.LabelEndomLoc.TabIndex = 6
        Me.LabelEndomLoc.Text = "Localizzazione endometriosi"
        '
        'TableLayoutPanelOvar
        '
        Me.TableLayoutPanelOvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelOvar.ColumnCount = 2
        Me.TableLayoutPanelOvar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelOvar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelOvar.Controls.Add(Me.LabelEndomOvar, 1, 0)
        Me.TableLayoutPanelOvar.Controls.Add(Me.MetroToggleOvarSiNo, 0, 0)
        Me.TableLayoutPanelOvar.Location = New System.Drawing.Point(25, 169)
        Me.TableLayoutPanelOvar.Name = "TableLayoutPanelOvar"
        Me.TableLayoutPanelOvar.RowCount = 1
        Me.TableLayoutPanelOvar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelOvar.Size = New System.Drawing.Size(200, 31)
        Me.TableLayoutPanelOvar.TabIndex = 10
        '
        'LabelEndomOvar
        '
        Me.LabelEndomOvar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndomOvar.AutoSize = True
        Me.LabelEndomOvar.Location = New System.Drawing.Point(73, 9)
        Me.LabelEndomOvar.Name = "LabelEndomOvar"
        Me.LabelEndomOvar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelEndomOvar.Size = New System.Drawing.Size(49, 13)
        Me.LabelEndomOvar.TabIndex = 1
        Me.LabelEndomOvar.Text = "Ovarico"
        '
        'MetroToggleOvarSiNo
        '
        Me.MetroToggleOvarSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroToggleOvarSiNo.AutoSize = True
        Me.MetroToggleOvarSiNo.DisplayStatus = False
        Me.MetroToggleOvarSiNo.Location = New System.Drawing.Point(10, 7)
        Me.MetroToggleOvarSiNo.Name = "MetroToggleOvarSiNo"
        Me.MetroToggleOvarSiNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroToggleOvarSiNo.Size = New System.Drawing.Size(50, 17)
        Me.MetroToggleOvarSiNo.TabIndex = 2
        Me.MetroToggleOvarSiNo.Text = "Off"
        Me.MetroToggleOvarSiNo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelPerit
        '
        Me.TableLayoutPanelPerit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelPerit.ColumnCount = 2
        Me.TableLayoutPanelPerit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelPerit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPerit.Controls.Add(Me.LabelEndomPerit, 1, 0)
        Me.TableLayoutPanelPerit.Controls.Add(Me.MetroTogglePeritSiNo, 0, 0)
        Me.TableLayoutPanelPerit.Location = New System.Drawing.Point(25, 135)
        Me.TableLayoutPanelPerit.Name = "TableLayoutPanelPerit"
        Me.TableLayoutPanelPerit.RowCount = 1
        Me.TableLayoutPanelPerit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPerit.Size = New System.Drawing.Size(200, 28)
        Me.TableLayoutPanelPerit.TabIndex = 9
        '
        'LabelEndomPerit
        '
        Me.LabelEndomPerit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEndomPerit.AutoSize = True
        Me.LabelEndomPerit.Location = New System.Drawing.Point(73, 7)
        Me.LabelEndomPerit.Name = "LabelEndomPerit"
        Me.LabelEndomPerit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LabelEndomPerit.Size = New System.Drawing.Size(65, 13)
        Me.LabelEndomPerit.TabIndex = 1
        Me.LabelEndomPerit.Text = "Peritoneale"
        '
        'MetroTogglePeritSiNo
        '
        Me.MetroTogglePeritSiNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroTogglePeritSiNo.AutoSize = True
        Me.MetroTogglePeritSiNo.DisplayStatus = False
        Me.MetroTogglePeritSiNo.Location = New System.Drawing.Point(10, 5)
        Me.MetroTogglePeritSiNo.Name = "MetroTogglePeritSiNo"
        Me.MetroTogglePeritSiNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroTogglePeritSiNo.Size = New System.Drawing.Size(50, 17)
        Me.MetroTogglePeritSiNo.TabIndex = 2
        Me.MetroTogglePeritSiNo.Text = "Off"
        Me.MetroTogglePeritSiNo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxEsito, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelEsito, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(74, 43)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(400, 34)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ComboBoxEsito
        '
        Me.ComboBoxEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEsito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxEsito.AutoCompleteSuggestDelay = 1
        Me.ComboBoxEsito.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxEsito.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxEsito.Location = New System.Drawing.Point(123, 6)
        Me.ComboBoxEsito.Name = "ComboBoxEsito"
        Me.ComboBoxEsito.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEsito.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ComboBoxEsito.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEsito.TabIndex = 30
        Me.ComboBoxEsito.TabStop = False
        Me.ComboBoxEsito.Tag = "Find"
        '
        'LabelEsito
        '
        Me.LabelEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEsito.AutoSize = True
        Me.LabelEsito.Location = New System.Drawing.Point(3, 10)
        Me.LabelEsito.Name = "LabelEsito"
        Me.LabelEsito.Size = New System.Drawing.Size(30, 13)
        Me.LabelEsito.TabIndex = 7
        Me.LabelEsito.Text = "Esito"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePickerDataEsecuzione, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelDataEsecuzione, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(74, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(400, 34)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'DateTimePickerDataEsecuzione
        '
        Me.DateTimePickerDataEsecuzione.AllowNull = True
        Me.DateTimePickerDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataEsecuzione.DateTimeIcon = Nothing
        Me.DateTimePickerDataEsecuzione.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataEsecuzione.Location = New System.Drawing.Point(123, 6)
        Me.DateTimePickerDataEsecuzione.Name = "DateTimePickerDataEsecuzione"
        Me.DateTimePickerDataEsecuzione.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerDataEsecuzione.TabIndex = 12
        Me.DateTimePickerDataEsecuzione.ToolTipText = ""
        '
        'LabelDataEsecuzione
        '
        Me.LabelDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDataEsecuzione.AutoSize = True
        Me.LabelDataEsecuzione.Location = New System.Drawing.Point(3, 10)
        Me.LabelDataEsecuzione.Name = "LabelDataEsecuzione"
        Me.LabelDataEsecuzione.Size = New System.Drawing.Size(87, 13)
        Me.LabelDataEsecuzione.TabIndex = 5
        Me.LabelDataEsecuzione.Text = "Data esecuzione"
        '
        'UC_VisitaRMN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelRmn)
        Me.Name = "UC_VisitaRMN"
        Me.Size = New System.Drawing.Size(800, 600)
        Me.TableLayoutPanelRmn.ResumeLayout(False)
        Me.TableLayoutPanelNuovaRMN.ResumeLayout(False)
        Me.TableLayoutPanelNuovaRMN.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanelDettEsito.ResumeLayout(False)
        Me.TableLayoutPanelDettEsito.PerformLayout()
        Me.TableLayoutPanelNevPud.ResumeLayout(False)
        Me.TableLayoutPanelNevPud.PerformLayout()
        Me.TableLayoutPanelEndom.ResumeLayout(False)
        Me.TableLayoutPanelEndomSiNo.ResumeLayout(False)
        Me.TableLayoutPanelEndomSiNo.PerformLayout()
        Me.TableLayoutPanelEndomLoc.ResumeLayout(False)
        Me.TableLayoutPanelEndomLoc.PerformLayout()
        Me.TableLayoutPanelRettoVag.ResumeLayout(False)
        Me.TableLayoutPanelRettoVag.PerformLayout()
        Me.TableLayoutPanelVescic.ResumeLayout(False)
        Me.TableLayoutPanelVescic.PerformLayout()
        Me.TableLayoutPanelLusTorus.ResumeLayout(False)
        Me.TableLayoutPanelLusTorus.PerformLayout()
        Me.TableLayoutPanelOvar.ResumeLayout(False)
        Me.TableLayoutPanelOvar.PerformLayout()
        Me.TableLayoutPanelPerit.ResumeLayout(False)
        Me.TableLayoutPanelPerit.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanelRmn As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelNuovaRMN As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ComboBoxEsito As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents LabelEsito As Label
    Friend WithEvents DateTimePickerDataEsecuzione As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents LabelDataEsecuzione As Label
    Friend WithEvents TableLayoutPanelDettEsito As TableLayoutPanel
    Friend WithEvents LabelRMNDettagliEsito As Label
    Friend WithEvents TableLayoutPanelEndomSiNo As TableLayoutPanel
    Friend WithEvents LabelEndomSiNo As Label
    Friend WithEvents MetroToggleEndomSiNo As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelNevPud As TableLayoutPanel
    Friend WithEvents LabelNevPudSiNo As Label
    Friend WithEvents MetroToggleNevPudSiNo As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelEndom As TableLayoutPanel
    Friend WithEvents TableLayoutPanelEndomLoc As TableLayoutPanel
    Friend WithEvents LabelEndomLoc As Label
    Friend WithEvents TableLayoutPanelOvar As TableLayoutPanel
    Friend WithEvents LabelEndomOvar As Label
    Friend WithEvents MetroToggleOvarSiNo As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelPerit As TableLayoutPanel
    Friend WithEvents LabelEndomPerit As Label
    Friend WithEvents MetroTogglePeritSiNo As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelVescic As TableLayoutPanel
    Friend WithEvents LabelEndomVesc As Label
    Friend WithEvents MetroToggleVescicSiNo As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelLusTorus As TableLayoutPanel
    Friend WithEvents LabelEndomLusTorus As Label
    Friend WithEvents MetroToggleLusTorusSiNo As MetroFramework.Controls.MetroToggle
    Friend WithEvents TableLayoutPanelRettoVag As TableLayoutPanel
    Friend WithEvents LabelEndomRettoVag As Label
    Friend WithEvents MetroToggleRettoVagSiNo As MetroFramework.Controls.MetroToggle
End Class
