<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_CercaVisita
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
        Me.dgvSelezioneVisita = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSeleziona = New Syncfusion.WinForms.Controls.SfButton()
        Me.ButtonAnnulla = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTipoVisita = New System.Windows.Forms.Label()
        Me.ComboBoxTipoVisita = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.LabelDataVisita = New System.Windows.Forms.Label()
        Me.DateTimePickerDataVisita = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonCercaVisita = New Syncfusion.WinForms.Controls.SfButton()
        CType(Me.dgvSelezioneVisita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ComboBoxTipoVisita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSelezioneVisita
        '
        Me.dgvSelezioneVisita.AccessibleName = "Table"
        Me.dgvSelezioneVisita.AllowEditing = False
        Me.dgvSelezioneVisita.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
        Me.dgvSelezioneVisita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSelezioneVisita.Location = New System.Drawing.Point(3, 103)
        Me.dgvSelezioneVisita.Name = "dgvSelezioneVisita"
        Me.dgvSelezioneVisita.Size = New System.Drawing.Size(760, 370)
        Me.dgvSelezioneVisita.TabIndex = 3
        Me.dgvSelezioneVisita.Text = "SfDataGrid1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvSelezioneVisita, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
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
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LabelTipoVisita, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxTipoVisita, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelDataVisita, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DateTimePickerDataVisita, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(754, 48)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'LabelTipoVisita
        '
        Me.LabelTipoVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTipoVisita.AutoSize = True
        Me.LabelTipoVisita.Location = New System.Drawing.Point(12, 17)
        Me.LabelTipoVisita.Name = "LabelTipoVisita"
        Me.LabelTipoVisita.Size = New System.Drawing.Size(55, 13)
        Me.LabelTipoVisita.TabIndex = 3
        Me.LabelTipoVisita.Text = "Tipo visita"
        '
        'ComboBoxTipoVisita
        '
        Me.ComboBoxTipoVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxTipoVisita.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxTipoVisita.AutoCompleteSuggestDelay = 1
        Me.ComboBoxTipoVisita.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxTipoVisita.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
        Me.ComboBoxTipoVisita.Location = New System.Drawing.Point(83, 13)
        Me.ComboBoxTipoVisita.Name = "ComboBoxTipoVisita"
        Me.ComboBoxTipoVisita.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTipoVisita.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxTipoVisita.TabIndex = 11
        Me.ComboBoxTipoVisita.Tag = "Find"
        '
        'LabelDataVisita
        '
        Me.LabelDataVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelDataVisita.AutoSize = True
        Me.LabelDataVisita.Location = New System.Drawing.Point(241, 17)
        Me.LabelDataVisita.Name = "LabelDataVisita"
        Me.LabelDataVisita.Size = New System.Drawing.Size(57, 13)
        Me.LabelDataVisita.TabIndex = 9
        Me.LabelDataVisita.Text = "Data visita"
        '
        'DateTimePickerDataVisita
        '
        Me.DateTimePickerDataVisita.AllowNull = True
        Me.DateTimePickerDataVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataVisita.DateTimeIcon = Nothing
        Me.DateTimePickerDataVisita.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataVisita.Location = New System.Drawing.Point(313, 13)
        Me.DateTimePickerDataVisita.Name = "DateTimePickerDataVisita"
        Me.DateTimePickerDataVisita.Size = New System.Drawing.Size(198, 21)
        Me.DateTimePickerDataVisita.TabIndex = 10
        Me.DateTimePickerDataVisita.ToolTipText = ""
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonCercaVisita, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 57)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(754, 34)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'ButtonCercaVisita
        '
        Me.ButtonCercaVisita.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonCercaVisita.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonCercaVisita.Location = New System.Drawing.Point(655, 3)
        Me.ButtonCercaVisita.Name = "ButtonCercaVisita"
        Me.ButtonCercaVisita.Size = New System.Drawing.Size(96, 27)
        Me.ButtonCercaVisita.TabIndex = 0
        Me.ButtonCercaVisita.Tag = "OkButton"
        Me.ButtonCercaVisita.Text = "Cerca"
        '
        'UC_CercaVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_CercaVisita"
        Me.Size = New System.Drawing.Size(766, 516)
        CType(Me.dgvSelezioneVisita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ComboBoxTipoVisita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSelezioneVisita As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ButtonSeleziona As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents ButtonAnnulla As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LabelDataVisita As Label
    Friend WithEvents LabelTipoVisita As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ButtonCercaVisita As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents DateTimePickerDataVisita As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents ComboBoxTipoVisita As Syncfusion.WinForms.ListView.SfComboBox
End Class
