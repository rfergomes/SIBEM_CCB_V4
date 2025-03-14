Imports System.ComponentModel

'Default event when double click on control in designer
<DefaultEvent("OnTextChange")>
Public Class RJTextBox
    Inherits UserControl

    ''' <summary>
    ''' This class inherits from the <UserControl/> class
    ''' This custom text box allows you to change 2 main styles, with a 
    ''' border around it or single border at the bottom (underlined).
    ''' It also allows adding a watermark (Place Holder) and setting if
    ''' it is a password field. In addition to customizing the border color 
    ''' and size, background color, text color, and placeholder text color, 
    ''' border radius and among others.
    ''' Tutorial guia (Parte 1): https://youtu.be/CkpUQYzYCC8
    ''' Tutorial guia (Parte 2): https://youtu.be/3wP6QqjiCCo
    ''' </summary>
    ''' 

#Region "-> Fields"

    Private _style As TextBoxStyle 'Gets or sets the style of the text box (MatteBorder, FlaringBorder, MatteLine, or FlaringLine)
    Private _placeHolderColor As Color 'Gets or sets the color of the placeholder text
    Private _borderColor As Color 'Gets or sets the border color.
    Private _borderFocusColor As Color = Color.Black 'Gets or sets the border color in focused state
    Private _borderSize As Integer = 2 'Gets or sets the width of the border.
    Private _borderRadius As Integer = 0 'Gets or sets the border radius.
    Private _maxLength As Integer = 32767 'Gets or sets the maximum number of characters in the text box.
    Private _placeHolderText As String 'Gets or sets the placeholder text.
    Private _isPlaceHolder As Boolean 'Gets or sets whether the text box is in placeholder state.
    Private _isPasswordChar As Boolean 'Gets or sets whether it is a password character or a password field.
    Private __customizable As Boolean 'Gets or sets whether the control's colors are customizable or mapped based on appearance settings
    Private Shared _padFactor As Integer = 7 'Sets the value for padding (Padding: Top | Bottom)
    'Controls
    Private textBox As TextBox 'Set or get the text box
#End Region

#Region "-> Events"

    <Category("RJ Code Advance")>
    Public Event OnTextChange As EventHandler 'Default event of RJTextBox
#End Region

#Region "-> Constructor"

    Public Sub New()
        Me.DoubleBuffered = True
        textBox = New TextBox()
        Me.SuspendLayout()
        '
        'TextBox: (Occupies most of the RJTextBox user control)
        '
        textBox.Location = New Point(2, 3)
        textBox.Dock = DockStyle.Fill
        textBox.BackColor = UIAppearance.BackgroundColor
        textBox.BorderStyle = BorderStyle.None
        textBox.Size = New System.Drawing.Size(230, 16)
        AddHandler textBox.Enter, AddressOf Me.TextBox_Enter 'Subscribe to the Enter event of the TextBox to highlight and remove the placeholder if it is the case.
        AddHandler textBox.Leave, AddressOf Me.TextBox_Leave 'subscribe to the Leave event of the TextBox to remove the highlighting and reset the placeholder if this is the case.
        AddHandler textBox.TextChanged, AddressOf Me.TextBox_TextChanged 'Subscribe to the control's TextChanged event and attach it to the previously defined OnTextChanged default event (see method definition).
        '/ * The textBox control takes up most of the user control, therefore
        'It is necessary to attach the events that occur in the text box (textBox) to the events of the user control (RJTextBox),
        'That is, for example in the Click event, when the text box is clicked, the click event of the user control (RJTextBox) must also be executed.
        'See the definition of the event methods to understand better. * /
        AddHandler textBox.Click, AddressOf Me.RJTextBox_Click
        AddHandler textBox.KeyDown, AddressOf Me.RJTextBox_KeyDown
        AddHandler textBox.KeyPress, AddressOf Me.RJTextBox_KeyPress
        AddHandler textBox.KeyUp, AddressOf Me.RJTextBox_KeyUp
        AddHandler textBox.MouseEnter, AddressOf Me.RJTextBox_MouseEnter
        'You can keep attaching the events you want, if it doesn't exist you can create it like you did with the onTextChanged event

        '
        'UserControl: RJTextBox
        '
        Me.Controls.Add(textBox) 'Add the textBox control
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.None
        Me.BackColor = UIAppearance.StyleColor
        Me.Padding = New Padding(10, _padFactor, 10, _padFactor)
        Me.Size = New System.Drawing.Size(250, 32)
        Me.Font = New Font(UIAppearance.TextFamilyName, UIAppearance.TextSize)
        Me.ForeColor = UIAppearance.TextColor
        Me.ResumeLayout(False)
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    <Description("Gets or sets the style of the text")>
    Public Property Style As TextBoxStyle
        Get
            Return _style
        End Get
        Set(ByVal value As TextBoxStyle)
            _style = value

            If Me.DesignMode Then 'Preview changes in design mode
                ApplyAppearanceSettings()
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets whether the colors of the control are customizable or assigned based on appearance settings")>
    Public Property _Customizable As Boolean
        Get
            Return __customizable
        End Get
        Set(ByVal value As Boolean)
            __customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the background color")>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            Me.textBox.BackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the border color")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the border color in focused state")>
    Public Property BorderFocusColor As Color
        Get
            Return _borderFocusColor
        End Get
        Set(ByVal value As Color)
            _borderFocusColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the width of the border")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)

            If value > 0 OrElse value < 5 Then
                _borderSize = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the radius of the corners of the control")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)

            If value >= 0 Then
                _borderRadius = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Get or set the text color")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            textBox.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets whether it is a password character or a password field")>
    Public Property PasswordChar As Boolean
        Get
            Return _isPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _isPasswordChar = value
            If Not _isPlaceHolder Then textBox.UseSystemPasswordChar = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets if multiline")>
    Public Property MultiLine As Boolean
        Get
            Return Me.textBox.Multiline
        End Get
        Set(ByVal value As Boolean)
            Me.textBox.Multiline = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the color of the placeholder text")>
    Public Property PlaceHolderColor As Color
        Get
            Return _placeHolderColor
        End Get
        Set(ByVal value As Color)
            _placeHolderColor = value
            If _isPlaceHolder Then textBox.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the placeholder text")>
    Public Property PlaceHolderText As String
        Get
            Return _placeHolderText
        End Get
        Set(ByVal value As String)
            _placeHolderText = value
            textBox.Text = "" 'Set Blank Text in Text Box
            SetPlaceholder() 'Set the placeholder to the text box.
        End Set
    End Property

    <Category("RJ Code Advance")>
    <DefaultValue(32767)>
    <Description("Get or set the maximum number of characters in the text box.")>
    Public Property MaxLength As Integer
        Get
            Return _maxLength
        End Get
        Set(ByVal value As Integer)
            _maxLength = value
            textBox.MaxLength = _maxLength
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Get or set the font")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            textBox.Font = value
            If Me.DesignMode Then UpdateControlHeight() 'Set an appropriate height of the user control and textBox.
        End Set
    End Property

    <Description("Gets or sets the text in the text box")>
    Public Overloads Property Text As String
        Get
            If _isPlaceHolder Then 'If the textbox is a placeholder, Return an empty string
                Return ""
            Else 'Otherwise return the text
                Return textBox.Text
            End If
        End Get
        Set(ByVal value As String)
            RemovePlaceHolder() 'remove placeholder if it is the case.
            textBox.Text = value
            SetPlaceholder() 'Set placeholder if it is the case.
        End Set
    End Property

    <Localizable(True)>
    <Category("RJ Code Advance")>
    <Description("Get or set scroll bars - should only be used when multiline")>
    Public Property ScrollBars As ScrollBars
        Get
            Return textBox.ScrollBars
        End Get
        Set(ByVal value As ScrollBars)
            textBox.ScrollBars = value
        End Set
    End Property

    <Browsable(False)>
    <Description("Override the Padding property to set a unique value")>
    Public Overloads Property Padding As Padding
        Get
            Return MyBase.Padding
        End Get
        Set(ByVal value As Padding)
            MyBase.Padding = New Padding(10, _padFactor, 10, _padFactor)
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub SetPlaceholder()
        'Set placeholder in text box whenever text box is empty or null.
        If String.IsNullOrWhiteSpace(textBox.Text) AndAlso String.IsNullOrWhiteSpace(_placeHolderText) = False Then
            _isPlaceHolder = True 'Set textbox to placeholder state.
            textBox.Text = _placeHolderText 'Set the placeholder text to text box text.
            textBox.ForeColor = _placeHolderColor 'Set the color of the placeholder text.
            If _isPasswordChar Then textBox.UseSystemPasswordChar = False 'If it is a password field, remove the password character to display the placeholder text.
        Else
            _isPlaceHolder = False
            textBox.ForeColor = Me.ForeColor
        End If
    End Sub

    Private Sub RemovePlaceHolder()
        'This method takes care of removing the placeholder.
        If _isPlaceHolder AndAlso String.IsNullOrWhiteSpace(_placeHolderText) = False Then
            _isPlaceHolder = False 'remove placeholder state from text box
            textBox.Text = "" 'Empty text
            If _Customizable Then 'If customizable, set the specified text color
                textBox.ForeColor = Me.ForeColor
            Else 'Otherwise set text color specified in appearance settings
                textBox.ForeColor = UIAppearance.PrimaryTextColor
            End If
            'If it is a password field, reset the password character to mask the characters.
            If _isPasswordChar Then textBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub UpdateControlHeight()
        'This method takes care of setting a suitable height for the user control (RJTextBox) and textbox (textBox),
        'This to fully display the text and have a considerable halt in user control.
        If MultiLine = False Then
            Dim txtHeight As Integer = TextRenderer.MeasureText("Text", Me.Font).Height + 1 'Get the height of the text and add 1.
            textBox.Multiline = True
            textBox.MinimumSize = New Size(0, txtHeight) 'Set the minimum height of the text box.
            textBox.Multiline = False
            Me.Height = textBox.Height + (_padFactor * 2) 'Set the height of the user control.
        End If
    End Sub

    Private Sub ValidateControlRadius()
        'This method validates if the radius has a maximum allowed value. The maximum radius is half the height of the user control.
        Dim maxRadius As Integer = Me.Height / 2
        If _borderRadius > maxRadius Then _borderRadius = maxRadius
    End Sub

    Private Sub ApplyAppearanceSettings()
        If _Customizable = False Then
            BackColor = UIAppearance.BackgroundColor
            Me.ForeColor = UIAppearance.PrimaryTextColor
            BorderFocusColor = ColorEditor.Lighten(UIAppearance.StyleColor, 15)

            If UIAppearance.Theme = UITheme.Dark Then
                PlaceHolderColor = ColorEditor.Darken(UIAppearance.TextColor, 5)
            Else
                PlaceHolderColor = Color.DarkGray
            End If

            If _style = TextBoxStyle.MatteBorder OrElse _style = TextBoxStyle.MatteLine Then

                If UIAppearance.Theme = UITheme.Dark Then
                    BorderColor = ColorEditor.Darken(UIAppearance.TextColor, 10)
                Else
                    BorderColor = UIAppearance.TextColor
                End If
            Else
                BorderColor = UIAppearance.StyleColor
            End If
        End If
    End Sub
#End Region

#Region "-> Public methods"

    Public Sub Clear()
        Text = String.Empty
    End Sub
#End Region

#Region "-> Event methods"
    '// -> Default event
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Attach the default event onTextChanged of the user control (RJTextBox)
        'to the TextChanged event of the text box (textBox).
        RaiseEvent OnTextChange(sender, e)
    End Sub

    '// -> Component actions
    Private Sub TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs)
        'when the cursor enters the textbox, remove the placeholder if it is the case
        'and highlight the border
        Me.Invalidate()
        RemovePlaceHolder()
    End Sub

    Private Sub TextBox_Leave(ByVal sender As Object, ByVal e As EventArgs)
        'when the cursor leaves the text box, reset the placeholder if it is the case and reset the border color
        Me.Invalidate()
        SetPlaceholder()
    End Sub

    '// -> Attach events: TextBox -> UserControl
    Private Sub RJTextBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Attach the click event of the user control (RJTextBox) to this click event of the text box (textBox).
        Me.OnClick(e)
        '/ * This event method is subscribed to the click event of the textbox, remember it represents
        'most of the user control, so when the textbox is clicked,
        'the click event of the user control will be fired.
        'This scenario is the same as the default onTextChanged event created. * /
    End Sub

    Private Sub RJTextBox_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseEnter(e)
    End Sub

    Private Sub RJTextBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyUp(e)
    End Sub

    Private Sub RJTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Me.OnKeyPress(e)
    End Sub

    Private Sub RJTextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyDown(e)
    End Sub
    'You can keep adding the events you need
#End Region

#Region "-> Overridden methods"

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics
        Dim currentBorderColor As Color

        'Set the current border color, that is, border color in focus or not.
        If textBox.Focused Then
            currentBorderColor = _borderFocusColor
        Else
            currentBorderColor = _borderColor
        End If
        'Draw rectangular border in MatteBorder or FlaringBorder style
        If _style = TextBoxStyle.MatteBorder OrElse _style = TextBoxStyle.FlaringBorder Then
            '// -> Apply rounded corners to user control-> REGION + SMOOTHING + BORDER
            RoundedControl.RegionAndBorder(Me, _borderRadius, graph, currentBorderColor, _borderSize)
            '// -> Apply rounded corners to textbox-> REGION ONLY
            If _borderRadius > 15 Then 'The radius border must be greater than 15, because if it is less it is not necessary to apply a rounded region.

                If Not MultiLine Then 'If not multiline the border radius is equal to twice the border size
                    RoundedControl.RegionOnly(textBox, _borderSize * 2)
                Else 'Otherwise, the border radius is at the set value minus
                    RoundedControl.RegionOnly(textBox, _borderRadius - (_borderSize * 2))
                End If
            End If
        Else
            '// Draw underlined border in MatteLine or FlaringLine style
            Using penBorder As Pen = New Pen(currentBorderColor, _borderSize)
                '// -> Apply rounded corners to user control-> REGION + SMOOTHING
                RoundedControl.RegionAndSmoothed(Me, _borderRadius, graph)
                '// Draw a line at the bottom without smoothing.
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
                graph.DrawLine(penBorder, 0, Me.Height - 1.0F, Me.Width, Me.Height - 1.0F)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        If Me.DesignMode Then UpdateControlHeight()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        ApplyAppearanceSettings()
        UpdateControlHeight()
        ValidateControlRadius()
    End Sub

#End Region

End Class
