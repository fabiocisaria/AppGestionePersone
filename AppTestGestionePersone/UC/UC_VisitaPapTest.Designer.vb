<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_VisitaPapTest
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
        Me.TableLayoutPanelPapTest = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelNuovoPapTest = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDatiPapTest = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimePickerDataEsecuzione = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelEsito = New System.Windows.Forms.Label()
        Me.LabelDataEsecuzione = New System.Windows.Forms.Label()
        Me.ComboBoxEsito = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.TableLayoutPanelPapTest.SuspendLayout()
        Me.TableLayoutPanelNuovoPapTest.SuspendLayout()
        Me.TableLayoutPanelDatiPapTest.SuspendLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelPapTest
        '
        Me.TableLayoutPanelPapTest.ColumnCount = 1
        Me.TableLayoutPanelPapTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPapTest.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelPapTest.Controls.Add(Me.TableLayoutPanelNuovoPapTest, 0, 0)
        Me.TableLayoutPanelPapTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPapTest.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPapTest.Name = "TableLayoutPanelPapTest"
        Me.TableLayoutPanelPapTest.RowCount = 2
        Me.TableLayoutPanelPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPapTest.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelPapTest.TabIndex = 2
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
        'TableLayoutPanelNuovoPapTest
        '
        Me.TableLayoutPanelNuovoPapTest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovoPapTest.ColumnCount = 1
        Me.TableLayoutPanelNuovoPapTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoPapTest.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovoPapTest.Controls.Add(Me.TableLayoutPanelDatiPapTest, 0, 1)
        Me.TableLayoutPanelNuovoPapTest.Location = New System.Drawing.Point(183, 181)
        Me.TableLayoutPanelNuovoPapTest.Name = "TableLayoutPanelNuovoPapTest"
        Me.TableLayoutPanelNuovoPapTest.RowCount = 2
        Me.TableLayoutPanelNuovoPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovoPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoPapTest.Size = New System.Drawing.Size(400, 114)
        Me.TableLayoutPanelNuovoPapTest.TabIndex = 23
        Me.TableLayoutPanelNuovoPapTest.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(46, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Pap test"
        '
        'TableLayoutPanelDatiPapTest
        '
        Me.TableLayoutPanelDatiPapTest.ColumnCount = 2
        Me.TableLayoutPanelDatiPapTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelDatiPapTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiPapTest.Controls.Add(Me.ComboBoxEsito, 1, 1)
        Me.TableLayoutPanelDatiPapTest.Controls.Add(Me.DateTimePickerDataEsecuzione, 1, 0)
        Me.TableLayoutPanelDatiPapTest.Controls.Add(Me.LabelEsito, 0, 1)
        Me.TableLayoutPanelDatiPapTest.Controls.Add(Me.LabelDataEsecuzione, 0, 0)
        Me.TableLayoutPanelDatiPapTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatiPapTest.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanelDatiPapTest.Name = "TableLayoutPanelDatiPapTest"
        Me.TableLayoutPanelDatiPapTest.RowCount = 2
        Me.TableLayoutPanelDatiPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiPapTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelDatiPapTest.Size = New System.Drawing.Size(394, 78)
        Me.TableLayoutPanelDatiPapTest.TabIndex = 0
        '
        'DateTimePickerDataEsecuzione
        '
        Me.DateTimePickerDataEsecuzione.AllowNull = True
        Me.DateTimePickerDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataEsecuzione.DateTimeIcon = Nothing
        Me.DateTimePickerDataEsecuzione.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataEsecuzione.Location = New System.Drawing.Point(153, 9)
        Me.DateTimePickerDataEsecuzione.Name = "DateTimePickerDataEsecuzione"
        Me.DateTimePickerDataEsecuzione.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerDataEsecuzione.TabIndex = 11
        Me.DateTimePickerDataEsecuzione.ToolTipText = ""
        '
        'LabelEsito
        '
        Me.LabelEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEsito.AutoSize = True
        Me.LabelEsito.Location = New System.Drawing.Point(3, 52)
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
        'ComboBoxEsito
        '
        Me.ComboBoxEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEsito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxEsito.AutoCompleteSuggestDelay = 1
        Me.ComboBoxEsito.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxEsito.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxEsito.Location = New System.Drawing.Point(153, 48)
        Me.ComboBoxEsito.Name = "ComboBoxEsito"
        Me.ComboBoxEsito.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEsito.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEsito.TabIndex = 25
        Me.ComboBoxEsito.TabStop = False
        Me.ComboBoxEsito.Tag = "Find"
        '
        'UC_VisitaPapTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelPapTest)
        Me.Name = "UC_VisitaPapTest"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelPapTest.ResumeLayout(False)
        Me.TableLayoutPanelNuovoPapTest.ResumeLayout(False)
        Me.TableLayoutPanelNuovoPapTest.PerformLayout()
        Me.TableLayoutPanelDatiPapTest.ResumeLayout(False)
        Me.TableLayoutPanelDatiPapTest.PerformLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelPapTest As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelDatiPapTest As TableLayoutPanel
    Friend WithEvents DateTimePickerDataEsecuzione As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents LabelEsito As Label
    Friend WithEvents LabelDataEsecuzione As Label
    Friend WithEvents TableLayoutPanelNuovoPapTest As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents ComboBoxEsito As Syncfusion.WinForms.ListView.SfComboBox
End Class
