Imports System.ComponentModel

Public Class RJPictureBox
    Inherits PictureBox

#Region "-> Fields"
    Private _borderColor As Color = Color.RoyalBlue
    Private _borderSize As Integer = 0
    Private _borderRadius As Integer = 0
    Private _customizable As Boolean = True
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
        If _customizable = False Then
            _borderColor = UIAppearance.StyleColor
        End If
    End Sub
#End Region

#Region "-> Overridden methods"
    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        ApplyAppearanceSettings()
    End Sub

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        Me.BackColor = Me.Parent.BackColor
        RoundedControl.RegionAndBorder(Me, _borderRadius, pe.Graphics, _borderColor, _borderSize)
    End Sub
#End Region
End Class
