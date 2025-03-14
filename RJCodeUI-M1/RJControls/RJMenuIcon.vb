Imports System.ComponentModel
Imports FontAwesome.Sharp

Public Class RJMenuIcon
    Inherits IconPictureBox

    ''' <summary>
    ''' This class inherits from the <IconPictureBox/> class of the <FontAwesome.Sharp/> library
    '''      Autor: mkoertgen
    '''      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
    '''      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp
    ''' This is a special control that is designed primarily to be used on the title bar of the main form,
    ''' however you can disable that by setting the BackIcon property to true (Icon color equals text color)
    ''' This control can work as a normal button or as a drop down menu button, for this you need to add 
    ''' a drop down menu(<RJDropdownMenu/>) of the properties of this control (<DropdownMenu/>)
    ''' and the click event will be automatically created to display the drop-down menu.
    ''' You can change the appearance color, but you must set the customizable property to TRUE.
    ''' </summary>

#Region "-> Fields"

    Private _supernovaColor As Color 'Sets a color for the supernova style
    Private _tempColor As Color 'Sets a temporary color for the icon
    Private _tempSize As Integer 'Sets a temporary size for the icon
    Private _dropdownMenuIsDisplayed As Boolean 'Sets whether the control displays a dropdown menu
    Private _customizable As Boolean 'Sets whether the control can be customized regardless of the style set
    Private _backIcon As Boolean 'Gets or sets whether the control is an icon that can be used in the client area of any form.
    Private _dropdownMenu As RJDropdownMenu 'Sets or gets the dropdown menu.
#End Region

#Region "-> Constructor"

    Public Sub New()
        Me.IconChar = FontAwesome.Sharp.IconChar.Github
        Me.IconColor = Color.Crimson
        Me.IconSize = 25
        Me.SizeMode = PictureBoxSizeMode.AutoSize
        Me.Cursor = Cursors.Hand
        Me.BackColor = Color.Transparent
        AddHandler Me.HandleCreated, AddressOf BarIcon_HandleCreated 'Apply settings when HandleCreated event fires.
        AddHandler Me.MouseEnter, AddressOf BarIcon_MouseEnter 'Occurs when the mouse hovers over the control.
        AddHandler Me.MouseLeave, AddressOf BarIcon_MouseLeave 'Occurs when the mouse leaves control.
    End Sub
#End Region

#Region "-> Properties"

    'Hide ContextMenuStrip property
    <Browsable(False)>
    <[ReadOnly](True)>
    Public Overloads Property ContextMenuStrip As ContextMenuStrip
        Get
            Return MyBase.ContextMenuStrip
        End Get
        Set(value As ContextMenuStrip)
        End Set
    End Property

    'Create a new property to associate an RJDropdownMenu
    <Category("RJ Code Advance")>
    <Description("Gets or sets the RJDropdownMenu associated with this control")>
    Public Property DropdownMenu As RJDropdownMenu
        Get
            Return _dropdownMenu 'Return RJDropdownMenu
        End Get
        Set(value As RJDropdownMenu)
            _dropdownMenu = value 'Set value

            If _dropdownMenu IsNot Nothing Then
                AddHandler _dropdownMenu.VisibleChanged, AddressOf DropdownMenu_VisibleChanged 'Subscribe the RJDropdownMenu.VisibleChanged event.
                AddHandler Me.Click, AddressOf Show_DropdownMenu 'Subscribe the click event to show the dropdown menu.
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BackIcon As Boolean
        'Sets or gets if the control is a menu icon in the title bar of the main form (False),
        'or is a menu icon in any client area of ​​the form (True).
        Get
            Return _backIcon
        End Get
        Set(value As Boolean)
            _backIcon = value
            If Me.DesignMode Then ApplyAppearanceSettings()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Customizable As Boolean
        'Sets whether the control can be customized regardless of the style set
        Get
            Return _customizable
        End Get
        Set(value As Boolean)
            _customizable = value
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ShowDropdownMenu()
        'Show dropdown menu
        Try
            _dropdownMenu.Show(Me, DropdownMenuPosition.BottomRight)
        Catch ex As Exception
            RJMessageBox.Show("An error has occurred" & vbLf & ex.ToString())
        End Try
    End Sub

    Private Sub ApplyAppearanceSettings()
        'Apply settings as long as they are not customizable
        If _customizable = False Then

            If _backIcon = True Then 'Menu icon on any background of a form.
                Me.IconColor = UIAppearance.TextColor

            Else 'Menu icon in title bar of main form
                'if the theme is dark and the style is supernova, the icon color will be the same color as normal paragraph text
                If UIAppearance.Theme = UITheme.Dark AndAlso UIAppearance.Style = UIStyle.Supernova Then
                    Me.IconColor = ColorEditor.Lighten(UIAppearance.TextColor, 65)
                    'if the theme is clear and the style is supernova, the icon color will be the same color as normal paragraph text
                ElseIf UIAppearance.Theme = UITheme.Light AndAlso UIAppearance.Style = UIStyle.Supernova Then
                    Me.IconColor = ColorEditor.Darken(UIAppearance.TextColor, 25)
                Else 'if the style is different, the icon color will be white.
                    Me.IconColor = Color.WhiteSmoke
                End If
            End If
        End If
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub BarIcon_HandleCreated(sender As Object, e As EventArgs)
        'Apply settings when HandleCreated event fires
        ApplyAppearanceSettings()
        'if the style is supernova get a color
        If UIAppearance.Style = UIStyle.Supernova Then _supernovaColor = RJColors.GetSupernovaColor()
    End Sub

    Private Sub BarIcon_MouseEnter(sender As Object, e As EventArgs)
        'When the mouse hovers over the control, enlarge the size of the icon and if the style is supernova, change the color of the icon.
        _tempSize = Me.IconSize 'Save icon size.
        Me.IconSize = Me.IconSize + 2 'Set new icon size

        If UIAppearance.Style = UIStyle.Supernova Then 'if the style is supernova
            _tempColor = Me.IconColor 'Save the icon color.
            Me.IconColor = _supernovaColor 'Set supernova color
        End If
    End Sub

    Private Sub BarIcon_MouseLeave(sender As Object, e As EventArgs)
        'When the mouse leaves control
        If Not _dropdownMenuIsDisplayed Then 'Reset to defaults whenever dropdown menu is not open
            Me.IconSize = _tempSize
            If UIAppearance.Style = UIStyle.Supernova Then Me.IconColor = _tempColor
        End If
        'Note: This is to keep the bar icon activated (highlighted) when the drop-down menu is displayed.
    End Sub

    Private Sub Show_DropdownMenu(sender As Object, e As EventArgs)
        ShowDropdownMenu()
    End Sub

    Private Sub DropdownMenu_VisibleChanged(sender As Object, e As EventArgs)
        If Not Me.DesignMode Then 'Run this when not in design mode

            If _dropdownMenu.Visible Then 'If dropdown menu was displayed
                _dropdownMenuIsDisplayed = True 'Set true
            Else 'If drop-down menu has been hidden (Closed)
                _dropdownMenuIsDisplayed = False 'Set false
                'Reset original values
                Me.IconSize = _tempSize
                If UIAppearance.Style = UIStyle.Supernova Then Me.IconColor = _tempColor
            End If
        End If
    End Sub
#End Region

End Class
