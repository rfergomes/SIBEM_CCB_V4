Imports System.ComponentModel

Public Class RJImageColorOverlay
    Inherits Panel

    ''' <summary>
    ''' This class enherits from the <Panel/> class 
    ''' This control incorporates the function of overlay color to images. This means that you cover 
    ''' an image with a semi-transparent color box. This method is very popular on websites because
    ''' it improves the appearance considerably and the elements on it are more readable, so I decided 
    ''' to make one for windows forms.
    ''' 
    ''' the trick here is to draw a box with a semi-transparent color (you can set opacity) on the panel
    ''' with an image background.To get a semi-transparent color, set the alpha color component.
    ''' In Windows, the alpha component is a number between 0 (fully transparent) and 255 (fully opaque).
    ''' </summary>
    ''' 

#Region "-> Fields"

    Private _opacity As Integer 'Set or get opacity (percentage of transparency, 0 = fully transparent and 100 fully opaque / solid)
    Private _alpha As Integer 'Sets or gets the value of the alpha parameter
    Private _overlayColor As Color 'Sets or gets the overlay color
    Private _borderRadius As Integer 'Sets or gets the border radius
    Private _customizable As Boolean 'Sets or gets whether the control's appearance color is customizable.
#End Region

#Region "-> Constructor"

    Public Sub New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True) 'Set control styles to avoid flickering
        Me.BackgroundImage = My.Resources.userProfile 'Set default image
        Me.BackgroundImageLayout = ImageLayout.Stretch 'Set the default image layout
        Opacity = 50 'Set a default opacity of 50%
        OverlayColor = Color.MediumSlateBlue 'Set the default overlay color
        Me.TabStop = False
        Me.Size = New Size(250, 250)
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    Public Property Customizable As Boolean
        Get
            Return _customizable
        End Get
        Set(value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Opacity As Integer
        'Set or get opacity (percentage of transparency, 0 = fully transparent and 100 fully opaque / solid)
        Get
            Return _opacity
        End Get
        Set(value As Integer)
            If value > 0 OrElse value < 100 Then
                _opacity = value 'Set value
                _alpha = Convert.ToInt32(_opacity / 100.0R * 255) 'Convert the opacity value to a valid alpha value for windows.
                'Alpha = Opacity / 100% * 255 (On Windows, the maximum alpha value is 255, which is completely opaque)
                'The suffix D is of type double which would be equal to 100.00 or (double) 100.
                If Me.DesignMode Then Me.Invalidate(False) 'Redraw control to apply changes (invokes OnPaint event) -> preview in design mode
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OverlayColor As Color
        'Set or get the overlay color
        Get
            Return _overlayColor
        End Get
        Set(value As Color)
            _overlayColor = value 'Set value
            If Me.DesignMode Then Me.Invalidate(False) 'Redraw control to apply changes (invokes OnPaint event) -> preview in design mode
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Image As Image
        'Set or get the background image
        Get
            Return Me.BackgroundImage
        End Get
        Set(value As Image)
            Me.BackgroundImage = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ImageMode As ImageLayout
        'Set or get the image layout
        Get
            Return Me.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            Me.BackgroundImageLayout = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Set or get the edge radius")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)
            _borderRadius = value
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        If _customizable = False Then
            _overlayColor = UIAppearance.StyleColor
        End If
    End Sub
#End Region

#Region "-> Overridden methods"

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        ApplyAppearanceSettings()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        'Occurs when the control is redrawn
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics
        'Create a solid color brush object from the overlay color parameter and the opacity set in the alpha parameter
        Using brush = New SolidBrush(Color.FromArgb(_alpha, _overlayColor))
            graph.FillRectangle(brush, Me.ClientRectangle) 'Fill the inside of the panel with the solid brush created
            'Basically draw a transparent colored rectangle (based on the alpha value defined by opacity) on the panel.
            RoundedControl.RegionAndSmoothed(Me, BorderRadius, graph) 'Apply Rounded Corners + Edge Smoothing.
        End Using
    End Sub
#End Region

End Class

