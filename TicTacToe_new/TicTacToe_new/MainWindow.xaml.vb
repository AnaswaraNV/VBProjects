Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Web.Script.Serialization

Class MainWindow

    Property playerName As String
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim playerWindow As New PlayerWindow
        playerWindow.Show()
        'adding event handler on player name updation 
        AddHandler playerWindow.OnUpdated, AddressOf onPlayerNameUpdated

    End Sub

    Private Sub onPlayerNameUpdated(ByVal playerName As String)
        MessageBox.Show("Player name updated" & playerName)
        Me.playerName = playerName

        'after updating player anme other 2 buttons are enabled
        'and player button disabled
        Me.TicButton.IsEnabled = True
        Me.SerializeButton.IsEnabled = True
        Me.playerButton.IsEnabled = False
    End Sub
    Private Sub TicButton_Click(sender As Object, e As RoutedEventArgs) Handles TicButton.Click

        Dim tictacWindow As New TicTacWindow(Me.playerName)
        tictacWindow.Show()

    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        '2 buttons are disabled as we want user to enter player anme first
        Me.TicButton.IsEnabled = False
        Me.SerializeButton.IsEnabled = False
        initializeSerializingProcess()

    End Sub

    Public Sub initializeSerializingProcess()
        Dim gameHistoryObj As New GameHistory
        Dim streamWriter As StreamWriter = New StreamWriter("C:\temp\resultBinary.bin")
        Dim binaryFormatter As New BinaryFormatter()
        binaryFormatter.Serialize(streamWriter.BaseStream, gameHistoryObj)
        streamWriter.Close()
        MessageBox.Show("Successfully initialized the Binary Serialized object")

        Dim gameHistoryOb As New GameHistory
        Dim javaScriptSerializer As New JavaScriptSerializer()
        Dim streamWriterJSON As StreamWriter = New StreamWriter("C:\temp\resultJSON.json")
        streamWriterJSON.WriteLine(javaScriptSerializer.Serialize(gameHistoryOb).ToString())
        streamWriterJSON.Close()
        MessageBox.Show("Successfully serialized the person object")
    End Sub

    Private Sub SerializeButton_Click(sender As Object, e As RoutedEventArgs) Handles SerializeButton.Click
        Dim gameHistoryObj As New GameHistory
        Dim javaScriptSerializer As New JavaScriptSerializer()

        'deserialize the game history object 
        Dim streamReaderJSON As StreamReader = New StreamReader("C:\temp\resultJSON.json")

        gameHistoryObj = JavaScriptSerializer.Deserialize(Of GameHistory)(streamReaderJSON.ReadLine())
        streamReaderJSON.Close()
        MessageBox.Show("Successfully deserialized the historyobject" & gameHistoryObj.ToString())

    End Sub
End Class
