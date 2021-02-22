<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterBox
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
        Me.Label = New System.Windows.Forms.Label()
        Me.FiltrBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(4, 4)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(107, 13)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Rechnungsnummer"
        '
        'FiltrBox
        '
        Me.FiltrBox.Location = New System.Drawing.Point(7, 21)
        Me.FiltrBox.Name = "FiltrBox"
        Me.FiltrBox.Size = New System.Drawing.Size(153, 22)
        Me.FiltrBox.TabIndex = 1
        '
        'FilterBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FiltrBox)
        Me.Controls.Add(Me.Label)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FilterBox"
        Me.Size = New System.Drawing.Size(166, 51)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents FiltrBox As System.Windows.Forms.TextBox

End Class
