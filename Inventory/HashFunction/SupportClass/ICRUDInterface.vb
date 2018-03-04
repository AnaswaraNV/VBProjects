Imports CVBHash

Namespace SupportClass
    Public Interface ICRUDInterface
        Sub CreateUser()
        Sub ReadUSer()
        Sub EditUser(USerName As String)
        Function DeleteUser(UserName As String) As Boolean
        Function SearchUserByName(UserName As String) As User
    End Interface

    Public Class InterfaceImpl
        Implements ICRUDInterface

        Dim userObject As New User

        Public Sub CreateUser() Implements ICRUDInterface.CreateUser

            'creating appdata instance and setting to the instance
            Dim appData As AppData = AppData.Instance

            Dim userObj As New User
            appData.SetUsersObj(appData.UsersObj)

        End Sub

        Public Sub ReadUSer() Implements ICRUDInterface.ReadUSer
            'creating appdata instance and setting to the instance
            Dim appData As AppData = AppData.Instance

            'display window
            Dim displayWindow As New DisplayWindow
            displayWindow.DisplayBlock.Text = appData.GetUserObj().Tostring
            displayWindow.Show()
        End Sub

        Public Sub EditUser(USerName As String) Implements ICRUDInterface.EditUser
            'creating appdata instance and setting to the instance
            Dim appData As AppData = AppData.Instance

        End Sub


        Public Function DeleteUser(UserName As String) As Boolean Implements ICRUDInterface.DeleteUser
            Dim status As Boolean = False
            'creating appdata instance and setting to the instance
            Dim appData As AppData = AppData.Instance

            Dim counter As Integer = appData.GetUserObj().GetUserList().Count - 1
            Dim position As Integer
            For i = 0 To counter
                'Dim password As String = sHAHashMethods.StringToSHA256Managed(appData.GetUserObj().GetUserList().Item(i).GetPassword())
                If appData.GetUserObj().GetUserList().Item(i).GetUserName() = UserName AndAlso status = False Then
                    position = i
                    status = True
                    counter = counter - 1
                End If
            Next
            If status Then
                appData.GetUserObj().GetUserList().RemoveAt(position)
            End If
            Return status
        End Function

        Public Function SearchUserByName(UserName As String) As User Implements ICRUDInterface.SearchUserByName
            Dim status As Boolean = False
            'creating appdata instance and setting to the instance
            Dim appData As AppData = AppData.Instance

            Dim counter As Integer = appData.GetUserObj().GetUserList().Count - 1
            Dim user As New User
            For i = 0 To counter
                'Dim password As String = sHAHashMethods.StringToSHA256Managed(appData.GetUserObj().GetUserList().Item(i).GetPassword())
                If appData.GetUserObj().GetUserList().Item(i).GetUserName() = UserName AndAlso status = False Then
                    user = appData.GetUserObj().GetUserList().Item(i)
                    status = True
                End If
            Next

            Return user
        End Function


    End Class
End Namespace
