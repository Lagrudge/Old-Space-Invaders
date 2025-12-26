<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.gpbMovement = New System.Windows.Forms.GroupBox()
        Me.rtbInstructions = New System.Windows.Forms.RichTextBox()
        Me.lblCannonSensitivity = New System.Windows.Forms.Label()
        Me.hsbCannonSensitivity = New System.Windows.Forms.HScrollBar()
        Me.tlt = New System.Windows.Forms.ToolTip(Me.components)
        Me.radMinView = New System.Windows.Forms.RadioButton()
        Me.radOptimal = New System.Windows.Forms.RadioButton()
        Me.lblCanSens = New System.Windows.Forms.Label()
        Me.tmrCanSens = New System.Windows.Forms.Timer(Me.components)
        Me.tspBack = New System.Windows.Forms.ToolStrip()
        Me.tsbBack = New System.Windows.Forms.ToolStripButton()
        Me.lblBack = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.iml = New System.Windows.Forms.ImageList(Me.components)
        Me.chkInvert = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Options = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.butFont = New System.Windows.Forms.Button()
        Me.butTextColour = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudWave = New System.Windows.Forms.NumericUpDown()
        Me.nudLives = New System.Windows.Forms.NumericUpDown()
        Me.cdgAll = New System.Windows.Forms.ColorDialog()
        Me.fdgAll = New System.Windows.Forms.FontDialog()
        Me.gpbMovement.SuspendLayout()
        Me.tspBack.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Options.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nudWave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbMovement
        '
        Me.gpbMovement.Controls.Add(Me.rtbInstructions)
        Me.gpbMovement.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbMovement.ForeColor = System.Drawing.Color.Lime
        Me.gpbMovement.Location = New System.Drawing.Point(8, 20)
        Me.gpbMovement.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbMovement.Name = "gpbMovement"
        Me.gpbMovement.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbMovement.Size = New System.Drawing.Size(672, 247)
        Me.gpbMovement.TabIndex = 0
        Me.gpbMovement.TabStop = False
        Me.gpbMovement.Text = "Instructions"
        '
        'rtbInstructions
        '
        Me.rtbInstructions.BackColor = System.Drawing.Color.Black
        Me.rtbInstructions.ForeColor = System.Drawing.Color.Lime
        Me.rtbInstructions.HideSelection = False
        Me.rtbInstructions.Location = New System.Drawing.Point(19, 26)
        Me.rtbInstructions.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbInstructions.Name = "rtbInstructions"
        Me.rtbInstructions.ReadOnly = True
        Me.rtbInstructions.ShowSelectionMargin = True
        Me.rtbInstructions.Size = New System.Drawing.Size(631, 213)
        Me.rtbInstructions.TabIndex = 0
        Me.rtbInstructions.Text = resources.GetString("rtbInstructions.Text")
        '
        'lblCannonSensitivity
        '
        Me.lblCannonSensitivity.AutoSize = True
        Me.lblCannonSensitivity.Font = New System.Drawing.Font("Stencil", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCannonSensitivity.ForeColor = System.Drawing.Color.Lime
        Me.lblCannonSensitivity.Location = New System.Drawing.Point(16, 310)
        Me.lblCannonSensitivity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCannonSensitivity.Name = "lblCannonSensitivity"
        Me.lblCannonSensitivity.Size = New System.Drawing.Size(266, 30)
        Me.lblCannonSensitivity.TabIndex = 1
        Me.lblCannonSensitivity.Text = "Cannon Sensitivity"
        Me.tlt.SetToolTip(Me.lblCannonSensitivity, "how fast the cannon moves")
        '
        'hsbCannonSensitivity
        '
        Me.hsbCannonSensitivity.Location = New System.Drawing.Point(21, 351)
        Me.hsbCannonSensitivity.Maximum = 109
        Me.hsbCannonSensitivity.Minimum = 1
        Me.hsbCannonSensitivity.Name = "hsbCannonSensitivity"
        Me.hsbCannonSensitivity.Size = New System.Drawing.Size(269, 21)
        Me.hsbCannonSensitivity.TabIndex = 2
        Me.hsbCannonSensitivity.Value = 10
        '
        'radMinView
        '
        Me.radMinView.AutoSize = True
        Me.radMinView.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMinView.ForeColor = System.Drawing.Color.Lime
        Me.radMinView.Location = New System.Drawing.Point(368, 228)
        Me.radMinView.Name = "radMinView"
        Me.radMinView.Size = New System.Drawing.Size(256, 33)
        Me.radMinView.TabIndex = 11
        Me.radMinView.TabStop = True
        Me.radMinView.Text = "Minimilistic View"
        Me.tlt.SetToolTip(Me.radMinView, "A simplified version used for performance.")
        Me.radMinView.UseVisualStyleBackColor = True
        '
        'radOptimal
        '
        Me.radOptimal.AutoSize = True
        Me.radOptimal.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOptimal.ForeColor = System.Drawing.Color.Lime
        Me.radOptimal.Location = New System.Drawing.Point(368, 326)
        Me.radOptimal.Name = "radOptimal"
        Me.radOptimal.Size = New System.Drawing.Size(199, 33)
        Me.radOptimal.TabIndex = 12
        Me.radOptimal.TabStop = True
        Me.radOptimal.Text = "Optimal View"
        Me.tlt.SetToolTip(Me.radOptimal, "The way the developer of this game intended for it to be played.")
        Me.radOptimal.UseVisualStyleBackColor = True
        '
        'lblCanSens
        '
        Me.lblCanSens.AutoSize = True
        Me.lblCanSens.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanSens.ForeColor = System.Drawing.Color.Lime
        Me.lblCanSens.Location = New System.Drawing.Point(295, 350)
        Me.lblCanSens.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCanSens.Name = "lblCanSens"
        Me.lblCanSens.Size = New System.Drawing.Size(27, 29)
        Me.lblCanSens.TabIndex = 3
        Me.lblCanSens.Text = "0"
        '
        'tmrCanSens
        '
        Me.tmrCanSens.Interval = 1
        '
        'tspBack
        '
        Me.tspBack.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBack, Me.lblBack, Me.ToolStripSeparator1})
        Me.tspBack.Location = New System.Drawing.Point(0, 0)
        Me.tspBack.Name = "tspBack"
        Me.tspBack.Size = New System.Drawing.Size(869, 25)
        Me.tspBack.TabIndex = 4
        '
        'tsbBack
        '
        Me.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBack.Image = CType(resources.GetObject("tsbBack.Image"), System.Drawing.Image)
        Me.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBack.Name = "tsbBack"
        Me.tsbBack.Size = New System.Drawing.Size(23, 22)
        Me.tsbBack.Text = "Back To Main Menu"
        '
        'lblBack
        '
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(40, 22)
        Me.lblBack.Text = "Back"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'iml
        '
        Me.iml.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iml.ImageSize = New System.Drawing.Size(16, 16)
        Me.iml.TransparentColor = System.Drawing.Color.Transparent
        '
        'chkInvert
        '
        Me.chkInvert.AutoSize = True
        Me.chkInvert.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInvert.ForeColor = System.Drawing.Color.Lime
        Me.chkInvert.Location = New System.Drawing.Point(400, 345)
        Me.chkInvert.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInvert.Name = "chkInvert"
        Me.chkInvert.Size = New System.Drawing.Size(243, 33)
        Me.chkInvert.TabIndex = 5
        Me.chkInvert.Text = "Invert Controls"
        Me.chkInvert.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(96, 476)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.TrackBar1.Maximum = 4
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(495, 56)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.Value = 2
        '
        'Options
        '
        Me.Options.Controls.Add(Me.TabPage1)
        Me.Options.Controls.Add(Me.TabPage2)
        Me.Options.Location = New System.Drawing.Point(93, 34)
        Me.Options.Margin = New System.Windows.Forms.Padding(4)
        Me.Options.Name = "Options"
        Me.Options.SelectedIndex = 0
        Me.Options.Size = New System.Drawing.Size(699, 638)
        Me.Options.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.gpbMovement)
        Me.TabPage1.Controls.Add(Me.TrackBar1)
        Me.TabPage1.Controls.Add(Me.lblCannonSensitivity)
        Me.TabPage1.Controls.Add(Me.chkInvert)
        Me.TabPage1.Controls.Add(Me.hsbCannonSensitivity)
        Me.TabPage1.Controls.Add(Me.lblCanSens)
        Me.TabPage1.ForeColor = System.Drawing.Color.Lime
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(691, 609)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Options"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(520, 535)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Insane"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(415, 535)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(281, 535)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Medium"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(188, 535)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Easy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(269, 446)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Difficulty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(91, 535)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Baby"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.radOptimal)
        Me.TabPage2.Controls.Add(Me.radMinView)
        Me.TabPage2.Controls.Add(Me.butFont)
        Me.TabPage2.Controls.Add(Me.butTextColour)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.nudWave)
        Me.TabPage2.Controls.Add(Me.nudLives)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(691, 609)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced Options"
        '
        'butFont
        '
        Me.butFont.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butFont.ForeColor = System.Drawing.Color.Lime
        Me.butFont.Location = New System.Drawing.Point(13, 310)
        Me.butFont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butFont.Name = "butFont"
        Me.butFont.Size = New System.Drawing.Size(205, 64)
        Me.butFont.TabIndex = 10
        Me.butFont.Text = "Font"
        Me.butFont.UseVisualStyleBackColor = True
        '
        'butTextColour
        '
        Me.butTextColour.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butTextColour.ForeColor = System.Drawing.Color.Lime
        Me.butTextColour.Location = New System.Drawing.Point(13, 228)
        Me.butTextColour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.butTextColour.Name = "butTextColour"
        Me.butTextColour.Size = New System.Drawing.Size(205, 58)
        Me.butTextColour.TabIndex = 9
        Me.butTextColour.Text = "Text Colour"
        Me.butTextColour.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(4, 122)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(316, 29)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Number of Aliens / Wave"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(8, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Number of Lives"
        '
        'nudWave
        '
        Me.nudWave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudWave.Location = New System.Drawing.Point(368, 117)
        Me.nudWave.Margin = New System.Windows.Forms.Padding(4)
        Me.nudWave.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudWave.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWave.Name = "nudWave"
        Me.nudWave.Size = New System.Drawing.Size(160, 34)
        Me.nudWave.TabIndex = 1
        Me.nudWave.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'nudLives
        '
        Me.nudLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLives.Location = New System.Drawing.Point(368, 34)
        Me.nudLives.Margin = New System.Windows.Forms.Padding(4)
        Me.nudLives.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudLives.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLives.Name = "nudLives"
        Me.nudLives.Size = New System.Drawing.Size(160, 34)
        Me.nudLives.TabIndex = 0
        Me.nudLives.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(869, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.tspBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.Text = "frmOptions"
        Me.gpbMovement.ResumeLayout(False)
        Me.tspBack.ResumeLayout(False)
        Me.tspBack.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Options.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nudWave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbMovement As System.Windows.Forms.GroupBox
    Friend WithEvents tlt As System.Windows.Forms.ToolTip
    Friend WithEvents lblCannonSensitivity As System.Windows.Forms.Label
    Friend WithEvents hsbCannonSensitivity As System.Windows.Forms.HScrollBar
    Friend WithEvents lblCanSens As System.Windows.Forms.Label
    Friend WithEvents tmrCanSens As System.Windows.Forms.Timer
    Friend WithEvents tspBack As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblBack As System.Windows.Forms.ToolStripLabel
    Friend WithEvents iml As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkInvert As System.Windows.Forms.CheckBox
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Options As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudWave As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLives As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents butFont As System.Windows.Forms.Button
    Friend WithEvents butTextColour As System.Windows.Forms.Button
    Friend WithEvents cdgAll As System.Windows.Forms.ColorDialog
    Friend WithEvents fdgAll As System.Windows.Forms.FontDialog
    Friend WithEvents rtbInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents radOptimal As System.Windows.Forms.RadioButton
    Friend WithEvents radMinView As System.Windows.Forms.RadioButton
End Class
