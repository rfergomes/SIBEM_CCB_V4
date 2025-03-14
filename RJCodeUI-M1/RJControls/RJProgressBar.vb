Imports System.ComponentModel

Public Class RJProgressBar
    Inherits ProgressBar
    'Tutorial guide: https://youtu.be/Sj_b3yOUQDk

#Region "-> Fields"
    '// -> Appearance
    Private _channelColor As Color = Color.LightSteelBlue 'Get or set the color of the channel.
    Private _sliderColor As Color = Color.RoyalBlue 'Gets or sets the color of the slider or indicator.
    Private _foreBackColor As Color = Color.RoyalBlue 'Gets or sets the background color of the value text.
    Private _channelHeight As Integer = 6 'Get or set the height of the channel.
    Private _sliderHeight As Integer = 6 'Gets or sets the height of the slider.
    Private _showValue As TextPosition = TextPosition.Right 'Gets or sets the text position of the value.
    Private _symbolBefore As String = "" 'Gets or sets a token or text before the value text.
    Private _symbolAfter As String = "" 'Gets or sets a symbol or text after the value text.
    Private _showMaximun As Boolean = False 'Gets or stable if the maximum value is displayed.
    Private _customizable As Boolean = True 'Gets or stable if colors are customizable, or set by appearance settings.

    '// -> Others
    Private _paintedBack As Boolean = False 'Get or set whether background color has been painted.
    Private _stopPainting As Boolean = False 'Gets or stable if the painting should stop painting.
#End Region

#Region "-> Constructor"
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.ForeColor = Color.White
    End Sub
#End Region

#Region "-> Properties"
    <Category("RJ Code Advance")>
    Public Property Customizable As Boolean
        Get
            Return _customizable
        End Get
        Set(ByVal value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ChannelColor As Color
        Get
            Return _channelColor
        End Get
        Set(ByVal value As Color)
            _channelColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property SliderColor As Color
        Get
            Return _sliderColor
        End Get
        Set(ByVal value As Color)
            _sliderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ForeBackColor As Color
        Get
            Return _foreBackColor
        End Get
        Set(ByVal value As Color)
            _foreBackColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ChannelHeight As Integer
        Get
            Return _channelHeight
        End Get
        Set(ByVal value As Integer)
            _channelHeight = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property SliderHeight As Integer
        Get
            Return _sliderHeight
        End Get
        Set(ByVal value As Integer)
            _sliderHeight = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ShowValue As TextPosition
        Get
            Return _showValue
        End Get
        Set(ByVal value As TextPosition)
            _showValue = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property SymbolBefore As String
        Get
            Return _symbolBefore
        End Get
        Set(ByVal value As String)
            _symbolBefore = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property SymbolAfter As String
        Get
            Return _symbolAfter
        End Get
        Set(ByVal value As String)
            _symbolAfter = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ShowMaximun As Boolean
        Get
            Return _showMaximun
        End Get
        Set(ByVal value As Boolean)
            _showMaximun = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Browsable(True)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
        End Set
    End Property
#End Region

#Region "-> Methods overridden"
    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        ApplyAppearanceSettings()
        AddHandler Me.Parent.Paint, (AddressOf ParentContainer_RePaint)
    End Sub

    Private Sub ParentContainer_RePaint(ByVal sender As Object, ByVal e As PaintEventArgs)
        'If the container (Form or control) of the control is repainted,
        'For example, when the form is scrolled, restart the painting of the control.
        _stopPainting = False
        _paintedBack = False
    End Sub

    '// -> Paint the background and channel of the control.
    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        If _stopPainting = False Then
            If _paintedBack = False Then
                '// Fields
                Dim graph As Graphics = pevent.Graphics
                Dim rectChannel As Rectangle = New Rectangle(0, 0, Me.Width, ChannelHeight)
                Using brushChannel = New SolidBrush(_channelColor)
                    If _channelHeight >= _sliderHeight Then
                        rectChannel.Y = Me.Height - _channelHeight
                    Else
                        rectChannel.Y = Me.Height - ((_channelHeight + _sliderHeight) / 2)
                    End If

                    '//Painting
                    graph.Clear(Me.Parent.BackColor) 'Paint the surface / background of the control
                    graph.FillRectangle(brushChannel, rectChannel) 'paint control channel
                    'Stop painting the bottom and channel, with this condition the bottom and channel is only painted once, that is to avoid flickering.
                    If Me.DesignMode = False Then _paintedBack = True
                End Using
            End If
            'Restart the painting of the bottom and channel, as long as the value reaches the maximum or minimum value.
            If Me.Value = Me.Maximum OrElse Me.Value = Me.Minimum Then
                _paintedBack = False
            End If

        End If
    End Sub

    '// -> Paint the slider or indicator.
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If _stopPainting = False Then
            '// Fields
            Dim graph As Graphics = e.Graphics
            Dim scaleFactor As Double = ((CDbl(Me.Value) - Me.Minimum) / (CDbl(Me.Maximum) - Me.Minimum))
            Dim sliderWidth As Integer = CInt((Me.Width * scaleFactor))
            Dim rectSlider As Rectangle = New Rectangle(0, 0, sliderWidth, _sliderHeight)
            Using brushSlider = New SolidBrush(_sliderColor)
                If _sliderHeight >= _channelHeight Then
                    rectSlider.Y = Me.Height - _sliderHeight
                Else
                    rectSlider.Y = Me.Height - ((_sliderHeight + _channelHeight) / 2)
                End If
                '  //Painting
                If sliderWidth > 1 Then graph.FillRectangle(brushSlider, rectSlider) 'Paint the slider
                If _showValue <> TextPosition.None Then DrawValueText(graph, sliderWidth, rectSlider) 'Draw the text of the value.
            End Using
        End If

        If Me.Value = Me.Maximum Then 'Stop painting if the value reaches the maximum value
            _stopPainting = True
        Else 'Otherwise, continue painting.
            _stopPainting = False
        End If
    End Sub
#End Region

#Region "-> Private methods"
    '// -> Paint the text of the value.
    Private Sub DrawValueText(ByVal graph As Graphics, ByVal sliderWidth As Integer, ByVal rectSlider As Rectangle)
        'Fields
        Dim text As String = _symbolBefore & Me.Value.ToString() & _symbolAfter
        If _showMaximun Then text = text & "/" & _symbolBefore & Me.Maximum.ToString() & _symbolAfter
        Dim textSize = TextRenderer.MeasureText(text, Me.Font)
        Dim rectText = New Rectangle(0, 0, textSize.Width, textSize.Height + 2)
        Using brushText = New SolidBrush(Me.ForeColor)
            Using brushTextBack = New SolidBrush(_foreBackColor)
                Using textFormat = New StringFormat()

                    Select Case _showValue
                        Case TextPosition.Left
                            rectText.X = 0
                            textFormat.Alignment = StringAlignment.Near
                        Case TextPosition.Right
                            rectText.X = Me.Width - textSize.Width
                            textFormat.Alignment = StringAlignment.Far
                        Case TextPosition.Center
                            rectText.X = (Me.Width - textSize.Width) / 2
                            textFormat.Alignment = StringAlignment.Center
                        Case TextPosition.Sliding
                            rectText.X = sliderWidth - textSize.Width
                            textFormat.Alignment = StringAlignment.Center
                            'Clean the front surface of the text.
                            Using brushClear = New SolidBrush(Me.Parent.BackColor)
                                Dim rect = rectSlider
                                rect.Y = rectText.Y
                                rect.Height = rectText.Height
                                graph.FillRectangle(brushClear, rect)
                            End Using
                    End Select
                    'Painting
                    graph.FillRectangle(brushTextBack, rectText) 'Paint the background of the text.
                    graph.DrawString(text, Me.Font, brushText, rectText, textFormat) 'Draw the text.
                End Using
            End Using
        End Using
    End Sub

    Private Sub ApplyAppearanceSettings()
        If _customizable = False Then 'If not customizable, apply appearance color settings.
            _foreBackColor = UIAppearance.StyleColor
            SliderColor = UIAppearance.StyleColor

            If UIAppearance.Theme = UITheme.Dark Then
                _channelColor = ColorEditor.Lighten(UIAppearance.ItemBackgroundColor, 5)
            Else
                _channelColor = ColorEditor.Darken(UIAppearance.BackgroundColor, 15)
            End If
        End If
    End Sub
#End Region

End Class
