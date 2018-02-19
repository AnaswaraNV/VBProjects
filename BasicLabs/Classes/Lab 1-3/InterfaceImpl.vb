Imports Microsoft.VisualBasic

Public Class FSLogger
    Implements ILogger

    Public Sub WriteLog(input As String)
        'input = "FSLogger"
        Console.WriteLine(input)
    End Sub

End Class

Public Class DBLogger
    Implements ILogger

    Public Sub WriteLog(input As String)
        'input = "DBLogger"
        Console.WriteLine(input)
    End Sub

End Class

Public Class FSDBLogger
    Implements ILogger, ISender
    Public Sub WriteLog(message As String)
        'message = "FSDBLogger"
        Console.WriteLine(message)
    End Sub
    Function sendMessage(message As String)
        Console.Writeline(message)
    End Function
End Class