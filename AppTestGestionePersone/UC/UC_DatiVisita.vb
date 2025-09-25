Public Class UC_DatiVisita
    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ThemeManager_old.ApplyThemeToControls(Me)

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub ConfiguraCampiVisualizzazione()
        With TextBoxTipoVisita
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackColor = Me.BackColor
            .ForeColor = Color.Black
            .TabStop = False
        End With

        With TextBoxDataVisita
            .ReadOnly = True
            .BorderStyle = BorderStyle.None
            .BackColor = Me.BackColor
            .ForeColor = Color.Black
            .TabStop = False
        End With
    End Sub

    Public Sub CaricaDatiVisita(main As MainForm)
        TextBoxTipoVisita.Text = main.TipoVisitaSelezionata
        TextBoxDataVisita.Text = main.DataVisitaSelezionata.ToString("dddd, dd MMMM yyyy")  'formato esteso. Sostituire con dd/MM/yyyy per formato compatto
    End Sub

    Private Sub UC_DatiPaziente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        ConfiguraCampiVisualizzazione()
        CaricaDatiVisita(main)
    End Sub
End Class
