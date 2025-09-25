<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_CercaPaziente
    Inherits System.Windows.Forms.UserControl
    'Inherits GradientUserControl

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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSeleziona = New Syncfusion.WinForms.Controls.SfButton()
        Me.ButtonAnnulla = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxCodiceID = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelCodiceID = New System.Windows.Forms.Label()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.TextBoxCognome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonCercaPaziente = New Syncfusion.WinForms.Controls.SfButton()
        Me.dgvSelezionePaziente = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.TextBoxCodiceID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxCognome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvSelezionePaziente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvSelezionePaziente, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonSeleziona, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonAnnulla, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 479)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(760, 34)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'ButtonSeleziona
        '
        Me.ButtonSeleziona.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonSeleziona.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonSeleziona.Location = New System.Drawing.Point(661, 3)
        Me.ButtonSeleziona.Name = "ButtonSeleziona"
        Me.ButtonSeleziona.Size = New System.Drawing.Size(96, 27)
        Me.ButtonSeleziona.TabIndex = 2
        Me.ButtonSeleziona.Tag = "SelectButton"
        Me.ButtonSeleziona.Text = "Seleziona"
        '
        'ButtonAnnulla
        '
        Me.ButtonAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonAnnulla.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonAnnulla.Location = New System.Drawing.Point(3, 3)
        Me.ButtonAnnulla.Name = "ButtonAnnulla"
        Me.ButtonAnnulla.Size = New System.Drawing.Size(96, 27)
        Me.ButtonAnnulla.TabIndex = 1
        Me.ButtonAnnulla.Tag = "CancelButton"
        Me.ButtonAnnulla.Text = "Annulla"
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 94)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxCodiceID, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelCodiceID, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelCognome, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxCognome, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(754, 48)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TextBoxCodiceID
        '
        Me.TextBoxCodiceID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxCodiceID.BeforeTouchSize = New System.Drawing.Size(190, 20)
        Me.TextBoxCodiceID.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxCodiceID.Location = New System.Drawing.Point(413, 14)
        Me.TextBoxCodiceID.Name = "TextBoxCodiceID"
        Me.TextBoxCodiceID.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxCodiceID.TabIndex = 8
        Me.TextBoxCodiceID.Tag = "Find"
        Me.TextBoxCodiceID.Text = "Codice identificativo"
        '
        'LabelCodiceID
        '
        Me.LabelCodiceID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelCodiceID.AutoSize = True
        Me.LabelCodiceID.Location = New System.Drawing.Point(299, 17)
        Me.LabelCodiceID.Name = "LabelCodiceID"
        Me.LabelCodiceID.Size = New System.Drawing.Size(102, 13)
        Me.LabelCodiceID.TabIndex = 5
        Me.LabelCodiceID.Text = "Codice identificativo"
        '
        'LabelCognome
        '
        Me.LabelCognome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelCognome.AutoSize = True
        Me.LabelCognome.Location = New System.Drawing.Point(9, 17)
        Me.LabelCognome.Name = "LabelCognome"
        Me.LabelCognome.Size = New System.Drawing.Size(52, 13)
        Me.LabelCognome.TabIndex = 3
        Me.LabelCognome.Text = "Cognome"
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxCognome.BeforeTouchSize = New System.Drawing.Size(190, 20)
        Me.TextBoxCognome.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxCognome.Location = New System.Drawing.Point(73, 14)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxCognome.TabIndex = 7
        Me.TextBoxCognome.Tag = "Find"
        Me.TextBoxCognome.Text = "Cognome"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonCercaPaziente, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 57)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(754, 34)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'ButtonCercaPaziente
        '
        Me.ButtonCercaPaziente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonCercaPaziente.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonCercaPaziente.Location = New System.Drawing.Point(655, 3)
        Me.ButtonCercaPaziente.Name = "ButtonCercaPaziente"
        Me.ButtonCercaPaziente.Size = New System.Drawing.Size(96, 27)
        Me.ButtonCercaPaziente.TabIndex = 0
        Me.ButtonCercaPaziente.Tag = "OkButton"
        Me.ButtonCercaPaziente.Text = "Cerca"
        '
        'dgvSelezionePaziente
        '
        Me.dgvSelezionePaziente.AccessibleName = "Table"
        Me.dgvSelezionePaziente.AllowEditing = False
        Me.dgvSelezionePaziente.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
        Me.dgvSelezionePaziente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSelezionePaziente.Location = New System.Drawing.Point(3, 103)
        Me.dgvSelezionePaziente.Name = "dgvSelezionePaziente"
        Me.dgvSelezionePaziente.Size = New System.Drawing.Size(760, 370)
        Me.dgvSelezionePaziente.TabIndex = 3
        Me.dgvSelezionePaziente.Text = "SfDataGrid1"
        '
        'UC_CercaPaziente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_CercaPaziente"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.TextBoxCodiceID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxCognome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgvSelezionePaziente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents LabelCognome As Label
    Friend WithEvents LabelCodiceID As Label
    Friend WithEvents ButtonCercaPaziente As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TextBoxCognome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxCodiceID As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents ButtonSeleziona As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents ButtonAnnulla As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents dgvSelezionePaziente As Syncfusion.WinForms.DataGrid.SfDataGrid
End Class
