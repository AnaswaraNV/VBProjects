Imports Microsoft.VisualBasic
Imports MobilePhone

Public Class MobilePhoneImpl
    Implements MobilePhoneInterface

    Property MobilePhoneName As String Implements MobilePhoneInterface.MobilePhoneName
    Property OperatingSystem As String Implements MobilePhoneInterface.OperatingSystem
    Property Version As String Implements MobilePhoneInterface.Version
    Property Model As String Implements MobilePhoneInterface.Model
    Property IMEI As String Implements MobilePhoneInterface.IMEI
    Property Storage As String Implements MobilePhoneInterface.Storage

    'Implementing the functions in interface
    Public Function LoginToPhone(LoginID As String) As Boolean Implements MobilePhoneInterface.LoginToPhone
        Console.WriteLine("Login to " & Me.MobilePhoneName & " Successful")
        Return True
    End Function


    Public Sub ConnectToDefaultAppstore(StoreName As String) Implements MobilePhoneInterface.ConnectToDefaultAppstore
        Console.WriteLine("Connected to  Default Appstore :" & StoreName)
    End Sub
    Public Sub ChargeMobilePhone(ChargerType As String) Implements MobilePhoneInterface.ChargeMobilePhone
        Console.WriteLine("Charging  " & Me.MobilePhoneName & " with " & ChargerType)
    End Sub
    Sub SimCardPhoneNumebr(PhoneNumber As String) Implements MobilePhoneInterface.SimCardPhoneNumebr
        Console.WriteLine(Me.MobilePhoneName & "has sim card with phone Number " & PhoneNumber)
    End Sub
    Public Function CallMobilePhone(DestPhoneNumber As String) As Boolean Implements MobilePhoneInterface.CallMobilePhone
        Console.WriteLine("Calling with " & Me.MobilePhoneName & " to " & DestPhoneNumber & "..... ")
        Return True
    End Function
    Public Function MessageMobilePhone(DestPhoneNumber As String) As Boolean Implements MobilePhoneInterface.MessageMobilePhone
        Console.WriteLine("Messaging with  " & Me.MobilePhoneName & " to " & DestPhoneNumber & "..... ")
        Return True
    End Function
End Class
