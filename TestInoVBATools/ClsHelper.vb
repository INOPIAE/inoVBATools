Imports System.IO
Imports System.Text
Imports NUnit.Framework
Public Class ClsHelper

    Public Structure TestSettings
        Public repo As String
        Public remote As String
        Public branch As String
    End Structure


    Public Function CreateTestFolder(Optional strSubfolder As String = "") As String
        Dim strFolder As String = Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)

        strFolder &= "\" & strSubfolder
        Directory.CreateDirectory(strFolder)
        Return strFolder
    End Function

    Public Function CreateLocalTestFolder(Optional strLocalPath As String = "c:\Testing", Optional strSubfolder As String = "") As String
        Dim strFolder As String = Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)

        strFolder = strLocalPath & "\" & strSubfolder
        Directory.CreateDirectory(strFolder)
        Return strFolder
    End Function

    Public Sub DeleteTestFolder(strFolder)
        ' KillGitProcesses()

        For Each d In Directory.GetDirectories(strFolder)
            DeleteFilesAndFolders(d)
        Next

        For Each f In Directory.GetFiles(strFolder)
            File.Delete(f)
        Next
    End Sub

    Public Function GetTestsettings(FilePath As String) As TestSettings
        Dim ts As New TestSettings
        Dim stream As New FileStream(FilePath, FileMode.Open)
        Dim line As String
        Dim flag As Boolean = True
        Dim reader As StreamReader
        reader = New StreamReader(stream, Encoding.UTF8)

        While (flag = True)
            line = reader.ReadLine()
            If (line = Nothing) Then
                flag = False
            Else
                Dim lSplit As String() = line.Split(":", 2)
                Select Case lSplit(0)
                    Case "branch"
                        ts.repo = lSplit(1).Trim
                    Case "remote"
                        ts.remote = lSplit(1).Trim
                    Case "branch"
                        ts.branch = lSplit(1).Trim
                End Select
            End If
        End While
        reader.Close()
        Return ts
    End Function

    Public Sub KillGitProcesses()
        Try
            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/C taskkill /IM git.exe /F"
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.Start()
            process.WaitForExit()

            Console.WriteLine("All currrent git.exe processes were terminated.")
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub DeleteFilesAndFolders(path As String)
        Try
            ' Alle Dateien löschen
            For Each fileF As String In Directory.GetFiles(path, "*", SearchOption.AllDirectories)
                File.SetAttributes(fileF, FileAttributes.Normal) ' Falls ReadOnly gesetzt ist
                File.Delete(fileF)
            Next

            ' Danach den Ordner selbst löschen
            Directory.Delete(path, True)
            Console.WriteLine("Folder successfull deleted: " & path)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Class
