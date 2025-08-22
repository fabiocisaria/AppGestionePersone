<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnamnesiFisiologicaRicPaziente
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
        Me.GroupBoxRicercaPaziente = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.ButtonCercaPaziente = New System.Windows.Forms.Button()
        Me.LabelIDAnagrafica = New System.Windows.Forms.Label()
        Me.TextBoxCognome = New System.Windows.Forms.TextBox()
        Me.LabelCodiceID = New System.Windows.Forms.Label()
        Me.TextBoxCodiceID = New System.Windows.Forms.TextBox()
        Me.GroupBoxAnamnesiFisiologica = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.LabelBMI = New System.Windows.Forms.Label()
        Me.TextBoxAltezza = New System.Windows.Forms.TextBox()
        Me.LabelPeso = New System.Windows.Forms.Label()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.TextBoxBMI = New System.Windows.Forms.TextBox()
        Me.GroupBoxFumo = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxQuantita = New System.Windows.Forms.ComboBox()
        Me.LabelTipoSigarette = New System.Windows.Forms.Label()
        Me.LabelQuantita = New System.Windows.Forms.Label()
        Me.ButtonSalva = New System.Windows.Forms.Button()
        Me.TableLayoutPanelAnmnFisio = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxRicercaPaziente.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBoxAnamnesiFisiologica.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBoxFumo.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanelAnmnFisio.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRicercaPaziente
        '
        Me.GroupBoxRicercaPaziente.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBoxRicercaPaziente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxRicercaPaziente.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxRicercaPaziente.Name = "GroupBoxRicercaPaziente"
        Me.GroupBoxRicercaPaziente.Size = New System.Drawing.Size(541, 116)
        Me.GroupBoxRicercaPaziente.TabIndex = 1
        Me.GroupBoxRicercaPaziente.TabStop = False
        Me.GroupBoxRicercaPaziente.Text = "Ricerca paziente"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.LabelCognome, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.ButtonCercaPaziente, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.LabelIDAnagrafica, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBoxCognome, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.LabelCodiceID, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBoxCodiceID, 1, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(535, 97)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'LabelCognome
        '
        Me.LabelCognome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCognome.AutoSize = True
        Me.LabelCognome.Location = New System.Drawing.Point(3, 9)
        Me.LabelCognome.Name = "LabelCognome"
        Me.LabelCognome.Size = New System.Drawing.Size(52, 13)
        Me.LabelCognome.TabIndex = 2
        Me.LabelCognome.Text = "Cognome"
        '
        'ButtonCercaPaziente
        '
        Me.ButtonCercaPaziente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonCercaPaziente.Location = New System.Drawing.Point(457, 69)
        Me.ButtonCercaPaziente.Name = "ButtonCercaPaziente"
        Me.ButtonCercaPaziente.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCercaPaziente.TabIndex = 2
        Me.ButtonCercaPaziente.Text = "Cerca"
        Me.ButtonCercaPaziente.UseVisualStyleBackColor = True
        '
        'LabelIDAnagrafica
        '
        Me.LabelIDAnagrafica.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIDAnagrafica.AutoSize = True
        Me.LabelIDAnagrafica.Location = New System.Drawing.Point(3, 74)
        Me.LabelIDAnagrafica.Name = "LabelIDAnagrafica"
        Me.LabelIDAnagrafica.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDAnagrafica.TabIndex = 1
        Me.LabelIDAnagrafica.Visible = False
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxCognome.Location = New System.Drawing.Point(126, 6)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(403, 20)
        Me.TextBoxCognome.TabIndex = 0
        '
        'LabelCodiceID
        '
        Me.LabelCodiceID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCodiceID.AutoSize = True
        Me.LabelCodiceID.Location = New System.Drawing.Point(3, 41)
        Me.LabelCodiceID.Name = "LabelCodiceID"
        Me.LabelCodiceID.Size = New System.Drawing.Size(102, 13)
        Me.LabelCodiceID.TabIndex = 2
        Me.LabelCodiceID.Text = "Codice identificativo"
        '
        'TextBoxCodiceID
        '
        Me.TextBoxCodiceID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxCodiceID.Location = New System.Drawing.Point(126, 38)
        Me.TextBoxCodiceID.Name = "TextBoxCodiceID"
        Me.TextBoxCodiceID.Size = New System.Drawing.Size(403, 20)
        Me.TextBoxCodiceID.TabIndex = 1
        '
        'GroupBoxAnamnesiFisiologica
        '
        Me.GroupBoxAnamnesiFisiologica.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBoxAnamnesiFisiologica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxAnamnesiFisiologica.Location = New System.Drawing.Point(3, 125)
        Me.GroupBoxAnamnesiFisiologica.Name = "GroupBoxAnamnesiFisiologica"
        Me.GroupBoxAnamnesiFisiologica.Size = New System.Drawing.Size(541, 289)
        Me.GroupBoxAnamnesiFisiologica.TabIndex = 2
        Me.GroupBoxAnamnesiFisiologica.TabStop = False
        Me.GroupBoxAnamnesiFisiologica.Text = "Anamnesi fisiologica"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxFumo, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(535, 270)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.LabelAllergie, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxAllergie, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 132)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(529, 37)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'LabelAllergie
        '
        Me.LabelAllergie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAllergie.AutoSize = True
        Me.LabelAllergie.Location = New System.Drawing.Point(3, 12)
        Me.LabelAllergie.Name = "LabelAllergie"
        Me.LabelAllergie.Size = New System.Drawing.Size(41, 13)
        Me.LabelAllergie.TabIndex = 25
        Me.LabelAllergie.Text = "Allergie"
        '
        'TextBoxAllergie
        '
        Me.TextBoxAllergie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxAllergie.Location = New System.Drawing.Point(82, 8)
        Me.TextBoxAllergie.Name = "TextBoxAllergie"
        Me.TextBoxAllergie.Size = New System.Drawing.Size(434, 20)
        Me.TextBoxAllergie.TabIndex = 7
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.LabelIntollerazne, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxIntolleranze, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 89)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(529, 37)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'LabelIntollerazne
        '
        Me.LabelIntollerazne.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIntollerazne.AutoSize = True
        Me.LabelIntollerazne.Location = New System.Drawing.Point(3, 12)
        Me.LabelIntollerazne.Name = "LabelIntollerazne"
        Me.LabelIntollerazne.Size = New System.Drawing.Size(61, 13)
        Me.LabelIntollerazne.TabIndex = 24
        Me.LabelIntollerazne.Text = "Intolleranze"
        '
        'TextBoxIntolleranze
        '
        Me.TextBoxIntolleranze.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxIntolleranze.Location = New System.Drawing.Point(82, 8)
        Me.TextBoxIntolleranze.Name = "TextBoxIntolleranze"
        Me.TextBoxIntolleranze.Size = New System.Drawing.Size(434, 20)
        Me.TextBoxIntolleranze.TabIndex = 6
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LabelIdratazione, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxIdratazione, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 46)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(529, 37)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'LabelIdratazione
        '
        Me.LabelIdratazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelIdratazione.AutoSize = True
        Me.LabelIdratazione.Location = New System.Drawing.Point(3, 12)
        Me.LabelIdratazione.Name = "LabelIdratazione"
        Me.LabelIdratazione.Size = New System.Drawing.Size(59, 13)
        Me.LabelIdratazione.TabIndex = 23
        Me.LabelIdratazione.Text = "Idratazione"
        '
        'ComboBoxIdratazione
        '
        Me.ComboBoxIdratazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxIdratazione.FormattingEnabled = True
        Me.ComboBoxIdratazione.Items.AddRange(New Object() {"< 1.0 l", "1.0 - 1.5 l", "1.5 - 2.0 l", "2.0 - 3.0 l", "> 3.0 l"})
        Me.ComboBoxIdratazione.Location = New System.Drawing.Point(82, 8)
        Me.ComboBoxIdratazione.Name = "ComboBoxIdratazione"
        Me.ComboBoxIdratazione.Size = New System.Drawing.Size(141, 21)
        Me.ComboBoxIdratazione.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.7199!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.71988!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.72886!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72815!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.000875!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.10234!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelAltezza, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelBMI, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxAltezza, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPeso, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxPeso, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxBMI, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(529, 37)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'LabelAltezza
        '
        Me.LabelAltezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAltezza.AutoSize = True
        Me.LabelAltezza.Location = New System.Drawing.Point(3, 12)
        Me.LabelAltezza.Name = "LabelAltezza"
        Me.LabelAltezza.Size = New System.Drawing.Size(64, 13)
        Me.LabelAltezza.TabIndex = 16
        Me.LabelAltezza.Text = "Altezza (cm)"
        '
        'LabelBMI
        '
        Me.LabelBMI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelBMI.AutoSize = True
        Me.LabelBMI.Location = New System.Drawing.Point(355, 12)
        Me.LabelBMI.Name = "LabelBMI"
        Me.LabelBMI.Size = New System.Drawing.Size(26, 13)
        Me.LabelBMI.TabIndex = 27
        Me.LabelBMI.Text = "BMI"
        '
        'TextBoxAltezza
        '
        Me.TextBoxAltezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxAltezza.Location = New System.Drawing.Point(80, 8)
        Me.TextBoxAltezza.Name = "TextBoxAltezza"
        Me.TextBoxAltezza.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxAltezza.TabIndex = 3
        '
        'LabelPeso
        '
        Me.LabelPeso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPeso.AutoSize = True
        Me.LabelPeso.Location = New System.Drawing.Point(179, 12)
        Me.LabelPeso.Name = "LabelPeso"
        Me.LabelPeso.Size = New System.Drawing.Size(54, 13)
        Me.LabelPeso.TabIndex = 21
        Me.LabelPeso.Text = "Peso (km)"
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxPeso.Location = New System.Drawing.Point(246, 8)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxPeso.TabIndex = 4
        '
        'TextBoxBMI
        '
        Me.TextBoxBMI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxBMI.Location = New System.Drawing.Point(402, 8)
        Me.TextBoxBMI.Name = "TextBoxBMI"
        Me.TextBoxBMI.ReadOnly = True
        Me.TextBoxBMI.ShortcutsEnabled = False
        Me.TextBoxBMI.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxBMI.TabIndex = 15
        Me.TextBoxBMI.TabStop = False
        '
        'GroupBoxFumo
        '
        Me.GroupBoxFumo.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBoxFumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxFumo.Location = New System.Drawing.Point(3, 175)
        Me.GroupBoxFumo.Name = "GroupBoxFumo"
        Me.GroupBoxFumo.Size = New System.Drawing.Size(529, 92)
        Me.GroupBoxFumo.TabIndex = 4
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
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(523, 73)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Tradizionale", "IQOS", "Elettronica"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(81, 44)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(141, 21)
        Me.ComboBoxTipo.TabIndex = 27
        '
        'ComboBoxQuantita
        '
        Me.ComboBoxQuantita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxQuantita.FormattingEnabled = True
        Me.ComboBoxQuantita.Items.AddRange(New Object() {"No", "< 5gg", "> 5gg"})
        Me.ComboBoxQuantita.Location = New System.Drawing.Point(81, 7)
        Me.ComboBoxQuantita.Name = "ComboBoxQuantita"
        Me.ComboBoxQuantita.Size = New System.Drawing.Size(141, 21)
        Me.ComboBoxQuantita.TabIndex = 6
        '
        'LabelTipoSigarette
        '
        Me.LabelTipoSigarette.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTipoSigarette.AutoSize = True
        Me.LabelTipoSigarette.Location = New System.Drawing.Point(3, 48)
        Me.LabelTipoSigarette.Name = "LabelTipoSigarette"
        Me.LabelTipoSigarette.Size = New System.Drawing.Size(71, 13)
        Me.LabelTipoSigarette.TabIndex = 26
        Me.LabelTipoSigarette.Text = "Tipo sigarette"
        '
        'LabelQuantita
        '
        Me.LabelQuantita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelQuantita.AutoSize = True
        Me.LabelQuantita.Location = New System.Drawing.Point(3, 11)
        Me.LabelQuantita.Name = "LabelQuantita"
        Me.LabelQuantita.Size = New System.Drawing.Size(47, 13)
        Me.LabelQuantita.TabIndex = 24
        Me.LabelQuantita.Text = "Quantità"
        '
        'ButtonSalva
        '
        Me.ButtonSalva.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonSalva.Location = New System.Drawing.Point(469, 424)
        Me.ButtonSalva.Name = "ButtonSalva"
        Me.ButtonSalva.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalva.TabIndex = 8
        Me.ButtonSalva.Text = "Salva"
        Me.ButtonSalva.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelAnmnFisio
        '
        Me.TableLayoutPanelAnmnFisio.ColumnCount = 1
        Me.TableLayoutPanelAnmnFisio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnmnFisio.Controls.Add(Me.GroupBoxRicercaPaziente, 0, 0)
        Me.TableLayoutPanelAnmnFisio.Controls.Add(Me.GroupBoxAnamnesiFisiologica, 0, 1)
        Me.TableLayoutPanelAnmnFisio.Controls.Add(Me.ButtonSalva, 0, 2)
        Me.TableLayoutPanelAnmnFisio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAnmnFisio.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelAnmnFisio.Name = "TableLayoutPanelAnmnFisio"
        Me.TableLayoutPanelAnmnFisio.RowCount = 3
        Me.TableLayoutPanelAnmnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.0!))
        Me.TableLayoutPanelAnmnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanelAnmnFisio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanelAnmnFisio.Size = New System.Drawing.Size(547, 455)
        Me.TableLayoutPanelAnmnFisio.TabIndex = 3
        '
        'FormAnamnesiFisiologicaRicPaziente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 455)
        Me.Controls.Add(Me.TableLayoutPanelAnmnFisio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormAnamnesiFisiologicaRicPaziente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anamnesi fisiologica"
        Me.GroupBoxRicercaPaziente.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.GroupBoxAnamnesiFisiologica.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBoxFumo.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanelAnmnFisio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxRicercaPaziente As GroupBox
    Friend WithEvents LabelIDAnagrafica As Label
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents LabelCognome As Label
    Friend WithEvents ButtonCercaPaziente As Button
    Friend WithEvents TextBoxCodiceID As TextBox
    Friend WithEvents TextBoxCognome As TextBox
    Friend WithEvents GroupBoxAnamnesiFisiologica As GroupBox
    Friend WithEvents ComboBoxIdratazione As ComboBox
    Friend WithEvents ButtonSalva As Button
    Friend WithEvents TextBoxAllergie As TextBox
    Friend WithEvents LabelAllergie As Label
    Friend WithEvents TextBoxIntolleranze As TextBox
    Friend WithEvents LabelIntollerazne As Label
    Friend WithEvents LabelIdratazione As Label
    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents LabelPeso As Label
    Friend WithEvents TextBoxBMI As TextBox
    Friend WithEvents TextBoxAltezza As TextBox
    Friend WithEvents LabelAltezza As Label
    Friend WithEvents LabelBMI As Label
    Friend WithEvents TableLayoutPanelAnmnFisio As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBoxFumo As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents ComboBoxQuantita As ComboBox
    Friend WithEvents LabelTipoSigarette As Label
    Friend WithEvents LabelQuantita As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
End Class
