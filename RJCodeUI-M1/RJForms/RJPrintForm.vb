Imports System.Drawing.Printing

Public Class RJPrintForm


    ''' <summary>
    ''' This class inherits from the <RJChildForm /> class
    ''' The PARTIAL class is who should inherit from RJChildForm (Found in RJPrintForm.Designer.vb):
    '''     Partial Class RJPrintForm
    '''             Inherits RJChildForm
    ''' It is optional that this class inherits from RJChildForm.
    ''' </summary>
    ''' 

#Region "-> Fields"

    Private screenshot As Image 'Gets or sets the screenshot source
    Private sizeA4 As Size 'Gets or sets the A4 Size
    Private imgDocument As Image 'Gets or sets the Document in image format (this is what is printed)
#End Region

#Region "-> Constructor"

    Public Sub New(_screenshot As Image, docTitle As String)
        InitializeComponent() 'The designer was used to make this form.
        Me.DisableFormOptions = True 'Disable form options
        toolTip1.SetToolTip(btnPrint, "Print document")
        toolTip1.SetToolTip(btnPortrait, "Portrait Orientation")
        toolTip1.SetToolTip(btnLandscape, "Landscape Orientation")
        toolTip1.SetToolTip(btnCancel, "Cancel print")

        sizeA4 = New Size(794, 1123) '96 dpi A4 paper size in pixels
        lblDate.Text = DateTime.Now.ToLongDateString() 'Get current date
        lblTitle.Text = docTitle 'Set document title
        pbContent.Image = _screenshot 'set screenshot to image box content
        screenshot = _screenshot 'Set screenshot field

        '' Set background color of print menu
        If UIAppearance.Theme = UITheme.Dark Then
            Me.pnlPrintMenu.BackColor = RJColors.DarkActiveBackground
        Else
            Me.pnlPrintMenu.BackColor = RJColors.LightItemBackground
        End If

        PortraitOrientation() 'Start the preview in portrait mode
    End Sub
#End Region

#Region "-> Private methods"

    Private Sub PortraitOrientation()
        '' Print layout in portrait mode
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
        printDoc.DefaultPageSettings.Landscape = False 'Disable Landscape mode (enable portrait orientation)
        Me.Size = New Size(960, Screen.FromHandle(Me.Handle).WorkingArea.Height) 'set as size 960 and the entire height of the desktop area
        Me.CenterToScreen() 'Center the form on the current screen
        pnlDocument.Size = sizeA4 'Set the size of the document pane
        pnlDocument.Location = New Point(70, 50) 'Set the location of the document pane
        pbContent.Size = New Size(pnlHeader.Width, 1000) 'Set the size of the Content image box.

        'Set the image box height equal to the height of the scaled image within the Content image box.
        Dim widhtFactor As Double = CDbl(screenshot.Width) / pbContent.Width 'Get the width factor.
        Dim heightFactor As Double = CDbl(screenshot.Height) / pbContent.Height 'Get the height factor.
        Dim resizeFactor As Double = Math.Max(widhtFactor, heightFactor) 'Return the largest number that indicates what the resizing factor is.

        pbContent.Height = CInt((screenshot.Height / resizeFactor)) 'Set the NEW SIZE of the contained image box (this way the image will be displayed at the top and center).
    End Sub

    Private Sub LandscapeOrientation()
        '' Landscape mode print layout
        If Me.WindowState = FormWindowState.Normal Then Me.MaximizeWindow() 'Maximize window
        printDoc.DefaultPageSettings.Landscape = True 'Set landscape mode
        pnlDocument.Size = New Size(sizeA4.Height - 50, sizeA4.Width) 'Rotate size a4: Width = height-50 (we subtract 50, somehow not the same size) and Height = Width)
        Dim xCenteredLocation As Integer = (Me.Width - pnlDocument.Width) / 2 'Get the X coordinate to center the document pane
        pnlDocument.Location = New Point(xCenteredLocation, 50) 'Set the location of the document pane
        pbContent.Size = New Size(pnlHeader.Width, 680) 'Set the size of the contained image box.

        'Set the height of the Content image box equal to the height of the scaled image within the Content image box.
        Dim widhtFactor As Double = CDbl(screenshot.Width) / pbContent.Width
        Dim heightfactor As Double = CDbl(screenshot.Height) / pbContent.Height
        Dim resizeFactor As Double = Math.Max(widhtFactor, heightfactor)

        pbContent.Height = CInt((screenshot.Height / resizeFactor)) 'Set the NEW SIZE of the contained image box (this way the image will be displayed at the top and center).
    End Sub

    Private Sub PrintDocument()
        'Responsible method of printing
        Dim bmpScreenshot = New Bitmap(pnlDocument.Width, pnlDocument.Height) 'Set bitmap object to desktop pane size
        pnlDocument.DrawToBitmap(bmpScreenshot, New Rectangle(0, 0, bmpScreenshot.Width, bmpScreenshot.Height)) 'Draw the document pane on the bitmap
        imgDocument = CType(bmpScreenshot, Image) 'Set the screenshot of the document to print

        Try
            printDoc.Print() 'Start printing the document.
            'This method calls the PrintPage event (Private Sub printDoc_PrintPage (sender As Object, e As PrintPageEventArgs))
        Catch ex As Exception
            RJMessageBox.Show("There was a problem trying to print. Please try again." & VbLf & "Details" & vbLf & ex.Message)
        End Try
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        e.Graphics.DrawImage(imgDocument, 0, 0) 'Draw imgDocument to printDocument and print the image.
    End Sub

    Private Sub btnLandscape_Click(sender As Object, e As EventArgs) Handles btnLandscape.Click
        LandscapeOrientation()
    End Sub

    Private Sub btnPortrait_Click(sender As Object, e As EventArgs) Handles btnPortrait.Click
        PortraitOrientation()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument()
    End Sub
#End Region

End Class