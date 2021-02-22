<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FastPic
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
        Me.Bild = New System.Windows.Forms.PictureBox()
        Me.Seite = New System.Windows.Forms.Label()
        CType(Me.Bild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bild
        '
        Me.Bild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bild.Location = New System.Drawing.Point(0, 0)
        Me.Bild.Name = "Bild"
        Me.Bild.Size = New System.Drawing.Size(105, 149)
        Me.Bild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bild.TabIndex = 0
        Me.Bild.TabStop = False
        '
        'Seite
        '
        Me.Seite.AutoSize = True
        Me.Seite.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Seite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Seite.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Seite.Location = New System.Drawing.Point(88, 0)
        Me.Seite.Name = "Seite"
        Me.Seite.Size = New System.Drawing.Size(19, 19)
        Me.Seite.TabIndex = 1
        Me.Seite.Text = "X"
        '
        'FastPic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Seite)
        Me.Controls.Add(Me.Bild)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FastPic"
        Me.Size = New System.Drawing.Size(105, 149)
        CType(Me.Bild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Bild As System.Windows.Forms.PictureBox
    Private WithEvents Seite As System.Windows.Forms.Label

End Class
