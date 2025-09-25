<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_DatiPaziente
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
        Me.TableLayoutPanelDatiPaziente = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxCognome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxNome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxCodiceID = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxDataNascita = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelPazienteSelezionato = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TableLayoutPanelDatiPaziente.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TextBoxCognome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxCodiceID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxDataNascita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelDatiPaziente
        '
        Me.TableLayoutPanelDatiPaziente.ColumnCount = 1
        Me.TableLayoutPanelDatiPaziente.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiPaziente.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelDatiPaziente.Controls.Add(Me.LabelPazienteSelezionato, 0, 0)
        Me.TableLayoutPanelDatiPaziente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatiPaziente.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelDatiPaziente.Name = "TableLayoutPanelDatiPaziente"
        Me.TableLayoutPanelDatiPaziente.RowCount = 2
        Me.TableLayoutPanelDatiPaziente.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanelDatiPaziente.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanelDatiPaziente.Size = New System.Drawing.Size(766, 60)
        Me.TableLayoutPanelDatiPaziente.TabIndex = 1
        Me.TableLayoutPanelDatiPaziente.Tag = "Dati"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxCognome, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxNome, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxCodiceID, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxDataNascita, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 27)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 30)
        Me.TableLayoutPanel2.TabIndex = 0
        Me.TableLayoutPanel2.Tag = "Dati"
        '
        'TextBoxCognome
        '
        Me.TextBoxCognome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxCognome.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxCognome.BeforeTouchSize = New System.Drawing.Size(105, 20)
        Me.TextBoxCognome.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxCognome.Location = New System.Drawing.Point(10, 5)
        Me.TextBoxCognome.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.TextBoxCognome.Name = "TextBoxCognome"
        Me.TextBoxCognome.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxCognome.TabIndex = 0
        Me.TextBoxCognome.Tag = "Code"
        Me.TextBoxCognome.Text = "Cognome"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxNome.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxNome.BeforeTouchSize = New System.Drawing.Size(105, 20)
        Me.TextBoxNome.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxNome.Location = New System.Drawing.Point(137, 5)
        Me.TextBoxNome.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(111, 20)
        Me.TextBoxNome.TabIndex = 0
        Me.TextBoxNome.Tag = "Code"
        Me.TextBoxNome.Text = "Nome"
        '
        'TextBoxCodiceID
        '
        Me.TextBoxCodiceID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxCodiceID.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxCodiceID.BeforeTouchSize = New System.Drawing.Size(105, 20)
        Me.TextBoxCodiceID.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxCodiceID.Location = New System.Drawing.Point(261, 5)
        Me.TextBoxCodiceID.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.TextBoxCodiceID.Name = "TextBoxCodiceID"
        Me.TextBoxCodiceID.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxCodiceID.TabIndex = 0
        Me.TextBoxCodiceID.Tag = "Code"
        Me.TextBoxCodiceID.Text = "Codice identificativo"
        '
        'TextBoxDataNascita
        '
        Me.TextBoxDataNascita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxDataNascita.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxDataNascita.BeforeTouchSize = New System.Drawing.Size(105, 20)
        Me.TextBoxDataNascita.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxDataNascita.Location = New System.Drawing.Point(387, 5)
        Me.TextBoxDataNascita.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.TextBoxDataNascita.Name = "TextBoxDataNascita"
        Me.TextBoxDataNascita.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxDataNascita.TabIndex = 0
        Me.TextBoxDataNascita.Tag = "Code"
        Me.TextBoxDataNascita.Text = "Data di nascita"
        '
        'LabelPazienteSelezionato
        '
        Me.LabelPazienteSelezionato.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPazienteSelezionato.Location = New System.Drawing.Point(3, 5)
        Me.LabelPazienteSelezionato.Name = "LabelPazienteSelezionato"
        Me.LabelPazienteSelezionato.Size = New System.Drawing.Size(104, 13)
        Me.LabelPazienteSelezionato.TabIndex = 1
        Me.LabelPazienteSelezionato.Tag = "TitlePaziente"
        Me.LabelPazienteSelezionato.Text = "Paziente selezionato"
        '
        'UC_DatiPaziente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanelDatiPaziente)
        Me.Name = "UC_DatiPaziente"
        Me.Size = New System.Drawing.Size(766, 60)
        Me.Tag = "DatiPaziente"
        Me.TableLayoutPanelDatiPaziente.ResumeLayout(False)
        Me.TableLayoutPanelDatiPaziente.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TextBoxCognome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxCodiceID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxDataNascita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelDatiPaziente As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBoxCognome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxNome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxCodiceID As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxDataNascita As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LabelPazienteSelezionato As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
