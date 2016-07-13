Imports System.IO
Imports System.Security
Imports System.Security.Cryptography


Public Class Form1
    ' We traverse the array of bytes and converting each byte in hexadecimal
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        ' We traverse the array of bytes
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' We convert each byte in hexadecimal
            hex_value += array(i).ToString("X2")

        Next i

        ' We return the string in lowercase
        Return hex_value.ToLower

    End Function
    ' Function to obtain the desired hash of a file
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        ' We declare the variable : hash
        Dim hash
        If hash_type.ToLower = "md5" Then
            ' Initializes a md5 hash object
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initializes a SHA-1 hash object
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initializes a SHA-256 hash object
            hash = SHA256.Create()
        Else
            MsgBox("Unknown type of hash : " & hash_type, MsgBoxStyle.Critical)
            Return False
        End If

        ' We declare a variable to be an array of bytes
        Dim hashValue() As Byte

        ' We create a FileStream for the file passed as a parameter
        Dim fileStream As FileStream = File.OpenRead(file_name)
        ' We position the cursor at the beginning of stream
        fileStream.Position = 0
        ' We calculate the hash of the file
        hashValue = hash.ComputeHash(fileStream)
        ' The array of bytes is converted into hexadecimal before it can be read easily
        Dim hash_hex = PrintByteArray(hashValue)

        ' We close the open file
        fileStream.Close()

        ' The hash is returned
        Return hash_hex

    End Function
    ' md5 is a reserved name, so we named the function : md5_hash
    Function md5_hash(ByVal file_name As String)
        Return hash_generator("md5", file_name)
    End Function

    Function sha_1(ByVal file_name As String)
        Return hash_generator("sha1", file_name)
    End Function

    Function sha_256(ByVal file_name As String)
        Return hash_generator("sha256", file_name)
    End Function
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
        hashListBox.Items.Clear()
        Dim fileNames = My.Computer.FileSystem.GetFiles(folderPath)
        For Each fileName As String In fileNames
            'add an entry in the original file name list
            filesListBox.Items.Add(Path.GetFileName(fileName))
            ' And we compute the hashes : MD5
            Dim hash_md5 = md5_hash(fileName)
            hashListBox.Items.Add(hash_md5)
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' We specify the file path
        Dim path As String = "C:\mon_fichier.exe"

        ' And we compute the hashes : MD5, SHA-1 and SHA-256
        Dim hash_md5 = md5_hash(path)








    End Sub
End Class
