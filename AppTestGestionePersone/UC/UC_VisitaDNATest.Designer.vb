<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_VisitaDNATest
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
        Me.TableLayoutPanelDNA = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelNuovoDNATest = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDatiDNA = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxCeppo = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.ComboBoxEsito = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.DateTimePickerDataEsecuzione = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelCeppo = New System.Windows.Forms.Label()
        Me.LabelEsito = New System.Windows.Forms.Label()
        Me.LabelDataEsecuzione = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDNA.SuspendLayout()
        Me.TableLayoutPanelNuovoDNATest.SuspendLayout()
        Me.TableLayoutPanelDatiDNA.SuspendLayout()
        CType(Me.ComboBoxCeppo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelDNA
        '
        Me.TableLayoutPanelDNA.ColumnCount = 1
        Me.TableLayoutPanelDNA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDNA.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelDNA.Controls.Add(Me.TableLayoutPanelNuovoDNATest, 0, 0)
        Me.TableLayoutPanelDNA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDNA.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelDNA.Name = "TableLayoutPanelDNA"
        Me.TableLayoutPanelDNA.RowCount = 2
        Me.TableLayoutPanelDNA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDNA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelDNA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelDNA.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelDNA.TabIndex = 3
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 2
        Me.ButtonInserisci.Tag = "OkButton"
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'TableLayoutPanelNuovoDNATest
        '
        Me.TableLayoutPanelNuovoDNATest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovoDNATest.ColumnCount = 1
        Me.TableLayoutPanelNuovoDNATest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoDNATest.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovoDNATest.Controls.Add(Me.TableLayoutPanelDatiDNA, 0, 1)
        Me.TableLayoutPanelNuovoDNATest.Location = New System.Drawing.Point(203, 159)
        Me.TableLayoutPanelNuovoDNATest.Name = "TableLayoutPanelNuovoDNATest"
        Me.TableLayoutPanelNuovoDNATest.RowCount = 2
        Me.TableLayoutPanelNuovoDNATest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovoDNATest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoDNATest.Size = New System.Drawing.Size(360, 158)
        Me.TableLayoutPanelNuovoDNATest.TabIndex = 22
        Me.TableLayoutPanelNuovoDNATest.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(54, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "DNA Test"
        '
        'TableLayoutPanelDatiDNA
        '
        Me.TableLayoutPanelDatiDNA.ColumnCount = 2
        Me.TableLayoutPanelDatiDNA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanelDatiDNA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiDNA.Controls.Add(Me.ComboBoxCeppo, 1, 2)
        Me.TableLayoutPanelDatiDNA.Controls.Add(Me.ComboBoxEsito, 1, 1)
        Me.TableLayoutPanelDatiDNA.Controls.Add(Me.DateTimePickerDataEsecuzione, 1, 0)
        Me.TableLayoutPanelDatiDNA.Controls.Add(Me.LabelCeppo, 0, 2)
        Me.TableLayoutPanelDatiDNA.Controls.Add(Me.LabelEsito, 0, 1)
        Me.TableLayoutPanelDatiDNA.Controls.Add(Me.LabelDataEsecuzione, 0, 0)
        Me.TableLayoutPanelDatiDNA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatiDNA.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanelDatiDNA.Name = "TableLayoutPanelDatiDNA"
        Me.TableLayoutPanelDatiDNA.RowCount = 3
        Me.TableLayoutPanelDatiDNA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiDNA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiDNA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiDNA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelDatiDNA.Size = New System.Drawing.Size(354, 122)
        Me.TableLayoutPanelDatiDNA.TabIndex = 0
        '
        'ComboBoxCeppo
        '
        Me.ComboBoxCeppo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxCeppo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxCeppo.AutoCompleteSuggestDelay = 1
        Me.ComboBoxCeppo.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxCeppo.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxCeppo.Location = New System.Drawing.Point(115, 90)
        Me.ComboBoxCeppo.Name = "ComboBoxCeppo"
        Me.ComboBoxCeppo.Size = New System.Drawing.Size(218, 21)
        Me.ComboBoxCeppo.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxCeppo.TabIndex = 30
        Me.ComboBoxCeppo.TabStop = False
        Me.ComboBoxCeppo.Tag = "Find"
        '
        'ComboBoxEsito
        '
        Me.ComboBoxEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEsito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxEsito.AutoCompleteSuggestDelay = 1
        Me.ComboBoxEsito.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxEsito.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxEsito.Location = New System.Drawing.Point(115, 49)
        Me.ComboBoxEsito.Name = "ComboBoxEsito"
        Me.ComboBoxEsito.Size = New System.Drawing.Size(218, 21)
        Me.ComboBoxEsito.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEsito.TabIndex = 29
        Me.ComboBoxEsito.TabStop = False
        Me.ComboBoxEsito.Tag = "Find"
        '
        'DateTimePickerDataEsecuzione
        '
        Me.DateTimePickerDataEsecuzione.AllowNull = True
        Me.DateTimePickerDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataEsecuzione.DateTimeIcon = Nothing
        Me.DateTimePickerDataEsecuzione.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataEsecuzione.Location = New System.Drawing.Point(115, 9)
        Me.DateTimePickerDataEsecuzione.Name = "DateTimePickerDataEsecuzione"
        Me.DateTimePickerDataEsecuzione.Size = New System.Drawing.Size(218, 21)
        Me.DateTimePickerDataEsecuzione.TabIndex = 11
        Me.DateTimePickerDataEsecuzione.ToolTipText = ""
        '
        'LabelCeppo
        '
        Me.LabelCeppo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCeppo.AutoSize = True
        Me.LabelCeppo.Location = New System.Drawing.Point(3, 94)
        Me.LabelCeppo.Name = "LabelCeppo"
        Me.LabelCeppo.Size = New System.Drawing.Size(38, 13)
        Me.LabelCeppo.TabIndex = 8
        Me.LabelCeppo.Text = "Ceppo"
        '
        'LabelEsito
        '
        Me.LabelEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEsito.AutoSize = True
        Me.LabelEsito.Location = New System.Drawing.Point(3, 53)
        Me.LabelEsito.Name = "LabelEsito"
        Me.LabelEsito.Size = New System.Drawing.Size(30, 13)
        Me.LabelEsito.TabIndex = 6
        Me.LabelEsito.Text = "Esito"
        '
        'LabelDataEsecuzione
        '
        Me.LabelDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDataEsecuzione.AutoSize = True
        Me.LabelDataEsecuzione.Location = New System.Drawing.Point(3, 13)
        Me.LabelDataEsecuzione.Name = "LabelDataEsecuzione"
        Me.LabelDataEsecuzione.Size = New System.Drawing.Size(87, 13)
        Me.LabelDataEsecuzione.TabIndex = 4
        Me.LabelDataEsecuzione.Text = "Data esecuzione"
        '
        'UC_VisitaDNATest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelDNA)
        Me.Name = "UC_VisitaDNATest"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelDNA.ResumeLayout(False)
        Me.TableLayoutPanelNuovoDNATest.ResumeLayout(False)
        Me.TableLayoutPanelNuovoDNATest.PerformLayout()
        Me.TableLayoutPanelDatiDNA.ResumeLayout(False)
        Me.TableLayoutPanelDatiDNA.PerformLayout()
        CType(Me.ComboBoxCeppo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelDNA As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelDatiDNA As TableLayoutPanel
    Friend WithEvents DateTimePickerDataEsecuzione As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents LabelCeppo As Label
    Friend WithEvents LabelEsito As Label
    Friend WithEvents LabelDataEsecuzione As Label
    Friend WithEvents TableLayoutPanelNuovoDNATest As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents ComboBoxCeppo As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents ComboBoxEsito As Syncfusion.WinForms.ListView.SfComboBox
End Class
