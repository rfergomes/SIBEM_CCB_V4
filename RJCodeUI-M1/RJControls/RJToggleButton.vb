Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RJToggleButton
    Inherits CheckBox

    '' <summary>
    '' This class enherits from <CheckBox/> class.
    '' This control completely overrides the paint event and a new ToggleButton control
    '' design is drawn with the colors assigned in the appearance settings, allows to
    '' change the style to solid or glass.
    '' 
    '' The drawings occur in the following order:
    ''     1.- The background of the control surface is drawn.       
    ''     2.- The border(glass style) or background (solid style) of the toggle button is drawn.
    ''     3.- The toggle button lever is drawn (ON or OFF).
    ''     4.- The text is drawn.
    ''     
    '' It exposes all the functionalities (properties, methods and events of the checkbox control)
    '' and new properties are added to customize the activation lever control.
    '' Tutorial guide: https://www.youtube.com/watch?v=m7Iv6xfjnuw&t
    '' </summary>
    '' 

#Region "-> Fields"

    Private _style As ControlStyle 'Gets or sets the CheckBox style (Glass or Solid)
    Private _onBackBorderColor As Color 'Gets or sets the background or border color in the on state.
    Private _onToggleColor As Color 'Gets or sets the toggle color in the on state.
    Private _onTextColor As Color 'Gets or sets the toggle color in the on state.
    Private _onText As String 'Gets or sets the text in the on state.
    Private _offBackBorderColor As Color 'Gets or sets the background or border color in the off state.
    Private _offToggleColor As Color 'Gets or sets the toggle color in the off state.
    Private _offTextColor As Color 'Gets or sets the color of the text in the off state.
    Private _offText As String 'Gets or sets the text in the off state.
    Private _customizable As Boolean 'Gets or sets whether the control color is customizable or the colors are set based on appearance settings
#End Region

#Region "-> Constructor"

    Public Sub New()
        Me.MinimumSize = New Size(50, 25) 'Set minimum size
        Activated = True 'Set initial value

        _onBackBorderColor = Color.MediumSlateBlue
        _onToggleColor = Color.White
        _onTextColor = Color.White
        _offBackBorderColor = Color.LightGray
        _offToggleColor = Color.Gray
        _offTextColor = Color.Gray

        Style = ControlStyle.Glass
    End Sub
#End Region

#Region "-> Properties"

    'Override text property
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = "#"
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ON_Text As String
        'Gets or sets the text for the on state
        Get
            Return _onText
        End Get
        Set(value As String)
            _onText = value
            If Me.DesignMode Then 'Preview changes in design mode
                Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
            End If

        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OFF_Text As String
        'Gets or sets the text for the disabled state
        Get
            Return _offText
        End Get
        Set(value As String)
            _offText = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Style As ControlStyle
        'Sets or gets the toggle button style (glass or solid)
        Get
            Return _style
        End Get
        Set(value As ControlStyle)
            _style = value 'Set value

            'Preview changes in design mode
            If Me.DesignMode Then
                ApplyAppearanceSettings() 'Update appearance settings.
                Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Activated As Boolean
        'sets or gets whether the toggle button is on or off.
        'this value is determined by the checked property of the checkbox
        'since they both have a single value: Checked or UnChecked - ON or OFF = true or false.
        Get
            Return Me.Checked
        End Get
        Set(value As Boolean)
            Me.Checked = value
        End Set
    End Property

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
    Public Property ON_BackBorderColor As Color
        'Gets or sets the background or border color of the on state.
        Get
            Return _onBackBorderColor
        End Get
        Set(value As Color)
            _onBackBorderColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ON_ToggleColor As Color
        'Gets or sets the toggle color for the on state.
        Get
            Return _onToggleColor
        End Get
        Set(value As Color)
            _onToggleColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ON_TextColor As Color
        'Gets or sets the text color of the on state.
        Get
            Return _onTextColor
        End Get
        Set(value As Color)
            _onTextColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OFF_BackBorderColor As Color
        'Gets or sets the background or border color for the disabled state.
        Get
            Return _offBackBorderColor
        End Get
        Set(value As Color)
            _offBackBorderColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OFF_ToggleColor As Color
        'Gets or sets the toggle color for the off state.
        Get
            Return _offToggleColor
        End Get
        Set(value As Color)
            _offToggleColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OFF_TextColor As Color
        'Gets or sets the text color for the disabled state.
        Get
            Return _offTextColor
        End Get
        Set(value As Color)
            _offTextColor = value
            'Preview changes in design mode
            If Me.DesignMode Then Me.Invalidate() 'Redraw control (See OnPaint (PaintEventArgs e) method)
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        'Apply appearance settings as long as they are not customizable
        If _customizable = False Then

            If UIAppearance.Theme = UITheme.Light Then 'Set theme colors LIGHT

                'Solid style.
                If _style = ControlStyle.Solid Then
                    _onBackBorderColor = UIAppearance.StyleColor
                    _onToggleColor = Color.White
                    _onTextColor = Color.WhiteSmoke
                    _offBackBorderColor = Color.LightGray
                    _offToggleColor = Color.White
                    _offTextColor = Color.Gray

                Else 'Style glass
                    _onBackBorderColor = UIAppearance.StyleColor
                    _onToggleColor = UIAppearance.StyleColor
                    _onTextColor = UIAppearance.TextColor
                    _offBackBorderColor = Color.FromArgb(171, 171, 171)
                    _offToggleColor = Color.FromArgb(171, 171, 171)
                    _offTextColor = Color.Gray
                End If

            Else 'Set DARK theme colors
                _onBackBorderColor = UIAppearance.StyleColor

                'Solid style.
                If _style = ControlStyle.Solid Then
                    _onToggleColor = RJColors.DarkItemBackground
                    _onTextColor = Color.Gainsboro
                Else 'Style glass
                    _onToggleColor = UIAppearance.StyleColor
                    _onTextColor = ColorEditor.Lighten(UIAppearance.TextColor, 20)
                End If

                _offBackBorderColor = RJColors.DarkActiveBackground
                _offToggleColor = Color.FromArgb(110, 104, 153)
                _offTextColor = UIAppearance.TextColor
            End If
        End If
    End Sub

    Private Function GetFigurePath(rect As Rectangle) As GraphicsPath
        'Method to draw the background or just the edge with rounded ends of the toggle button
        Dim arcSize As Integer = rect.Height 'Set the size of the elliptical arc 
        Dim leftArc As Rectangle = New Rectangle(rect.X, rect.Y, arcSize, arcSize) 'Create a rectangular object for the left arc with the specified location (x, y) and size.
        Dim rightArc As Rectangle = New Rectangle(rect.Width - arcSize, rect.Y, arcSize, arcSize) 'Create a rectangular object for the right arc with the specified location (x, y) and size.
        Dim path As GraphicsPath = New GraphicsPath() 'Create a graphics path object
        path.StartFigure() 'Start Figure
        path.AddArc(leftArc, 90, 180) 'Add the left arc to the figure starting at 90 degrees with a range of 180 degrees.
        path.AddArc(rightArc, 270, 180) 'Add the right arc to the figure starting at 270 degrees with a range of 180 degrees.
        path.CloseFigure() 'End figure
        Return path 'Return the background or border shape.
    End Function

#End Region

#Region "-> Overridden methods"

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        'This method completely overrides the paint and redraws a new layout and appearance of the control.
        'FIELDS
        Dim graph As Graphics = pevent.Graphics ' Graphics Object
        Dim tbRect As Rectangle = Rectangle.Inflate(Me.ClientRectangle, -2, -2) 'Dimensions for the toggle button.
        Dim toggleSize As Single = tbRect.Height - 4.8F 'Toggle size.
        '' Dimensions for the lever in the off state.
        Dim rectOffToggle As RectangleF = New RectangleF() With {
            .X = tbRect.X + ((tbRect.Height - toggleSize) / 2),
            .Y = tbRect.Y + ((tbRect.Height - toggleSize) / 2),
            .Width = toggleSize,
            .Height = toggleSize
        }
        '' Dimensions for the lever in the on state.
        Dim rectOnToggle As RectangleF = New RectangleF() With {
            .X = tbRect.Width - toggleSize - ((tbRect.Height - toggleSize) / 2),
            .Y = tbRect.Y + ((tbRect.Height - toggleSize) / 2),
            .Width = toggleSize,
            .Height = toggleSize
        }

        'HE DREW

        Using path As GraphicsPath = GetFigurePath(tbRect) 'Get the path of the figure
            graph.SmoothingMode = SmoothingMode.AntiAlias ' Set the smoothing mode.
            'Draw the surface
            graph.Clear(Me.Parent.BackColor)
            'Draw the toggle button in the on state.
            If Me.Checked Then 'ON

                'Draw the bottom of the toggle button
                If _style = ControlStyle.Solid Then
                    graph.FillPath(New SolidBrush(_onBackBorderColor), path)
                Else
                    graph.DrawPath(New Pen(_onBackBorderColor, 2), path)
                End If
                'Draw the lever
                graph.FillEllipse(New SolidBrush(_onToggleColor), rectOnToggle)
                'Draw the text - Centered
                If _onText <> "" OrElse _onText IsNot Nothing Then
                    graph.DrawString(_onText, Me.Font, New SolidBrush(_onTextColor), ((tbRect.Right - TextRenderer.MeasureText(_onText, Me.Font).Width) / 2) - (toggleSize / 2), ((Me.Height - TextRenderer.MeasureText(_onText, Me.Font).Height) / 2))
                End If


                'Draw the toggle button in the off state.
            Else 'OFF
                'Draw the bottom of the toggle button
                If _style = ControlStyle.Solid Then
                    graph.FillPath(New SolidBrush(_offBackBorderColor), path)
                Else
                    pevent.Graphics.DrawPath(New Pen(_offBackBorderColor, 2), path)
                End If
                'Draw the lever
                graph.FillEllipse(New SolidBrush(_offToggleColor), rectOffToggle)
                'Draw the text - Centered
                If _offText <> "" OrElse _offText IsNot Nothing Then
                    graph.DrawString(_offText, Me.Font, New SolidBrush(_offTextColor), ((tbRect.Right - TextRenderer.MeasureText(_onText, Me.Font).Width) / 2) + (toggleSize / 2), ((Me.Height - TextRenderer.MeasureText(_onText, Me.Font).Height) / 2))
                End If
            End If
        End Using
    End Sub
#End Region

End Class
