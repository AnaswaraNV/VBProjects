'Author: Anaswara NV
'Purpose: Lab1-5
'Program to display user entered text diagonally
Module Module1

    Sub Main()
        Console.WriteLine("Enter your name")
        Dim name As String = Console.ReadLine()
        Dim length As Integer = name.Length
        For outerCounter = 0 To length - 1
            For innerCounter = 0 To outerCounter
                If innerCounter = outerCounter Then
                    Dim character As Char = name.Chars(outerCounter)
                    Console.Write(character)
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
