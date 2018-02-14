Namespace SupportClass

    Public Class Lab1_5
        ''' <summary>
        ''' Reding the name from user and display in the specific format
        ''' </summary>
        Public Sub New()

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
    End Class

End Namespace