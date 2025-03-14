Imports System.Drawing.Drawing2D

Module RoundedControl
    '' <summary>
    '' This static class is in charge of making controls with rounded corners.
    '' It has 3 ways to do it:
    '' -Apply the radius border only to the Control Region.
    '' -Apply the Control's Region Radius border + Contour Smoothing.
    '' -Apply the Control's Region Radius border + Contour Smoothing + border Drawing.
    '' </summary>
    ''
#Region "-> Public methods"
    Function GetRoundedGPath(rect As Rectangle, radius As Single) As GraphicsPath
        'This method is responsible for creating the rounded path of a specified rectangle and radius.
        Dim path As GraphicsPath = New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    '// ROUNDED REGION
    Sub RegionOnly(control As Control, radius As Integer)
        'This method takes care of applying a rounded region to a specified control and radius.
        'The rounded corners are not smooth.
        If radius >= 1 Then 'Apply border radius (ROUNDED CONTROL)

            Using roundPath As GraphicsPath = GetRoundedGPath(control.ClientRectangle, radius) 'Get shape path with rounded corners.
                control.Region = New Region(roundPath) 'Apply rounded path as new region.
            End Using
            'If the control is resized, update the rounded region.
            AddHandler control.Resize, Sub(s, e)

                                           Using newRoundPath As GraphicsPath = GetRoundedGPath(control.ClientRectangle, radius)
                                               control.Region = New Region(newRoundPath)
                                           End Using
                                       End Sub
        Else 'Do not apply border radius (RECTANGULAR CONTROL)
            'Reset the region
            control.Region = New Region(control.ClientRectangle)
            AddHandler control.Resize, Sub(s, e)
                                           control.Region = New Region(control.ClientRectangle)
                                       End Sub
        End If
    End Sub

    '// ROUNDED REGION + CONTOUR SMOOTHING
    Sub RegionAndSmoothed(control As Control, radius As Integer, graph As Graphics)
        'This method takes care of applying a rounded region and smoothing the contour of the control
        'to obtain high-quality rounded corners with smooth borders (Not pixelated).
        'Use this method from the Paint event of the control.
        If radius > 1 Then 'Apply border radius (ROUNDED CONTROL)

            Using roundPath As GraphicsPath = GetRoundedGPath(control.ClientRectangle, radius) 'Get shape path with rounded corners.
                Using penSmoothing As Pen = New Pen(control.Parent.BackColor, 1) 'Pen for contour smoothing, the color must be equal to the background color of its container.
                    graph.SmoothingMode = SmoothingMode.AntiAlias
                    control.Region = New Region(roundPath) 'Apply rounded path as new region.
                    graph.DrawPath(penSmoothing, roundPath) 'Draw the rounded path to smooth the outline of the control.
                End Using
            End Using
        Else 'Do not apply border radius (RECTANGULAR CONTROL)
            control.Region = New Region(control.ClientRectangle) 'Reset the region.
        End If
    End Sub

    'ROUNDED REGION + CONTOUR SMOOTHING + border DRAWING
    Sub RegionAndBorder(control As Control, radius As Integer, graph As Graphics, borderColor As Color, borderSize As Single)
        'This method takes care of applying a rounded region and smoothing the contour of the control
        'to obtain high-quality rounded corners with smooth borders (Non-pixelated), in addition to drawing the border of the control.
        'Use this method from the Paint event of the control.
        If radius > 1 Then 'Apply border radius (ROUNDED CONTROL)

            Using roundPath As GraphicsPath = GetRoundedGPath(control.ClientRectangle, radius) 'Get shape path with rounded corners.
                Using penSmoothing As Pen = New Pen(control.Parent.BackColor, borderSize + 1) 'Pen for smoothing the contour, the color must be equal to the background color of its container.
                    Using penBorder As Pen = New Pen(borderColor, borderSize) 'Pen to draw the border of the control
                        Using transform As Matrix = New Matrix() 'Matrix to scale the graph object and draw the border.
                            graph.SmoothingMode = SmoothingMode.AntiAlias
                            control.Region = New Region(roundPath) 'Apply rounded path as new region.
                            graph.DrawPath(penSmoothing, roundPath) 'Draw the rounded path to smooth the outline of the control.

                            'Draw the rounded border of the control.
                            'For this purpose it is necessary to scale the dimensions of the path within the smoothing drawing above.
                            If borderSize >= 1 Then
                                Dim rect As Rectangle = control.ClientRectangle
                                Dim scaleX As Single = 1.0F - ((borderSize + 1) / rect.Width)
                                Dim scaleY As Single = 1.0F - ((borderSize + 1) / rect.Height)
                                transform.Scale(scaleX, scaleY)
                                transform.Translate(borderSize / 1.6F, borderSize / 1.6F)
                                graph.Transform = transform 'Apply the scaling to the graphics object.
                                graph.DrawPath(penBorder, roundPath) 'Draw the border of the control.
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Else 'Do not apply border radius (RECTANGULAR CONTROL)
            control.Region = New Region(control.ClientRectangle) 'Reset the region.

            If borderSize >= 1 Then 'Draw rectangular border
                Using penBorder As Pen = New Pen(borderColor, borderSize)
                    penBorder.Alignment = PenAlignment.Inset
                    graph.DrawRectangle(penBorder, 0, 0, control.Width - 0.5F, control.Height - 0.5F)
                End Using
            End If
        End If
    End Sub

#End Region

End Module



