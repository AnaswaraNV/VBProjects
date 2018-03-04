Imports System.Text

Namespace SupportClass
    <Serializable>
    Public Class UserData
        Dim userTable As List(Of User)

        Public Sub SetUserList(user As User)
            If Me.userTable IsNot Nothing Then
                Me.userTable.Add(user)
            Else
                Me.userTable = New List(Of User)
            End If
        End Sub

        Public Function GetUserList() As List(Of User)
            Return userTable
        End Function

        Public Overrides Function Tostring() As String
            Dim output As New StringBuilder
            If userTable IsNot Nothing Then
                For i = 0 To userTable.Count - 1
                    output.Append(userTable(i).Tostring())
                Next
            Else
                output.Append("No content to Display")
            End If
            Return output.ToString
        End Function

    End Class
End Namespace