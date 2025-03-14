Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports FontAwesome.Sharp

Public Class RJCheckBox
    Inherits CheckBox

    ''' <summary>
    ''' This class inherits from the <CheckBox/> class
    ''' You can change the button style to glassy or solid (<ControlStyle/>).
    ''' In addition to being able to customize the colors of the background, border, checked, icon, etc.
    ''' as long as the customizable property is set to true.
    ''' Tutorial guide: https://www.youtube.com/watch?v=SAA5qDoiL4M 
    ''' </summary>
    ''' 

#Region "-> Fields"

    Private _customizable As Boolean 'Gets or sets whether the control is customizable.
    Private _style As ControlStyle 'Gets or sets the CheckBox style (Glass or Solid).
    Private _borderSize As Integer = 1 'Gets or sets the border size.
    Private _borderColor As Color = UIAppearance.StyleColor 'Gets or sets the border color.
    Private _checkIcon As IconPictureBox 'Gets or sets the checked checkbox icon.

    ''' <Note>:ICON PICTURE BOX is provided by <FontAwesome.Sharp/> library
    '''       Author: mkoertgen
    '''       GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
    '''       Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp </Note>
#End Region

#Region "-> Constructor"

    Public Sub New()
        _checkIcon = New IconPictureBox()
        _checkIcon.IconChar = IconChar.Check
        _checkIcon.IconSize = 19
        _checkIcon.IconColor = UIAppearance.StyleColor
        Me.Cursor = Cursors.Hand
        Me.Checked = True
        Me.Font = New Font(UIAppearance.TextFamilyName, UIAppearance.TextSize)
        Me.ForeColor = UIAppearance.TextColor
        Me.MinimumSize = New Size(0, 21)
        'Set a Padding of 10 to the left to increase the width of the control,
        'so that the icon and text fit together and display completely.
        Me.Padding = New Padding(10, 0, 0, 0)
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    <Description("Gets or Sets the CheckBox style (Glass or Solid)")>
    Public Property Style As ControlStyle
        Get
            Return _style
        End Get
        Set(ByVal value As ControlStyle)
            _style = value 'Set value
            Me.Image = Nothing 'Remove check icon (when style change, checkIcon image changes, then image is stale, see next method codes)
            ApplyAppearanceSettings() 'Update or apply appearance settings.
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the width of the border")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then _borderSize = value 'The value must be greater than 0.
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets a set if the check box is checked")>
    Public Property Check As Boolean
        Get
            Return Me.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.Checked = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets whether the control's appearance colors are customizable, otherwise the appearance color is set according to the appearance settings.")>
    Public Property Customizable As Boolean
        Get
            Return _customizable
        End Get
        Set(ByVal value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the border color.")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the color of the check icon.")>
    Public Property IconColor As Color
        Get
            Return _checkIcon.IconColor
        End Get
        Set(ByVal value As Color)
            _checkIcon.IconColor = value
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property

#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        'Apply appearance settings as long as customizable property is set to false
        If Customizable = False Then
            _borderColor = UIAppearance.StyleColor
            Me.ForeColor = UIAppearance.TextColor

            If Style = ControlStyle.Solid Then
                IconColor = Color.White
            Else
                IconColor = UIAppearance.StyleColor
            End If
        End If
    End Sub
#End Region

#Region "-> Overridden methods"

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        'This method takes care of completely overriding the paint and drawing a new control with a custom look.
        'Fields
        Dim graphics As Graphics = pevent.Graphics ' Graphics object.
        Dim cbSize As Integer = 18 'Checkbox size.
        Dim checkIconSize As Integer = _checkIcon.IconSize 'Checkbox icon size.
        '' Check box dimensions | Y = Centered
        Dim rectCheckBox As Rectangle = New Rectangle() With {
            .X = 1,
            .Y = (Me.Height - cbSize) / 2,
            .Width = cbSize,
        .Height = cbSize
        }
        'Checkbox icon dimensions. X & Y = Centered
        Dim rectCheckIcon As Rectangle = New Rectangle() With {
            .X = rectCheckBox.X + ((rectCheckBox.Width - checkIconSize) / 2) + 1,
            .Y = ((Me.Height - checkIconSize) / 2) + 2,
            .Width = checkIconSize,
            .Height = checkIconSize
        }
        'He drew
        Using penRbBorder As Pen = New Pen(BorderColor, BorderSize) 'Pen to draw the border.
            Using brushRbFill As SolidBrush = New SolidBrush(BorderColor) 'Brush to draw the fill of the box
                Using brushText As SolidBrush = New SolidBrush(Me.ForeColor) 'Brush to draw the text.
                    graphics.SmoothingMode = SmoothingMode.AntiAlias ' Set the smoothing mode.
                    'Draw the control surface
                    graphics.Clear(Me.BackColor)
                    'Draw the checkbox
                    If Me.Checked Then 'Status checked.
                        If Style = ControlStyle.Solid Then graphics.FillRectangle(brushRbFill, rectCheckBox) 'Fill the box
                        graphics.DrawRectangle(penRbBorder, rectCheckBox) 'Border of box
                        graphics.DrawImage(_checkIcon.Image, rectCheckIcon) 'Check box icon
                    Else 'Status not checked.
                        graphics.DrawRectangle(penRbBorder, rectCheckBox) 'Border of box
                    End If
                    'Draw the text
                    'Y = Centered
                    graphics.DrawString(Me.Text, Me.Font, brushText, cbSize + 8, (Me.Height - TextRenderer.MeasureText(Me.Text, Me.Font).Height) / 2)
                End Using
            End Using
        End Using
    End Sub
#End Region

End Class
