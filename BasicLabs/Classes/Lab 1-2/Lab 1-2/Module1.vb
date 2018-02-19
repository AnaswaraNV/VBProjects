Imports System.Text

Module Module1

    Sub Main()

        Console.BackgroundColor = ConsoleColor.Gray
        Console.ForegroundColor = ConsoleColor.DarkMagenta

        'Step1: Secret Word creation
        Dim secretWord As String = SecretWordCreation()

        'Step2: New Word with - creaton
        Dim newWord As StringBuilder = NewWordCreation(secretWord)
        Console.WriteLine("secret Word length: " & secretWord.Length)

        'Call the word processing function
        Dim resultStatus As Boolean = WordProcess(newWord, secretWord)

        If (resultStatus) Then
            Console.WriteLine("Congrats!You guessed it correctly!")
        Else
            Console.WriteLine("You reached Maximum 3 wrong attempt limit!! Start from top again!")
        End If

    End Sub
    Public Function SecretWordCreation() As String
        'secret word
        Dim secretWord As String = "VisualBasic"
        Return secretWord
    End Function

    Public Function NewWordCreation(secretWord As String) As StringBuilder
        If String.IsNullOrWhiteSpace(secretWord) Then
            Throw New ArgumentException("message", NameOf(secretWord))
        End If

        Dim newWord As New StringBuilder()
        'Creating new Word with '-' 
        For i = 0 To secretWord.Length - 1
            newWord = newWord.Append("-")
        Next
        Console.WriteLine(newWord)
        Console.WriteLine()

        Return newWord
    End Function

    Public Function WordProcess(newWord As StringBuilder, secretWord As String) As Boolean
        'variable declarations 
        Dim i As Integer
        Dim userInput As String
        Dim wrongAttempt As Integer = 3
        Dim resultStatus As Boolean = False

        'Loop to read from user until the user attempted 3 mistakes 
        Do
            Dim elementExist As Boolean = False
            'Read letter 
            Console.WriteLine("Type a letter and press <ENTER> ")
            userInput = Console.ReadLine()
            Console.WriteLine("you entered : " & userInput)

            For j As Integer = 0 To secretWord.Length - 1
                Dim character As Char = secretWord(j)
                If (Char.ToUpper(character) = Char.ToUpper(userInput)) Then
                    newWord = newWord.Remove(j, 1)
                    If (j = 0) Then
                        newWord = newWord.Insert(j, Char.ToUpper(character))
                    Else
                        newWord = newWord.Insert(j, character)
                    End If

                    elementExist = True
                End If
            Next
            'Console.WriteLine("elementExist " & elementExist)
            If elementExist = False Then
                wrongAttempt = wrongAttempt - 1
                Console.WriteLine("Attempts Left! : " & wrongAttempt)
            End If
            Console.WriteLine("Secret word is : " & newWord.ToString)

        Loop Until (wrongAttempt = 0 Or newWord.ToString().Equals(secretWord))

        If (newWord.ToString().Equals(secretWord)) Then
            resultStatus = True
        ElseIf wrongAttempt = 0 Then
            resultStatus = False
        End If
        Return resultStatus
    End Function

End Module
