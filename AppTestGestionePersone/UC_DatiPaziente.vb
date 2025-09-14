Public Class UC_DatiPaziente
    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        Me.BackColor = Theme.BackgroundColor
        TableLayoutPanel2.BackColor = Theme.BackgroundColor
        TableLayoutPanelDatiPaziente.BackColor = Theme.BackgroundColor

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    ' ====================
    ' Configuro le textbox dei dati del paziente affinché sembrino label
    ' ====================
    Private Sub ConfiguraCampiVisualizzazione()
        With TextBoxCognome
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackColor = Me.BackColor
            .ForeColor = Color.Black
            .TabStop = False
        End With

        With TextBoxNome
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackColor = Me.BackColor
            .ForeColor = Color.Black
            .TabStop = False
        End With

        With TextBoxCodiceID
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackColor = Me.BackColor
            .ForeColor = Color.Black
            .TabStop = False
        End With

        With TextBoxDataNascita
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackColor = Me.BackColor
            .ForeColor = Color.Black
            .TabStop = False
        End With
    End Sub

    Public Sub CaricaDatiPaziente(main As MainForm)
        TextBoxCognome.Text = main.CognomePazienteSelezionato
        TextBoxNome.Text = main.NomePazienteSelezionato
        TextBoxCodiceID.Text = main.CodicePazienteSelezionato
        TextBoxDataNascita.Text = main.DataNascitaPazienteSelezionato.ToString("dd/MM/yyyy")
    End Sub

    Private Sub UC_DatiPaziente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        ConfiguraCampiVisualizzazione()
        CaricaDatiPaziente(main)
    End Sub
End Class
