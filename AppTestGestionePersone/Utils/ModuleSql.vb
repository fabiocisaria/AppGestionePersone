'Imports System.Data.SqlClient
'Imports System.Data.SqlClient
Imports System.Threading
Imports Azure.Core
Imports Microsoft.Data.Common
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client

Module ConnessioneDB
    Private ReadOnly TenantId As String = "de9a97de-c78e-45ee-bfe4-e914651a9573"
    Private ReadOnly ClientId As String = "68aca7a3-86df-44f4-82c5-722f6f8739f1"
    Private ReadOnly Authority As String = $"https://login.microsoftonline.com/{TenantId}"
    Private ReadOnly SqlScope As String() = {"https://database.windows.net//.default"}

    Private ReadOnly pca As IPublicClientApplication = PublicClientApplicationBuilder _
        .Create(ClientId) _
        .WithAuthority(Authority) _
        .WithDefaultRedirectUri() _
        .Build()

    Private accessToken As String = Nothing
    Private tokenExpiry As DateTimeOffset

    Private connectionTimeout As Integer = 30 ' Timeout di connessione in secondi

    ' Gestisco l'errato rinnovo del token
    Public Event RichiediNuovoLogin()

    ' 🔹 Acquisisce o rinnova il token in modo asincrono
    Public Async Function AcquireTokenAsync(Optional isLogin As Boolean = False) As Task(Of String)
        Dim result As AuthenticationResult = Nothing

        Try
            Dim accounts = Await pca.GetAccountsAsync()
            result = Await pca.AcquireTokenSilent(SqlScope, accounts.FirstOrDefault()) _
                          .ExecuteAsync()
        Catch ex As MsalUiRequiredException
            ' Non faccio Await qui dentro, solo segno che serve login interattivo
        End Try

        ' Se non ho ottenuto un token → forzo login interattivo
        If result Is Nothing Then
            Try
                result = Await pca.AcquireTokenInteractive(SqlScope.AsEnumerable()) _
                              .WithPrompt(Prompt.ForceLogin) _
                              .ExecuteAsync()
            Catch ex As MsalClientException
                ' Utente ha chiuso la finestra o ha negato l’accesso
                If isLogin Then
                    Return "Accesso negato"
                Else
                    RaiseEvent RichiediNuovoLogin()
                    Return Nothing
                End If
            Catch ex As MsalServiceException
                ' Problema lato Azure AD (es. tenant non trovato, rete, ecc.)
                If isLogin Then
                    Return "Accesso negato"
                Else
                    RaiseEvent RichiediNuovoLogin()
                    Return Nothing
                End If
            End Try
        End If

        If result IsNot Nothing Then
            tokenExpiry = result.ExpiresOn
            Return result.AccessToken
        End If

        RaiseEvent RichiediNuovoLogin()
        Return Nothing
    End Function

    ' 🔹 Recupera token (prima tenta silent, se non c’è fa login interattivo)
    Private Async Function GetAccessTokenAsync() As Task(Of String)
        If String.IsNullOrEmpty(accessToken) OrElse DateTimeOffset.UtcNow >= tokenExpiry.AddMinutes(-5) Then
            accessToken = Await AcquireTokenAsync()
        End If
        Return accessToken
    End Function

    ' 🔹 Funzione per aprire una connessione SQL con token Azure AD
    Public Async Function GetConnectionAsync() As Task(Of SqlConnection)
        Dim token As String = Await GetAccessTokenAsync()

        ' Stringa di connessione base (senza user/password)
        Dim connectionString As String = "Server = tcp:gynarchive-svr.database.windows.net,1433;" &
                                         "Database = GynArchiveDB;" &
                                         "Encrypt = True;" &
                                         "Column Encryption Setting = Disabled;" &
                                         "TrustServerCertificate = False;" &
                                         "Connect Timeout = " & connectionTimeout.ToString() & ";"

        ' Costruzione della connessione con Access Token
        Dim conn As New SqlConnection(connectionString)
        conn.AccessToken = token

        Try
            Await conn.OpenAsync()
        Catch ex As Exception
            Debug.WriteLine("Errore di connessione al database: " & ex.Message)
            Throw
        End Try

        Return conn
    End Function

    Public Sub ResetToken()
        accessToken = Nothing
        tokenExpiry = DateTimeOffset.MinValue
    End Sub

    Public Async Function WakeUpQuery(Optional updateTentativi As Action(Of Integer) = Nothing) As Task
        ' Wake up query per risvegliare il database in caso di pausa

        connectionTimeout = 9 ' abbasso il connection timeout perché se il server è attivo risponde subito

        Dim timeout As Integer = 5

        Dim query As String = "SELECT 1"

        Dim dbReady As Boolean = False
        Dim tentativi As Integer = 0
        Const maxTentativi As Integer = 10

        While Not dbReady AndAlso tentativi < maxTentativi
            tentativi += 1

            updateTentativi?.Invoke(tentativi) ' Aggiorna tentativi nello UC

            Try
                Using conn As SqlConnection = Await GetConnectionAsync()
                    Using cmd As New SqlCommand(query, conn)
                        cmd.CommandTimeout = timeout
                        Dim result = Await cmd.ExecuteScalarAsync()
                        dbReady = True ' Query eseguita con successo, il DB è pronto

                        connectionTimeout = 30 ' ripristino timeout normale
                    End Using
                End Using
            Catch ex As Exception
                Debug.WriteLine($"Tentativo {tentativi}: DB non ancora pronto → {ex.Message}")
            End Try

            If Not dbReady Then
                Await Task.Delay(1000) ' attesa di 1 secondi prima del prossimo tentativo
            End If
        End While

        If Not dbReady Then
            Throw New Exception("Impossibile risvegliare il database dopo diversi tentativi.")
        End If
    End Function

    ' 🔹 Funzione per eseguire query di tipo INSERT/UPDATE/DELETE
    Public Async Function EseguiNonQueryAsync(query As String, Optional parameters As List(Of SqlParameter) = Nothing, Optional timeout As Integer = 15) As Task(Of Integer)
        Dim righeAffette As Integer = 0
        Using conn As SqlConnection = Await GetConnectionAsync()
            Using cmd As New SqlCommand(query, conn)

                cmd.CommandTimeout = timeout

                If parameters IsNot Nothing Then
                    ' Servono in caso di colonne crittografate (funzionano anche su quelle normali)
                    'Dim fixedParams = NormalizeParameters(parameters)
                    'cmd.Parameters.AddRange(fixedParams.ToArray())
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Try
                    righeAffette = Await cmd.ExecuteNonQueryAsync()
                Catch ex As Exception
                    Debug.WriteLine("Errore nell'esecuzione della query: " & ex.Message)
                    Throw
                End Try
            End Using
        End Using
        Return righeAffette
    End Function

    Public Async Function EseguiScalarAsync(query As String, Optional parameters As List(Of SqlParameter) = Nothing, Optional timeout As Integer = 15) As Task(Of Integer)
        Dim result As Object = Nothing
        Using conn As SqlConnection = Await GetConnectionAsync()
            Using cmd As New SqlCommand(query, conn)

                cmd.CommandTimeout = timeout

                If parameters IsNot Nothing Then
                    ' Servono in caso di colonne crittografate (funzionano anche su quelle normali)
                    'Dim fixedParams = NormalizeParameters(parameters)
                    'cmd.Parameters.AddRange(fixedParams.ToArray())
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Try
                    result = Await cmd.ExecuteScalarAsync()
                Catch ex As Exception
                    Debug.WriteLine("Errore nell'esecuzione della query: " & ex.Message)
                    Throw
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
    Public Async Function EseguiQueryAsync(query As String, Optional parameters As List(Of SqlParameter) = Nothing, Optional timeout As Integer = 15) As Task(Of DataTable)
        Dim dt As New DataTable()
        Using conn As SqlConnection = Await GetConnectionAsync()
            Using cmd As New SqlCommand(query, conn)

                cmd.CommandTimeout = timeout

                If parameters IsNot Nothing Then
                    ' Servono in caso di colonne crittografate (funzionano anche su quelle normali)
                    'Dim fixedParams = NormalizeParameters(parameters)
                    'cmd.Parameters.AddRange(fixedParams.ToArray())
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Try
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    Debug.WriteLine("Errore nell'esecuzione della query: " & ex.Message)
                    Throw
                End Try
            End Using
        End Using
        Return dt
    End Function
End Module
