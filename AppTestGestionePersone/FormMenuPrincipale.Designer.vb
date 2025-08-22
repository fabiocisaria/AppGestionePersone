<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipale
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.ButtonNuovoPaziente = New System.Windows.Forms.Button()
        Me.ButtonAnamnesiFamiliare = New System.Windows.Forms.Button()
        Me.ButtonAnamnesiFisiologica = New System.Windows.Forms.Button()
        Me.ButtonVisita = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonNuovoPaziente
        '
        Me.ButtonNuovoPaziente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonNuovoPaziente.Location = New System.Drawing.Point(105, 8)
        Me.ButtonNuovoPaziente.Name = "ButtonNuovoPaziente"
        Me.ButtonNuovoPaziente.Size = New System.Drawing.Size(127, 23)
        Me.ButtonNuovoPaziente.TabIndex = 0
        Me.ButtonNuovoPaziente.Text = "Nuovo paziente"
        Me.ButtonNuovoPaziente.UseVisualStyleBackColor = True
        '
        'ButtonAnamnesiFamiliare
        '
        Me.ButtonAnamnesiFamiliare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAnamnesiFamiliare.Location = New System.Drawing.Point(105, 48)
        Me.ButtonAnamnesiFamiliare.Name = "ButtonAnamnesiFamiliare"
        Me.ButtonAnamnesiFamiliare.Size = New System.Drawing.Size(127, 23)
        Me.ButtonAnamnesiFamiliare.TabIndex = 1
        Me.ButtonAnamnesiFamiliare.Text = "Anamnesi familiare"
        Me.ButtonAnamnesiFamiliare.UseVisualStyleBackColor = True
        '
        'ButtonAnamnesiFisiologica
        '
        Me.ButtonAnamnesiFisiologica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAnamnesiFisiologica.Location = New System.Drawing.Point(105, 88)
        Me.ButtonAnamnesiFisiologica.Name = "ButtonAnamnesiFisiologica"
        Me.ButtonAnamnesiFisiologica.Size = New System.Drawing.Size(127, 23)
        Me.ButtonAnamnesiFisiologica.TabIndex = 1
        Me.ButtonAnamnesiFisiologica.Text = "Anamnesi fisiologica"
        Me.ButtonAnamnesiFisiologica.UseVisualStyleBackColor = True
        '
        'ButtonVisita
        '
        Me.ButtonVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonVisita.Location = New System.Drawing.Point(105, 129)
        Me.ButtonVisita.Name = "ButtonVisita"
        Me.ButtonVisita.Size = New System.Drawing.Size(127, 23)
        Me.ButtonVisita.TabIndex = 2
        Me.ButtonVisita.Text = "Visita"
        Me.ButtonVisita.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonNuovoPaziente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonVisita, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAnamnesiFamiliare, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAnamnesiFisiologica, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(337, 162)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'FormMenuPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 162)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormMenuPrincipale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menù principale"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonNuovoPaziente As Button
    Friend WithEvents ButtonAnamnesiFamiliare As Button
    Friend WithEvents ButtonAnamnesiFisiologica As Button
    Friend WithEvents ButtonVisita As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
