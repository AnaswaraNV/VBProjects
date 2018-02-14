Public Class ZodiacResult
    Property index As Integer

    Public Sub New(index As Integer)
        Me.index = index
    End Sub


    ''' <summary>
    ''' Implementing array concept
    ''' </summary>
    ''' <returns></returns>
    Public Function yearConvertionArray() As String
        Dim result = New String() {"Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "monkey", "Rooster", "Dog", "Pig"}
        Dim value As String = Nothing
        Console.WriteLine("in array : index is " & index)
        'return corresponding result back depending on the index
        For i = 0 To result.Length
            If i + 1 = Me.index Then
                value = result(i)
            End If
        Next
        Return value
    End Function
End Class
