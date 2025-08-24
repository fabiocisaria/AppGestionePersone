<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_CercaPaziente
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvSelezionePaziente = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSeleziona = New System.Windows.Forms.Button()
        Me.ButtonAnnulla = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxCodiceID = New System.Windows.Forms.TextBox()
        Me.LabelCodiceID = New System.Windows.Forms.Label()
        Me.TextBoxCognome = New System.Windows.Forms.TextBox()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonCercaPaziente = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvSelezionePaziente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvSelezionePaziente, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvSelezionePaziente
        '
        Me.dgvSelezionePaziente.AllowUserToAddRows = False
        Me.dgvSelezionePaziente.AllowUserToDeleteRows = False
        Me.dgvSelezionePaziente.AllowUserToOrderColumns = True
        Me.dgvSelezionePaziente.AllowUserToResizeRows = False
        Me.dgvSelezionePaziente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSelezionePaziente.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvSelezionePaziente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSelezionePaziente.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSelezionePaziente.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvSelezionePaziente.Location = New System.Drawing.Point(3, 106)
        Me.dgvSelezionePaziente.Name = "dgvSelezionePaziente"
        Me.dgvSelezionePaziente.ReadOnly = True
        Me.dgvSelezionePaziente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelezionePaziente.Size = New System.Drawing.Size(760, 352)
        Me.dgvSelezionePaziente.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonSeleziona, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonAnnulla, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 477)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(760, 36)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'ButtonSeleziona
        '
        Me.ButtonSeleziona.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonSeleziona.Location = New System.Drawing.Point(682, 6)
        Me.ButtonSeleziona.Name = "ButtonSeleziona"
        Me.ButtonSeleziona.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSeleziona.TabIndex = 3
        Me.ButtonSeleziona.Text = "Seleziona"
        Me.ButtonSeleziona.UseVisualStyleBackColor = True
        '
        'ButtonAnnulla
        '
        Me.ButtonAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonAnnulla.Location = New System.Drawing.Point(3, 6)
        Me.ButtonAnnulla.Name = "ButtonAnnulla"
        Me.ButtonAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAnnulla.TabIndex = 2
        Me.ButtonAnnulla.Text = "Annulla"
        Me.ButtonAnnulla.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 97)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxCodiceID, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelCodiceID, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxCognome, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelCognome, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(754, 52)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TextBoxCodiceID
        '
        Me.TextBoxCodiceID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxCodiceID.Location = New System.Drawing.Point(482, 16)
        Me.TextBoxCodiceID.Name = "TextBoxCodiceID"
        Me.TextBoxCodiceID.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxCodiceID.TabIndex = 6
        '
        'LabelCodiceID
        '
        Me.LabelCodiceID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelCodiceID.AutoSize = True
        Me.LabelCodiceID.Location = New System.Drawing.Point(358, 19)
        Me.LabelCodiceID.Name = "LabelCodiceID"
        Me.LabelCodiceID.Size = New System.Drawing.Size(102, 13)
        Me.LabelCodiceID.TabIndex = 5
        Me.LabelCodiceID.Text = "Codice identificativo"
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxCognome.Location = New System.Drawing.Point(79, 16)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(261, 20)
        Me.TextBoxCognome.TabIndex = 4
        '
        'LabelCognome
        '
        Me.LabelCognome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelCognome.AutoSize = True
        Me.LabelCognome.Location = New System.Drawing.Point(7, 19)
        Me.LabelCognome.Name = "LabelCognome"
        Me.LabelCognome.Size = New System.Drawing.Size(52, 13)
        Me.LabelCognome.TabIndex = 3
        Me.LabelCognome.Text = "Cognome"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonCercaPaziente, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 61)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(754, 33)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'ButtonCercaPaziente
        '
        Me.ButtonCercaPaziente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonCercaPaziente.Location = New System.Drawing.Point(676, 5)
        Me.ButtonCercaPaziente.Name = "ButtonCercaPaziente"
        Me.ButtonCercaPaziente.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCercaPaziente.TabIndex = 3
        Me.ButtonCercaPaziente.Text = "Cerca"
        Me.ButtonCercaPaziente.UseVisualStyleBackColor = True
        '
        'UC_CercaPaziente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_CercaPaziente"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvSelezionePaziente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents LabelCognome As Label
    Friend WithEvents TextBoxCognome As TextBox
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents TextBoxCodiceID As TextBox
    Friend WithEvents ButtonCercaPaziente As Button
    Friend WithEvents dgvSelezionePaziente As DataGridView
    Friend WithEvents ButtonAnnulla As Button
    Friend WithEvents ButtonSeleziona As Button
End Class
