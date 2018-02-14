Namespace SupportClass
    Public Class Lab1_1
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
            Try
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
            Catch e As FormatException
                Console.WriteLine("Please check input")
            Catch e As Exception
                Console.WriteLine("Something wrong happened!")
            End Try

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

            Try
                Console.WriteLine("Please enter height:")
                Dim height As Integer = Console.ReadLine()
                For outerCounter = 0 To height - 1
                    For innerCounter = 0 To outerCounter
                        Console.Write("*")
                    Next
                    Console.WriteLine()
                Next
            Catch e As FormatException
                Console.WriteLine("Please check input")
            Catch e As Exception
                Console.WriteLine("Something wrong happened!")
            End Try
        End Sub
    End Class
End Namespace