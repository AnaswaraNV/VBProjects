Class MainWindow
    Private Sub VerifyButton_Click(sender As Object, e As RoutedEventArgs) Handles VerifyButton.Click
        readNumber()
    End Sub

    Sub readNumber()
        Dim number As Integer

        If String.IsNullOrEmpty(Me.NumberTextBox.Text) Or Not IsNumeric(Me.NumberTextBox.Text) Then
            MessageBox.Show("please enter a valid number!")
            Me.NumberTextBox.Text = String.Empty
        Else
            If Integer.TryParse(Me.NumberTextBox.Text, number) Then
                If (number >= 10 And number <= 100) Then
                    MessageBox.Show("Great! Number is within the specified range!")
                Else
                    MessageBox.Show("Number not within the range!")
                End If
            End If
            Me.NumberTextBox.Text = String.Empty
        End If

    End Sub
End Class
