Imports System.Windows.Forms.DataVisualization.Charting

Public Class RJChart
    Inherits Chart

    ''' <summary>
    ''' This class enherits from <Chart/> class.
    ''' This control simply sets the colors from the appearance settings.
    ''' </summary>
    ''' 

#Region "-> Constructor"

    Public Sub New()
        AddHandler HandleCreated, AddressOf Chart_HandleCreated 'Subscribe the HandleCreated event.
    End Sub
#End Region

#Region "-> Private methods"

    Private Sub ApplyAppearanceSettings()


        Me.BackColor = UIAppearance.ItemBackgroundColor 'Set background color

        For Each serie In Me.Series ' Set the appearance of the series

            If serie.ChartType = SeriesChartType.Doughnut OrElse serie.ChartType = SeriesChartType.Pie Then
                serie.LabelForeColor = Color.White
                serie.BorderWidth = 1
                serie.BorderColor = UIAppearance.ItemBackgroundColor
            Else
                serie.LabelForeColor = UIAppearance.TextColor
            End If
        Next

        For Each chartArea In Me.ChartAreas ' Set the appearance for chart areas
            chartArea.BackColor = UIAppearance.ItemBackgroundColor 'Set the background color of the chart area
            'X-axis of the area chart
            chartArea.AxisX.LabelStyle.ForeColor = UIAppearance.TextColor 'Text Color
            chartArea.AxisX.LineColor = ColorEditor.Lighten(UIAppearance.TextColor, 30) 'Line color
            chartArea.AxisX.LineWidth = 2 'Line width
            chartArea.AxisX.MajorTickMark.LineColor = ColorEditor.Lighten(UIAppearance.TextColor, 30) 'Main tick mark line color
            chartArea.AxisX.MajorTickMark.LineWidth = 2 'Main tick mark line width
            chartArea.AxisX.MajorGrid.LineColor = UIAppearance.ItemBackgroundColor 'Color of the main grid line
            chartArea.AxisX.MinorGrid.LineColor = UIAppearance.ActiveBackgroundColor 'Minor Grid Line Color
            'Y-axis of the area chart

            chartArea.AxisY.LabelStyle.ForeColor = UIAppearance.TextColor 'Text Color
            chartArea.AxisY.LineColor = ColorEditor.Lighten(UIAppearance.TextColor, 30) 'Line color
            chartArea.AxisY.LineWidth = 2 'Line width
            chartArea.AxisY.MajorTickMark.LineColor = ColorEditor.Lighten(UIAppearance.TextColor, 30) 'Primary tick mark line color
            chartArea.AxisY.MajorTickMark.LineWidth = 2 'Main tick mark line width
            chartArea.AxisY.MajorGrid.LineColor = UIAppearance.ActiveBackgroundColor 'Color of the main grid line
            chartArea.AxisY.MinorGrid.LineColor = UIAppearance.ActiveBackgroundColor 'Minor Grid Line Color
        Next

        For Each legend In Me.Legends ' Set colors for legends
            legend.BackColor = UIAppearance.ItemBackgroundColor
            legend.ForeColor = UIAppearance.TextColor
            legend.Font = New Font(legend.Font.FontFamily, 8.5F)
        Next

        For Each title In Me.Titles ' Set appearance properties for titles

            If UIAppearance.Theme = UITheme.Dark Then
                title.ForeColor = ColorEditor.Lighten(UIAppearance.TextColor, 30)
            Else
                title.ForeColor = ColorEditor.Darken(UIAppearance.TextColor, 10)
            End If

            title.Font = New Font("Verdana", 11.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte((0))))
            title.Alignment = ContentAlignment.MiddleLeft
        Next
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub Chart_HandleCreated(sender As Object, e As EventArgs)
        'This event occurs when an identifier is created,
        'This event is the one that most closely resembles the Load event.
        ApplyAppearanceSettings() 'Apply appearance settings
    End Sub
#End Region

End Class
