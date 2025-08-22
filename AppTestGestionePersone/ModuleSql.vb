Imports System.Data.SqlClient

Module ConnessioneDB
    ' 🔹 Stringa di connessione centralizzata
    Public connectionString As String = "Server=192.168.49.128,1433;Database=GestionePersone;User Id=sa;Password=Admin2025;"

    ' 🔹 Funzione per aprire una connessione SQL
    Public Function GetConnection() As SqlConnection
        Dim conn As New SqlConnection(connectionString)
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Errore di connessione al database: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conn
    End Function

    ' 🔹 Funzione per eseguire query di tipo INSERT/UPDATE/DELETE
    Public Function EseguiNonQuery(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As Integer
        Dim righeAffette As Integer = 0
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Try
                    righeAffette = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Errore nell'esecuzione della query: " & ex.Message, "Errore SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return righeAffette
    End Function

    Public Function EseguiScalar(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As Integer
        Dim result As Object = Nothing
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Try
                    result = cmd.ExecuteScalar()
                Catch ex As Exception
                    MessageBox.Show("Errore nell'esecuzione della query: " & ex.Message, "Errore SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        ' Se il risultato è DBNull o Nothing, restituisci 0, altrimenti converte in Integer
        If result Is Nothing OrElse IsDBNull(result) Then
            Return 0
        Else
            Return Convert.ToInt32(result)
        End If
    End Function

    ' 🔹 Funzione per eseguire query di tipo SELECT (ritorna DataTable)
    Public Function EseguiQuery(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Try
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Errore nell'esecuzione della query: " & ex.Message, "Errore SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return dt
    End Function
End Module
