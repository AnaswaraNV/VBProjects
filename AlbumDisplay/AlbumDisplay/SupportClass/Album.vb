Namespace SupportClass
    Public Class Album
        Property AlbumTitle As String
        Property AlbumGenre As String
        Property Artist As String
        Property songList As New List(Of Songs)
        Property ReleaseDate As Date
        Property RecordLabel As String

        'Getters And setters : AlbumTitle
        Public Sub setAlbumTitle(AlbumTitle As String)
            Me.AlbumTitle = AlbumTitle
        End Sub

        Public Function getAlbumTitle()
            Return Me.AlbumTitle
        End Function

        'Getters And setters : AlbumGenre
        Public Sub setAlbumGenre(AlbumGenre As String)
            Me.AlbumGenre = AlbumGenre
        End Sub

        Public Function getAlbumGenre()
            Console.WriteLine("I am here")
            Console.WriteLine("MyBase valuse is  " & Me.AlbumGenre)
            Return Me.AlbumGenre
        End Function

        'Getters And setters : Artist
        Public Sub setArtist(Artist As String)
            Me.Artist = Artist
        End Sub

        Public Function getArtist()
            Return Me.Artist
        End Function

        'Getters And setters : AlbumTitle
        Public Sub setReleaseDate(ReleaseDate As String)
            Me.ReleaseDate = ReleaseDate
        End Sub

        ''' <summary>
        ''' Date type is : 01/01/2000
        ''' </summary>
        ''' <returns></returns>
        Public Function getReleaseDate()
            Dim dateTimeDemo As Date
            Try
                DateTime.TryParse(ReleaseDate, dateTimeDemo)
                Console.WriteLine(dateTimeDemo)

            Catch e As System.InvalidCastException
                dateTimeDemo = DateTime.Today
                MessageBox.Show("Could not parse the entered date.")
            Catch e As System.Exception
                dateTimeDemo = DateTime.Today
                MessageBox.Show("Error occured!")
            End Try
            Return dateTimeDemo
        End Function

        'Getters And setters : AlbumTitle
        Public Sub setRecordLabel(RecordLabel As String)
            Me.RecordLabel = RecordLabel
        End Sub

        Public Function getRecordLabel()
            Return Me.RecordLabel
        End Function

        ''' <summary>
        ''' Setter of song array
        ''' </summary>
        ''' <param name="songObj"></param>
        Public Sub setsongList(songObj As Songs)
            Me.songList.Add(songObj)
        End Sub

        Public Function getsongList() As List(Of Songs)
            Return Me.songList
        End Function

        'getting song of index position
        Public Function getSong(index As Integer) As Songs
            Return Me.getsongList().Item(index)
        End Function
    End Class
End Namespace