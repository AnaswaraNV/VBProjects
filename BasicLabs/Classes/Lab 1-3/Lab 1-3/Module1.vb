'@author Anaswara
'Purpose: Lab 1-3

Module Module1

    Sub Main()

        Dim ILoggerObj As New FSLogger
        ILoggerObj.writeLog("FSLogger")

        Dim DBLoggerObj As New DBLogger
        DBLoggerObj.writeLog("DBLogger")

        Dim FSDBLoggerObj As New FSDBLogger
        FSDBLoggerObj.writeLog("FSDBLogger")
        FSDBLoggerObj.sendMessage("FSDBLogger")

    End Sub

End Module
