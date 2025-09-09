Imports System.Web.UI.WebControls
Imports Microsoft.Data.SqlClient

Public Class UC_ClasseFarmaco
    Public Sub New()
        InitializeComponent()

        ' ====================
        ' SfButtons
        ' ====================
        With ButtonInserisci.Style
            .BackColor = Color.FromArgb(41, 128, 185)
            .HoverBackColor = Color.FromArgb(31, 97, 144)  ' colore hover
            .PressedBackColor = Color.FromArgb(31, 97, 144) ' colore quando premuto
            .FocusedBackColor = Color.FromArgb(31, 97, 144) ' mantiene il blu anche se focus
            .ForeColor = Color.White
            .HoverForeColor = Color.White
            .PressedForeColor = Color.White
            .FocusedForeColor = Color.White
        End With
    End Sub

    Private Sub FormClasseFarmaco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxNomeClasse.Text = ""
    End Sub

    Private Function CheckSelezione() As Boolean
        Dim esito As Boolean = True

        ' Verifico se il campo Nome classe è stato compilato
        If String.IsNullOrWhiteSpace(TextBoxNomeClasse.Text.Trim()) Then
            esito = False
            HilightControls(True, TextBoxNomeClasse)
        Else
            HilightControls(False, TextBoxNomeClasse)
        End If

        Return esito
    End Function

    Private Function CercaClasse() As Boolean
        Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)
        Dim esiste As Boolean = False

        'Verifica che la classe inserita non esistà già
        Dim checkQuery As String = "SELECT * FROM ClassiFarmaci WHERE Classe = @classe"

        Dim classe As String = TextBoxNomeClasse.Text.Trim()

        Dim checkParam As New List(Of SqlParameter) From {
            New SqlParameter("@classe", classe)
        }

        Dim dtCheck As DataTable = EseguiQuery(checkQuery, checkParam)

        If dtCheck.Rows.Count <> 0 Then
            esiste = True ' Classe di farmaco esistente
        Else
            esiste = False
        End If

        Return esiste
    End Function

    Private Function SalvaDati() As Boolean
        Dim selezioneOK As Boolean = CheckSelezione()
        Dim esito As Boolean = True

        If selezioneOK Then
            Dim main As MainForm = DirectCast(Me.ParentForm, MainForm)

            Dim successo As Boolean = True

            Dim classe As String = TextBoxNomeClasse.Text.Trim()

            ' TODO
            Try
                Dim queryClassiFarmaci As String = ""
                Dim esiste As Boolean = CercaClasse()

                If Not esiste Then
                    queryClassiFarmaci = "INSERT INTO ClassiFarmaci (
                                                        Classe
                                                        ) VALUES (
                                                        @classe)"

                    Dim parametriClassiFarmaci As New List(Of SqlParameter) From {
                        New SqlParameter("@classe", classe)
                    }

                    If EseguiNonQuery(queryClassiFarmaci, parametriClassiFarmaci) > 0 Then
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

    Private Sub ButtonInserisci_Click(sender As Object, e As EventArgs) Handles ButtonInserisci.Click
        Dim esito = SalvaDati()
        If esito Then
            PulisciCampi(TextBoxNomeClasse)
        End If
    End Sub
End Class
