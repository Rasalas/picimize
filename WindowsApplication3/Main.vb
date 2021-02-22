Imports System.IO

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

    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter, Me.DragEnter, Panel1.DragEnter, Panel2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            hoverView()
        Else
            e.Effect = DragDropEffects.None
            normalView()
        End If
    End Sub
    Private Sub Form1_DragLeave(sender As Object, e As EventArgs) Handles Me.DragLeave
        normalView()
    End Sub
    Dim DateiPfad As String
    Dim UnterOrdnerPfad As String
    Dim DateiName As String
    Dim TempBild As Bitmap
    Dim SizePic As Bitmap
    Dim PicSize As Size
    Dim PicRatio As Double
    Dim NewPicSize As Integer
    Dim errorMessage As String = ""
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop, TextBox1.DragDrop, Panel1.DragDrop, Panel2.DragDrop

        normalView()

        'TextBox1.Enabled = False
        'Select Case True

        '    Case RadioButton1.Checked
        '        NewPicSize = 640
        '        My.Settings.RadioButton = 1
        '    Case RadioButton2.Checked
        '        NewPicSize = 800
        '        My.Settings.RadioButton = 2
        '    Case RadioButton3.Checked
        '        NewPicSize = 1024
        '        My.Settings.RadioButton = 3
        '    Case RadioButton4.Checked
        '        NewPicSize = 1600
        '        My.Settings.RadioButton = 4
        '    Case RadioButton5.Checked
        '        NewPicSize = CInt(TextBox1.Text)
        '        My.Settings.UserSize = NewPicSize
        '        TextBox1.Enabled = True
        '        My.Settings.RadioButton = 5
        'End Select

        For Each Files As String In DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
            '    Dim fi As New System.IO.FileInfo(Files)


            DateiPfad = Files
            UnterOrdnerPfad = Path.GetDirectoryName(DateiPfad)
            DateiName = Replace(DateiPfad, UnterOrdnerPfad, "")


            If DateiPfad.ToLower.EndsWith(".jpg") _
                Or DateiPfad.ToLower.EndsWith(".jpeg") _
                Or DateiPfad.ToLower.EndsWith(".png") Then

                SizePic = Image.FromFile(DateiPfad)

                PicRatio = SizePic.PhysicalDimension.Height / SizePic.PhysicalDimension.Width

                If PicRatio <= 1 Then ' Horizontal
                    If SizePic.PhysicalDimension.Width > NewPicSize Then ' Wenn Bild größer als eingestellt
                        TempBild = New Bitmap(SizePic, NewPicSize, NewPicSize * PicRatio)
                    Else
                        TempBild = SizePic
                    End If
                Else ' Vertikal
                    If SizePic.PhysicalDimension.Height > NewPicSize Then ' Wenn Bild größer als eingestellt
                        TempBild = New Bitmap(SizePic, NewPicSize / PicRatio, NewPicSize)
                    Else
                        TempBild = SizePic
                    End If
                End If


                If Not IO.Directory.Exists(UnterOrdnerPfad & "\#" & NewPicSize) Then
                    System.IO.Directory.CreateDirectory(UnterOrdnerPfad & "\#" & NewPicSize)
                End If
                TempBild.Save(UnterOrdnerPfad & "\#" & NewPicSize & "\" & DateiName, Imaging.ImageFormat.Jpeg)

                'If errorMessage <> "" Then
                '    MsgBox("Einige Bilder waren kleiner als die angegebene")
                'End If
            Else
                MsgBox("Das funktioniert nur mit Bildern :)")
            End If
            ClearData()

            '    TextBox1.Text += fi.ToString
        Next


    End Sub
    Private Sub ClearData()
        TempBild.Dispose()
        SizePic.Dispose()
    End Sub

    Private Sub hoverView()
        lblDrop.Visible = True
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub
    Private Sub normalView()
        lblDrop.Visible = False
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            NewPicSize = CInt(TextBox1.Text)
            My.Settings.UserSize = CInt(TextBox1.Text)
        End If
    End Sub
    Private Sub tboxPage_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = Len(TextBox1.Text)
    End Sub
    Private Sub supressKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.D0 To Keys.D9, Keys.Back, Keys.Delete, Keys.NumPad0 To Keys.NumPad9, Keys.Tab, Keys.Left, Keys.Right
                'Tasten oben zulassen
            Case Else
                'alle anderen Eingaben sperren
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub MainBig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.MinorRevision)
        TextBox1.Text = My.Settings.UserSize.ToString
        Select Case My.Settings.RadioButton
            Case 1
                RadioButton1.Checked = True
            Case 2
                RadioButton2.Checked = True
            Case 3
                RadioButton3.Checked = True
            Case 4
                RadioButton4.Checked = True
            Case 5
                RadioButton5.Checked = True
                TextBox1.Enabled = True
        End Select
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged,
        RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged

        TextBox1.Enabled = False
        Select Case True

            Case RadioButton1.Checked
                NewPicSize = 640
                My.Settings.RadioButton = 1
            Case RadioButton2.Checked
                NewPicSize = 800
                My.Settings.RadioButton = 2
            Case RadioButton3.Checked
                NewPicSize = 1024
                My.Settings.RadioButton = 3
            Case RadioButton4.Checked
                NewPicSize = 1600
                My.Settings.RadioButton = 4
            Case RadioButton5.Checked
                NewPicSize = CInt(TextBox1.Text)
                My.Settings.UserSize = NewPicSize
                TextBox1.Enabled = True
                My.Settings.RadioButton = 5
        End Select
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub infoClose_Click(sender As Object, e As EventArgs) Handles infoClose.Click
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.rasalas.de/")

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("mailto:info@rasalas.de?subject=Picimize" & " v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.MinorRevision)

    End Sub

    Private Sub infoOpen_Click(sender As Object, e As EventArgs) Handles infoOpen.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        My.Settings.UserSize = NewPicSize
        Me.Close()
    End Sub
End Class
