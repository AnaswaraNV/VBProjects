
Namespace SupportClass
    Public Class AppData
        Property albumObj As Album
        'Property songObj As List(Of Songs)


        'creating a singleton class 
        Private Shared newInstance As AppData = Nothing

        Public Shared ReadOnly Property Instance()
            Get
                If (newInstance Is Nothing) Then
                    newInstance = New AppData()
                End If
                Return newInstance
            End Get
        End Property

        Public Sub New()

        End Sub

        ''' <summary>
        ''' setter of album object
        ''' </summary>
        ''' <param name="albumObj"></param>
        Public Sub setAlbumObj(albumObj As Album)
            Me.albumObj = albumObj
        End Sub


        Public Overrides Function ToString() As String
            Dim Output As String
            Output = albumObj.ToString()
            Return Output
        End Function

    End Class
End Namespace