Public Class FilterBox

    Public WriteOnly Property LblTxt As String
        Set(value As String)
            Label.Text = value
        End Set
    End Property
    Public Property TBoxTxt As String
        Get
            Return FiltrBox.Text
        End Get
        Set(value As String)
            FiltrBox.Text = value
        End Set
    End Property
    Public Shared Function getHeight() As Integer
        Dim a As New FilterBox
        Return a.Height
    End Function

End Class
