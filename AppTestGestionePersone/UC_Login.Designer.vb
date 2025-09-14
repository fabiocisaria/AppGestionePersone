<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Login))
        Me.TableLayoutPanelLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonEsci = New Syncfusion.WinForms.Controls.SfButton()
        Me.ButtonAccedi = New Syncfusion.WinForms.Controls.SfButton()
        Me.LabelAccesso = New System.Windows.Forms.Label()
        Me.LabelBenvenuto = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelStatoLogin = New System.Windows.Forms.Label()
        Me.TableLayoutPanelLogin.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelLogin
        '
        Me.TableLayoutPanelLogin.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanelLogin.ColumnCount = 1
        Me.TableLayoutPanelLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelLogin.Controls.Add(Me.ButtonEsci, 0, 4)
        Me.TableLayoutPanelLogin.Controls.Add(Me.ButtonAccedi, 0, 3)
        Me.TableLayoutPanelLogin.Controls.Add(Me.LabelAccesso, 0, 2)
        Me.TableLayoutPanelLogin.Controls.Add(Me.LabelBenvenuto, 0, 1)
        Me.TableLayoutPanelLogin.Controls.Add(Me.PictureBoxLogo, 0, 0)
        Me.TableLayoutPanelLogin.Controls.Add(Me.LabelStatoLogin, 0, 5)
        Me.TableLayoutPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelLogin.Name = "TableLayoutPanelLogin"
        Me.TableLayoutPanelLogin.RowCount = 6
        Me.TableLayoutPanelLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanelLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelLogin.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelLogin.TabIndex = 0
        '
        'ButtonEsci
        '
        Me.ButtonEsci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEsci.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEsci.Location = New System.Drawing.Point(320, 422)
        Me.ButtonEsci.Name = "ButtonEsci"
        Me.ButtonEsci.Size = New System.Drawing.Size(126, 35)
        Me.ButtonEsci.TabIndex = 8
        Me.ButtonEsci.Text = "ESCI"
        '
        'ButtonAccedi
        '
        Me.ButtonAccedi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAccedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAccedi.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAccedi.Location = New System.Drawing.Point(320, 349)
        Me.ButtonAccedi.Name = "ButtonAccedi"
        Me.ButtonAccedi.Size = New System.Drawing.Size(126, 35)
        Me.ButtonAccedi.TabIndex = 3
        Me.ButtonAccedi.Text = "ACCEDI"
        '
        'LabelAccesso
        '
        Me.LabelAccesso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelAccesso.AutoSize = True
        Me.LabelAccesso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAccesso.Location = New System.Drawing.Point(266, 299)
        Me.LabelAccesso.Name = "LabelAccesso"
        Me.LabelAccesso.Size = New System.Drawing.Size(233, 21)
        Me.LabelAccesso.TabIndex = 4
        Me.LabelAccesso.Text = "Effettua l'accesso per continuare"
        '
        'LabelBenvenuto
        '
        Me.LabelBenvenuto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelBenvenuto.AutoSize = True
        Me.LabelBenvenuto.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBenvenuto.Location = New System.Drawing.Point(213, 251)
        Me.LabelBenvenuto.Name = "LabelBenvenuto"
        Me.LabelBenvenuto.Size = New System.Drawing.Size(340, 37)
        Me.LabelBenvenuto.TabIndex = 6
        Me.LabelBenvenuto.Text = "Benvenuto in GynArchive"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxLogo.ErrorImage = Nothing
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(293, 35)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(180, 180)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 7
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelStatoLogin
        '
        Me.LabelStatoLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelStatoLogin.AutoSize = True
        Me.LabelStatoLogin.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatoLogin.Location = New System.Drawing.Point(330, 488)
        Me.LabelStatoLogin.Name = "LabelStatoLogin"
        Me.LabelStatoLogin.Size = New System.Drawing.Size(105, 15)
        Me.LabelStatoLogin.TabIndex = 5
        Me.LabelStatoLogin.Text = "Stato login..."
        '
        'UC_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelLogin)
        Me.Name = "UC_Login"
        Me.Size = New System.Drawing.Size(766, 516)
        Me.TableLayoutPanelLogin.ResumeLayout(False)
        Me.TableLayoutPanelLogin.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanelLogin As TableLayoutPanel
    Friend WithEvents ButtonAccedi As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents LabelAccesso As Label
    Friend WithEvents LabelStatoLogin As Label
    Friend WithEvents LabelBenvenuto As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonEsci As Syncfusion.WinForms.Controls.SfButton
End Class
