Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports FontAwesome.Sharp

'Default event when double click on control in designer
<DefaultEvent("OnSelectedIndexChanged")>
Public Class RJComboBox
    Inherits UserControl

    ''' <summary>
    ''' This class inherits the <UserControl/>class.
    ''' This control exposes most of the most used and essential properties and events of 
    ''' a normal combobox, you can add the functionalities that you probably need and are missing here.
    ''' On the other hand, you can change the style to solid or glass, also customize the dropdown 
    ''' arrow icon, border color and border radius.
    ''' Tutorial guide: https://youtu.be/5V6ZD2mAUw8 (Custom ComboBox - UserControl)
    ''' </summary>

#Region "-> Fields"

    Private _style As ControlStyle 'Style (solid or glass)
    Private _backgroundColor As Color 'Gets or sets the background color.
    Private _iconColor As Color 'Gets or sets the icon color.
    Private _borderColor As Color 'Gets or sets the border color.
    Private _borderSize As Integer = 1 'Gets or sets the border size.
    Private _borderRadius As Integer = 0 'Gets or sets the border radius.
    Private _customizable As Boolean 'Gets or sets whether the control is customizable.
    'Controls
    Private _comboList As ComboBox 'Gets or sets the Combo Box (not visible, but may show dropdown list)
    Private _btnIcon As IconButton 'Gets or sets the Dropdown Arrow Icon (button to show dropdown list)
    Private _label As Label 'Gets or sets the Label (to display the text of the combo box, you can change it to TextBox if you want to type in it, or you can use the keystroke event)

    ''' <Note>: ICON BUTTON is provided by the <FontAwesome.Sharp/> library
    '''       Author: mkoertgen
    '''       GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
    '''       Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp </Note>
#End Region

#Region "-> Events"

    <Category("RJ Code Advance")>
    Public Event OnSelectedIndexChanged As EventHandler 'Default event of combo box
#End Region

#Region "-> Constructor"
    Public Sub New()
        _comboList = New ComboBox()
        _btnIcon = New IconButton()
        _label = New Label()
        Me.SuspendLayout()
        ''
        '' ComboBox: Combined list
        ''
        _comboList.Font = New Font("Microsoft Sans Serif", 9.5F)
        _comboList.FormattingEnabled = True
        _comboList.Size = New Size(170, 21)
        AddHandler _comboList.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged 'Subscribe the SelectedIndexChanged event of the control and attach it to the predefined default OnSelectedIndexChanged event (see method definition).
        AddHandler _comboList.DropDownClosed, AddressOf ComboBox_DropDownClosed
        AddHandler _comboList.TextChanged, AddressOf ComboBox_TextChanged
        ''
        '' IconButton: Dropdown Arrow Icon
        ''
        _btnIcon.FlatStyle = FlatStyle.Flat
        _btnIcon.FlatAppearance.BorderSize = 0
        _btnIcon.Size = New Size(30, 30)
        _btnIcon.Dock = DockStyle.Right
        _btnIcon.BackColor = Color.WhiteSmoke
        _btnIcon.IconChar = IconChar.AngleDown 'Set drop down arrow icon
        _btnIcon.IconColor = Color.MediumSlateBlue
        _btnIcon.IconSize = 22
        _btnIcon.Location = New Point(169, 1)
        _btnIcon.Cursor = Cursors.Hand
        AddHandler _btnIcon.Click, AddressOf BtnIcon_Click 'Subscribe to BtnIcon.Click event (To Show combo box drop down list)
        ''
        '' Label: ComboBox Label (It is the visual part, face or surface of RJComboBox, it shows the text and fills the user control.)
        ''
        _label.BackColor = Color.WhiteSmoke
        _label.Dock = DockStyle.Fill 'Set padding
        _label.Location = New Point(1, 1)
        _label.Padding = New Padding(8, 0, 0, 0)
        _label.Size = New Size(168, 30)
        _label.TextAlign = ContentAlignment.MiddleLeft
        _label.Text = ""
        _label.Controls.Add(_btnIcon) 'Add the icon button to the label.
        _label.Font = New Font(UIAppearance.TextFamilyName, UIAppearance.TextSize) 'Font

        '/ * Since the label is the surface of the RJComboBox and occupies most of the user control,
        'It is necessary to attach the events that occur in the label (label) to the events of the user control (RJComboBox),
        'That is, for example in the Click event, when the label is clicked, the click event of the user control (RJComboBox) must also be executed.
        'See the definition of the event methods to understand better. * /
        AddHandler _label.Click, AddressOf RJComboBox_Click
        AddHandler _label.KeyDown, AddressOf RJComboBox_KeyDown
        AddHandler _label.KeyPress, AddressOf RJComboBox_KeyPress
        AddHandler _label.KeyUp, AddressOf RJComboBox_KeyUp
        AddHandler _label.MouseEnter, AddressOf RJComboBox_MouseEnter
        'You can attach the events you want, if it doesn't exist, you can create it was done with the OnSelectedIndexChanged event.

        ''
        '' User control: RJComboBox
        ''
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.None
        Me.BackColor = Color.MediumSlateBlue
        BorderSize = _borderSize 'Set border size to apply necessary adjustments.
        Me.Size = New Size(200, 32)
        'Add the controls
        Me.Controls.Add(_label) 'Fill in the remaining space (display the text of the combo box)
        Me.Controls.Add(_comboList) 'It's in the background, behind the label (not visible, but showing the drop-down list).
        Cursor = Cursors.Hand
        'This order is important, the last controls are added first (from bottom to top).
        Me.ResumeLayout(False)
        SetComboComponentLocation()
    End Sub
#End Region

#Region "-> Properties"

#Region "- Appearance properties"

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the style (glass or solid)")>
    Public Property Style As ControlStyle
        Get
            Return _style
        End Get
        Set(ByVal value As ControlStyle)
            _style = value
            'Update appearance settings-> preview changes in design mode.
            If Me.DesignMode Then ApplyAppearanceSettings()
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets whether the control is customizable")>
    Public Property Customizable As Boolean
        Get
            Return _customizable
        End Get
        Set(ByVal value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the background color")>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            _backgroundColor = value
            _label.BackColor = _backgroundColor
            _btnIcon.BackColor = _backgroundColor
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the border color")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate() 'Draw the border (Redraw the control)
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the border size")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)

            If value >= 1 Then
                _borderSize = value
                Me.Padding = New Padding(_borderSize + 1) 'Set the Padding property to apply a space and draw the border.
                SetComboComponentLocation() 'Update the location of the combobox.
                Me.Invalidate() 'Draw the border (Redraw the control)
            End If
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the border radius")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)

            If value >= 0 Then
                _borderRadius = value
                SetComboComponentLocation() 'Update the location of the combobox.
                Me.Invalidate() 'Draw border and radius (Redraw control)
            End If
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the icon color")>
    Public Property IconColor As Color
        Get
            Return _btnIcon.IconColor
        End Get
        Set(ByVal value As Color)
            _iconColor = value
            _btnIcon.IconColor = _iconColor
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the dropdown style")>
    Public Property DropDownStyle As ComboBoxStyle
        Get
            Return _comboList.DropDownStyle
        End Get
        Set(ByVal value As ComboBoxStyle)
            _comboList.DropDownStyle = value

            If _comboList.DropDownStyle = ComboBoxStyle.Simple Then
                _btnIcon.Visible = False
            Else
                _btnIcon.Visible = True
            End If
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the background color of the drop-down list")>
    Public Property DropDownBackColor As Color
        Get
            Return _comboList.BackColor
        End Get
        Set(ByVal value As Color)
            _comboList.BackColor = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the text color of the drop-down list")>
    Public Property DropDownTextColor As Color
        Get
            Return _comboList.ForeColor
        End Get
        Set(ByVal value As Color)
            _comboList.ForeColor = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Gets or sets the text color of the combo")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            _label.ForeColor = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Get or set the font")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            _label.Font = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    <Description("Get or set the text")>
    Public Property Texts As String
        Get
            Return _label.Text
        End Get
        Set(ByVal value As String)
            _label.Text = value
        End Set
    End Property
#End Region

#Region "- Functional properties"

    <Category("RJ Code - Data")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design", GetType(UITypeEditor))>
    <Localizable(True)>
    <MergableProperty(False)>
    <Description("Gets an object that represents the collection of elements contained in this ComboBox")>
    Public ReadOnly Property Items As ComboBox.ObjectCollection
        Get
            Return _comboList.Items
            '/ *
            'This property exposes all the functionality of the ITEMS property of the normal combobox (ComboBox.ObjectCollection),
            'how to add a collection of strings from the designer, using the Methods Items.Add, Items.AddRange, Items.Remove,
            'Items.Count, etc.
            'In sumary, this property allows you to get a reference to the list of items that are currently stored
            'in the ComboBox. With this reference, you can add items, remove items, and get a count of the items in the collection.
            'More information
            'https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox.items?view=net-5.0#System_Windows_Forms_ComboBox_Items
            '* /
        End Get
    End Property

    <Category("RJ Code - Data")>
    <AttributeProvider(GetType(IListSource))>
    <DefaultValue("")>
    <RefreshProperties(RefreshProperties.Repaint)>
    <Description("Gets or sets the data source for this ComboBox.")>
    Public Property DataSource As Object
        Get
            Return _comboList.DataSource
        End Get
        Set(ByVal value As Object)
            _comboList.DataSource = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <DefaultValue("")>
    <Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", GetType(UITypeEditor))>
    <TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design")>
    <Description("Gets or sets the property to display for this ListControl. (Inherited from ListControl)")>
    Public Property DisplayMember As String
        Get
            Return _comboList.DisplayMember
        End Get
        Set(ByVal value As String)
            _comboList.DisplayMember = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <DefaultValue("")>
    <Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", GetType(UITypeEditor))>
    <Description("Gets or sets the property path to be used as the actual value for items in the ListControl. (Inherited from ListControl)")>
    Public Property ValueMember As String
        Get
            Return _comboList.ValueMember
        End Get
        Set(ByVal value As String)
            _comboList.ValueMember = value
        End Set
    End Property
    ' Property not visible in property box
    <Browsable(False)>
    <Description("Gets or sets the index that the currently selected item specifies.")>
    Public Property SelectedIndex As Integer
        Get
            Return _comboList.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            ' Verifica se o índice é válido
            If value >= 0 AndAlso value < _comboList.Items.Count Then
                _comboList.SelectedIndex = value
            End If
        End Set
    End Property

    ' Property not visible in property box
    <Browsable(False)>
    Public Property SelectedValue As Object
        Get
            Return _comboList.SelectedValue
        End Get
        Set(ByVal value As Object)
            ' Verifica se o valor não é nulo
            If value IsNot Nothing Then
                ' Tenta definir o valor usando SelectedValue, se existir no DataSource
                If _comboList.Items.Contains(value) Then
                    _comboList.SelectedValue = value
                Else
                    ' Tenta buscar o índice correspondente ao valor se não estiver diretamente
                    Dim index As Integer = -1
                    For i As Integer = 0 To _comboList.Items.Count - 1
                        If _comboList.Items(i).Equals(value) Then
                            index = i
                            Exit For
                        End If
                    Next
                    If index >= 0 Then
                        _comboList.SelectedIndex = index
                    End If
                End If
            End If
        End Set
    End Property

    ' Property not visible in property box
    <Browsable(False)>
    Public Property SelectedItem As Object
        Get
            Return _comboList.SelectedItem
        End Get
        Set(ByVal value As Object)
            ' Verifica se o valor não é nulo
            If value IsNot Nothing Then
                ' Verifica se o item está na lista e define como selecionado
                If _comboList.Items.Contains(value) Then
                    _comboList.SelectedItem = value
                Else
                    ' Busca o índice correspondente ao item
                    Dim index As Integer = -1
                    For i As Integer = 0 To _comboList.Items.Count - 1
                        If _comboList.Items(i).Equals(value) Then
                            index = i
                            Exit For
                        End If
                    Next
                    If index >= 0 Then
                        _comboList.SelectedIndex = index
                    End If
                End If
            End If
        End Set
    End Property


    <Browsable(True)>
    <Category("RJ Code - Data AC")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version = 4.0.0.0, Culture = neutral, PublicKeyToken = b03f5f7f11d50a3a", GetType(UITypeEditor))>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <Localizable(True)>
    Public Property AutoCompleteCustomSource As AutoCompleteStringCollection
        Get
            Return _comboList.AutoCompleteCustomSource
        End Get
        Set(ByVal value As AutoCompleteStringCollection)
            _comboList.AutoCompleteCustomSource = value
        End Set
    End Property

    <Browsable(True)>
    <Category("RJ Code - Data AC")>
    <EditorBrowsable(EditorBrowsableState.Always)>
    Public Property AutoCompleteMode As AutoCompleteMode
        Get
            Return _comboList.AutoCompleteMode
        End Get
        Set(ByVal value As AutoCompleteMode)
            _comboList.AutoCompleteMode = value
        End Set
    End Property

    <Browsable(True)>
    <Category("RJ Code - Data AC")>
    <EditorBrowsable(EditorBrowsableState.Always)>
    Public Property AutoCompleteSource As AutoCompleteSource
        Get
            Return _comboList.AutoCompleteSource
        End Get
        Set(ByVal value As AutoCompleteSource)
            _comboList.AutoCompleteSource = value
        End Set
    End Property
    'You can keep adding more conventional combo box properties than in case you need to or forgot to do so
#End Region

#Region "- Overridden properties"
    'Override the text property of the user control and set or get the label text for the combo box.
    Public Overloads Property Text As String
        Get
            Return _label.Text
        End Get
        Set(ByVal value As String)
            _label.Text = value
        End Set
    End Property
#End Region
#End Region

#Region "-> Private methods"
    Private Sub ApplyAppearanceSettings()
        'Apply appearance settings
        If _customizable = False Then
            _comboList.ForeColor = UIAppearance.TextColor
            _comboList.BackColor = UIAppearance.ItemBackgroundColor

            Select Case _style
                Case ControlStyle.Solid 'Solid Style
                    BorderColor = UIAppearance.StyleColor
                    BorderSize = 0
                    _label.ForeColor = Color.White
                    _btnIcon.IconColor = Color.White
                    Me.BackColor = UIAppearance.StyleColor
                Case ControlStyle.Glass ' Glass Style
                    _btnIcon.IconColor = UIAppearance.StyleColor
                    _label.ForeColor = UIAppearance.PrimaryTextColor
                    Me.BackColor = UIAppearance.BackgroundColor

                    If UIAppearance.Theme = UITheme.Dark Then
                        BorderColor = ColorEditor.Darken(UIAppearance.TextColor, 10)
                    Else
                        BorderColor = UIAppearance.TextColor
                    End If
            End Select
        End If
    End Sub

    Private Sub SetComboComponentLocation()
        'Update the size and location of the ComboBox
        _comboList.Width = _label.Width - _btnIcon.Width
        If _borderRadius > 2 Then
            _comboList.Location = New Point(Me.Width - _comboList.Width - Me.Padding.Right - (_borderRadius / 2) - 2, _label.Bottom - _comboList.Height)
        Else
            _comboList.Location = New Point(Me.Width - _comboList.Width - Me.Padding.Right, _label.Bottom - _comboList.Height)
        End If
    End Sub
#End Region

#Region "-> Public methods"
    Public Sub Clear()
        'Clear control
        Me._label.Text = ""
        _comboList.Items.Clear()
    End Sub
#End Region

#Region "-> Event methods"
    '// -> Default event
    Private Sub ComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Attach the default event OnSelectedIndexChanged of the user control (RJComboBox)
        'to the SelectedIndexChanged event of the ComboBox (comboList).
        RaiseEvent OnSelectedIndexChanged(_comboList, e)
        'When an item is selected or the dropdown text changes, update the label text.
        _label.Text = _comboList.Text
    End Sub

    '// -> Actiones of the components
    Private Sub ComboBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'When an item is selected or the dropdown text changes, update the label text.
        _label.Text = _comboList.Text
    End Sub

    Private Sub BtnIcon_Click(ByVal sender As Object, ByVal e As EventArgs)
        'When the drop down arrow icon button is clicked, display the drop down combo box.
        _comboList.Select() 'As a precaution, the combobox must be focused before, some problems happen sometimes.
        _comboList.DroppedDown = True 'Set the DroppedDown property to true to display the drop-down list.

        If _customizable Then 'If customizable

            Select Case _style 'Apply a highlight to the drop-down arrow icon button.
                Case ControlStyle.Solid
                    _btnIcon.BackColor = ColorEditor.Darken(_backgroundColor, 10)
                    _btnIcon.IconColor = Color.White
                Case ControlStyle.Glass
                    _btnIcon.BackColor = _borderColor
                    _btnIcon.IconColor = Color.White
                    BorderColor = _borderColor
            End Select
        Else 'Si is not customizable

            Select Case _style 'Apply a highlight to the drop-down arrow icon button.
                Case ControlStyle.Solid
                    _btnIcon.BackColor = ColorEditor.Darken(UIAppearance.StyleColor, 10)
                    _btnIcon.IconColor = Color.White
                Case ControlStyle.Glass
                    _btnIcon.BackColor = UIAppearance.StyleColor
                    _btnIcon.IconColor = Color.White
                    BorderColor = UIAppearance.StyleColor
            End Select
        End If
    End Sub

    Private Sub ComboBox_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
        'Happens when dropdown list is closed
        If _customizable Then
            'Disable the highlighting of the drop-down icon button.
            _btnIcon.BackColor = _backgroundColor
            _btnIcon.IconColor = _iconColor
            BorderColor = _borderColor
        Else
            'Refresh the appearance to disable the highlighting of the flyout button.
            ApplyAppearanceSettings()
        End If
    End Sub

    Private Sub RJComboBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnClick(e)
        'Attach the click event of the user control (RJComboBox) to this click event of the label (dateText).
        _comboList.Select()
        If DropDownStyle = ComboBoxStyle.DropDownList Then 'When the style is DropDownList, the dropdown list should be opened when clicking anywhere in the control (In the same way as in a traditional ComboBox).
            _comboList.DroppedDown = True 'Set the DroppedDown property to true to display the drop-down list.
        End If
        '/ * This event method is subscribed to the click event of the label (remember that the label
        ' represents most of the user control), so when the label is clicked,
        'the click event of the user control will be fired.
        'This scenario is the same as the default OnSelectedIndexChanged event created. * /

    End Sub
    '// -> Attach events: Label -> UserControl
    Private Sub RJComboBox_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) 'Attach the other necessary events in the same way.
        Me.OnMouseEnter(e)
    End Sub

    Private Sub RJComboBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyUp(e)
    End Sub

    Private Sub RJComboBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Me.OnKeyPress(e)
    End Sub

    Private Sub RJComboBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyDown(e)
    End Sub
    'You can keep adding the events you need
#End Region

#Region "-> Overridden methods"
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        SetComboComponentLocation()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        'Load event
        MyBase.OnLoad(e)
        Me.Visible = False 'Hide the control while applying appearance settings, this prevents flickering when displaying the form.
        ApplyAppearanceSettings() 'Apply UI appearance settings
        Me.Visible = True
        SetComboComponentLocation()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics
        ' GLASS style
        If _style = ControlStyle.Glass Then
            'Apply rounded corners (If applicable) to the region + smoothing + border drawing of the user control.
            RoundedControl.RegionAndBorder(Me, _borderRadius, graph, _borderColor, _borderSize)

            If _borderRadius > 1 Then 'If the radius is greater than 1, apply rounded corners to the label.
                RoundedControl.RegionOnly(_label, _borderRadius - _borderSize)

                If _comboList.DroppedDown = True Then 'If the drop-down list is open, draw a fill in the button area to remove visible surface from the background, you can comment the code to understand what I mean.

                    Using brush As SolidBrush = New SolidBrush(_borderColor)
                        graph.SmoothingMode = SmoothingMode.AntiAlias
                        Dim rect = New Rectangle(_btnIcon.Left + 5, _btnIcon.Top + 0, _btnIcon.Width, Me.Height)
                        Dim path As GraphicsPath = RoundedControl.GetRoundedGPath(rect, _borderRadius - _borderSize)
                        graph.FillPath(New SolidBrush(_borderColor), path)
                    End Using
                End If
            End If
            'SOLID style
        Else
            'Just apply rounded corners (If that's the case) to the user control's + smoothing region.
            RoundedControl.RegionAndSmoothed(Me, _borderRadius, graph)
            If _borderRadius > 1 Then 'If the radius is greater than 1, apply rounded corners to the label.
                RoundedControl.RegionOnly(_label, _borderRadius - _borderSize)
            End If
        End If
    End Sub
#End Region

End Class

