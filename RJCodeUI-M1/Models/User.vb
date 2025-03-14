Namespace Models
    Public Class User

        ''' <summary>
        ''' This class was created for testing purposes only,
        ''' the data may be inaccurate and meaningless.
        ''' </summary>
        '''  

        Public Property Id As Integer
        Public Property Username As String
        Public Property Password As String
        Public Property FirstName As String
        Public Property LastName As String
        Public Property ProfilePicture As Image
        Public Property Email As String
        Public Property PhoneNumber As String
        Public Property Birthdate As DateTime

        Public Sub New()
        End Sub

        Public Function Login(username As String, pass As String) As User
            Dim user = GetUsers().Find(Function(x) x.Username = username AndAlso x.Password = pass)
            Return user
        End Function

        Private Function GetUsers() As List(Of User)
            Dim UsersList = New List(Of User)()
            UsersList.Add(New User With {
                .Id = 1,
                .Username = "admin",
                .Password = "admin",
                .FirstName = "Rummer John",
                .LastName = "Cranel",
                .ProfilePicture = My.Resources.userProfile,
                .Email = "rummerCranel@gmail.com",
                .PhoneNumber = "16861125 9634",
                .Birthdate = New DateTime(1999, 10, 18)
            })
            UsersList.Add(New User With {
                .Id = 2,
                .Username = "arely",
                .Password = "arely123",
                .FirstName = "Arely",
                .LastName = "Smith",
                .ProfilePicture = My.Resources.userProfile,
                .Email = "Are@gmail.com",
                .PhoneNumber = "16850718 4565",
                .Birthdate = New DateTime(2002, 4, 27)
            })
            Return UsersList
        End Function
    End Class
End Namespace
