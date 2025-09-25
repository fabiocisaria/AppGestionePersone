Imports System.Web.UI.WebControls
Imports Microsoft.Data.SqlClient

Public Class UC_ClasseFarmaco

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
        PulisciCampi(TextBoxNomeClasse)
        HilightControls(False, TextBoxNomeClasse)
        ControlText(TextBoxNomeClasse) = "Classe"
        TextBoxNomeClasse.Text = ControlText(TextBoxNomeClasse)
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBoxNomeClasse.Enter
        Dim ctrl As Control = DirectCast(sender, Control)
        If ctrl.Text = ControlText(ctrl) Then
            ctrl.Text = ""
            ctrl.ForeColor = Theme.TextBoxForeColor
            ctrl.Font = Theme.TxtFont
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBoxNomeClasse.Leave
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
        If String.IsNullOrWhiteSpace(TextBoxNomeClasse.Text.Trim()) OrElse TextBoxNomeClasse.Text.Trim() = ControlText(TextBoxNomeClasse) Then
            esito = False
            HilightControls(True, TextBoxNomeClasse)
            If String.IsNullOrWhiteSpace(TextBoxNomeClasse.Text.Trim()) Then
                TextBoxNomeClasse.Text = ControlText(TextBoxNomeClasse)
            End If
        Else
            HilightControls(False, TextBoxNomeClasse)
        End If

        Return esito
    End Function

    Private Async Function CercaClasseAsync() As Task(Of Boolean)
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim esiste As Boolean = False

        'Verifica che la classe inserita non esistà già
        Dim checkQuery As String = "SELECT * FROM ClassiFarmaci WHERE Classe = @classe"

        Dim classe As String = TextBoxNomeClasse.Text.Trim()

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@classe", classe)
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

            Dim classe As String = TextBoxNomeClasse.Text.Trim()

            ' TODO
            Try
                Dim queryClassiFarmaci As String = ""

                Dim esiste As Boolean = Await CercaClasseAsync()

                If Not esiste Then
                    queryClassiFarmaci = "INSERT INTO ClassiFarmaci (
                                                        Classe
                                                        ) VALUES (
                                                        @classe)"

                    Dim parametriClassiFarmaci As New List(Of SqlParameter) From {
                        New SqlParameter("@classe", classe)
                    }

                    If Await ConnessioneDB.EseguiNonQueryAsync(queryClassiFarmaci, parametriClassiFarmaci) > 0 Then
                        successo = True
                    End If

                    If successo Then
                        main.MostraToast("Classe di farmaco aggiunta correttamente.")
                    End If
                Else
                    main.MostraToast("Classe di farmaco già esistente.")
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
            PulisciCampi(TextBoxNomeClasse)
        End If
    End Sub
End Class
