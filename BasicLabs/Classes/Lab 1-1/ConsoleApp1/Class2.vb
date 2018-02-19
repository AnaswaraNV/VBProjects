Public Class Song
    Property songName As String
    Property songDuration As String
    Property songSinger As String
    Property songDirector As String

    Sub setSongName(songName As String)
        Me.songName = songName
    End Sub

    Function getSongName()
        Return Me.songName
    End Function

    Sub setSongDuration(songDuration As String)
        Me.songDuration = songDuration
    End Sub

    Function getSongDuration()
        Return Me.songDuration
    End Function

    Sub setSongSinger(songSinger As String)
        Me.songSinger = songSinger
    End Sub

    Function getSongSinger()
        Return Me.songSinger
    End Function

    Sub setSongDirector(songDirector As String)
        Me.songDirector = songDirector
    End Sub

    Function getSongDirector()
        Return Me.songDirector
    End Function
End Class
