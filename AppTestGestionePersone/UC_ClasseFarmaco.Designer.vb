<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ClasseFarmaco
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
        Me.TableLayoutPanelRmn = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelDatiFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomeClasse = New System.Windows.Forms.TextBox()
        Me.LabelNomeClasse = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelRmn.SuspendLayout()
        Me.TableLayoutPanelDatiFarmaco.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelRmn
        '
        Me.TableLayoutPanelRmn.ColumnCount = 1
        Me.TableLayoutPanelRmn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.Controls.Add(Me.TableLayoutPanelDatiFarmaco, 0, 0)
        Me.TableLayoutPanelRmn.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelRmn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRmn.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelRmn.Name = "TableLayoutPanelRmn"
        Me.TableLayoutPanelRmn.RowCount = 2
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelRmn.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelRmn.TabIndex = 3
        '
        'TableLayoutPanelDatiFarmaco
        '
        Me.TableLayoutPanelDatiFarmaco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDatiFarmaco.ColumnCount = 2
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.TextBoxNomeClasse, 1, 0)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelNomeClasse, 0, 0)
        Me.TableLayoutPanelDatiFarmaco.Location = New System.Drawing.Point(184, 214)
        Me.TableLayoutPanelDatiFarmaco.Name = "TableLayoutPanelDatiFarmaco"
        Me.TableLayoutPanelDatiFarmaco.RowCount = 1
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.Size = New System.Drawing.Size(397, 47)
        Me.TableLayoutPanelDatiFarmaco.TabIndex = 0
        '
        'TextBoxNomeClasse
        '
        Me.TextBoxNomeClasse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxNomeClasse.Location = New System.Drawing.Point(110, 13)
        Me.TextBoxNomeClasse.Name = "TextBoxNomeClasse"
        Me.TextBoxNomeClasse.Size = New System.Drawing.Size(267, 20)
        Me.TextBoxNomeClasse.TabIndex = 9
        '
        'LabelNomeClasse
        '
        Me.LabelNomeClasse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomeClasse.AutoSize = True
        Me.LabelNomeClasse.Location = New System.Drawing.Point(3, 17)
        Me.LabelNomeClasse.Name = "LabelNomeClasse"
        Me.LabelNomeClasse.Size = New System.Drawing.Size(68, 13)
        Me.LabelNomeClasse.TabIndex = 4
        Me.LabelNomeClasse.Text = "Nome classe"
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
        'UC_ClasseFarmaco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelRmn)
        Me.Name = "UC_ClasseFarmaco"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelRmn.ResumeLayout(False)
        Me.TableLayoutPanelDatiFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelDatiFarmaco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelRmn As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDatiFarmaco As TableLayoutPanel
    Friend WithEvents TextBoxNomeClasse As TextBox
    Friend WithEvents LabelNomeClasse As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
