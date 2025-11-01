<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_AnamnesiFamiliare
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelAnmFam = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanelPatologie = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelPatologie = New System.Windows.Forms.Label()
        Me.SfButtonAggiungiPatologie = New Syncfusion.WinForms.Controls.SfButton()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanelAnmFam.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelAnmFam, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 15
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanelAnmFam
        '
        Me.TableLayoutPanelAnmFam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelAnmFam.ColumnCount = 1
        Me.TableLayoutPanelAnmFam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnmFam.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanelAnmFam.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelAnmFam.Location = New System.Drawing.Point(40, 27)
        Me.TableLayoutPanelAnmFam.Name = "TableLayoutPanelAnmFam"
        Me.TableLayoutPanelAnmFam.RowCount = 2
        Me.TableLayoutPanelAnmFam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelAnmFam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnmFam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelAnmFam.Size = New System.Drawing.Size(685, 421)
        Me.TableLayoutPanelAnmFam.TabIndex = 20
        Me.TableLayoutPanelAnmFam.Tag = "PrimaryPanel"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanelPatologie, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(23, 48)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(638, 354)
        Me.TableLayoutPanel6.TabIndex = 31
        '
        'FlowLayoutPanelPatologie
        '
        Me.FlowLayoutPanelPatologie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelPatologie.Location = New System.Drawing.Point(3, 33)
        Me.FlowLayoutPanelPatologie.Name = "FlowLayoutPanelPatologie"
        Me.FlowLayoutPanelPatologie.Size = New System.Drawing.Size(632, 318)
        Me.FlowLayoutPanelPatologie.TabIndex = 11
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.LabelPatologie, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.SfButtonAggiungiPatologie, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(632, 24)
        Me.TableLayoutPanel8.TabIndex = 10
        '
        'LabelPatologie
        '
        Me.LabelPatologie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelPatologie.AutoSize = True
        Me.LabelPatologie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPatologie.Location = New System.Drawing.Point(297, 3)
        Me.LabelPatologie.Name = "LabelPatologie"
        Me.LabelPatologie.Size = New System.Drawing.Size(67, 17)
        Me.LabelPatologie.TabIndex = 1
        Me.LabelPatologie.Text = "Patologie"
        '
        'SfButtonAggiungiPatologie
        '
        Me.SfButtonAggiungiPatologie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SfButtonAggiungiPatologie.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SfButtonAggiungiPatologie.Location = New System.Drawing.Point(3, 3)
        Me.SfButtonAggiungiPatologie.Name = "SfButtonAggiungiPatologie"
        Me.SfButtonAggiungiPatologie.Size = New System.Drawing.Size(24, 18)
        Me.SfButtonAggiungiPatologie.TabIndex = 4
        Me.SfButtonAggiungiPatologie.Tag = "AddButton"
        Me.SfButtonAggiungiPatologie.Text = "+"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(94, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Anamnesi familiare"
        '
        'UC_AnamnesiFamiliare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_AnamnesiFamiliare"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanelAnmFam.ResumeLayout(False)
        Me.TableLayoutPanelAnmFam.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TableLayoutPanelAnmFam As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanelPatologie As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents LabelPatologie As Label
    Friend WithEvents SfButtonAggiungiPatologie As Syncfusion.WinForms.Controls.SfButton
End Class
