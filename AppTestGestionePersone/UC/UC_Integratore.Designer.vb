<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Integratore
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
        Me.TableLayoutPanelNuovoIntegratore = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelIntegratore = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomeIntegratore = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelNomeIntegratore = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelTerapRiab.SuspendLayout()
        Me.TableLayoutPanelNuovoIntegratore.SuspendLayout()
        Me.TableLayoutPanelIntegratore.SuspendLayout()
        CType(Me.TextBoxNomeIntegratore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelTerapRiab
        '
        Me.TableLayoutPanelTerapRiab.ColumnCount = 1
        Me.TableLayoutPanelTerapRiab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapRiab.Controls.Add(Me.TableLayoutPanelNuovoIntegratore, 0, 0)
        Me.TableLayoutPanelTerapRiab.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelTerapRiab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelTerapRiab.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelTerapRiab.Name = "TableLayoutPanelTerapRiab"
        Me.TableLayoutPanelTerapRiab.RowCount = 2
        Me.TableLayoutPanelTerapRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTerapRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelTerapRiab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTerapRiab.Size = New System.Drawing.Size(716, 516)
        Me.TableLayoutPanelTerapRiab.TabIndex = 5
        '
        'TableLayoutPanelNuovoIntegratore
        '
        Me.TableLayoutPanelNuovoIntegratore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovoIntegratore.ColumnCount = 1
        Me.TableLayoutPanelNuovoIntegratore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoIntegratore.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovoIntegratore.Controls.Add(Me.TableLayoutPanelIntegratore, 0, 1)
        Me.TableLayoutPanelNuovoIntegratore.Location = New System.Drawing.Point(158, 181)
        Me.TableLayoutPanelNuovoIntegratore.Name = "TableLayoutPanelNuovoIntegratore"
        Me.TableLayoutPanelNuovoIntegratore.RowCount = 2
        Me.TableLayoutPanelNuovoIntegratore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovoIntegratore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoIntegratore.Size = New System.Drawing.Size(400, 113)
        Me.TableLayoutPanelNuovoIntegratore.TabIndex = 22
        Me.TableLayoutPanelNuovoIntegratore.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(92, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Nuova integratore"
        '
        'TableLayoutPanelIntegratore
        '
        Me.TableLayoutPanelIntegratore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelIntegratore.ColumnCount = 2
        Me.TableLayoutPanelIntegratore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanelIntegratore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIntegratore.Controls.Add(Me.TextBoxNomeIntegratore, 1, 0)
        Me.TableLayoutPanelIntegratore.Controls.Add(Me.LabelNomeIntegratore, 0, 0)
        Me.TableLayoutPanelIntegratore.Location = New System.Drawing.Point(15, 48)
        Me.TableLayoutPanelIntegratore.Name = "TableLayoutPanelIntegratore"
        Me.TableLayoutPanelIntegratore.RowCount = 1
        Me.TableLayoutPanelIntegratore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelIntegratore.Size = New System.Drawing.Size(370, 47)
        Me.TableLayoutPanelIntegratore.TabIndex = 0
        '
        'TextBoxNomeIntegratore
        '
        Me.TextBoxNomeIntegratore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomeIntegratore.BeforeTouchSize = New System.Drawing.Size(248, 20)
        Me.TextBoxNomeIntegratore.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomeIntegratore.Location = New System.Drawing.Point(110, 13)
        Me.TextBoxNomeIntegratore.Name = "TextBoxNomeIntegratore"
        Me.TextBoxNomeIntegratore.Size = New System.Drawing.Size(248, 20)
        Me.TextBoxNomeIntegratore.TabIndex = 22
        Me.TextBoxNomeIntegratore.Tag = "Find"
        Me.TextBoxNomeIntegratore.Text = "Nome integratore"
        '
        'LabelNomeIntegratore
        '
        Me.LabelNomeIntegratore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomeIntegratore.AutoSize = True
        Me.LabelNomeIntegratore.Location = New System.Drawing.Point(3, 17)
        Me.LabelNomeIntegratore.Name = "LabelNomeIntegratore"
        Me.LabelNomeIntegratore.Size = New System.Drawing.Size(88, 13)
        Me.LabelNomeIntegratore.TabIndex = 4
        Me.LabelNomeIntegratore.Text = "Nome integratore"
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(617, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_Integratore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelTerapRiab)
        Me.Name = "UC_Integratore"
        Me.Size = New System.Drawing.Size(716, 516)
        Me.TableLayoutPanelTerapRiab.ResumeLayout(False)
        Me.TableLayoutPanelNuovoIntegratore.ResumeLayout(False)
        Me.TableLayoutPanelNuovoIntegratore.PerformLayout()
        Me.TableLayoutPanelIntegratore.ResumeLayout(False)
        Me.TableLayoutPanelIntegratore.PerformLayout()
        CType(Me.TextBoxNomeIntegratore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelTerapRiab As TableLayoutPanel
    Friend WithEvents TableLayoutPanelNuovoIntegratore As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TableLayoutPanelIntegratore As TableLayoutPanel
    Friend WithEvents TextBoxNomeIntegratore As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LabelNomeIntegratore As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
