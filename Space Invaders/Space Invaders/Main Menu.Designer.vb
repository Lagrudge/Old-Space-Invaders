<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.butStart = New System.Windows.Forms.Button()
        Me.butScore = New System.Windows.Forms.Button()
        Me.mnsLmao = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInputScoreBoard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRetro = New System.Windows.Forms.ToolStripMenuItem()
        Me.leDash = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.butOptions = New System.Windows.Forms.Button()
        Me.fbgSave = New System.Windows.Forms.FolderBrowserDialog()
        Me.mnsLmao.SuspendLayout()
        Me.SuspendLayout()
        '
        'butStart
        '
        Me.butStart.Location = New System.Drawing.Point(380, 140)
        Me.butStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butStart.Name = "butStart"
        Me.butStart.Size = New System.Drawing.Size(520, 123)
        Me.butStart.TabIndex = 0
        Me.butStart.Text = "&BEGIN"
        Me.butStart.UseVisualStyleBackColor = True
        '
        'butScore
        '
        Me.butScore.Location = New System.Drawing.Point(380, 399)
        Me.butScore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butScore.Name = "butScore"
        Me.butScore.Size = New System.Drawing.Size(520, 123)
        Me.butScore.TabIndex = 1
        Me.butScore.Text = "ScoreBoard"
        Me.butScore.UseVisualStyleBackColor = True
        '
        'mnsLmao
        '
        Me.mnsLmao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuGameMode})
        Me.mnsLmao.Location = New System.Drawing.Point(0, 0)
        Me.mnsLmao.Name = "mnsLmao"
        Me.mnsLmao.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnsLmao.Size = New System.Drawing.Size(1276, 28)
        Me.mnsLmao.TabIndex = 2
        Me.mnsLmao.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInputScoreBoard})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuInputScoreBoard
        '
        Me.mnuInputScoreBoard.Name = "mnuInputScoreBoard"
        Me.mnuInputScoreBoard.Size = New System.Drawing.Size(204, 24)
        Me.mnuInputScoreBoard.Text = "Import ScoreBoard"
        '
        'mnuGameMode
        '
        Me.mnuGameMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRetro, Me.leDash, Me.mnuHorizontal})
        Me.mnuGameMode.Name = "mnuGameMode"
        Me.mnuGameMode.Size = New System.Drawing.Size(103, 24)
        Me.mnuGameMode.Text = "&Game Mode"
        '
        'mnuRetro
        '
        Me.mnuRetro.Name = "mnuRetro"
        Me.mnuRetro.Size = New System.Drawing.Size(148, 24)
        Me.mnuRetro.Text = "Retro "
        '
        'leDash
        '
        Me.leDash.Name = "leDash"
        Me.leDash.Size = New System.Drawing.Size(145, 6)
        '
        'mnuHorizontal
        '
        Me.mnuHorizontal.Name = "mnuHorizontal"
        Me.mnuHorizontal.Size = New System.Drawing.Size(148, 24)
        Me.mnuHorizontal.Text = "Horizontal"
        '
        'butOptions
        '
        Me.butOptions.Location = New System.Drawing.Point(380, 270)
        Me.butOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butOptions.Name = "butOptions"
        Me.butOptions.Size = New System.Drawing.Size(520, 123)
        Me.butOptions.TabIndex = 3
        Me.butOptions.Text = "Options"
        Me.butOptions.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1276, 783)
        Me.Controls.Add(Me.butOptions)
        Me.Controls.Add(Me.butScore)
        Me.Controls.Add(Me.butStart)
        Me.Controls.Add(Me.mnsLmao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsLmao
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainMenu"
        Me.Text = "SPACE INVADERS"
        Me.mnsLmao.ResumeLayout(False)
        Me.mnsLmao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butStart As System.Windows.Forms.Button
    Friend WithEvents butScore As System.Windows.Forms.Button
    Friend WithEvents mnsLmao As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGameMode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRetro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInputScoreBoard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents butOptions As System.Windows.Forms.Button
    Friend WithEvents leDash As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fbgSave As System.Windows.Forms.FolderBrowserDialog

End Class
