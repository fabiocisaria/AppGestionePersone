<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_InserisciVisita
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
        Me.LabelTipoVisita = New System.Windows.Forms.Label()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.LabelMotivoVisita = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelNuovaVisita = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxMotivo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.DateTimePickerDataVisita = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelTipoVisitaTx = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanelNuovaVisita.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TextBoxMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTipoVisita
        '
        Me.LabelTipoVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTipoVisita.Location = New System.Drawing.Point(83, 8)
        Me.LabelTipoVisita.Name = "LabelTipoVisita"
        Me.LabelTipoVisita.Size = New System.Drawing.Size(200, 13)
        Me.LabelTipoVisita.TabIndex = 10
        Me.LabelTipoVisita.Text = "Tipo visita"
        '
        'LabelData
        '
        Me.LabelData.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(3, 44)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 8
        Me.LabelData.Text = "Data"
        '
        'LabelMotivoVisita
        '
        Me.LabelMotivoVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelMotivoVisita.AutoSize = True
        Me.LabelMotivoVisita.Location = New System.Drawing.Point(3, 86)
        Me.LabelMotivoVisita.Name = "LabelMotivoVisita"
        Me.LabelMotivoVisita.Size = New System.Drawing.Size(39, 13)
        Me.LabelMotivoVisita.TabIndex = 6
        Me.LabelMotivoVisita.Text = "Motivo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelNuovaVisita, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonInserisci, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TableLayoutPanelNuovaVisita
        '
        Me.TableLayoutPanelNuovaVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaVisita.ColumnCount = 1
        Me.TableLayoutPanelNuovaVisita.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaVisita.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaVisita.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelNuovaVisita.Location = New System.Drawing.Point(203, 173)
        Me.TableLayoutPanelNuovaVisita.Name = "TableLayoutPanelNuovaVisita"
        Me.TableLayoutPanelNuovaVisita.RowCount = 2
        Me.TableLayoutPanelNuovaVisita.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaVisita.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaVisita.Size = New System.Drawing.Size(360, 150)
        Me.TableLayoutPanelNuovaVisita.TabIndex = 21
        Me.TableLayoutPanelNuovaVisita.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(53, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Dati visita"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxMotivo, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePickerDataVisita, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelTipoVisitaTx, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelData, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelMotivoVisita, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelTipoVisita, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(354, 114)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBoxMotivo
        '
        Me.TextBoxMotivo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxMotivo.BeforeTouchSize = New System.Drawing.Size(200, 20)
        Me.TextBoxMotivo.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxMotivo.Location = New System.Drawing.Point(83, 83)
        Me.TextBoxMotivo.Name = "TextBoxMotivo"
        Me.TextBoxMotivo.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxMotivo.TabIndex = 23
        Me.TextBoxMotivo.Tag = "Find"
        Me.TextBoxMotivo.Text = "Motivo"
        '
        'DateTimePickerDataVisita
        '
        Me.DateTimePickerDataVisita.AllowNull = True
        Me.DateTimePickerDataVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataVisita.DateTimeIcon = Nothing
        Me.DateTimePickerDataVisita.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataVisita.Location = New System.Drawing.Point(83, 40)
        Me.DateTimePickerDataVisita.Name = "DateTimePickerDataVisita"
        Me.DateTimePickerDataVisita.Size = New System.Drawing.Size(241, 21)
        Me.DateTimePickerDataVisita.TabIndex = 22
        Me.DateTimePickerDataVisita.ToolTipText = ""
        '
        'LabelTipoVisitaTx
        '
        Me.LabelTipoVisitaTx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTipoVisitaTx.AutoSize = True
        Me.LabelTipoVisitaTx.Location = New System.Drawing.Point(3, 8)
        Me.LabelTipoVisitaTx.Name = "LabelTipoVisitaTx"
        Me.LabelTipoVisitaTx.Size = New System.Drawing.Size(55, 13)
        Me.LabelTipoVisitaTx.TabIndex = 11
        Me.LabelTipoVisitaTx.Text = "Tipo visita"
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 3
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_InserisciVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_InserisciVisita"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanelNuovaVisita.ResumeLayout(False)
        Me.TableLayoutPanelNuovaVisita.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TextBoxMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelData As Label
    Friend WithEvents LabelMotivoVisita As Label
    Friend WithEvents LabelTipoVisita As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelTipoVisitaTx As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelNuovaVisita As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents DateTimePickerDataVisita As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents TextBoxMotivo As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
