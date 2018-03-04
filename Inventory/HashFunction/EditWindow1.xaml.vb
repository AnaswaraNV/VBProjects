Imports HashFunction.SupportClass

Public Class EditWindow1

    Private Sub searchButton_Click(sender As Object, e As RoutedEventArgs) Handles searchButton.Click
        If Not String.IsNullOrEmpty(Me.updTextBox.Text) Then
            Dim userName As String = Me.updTextBox.Text
            Dim implObj As New InterfaceImpl()
            Dim user As New User
            user = implObj.SearchUserByName(userName)
            If user.GetFirstName() IsNot Nothing Then
                Dim editWindow As New EditWindow
                editWindow.SetUser(user)
                editWindow.Show()
            Else
                Me.MsgBox.Visibility = Visibility.Visible
                Me.MsgBox.Text = "User Doesn't Exist!!!"
            End If
        Else
            MessageBox.Show("Please enter a valid input!")
        End If
    End Sub
End Class
