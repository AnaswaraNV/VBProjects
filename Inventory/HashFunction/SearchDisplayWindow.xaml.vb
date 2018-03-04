Imports HashFunction.SupportClass

Public Class SearchDisplayWindow
    Public Sub New(user As User)

        ' This call is required by the designer.
        InitializeComponent()
        'creating appdata instance and setting to the instance
        Dim appData As AppData = AppData.Instance
        Dim counter As Integer = appData.GetUserObj().GetUserList().Count - 1
        For i = 0 To counter
            If appData.GetUserObj().GetUserList().Item(i) Is user Then
                Me.DisplayBlock.Text = user.Tostring()
            End If
        Next

    End Sub


End Class
