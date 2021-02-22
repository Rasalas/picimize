<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainBig
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoad = New WindowsApplication3.RasalasButton()
        Me.btnImport = New WindowsApplication3.RasalasButton()
        Me.btnSave = New WindowsApplication3.RasalasButton()
        Me.btnClear = New WindowsApplication3.RasalasButton()
        Me.RasalasMinMaxClose1 = New WindowsApplication3.RasalasMinMaxClose()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(9, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(483, 379)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Location = New System.Drawing.Point(1, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 401)
        Me.Panel1.TabIndex = 6
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnLoad.Image = Nothing
        Me.btnLoad.LblText = "Laden"
        Me.btnLoad.Location = New System.Drawing.Point(498, 202)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(116, 23)
        Me.btnLoad.TabIndex = 5
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnImport.Image = Nothing
        Me.btnImport.LblText = "Bilder importieren..."
        Me.btnImport.Location = New System.Drawing.Point(498, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(116, 23)
        Me.btnImport.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSave.Image = Nothing
        Me.btnSave.LblText = "Speichern"
        Me.btnSave.Location = New System.Drawing.Point(498, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 23)
        Me.btnSave.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnClear.Image = Nothing
        Me.btnClear.LblText = "Leeren"
        Me.btnClear.Location = New System.Drawing.Point(498, 45)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 23)
        Me.btnClear.TabIndex = 5
        '
        'RasalasMinMaxClose1
        '
        Me.RasalasMinMaxClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RasalasMinMaxClose1.Location = New System.Drawing.Point(521, 1)
        Me.RasalasMinMaxClose1.Margin = New System.Windows.Forms.Padding(0)
        Me.RasalasMinMaxClose1.MaxBox = True
        Me.RasalasMinMaxClose1.MinBox = True
        Me.RasalasMinMaxClose1.Name = "RasalasMinMaxClose1"
        Me.RasalasMinMaxClose1.Size = New System.Drawing.Size(102, 26)
        Me.RasalasMinMaxClose1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bilder verkleinern"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(624, 430)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RasalasMinMaxClose1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Bilder verkleinern"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RasalasMinMaxClose1 As WindowsApplication3.RasalasMinMaxClose
    Friend WithEvents btnImport As WindowsApplication3.RasalasButton
    Friend WithEvents btnClear As WindowsApplication3.RasalasButton
    Friend WithEvents btnLoad As WindowsApplication3.RasalasButton
    Friend WithEvents btnSave As WindowsApplication3.RasalasButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
