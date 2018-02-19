
Public Class Album

    Property AlbumTitle As String
    Property AlbumGenre As String
    Property Artist As String
    Property SongObj() As Song()
    Property ReleaseDate As Date
    Property RecordLabel As String

    'Getters And setters : AlbumTitle
    Public Sub setAlbumTitle(AlbumTitle As String)
        Me.AlbumTitle = AlbumTitle
    End Sub

    Function getAlbumTitle()
        Return Me.AlbumTitle
    End Function

    'Getters And setters : AlbumGenre
    Sub setAlbumGenre(AlbumGenre As String)
        Me.AlbumGenre = AlbumGenre
    End Sub

    Function getAlbumGenre()
        Return Me.AlbumGenre
    End Function

    'Getters And setters : Artist
    Sub setArtist(Artist As String)
        Me.Artist = Artist
    End Sub

    Function getArtist()
        Return Me.Artist
    End Function

    'Getters And setters : AlbumTitle
    Sub setReleaseDate(ReleaseDate As String)
        Me.ReleaseDate = ReleaseDate
    End Sub

    Function getReleaseDate()
        Dim dateTimeDemo As Date
        Try
            DateTime.TryParse(ReleaseDate, dateTimeDemo)
            Console.WriteLine(dateTimeDemo)

        Catch e As System.InvalidCastException
            dateTimeDemo = DateTime.Today
            Console.WriteLine("Could not parse the entered date.")
        Catch e As System.Exception
            dateTimeDemo = DateTime.Today
            Console.WriteLine("Error occured!")
        End Try
        Return dateTimeDemo
    End Function

    'Getters And setters : AlbumTitle
    Sub setRecordLabel(RecordLabel As String)
        Me.RecordLabel = RecordLabel
    End Sub

    Function getRecordLabel()
        Return Me.RecordLabel
    End Function

    'Getters And setters : AlbumTitle
    Public Sub setSong(songObj As Song())
        Me.SongObj = songObj
    End Sub

    Function getSong()
        Return Me.SongObj
    End Function

    Sub displayAlbumDetails()
        Try
            Console.WriteLine("####################################################")
            Console.WriteLine("Plaese find below details that you entered: ")
            Console.WriteLine("1.Album Title: " & Me.AlbumTitle)
            Console.WriteLine("2.Album Genre: " & Me.AlbumGenre)
            Console.WriteLine("3.Artist: " & Me.Artist)
            Console.WriteLine("5.Release date: " & Me.ReleaseDate)
            Console.WriteLine("6.RecordLabel : " & Me.RecordLabel)

            Console.WriteLine("4.Song Info: ")
            For i As Integer = 0 To 2
                Dim songN As String = Me.SongObj(i).songName
                Console.WriteLine("*************************")
                Console.WriteLine("Song" & i & " Name: " & songN)
                Dim songDuration As String = Me.SongObj(i).songDuration
                Console.WriteLine("           " & " Duration: " & songDuration)
                Dim songSinger As String = Me.SongObj(i).songSinger
                Console.WriteLine("           " & " Singer: " & songSinger)
                Dim songDirector As String = Me.SongObj(i).songDirector
                Console.WriteLine("           " & " Director: " & songDirector)
                Console.WriteLine("*************************")
            Next
        Catch e As NullReferenceException
            Console.WriteLine("Null Exception")
        Catch e As ArgumentNullException
            Console.WriteLine("Argument Null Exception")
        Catch e As Exception
            Console.WriteLine("Error occured!")
        End Try
    End Sub

End Class
