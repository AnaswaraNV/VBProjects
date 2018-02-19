'Programmer: Anaswara NV
'Purpose: Week1 Lab1-1

Module Module1

    Sub Main()

        'Steps to read from user and display 
        Dim readInput As String
        Console.WriteLine("Hello World")
        readInput = Console.ReadLine()
        Console.WriteLine(readInput)

        ' Wait for the user to press any key before the console window is dismised 
        Console.ReadKey()
        PrintAsterisksSquare()
        PrintAsterisksSquareDynamic()
        PrintAsterisksTriangle()
        PrintAsterisksTriangleDynamic()
    End Sub

    'Sub to print the squares in asterisks
    Sub PrintAsterisksSquare()
        Console.WriteLine("print Asterisks")
        Dim outerCounter As Integer
        For outerCounter = 0 To 4
            For innerCounter = 0 To 4
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    'Sub to print the squares in asterisks dynamically
    Sub PrintAsterisksSquareDynamic()
        Console.WriteLine("print Asterisks dynamically")
        Console.WriteLine("Please Enter height")
        Dim height As Integer = Console.ReadLine()
        Console.WriteLine("Please Enter width")
        Dim width As Integer = Console.ReadLine()
        Dim outerCounter As Integer
        Dim innerCounter As Integer
        For outerCounter = 0 To height - 1
            For innerCounter = 0 To width - 1
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    'Sub to print the asterisks triangle
    Sub PrintAsterisksTriangle()
        Console.WriteLine("print Asterisks triangle")
        Dim outerCounter As Integer = 0
        Dim innerCounter As Integer = 0
        For outerCounter = 0 To 4
            For innerCounter = 0 To outerCounter
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    'Sub to print the asterisks triangle
    Sub PrintAsterisksTriangleDynamic()
        Console.WriteLine("print Asterisks triangle dynamically")
        Dim outerCounter As Integer = 0
        Dim innerCounter As Integer = 0
        Console.WriteLine("Please enter height:")
        Dim height As Integer = Console.ReadLine()
        For outerCounter = 0 To height - 1
            For innerCounter = 0 To outerCounter
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
