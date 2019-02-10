Module Module1
    Public volexe As String = "volrun.exe"
    Public dumppath As String
    Public profile As String
    Public md5hashvalue As String


    Public Function volengine(ByVal volArguments As String) As String()
        Dim myProcess As New Process()
        Dim line As String
        Dim linecount As Integer = 1
        Dim outList As New List(Of String)()
        Dim output() As String = {}

        myProcess.StartInfo.FileName = volexe
        myProcess.StartInfo.Arguments = volArguments
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.RedirectStandardOutput = True

        myProcess.Start()

        Do
            line = myProcess.StandardOutput.ReadLine
            If Not line Is Nothing Then

                outList.Add(line)

                linecount += 1
            End If
        Loop Until line Is Nothing

        If outList.Count = 0 Then
            outList.Add("")
            outList.Add("Plugin not supported to image type or no profile selected")
        End If
        Return outList.ToArray
    End Function

End Module
