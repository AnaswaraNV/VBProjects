
Imports System.Text

<Serializable()>
Public Class GameResult
    Property winStatus As StatusEnum.status
    Property arrayOfValue As Integer()

    Public Sub New()

    End Sub
    Public Sub New(winStatus As StatusEnum.status, arrayOfValue() As Integer)
        Me.winStatus = winStatus
        Me.arrayOfValue = arrayOfValue
    End Sub

    Public Overrides Function ToString() As String
        Dim output As New StringBuilder
        For i = 0 To arrayOfValue.Length - 1
            output.Append("button" & i + 1 & " : " & arrayOfValue(i) & " ")
        Next
        Return output.ToString
    End Function

End Class
