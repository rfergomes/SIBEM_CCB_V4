Imports System.ComponentModel

Public Class RJLabel
    Inherits Label

#Region "-> Fields"

    Private _style As LabelStyle 'Gets or sets the label style
    Private _linkLabel As Boolean 'Gets or sets if it is a link label (open a link in the browser or form)
    Private _textColor As Color 'Gets or sets the text color.
#End Region

#Region "-> Constructor"

    Public Sub New()
        Me.ForeColor = UIAppearance.TextColor 'Set the theme text color
        Me.Font = New Font("Verdana", UIAppearance.TextSize, FontStyle.Regular, GraphicsUnit.Point, (CByte((0)))) 'Set default font
        _style = LabelStyle.Normal 'Set label style
        AddHandler Me.MouseEnter, AddressOf Label_MouseEnter
        AddHandler Me.MouseLeave, AddressOf Label_MouseLeave
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    Public Property Style As LabelStyle
        Get
            Return _style
        End Get
        Set(value As LabelStyle)
            _style = value
            ApplyAppearanceSettings() 'Apply theme when label style is set
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property LinkLabel As Boolean
        'Gets or sets if the tag is a link
        '(If true, label changes pointer and text color when mouse hovers over it, see event methods)
        Get
            Return _linkLabel
        End Get
        Set(value As Boolean)
            _linkLabel = value

            If _linkLabel = True Then
                Me.Cursor = Cursors.Hand
            Else
                Me.Cursor = Cursors.Arrow
            End If
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        Select Case _style
            Case LabelStyle.Normal 'If the style is normal, set the color and size of the text set in the appearance settings.
                _textColor = UIAppearance.TextColor
                Me.ForeColor = _textColor
                Me.Font = New Font(Me.Font.Name, UIAppearance.TextSize, Me.Font.Style, Me.Font.Unit)

            Case LabelStyle.Description 'If the style is description

                If UIAppearance.Theme = UITheme.Dark Then 'If the theme is dark style, lighten the text color
                    _textColor = ColorEditor.Darken(UIAppearance.TextColor, 10)
                Else 'If the theme is light style, darken the text color
                    _textColor = ColorEditor.Lighten(UIAppearance.TextColor, 15)
                End If
                Me.ForeColor = _textColor
                Me.Font = New Font(Me.Font.Name, 8.0F, Me.Font.Style, Me.Font.Unit)

            Case LabelStyle.Subtitle 'If the style is subtitle, set the color set in the theme and a size of 12.5F

                If UIAppearance.Theme = UITheme.Dark Then 'If the theme is dark style, lighten the text color
                    _textColor = ColorEditor.Lighten(UIAppearance.TextColor, 45)
                Else 'If the theme is light style, darken the text color
                    _textColor = ColorEditor.Darken(UIAppearance.TextColor, 20)
                End If
                Me.ForeColor = _textColor
                Me.Font = New Font(Me.Font.Name, 12.0F, Me.Font.Style, Me.Font.Unit)

            Case LabelStyle.Title 'If style is title, set application style color to text color or 16F size.
                _textColor = UIAppearance.StyleColor
                Me.ForeColor = _textColor
                Me.Font = New Font(Me.Font.Name, 16.0F, Me.Font.Style, Me.Font.Unit)

            Case LabelStyle.Title2
                If UIAppearance.Theme = UITheme.Dark Then 'If the theme is dark style, lighten the text color
                    _textColor = ColorEditor.Lighten(UIAppearance.TextColor, 50)
                Else 'If the theme is light style, darken the text color
                    _textColor = ColorEditor.Darken(UIAppearance.TextColor, 25)
                End If
                Me.ForeColor = _textColor
                Me.Font = New Font(Me.Font.Name, 14.0F, Me.Font.Style, Me.Font.Unit)

            Case LabelStyle.BarCaption 'If the style is a title of the title bar of the main form.
                Me.Font = New Font("Verdana", 12.5F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
                ColorTitleBar()

            Case LabelStyle.BarText 'If the style is a text from the title bar of the main form.
                Me.Font = New Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
                ColorTitleBar()

            Case LabelStyle.Custom 'Custom size and font, however text color is set by theme.
                _textColor = UIAppearance.TextColor
                Me.ForeColor = _textColor
        End Select
    End Sub

    Private Sub ColorTitleBar()
        'If the theme is light and the style is supernova, darken the text color
        If UIAppearance.Theme = UITheme.Light AndAlso UIAppearance.Style = UIStyle.Supernova Then
            Me.ForeColor = ColorEditor.Darken(UIAppearance.TextColor, 25)
            'If the theme is dark and the style is supernova, lighten the text color
        ElseIf UIAppearance.Theme = UITheme.Dark AndAlso UIAppearance.Style = UIStyle.Supernova Then
            Me.ForeColor = ColorEditor.Lighten(UIAppearance.TextColor, 65)
        Else 'If the style is any other, set white as the text color.
            Me.ForeColor = Color.WhiteSmoke
        End If
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub Label_MouseEnter(sender As Object, e As EventArgs)
        'If the label is of type link, change the color of the text when the mouse passes over it.
        If _linkLabel = True Then Me.ForeColor = ColorEditor.Lighten(UIAppearance.StyleColor, 20)
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        'If the label is of type link, reset the color of the text when the mouse leaves the control.
        If _linkLabel = True Then Me.ForeColor = _textColor
    End Sub
#End Region

End Class
