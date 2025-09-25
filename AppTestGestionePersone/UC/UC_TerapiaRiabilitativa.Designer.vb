<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_TerapiaRiabilitativa
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
        Me.TableLayoutPanelTerapRiab = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelNuovaTerRiab = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelTerapiaRiabilitativa = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomeTerapiaRiabilitativa = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelNomeTerapiaRiabilitativa = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelTerapRiab.SuspendLayout()
        Me.TableLayoutPanelNuovaTerRiab.SuspendLayout()
        Me.TableLayoutPanelTerapiaRiabilitativa.SuspendLayout()
        CType(Me.TextBoxNomeTerapiaRiabilitativa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelTerapRiab
        '
        Me.TableLayoutPanelTerapRiab.ColumnCount = 1
        Me.TableLayoutPanelTerapRiab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapRiab.Controls.Add(Me.TableLayoutPanelNuovaTerRiab, 0, 0)
        Me.TableLayoutPanelTerapRiab.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelTerapRiab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelTerapRiab.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelTerapRiab.Name = "TableLayoutPanelTerapRiab"
        Me.TableLayoutPanelTerapRiab.RowCount = 2
        Me.TableLayoutPanelTerapRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelTerapRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTerapRiab.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelTerapRiab.TabIndex = 4
        '
        'TableLayoutPanelNuovaTerRiab
        '
        Me.TableLayoutPanelNuovaTerRiab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaTerRiab.ColumnCount = 1
        Me.TableLayoutPanelNuovaTerRiab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaTerRiab.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaTerRiab.Controls.Add(Me.TableLayoutPanelTerapiaRiabilitativa, 0, 1)
        Me.TableLayoutPanelNuovaTerRiab.Location = New System.Drawing.Point(183, 181)
        Me.TableLayoutPanelNuovaTerRiab.Name = "TableLayoutPanelNuovaTerRiab"
        Me.TableLayoutPanelNuovaTerRiab.RowCount = 2
        Me.TableLayoutPanelNuovaTerRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaTerRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaTerRiab.Size = New System.Drawing.Size(400, 113)
        Me.TableLayoutPanelNuovaTerRiab.TabIndex = 22
        Me.TableLayoutPanelNuovaTerRiab.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(126, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Nuova terapia riabilitativa"
        '
        'TableLayoutPanelTerapiaRiabilitativa
        '
        Me.TableLayoutPanelTerapiaRiabilitativa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelTerapiaRiabilitativa.ColumnCount = 2
        Me.TableLayoutPanelTerapiaRiabilitativa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.Controls.Add(Me.TextBoxNomeTerapiaRiabilitativa, 1, 0)
        Me.TableLayoutPanelTerapiaRiabilitativa.Controls.Add(Me.LabelNomeTerapiaRiabilitativa, 0, 0)
        Me.TableLayoutPanelTerapiaRiabilitativa.Location = New System.Drawing.Point(15, 48)
        Me.TableLayoutPanelTerapiaRiabilitativa.Name = "TableLayoutPanelTerapiaRiabilitativa"
        Me.TableLayoutPanelTerapiaRiabilitativa.RowCount = 1
        Me.TableLayoutPanelTerapiaRiabilitativa.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.Size = New System.Drawing.Size(370, 47)
        Me.TableLayoutPanelTerapiaRiabilitativa.TabIndex = 0
        '
        'TextBoxNomeTerapiaRiabilitativa
        '
        Me.TextBoxNomeTerapiaRiabilitativa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomeTerapiaRiabilitativa.BeforeTouchSize = New System.Drawing.Size(206, 20)
        Me.TextBoxNomeTerapiaRiabilitativa.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomeTerapiaRiabilitativa.Location = New System.Drawing.Point(143, 13)
        Me.TextBoxNomeTerapiaRiabilitativa.Name = "TextBoxNomeTerapiaRiabilitativa"
        Me.TextBoxNomeTerapiaRiabilitativa.Size = New System.Drawing.Size(206, 20)
        Me.TextBoxNomeTerapiaRiabilitativa.TabIndex = 22
        Me.TextBoxNomeTerapiaRiabilitativa.Tag = "Find"
        Me.TextBoxNomeTerapiaRiabilitativa.Text = "Nome terapia"
        '
        'LabelNomeTerapiaRiabilitativa
        '
        Me.LabelNomeTerapiaRiabilitativa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomeTerapiaRiabilitativa.AutoSize = True
        Me.LabelNomeTerapiaRiabilitativa.Location = New System.Drawing.Point(3, 17)
        Me.LabelNomeTerapiaRiabilitativa.Name = "LabelNomeTerapiaRiabilitativa"
        Me.LabelNomeTerapiaRiabilitativa.Size = New System.Drawing.Size(122, 13)
        Me.LabelNomeTerapiaRiabilitativa.TabIndex = 4
        Me.LabelNomeTerapiaRiabilitativa.Text = "Nome terapia riabilitativa"
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_TerapiaRiabilitativa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelTerapRiab)
        Me.Name = "UC_TerapiaRiabilitativa"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelTerapRiab.ResumeLayout(False)
        Me.TableLayoutPanelNuovaTerRiab.ResumeLayout(False)
        Me.TableLayoutPanelNuovaTerRiab.PerformLayout()
        Me.TableLayoutPanelTerapiaRiabilitativa.ResumeLayout(False)
        Me.TableLayoutPanelTerapiaRiabilitativa.PerformLayout()
        CType(Me.TextBoxNomeTerapiaRiabilitativa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelTerapRiab As TableLayoutPanel
    Friend WithEvents TableLayoutPanelTerapiaRiabilitativa As TableLayoutPanel
    Friend WithEvents LabelNomeTerapiaRiabilitativa As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelNuovaTerRiab As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TextBoxNomeTerapiaRiabilitativa As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
