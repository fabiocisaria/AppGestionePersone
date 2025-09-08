Public Class ToastForm
    Inherits Form

    ' Fa in modo che il toast non rubi il focus
    Protected Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H8000000 ' WS_EX_NOACTIVATE
            Return cp
        End Get
    End Property
End Class
