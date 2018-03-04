Imports System.Text

Namespace SupportClass
    <Serializable>
    Public Class AppData

        'Property UserObj As List(Of User)
        Property UsersObj As New UserData

        'creating a singleton class 
        Private Shared newInstance As AppData = Nothing

        Public Shared ReadOnly Property Instance()
            Get
                If (newInstance Is Nothing) Then
                    newInstance = New AppData()
                End If
                Return newInstance
            End Get
        End Property

        Public Sub SetUsersObj(userObj)
            Me.UsersObj = userObj
        End Sub

        Public Function GetUserObj() As UserData
            Return Me.UsersObj
        End Function

    End Class
End Namespace