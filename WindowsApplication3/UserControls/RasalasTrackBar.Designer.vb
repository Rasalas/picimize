<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RasalasTrackBar
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RasalasTrackBar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDown = New System.Windows.Forms.Label()
        Me.lblUp = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblUp)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(21, 103)
        Me.Panel1.TabIndex = 0
        '
        'lblDown
        '
        Me.lblDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDown.Image = CType(resources.GetObject("lblDown.Image"), System.Drawing.Image)
        Me.lblDown.Location = New System.Drawing.Point(0, 103)
        Me.lblDown.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDown.Name = "lblDown"
        Me.lblDown.Size = New System.Drawing.Size(21, 21)
        Me.lblDown.TabIndex = 1
        '
        'lblUp
        '
        Me.lblUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUp.Image = CType(resources.GetObject("lblUp.Image"), System.Drawing.Image)
        Me.lblUp.Location = New System.Drawing.Point(0, 82)
        Me.lblUp.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(21, 21)
        Me.lblUp.TabIndex = 2
        '
        'RasalasTrackBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDown)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "RasalasTrackBar"
        Me.Size = New System.Drawing.Size(21, 277)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDown As System.Windows.Forms.Label
    Friend WithEvents lblUp As System.Windows.Forms.Label

End Class
