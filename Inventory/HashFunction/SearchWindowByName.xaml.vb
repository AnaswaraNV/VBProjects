Imports HashFunction.SupportClass

Public Class SearchWindowByName

    ''' <summary>
    ''' If user exist, display message 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub searchButton_Click(sender As Object, e As RoutedEventArgs) Handles searchButton.Click
        If Not String.IsNullOrEmpty(Me.srchTextBox.Text) Then
            Dim userName As String = Me.srchTextBox.Text
            Dim implObj As New InterfaceImpl()
            Dim user As New User
            user = implObj.SearchUserByName(userName)
            If user.GetFirstName() IsNot Nothing Then
                Me.MsgBox.Visibility = Visibility.Visible
                Me.MsgBox.Text = "Found user!!!"
                Dim srchDisplayWindow As New SearchDisplayWindow(user)
                srchDisplayWindow.Show()
            Else
                Me.MsgBox.Visibility = Visibility.Visible
                Me.MsgBox.Text = "User Doesn't Exist!!"
            End If
        Else
            MessageBox.Show("Please enter a valid input!")
        End If
    End Sub
End Class
