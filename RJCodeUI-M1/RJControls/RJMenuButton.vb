Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports FontAwesome.Sharp

Public Class RJMenuButton
    Inherits IconButton

    ''' <summary>
    ''' -----This class inherits from the <sIconButton/> class of the <FontAwesome.Sharp/> library
    '''      Autor: mkoertgen
    '''      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
    '''      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp
    '''      
    ''' This is a special control that is only designed to be used in the side menu of the main form.
    ''' This control can work as a normal menu button or as a drop-down menu button, for this you need 
    ''' to add a drop-down menu (<RJDropdownMenu/>) from the properties(<DropdownMenu/>)  
    ''' of this control and the click event will be created automatically to show the drop-down menu.
    ''' It has 2 essential appearance methods:
    ''' -> As a normal menu button; allows associating a form and the button is activated/highlighted 
    ''' until the form is closed (See Activate(RJChildForm) method)
    ''' -> As a drop-down menu button; allows associating many forms, the button and menu item is 
    ''' activated/highlighted until all forms are closed (See Activate(RJChildForm, ToolStripMenuItem) method)
    ''' These methods help the user to identify which forms are open, it works in a similar way as tabs.
    ''' </summary>
    '''

#Region "-> Fields"

    Private _textLeftPadding As String 'Sets a padding to the left before the text to keep considerable space between the icon and the text
    Private _tempText As String 'Set or get temporary text in case side menu collapses (text is empty)
    Private _isDropdownMenu As Boolean 'Sets or gets if the button is a dropdown menu
    Private _guestFormsCount As Integer 'Stores the number of associated forms that the menu button has (if the button is not a drop-down menu it will only have one associated form and if the button is a drop-down menu it will have 2 or more associated forms)
    Private _tempMenuItemTextColor As Color 'Sets or gets the color of the temporary text of the menu item in case it is enabled / highlighted
    Private _supernovaColor As Color = If(UIAppearance.Style = UIStyle.Supernova, RJColors.GetSupernovaColor(), Color.CornflowerBlue) 'Sets and gets supernova color if style is supernova
    Private _dropdownMenu As RJDropdownMenu 'Sets or gets dropdown menu
    Private _pbDropdownArrowIcon As IconPictureBox 'Sets and gets dropdown angle icon in case button shows dropdown
    Private Shared ReadOnly _deactivateItemsColor As Color = Color.FromArgb(255, 255, 255) 'Sets or gets icon and text color when menu button is disabled
    Private Shared ReadOnly _activateForeColor As Color = Color.FromArgb(206, 203, 226) 'Sets or gets the color of the text when the menu button is activated.
    Private Shared ReadOnly _activateBackColor As Color = Color.FromArgb(73, 101, 108) '(58, 50, 97) 'Sets or gets the background color when the menu button is activated and the dropdown is displayed
#End Region

#Region "-> Constructor"

    Public Sub New()
        _pbDropdownArrowIcon = New IconPictureBox()
        'Initialize properties and events
        Me.Dock = DockStyle.Top
        Me.BackColor = RJColors.SideMenuColor
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.MouseDownBackColor = RJColors.DarkItemBackground
        Me.FlatStyle = FlatStyle.Flat
        Me.Flip = FlipOrientation.Normal
        Me.Font = New Font("Verdana", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        Me.ForeColor = _deactivateItemsColor
        Me.IconChar = FontAwesome.Sharp.IconChar.DiceD6
        Me.IconColor = _deactivateItemsColor
        Me.IconSize = 28
        Me.Rotation = 0.0R
        Me.Size = New Size(220, 55)
        Me.TextAlign = ContentAlignment.MiddleLeft
        Me.ImageAlign = ContentAlignment.MiddleLeft
        Me.TextImageRelation = TextImageRelation.ImageBeforeText
        Me.Padding = New Padding(12, 0, 0, 0)
        AddHandler Me.SizeChanged, AddressOf WidthChanged
        AddHandler Me.HandleCreated, AddressOf MB_HandleCreated
        Cursor = Cursors.Hand
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)

            If value IsNot Nothing Then
                _textLeftPadding = "   " 'Set the number of blanks to apply a padding to the left before the text and after the icon.
                MyBase.Text = _textLeftPadding & value.Trim() 'Set padding and concatenate text by trimming leading and trailing empty characters
            End If
        End Set
    End Property

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

    'Create a new property to associate an RJDropdownMenu.
    <Category("RJ Code Advance")>
    <Description("Gets or sets the RJDropdownMenu associated with this control")>
    Public Property DropdownMenu As RJDropdownMenu
        Get
            Return _dropdownMenu 'Return RJDropdownMenu
        End Get
        Set(value As RJDropdownMenu)
            _dropdownMenu = value 'Set value

            If _dropdownMenu IsNot Nothing Then 'if the value is not null (it is an object), Set as dropdown button
                _isDropdownMenu = True 'Set menu button as drop down menu
                AddHandler _dropdownMenu.VisibleChanged, AddressOf DropdownMenu_VisibleChanged 'Subscribe the event RJDropdownMenu.VisibleChanged
                DrawDropdownArrowIcon(False) 'Draw a dropdown angle icon
                AddHandler Me.Click, AddressOf DropdownMenuButton_Click 'Subscribe Click event (show dropdown)
            Else 'if value is null (it is none), set as normal menu button
                _isDropdownMenu = False 'Set the menu button as NOT a dropdown menu
                Me.BackgroundImage = Nothing 'Remove dropdown icon.
            End If
        End Set
    End Property
#End Region

#Region "-> Public methods"

    Public Sub Activate(guestForm As RJChildForm)
        '-> Normal menu button
        'This method allows activating / highlighting the menu button from the outside, at the same time 
        'associating a guest form (the button will remain activated when the form is open or instantiated 
        'and once the form is closed the button will be deactivated) Use this method when you open a form 
        'directly from the menu button (the button is not a drop-down menu and it will only have an associated form).

        ActivateButton() 'Activate / highlight menu button
        AddHandler guestForm.FormClosed, AddressOf GuestForm_Closed 'Subscribe the closed event of the form, to deactivate the menu button.
        _guestFormsCount = 1 'set form associated to one, this is optional since by default it is 0, therefore once the form is closed the button will be deactivated.
    End Sub

    Public Sub Activate(guestForm As RJChildForm, menuItem As ToolStripMenuItem)
        '-> Drop-down menu button
        ' This method allows activating / highlighting the menu button and the sender menu item from the outside, 
        ' at the same time associating a guest form (the menu button will remain activated when the form is open or 
        ' instantiated and once the menu button has no associated forms, the button will be deactivated) , 
        ' Use this method when the button is a dropdown menu and you open a form from the menu item (the menu 
        ' button is a drop down menu and can have many associated forms).

        ActivateButton() 'Activate / highlight menu button
        ActivateMenuItem(guestForm, menuItem) 'Activate / highlight dropdown menu item
        If Me.Width > 100 Then 'if the width is greater than 100, that is, the side menu is expanded,
            DrawDropdownArrowIcon(False) 'Draw the collapsed arrow icon, ie the dropdown menu is not displayed.
        End If
        'Subscribe to closed event of form to deactivate menu item (pass additional parameter to event using delegate via lambda expressions)
        AddHandler guestForm.FormClosed, Sub(sender, e) GuestForm_Closed(sender, e, menuItem) 'More information: https://stackoverflow.com/a/34622752/12778930
        _guestFormsCount += 1 'Increase the counter of associated forms by one.
    End Sub
#End Region

#Region "-> Private methods"

    Private Sub ActivateButton()
        'Activate / highlight menu button
        If _guestFormsCount = 0 Then
            'If the button does not yet have an associated form (This condition to not reactivate the button
            ' when it already has an associated form, so the button has already been previously activated)

            Me.ForeColor = _activateForeColor 'set the menu button text color
            If UIAppearance.Style = UIStyle.Supernova Then
                Me.IconColor = _supernovaColor 'If the style is supernova, set the icon color to a supernova color.
            Else 'If it's any other theme, set the style color as the icon color.
                Me.IconColor = UIAppearance.StyleColor
            End If
        End If
    End Sub

    Private Sub DeactivateButton()
        'Disable the menu button as long as it does not have an associated form.
        If _guestFormsCount = 0 Then
            Me.IconColor = _deactivateItemsColor
            Me.ForeColor = _deactivateItemsColor
            If Me.Width > 100 AndAlso _isDropdownMenu Then 'if the width is greater than 100 (that is, the side menu is expanded) and the menu button is a drop down menu,
                DrawDropdownArrowIcon(False) 'Draw the collapsed arrow icon, ie the dropdown menu is not displayed.
            End If
        End If
    End Sub

    Private Sub ShowDropdownMenu()
        'Show button drop-down menu
        Try
            _dropdownMenu.OwnerIsMenuButton = True 'Tell the dropdown menu that its owner is a menu button.

            If Me.Width > 100 Then 'If the flyout is expanded, show the dropdown menu at the bottom right of the menu button.
                _dropdownMenu.Show(Me, DropdownMenuPosition.BottomRight)
            Else 'If the side menu is collapsed, show the drop-down menu at the top right of the menu button
                _dropdownMenu.Show(Me, DropdownMenuPosition.TopRight)
            End If

        Catch ex As Exception
            RJMessageBox.Show("An error has occurred" & vbLf & ex.Message)
        End Try
    End Sub

    Private Sub DrawDropdownArrowIcon(expandedMenu As Boolean)
        'This method draws the arrow icon of the drop down menu button

        Dim iconSize As Integer = 25 'Define a set icon size
        Dim iconColor As Color = Me.IconColor 'Define and set the icon color.
        Dim arrowIcon As Bitmap 'Define the bitmap for the arrow icon
        _pbDropdownArrowIcon.IconSize = iconSize 'Set icon size
        _pbDropdownArrowIcon.IconColor = iconColor 'Set icon color

        If expandedMenu Then 'If the parameter is an expanded menu, Set down arrow as the dropdown menu icon
            _pbDropdownArrowIcon.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Else 'If the parameter is not an expanded menu, set right arrow as the dropdown menu icon
            _pbDropdownArrowIcon.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        End If

        arrowIcon = New Bitmap(Me.Width, Me.Height) 'Initialize the bitmap to the same size as the menu button

        Using drawIcon As Graphics = Graphics.FromImage(arrowIcon) 'Create a graphic object from the bitmap
            Dim point As Point = New Point((Me.Width - iconSize) - 15, ((Me.Height - iconSize) / 2) + 3) 'Set the location of the arrow icon (docked to the right and center)
            Dim rectangle = New Rectangle(point, New Size(iconSize, iconSize)) 'Create a rectangle with the specified location and size equal to the icon size
            drawIcon.SmoothingMode = SmoothingMode.AntiAlias ' Set the smoothing mode
            drawIcon.DrawImage(_pbDropdownArrowIcon.Image, rectangle) 'Draw the arrow icon at the specified location in the bitmap
            Me.BackgroundImage = arrowIcon 'Set arrow icon as button menu background
        End Using
    End Sub

    Private Sub ActivateMenuItem(guestForm As RJChildForm, menuItem As ToolStripMenuItem)
        'Activate / highlight MenuItem

        Dim iconColor As Color 'Define the icon color
        _tempMenuItemTextColor = menuItem.ForeColor 'Save the text color of the menu item.
        menuItem.ForeColor = _activateForeColor 'Set the active text color.
        _dropdownMenu.ActiveMenuItem = True 'Tell the dropdown that it has an active item.
        'Set menu item icon color
        If UIAppearance.Style = UIStyle.Supernova Then
            iconColor = RJColors.GetSupernovaColor()
        Else
            iconColor = UIAppearance.StyleColor
        End If

        'If the configuration is configured to show the form icon in the active menu item
        If UIAppearance.FormIconActiveMenuItem Then
            'Get and set the form icon in the menu item.
            Dim formIcon As Bitmap = guestForm.FormIcon.ToBitmap(iconColor, 25)
            menuItem.Image = formIcon
        Else 'Otherwise set a simple shape (Circular point) as the icon of the menu item.
            Dim iconShape As Bitmap = New Bitmap(14, 14) 'Create a bitmap object with a size of 14.

            Using graphics As Graphics = graphics.FromImage(iconShape) 'Create a graphics object from the bitmap.
                graphics.SmoothingMode = SmoothingMode.AntiAlias ' Set the smoothing mode.

                Using brush As Brush = New SolidBrush(iconColor)
                    graphics.FillEllipse(brush, 0, 0, 13, 13) 'Draw a circle.
                End Using
            End Using

            menuItem.Image = iconShape 'Set the bitmap as the icon of the active menu item.
        End If
    End Sub

    Private Sub DeactivateMenuItem(menuItem As ToolStripMenuItem)
        'Deactivate the menu item.
        If menuItem IsNot Nothing Then
            menuItem.Image = Nothing 'Remove icon
            menuItem.ForeColor = _tempMenuItemTextColor 'Restore the text color
            If _guestFormsCount = 0 Then 'if the dropdown button no longer has associated forms,
                _dropdownMenu.ActiveMenuItem = False 'indicate to the dropdown menu that it no longer has an active menu.
            End If
        End If
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub MB_HandleCreated(sender As Object, e As EventArgs)
        'Run this code snippet when not in design mode.
        If Not Me.DesignMode Then _tempText = Me.Text 'Save Menu Button text
    End Sub

    Private Sub WidthChanged(sender As Object, e As EventArgs)
        'This event will happen when the side menu is collapsed or expanded (the button has the dock property at the top (Dock = Top), don't change it)
        If Not Me.DesignMode Then 'Run this when not in design mode

            If Me.Size.Width < 100 Then 'If side menu is collapsed
                Me.Text = "" 'Set empty text
                If _isDropdownMenu Then Me.BackgroundImage = Nothing 'If the button is from the dropdown menu, remove the arrow icon
            Else 'If the side menu expands
                Me.Text = _tempText 'Reset menu button text.
                If _isDropdownMenu Then DrawDropdownArrowIcon(False) 'If the button is a dropdown menu, draw the collapsed arrow icon.
            End If
        End If
    End Sub

    Private Sub GuestForm_Closed(sender As Object, e As FormClosedEventArgs)
        'This event is executed when the form is closed,
        'See predecessor method <see cref = "Activate (RJChildForm guestForm)" />
        _guestFormsCount = 0 'Set associated form to 0
        DeactivateButton() 'Deactivate menu button
    End Sub

    Private Sub GuestForm_Closed(sender As Object, e As FormClosedEventArgs, menuItem As ToolStripMenuItem)
        'This event is executed when the form is closed,
        'See predecessor method <see cref = "Activate (RJChildForm guestForm, ToolStripMenuItem menuItem))" />
        _guestFormsCount -= 1 'When the form is closed, decrease the counter of associated forms by one.
        DeactivateButton() 'Deactivate menu button
        DeactivateMenuItem(menuItem) 'Deactivate the dropdown menu item.
    End Sub

    Private Sub DropdownMenuButton_Click(sender As Object, e As EventArgs)
        ShowDropdownMenu() 'Show dropdown menu
    End Sub

    Private Sub DropdownMenu_VisibleChanged(sender As Object, e As EventArgs)
        'This event occurs when the dropdown menu is shown or hidden
        If Not DesignMode Then 'Run this when not in design mode.

            If _dropdownMenu.Visible Then 'If dropdown menu was displayed
                ActivateButton() 'Activate menu button
                Me.BackColor = _activateBackColor 'Set active background color
                If Me.Width > 100 Then 'if the width is greater than 100, that is, the side menu is expanded,
                    DrawDropdownArrowIcon(True) 'Draw expanded arrow icon
                End If

            Else 'If drop-down menu has been hidden (Close)
                DeactivateButton() 'Deactivate menu button (Also takes care of drawing the arrow icon when the button has no associated forms)
                Me.BackColor = RJColors.SideMenuColor 'Restore background color
                If Me.Width > 100 AndAlso _guestFormsCount <> 0 Then 'This condition is to draw the arrow icon when the button has associated forms
                    DrawDropdownArrowIcon(False) 'Draw the collapsed arrow icon.
                End If

            End If
        End If
    End Sub
#End Region

End Class

