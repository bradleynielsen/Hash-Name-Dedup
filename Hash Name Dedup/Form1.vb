Imports System.IO
Imports System.Security
Imports System.Security.Cryptography


Public Class Form1
    'Select the working path
    Private Sub browseButton_Click(sender As Object, e As EventArgs) Handles browseButton.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' Create a list of files in the folder.
            ListFiles(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
    Private Sub ListFiles(ByVal folderPath As String)
        'This lists the filenames in the selected working path
        Me.filesListBox.AutoSize = True
        filesListBox.Items.Clear()
        Dim fileNames = My.Computer.FileSystem.GetFiles(folderPath)
        For Each fileName As String In fileNames
            filesListBox.Items.Add(Path.GetFileName(fileName))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Sub to obtain the desired hash of a file

    End Sub
End Class
