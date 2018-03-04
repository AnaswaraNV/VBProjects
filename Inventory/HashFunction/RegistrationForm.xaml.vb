Imports HashFunction.SupportClass
Public Class RegistrationForm
    Property user As New User

    Private Sub submitButton_Click(sender As Object, e As RoutedEventArgs) Handles submitButton.Click
        setUserValues()
        Dim NameValid As Boolean = UserNameValidation()
        Dim FirstValid As Boolean = FirstNameValidation()
        Dim LastValid As Boolean = LastNameValidation()
        Dim EmailValid As Boolean = EmailValidation()
        Dim PasswordValid As Boolean = PasswordValidation()
        If NameValid AndAlso FirstValid AndAlso LastValid AndAlso EmailValid AndAlso PasswordValid Then
            Me.successButton.Visibility = Visibility.Visible
            'creating appdata instance and setting to the instance
            Dim appData As AppData = AppData.Instance
            appData.GetUserObj().SetUserList(user)

            Me.successButton.Content = "Successfully added"
        Else
            MessageBox.Show("please Enter valid Details")
        End If
    End Sub

    Private Sub RegistrationForm_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Me.successButton.Visibility = Visibility.Hidden
    End Sub

    Public Sub SetUserValues()
        Me.user.SetUserName(Me.UserTextBox.Text)
        Me.user.SetFirstName(Me.FirstTextBox.Text)
        Me.user.SetLastName(Me.LastTextBox.Text)
        Me.user.SetEmail(Me.EmailTextBox.Text)
        Me.user.SetPassword(Me.PasswordTextBox.Text)
    End Sub

    Public Function getUser() As User
        Return Me.user
    End Function
    Public Function UserNameValidation() As Boolean
        Dim isValid As Boolean = False

        If Not String.IsNullOrEmpty(Me.user.UserName) Then
            Dim userName As String = Me.UserTextBox.Text
            isValid = True
        Else
            MessageBox.Show("user name empty")
        End If
        Return isValid
    End Function

    Public Function FirstNameValidation() As Boolean
        Dim isValid As Boolean = False
        If Not String.IsNullOrEmpty(Me.user.FirstName) Then
            isValid = True
        Else
            MessageBox.Show("Firstname is empty")
        End If
        Return isValid
    End Function

    Public Function LastNameValidation() As Boolean
        Dim isValid As Boolean = False
        If Not String.IsNullOrEmpty(Me.user.LastName) Then
            isValid = True
        Else
            MessageBox.Show("Last name empty")
        End If
        Return isValid
    End Function

    Public Function EmailValidation() As Boolean
        Dim isValid As Boolean = False
        'Dim pattern As String = "(\w+)\s+(car)"

        If Not String.IsNullOrEmpty(Me.user.Email) Then
            isValid = True
        Else
            MessageBox.Show("Email empty")
        End If
        Return isValid
    End Function

    Public Function PasswordValidation() As Boolean
        Dim isValid As Boolean = False
        If Not String.IsNullOrEmpty(Me.user.Password) Then
            isValid = True
        Else
            MessageBox.Show("Password empty")
        End If
        Return isValid
    End Function

End Class
