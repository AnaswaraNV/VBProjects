
' BINARY
Imports System.Runtime.Serialization.Formatters.Binary
' XML
Imports System.Runtime.Serialization.Formatters.Soap
' JSON
Imports System.Web.Script.Serialization

Imports System.IO
Public Class TicTacWindow
    'array to set the button content values 
    'X  --- 1
    'O  --- 2
    'empty  0
    Property processArray As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0}
    Property valueX As Integer = 1
    Property valueO As Integer = 2
    Dim result As GameResultEnum.result
    Dim winStatus As StatusEnum.status
    Property playerName As String

    Public Sub New(playerName)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.playerName = playerName
    End Sub

    Private Sub TicTacWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Me.helloTextBox.Text = "Hello " & Me.playerName & " , Welcome!!!"
    End Sub

    ''' <summary>
    ''' If a particular button is save the button name and change the content to X
    ''' as this is the user attempted turn
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub Button_Click(sender As Button, e As RoutedEventArgs)
        Dim buttonName As String
        buttonName = sender.Name
        sender.Content = "X"

        Dim position As Char = getButtonNumber(buttonName)
        Dim index As Integer
        If Integer.TryParse(position, index) Then
            'X to 1 in array
            Me.processArray(index - 1) = 1

            'check if is game over
            Dim gameOver As GameResultEnum.result = isGameOver()

            If gameOver = GameResultEnum.result.Win Then
                MessageBox.Show("PlayerWins")
                Me.winStatus = StatusEnum.status.Player
                'have to close window. before that serialize and store ressult
                serializeProcess(Me.winStatus, processArray)
                Me.Close()

            ElseIf gameOver = GameResultEnum.result.Tie Then
                MessageBox.Show("It's a Tie!!")
                serializeProcess(Me.winStatus, processArray)
                Me.Close()
            Else
                processTicTac(index - 1)
                'check if is game over
                gameOver = isGameOver()

                If gameOver = GameResultEnum.result.Win Then
                    MessageBox.Show("Computer Wins")
                    serializeProcess(Me.winStatus, processArray)
                    Me.Close()
                ElseIf gameOver = GameResultEnum.result.Tie Then
                    MessageBox.Show("It's a Tie!!")
                    serializeProcess(Me.winStatus, processArray)
                    Me.Close()

                End If
            End If

        End If

    End Sub

    ''' <summary>
    ''' getting clicked button position
    ''' </summary>
    ''' <param name="buttonName"></param>
    ''' <returns></returns>
    Public Function getButtonNumber(buttonName As String) As Char
        Dim position As Char = buttonName.Chars(6)
        'MessageBox.Show("character is " & position)
        Return position
    End Function

    ''' <summary>
    ''' Processing tic tac toe tile values
    ''' </summary>
    Public Sub processTicTac(index As Integer)
        'setting status of random number 
        Dim randomIsExist = False

        'For i = 0 To processArray.Length
        Do
            Dim myValue As Integer
            myValue = getRandomNumber()

            'if the value at random position is 0, then set it as 2 (computer opted position)
            If Me.processArray(myValue - 1) = 0 Then

                randomIsExist = True
                Me.processArray(myValue - 1) = 2
                Dim newButtonName As String = "button" & myValue
                ' MessageBox.Show("new button name is " & newButtonName)

                'computer uses this button and have to set as O 
                computerPlay(newButtonName)
            ElseIf Me.processArray(myValue - 1) = 1 OrElse Me.processArray(myValue - 1) = 2 Then
                randomIsExist = False
            End If
        Loop Until randomIsExist
        'Next

    End Sub
    ''' <summary>
    ''' Pausing 3 seconds
    ''' </summary>
    Private Sub sleeper()
        Threading.Thread.Sleep(1000)
    End Sub

    ''' <summary>
    '''getting random number  between 0 - 8 
    ''' </summary>
    ''' <returns></returns>
    Private Function getRandomNumber() As Integer
        Dim MyValue
        MyValue = CInt(Math.Round(Rnd() * 8)) + 1
        Return MyValue
    End Function

    Public Sub computerPlay(buttonName As String)
        Dim button As Button
        sleeper()
        'getting the button from name
        button = Me.FindName(buttonName)
        button.Content = "O"

    End Sub

    ''' <summary>
    ''' win possibilites are : (horizontal) 012, 345, 678, (vertical) 036, 147, 258, (diagonal)048, 246 - X or O
    ''' if no win , need to check if 0 in any of the array , if yes game is not over 
    ''' if no win, no zero in array tie
    ''' </summary>
    Private Function isGameOver() As GameResultEnum.result
        Dim gameOver As Boolean = False

        Dim horizontalStatus As Boolean = checkHorizontalRow()
        Dim verticalStatus As Boolean = checkVerticalRow()
        Dim diagonalStatus As Boolean = checkDiagonalRow()

        If horizontalStatus OrElse verticalStatus OrElse diagonalStatus Then
            gameOver = True
            Me.result = GameResultEnum.result.Win
        Else
            Dim status As Boolean = isThereEmptyTiles()
            If status = False Then
                'gameOver = True

                Me.Close()
            End If
        End If

        Return result
    End Function

    Public Function checkHorizontalRow() As Boolean
        Dim status As Boolean = False
        If processArray(0) = 1 AndAlso processArray(1) = 1 AndAlso processArray(2) = 1 Then
            MessageBox.Show("case 1 horizontal")
            status = True
        ElseIf processArray(3) = 1 AndAlso processArray(4) = 1 AndAlso processArray(5) = 1 Then
            MessageBox.Show("case 2 horizontal")
            status = True
        ElseIf processArray(6) = 1 AndAlso processArray(7) = 1 AndAlso processArray(8) = 1 Then
            MessageBox.Show("case 3 horizontal")
            status = True
        ElseIf processArray(0) = 2 AndAlso processArray(1) = 2 AndAlso processArray(2) = 2 Then
            MessageBox.Show("case 4 horizontal")
            status = True
        ElseIf processArray(3) = 2 AndAlso processArray(4) = 2 AndAlso processArray(5) = 2 Then
            MessageBox.Show("case 5 horizontal")
            status = True
        ElseIf processArray(6) = 2 AndAlso processArray(7) = 2 AndAlso processArray(8) = 2 Then
            MessageBox.Show("case 6 horizontal")
            status = True
        End If
        Return status
    End Function

    Public Function checkVerticalRow() As Boolean
        Dim status As Boolean = False
        If processArray(0) = 1 AndAlso processArray(3) = 1 AndAlso processArray(6) = 1 Then
            MessageBox.Show("case 1 Vertical")
            status = True
        ElseIf processArray(1) = 1 AndAlso processArray(4) = 1 AndAlso processArray(7) = 1 Then
            MessageBox.Show("case 2 Vertical")
            status = True
        ElseIf processArray(2) = 1 AndAlso processArray(5) = 1 AndAlso processArray(8) = 1 Then
            MessageBox.Show("case 3 Vertical")
            status = True
        ElseIf processArray(0) = 2 AndAlso processArray(3) = 2 AndAlso processArray(6) = 2 Then
            MessageBox.Show("case 4 Vertical")
            status = True
        ElseIf processArray(1) = 2 AndAlso processArray(4) = 2 AndAlso processArray(7) = 2 Then
            MessageBox.Show("case 5 Vertical")
            status = True
        ElseIf processArray(2) = 2 AndAlso processArray(5) = 2 AndAlso processArray(8) = 2 Then
            MessageBox.Show("case 6 Vertical")
            status = True
        End If
        Return status
    End Function

    Public Function checkDiagonalRow() As Boolean
        Dim status As Boolean = False
        If processArray(0) = 1 AndAlso processArray(4) = 1 AndAlso processArray(8) = 1 Then
            MessageBox.Show("case 1 diagonal")
            status = True
        ElseIf processArray(2) = 1 AndAlso processArray(4) = 1 AndAlso processArray(6) = 1 Then
            MessageBox.Show("case 2 diagonal")
            status = True
        ElseIf processArray(0) = 2 AndAlso processArray(4) = 2 AndAlso processArray(8) = 2 Then
            MessageBox.Show("case 3 diagonal")
            status = True
        ElseIf processArray(2) = 2 AndAlso processArray(4) = 2 AndAlso processArray(6) = 2 Then
            MessageBox.Show("case 4 diagonal")
            status = True
        End If
        Return status
    End Function

    ''' <summary>
    ''' check if any of the tiles are empty , if yes game continues
    ''' </summary>
    ''' <returns></returns>
    Public Function isThereEmptyTiles() As Boolean
        Dim status As Boolean = False
        Me.result = GameResultEnum.result.Tie

        For index = 0 To processArray.Length - 1
            If processArray(index) = 0 Then
                status = True
                Me.result = GameResultEnum.result.Ongoing
            End If
        Next
        Return status
    End Function

    Public Sub serializeProcess(winstatus As StatusEnum.status, processArray As Integer())
        Dim gameResultObj As New GameResult(Me.winStatus, processArray)
        Dim gameHistoryObj As GameHistory
        Dim binaryFormatter As New BinaryFormatter()

        'deserialize the game history object 
        Dim streamReader As StreamReader = New StreamReader("C:\temp\resultBinary.bin")
        gameHistoryObj = DirectCast(binaryFormatter.Deserialize(streamReader.BaseStream), GameHistory)
        streamReader.Close()
        MessageBox.Show("Successfully deserialized the game history object")

        'serialize the game history object
        Dim streamWriter As StreamWriter = New StreamWriter("C:\temp\resultBinary.bin")
        'adding alues to gamehistory object
        gameHistoryObj.setGameObj(gameResultObj)
        gameHistoryObj.increment()


        'binary formatter serialize
        binaryFormatter.Serialize(streamWriter.BaseStream, gameHistoryObj)
        streamWriter.Close()
        MessageBox.Show("Successfully serialized the History object" & vbNewLine & gameHistoryObj.ToString)

        'serialize in csv
        Dim streamWriterCSV As StreamWriter = New StreamWriter("C:\temp\resultCSV.csv")
        streamWriterCSV.WriteLine(gameHistoryObj.totalNoOfGames & "," & gameResultObj.ToString)
        streamWriterCSV.Close()
        MessageBox.Show("Successfully serialized the person object")

        'xml format serialize
        'XML does not support serialization of generic types
        'Dim streamWriterXML As StreamWriter = New StreamWriter("C:\temp\resultXML.xml")
        'Dim xmlFormatter As New SoapFormatter()
        'xmlFormatter.Serialize(streamWriterXML.BaseStream, gameHistoryObj)
        'streamWriterXML.Close()
        'MessageBox.Show("Successfully serialized the history object in xml")

        'serialize in json
        Dim javaScriptSerializer As New JavaScriptSerializer()
        Dim streamWriterJSON As StreamWriter = New StreamWriter("C:\temp\resultJSON.json")
        streamWriterJSON.WriteLine(javaScriptSerializer.Serialize(gameHistoryObj).ToString())
        streamWriterJSON.Close()
        MessageBox.Show("Successfully serialized the history object in json")

    End Sub
End Class
