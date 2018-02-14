Namespace SupportClass
    Public Class Lab1_4
        ' Array Example
        ' Declare, initialize, and assign value
        Dim subjectArray(4) As String
        Dim gradeArray(4) As String
        Dim gradeValue As String
        Dim cumulativeGpa As Double
        Dim gpaTable As New Hashtable()

        ''' <summary>
        ''' Read subject array 
        ''' If the status returned is true , read grade array
        ''' If status is true dispaly all details to user
        ''' </summary>
        Public Sub New()
            Dim statusReadSubject As Boolean = readSubjectArray()
            If statusReadSubject Then
                Dim statusReadGrade As Boolean = readGradeArray()
                If statusReadGrade Then
                    displayDetails()
                End If
            End If
        End Sub

        ''' <summary>
        ''' Read subject array and return status of execution
        ''' </summary>
        ''' <returns></returns>
        Function readSubjectArray() As Boolean
            Dim counter As Integer = 0
            Dim statusReadSubject As Boolean = False

            Console.WriteLine("Please enter 5 Subject Names (Press enter after each subject name)")
            Try
                While counter < 5
                    Dim value As String = Console.ReadLine()
                    If value = " " OrElse vbEmpty Then
                        Throw New Exception
                    Else
                        Me.subjectArray(counter) = value
                        counter = counter + 1
                    End If

                End While
                statusReadSubject = True
            Catch e As Exception
                Console.WriteLine("Please enter valid input")
                Console.WriteLine("Error in reading SubjectArray")
            End Try

            Return statusReadSubject
        End Function

        ''' <summary>
        ''' Reead grade array and return status of execution
        ''' </summary>
        ''' <returns></returns>
        Function readGradeArray() As Boolean
            Dim counter As Integer = 0
            Dim total As Double
            Dim statusReadGrade As Boolean = False

            Try
                Console.WriteLine("Please enter corresponding Grades(Press enter after each subject name")
                While counter < 5
                    gradeValue = Console.ReadLine()
                    If gradeValue = " " OrElse vbEmpty Then
                        Throw New Exception
                    Else
                        Me.gradeArray(counter) = gradeValue.ToUpper
                        counter = counter + 1
                    End If
                End While

                gpaTable.Add("A+", 4.0)
                gpaTable.Add("A", 4.0)
                gpaTable.Add("B+", 3.5)
                gpaTable.Add("B", 3.0)
                gpaTable.Add("C+", 2.5)
                gpaTable.Add("C", 2.0)
                gpaTable.Add("D+", 1.5)
                gpaTable.Add("D", 1.0)

                For counter = 0 To 4

                    Dim grade As String
                    grade = Me.gradeArray(counter)
                    total = total + gpaTable.Item(grade)
                Next

                Me.cumulativeGpa = total / 5
                'setting status to true
                statusReadGrade = True

            Catch e As Exception
                Console.WriteLine("Error in reading grade...")
            End Try
            Console.WriteLine("status in reading grade" & statusReadGrade)
            Return statusReadGrade
        End Function

        ''' <summary>
        ''' Display details of student subject , grade and cumulative GPA
        ''' </summary>
        Sub displayDetails()
            Console.WriteLine("######################################")
            For counter = 0 To 4
                Console.WriteLine(Me.subjectArray(counter) & " " & Me.gradeArray(counter) & " " & Me.gpaTable.Item(counter))
            Next
            Console.WriteLine("cumulativeGpa: " & Me.cumulativeGpa)
            Console.WriteLine("######################################")

        End Sub
    End Class
End Namespace