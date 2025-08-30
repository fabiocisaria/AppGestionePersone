<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_VisitaRMN
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
        Me.TableLayoutPanelDatiRMN = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxEndometriosi = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.ComboBoxEsito = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.DateTimePickerDataEsecuzione = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelDettagliEndometriosi = New System.Windows.Forms.Label()
        Me.LabelEsito = New System.Windows.Forms.Label()
        Me.LabelDataEsecuzione = New System.Windows.Forms.Label()
        Me.TableLayoutPanelRmn = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.GroupBoxRMN = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelDatiRMN.SuspendLayout()
        CType(Me.ComboBoxEndometriosi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelRmn.SuspendLayout()
        Me.GroupBoxRMN.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelDatiRMN
        '
        Me.TableLayoutPanelDatiRMN.ColumnCount = 2
        Me.TableLayoutPanelDatiRMN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelDatiRMN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.ComboBoxEndometriosi, 1, 2)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.ComboBoxEsito, 1, 1)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.DateTimePickerDataEsecuzione, 1, 0)
        Me.TableLayoutPanelDatiRMN.Controls.Add(Me.LabelDettagliEndometriosi, 0, 2)
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
        'ComboBoxEndometriosi
        '
        Me.ComboBoxEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEndometriosi.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxEndometriosi.Location = New System.Drawing.Point(153, 93)
        Me.ComboBoxEndometriosi.Name = "ComboBoxEndometriosi"
        Me.ComboBoxEndometriosi.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxEndometriosi.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEndometriosi.TabIndex = 13
        Me.ComboBoxEndometriosi.TabStop = False
        '
        'ComboBoxEsito
        '
        Me.ComboBoxEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEsito.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxEsito.Location = New System.Drawing.Point(153, 51)
        Me.ComboBoxEsito.Name = "ComboBoxEsito"
        Me.ComboBoxEsito.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxEsito.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEsito.TabIndex = 12
        Me.ComboBoxEsito.TabStop = False
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
        'LabelDettagliEndometriosi
        '
        Me.LabelDettagliEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDettagliEndometriosi.AutoSize = True
        Me.LabelDettagliEndometriosi.Location = New System.Drawing.Point(3, 97)
        Me.LabelDettagliEndometriosi.Name = "LabelDettagliEndometriosi"
        Me.LabelDettagliEndometriosi.Size = New System.Drawing.Size(105, 13)
        Me.LabelDettagliEndometriosi.TabIndex = 8
        Me.LabelDettagliEndometriosi.Text = "Dettagli endometriosi"
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
        'TableLayoutPanelRmn
        '
        Me.TableLayoutPanelRmn.ColumnCount = 1
        Me.TableLayoutPanelRmn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelRmn.Controls.Add(Me.GroupBoxRMN, 0, 0)
        Me.TableLayoutPanelRmn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRmn.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelRmn.Name = "TableLayoutPanelRmn"
        Me.TableLayoutPanelRmn.RowCount = 2
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelRmn.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelRmn.TabIndex = 1
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
        'GroupBoxRMN
        '
        Me.GroupBoxRMN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxRMN.Controls.Add(Me.TableLayoutPanelDatiRMN)
        Me.GroupBoxRMN.Location = New System.Drawing.Point(210, 166)
        Me.GroupBoxRMN.Name = "GroupBoxRMN"
        Me.GroupBoxRMN.Size = New System.Drawing.Size(346, 144)
        Me.GroupBoxRMN.TabIndex = 1
        Me.GroupBoxRMN.TabStop = False
        Me.GroupBoxRMN.Text = "Dettagli risonanza magnetica"
        '
        'UC_RMN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelRmn)
        Me.Name = "UC_RMN"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelDatiRMN.ResumeLayout(False)
        Me.TableLayoutPanelDatiRMN.PerformLayout()
        CType(Me.ComboBoxEndometriosi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelRmn.ResumeLayout(False)
        Me.GroupBoxRMN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelDatiRMN As TableLayoutPanel
    Friend WithEvents LabelDettagliEndometriosi As Label
    Friend WithEvents LabelEsito As Label
    Friend WithEvents LabelDataEsecuzione As Label
    Friend WithEvents TableLayoutPanelRmn As TableLayoutPanel
    Friend WithEvents GroupBoxRMN As GroupBox
    Friend WithEvents DateTimePickerDataEsecuzione As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents ComboBoxEndometriosi As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents ComboBoxEsito As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
