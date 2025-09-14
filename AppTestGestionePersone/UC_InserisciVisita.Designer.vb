<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_InserisciVisita
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
        Me.LabelTipoVisita = New System.Windows.Forms.Label()
        Me.DateTimePickerDataVisita = New System.Windows.Forms.DateTimePicker()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.TextBoxMotivo = New System.Windows.Forms.TextBox()
        Me.LabelMotivoVisita = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTipoVisitaTx = New System.Windows.Forms.Label()
        Me.ButtonInserisci = New Syncfusion.WinForms.Controls.SfButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTipoVisita
        '
        Me.LabelTipoVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTipoVisita.Location = New System.Drawing.Point(99, 8)
        Me.LabelTipoVisita.Name = "LabelTipoVisita"
        Me.LabelTipoVisita.Size = New System.Drawing.Size(200, 13)
        Me.LabelTipoVisita.TabIndex = 10
        Me.LabelTipoVisita.Text = "Tipo visita"
        '
        'DateTimePickerDataVisita
        '
        Me.DateTimePickerDataVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePickerDataVisita.Location = New System.Drawing.Point(99, 37)
        Me.DateTimePickerDataVisita.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerDataVisita.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerDataVisita.Name = "DateTimePickerDataVisita"
        Me.DateTimePickerDataVisita.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDataVisita.TabIndex = 4
        Me.DateTimePickerDataVisita.Value = New Date(2025, 8, 19, 1, 36, 7, 0)
        '
        'LabelData
        '
        Me.LabelData.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(3, 41)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 8
        Me.LabelData.Text = "Data"
        '
        'TextBoxMotivo
        '
        Me.TextBoxMotivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxMotivo.Location = New System.Drawing.Point(99, 72)
        Me.TextBoxMotivo.Name = "TextBoxMotivo"
        Me.TextBoxMotivo.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxMotivo.TabIndex = 5
        '
        'LabelMotivoVisita
        '
        Me.LabelMotivoVisita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelMotivoVisita.AutoSize = True
        Me.LabelMotivoVisita.Location = New System.Drawing.Point(3, 76)
        Me.LabelMotivoVisita.Name = "LabelMotivoVisita"
        Me.LabelMotivoVisita.Size = New System.Drawing.Size(39, 13)
        Me.LabelMotivoVisita.TabIndex = 6
        Me.LabelMotivoVisita.Text = "Motivo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonInserisci, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2766!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelTipoVisitaTx, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxMotivo, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelData, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelMotivoVisita, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePickerDataVisita, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelTipoVisita, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(218, 188)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(329, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'LabelTipoVisitaTx
        '
        Me.LabelTipoVisitaTx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTipoVisitaTx.AutoSize = True
        Me.LabelTipoVisitaTx.Location = New System.Drawing.Point(3, 8)
        Me.LabelTipoVisitaTx.Name = "LabelTipoVisitaTx"
        Me.LabelTipoVisitaTx.Size = New System.Drawing.Size(55, 13)
        Me.LabelTipoVisitaTx.TabIndex = 11
        Me.LabelTipoVisitaTx.Text = "Tipo visita"
        '
        'ButtonInserisci
        '
        Me.ButtonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonInserisci.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonInserisci.Location = New System.Drawing.Point(667, 482)
        Me.ButtonInserisci.Name = "ButtonInserisci"
        Me.ButtonInserisci.Size = New System.Drawing.Size(96, 27)
        Me.ButtonInserisci.TabIndex = 3
        Me.ButtonInserisci.Text = "Inserisci"
        '
        'UC_InserisciVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_InserisciVisita"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePickerDataVisita As DateTimePicker
    Friend WithEvents LabelData As Label
    Friend WithEvents TextBoxMotivo As TextBox
    Friend WithEvents LabelMotivoVisita As Label
    Friend WithEvents LabelTipoVisita As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelTipoVisitaTx As Label
    Friend WithEvents ButtonInserisci As Syncfusion.WinForms.Controls.SfButton
End Class
