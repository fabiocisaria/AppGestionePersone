<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AnamnesiFamiliareSelezione
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSeleziona = New Syncfusion.WinForms.Controls.SfButton()
        Me.ButtonAnnulla = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxParentela = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.ButtonAggiungi = New Syncfusion.WinForms.Controls.SfButton()
        Me.LabelParente = New System.Windows.Forms.Label()
        Me.dgvSelezioneParente = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ComboBoxParentela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelezioneParente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvSelezioneParente, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 1
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
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 54)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxParentela, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonAggiungi, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelParente, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(754, 48)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ComboBoxParentela
        '
        Me.ComboBoxParentela.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxParentela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxParentela.AutoCompleteSuggestDelay = 1
        Me.ComboBoxParentela.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxParentela.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxParentela.Location = New System.Drawing.Point(73, 13)
        Me.ComboBoxParentela.Name = "ComboBoxParentela"
        Me.ComboBoxParentela.Size = New System.Drawing.Size(203, 21)
        Me.ComboBoxParentela.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxParentela.TabIndex = 24
        Me.ComboBoxParentela.TabStop = False
        Me.ComboBoxParentela.Tag = "Find"
        '
        'ButtonAggiungi
        '
        Me.ButtonAggiungi.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonAggiungi.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonAggiungi.Location = New System.Drawing.Point(655, 10)
        Me.ButtonAggiungi.Name = "ButtonAggiungi"
        Me.ButtonAggiungi.Size = New System.Drawing.Size(96, 27)
        Me.ButtonAggiungi.TabIndex = 0
        Me.ButtonAggiungi.Tag = "OkButton"
        Me.ButtonAggiungi.Text = "Aggiungi"
        '
        'LabelParente
        '
        Me.LabelParente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelParente.AutoSize = True
        Me.LabelParente.Location = New System.Drawing.Point(9, 17)
        Me.LabelParente.Name = "LabelParente"
        Me.LabelParente.Size = New System.Drawing.Size(52, 13)
        Me.LabelParente.TabIndex = 3
        Me.LabelParente.Text = "Parentela"
        '
        'dgvSelezioneParente
        '
        Me.dgvSelezioneParente.AccessibleName = "Table"
        Me.dgvSelezioneParente.AllowEditing = False
        Me.dgvSelezioneParente.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
        Me.dgvSelezioneParente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSelezioneParente.Location = New System.Drawing.Point(3, 63)
        Me.dgvSelezioneParente.Name = "dgvSelezioneParente"
        Me.dgvSelezioneParente.Size = New System.Drawing.Size(760, 410)
        Me.dgvSelezioneParente.TabIndex = 3
        Me.dgvSelezioneParente.Text = "SfDataGrid1"
        '
        'UC_AnamnesiFamiliareSelezione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_AnamnesiFamiliareSelezione"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ComboBoxParentela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelezioneParente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ButtonSeleziona As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents ButtonAnnulla As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ButtonAggiungi As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents LabelParente As Label
    Friend WithEvents dgvSelezioneParente As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents ComboBoxParentela As Syncfusion.WinForms.ListView.SfComboBox
End Class
