Imports HashFunction.SupportClass

Public Class DeleteWindow
    Property userName As String

    Private Sub DelButton_Click(sender As Object, e As RoutedEventArgs) Handles DelButton.Click
        If Not String.IsNullOrEmpty(Me.DelTextBox.Text) Then
            Me.userName = Me.DelTextBox.Text
            Dim implObj As New InterfaceImpl()
            Dim status As Boolean = implObj.DeleteUser(Me.userName)
            Me.MsgBox.Visibility = Visibility.Visible
            If status Then
                Me.MsgBox.Text = "Successfully Deleted"
            Else
                Me.MsgBox.Text = "User doesn't Exist"
            End If
        Else
            MessageBox.Show("Please enter a valid user name")
        End If

    End Sub

    Private Sub DeleteWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Me.MsgBox.Visibility = Visibility.Hidden
    End Sub

    Public Function GetUSerName()
        Return Me.userName
    End Function
End Class
