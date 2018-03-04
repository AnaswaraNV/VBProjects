Imports System.Text
Imports CVBHash
Namespace SupportClass
    <Serializable()>
    Public Class User
        Property UserID As Integer = 1000
        Property UserName As String
        Property FirstName As String
        Property LastName As String
        Property Email As String
        Property Password As String

        'defining getters and setters
        Public Sub SetUserName(UserName As String)
            Me.UserName = UserName
        End Sub

        Public Function GetUserName()
            Return Me.UserName
        End Function

        Public Sub SetFirstName(FirstName As String)
            Me.FirstName = FirstName
        End Sub

        Public Function GetFirstName()
            Return Me.FirstName
        End Function
        Public Sub SetLastName(LastName As String)
            Me.LastName = LastName
        End Sub

        Public Function GetLastName()
            Return Me.LastName
        End Function

        Public Sub SetEmail(Email As String)
            Me.Email = Email
        End Sub

        Public Function GetEmail()
            Return Me.Email
        End Function

        Public Sub SetPassword(Password As String)
            Dim sHAHashMethods As New SHAHashMethods()
            Me.Password = sHAHashMethods.StringToSHA256Managed(Password)
        End Sub

        Public Function GetPassword()
            Return Me.Password
        End Function

        Public Overrides Function Tostring() As String
            Dim output As New StringBuilder
            output.Append("UserName: " & Me.UserName & vbNewLine)
            output.Append("FirstName: " & Me.FirstName & vbNewLine)
            output.Append("LastName: " & Me.LastName & vbNewLine)
            output.Append("Email: " & Me.Email & vbNewLine)
            output.Append("Password: " & Me.Password & vbNewLine)
            Return output.ToString()
        End Function

    End Class
End Namespace