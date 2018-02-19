'Interface Implementation

Public Class FSLogger
    Implements ILogger

    Sub writeLog(message As String) Implements ILogger.writeLog
        Console.WriteLine(message)
    End Sub
End Class

Public Class DBLogger
    Implements ILogger

    Sub writeLog(message As String) Implements ILogger.writeLog
        Console.WriteLine(message)
    End Sub

End Class

Public Class FSDBLogger
    Implements ILogger, ISender
    Sub writeLog(message As String) Implements ILogger.writeLog
        Console.WriteLine(message)
    End Sub
    Function sendMessage(message As String) As Boolean Implements ISender.sendMessage
        Console.WriteLine(message)
        Return True
    End Function
End Class