<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPositionChange
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        SpMain = New SplitContainer()
        SpData = New SplitContainer()
        TxtFrom = New TextBox()
        TxtTo = New TextBox()
        CmdInsert = New Button()
        CmdSwitch = New Button()
        CmdCopy = New Button()
        CmdClose = New Button()
        CType(SpMain, ComponentModel.ISupportInitialize).BeginInit()
        SpMain.Panel1.SuspendLayout()
        SpMain.Panel2.SuspendLayout()
        SpMain.SuspendLayout()
        CType(SpData, ComponentModel.ISupportInitialize).BeginInit()
        SpData.Panel1.SuspendLayout()
        SpData.Panel2.SuspendLayout()
        SpData.SuspendLayout()
        SuspendLayout()
        ' 
        ' SpMain
        ' 
        SpMain.Dock = DockStyle.Fill
        SpMain.FixedPanel = FixedPanel.Panel1
        SpMain.IsSplitterFixed = True
        SpMain.Location = New Point(0, 0)
        SpMain.Name = "SpMain"
        SpMain.Orientation = Orientation.Horizontal
        ' 
        ' SpMain.Panel1
        ' 
        SpMain.Panel1.Controls.Add(CmdClose)
        SpMain.Panel1.Controls.Add(CmdCopy)
        SpMain.Panel1.Controls.Add(CmdSwitch)
        SpMain.Panel1.Controls.Add(CmdInsert)
        ' 
        ' SpMain.Panel2
        ' 
        SpMain.Panel2.Controls.Add(SpData)
        SpMain.Size = New Size(800, 450)
        SpMain.TabIndex = 0
        ' 
        ' SpData
        ' 
        SpData.Dock = DockStyle.Fill
        SpData.Location = New Point(0, 0)
        SpData.Name = "SpData"
        ' 
        ' SpData.Panel1
        ' 
        SpData.Panel1.Controls.Add(TxtFrom)
        ' 
        ' SpData.Panel2
        ' 
        SpData.Panel2.Controls.Add(TxtTo)
        SpData.Size = New Size(800, 396)
        SpData.SplitterDistance = 266
        SpData.SplitterWidth = 10
        SpData.TabIndex = 0
        ' 
        ' TxtFrom
        ' 
        TxtFrom.Dock = DockStyle.Fill
        TxtFrom.Location = New Point(0, 0)
        TxtFrom.Multiline = True
        TxtFrom.Name = "TxtFrom"
        TxtFrom.Size = New Size(266, 396)
        TxtFrom.TabIndex = 0
        ' 
        ' TxtTo
        ' 
        TxtTo.Dock = DockStyle.Fill
        TxtTo.Location = New Point(0, 0)
        TxtTo.Multiline = True
        TxtTo.Name = "TxtTo"
        TxtTo.Size = New Size(524, 396)
        TxtTo.TabIndex = 0
        ' 
        ' CmdInsert
        ' 
        CmdInsert.Location = New Point(106, 12)
        CmdInsert.Name = "CmdInsert"
        CmdInsert.Size = New Size(75, 23)
        CmdInsert.TabIndex = 0
        CmdInsert.Text = "Insert"
        CmdInsert.UseVisualStyleBackColor = True
        ' 
        ' CmdSwitch
        ' 
        CmdSwitch.Location = New Point(230, 12)
        CmdSwitch.Name = "CmdSwitch"
        CmdSwitch.Size = New Size(75, 23)
        CmdSwitch.TabIndex = 0
        CmdSwitch.Text = "Switch"
        CmdSwitch.UseVisualStyleBackColor = True
        ' 
        ' CmdCopy
        ' 
        CmdCopy.Location = New Point(351, 12)
        CmdCopy.Name = "CmdCopy"
        CmdCopy.Size = New Size(75, 23)
        CmdCopy.TabIndex = 0
        CmdCopy.Text = "Copy"
        CmdCopy.UseVisualStyleBackColor = True
        ' 
        ' CmdClose
        ' 
        CmdClose.Location = New Point(701, 12)
        CmdClose.Name = "CmdClose"
        CmdClose.Size = New Size(75, 23)
        CmdClose.TabIndex = 0
        CmdClose.Text = "Close"
        CmdClose.UseVisualStyleBackColor = True
        ' 
        ' FrmPositionChange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SpMain)
        Name = "FrmPositionChange"
        Text = "FrmPositionChange"
        SpMain.Panel1.ResumeLayout(False)
        SpMain.Panel2.ResumeLayout(False)
        CType(SpMain, ComponentModel.ISupportInitialize).EndInit()
        SpMain.ResumeLayout(False)
        SpData.Panel1.ResumeLayout(False)
        SpData.Panel1.PerformLayout()
        SpData.Panel2.ResumeLayout(False)
        SpData.Panel2.PerformLayout()
        CType(SpData, ComponentModel.ISupportInitialize).EndInit()
        SpData.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SpMain As SplitContainer
    Friend WithEvents CmdSwitch As Button
    Friend WithEvents CmdInsert As Button
    Friend WithEvents SpData As SplitContainer
    Friend WithEvents TxtFrom As TextBox
    Friend WithEvents TxtTo As TextBox
    Friend WithEvents CmdClose As Button
    Friend WithEvents CmdCopy As Button
End Class
