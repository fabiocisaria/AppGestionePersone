Imports Syncfusion.Licensing

Public Class MainForm
    Inherits Form

    ' ====================
    ' Carico licenza Syncfusion
    ' ====================
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Registra la licenza Syncfusion
        SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JEaF1cWWhAYVJpR2Nbek50flRPal9QVBYiSV9jS3tTfkdmWHlfeXdUTmJeUU91Xw==")
        'SfSkinManager.SetTheme(Me, Theme.)
    End Sub


    ' ====================
    ' Variabili e UC
    ' ====================
    Private _ucCercaPaziente As UC_CercaPaziente
    Private _ucAnagrafica As UC_Anagrafica
    Private _ucAnamnesiFisiologica As UC_AnamnesiFisiologica
    Private _ucAnamnesiFamiliare As UC_AnamnesiFamiliare
    Private _ucDatiPaziente As UC_DatiPaziente
    Private _ucInserisciVisita As UC_InserisciVisita
    Private _ucCercaVisita As UC_CercaVisita
    Private _ucVisitaSintomi As UC_VisitaSintomi
    Private _ucDatiVisita As UC_DatiVisita

    ' Stato paziente selezionato
    Public Property IDPazienteSelezionato As Integer
    Public Property CodicePazienteSelezionato As String
    Public Property CognomePazienteSelezionato As String
    Public Property NomePazienteSelezionato As String
    Public Property DataNascitaPazienteSelezionato As Date
    Public Property IDVisitaSelezionata As Integer
    Public Property TipoVisitaSelezionata As String
    Public Property DataVisitaSelezionata As Date


    ' ====================
    ' Handler evento paziente selezionato
    ' ====================
    Private Sub PazienteSelezionatoHandler(ID As Integer, CodiceIdentificativo As String, Cognome As String, Nome As String, DataNascita As Date)
        Me.IDPazienteSelezionato = ID
        Me.CodicePazienteSelezionato = CodiceIdentificativo
        Me.CognomePazienteSelezionato = Cognome
        Me.NomePazienteSelezionato = Nome
        Me.DataNascitaPazienteSelezionato = DataNascita

        ' Aggiorna eventuale label globale (opzionale)
        ' LabelPazienteSelezionato.Text = "Paziente: " & CodiceIdentificativo

        ' Mostra toast
        MostraToast("Paziente selezionato: " & CodiceIdentificativo)
    End Sub

    ' ====================
    ' Handler evento visita selezionata
    ' ====================
    Private Sub VisitaSelezionataHandler(IDVisita As Integer, TipoVisita As String, DataVisita As Date)
        Me.IDVisitaSelezionata = IDVisita
        Me.TipoVisitaSelezionata = TipoVisita
        Me.DataVisitaSelezionata = DataVisita

        ' Aggiorna eventuale label globale (opzionale)
        ' LabelPazienteSelezionato.Text = "Paziente: " & CodiceIdentificativo

        ' Mostra toast
        MostraToast("Visita selezionata: " & CognomePazienteSelezionato & " - " & DataVisitaSelezionata)
    End Sub

    ' ====================
    ' Caricamento UC in TableLayoutPanelMain nella prima riga e prima colonna e fa il dispose del precedente
    ' ====================
    Private Sub CaricaControllo(ctrl As UserControl)
        CaricaControllo(ctrl, 0, 0, True)
    End Sub

    ' ====================
    ' Caricamento UC in TableLayoutPanelMain. Se non passo "dispose" faccio il dispose del vecchio controllo
    ' ====================
    Private Sub CaricaControllo(ctrl As UserControl, column As Integer, row As Integer, Optional dispose As Boolean = True)
        EliminaControllo(column, row, dispose)
        ctrl.Dock = DockStyle.Fill
        TableLayoutPanelMain.Controls.Add(ctrl, column, row)
    End Sub

    ' ====================
    ' Elimino controlli nella main form. Se non passo riga e colonna li elimino tutti
    ' ====================
    Private Sub EliminaControllo()
        TableLayoutPanelMain.Controls.Clear()
    End Sub

    ' ====================
    ' Elimino il controllo (riga, colonna) nella main form.
    ' Se non passo alcun argomento elimino tutti i controlli                                                ==> EliminaControllo()
    ' Se passo riga/colonna, ma non il dispose, elimino quello nella (riga, colonna) e faccio il dispose.   ==> Elimina controllo(column, row)
    ' Se passo solo il dispose senza riga e colonna li elimino tutti e verifico se fare il dispose.         ==> Elimina controllo( , , dispose)
    ' ====================
    Private Sub EliminaControllo(Optional column As Integer = -1, Optional row As Integer = -1, Optional dispose As Boolean = False)
        For i As Integer = TableLayoutPanelMain.Controls.Count - 1 To 0 Step -1
            Dim c As Control = TableLayoutPanelMain.Controls(i)

            ' Se non passo riga/colonna (-1), li elimino tutti
            If (column = -1 OrElse TableLayoutPanelMain.GetColumn(c) = column) AndAlso
           (row = -1 OrElse TableLayoutPanelMain.GetRow(c) = row) Then

                TableLayoutPanelMain.Controls.Remove(c)
                If dispose Then c.Dispose()
            End If
        Next
    End Sub

    ' ====================
    ' Toast animato
    ' ====================
    Private _toastAttivo As Boolean = False
    Private _toastCorrente As Form
    Private _fadeInTimer As Timer
    Private _fadeOutTimer As Timer
    Private _closeTimer As Timer

    Public Sub MostraToast(messaggio As String)
        ' Se c'è già un toast attivo, chiudilo subito
        If _toastAttivo AndAlso _toastCorrente IsNot Nothing AndAlso Not _toastCorrente.IsDisposed Then
            _fadeInTimer?.Stop()
            _fadeOutTimer?.Stop()
            _closeTimer?.Stop()
            _toastCorrente.Close()
        End If

        _toastAttivo = True

        ' Crea il nuovo toast
        _toastCorrente = New Form() With {
        .FormBorderStyle = FormBorderStyle.None,
        .StartPosition = FormStartPosition.Manual,
        .BackColor = Color.FromArgb(50, 50, 50),
        .ForeColor = Color.White,
        .Size = New Size(300, 40),
        .TopMost = True,
        .ShowInTaskbar = False,
        .Location = New Point(Me.Left + Me.Width - 310, Me.Top + Me.Height - 50),
        .Opacity = 0
    }

        Dim lbl As New Label() With {
        .Text = messaggio,
        .ForeColor = Color.White,
        .BackColor = Color.Transparent,
        .Dock = DockStyle.Fill,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Font = New Font("Segoe UI", 8, FontStyle.Bold)
    }

        _toastCorrente.Controls.Add(lbl)
        _toastCorrente.Show()

        ' Fade-in
        _fadeInTimer = New Timer With {.Interval = 30}
        AddHandler _fadeInTimer.Tick, Sub()
                                          If _toastCorrente IsNot Nothing AndAlso Not _toastCorrente.IsDisposed Then
                                              If _toastCorrente.Opacity < 1 Then
                                                  _toastCorrente.Opacity += 0.1
                                              Else
                                                  _fadeInTimer.Stop()
                                              End If
                                          End If
                                      End Sub
        _fadeInTimer.Start()

        ' Timer chiusura con fade-out
        _closeTimer = New Timer With {.Interval = 2000} ' 2 secondi visibilità
        AddHandler _closeTimer.Tick, Sub()
                                         _closeTimer.Stop()
                                         _fadeOutTimer = New Timer With {.Interval = 30}
                                         AddHandler _fadeOutTimer.Tick, Sub()
                                                                            If _toastCorrente IsNot Nothing AndAlso Not _toastCorrente.IsDisposed Then
                                                                                If _toastCorrente.Opacity > 0 Then
                                                                                    _toastCorrente.Opacity -= 0.1
                                                                                Else
                                                                                    _fadeOutTimer.Stop()
                                                                                    _toastCorrente.Close()
                                                                                    _toastAttivo = False
                                                                                End If
                                                                            End If
                                                                        End Sub
                                         _fadeOutTimer.Start()
                                     End Sub
        _closeTimer.Start()
    End Sub


    ' ====================
    ' Menu Nuovo Paziente
    ' ====================
    Private Sub NuovoPazienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuovoPazienteToolStripMenuItem.Click
        If _ucAnagrafica Is Nothing Then
            _ucAnagrafica = New UC_Anagrafica()
        End If
        CaricaControllo(_ucAnagrafica, 0, 2)
    End Sub

    ' ====================
    ' Menu Cerca Paziente
    ' ====================
    Private Sub PazienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PazienteToolStripMenuItem.Click
        If _ucCercaPaziente Is Nothing Then
            _ucCercaPaziente = New UC_CercaPaziente()
            AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
        End If
        EliminaControllo(0, 0)
        EliminaControllo(0, 1)
        EliminaControllo(0, 2)
        CaricaControllo(_ucCercaPaziente, 0, 2)
    End Sub

    Private Sub FisiologicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FisiologicaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If
            EliminaControllo(0, 0)
            EliminaControllo(0, 1)
            EliminaControllo(0, 2)
            CaricaControllo(_ucCercaPaziente, 0, 2)
            Return
        End If

        If _ucDatiPaziente Is Nothing Then
            _ucDatiPaziente = New UC_DatiPaziente()
        Else
            _ucDatiPaziente.CaricaDatiPaziente(Me)
        End If

        If _ucAnamnesiFisiologica Is Nothing Then
            _ucAnamnesiFisiologica = New UC_AnamnesiFisiologica()
        End If

        EliminaControllo(0, 0)
        EliminaControllo(0, 1)
        EliminaControllo(0, 2)
        CaricaControllo(_ucDatiPaziente, 0, 0)
        CaricaControllo(_ucAnamnesiFisiologica, 0, 2)
    End Sub

    Private Sub FamiliareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliareToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If

            EliminaControllo(0, 0)
            EliminaControllo(0, 1)
            EliminaControllo(0, 2)
            CaricaControllo(_ucCercaPaziente, 0, 2)
            Return
        End If

        If _ucDatiPaziente Is Nothing Then
            _ucDatiPaziente = New UC_DatiPaziente()
        Else
            _ucDatiPaziente.CaricaDatiPaziente(Me)
        End If

        If _ucAnamnesiFamiliare Is Nothing Then
            _ucAnamnesiFamiliare = New UC_AnamnesiFamiliare()
        End If

        EliminaControllo(0, 0)
        EliminaControllo(0, 1)
        EliminaControllo(0, 2)
        CaricaControllo(_ucDatiPaziente, 0, 0)
        CaricaControllo(_ucAnamnesiFamiliare, 0, 2)
    End Sub

    Private Sub PrimaVisitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimaVisitaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If

            EliminaControllo(0, 0)
            EliminaControllo(0, 1)
            EliminaControllo(0, 2)
            CaricaControllo(_ucCercaPaziente, 0, 2)
            Return
        End If

        If _ucDatiPaziente Is Nothing Then
            _ucDatiPaziente = New UC_DatiPaziente()
        Else
            _ucDatiPaziente.CaricaDatiPaziente(Me)
        End If

        If _ucInserisciVisita Is Nothing Then
            _ucInserisciVisita = New UC_InserisciVisita("Prima visita")
        End If

        EliminaControllo(0, 0)
        EliminaControllo(0, 1)
        EliminaControllo(0, 2)
        CaricaControllo(_ucDatiPaziente, 0, 0)
        CaricaControllo(_ucInserisciVisita, 0, 2)
    End Sub

    Private Sub ControlloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlloToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If

            EliminaControllo(0, 0)
            EliminaControllo(0, 1)
            EliminaControllo(0, 2)
            CaricaControllo(_ucCercaPaziente, 0, 2)
            Return
        End If

        If _ucDatiPaziente Is Nothing Then
            _ucDatiPaziente = New UC_DatiPaziente()
        Else
            _ucDatiPaziente.CaricaDatiPaziente(Me)
        End If

        If _ucInserisciVisita Is Nothing Then
            _ucInserisciVisita = New UC_InserisciVisita("Controllo")
        End If

        EliminaControllo(0, 0)
        EliminaControllo(0, 1)
        EliminaControllo(0, 2)
        CaricaControllo(_ucDatiPaziente, 0, 0)
        CaricaControllo(_ucInserisciVisita, 0, 2)
    End Sub

    Private Sub VisitaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VisitaToolStripMenuItem1.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If

            EliminaControllo(0, 0)
            EliminaControllo(0, 1)
            EliminaControllo(0, 2)
            CaricaControllo(_ucCercaPaziente, 0, 2)
            Return
        End If

        If _ucDatiPaziente Is Nothing Then
            _ucDatiPaziente = New UC_DatiPaziente()
        Else
            _ucDatiPaziente.CaricaDatiPaziente(Me)
        End If

        If _ucCercaVisita Is Nothing Then
            _ucCercaVisita = New UC_CercaVisita()
            AddHandler _ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
        End If

        EliminaControllo(0, 0)
        EliminaControllo(0, 1)
        EliminaControllo(0, 2)
        CaricaControllo(_ucDatiPaziente, 0, 0)
        CaricaControllo(_ucCercaVisita, 0, 2)
    End Sub

    Private Sub SintomiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SintomiToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = 0 Then
            MostraToast("Seleziona prima un paziente.")
            ' Carico lo UserControl di ricerca
            If _ucCercaPaziente Is Nothing Then
                _ucCercaPaziente = New UC_CercaPaziente()
                AddHandler _ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            End If

            EliminaControllo(0, 0)
            EliminaControllo(0, 1)
            EliminaControllo(0, 2)
            CaricaControllo(_ucCercaPaziente, 0, 2)
            Return
        End If

        If _ucDatiPaziente Is Nothing Then
            _ucDatiPaziente = New UC_DatiPaziente()
        Else
            _ucDatiPaziente.CaricaDatiPaziente(Me)
        End If

        If Me.IDVisitaSelezionata = 0 Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            If _ucCercaVisita Is Nothing Then
                _ucCercaVisita = New UC_CercaVisita()
                AddHandler _ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
            End If

            EliminaControllo(0, 0)
            EliminaControllo(0, 1)
            EliminaControllo(0, 2)
            CaricaControllo(_ucCercaVisita, 0, 2)
            Return
        End If

        If _ucDatiVisita Is Nothing Then
            _ucDatiVisita = New UC_DatiVisita
            _ucDatiVisita.CaricaDatiVisita(Me)
        End If

        If _ucVisitaSintomi Is Nothing Then
            _ucVisitaSintomi = New UC_VisitaSintomi()
        End If

        EliminaControllo(0, 0)
        EliminaControllo(0, 1)
        EliminaControllo(0, 2)
        CaricaControllo(_ucDatiPaziente, 0, 0)
        CaricaControllo(_ucDatiVisita, 0, 1)
        CaricaControllo(_ucVisitaSintomi, 0, 2)
    End Sub
End Class