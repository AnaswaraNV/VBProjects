Imports ReImplementatiom.SupportClass
Module Module1

    Sub Main()
        Console.BackgroundColor = ConsoleColor.Gray
        Console.ForegroundColor = ConsoleColor.DarkMagenta
        Try
            selectLabNumber()

        Catch e As Exception
            Console.WriteLine("Input is wrong")

        End Try

    End Sub

    Sub selectLabNumber()
        Dim questionNumber As Integer

        Do
            questionNumber = displayMenu()
            Select Case questionNumber
                Case 1
                    Console.WriteLine("Executing Lab 1-1 ... ")
                    executeCase1()
                    Console.WriteLine("Any key to continue...")
                    Console.ReadKey()
                Case 4
                    Console.WriteLine("Executing Lab 1-4 ... ")
                    executeCase4()
                    Console.WriteLine("Any key to continue...")
                    Console.ReadKey()
                Case 5
                    Console.WriteLine("Executing Lab 1-5 ... ")
                    executeCase5()
                    Console.WriteLine("Any key to continue...")
                    Console.ReadKey()
                Case 6
                    Console.WriteLine("Exiting...")
                Case Else
                    Console.WriteLine("You have to enter number from 1 to 5 and 6 to Exit!!")
                    selectLabNumber()
            End Select
        Loop Until questionNumber = 6
    End Sub
    ''' <summary>
    ''' Displaying menu to user and returning the question number
    ''' </summary>
    ''' <returns></returns>
    Public Function displayMenu() As Integer
        Console.WriteLine("Week1 Lab Questions")
        Console.WriteLine("#######################################")
        Console.WriteLine("****Lab 1_1 - 1")
        Console.WriteLine("****Lab 1_4 - 4")
        Console.WriteLine("****Lab 1_5 - 5")
        Console.WriteLine("****Exit - 6")
        Console.WriteLine("Enter the question number to view the answer: (eg : 1 (for Lab1_1))")
        Dim questionNumber As Integer
        If Integer.TryParse(Console.ReadLine(), questionNumber) Then
            Console.WriteLine("Option you entered is " & questionNumber)
        Else
            Console.WriteLine("Please enter a number")
        End If

        Return questionNumber
    End Function

    Sub executeCase1()
        Dim obj As New Lab1_1()
        obj.PrintAsterisksSquare()

        Console.WriteLine("Any key to continue...")
        Console.ReadKey()

        obj.PrintAsterisksSquareDynamic()

        Console.WriteLine("Any key to continue...")
        Console.ReadKey()

        obj.PrintAsterisksTriangle()

        Console.WriteLine("Any key to continue...")
        Console.ReadKey()

        obj.PrintAsterisksTriangleDynamic()

        Console.WriteLine("Any key to continue...")
        Console.ReadKey()
    End Sub

    Sub executeCase4()

        Dim obj As New Lab1_4()

    End Sub

    Sub executeCase5()
        Dim obj As New Lab1_5()
    End Sub

End Module
