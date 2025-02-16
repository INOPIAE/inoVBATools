Public Class ClsSwitch
    Public Function SwitchPosition(strText As String) As String
        Dim lines As String() = strText.Split({vbCrLf}, StringSplitOptions.None)

        For i As Integer = 0 To lines.Count - 1
            lines(i) = SwitchPositionLine(lines(i))
        Next

        Return String.Join(vbCrLf, lines)

    End Function

    Public Function SwitchPositionLine(strText As String) As String
        Dim count As Integer = strText.TakeWhile(Function(c) c = " "c).Count()
        Dim strT() As String = strText.Trim.Split("=")
        If strT.Count = 1 Then
            Return strText
        Else
            Return String.Format("{0}{1} = {2}", New String(" "c, count), strT(1).Trim, strT(0).Trim)
        End If
    End Function
End Class
