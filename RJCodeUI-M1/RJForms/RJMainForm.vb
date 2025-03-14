Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports FontAwesome.Sharp

Public Class RJMainForm
    Inherits RJBaseForm

    ''' This class inherits from the <RJBaseForm/> class
    '''  
    ''' <summary>
    ''' In this class, a borderless window is set and add a custom title bar, 
    ''' a side menu and a client area using panels, you set a method to 
    ''' open the child forms within the area of the client (desktop), in addition
    ''' to adding screenshot functions, printing and moving the child form to a new window. 
    ''' As well as add the buttons to maximize, minimize, close and the Dropdown Menu for the
    ''' list of options in the form.
    ''' </summary>

#Region "-> Fields"

    Private components As IContainer = Nothing 'Container for non-child components of the form.
    'Allows all added components to be disposed with the Dispose method by the component container.
    '<see cref = "protected override void Dispose (bool disposing)" />
    Private activeChildForm As RJChildForm 'Sets or gets the currently active child form in the desktop pane
    Private listChildForms As List(Of RJChildForm) 'Stores child forms that have been opened and are active in the background (forms are hidden)
    Private deactivateFormEvent As Boolean
    'Controls
    Private lblCaption As RJLabel 'Form Title
    Private pnlSide As Panel 'Side Panel
    Private pnlMarker As Panel 'Current child form marker, places a marker on the menu button to indicate which is the current / active form on the application desktop
    Private biSideMenuButton As RJMenuIcon 'Side menu button
    Private biFormIcon As RJMenuIcon 'Form Icon Button
    Private btnMoveNewWindow As IconButton 'Move the child form to a new window
    Private btnScreenshot As IconButton 'Form screenshot
    Private btnPrint As IconButton 'print child form
    Private btnHelp As IconButton 'Child Form Help
    Private dragControl As RJDragControl 'Form drag control, (it's component, the constructor accepts a parameter of type IContainer)
    Private miCloseChildForms As IconMenuItem 'menu item Close all child forms
    Private toolTip As ToolTip 'Shows a short description of a control (it is a component, the constructor accepts a parameter of type IContainer)

    Friend dmFormOptions As RJDropdownMenu 'Drop-down menu of the form options (it is component, the constructor accepts a parameter of type IContainer)
    Protected pnlSideMenu As Panel 'Side Menu
    Protected pnlSideMenuHeader As Panel 'Side menu header
    Protected pnlTitleBar As Panel 'Title Bar
    Protected pnlDesktop As Panel '' Application Desktop (Client Area: Child Form Container) This panel will only store and display a child form. The other disabled child forms are stored in the generic list of forms.
    Protected pnlDesktopHeader As Panel 'desktop header

    '''<Note>: ICON MENU ITEM and ICON BUTTON is provided by the <FontAwesome.Sharp/> library.
    '''        Author: mkoertgen
    '''        GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
    '''        Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp </Note>
#End Region

#Region "-> Constructor"

    Public Sub New()
        RJColors.colorIndex = 0 'Reset the superonva color index
        listChildForms = New List(Of RJChildForm)() 'Initialize generic list
        InitializeItems()

    End Sub

    Private Sub InitializeItems()
        'Initialize the components (instantiation of objects) for the form design:
        'add title bar, side menu, buttons for form options, maximize, minimize, user options drop-down menu
        'and the client area (Desktop) of the form.

        components = New System.ComponentModel.Container() 'initialize container

        '-> Instantiation of controls
        pnlSideMenu = New Panel()
        pnlSideMenuHeader = New Panel()
        pnlTitleBar = New Panel()
        pnlDesktop = New Panel()
        pnlDesktopHeader = New Panel()
        pnlMarker = New Panel()
        pnlSide = New Panel()
        btnMoveNewWindow = New FontAwesome.Sharp.IconButton()
        btnScreenshot = New FontAwesome.Sharp.IconButton()
        btnPrint = New FontAwesome.Sharp.IconButton()
        btnHelp = New FontAwesome.Sharp.IconButton()
        biSideMenuButton = New RJMenuIcon()
        biFormIcon = New RJMenuIcon()
        lblCaption = New RJLabel()
        dmFormOptions = New RJDropdownMenu(components) 'Add to component container
        miCloseChildForms = New FontAwesome.Sharp.IconMenuItem()
        toolTip = New ToolTip(components) 'Add to component container
        dragControl = New RJDragControl(pnlTitleBar, Me, components) 'Drag Control, Add to Component Container

        '-> Side menu of the form

        '- Panel: Side panel of the form
        pnlSide.Name = "pnlSide"
        pnlSide.Dock = DockStyle.Left
        pnlSide.Location = New Point(0, 0)
        pnlSide.Size = New Size(220, 610)
        pnlSide.Controls.Add(pnlSideMenu) 'Add controls
        pnlSide.Controls.Add(pnlSideMenuHeader)

        '- Panel: Side menu
        pnlSideMenu.Name = "pnlSideMenu"
        pnlSideMenu.Padding = New Padding(0, 65, 0, 0)
        pnlSideMenu.BackColor = RJColors.SideMenuColor
        pnlSideMenu.Dock = DockStyle.Fill
        pnlSideMenu.Location = New Point(0, 60)
        pnlSideMenu.Size = New Size(220, 550)
        pnlSideMenu.Controls.Add(pnlMarker) '' Add controls

        '- Panel: Side Menu Header
        pnlSideMenuHeader.Name = "pnlSideMenuHeader"
        pnlSideMenuHeader.Controls.Add(biSideMenuButton) 'Add control
        pnlSideMenuHeader.Size = New Size(220, 60)
        pnlSideMenuHeader.Dock = DockStyle.Top
        pnlSideMenuHeader.Location = New Point(0, 0)

        '- RJ BarIcon: Side menu button
        biSideMenuButton.Name = "biSideMenuButton"
        biSideMenuButton.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
        biSideMenuButton.Customizable = True
        biSideMenuButton.IconColor = Color.White
        biSideMenuButton.BackColor = Color.Transparent
        biSideMenuButton.Cursor = Cursors.Hand
        biSideMenuButton.IconChar = FontAwesome.Sharp.IconChar.Bars
        biSideMenuButton.IconSize = 25
        biSideMenuButton.Location = New Point(175, 20)
        biSideMenuButton.Size = New System.Drawing.Size(25, 25)
        AddHandler biSideMenuButton.Click, AddressOf SideMenuButton_Click 'Subscribe event.

        '- Panel: Secondary Form Marker
        pnlMarker.Name = "pnlChildFormMarker"
        pnlMarker.Size = New Size(4, 55)
        pnlMarker.Location = New Point(0, 60)
        pnlMarker.Visible = False

        '-> Form title bar

        '- Panel: Title bar
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.BackColor = UIAppearance.StyleColor
        pnlTitleBar.Size = New Size(960, 60)
        pnlTitleBar.Location = New Point(220, 0)
        pnlTitleBar.Dock = DockStyle.Top
        pnlTitleBar.Controls.Add(lblCaption) 'Add controls
        pnlTitleBar.Controls.Add(biFormIcon)
        pnlTitleBar.Controls.Add(Me.btnMinimize)
        pnlTitleBar.Controls.Add(Me.btnMaximize)
        pnlTitleBar.Controls.Add(Me.btnClose)

        '- Label: Form title
        lblCaption.Name = "lblCaption"
        lblCaption.AutoSize = True
        lblCaption.Style = LabelStyle.BarCaption
        lblCaption.Location = New Point(46, 20)
        lblCaption.TextAlign = ContentAlignment.MiddleLeft
        lblCaption.Text = "Home"

        '- Button: Control box buttons
        Me.btnClose.Size = New Size(35, 20)
        Me.btnClose.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
        Me.btnMaximize.Size = New Size(35, 20)
        Me.btnMaximize.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
        Me.btnMinimize.Size = New Size(35, 20)
        Me.btnMinimize.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)

        '- Bar Icon: Active form icon
        biFormIcon.Name = "biFormIcon"
        biFormIcon.BackColor = Color.Transparent
        biFormIcon.Cursor = Cursors.Hand
        biFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home
        biFormIcon.IconSize = 25
        biFormIcon.Location = New Point(19, 20)
        biFormIcon.Size = New Size(25, 25)
        biFormIcon.SizeMode = PictureBoxSizeMode.AutoSize
        AddHandler biFormIcon.Click, AddressOf Me.FormIcon_Click
        AddHandler biFormIcon.MouseEnter, AddressOf FormIcon_MouseHover
        AddHandler biFormIcon.MouseLeave, AddressOf FormIcon_MouseLeave

        '-> -Form options
        '- Icon MenuItem: Close child forms (FontAwesome.Sharp library)
        miCloseChildForms.Name = "miCloseChildForms"
        miCloseChildForms.Text = "Close child forms"
        miCloseChildForms.IconSize = 24
        miCloseChildForms.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes
        miCloseChildForms.IconColor = RJColors.FantasyColorScheme4
        AddHandler miCloseChildForms.Click, AddressOf CloseAllChildForms_Click

        '- DropdownMenu: Form Options -------------
        dmFormOptions.Name = "dmFormOptions"
        dmFormOptions.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        dmFormOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {miSnapLeft, miSnapRight, miExitSnap, miCloseChildForms})
        dmFormOptions.OwnerIsMenuButton = False

        '-> Desktop header (child form options)

        '- Panel: Desktop Header -------------
        pnlDesktopHeader.Name = "pnlDesktopHeader"
        pnlDesktopHeader.BackColor = RJColors.LightBackground
        pnlDesktopHeader.Dock = DockStyle.Top
        pnlDesktopHeader.Location = New Point(220, 60)
        pnlDesktopHeader.Size = New Size(960, 25)
        pnlDesktopHeader.Padding = New Padding(14, 0, 0, 0)
        pnlDesktopHeader.Controls.Add(btnHelp) 'Add controls
        pnlDesktopHeader.Controls.Add(btnMoveNewWindow)
        pnlDesktopHeader.Controls.Add(btnScreenshot)
        pnlDesktopHeader.Controls.Add(btnPrint)

        '- Icon Button: Print form (FontAwesome.Sharp library control)
        btnPrint.Dock = DockStyle.Left
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.IconSize = 20
        btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        btnPrint.IconColor = RJColors.FantasyColorScheme1
        btnPrint.Location = New Point(0, 0)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(35, 25)
        btnPrint.UseVisualStyleBackColor = True
        btnPrint.Cursor = Cursors.Hand
        btnPrint.Visible = False
        AddHandler btnPrint.Click, AddressOf Print_Click

        '- Icon Button: Captura de pantalla (Control de la librería FontAwesome.Sharp)
        btnScreenshot.Dock = DockStyle.Left
        btnScreenshot.FlatAppearance.BorderSize = 0
        btnScreenshot.FlatStyle = FlatStyle.Flat
        btnScreenshot.IconSize = 20
        btnScreenshot.IconChar = FontAwesome.Sharp.IconChar.Camera
        btnScreenshot.IconColor = RJColors.FantasyColorScheme2
        btnScreenshot.Location = New Point(0, 0)
        btnScreenshot.Name = "btnScreenShoot"
        btnScreenshot.Size = New Size(35, 25)
        btnScreenshot.UseVisualStyleBackColor = True
        btnScreenshot.Cursor = Cursors.Hand
        btnScreenshot.Visible = False
        AddHandler btnScreenshot.Click, AddressOf Screenshot_Click

        '- Icon Button: Move child form to new window (FontAwesome.Sharp library control)
        btnMoveNewWindow.Name = "btnOpenNewWindow"
        btnMoveNewWindow.Dock = DockStyle.Left
        btnMoveNewWindow.FlatAppearance.BorderSize = 0
        btnMoveNewWindow.FlatStyle = FlatStyle.Flat
        btnMoveNewWindow.IconSize = 20
        btnMoveNewWindow.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        btnMoveNewWindow.IconColor = RJColors.FantasyColorScheme3
        btnMoveNewWindow.Location = New Point(15, 0)
        btnMoveNewWindow.Size = New Size(35, 25)
        btnMoveNewWindow.UseVisualStyleBackColor = True
        btnMoveNewWindow.Cursor = Cursors.Hand
        btnMoveNewWindow.Visible = False
        AddHandler btnMoveNewWindow.Click, AddressOf MoveNewWindow_Click

        '- Icon Button: User help (FontAwesome.Sharp library control)
        btnHelp.Dock = DockStyle.Left
        btnHelp.FlatAppearance.BorderSize = 0
        btnHelp.FlatStyle = FlatStyle.Flat
        btnHelp.IconSize = 20
        btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        btnHelp.IconColor = RJColors.FantasyColorScheme4
        btnHelp.Location = New Point(0, 0)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(35, 25)
        btnHelp.UseVisualStyleBackColor = True
        btnHelp.Cursor = Cursors.Hand
        btnHelp.Visible = False
        AddHandler btnHelp.Click, AddressOf ChilFormHelp_Click

        '-> Desktop (Client area - Secondary form container)
        '- Panel: Desktop
        pnlDesktop.Name = "pnlDesktop"
        pnlDesktop.BackColor = RJColors.LightBackground
        pnlDesktop.Dock = DockStyle.Fill
        pnlDesktop.Location = New Point(220, 85)
        pnlDesktop.Size = New Size(960, 525)

        '-> Others
        toolTip.AutoPopDelay = 5000
        toolTip.InitialDelay = 1000
        toolTip.ReshowDelay = 500
        toolTip.ShowAlways = True
        toolTip.BackColor = Color.FromArgb(236, 82, 99)
        toolTip.ForeColor = Color.White
        toolTip.OwnerDraw = True
        AddHandler toolTip.Draw, AddressOf ToolTip_Draw
        toolTip.SetToolTip(btnPrint, "Print form content")
        toolTip.SetToolTip(btnScreenshot, "Take screenshot")
        toolTip.SetToolTip(btnMoveNewWindow, "Move form to new window")
        toolTip.SetToolTip(btnHelp, "Help message")

        '-> RJ Main Form Properties
        deactivateFormEvent = True
        Me.Resizable = True
        Me.PrimaryForm = True
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.None
        Me.FormBorderStyle = FormBorderStyle.None 'Borderless form
        Me.MinimumSize = New Size(650, 400) 'Minimum form size
        Me.Controls.Add(pnlDesktop) 'Add controls
        Me.Controls.Add(pnlDesktopHeader)
        Me.Controls.Add(pnlTitleBar)
        Me.Controls.Add(pnlSide)
        AddHandler Me.Load, AddressOf MainForm_Load
        AddHandler Me.Activated, AddressOf MainForm_Activated 'Subscribe to the Activated event to retrieve the title bar color.
        AddHandler Me.Deactivate, AddressOf MainForm_Deactivate 'subscribe to Deactivated event to change / opaque title bar color
    End Sub
#End Region

#Region "-> Properties"

    Public Overloads Property ClientSize As Size
        'Hide client size for default size to take effect on derived forms
        Get
            Return MyBase.ClientSize
        End Get
        Set(value As Size)
        End Set
    End Property

    Protected Overrides ReadOnly Property DefaultSize As Size
        'Default form size
        Get
            Return New Size(1180, 610)
        End Get
    End Property
#End Region

#Region "-> Protected methods"

    '-> Open secondary form

    Protected Sub OpenChildForm(Of childForm As RJChildForm)(_delegate As Func(Of childForm))
        'Generic method with a generic delegate parameter (Func <TResult>) where the data type is RJChildForm.
        'This method ALLOWS to open forms WITH or WITHOUT parameters within the desktop panel. On many occasions,
        'the youtube tutorials used methods similar to this. However, it simply allowed forms to be opened 
        'WITHOUT parameters ( e.g <see cref="new MyForm ()"/> )
        'and it was impossible to open a form WITH parameters( e.g. <see cref="new MyForm (user:"John", mail:"john@gmail.com"/> )
        'so this method solves this defect thanks to the generic delegate (Func <TResult>)   

        Dim form As RJChildForm = Application.OpenForms.OfType(Of childForm)().FirstOrDefault() 'Check if child form is already open

        '- >>>> Show child form as a new instance
        If form Is Nothing Then 'If there is no result, the form is not open, then create the instance and display it on the desktop panel
            deactivateFormEvent = False 'Do not deactivate form when child form is opened
            form = _delegate() 'Execute delegate
            form.IsChildForm = True 'Set form as child form
            form.TopLevel = False 'Indicate that the form is not top level
            form.Dock = DockStyle.Fill 'Set dock style to full (Fill desktop panel)
            form.MarkerPosition = 0 'Set the Marker Position to zero, because the form does not open from a menu button.

            CleanDesktop() 'Remove current child form from desktop panel
            If UIAppearance.MultiChildForms = False Then 'If the multiple child forms option is disabled, only allow to open a single form within the desktop panel, then definitively close the previous one.
                CloseActiveChildForm() 'Close current child form: This does not affect if the child form is open in a new window.
            End If

            listChildForms.Add(form) 'Add child form to list of forms
            pnlDesktop.Controls.Add(form) 'Add child form to desktop panel
            pnlDesktop.Tag = form 'Store the form
            form.Show() 'Show the form
            form.BringToFront() 'Bring to front
            form.Focus() 'Focus the form

            activeChildForm = form 'set FORM as active child form
            SetChildFormItems() 'Set the title, icon, and options of the child form in the design of the parent form
            deactivateFormEvent = True 'Reset value

            '- >>>> Redisplay existing form or child form
        Else 'If the form is already open, show the form again
            If form.IsChildForm AndAlso form IsNot activeChildForm Then 'if the form is a child form and the form is different from the active child form, add it back to the panel and set it as an active child form
                CleanDesktop() 'Remove current child form from desktop panel
                pnlDesktop.Controls.Add(form) 'add child form to desktop panel
                pnlDesktop.Tag = form 'Store the form
                activeChildForm = form 'set FORM as active child form
                SetChildFormItems() 'Set the title, icon, and options of the child form in the design of the parent form
            End If
            If form.WindowState = FormWindowState.Minimized Then 'If form is minimized, restore form.
                form.WindowState = FormWindowState.Normal
            End If
            form.Show() 'show the form on the desktop panel or outside in a new window if the form IS NOT A Child FORM
            form.BringToFront() 'Brings the form to the front
            form.Focus() 'Focus form
        End If

        'You can use the Func <TResult> delegate with anonymous methods or lambda expression,
        'for example, we can call this method as follows:
        'Me.OpenChildForm (Function () New MyForm (id))
    End Sub

    Protected Sub OpenChildForm(Of childForm As RJChildForm)(_delegate As Func(Of childForm), senderMenuButton As Object)
        'Generic method with a generic delegate parameter (Func <TResult>) and a menu button parameter where the data type is RJChildForm.

        If senderMenuButton Is Nothing OrElse senderMenuButton.[GetType]() <> GetType(RJMenuButton) Then 'Check if object is valid
            RJMessageBox.Show("Submit a valid object, null values ​​are not allowed")
            Return
        End If

        Dim menuButton As RJMenuButton = CType(senderMenuButton, RJMenuButton)
        Dim form As RJChildForm = Application.OpenForms.OfType(Of childForm)().FirstOrDefault() 'Check if child form is already open

        '- >>>> Show child form as a new instance
        If form Is Nothing Then 'If there is no result, the form is not open, then create the instance and display it on the desktop panel
            deactivateFormEvent = False 'Do not deactivate form when child form is opened
            form = _delegate() 'Execute delegate
            form.IsChildForm = True
            form.TopLevel = False 'Indicate that the form is not top level
            form.Dock = DockStyle.Fill
            form.MarkerPosition = menuButton.Location.Y 'Set the position of the marker

            CleanDesktop() 'remove current child form from desktop panel
            If UIAppearance.MultiChildForms = False Then
                CloseActiveChildForm() 'Close the current child form if the multiple child forms option is disabled: This does not affect if the child form is open in a new window.
            End If

            listChildForms.Add(form) 'add child form to list of forms
            pnlDesktop.Controls.Add(form) 'add child form to desktop panel
            pnlDesktop.Tag = form
            form.Show()
            form.BringToFront()
            form.Focus()

            activeChildForm = form 'set FORM as active child form
            SetChildFormItems() 'Set the title, icon, and options of the child form in the design of the parent form
            menuButton.Activate(form) 'Activate the menu button and associate the form so that the button remains highlighted when the form is instantiated.
            deactivateFormEvent = True 'Reset value

            '- >>>> Redisplay existing form or child form
        Else
            'if the form is a child form and the form is different from the active child form, add it back to the dashboard and set it as active child form
            If form.IsChildForm AndAlso form IsNot activeChildForm Then
                CleanDesktop() 'Remove current child form from desktop panel
                pnlDesktop.Controls.Add(form) 'add child form to desktop panel
                pnlDesktop.Tag = form
                activeChildForm = form 'set FORM as active child form
                SetChildFormItems() 'Set the title, icon, and options of the child form in the design of the parent form
            End If

            If form.WindowState = FormWindowState.Minimized Then
                form.WindowState = FormWindowState.Normal
            End If
            form.Show() 'display the form on the desktop panel or outside in a new window if the form IS NOT A child FORM
            form.BringToFront()
            form.Focus()
        End If
    End Sub

    Protected Sub OpenChildForm(Of childForm As RJChildForm)(_delegate As Func(Of childForm), senderMenuItem As Object, ownerMenuButton As RJMenuButton)
        'Generic method with Generic Delegate parameter (Func <TResult>), Menu button and menu item where the data type is RJChildForm.

        'validate parameters
        If ownerMenuButton Is Nothing OrElse senderMenuItem Is Nothing OrElse senderMenuItem.[GetType]() <> GetType(ToolStripMenuItem) Then
            RJMessageBox.Show("Submit a valid object, null values ​​are not allowed")
            Return
        End If

        Dim form As RJChildForm = Application.OpenForms.OfType(Of childForm)().FirstOrDefault() 'Check if child form is already open

        '- >>>> Show child form as a new instance
        If form Is Nothing Then
            deactivateFormEvent = False
            form = _delegate()
            form.IsChildForm = True
            form.TopLevel = False
            form.Dock = DockStyle.Fill
            form.MarkerPosition = ownerMenuButton.Location.Y 'Set the position of the marker
            CleanDesktop()
            If UIAppearance.MultiChildForms = False Then CloseActiveChildForm()
            listChildForms.Add(form)
            pnlDesktop.Controls.Add(form)
            pnlDesktop.Tag = form
            form.Show()
            form.BringToFront()
            form.Focus()
            activeChildForm = form
            SetChildFormItems()
            ownerMenuButton.Activate(form, CType(senderMenuItem, ToolStripMenuItem)) 'Activate the menu button and associate
            ' a form for the button to remain highlighted until all forms are closed.
            ' You can have many associated forms since the menu button shows a drop-down menu.
            ' Also activate the menu item and associate it to the form so that the menu item remains
            ' highlighted when the form is instantiated.
            deactivateFormEvent = True

            '- >>>> Redisplay existing form or secondary form
        Else

            If form.IsChildForm AndAlso form IsNot activeChildForm Then
                CleanDesktop()
                pnlDesktop.Controls.Add(form)
                pnlDesktop.Tag = form
                activeChildForm = form
                SetChildFormItems()
            End If

            If form.WindowState = FormWindowState.Minimized Then
                form.WindowState = FormWindowState.Normal
            End If
            form.Show()
            form.BringToFront()
            form.Focus()
        End If
    End Sub

#End Region

#Region "-> Private methods"

    '-> Load design properties

    Private Sub SetChildFormItems()
        'When a child form is displayed on the desktop, set the title, icon,
        'the marker and options of the child form in the design of the main form

        biFormIcon.IconChar = activeChildForm.FormIcon 'Set form icon
        lblCaption.Text = activeChildForm.Text 'Set form caption
        pnlDesktopHeader.BackColor = UIAppearance.ItemBackgroundColor 'Set desktop header background color
        'Show child form option buttons
        btnHelp.Visible = True
        btnMoveNewWindow.Visible = True
        btnScreenshot.Visible = True
        btnPrint.Visible = True

        ' Set Child form marker, as long as the ChildFormMarker field of UIAppearance is set to true
        ' and the MarkerPosition field of the active form has a value other than 0 (In this case, Zero 
        ' is equal to a position not being set for the marker because the form was not opened from 
        ' a menu button) see OpenChildForm(Of childForm As RJChildForm)(_delegate As Func(Of childForm)) method.
        If UIAppearance.ChildFormMarker = True AndAlso activeChildForm.MarkerPosition <> 0 Then
            pnlMarker.Location = New Point(0, activeChildForm.MarkerPosition)
            pnlMarker.Visible = True
        End If
    End Sub

    Private Sub ResetToDefaults()
        'Reset main form to defaults

        activeChildForm = Nothing 'Set current child form field to null
        lblCaption.Text = "Home"
        biFormIcon.IconChar = IconChar.Home
        pnlMarker.Visible = False 'Hide child form marker
        pnlDesktopHeader.BackColor = UIAppearance.BackgroundColor
        'Hide option buttons from child form
        btnPrint.Visible = False
        btnScreenshot.Visible = False
        btnMoveNewWindow.Visible = False
        btnHelp.Visible = False
    End Sub

    Private Sub UpdateFormLayout()
        'This method is responsible for updating the main form with the proper parameters,
        'either reset the default values ​​or show a previous child form if that's the case.

        Dim childForm = listChildForms.LastOrDefault() 'Check and get the last (old) child form in the form list
        '- If there is no result, there is no instance in the list of child forms.
        If childForm Is Nothing Then
            ResetToDefaults() 'Reset main form to defaults

        Else 'if there is an instantiated child form in the list, add it back to the desktop panel, set it as an active child form, and display it.
            activeChildForm = childForm 'Set form as current child form (old form)
            pnlDesktop.Controls.Add(childForm) 'Add to desktop panel
            pnlDesktop.Tag = childForm
            childForm.Show() 'Show child form
            childForm.BringToFront()
            SetChildFormItems() 'Set the title, icon, and options of the child form in the design of the parent form
        End If
    End Sub

    Private Sub CleanDesktop()
        '' Clean desktop panel
        If activeChildForm IsNot Nothing Then
            activeChildForm.Hide()
            pnlDesktop.Controls.Remove(activeChildForm)
        End If
        'This method hides and removes the active child form from the desktop panel, so there will only be
        ' one child form open within the desktop panel, since adding a new form removes the old form and adds 
        ' the new one (check the OpenChildForm method) Inactive child forms are stored in a generic list.
        ' 
        ' I created these methods to get rid of the doubts as many think (myself included) that having 20 or 
        ' 50 forms added within the desktop affects performance, well I didn't realize that. In fact, it is 
        ' possible to add 10 thousand controls dynamically in a displayed form and there is no limit if it is
        ' added from the form's constructor, for experimenting, I added 100 thousand labels and 10 thousand 
        ' panels with color although it took more than 10 minutes to show ( pc: 8 ram, SixCore 3.50 GHz cpu) 
        ' and there is no performance problem (consumed 20mb ram) and scrolling the form works fine.
        ' 
        ' Therefore, if these methods seem very tedious or difficult to understand, you can use the methods 
        ' of opening a child form within the Previous Projects panel (tutorials) that are shown on YouTube,
        ' where the secondary forms are stored within the desktop, they overlap one after the other and one 
        ' is displayed (form.bringtofront ();).
        ' 
        ' However, it still doesn't seem appropriate to me to add so many forms within a panel considering 
        ' that a default form is top-level and I don't like the idea of ​​having so many controls in a panel (child form controls).
        ' 
        ' As a result, I preferred to store the child forms in a generic list and add and display only a 
        ' single form on the desktop panel :)
    End Sub

    Private Sub ApplyAppearanceSettings()
        'Apply appearance settings
        pnlDesktop.BackColor = UIAppearance.BackgroundColor 'Set background color
        pnlDesktopHeader.BackColor = UIAppearance.BackgroundColor 'Set the background color of the desktop header
        Me.BorderColor = UIAppearance.FormBorderColor 'Set the border color
        Me.BorderSize = UIAppearance.FormBorderSize 'Set the width of the form border

        If UIAppearance.Style = UIStyle.Supernova Then 'If the style is supernova
            pnlTitleBar.BackColor = ColorEditor.Darken(UIAppearance.BackgroundColor, 7) 'Set background color of title bar
            pnlSideMenuHeader.BackColor = RJColors.SideMenuColor 'Set side menu header background color
            pnlMarker.BackColor = Color.CornflowerBlue 'Set the marker color

        Else 'Any style that isn't supernova
            pnlTitleBar.BackColor = UIAppearance.PrimaryStyleColor 'Set title bar background color
            pnlSideMenuHeader.BackColor = ColorEditor.Darken(UIAppearance.PrimaryStyleColor, 6) 'Set flyout header background color
            pnlMarker.BackColor = UIAppearance.StyleColor 'Set the marker color
        End If
    End Sub

    '-> Child form options

    Private Sub MoveFormNewWindow()
        'Move the active child form to a new window
        If activeChildForm IsNot Nothing Then
            listChildForms.Remove(activeChildForm) 'Remove the current child form from the list of forms.
            pnlDesktop.Controls.Remove(activeChildForm) 'Remove the current child form from the desktop panel.
            activeChildForm.IsChildForm = False 'Set the form as a normal form (has a title bar and resizes)
            activeChildForm.TopLevel = True 'Set the form as top level
            activeChildForm.Dock = DockStyle.None
            UpdateFormLayout() 'Update main form.
        End If
    End Sub

    Private Sub CloseActiveChildForm()
        'Close active child form
        If activeChildForm IsNot Nothing Then
            listChildForms.Remove(activeChildForm) 'Remove the current child form from the list of forms.
            pnlDesktop.Controls.Remove(activeChildForm) 'Remove the current child form from the desktop panel.
            activeChildForm.Close() 'Close current child form.
        End If
    End Sub

    Private Sub CloseAllChildForm()
        'Close all child forms
        Dim childForms = Application.OpenForms.OfType(Of RJChildForm)().FirstOrDefault() 'Check if a child form is open.

        'If there is any form open, close all forms except this form (Me)
        If childForms IsNot Nothing Then 'and the application startup form (0) (for example, login form, or any other set in the program class)
            Application.OpenForms.Cast(Of Form)().Except(New Form() {Me, Application.OpenForms(0)}).ToList().ForEach(Sub(x) x.Close())
            listChildForms.Clear() 'Empty all elements of the form list.
            pnlMarker.Visible = False
            ResetToDefaults()

            'If no forms are open, show message
        Else
            RJMessageBox.Show("There is no child form open", "Message")
        End If
    End Sub

    Private Sub Screenshot()
        'Take screenshot of the form

        Dim initialDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) 'Default save directory (images)
        Dim saveScreenshot = New SaveFileDialog() 'Instantiate SaveFileDialog object
        'Filter image files
        saveScreenshot.Filter = "PNG Image | * .png | JPG Image | * .jpg | BMP IMAGE | * .bmp" & "| Image Files | * .png; *. jpg; *. BMP; *. gif" & " | All Files | *. * "
        saveScreenshot.DefaultExt = "png" 'Set default extension.
        saveScreenshot.AddExtension = True
        saveScreenshot.FileName = "RJCode #" & Path.GetRandomFileName() 'Suggest a random name.
        saveScreenshot.InitialDirectory = initialDirectory 'Specify the default / initial directory.

        'Take the screenshot from the upper left corner to the lower right corner
        Dim bmpScreenshot As Bitmap = New Bitmap(Me.Size.Width, Me.Size.Height, PixelFormat.Format32bppArgb) 'Set bitmap object to main form size
        Dim graphic As Graphics = Graphics.FromImage(bmpScreenshot) 'Create graphic object from bitmap
        graphic.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size) 'Take the screenshot only the region of the main form (Me.size)

        If saveScreenshot.ShowDialog() = DialogResult.OK Then 'If the user clicks the Save button.
            bmpScreenshot.Save(saveScreenshot.FileName) 'Save the screenshot to the path and filename chosen by the user.
            Process.Start(saveScreenshot.FileName) 'Show the screenshot in the default image viewer application of the operating system.
        End If
    End Sub

    Private Sub PrintCurrentChildForm()
        'Print current child form

        '' Screenshot of the desktop panel
        Dim bmpScreenshot As Bitmap = New Bitmap(pnlDesktop.Width, pnlDesktop.Height, PixelFormat.Format32bppArgb) 'Set the bitmap object to the size of the desktop panel.
        Dim screenPoint = Me.PointToScreen(pnlDesktop.Location) 'Calculates the location of the screen point in the coordinates of the desktop panel.
        Dim graphic As Graphics = Graphics.FromImage(bmpScreenshot) 'Creates a graphic object from the bitmap.
        graphic.CopyFromScreen(screenPoint.X, screenPoint.Y, 0, 0, pnlDesktop.Size) 'Take screenshot only desktop panel region.

        Dim printForm = New RJPrintForm(bmpScreenshot, activeChildForm.Caption) 'Open the print form and submit the screenshot and the form title.
        printForm.ShowDialog() 'Show as modal window.
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub MainForm_Load(sender As Object, e As EventArgs)
        ApplyAppearanceSettings()
        pnlMarker.BringToFront() 'Set markup to foreground
        '' Set the Location of the control box buttons
        btnClose.Location = New Point(Me.pnlTitleBar.Width - btnClose.Width, 0)
        btnMaximize.Location = New Point(btnClose.Location.X - btnMaximize.Width, 0)
        btnMinimize.Location = New Point(btnMaximize.Location.X - btnMinimize.Width, 0)
    End Sub

    Private Sub MainForm_Deactivate(sender As Object, e As EventArgs)
        'When the form goes into deactivated mode (loses focus), the color of the title bar changes.
        If deactivateFormEvent = True Then
            Me.BorderColor = RJColors.DefaultFormBorderColor 'Set the border color

            If UIAppearance.Style <> UIStyle.Supernova Then 'If style is not supernova, change title bar color
                pnlTitleBar.BackColor = UIAppearance.DeactiveFormColor 'Set background color of title bar.
                pnlSideMenuHeader.BackColor = ColorEditor.Darken(UIAppearance.DeactiveFormColor, 6) 'Set the background color of the flyout header.
                pnlTitleBar.Update() 'Force the title bar to be drawn to avoid flickering when the background color is changed.
            End If
        End If
    End Sub

    Private Sub MainForm_Activated(sender As Object, e As EventArgs)
        'When the form goes into activated mode (recovers focus, redisplay the form),
        'Set the title bar back to normal color.

        Me.BorderColor = UIAppearance.FormBorderColor 'Set the border color

        If UIAppearance.Style <> UIStyle.Supernova Then
            pnlTitleBar.BackColor = UIAppearance.PrimaryStyleColor
            pnlSideMenuHeader.BackColor = ColorEditor.Darken(UIAppearance.PrimaryStyleColor, 6)
            pnlTitleBar.Update()
        End If
    End Sub

    Private Sub SideMenuButton_Click(sender As Object, e As EventArgs)

        '-> Collapse side menu
        If Me.pnlSide.Width = 220 Then
            Me.pnlSide.Width = 65
            'Hide any header control except the side menu button
            For Each control As Control In Me.pnlSideMenuHeader.Controls

                If control IsNot biSideMenuButton Then
                    control.Visible = False
                    Else
                    control.Visible = true
                End If
            Next

            '-> Expand the side menu
        Else
            Me.pnlSide.Width = 220
            'Show any header control
            For Each control As Control In Me.pnlSideMenuHeader.Controls

                If control IsNot biSideMenuButton Then
                    control.Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub FormIcon_Click(sender As Object, e As EventArgs)
        CloseActiveChildForm() 'Close the current child form from the panel desktop
        UpdateFormLayout() 'Update main form
    End Sub

    Private Sub FormIcon_MouseHover(sender As Object, e As EventArgs)
        'When the user hovers the mouse over the form icon, change the icon to close.
        If Me.activeChildForm IsNot Nothing Then
            Me.biFormIcon.IconChar = IconChar.TimesCircle 'Close icon
        End If
    End Sub

    Private Sub FormIcon_MouseLeave(sender As Object, e As EventArgs)
        'when mouse pointer leaves form icon, reset current form icon
        If Me.activeChildForm IsNot Nothing Then
            Me.biFormIcon.IconChar = activeChildForm.FormIcon
        End If
    End Sub

    Private Sub CloseAllChildForms_Click(sender As Object, e As EventArgs)
        'Close all child forms
        CloseAllChildForm()
    End Sub

    Private Sub MoveNewWindow_Click(sender As Object, e As EventArgs)
        'Move child form to a new window
        MoveFormNewWindow()
    End Sub

    Private Sub ChilFormHelp_Click(sender As Object, e As EventArgs)
        'Show help message of child form
        If activeChildForm.HelpMessage = "" OrElse activeChildForm.HelpMessage Is Nothing Then
            RJMessageBox.Show("No help message has been added for this form", "Message")
        Else 'Show help message
            RJMessageBox.Show(activeChildForm.HelpMessage, "Help")
        End If
    End Sub

    Private Sub Screenshot_Click(sender As Object, e As EventArgs)
        Screenshot()
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs)
        PrintCurrentChildForm()
    End Sub

    Private Sub ToolTip_Draw(sender As Object, e As DrawToolTipEventArgs)
        'Draw the control from the properties provided in the properties.
        e.DrawBackground() 'Background color
        e.DrawText() 'Text
    End Sub
#End Region

End Class

