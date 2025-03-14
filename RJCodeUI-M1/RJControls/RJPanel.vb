Imports System.ComponentModel

Public Class RJPanel
    Inherits Panel

    ''' <summary>
    ''' This control has no additional customization properties, 
    ''' it simply sets the background color based on the theme set by the appearance settings.
    ''' and set a border radius
    ''' </summary>
    ''' 

#Region "-> Fields"
    Private _customizable As Boolean 'Gets or sets whether the appearance colors are customizable
    Private _borderRadius ' Gets or sets the border radius
#End Region

#Region "-> Properties"
    <Category("RJ Code Advance")>
    <Description("Gets or sets whether the control's appearance colors are customizable")>
    Public Property Customizable As Boolean
        Get
            Return _customizable
        End Get
        Set(ByVal value As Boolean)
            _customizable = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    <Description("Gets or sets the border radius")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property
#End Region

#Region "-> Private methods"
    Private Sub ApplyAppearanceSettings()
        'Apply appearance settings
        If Customizable = False Then
            Me.BackColor = Color.FromArgb(205, 212, 220) 'UIAppearance.ItemBackgroundColor
        End If
    End Sub
#End Region

#Region "-> Overridden methods"
    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        'Apply appearance settings
        ApplyAppearanceSettings()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        'Rounded Control
        RoundedControl.RegionAndSmoothed(Me, _borderRadius, e.Graphics)
    End Sub

#End Region

End Class
