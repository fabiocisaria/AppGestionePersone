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
        Me.TableLayoutPanelFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelNuovoFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDatiFarmaco = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxViaSomministrazione = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.ComboBoxClasse = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.TextBoxPrincipioAttivo = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxNomeCommerciale = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelViaSomministrazione = New System.Windows.Forms.Label()
        Me.LabelClasse = New System.Windows.Forms.Label()
        Me.LabelPrincipioAttivo = New System.Windows.Forms.Label()
        Me.LabelNomeCommerciale = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanelFarmaco.SuspendLayout()
        Me.TableLayoutPanelNuovoFarmaco.SuspendLayout()
        Me.TableLayoutPanelDatiFarmaco.SuspendLayout()
        CType(Me.ComboBoxViaSomministrazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxClasse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxPrincipioAttivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxNomeCommerciale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelFarmaco
        '
        Me.TableLayoutPanelFarmaco.ColumnCount = 1
        Me.TableLayoutPanelFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelFarmaco.Controls.Add(Me.TableLayoutPanelNuovoFarmaco, 0, 0)
        Me.TableLayoutPanelFarmaco.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanelFarmaco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelFarmaco.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelFarmaco.Name = "TableLayoutPanelFarmaco"
        Me.TableLayoutPanelFarmaco.RowCount = 2
        Me.TableLayoutPanelFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelFarmaco.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelFarmaco.TabIndex = 2
        '
        'TableLayoutPanelNuovoFarmaco
        '
        Me.TableLayoutPanelNuovoFarmaco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelNuovoFarmaco.ColumnCount = 1
        Me.TableLayoutPanelNuovoFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoFarmaco.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanelNuovoFarmaco.Controls.Add(Me.TableLayoutPanelDatiFarmaco, 0, 1)
        Me.TableLayoutPanelNuovoFarmaco.Location = New System.Drawing.Point(183, 132)
        Me.TableLayoutPanelNuovoFarmaco.Name = "TableLayoutPanelNuovoFarmaco"
        Me.TableLayoutPanelNuovoFarmaco.RowCount = 2
        Me.TableLayoutPanelNuovoFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelNuovoFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNuovoFarmaco.Size = New System.Drawing.Size(400, 211)
        Me.TableLayoutPanelNuovoFarmaco.TabIndex = 20
        Me.TableLayoutPanelNuovoFarmaco.Tag = "PrimaryPanel"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Tag = "PrimaryTitle"
        Me.Label2.Text = "Dati farmaco"
        '
        'TableLayoutPanelDatiFarmaco
        '
        Me.TableLayoutPanelDatiFarmaco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanelDatiFarmaco.ColumnCount = 2
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelDatiFarmaco.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.ComboBoxViaSomministrazione, 1, 3)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.ComboBoxClasse, 1, 2)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.TextBoxPrincipioAttivo, 1, 1)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.TextBoxNomeCommerciale, 1, 0)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelViaSomministrazione, 0, 3)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelClasse, 0, 2)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelPrincipioAttivo, 0, 1)
        Me.TableLayoutPanelDatiFarmaco.Controls.Add(Me.LabelNomeCommerciale, 0, 0)
        Me.TableLayoutPanelDatiFarmaco.Location = New System.Drawing.Point(10, 45)
        Me.TableLayoutPanelDatiFarmaco.Name = "TableLayoutPanelDatiFarmaco"
        Me.TableLayoutPanelDatiFarmaco.RowCount = 4
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelDatiFarmaco.Size = New System.Drawing.Size(380, 151)
        Me.TableLayoutPanelDatiFarmaco.TabIndex = 0
        '
        'ComboBoxViaSomministrazione
        '
        Me.ComboBoxViaSomministrazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxViaSomministrazione.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxViaSomministrazione.AutoCompleteSuggestDelay = 1
        Me.ComboBoxViaSomministrazione.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxViaSomministrazione.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxViaSomministrazione.Location = New System.Drawing.Point(153, 120)
        Me.ComboBoxViaSomministrazione.Name = "ComboBoxViaSomministrazione"
        Me.ComboBoxViaSomministrazione.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxViaSomministrazione.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ComboBoxViaSomministrazione.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxViaSomministrazione.TabIndex = 27
        Me.ComboBoxViaSomministrazione.TabStop = False
        Me.ComboBoxViaSomministrazione.Tag = "Find"
        '
        'ComboBoxClasse
        '
        Me.ComboBoxClasse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxClasse.AutoCompleteSuggestDelay = 1
        Me.ComboBoxClasse.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        Me.ComboBoxClasse.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center
        Me.ComboBoxClasse.Location = New System.Drawing.Point(153, 82)
        Me.ComboBoxClasse.Name = "ComboBoxClasse"
        Me.ComboBoxClasse.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxClasse.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxClasse.TabIndex = 26
        Me.ComboBoxClasse.TabStop = False
        Me.ComboBoxClasse.Tag = "Find"
        '
        'TextBoxPrincipioAttivo
        '
        Me.TextBoxPrincipioAttivo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxPrincipioAttivo.BeforeTouchSize = New System.Drawing.Size(200, 20)
        Me.TextBoxPrincipioAttivo.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxPrincipioAttivo.Location = New System.Drawing.Point(153, 45)
        Me.TextBoxPrincipioAttivo.Name = "TextBoxPrincipioAttivo"
        Me.TextBoxPrincipioAttivo.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxPrincipioAttivo.TabIndex = 25
        Me.TextBoxPrincipioAttivo.Tag = "Find"
        Me.TextBoxPrincipioAttivo.Text = "Principio attivo"
        '
        'TextBoxNomeCommerciale
        '
        Me.TextBoxNomeCommerciale.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxNomeCommerciale.BeforeTouchSize = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeCommerciale.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNomeCommerciale.Location = New System.Drawing.Point(153, 8)
        Me.TextBoxNomeCommerciale.Name = "TextBoxNomeCommerciale"
        Me.TextBoxNomeCommerciale.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxNomeCommerciale.TabIndex = 24
        Me.TextBoxNomeCommerciale.Tag = "Find"
        Me.TextBoxNomeCommerciale.Text = "Nome commerciale"
        '
        'LabelViaSomministrazione
        '
        Me.LabelViaSomministrazione.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelViaSomministrazione.AutoSize = True
        Me.LabelViaSomministrazione.Location = New System.Drawing.Point(3, 124)
        Me.LabelViaSomministrazione.Name = "LabelViaSomministrazione"
        Me.LabelViaSomministrazione.Size = New System.Drawing.Size(115, 13)
        Me.LabelViaSomministrazione.TabIndex = 13
        Me.LabelViaSomministrazione.Text = "Via di somministrazione"
        '
        'LabelClasse
        '
        Me.LabelClasse.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelClasse.AutoSize = True
        Me.LabelClasse.Location = New System.Drawing.Point(3, 86)
        Me.LabelClasse.Name = "LabelClasse"
        Me.LabelClasse.Size = New System.Drawing.Size(38, 13)
        Me.LabelClasse.TabIndex = 8
        Me.LabelClasse.Text = "Classe"
        '
        'LabelPrincipioAttivo
        '
        Me.LabelPrincipioAttivo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPrincipioAttivo.AutoSize = True
        Me.LabelPrincipioAttivo.Location = New System.Drawing.Point(3, 49)
        Me.LabelPrincipioAttivo.Name = "LabelPrincipioAttivo"
        Me.LabelPrincipioAttivo.Size = New System.Drawing.Size(77, 13)
        Me.LabelPrincipioAttivo.TabIndex = 6
        Me.LabelPrincipioAttivo.Text = "Principio Attivo"
        '
        'LabelNomeCommerciale
        '
        Me.LabelNomeCommerciale.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomeCommerciale.AutoSize = True
        Me.LabelNomeCommerciale.Location = New System.Drawing.Point(3, 12)
        Me.LabelNomeCommerciale.Name = "LabelNomeCommerciale"
        Me.LabelNomeCommerciale.Size = New System.Drawing.Size(97, 13)
        Me.LabelNomeCommerciale.TabIndex = 4
        Me.LabelNomeCommerciale.Text = "Nome commerciale"
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
        'UC_Farmaco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelFarmaco)
        Me.Name = "UC_Farmaco"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelNuovoFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelNuovoFarmaco.PerformLayout()
        Me.TableLayoutPanelDatiFarmaco.ResumeLayout(False)
        Me.TableLayoutPanelDatiFarmaco.PerformLayout()
        CType(Me.ComboBoxViaSomministrazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxClasse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxPrincipioAttivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxNomeCommerciale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelFarmaco As TableLayoutPanel
    Friend WithEvents TableLayoutPanelDatiFarmaco As TableLayoutPanel
    Friend WithEvents LabelClasse As Label
    Friend WithEvents LabelPrincipioAttivo As Label
    Friend WithEvents LabelNomeCommerciale As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents LabelViaSomministrazione As Label
    Friend WithEvents TableLayoutPanelNuovoFarmaco As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPrincipioAttivo As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxNomeCommerciale As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents ComboBoxClasse As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents ComboBoxViaSomministrazione As Syncfusion.WinForms.ListView.SfComboBox
End Class
