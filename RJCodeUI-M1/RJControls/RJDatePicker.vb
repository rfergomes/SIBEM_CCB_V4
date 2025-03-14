Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports FontAwesome.Sharp

'Default event when double click on control in designer.
<DefaultEvent("OnValueChanged")>
Public Class RJDatePicker
    Inherits UserControl

    '' <summary>
    '' This class inherits the <UserControl/>class.
    '' This control exposes most of the most used and essential properties and events of 
    '' a normal DateTimePicker, you can add the functionalities that you probably need and are missing here.
    '' On the other hand, you can change the style to solid or glass, also customize the dropdown 
    '' calendar icon, border color and border radius (rounded corners).
    '' Tutorial guia: https://www.youtube.com/watch?v=IJM9SIX0pIs&t=1s (Custom data picker - No UserControl)
    '' Tutorial guia 2: https://www.youtube.com/watch?v=CkpUQYzYCC8&t=24s (Custon text box - UserControl)
    '' </summary>
    '' 

#Region "-> Fields"

    Private _borderRadius As Integer 'Gets or sets the size of the border radius (rounded corners).
    Private _borderSize As Integer = 1 'Gets or sets the border size.
    Private _style As ControlStyle 'Gets or sets the control style (Glass or Solid).
    Private _backgroundColor As Color 'Gets or sets the Background Color.
    Private _borderColor As Color 'Gets or sets the Border Color.
    Private _iconColor As Color 'Gets or sets the Icon Color.
    Private _customizable As Boolean 'Gets or set if the control's appearance colors are customizable.
    Private _isDroppedDown As Boolean = False 'Gets or sets whether the dropdown calendar is open.
    'Controls
    Private _dateText As Label 'Gets or sets the Label of the DateTimePicker (to display the date text of the DateTimePicker).
    Private _btnIcon As IconButton 'Gets or sets the Dropdown Calendar Icon (button to display the calendar).
    Private _datePicker As DateTimePicker 'Gets or sets the Date Picker (not visible, but can display the dropdown calendar).

    ''' ///<Note>:ICON BUTTON es proporcionado por la librería <see cref="FontAwesome.Sharp"/>.
    '''      Autor: mkoertgen
    '''      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
    '''      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp </Note>

#End Region

#Region "-> Events"

    <Category("RJ Code Advance")>
    Public Event OnValueChanged As EventHandler 'Default event for the control.
#End Region

#Region "-> Constructor"

    Public Sub New()
        _dateText = New Label()
        _datePicker = New DateTimePicker()
        _btnIcon = New IconButton()
        Me.SuspendLayout()

        '
        'IconButton: Dropdown Calendar Icon
        '
        _btnIcon.Dock = DockStyle.Right
        _btnIcon.FlatAppearance.BorderSize = 0
        _btnIcon.FlatStyle = FlatStyle.Flat
        _btnIcon.Flip = FlipOrientation.Normal
        _btnIcon.IconChar = IconChar.CalendarAlt 'Set calendar icon.
        _btnIcon.IconColor = Color.White
        _btnIcon.IconSize = 22
        _btnIcon.Location = New Point(189, 1)
        _btnIcon.Name = "dropdownArrowIcon"
        _btnIcon.Rotation = 0.0R
        _btnIcon.Size = New Size(30, 30)
        _btnIcon.UseVisualStyleBackColor = False
        _btnIcon.Cursor = Cursors.Hand
        AddHandler _btnIcon.Click, (AddressOf ButtonIcon_Click) 'Subscribe to the click event (To display the calendar)

        '//
        'Label: Date Text (Represents the visual part of the DateTimePicker, displays the text of the date, and FILLS in the user control)
        '
        _dateText.Dock = DockStyle.Fill 'Set padding as dock style
        _dateText.FlatStyle = FlatStyle.Flat
        _dateText.Font = New Font("Microsoft Sans Serif", 10.0F)
        _dateText.ForeColor = Color.Gray
        _dateText.ImageAlign = ContentAlignment.MiddleLeft
        _dateText.Location = New Point(1, 1)
        _dateText.Name = "dateText"
        _dateText.Padding = New Padding(8, 0, 0, 0)
        _dateText.Controls.Add(_btnIcon) 'Add the icon button to the label.
        _dateText.TextAlign = ContentAlignment.MiddleLeft

        '/ * Since the (dateText) label represents the visual part of the ComboBox and takes up most of the user control,
        'It is necessary to attach the events that occur in the label (dateText) to the events of the user control (RJDatePicker),
        'That is, for example in the Click event, when the label is clicked, the click event of the user control (RJDatePicker) must also be executed.
        'See the definition of the event methods to understand better. * /
        AddHandler _dateText.Click, AddressOf RJDatePicker_Click
        AddHandler _dateText.KeyDown, AddressOf RJDatePicker_KeyDown
        AddHandler _dateText.KeyPress, AddressOf RJDatePicker_KeyPress
        AddHandler _dateText.KeyUp, AddressOf RJDatePicker_KeyUp
        AddHandler _dateText.MouseEnter, AddressOf RJDatePicker_MouseEnter
        '// You can attach whatever events you want, if it doesn't exist, you can create it like you did with the OnValueChanged event.

        '
        'DateTimePicker: Date Picker
        '
        _datePicker.Name = "datePicker"
        _datePicker.Size = New Size(100, 20)
        _datePicker.Location = New Point(2, 2)
        _datePicker.DropDownAlign = LeftRightAlignment.Right
        AddHandler _datePicker.CloseUp, (AddressOf DatePicker_CloseUp) 'Subscribe to the CloseUp event (It happens when the calendar is hidden / closed)
        AddHandler _datePicker.ValueChanged, (AddressOf DatePicker_ValueChanged) 'Subscribe the ValueChanged event of the control and attach it to the previously defined OnValueChanged event (see method definition).
        '
        'User control: RJDatePicker
        '
        'Add controls
        Me.Controls.Add(_dateText) 'Populate all user control (display datepicker text)
        Me.Controls.Add(_datePicker) 'It's in the background, behind the label (not visible, but showing the drop-down calendar).
        'This order is important, the last controls are added first (from bottom to top)

        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.None
        Me.BackColor = Color.MediumSlateBlue
        Me.MinimumSize = New Size(120, 25)
        Me.Padding = New Padding(1)
        Me.Size = New Size(260, 32)
        BorderSize = _borderSize 'Set border size to apply necessary adjustments.
        Me.ResumeLayout(False)
    End Sub
#End Region

#Region "-> Properties"

#Region "- Design properties"
    <Category("RJ Code Advance")>
    <Description("Set or get the style (glass or solid)")>
    Public Property Style As ControlStyle
        Get
            Return _style
        End Get
        Set(ByVal value As ControlStyle)
            _style = value
            BorderRadius = _borderRadius ' Update border radius.
            If Me.DesignMode Then ApplyAppearanceSettings() 'update appearance settings-> preview changes in design mode.
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Sets or gets if the control is customizable")>
    Public Property Customizable As Boolean
        Get
            Return _customizable
        End Get
        Set(ByVal value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Set or set the border color")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate() 'Draw the border (Redraw the control)
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Get or set border size")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)

            If value >= 1 Then
                _borderSize = value
                Me.Padding = New Padding(_borderSize + 1) 'Set the Padding property to apply a space and draw the border.
                SetDatePickerLocation() 'Update the location of the combobox.
                Me.Invalidate() 'Draw the border (Redraw the control)
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Set or get the edge radius")>
    <DefaultValue(0)>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)

            If value >= 0 Then
                _borderRadius = value
                SetDatePickerLocation() 'Update the location of the combobox.
                Me.Invalidate() 'Draw edge and radius (Redraw control)
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Set or get the background color.")>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            _backgroundColor = value
            _dateText.BackColor = _backgroundColor
            _btnIcon.BackColor = _backgroundColor
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Set or keep the icon color.")>
    Public Property IconColor As Color
        Get
            Return _btnIcon.IconColor
        End Get
        Set(ByVal value As Color)
            _iconColor = value
            _btnIcon.IconColor = _iconColor
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            _dateText.ForeColor = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Get or set the font")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            _dateText.Font = value
        End Set
    End Property
#End Region

#Region "- Functional properties"

    <Category("RJ Code Advance")>
    <Description("Gets or sets the format of the date and time displayed in the control")>
    Public Property Format As DateTimePickerFormat
        Get
            Return _datePicker.Format
        End Get
        Set(ByVal value As DateTimePickerFormat)
            _datePicker.Format = value
            _dateText.Text = _datePicker.Text 'Update date text
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the custom date / time format string")>
    Public Property CustomFormat As String
        Get
            Return _datePicker.CustomFormat
        End Get
        Set(ByVal value As String)
            _datePicker.CustomFormat = value
            _dateText.Text = _datePicker.Text 'Update date text
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the date / time value assigned to the control")>
    Public Property Value As DateTime
        Get
            Return _datePicker.Value
        End Get
        Set(ByVal value As DateTime)
            _datePicker.Value = value
            _dateText.Text = _datePicker.Text 'Update date text
        End Set
    End Property

    'Property not visible in the properties box
    <Browsable(False)>
    Public Overloads ReadOnly Property Text As String 'Override text property of user control
        Get
            Return _datePicker.Text 'Return the text of the date picker.
        End Get
    End Property
#End Region
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        'Apply appearance settings
        If _customizable = False Then

            Select Case _style
                Case ControlStyle.Solid 'Solid style.
                    BorderColor = UIAppearance.StyleColor
                    BorderSize = 0
                    _dateText.ForeColor = Color.White
                    _btnIcon.IconColor = Color.White
                    Me.BackColor = UIAppearance.StyleColor
                Case ControlStyle.Glass ' Glass style.
                    _btnIcon.IconColor = UIAppearance.StyleColor
                    _dateText.ForeColor = UIAppearance.PrimaryTextColor
                    Me.BackColor = UIAppearance.BackgroundColor

                    If UIAppearance.Theme = UITheme.Dark Then
                        BorderColor = ColorEditor.Darken(UIAppearance.TextColor, 10)
                    Else
                        BorderColor = UIAppearance.TextColor
                    End If
            End Select
        End If
    End Sub

    Private Sub SetDatePickerLocation()
        'It is responsible for locating the datePicker in the lower right corner.
        If _borderRadius > 2 Then
            _datePicker.Location = New Point(Me.Width - _datePicker.Width - Me.Padding.Right - (_borderRadius / 2) - 2, _dateText.Bottom - _datePicker.Height)
        Else
            _datePicker.Location = New Point(Me.Width - _datePicker.Width - Me.Padding.Right, _dateText.Bottom - _datePicker.Height)
        End If
    End Sub
#End Region

#Region "-> Event methods"
    '// -> Default event
    Private Sub DatePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Attach the default event created OnValueChanged of the user control (RJDatePicker)
        'to the ValueChanged main event of the datepicker (datePicker).
        RaiseEvent OnValueChanged(sender, e)
        _dateText.Text = _datePicker.Text 'When a date is selected from the drop-down calendar, update the label text.
    End Sub

    '-> Component actions
    Private Sub ButtonIcon_Click(ByVal sender As Object, ByVal e As EventArgs)
        'When the calendar icon button is clicked, the drop-down calendar will be displayed
        _isDroppedDown = True
        Me._datePicker.Select() 'As a precaution, the date picker needs to be in focus before, some problems happen sometimes.
        SendKeys.Send("%{DOWN}") 'This control does not have the DroppedDown property to display the calendar.
        'therefore we will use the operating system shortcut keys to display the calendar: Alt key + down arrow is pressed
        'Alt key =%
        'Down arrow key = DOWN
        'Then we send keystrokes when the calendar icon is clicked.

        If _customizable Then
            Select Case _style 'Apply a highlight to the icon button
                Case ControlStyle.Solid
                    _btnIcon.BackColor = ColorEditor.Darken(_backgroundColor, 10)
                    _btnIcon.IconColor = Color.White
                Case ControlStyle.Glass
                    _btnIcon.BackColor = _borderColor
                    _btnIcon.IconColor = Color.White
                    BorderColor = _borderColor
            End Select
        Else 'Not customizable
            Select Case _style 'Apply a highlight to the icon button
                Case ControlStyle.Solid
                    _btnIcon.BackColor = ColorEditor.Darken(UIAppearance.StyleColor, 10)
                    _btnIcon.IconColor = Color.White
                Case ControlStyle.Glass
                    _btnIcon.BackColor = UIAppearance.StyleColor
                    _btnIcon.IconColor = Color.White
                    BorderColor = UIAppearance.StyleColor
            End Select
        End If
    End Sub

    Private Sub DatePicker_CloseUp(ByVal sender As Object, ByVal e As EventArgs)
        'Occurs when the dropdown calendar closes
        _isDroppedDown = False

        If _customizable Then
            'Disable icon button highlighting.
            _btnIcon.BackColor = _backgroundColor
            _btnIcon.IconColor = _iconColor
            BorderColor = _borderColor
        Else
            ApplyAppearanceSettings() 'Refresh appearance to disable icon button highlighting.
        End If
    End Sub

    '// -> Attach events: Label -> UserControl
    Private Sub RJDatePicker_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Attach the click event of the user control (RJComboBox) to this click event of the label (dateText).
        Me.OnClick(e)
        '/ * This event method is subscribed to the click event of the label (remember that the label represents
        'most of the user control), so when the label is clicked,
        'the click event of the user control will be fired.
        'This scenario is the same as the default OnValueChanged event created. * /
    End Sub

    'Attach the other events in the same way.
    Private Sub RJDatePicker_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseEnter(e)
    End Sub

    Private Sub RJDatePicker_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyUp(e)
    End Sub

    Private Sub RJDatePicker_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Me.OnKeyPress(e)
    End Sub

    Private Sub RJDatePicker_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyDown(e)
    End Sub
    'You can keep adding the events you need
#End Region

#Region "-> Overridden methods"
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        'Load event
        _dateText.Text = _datePicker.Text 'Update the text of the user control.
        Me.Visible = False 'Hide the control while applying appearance settings, this prevents flickering when displaying the form.
        ApplyAppearanceSettings() 'Apply UI appearance settings
        SetDatePickerLocation() 'Update the location of datePicker
        Me.Visible = True
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        SetDatePickerLocation() 'Update the location of datePicker
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics

        ' GLASS style
        If _style = ControlStyle.Glass Then
            'Apply rounded corners (If applicable) to the region + anti-aliasing + edge drawing of the user control.
            RoundedControl.RegionAndBorder(Me, _borderRadius, graph, _borderColor, _borderSize)
            If _borderRadius > 1 Then 'If the radius is greater than 1, apply rounded corners to the label.
                RoundedControl.RegionOnly(_dateText, _borderRadius - _borderSize)

                If _isDroppedDown = True Then 'If the drop-down list is open, draw a fill in the button area to remove visible surface from the background, you can comment the code to understand what I mean.
                    Using brush As SolidBrush = New SolidBrush(_borderColor)
                        graph.SmoothingMode = SmoothingMode.AntiAlias
                        Dim rect = New Rectangle(_btnIcon.Left + 5, _btnIcon.Top + 0, _btnIcon.Width, Me.Height)
                        Dim path As GraphicsPath = RoundedControl.GetRoundedGPath(rect, _borderRadius - _borderSize)
                        graph.FillPath(New SolidBrush(_borderColor), path)
                    End Using
                End If
            End If
            ' SOLID style
        Else
            'Just apply rounded corners (If that's the case) to the user control's + anti-aliasing region.
            RoundedControl.RegionAndSmoothed(Me, _borderRadius, graph)
            If _borderRadius > 1 Then RoundedControl.RegionOnly(_dateText, _borderRadius - _borderSize) 'If the radius is greater than 1, apply rounded corners to the label.
        End If
    End Sub
#End Region
End Class
