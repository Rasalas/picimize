Imports System.ComponentModel

<DefaultEvent("Click")> _
Public Class RasalasButton

    Public Property [Image] As Bitmap
        Set(ByVal value As Bitmap)
            Lbl.Image = value
        End Set
        Get
            Return CType(Lbl.Image, Bitmap)
        End Get
    End Property
    Public Property LblText As String
        Set(ByVal value As String)
            Lbl.Text = value
        End Set
        Get
            Return Lbl.Text
        End Get
    End Property

    Private Sub Lbl_MouseLeave(sender As Object, e As EventArgs) Handles Lbl.MouseLeave
        Lbl.BackColor = Color.Transparent
        'Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub Lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Lbl.MouseMove, Lbl.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left _
            AndAlso e.X > 0 _
            AndAlso e.X < Lbl.Width _
            AndAlso e.Y > 0 _
            AndAlso e.Y < Lbl.Height Then 'von links, rechts, oben, unten in die Form rein = Farbe
            Lbl.BackColor = My.Settings.ColorDark
        Else
            If Not e.Button = Windows.Forms.MouseButtons.Left Then
                Lbl.BackColor = Color.FromArgb(211, 211, 211) 'Mouseover Grau
            Else
                'Lbl.BackColor = Color.FromArgb(229, 229, 229) 'zurücksetzen bei klickLeave
                Lbl.BackColor = Color.Transparent
            End If
        End If
    End Sub

    'Protected Overrides Sub OnClick(ByVal e As EventArgs)
    '    MyBase.OnClick(e)
    'End Sub

    Private Sub Lbl_Click(sender As Object, e As EventArgs) Handles Lbl.Click
        MyBase.OnClick(e)
    End Sub
End Class
