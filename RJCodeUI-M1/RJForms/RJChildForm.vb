Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports FontAwesome.Sharp

Public Class RJChildForm
    Inherits RJBaseForm

    ''' This class inherits from the <RJBaseForm/> class
    '''  
    ''' <summary>
    ''' In This class, you set a default size of the form, remove the border of the form, 
    ''' and add custom title bar and client area using panels, as well as add the buttons
    ''' to maximize, minimize, close, and the Dropdown menu for the list of options 
    ''' for the form. (Left-Right SnapWindow, Help).
    ''' The default form size is equal to the Desktop Panel Size of the main form,
    ''' you can change that by setting the _DesktopPanelSize property to false.
    ''' </summary>

#Region "-> Fields"

    Private _components As IContainer = Nothing 'Container of components for which they are not children of the form.
    'Allow all added components to be disposed with the Dispose method by the component container
    '<see cref = "protected override void Dispose (bool disposing)" />
    Private _isChildForm As Boolean 'Gets or sets if it is a child form
    Private _markerPosition As Integer 'Gets or sets the marker location for the form menu button
    Private _helpMessage As String 'Gets or sets the help message of the form for the user
    Private _formIcon As IconChar 'Gets or sets the form icon
    Private _disableFormOptions As Boolean 'Disables or enables the Windows Form Options drop-down menu
    Private _deskPanelSize As Boolean 'Gets or sets whether the size of the form is equal to the size of the desktop pane or can be customized from the size property of the designer properties box (default is true)
    Private _supernovaColor As Color = If(UIAppearance.Style = UIStyle.Supernova, RJColors.GetSupernovaColor(), Color.CornflowerBlue)
    'Controls
    Private _pnlTitleBar As Panel 'Sets the title bar of the form
    Private _lblCaption As Label 'Sets the form caption
    Private _dragControl As RJDragControl 'Sets the drag control of the form (it is a component, the constructor accepts a parameter of type IContainer)
    Private _btnFormIcon As IconButton 'Sets the form icon button
    Private _dmFormOptions As RJDropdownMenu 'Sets the drop-down menu for Windows form options (it is a component, the constructor accepts a parameter of type IContainer)
    Private _miHelp As IconMenuItem 'Sets the help menu item.

    Protected _pnlClientArea As Panel 'Sets the client area (Body) of the form.
#End Region

#Region "-> Constructor"

    Public Sub New()
        'Initialize the components for the form design: add the title bar, buttons to maximize, minimize,
        'drop down menu of form options and the client area of ​​the form

        _components = New System.ComponentModel.Container() 'initialize container
        '' Instantiation of controls
        _pnlClientArea = New Panel()
        _pnlTitleBar = New Panel()
        _lblCaption = New Label()
        _dragControl = New RJDragControl(_pnlTitleBar, Me, _components) 'Drag control, add to component container
        _dmFormOptions = New RJDropdownMenu(_components) 'Add to component container
        _btnFormIcon = New FontAwesome.Sharp.IconButton()
        _miHelp = New FontAwesome.Sharp.IconMenuItem()

        '-> Form title bar

        '- Panel: Form Title Bar
        _pnlTitleBar.SuspendLayout()
        _pnlTitleBar.Name = "_pnlTitleBar"
        _pnlTitleBar.Location = New Point(0, 0)
        _pnlTitleBar.Dock = DockStyle.Top
        _pnlTitleBar.Size = New Size(960, 40)
        _pnlTitleBar.Controls.Add(_btnFormIcon) 'Add controls
        _pnlTitleBar.Controls.Add(_lblCaption)
        _pnlTitleBar.Controls.Add(Me.btnMinimize)
        _pnlTitleBar.Controls.Add(Me.btnMaximize)
        _pnlTitleBar.Controls.Add(Me.btnClose)

        '- Icon Button: Form icon (FontAwesome.Sharp library)
        _btnFormIcon.Name = "btnIcon"
        _btnFormIcon.Cursor = Cursors.Hand
        _btnFormIcon.FlatStyle = FlatStyle.Flat
        _btnFormIcon.FlatAppearance.BorderSize = 0
        _btnFormIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        _btnFormIcon.IconChar = FontAwesome.Sharp.IconChar.Folder
        _btnFormIcon.IconColor = Color.WhiteSmoke
        _btnFormIcon.IconSize = 25
        _btnFormIcon.Rotation = 0.0R
        _btnFormIcon.Location = New Point(0, 0)
        _btnFormIcon.Size = New Size(40, 40)
        _btnFormIcon.UseVisualStyleBackColor = False
        AddHandler _btnFormIcon.MouseEnter, AddressOf FormIcon_MouseEnter 'Events
        AddHandler _btnFormIcon.MouseLeave, AddressOf FormIcon_MouseLeave
        AddHandler _btnFormIcon.Click, AddressOf FormIcon_Click

        '- Label: Form title
        _lblCaption.Name = "_lblCaption"
        _lblCaption.AutoSize = True
        _lblCaption.Font = New Font("Montserrat", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        _lblCaption.ForeColor = Color.WhiteSmoke
        _lblCaption.Location = New Point(40, 10)

        '- Button: Control box buttons
        Me.btnClose.Dock = DockStyle.Right
        Me.btnMaximize.Dock = DockStyle.Right
        Me.btnMinimize.Dock = DockStyle.Right

        '-> -Form options

        '- Icon MenuItem: Help (FontAwesome.Sharp library)
        _miHelp.Name = "_miHelp"
        _miHelp.Text = "Help"
        _miHelp.IconSize = 21
        _miHelp.IconChar = IconChar.Question
        _miHelp.IconColor = RJColors.FantasyColorScheme4
        AddHandler _miHelp.Click, AddressOf HelpMessage_Click

        '- DropdownMenu: Form options
        _dmFormOptions.Name = "_dmFormOptions"
        _dmFormOptions.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        _dmFormOptions.Items.AddRange(New ToolStripItem() {miSnapLeft, miSnapRight, miExitSnap, _miHelp}) 'Add dropdown menu items
        _dmFormOptions.OwnerIsMenuButton = False
        AddHandler _dmFormOptions.VisibleChanged, AddressOf FormOptions_VisibleChanged
        '-> Customer area of ​​the form

        '- Panel: Client area (Form Body)
        _pnlClientArea.Dock = DockStyle.Fill
        _pnlClientArea.Location = New Point(0, 40)
        _pnlClientArea.Name = "_pnlClientArea"
        _pnlClientArea.Size = New Size(960, 485)
        _pnlClientArea.AutoScroll = True

        '-> RJ Child Form Properties
        Me.Name = "RJChildForm"
        Me.Text = "RJ Child form"
        Me.Controls.Add(_pnlClientArea)
        Me.Controls.Add(_pnlTitleBar)
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.None 'Disable autoscale mode to keep form size set in DefaultSize property
        Me.FormBorderStyle = FormBorderStyle.None 'Set Borderless Form
        Me.MinimumSize = New Size(400, 180) 'Minimum form size
        Me.DoubleBuffered = True
        AddHandler Me.Load, AddressOf FormLoad
        AddHandler Me.Resize, AddressOf Form_Resized
        AddHandler Me.Deactivate, AddressOf Form_Deactivate 'subscribe disabled event to change / opaque title bar color
        AddHandler Me.Activated, AddressOf Form_Activate 'Subscribe Activated event to retrieve title bar color
        _deskPanelSize = True 'Set as default.
        _formIcon = IconChar.Folder
        _pnlTitleBar.PerformLayout()
        _pnlTitleBar.ResumeLayout()
    End Sub
#End Region

#Region "-> Properties"

    <Browsable(False)>
    Public Property IsChildForm As Boolean
        'Gets or sets if it is a child form
        Get
            Return _isChildForm
        End Get
        Set(value As Boolean)
            _isChildForm = value

            If _isChildForm = True Then 'If the form is a child form, set to NON-resizable form.
                Me.Resizable = False
            Else 'Otherwise, set as resizable form.
                Me.Resizable = True
            End If
            ApplyApperanceSettings() 'Reapply settings when this property changes.
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property _DesktopPanelSize As Boolean
        'Gets or sets whether the size of the form is equal to the size of the main form's desktop pane
        'or it can be customized from the size property of the designer properties box.
        Get
            Return _deskPanelSize
        End Get
        Set(value As Boolean)
            _deskPanelSize = value 'Set value
            If value = True Then 'If the value is true, set the size of the desktop panel as the size of the form + the height of the title bar
                Me.Size = New Size(960, 560)
            End If
        End Set
        'Note> Do not change the name, at least the underscore (_). Properties run on
        'alphabetically, so this property must be executed before the ClientSize property.
    End Property

    <Category("RJ Code Advance")>
    Public Property DisableFormOptions As Boolean
        'Disable the Form Options drop-down menu
        Get
            Return _disableFormOptions
        End Get
        Set(value As Boolean)
            _disableFormOptions = value

            If value = True Then
                _btnFormIcon.Cursor = Cursors.Arrow
                _btnFormIcon.FlatAppearance.MouseOverBackColor = UIAppearance.StyleColor
                _btnFormIcon.FlatAppearance.MouseDownBackColor = UIAppearance.StyleColor
            End If
        End Set
    End Property

    <Browsable(False)>
    Public Property MarkerPosition As Integer
        'Gets or sets the location of the menu button marker on the main form
        Get
            Return _markerPosition
        End Get
        Set(value As Integer)
            _markerPosition = value
        End Set
    End Property

    Public Overloads Property ClientSize As Size
        'Hide client size so that the default size (Main form desktop panel size) takes effect on derived forms
        'You can disable it by setting the _DesktopPanelSize property to false
        Get
            Return MyBase.ClientSize
        End Get
        Set(value As Size)

            If _deskPanelSize = False Then 'If the desktopPanelSize field is false, set the value as the size of the form
                MyBase.ClientSize = value
            Else
                'Otherwise, keep the default size set
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property DefaultSize As Size
        'Default size form
        Get
            Return New Size(960, 560)
        End Get
        '<Note> The default size of the form must be equal to the size of the desktop panel of the main form + Height title bar (40)
        'this to avoid problems with the location and display of the controls when the form is displayed on the desktop panel.
        'In addition to having an exact and elegant design where you can have more control over the docking and docking properties of the control
    End Property

    Public Overrides Property Text As String
        'Override text property to extend functionality.
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            _lblCaption.Text = value 'Set form caption
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Caption As String
        'Get or set the Form Title
        Get
            Return Me.Text
        End Get
        Set(value As String)
            Me.Text = value 'Set form title
            _lblCaption.Text = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <TypeConverter(GetType(IconConverter))>
    Public Property FormIcon As IconChar
        'Get or set form icon
        Get
            Return _formIcon
        End Get
        Set(value As IconChar)
            _formIcon = value
            _btnFormIcon.IconChar = _formIcon
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property HelpMessage As String
        'Form help message for user
        Get
            Return _helpMessage
        End Get
        Set(value As String)
            _helpMessage = value
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyApperanceSettings()
        'Apply theme settings
        Me._pnlClientArea.BackColor = UIAppearance.BackgroundColor 'Set the background color of the form

        If _isChildForm Then 'If it is a child form. That is, it is displayed on the desktop panel of the main form.
            _pnlTitleBar.Visible = False 'Hide title bar
            Me.BorderSize = 0 'Delete form border

        Else 'is not a child form, that is, it is displayed outside the desktop pane of the main form
            'The form has the title bar and border
            If Not Me.DesignMode Then Me.CenterToScreen() 'Center window

            If UIAppearance.Style = UIStyle.Supernova Then
                _pnlTitleBar.BackColor = RJColors.DarkItemBackground
                _btnFormIcon.IconColor = _supernovaColor
            Else
                _pnlTitleBar.BackColor = UIAppearance.PrimaryStyleColor 'set title bar background color
                _btnFormIcon.IconColor = Color.WhiteSmoke
            End If

            _pnlTitleBar.Visible = True 'Show title bar
            _lblCaption.Text = Me.Text 'Set form caption
            _btnFormIcon.IconChar = _formIcon 'Set form icon
            Me.BorderSize = UIAppearance.FormBorderSize 'The width of the form border will be equal to the border of the user setting
            Me.BorderColor = UIAppearance.FormBorderColor 'Set the border color of the form
        End If
    End Sub
#End Region

#Region "-> Overrides"

    ''' <summary>
    ''' Clean up the resources that are being used.
    ''' </summary>
    ''' <param name = "disposing"> true if managed resources should be removed; otherwise false. </param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (_components IsNot Nothing) Then
            _components.Dispose() 'Dispose of components
        End If

        MyBase.Dispose(disposing)
    End Sub

#End Region

#Region "-> Event methods"

    Private Sub FormLoad(sender As Object, e As EventArgs)
        If _isChildForm = False Then 'If the IsChildform property is TRUE, the ApplyApperanceSettings method is called there, so there is no need to call it again.
            ApplyApperanceSettings() 'Apply appearance settings in load event.
        End If
    End Sub

    Private Sub Form_Resized(sender As Object, e As EventArgs)
        If Me.DesignMode Then 'if the desktopPanelSize field is true, just allow to change the height of the form, the width should be kept equal to the width of the desktop panel
            If _deskPanelSize Then Me.Size = New Size(960, Me.Size.Height)
        End If
        '<Note> If the form is in design mode, it will not be possible to change the width of the form
        'to always have the same width as the desktop panel of the main form,
        'this to have an exact and elegant design.
        'However, if it is possible to change the height of the form and scroll down
        'If you don't agree with this, you can remove this code
    End Sub

    Private Sub Form_Deactivate(sender As Object, e As EventArgs)
        'When the form goes into deactivated mode (loses focus), change / opaque the color of the title bar.
        _pnlTitleBar.SuspendLayout()
        _pnlTitleBar.BackColor = UIAppearance.DeactiveFormColor 'Set title bar background color
        Me.BorderColor = RJColors.DefaultFormBorderColor 'Set the border color
        If UIAppearance.Style = UIStyle.Supernova Then _btnFormIcon.IconColor = Color.WhiteSmoke 'If the style is supernova, change the icon color to white
        _pnlTitleBar.ResumeLayout()
        _pnlTitleBar.Update() 'Force the title bar to be drawn to avoid flickering when the background color is changed.
    End Sub

    Private Sub Form_Activate(sender As Object, e As EventArgs)
        'When the form enters activated mode (recovers focus - form is redisplayed),
        'Reset the color of the title bar and border of the form.
        If UIAppearance.Style = UIStyle.Supernova Then
            _pnlTitleBar.BackColor = RJColors.DarkItemBackground 'Set title bar background color
            _btnFormIcon.IconColor = _supernovaColor 'Set icon color
        Else
            _pnlTitleBar.BackColor = UIAppearance.PrimaryStyleColor 'Set title bar background color
        End If

        Me.BorderColor = UIAppearance.FormBorderColor 'Set the border color
        _pnlTitleBar.Update() 'Force the title bar to be drawn to avoid flickering when the background color is changed.
    End Sub

    Private Sub FormIcon_MouseEnter(sender As Object, e As EventArgs)
        'If the mouse pointer hovers over the form icon button, change the form icon to options list
        'as long as the form options drop down is not disabled and the options drop down has not been shown
        If _disableFormOptions = False Then
            If _dmFormOptions.Visible = False Then _btnFormIcon.IconChar = IconChar.ListUl 'Options list icon
        End If
    End Sub

    Private Sub FormIcon_MouseLeave(sender As Object, e As EventArgs)
        'If the mouse pointer leaves the form icon button, re-set the form icon.
        'as long as the form options dropdown is not disabled and has not been shown
        If _disableFormOptions = False Then
            If _dmFormOptions.Visible = False Then _btnFormIcon.IconChar = _formIcon 'Form icon
        End If
    End Sub

    Private Sub FormIcon_Click(sender As Object, e As EventArgs)
        'if the form icon is clicked and the form options dropdown is not disabled
        'Show drop-down menu from list of form options
        If _disableFormOptions = False Then
            Me._dmFormOptions.Show(_pnlTitleBar, DropdownMenuPosition.LeftBottom) 'Show at the bottom left of the form
        End If
    End Sub

    Private Sub FormOptions_VisibleChanged(sender As Object, e As EventArgs)
        'When the form options drop-down menu is displayed or closed
        If _dmFormOptions.Visible = True Then 'If menu is displayed
            'keep the button highlighted and set the icon in the options list
            _btnFormIcon.BackColor = ColorEditor.Darken(_btnFormIcon.BackColor, 15)
            _btnFormIcon.FlatAppearance.MouseOverBackColor = _btnFormIcon.BackColor
            _btnFormIcon.IconChar = IconChar.ListUl 'Options list icon

        Else 'If the menu is hidden
            'set default color and icon
            If UIAppearance.Style = UIStyle.Supernova Then
                _btnFormIcon.BackColor = RJColors.DarkItemBackground
            Else
                _btnFormIcon.BackColor = UIAppearance.PrimaryStyleColor
            End If
            _btnFormIcon.IconChar = _formIcon 'Form icon
        End If
    End Sub

    Private Sub HelpMessage_Click(sender As Object, e As EventArgs)
        'Show the help message of the form
        If _helpMessage = "" OrElse _helpMessage Is Nothing Then
            RJMessageBox.Show("No help message has been added for this form", "Message")
        Else
            RJMessageBox.Show(_helpMessage, "Quick Help")
        End If
    End Sub
#End Region

End Class
