Imports TemperatureConversionClassLibrary
Class MainWindow

    ''' <summary>
    ''' Define window load functionalities
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        'When window loads set the radio as default
        Me.FtoCRadio.IsChecked = True

        'Binding via code
        Dim bindInputTextBox As New Binding
        bindInputTextBox.ElementName = "TextboxOutput"
        bindInputTextBox.Path = New PropertyPath("Text")
        bindInputTextBox.Mode = BindingMode.OneWay
        Me.TextboxInput.SetBinding(TextBox.TextProperty, bindInputTextBox)
    End Sub

    ''' <summary>
    ''' When radio button is checked, input box is cleared
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FtoCRadio_Checked(sender As Object, e As RoutedEventArgs) Handles FtoCRadio.Checked
        Me.TextboxInput.Text = Nothing
        Me.TextboxOutput.Text = Nothing
    End Sub

    ''' <summary>
    ''' When radio button is checked, input box is cleared
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CToFRadio_Checked(sender As Object, e As RoutedEventArgs) Handles CToFRadio.Checked
        Me.TextboxInput.Text = Nothing
        Me.TextboxOutput.Text = Nothing
    End Sub

    ''' <summary>
    ''' Calling temperature changed function when input textbox value is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextboxInput_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TextboxInput.TextChanged
        Me.TextboxInput.Text = TextboxInput.Text

        Dim temperature As Double
        'If parsing successfull 
        If Double.TryParse(Me.TextboxInput.Text, temperature) Then
            'Calling temperature conversion object
            Dim conversionObject As TemperatureConversion
            conversionObject = New TemperatureConversion(temperature)
            If Me.FtoCRadio.IsChecked Then
                Me.TextboxOutput.Text = conversionObject.FarenheitToCelcius().ToString
            ElseIf Me.CToFRadio.IsChecked Then
                Me.TextboxOutput.Text = conversionObject.CelciusToFarenheit().ToString
            End If '
        Else
            CheckForValidity(Me.TextboxInput.Text)

        End If

    End Sub
    ''' <summary>
    ''' Checking for validity in input box.If the user entered a string it will show a message 
    ''' to enter a valid value
    ''' </summary>
    ''' <param name="value"></param>
    Private Sub CheckForValidity(value As String)
        If String.IsNullOrEmpty(value) Then
            Me.errorLabel.Content = ""
            Me.errorLabel.Visibility = Visibility.Hidden
        Else
            Me.errorLabel.Content = "Please enter a valid value"
            Me.errorLabel.Visibility = Visibility.Visible
        End If
    End Sub

End Class
