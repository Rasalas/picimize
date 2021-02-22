<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RasalasButton
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
        Me.Lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl
        '
        Me.Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl.Location = New System.Drawing.Point(0, 0)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(73, 62)
        Me.Lbl.TabIndex = 0
        Me.Lbl.Text = "RasalasBtn"
        Me.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RasalasButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Lbl)
        Me.Name = "RasalasButton"
        Me.Size = New System.Drawing.Size(73, 62)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl As System.Windows.Forms.Label

End Class
