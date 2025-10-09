Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Channels
Imports Syncfusion.WinForms.Controls

Public Class UC_Login
    Inherits UserControl

    Private _tentativoWakeup As Integer = 0

    Public Property TentativoWakeup As Integer
        Get
            Return _tentativoWakeup
        End Get
        Set(value As Integer)
            _tentativoWakeup = value
            LabelTentativi.Text = "Tentativo " & value & " di 10"
        End Set
    End Property

    Public Property MessaggioStatoLogin As String
        Get
            Return LabelStatoLogin.Text
        End Get
        Set(value As String)
            LabelStatoLogin.Text = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()

        LabelTentativi.Text = ""
        LabelTentativi.Visible = False

        With ButtonAccedi.Style
            .BackColor = Color.FromArgb(41, 144, 228)
            .HoverBackColor = Color.FromArgb(21, 124, 208)  ' colore hover
            .PressedBackColor = Color.FromArgb(21, 124, 208) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(41, 144, 228) ' mantiene il blu anche se focus
            .DisabledBackColor = Color.FromArgb(41, 144, 228)
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
            .DisabledForeColor = Color.White
            .DisabledForeColor = Color.Gray
        End With

        ButtonAccedi.ThemeName = "None"
        ButtonAccedi.Text = ""
        ButtonAccedi.Tag = "ACCEDI"

        With ButtonEsci.Style
            .BackColor = Color.FromArgb(41, 144, 228)
            .HoverBackColor = Color.FromArgb(21, 124, 208)  ' colore hover
            .PressedBackColor = Color.FromArgb(21, 124, 208) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(41, 144, 228) ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With

        ButtonEsci.ThemeName = "None"
        ButtonEsci.Text = ""
        ButtonEsci.Tag = "ESCI"

        LabelAccesso.ForeColor = Color.White
        LabelBenvenuto.ForeColor = Color.White
        LabelStatoLogin.ForeColor = Color.White
        LabelTentativi.ForeColor = Color.White

        Utils.RoundControl(ButtonAccedi, 7)
        Utils.RoundControl(ButtonEsci, 7)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTentativi.Visible = False
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HTCAPTION As Integer = 2

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanelLogin.MouseDown, PictureBoxLogo.MouseDown
        ' Qui chiamiamo i metodi Shared
        ReleaseCapture()
        SendMessage(Me.Parent.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub SfButton1_Paint(sender As Object, e As PaintEventArgs) Handles ButtonAccedi.Paint, ButtonEsci.Paint
        Dim btn As SfButton = CType(sender, SfButton)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim txt As String = sender.Tag

        Dim totalWidth As Integer = 0

        For Each c As Char In txt
            totalWidth += e.Graphics.MeasureString(c, btn.Font).Width
        Next

        Dim x As Integer = (btn.Width - totalWidth) \ 2

        Dim y As Integer = (btn.Height - btn.Font.Height) / 2

        For Each c As Char In txt
            TextRenderer.DrawText(e.Graphics, c, btn.Font, New Point(x, y), btn.ForeColor)
            x += e.Graphics.MeasureString(c, btn.Font).Width
            'x += TextRenderer.MeasureText(c, btn.Font).Width ' 2 pixel in più tra i caratteri
        Next
    End Sub

    Private Sub ButtonAccedi_Paint(sender As Object, e As PaintEventArgs) Handles ButtonAccedi.Paint
        Dim btn As SfButton = DirectCast(sender, SfButton)
        If Not btn.Enabled Then
            Using brush As New SolidBrush(Color.FromArgb(120, Color.White))
                e.Graphics.FillRectangle(brush, btn.ClientRectangle)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Definisco i colori per la sfumatura
        Dim colori() As Color = {
            Color.FromArgb(&H31, &HA6, &HE3), ' #31A6E3 inizio
            Color.FromArgb(&H56, &H80, &HE0), ' colore intermedio chiaro
            Color.FromArgb(&H44, &H45, &HA9)  ' #4445A9 fine
        }

        ' Posizioni dei colori nella sfumatura (da 0.0 a 1.0)
        Dim posizioni() As Single = {0.0F, 0.5F, 1.0F}

        ' Punti per la sfumatura diagonale
        Dim startPoint As New Point(0, 0)
        Dim endPoint As New Point(Me.Width, Me.Height)

        Using brush As New LinearGradientBrush(startPoint, endPoint, Color.White, Color.White)
            Dim blend As New ColorBlend()
            blend.Colors = colori
            blend.Positions = posizioni
            brush.InterpolationColors = blend

            e.Graphics.FillRectangle(brush, 0, 0, Me.Width, Me.Height)
        End Using
    End Sub

    Public Event LoginSuccess()

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles ButtonAccedi.Click
        ButtonAccedi.Enabled = False
        MessaggioStatoLogin = "Autenticazione in corso..."

        Try
            Dim success = Await ConnessioneDB.AcquireTokenAsync()
            If success IsNot Nothing Then
                If success = "Accesso negato" Then
                    MessaggioStatoLogin = "Credenziali non valide o accesso rifiutato."
                Else
                    MessaggioStatoLogin = "Login eseguito con successo!"
                    Await Task.Delay(1500)
                    MessaggioStatoLogin = "Connessione al database in corso ..."
                    LabelTentativi.Visible = True
                    Await Task.Delay(1000)
                    RaiseEvent LoginSuccess()
                End If
            Else
                LabelStatoLogin.Text = "Errore di connessione o autenticazione."
                LabelTentativi.Visible = False
                ButtonAccedi.Enabled = True
            End If
        Catch ex As Exception
            LabelStatoLogin.Text = "Errore: " & ex.Message
            ButtonAccedi.Enabled = True
        End Try
    End Sub

    Private Sub ButtonEsci_Click(sender As Object, e As EventArgs) Handles ButtonEsci.Click
        ' Chiudi la form di login
        Dim loginForm As Form = Me.FindForm()
        If loginForm IsNot Nothing Then
            loginForm.Close()
        End If

        ' Chiudi la MainForm nascosta
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is MainForm Then
                frm.Close()
                Exit For
            End If
        Next

    End Sub
End Class
