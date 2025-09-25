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
        Me.TableLayoutPanelDatiVisita = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxTipoVisita = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxDataVisita = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LabelVisitaSelezionata = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TableLayoutPanelDatiVisita.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TextBoxTipoVisita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxDataVisita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelDatiVisita
        '
        Me.TableLayoutPanelDatiVisita.ColumnCount = 1
        Me.TableLayoutPanelDatiVisita.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelDatiVisita.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanelDatiVisita.Controls.Add(Me.LabelVisitaSelezionata, 0, 0)
        Me.TableLayoutPanelDatiVisita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelDatiVisita.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelDatiVisita.Name = "TableLayoutPanelDatiVisita"
        Me.TableLayoutPanelDatiVisita.RowCount = 2
        Me.TableLayoutPanelDatiVisita.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanelDatiVisita.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanelDatiVisita.Size = New System.Drawing.Size(766, 60)
        Me.TableLayoutPanelDatiVisita.TabIndex = 2
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
        Me.TableLayoutPanel2.Tag = "Dati"
        '
        'TextBoxTipoVisita
        '
        Me.TextBoxTipoVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxTipoVisita.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxTipoVisita.BeforeTouchSize = New System.Drawing.Size(105, 20)
        Me.TextBoxTipoVisita.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxTipoVisita.Location = New System.Drawing.Point(3, 5)
        Me.TextBoxTipoVisita.Name = "TextBoxTipoVisita"
        Me.TextBoxTipoVisita.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxTipoVisita.TabIndex = 0
        Me.TextBoxTipoVisita.Tag = "Code"
        Me.TextBoxTipoVisita.Text = "Tipo visita"
        '
        'TextBoxDataVisita
        '
        Me.TextBoxDataVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxDataVisita.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxDataVisita.BeforeTouchSize = New System.Drawing.Size(105, 20)
        Me.TextBoxDataVisita.BorderColor = System.Drawing.Color.Transparent
        Me.TextBoxDataVisita.Location = New System.Drawing.Point(183, 5)
        Me.TextBoxDataVisita.Name = "TextBoxDataVisita"
        Me.TextBoxDataVisita.Size = New System.Drawing.Size(206, 20)
        Me.TextBoxDataVisita.TabIndex = 0
        Me.TextBoxDataVisita.Tag = "Code"
        Me.TextBoxDataVisita.Text = "Data visita"
        '
        'LabelVisitaSelezionata
        '
        Me.LabelVisitaSelezionata.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVisitaSelezionata.Location = New System.Drawing.Point(3, 5)
        Me.LabelVisitaSelezionata.Name = "LabelVisitaSelezionata"
        Me.LabelVisitaSelezionata.Size = New System.Drawing.Size(88, 13)
        Me.LabelVisitaSelezionata.TabIndex = 1
        Me.LabelVisitaSelezionata.Tag = "TitleVisita"
        Me.LabelVisitaSelezionata.Text = "Visita selezionata"
        '
        'UC_DatiVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelDatiVisita)
        Me.Name = "UC_DatiVisita"
        Me.Size = New System.Drawing.Size(766, 60)
        Me.Tag = "DatiVisita"
        Me.TableLayoutPanelDatiVisita.ResumeLayout(False)
        Me.TableLayoutPanelDatiVisita.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TextBoxTipoVisita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxDataVisita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelDatiVisita As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBoxTipoVisita As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxDataVisita As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LabelVisitaSelezionata As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
