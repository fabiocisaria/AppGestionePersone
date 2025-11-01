<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Patologia
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
        Me.TableLayoutPanelNuovaPat = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelNuovaPatologia = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelPatologia = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomePatologia = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelNomePatologia = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelNuovaPat.SuspendLayout()
        Me.TableLayoutPanelNuovaPatologia.SuspendLayout()
        Me.TableLayoutPanelPatologia.SuspendLayout()
        CType(Me.TextBoxNomePatologia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelNuovaPat
        '
        Me.TableLayoutPanelNuovaPat.ColumnCount = 1
        Me.TableLayoutPanelNuovaPat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaPat.Controls.Add(Me.TableLayoutPanelNuovaPatologia, 0, 0)
        Me.TableLayoutPanelNuovaPat.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelNuovaPat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelNuovaPat.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelNuovaPat.Name = "TableLayoutPanelNuovaPat"
        Me.TableLayoutPanelNuovaPat.RowCount = 2
        Me.TableLayoutPanelNuovaPat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaPat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelNuovaPat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelNuovaPat.Size = New System.Drawing.Size(716, 516)
        Me.TableLayoutPanelNuovaPat.TabIndex = 6
        '
        'TableLayoutPanelNuovaPatologia
        '
        Me.TableLayoutPanelNuovaPatologia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaPatologia.ColumnCount = 1
        Me.TableLayoutPanelNuovaPatologia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaPatologia.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaPatologia.Controls.Add(Me.TableLayoutPanelPatologia, 0, 1)
        Me.TableLayoutPanelNuovaPatologia.Location = New System.Drawing.Point(158, 181)
        Me.TableLayoutPanelNuovaPatologia.Name = "TableLayoutPanelNuovaPatologia"
        Me.TableLayoutPanelNuovaPatologia.RowCount = 2
        Me.TableLayoutPanelNuovaPatologia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaPatologia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaPatologia.Size = New System.Drawing.Size(400, 113)
        Me.TableLayoutPanelNuovaPatologia.TabIndex = 22
        Me.TableLayoutPanelNuovaPatologia.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(85, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Nuova patologia"
        '
        'TableLayoutPanelPatologia
        '
        Me.TableLayoutPanelPatologia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelPatologia.ColumnCount = 2
        Me.TableLayoutPanelPatologia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanelPatologia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPatologia.Controls.Add(Me.TextBoxNomePatologia, 1, 0)
        Me.TableLayoutPanelPatologia.Controls.Add(Me.LabelNomePatologia, 0, 0)
        Me.TableLayoutPanelPatologia.Location = New System.Drawing.Point(15, 48)
        Me.TableLayoutPanelPatologia.Name = "TableLayoutPanelPatologia"
        Me.TableLayoutPanelPatologia.RowCount = 1
        Me.TableLayoutPanelPatologia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPatologia.Size = New System.Drawing.Size(370, 47)
        Me.TableLayoutPanelPatologia.TabIndex = 0
        '
        'TextBoxNomePatologia
        '
        Me.TextBoxNomePatologia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomePatologia.BeforeTouchSize = New System.Drawing.Size(248, 20)
        Me.TextBoxNomePatologia.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomePatologia.Location = New System.Drawing.Point(110, 13)
        Me.TextBoxNomePatologia.Name = "TextBoxNomePatologia"
        Me.TextBoxNomePatologia.Size = New System.Drawing.Size(248, 20)
        Me.TextBoxNomePatologia.TabIndex = 22
        Me.TextBoxNomePatologia.Tag = "Find"
        Me.TextBoxNomePatologia.Text = "Nome patologia"
        '
        'LabelNomePatologia
        '
        Me.LabelNomePatologia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomePatologia.AutoSize = True
        Me.LabelNomePatologia.Location = New System.Drawing.Point(3, 17)
        Me.LabelNomePatologia.Name = "LabelNomePatologia"
        Me.LabelNomePatologia.Size = New System.Drawing.Size(81, 13)
        Me.LabelNomePatologia.TabIndex = 4
        Me.LabelNomePatologia.Text = "Nome patologia"
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
        'UC_Patologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelNuovaPat)
        Me.Name = "UC_Patologia"
        Me.Size = New System.Drawing.Size(716, 516)
        Me.TableLayoutPanelNuovaPat.ResumeLayout(False)
        Me.TableLayoutPanelNuovaPatologia.ResumeLayout(False)
        Me.TableLayoutPanelNuovaPatologia.PerformLayout()
        Me.TableLayoutPanelPatologia.ResumeLayout(False)
        Me.TableLayoutPanelPatologia.PerformLayout()
        CType(Me.TextBoxNomePatologia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelNuovaPat As TableLayoutPanel
    Friend WithEvents TableLayoutPanelNuovaPatologia As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TableLayoutPanelPatologia As TableLayoutPanel
    Friend WithEvents TextBoxNomePatologia As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LabelNomePatologia As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
