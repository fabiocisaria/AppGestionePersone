<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_VisitaPapTest
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
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.GroupBoxPapTest = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelDatiRMN = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxEsito = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDataEsecuzione = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelEsito = New System.Windows.Forms.Label()
        Me.LabelDataEsecuzione = New System.Windows.Forms.Label()
        Me.LabelCeppo = New System.Windows.Forms.Label()
        Me.ComboBoxCeppo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanelRmn.SuspendLayout()
        Me.GroupBoxPapTest.SuspendLayout()
        Me.TableLayoutPanelDatiRMN.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelRmn
        '
        Me.TableLayoutPanelRmn.ColumnCount = 1
        Me.TableLayoutPanelRmn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelRmn.Controls.Add(Me.GroupBoxPapTest, 0, 0)
        Me.TableLayoutPanelRmn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRmn.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelRmn.Name = "TableLayoutPanelRmn"
        Me.TableLayoutPanelRmn.RowCount = 2
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelRmn.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelRmn.TabIndex = 2
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
        'GroupBoxPapTest
        '
        Me.GroupBoxPapTest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxPapTest.Controls.Add(Me.TableLayoutPanelDatiRMN)
        Me.GroupBoxPapTest.Location = New System.Drawing.Point(210, 166)
        Me.GroupBoxPapTest.Name = "GroupBoxPapTest"
        Me.GroupBoxPapTest.Size = New System.Drawing.Size(346, 144)
        Me.GroupBoxPapTest.TabIndex = 1
        Me.GroupBoxPapTest.TabStop = False
        Me.GroupBoxPapTest.Text = "Pap test"
        '
        'TableLayoutPanelDatiRMN
        '
        Me.TableLayoutPanelDatiRMN.ColumnCount = 2
        Me.TableLayoutPanelDatiRMN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelDatiRMN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.ComboBoxCeppo, 1, 2)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.ComboBoxEsito, 1, 1)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.DateTimePickerDataEsecuzione, 1, 0)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.LabelCeppo, 0, 2)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.LabelEsito, 0, 1)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.LabelDataEsecuzione, 0, 0)
        Me.TableLayoutPanelDatiRMN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatiRMN.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelDatiRMN.Name = "TableLayoutPanelDatiRMN"
        Me.TableLayoutPanelDatiRMN.RowCount = 3
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelDatiRMN.Size = New System.Drawing.Size(340, 125)
        Me.TableLayoutPanelDatiRMN.TabIndex = 0
        '
        'ComboBoxEsito
        '
        Me.ComboBoxEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEsito.FormattingEnabled = True
        Me.ComboBoxEsito.Items.AddRange(New Object() {"Negativo", "Positivo"})
        Me.ComboBoxEsito.Location = New System.Drawing.Point(153, 51)
        Me.ComboBoxEsito.Name = "ComboBoxEsito"
        Me.ComboBoxEsito.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxEsito.TabIndex = 14
        '
        'DateTimePickerDataEsecuzione
        '
        Me.DateTimePickerDataEsecuzione.AllowNull = True
        Me.DateTimePickerDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataEsecuzione.DateTimeIcon = Nothing
        Me.DateTimePickerDataEsecuzione.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataEsecuzione.Location = New System.Drawing.Point(153, 10)
        Me.DateTimePickerDataEsecuzione.Name = "DateTimePickerDataEsecuzione"
        Me.DateTimePickerDataEsecuzione.Size = New System.Drawing.Size(166, 21)
        Me.DateTimePickerDataEsecuzione.TabIndex = 11
        Me.DateTimePickerDataEsecuzione.ToolTipText = ""
        '
        'LabelEsito
        '
        Me.LabelEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEsito.AutoSize = True
        Me.LabelEsito.Location = New System.Drawing.Point(3, 55)
        Me.LabelEsito.Name = "LabelEsito"
        Me.LabelEsito.Size = New System.Drawing.Size(30, 13)
        Me.LabelEsito.TabIndex = 6
        Me.LabelEsito.Text = "Esito"
        '
        'LabelDataEsecuzione
        '
        Me.LabelDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDataEsecuzione.AutoSize = True
        Me.LabelDataEsecuzione.Location = New System.Drawing.Point(3, 14)
        Me.LabelDataEsecuzione.Name = "LabelDataEsecuzione"
        Me.LabelDataEsecuzione.Size = New System.Drawing.Size(87, 13)
        Me.LabelDataEsecuzione.TabIndex = 4
        Me.LabelDataEsecuzione.Text = "Data esecuzione"
        '
        'LabelCeppo
        '
        Me.LabelCeppo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCeppo.AutoSize = True
        Me.LabelCeppo.Location = New System.Drawing.Point(3, 97)
        Me.LabelCeppo.Name = "LabelCeppo"
        Me.LabelCeppo.Size = New System.Drawing.Size(38, 13)
        Me.LabelCeppo.TabIndex = 8
        Me.LabelCeppo.Text = "Ceppo"
        '
        'ComboBoxCeppo
        '
        Me.ComboBoxCeppo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxCeppo.FormattingEnabled = True
        Me.ComboBoxCeppo.Items.AddRange(New Object() {"Tradizionale", "IQOS", "Elettronica"})
        Me.ComboBoxCeppo.Location = New System.Drawing.Point(153, 93)
        Me.ComboBoxCeppo.Name = "ComboBoxCeppo"
        Me.ComboBoxCeppo.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxCeppo.TabIndex = 28
        '
        'UC_VisitaPapTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelRmn)
        Me.Name = "UC_VisitaPapTest"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelRmn.ResumeLayout(False)
        Me.GroupBoxPapTest.ResumeLayout(False)
        Me.TableLayoutPanelDatiRMN.ResumeLayout(False)
        Me.TableLayoutPanelDatiRMN.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelRmn As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents GroupBoxPapTest As GroupBox
    Friend WithEvents TableLayoutPanelDatiRMN As TableLayoutPanel
    Friend WithEvents ComboBoxCeppo As ComboBox
    Friend WithEvents ComboBoxEsito As ComboBox
    Friend WithEvents DateTimePickerDataEsecuzione As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents LabelCeppo As Label
    Friend WithEvents LabelEsito As Label
    Friend WithEvents LabelDataEsecuzione As Label
End Class
