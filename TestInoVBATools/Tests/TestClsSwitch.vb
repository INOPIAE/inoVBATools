Imports NUnit.Framework
Imports File = System.IO.File
Imports NUnit.Framework.Internal
Imports inoVBAToolsDLL
Imports System.IO


Namespace TestInoVBATools
    Public Class TestClsSwitch
        Private testPath As String = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)).Replace("\bin", ""), "TestData")
        'Private DBFile As String = testPath & "\TestData\DB\pfalzenCurrentDB.accdb"
        Private cSW As inoVBAToolsDLL.ClsSwitch
        Private cHelper As New ClsHelper
        Private testFolder As String


        <SetUp>
        Public Sub Setup()
            testFolder = cHelper.CreateTestFolder("currenttestdata")
            cHelper.DeleteTestFolder(testFolder)
            'DBFileTest = testFolder & "\pfalzenCurrentDB.accdb"
            'File.Copy(DBFile, DBFileTest)
            cSW = New inoVBAToolsDLL.ClsSwitch
        End Sub

        <TearDown>
        Public Sub TearDown()
            cHelper.DeleteTestFolder(testFolder)
        End Sub

        <Test>
        Public Sub TestSwitchPositionLine()
            Dim testLine As String = "   c = b"
            Dim result As String = cSW.SwitchPositionLine(testLine)

            Assert.That(result, NUnit.Framework.Is.EqualTo("   b = c"))


            testLine = " Hello World"
            result = cSW.SwitchPositionLine(testLine)

            Assert.That(result, NUnit.Framework.Is.EqualTo(testLine))

        End Sub

        <Test>
        Public Sub TestSwitchPosition()
            Dim testLine(4) As String
            testLine(0) = " Hello World"
            testLine(1) = "   c = b"
            testLine(2) = "   d = a"
            testLine(3) = ""
            testLine(4) = "   f = g"

            Dim result As String = cSW.SwitchPosition(String.Join(vbCrLf, testLine))

            Dim resultlines As String() = result.Split({vbCrLf}, StringSplitOptions.None)

            Assert.That(resultlines(0), NUnit.Framework.Is.EqualTo(testLine(0)))
            Assert.That(resultlines(1), NUnit.Framework.Is.EqualTo("   b = c"))
            Assert.That(resultlines(2), NUnit.Framework.Is.EqualTo("   a = d"))
            Assert.That(resultlines(3), NUnit.Framework.Is.EqualTo(testLine(3)))
            Assert.That(resultlines(4), NUnit.Framework.Is.EqualTo("   g = f"))

        End Sub
    End Class
End Namespace
