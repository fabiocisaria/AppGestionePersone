<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_AnamnesiFamiliare
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxAnamnesi = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxParentela = New System.Windows.Forms.ComboBox()
        Me.LabelPatologie = New System.Windows.Forms.Label()
        Me.TextPatologie = New System.Windows.Forms.TextBox()
        Me.LabelParentela = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxAnamnesi.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxAnamnesi, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxAnamnesi
        '
        Me.GroupBoxAnamnesi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxAnamnesi.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxAnamnesi.Location = New System.Drawing.Point(223, 145)
        Me.GroupBoxAnamnesi.Name = "GroupBoxAnamnesi"
        Me.GroupBoxAnamnesi.Size = New System.Drawing.Size(319, 185)
        Me.GroupBoxAnamnesi.TabIndex = 4
        Me.GroupBoxAnamnesi.TabStop = False
        Me.GroupBoxAnamnesi.Text = "Dati anamnesi"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.32268!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.67731!))
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxParentela, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPatologie, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextPatologie, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelParentela, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(313, 166)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'ComboBoxParentela
        '
        Me.ComboBoxParentela.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxParentela.FormattingEnabled = True
        Me.ComboBoxParentela.Location = New System.Drawing.Point(76, 31)
        Me.ComboBoxParentela.Name = "ComboBoxParentela"
        Me.ComboBoxParentela.Size = New System.Drawing.Size(195, 21)
        Me.ComboBoxParentela.TabIndex = 4
        '
        'LabelPatologie
        '
        Me.LabelPatologie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPatologie.AutoSize = True
        Me.LabelPatologie.Location = New System.Drawing.Point(3, 118)
        Me.LabelPatologie.Name = "LabelPatologie"
        Me.LabelPatologie.Size = New System.Drawing.Size(51, 13)
        Me.LabelPatologie.TabIndex = 2
        Me.LabelPatologie.Text = "Patologie"
        '
        'TextPatologie
        '
        Me.TextPatologie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextPatologie.Location = New System.Drawing.Point(76, 114)
        Me.TextPatologie.Name = "TextPatologie"
        Me.TextPatologie.Size = New System.Drawing.Size(195, 20)
        Me.TextPatologie.TabIndex = 5
        '
        'LabelParentela
        '
        Me.LabelParentela.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelParentela.AutoSize = True
        Me.LabelParentela.Location = New System.Drawing.Point(3, 35)
        Me.LabelParentela.Name = "LabelParentela"
        Me.LabelParentela.Size = New System.Drawing.Size(52, 13)
        Me.LabelParentela.TabIndex = 5
        Me.LabelParentela.Text = "Parentela"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonInserisci, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 479)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(760, 34)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(661, 3)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 15
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_AnamnesiFamiliare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_AnamnesiFamiliare"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxAnamnesi.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxAnamnesi As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ComboBoxParentela As ComboBox
    Friend WithEvents LabelParentela As Label
    Friend WithEvents LabelPatologie As Label
    Friend WithEvents TextPatologie As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
