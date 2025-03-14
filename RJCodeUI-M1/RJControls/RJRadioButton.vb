Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RJRadioButton
    Inherits RadioButton

    ''' <summary>
    ''' This class enherits from <RadioButton/> class.
    ''' this control completely overrides the paint event and a new radio button
    ''' design is drawn with the colors assigned in the appearance settings. 
    ''' 
    ''' The drawings occur in the following order:
    '''     1.- The background of the control surface is drawn.
    '''     2.- The text is drawn.
    '''     3.- The border of the radio button is drawn.
    '''     4.- The background of the radio button is drawn.
    '''     5.- The radio button check mark is drawn.
    ''' Tutorial guia: https://www.youtube.com/watch?v=SAA5qDoiL4M
    ''' </summary>
    ''' 

#Region "-> Fields"

    Private _checkedColor As Color = UIAppearance.StyleColor 'Gets or sets the color of the checked state.
    Private _unCheckedColor As Color = RJColors.Cancel 'Gets or sets the color of the unchecked state.
    Private _fillColor As Color = UIAppearance.ItemBackgroundColor 'Gets or sets the circular fill color of the radio button.
    Private _customizable As Boolean = False 'Gets or sets whether the control's colors are customizable.

#End Region

#Region "-> Constructor"

    Public Sub New()
        Me.MinimumSize = New Size(0, 21)
        Me.Font = New Font("Verdana", UIAppearance.TextSize, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        Me.Cursor = Cursors.Hand
        'Set a Padding of 10 to the left to increase the width of the control, so that the icon and text fit and display completely.
        Me.Padding = New Padding(10, 0, 0, 0)
        Cursor = Cursors.Hand
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    <Description("Gets or sets whether the control's colors are customizable.")>
    Public Property Customizable As Boolean
        Get
            Return _customizable
        End Get
        Set(ByVal value As Boolean)
            _customizable = value

            If Me.DesignMode Then
                ApplyApperanceSettings()
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets whether the control's colors are customizable.")>
    Public Property CheckedColor As Color
        Get
            Return _checkedColor
        End Get
        Set(ByVal value As Color)
            _checkedColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets whether the control's colors are customizable.")>
    Public Property UnCheckedColor As Color
        Get
            Return _unCheckedColor
        End Get
        Set(ByVal value As Color)
            _unCheckedColor = value
            Me.Invalidate()
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyApperanceSettings()
        If _customizable = False Then
            _checkedColor = UIAppearance.StyleColor
            _unCheckedColor = RJColors.Cancel
            Me.ForeColor = UIAppearance.TextColor

            If UIAppearance.Theme = UITheme.Light Then
                _fillColor = ColorEditor.Lighten(UIAppearance.BackgroundColor, 15)
            Else
                _fillColor = ColorEditor.Darken(UIAppearance.BackgroundColor, 3)
            End If
        End If
    End Sub
#End Region

#Region "-> Methods overridden"

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        ApplyApperanceSettings()
    End Sub

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        'This method takes care of completely overriding the paint and drawing a new control with a custom look.
        'Fields
        Dim graphics As Graphics = pevent.Graphics ' Graphics object.
        Dim rbSize As Integer = 18 'Size of the radio button.
        Dim rbCheckSize As Integer = 12 'Size of radio button check icon.
        'Radio button dimensions. Y = Centered
        Dim rectRadioButton As Rectangle = New Rectangle() With {
            .X = 1,
            .Y = (Me.Height - rbSize) / 2,
            .Width = rbSize,
            .Height = rbSize
        }
        'Radio button markup icon dimensions. X & Y = Centered
        Dim rectRbCheck As Rectangle = New Rectangle() With {
            .X = rectRadioButton.X + ((rectRadioButton.Width - rbCheckSize) / 2),
            .Y = (Me.Height - rbCheckSize + 1) / 2,
            .Width = rbCheckSize,
            .Height = rbCheckSize
        }
        'Set the background color if the control is customizable.
        If _customizable AndAlso Me.Parent IsNot Nothing Then

            If UIAppearance.Theme = UITheme.Light Then
                _fillColor = ColorEditor.Lighten(Me.Parent.BackColor, 10)
            Else
                _fillColor = ColorEditor.Darken(Me.Parent.BackColor, 3)
            End If
        End If

        'Drawing
        Using penRbBorder As Pen = New Pen(_checkedColor, 1.5F) 'Pen to draw the border.
            Using brushRbFill As SolidBrush = New SolidBrush(_fillColor) 'Brush to draw the circular fill.
                Using brushRbCheck As SolidBrush = New SolidBrush(_checkedColor) 'Brush to draw the markup icon.
                    Using brushText As SolidBrush = New SolidBrush(Me.ForeColor) 'Brush to draw the text.
                        graphics.SmoothingMode = SmoothingMode.AntiAlias ' Set the smoothing mode.
                        'Draw the control surface
                        graphics.Clear(Me.BackColor)
                        'Draw the radio button
                        If Me.Checked Then 'Checked state
                            graphics.FillEllipse(brushRbFill, rectRadioButton) 'Circular fill of radio button
                            graphics.DrawEllipse(penRbBorder, rectRadioButton) 'Circular border of radio button
                            graphics.FillEllipse(brushRbCheck, rectRbCheck) 'Circular marking of radio button
                        Else 'Status unchecked
                            penRbBorder.Color = _unCheckedColor 'Change the color of the pen
                            graphics.FillEllipse(brushRbFill, rectRadioButton) 'Circular fill of radio button
                            graphics.DrawEllipse(penRbBorder, rectRadioButton) 'Circular border of radio button
                        End If
                        'Draw the text
                        graphics.DrawString(Me.Text, Me.Font, brushText, rbSize + 8, (Me.Height - TextRenderer.MeasureText(Me.Text, Me.Font).Height) / 2) 'Y = Centered
                    End Using
                End Using
            End Using
        End Using
    End Sub
#End Region

End Class
