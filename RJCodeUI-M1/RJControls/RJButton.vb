Imports System.ComponentModel
Imports FontAwesome.Sharp

Public Class RJButton
    Inherits IconButton

    ''<summary>
    ''------This class inherits from the <IconButton/> class of the <FontAwesome.Sharp/> library
    ''      Autor: mkoertgen   
    ''      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp 
    ''      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp   
    '' This button implements 4 appearance properties:
    ''->You can change the button style to glass or solid (<Style_as_ControlStyle_/>).
    ''->You can change the button design to Normal, Icon Button, Metro, Confirm, Cancel or Delete(<Design_as_ButtonDesign/>).
    ''->You can set rounded border, however it only affects the solid style (<BorderRadius/>)
    ''->You can change the button border size (Only for glass style)
    '' Tutorial guide:https://www.youtube.com/watch?v=u8SL5g9QGcI&t 
    '' </summary>

#Region "-> Fields"

    Private _style As ControlStyle 'Gets or sets the style of the button (glass or solid).
    Private _design As ButtonDesign 'Gets or sets the button design (Normal, Icon Button, Metro, Confirm, Cancel, or Delete).
    Private _tempSize As Size 'Gets or sets the temporary size of the button.
    Private _borderRadius As Integer 'Gets or sets the size of the border radius (rounded corners).
    Private _borderSize As Integer 'Gets or sets the size of the button border.
    Private _skinBorderColor As Color = UIAppearance.StyleColor 'Gets or sets the border color if the style is GLASS, or the background color if the style is SOLID;
    'Static fields
    Private Shared ReadOnly _supernovaColor As Color = If(UIAppearance.Style = UIStyle.Supernova, RJColors.GetSupernovaColor(), Color.CornflowerBlue) 'Sets and gets a supernova color if the style is supernova
#End Region

#Region "-> Constructor"

    Public Sub New()
        'Initialize properties
        Me.BackColor = UIAppearance.StyleColor
        Me.FlatAppearance.BorderSize = 0
        Me.FlatStyle = FlatStyle.Flat
        Me.Flip = FlipOrientation.Normal
        Me.Font = New Font("Microsoft Sans Serif", UIAppearance.TextSize, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        Me.ForeColor = Color.White
        Me.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconSize = 24
        Me.IconColor = Color.White
        Me.Rotation = 0.0R
        Me.Size = New Size(95, 30)
        Cursor = Cursors.Hand
        SetButtonDesign()
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    <Description("Gets or sets the button design (Normal, Icon Button, metro, Confirm, Cancel, or Delete)")>
    Public Property Design As ButtonDesign
        Get
            Return _design
        End Get
        Set(ByVal value As ButtonDesign)
            _design = value
            If _design <> ButtonDesign.Custom Then 'If the design is not custom,
                SetButtonDesign() 'Set the specified design.
            End If

            'It is not necessary to call the invalidate () method, since when changing the background or text color the method is invoked automatically.
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the button style (glass or solid)")>
    Public Property Style As ControlStyle
        Get
            Return _style
        End Get
        Set(ByVal value As ControlStyle)
            _style = value 'Assign the specified value.
            SetButtonStyle() 'And set the specified style.
            'It is not necessary to call the invalidate () method, since when changing the background or text color the method is invoked automatically.
        End Set
    End Property


    <Category("RJ Code Advance")>
    <Description("Gets or sets the border color if the style is GLASS, or the background color if the style is SOLID")>
    Public Property SkinBorderColor As Color
        Get
            Return _skinBorderColor
        End Get
        Set(ByVal value As Color)
            _skinBorderColor = value
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or Sets the Border Radius")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate() '' Redraw the control to update the appearance.
        End Set
    End Property


    <DefaultValue(GetType(Color), "Color.Black")>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
        End Set
    End Property

#End Region

#Region "-> Private methods"

    Private Sub SetButtonStyle()
        'This method takes care of set the style of the button.
        If Design <> ButtonDesign.Custom Then
            If Style = ControlStyle.Solid Then 'Solid Style.
                Me.BackColor = _skinBorderColor
                Me.ForeColor = Color.White
                Me.IconColor = Color.White
            Else 'Style Glass.
                If BorderSize < 1 Then BorderSize = 1
                Me.ForeColor = _skinBorderColor
                Me.IconColor = _skinBorderColor
                Me.BackColor = Color.Empty
            End If
        End If
        'It is not necessary to call the invalidate () method, since when changing the background or text color the method is invoked automatically.
    End Sub

    Private Sub SetButtonDesign()
        'This method takes care of set the button layout.
        Select Case Design
            Case ButtonDesign.Normal 'Normal Button (no icon)
                SetNormalButton() 'Set the properties of a button without an icon.
                ApplyAppearanceSettings() 'Get and set the border or background color of the appearance sets.

            Case ButtonDesign.IconButton 'Button Icon
                SetIconButton() 'Set the properties of an icon button.
                'If it has no icon or the icon is confirm, cancel or delete, set a default icon.
                If Me.IconChar = FontAwesome.Sharp.IconChar.None OrElse Me.IconChar = FontAwesome.Sharp.IconChar.Check OrElse Me.IconChar = FontAwesome.Sharp.IconChar.TrashAlt OrElse Me.IconChar = FontAwesome.Sharp.IconChar.TimesCircle Then
                    Me.IconChar = FontAwesome.Sharp.IconChar.Magento
                End If
                ApplyAppearanceSettings() 'Get and set the border or background color of the appearance sets.

            Case ButtonDesign.Metro 'Metro Button
                SetMetroButton() 'Set the properties of a metro button.
                'If it has no icon or the icon is confirm, cancel or delete, set a default icon.
                If Me.IconChar = FontAwesome.Sharp.IconChar.None OrElse Me.IconChar = FontAwesome.Sharp.IconChar.Check OrElse Me.IconChar = FontAwesome.Sharp.IconChar.TrashAlt OrElse Me.IconChar = FontAwesome.Sharp.IconChar.TimesCircle Then
                    Me.IconChar = FontAwesome.Sharp.IconChar.Magento 'Default icon.
                End If
                ApplyAppearanceSettings() 'Get and set the border or background color of the appearance sets.

            Case ButtonDesign.Add 'Confirm button
                SetIconButton() 'Set the properties of an icon button.
                Me.IconChar = FontAwesome.Sharp.IconChar.FileText 'Set confirm icon
                Me.Text = "Novo" 'Set text
                _skinBorderColor = RJColors.Add 'Border or background color.

            Case ButtonDesign.Edit 'Confirm button
                SetIconButton() 'Set the properties of an icon button.
                Me.IconChar = FontAwesome.Sharp.IconChar.Pencil 'Set confirm icon
                Me.Text = "Editar" 'Set text
                _skinBorderColor = RJColors.Add 'Border or background color.
                ApplyAppearanceSettings()
            Case ButtonDesign.Confirm 'Confirm button
                SetIconButton() 'Set the properties of an icon button.
                Me.IconChar = FontAwesome.Sharp.IconChar.Save 'Set confirm icon
                Me.Text = "Salvar" 'Set text
                _skinBorderColor = RJColors.Confirm 'Border or background color.

            Case ButtonDesign.Delete 'Delete button
                SetIconButton() 'Set the properties of an icon button.
                Me.IconChar = FontAwesome.Sharp.IconChar.TrashAlt 'Set delete icon
                Me.Text = "Excluir" 'Set text
                _skinBorderColor = RJColors.Delete 'Border or background color.

            Case ButtonDesign.Cancel 'Cancel Button
                SetIconButton() 'Set the properties of an icon button.
                Me.IconChar = FontAwesome.Sharp.IconChar.Ban 'Set cancel icon
                Me.Text = "Cancelar" 'Set text
                _skinBorderColor = RJColors.Cancel 'Border or background color.
        End Select
        SetButtonStyle()
    End Sub

    Private Sub SetNormalButton()
        'This method takes care of set the normal button properties without icon.
        Me.TextImageRelation = TextImageRelation.Overlay
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.IconChar = FontAwesome.Sharp.IconChar.None
        If Me.DesignMode Then Me.Size = New Size(95, 30) 'Reset the specified size
    End Sub

    Private Sub SetIconButton()
        'This method takes care of set the icon button properties.
        Me.TextAlign = ContentAlignment.MiddleRight
        Me.ImageAlign = ContentAlignment.MiddleCenter
        Me.TextImageRelation = TextImageRelation.ImageBeforeText

        If Me.DesignMode Then 'Reset specified size and icon only at design time.
            Me.Size = New Size(95, 30)
            Me.IconSize = 24
        End If
    End Sub

    Private Sub SetMetroButton()
        'This method takes care of set the metro button properties.
        Me.TextAlign = ContentAlignment.BottomCenter
        Me.ImageAlign = ContentAlignment.MiddleCenter
        Me.TextImageRelation = TextImageRelation.ImageAboveText

        If Me.DesignMode Then 'Set specified size and icon for meter (design-time only)
            Me.Size = New Size(110, 110)
            Me.IconSize = 50
        End If
    End Sub

    Private Sub ApplyAppearanceSettings()
        'This method takes care of set the border or background color of the appearance sets.
        If Design = ButtonDesign.Normal OrElse Design = ButtonDesign.IconButton OrElse Design = ButtonDesign.Metro Then

            If UIAppearance.Style = UIStyle.Supernova Then
                _skinBorderColor = _supernovaColor
            Else
                _skinBorderColor = UIAppearance.StyleColor
            End If
        End If

        Me.FlatAppearance.MouseOverBackColor = ColorEditor.Darken(Me.BackColor, 12)
        Me.FlatAppearance.MouseDownBackColor = ColorEditor.Darken(Me.BackColor, 6)
    End Sub

#End Region

#Region "-> Overridden methods"

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        'This method takes care of establishing the region of the button and drawing the border.
        MyBase.OnPaint(pevent)
        Dim graph As Graphics = pevent.Graphics

        If Style = ControlStyle.Glass OrElse Design = ButtonDesign.Custom Then 'Style Glass
            'Apply rounded corners to the region and smooth + draw the edge.
            RoundedControl.RegionAndBorder(Me, BorderRadius, graph, _skinBorderColor, BorderSize)
        Else 'Solid Style
            'Apply rounded corners to the region and smooth the edge.
            RoundedControl.RegionAndSmoothed(Me, BorderRadius, graph)
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        'Check and validate the radio. (The maximum radius is half the value of the top of the control)
        Dim maxRadius As Integer = Me.Height / 2
        If BorderRadius > maxRadius Then BorderRadius = maxRadius
    End Sub

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        ApplyAppearanceSettings() 'Apply appearance settings.
    End Sub
#End Region

End Class
