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
        Me.GroupBoxFumo = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxQuantita = New System.Windows.Forms.ComboBox()
        Me.LabelTipoSigarette = New System.Windows.Forms.Label()
        Me.LabelQuantita = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelAllergie = New System.Windows.Forms.Label()
        Me.TextBoxAllergie = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelIntollerazne = New System.Windows.Forms.Label()
        Me.TextBoxIntolleranze = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelIdratazione = New System.Windows.Forms.Label()
        Me.ComboBoxIdratazione = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelAltezza = New System.Windows.Forms.Label()
        Me.TextBoxAltezza = New System.Windows.Forms.TextBox()
        Me.LabelPeso = New System.Windows.Forms.Label()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.LabelBMI = New System.Windows.Forms.Label()
        Me.TextBoxBMI = New System.Windows.Forms.TextBox()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelAnamnesiFisiologica.SuspendLayout()
        Me.GroupBoxFumo.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelAnamnesiFisiologica
        '
        Me.TableLayoutPanelAnamnesiFisiologica.ColumnCount = 1
        Me.TableLayoutPanelAnamnesiFisiologica.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.ButtonInserisci, 0, 5)
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.GroupBoxFumo, 0, 4)
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.TableLayoutPanel5, 0, 3)
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanelAnamnesiFisiologica.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanelAnamnesiFisiologica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAnamnesiFisiologica.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelAnamnesiFisiologica.Name = "TableLayoutPanelAnamnesiFisiologica"
        Me.TableLayoutPanelAnamnesiFisiologica.RowCount = 6
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelAnamnesiFisiologica.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelAnamnesiFisiologica.TabIndex = 12
        '
        'GroupBoxFumo
        '
        Me.GroupBoxFumo.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBoxFumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxFumo.Location = New System.Drawing.Point(3, 311)
        Me.GroupBoxFumo.Name = "GroupBoxFumo"
        Me.GroupBoxFumo.Size = New System.Drawing.Size(760, 148)
        Me.GroupBoxFumo.TabIndex = 7
        Me.GroupBoxFumo.TabStop = False
        Me.GroupBoxFumo.Text = "GroupBoxFumo"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxTipo, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxQuantita, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelTipoSigarette, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelQuantita, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(754, 129)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Tradizionale", "IQOS", "Elettronica"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(116, 86)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(141, 21)
        Me.ComboBoxTipo.TabIndex = 27
        '
        'ComboBoxQuantita
        '
        Me.ComboBoxQuantita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxQuantita.FormattingEnabled = True
        Me.ComboBoxQuantita.Items.AddRange(New Object() {"No", "< 5gg", "> 5gg"})
        Me.ComboBoxQuantita.Location = New System.Drawing.Point(116, 21)
        Me.ComboBoxQuantita.Name = "ComboBoxQuantita"
        Me.ComboBoxQuantita.Size = New System.Drawing.Size(141, 21)
        Me.ComboBoxQuantita.TabIndex = 6
        '
        'LabelTipoSigarette
        '
        Me.LabelTipoSigarette.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTipoSigarette.AutoSize = True
        Me.LabelTipoSigarette.Location = New System.Drawing.Point(3, 90)
        Me.LabelTipoSigarette.Name = "LabelTipoSigarette"
        Me.LabelTipoSigarette.Size = New System.Drawing.Size(71, 13)
        Me.LabelTipoSigarette.TabIndex = 26
        Me.LabelTipoSigarette.Text = "Tipo sigarette"
        '
        'LabelQuantita
        '
        Me.LabelQuantita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelQuantita.AutoSize = True
        Me.LabelQuantita.Location = New System.Drawing.Point(3, 25)
        Me.LabelQuantita.Name = "LabelQuantita"
        Me.LabelQuantita.Size = New System.Drawing.Size(47, 13)
        Me.LabelQuantita.TabIndex = 24
        Me.LabelQuantita.Text = "Quantità"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.LabelAllergie, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxAllergie, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 234)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(760, 71)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'LabelAllergie
        '
        Me.LabelAllergie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAllergie.AutoSize = True
        Me.LabelAllergie.Location = New System.Drawing.Point(3, 29)
        Me.LabelAllergie.Name = "LabelAllergie"
        Me.LabelAllergie.Size = New System.Drawing.Size(41, 13)
        Me.LabelAllergie.TabIndex = 10
        Me.LabelAllergie.Text = "Allergie"
        '
        'TextBoxAllergie
        '
        Me.TextBoxAllergie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxAllergie.Location = New System.Drawing.Point(132, 25)
        Me.TextBoxAllergie.Name = "TextBoxAllergie"
        Me.TextBoxAllergie.Size = New System.Drawing.Size(419, 20)
        Me.TextBoxAllergie.TabIndex = 5
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.LabelIntollerazne, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxIntolleranze, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 157)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(760, 71)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'LabelIntollerazne
        '
        Me.LabelIntollerazne.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIntollerazne.AutoSize = True
        Me.LabelIntollerazne.Location = New System.Drawing.Point(3, 29)
        Me.LabelIntollerazne.Name = "LabelIntollerazne"
        Me.LabelIntollerazne.Size = New System.Drawing.Size(61, 13)
        Me.LabelIntollerazne.TabIndex = 8
        Me.LabelIntollerazne.Text = "Intolleranze"
        '
        'TextBoxIntolleranze
        '
        Me.TextBoxIntolleranze.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxIntolleranze.Location = New System.Drawing.Point(132, 25)
        Me.TextBoxIntolleranze.Name = "TextBoxIntolleranze"
        Me.TextBoxIntolleranze.Size = New System.Drawing.Size(419, 20)
        Me.TextBoxIntolleranze.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LabelIdratazione, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxIdratazione, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 80)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(760, 71)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'LabelIdratazione
        '
        Me.LabelIdratazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIdratazione.AutoSize = True
        Me.LabelIdratazione.Location = New System.Drawing.Point(3, 29)
        Me.LabelIdratazione.Name = "LabelIdratazione"
        Me.LabelIdratazione.Size = New System.Drawing.Size(59, 13)
        Me.LabelIdratazione.TabIndex = 6
        Me.LabelIdratazione.Text = "Idratazione"
        '
        'ComboBoxIdratazione
        '
        Me.ComboBoxIdratazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxIdratazione.FormattingEnabled = True
        Me.ComboBoxIdratazione.Items.AddRange(New Object() {"< 1.0 l", "1.0 - 1.5 l", "1.5 - 2.0 l", "2.0 - 3.0 l", "> 3.0 l"})
        Me.ComboBoxIdratazione.Location = New System.Drawing.Point(132, 25)
        Me.ComboBoxIdratazione.Name = "ComboBoxIdratazione"
        Me.ComboBoxIdratazione.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxIdratazione.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelAltezza, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxAltezza, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPeso, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxPeso, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelBMI, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxBMI, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 71)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'LabelAltezza
        '
        Me.LabelAltezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAltezza.AutoSize = True
        Me.LabelAltezza.Location = New System.Drawing.Point(3, 29)
        Me.LabelAltezza.Name = "LabelAltezza"
        Me.LabelAltezza.Size = New System.Drawing.Size(64, 13)
        Me.LabelAltezza.TabIndex = 0
        Me.LabelAltezza.Text = "Altezza (cm)"
        '
        'TextBoxAltezza
        '
        Me.TextBoxAltezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxAltezza.Location = New System.Drawing.Point(109, 25)
        Me.TextBoxAltezza.Name = "TextBoxAltezza"
        Me.TextBoxAltezza.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxAltezza.TabIndex = 1
        '
        'LabelPeso
        '
        Me.LabelPeso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPeso.AutoSize = True
        Me.LabelPeso.Location = New System.Drawing.Point(245, 29)
        Me.LabelPeso.Name = "LabelPeso"
        Me.LabelPeso.Size = New System.Drawing.Size(54, 13)
        Me.LabelPeso.TabIndex = 4
        Me.LabelPeso.Text = "Peso (km)"
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxPeso.Location = New System.Drawing.Point(351, 25)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxPeso.TabIndex = 2
        '
        'LabelBMI
        '
        Me.LabelBMI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelBMI.AutoSize = True
        Me.LabelBMI.Location = New System.Drawing.Point(487, 29)
        Me.LabelBMI.Name = "LabelBMI"
        Me.LabelBMI.Size = New System.Drawing.Size(26, 13)
        Me.LabelBMI.TabIndex = 2
        Me.LabelBMI.Text = "BMI"
        '
        'TextBoxBMI
        '
        Me.TextBoxBMI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxBMI.Location = New System.Drawing.Point(555, 25)
        Me.TextBoxBMI.Name = "TextBoxBMI"
        Me.TextBoxBMI.ReadOnly = True
        Me.TextBoxBMI.ShortcutsEnabled = False
        Me.TextBoxBMI.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxBMI.TabIndex = 0
        Me.TextBoxBMI.TabStop = False
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 475)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 3
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
        Me.GroupBoxFumo.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelAnamnesiFisiologica As TableLayoutPanel
    Friend WithEvents GroupBoxFumo As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents ComboBoxQuantita As ComboBox
    Friend WithEvents LabelTipoSigarette As Label
    Friend WithEvents LabelQuantita As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents LabelAllergie As Label
    Friend WithEvents TextBoxAllergie As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents LabelIntollerazne As Label
    Friend WithEvents TextBoxIntolleranze As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LabelIdratazione As Label
    Friend WithEvents ComboBoxIdratazione As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelAltezza As Label
    Friend WithEvents TextBoxAltezza As TextBox
    Friend WithEvents LabelPeso As Label
    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents LabelBMI As Label
    Friend WithEvents TextBoxBMI As TextBox
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
