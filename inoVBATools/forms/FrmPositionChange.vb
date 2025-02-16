Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports inoVBAToolsDLL

Public Class FrmPositionChange
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdCopy_Click(sender As Object, e As EventArgs) Handles CmdCopy.Click
        Clipboard.SetText(TxtTo.Text)
    End Sub

    Private Sub CmdSwitch_Click(sender As Object, e As EventArgs) Handles CmdSwitch.Click
        Dim cSW As New ClsSwitch
        TxtTo.Text = cSW.SwitchPosition(TxtFrom.Text)
    End Sub

    Private Sub CmdInsert_Click(sender As Object, e As EventArgs) Handles CmdInsert.Click
        TxtFrom.Text = Clipboard.GetText()
    End Sub

    Private Sub FrmPositionChange_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CmdClose.Left = Me.Width - CmdClose.Width - 30
        CmdInsert.Left = Me.Width / 4 - CmdInsert.Width / 2
        CmdCopy.Left = Me.Width / 4 * 3 - CmdCopy.Width / 2
        CmdSwitch.Left = Me.Width / 2 - CmdSwitch.Width / 2
        SpData.SplitterDistance = SpData.Width \ 2
    End Sub

    Private Sub FrmPositionChange_Load(sender As Object, e As EventArgs) Handles Me.Load
        translateForm
    End Sub

    Private Sub translateForm()
        CmdSwitch.Text = My.Resources.ResourceLang.BtnSwitch
        CmdInsert.Text = My.Resources.ResourceLang.BtnInsert
        CmdCopy.Text = My.Resources.ResourceLang.BtnCopy
        CmdClose.Text = My.Resources.ResourceLang.BtnClose

        Me.Text = My.Resources.ResourceLang.BtnSwitch
    End Sub
End Class