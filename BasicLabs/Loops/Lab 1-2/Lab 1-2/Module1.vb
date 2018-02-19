'Programmer: Anaswara NV
'Purpose: Week1 Lab1-2
'Create a console application: Lab 1-2​ which prompts the user to enter a number from 10
'to 100.
' If the user enters a number within that range display the number entered, if Not display
'“Invalid number​”. Keep on prompting the user to enter the number until the correct
'number Is entered.


Module Module1

    Sub Main()
        Console.WriteLine("Please enter a number within 10 to 100")
        Dim number As Integer = Console.ReadLine()
        Dim inputStatus As Boolean = True
        While inputStatus
            If (number > 10 And number < 100) Then
                Console.WriteLine("Great!number is " & number)
                inputStatus = False
            Else
                inputStatus = True
                Console.WriteLine("invalid number.Please try again!")
                number = Console.ReadLine()
            End If
        End While
    End Sub

End Module
