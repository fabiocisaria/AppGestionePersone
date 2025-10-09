Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml

Module ImportUtils
    Public Function LeggiFile(filePath As String) As DataTable
        Dim estensione = Path.GetExtension(filePath).ToLower()

        Select Case estensione
            Case ".csv"
                Return CaricaDaCsv(filePath)
            Case ".xlsx"
                Return CaricaDaExcel(filePath)
            Case Else
                Throw New Exception("Formato file non supportato")
        End Select
    End Function

    Public Function CaricaDaCsv(filePath As String) As DataTable
        Dim dt As New DataTable()

        Dim lines = File.ReadLines(filePath).ToList()
        If lines.Count = 0 Then Throw New Exception("File vuoto")

        ' Creo le colonne dall'intestazione (prima riga)
        Dim headers = lines(0).Split(","c)
        For Each header In headers
            dt.Columns.Add(header)
        Next

        ' Aggiungo i dati (salto la riga 0 = intestazioni)
        For i As Integer = 1 To lines.Count - 1
            dt.Rows.Add(lines(i).Split(","c))
        Next

        Return dt
    End Function

    Public Function CaricaDaExcel(filePath As String) As DataTable
        Dim dt As New DataTable()

        Using package As New ExcelPackage(New FileInfo(filePath))
            Dim ws = package.Workbook.Worksheets(0) ' primo foglio

            ' Creo intestazioni
            For col As Integer = 1 To ws.Dimension.End.Column
                dt.Columns.Add(ws.Cells(1, col).Text)
            Next

            ' Leggo dati (limito a prime 100 righe per anteprima)
            For row As Integer = 2 To Math.Min(101, ws.Dimension.End.Row)
                Dim dr = dt.NewRow()
                For col As Integer = 1 To ws.Dimension.End.Column
                    dr(col - 1) = ws.Cells(row, col).Text
                Next
                dt.Rows.Add(dr)
            Next
        End Using

        Return dt
    End Function

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