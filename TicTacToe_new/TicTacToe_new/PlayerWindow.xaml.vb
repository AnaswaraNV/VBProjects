Public Class PlayerWindow
    'creatng an even to detect when playwer name is updated
    Event OnUpdated(ByVal playerName As String)
    Property playerName As String

    Public Function Button_Click(sender As Object, e As RoutedEventArgs) As String
        setPlayerName(Me.playerTextBox.Text)
        Console.WriteLine("in here")
        If String.IsNullOrEmpty(playerName) Then
            Me.successTexrBox.Visibility = Visibility.Visible
            Me.successTexrBox.Text = "Please enter a valid value"
        End If
        If Not String.IsNullOrEmpty(playerName) Then
            Me.successTexrBox.Visibility = Visibility.Visible
            Me.successTexrBox.Text = "Successfully submitted"
        End If
        RaiseEvent OnUpdated(Me.playerName)
        Return playerName
    End Function

    Public Sub setPlayerName(name As String)
        Me.playerName = name
    End Sub

    Public Function getPlayer() As String
        Return Me.playerName
    End Function
End Class
