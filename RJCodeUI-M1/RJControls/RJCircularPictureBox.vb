Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RJCircularPictureBox
    Inherits PictureBox

    '''<summary>
    '''This class inherits from the <see cref = "PictureBox" /> class
    '''This custom control creates a circular picture box, where you can change the border size,
    '''border color, line style, cap style, enable border gradient color,
    '''and finally set the angle of the gradient.
    '''Tutorial guide: https://youtu.be/54347QjDisA
    '''</summary>
    '''

#Region "-> Fields"
    Private _borderSize As Integer = 2 'Get or set the border size
    Private _borderColor As Color = Color.RoyalBlue 'Gets or sets the border color.
    Private _borderColor2 As Color = Color.HotPink 'Gets or sets the second border color to apply a gradient color.
    Private _borderLineStyle As DashStyle = DashStyle.Solid 'Gets or sets the border line style.
    Private _borderCapStyle As DashCap = DashCap.Flat 'Gets or sets the border cap style to the dash style (Dash).
    Private _gradientColor As Boolean = False 'Gets or stable if the border color is gradient.
    Private _gradientAngle As Single = 50.0F 'Gets or sets the angle of the gradient.
    Private _customizable As Boolean = True 'Gets or stable if the border color is customizable, or the color is equal to the color set in the appearance settings.
#End Region

#Region "-> Constructor"
    Public Sub New()
        Me.Size = New Size(100, 100)
        Me.SizeMode = PictureBoxSizeMode.StretchImage
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
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
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
    Public Property BorderColor2 As Color
        Get
            Return _borderColor2
        End Get
        Set(ByVal value As Color)
            _borderColor2 = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderLineStyle As DashStyle
        Get
            Return _borderLineStyle
        End Get
        Set(ByVal value As DashStyle)
            _borderLineStyle = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderCapStyle As DashCap
        Get
            Return _borderCapStyle
        End Get
        Set(ByVal value As DashCap)
            _borderCapStyle = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property GradientColor As Boolean
        Get
            Return _gradientColor
        End Get
        Set(ByVal value As Boolean)
            _gradientColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property GradientAngle As Single
        Get
            Return _gradientAngle
        End Get
        Set(ByVal value As Single)
            _gradientAngle = value
            Me.Invalidate()
        End Set
    End Property
#End Region

#Region "-> Private methods"
    Private Sub ApplyAppearanceSettings()
        'If not customizable, apply appearance color settings.
        If Customizable = False Then
            _borderColor = UIAppearance.StyleColor
            _borderColor2 = UIAppearance.PrimaryStyleColor
        End If
    End Sub
#End Region

#Region "-> Methods overridden"
    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        ApplyAppearanceSettings() 'Apply UI appearance settings
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        'Set the same value for the width and height of the size so that the control has a perfect circular shape.
        Me.Size = New Size(Me.Width, Me.Width)
    End Sub

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        'Fields
        Dim graph = pe.Graphics ' Graphics object.
        Dim rectContourSmooth = Rectangle.Inflate(Me.ClientRectangle, -1, -1) 'Rectangle for the dimensions of the contour smoothing and rounded region of the control.
        Dim rectBorder = Rectangle.Inflate(rectContourSmooth, -BorderSize, -BorderSize) 'Rectangle for border dimensions.
        Dim rectBorderSmooth = RectangleF.Inflate(rectBorder, 0.5F, 0.5F)
        Dim smoothSize = If(BorderSize > 0, BorderSize, 1) 'Smooth size, If the border size is greater than 0, the smooth size is equal to the border size, otherwise the value is 1.
        Using pathRegion = New GraphicsPath() 'Graphics path object for the control region.
            Using penSmooth = New Pen(Me.Parent.BackColor, smoothSize) 'Pen object to draw contour smoothing.
                Using penBorder = New Pen(BorderColor, BorderSize) 'Pen object to draw the border of the control.
                    graph.SmoothingMode = SmoothingMode.AntiAlias ' Set the smoothing mode of the graphics object.
                    penBorder.DashStyle = BorderLineStyle 'Set the border line style.
                    penBorder.DashCap = BorderCapStyle 'Set the cap style of the line (Dash or Period).
                    pathRegion.AddEllipse(rectContourSmooth) 'Add an ellipse in the path of the region with the dimensions of the rectangle defined above.
                    'Set the rounded region of the control.
                    Me.Region = New Region(pathRegion)
                    'He drew
                    graph.DrawEllipse(penSmooth, rectContourSmooth) 'Draw the contour smoothing.
                    If BorderSize > 0 Then
                        graph.DrawEllipse(penSmooth, rectBorderSmooth) 'Draw the border smoothing
                        If GradientColor Then 'Draw the gradient color border.
                            Using bGradientColor = New LinearGradientBrush(rectBorder, BorderColor, BorderColor2, GradientAngle)
                                penBorder.Brush = bGradientColor
                                graph.DrawEllipse(penBorder, rectBorder)
                            End Using
                        Else 'Draw solid color border, single color.
                            graph.DrawEllipse(penBorder, rectBorder)
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub
#End Region

End Class
