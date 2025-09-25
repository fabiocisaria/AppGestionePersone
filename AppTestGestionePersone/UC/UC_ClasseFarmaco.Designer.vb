<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_ClasseFarmaco
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
        Me.TableLayoutPanelClassiFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelNuovaClasseFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDatiFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNomeClasse = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelNomeClasse = New System.Windows.Forms.Label()
        Me.TableLayoutPanelClassiFarmaco.SuspendLayout()
        Me.TableLayoutPanelNuovaClasseFarmaco.SuspendLayout()
        Me.TableLayoutPanelDatiFarmaco.SuspendLayout()
        CType(Me.TextBoxNomeClasse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelClassiFarmaco
        '
        Me.TableLayoutPanelClassiFarmaco.ColumnCount = 1
        Me.TableLayoutPanelClassiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelClassiFarmaco.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelClassiFarmaco.Controls.Add(Me.TableLayoutPanelNuovaClasseFarmaco, 0, 0)
        Me.TableLayoutPanelClassiFarmaco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelClassiFarmaco.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelClassiFarmaco.Name = "TableLayoutPanelClassiFarmaco"
        Me.TableLayoutPanelClassiFarmaco.RowCount = 2
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelClassiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelClassiFarmaco.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelClassiFarmaco.TabIndex = 3
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
        'TableLayoutPanelNuovaClasseFarmaco
        '
        Me.TableLayoutPanelNuovaClasseFarmaco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaClasseFarmaco.ColumnCount = 1
        Me.TableLayoutPanelNuovaClasseFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaClasseFarmaco.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaClasseFarmaco.Controls.Add(Me.TableLayoutPanelDatiFarmaco, 0, 1)
        Me.TableLayoutPanelNuovaClasseFarmaco.Location = New System.Drawing.Point(183, 181)
        Me.TableLayoutPanelNuovaClasseFarmaco.Name = "TableLayoutPanelNuovaClasseFarmaco"
        Me.TableLayoutPanelNuovaClasseFarmaco.RowCount = 2
        Me.TableLayoutPanelNuovaClasseFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaClasseFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaClasseFarmaco.Size = New System.Drawing.Size(400, 113)
        Me.TableLayoutPanelNuovaClasseFarmaco.TabIndex = 21
        Me.TableLayoutPanelNuovaClasseFarmaco.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(113, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Nuova classe farmaco"
        '
        'TableLayoutPanelDatiFarmaco
        '
        Me.TableLayoutPanelDatiFarmaco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDatiFarmaco.ColumnCount = 2
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.TextBoxNomeClasse, 1, 0)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelNomeClasse, 0, 0)
        Me.TableLayoutPanelDatiFarmaco.Location = New System.Drawing.Point(23, 48)
        Me.TableLayoutPanelDatiFarmaco.Name = "TableLayoutPanelDatiFarmaco"
        Me.TableLayoutPanelDatiFarmaco.RowCount = 1
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.Size = New System.Drawing.Size(354, 47)
        Me.TableLayoutPanelDatiFarmaco.TabIndex = 0
        Me.TableLayoutPanelDatiFarmaco.Tag = ""
        '
        'TextBoxNomeClasse
        '
        Me.TextBoxNomeClasse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomeClasse.BeforeTouchSize = New System.Drawing.Size(105, 20)
        Me.TextBoxNomeClasse.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomeClasse.Location = New System.Drawing.Point(94, 13)
        Me.TextBoxNomeClasse.Name = "TextBoxNomeClasse"
        Me.TextBoxNomeClasse.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeClasse.TabIndex = 23
        Me.TextBoxNomeClasse.Tag = "Find"
        Me.TextBoxNomeClasse.Text = "Classe"
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
        'UC_ClasseFarmaco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelClassiFarmaco)
        Me.Name = "UC_ClasseFarmaco"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelClassiFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelNuovaClasseFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelNuovaClasseFarmaco.PerformLayout()
        Me.TableLayoutPanelDatiFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelDatiFarmaco.PerformLayout()
        CType(Me.TextBoxNomeClasse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelClassiFarmaco As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDatiFarmaco As TableLayoutPanel
    Friend WithEvents LabelNomeClasse As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelNuovaClasseFarmaco As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TextBoxNomeClasse As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
