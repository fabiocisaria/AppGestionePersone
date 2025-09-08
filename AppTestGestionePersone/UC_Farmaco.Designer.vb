<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Farmaco
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
        Me.ComboBoxViaSomministrazione = New System.Windows.Forms.ComboBox()
        Me.ComboBoxClasse = New System.Windows.Forms.ComboBox()
        Me.LabelViaSomministrazione = New System.Windows.Forms.Label()
        Me.TextBoxPrincipioAttivo = New System.Windows.Forms.TextBox()
        Me.TextBoxNomeCommerciale = New System.Windows.Forms.TextBox()
        Me.LabelClasse = New System.Windows.Forms.Label()
        Me.LabelPrincipioAttivo = New System.Windows.Forms.Label()
        Me.LabelNomeCommerciale = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanelRmn.TabIndex = 2
        '
        'TableLayoutPanelDatiFarmaco
        '
        Me.TableLayoutPanelDatiFarmaco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDatiFarmaco.ColumnCount = 2
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.ComboBoxViaSomministrazione, 1, 3)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.ComboBoxClasse, 1, 2)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelViaSomministrazione, 0, 3)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.TextBoxPrincipioAttivo, 1, 1)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.TextBoxNomeCommerciale, 1, 0)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelClasse, 0, 2)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelPrincipioAttivo, 0, 1)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelNomeCommerciale, 0, 0)
        Me.TableLayoutPanelDatiFarmaco.Location = New System.Drawing.Point(184, 144)
        Me.TableLayoutPanelDatiFarmaco.Name = "TableLayoutPanelDatiFarmaco"
        Me.TableLayoutPanelDatiFarmaco.RowCount = 4
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.Size = New System.Drawing.Size(397, 188)
        Me.TableLayoutPanelDatiFarmaco.TabIndex = 0
        '
        'ComboBoxViaSomministrazione
        '
        Me.ComboBoxViaSomministrazione.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBoxViaSomministrazione.FormattingEnabled = True
        Me.ComboBoxViaSomministrazione.Items.AddRange(New Object() {"Negativo", "Positivo"})
        Me.ComboBoxViaSomministrazione.Location = New System.Drawing.Point(173, 154)
        Me.ComboBoxViaSomministrazione.Name = "ComboBoxViaSomministrazione"
        Me.ComboBoxViaSomministrazione.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxViaSomministrazione.TabIndex = 16
        '
        'ComboBoxClasse
        '
        Me.ComboBoxClasse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBoxClasse.FormattingEnabled = True
        Me.ComboBoxClasse.Items.AddRange(New Object() {"Negativo", "Positivo"})
        Me.ComboBoxClasse.Location = New System.Drawing.Point(173, 107)
        Me.ComboBoxClasse.Name = "ComboBoxClasse"
        Me.ComboBoxClasse.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxClasse.TabIndex = 15
        '
        'LabelViaSomministrazione
        '
        Me.LabelViaSomministrazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelViaSomministrazione.AutoSize = True
        Me.LabelViaSomministrazione.Location = New System.Drawing.Point(3, 158)
        Me.LabelViaSomministrazione.Name = "LabelViaSomministrazione"
        Me.LabelViaSomministrazione.Size = New System.Drawing.Size(115, 13)
        Me.LabelViaSomministrazione.TabIndex = 13
        Me.LabelViaSomministrazione.Text = "Via di somministrazione"
        '
        'TextBoxPrincipioAttivo
        '
        Me.TextBoxPrincipioAttivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxPrincipioAttivo.Location = New System.Drawing.Point(173, 60)
        Me.TextBoxPrincipioAttivo.Name = "TextBoxPrincipioAttivo"
        Me.TextBoxPrincipioAttivo.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxPrincipioAttivo.TabIndex = 10
        '
        'TextBoxNomeCommerciale
        '
        Me.TextBoxNomeCommerciale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxNomeCommerciale.Location = New System.Drawing.Point(173, 13)
        Me.TextBoxNomeCommerciale.Name = "TextBoxNomeCommerciale"
        Me.TextBoxNomeCommerciale.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeCommerciale.TabIndex = 9
        '
        'LabelClasse
        '
        Me.LabelClasse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelClasse.AutoSize = True
        Me.LabelClasse.Location = New System.Drawing.Point(3, 111)
        Me.LabelClasse.Name = "LabelClasse"
        Me.LabelClasse.Size = New System.Drawing.Size(38, 13)
        Me.LabelClasse.TabIndex = 8
        Me.LabelClasse.Text = "Classe"
        '
        'LabelPrincipioAttivo
        '
        Me.LabelPrincipioAttivo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPrincipioAttivo.AutoSize = True
        Me.LabelPrincipioAttivo.Location = New System.Drawing.Point(3, 64)
        Me.LabelPrincipioAttivo.Name = "LabelPrincipioAttivo"
        Me.LabelPrincipioAttivo.Size = New System.Drawing.Size(77, 13)
        Me.LabelPrincipioAttivo.TabIndex = 6
        Me.LabelPrincipioAttivo.Text = "Principio Attivo"
        '
        'LabelNomeCommerciale
        '
        Me.LabelNomeCommerciale.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomeCommerciale.AutoSize = True
        Me.LabelNomeCommerciale.Location = New System.Drawing.Point(3, 17)
        Me.LabelNomeCommerciale.Name = "LabelNomeCommerciale"
        Me.LabelNomeCommerciale.Size = New System.Drawing.Size(97, 13)
        Me.LabelNomeCommerciale.TabIndex = 4
        Me.LabelNomeCommerciale.Text = "Nome commerciale"
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
        'UC_Farmaco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelRmn)
        Me.Name = "UC_Farmaco"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelRmn.ResumeLayout(False)
        Me.TableLayoutPanelDatiFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelDatiFarmaco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelRmn As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDatiFarmaco As TableLayoutPanel
    Friend WithEvents LabelClasse As Label
    Friend WithEvents LabelPrincipioAttivo As Label
    Friend WithEvents LabelNomeCommerciale As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TextBoxNomeCommerciale As TextBox
    Friend WithEvents TextBoxPrincipioAttivo As TextBox
    Friend WithEvents LabelViaSomministrazione As Label
    Friend WithEvents ComboBoxViaSomministrazione As ComboBox
    Friend WithEvents ComboBoxClasse As ComboBox
End Class
