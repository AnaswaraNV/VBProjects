Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports HashFunction.SupportClass

Class MainWindow
    Private Sub MenuItemNew_Click(sender As Object, e As RoutedEventArgs)
        'display registration window
        Dim regWindow As New RegistrationForm
        regWindow.Show()

    End Sub
    Private Sub MenuItemRead_Click(sender As Object, e As RoutedEventArgs)
        Dim implObj As New InterfaceImpl()
        implObj.ReadUSer()
    End Sub

    Private Sub MenuItemDelete_Click(sender As Object, e As RoutedEventArgs)
        Dim delWindow As New DeleteWindow
        delWindow.Show()
    End Sub

    Private Sub MenuItemUpdate_Click(sender As Object, e As RoutedEventArgs)

        Dim editWindow As New EditWindow1
        editWindow.Show()
    End Sub
    Private Sub MenuItemByName_Click(sender As Object, e As RoutedEventArgs)
        Dim searchWNameObj As New SearchWindowByName
        searchWNameObj.Show()
    End Sub

    Private Sub MenuItemByEmail_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Under Construction!!!")
    End Sub
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        'creating appdata instance and setting to the instance
        Dim appData As AppData = AppData.Instance
        Dim userData As New UserData

        Try
            'deserialize the game history object
            Dim binaryFormatter As New BinaryFormatter()
            Dim streamReader As StreamReader = New StreamReader("C:\temp\DataFile.bin")
            userData = DirectCast(binaryFormatter.Deserialize(streamReader.BaseStream), UserData)
            appData.SetUsersObj(userData)
            streamReader.Close()
            MessageBox.Show("Successfully deserialized the object")
        Catch fe As FileNotFoundException
            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create("C:\temp\DataFile.bin")
        Catch se As SerializationException
            'do nothing
        End Try
    End Sub


    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'serialize the game history object
        Dim streamWriter As StreamWriter = New StreamWriter("C:\temp\DataFile.bin")

        'creating appData instance And setting to the instance
        Dim appData As AppData = AppData.Instance

        Dim binaryFormatter As New BinaryFormatter()
        binaryFormatter.Serialize(streamWriter.BaseStream, appData.GetUserObj())
        streamWriter.Close()
        MessageBox.Show("successfully serialized")
    End Sub
End Class
