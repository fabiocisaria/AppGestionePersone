<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelezione
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelezione))
        Me.dgvSelezione = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.TableLayoutPanelSelezione = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSeleziona = New Syncfusion.WinForms.Controls.SfButton()
        Me.ButtonAnnulla = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitleBar = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dgvSelezione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelSelezione.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSelezione
        '
        Me.dgvSelezione.AccessibleName = "Table"
        Me.dgvSelezione.AllowEditing = False
        Me.dgvSelezione.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
        Me.dgvSelezione.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSelezione.Location = New System.Drawing.Point(3, 3)
        Me.dgvSelezione.Name = "dgvSelezione"
        Me.dgvSelezione.Size = New System.Drawing.Size(788, 368)
        Me.dgvSelezione.TabIndex = 3
        Me.dgvSelezione.Text = "SfDataGrid1"
        '
        'TableLayoutPanelSelezione
        '
        Me.TableLayoutPanelSelezione.ColumnCount = 1
        Me.TableLayoutPanelSelezione.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSelezione.Controls.Add(Me.PanelTitleBar, 0, 0)
        Me.TableLayoutPanelSelezione.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanelSelezione.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelSelezione.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSelezione.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelSelezione.Name = "TableLayoutPanelSelezione"
        Me.TableLayoutPanelSelezione.RowCount = 3
        Me.TableLayoutPanelSelezione.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelSelezione.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSelezione.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelSelezione.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanelSelezione.TabIndex = 1
        Me.TableLayoutPanelSelezione.Tag = "Selection"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonSeleziona, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonAnnulla, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 413)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(794, 34)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'ButtonSeleziona
        '
        Me.ButtonSeleziona.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonSeleziona.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonSeleziona.Location = New System.Drawing.Point(695, 3)
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
        Me.TableLayoutPanel2.Controls.Add(Me.dgvSelezione, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(794, 374)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelTitleBar.ColumnCount = 3
        Me.PanelTitleBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PanelTitleBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelTitleBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.PanelTitleBar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTitleBar.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelTitleBar.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.RowCount = 1
        Me.PanelTitleBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelTitleBar.Size = New System.Drawing.Size(794, 24)
        Me.PanelTitleBar.TabIndex = 3
        '
        'FormSelezione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanelSelezione)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelezione"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSelezione"
        CType(Me.dgvSelezione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelSelezione.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSelezione As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents TableLayoutPanelSelezione As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ButtonSeleziona As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents ButtonAnnulla As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PanelTitleBar As TableLayoutPanel
End Class
