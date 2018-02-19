'@suthor: Anaswara
'Purpose: Interface 

Public Interface ILogger
    Sub writeLog(message As String)
End Interface

Public Interface ISender
    Function sendMessage(message As String) As Boolean
End Interface
