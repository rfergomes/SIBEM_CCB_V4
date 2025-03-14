Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class RJDragControl
    Inherits Component

    ''' <summary>
    ''' This class inherits from the component class, Component is the base class for all components
    ''' in the common language runtime that marshal by reference. In this case, it is basically to 
    ''' convert this class to a control without design (component)
    ''' 
    ''' The <ReleaseCapture/> method is an external function of the user.32 library, this method Releases
    ''' the mouse capture from a window in the current thread and restores normal mouse input processing.
    ''' 
    ''' The <SendMessage/> method is an external function of the user.32 library, this method Sends the specified 
    ''' message to a window or windows. The SendMessage function calls the window procedure for the specified 
    ''' window and does not return until the window procedure has processed the message.
    ''' for these 2 previous methods is necessary to import the <user32.DLL/> library of unmanaged code through
    ''' Interop services <System.Runtime.InteropServices/>
    ''' <see cref="DllImportAttribute"/>([DllImport("dll name")]), Indicates that the attributed  
    ''' method is exposed by an unmanaged dynamic-link library (DLL) as a static entry point
    ''' </summary>
    ''' 

#Region "-> Fields"

    Private _dragControl As Control 'Gets or sets the control responsible for dragging the form
    Private _targetForm As Form 'Gets or sets the target form to drag
#End Region

#Region "-> Constructors"

    Public Sub New()
        'Constructor without parameters
    End Sub

    Public Sub New(container As IContainer) 'This constructor is automatically invoked in the form designer when the control is dragged from the toolbox onto the form.
        'Initializes a new instance and associates it with the specified container.
        'This constructor ensures that the object is removed correctly, as it is not a child of the form.
        container.Add(CType(Me, IComponent))
    End Sub

    Public Sub New(dragControl As Control, targetForm As Form)
        _targetForm = targetForm
        _dragControl = dragControl
        AddHandler _dragControl.MouseDown, AddressOf Control_MouseDown 'Subscribe MouseDown event - Occurs when mouse button is held down on drag control
    End Sub

    Public Sub New(dragControl As Control, targetForm As Form, container As IContainer)
        'Initializes a new instance and associates it with the specified container.
        'This constructor ensures that the object is removed correctly, as it is not a child of the form.
        container.Add(CType(Me, IComponent))
        _targetForm = targetForm
        _dragControl = dragControl
        AddHandler _dragControl.MouseDown, AddressOf Control_MouseDown 'Subscribe MouseDown event - Occurs when mouse button is held down on drag control
    End Sub
#End Region

#Region "-> Properties"

    <Category("RJ Code Advance")>
    <Description("Set the control responsible for dragging the form")>
    Public Property DragControl As Control
        Get
            Return _dragControl
        End Get
        Set(value As Control)
            _dragControl = value 'Set the drag control

            If _dragControl IsNot Nothing Then
                AddHandler _dragControl.HandleCreated, AddressOf Control_Created 'Associate the HandleCreated event: occurs when the control is displayed for the first time in its container (form, panel, etc.)
                AddHandler _dragControl.MouseDown, AddressOf Control_MouseDown 'Associate MouseDown event: Occurs when mouse button is held down on drag control
            End If
        End Set
    End Property
#End Region

#Region "-> External methods"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
#End Region

#Region "-> Event methods"

    Private Sub Control_Created(sender As Object, e As EventArgs)
        'Occurs when the control is first displayed in its container (form, panel, etc.)
        If Not Me.DesignMode Then _targetForm = _dragControl.FindForm() 'Find the form the control belongs to and set as the target form to drag
    End Sub

    Private Sub Control_MouseDown(sender As Object, e As MouseEventArgs)
        'Occurs when the mouse button is held down on the control and moving it will drag the form
        ReleaseCapture() 'Release the mouse capture from a window
        SendMessage(_targetForm.Handle, &H112, &HF012, 0) 'Send message to window
        '<param value = "targetForm.Handle"> send target form handler to drag </param>
        '<param value = "0x112"> Send WM_SYSCOMMAND as message </param>
        '<param value = "0xf012"> Send a false click on the title bar (Clicking on the title bar generates 0xF012) </param>
    End Sub
#End Region

End Class

