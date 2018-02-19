Namespace SupportClass
    Public Class Songs

        Property songName As String
        Property songDuration As String
        Property songSinger As String
        Property songDirector As String

        Public Sub setSongName(songName As String)
            Me.songName = songName
        End Sub

        Public Function getSongName()
            Return Me.songName
        End Function

        Public Sub setSongDuration(songDuration As String)
            Me.songDuration = songDuration
        End Sub

        Public Function getSongDuration()
            Return Me.songDuration
        End Function

        Public Sub setSongSinger(songSinger As String)
            Me.songSinger = songSinger
        End Sub

        Public Function getSongSinger()
            Return Me.songSinger
        End Function

        Public Sub setSongDirector(songDirector As String)
            Me.songDirector = songDirector
        End Sub

        Public Function getSongDirector()
            Return Me.songDirector
        End Function
    End Class
End Namespace