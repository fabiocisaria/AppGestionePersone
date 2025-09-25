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
        Me.DateTimePickerDataEsecuzione = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelDettagliEndometriosi = New System.Windows.Forms.Label()
        Me.LabelEsito = New System.Windows.Forms.Label()
        Me.LabelDataEsecuzione = New System.Windows.Forms.Label()
        Me.TableLayoutPanelRmn = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelNuovaRMN = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.ComboBoxEsito = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.ComboBoxEndometriosi = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.TableLayoutPanelDatiRMN.SuspendLayout()
        Me.TableLayoutPanelRmn.SuspendLayout()
        Me.TableLayoutPanelNuovaRMN.SuspendLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEndometriosi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanelDatiRMN.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanelDatiRMN.Name = "TableLayoutPanelDatiRMN"
        Me.TableLayoutPanelDatiRMN.RowCount = 3
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelDatiRMN.Size = New System.Drawing.Size(394, 109)
        Me.TableLayoutPanelDatiRMN.TabIndex = 0
        '
        'DateTimePickerDataEsecuzione
        '
        Me.DateTimePickerDataEsecuzione.AllowNull = True
        Me.DateTimePickerDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataEsecuzione.DateTimeIcon = Nothing
        Me.DateTimePickerDataEsecuzione.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataEsecuzione.Location = New System.Drawing.Point(153, 7)
        Me.DateTimePickerDataEsecuzione.Name = "DateTimePickerDataEsecuzione"
        Me.DateTimePickerDataEsecuzione.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerDataEsecuzione.TabIndex = 11
        Me.DateTimePickerDataEsecuzione.ToolTipText = ""
        '
        'LabelDettagliEndometriosi
        '
        Me.LabelDettagliEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDettagliEndometriosi.AutoSize = True
        Me.LabelDettagliEndometriosi.Location = New System.Drawing.Point(3, 84)
        Me.LabelDettagliEndometriosi.Name = "LabelDettagliEndometriosi"
        Me.LabelDettagliEndometriosi.Size = New System.Drawing.Size(105, 13)
        Me.LabelDettagliEndometriosi.TabIndex = 8
        Me.LabelDettagliEndometriosi.Text = "Dettagli endometriosi"
        '
        'LabelEsito
        '
        Me.LabelEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEsito.AutoSize = True
        Me.LabelEsito.Location = New System.Drawing.Point(3, 47)
        Me.LabelEsito.Name = "LabelEsito"
        Me.LabelEsito.Size = New System.Drawing.Size(30, 13)
        Me.LabelEsito.TabIndex = 6
        Me.LabelEsito.Text = "Esito"
        '
        'LabelDataEsecuzione
        '
        Me.LabelDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDataEsecuzione.AutoSize = True
        Me.LabelDataEsecuzione.Location = New System.Drawing.Point(3, 11)
        Me.LabelDataEsecuzione.Name = "LabelDataEsecuzione"
        Me.LabelDataEsecuzione.Size = New System.Drawing.Size(87, 13)
        Me.LabelDataEsecuzione.TabIndex = 4
        Me.LabelDataEsecuzione.Text = "Data esecuzione"
        '
        'TableLayoutPanelRmn
        '
        Me.TableLayoutPanelRmn.ColumnCount = 1
        Me.TableLayoutPanelRmn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.Controls.Add(Me.TableLayoutPanelNuovaRMN, 0, 1)
        Me.TableLayoutPanelRmn.Controls.Add(Me.ButtonInserisci, 0, 2)
        Me.TableLayoutPanelRmn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRmn.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelRmn.Name = "TableLayoutPanelRmn"
        Me.TableLayoutPanelRmn.RowCount = 3
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRmn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelRmn.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelRmn.TabIndex = 1
        '
        'TableLayoutPanelNuovaRMN
        '
        Me.TableLayoutPanelNuovaRMN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaRMN.ColumnCount = 1
        Me.TableLayoutPanelNuovaRMN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaRMN.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaRMN.Controls.Add(Me.TableLayoutPanelDatiRMN, 0, 1)
        Me.TableLayoutPanelNuovaRMN.Location = New System.Drawing.Point(183, 175)
        Me.TableLayoutPanelNuovaRMN.Name = "TableLayoutPanelNuovaRMN"
        Me.TableLayoutPanelNuovaRMN.RowCount = 2
        Me.TableLayoutPanelNuovaRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaRMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaRMN.Size = New System.Drawing.Size(400, 145)
        Me.TableLayoutPanelNuovaRMN.TabIndex = 24
        Me.TableLayoutPanelNuovaRMN.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(109, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Risonanza magnetica"
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
        'ComboBoxEsito
        '
        Me.ComboBoxEsito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEsito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxEsito.AutoCompleteSuggestDelay = 1
        Me.ComboBoxEsito.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxEsito.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxEsito.Location = New System.Drawing.Point(153, 43)
        Me.ComboBoxEsito.Name = "ComboBoxEsito"
        Me.ComboBoxEsito.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEsito.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEsito.TabIndex = 29
        Me.ComboBoxEsito.TabStop = False
        Me.ComboBoxEsito.Tag = "Find"
        '
        'ComboBoxEndometriosi
        '
        Me.ComboBoxEndometriosi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxEndometriosi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxEndometriosi.AutoCompleteSuggestDelay = 1
        Me.ComboBoxEndometriosi.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxEndometriosi.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxEndometriosi.Location = New System.Drawing.Point(153, 80)
        Me.ComboBoxEndometriosi.Name = "ComboBoxEndometriosi"
        Me.ComboBoxEndometriosi.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEndometriosi.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEndometriosi.TabIndex = 30
        Me.ComboBoxEndometriosi.TabStop = False
        Me.ComboBoxEndometriosi.Tag = "Find"
        '
        'UC_VisitaRMN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelRmn)
        Me.Name = "UC_VisitaRMN"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelDatiRMN.ResumeLayout(False)
        Me.TableLayoutPanelDatiRMN.PerformLayout()
        Me.TableLayoutPanelRmn.ResumeLayout(False)
        Me.TableLayoutPanelNuovaRMN.ResumeLayout(False)
        Me.TableLayoutPanelNuovaRMN.PerformLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEndometriosi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelDatiRMN As TableLayoutPanel
    Friend WithEvents LabelDettagliEndometriosi As Label
    Friend WithEvents LabelEsito As Label
    Friend WithEvents LabelDataEsecuzione As Label
    Friend WithEvents TableLayoutPanelRmn As TableLayoutPanel
    Friend WithEvents DateTimePickerDataEsecuzione As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelNuovaRMN As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents ComboBoxEsito As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents ComboBoxEndometriosi As Syncfusion.WinForms.ListView.SfComboBox
End Class
