Imports System.Web.UI.WebControls
Imports Microsoft.Data.SqlClient

Public Class UC_MalattiaAutoimmune
    Private Shared ReadOnly ControlText As New Dictionary(Of Control, String)

    Public Sub New()
        InitializeComponent()

        Me.SuspendLayout()
        Me.DoubleBuffered = True

        ThemeManager.ApplyThemeToControls(Me)

        Me.ResumeLayout()
        Me.Refresh() ' forza un unico ridisegno completo
    End Sub

    Private Sub FormClasseFarmaco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PulisciCampi(TextBoxNomeMalattia)
        HilightControls(False, TextBoxNomeMalattia)
        ControlText(TextBoxNomeMalattia) = "Nome malattia"
        TextBoxNomeMalattia.Text = ControlText(TextBoxNomeMalattia)
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBoxNomeMalattia.Enter
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ""
            ctrl.ForeColor = Theme.TextBoxForeColor
            ctrl.Font = Theme.TxtFont
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBoxNomeMalattia.Leave
        Dim ctrl As Control = DirectCast(sender, Control)
        If String.IsNullOrWhiteSpace(ctrl.Text) Then
            ctrl.Text = ControlText(ctrl)
            ctrl.ForeColor = Theme.FindColor
            ctrl.Font = Theme.TxtFontItalic
        End If
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True

        ' Verifico se il campo Nome classe è stato compilato
        If String.IsNullOrWhiteSpace(TextBoxNomeMalattia.Text.Trim()) OrElse TextBoxNomeMalattia.Text.Trim() = ControlText(TextBoxNomeMalattia) Then
            esito = False
            HilightControls(True, TextBoxNomeMalattia)
            If String.IsNullOrWhiteSpace(TextBoxNomeMalattia.Text.Trim()) Then
                TextBoxNomeMalattia.Text = ControlText(TextBoxNomeMalattia)
            End If
        Else
            HilightControls(False, TextBoxNomeMalattia)
        End If

        Return esito
    End Function

    Private Async Function CercaMalattiaAutoimmAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim esiste As Boolean = False

        'Verifica che la classe inserita non esistà già
        Dim checkQuery As String = "SELECT * FROM MalattieAutoimmuni WHERE NomeMalattia = @nomeMalattia"

        Dim nomeMalattia As String = TextBoxNomeMalattia.Text.Trim()

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@nomeMalattia", nomeMalattia)
        }

        Dim dtCheck As DataTable = Await ConnessioneDB.EseguiQueryAsync(checkQuery, checkParam)

        If dtCheck.Rows.Count <> 0 Then
            esiste = True ' Classe di farmaco esistente
        Else
            esiste = False
        End If

        Return esiste
    End Function

    Private Async Function SalvaDatiAsync() As Task(Of Boolean)
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

            Dim successo As Boolean = True

            Dim nomeMalattia As String = TextBoxNomeMalattia.Text.Trim()

            ' TODO
            Try
                Dim queryMalattie As String = ""

                Dim esiste As Boolean = Await CercaMalattiaAutoimmAsync()

                If Not esiste Then
                    queryMalattie = "INSERT INTO MalattieAutoimmuni (
                                                        NomeMalattia
                                                        ) VALUES (
                                                        @nomeMalattia)"

                    Dim parametriMalattie As New List(Of SqlParameter) From {
                        New SqlParameter("@nomeMalattia", nomeMalattia)
                    }

                    If Await ConnessioneDB.EseguiNonQueryAsync(queryMalattie, parametriMalattie) > 0 Then
                        successo = True
                    End If

                    If successo Then
                        main.MostraToast("Malattia autoimmune aggiunta correttamente.")
                    End If
                Else
                    main.MostraToast("Malattia autoimmune già esistente.")
                    esito = False
                End If
            Catch ex As Exception
                MessageBox.Show("Errore imprevisto: " & ex.Message)
                esito = False
            End Try
        Else
            esito = False
        End If

        Return esito
    End Function

    Private Async Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

        ' Disabilito tutti i controlli
        TableLayoutPanelClassiFarmaco.Enabled = False

        main.MostraToast("Salvataggio in corso ...")
        Dim esito = Await SalvaDatiAsync()

        TableLayoutPanelClassiFarmaco.Enabled = True
        If esito Then
            PulisciCampi(TextBoxNomeMalattia)
        End If
    End Sub
End Class
