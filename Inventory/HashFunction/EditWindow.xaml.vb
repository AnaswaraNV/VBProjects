Imports HashFunction.SupportClass

Public Class EditWindow
    'Property Position As Integer
    Property UserObject As New User
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub SetUser(user As User)
        Me.UserObject = user
    End Sub

    ''' <summary>
    ''' check if user exist, if yes check for validity and update the user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub submitButton_Click(sender As Object, e As RoutedEventArgs) Handles submitButton.Click

        Dim FirstValid As Boolean = FirstNameValidation()
        Dim LastValid As Boolean = LastNameValidation()
        Dim EmailValid As Boolean = EmailValidation()
        Dim PasswordValid As Boolean = PasswordValidation()
        If FirstValid AndAlso LastValid AndAlso EmailValid AndAlso PasswordValid Then
            SetUserValues()
            Me.successButton.Visibility = Visibility.Visible
            Me.successButton.Content = "Successfully added"
        End If
    End Sub

    Public Sub PopulateUserValues()

        Me.FirstTextBox.Text = Me.UserObject.GetFirstName()
        Me.LastTextBox.Text = Me.UserObject.GetLastName()
        Me.EmailTextBox.Text = Me.UserObject.GetEmail()
    End Sub
    Public Sub SetUserValues()
        Me.UserObject.SetFirstName(Me.FirstTextBox.Text)
        Me.UserObject.SetLastName(Me.LastTextBox.Text)
        Me.UserObject.SetEmail(Me.EmailTextBox.Text)
        Me.UserObject.SetPassword(Me.PasswordTextBox.Text)
    End Sub

    Private Sub EditWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        PopulateUserValues()
    End Sub

    Public Function FirstNameValidation() As Boolean
        Dim isValid As Boolean = False
        If Not String.IsNullOrEmpty(Me.UserObject.FirstName) Then
            isValid = True
        Else
            MessageBox.Show("Firstname is empty")
        End If
        Return isValid
    End Function

    Public Function LastNameValidation() As Boolean
        Dim isValid As Boolean = False
        If Not String.IsNullOrEmpty(Me.UserObject.LastName) Then
            isValid = True
        Else
            MessageBox.Show("Last name empty")
        End If
        Return isValid
    End Function

    Public Function EmailValidation() As Boolean
        Dim isValid As Boolean = False
        'Dim pattern As String = "(\w+)\s+(car)"

        If Not String.IsNullOrEmpty(Me.UserObject.Email) Then
            isValid = True
        Else
            MessageBox.Show("Email empty")
        End If
        Return isValid
    End Function
    Public Function PasswordValidation() As Boolean
        Dim isValid As Boolean = False
        If Not String.IsNullOrEmpty(Me.UserObject.Password) Then
            isValid = True
        Else
            MessageBox.Show("Password empty")
        End If
        Return isValid
    End Function
End Class
