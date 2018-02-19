'@author: Anaswara
'Defining MobilePhone interface

Public Interface MobilePhoneInterface

    'Common Property
    Property MobilePhoneName As String
    Property OperatingSystem As String
    Property Version As String
    Property Model As String
    Property IMEI As String
    Property Storage As String

    'Common Methods
    Function LoginToPhone(LoginID As String) As Boolean
    Sub ConnectToDefaultAppstore(StoreName As String)
    Sub ChargeMobilePhone(ChargerType As String)
    Sub SimCardPhoneNumebr(PhoneNumebr As String)
    Function CallMobilePhone(DestPhoneNumber As String) As Boolean
    Function MessageMobilePhone(DestPhoneNumber As String) As Boolean

End Interface
