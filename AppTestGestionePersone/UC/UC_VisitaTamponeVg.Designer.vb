<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_VisitaTamponeVg
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
        Me.TableLayoutPanelTamponeVg = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelNuovaTampVg = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDatiTammVg = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimePickerDataEsecuzione = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.LabelEsito = New System.Windows.Forms.Label()
        Me.LabelDataEsecuzione = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.ComboBoxEsito = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.TableLayoutPanelTamponeVg.SuspendLayout()
        Me.TableLayoutPanelNuovaTampVg.SuspendLayout()
        Me.TableLayoutPanelDatiTammVg.SuspendLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelTamponeVg
        '
        Me.TableLayoutPanelTamponeVg.ColumnCount = 1
        Me.TableLayoutPanelTamponeVg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTamponeVg.Controls.Add(Me.TableLayoutPanelNuovaTampVg, 0, 0)
        Me.TableLayoutPanelTamponeVg.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelTamponeVg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelTamponeVg.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelTamponeVg.Name = "TableLayoutPanelTamponeVg"
        Me.TableLayoutPanelTamponeVg.RowCount = 2
        Me.TableLayoutPanelTamponeVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTamponeVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelTamponeVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTamponeVg.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelTamponeVg.TabIndex = 4
        '
        'TableLayoutPanelNuovaTampVg
        '
        Me.TableLayoutPanelNuovaTampVg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovaTampVg.ColumnCount = 1
        Me.TableLayoutPanelNuovaTampVg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaTampVg.Controls.Add(Me.LabelTitolo, 0, 0)
        Me.TableLayoutPanelNuovaTampVg.Controls.Add(Me.TableLayoutPanelDatiTammVg, 0, 1)
        Me.TableLayoutPanelNuovaTampVg.Location = New System.Drawing.Point(183, 179)
        Me.TableLayoutPanelNuovaTampVg.Name = "TableLayoutPanelNuovaTampVg"
        Me.TableLayoutPanelNuovaTampVg.RowCount = 2
        Me.TableLayoutPanelNuovaTampVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovaTampVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovaTampVg.Size = New System.Drawing.Size(400, 118)
        Me.TableLayoutPanelNuovaTampVg.TabIndex = 25
        Me.TableLayoutPanelNuovaTampVg.Tag = "PrimaryPanel"
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(3, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(95, 13)
        Me.LabelTitolo.TabIndex = 16
        Me.LabelTitolo.Tag = "PrimaryTitle"
        Me.LabelTitolo.Text = "Tampone vaginale"
        '
        'TableLayoutPanelDatiTammVg
        '
        Me.TableLayoutPanelDatiTammVg.ColumnCount = 2
        Me.TableLayoutPanelDatiTammVg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelDatiTammVg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiTammVg.Controls.Add(Me.ComboBoxEsito, 1, 1)
        Me.TableLayoutPanelDatiTammVg.Controls.Add(Me.DateTimePickerDataEsecuzione, 1, 0)
        Me.TableLayoutPanelDatiTammVg.Controls.Add(Me.LabelEsito, 0, 1)
        Me.TableLayoutPanelDatiTammVg.Controls.Add(Me.LabelDataEsecuzione, 0, 0)
        Me.TableLayoutPanelDatiTammVg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatiTammVg.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanelDatiTammVg.Name = "TableLayoutPanelDatiTammVg"
        Me.TableLayoutPanelDatiTammVg.RowCount = 2
        Me.TableLayoutPanelDatiTammVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiTammVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiTammVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanelDatiTammVg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelDatiTammVg.Size = New System.Drawing.Size(394, 82)
        Me.TableLayoutPanelDatiTammVg.TabIndex = 0
        '
        'DateTimePickerDataEsecuzione
        '
        Me.DateTimePickerDataEsecuzione.AllowNull = True
        Me.DateTimePickerDataEsecuzione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePickerDataEsecuzione.DateTimeIcon = Nothing
        Me.DateTimePickerDataEsecuzione.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate
        Me.DateTimePickerDataEsecuzione.Location = New System.Drawing.Point(153, 10)
        Me.DateTimePickerDataEsecuzione.Name = "DateTimePickerDataEsecuzione"
        Me.DateTimePickerDataEsecuzione.Size = New System.Drawing.Size(200, 21)
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
        Me.ComboBoxEsito.Location = New System.Drawing.Point(153, 51)
        Me.ComboBoxEsito.Name = "ComboBoxEsito"
        Me.ComboBoxEsito.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEsito.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEsito.TabIndex = 30
        Me.ComboBoxEsito.TabStop = False
        Me.ComboBoxEsito.Tag = "Find"
        '
        'UC_VisitaTamponeVg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelTamponeVg)
        Me.Name = "UC_VisitaTamponeVg"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelTamponeVg.ResumeLayout(False)
        Me.TableLayoutPanelNuovaTampVg.ResumeLayout(False)
        Me.TableLayoutPanelNuovaTampVg.PerformLayout()
        Me.TableLayoutPanelDatiTammVg.ResumeLayout(False)
        Me.TableLayoutPanelDatiTammVg.PerformLayout()
        CType(Me.ComboBoxEsito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelTamponeVg As TableLayoutPanel
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents TableLayoutPanelDatiTammVg As TableLayoutPanel
    Friend WithEvents DateTimePickerDataEsecuzione As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents LabelEsito As Label
    Friend WithEvents LabelDataEsecuzione As Label
    Friend WithEvents TableLayoutPanelNuovaTampVg As TableLayoutPanel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents ComboBoxEsito As Syncfusion.WinForms.ListView.SfComboBox
End Class
