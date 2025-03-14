Imports System.ComponentModel

Public Class RJDropdownMenu
    Inherits ContextMenuStrip

    ''' <summary>
    ''' This class inherits from the ContextMenuStrip class.
    ''' To customize the appearance of this control use the classes:
    ''' <DropdownMenuColors/> and <DropdownMenuRenderer/>
    ''' It also helps you to position the control in an easier way thanks
    ''' to the <DropdownMenuPosition/> enumeration.
    ''' </summary>
    '''

#Region "-> Fields"

    Private _ownerIsMenuButton As Boolean 'Sets or gets if the dropdown menu belongs to the menu button of the main form side menu (RJMenuButton)
    Private _activeMenuItem As Boolean 'Sets or gets if menu item is on (has an associated form, a menu item will remain highlighted when the form is open)
    Private _menuItemColor As MenuItemColors ' Sets or gets the dropdown menu colors.
    Private _menuItemIcon As Bitmap 'Sets or gets the icon of the menu item, also sets the height of the menu item.
#End Region

#Region "-> Constructors"

    Public Sub New()
        _menuItemColor = New MenuItemColors()
        ApplyAppearanceSettings()
        LoadItemAppearance()
        Me.Renderer = New DropdownMenuRenderer(_menuItemColor) 'Set the custom renderer and send the ownerIsMenuButton property to the parameter.
        Me.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0)))) 'Set default font
    End Sub


    '' Summary:
    '' Initialize a new instance of the RJDropdownMenu class
    '' and associates it with the specified container.
    ''
    '' Parameters:
    ''      container:
    '' A component that implements the System.ComponentModel.IContainer that is the container for the
    '' system.Windows.Forms.ContextMenuStrip.
    Public Sub New(container As IContainer) 'This constructor is automatically invoked in the form designer when the control is dragged from the toolbox onto the form.
        MyBase.New(container) 'This constructor ensures that the object is disposed of correctly, as it is not a child of the form.
        _menuItemColor = New MenuItemColors()
        ApplyAppearanceSettings()
        LoadItemAppearance()
        Me.Renderer = New DropdownMenuRenderer(_menuItemColor) 'Set the custom renderer and send the ownerIsMenuButton property to the parameter.
        Me.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0)))) 'Set default font
    End Sub
#End Region

#Region "-> Properties"

    <Browsable(False)>
    Public Property OwnerIsMenuButton As Boolean
        'Sets or gets if the dropdown menu belongs to the main form side menu menu button
        Get
            Return _ownerIsMenuButton
        End Get
        Set(value As Boolean)
            _ownerIsMenuButton = value
        End Set
    End Property

    <Browsable(False)>
    Public Property ActiveMenuItem As Boolean
        Get
            Return _activeMenuItem
        End Get
        Set(value As Boolean)
            _activeMenuItem = value
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        If UIAppearance.Theme = UITheme.Dark OrElse _ownerIsMenuButton = True Then 'If the theme is dark or the dropdown is displayed from the menu button, set the following colors
            _menuItemColor.DropdownMenuBackground = RJColors.DarkItemBackground
            _menuItemColor.DropdownMenuBorder = ColorEditor.Darken(RJColors.DarkItemBackground, 10)
            _menuItemColor.MenuItemBorder = RJColors.DarkActiveBackground
            _menuItemColor.MenuItemSelected = RJColors.DarkActiveBackground
            _menuItemColor.LeftColumnGradientBegin = ColorEditor.Darken(RJColors.DarkItemBackground, 4)
            _menuItemColor.LeftColumnGradientMiddle = ColorEditor.Darken(RJColors.DarkItemBackground, 4)
            _menuItemColor.LeftColumnGradientEnd = ColorEditor.Darken(RJColors.DarkItemBackground, 4)
            _menuItemColor.MenuItemArrow = UIAppearance.StyleColor
            _menuItemColor.TextColor = RJColors.DarkTextColor
        Else 'If the theme is clear, set the following colors.
            _menuItemColor.DropdownMenuBackground = RJColors.LightItemBackground
            _menuItemColor.DropdownMenuBorder = ColorEditor.Darken(UIAppearance.BackgroundColor, 10)
            _menuItemColor.MenuItemBorder = RJColors.LightActiveBackground
            _menuItemColor.MenuItemSelected = RJColors.LightActiveBackground
            _menuItemColor.LeftColumnGradientBegin = ColorEditor.Darken(RJColors.LightItemBackground, 4)
            _menuItemColor.LeftColumnGradientMiddle = ColorEditor.Darken(RJColors.LightItemBackground, 4)
            _menuItemColor.LeftColumnGradientEnd = ColorEditor.Darken(RJColors.LightItemBackground, 4)
            _menuItemColor.MenuItemArrow = UIAppearance.StyleColor
            _menuItemColor.TextColor = RJColors.LightTextColor
        End If
    End Sub

    Private Sub LoadItemAppearance()
        'Set text color
        If UIAppearance.Theme = UITheme.Dark OrElse _ownerIsMenuButton = True Then
            _menuItemColor.TextColor = RJColors.DarkTextColor
        Else
            _menuItemColor.TextColor = RJColors.LightTextColor
        End If

        '- Set the height of the menu item and the width of the left column of the drop-down menu using the image property of the menu item.
        If OwnerIsMenuButton = True Then 'If the owner is a menu button.
            _menuItemIcon = New Bitmap(25, 45) 'Set 25 px wide and 45 px HEIGHT
        Else 'Otherwise, default value and specified height.
            _menuItemIcon = New Bitmap(22, 25) 'Set 22 px width and specified height.
        End If

        '- Set the text color of the settings and adjust the image of the menu item (icon)
        'region - Dropdown Menu Item Level 1 ------------------------------------------ ---
        For Each menuItemL1 As ToolStripMenuItem In Me.Items
            If _activeMenuItem = False Then menuItemL1.ForeColor = _menuItemColor.TextColor 'Set the text color when you do not have a menu item activated, that is, keep the highlighted color that is set in the menu button.
            menuItemL1.ImageScaling = ToolStripItemImageScaling.None

            If menuItemL1.Image Is Nothing Then 'If no image is set in the menu item, set the no-image bitmap (menuItemIcon) to keep the previously defined height and width.
                menuItemL1.Image = _menuItemIcon 'Set non-image bitmap
            Else 'If an image has been set in the menu item, readjust the image to keep the previously defined height and width (Limit left column width and menu item height)
                menuItemL1.Image = RedrawMenuItemIcon(menuItemL1.Image) 'Redraw menu item icon
            End If

            'region - Dropdown Menu Item Level 2 ------------------------------------------ ---
            For Each menuItemL2 As ToolStripMenuItem In menuItemL1.DropDownItems
                If _activeMenuItem = False Then menuItemL2.ForeColor = _menuItemColor.TextColor
                menuItemL2.ImageScaling = ToolStripItemImageScaling.None

                If menuItemL2.Image Is Nothing Then
                    menuItemL2.Image = _menuItemIcon
                Else
                    menuItemL2.Image = RedrawMenuItemIcon(menuItemL2.Image)
                End If

                'region - Dropdown Menu Item Level 3 ------------------------------------------ ---
                For Each menuItemL3 As ToolStripMenuItem In menuItemL2.DropDownItems
                    If _activeMenuItem = False Then menuItemL3.ForeColor = _menuItemColor.TextColor
                    menuItemL3.ImageScaling = ToolStripItemImageScaling.None

                    If menuItemL3.Image Is Nothing Then
                        menuItemL3.Image = _menuItemIcon
                    Else
                        menuItemL3.Image = RedrawMenuItemIcon(menuItemL3.Image)
                    End If

                    'region - Dropdown Menu Item Level 4 ------------------------------------------ ---
                    For Each menuItemL4 As ToolStripMenuItem In menuItemL3.DropDownItems
                        If _activeMenuItem = False Then menuItemL4.ForeColor = _menuItemColor.TextColor
                        menuItemL4.ImageScaling = ToolStripItemImageScaling.None

                        If menuItemL4.Image Is Nothing Then
                            menuItemL4.Image = _menuItemIcon
                        Else
                            menuItemL4.Image = RedrawMenuItemIcon(menuItemL4.Image)
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    Private Function RedrawMenuItemIcon(itemImage As Image) As Image
        'This method will resize and center the image of the menu item
        Dim newItemIcon = New Bitmap(_menuItemIcon.Width, _menuItemIcon.Height) 'Create a new bitmap with the dimensions specified above.
        'If the item's image size is larger than the specified icon image
        If itemImage.Size.Width > newItemIcon.Size.Width Then 'Resize the image by subtracting 1 to apply padding.
            itemImage = New Bitmap(itemImage, New Size(newItemIcon.Width - 1, newItemIcon.Width - 1))
        End If

        'Get centered position
        Dim locX As Integer = (_menuItemIcon.Width - itemImage.Width) / 2
        Dim locY As Integer = (_menuItemIcon.Height - itemImage.Height) / 2

        'Draw the resized and centered image on the created bitmap newItemIcon
        Using graphic As Graphics = Graphics.FromImage(newItemIcon)
            graphic.DrawImage(itemImage, locX, locY)
        End Using

        Return newItemIcon 'Return new icon of menu item.
    End Function
#End Region

#Region "-> Overridden methods"

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        ApplyAppearanceSettings()
    End Sub

    Public Overloads Sub Show(ownerControl As Control, position As DropdownMenuPosition)
        'This method helps to display and position the drop-down menu more easily.
        LoadItemAppearance() 'Apply Settings
        Dim x As Integer = 0
        Dim y As Integer = 0

        Select Case position
            Case DropdownMenuPosition.LeftTop
                x = 0 - Me.Width
                y = 0
            Case DropdownMenuPosition.LeftBottom
                x = 0
                y = ownerControl.Height
            Case DropdownMenuPosition.TopRight
                x = ownerControl.Width
                y = 0
            Case DropdownMenuPosition.BottomRight
                x = ownerControl.Width - Me.Width
                y = ownerControl.Height
        End Select

        Me.Show(ownerControl, x, y) 'Send values ​​to show dropdown menu.
    End Sub

    'Apply appearance settings on all show base methods.
    Public Overloads Sub Show()
        LoadItemAppearance()
        MyBase.Show()
    End Sub

    Public Overloads Sub Show(screenLocation As Point)
        LoadItemAppearance()
        MyBase.Show(screenLocation)
    End Sub

    Public Overloads Sub Show(x As Integer, y As Integer)
        LoadItemAppearance()
        MyBase.Show(x, y)
    End Sub

    Public Overloads Sub Show(position As Point, direction As ToolStripDropDownDirection)
        LoadItemAppearance()
        MyBase.Show(position, direction)
    End Sub

    Public Overloads Sub Show(ownerControl As Control, position As Point)
        LoadItemAppearance()
        MyBase.Show(ownerControl, position)
    End Sub

    Public Overloads Sub Show(ownerControl As Control, x As Integer, y As Integer)
        LoadItemAppearance()
        MyBase.Show(ownerControl, x, y)
    End Sub

    Public Overloads Sub Show(ownerControl As Control, position As Point, direction As ToolStripDropDownDirection)
        LoadItemAppearance()
        MyBase.Show(ownerControl, position, direction)
    End Sub
#End Region

End Class
