<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Contraccettivo
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
        Me.TableLayoutPanelNuovoContraccettivo = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelContracettivo = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomeContraccettivo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelNomeContraccettivo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelClassiFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelNuovoContraccettivo.SuspendLayout()
        Me.TableLayoutPanelContracettivo.SuspendLayout()
        CType(Me.TextBoxNomeContraccettivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelClassiFarmaco.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelNuovoContraccettivo
        '
        Me.TableLayoutPanelNuovoContraccettivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovoContraccettivo.ColumnCount = 1
        Me.TableLayoutPanelNuovoContraccettivo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoContraccettivo.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovoContraccettivo.Controls.Add(Me.TableLayoutPanelContracettivo, 0, 1)
        Me.TableLayoutPanelNuovoContraccettivo.Location = New System.Drawing.Point(158, 181)
        Me.TableLayoutPanelNuovoContraccettivo.Name = "TableLayoutPanelNuovoContraccettivo"
        Me.TableLayoutPanelNuovoContraccettivo.RowCount = 2
        Me.TableLayoutPanelNuovoContraccettivo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovoContraccettivo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoContraccettivo.Size = New System.Drawing.Size(400, 113)
        Me.TableLayoutPanelNuovoContraccettivo.TabIndex = 21
        Me.TableLayoutPanelNuovoContraccettivo.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(110, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Nuovo contraccettivo"
        '
        'TableLayoutPanelContracettivo
        '
        Me.TableLayoutPanelContracettivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelContracettivo.ColumnCount = 2
        Me.TableLayoutPanelContracettivo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanelContracettivo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelContracettivo.Controls.Add(Me.TextBoxNomeContraccettivo, 1, 0)
        Me.TableLayoutPanelContracettivo.Controls.Add(Me.LabelNomeContraccettivo, 0, 0)
        Me.TableLayoutPanelContracettivo.Location = New System.Drawing.Point(23, 48)
        Me.TableLayoutPanelContracettivo.Name = "TableLayoutPanelContracettivo"
        Me.TableLayoutPanelContracettivo.RowCount = 1
        Me.TableLayoutPanelContracettivo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelContracettivo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelContracettivo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelContracettivo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelContracettivo.Size = New System.Drawing.Size(354, 47)
        Me.TableLayoutPanelContracettivo.TabIndex = 0
        Me.TableLayoutPanelContracettivo.Tag = ""
        '
        'TextBoxNomeContraccettivo
        '
        Me.TextBoxNomeContraccettivo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomeContraccettivo.BeforeTouchSize = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeContraccettivo.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomeContraccettivo.Location = New System.Drawing.Point(94, 13)
        Me.TextBoxNomeContraccettivo.Name = "TextBoxNomeContraccettivo"
        Me.TextBoxNomeContraccettivo.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeContraccettivo.TabIndex = 23
        Me.TextBoxNomeContraccettivo.Tag = "Find"
        Me.TextBoxNomeContraccettivo.Text = "Contraccettivo"
        '
        'LabelNomeContraccettivo
        '
        Me.LabelNomeContraccettivo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomeContraccettivo.AutoSize = True
        Me.LabelNomeContraccettivo.Location = New System.Drawing.Point(3, 10)
        Me.LabelNomeContraccettivo.Name = "LabelNomeContraccettivo"
        Me.LabelNomeContraccettivo.Size = New System.Drawing.Size(75, 26)
        Me.LabelNomeContraccettivo.TabIndex = 4
        Me.LabelNomeContraccettivo.Text = "Nome contraccettivo"
        '
        'TableLayoutPanelClassiFarmaco
        '
        Me.TableLayoutPanelClassiFarmaco.ColumnCount = 1
        Me.TableLayoutPanelClassiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelClassiFarmaco.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelClassiFarmaco.Controls.Add(Me.TableLayoutPanelNuovoContraccettivo, 0, 0)
        Me.TableLayoutPanelClassiFarmaco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelClassiFarmaco.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelClassiFarmaco.Name = "TableLayoutPanelClassiFarmaco"
        Me.TableLayoutPanelClassiFarmaco.RowCount = 2
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelClassiFarmaco.Size = New System.Drawing.Size(716, 516)
        Me.TableLayoutPanelClassiFarmaco.TabIndex = 4
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(615, 481)
        Me.ButtonInserisci.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_Contraccettivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelClassiFarmaco)
        Me.Name = "UC_Contraccettivo"
        Me.Size = New System.Drawing.Size(716, 516)
        Me.TableLayoutPanelNuovoContraccettivo.ResumeLayout(False)
        Me.TableLayoutPanelNuovoContraccettivo.PerformLayout()
        Me.TableLayoutPanelContracettivo.ResumeLayout(False)
        Me.TableLayoutPanelContracettivo.PerformLayout()
        CType(Me.TextBoxNomeContraccettivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelClassiFarmaco.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelNuovoContraccettivo As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TableLayoutPanelContracettivo As TableLayoutPanel
    Friend WithEvents TextBoxNomeContraccettivo As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LabelNomeContraccettivo As Label
    Friend WithEvents TableLayoutPanelClassiFarmaco As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
