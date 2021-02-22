Public Class FastPic

    Public WriteOnly Property LabelText As String
        Set(value As String)
            Seite.Text = value
        End Set
    End Property
    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function
    Public WriteOnly Property PictureBoxImage As Bitmap

        Set(value As Bitmap)
            Dim myCallback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
            Dim pic As Bitmap
            pic = value
            If pic.PhysicalDimension.Height >= pic.PhysicalDimension.Width Then
                Me.Size = My.Settings.FastPicSize
                Bild.Image = pic.GetThumbnailImage(My.Settings.FastPicSize.Width, My.Settings.FastPicSize.Height, myCallback, IntPtr.Zero)
            Else
                Me.Height = My.Settings.FastPicSize.Width
                Me.Width = My.Settings.FastPicSize.Height
                Bild.Image = pic.GetThumbnailImage(My.Settings.FastPicSize.Height, My.Settings.FastPicSize.Width, myCallback, IntPtr.Zero)
            End If
        End Set
    End Property
    Private Sub FasPic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Seite.Left = 0
        'Seite.Top = 0
        'Bild.Left = 0
        'Bild.Top = 0

        Bild.Width = Me.Width
        Bild.Height = Me.Height
    End Sub
    Private Sub FasPic_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Seite.Left = 0
        'Seite.Top = 0
        'Bild.Left = 0
        'Bild.Top = 0

        Bild.Width = Me.Width
        Bild.Height = Me.Height
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As EventArgs) Handles Bild.DoubleClick, Seite.DoubleClick
        'Hier Befehl für Bild öffnen/
        'MsgBox(Seite.Text)
        ''Main.tboxPage.Text = Seite.Text
        ''Main.PrettyTabControl1.SelectedIndex = 4 'oder 1
        ''Main.TabControl1.SelectedIndex = 4 'oder 1
    End Sub

    Private Sub Seite_Click(sender As Object, e As EventArgs) Handles Seite.Click

    End Sub
End Class
