Imports System.Drawing.Drawing2D
Imports FontAwesome.Sharp

Class DropdownMenuRenderer
    Inherits ToolStripProfessionalRenderer

    '''' <summary>
    '''' this class inherits the <ToolStripProfessionalRenderer/> class that provides
    '''' the painting functionality for <ToolStrip/> objects, applying a custom palette and a 
    '''' streamlined style based on a replaceable color table called <ProfessionalColorTable/>.
    '''' Remember that the ToolStripProfessionalRenderer class calls an instance of the <ProfessionalColorTable/>  class,
    '''' In this case the <DropdownMenuColors/> class the inherits ProfessionalColorTable class.
    '''' 
    '''' The <menuButton/> parameter simply sets if the dropdown menu is displayed from the menu button of the main form
    '''' </summary>
    ''''  

    'Fields

    Private dropdownItemIcon As Bitmap 'Sets the icon for a dropdown menu item.
    Private itemArrowIconColor As Color '/ Sets the color of the arrow icon.

    'Constructor
    'Send the menu item colors and send an instance of the custom DropdownMenuColors class (<"ProfessionalColorTable" />) to the base class <ToolStripProfessionalRenderer />.
    Public Sub New(ByVal menuItemColors As MenuItemColors)
        MyBase.New(New DropdownMenuColors(menuItemColors))
        itemArrowIconColor = menuItemColors.MenuItemArrow
    End Sub

    'Overrides
    'Override the OnRenderArrow event to draw the custom icon for a drop-down menu item.
    Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
        dropdownItemIcon = FontAwesome.Sharp.IconChar.AngleRight.ToBitmap(itemArrowIconColor, 25) 'Set the icon for dropdown menu items.
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias ' Set the smoothing mode
        Dim point As Point = New Point(e.ArrowRectangle.Location.X - 10, e.Item.Height / 2 - 7) 'Set icon location to draw
        Dim rectangle = New Rectangle(point, New Size(25, 25)) 'Create a rectangle object.
        e.Graphics.DrawImage(dropdownItemIcon, rectangle) 'Draw the icon in the dropdown item.
    End Sub

End Class
