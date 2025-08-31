Public Class ToastForm
    Inherits Form

    ' Fa in modo che il toast non rubi il focus
    Protected Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property
End Class
