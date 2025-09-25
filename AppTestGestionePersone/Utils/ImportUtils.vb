Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb

Module ImportUtils

    Private connectionString As String = "Server=tuo_server.database.windows.net;Database=nome_db;User Id=utente;Password=xxx;"

    ' Import da CSV
    Public Sub ImportCSV(filePath As String)
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            For Each line In File.ReadAllLines(filePath).Skip(1) 'salta intestazione
                Dim valori = line.Split(","c)
                Dim query As String = "INSERT INTO TuaTabella (Col1, Col2, Col3) VALUES (@v1, @v2, @v3)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@v1", valori(0))
                    cmd.Parameters.AddWithValue("@v2", valori(1))
                    cmd.Parameters.AddWithValue("@v3", valori(2))
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub

    ' Import da Excel
    Public Sub ImportExcel(filePath As String)
        Dim connExcel As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filePath & ";Extended Properties='Excel 12.0 Xml;HDR=YES';")
        connExcel.Open()

        Dim cmdExcel As New OleDbCommand("SELECT * FROM [Foglio1$]", connExcel)
        Dim da As New OleDbDataAdapter(cmdExcel)
        Dim dt As New DataTable()
        da.Fill(dt)
        connExcel.Close()

        Using connSql As New SqlConnection(connectionString)
            connSql.Open()
            For Each r As DataRow In dt.Rows
                Dim query As String = "INSERT INTO TuaTabella (Col1, Col2, Col3) VALUES (@v1, @v2, @v3)"
                Using cmd As New SqlCommand(query, connSql)
                    cmd.Parameters.AddWithValue("@v1", r("Col1"))
                    cmd.Parameters.AddWithValue("@v2", r("Col2"))
                    cmd.Parameters.AddWithValue("@v3", r("Col3"))
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub

End Module