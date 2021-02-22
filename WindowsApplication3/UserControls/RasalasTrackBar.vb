Imports System.ComponentModel

<DefaultEvent("ValueChanged")> _
Public Class RasalasTrackBar
    Private _tbarValue As Single
    Private _factor As Integer
    Public Event ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    <DefaultValue(1)> _
        Public Property [Value] As Single
        Get
            Return _tbarValue
        End Get
        Set(ByVal value As Single)
            _tbarValue = value
            If _tbarValue = 0S Then
                Panel1.Height = CInt(_tbarValue)
            Else
                Panel1.Height = CInt(_tbarValue * Me.Height)
            End If
            lblDown.Location = New Point(lblDown.Location.X, Panel1.Height)
            lblUp.Location = New Point(lblUp.Location.X, Panel1.Height - lblUp.Height)
        End Set
    End Property
    <DefaultValue(6)> _
    Public Property Factor As Integer
        Get
            Return _factor
        End Get
        Set(value As Integer)
            _factor = value
        End Set
    End Property


    Private Sub RasalasTrackBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panel1.Height = CInt(_tbarValue * Me.Height)
        'lblDown.Location = New Point(lblDown.Location.X, 0)
        ArrowAlign()
        Panel1.BackColor = My.Settings.ColorLight
        'Panel1.Height = 0
    End Sub


    Private Sub TBar_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove, Panel1.MouseDown, Me.MouseMove, Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left _
            AndAlso e.Y > 0 _
            AndAlso e.Y < Me.Height Then 'von links, rechts, oben, unten in die Form rein = Farbe
            Panel1.Height = e.Y
            Update()
            'Label1.Location = New Point(Label1.Location.X, e.Y)
            '_tbarValue = CSng(Math.Round((Panel1.Height / Me.Height) * (6 - 1) + 1, 1))
            'RaiseEvent ValueChanged(Me, EventArgs.Empty)
            'Else
            '    'If Not e.Button = Windows.Forms.MouseButtons.Left _
            '    'AndAlso e.X > 0 _
            '    'AndAlso e.X < Me.Width _
            '    'AndAlso e.Y > 0 _
            '    'AndAlso e.Y < Me.Height Then
            '    '    Panel1.BackColor = My.Settings.ColorDark 'Mouseover Grau
            '    'Else
            '    '    'Lbl.BackColor = Color.FromArgb(229, 229, 229) 'zurücksetzen bei klickLeave
            '    '    Panel1.BackColor = My.Settings.ColorLight
            '    'End If
        End If
    End Sub

    Private Overloads Sub Update()
        lblDown.Location = New Point(lblDown.Location.X, Panel1.Height)
        lblUp.Location = New Point(lblUp.Location.X, Panel1.Height - lblUp.Height)
        _tbarValue = CSng(Math.Round((Panel1.Height / Me.Height) * (6 - 1) + 1, 1))
        RaiseEvent ValueChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub LblDown_Click(sender As Object, e As EventArgs) Handles lblDown.Click
        If Panel1.Height <= 0.9 * Me.Height Then
            Panel1.Height += CInt(Me.Height * 0.1)
        Else
            Panel1.Height = Me.Height
        End If
        Update()
    End Sub
    Private Sub LblUp_Click(sender As Object, e As EventArgs) Handles lblUp.Click
        If Panel1.Height >= 0.1 * Me.Height Then
            Panel1.Height -= CInt(Me.Height * 0.1)
        Else
            Panel1.Height = 0
        End If
        Update()
    End Sub

    Private Sub RasalasTrackBar_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'lblDown.Location = New Point(lblDown.Location.X, Panel1.Height)
        'lblUp.Location = New Point(lblUp.Location.X, Panel1.Height - lblUp.Height)
        ArrowAlign()
    End Sub
    Private Sub ArrowAlign()
        lblDown.Location = New Point(lblDown.Location.X, Panel1.Height)
        lblUp.Location = New Point(lblUp.Location.X, Panel1.Height - lblUp.Height)
    End Sub
End Class
