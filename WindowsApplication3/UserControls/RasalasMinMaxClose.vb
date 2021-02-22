Public Class RasalasClose
    Dim F As Form
    Public Property MinBox As Boolean
        Get
            Return btnMinimize.Enabled
        End Get
        Set(ByVal value As Boolean)
            btnMinimize.Enabled = value
        End Set
    End Property
    Private Sub RasalasMinMaxClose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        F = Me.Parent.FindForm
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        F.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        F.WindowState = FormWindowState.Minimized
    End Sub
End Class
