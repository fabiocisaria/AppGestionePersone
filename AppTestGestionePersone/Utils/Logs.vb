Imports System.IO

Module Logs
    Private ReadOnly logFolder As String = Path.Combine(Application.StartupPath, "Logs")
    Private ReadOnly logFilePath As String = Path.Combine(logFolder, $"Log_{DateTime.Now:yyyyMMdd}.txt")

    Public Sub WriteLog(message As String, Optional level As String = "OK")
        Try
            ' Crea la cartella Logs se non esiste
            If Not Directory.Exists(logFolder) Then
                Directory.CreateDirectory(logFolder)
            End If

            ' Normalizza il livello in maiuscolo
            level = level.Trim().ToUpper()

            ' Controllo di sicurezza: se non è uno dei valori previsti, lo segno come "INFO"
            If Not {"OK", "WARNING", "ERROR"}.Contains(level) Then
                level = "INFO"
            End If

            ' Prepara la riga di log con data e ora
            Dim logLine As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}"

            ' Scrive la riga nel file (append)
            File.AppendAllText(logFilePath, logLine & Environment.NewLine)
        Catch ex As Exception
            ' In caso di errore nella scrittura, non bloccare l'app
            Debug.WriteLine("Errore nel log: " & ex.Message)
        End Try
    End Sub
End Module
