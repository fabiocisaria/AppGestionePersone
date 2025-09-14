<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Terapia
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
        Me.TableLayoutPanelTerapia = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxMiglioramenti = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelMiglioramenti = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonNullo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLieve = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNotevole = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAsintomatico = New System.Windows.Forms.RadioButton()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanelTerapieRiabilitative = New System.Windows.Forms.FlowLayoutPanel()
        Me.SfButtonAggiungiTerapiaRiabilitativa = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButtonAggiungiFarmaco = New Syncfusion.WinForms.Controls.SfButton()
        Me.FlowLayoutPanelFarmaci = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelTerapieRiabilitative = New System.Windows.Forms.Label()
        Me.LabelFarmaci = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelTerapia.SuspendLayout()
        Me.GroupBoxMiglioramenti.SuspendLayout()
        Me.TableLayoutPanelMiglioramenti.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelTerapia
        '
        Me.TableLayoutPanelTerapia.ColumnCount = 1
        Me.TableLayoutPanelTerapia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapia.Controls.Add(Me.GroupBoxMiglioramenti, 0, 0)
        Me.TableLayoutPanelTerapia.Controls.Add(Me.ButtonInserisci, 0, 2)
        Me.TableLayoutPanelTerapia.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelTerapia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelTerapia.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelTerapia.Name = "TableLayoutPanelTerapia"
        Me.TableLayoutPanelTerapia.RowCount = 3
        Me.TableLayoutPanelTerapia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanelTerapia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelTerapia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTerapia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTerapia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTerapia.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelTerapia.TabIndex = 5
        '
        'GroupBoxMiglioramenti
        '
        Me.GroupBoxMiglioramenti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxMiglioramenti.Controls.Add(Me.TableLayoutPanelMiglioramenti)
        Me.GroupBoxMiglioramenti.Location = New System.Drawing.Point(190, 18)
        Me.GroupBoxMiglioramenti.Name = "GroupBoxMiglioramenti"
        Me.GroupBoxMiglioramenti.Size = New System.Drawing.Size(385, 64)
        Me.GroupBoxMiglioramenti.TabIndex = 3
        Me.GroupBoxMiglioramenti.TabStop = False
        Me.GroupBoxMiglioramenti.Text = "Miglioramenti"
        '
        'TableLayoutPanelMiglioramenti
        '
        Me.TableLayoutPanelMiglioramenti.ColumnCount = 4
        Me.TableLayoutPanelMiglioramenti.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelMiglioramenti.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelMiglioramenti.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelMiglioramenti.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelMiglioramenti.Controls.Add(Me.RadioButtonNullo, 0, 0)
        Me.TableLayoutPanelMiglioramenti.Controls.Add(Me.RadioButtonLieve, 1, 0)
        Me.TableLayoutPanelMiglioramenti.Controls.Add(Me.RadioButtonNotevole, 2, 0)
        Me.TableLayoutPanelMiglioramenti.Controls.Add(Me.RadioButtonAsintomatico, 3, 0)
        Me.TableLayoutPanelMiglioramenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMiglioramenti.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelMiglioramenti.Name = "TableLayoutPanelMiglioramenti"
        Me.TableLayoutPanelMiglioramenti.RowCount = 1
        Me.TableLayoutPanelMiglioramenti.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelMiglioramenti.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelMiglioramenti.Size = New System.Drawing.Size(379, 45)
        Me.TableLayoutPanelMiglioramenti.TabIndex = 0
        '
        'RadioButtonNullo
        '
        Me.RadioButtonNullo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonNullo.AutoSize = True
        Me.RadioButtonNullo.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RadioButtonNullo.Location = New System.Drawing.Point(29, 7)
        Me.RadioButtonNullo.Name = "RadioButtonNullo"
        Me.RadioButtonNullo.Size = New System.Drawing.Size(35, 30)
        Me.RadioButtonNullo.TabIndex = 9
        Me.RadioButtonNullo.TabStop = True
        Me.RadioButtonNullo.Text = "Nullo"
        Me.RadioButtonNullo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonNullo.UseVisualStyleBackColor = True
        '
        'RadioButtonLieve
        '
        Me.RadioButtonLieve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonLieve.AutoSize = True
        Me.RadioButtonLieve.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RadioButtonLieve.Location = New System.Drawing.Point(122, 7)
        Me.RadioButtonLieve.Name = "RadioButtonLieve"
        Me.RadioButtonLieve.Size = New System.Drawing.Size(37, 30)
        Me.RadioButtonLieve.TabIndex = 10
        Me.RadioButtonLieve.TabStop = True
        Me.RadioButtonLieve.Text = "Lieve"
        Me.RadioButtonLieve.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonLieve.UseVisualStyleBackColor = True
        '
        'RadioButtonNotevole
        '
        Me.RadioButtonNotevole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonNotevole.AutoSize = True
        Me.RadioButtonNotevole.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RadioButtonNotevole.Location = New System.Drawing.Point(208, 7)
        Me.RadioButtonNotevole.Name = "RadioButtonNotevole"
        Me.RadioButtonNotevole.Size = New System.Drawing.Size(54, 30)
        Me.RadioButtonNotevole.TabIndex = 11
        Me.RadioButtonNotevole.TabStop = True
        Me.RadioButtonNotevole.Text = "Notevole"
        Me.RadioButtonNotevole.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonNotevole.UseVisualStyleBackColor = True
        '
        'RadioButtonAsintomatico
        '
        Me.RadioButtonAsintomatico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButtonAsintomatico.AutoSize = True
        Me.RadioButtonAsintomatico.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RadioButtonAsintomatico.Location = New System.Drawing.Point(295, 7)
        Me.RadioButtonAsintomatico.Name = "RadioButtonAsintomatico"
        Me.RadioButtonAsintomatico.Size = New System.Drawing.Size(71, 30)
        Me.RadioButtonAsintomatico.TabIndex = 12
        Me.RadioButtonAsintomatico.TabStop = True
        Me.RadioButtonAsintomatico.Text = "Asintomatico"
        Me.RadioButtonAsintomatico.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButtonAsintomatico.UseVisualStyleBackColor = True
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Text = "Salva"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanelTerapieRiabilitative, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanelFarmaci, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 103)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 370)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'FlowLayoutPanelTerapieRiabilitative
        '
        Me.FlowLayoutPanelTerapieRiabilitative.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelTerapieRiabilitative.Location = New System.Drawing.Point(383, 33)
        Me.FlowLayoutPanelTerapieRiabilitative.Name = "FlowLayoutPanelTerapieRiabilitative"
        Me.FlowLayoutPanelTerapieRiabilitative.Size = New System.Drawing.Size(374, 334)
        Me.FlowLayoutPanelTerapieRiabilitative.TabIndex = 6
        '
        'SfButtonAggiungiTerapiaRiabilitativa
        '
        Me.SfButtonAggiungiTerapiaRiabilitativa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SfButtonAggiungiTerapiaRiabilitativa.Location = New System.Drawing.Point(3, 3)
        Me.SfButtonAggiungiTerapiaRiabilitativa.Name = "SfButtonAggiungiTerapiaRiabilitativa"
        Me.SfButtonAggiungiTerapiaRiabilitativa.Size = New System.Drawing.Size(24, 18)
        Me.SfButtonAggiungiTerapiaRiabilitativa.TabIndex = 4
        Me.SfButtonAggiungiTerapiaRiabilitativa.Text = "+"
        '
        'SfButtonAggiungiFarmaco
        '
        Me.SfButtonAggiungiFarmaco.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SfButtonAggiungiFarmaco.Location = New System.Drawing.Point(3, 3)
        Me.SfButtonAggiungiFarmaco.Name = "SfButtonAggiungiFarmaco"
        Me.SfButtonAggiungiFarmaco.Size = New System.Drawing.Size(24, 18)
        Me.SfButtonAggiungiFarmaco.TabIndex = 3
        Me.SfButtonAggiungiFarmaco.Text = "+"
        '
        'FlowLayoutPanelFarmaci
        '
        Me.FlowLayoutPanelFarmaci.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelFarmaci.Location = New System.Drawing.Point(3, 33)
        Me.FlowLayoutPanelFarmaci.Name = "FlowLayoutPanelFarmaci"
        Me.FlowLayoutPanelFarmaci.Size = New System.Drawing.Size(374, 334)
        Me.FlowLayoutPanelFarmaci.TabIndex = 5
        '
        'LabelTerapieRiabilitative
        '
        Me.LabelTerapieRiabilitative.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTerapieRiabilitative.AutoSize = True
        Me.LabelTerapieRiabilitative.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTerapieRiabilitative.Location = New System.Drawing.Point(138, 3)
        Me.LabelTerapieRiabilitative.Name = "LabelTerapieRiabilitative"
        Me.LabelTerapieRiabilitative.Size = New System.Drawing.Size(128, 17)
        Me.LabelTerapieRiabilitative.TabIndex = 1
        Me.LabelTerapieRiabilitative.Text = "Terapie riabilitative"
        '
        'LabelFarmaci
        '
        Me.LabelFarmaci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelFarmaci.AutoSize = True
        Me.LabelFarmaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFarmaci.Location = New System.Drawing.Point(173, 3)
        Me.LabelFarmaci.Name = "LabelFarmaci"
        Me.LabelFarmaci.Size = New System.Drawing.Size(58, 17)
        Me.LabelFarmaci.TabIndex = 0
        Me.LabelFarmaci.Text = "Farmaci"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SfButtonAggiungiFarmaco, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelFarmaci, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(374, 24)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.LabelTerapieRiabilitative, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.SfButtonAggiungiTerapiaRiabilitativa, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(383, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(374, 24)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'UC_Terapia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelTerapia)
        Me.Name = "UC_Terapia"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelTerapia.ResumeLayout(False)
        Me.GroupBoxMiglioramenti.ResumeLayout(False)
        Me.TableLayoutPanelMiglioramenti.ResumeLayout(False)
        Me.TableLayoutPanelMiglioramenti.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelTerapia As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents GroupBoxMiglioramenti As GroupBox
    Friend WithEvents TableLayoutPanelMiglioramenti As TableLayoutPanel
    Friend WithEvents RadioButtonAsintomatico As RadioButton
    Friend WithEvents RadioButtonNotevole As RadioButton
    Friend WithEvents RadioButtonLieve As RadioButton
    Friend WithEvents RadioButtonNullo As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SfButtonAggiungiTerapiaRiabilitativa As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfButtonAggiungiFarmaco As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents LabelTerapieRiabilitative As Label
    Friend WithEvents LabelFarmaci As Label
    Friend WithEvents FlowLayoutPanelTerapieRiabilitative As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelFarmaci As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
