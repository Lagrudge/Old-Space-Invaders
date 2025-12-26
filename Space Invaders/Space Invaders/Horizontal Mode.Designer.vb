<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorizontal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorizontal))
        Me.lblPause = New System.Windows.Forms.Label()
        Me.tmrAliens = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCollisionDetect = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCannonMovement = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Life2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Life1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Life3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.tmrScore = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWaveComplete = New System.Windows.Forms.Timer(Me.components)
        Me.lblWaveComplete = New System.Windows.Forms.Label()
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.picCannon = New System.Windows.Forms.PictureBox()
        CType(Me.picCannon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPause
        '
        Me.lblPause.BackColor = System.Drawing.Color.Honeydew
        Me.lblPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPause.Font = New System.Drawing.Font("Stencil", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.Color.Lime
        Me.lblPause.Location = New System.Drawing.Point(424, 165)
        Me.lblPause.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(379, 118)
        Me.lblPause.TabIndex = 18
        Me.lblPause.Text = "Paused "
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPause.UseWaitCursor = True
        Me.lblPause.Visible = False
        '
        'tmrAliens
        '
        Me.tmrAliens.Interval = 150
        '
        'tmrCollisionDetect
        '
        Me.tmrCollisionDetect.Interval = 1
        '
        'tmrBullet
        '
        Me.tmrBullet.Interval = 10
        '
        'tmrCannonMovement
        '
        Me.tmrCannonMovement.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 46)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "SCORE:"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Stencil", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Lime
        Me.lblScore.Location = New System.Drawing.Point(167, 9)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(242, 48)
        Me.lblScore.TabIndex = 21
        Me.lblScore.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Stencil", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(714, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 46)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "LIVES"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Life2, Me.Life1, Me.Life3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1342, 491)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'Life2
        '
        Me.Life2.Location = New System.Drawing.Point(1133, 10)
        Me.Life2.Name = "Life2"
        Me.Life2.Size = New System.Drawing.Size(50, 50)
        '
        'Life1
        '
        Me.Life1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Life1.Location = New System.Drawing.Point(1208, 11)
        Me.Life1.Name = "Life1"
        Me.Life1.Size = New System.Drawing.Size(50, 50)
        '
        'Life3
        '
        Me.Life3.Location = New System.Drawing.Point(1281, 12)
        Me.Life3.Name = "Life3"
        Me.Life3.Size = New System.Drawing.Size(50, 50)
        '
        'lblGameOver
        '
        Me.lblGameOver.BackColor = System.Drawing.Color.Honeydew
        Me.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblGameOver.Font = New System.Drawing.Font("Stencil", 49.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.Lime
        Me.lblGameOver.Location = New System.Drawing.Point(117, 165)
        Me.lblGameOver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(411, 162)
        Me.lblGameOver.TabIndex = 24
        Me.lblGameOver.Text = "GAME OVER"
        Me.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGameOver.UseWaitCursor = True
        Me.lblGameOver.Visible = False
        '
        'tmrScore
        '
        Me.tmrScore.Interval = 1
        '
        'tmrWaveComplete
        '
        '
        'lblWaveComplete
        '
        Me.lblWaveComplete.BackColor = System.Drawing.Color.Honeydew
        Me.lblWaveComplete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWaveComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblWaveComplete.Font = New System.Drawing.Font("Stencil", 49.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaveComplete.ForeColor = System.Drawing.Color.Lime
        Me.lblWaveComplete.Location = New System.Drawing.Point(323, 188)
        Me.lblWaveComplete.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWaveComplete.Name = "lblWaveComplete"
        Me.lblWaveComplete.Size = New System.Drawing.Size(610, 150)
        Me.lblWaveComplete.TabIndex = 25
        Me.lblWaveComplete.Text = "WAVE COMPLETE"
        Me.lblWaveComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWaveComplete.UseWaitCursor = True
        Me.lblWaveComplete.Visible = False
        '
        'tmrReload
        '
        Me.tmrReload.Interval = 1
        '
        'picCannon
        '
        Me.picCannon.BackColor = System.Drawing.Color.Black
        Me.picCannon.Image = CType(resources.GetObject("picCannon.Image"), System.Drawing.Image)
        Me.picCannon.Location = New System.Drawing.Point(299, 341)
        Me.picCannon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picCannon.Name = "picCannon"
        Me.picCannon.Size = New System.Drawing.Size(150, 80)
        Me.picCannon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCannon.TabIndex = 19
        Me.picCannon.TabStop = False
        '
        'frmHorizontal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 491)
        Me.Controls.Add(Me.lblWaveComplete)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCannon)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmHorizontal"
        Me.Text = "SPACE INVADERS  - HORIZONTAL MODE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picCannon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents picCannon As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCollisionDetect As System.Windows.Forms.Timer
    Friend WithEvents tmrBullet As System.Windows.Forms.Timer
    Friend WithEvents tmrCannonMovement As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Life2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Life1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Life3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents tmrScore As System.Windows.Forms.Timer
    Friend WithEvents tmrAliens As System.Windows.Forms.Timer
    Friend WithEvents tmrWaveComplete As System.Windows.Forms.Timer
    Friend WithEvents lblWaveComplete As System.Windows.Forms.Label
    Friend WithEvents tmrReload As System.Windows.Forms.Timer
End Class
