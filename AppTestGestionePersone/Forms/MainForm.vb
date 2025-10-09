
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports Syncfusion.Licensing
Imports OfficeOpenXml

Public Class MainForm
    Inherits Form

    Public Enum StatoLogin
        LoginIniziale = 0       ' All’avvio, mostra solo il login, MainForm nascosta
        LoginRiuscito = 1       ' Login riuscito, MainForm abilitata e visibile
        RichiestaLogin = 2      ' Token scaduto / disconnessione, MainForm visibile ma bloccata
        Logout = 3
        Close = 4
        AttesaDB = 5            ' Attesa DB (dopo login, prima di mostrare MainForm)
    End Enum

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HTCAPTION As Integer = 2

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ' Qui chiamiamo i metodi Shared
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Dim _radius As Integer = 8

    Public Sub New()
        InitializeComponent()

        TableLayoutPanelMain.BackColor = Color.Transparent
        PanelTitleBar.BackColor = Theme.StripMenuPrimaryColor

        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        'MenuStrip1.Renderer = New GradientMenuStripRenderer()
        MenuStrip1.Renderer = New MenuItemColorRenderer()
        'MenuStrip1.BackColor = ColorTranslator.FromHtml("#C3BDE3")
        'MenuStrip1.ForeColor = Color.Gainsboro

        ' Pulsante X per chiusura
        Dim btnClose As New CloseButton()
        btnClose.Location = New Point(Me.Width - 45, 0)
        AddHandler btnClose.CloseClicked, AddressOf Me.BtnClose_Click
        Me.Controls.Add(btnClose)
        btnClose.BringToFront()

        ' Applica bordo arrotondato con ThemeManager
        Rounder.ApplyRounded(Me, _radius)
        BorderThemer.ApplyBorder(Me, _radius, 30, Theme.StripMenuTextPrimaryColor)

        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private _statoLogin As StatoLogin = StatoLogin.LoginIniziale
    Public Property StatoLoginCorrente As StatoLogin
        Get
            Return _statoLogin
        End Get
        Set(value As StatoLogin)
            _statoLogin = value
            Select Case _statoLogin
                Case StatoLogin.LoginIniziale
                    Me.Hide()
                    ApriLogin()   ' Mostra solo login
                Case StatoLogin.AttesaDB
                    Me.Enabled = False
                    Me.Hide()
                Case StatoLogin.LoginRiuscito
                    Me.Enabled = True
                    Me.Show()
                Case StatoLogin.RichiestaLogin
                    Me.Enabled = False  ' Blocca MainForm
                    ApriLogin()         ' Mostra login sopra MainForm
                Case StatoLogin.Logout
                    ConnessioneDB.ResetToken()
                    Me.Enabled = False
                    Me.Hide()
                    ApriLogin()
                Case StatoLogin.Close
                    ConnessioneDB.ResetToken()
                    Me.Close()
            End Select
        End Set
    End Property

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        StatoLoginCorrente = StatoLogin.Close
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ====================
        ' Carico licenza Syncfusion
        ' ====================
        ' Registra la licenza Syncfusion
        SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JFaF5cXGRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXZfdXZVQmleVU11WUFWYEg=")

        ' Imposto la licenza una volta sola per tutta l'app
        OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("Fabio Cisaria")

        'SfSkinManager.SetTheme(Me, Theme.)

        ' Aggancio evento RichiediNuovoLogin dal modulo ConnessioneDB
        AddHandler ConnessioneDB.RichiediNuovoLogin, Sub()
                                                         StatoLoginCorrente = StatoLogin.RichiestaLogin
                                                     End Sub

        InizializzaUCRegistry()

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.UserPaint Or
            ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        Me.BackColor = Color.White

        ' Mostra login iniziale
        StatoLoginCorrente = StatoLogin.LoginIniziale
        'StatoLoginCorrente = StatoLogin.LoginRiuscito
    End Sub

    Private Sub MainForm_Actived(sender As Object, e As EventArgs) Handles MyBase.Activated
        PictureBox1.Image = My.Resources.IconaAttiva
    End Sub

    Private Sub MainForm_Dectived(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        PictureBox1.Image = My.Resources.IconaNonAttiva
    End Sub

    Private Sub ApriLogin()
        ' Invoke perché l’evento potrebbe arrivare da un thread async
        Me.Invoke(Sub()
                      Me.Enabled = False
                      ' Crea la form di login
                      Dim loginForm As New Form()
                      loginForm.Text = "Login"
                      'loginForm.FormBorderStyle = FormBorderStyle.FixedDialog
                      loginForm.StartPosition = FormStartPosition.CenterScreen
                      loginForm.Width = 400
                      loginForm.Height = 500
                      loginForm.MaximizeBox = False
                      loginForm.ShowIcon = True
                      loginForm.Icon = Me.Icon
                      loginForm.FormBorderStyle = FormBorderStyle.None
                      Utils.RoundControl(loginForm, 10)

                      ' Aggiungi il tuo UserControl di login
                      Dim loginUC As New UC_Login()
                      loginUC.Dock = DockStyle.Fill
                      loginForm.Controls.Add(loginUC)

                      ' Gestisci evento login
                      AddHandler loginUC.LoginSuccess, Async Sub()
                                                           Try
                                                               ' Disabilita UI o mostra un cursore di attesa
                                                               Cursor.Current = Cursors.WaitCursor

                                                               ' Risveglia il DB
                                                               Await ConnessioneDB.WakeUpQuery(Sub(tentativo)
                                                                                                   loginUC.TentativoWakeup = tentativo
                                                                                               End Sub)

                                                               ' Chiudi il form di login
                                                               loginForm.Close()

                                                               ' Aggiorna stato login
                                                               StatoLoginCorrente = StatoLogin.LoginRiuscito

                                                           Catch ex As Exception
                                                               loginUC.MessaggioStatoLogin = "Connessione al database non riuscita. Riprovare più tardi"
                                                           Finally
                                                               ' Ripristina cursore
                                                               Cursor.Current = Cursors.Default
                                                           End Try
                                                       End Sub

                      loginForm.ShowDialog()
                  End Sub)
    End Sub

    ' Dichiarazione P/Invoke per ShowWindow
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean
    End Function

    Private Const SW_SHOWNOACTIVATE As Integer = 4

    ' ====================
    ' Variabili e UC (UC gestiti dal registry)
    ' ====================
    Private UCRegistry As New Dictionary(Of String, UCInfo)

    Public Class UCInfo
        Public Property UC As UserControl
        Public Property Categoria As String
        Public Property Factory As Func(Of UserControl)
        Public Property Ricreabile As Boolean = True
    End Class

    Private Sub InizializzaUCRegistry()
        UCRegistry("CercaPaziente") = New UCInfo With {
            .Categoria = "CercaPaziente",
            .Factory = Function() New UC_CercaPaziente(),
            .Ricreabile = True
        }

        UCRegistry("Anagrafica") = New UCInfo With {
            .Categoria = "NuovoPaziente",
            .Factory = Function() New UC_Anagrafica(),
            .Ricreabile = True
        }

        UCRegistry("AnamnesiFisiologica") = New UCInfo With {
            .Categoria = "Paziente",
            .Factory = Function() New UC_AnamnesiFisiologica(),
            .Ricreabile = True
        }

        UCRegistry("AnamnesiFamiliare") = New UCInfo With {
            .Categoria = "Paziente",
            .Factory = Function() New UC_AnamnesiFamiliare(),
            .Ricreabile = True
        }

        UCRegistry("AnamnesiPatologicaRemota") = New UCInfo With {
            .Categoria = "Paziente",
            .Factory = Function() New UC_AnamnesiPatologicaRemota(),
            .Ricreabile = True
        }

        UCRegistry("DatiPaziente") = New UCInfo With {
            .Categoria = "Paziente",
            .Factory = Function() New UC_DatiPaziente(),
            .Ricreabile = True
        }

        UCRegistry("InserisciVisitaPrima") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_InserisciVisita("Prima visita"),
            .Ricreabile = True
        }

        UCRegistry("InserisciVisitaControllo") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_InserisciVisita("Controllo"),
            .Ricreabile = True
        }

        UCRegistry("CercaVisita") = New UCInfo With {
            .Categoria = "CercaVisita",
            .Factory = Function() New UC_CercaVisita(),
            .Ricreabile = True
        }

        UCRegistry("VisitaSintomi") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New VisitaSintomiNew(),
            .Ricreabile = True
        }

        UCRegistry("DatiVisita") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_DatiVisita(),
            .Ricreabile = True
        }

        UCRegistry("VisitaUroGineco") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_VisitaUroGineco(),
            .Ricreabile = True
        }

        UCRegistry("VisitaRMN") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_VisitaRMN(),
            .Ricreabile = True
        }

        UCRegistry("VisitaUrinocoltura") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_VisitaUrinocoltura(),
            .Ricreabile = True
        }

        UCRegistry("VisitaTamponeVg") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_VisitaTamponeVg(),
            .Ricreabile = True
        }

        UCRegistry("VisitaDNATest") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_VisitaDNATest(),
            .Ricreabile = True
        }

        UCRegistry("VisitaPapTest") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_VisitaPapTest(),
            .Ricreabile = True
        }

        UCRegistry("VisitaAnamnesiOstrGineco") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_VisitaAnamnesiOstrGineco(),
            .Ricreabile = True
        }

        UCRegistry("Farmaco") = New UCInfo With {
            .Categoria = "Farmaco",
            .Factory = Function() New UC_Farmaco(),
            .Ricreabile = True
        }

        UCRegistry("ClasseFarmaco") = New UCInfo With {
            .Categoria = "ClasseFarmaco",
            .Factory = Function() New UC_ClasseFarmaco(),
            .Ricreabile = True
        }

        UCRegistry("TerapiaRiabilitativa") = New UCInfo With {
            .Categoria = "TerapiaRiabilitativa",
            .Factory = Function() New UC_TerapiaRiabilitativa(),
            .Ricreabile = True
        }

        UCRegistry("Terapia") = New UCInfo With {
            .Categoria = "Visita",
            .Factory = Function() New UC_Terapia(),
            .Ricreabile = True
        }

        UCRegistry("Contraccettivo") = New UCInfo With {
            .Categoria = "Contraccettivo",
            .Factory = Function() New UC_Contraccettivo(),
            .Ricreabile = True
        }

        UCRegistry("Integratore") = New UCInfo With {
            .Categoria = "Integratore",
            .Factory = Function() New UC_Integratore(),
            .Ricreabile = True
        }

        UCRegistry("MalattiaAutoimmune") = New UCInfo With {
            .Categoria = "MalattiaAutoimmune",
            .Factory = Function() New UC_MalattiaAutoimmune(),
            .Ricreabile = True
        }

        UCRegistry("Importazione") = New UCInfo With {
            .Categoria = "Importazione",
            .Factory = Function() New UC_FileImportazione(),
            .Ricreabile = True
        }
    End Sub

    ' Stato paziente selezionato
    Public Property IDPazienteSelezionato As Integer = Nothing
    Public Property CodicePazienteSelezionato As String
    Public Property CognomePazienteSelezionato As String
    Public Property NomePazienteSelezionato As String
    Public Property DataNascitaPazienteSelezionato As Date
    Public Property IDVisitaSelezionata As Integer = Nothing
    Public Property TipoVisitaSelezionata As String
    Public Property DataVisitaSelezionata As Date
    ''' <summary>
    ''' Rimuove UC in base alla categoria o alla lista di nomi.
    ''' Se non passi nulla, rimuove tutti.
    ''' </summary>
    Private Sub RimuoviUC(Optional categoria As String = Nothing, Optional nomi As List(Of String) = Nothing)
        For Each kvp In UCRegistry.ToList()
            Dim nomeUC As String = kvp.Key
            Dim ucInfo As UCInfo = kvp.Value
            Dim uc As UserControl = ucInfo.UC

            If uc IsNot Nothing AndAlso
           ucInfo.Ricreabile AndAlso ' <<-- elimino SOLO se ricreabile
           (categoria Is Nothing OrElse ucInfo.Categoria = categoria) AndAlso
           (nomi Is Nothing OrElse nomi.Contains(nomeUC)) Then

                TableLayoutPanelMain.Controls.Remove(uc)
                uc.Dispose()
                ucInfo.UC = Nothing
            End If
        Next
    End Sub

    ' Crea UC se non esiste già
    Public Function GetUC(nome As String) As UserControl
        Dim info = UCRegistry(nome)

        If info.UC Is Nothing Then
            Dim creator As Func(Of UserControl) = info.Factory
            info.UC = creator()  ' ora la lambda viene invocata correttamente
        End If

        Return info.UC
    End Function

    Private Sub ResetPaziente()
        IDPazienteSelezionato = Nothing
        CodicePazienteSelezionato = Nothing
        CognomePazienteSelezionato = Nothing
        NomePazienteSelezionato = Nothing
        DataNascitaPazienteSelezionato = Nothing
    End Sub

    Private Sub ResetVisita()
        IDVisitaSelezionata = Nothing
        TipoVisitaSelezionata = Nothing
        DataVisitaSelezionata = Nothing
    End Sub

    ' ====================
    ' Handler evento paziente selezionato
    ' ====================
    Private Sub PazienteSelezionatoHandler(ID As Integer, CodiceIdentificativo As String, Cognome As String, Nome As String, DataNascita As Date)
        If Me.IDPazienteSelezionato <> ID Then
            RimuoviUC("Paziente")
            RimuoviUC("Visita")
            RimuoviUC("CercaVisita")
        End If
        Me.IDPazienteSelezionato = ID
        Me.CodicePazienteSelezionato = CodiceIdentificativo
        Me.CognomePazienteSelezionato = Cognome
        Me.NomePazienteSelezionato = Nome
        Me.DataNascitaPazienteSelezionato = DataNascita

        ' Reset dati visita selezionata perché cambio paziente
        Me.IDVisitaSelezionata = Nothing
        Me.TipoVisitaSelezionata = Nothing
        Me.DataVisitaSelezionata = Nothing

        ' Aggiorna eventuale label globale (opzionale)
        ' LabelPazienteSelezionato.Text = "Paziente: " & CodiceIdentificativo

        ' Mostra toast
        MostraToast("Paziente selezionato: " & CodiceIdentificativo)
    End Sub

    ' ====================
    ' Handler nuovo paziente
    ' ====================
    Private Sub NuovoPazienteHandler(ID As Integer, CodiceIdentificativo As String, Cognome As String, Nome As String, DataNascita As Date)
        If Me.IDPazienteSelezionato <> ID Then
            RimuoviUC("Paziente")
            RimuoviUC("Visita")
            RimuoviUC("CercaVisita")
            RimuoviUC("CercaPaziente")
        End If
        Me.IDPazienteSelezionato = ID
        Me.CodicePazienteSelezionato = CodiceIdentificativo
        Me.CognomePazienteSelezionato = Cognome
        Me.NomePazienteSelezionato = Nome
        Me.DataNascitaPazienteSelezionato = DataNascita

        ' Reset dati visita selezionata perché cambio paziente
        Me.IDVisitaSelezionata = Nothing
        Me.TipoVisitaSelezionata = Nothing
        Me.DataVisitaSelezionata = Nothing

        ' Aggiorna eventuale label globale (opzionale)
        ' LabelPazienteSelezionato.Text = "Paziente: " & CodiceIdentificativo

        ' Mostra toast
        MostraToast("Paziente selezionato: " & CodiceIdentificativo)
    End Sub

    ' ====================
    ' Handler evento visita selezionata
    ' ====================
    Private Sub VisitaSelezionataHandler(IDVisita As Integer, TipoVisita As String, DataVisita As Date)
        If Me.IDVisitaSelezionata <> IDVisita Then
            ' Se cambio visita, rimuovo tutte le UC di visita
            RimuoviUC("Visita")
        End If
        Me.IDVisitaSelezionata = IDVisita
        Me.TipoVisitaSelezionata = TipoVisita
        Me.DataVisitaSelezionata = DataVisita

        ' Aggiorna eventuale label globale (opzionale)
        ' LabelPazienteSelezionato.Text = "Paziente: " & CodiceIdentificativo

        ' Mostra toast
        MostraToast("Visita selezionata: " & CognomePazienteSelezionato & " - " & DataVisitaSelezionata)
    End Sub

    ' ====================
    ' Handler nuova visita
    ' ====================
    Private Sub NuovaVisitaHandler(IDVisita As Integer, TipoVisita As String, DataVisita As Date)
        If Me.IDVisitaSelezionata <> IDVisita Then
            ' Se cambio visita, rimuovo tutte le UC di visita
            RimuoviUC("Visita")
            RimuoviUC("CercaVisita")
            'Dim ucCercaVisita = GetUC("CercaVisita")
            'TableLayoutPanelMain.Controls.Add(ucCercaVisita, 0, 0)
        End If
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
        EliminaControllo(column, row)
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
    Private Sub EliminaControllo(Optional column As Integer = -1, Optional row As Integer = -1)
        For i As Integer = TableLayoutPanelMain.Controls.Count - 1 To 0 Step -1
            Dim c As Control = TableLayoutPanelMain.Controls(i)

            ' Se non passo riga/colonna (-1), li elimino tutti
            If (column = -1 OrElse TableLayoutPanelMain.GetColumn(c) = column) AndAlso
           (row = -1 OrElse TableLayoutPanelMain.GetRow(c) = row) Then

                TableLayoutPanelMain.Controls.Remove(c)
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
        _toastCorrente = New ToastForm() With {
            .FormBorderStyle = FormBorderStyle.None,
            .StartPosition = FormStartPosition.Manual,
            .BackColor = Color.FromArgb(50, 50, 50),
            .ForeColor = Color.White,
            .Size = New Size(300, 40),
            .TopMost = True,
            .ShowInTaskbar = False,
            .Location = New Point(Me.Left + Me.Width / 2 - 150, Me.Top + Me.Height - 50),
            .Opacity = 0
        }
        '.Owner = Me

        Dim lbl As New Label() With {
            .Text = messaggio,
            .ForeColor = Color.White,
            .BackColor = Color.Transparent,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
        }

        _toastCorrente.Controls.Add(lbl)
        ShowWindow(_toastCorrente.Handle, SW_SHOWNOACTIVATE)
        '_toastCorrente.Show()

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
    Private Sub NuovoPazienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PazienteToolStripMenuItem1.Click
        ' Rimuove tutte le UC Paziente (ricreabili) tranne CercaPaziente
        'RimuoviUC("Paziente")

        ' Rimuove eventuali UC Visita
        'RimuoviUC("Visita")
        EliminaControllo()

        ' Carica UC Anagrafica
        Dim ucAnagrafica As UserControl = GetUC("Anagrafica")

        ucAnagrafica.Visible = False

        ' Aggiunge handler se non già aggiunto
        Dim uc As UC_Anagrafica = DirectCast(ucAnagrafica, UC_Anagrafica)
        If Not uc.IsHandlerAttached Then
            AddHandler uc.NuovoPazienteInserito, AddressOf NuovoPazienteHandler
            uc.IsHandlerAttached = True
        End If

        ' Carica nel TableLayoutPanel
        CaricaControllo(ucAnagrafica, 0, 2)
        ucAnagrafica.Visible = True
    End Sub

    ' ====================
    ' Menu Cerca Paziente
    ' ====================
    Private Sub PazienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PazienteToolStripMenuItem.Click
        ' Ottiene l'UC CercaPaziente dal registry
        Dim ucCercaPaziente As UserControl = GetUC("CercaPaziente")

        ucCercaPaziente.Visible = False

        EliminaControllo()

        ' Aggiunge handler se non già aggiunto
        Dim uc As UC_CercaPaziente = DirectCast(ucCercaPaziente, UC_CercaPaziente)
        If Not uc.IsHandlerAttached Then
            AddHandler uc.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
            uc.IsHandlerAttached = True
        End If

        ' Carica l'UC nella main form
        CaricaControllo(ucCercaPaziente, 0, 2)

        ucCercaPaziente.Visible = True
    End Sub

    Private Sub FisiologicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FisiologicaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If
            ucCercaPaziente.Visible = False
            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        ' Rimuove tutte le UC Paziente tranne CercaPaziente
        'RimuoviUC("Paziente")

        ' Rimuove eventuali UC Visita
        'RimuoviUC("Visita")

        ' Ottiene UC DatiPaziente e AnamnesiFisiologica dal registry
        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)
        Dim ucAnamnesiFisiologica As UC_AnamnesiFisiologica = DirectCast(GetUC("AnamnesiFisiologica"), UC_AnamnesiFisiologica)

        ucAnamnesiFisiologica.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)

        EliminaControllo(0, 1)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucAnamnesiFisiologica, 0, 2)

        ' Aggiorna dati UC AnamnesiFisiologica

        ucAnamnesiFisiologica.Visible = True

        ucAnamnesiFisiologica.AggiornaDatiAsync()
    End Sub

    Private Sub FamiliareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliareToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False
            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        ' Rimuove tutte le UC Paziente tranne CercaPaziente
        'RimuoviUC("Paziente")

        ' Rimuove eventuali UC Visita
        'RimuoviUC("Visita")

        ' Ottiene UC DatiPaziente e AnamnesiFisiologica dal registry
        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)
        Dim ucAnamnesiFamiliare As UC_AnamnesiFamiliare = DirectCast(GetUC("AnamnesiFamiliare"), UC_AnamnesiFamiliare)

        ucAnamnesiFamiliare.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)

        EliminaControllo(0, 1)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucAnamnesiFamiliare, 0, 2)

        ucAnamnesiFamiliare.Visible = True
    End Sub

    Private Sub PrimaVisitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimaVisitaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False
            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        EliminaControllo(0, 1)

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        Dim ucInserisciVisita As UserControl = GetUC("InserisciVisitaPrima")

        ' Aggiunge handler se non già aggiunto
        Dim uc As UC_InserisciVisita = DirectCast(ucInserisciVisita, UC_InserisciVisita)
        If Not uc.IsHandlerAttached Then
            AddHandler uc.NuovaVisitaInserita, AddressOf NuovaVisitaHandler
            uc.IsHandlerAttached = True
        End If
        ucInserisciVisita.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)

        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucInserisciVisita, 0, 2)

        ucInserisciVisita.Visible = True
    End Sub

    Private Sub ControlloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlloToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        EliminaControllo(0, 1)

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        Dim ucInserisciVisita As UserControl = GetUC("InserisciVisitaControllo")

        ucInserisciVisita.Visible = False

        ' Aggiunge handler se non già aggiunto
        Dim uc As UC_InserisciVisita = DirectCast(ucInserisciVisita, UC_InserisciVisita)
        If Not uc.IsHandlerAttached Then
            AddHandler uc.NuovaVisitaInserita, AddressOf NuovaVisitaHandler
            uc.IsHandlerAttached = True
        End If

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)

        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucInserisciVisita, 0, 2)

        ucInserisciVisita.Visible = True
    End Sub

    Private Sub VisitaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VisitaToolStripMenuItem1.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False
            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        ' Rimuove eventuali UC Visita
        'RimuoviUC("Visita")
        EliminaControllo(0, 1)

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)
        ' Aggiunge handler se non già aggiunto
        Dim uc As UC_CercaVisita = DirectCast(ucCercaVisita, UC_CercaVisita)
        If Not uc.IsHandlerAttached Then
            AddHandler uc.VisitaSelezionata, AddressOf VisitaSelezionataHandler
            uc.IsHandlerAttached = True
        End If

        ucCercaVisita.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)

        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucCercaVisita, 0, 2)

        ucCercaVisita.Visible = True
    End Sub

    Private Sub SintomiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SintomiToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If

            ucCercaVisita.Visible = False

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaSintomi As VisitaSintomiNew = DirectCast(GetUC("VisitaSintomi"), VisitaSintomiNew)

        ucVisitaSintomi.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaSintomi, 0, 2)

        ucVisitaSintomi.Visible = True

        ucVisitaSintomi.AggiornaDati()
    End Sub

    Private Sub UroGinecologicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UroGinecologicaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If

            ucCercaVisita.Visible = False

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaUroGineco As UC_VisitaUroGineco = DirectCast(GetUC("VisitaUroGineco"), UC_VisitaUroGineco)

        ucVisitaUroGineco.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaUroGineco, 0, 2)

        ucVisitaUroGineco.Visible = True

        ucVisitaUroGineco.AggiornaDati()
    End Sub

    Private Sub RMNToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RMNToolStripMenuItem1.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If

            ucCercaVisita.Visible = False

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaRMN As UC_VisitaRMN = DirectCast(GetUC("VisitaRMN"), UC_VisitaRMN)

        ucVisitaRMN.Visible = False
        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaRMN, 0, 2)

        ucVisitaRMN.Visible = True

        ucVisitaRMN.AggiornaDati()
    End Sub

    Private Sub PapTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PapTestToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False
            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If

            ucCercaVisita.Visible = False
            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaPapTest As UC_VisitaPapTest = DirectCast(GetUC("VisitaPapTest"), UC_VisitaPapTest)

        ucVisitaPapTest.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaPapTest, 0, 2)

        ucVisitaPapTest.Visible = True

        ucVisitaPapTest.AggiornaDati()
    End Sub

    Private Sub UrinoculturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UrinoculturaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If

            ucCercaVisita.Visible = False

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaUrinocoltura As UC_VisitaUrinocoltura = DirectCast(GetUC("VisitaUrinocoltura"), UC_VisitaUrinocoltura)

        ucVisitaUrinocoltura.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaUrinocoltura, 0, 2)

        ucVisitaUrinocoltura.Visible = True

        ucVisitaUrinocoltura.AggiornaDati()
    End Sub

    Private Sub TamponeVaginaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamponeVaginaleToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If


            ucCercaVisita.Visible = False
            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaTamponeVg As UC_VisitaTamponeVg = DirectCast(GetUC("VisitaTamponeVg"), UC_VisitaTamponeVg)

        ucVisitaTamponeVg.Visible = False
        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaTamponeVg, 0, 2)

        ucVisitaTamponeVg.Visible = True

        ucVisitaTamponeVg.AggiornaDati()
    End Sub

    Private Sub DNATestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DNATestToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If

            ucCercaVisita.Visible = False

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaDNATest As UC_VisitaDNATest = DirectCast(GetUC("VisitaDNATest"), UC_VisitaDNATest)

        ucVisitaDNATest.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaDNATest, 0, 2)

        ucVisitaDNATest.Visible = True

        ucVisitaDNATest.AggiornaDati()
    End Sub

    Private Sub StoriaOstetricoginecologicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoriaOstetricoginecologicaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If


            ucCercaVisita.Visible = False

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucVisitaAnamnesiOstrGineco As UC_VisitaAnamnesiOstrGineco = DirectCast(GetUC("VisitaAnamnesiOstrGineco"), UC_VisitaAnamnesiOstrGineco)

        ucVisitaAnamnesiOstrGineco.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucVisitaAnamnesiOstrGineco, 0, 2)

        ucVisitaAnamnesiOstrGineco.Visible = True

        ucVisitaAnamnesiOstrGineco.AggiornaDati()
    End Sub

    Private Sub PatologicaRemotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatologicaRemotaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        ' Rimuove tutte le UC Paziente tranne CercaPaziente
        'RimuoviUC("Paziente")

        ' Rimuove eventuali UC Visita
        'RimuoviUC("Visita")

        ' Ottiene UC DatiPaziente e AnamnesiFisiologica dal registry
        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)
        Dim ucAnamnesiPatologicaRemota As UC_AnamnesiPatologicaRemota = DirectCast(GetUC("AnamnesiPatologicaRemota"), UC_AnamnesiPatologicaRemota)

        ucAnamnesiPatologicaRemota.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)

        EliminaControllo(0, 1)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucAnamnesiPatologicaRemota, 0, 2)

        ucAnamnesiPatologicaRemota.Visible = True

        ' Aggiorna dati UC AnamnesiFisiologica
        ucAnamnesiPatologicaRemota.AggiornaDatiAsync()
    End Sub

    Private Sub NuovaClasseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuovaClasseToolStripMenuItem.Click
        EliminaControllo()

        RimuoviUC("Farmaco")
        Dim ucClasseFarmaco As UC_ClasseFarmaco = DirectCast(GetUC("ClasseFarmaco"), UC_ClasseFarmaco)
        CaricaControllo(ucClasseFarmaco, 0, 2)
    End Sub

    Private Sub NuovoFarmacoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuovoFarmacoToolStripMenuItem.Click
        EliminaControllo()

        Dim ucFarmaco As UC_Farmaco = DirectCast(GetUC("Farmaco"), UC_Farmaco)
        CaricaControllo(ucFarmaco, 0, 2)
    End Sub

    Private Sub TerapiaRiabilitativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerapiaRiabilitativaToolStripMenuItem.Click
        EliminaControllo()

        Dim ucTerapiaRiabilitativa As UC_TerapiaRiabilitativa = DirectCast(GetUC("TerapiaRiabilitativa"), UC_TerapiaRiabilitativa)
        CaricaControllo(ucTerapiaRiabilitativa, 0, 2)
    End Sub

    Private Sub TerapiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerapiaToolStripMenuItem.Click
        If Me.IDPazienteSelezionato = Nothing Then
            MostraToast("Seleziona prima un paziente.")

            ' Ottiene l'UC CercaPaziente
            Dim ucCercaPaziente As UC_CercaPaziente = DirectCast(GetUC("CercaPaziente"), UC_CercaPaziente)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaPaziente.IsHandlerAttached Then
                AddHandler ucCercaPaziente.PazienteSelezionato, AddressOf PazienteSelezionatoHandler
                ucCercaPaziente.IsHandlerAttached = True
            End If

            ucCercaPaziente.Visible = False

            ' Rimuove tutti gli UC Paziente tranne CercaPaziente
            'RimuoviUC("Paziente")

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaPaziente, 0, 2)

            ucCercaPaziente.Visible = True
            Return
        End If

        Dim ucDatiPaziente As UC_DatiPaziente = DirectCast(GetUC("DatiPaziente"), UC_DatiPaziente)

        If Me.IDVisitaSelezionata = Nothing Then
            MostraToast("Seleziona prima una visita.")
            ' Carico lo UserControl di ricerca visita
            Dim ucCercaVisita As UC_CercaVisita = DirectCast(GetUC("CercaVisita"), UC_CercaVisita)

            ' Aggiunge handler se non già aggiunto
            If Not ucCercaVisita.IsHandlerAttached Then
                AddHandler ucCercaVisita.VisitaSelezionata, AddressOf VisitaSelezionataHandler
                ucCercaVisita.IsHandlerAttached = True
            End If

            ucCercaVisita.Visible = False

            ' Rimuove eventuali UC Visita
            'RimuoviUC("Visita")

            ' Carica UC di ricerca paziente
            CaricaControllo(ucCercaVisita, 0, 2)

            ucCercaVisita.Visible = True
            Return
        End If

        Dim ucDatiVisita As UC_DatiVisita = DirectCast(GetUC("DatiVisita"), UC_DatiVisita)

        Dim ucTerapia As UC_Terapia = DirectCast(GetUC("Terapia"), UC_Terapia)

        ucTerapia.Visible = False

        ' Aggiorna dati paziente
        ucDatiPaziente.CaricaDatiPaziente(Me)
        ucDatiVisita.CaricaDatiVisita(Me)

        ' Carica UC
        CaricaControllo(ucDatiPaziente, 0, 0)
        CaricaControllo(ucDatiVisita, 0, 1)
        CaricaControllo(ucTerapia, 0, 2)

        ucTerapia.Visible = True

        ucTerapia.AggiornaDatiAsync()
    End Sub

    Private Sub ContraccettivoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContraccettivoToolStripMenuItem1.Click
        EliminaControllo()

        Dim ucContraccettivo As UC_Contraccettivo = DirectCast(GetUC("Contraccettivo"), UC_Contraccettivo)
        CaricaControllo(ucContraccettivo, 0, 2)
    End Sub

    Private Sub IntegratoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegratoreToolStripMenuItem.Click
        EliminaControllo()

        Dim ucIntegratore As UC_Integratore = DirectCast(GetUC("Integratore"), UC_Integratore)
        CaricaControllo(ucIntegratore, 0, 2)
    End Sub

    Private Sub MalattiaAutoimmuneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MalattiaAutoimmuneToolStripMenuItem.Click
        EliminaControllo()

        Dim ucMalattiaAutoimmune As UC_MalattiaAutoimmune = DirectCast(GetUC("MalattiaAutoimmune"), UC_MalattiaAutoimmune)
        CaricaControllo(ucMalattiaAutoimmune, 0, 2)
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        StatoLoginCorrente = StatoLogin.Close
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        StatoLoginCorrente = StatoLogin.Logout
    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        EliminaControllo()

        RimuoviUC("Importazione")

        Dim ucImportaFile As UC_FileImportazione = DirectCast(GetUC("Importazione"), UC_FileImportazione)
        CaricaControllo(ucImportaFile, 0, 2)
    End Sub
End Class