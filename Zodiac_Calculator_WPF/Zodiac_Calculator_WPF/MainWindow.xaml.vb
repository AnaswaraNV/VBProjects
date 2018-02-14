Imports System.Text.RegularExpressions
Imports ChineseZodiacClassLibrary
Imports System.IO
Class MainWindow
    Dim year As Integer
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'code here
        Me.indexImage.Source = New BitmapImage(New Uri("\Resources\calculate.jpg", UriKind.Relative))
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        'On button click calls the read year function
        Dim Year As Integer = readYear()

    End Sub


    ''' <summary>
    ''' Function to read yesr from user and display appropriate image 
    ''' It also validates the user input, if it is an year 
    ''' If not shows an error that it is not valid year
    ''' If valid year calls the calculator object and display the appropriate image
    ''' </summary>
    ''' <returns></returns>
    Public Function readYear() As Integer
        If Integer.TryParse(Me.yearInput.Text, year) AndAlso Me.yearInput.Text.Length = 4 Then

            'It's a number. Now look at other criteria

            'regex to match year
            Dim pattern As String = "[1-9][0-9][0-9][0-9]"
            ' Instantiate the regular expression object.
            Dim reg As Regex = New Regex(pattern, RegexOptions.IgnoreCase)

            ' Match the regular expression pattern against a text string.
            Dim match As Match = reg.Match(year)

            If match.Success Then
                'MessageBox.Show(year & " is a valid year")
                'Chinese zodiac object calculator
                Dim chineseZodiac As ChineseZodiacUtil
                chineseZodiac = New ChineseZodiacUtil()

                'Calling the zodic function used in the dll
                Dim index = chineseZodiac.getChineseZodiac(year)

                'Creating object for Chinese    zodiac calculator
                Dim obj As ZodiacResult
                obj = New ZodiacResult(index)

                'Object function implemnted using various type case, array, arraylist, hash table
                Dim value As String = "calculate"

                value = obj.yearConvertionArray()
                'Console.WriteLine("Value (Case statement) : " & value)
                Dim fileName As String = "\Resources\" & value & ".jpg"
                Me.indexImage.Source = New BitmapImage(New Uri(fileName, UriKind.Relative))

            Else
                MessageBox.Show("Not a valid year!")
            End If
        Else
            MessageBox.Show("Please enter a valid input!")
        End If
        Return year

    End Function

End Class
