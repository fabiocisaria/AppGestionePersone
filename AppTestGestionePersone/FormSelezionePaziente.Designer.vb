<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelezionePaziente
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
        Me.dgvSelezionePaziente = New System.Windows.Forms.DataGridView()
        Me.ButtonSeleziona = New System.Windows.Forms.Button()
        Me.ButtonAnnulla = New System.Windows.Forms.Button()
        CType(Me.dgvSelezionePaziente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSelezionePaziente
        '
        Me.dgvSelezionePaziente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelezionePaziente.Location = New System.Drawing.Point(12, 12)
        Me.dgvSelezionePaziente.Name = "dgvSelezionePaziente"
        Me.dgvSelezionePaziente.Size = New System.Drawing.Size(776, 352)
        Me.dgvSelezionePaziente.TabIndex = 0
        '
        'ButtonSeleziona
        '
        Me.ButtonSeleziona.Location = New System.Drawing.Point(713, 370)
        Me.ButtonSeleziona.Name = "ButtonSeleziona"
        Me.ButtonSeleziona.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSeleziona.TabIndex = 1
        Me.ButtonSeleziona.Text = "Seleziona"
        Me.ButtonSeleziona.UseVisualStyleBackColor = True
        '
        'ButtonAnnulla
        '
        Me.ButtonAnnulla.Location = New System.Drawing.Point(632, 370)
        Me.ButtonAnnulla.Name = "ButtonAnnulla"
        Me.ButtonAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAnnulla.TabIndex = 1
        Me.ButtonAnnulla.Text = "Annulla"
        Me.ButtonAnnulla.UseVisualStyleBackColor = True
        '
        'FormSelezionePaziente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 409)
        Me.Controls.Add(Me.ButtonAnnulla)
        Me.Controls.Add(Me.ButtonSeleziona)
        Me.Controls.Add(Me.dgvSelezionePaziente)
        Me.MaximizeBox = False
        Me.Name = "FormSelezionePaziente"
        Me.Text = "Selezione paziente"
        CType(Me.dgvSelezionePaziente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSelezionePaziente As DataGridView
    Friend WithEvents ButtonSeleziona As Button
    Friend WithEvents ButtonAnnulla As Button
End Class
