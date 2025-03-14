Imports System.ComponentModel

Public Class RJDataGridView
    Inherits DataGridView

#Region "-> Fields"

    Private _customizable As Boolean 'Gets or sets whether the control is customizable
    Private _isAlternatingRowsColor As Boolean 'Gets or sets whether to apply a different background color to odd rows.
    Private _borderRadius As Integer 'Gets or sets the border radius size (rounded corners)
    Private _columnHeaderStyle As DataGridViewCellStyle 'Sets or gets the style of column headers.
    Private _rowHeaderStyle As DataGridViewCellStyle 'Sets or gets the style of row headers
    Private _rowStyle As DataGridViewCellStyle 'Sets or gets the Rows style
    Private _stopScroll As Boolean = True 'Sets or gets whether the scroll bar is moving.
    '(True = It is NOT scrolling: False = It is scrolling).
#End Region

#Region "-> Constructor"

    Public Sub New()
        'Initialize data grid view cell style objects
        _columnHeaderStyle = New DataGridViewCellStyle()
        _rowHeaderStyle = New DataGridViewCellStyle()
        _rowStyle = New DataGridViewCellStyle()

        'General adjustments
        Me.AllowUserToResizeRows = False
        Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.BackgroundColor = RJColors.LightItemBackground
        Me.BorderStyle = BorderStyle.None
        Me.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.EnableHeadersVisualStyles = False
        Me.GridColor = Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((224)))))), (CInt(((CByte((224)))))))
        'Me.ReadOnly = True
        Me.RightToLeft = RightToLeft.No
        Me.Size = New System.Drawing.Size(250, 200)

        'Set appearance styles in column headers
        _columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        _columnHeaderStyle.BackColor = Color.MediumPurple
        _columnHeaderStyle.Font = New Font("Microsoft Sans Serif", 11.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        _columnHeaderStyle.ForeColor = Color.White
        _columnHeaderStyle.WrapMode = DataGridViewTriState.True
        _columnHeaderStyle.Padding = New Padding(15, 0, 0, 0)
        Me.ColumnHeadersDefaultCellStyle = _columnHeaderStyle 'Set ColumnHeaderStyle
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ColumnHeadersHeight = 30

        'Set appearance styles in row headers
        _rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        _rowHeaderStyle.BackColor = Color.WhiteSmoke
        _rowHeaderStyle.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        _rowHeaderStyle.ForeColor = Color.White
        _rowHeaderStyle.SelectionBackColor = Color.FromArgb((CInt(((CByte((213)))))), (CInt(((CByte((199)))))), (CInt(((CByte((241)))))))
        _rowHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        _rowHeaderStyle.WrapMode = DataGridViewTriState.False
        Me.RowHeadersDefaultCellStyle = _rowHeaderStyle 'Set RowHeaderStyle
        Me.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.RowHeadersWidth = 25 'Set width
        Me.RowHeadersVisible = False 'Hide row header

        'Set appearance styles in rows
        _rowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        _rowStyle.BackColor = RJColors.LightItemBackground
        _rowStyle.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
        _rowStyle.ForeColor = Color.Gray
        _rowStyle.Padding = New Padding(15, 0, 0, 0)
        _rowStyle.SelectionBackColor = Color.FromArgb((CInt(((CByte((232)))))), (CInt(((CByte((225)))))), (CInt(((CByte((247)))))))
        _rowStyle.SelectionForeColor = Color.Gray
        Me.RowsDefaultCellStyle = _rowStyle 'Set RowStyle
        Me.RowTemplate.Height = 26 'Set height
        BorderRadius = 13

        'Attach scroll events to determine if the scroll bar stopped moving and thus redraw the control.
        Dim horizontalScroll As HScrollBar = Me.Controls.OfType(Of HScrollBar)().First() 'Get the horizontal scroll bar.
        Dim verticalalScroll As VScrollBar = Me.Controls.OfType(Of VScrollBar)().First() 'Get the vertical scroll bar.
        AddHandler horizontalScroll.Scroll, AddressOf ScrollBar_Event
        AddHandler verticalalScroll.Scroll, AddressOf ScrollBar_Event
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    Public Property ColumnHeaderHeight As Integer
        'Sets or gets the height of the column header
        Get
            Return Me.ColumnHeadersHeight
        End Get
        Set(value As Integer)
            Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            If value < 40 Then 'Minimum height
                Me.ColumnHeadersHeight = 40
            Else
                Me.ColumnHeadersHeight = value
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ColumnsMode As DataGridViewAutoSizeColumnsMode
        'Set or get the autosize columns mode of the DataGrid view
        Get
            Return Me.AutoSizeColumnsMode
        End Get
        Set(value As DataGridViewAutoSizeColumnsMode)
            Me.AutoSizeColumnsMode = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Customizable As Boolean
        'Sets or gets if the control is customizable or the layout will be set by appearance settings
        Get
            Return _customizable
        End Get
        Set(value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ColumnHeaderColor As Color
        'Sets or gets the background color of the column header
        Get
            Return Me.ColumnHeadersDefaultCellStyle.BackColor
        End Get
        Set(value As Color)
            Me.ColumnHeadersDefaultCellStyle.BackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ColumnHeaderTextColor As Color
        'Sets or gets the column header text color
        Get
            Return Me.ColumnHeadersDefaultCellStyle.ForeColor
        End Get
        Set(value As Color)
            Me.ColumnHeadersDefaultCellStyle.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property ColumnHeaderFont As Font
        'Sets or gets the font of the column header
        Get
            Return Me.ColumnHeadersDefaultCellStyle.Font
        End Get
        Set(value As Font)
            Me.ColumnHeadersDefaultCellStyle.Font = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property RowHeaderColor As Color
        'Sets or gets the background color of the row header
        Get
            Return Me.RowHeadersDefaultCellStyle.BackColor
        End Get
        Set(value As Color)
            Me.RowHeadersDefaultCellStyle.BackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property SelectionBackColor As Color
        'Sets or gets the background color of the selection
        Get
            Return Me.RowHeadersDefaultCellStyle.SelectionBackColor
        End Get
        Set(value As Color)
            Me.RowHeadersDefaultCellStyle.SelectionBackColor = value
            Me.RowsDefaultCellStyle.SelectionBackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property RowsColor As Color
        'Set or get the color of the rows
        Get
            Return Me.RowsDefaultCellStyle.BackColor
        End Get
        Set(value As Color)
            Me.RowsDefaultCellStyle.BackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property AlternatingRowsColorApply As Boolean
        'Gets or sets whether to apply a background color to odd rows.
        Get
            Return _isAlternatingRowsColor
        End Get
        Set(value As Boolean)
            _isAlternatingRowsColor = value

            If value = False Then 'If the value is false, restore the default color (Color.Empty)
                Me.AlternatingRowsDefaultCellStyle.BackColor = Color.Empty
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property AlternatingRowsColor As Color
        'Sets or gets the color of alternate rows
        Get
            Return Me.AlternatingRowsDefaultCellStyle.BackColor
        End Get
        Set(value As Color)
            If _isAlternatingRowsColor Then Me.AlternatingRowsDefaultCellStyle.BackColor = value
        End Set
        'Warning: This property can cause a performance impact when you have many rows.
    End Property

    <Category("RJ Code Advance")>
    Public Property RowsTextColor As Color
        'Set or get the text color of the rows
        Get
            Return Me.RowsDefaultCellStyle.ForeColor
        End Get
        Set(value As Color)
            Me.RowsDefaultCellStyle.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property SelectionTextColor As Color
        Get
            Return Me.RowsDefaultCellStyle.SelectionForeColor
        End Get
        Set(value As Color)
            Me.RowsDefaultCellStyle.SelectionForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property RowHeight As Integer
        'Set or get the height of the rows
        Get
            Return Me.RowTemplate.Height
        End Get
        Set(value As Integer)
            Me.RowTemplate.Height = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property DgvBackColor As Color
        'Set or get the Background Color of DataGridView
        Get
            Return Me.BackgroundColor
        End Get
        Set(value As Color)
            Me.BackgroundColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderRadius As Integer
        'Gets or sets the radius of the border
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate() 'Redraw the control to update the appearance.
        End Set
    End Property
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()
        If _customizable = False Then 'if not customizable, apply appearance settings.

            If UIAppearance.Theme = UITheme.Dark Then 'If the theme is dark, set the following properties
                DgvBackColor = RJColors.DarkItemBackground 'Background color
                RowsColor = RJColors.DarkItemBackground 'Rows color
                ColumnHeaderColor = RJColors.DarkActiveBackground 'Background color of column headers
                ColumnHeaderTextColor = Color.Gainsboro 'Column headings text color.
                RowsTextColor = UIAppearance.PrimaryTextColor 'Rows text color
                Me.GridColor = UIAppearance.BackgroundColor 'Grid Color

                If _isAlternatingRowsColor Then 'If Alternate Rows Color, set a color for alternate rows color
                    AlternatingRowsColor = ColorEditor.Lighten(RJColors.DarkActiveBackground, 5) 'Background color of alternate rows
                    SelectionBackColor = ColorEditor.Lighten(UIAppearance.StyleColor, 30) 'Background color of the selection.
                    SelectionTextColor = Color.White 'Selection text color.
                Else 'Normal Row Color
                    SelectionBackColor = ColorEditor.Lighten(RJColors.DarkActiveBackground, 5) 'Background color of the selection.
                    SelectionTextColor = UIAppearance.PrimaryTextColor 'Selection text color.
                End If

            Else 'If the subject is clear, set the following properties
                DgvBackColor = Color.FromArgb(205, 212, 220) 'RJColors.LightItemBackground
                RowsColor = RJColors.LightItemBackground
                ColumnHeaderColor = UIAppearance.StyleColor
                ColumnHeaderTextColor = Color.WhiteSmoke
                RowsTextColor = UIAppearance.TextColor
                Me.GridColor = Color.Gainsboro

                If _isAlternatingRowsColor Then
                    AlternatingRowsColor = ColorEditor.Lighten(UIAppearance.StyleColor, 80)
                    SelectionBackColor = ColorEditor.Lighten(UIAppearance.StyleColor, 40)
                    SelectionTextColor = Color.White
                Else
                    SelectionBackColor = ColorEditor.Lighten(UIAppearance.StyleColor, 80)
                    SelectionTextColor = UIAppearance.TextColor
                End If

            End If
        End If
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub ScrollBar_Event(ByVal sender As Object, ByVal e As ScrollEventArgs)
        If e.Type = ScrollEventType.EndScroll Then
            _stopScroll = True
            Me.Invalidate()
        Else
            _stopScroll = False
        End If
    End Sub
#End Region

#Region "-> Overridden methods"
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        ' It is responsible for applying appearance settings at runtime.
        'and validate the minimum height of the column header.
        If Not Me.DesignMode Then ApplyAppearanceSettings() 'Apply UI appearance settings

        If Me.ColumnHeadersHeight < 30 Then
            ColumnHeaderHeight = 30
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        '  Responsible for applying the rounded corners + edge smoothing
        MyBase.OnPaint(e)
        'If the scroll bar is not moving, apply and smooth the rounded edges.
        If _stopScroll = True Then RoundedControl.RegionAndSmoothed(Me, _borderRadius, e.Graphics)
    End Sub
#End Region

End Class

