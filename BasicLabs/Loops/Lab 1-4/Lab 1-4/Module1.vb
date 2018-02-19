'Programmer: Anaswara NV
'Purpose: Lab 1-4
'Program to calculate GPA

Module Module1

    Sub Main()

        ' Array Example
        ' Declare, initialize, and assign value
        Dim counter As Integer = 0
        Dim subjectArray(4) As String
        Dim gradeArray(4) As String
        Dim gradeValue As String
        Dim gpaArray(4) As Double
        Dim total As Double = 0
        Dim cumulativeGpa As Double = 0
        Console.WriteLine("Please enter 5 Subject Names (Press enter after each subject name)")
        While counter < 5
            Dim value As String = Console.ReadLine()
            subjectArray(counter) = value
            counter = counter + 1
        End While
        Console.WriteLine("Press any key to continue")
        Console.ReadKey()
        counter = 0
        Console.WriteLine("Please enter corresponding Grades(Press enter after each subject name)")
        While counter < 5
            gradeValue = Console.ReadLine()
            gradeArray(counter) = gradeValue.ToUpper
            counter = counter + 1
        End While
        For counter = 0 To 4
            Dim grade As String
            grade = gradeArray(counter)
            Select Case grade
                Case "A" To "A+"
                    gpaArray(counter) = 4.0
                Case "B+"
                    gpaArray(counter) = 3.5
                Case "B"
                    gpaArray(counter) = 3.0
                Case "C+"
                    gpaArray(counter) = 2.5
                Case "C"
                    gpaArray(counter) = 2.0
                Case "D+"
                    gpaArray(counter) = 1.5
                Case "D"
                    gpaArray(counter) = 1.0
                Case Else
                    gpaArray(counter) = 0.0
            End Select
            total = total + gpaArray(counter)
        Next
        cumulativeGpa = total / 5
        Console.WriteLine("Press any key to continue")
        Console.ReadKey()
        Console.WriteLine("######################################")
        For counter = 0 To 4
            Console.WriteLine(subjectArray(counter) & " " & gradeArray(counter) & " " & gpaArray(counter))
        Next
        Console.WriteLine("cumulativeGpa: " & cumulativeGpa)
        Console.WriteLine("######################################")
        Console.WriteLine("Press any key to continue")
        Console.ReadKey()

    End Sub

End Module