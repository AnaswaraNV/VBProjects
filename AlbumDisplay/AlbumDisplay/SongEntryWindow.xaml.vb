Imports System.Text
Imports AlbumDisplay.SupportClass

Public Class SongEntryWindow
        Dim songObject As New Songs()

        ''' <summary>
        ''' Continue to enter song details
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ConinueButton_Click(sender As Object, e As RoutedEventArgs)

            UpdateSongObject()

            'New window object
            Dim window As New SongEntryWindow()
            window.Show()
            Me.Close()
        End Sub


    ''' <summary>
    ''' If finish button is pressed a summary page appears
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FinishButton_Click(sender As Object, e As RoutedEventArgs) Handles FinishButton.Click

            UpdateSongObject()
            Dim finishWindowOb As New finishWindow()
            setTextBoxValues(finishWindowOb)
            finishWindowOb.Show()
            Me.Close()
        End Sub


    ''' <summary>
    ''' Updating song object
    ''' </summary>
    Public Sub UpdateSongObject()
            Try
                'Setting the values of songs from user
                Me.songObject.setSongName(SongNameTextBox.Text)
                Me.songObject.setSongSinger(SingerTextBox.Text)
                Me.songObject.setSongDuration(DurationTextBox.Text)
                Me.songObject.setSongDirector(DirectorTextBox.Text)

                'creating appdata instance and setting song to the instance
                Dim appData As AppData = AppData.Instance

                appData.albumObj.setsongList(Me.songObject)
            Catch err As InvalidCastException
            MessageBox.Show("Please enter a valid value for All fields")
        End Try
        End Sub
        ''' <summary>
        ''' Set the text box values for song deatils
        ''' </summary>
        ''' <param name="finishWindowOb"></param>
        Public Sub setTextBoxValues(finishWindowOb As finishWindow)
            'creating appdata instance 
            Dim appData As AppData = AppData.Instance

            finishWindowOb.TextBox_1.Text = appData.albumObj.getAlbumTitle()
            finishWindowOb.TextBox_2.Text = appData.albumObj.getAlbumGenre()
            finishWindowOb.TextBox_3.Text = appData.albumObj.getArtist()
            finishWindowOb.TextBox_4.Text = appData.albumObj.getReleaseDate()


            'Console.WriteLine("count is " + (appData.albumObj.getsongList().Count - 1).ToString)
            Dim count As Integer = appData.albumObj.getsongList().Count - 1
            'Defining Label's for song object
            For i = 0 To count
                'Label objects
                Dim Label1 As New Label()
                Dim Label2 As New Label()
                Dim Label3 As New Label()
                Dim Label4 As New Label()
                'Setting height
                Label1.Height = " 40"
                Label2.Height = " 40"
                Label3.Height = " 40"
                Label4.Height = " 40"
                'Setting content
                Label1.Content = "SongName"
                Label2.Content = "Singer"
                Label3.Content = " Duration"
                Label4.Content = "Director"
                'adding to stack panel
                finishWindowOb.stackPanel1.Children.Add(Label1)
                finishWindowOb.stackPanel1.Children.Add(Label2)
                finishWindowOb.stackPanel1.Children.Add(Label3)
                finishWindowOb.stackPanel1.Children.Add(Label4)
            Next
            For i = 0 To count
                'Creating 4 text box
                Dim TextBox1 As New TextBox()
                Dim TextBox2 As New TextBox()
                Dim TextBox3 As New TextBox()
                Dim TextBox4 As New TextBox()
                'Setting height
                TextBox1.Height = "40"
                TextBox2.Height = "40"
                TextBox3.Height = "40"
                TextBox4.Height = "40"

            'setting content
            TextBox1.Text = appData.albumObj.getSong(i).getSongName()
                TextBox2.Text = appData.albumObj.getSong(i).getSongSinger()
                TextBox3.Text = appData.albumObj.getSong(i).getSongDuration()
                TextBox4.Text = appData.albumObj.getSong(i).getSongDirector()
                'adding to stack panel object
                finishWindowOb.stackPanel2.Children.Add(TextBox1)
                finishWindowOb.stackPanel2.Children.Add(TextBox2)
                finishWindowOb.stackPanel2.Children.Add(TextBox3)
                finishWindowOb.stackPanel2.Children.Add(TextBox4)
            Next
        End Sub
    End Class
