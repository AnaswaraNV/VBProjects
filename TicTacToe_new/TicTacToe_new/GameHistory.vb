
Imports System.Text

<Serializable()>
Public Class GameHistory

    Property totalNoOfGames As Integer = 0
    Property gameObj As New List(Of GameResult)

    Public Sub setGameObj(gameObj As GameResult)
        Me.gameObj.Add(gameObj)
    End Sub

    Public Function increment() As Integer
        Me.totalNoOfGames = totalNoOfGames + 1
        Return totalNoOfGames
    End Function

    Public Overrides Function ToString() As String
        Dim output As New StringBuilder
        For i = 0 To totalNoOfGames - 1
            output.Append("Total games : " & Me.totalNoOfGames & vbNewLine & "GameSteps are shown below for each button. 1- X , 2- O , 0-Empty: " & vbNewLine & gameObj.Item(i).ToString)
        Next
        Return output.ToString
    End Function
End Class
