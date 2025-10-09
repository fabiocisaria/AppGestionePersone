<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_MalattiaAutoimmune
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
        Me.TableLayoutPanelClassiFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelNuovaMalattia = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDatiMalattia = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomeMalattia = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelNomeMalattia = New System.Windows.Forms.Label()
        Me.TableLayoutPanelClassiFarmaco.SuspendLayout()
        Me.TableLayoutPanelNuovaMalattia.SuspendLayout()
        Me.TableLayoutPanelDatiMalattia.SuspendLayout()
        CType(Me.TextBoxNomeMalattia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelClassiFarmaco
        '
        Me.TableLayoutPanelClassiFarmaco.ColumnCount = 1
        Me.TableLayoutPanelClassiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelClassiFarmaco.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelClassiFarmaco.Controls.Add(Me.TableLayoutPanelNuovaMalattia, 0, 0)
        Me.TableLayoutPanelClassiFarmaco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelClassiFarmaco.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelClassiFarmaco.Name = "TableLayoutPanelClassiFarmaco"
        Me.TableLayoutPanelClassiFarmaco.RowCount = 2
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelClassiFarmaco.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelClassiFarmaco.TabIndex = 4
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(665, 481)
        Me.ButtonInserisci.Margin = New System.Windows.Forms.Padding(3, 3, 5, 5)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanelNuovaMalattia
        '
        Me.TableLayoutPanelNuovaMalattia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaMalattia.ColumnCount = 1
        Me.TableLayoutPanelNuovaMalattia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaMalattia.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaMalattia.Controls.Add(Me.TableLayoutPanelDatiMalattia, 0, 1)
        Me.TableLayoutPanelNuovaMalattia.Location = New System.Drawing.Point(183, 181)
        Me.TableLayoutPanelNuovaMalattia.Name = "TableLayoutPanelNuovaMalattia"
        Me.TableLayoutPanelNuovaMalattia.RowCount = 2
        Me.TableLayoutPanelNuovaMalattia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaMalattia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaMalattia.Size = New System.Drawing.Size(400, 113)
        Me.TableLayoutPanelNuovaMalattia.TabIndex = 21
        Me.TableLayoutPanelNuovaMalattia.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(138, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Nuova malattia autoimmune"
        '
        'TableLayoutPanelDatiMalattia
        '
        Me.TableLayoutPanelDatiMalattia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDatiMalattia.ColumnCount = 2
        Me.TableLayoutPanelDatiMalattia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanelDatiMalattia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiMalattia.Controls.Add(Me.TextBoxNomeMalattia, 1, 0)
        Me.TableLayoutPanelDatiMalattia.Controls.Add(Me.LabelNomeMalattia, 0, 0)
        Me.TableLayoutPanelDatiMalattia.Location = New System.Drawing.Point(23, 48)
        Me.TableLayoutPanelDatiMalattia.Name = "TableLayoutPanelDatiMalattia"
        Me.TableLayoutPanelDatiMalattia.RowCount = 1
        Me.TableLayoutPanelDatiMalattia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiMalattia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiMalattia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiMalattia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiMalattia.Size = New System.Drawing.Size(354, 47)
        Me.TableLayoutPanelDatiMalattia.TabIndex = 0
        Me.TableLayoutPanelDatiMalattia.Tag = ""
        '
        'TextBoxNomeMalattia
        '
        Me.TextBoxNomeMalattia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomeMalattia.BeforeTouchSize = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeMalattia.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomeMalattia.Location = New System.Drawing.Point(94, 13)
        Me.TextBoxNomeMalattia.Name = "TextBoxNomeMalattia"
        Me.TextBoxNomeMalattia.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeMalattia.TabIndex = 23
        Me.TextBoxNomeMalattia.Tag = "Find"
        Me.TextBoxNomeMalattia.Text = "Nome malattia"
        '
        'LabelNomeMalattia
        '
        Me.LabelNomeMalattia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomeMalattia.AutoSize = True
        Me.LabelNomeMalattia.Location = New System.Drawing.Point(3, 17)
        Me.LabelNomeMalattia.Name = "LabelNomeMalattia"
        Me.LabelNomeMalattia.Size = New System.Drawing.Size(74, 13)
        Me.LabelNomeMalattia.TabIndex = 4
        Me.LabelNomeMalattia.Text = "Nome malattia"
        '
        'UC_MalattieAutoimmuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelClassiFarmaco)
        Me.Name = "UC_MalattieAutoimmuni"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelClassiFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelNuovaMalattia.ResumeLayout(False)
        Me.TableLayoutPanelNuovaMalattia.PerformLayout()
        Me.TableLayoutPanelDatiMalattia.ResumeLayout(False)
        Me.TableLayoutPanelDatiMalattia.PerformLayout()
        CType(Me.TextBoxNomeMalattia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelClassiFarmaco As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelNuovaMalattia As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TableLayoutPanelDatiMalattia As TableLayoutPanel
    Friend WithEvents TextBoxNomeMalattia As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LabelNomeMalattia As Label
End Class
