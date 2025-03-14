Module ColorEditor

    ''' <summary>
    ''' With this static class you can lighten or darken a specific color, based on this example:
    ''' https://www.pvladov.com/2012/09/make-color-lighter-or-darker.html Author: Pavel Vladov
    ''' </summary>
    ''' <param name = "color"> "A color to lighten or darken" </param>
    ''' <param name = "percentage"> "The level to lighten or darken the color, the maximum value is 100%" </param>
    ''' <returns> Color </returns>
    ''' 

    Public Function Lighten(color As Color, percentage As UShort) As Color
        'Lighten color
        If percentage <= 100 Then 'the maximum value is 100%
            Dim correctionFactor As Single = percentage / CSng(100) 'Convert percentage to decimals

            Dim red As Single = color.R 'Get the red component
            Dim green As Single = color.G 'Get the green component
            Dim blue As Single = color.B 'Get the blue component

            red = (255 - red) * correctionFactor + red 'Set new red component
            green = (255 - green) * correctionFactor + green 'Set new green component
            blue = (255 - blue) * correctionFactor + blue 'Set new blue component
            Return color.FromArgb(color.A, CInt(red), CInt(green), CInt(blue)) 'Return the lightened color
        Else
            Return color
        End If
    End Function

    Public Function Darken(color As Color, percentage As System.UInt16) As Color
        'Darken color
        If (percentage <= 100) Then
            Dim correctionFactor As Single = ((percentage / CType(100, Single)) * -1) 'Convert the percentage to negative decimals to produce dark colors
            correctionFactor = (1 + correctionFactor) 'Add 1, as sometimes it happens that the color parameter is negative and throws an exception
            Dim red As Single = color.R
            Dim green As Single = color.G
            Dim blue As Single = color.B
            red = (red * correctionFactor)
            green = (green * correctionFactor)
            blue = (blue * correctionFactor)
            Return color.FromArgb(color.A, CType(red, Integer), CType(green, Integer), CType(blue, Integer)) 'Return darkened color
        Else
            Return color
        End If
    End Function
End Module
