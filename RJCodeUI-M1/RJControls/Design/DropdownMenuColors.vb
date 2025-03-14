Class DropdownMenuColors
    Inherits ProfessionalColorTable

    '' <summary>
    '' This class inherits from the <ProfessionalColorTable/> Class that provides colors used for Microsoft Office display elements.
    '' Also note that the <ToolStripProfessionalRenderer/> class calls an instance of this class
    '' in this case the derived class <DropdownMenuRenderer/> that inherits this class
    '' </summary>

    'Campos
    Private menuItemColor As MenuItemColors

    'Constructor
    Public Sub New(ByVal menuItemColors As MenuItemColors)
        Me.menuItemColor = menuItemColors
    End Sub

#Region "-> Overridden methods"
    '-> Override main layout color methods from dropdown menu and return new color properties:

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        'Gets the background color of the dropdown menu (ToolStripDropDown).
        Get
            Return menuItemColor.DropdownMenuBackground
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder As Color
        'Gets the border color of the dropdown menu (MenuStrip).
        Get
            Return menuItemColor.DropdownMenuBorder
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder As Color
        'Gets the border color of the menu item (ToolStripMenuItem).
        Get
            Return menuItemColor.MenuItemBorder
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected As Color
        'Gets the background color of the menu item (ToolStripMenuItem) when selected.
        Get
            Return menuItemColor.MenuItemSelected
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        'Gets the initial color of the gradient used in the image margin of a ToolStripDropDown.
        Get
            Return menuItemColor.LeftColumnGradientBegin
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        'Gets the average color of the gradient used in the image margin of a ToolStripDropDown.
        Get
            Return menuItemColor.LeftColumnGradientMiddle
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        'Gets the final color of the gradient used in the image margin of a ToolStripDropDown.
        Get
            Return menuItemColor.LeftColumnGradientEnd
        End Get
    End Property
#End Region

End Class

Public Class MenuItemColors
    Public Property DropdownMenuBackground As Color 'Gets or Sets the background color of the dropdown menu.
    Public Property DropdownMenuBorder As Color 'Gets or Sets the color of the dropdown menu border.
    Public Property LeftColumnGradientBegin As Color 'Gets or Sets the start color of the left column of the drop-down menu.
    Public Property LeftColumnGradientMiddle As Color 'Gets or Sets the middle color of the left column of the dropdown menu.
    Public Property LeftColumnGradientEnd As Color 'Gets or Sets the ending color of the left column of the drop-down menu.
    Public Property MenuItemSelected As Color 'Gets or Sets the background color of the selected menu item or when the mouse is hovering over it.
    Public Property MenuItemBorder As Color 'Gets or Sets the border color of the menu item.
    Public Property MenuItemArrow As Color 'Gets or Sets the color of the arrow icon of a menu or submenu that has sub-items.
    Public Property TextColor As Color 'Gets or Sets the color of the text

    Public Sub New()
        'Default values
        DropdownMenuBackground = System.Drawing.Color.FromArgb(250, 252, 253)
        DropdownMenuBorder = System.Drawing.Color.FromArgb(216, 220, 224)
        LeftColumnGradientBegin = System.Drawing.Color.FromArgb(240, 241, 242)
        LeftColumnGradientEnd = System.Drawing.Color.FromArgb(240, 241, 242)
        LeftColumnGradientMiddle = System.Drawing.Color.FromArgb(240, 241, 242)
        MenuItemBorder = System.Drawing.Color.FromArgb(231, 238, 246)
        MenuItemSelected = System.Drawing.Color.FromArgb(231, 238, 246)
        MenuItemArrow = Color.RoyalBlue
        TextColor = Color.FromArgb(64, 64, 64)
    End Sub
End Class
