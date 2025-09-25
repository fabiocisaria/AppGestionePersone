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
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelAnmFam = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxParentela = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.TextPatologie = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelPatologie = New System.Windows.Forms.Label()
        Me.LabelParentela = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanelAnmFam.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ComboBoxParentela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextPatologie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanelAnmFam, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 15
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanelAnmFam
        '
        Me.TableLayoutPanelAnmFam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelAnmFam.ColumnCount = 1
        Me.TableLayoutPanelAnmFam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnmFam.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelAnmFam.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelAnmFam.Location = New System.Drawing.Point(203, 163)
        Me.TableLayoutPanelAnmFam.Name = "TableLayoutPanelAnmFam"
        Me.TableLayoutPanelAnmFam.RowCount = 2
        Me.TableLayoutPanelAnmFam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelAnmFam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAnmFam.Size = New System.Drawing.Size(360, 150)
        Me.TableLayoutPanelAnmFam.TabIndex = 20
        Me.TableLayoutPanelAnmFam.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(94, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Anamnesi familiare"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.32268!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.67731!))
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxParentela, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextPatologie, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPatologie, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelParentela, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(354, 114)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'ComboBoxParentela
        '
        Me.ComboBoxParentela.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxParentela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxParentela.AutoCompleteSuggestDelay = 1
        Me.ComboBoxParentela.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxParentela.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxParentela.Location = New System.Drawing.Point(85, 18)
        Me.ComboBoxParentela.Name = "ComboBoxParentela"
        Me.ComboBoxParentela.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxParentela.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxParentela.TabIndex = 23
        Me.ComboBoxParentela.TabStop = False
        Me.ComboBoxParentela.Tag = "Find"
        '
        'TextPatologie
        '
        Me.TextPatologie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextPatologie.BeforeTouchSize = New System.Drawing.Size(240, 20)
        Me.TextPatologie.BorderColor = System.Drawing.Color.Transparent
        Me.TextPatologie.Location = New System.Drawing.Point(85, 75)
        Me.TextPatologie.Name = "TextPatologie"
        Me.TextPatologie.Size = New System.Drawing.Size(240, 20)
        Me.TextPatologie.TabIndex = 22
        Me.TextPatologie.Tag = "Find"
        Me.TextPatologie.Text = "Patologie"
        '
        'LabelPatologie
        '
        Me.LabelPatologie.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPatologie.AutoSize = True
        Me.LabelPatologie.Location = New System.Drawing.Point(3, 79)
        Me.LabelPatologie.Name = "LabelPatologie"
        Me.LabelPatologie.Size = New System.Drawing.Size(51, 13)
        Me.LabelPatologie.TabIndex = 2
        Me.LabelPatologie.Text = "Patologie"
        '
        'LabelParentela
        '
        Me.LabelParentela.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelParentela.AutoSize = True
        Me.LabelParentela.Location = New System.Drawing.Point(3, 22)
        Me.LabelParentela.Name = "LabelParentela"
        Me.LabelParentela.Size = New System.Drawing.Size(52, 13)
        Me.LabelParentela.TabIndex = 5
        Me.LabelParentela.Text = "Parentela"
        '
        'UC_AnamnesiFamiliare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_AnamnesiFamiliare"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanelAnmFam.ResumeLayout(False)
        Me.TableLayoutPanelAnmFam.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ComboBoxParentela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextPatologie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelParentela As Label
    Friend WithEvents LabelPatologie As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents TableLayoutPanelAnmFam As TableLayoutPanel
    Friend WithEvents TextPatologie As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents ComboBoxParentela As Syncfusion.WinForms.ListView.SfComboBox
End Class
