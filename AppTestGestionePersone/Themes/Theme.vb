Imports System.Drawing.Drawing2D

Public Class Theme

    '=============
    ' Colori bordo
    '=============
    Private Shared ReadOnly BaseBorderColor As Color = Color.FromArgb(80, 80, 80)
    Private Shared ReadOnly FocusedBorderColor As Color = Color.FromArgb(41, 128, 185)
    Private Shared ReadOnly HoveredBorderColor As Color = Color.FromArgb(41, 128, 185)

    '=============
    ' Colori testo
    '=============
    Private Shared ReadOnly BaseForeColor As Color = Color.FromArgb(21, 36, 54)
    Private Shared ReadOnly FocusedForeColor As Color = Color.FromArgb(50, 155, 230)
    Private Shared ReadOnly DisabledForeColor As Color = Color.FromArgb(171, 171, 171)
    Private Shared ReadOnly PressedForeColor As Color = Color.FromArgb(50, 155, 230)
    Private Shared ReadOnly HoveredForeColor As Color = Color.FromArgb(50, 155, 230)
    Private Shared ReadOnly ActiveClearForeColor As Color = Color.FromArgb(192, 57, 43)

    '==============
    ' Colori sfondo
    '==============
    Private Shared ReadOnly BaseBackColor As Color = Color.FromArgb(255, 255, 255)
    Private Shared ReadOnly FocusedBackColor As Color = Color.FromArgb(255, 255, 255)
    Private Shared ReadOnly HoveredBackColor As Color = Color.FromArgb(255, 255, 255)
    Private Shared ReadOnly DisabledBackColor As Color = Color.FromArgb(255, 255, 255)
    Private Shared ReadOnly PressedBackColor As Color = Color.FromArgb(255, 255, 255)

    '======================
    ' Colori evidenziazioni
    '======================
    Private Shared ReadOnly HoverItemColor As Color = Color.FromArgb(229, 238, 255)
    Private Shared ReadOnly SelectedItemColor As Color = Color.LightGreen


    'Public Shared PrimaryColor As Color = Color.FromArgb(&H40, &H90, &HFF)
    'Public Shared SecondaryColor As Color = Color.FromArgb(&H70, &H60, &HE0)
    'Public Shared BackgroundColor As Color = Color.White
    'Public Shared TextColor As Color = Color.Black
    'Public Shared ButtonRadius As Integer = 8
    Public Shared ReadOnly UCBackgroundFirstColor As Color = Color.FromArgb(255, 255, 255)
    Public Shared ReadOnly UCBackgroundSecondColor As Color = Color.FromArgb(245, 245, 247)

    '==================
    ' Colori principali
    '==================
    Public Shared ReadOnly BackgroundPrimaryColor As Color = Color.White
    Public Shared ReadOnly PrimaryPanelBackgroundColor As Color = Color.White
    Public Shared ReadOnly SecondaryPanelActiveBackgroundColor As Color = Color.FromArgb(255, 255, 255)
    'Color.FromArgb(214, 231, 255)
    Public Shared ReadOnly SecondaryPanelInactiveBackgroundColor As Color = Color.FromArgb(232, 232, 232)
    'Color.FromArgb(245, 245, 245)

    '============
    ' Bordo panel
    '============
    Public Shared ReadOnly SecondaryPanelActiveBorder As Color = Color.FromArgb(230, 237, 244)
    Public Shared ReadOnly SecondaryPanelInactiveBorder As Color = Color.FromArgb(230, 237, 244)

    Public Shared ReadOnly PrimaryColor As Color = Color.FromArgb(41, 128, 185)
    Public Shared ReadOnly SecondaryColor As Color = Color.FromArgb(31, 97, 144)
    Public Shared ReadOnly TitlePazienteColor As Color = Color.FromArgb(46, 67, 89)
    Public Shared ReadOnly TextColor As Color = Color.FromArgb(21, 36, 54)
    Public Shared ReadOnly LabelColor As Color = Color.FromArgb(50, 50, 50)
    Public Shared ReadOnly CodeColor As Color = Color.FromArgb(90, 90, 90)
    Public Shared ReadOnly FindColor As Color = Color.Gray

    '=====
    ' Font
    '=====
    Public Shared ReadOnly DefaultFont As Font = New Font("Segoe UI", 10)
    Public Shared ReadOnly TitlePrimaryFont As Font = New Font("Segoe UI", 14, FontStyle.Bold)
    Public Shared ReadOnly TitleSecondaryFont As Font = New Font("Segoe UI", 12, FontStyle.Bold)
    Public Shared ReadOnly TitleThirdFont As Font = New Font("Segoe UI", 10, FontStyle.Bold)
    Public Shared ReadOnly TitlePazienteFont As Font = New Font("Segoe UI", 18, FontStyle.Bold)
    Public Shared ReadOnly TitleVisitaFont As Font = New Font("Segoe UI", 16, FontStyle.Bold)
    Public Shared ReadOnly CodeFont As Font = New Font("Segoe UI", 10, FontStyle.Bold)
    Public Shared ReadOnly TxtFontItalic As Font = New Font("Segoe UI", 10, FontStyle.Italic)
    Public Shared ReadOnly TxtFont As Font = New Font("Segoe UI", 10)
    Public Shared ReadOnly ButtonFont As Font = New Font("Segoe UI", 10, FontStyle.Bold)

    '===========
    'Colori menu
    '===========
    Public Shared ReadOnly StripMenuPrimaryColor As Color = Color.FromArgb(46, 67, 89)
    'Color.FromArgb(31, 59, 111)
    Public Shared ReadOnly StripMenuHoveredColor As Color = Color.FromArgb(63, 92, 122)
    'Color.FromArgb(235, 42, 74, 140)
    Public Shared ReadOnly StripMenuActiveColor As Color = Color.FromArgb(57, 83, 110)
    'Color.FromArgb(37, 70, 133)

    Public Shared ReadOnly StripMenuBorderHoveredColor As Color = Color.FromArgb(204, 222, 240)
    'Color.FromArgb(92, 122, 210)
    Public Shared ReadOnly StripMenuBorderActiveColor As Color = Color.FromArgb(63, 100, 143)

    Public Shared ReadOnly StripMenuTextPrimaryColor As Color = Color.FromArgb(208, 226, 252)
    Public Shared ReadOnly StripMenuTextHoveredColor As Color = Color.FromArgb(204, 222, 240)
    Public Shared ReadOnly StripMenuTextActiveColor As Color = Color.FromArgb(193, 210, 235)

    '=============
    ' DateTimeEdit
    '=============
    Public Shared ReadOnly DteBackColor As Color = BaseBackColor
    Public Shared ReadOnly DteBorderColor As Color = BaseBorderColor
    Public Shared ReadOnly DteDisabledBackColor As Color = DisabledBackColor
    Public Shared ReadOnly DteDisabledForeColor As Color = DisabledForeColor
    Public Shared ReadOnly DteFcusedBorderColor As Color = FocusedBorderColor
    Public Shared ReadOnly DteForeColor As Color = BaseForeColor
    Public Shared ReadOnly DteHoverBorderColor As Color = HoveredBorderColor
    Public Shared ReadOnly DteUpDownBackColor As Color = BaseBackColor
    Public Shared ReadOnly DteUpDownForeColor As Color = BaseForeColor
    Public Shared ReadOnly DteUpDownHoverBackColor As Color = HoveredBackColor
    Public Shared ReadOnly DteUpDownHoverForeColor As Color = HoveredForeColor
    Public Shared ReadOnly DteWatermarkForeColor As Color = BaseForeColor
    'DateTimeEdit DropDown
    Public Shared ReadOnly DteDropDownBackColor As Color = BaseBackColor
    Public Shared ReadOnly DteDropDownForeColor As Color = BaseForeColor
    Public Shared ReadOnly DteDropDownHoverBackColor As Color = HoveredBackColor
    Public Shared ReadOnly DteDropDownHoverForeColor As Color = HoveredForeColor
    Public Shared ReadOnly DteDropDownPressedBackColor As Color = PressedBackColor
    Public Shared ReadOnly DteDropDownPressedForeColor As Color = PressedForeColor

    '=========
    ' ComboBox
    '=========
    Public Shared ReadOnly ComboBoxBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxForeColor As Color = BaseForeColor
    Public Shared ReadOnly ComboBoxBorderColor As Color = BaseBorderColor
    Public Shared ReadOnly ComboBoxDisabledBackColor As Color = DisabledBackColor
    Public Shared ReadOnly ComboBoxHoveredBorderColor As Color = HoveredBorderColor
    Public Shared ReadOnly ComboBoxFocusedBorderColor As Color = FocusedBorderColor

    ' ComboBox editor style
    Public Shared ReadOnly ComboBoxEditorStyleBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxEditorStyleForeColor As Color = BaseForeColor
    Public Shared ReadOnly ComboBoxEditorStyleFocusedBorderColor As Color = FocusedBorderColor

    ' ComboBox dorp down button
    Public Shared ReadOnly ComboBoxDropDownButtonBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxDropDownButtonDisabledBackColor As Color = DisabledBackColor
    Public Shared ReadOnly ComboBoxDropDownButtonDisabledForeColor As Color = DisabledForeColor
    Public Shared ReadOnly ComboBoxDropDownButtonStyleFocusedBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxDropDownButtonStyleFocusedForeColor As Color = FocusedForeColor
    Public Shared ReadOnly ComboBoxDropDownButtonStyleForeColor As Color = BaseForeColor
    Public Shared ReadOnly ComboBoxDropDownButtonStyleHoverBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxDropDownButtonStyleHoverForeColor As Color = HoveredForeColor
    Public Shared ReadOnly ComboBoxDropDownButtonStylePressedBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxDropDownButtonStylePressedForeColor As Color = PressedForeColor

    ' ComboBox clear button
    Public Shared ReadOnly ComboBoxClearButtonBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxClearButtonDisabledBackColor As Color = DisabledBackColor
    Public Shared ReadOnly ComboBoxClearButtonDisabledForeColor As Color = DisabledForeColor
    Public Shared ReadOnly ComboBoxClearButtonStyleFocusedBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxClearButtonStyleFocusedForeColor As Color = ActiveClearForeColor
    Public Shared ReadOnly ComboBoxClearButtonStyleForeColor As Color = BaseForeColor
    Public Shared ReadOnly ComboBoxClearButtonStyleHoverBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxClearButtonStyleHoverForeColor As Color = ActiveClearForeColor
    Public Shared ReadOnly ComboBoxClearButtonStylePressedBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxClearButtonStylePressedForeColor As Color = ActiveClearForeColor

    'DropDown style
    Public Shared ReadOnly ComboBoxDropDownStyleBorderColor As Color = BaseBorderColor

    'Gesione elementi
    Public Shared ReadOnly ComboBoxItemHoverBackColor As Color = HoverItemColor
    Public Shared ReadOnly ComboBoxItemSelectedBackColor As Color = SelectedItemColor
    Public Shared ReadOnly ComboBoxItemBackColor As Color = BaseBackColor
    Public Shared ReadOnly ComboBoxItemForeColor As Color = BaseForeColor

    '=========
    ' TextBox
    '=========
    Public Shared ReadOnly TextBoxBorderColor As Color = BaseBorderColor
    Public Shared ReadOnly TextBoxFocusBorderColor As Color = FocusedBorderColor
    Public Shared ReadOnly TextBoxForeColor As Color = BaseForeColor
    Public Shared ReadOnly TextBoxBackColor As Color = BaseBackColor

    '==============
    ' Panel terapie
    '==============
    'Public Shared ReadOnly TerapiePanelBackColor As Color = Color.FromArgb(31, 97, 141)
    'Public Shared ReadOnly TerapiePanelHoveredBackColor As Color = Color.FromArgb(21, 67, 96)
    'Public Shared ReadOnly TerapiePanelForeColor As Color = Color.WhiteSmoke
    'Public Shared ReadOnly TerapiePanelHoveredForeColor As Color = Color.FromArgb(173, 216, 230)
    'Public Shared ReadOnly TerapiePanelDeleteForeColor As Color = Color.FromArgb(192, 57, 43)

    Public Shared ReadOnly TerapiePanelBackColor As Color = Color.FromArgb(142, 68, 173)
    Public Shared ReadOnly TerapiePanelHoveredBackColor As Color = Color.FromArgb(108, 52, 131)
    Public Shared ReadOnly TerapiePanelForeColor As Color = Color.WhiteSmoke
    Public Shared ReadOnly TerapiePanelHoveredForeColor As Color = Color.FromArgb(220, 198, 255)
    Public Shared ReadOnly TerapiePanelDeleteForeColor As Color = Color.FromArgb(192, 57, 43)

    '==============
    ' Panel Farmaci
    '==============
    Public Shared ReadOnly FarmaciPanelBackColor As Color = Color.FromArgb(52, 152, 219)
    Public Shared ReadOnly FarmaciPanelHoveredBackColor As Color = Color.FromArgb(52, 152, 219)
    Public Shared ReadOnly FarmaciPanelForeColor As Color = Color.WhiteSmoke
    Public Shared ReadOnly FarmaciPanelHoveredForeColor As Color = Color.FromArgb(173, 216, 230)
    Public Shared ReadOnly FarmaciPanelDeleteForeColor As Color = Color.FromArgb(192, 57, 43)

    '==============
    ' Panel Integratori
    '==============
    Public Shared ReadOnly IntegratoriPanelBackColor As Color = Color.FromArgb(26, 188, 156)
    Public Shared ReadOnly IntegratoriPanelHoveredBackColor As Color = Color.FromArgb(20, 143, 119)
    Public Shared ReadOnly IntegratoriPanelForeColor As Color = Color.WhiteSmoke
    Public Shared ReadOnly IntegratoriPanelHoveredForeColor As Color = Color.FromArgb(200, 250, 240)
    Public Shared ReadOnly IntegratoriPanelDeleteForeColor As Color = Color.FromArgb(192, 57, 43)

    '==========================
    ' Panel Malattie autoimmuni
    '==========================
    Public Shared ReadOnly MalattieAutoimmPanelBackColor As Color = Color.FromArgb(52, 152, 219)
    Public Shared ReadOnly MalattieAutoimmPanelHoveredBackColor As Color = Color.FromArgb(52, 152, 219)
    Public Shared ReadOnly MalattieAutoimmPanelForeColor As Color = Color.WhiteSmoke
    Public Shared ReadOnly MalattieAutoimmPanelHoveredForeColor As Color = Color.FromArgb(173, 216, 230)
    Public Shared ReadOnly MalattieAutoimmPanelDeleteForeColor As Color = Color.FromArgb(192, 57, 43)
End Class
