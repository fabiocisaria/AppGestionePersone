<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_FileImportazione
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
        Me.dgvAnteprima = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelImport = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonImporta = New Syncfusion.WinForms.Controls.SfButton()
        Me.ButtonAnnulla = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSfoglia = New Syncfusion.WinForms.Controls.SfButton()
        Me.LabelFile = New System.Windows.Forms.Label()
        Me.TextBoxNomeFile = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.SfButtonCarica = New Syncfusion.WinForms.Controls.SfButton()
        Me.ComboBoxTabelle = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.LabelTabella = New System.Windows.Forms.Label()
        CType(Me.dgvAnteprima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanelImport.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.TextBoxNomeFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.ComboBoxTabelle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAnteprima
        '
        Me.dgvAnteprima.AccessibleName = "Table"
        Me.dgvAnteprima.AllowEditing = False
        Me.dgvAnteprima.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
        Me.dgvAnteprima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAnteprima.Location = New System.Drawing.Point(3, 83)
        Me.dgvAnteprima.Name = "dgvAnteprima"
        Me.dgvAnteprima.Size = New System.Drawing.Size(710, 390)
        Me.dgvAnteprima.TabIndex = 3
        Me.dgvAnteprima.Text = "SfDataGrid1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelImport, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvAnteprima, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(716, 516)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanelImport
        '
        Me.TableLayoutPanelImport.ColumnCount = 2
        Me.TableLayoutPanelImport.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelImport.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelImport.Controls.Add(Me.ButtonImporta, 1, 0)
        Me.TableLayoutPanelImport.Controls.Add(Me.ButtonAnnulla, 0, 0)
        Me.TableLayoutPanelImport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelImport.Location = New System.Drawing.Point(3, 479)
        Me.TableLayoutPanelImport.Name = "TableLayoutPanelImport"
        Me.TableLayoutPanelImport.RowCount = 1
        Me.TableLayoutPanelImport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelImport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelImport.Size = New System.Drawing.Size(710, 34)
        Me.TableLayoutPanelImport.TabIndex = 2
        '
        'ButtonImporta
        '
        Me.ButtonImporta.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonImporta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonImporta.Location = New System.Drawing.Point(611, 3)
        Me.ButtonImporta.Name = "ButtonImporta"
        Me.ButtonImporta.Size = New System.Drawing.Size(96, 27)
        Me.ButtonImporta.TabIndex = 2
        Me.ButtonImporta.Tag = "SelectButton"
        Me.ButtonImporta.Text = "Importa"
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(710, 74)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonSfoglia, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelFile, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxNomeFile, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(704, 34)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ButtonSfoglia
        '
        Me.ButtonSfoglia.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonSfoglia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonSfoglia.Location = New System.Drawing.Point(605, 3)
        Me.ButtonSfoglia.Name = "ButtonSfoglia"
        Me.ButtonSfoglia.Size = New System.Drawing.Size(96, 27)
        Me.ButtonSfoglia.TabIndex = 0
        Me.ButtonSfoglia.Tag = "OkButton"
        Me.ButtonSfoglia.Text = "Sfoglia"
        '
        'LabelFile
        '
        Me.LabelFile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelFile.AutoSize = True
        Me.LabelFile.Location = New System.Drawing.Point(3, 10)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(79, 13)
        Me.LabelFile.TabIndex = 3
        Me.LabelFile.Text = "File selezionato"
        '
        'TextBoxNomeFile
        '
        Me.TextBoxNomeFile.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomeFile.BeforeTouchSize = New System.Drawing.Size(468, 20)
        Me.TextBoxNomeFile.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomeFile.Location = New System.Drawing.Point(123, 7)
        Me.TextBoxNomeFile.Name = "TextBoxNomeFile"
        Me.TextBoxNomeFile.Size = New System.Drawing.Size(468, 20)
        Me.TextBoxNomeFile.TabIndex = 7
        Me.TextBoxNomeFile.Tag = "Find"
        Me.TextBoxNomeFile.Text = "Seleziona un file"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.SfButtonCarica, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBoxTabelle, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelTabella, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 43)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(704, 34)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'SfButtonCarica
        '
        Me.SfButtonCarica.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SfButtonCarica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SfButtonCarica.Location = New System.Drawing.Point(605, 3)
        Me.SfButtonCarica.Name = "SfButtonCarica"
        Me.SfButtonCarica.Size = New System.Drawing.Size(96, 27)
        Me.SfButtonCarica.TabIndex = 13
        Me.SfButtonCarica.Tag = "OkButton"
        Me.SfButtonCarica.Text = "Carica"
        '
        'ComboBoxTabelle
        '
        Me.ComboBoxTabelle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxTabelle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxTabelle.AutoCompleteSuggestDelay = 1
        Me.ComboBoxTabelle.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxTabelle.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
        Me.ComboBoxTabelle.Location = New System.Drawing.Point(123, 6)
        Me.ComboBoxTabelle.Name = "ComboBoxTabelle"
        Me.ComboBoxTabelle.Size = New System.Drawing.Size(332, 21)
        Me.ComboBoxTabelle.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxTabelle.TabIndex = 12
        Me.ComboBoxTabelle.Tag = "Find"
        '
        'LabelTabella
        '
        Me.LabelTabella.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTabella.AutoSize = True
        Me.LabelTabella.Location = New System.Drawing.Point(3, 10)
        Me.LabelTabella.Name = "LabelTabella"
        Me.LabelTabella.Size = New System.Drawing.Size(104, 13)
        Me.LabelTabella.TabIndex = 5
        Me.LabelTabella.Text = "Tabella destinazione"
        '
        'UC_FileImportazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_FileImportazione"
        Me.Size = New System.Drawing.Size(716, 516)
        CType(Me.dgvAnteprima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanelImport.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.TextBoxNomeFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.ComboBoxTabelle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAnteprima As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanelImport As TableLayoutPanel
    Friend WithEvents ButtonImporta As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents ButtonAnnulla As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LabelTabella As Label
    Friend WithEvents LabelFile As Label
    Friend WithEvents TextBoxNomeFile As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ButtonSfoglia As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents ComboBoxTabelle As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents SfButtonCarica As Syncfusion.WinForms.Controls.SfButton
End Class
