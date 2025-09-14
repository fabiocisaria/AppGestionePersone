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
        Me.TableLayoutPanelTerapiaRiabilitativa = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomeTerapiaRiabilitativa = New System.Windows.Forms.TextBox()
        Me.LabelNomeTerapiaRiabilitativa = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelTerapRiab.SuspendLayout()
        Me.TableLayoutPanelTerapiaRiabilitativa.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelTerapRiab
        '
        Me.TableLayoutPanelTerapRiab.ColumnCount = 1
        Me.TableLayoutPanelTerapRiab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapRiab.Controls.Add(Me.TableLayoutPanelTerapiaRiabilitativa, 0, 0)
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
        'TableLayoutPanelTerapiaRiabilitativa
        '
        Me.TableLayoutPanelTerapiaRiabilitativa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelTerapiaRiabilitativa.ColumnCount = 2
        Me.TableLayoutPanelTerapiaRiabilitativa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.Controls.Add(Me.TextBoxNomeTerapiaRiabilitativa, 1, 0)
        Me.TableLayoutPanelTerapiaRiabilitativa.Controls.Add(Me.LabelNomeTerapiaRiabilitativa, 0, 0)
        Me.TableLayoutPanelTerapiaRiabilitativa.Location = New System.Drawing.Point(162, 214)
        Me.TableLayoutPanelTerapiaRiabilitativa.Name = "TableLayoutPanelTerapiaRiabilitativa"
        Me.TableLayoutPanelTerapiaRiabilitativa.RowCount = 1
        Me.TableLayoutPanelTerapiaRiabilitativa.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelTerapiaRiabilitativa.Size = New System.Drawing.Size(441, 47)
        Me.TableLayoutPanelTerapiaRiabilitativa.TabIndex = 0
        '
        'TextBoxNomeTerapiaRiabilitativa
        '
        Me.TextBoxNomeTerapiaRiabilitativa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxNomeTerapiaRiabilitativa.Location = New System.Drawing.Point(137, 13)
        Me.TextBoxNomeTerapiaRiabilitativa.Name = "TextBoxNomeTerapiaRiabilitativa"
        Me.TextBoxNomeTerapiaRiabilitativa.Size = New System.Drawing.Size(295, 20)
        Me.TextBoxNomeTerapiaRiabilitativa.TabIndex = 9
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
        Me.TableLayoutPanelTerapiaRiabilitativa.ResumeLayout(False)
        Me.TableLayoutPanelTerapiaRiabilitativa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelTerapRiab As TableLayoutPanel
    Friend WithEvents TableLayoutPanelTerapiaRiabilitativa As TableLayoutPanel
    Friend WithEvents TextBoxNomeTerapiaRiabilitativa As TextBox
    Friend WithEvents LabelNomeTerapiaRiabilitativa As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
