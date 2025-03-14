Imports System.ComponentModel
Imports FontAwesome.Sharp

Public Class RJBaseForm
    Inherits Form

    ''' This class inherits from the <Form/> class of the <System.Windows.Forms/> library
    ''' 
    ''' <summary>
    '''     A borderless form loses the functionality of resizing, aereo snap, maximize-restore and minimizing from the taskbar,
    '''     so in this class these functionalities will be re-implemented by overriding
    '''     the processing Windows messages, creation parameters methods at the operating system level
    '''     and adding the necessary buttons and methods.
    ''' </summary>

#Region "-> Fields"

    Private _isPrimaryForm As Boolean 'Gets or sets if it is a primary form: it is a base form for all forms in the application (for example, login form and main form)
    Private _isResizable As Boolean = True 'Gets or sets whether the form is resizable from the edges of the form
    Private _minimizeButton As Boolean = True 'Gets or sets whether the minimize button is shown.
    Private _maximizeButton As Boolean = True 'Gets or sets whether the maximize button is shown.
    Private _isMaximized As Boolean 'Get or set if the form is maximized: It is a switch to stop the code execution cycles on the resize event
    Private _snapWindow As Boolean 'Gets or sets whether to trigger winsnap of the form (this is a simple imitation of the window snapping function - window aero snap)
    Private _tempSize As Size 'Gets or sets the temporary size of the form to restore size after WinSnap is activated
    Private _tempLocation As Point 'Gets or sets the temporary location of the form to restore size after WinSnap is activated
    Private _borderSize As Integer 'Gets or sets the width of the form border
    Private _borderColor As Color 'Gets or sets the border color of the form
    'Constants
    Private Const _resizeAreaSize As Integer = 10 'Determines the size of the resize area of ​​the form.
    Private Const _WS_MINIMIZEBOX As Integer = &H20000 'Native Methods: Represents a window style that has a minimize button
    Private Const _WM_NCHITTEST As Integer = &H84 'Win32, Mouse input notification: determines which part of the window corresponds to a point, allows to change the size of the form.
    'Controls
    Friend btnMinimize As Button 'Minimize Button
    Friend btnMaximize As Button 'Maximize Button
    Friend btnClose As Button 'Close Button
    Friend miSnapLeft As IconMenuItem 'Menu item dock left   [Note: ICON MENU ITEM is provided by the FontAwesome.Sharp library]
    Friend miSnapRight As IconMenuItem 'Menu Item Dock Right [Author: mkoertgen, GitHub: https://github.com/awesome-inc/FontAwesome.Sharp]
    Friend miExitSnap As IconMenuItem 'Menu item undock or restore window size.
#End Region

#Region "-> Constructor"

    Public Sub New()
        'Initialize the components for the form design
        btnMinimize = New Button()
        btnMaximize = New Button()
        btnClose = New Button()
        miSnapLeft = New IconMenuItem()
        miSnapRight = New FontAwesome.Sharp.IconMenuItem()
        miExitSnap = New FontAwesome.Sharp.IconMenuItem()

        '-> Control box buttons
        '-Button: Close
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Image = My.Resources.CloseWhite
        btnClose.Location = New Point(175, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(35, 40)
        btnClose.UseVisualStyleBackColor = True
        AddHandler btnClose.Click, AddressOf Close_Click
        AddHandler btnClose.MouseEnter, AddressOf btnClose_MouseEnter
        AddHandler btnClose.MouseLeave, AddressOf btnClose_MouseLeave

        '-Button: Maximize
        btnMaximize.FlatAppearance.BorderSize = 0
        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.Image = My.Resources.MaximizeWhite
        btnMaximize.Location = New Point(140, 0)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(35, 40)
        btnMaximize.UseVisualStyleBackColor = True
        AddHandler btnMaximize.Click, AddressOf MaximizeRestore_Click
        AddHandler btnMaximize.MouseEnter, AddressOf btnMaximize_MouseEnter
        AddHandler btnMaximize.MouseLeave, AddressOf btnMaximize_MouseLeave

        '-Button: Minimize
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Image = My.Resources.MinimizeWhite
        btnMinimize.Location = New Point(105, 0)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(35, 40)
        btnMinimize.UseVisualStyleBackColor = True
        AddHandler btnMinimize.Click, New System.EventHandler(AddressOf Minimize_Click)
        AddHandler btnMinimize.MouseEnter, AddressOf btnMinimize_MouseEnter
        AddHandler btnMinimize.MouseLeave, AddressOf btnMinimize_MouseLeave

        '-> Snap Window
        '-MenuItem: Snap Window Left (FontAwesome.Sharp library)
        miSnapLeft.Name = "miSnapLeft"
        miSnapLeft.Text = "Snap Window Left"
        miSnapLeft.IconSize = 21
        miSnapLeft.IconChar = IconChar.SignInAlt
        miSnapLeft.Rotation = -180
        miSnapLeft.IconColor = RJColors.FantasyColorScheme1
        AddHandler miSnapLeft.Click, AddressOf SnapWindowLeft_Click

        '-MenuItem: Snap Window Right (FontAwesome.Sharp library)
        miSnapRight.Name = "miSnapRight"
        miSnapRight.Text = "Snap Window Right"
        miSnapRight.IconSize = 21
        miSnapRight.IconChar = IconChar.SignInAlt
        miSnapRight.IconColor = RJColors.FantasyColorScheme2
        AddHandler miSnapRight.Click, AddressOf SnapWindowRight_Click

        '-MenuItem: Exit Snap Window (FontAwesome.Sharp library)
        miExitSnap.Name = "miExitSnap"
        miExitSnap.Text = "Exit Snap Window"
        miExitSnap.IconSize = 21
        miExitSnap.IconChar = IconChar.CropAlt
        miExitSnap.IconColor = RJColors.FantasyColorScheme3
        AddHandler miExitSnap.Click, AddressOf ExitSnapWindow_Click

        '-> Form
        Me.Font = New Font("Microsoft Sans Serif", UIAppearance.TextSize, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        AddHandler Me.Load, AddressOf Form_Load
        AddHandler Me.Resize, AddressOf Form_Resize
    End Sub
#End Region

#Region "-> Properties"

    <Browsable(False)>
    Protected Property PrimaryForm As Boolean
        'Gets or sets if it is a parent form: it is a base form for all forms in the application (for example, login form and main form)
        Get
            Return _isPrimaryForm
        End Get
        Set(value As Boolean)
            _isPrimaryForm = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets if the form is resizable")>
    <DefaultValue(True)>
    Public Property Resizable As Boolean
        'Gets or sets whether the form is resizable (see WndProc (ref Message message) method)
        Get
            Return _isResizable
        End Get
        Set(value As Boolean)
            _isResizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Hide or show the minimize button")>
    <DefaultValue(True)>
    Public Property DisplayMinimizeButton As Boolean
        Get
            Return _minimizeButton
        End Get
        Set(value As Boolean)
            _minimizeButton = value
            btnMinimize.Visible = _minimizeButton
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Hide or show the maximize button")>
    <DefaultValue(True)>
    Public Property DisplayMaximizeButton As Boolean
        Get
            Return _maximizeButton
        End Get
        Set(value As Boolean)
            _maximizeButton = value
            btnMaximize.Visible = _maximizeButton
        End Set
    End Property

    <Browsable(False)>
    Public Property BorderSize As Integer
        'Gets or sets the width of the form border
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Padding = New Padding(_borderSize) 'The width of the form border will be defined by the Padding property
        End Set
    End Property

    <Browsable(False)>
    Public Property BorderColor As Color
        'Gets or sets the border color of the form
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.BackColor = value 'The border color of the form will be determined by the BackColor property
        End Set
    End Property

    'Hide background color property
    <Browsable(False)>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        'Override ownership of form creation parameters
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.Style = param.Style Or _WS_MINIMIZEBOX 'Sets a minimize box in the window style / Will allow to minimize the form from the taskbar icon
            Return param
        End Get
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        If UIAppearance.Style = UIStyle.Supernova Then 'if the style is supernova
            btnClose.FlatAppearance.MouseOverBackColor = RJColors.FantasyColorScheme4
            btnMaximize.FlatAppearance.MouseOverBackColor = RJColors.FantasyColorScheme1
            btnMinimize.FlatAppearance.MouseOverBackColor = RJColors.Sky

            If _isPrimaryForm Then

                If UIAppearance.Theme = UITheme.Light Then 'if the theme is CLEAR, set the maximize, minimize and close buttons to black.
                    Me.btnClose.Image = My.Resources.CloseDark
                    Me.btnMaximize.Image = My.Resources.MaximizeDark
                    Me.btnMinimize.Image = My.Resources.MinimizeDark
                End If
            End If
        End If
    End Sub

    Private Sub SetMaximizeRestoreIcon()
        If _isPrimaryForm Then 'If it is a primary form (for example, LoginForm and MainForm)

            'If the style is supernova and the theme is light: set the icon to a dark color
            If UIAppearance.Style = UIStyle.Supernova AndAlso UIAppearance.Theme = UITheme.Light Then
                If Me.WindowState = FormWindowState.Normal Then
                    btnMaximize.Image = My.Resources.MaximizeDark
                Else
                    btnMaximize.Image = My.Resources.RestoreDark
                End If

            Else 'If it's any other theme or style: set the icon to a light color
                If Me.WindowState = FormWindowState.Normal Then
                    btnMaximize.Image = My.Resources.MaximizeWhite
                Else
                    btnMaximize.Image = My.Resources.RestoreWhite
                End If
            End If

        Else 'If it is a child form: set the icon to a light color
            If Me.WindowState = FormWindowState.Normal Then
                btnMaximize.Image = My.Resources.MaximizeWhite
            Else
                btnMaximize.Image = My.Resources.RestoreWhite
            End If
        End If
    End Sub
#End Region

#Region "-> Protected methods"

    Protected Overridable Sub CloseWindow()
        If _isPrimaryForm Then 'If it is a main form (for example, Main Form or LoginForm) Completely close the application.
            Dim result = RJMessageBox.Show("Deseja realmente sair do sistema?", "Sair",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Application.Exit() 'Terminate all message loops and close all windows
            End If
        Else 'If it is a secondary form
            Me.Close() 'Close current form
        End If
    End Sub

    Protected Sub MinimizeWindow()
        'minimize the form
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Protected Sub MaximizeWindow()
        'Maximize or restore the form to its normal size

        '- >>> Maximize the form
        If Me.WindowState = FormWindowState.Normal Then
            '<Note>: When maximizing a borderless form, it covers the entire screen by hiding the taskbar,
            'for this you must specify a maximum size:
            Me.MaximumSize = Screen.FromHandle(Me.Handle).WorkingArea.Size 'Set the size of the desktop area as the maximum size of the form
            Me.WindowState = FormWindowState.Maximized
            BorderSize = 0 'Delete border in maximized state
            _isMaximized = True 'Set maximized state

            If _snapWindow = True Then 'If Snap Window is on, we set its normal size.
                Me.Size = _tempSize
                _snapWindow = False
            End If

            '- >>> Restore the form
        Else
            Me.WindowState = FormWindowState.Normal
        End If

        SetMaximizeRestoreIcon() 'Refresh button icon.
    End Sub

    Protected Sub SnapWindowLeft()
        'Dock the form to the left of the desktop: Width = Half the width of the desktop area, Height = Height of the desktop area.
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        Dim myScreen = Screen.FromHandle(Me.Handle) 'Gets the current system screen where the form is located
        Dim desktopArea = myScreen.WorkingArea.Size 'Gets the working area of ​​the screen (exclude the taskbar)
        Dim newSize = New Size(desktopArea.Width / 2, desktopArea.Height) 'Set the size of the form:
        'Width = half the width of the desktop area,
        'Height = height of desk area
        If Me.Size <> newSize Then _tempSize = Me.Size 'save the current size of the form so it can be reset when you exit snap mode
        If _snapWindow = False Then _tempLocation = Me.Location
        Me.Size = newSize 'Set the new size of the form
        Me.Location = New Point(myScreen.Bounds.X, myScreen.Bounds.Y) 'Set the location of the form (Y and X coordinates of the screen boundaries)
        'Dock the form to the LEFT of the desktop
        _snapWindow = True 'Set snap state
    End Sub

    Protected Sub SnapWindowRight()
        'Dock the form to the right of the desktop: Width = Half the width of the desktop area, Height = Height of the desktop area.
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        Dim myScreen = Screen.FromHandle(Me.Handle)
        Dim desktopArea = myScreen.WorkingArea.Size
        Dim newSize = New Size(desktopArea.Width / 2, desktopArea.Height)
        If Me.Size <> newSize Then _tempSize = Me.Size
        If _snapWindow = False Then _tempLocation = Me.Location
        Me.Size = newSize
        Me.Location = New Point(myScreen.Bounds.X + desktopArea.Width / 2, myScreen.Bounds.Y) 'Set the location of the form (X coordinate = midpoint of desktop area)
        'Dock the form to the RIGHT of the desktop
        _snapWindow = True
    End Sub

    Protected Sub ExitSnapWindow()
        'Restores the size of the form after docking the window
        If _snapWindow = True Then
            Me.Size = _tempSize
            Me.Location = _tempLocation
            _snapWindow = False
        End If
    End Sub
#End Region

#Region "-> Overrides"

    Protected Overrides Sub WndProc(ByRef message As Message)
        'WindowProc function: override Windows / OS level message processing

        '-> Resize Values ​​/ WM_NCHITTEST
        Const HTCLIENT As Integer = 1 'Represents the client area of ​​the window
        Const HTLEFT As Integer = 10 'Left edge of a window, allows horizontal resizing to the left
        Const HTRIGHT As Integer = 11 'Right edge of a window, allows to resize horizontally to the right
        Const HTTOP As Integer = 12 'Top horizontal edge of a window, allows resizing vertically upwards
        Const HTTOPLEFT As Integer = 13 'Top left corner of a window border, allows you to resize diagonally to the left
        Const HTTOPRIGHT As Integer = 14 'Upper right corner of a window border, allows you to resize diagonally to the right
        Const HTBOTTOM As Integer = 15 'Horizontal bottom edge of a window, allows resizing vertically downwards
        Const HTBOTTOMLEFT As Integer = 16 'Bottom left corner of a window border, allows you to resize diagonally to the left
        Const HTBOTTOMRIGHT As Integer = 17 'Bottom right corner of a window border, allows you to resize diagonally to the right
        'More information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest

        If _isResizable Then 'Allow resizing of the form as long as it is resizable from the edges

            Select Case message.Msg
                Case _WM_NCHITTEST 'If the Windows message is WM_NCHITTEST
                    MyBase.WndProc(message)

                    If Me.WindowState = FormWindowState.Normal Then 'Resize the form if it is in normal state

                        If CInt(message.Result) = HTCLIENT Then 'If the message result (mouse pointer) is in the client area of ​​the window
                            Dim screenPoint As Point = New Point(message.LParam.ToInt32()) 'Gets the coordinates of the screen point (X & Y coordinates of the pointer)
                            Dim clientPoint As Point = Me.PointToClient(screenPoint) 'Computes the location of the screen point in the client coordinates

                            If clientPoint.Y <= _resizeAreaSize Then 'If the pointer is at the top of the form (within the resize area, X coordinate)

                                If clientPoint.X <= _resizeAreaSize Then 'If the pointer is at coordinate X = 0 or less than the resize area (X = 10) in
                                    message.Result = CType(HTTOPLEFT, IntPtr) 'Resize diagonally to the left

                                ElseIf clientPoint.X < (Me.Size.Width - _resizeAreaSize) Then 'If the pointer is at coordinate X = 11 or less than the width of the form (X = Form.Width-resizeArea)
                                    message.Result = CType(HTTOP, IntPtr) 'Resize vertically up
                                Else 'Resize diagonally to the right
                                    message.Result = CType(HTTOPRIGHT, IntPtr)
                                End If

                            ElseIf clientPoint.Y <= (Me.Size.Height - _resizeAreaSize) Then 'If the pointer is inside the form at the Y coordinate (discounting the size of the resize area)

                                If clientPoint.X <= _resizeAreaSize Then 'Resize horizontally to the left
                                    message.Result = CType(HTLEFT, IntPtr)
                                ElseIf clientPoint.X > (Me.Width - _resizeAreaSize) Then 'Resize horizontally right
                                    message.Result = CType(HTRIGHT, IntPtr)
                                End If
                            Else

                                If clientPoint.X <= _resizeAreaSize Then 'Resize diagonally to the left
                                    message.Result = CType(HTBOTTOMLEFT, IntPtr)
                                ElseIf clientPoint.X < (Me.Size.Width - _resizeAreaSize) Then 'Resize vertically down
                                    message.Result = CType(HTBOTTOM, IntPtr)
                                Else 'Resize diagonally to the right
                                    message.Result = CType(HTBOTTOMRIGHT, IntPtr)
                                End If
                            End If
                        End If
                    End If

                    Return
            End Select
        End If

        MyBase.WndProc(message)
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub Form_Load(sender As Object, e As EventArgs)
        ApplyAppearanceSettings() 'Apply settings
    End Sub

    Private Sub Form_Resize(sender As Object, e As EventArgs)
        'Set border width of the form and update the maximized button when the form is restored to its normal size and the isMaximized switch is active
        If Me.WindowState = FormWindowState.Normal AndAlso _isMaximized = True Then
            _isMaximized = False
            _borderSize = UIAppearance.FormBorderSize
            SetMaximizeRestoreIcon()
        End If
        '<Note> If the isMaximized variable does not exist, the above code will always be executed when the form is resized,
        'location or dragged point by point, which might slow down a bit.
        'So with the above condition, the code snippet will only run once.
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs)
        CloseWindow()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs)
        MinimizeWindow()
    End Sub

    Private Sub MaximizeRestore_Click(sender As Object, e As EventArgs)
        MaximizeWindow()
    End Sub

    Private Sub SnapWindowLeft_Click(sender As Object, e As EventArgs)
        SnapWindowLeft()
    End Sub

    Private Sub SnapWindowRight_Click(sender As Object, e As EventArgs)
        SnapWindowRight()
    End Sub

    Private Sub ExitSnapWindow_Click(sender As Object, e As EventArgs)
        ExitSnapWindow()
    End Sub

    'If it's primary form and the style is supernova and the theme is clearer,
    'change the color of the icon when the mouse enters and exits the button to maximize, minimize or close.
    Private Sub btnMinimize_MouseEnter(sender As Object, e As EventArgs)
        If _isPrimaryForm AndAlso UIAppearance.Style = UIStyle.Supernova AndAlso UIAppearance.Theme = UITheme.Light Then btnMinimize.Image = My.Resources.MinimizeWhite
    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs)
        If _isPrimaryForm AndAlso UIAppearance.Style = UIStyle.Supernova AndAlso UIAppearance.Theme = UITheme.Light Then btnMinimize.Image = My.Resources.MinimizeDark
    End Sub

    Private Sub btnMaximize_MouseEnter(sender As Object, e As EventArgs)
        If _isPrimaryForm AndAlso UIAppearance.Style = UIStyle.Supernova AndAlso UIAppearance.Theme = UITheme.Light Then btnMaximize.Image = My.Resources.MaximizeWhite
    End Sub

    Private Sub btnMaximize_MouseLeave(sender As Object, e As EventArgs)
        If _isPrimaryForm AndAlso UIAppearance.Style = UIStyle.Supernova AndAlso UIAppearance.Theme = UITheme.Light Then btnMaximize.Image = My.Resources.MaximizeDark
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs)
        If _isPrimaryForm AndAlso UIAppearance.Style = UIStyle.Supernova AndAlso UIAppearance.Theme = UITheme.Light Then btnClose.Image = My.Resources.CloseWhite
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs)
        If _isPrimaryForm AndAlso UIAppearance.Style = UIStyle.Supernova AndAlso UIAppearance.Theme = UITheme.Light Then btnClose.Image = My.Resources.CloseDark
    End Sub
#End Region

End Class
