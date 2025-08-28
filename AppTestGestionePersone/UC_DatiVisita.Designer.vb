<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_DatiVisita
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
        Me.TableLayoutPanelDatiPaziente = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxTipoVisita = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxDataVisita = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelVisitaSelezionata = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TableLayoutPanelDatiPaziente.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TextBoxTipoVisita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxDataVisita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelDatiPaziente
        '
        Me.TableLayoutPanelDatiPaziente.ColumnCount = 1
        Me.TableLayoutPanelDatiPaziente.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiPaziente.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelDatiPaziente.Controls.Add(Me.LabelVisitaSelezionata, 0, 0)
        Me.TableLayoutPanelDatiPaziente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatiPaziente.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelDatiPaziente.Name = "TableLayoutPanelDatiPaziente"
        Me.TableLayoutPanelDatiPaziente.RowCount = 2
        Me.TableLayoutPanelDatiPaziente.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanelDatiPaziente.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanelDatiPaziente.Size = New System.Drawing.Size(766, 60)
        Me.TableLayoutPanelDatiPaziente.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxTipoVisita, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxDataVisita, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 27)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(760, 30)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBoxTipoVisita
        '
        Me.TextBoxTipoVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxTipoVisita.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxTipoVisita.BeforeTouchSize = New System.Drawing.Size(94, 20)
        Me.TextBoxTipoVisita.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxTipoVisita.Location = New System.Drawing.Point(3, 5)
        Me.TextBoxTipoVisita.Name = "TextBoxTipoVisita"
        Me.TextBoxTipoVisita.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxTipoVisita.TabIndex = 0
        Me.TextBoxTipoVisita.Text = "Tipo visita"
        '
        'TextBoxDataVisita
        '
        Me.TextBoxDataVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxDataVisita.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxDataVisita.BeforeTouchSize = New System.Drawing.Size(94, 20)
        Me.TextBoxDataVisita.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxDataVisita.Location = New System.Drawing.Point(183, 5)
        Me.TextBoxDataVisita.Name = "TextBoxDataVisita"
        Me.TextBoxDataVisita.Size = New System.Drawing.Size(206, 20)
        Me.TextBoxDataVisita.TabIndex = 0
        Me.TextBoxDataVisita.Text = "Data visita"
        '
        'LabelVisitaSelezionata
        '
        Me.LabelVisitaSelezionata.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVisitaSelezionata.Location = New System.Drawing.Point(3, 5)
        Me.LabelVisitaSelezionata.Name = "LabelVisitaSelezionata"
        Me.LabelVisitaSelezionata.Size = New System.Drawing.Size(88, 13)
        Me.LabelVisitaSelezionata.TabIndex = 1
        Me.LabelVisitaSelezionata.Text = "Visita selezionata"
        '
        'UC_DatiVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelDatiPaziente)
        Me.Name = "UC_DatiVisita"
        Me.Size = New System.Drawing.Size(766, 60)
        Me.TableLayoutPanelDatiPaziente.ResumeLayout(False)
        Me.TableLayoutPanelDatiPaziente.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TextBoxTipoVisita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxDataVisita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelDatiPaziente As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBoxTipoVisita As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxDataVisita As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LabelVisitaSelezionata As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
