Module Module1

    Sub Main()
        ' Console change color
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.DarkRed

        'Calling sub to read album info
        readAlbumInfo()

        Console.WriteLine("Thank you!")
        Console.ReadKey()
    End Sub

    Sub readAlbumInfo()

        'Creating Object of Album class
        Dim album As New Album()
        Try
            Console.WriteLine("Please Enter Details of Album below")
            Console.Write("Album Title: ")
            Dim albumTitle As String = Console.ReadLine()
            album.setAlbumTitle(albumTitle)

            Console.Write("Album Genre: ")
            Dim albumGenre As String = Console.ReadLine()
            album.setAlbumGenre(albumGenre)

            Console.Write("Album Artist: ")
            Dim artist As String = Console.ReadLine()
            album.setArtist(artist)

            Console.Write("Release Date: ")
            Console.WriteLine("Please enter a date value in this format: yyyy/MM/dd hh:mm:ss")
            Dim releaseDate As String = Console.ReadLine()
            album.setReleaseDate(releaseDate)

            Console.Write("Album record Label: ")
            Dim recordLabel As String = Console.ReadLine()
            album.setRecordLabel(recordLabel)

            'Reading song information
            Dim songArray() As Song

            songArray = readSongInfo()

            'setting song instance 
            album.setSong(songArray)
        Catch e As NullReferenceException
            Console.WriteLine("Null Exception")
        Catch e As ArgumentNullException
            Console.WriteLine("Argument Null Exception")
        Catch e As Exception
            Console.WriteLine("Error occured!")
        End Try
        'To print values of ALbum class
        album.displayAlbumDetails()

            Console.ReadKey()

    End Sub
    Public Function readSongInfo() As Song()

        Console.WriteLine("####################################################")
        Console.WriteLine("Enter 3 Song Details: ")
        Dim songCount As Integer = 3

        'Song object array
        Dim songArray(2) As Song

        For i = 0 To 2

            'song(i) = New Songs(songN, songDuration, songSinger, songDirector)
            songArray(i) = New Song()
            Try
                Console.WriteLine("Enter Song name: ")
                Dim songN As String = Console.ReadLine()
                songArray(i).setSongName(songN)


                Console.WriteLine("Enter Song duration: ")
                Dim songDuration As String = Console.ReadLine()
                songArray(i).setSongDuration(songDuration)

                Console.WriteLine("Enter Song singer: ")
                Dim songSinger As String = Console.ReadLine()
                songArray(i).setSongSinger(songSinger)


                Console.WriteLine("Enter Song director: ")
                Dim songDirector As String = Console.ReadLine()
                songArray(i).setSongDirector(songDirector)
                Console.WriteLine()
            Catch e As NullReferenceException
                Console.WriteLine("Null Exception")
            Catch e As ArgumentNullException
                Console.WriteLine("Argument Null Exception")
            Catch e As Exception
                Console.WriteLine("Error occured!")
            End Try
        Next
        Return songArray
    End Function

End Module
