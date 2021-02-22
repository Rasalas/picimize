Public Class MainBig
    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub DrawWindowBorder(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim PenWidth As Integer = 1
        Dim blackPen As New Pen(My.Settings.ColorDark, PenWidth)
        Dim rect As New Rectangle(CInt(PenWidth / 2), CInt(PenWidth / 2), Me.Width - PenWidth, Me.Height - PenWidth)

        e.Graphics.DrawRectangle(blackPen, rect)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim pb As New FastPic
        With pb
            .PictureBoxImage = New Bitmap(Image.FromFile("C:\Users\Torben\Desktop\124.jpg"))
        End With

        FlowLayoutPanel1.Controls.Add(pb)

    End Sub
End Class
