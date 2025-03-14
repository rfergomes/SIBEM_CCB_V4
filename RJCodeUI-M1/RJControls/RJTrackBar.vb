Imports System.ComponentModel
Imports System.Runtime.InteropServices

Class RJTrackBar
    Inherits TrackBar

    ''' <summary>
    '''  This class inherits from the <TrackBar/>  class.
    '''  The OnPaint event is overridden, to draw the channel and the trackbar slider.
    '''  Based on the example of Hans Passant: https://stackoverflow.com/a/2714457/12778930        
    ''' </summary>

#Region "-> Fields"

    Private _customizable As Boolean 'Gets or sets whether the control color is customizable or the colors are set by appearance settings
    Private _showValue As Boolean 'Gets or sets whether to display the current value of the track bar
    Private _channelColor As Color 'Gets or sets the channel color of the trackbar
    Private _sliderColor As Color 'Gets or sets the color of the track bar slider
    Private _textColor As Color 'Gets or sets the color of the track bar text
    Private _trackerValue As Integer
    Private _textFont As Font
    Private _brushSlider As SolidBrush
    Private _brushChannel As SolidBrush
    Private _brushText As SolidBrush

    Private Const WM_USER As Integer = &H400 'Used to define private messages for use by private window classes, generally of the form WM_USER + X, like the following.
    Private Const TBM_GETCHANNELRECT As Integer = WM_USER + 26 'This message retrieves the size and position of the bounding rectangle of the slider on a track bar.
    Private Const TBM_GETTHUMBRECT As Integer = WM_USER + 25 'This message retrieves the size and position of the bounding rectangle of the slider on a track bar.

    Private Structure RECT 'The RECT structure defines the coordinates of the upper left and lower right corners of a rectangle.
        Public Left, Top, Right, Bottom As Integer
    End Structure
#End Region

#Region "-> Constructor"

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True) 'Set the UserPaint control style to true so that the control paints itself instead of the operating system.
        'Initialize objects.
        _textFont = New Font("Verdana", 8.0F, FontStyle.Regular)
        _brushSlider = New SolidBrush(Color.CornflowerBlue)
        _brushChannel = New SolidBrush(Color.LightGray)
        _brushText = New SolidBrush(Color.Gray)
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    Public Property Customizable As Boolean
        'Gets or sets whether the control color is customizable or the colors are set by appearance settings
        Get
            Return _customizable
        End Get
        Set(value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ChannelColor As Color
        'Gets or sets the channel color of the trackbar
        Get
            Return _channelColor
        End Get
        Set(value As Color)
            _channelColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property SliderColor As Color
        'Gets or sets the color of the track bar slider
        Get
            Return _sliderColor
        End Get
        Set(value As Color)
            _sliderColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property TextColor As Color
        'Gets or sets the color of the value label text.
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ShowValue As Boolean
        'Gets or sets whether to display the value label.
        Get
            Return _showValue
        End Get
        Set(value As Boolean)
            _showValue = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate()
        End Set
    End Property
#End Region

#Region "-> External methods"

    ''' <summary>
    ''' The SendMessage(IntPtr hWnd, int msg, IntPtr wParam, ref RECT lParam)/> method is an external function of the user.32 
    ''' library, this method Sends the specified message to a window or windows.
    ''' The SendMessage function calls the window procedure for the specified window and does not return until the window 
    ''' procedure has processed the message.
    ''' <param name="hWnd">A handle to the window whose window procedure will receive the message</param>
    ''' <param name="wParam">Additional message-specific information: Must be zero </param>
    ''' <param name="lParam">Additional message-specific information: ref RECT> Pointer to a RECT structure.
    ''' The message fills this structure with the bounding rectangle of the trackbar's slider in client coordinates
    ''' of the trackbar's window </param>
    ''' </summary>
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Function SendMessageRect(hWnd As IntPtr, msg As Integer, wParam As IntPtr, ByRef lParam As RECT) As IntPtr
    End Function
#End Region

#Region "-> Private methods"

    Private Function GetSlider() As Rectangle
        'Get the size and position of the slider
        Dim rect As RECT = New RECT()
        SendMessageRect(Me.Handle, TBM_GETTHUMBRECT, IntPtr.Zero, rect)
        Return New Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top)
    End Function

    Private Function GetChannel() As Rectangle
        'Get the size and position of the channel
        Dim rect As RECT = New RECT()
        SendMessageRect(Me.Handle, TBM_GETCHANNELRECT, IntPtr.Zero, rect)

        If Me.Orientation = Orientation.Horizontal Then 'Horizontal Orientation
            Return New Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top + 3)
        Else 'Vertical Orientation
            Return New Rectangle(rect.Left, rect.Top, rect.Bottom - rect.Top + 3, rect.Right - rect.Left)
        End If
    End Function

    Private Sub ApplyAppearanceSettings()
        'Load appearance settings
        If Customizable = False Then

            If UIAppearance.Theme = UITheme.Light Then
                ChannelColor = Color.LightGray
                SliderColor = UIAppearance.StyleColor
                TextColor = ColorEditor.Lighten(UIAppearance.TextColor, 25)
            Else
                ChannelColor = RJColors.DefaultFormBorderColor
                SliderColor = UIAppearance.StyleColor
                TextColor = ColorEditor.Darken(UIAppearance.TextColor, 7)
            End If
        End If
        'Load brushes
        _brushSlider.Color = SliderColor
        _brushChannel.Color = ChannelColor
        _brushText.Color = TextColor
    End Sub
#End Region

#Region "-> Overrides"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        'This event is equivalent to the load event
        MyBase.OnHandleCreated(e)
        _trackerValue = Me.Value 'Set current value.
        ApplyAppearanceSettings() 'apply appearance settings.
    End Sub

    Protected Overrides Sub OnValueChanged(e As EventArgs)
        'This event occurs when the value of the track bar changes
        MyBase.OnValueChanged(e)
        _trackerValue = Me.Value 'Set current value.
        Me.Invalidate(False) 'Redraw control (invoke Paint event)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim channel = GetChannel() 'Get channel size and position
        Dim slider = GetSlider() 'Get the size and position of the slider

        e.Graphics.FillRectangle(_brushChannel, channel) 'Draw the channel of the tracking bar with the specified color and the size and position obtained.
        e.Graphics.FillRectangle(_brushSlider, slider) 'Draw the trackbar slider with the specified color and the obtained size and position.

        If ShowValue = True Then 'Draw the text with the current value of the track bar

            If Me.Orientation = Orientation.Horizontal Then 'Horizontal Orientation

                If _trackerValue >= 100 Then
                    e.Graphics.DrawString(_trackerValue.ToString(), _textFont, _brushText, slider.Left - 6, 21)
                Else
                    e.Graphics.DrawString(_trackerValue.ToString(), _textFont, _brushText, slider.Left, 21)
                End If

            Else 'Vertical Orientation
                e.Graphics.DrawString(_trackerValue.ToString(), _textFont, _brushText, 21, slider.Top)
                'Me.Value.ToString () will not work in this scenario, therefore the trackerValue field is created.
            End If
        End If
        'Note: font and brush objects are initialized in the constructor, as instantiating the objects here 
        'in this paint event Visual Studio 2012 stopped responding, for some reason it was unwise to create objects
        'at all times, in fact this paint The event runs a lot On the scroll event (default)
        'and in the valueChanged event, Manually invoked (Invalidate (false)) to force the text to be drawn,
        'If you don't want to draw the text, you don't need to call the Invalidate () method in the ValueChanged event.
    End Sub
#End Region

End Class
