<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PazienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimaVisitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarmacoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovoFarmacoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovaClasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContraccettivoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegratoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MalattiaAutoimmuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerapiaRiabilitativaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserisciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnamnesiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FisiologicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatologicaRemotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsamiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DNATestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PapTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RMNToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamponeVaginaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UrinoculturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintomiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoriaOstetricoginecologicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerapiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UroGinecologicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PazienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitleBar = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NuovoToolStripMenuItem1, Me.InserisciToolStripMenuItem, Me.CercaToolStripMenuItem, Me.ImportaToolStripMenuItem, Me.ImpostazioniToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(38, 6)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(358, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'NuovoToolStripMenuItem1
        '
        Me.NuovoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PazienteToolStripMenuItem1, Me.VisitaToolStripMenuItem2, Me.FarmacoToolStripMenuItem1, Me.ContraccettivoToolStripMenuItem1, Me.IntegratoreToolStripMenuItem, Me.MalattiaAutoimmuneToolStripMenuItem, Me.TerapiaRiabilitativaToolStripMenuItem})
        Me.NuovoToolStripMenuItem1.Name = "NuovoToolStripMenuItem1"
        Me.NuovoToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.NuovoToolStripMenuItem1.Text = "Nuovo"
        '
        'PazienteToolStripMenuItem1
        '
        Me.PazienteToolStripMenuItem1.Name = "PazienteToolStripMenuItem1"
        Me.PazienteToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.PazienteToolStripMenuItem1.Text = "Paziente"
        '
        'VisitaToolStripMenuItem2
        '
        Me.VisitaToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimaVisitaToolStripMenuItem, Me.ControlloToolStripMenuItem})
        Me.VisitaToolStripMenuItem2.Name = "VisitaToolStripMenuItem2"
        Me.VisitaToolStripMenuItem2.Size = New System.Drawing.Size(189, 22)
        Me.VisitaToolStripMenuItem2.Text = "Visita"
        '
        'PrimaVisitaToolStripMenuItem
        '
        Me.PrimaVisitaToolStripMenuItem.Name = "PrimaVisitaToolStripMenuItem"
        Me.PrimaVisitaToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PrimaVisitaToolStripMenuItem.Text = "Prima visita"
        '
        'ControlloToolStripMenuItem
        '
        Me.ControlloToolStripMenuItem.Name = "ControlloToolStripMenuItem"
        Me.ControlloToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ControlloToolStripMenuItem.Text = "Controllo"
        '
        'FarmacoToolStripMenuItem1
        '
        Me.FarmacoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovoFarmacoToolStripMenuItem, Me.NuovaClasseToolStripMenuItem})
        Me.FarmacoToolStripMenuItem1.Name = "FarmacoToolStripMenuItem1"
        Me.FarmacoToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.FarmacoToolStripMenuItem1.Text = "Farmaco"
        '
        'NuovoFarmacoToolStripMenuItem
        '
        Me.NuovoFarmacoToolStripMenuItem.Name = "NuovoFarmacoToolStripMenuItem"
        Me.NuovoFarmacoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NuovoFarmacoToolStripMenuItem.Text = "Nuovo farmaco"
        '
        'NuovaClasseToolStripMenuItem
        '
        Me.NuovaClasseToolStripMenuItem.Name = "NuovaClasseToolStripMenuItem"
        Me.NuovaClasseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NuovaClasseToolStripMenuItem.Text = "Nuova classe"
        '
        'ContraccettivoToolStripMenuItem1
        '
        Me.ContraccettivoToolStripMenuItem1.Name = "ContraccettivoToolStripMenuItem1"
        Me.ContraccettivoToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.ContraccettivoToolStripMenuItem1.Text = "Contraccettivo"
        '
        'IntegratoreToolStripMenuItem
        '
        Me.IntegratoreToolStripMenuItem.Name = "IntegratoreToolStripMenuItem"
        Me.IntegratoreToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.IntegratoreToolStripMenuItem.Text = "Integratore"
        '
        'MalattiaAutoimmuneToolStripMenuItem
        '
        Me.MalattiaAutoimmuneToolStripMenuItem.Name = "MalattiaAutoimmuneToolStripMenuItem"
        Me.MalattiaAutoimmuneToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MalattiaAutoimmuneToolStripMenuItem.Text = "Malattia autoimmune"
        '
        'TerapiaRiabilitativaToolStripMenuItem
        '
        Me.TerapiaRiabilitativaToolStripMenuItem.Name = "TerapiaRiabilitativaToolStripMenuItem"
        Me.TerapiaRiabilitativaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.TerapiaRiabilitativaToolStripMenuItem.Text = "Terapia riabilitativa"
        '
        'InserisciToolStripMenuItem
        '
        Me.InserisciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnamnesiToolStripMenuItem, Me.VisitaToolStripMenuItem})
        Me.InserisciToolStripMenuItem.Name = "InserisciToolStripMenuItem"
        Me.InserisciToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.InserisciToolStripMenuItem.Text = "Inserisci"
        '
        'AnamnesiToolStripMenuItem
        '
        Me.AnamnesiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FamiliareToolStripMenuItem, Me.FisiologicaToolStripMenuItem, Me.PatologicaRemotaToolStripMenuItem})
        Me.AnamnesiToolStripMenuItem.Name = "AnamnesiToolStripMenuItem"
        Me.AnamnesiToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AnamnesiToolStripMenuItem.Text = "Anamnesi"
        '
        'FamiliareToolStripMenuItem
        '
        Me.FamiliareToolStripMenuItem.Name = "FamiliareToolStripMenuItem"
        Me.FamiliareToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FamiliareToolStripMenuItem.Text = "Familiare"
        '
        'FisiologicaToolStripMenuItem
        '
        Me.FisiologicaToolStripMenuItem.Name = "FisiologicaToolStripMenuItem"
        Me.FisiologicaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FisiologicaToolStripMenuItem.Text = "Fisiologica"
        '
        'PatologicaRemotaToolStripMenuItem
        '
        Me.PatologicaRemotaToolStripMenuItem.Name = "PatologicaRemotaToolStripMenuItem"
        Me.PatologicaRemotaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PatologicaRemotaToolStripMenuItem.Text = "Patologica remota"
        '
        'VisitaToolStripMenuItem
        '
        Me.VisitaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EsamiToolStripMenuItem, Me.SintomiToolStripMenuItem, Me.StoriaOstetricoginecologicaToolStripMenuItem, Me.TerapiaToolStripMenuItem, Me.UroGinecologicaToolStripMenuItem})
        Me.VisitaToolStripMenuItem.Name = "VisitaToolStripMenuItem"
        Me.VisitaToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.VisitaToolStripMenuItem.Text = "Visita"
        '
        'EsamiToolStripMenuItem
        '
        Me.EsamiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DNATestToolStripMenuItem, Me.PapTestToolStripMenuItem, Me.RMNToolStripMenuItem1, Me.TamponeVaginaleToolStripMenuItem, Me.UrinoculturaToolStripMenuItem})
        Me.EsamiToolStripMenuItem.Name = "EsamiToolStripMenuItem"
        Me.EsamiToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EsamiToolStripMenuItem.Text = "Esami"
        '
        'DNATestToolStripMenuItem
        '
        Me.DNATestToolStripMenuItem.Name = "DNATestToolStripMenuItem"
        Me.DNATestToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DNATestToolStripMenuItem.Text = "DNA test"
        '
        'PapTestToolStripMenuItem
        '
        Me.PapTestToolStripMenuItem.Name = "PapTestToolStripMenuItem"
        Me.PapTestToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PapTestToolStripMenuItem.Text = "Pap. test"
        '
        'RMNToolStripMenuItem1
        '
        Me.RMNToolStripMenuItem1.Name = "RMNToolStripMenuItem1"
        Me.RMNToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.RMNToolStripMenuItem1.Text = "RMN"
        '
        'TamponeVaginaleToolStripMenuItem
        '
        Me.TamponeVaginaleToolStripMenuItem.Name = "TamponeVaginaleToolStripMenuItem"
        Me.TamponeVaginaleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TamponeVaginaleToolStripMenuItem.Text = "Tampone vaginale"
        '
        'UrinoculturaToolStripMenuItem
        '
        Me.UrinoculturaToolStripMenuItem.Name = "UrinoculturaToolStripMenuItem"
        Me.UrinoculturaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UrinoculturaToolStripMenuItem.Text = "Urinocultura"
        '
        'SintomiToolStripMenuItem
        '
        Me.SintomiToolStripMenuItem.Name = "SintomiToolStripMenuItem"
        Me.SintomiToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.SintomiToolStripMenuItem.Text = "Sintomi"
        '
        'StoriaOstetricoginecologicaToolStripMenuItem
        '
        Me.StoriaOstetricoginecologicaToolStripMenuItem.Name = "StoriaOstetricoginecologicaToolStripMenuItem"
        Me.StoriaOstetricoginecologicaToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.StoriaOstetricoginecologicaToolStripMenuItem.Text = "Storia Ostetrico-ginecologica"
        '
        'TerapiaToolStripMenuItem
        '
        Me.TerapiaToolStripMenuItem.Name = "TerapiaToolStripMenuItem"
        Me.TerapiaToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.TerapiaToolStripMenuItem.Text = "Terapia"
        '
        'UroGinecologicaToolStripMenuItem
        '
        Me.UroGinecologicaToolStripMenuItem.Name = "UroGinecologicaToolStripMenuItem"
        Me.UroGinecologicaToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.UroGinecologicaToolStripMenuItem.Text = "Uro - ginecologica"
        '
        'CercaToolStripMenuItem
        '
        Me.CercaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PazienteToolStripMenuItem, Me.VisitaToolStripMenuItem1})
        Me.CercaToolStripMenuItem.Name = "CercaToolStripMenuItem"
        Me.CercaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.CercaToolStripMenuItem.Text = "Cerca"
        '
        'PazienteToolStripMenuItem
        '
        Me.PazienteToolStripMenuItem.Name = "PazienteToolStripMenuItem"
        Me.PazienteToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PazienteToolStripMenuItem.Text = "Paziente"
        '
        'VisitaToolStripMenuItem1
        '
        Me.VisitaToolStripMenuItem1.Name = "VisitaToolStripMenuItem1"
        Me.VisitaToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.VisitaToolStripMenuItem1.Text = "Visita"
        '
        'ImportaToolStripMenuItem
        '
        Me.ImportaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1})
        Me.ImportaToolStripMenuItem.Name = "ImportaToolStripMenuItem"
        Me.ImportaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ImportaToolStripMenuItem.Text = "Importa"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(92, 22)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SQLConnectionToolStripMenuItem})
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        '
        'SQLConnectionToolStripMenuItem
        '
        Me.SQLConnectionToolStripMenuItem.Name = "SQLConnectionToolStripMenuItem"
        Me.SQLConnectionToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SQLConnectionToolStripMenuItem.Text = "SQL Connection"
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 33)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 3
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(1280, 927)
        Me.TableLayoutPanelMain.TabIndex = 1
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelTitleBar.ColumnCount = 3
        Me.PanelTitleBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PanelTitleBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelTitleBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.PanelTitleBar.Controls.Add(Me.MenuStrip1, 1, 0)
        Me.PanelTitleBar.Controls.Add(Me.PictureBox1, 0, 0)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTitleBar.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.RowCount = 1
        Me.PanelTitleBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelTitleBar.Size = New System.Drawing.Size(1280, 30)
        Me.PanelTitleBar.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 960)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GynArchive"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InserisciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnamnesiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FamiliareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FisiologicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatologicaRemotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SintomiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UroGinecologicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerapiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PazienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisitaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents StoriaOstetricoginecologicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsamiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RMNToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DNATestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PapTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamponeVaginaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UrinoculturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuovoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PazienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VisitaToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PrimaVisitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FarmacoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuovoFarmacoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuovaClasseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerapiaRiabilitativaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SQLConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelTitleBar As TableLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContraccettivoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImportaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IntegratoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MalattiaAutoimmuneToolStripMenuItem As ToolStripMenuItem
End Class
