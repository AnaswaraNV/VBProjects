Class MainWindow
    ''' <summary>
    ''' Defining button click property
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ConcatButton_Click(sender As Object, e As RoutedEventArgs) Handles ConcatButton.Click
        readName()


    End Sub

    Sub readName()
        Dim firstName As String = Nothing
        Dim lastName As String = Nothing
        If String.IsNullOrEmpty(Me.FirstNameTextBox.Text) Then
            MessageBox.Show("Please enter a valid value in " & Me.FirstNameTextBox.Name)
        Else
            firstName = Me.FirstNameTextBox.Text
            If String.IsNullOrEmpty(Me.LastNameTextBox.Text) Then
                MessageBox.Show("Please enter a valid value in " & Me.LastNameTextBox.Name)
            Else
                lastName = Me.LastNameTextBox.Text
            End If
        End If
        concatName(firstName, lastName)
    End Sub

    ''' <summary>
    ''' Concatenate first and last name
    ''' </summary>
    ''' <param name="firstName"></param>
    ''' <param name="lastName"></param>
    Sub concatName(firstName As String, lastName As String)
        If Not (String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName)) Then
            MessageBox.Show("Full Name is : " & firstName & " " & lastName)
        End If
        FirstNameTextBox.Text = String.Empty
        LastNameTextBox.Text = String.Empty
    End Sub
End Class
