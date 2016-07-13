<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.browseButton = New System.Windows.Forms.Button()
        Me.filesListBox = New System.Windows.Forms.ListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.hashListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(12, 12)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(75, 23)
        Me.browseButton.TabIndex = 0
        Me.browseButton.Text = "Browse"
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'filesListBox
        '
        Me.filesListBox.FormattingEnabled = True
        Me.filesListBox.Location = New System.Drawing.Point(12, 71)
        Me.filesListBox.Name = "filesListBox"
        Me.filesListBox.Size = New System.Drawing.Size(349, 212)
        Me.filesListBox.Sorted = True
        Me.filesListBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'hashListBox
        '
        Me.hashListBox.FormattingEnabled = True
        Me.hashListBox.Location = New System.Drawing.Point(554, 71)
        Me.hashListBox.Name = "hashListBox"
        Me.hashListBox.Size = New System.Drawing.Size(349, 212)
        Me.hashListBox.Sorted = True
        Me.hashListBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(915, 303)
        Me.Controls.Add(Me.hashListBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.filesListBox)
        Me.Controls.Add(Me.browseButton)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Hashname Converter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents browseButton As Button
    Friend WithEvents filesListBox As ListBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents hashListBox As ListBox
End Class
