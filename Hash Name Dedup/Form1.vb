Imports System.IO

Public Class Form1
    Dim userSelectedPath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dialog As FolderBrowserDialog = New FolderBrowserDialog
        Dim folderDirectory As String
        folderDirectory = Space$(255)
        Dialog.Description = "Choose a directory..."
        Dialog.ShowDialog(Me)
        folderDirectory = Dialog.SelectedPath
        RTrim(folderDirectory)
        userSelectedPath = folderDirectory
    End Sub
End Class
