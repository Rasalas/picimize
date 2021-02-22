Public Class RasalasCloseForm
    Dim F As Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        F.Close()
    End Sub

    Private Sub RasalasMinMaxClose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        F = Me.Parent.FindForm
    End Sub
End Class
