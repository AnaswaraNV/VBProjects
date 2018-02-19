Module Module1

    Sub Main()
        ' Console change color
        Console.BackgroundColor = ConsoleColor.DarkMagenta
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("***********************************")
        Dim IOSPhone As New IOSPhone
        IOSPhone.MobilePhoneName = "IPhone 7"
        IOSPhone.OperatingSystem = "IOS"
        IOSPhone.Version = "11.2.2 (15 C02)"
        IOSPhone.Model = "MN9V12VC/A"
        IOSPhone.IMEI = "35 534834 34686 56"
        IOSPhone.LoginToPhone("appleID")
        IOSPhone.ConnectToDefaultAppstore("Apple appStore")
        IOSPhone.ChargeMobilePhone("Lightning USB")
        IOSPhone.SimCardPhoneNumebr("6477892777")
        IOSPhone.CallMobilePhone("4572883643")
        IOSPhone.MessageMobilePhone("4572883643")
        Console.WriteLine("***********************************")
        Console.ReadKey()
        Console.WriteLine("***********************************")
        Dim androidPhone As New Andriod
        IOSPhone.MobilePhoneName = "Google Pixel"
        IOSPhone.OperatingSystem = "Android"
        IOSPhone.Version = "24.3.2 (15 C02)"
        IOSPhone.Model = "MG9Y12CC/B"
        IOSPhone.IMEI = "35 533246 34686 56"
        IOSPhone.LoginToPhone("Google ID")
        IOSPhone.ConnectToDefaultAppstore("Google Play Store")
        IOSPhone.ChargeMobilePhone("Micro USB")
        IOSPhone.SimCardPhoneNumebr("6475678906")
        IOSPhone.CallMobilePhone("4563452348")
        IOSPhone.MessageMobilePhone("4572883643")
        Console.WriteLine("***********************************")
        Console.WriteLine("Thank you!!")
        Console.ReadKey()
    End Sub

End Module
