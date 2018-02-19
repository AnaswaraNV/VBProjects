Imports AlbumDisplay.SupportClass

Public Class MainWindow
        Dim albumObj As New Album()

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        End Sub

        Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

            Try
            'Setting the values of album from user
            Me.albumObj.setAlbumTitle(Me.AlbumTitleTextBox.Text)
            Me.albumObj.setAlbumGenre(Me.AlbumGenreTextBox.Text)
                Me.albumObj.setArtist(Me.ArtistTextBox.Text)
                Me.albumObj.setReleaseDate(Me.ReleaseDateTextBox.Text)

                Dim appData As AppData = appData.Instance
                appData.setAlbumObj(Me.albumObj)

                'New window object
                Dim window As New SongEntryWindow()
                window.Show()
                Me.Close()
            Catch err As InvalidCastException
            MessageBox.Show("Please enter a valid value for All fields")
        End Try

        End Sub
    End Class
