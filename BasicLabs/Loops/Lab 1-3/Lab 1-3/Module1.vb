'Programmer: Anaswara NV
'Purpose: Week1 Lab1-3
'Program ​which prompts the user To enter their first name
'And last name.
' After the user has entered the first name And last name, display the concatenated first
'name And last name. 

Module Module1

    Sub Main()
        Console.WriteLine("Please enter your first name")
        Dim firstName = Console.ReadLine()
        Console.WriteLine("Please enter your last name")
        Dim lastName = Console.ReadLine()
        Console.WriteLine("Name you entered is :" & firstName & " " & lastName)
    End Sub

End Module
