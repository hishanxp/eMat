' And System.Security.Cryptography for Hashes : MD5, SHA1, SHA256, ...
Imports System.Security
Imports System.Security.Cryptography

Public Class frmload

    Private Sub btnopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopen.Click
        od.ShowDialog()
        txtfpath.Text = od.FileName
        txthash.Text = getFileMd5(od.FileName)

        btnopen.Enabled = False

        Dim myProcess As New Process()
        Dim line As String
        myProcess.StartInfo.FileName = "volrun.exe"
        myProcess.StartInfo.Arguments = "--profile=WinXPSP3x86 -f " & od.FileName & ""
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.RedirectStandardOutput = True

        myProcess.Start()


        'get the headings dynamically
        line = myProcess.StandardOutput.ReadLine
    End Sub

    Private Function getFileMd5(ByVal filePath As String) As String
        ' get all the file contents
        Dim File() As Byte = System.IO.File.ReadAllBytes(filePath)

        ' create a new md5 object
        Dim Md5 As New MD5CryptoServiceProvider()

        ' compute the hash
        Dim byteHash() As Byte = Md5.ComputeHash(File)

        ' return the value in base 64 
        'Return Convert.ToBase64String(byteHash)

        Return ByteArrayToString(byteHash)


    End Function

    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim sb As New System.Text.StringBuilder(arrInput.Length * 2)
        For i As Integer = 0 To arrInput.Length - 1
            sb.Append(arrInput(i).ToString("X2"))
        Next
        Return sb.ToString().ToLower
    End Function

End Class