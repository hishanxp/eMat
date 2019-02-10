' And System.Security.Cryptography for Hashes : MD5, SHA1, SHA256, ...
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmload
    Dim osshrtname(25) As String
    Dim oslongname(25) As String

    Private Sub btnopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopen.Click
        od.ShowDialog()
        txtfpath.Text = od.FileName
        If od.FileName = "" Then
            Exit Sub
        End If
        PictureBox2.Visible = True
        Me.Refresh()

        dumppath = od.FileName
        btnloadimage.Enabled = True
        btnbackupimage.Enabled = True
        'Loading image Code
        Dim volcommand As String = "imageinfo" & profile & " -f " & dumppath
        Dim userin As MsgBoxResult

        userin = MessageBox.Show("Do you want to select the profile Automatically using KDBG search?", "Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

       
        If userin = MsgBoxResult.Yes Then
            'finding prfile using KDBG search
            Dim outputarr As String() = volengine(volcommand)

            Dim prostr As String = outputarr(2).Split(":")(1).ToString
            ' MsgBox(prostr)
            cmbprofiles.Items.Clear()
            Dim proarr() As String = prostr.Split(",")
            For x = 0 To proarr.Length - 1
                cmbprofiles.Items.Add(Trim(proarr(x)))
            Next
            txtas1.Text = outputarr(3).Split(":")(1).ToString
            txtas2.Text = outputarr(4).Split(":")(1).ToString & outputarr(4).Split(":")(2).ToString
            txtpae.Text = outputarr(5).Split(":")(1).ToString
            txtdtb.Text = outputarr(6).Split(":")(1).ToString
            txtkdbg.Text = outputarr(7).Split(":")(1).ToString
            txtnop.Text = outputarr(8).Split(":")(1).ToString
            txtsp.Text = outputarr(9).Split(":")(1).ToString
            txtkcpr.Text = outputarr(10).Split(":")(1).ToString
            txtkuser.Text = outputarr(11).Split(":")(1).ToString
            txtximgdt.Text = outputarr(12).Split(":")(1).ToString & ":" & outputarr(12).Split(":")(2).ToString & ":" & outputarr(12).Split(":")(3).ToString
            txtimgldt.Text = outputarr(13).Split(":")(1).ToString & ":" & outputarr(13).Split(":")(2).ToString & ":" & outputarr(13).Split(":")(3).ToString

        Else

            cmbprofiles.Items.Clear()

            'Dim proarr() As String = prostr.Split(":")
            'Dim prostr As String = 
            '' MsgBox(prostr)

            For x = 0 To osshrtname.Length - 1
                cmbprofiles.Items.Add(Trim(oslongname(x) & ":" & osshrtname(x)))
            Next
        End If
        


        txthash.Text = getFileMd5(od.FileName)

        ''caluclating md5 hash
        'Dim thread As System.Threading.Thread
        'thread = New System.Threading.Thread(AddressOf Me.hashcalc)
        'thread.Start()

        PictureBox2.Visible = False
    End Sub

    Private Sub hashcalc()
        Dim hashval As String
        hashval = getFileMd5(od.FileName)
        txthash.Text = hashval

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloadimage.Click
        dumppath = txtfpath.Text

        If cmbprofiles.Text = "Guess Profile (Auto)" Then
            profile = "Guess Profile (Auto)"
        Else
            profile = cmbprofiles.Text.Split(":")(1).Trim
        End If
        'MessageBox.Show(profile)

        If profile = "Guess Profile (Auto)" Then
            MessageBox.Show("Guessing OS automatically :plugins might lode slow in mode", "eMAT Profile Select", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            profile = ""
            btnopen.Enabled = False
            btnloadimage.Enabled = False
        Else
            profile = "--profile=" + profile
            MessageBox.Show("Image information loded", "eMAT image loded", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnopen.Enabled = False
            btnloadimage.Enabled = False
        End If

        PictureBox2.Visible = False

        'Linux:
        '* 32-bit Linux kernels 2.6.11 to 3.5
        '* 64-bit Linux kernels 2.6.11 to 3.5
        '* OpenSuSE, Ubuntu, Debian, CentOS, Fedora, Mandriva, etc

        '        Mac(OSX)
        '* 32-bit 10.5.x Leopard (the only 64-bit 10.5 is Server, which isn't supported)
        '* 32-bit 10.6.x Snow Leopard
        '* 64-bit 10.6.x Snow Leopard
        '* 32-bit 10.7.x Lion
        '* 64-bit 10.7.x Lion
        '* 64-bit 10.8.x Mountain Lion (there is no 32-bit version)
        '* 64-bit 10.9.x Mavericks (there is no 32-bit version)

    End Sub

   

    Private Sub frmload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oslongname(0) = "32-bit Windows XP Service Pack 2"
        oslongname(1) = "32-bit Windows XP Service Pack 3"
        oslongname(2) = "32-bit Windows 2003 Server Service Pack 0"
        oslongname(3) = "32-bit Windows 2003 Server Service Pack 1"
        oslongname(4) = "32-bit Windows 2003 Server Service Pack 2"
        oslongname(5) = "32-bit Windows Vista Service Pack 0"
        oslongname(6) = "32-bit Windows Vista Service Pack 1"
        oslongname(7) = "32-bit Windows Vista Service Pack 2"
        oslongname(8) = "32-bit Windows 2008 Server Service Pack 1"
        oslongname(9) = "32-bit Windows 2008 Server Service Pack 2"
        oslongname(10) = "32-bit Windows 7 Service Pack 0"
        oslongname(11) = "32-bit Windows 7 Service Pack 1"
        oslongname(12) = "32-bit Windows 8 and 8.1"
        oslongname(13) = "64-bit Windows 7 Service Pack 0"
        oslongname(14) = "64-bit Windows 7 Service Pack 1"
        oslongname(15) = "64-bit Windows 8 and 8.1"
        oslongname(16) = "64-bit Windows 2003 Server Service Pack 1"
        oslongname(17) = "64-bit Windows 2003 Server Service Pack 2"
        oslongname(18) = "64-bit Windows Vista Service Pack 0"
        oslongname(19) = "64-bit Windows Vista Service Pack 1"
        oslongname(20) = "64-bit Windows Vista Service Pack 2"
        oslongname(21) = "64-bit Windows 2008 Server Service Pack 1"
        oslongname(22) = "64-bit Windows 2008 Server Service Pack 2"
        oslongname(23) = "64-bit Windows 2008 R2 Server Service Pack 0"
        oslongname(24) = "64-bit Windows 2008 R2 Server Service Pack 1"
        oslongname(25) = "64-bit Windows Server 2012 and 2012 R2 "


        

        ' ":::"
        osshrtname(0) = "WinXPSP2x86"
        osshrtname(1) = "WinXPSP3x86"
        osshrtname(2) = ""
        osshrtname(3) = ""
        osshrtname(4) = ""
        osshrtname(5) = ""
        osshrtname(6) = ""
        osshrtname(7) = ""
        osshrtname(8) = ""
        osshrtname(9) = ""
        osshrtname(10) = "Win7SP0x86"
        osshrtname(11) = "Win7SP1x86"
        osshrtname(12) = ""
        osshrtname(13) = "Win7SP0x64"
        osshrtname(14) = "Win7SP0x64"
        osshrtname(15) = ""
        osshrtname(16) = ""
        osshrtname(17) = ""
        osshrtname(18) = ""
        osshrtname(19) = ""
        osshrtname(20) = ""
        osshrtname(21) = ""
        osshrtname(22) = ""
        osshrtname(23) = ""
        osshrtname(24) = ""
        osshrtname(25) = ""
    End Sub

    Private Sub txthash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthash.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class