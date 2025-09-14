Public Class CustomColorTableMenu
    Inherits ProfessionalColorTable

    ' Sfondo dei dropdown
    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return ColorTranslator.FromHtml("#FFFFFF") ' sfondo uniforme
        End Get
    End Property

    ' Colore bordo del dropdown
    Public Overrides ReadOnly Property MenuBorder As Color
        Get
            Return ColorTranslator.FromHtml("#FFFFFF")
        End Get
    End Property

    ' Colore item hover
    Public Overrides ReadOnly Property MenuItemSelected As Color
        Get
            Return ColorTranslator.FromHtml("#8FB8E0") ' colore hover
        End Get
    End Property

    ' Colore del bordo dell'item (opzionale)
    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return ColorTranslator.FromHtml("#FFFFFF")
        End Get
    End Property
End Class
