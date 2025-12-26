Public Class frmHorizontal

    REM **************************************************************************************************************************************************
    REM     Variable Dictionary :
    REM AlienWave1 (Array of Picturebox) = The first wave of aliens.
    REM AlienWave2 (Array of Picturebox) = The second wave of aliens
    REM AlienWave3 (Array of Picturebox) = The third wave of aliens
    REM AlienWave4 (Array of Picturebox) = The fourth wave of aliens
    REM AlienWave5 (Array of Picturebox) = The fifth wave of aliens
    REM alienmove (Integer) = Counter for the first wave of aliens
    REM alienmove2 (Integer) = Counter for the second wave of aliens
    REM alienmove3 (Integer) = Counter for the third wave of aliens
    REM alienmove4 (Integer) = Counter for the fourth wave of aliens
    REM alienmove5 (Integer) = Counter for the fifth wave of aliens
    REM Bullets (Integer) = Number of bullets fired by the cannon
    REM MovingLeft (Boolean) = The Cannon is moving to the left (true) or not (false)
    REM MovingRight (Boolean) = The Cannon is moving to the right (true) or not (false)
    REM Lives (Integer) = The player's lives, or chances to come back from the dead
    REM Paused (Boolean) = If the game is paused (true) or running)
    REM Player (String) = Name of the player
    REM Shots (Array of Bullet) = The amount of bullets fired in total
    REM this (Integer) = the x position of the aliens
    REM that (Integer) = the y position of the aliens
    REM Score (Integer) = The score
    REM WaveLevelComplete (Integer) = An indicator that all aliens in the wave have perished.
    REM ticks (Integer) = A tick counter for the Wave Complete's timer
    REM wave (Integer) = An indicator for the next wave of aliens to appear
    REM ***************************************************************************************************************************************************


    Dim AlienWave1((AlienNum - 1)) As PictureBox
    Dim AlienWave2((AlienNum - 1)) As PictureBox
    Dim AlienWave3((AlienNum - 1)) As PictureBox
    Dim AlienWave4((AlienNum - 1)) As PictureBox
    Dim AlienWave5((AlienNum - 1)) As PictureBox

    Dim Paused As Boolean = False


    Dim Bullets As Integer = 0
    Dim Shots(0) As Bullet

    Dim this As Integer = 1
    Dim that As Integer = 100

    Dim alienmove As Integer = 10
    Dim alienmove2 As Integer = 10
    Dim alienmove3 As Integer = 10
    Dim alienmove4 As Integer = 10
    Dim alienmove5 As Integer = 10

    Dim wave As Integer = 0

    Dim MovingLeft As Boolean
    Dim MovingRight As Boolean

    Dim Score As Integer = 0

    Dim WaveLevelComplete As Integer = 0
    Dim ticks As Integer = 0

    Dim Player As String

    Dim newString As String


    Sub Restart(ByVal sender As System.Object, ByVal e As System.EventArgs)

        REM **********************************************************************************
        REM     Empties the form, resets all variables, then loads the form again
        REM **********************************************************************************

        lblWaveComplete.Visible = False

        Array.Clear(AlienWave1, 0, AlienNum)
        ReDim AlienWave1((AlienNum - 1))
        Array.Clear(AlienWave2, 0, AlienNum)
        ReDim AlienWave2((AlienNum - 1))
        Array.Clear(AlienWave3, 0, AlienNum)
        ReDim AlienWave3((AlienNum - 1))
        Array.Clear(AlienWave4, 0, AlienNum)
        ReDim AlienWave4((AlienNum - 1))
        Array.Clear(AlienWave5, 0, AlienNum)

        ReDim AlienWave5((AlienNum - 1))
        alienmove = 10
        alienmove2 = 10
        alienmove3 = 10
        alienmove4 = 10

        alienmove5 = 10
        this = 1
        that = 100
        wave = 0



        REM for the pause label
        lblPause.Left = CenterLeft(Me, lblPause)
        lblPause.Top = CenterTop(Me, lblPause)

        REM for the game over label
        lblGameOver.Left = CenterLeft(Me, lblGameOver)
        lblGameOver.Top = CenterTop(Me, lblGameOver)

        REM for the wave complete label
        lblWaveComplete.Left = CenterLeft(Me, lblWaveComplete)
        lblWaveComplete.Top = CenterTop(Me, lblWaveComplete)

        If Lives = 3 Then

            Life1.Visible = True
            Life2.Visible = True
            Life3.Visible = True

        ElseIf Lives = 2 Then

            Life1.Visible = True
            Life2.Visible = True
            Life3.Visible = False

        ElseIf Lives = 1 Then

            Life1.Visible = True
            Life2.Visible = False
            Life3.Visible = False

        End If
        Me.Controls.Clear()
        InitializeComponent()
        Form2_Load(sender, e)
        ticks = 0
        WaveLevelComplete = 0

    End Sub

    Function CenterTop(ByVal theForm As Form, ByVal theObject As Object) As Integer

        REM *************************************************************************************************
        REM Centers the top of the object with the top of the form
        REM *************************************************************************************************

        CenterTop = (theForm.ClientRectangle.Height / 2) - (theObject.Height / 2)

    End Function

    Function CenterLeft(ByVal theForm As Form, ByVal theObject As Object) As Integer

        REM *************************************************************************************************
        REM     Centers the left of the object with the left of the form
        REM *************************************************************************************************

        CenterLeft = (theForm.ClientRectangle.Width / 2) - (theObject.width / 2)

    End Function

    Sub MoveAlien(ByVal theAlien() As PictureBox, ByRef theVar As Integer, ByVal theForm As Form)

        REM *************************************************************************************************
        REM     Moves the aliens across the form, and increases the wave
        REM *************************************************************************************************

        For i = 0 To UBound(theAlien)

            theAlien(i).Left += theVar

        Next


        If theAlien(UBound(theAlien)).Left + theAlien(UBound(theAlien)).Width >= theForm.Width Then

            theVar *= -1

            For i = 0 To UBound(theAlien)

                theAlien(i).Top += 80

            Next

            wave += 1

        End If

        If theAlien(LBound(theAlien)).Left < 0 Then

            theVar *= -1

            For i = 0 To UBound(theAlien)

                theAlien(i).Top += 80

            Next

            wave += 1

        End If


    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        REM *************************************************************************************************
        REM    Pauses the game
        REM *************************************************************************************************

        If e.KeyCode = Keys.P And Paused = False Then

            Paused = True
            tmrAliens.Enabled = False
            tmrCollisionDetect.Enabled = False
            tmrBullet.Enabled = False
            tmrCannonMovement.Enabled = False
            tmrScore.Enabled = False
            lblPause.Visible = True

        ElseIf e.KeyCode = Keys.P And Paused = True Then

            Paused = False
            tmrAliens.Enabled = True
            tmrCollisionDetect.Enabled = True
            tmrBullet.Enabled = True
            tmrCannonMovement.Enabled = True
            tmrScore.Enabled = True
            lblPause.Visible = False

        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------'

        REM ****************************************************************************************************************
        REM   Moves the Cannon to the left or the right depending on the keypressed, and if Inverted is true or false
        REM ****************************************************************************************************************

        If Inverted = False Then

            If e.KeyCode = Keys.A And Paused = False Then

                MovingLeft = True

            End If

            If e.KeyCode = Keys.D And Paused = False Then

                MovingRight = True

            End If

        Else

            If e.KeyCode = Keys.A And Paused = False Then

                MovingRight = True

            End If

            If e.KeyCode = Keys.D And Paused = False Then

                MovingLeft = True

            End If

        End If

    End Sub

    Private Sub Form2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        REM *************************************************************************************************
        REM    Shoots after the SPACE key is raised, and stops moving the cannon
        REM *************************************************************************************************

        If e.KeyCode = Keys.Space And Paused = False Then

            ReDim Preserve Shots(Bullets)
            Dim newbullet As New Bullet
            Me.Controls.Add(newbullet)
            Shots(Bullets) = newbullet
            Bullets += 1
            tmrBullet.Enabled = True

        End If

        If Inverted = False Then

            If e.KeyCode = Keys.A And Paused = False Then

                MovingLeft = False

            End If

            If e.KeyCode = Keys.D And Paused = False Then

                MovingRight = False

            End If

        Else

            If e.KeyCode = Keys.A And Paused = False Then

                MovingRight = False

            End If

            If e.KeyCode = Keys.D And Paused = False Then

                MovingLeft = False

            End If

        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        REM *******************************************************************************************************
        REM     Draws the form, and adds necessary controls to it.
        REM *******************************************************************************************************

        REM State of Form
        Me.WindowState = FormWindowState.Maximized

        If Optimal = True Then

            Me.BackgroundImage = My.Resources.Image7

        ElseIf MinView = True Then

            Me.BackgroundImage = Nothing

            Me.BackColor = Color.WhiteSmoke


        End If

        REM Timers
        tmrAliens.Enabled = True
        tmrCollisionDetect.Enabled = True
        tmrBullet.Enabled = False
        tmrCannonMovement.Enabled = True
        tmrScore.Enabled = True

        REM Cannon placement
        picCannon.Left = CenterLeft(Me, picCannon)
        picCannon.Top = 900
        theCannon = picCannon

        REM for the pause label
        lblPause.Left = CenterLeft(Me, lblPause)
        lblPause.Top = CenterTop(Me, lblPause)

        REM for the game over label
        lblGameOver.Left = CenterLeft(Me, lblGameOver)
        lblGameOver.Top = CenterTop(Me, lblGameOver)

        REM for the wave complete label
        lblWaveComplete.Left = CenterLeft(Me, lblWaveComplete)
        lblWaveComplete.Top = CenterTop(Me, lblWaveComplete)


        REM *******************************************************************************************************
        REM     Sets the Aliens' speed depending on the difficulty
        REM *******************************************************************************************************

        If Baby = True Then

            alienmove = 5
            alienmove2 = 5
            alienmove3 = 5
            alienmove4 = 5
            alienmove5 = 5

        ElseIf Easy = True Then

            alienmove = 10
            alienmove2 = 10
            alienmove3 = 10
            alienmove4 = 10
            alienmove5 = 10

        ElseIf Medium = True Then

            alienmove = 15
            alienmove2 = 15
            alienmove3 = 15
            alienmove4 = 15
            alienmove5 = 15

        ElseIf Hard = True Then

            alienmove = 20
            alienmove2 = 20
            alienmove3 = 20
            alienmove4 = 20
            alienmove5 = 20

        ElseIf Insane = True Then

            alienmove = 40
            alienmove2 = 40
            alienmove3 = 40
            alienmove4 = 40
            alienmove5 = 40

        End If



        If Lives = 3 Then

            Life1.Visible = True
            Life2.Visible = True
            Life3.Visible = True

        ElseIf Lives = 2 Then

            Life1.Visible = True
            Life2.Visible = True
            Life3.Visible = False

        ElseIf Lives = 1 Then

            Life1.Visible = True
            Life2.Visible = False
            Life3.Visible = False

        End If


        '-----------------------------------------------------------'

        For i = 0 To (AlienNum - 1)

            AlienWave1(i) = New PictureBox

            AlienWave2(i) = New PictureBox

            AlienWave3(i) = New PictureBox

            AlienWave4(i) = New PictureBox

            AlienWave5(i) = New PictureBox

        Next

        '-----------------------------------------------------------'

        For i = 0 To (AlienNum - 1)

            Me.Controls.Add(AlienWave1(i))

            Me.Controls.Add(AlienWave2(i))

            Me.Controls.Add(AlienWave3(i))

            Me.Controls.Add(AlienWave4(i))

            Me.Controls.Add(AlienWave5(i))

        Next


        '-----------------------------------------------------------'


        REM *******************************************************************************************************
        REM     Creates the first wave of aliens
        REM *******************************************************************************************************

        For i = 0 To UBound(AlienWave1)

            With Me.AlienWave1(i)

                .SizeMode = PictureBoxSizeMode.StretchImage
                .Size() = New Size(80, 80)
                .Location = New Point(this, that)
                .Visible = True
                .Image = My.Resources.Image2

                this += 100

            End With

        Next




    End Sub

    Private Sub tmrBullet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBullet.Tick

        REM *******************************************************************************************************
        REM     Checks if the game is paused, and will stop everything if it is.
        REM *******************************************************************************************************

        If Paused = True Then

            tmrBullet.Enabled = False

        Else

            tmrBullet.Enabled = True

        End If

        '----------------------------------------------------------------------------------------------------------------'

        REM *******************************************************************************************************
        REM     Shoots the bullets when they're not off screen
        REM *******************************************************************************************************

        If Bullets > 0 Then

            For i = 0 To Shots.Length - 1

                If Shots(i).Top >= 8000 Then

                    GoTo there

                Else

                    Shots(i).Shoot()

                End If
there:

            Next

        End If

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        REM *******************************************************************************************************
        REM     Gives the user the option of quitting when closing the form during the game
        REM *******************************************************************************************************

        If lblGameOver.Visible = False Then

            Paused = True

            Select Case MsgBox("Are you sure you want to quit?", MsgBoxStyle.OkCancel)

                Case MsgBoxResult.Ok

                    frmMainMenu.Show()

                Case MsgBoxResult.Cancel

                    Paused = False

                    tmrAliens.Enabled = True

                    tmrBullet.Enabled = True

                    tmrCannonMovement.Enabled = True

                    tmrCollisionDetect.Enabled = True

                    tmrScore.Enabled = True

                    e.Cancel = True

            End Select

        End If

    End Sub

    Private Sub tmrAliens_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAliens.Tick

        On Error GoTo Here


        If Paused = True Then

            tmrAliens.Enabled = False

        Else

            tmrAliens.Enabled = True

        End If
        '--------------------------------------------------------------------------------------------'

        If WaveLevelComplete = (AlienNum * 5) Then

            tmrWaveComplete.Enabled = True

            If ticks = 10 Then

                Restart(sender, e)

            End If

        Else


            MoveAlien(AlienWave1, alienmove, Me)

            '---------------------------------------------------------------------------------------------------------------'
            If wave = 1 Then

                this = 1

                For i = 0 To UBound(AlienWave2)

                    With Me.AlienWave2(i)

                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Size() = New Size(80, 80)
                        .Location = New Point(this, that)
                        .Visible = True
                        .Image = My.Resources.Image2
                        this += 100

                    End With

                Next

                wave += 1

            End If

            If wave > 1 Then

                MoveAlien(AlienWave2, alienmove2, Me)

            End If

            '----------------------------------------------------------------------------------------------------------------'

            If wave = 3 Then

                this = 1

                For i = 0 To UBound(AlienWave3)

                    With Me.AlienWave3(i)

                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Size() = New Size(80, 80)
                        .Location = New Point(this, that)
                        .Visible = True
                        .Image = My.Resources.Image3
                        this += 100

                    End With

                Next

                wave += 1

            End If

            If wave > 3 Then

                MoveAlien(AlienWave3, alienmove3, Me)

            End If

            '----------------------------------------------------------------------------------------------------------------'

            If wave = 6 Then

                this = 1

                For i = 0 To UBound(AlienWave4)

                    With Me.AlienWave4(i)

                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Size() = New Size(80, 80)
                        .Location = New Point(this, that)
                        .Visible = True
                        .Image = My.Resources.Image3
                        this += 100

                    End With

                Next

                wave += 1

            End If


            If wave > 6 Then

                MoveAlien(AlienWave4, alienmove4, Me)

            End If

            '----------------------------------------------------------------------------------------------------------------'

            If wave = 10 Then

                this = 1

                For i = 0 To UBound(AlienWave5)

                    With Me.AlienWave5(i)

                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Size() = New Size(80, 80)
                        .Location = New Point(this, that)
                        .Visible = True
                        .Image = My.Resources.Image4
                        this += 100

                    End With

                Next

                wave += 1

            End If

            If wave > 10 Then

                MoveAlien(AlienWave5, alienmove5, Me)

            End If


        End If

        Exit Sub

Here:   MsgBox("Error #" & Err.Number & " : " & Err.Description)

    End Sub

    Private Sub tmrCannonMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCannonMovement.Tick

        If Paused = True Then

            tmrCannonMovement.Enabled = False

        Else

            tmrCannonMovement.Enabled = True

        End If

        If MovingLeft = True Then

            picCannon.Left -= CanSens

        End If


        If MovingRight = True Then

            picCannon.Left += CanSens

        End If

    End Sub

    Private Sub tmrCollisionDetect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCollisionDetect.Tick

        On Error GoTo Here

        REM *******************************************************************************************************
        REM     Stops the ship from leaving the form
        REM *******************************************************************************************************

        If picCannon.Left <= Me.Left Then

            picCannon.Left = 0.5

        End If

        If picCannon.Right >= Me.Right Then

            picCannon.Left = picCannon.Left - 10

        End If

        REM *******************************************************************************************************
        REM     Makes bullets invisible when they exit the form
        REM *******************************************************************************************************

        For i = 0 To Shots.Length - 1

            If Bullets > 0 Then

                If Shots(i).Top <= 0 Then

                    Shots(i).Visible = False

                End If

            End If

        Next

        '---------------------------------------------------------------------------------------------------------------'

        REM *******************************************************************************************************
        REM     When aliens come into contact with a bullet
        REM *******************************************************************************************************

        REM Bullet Collision for Alien Wave 1

        For j = 0 To UBound(AlienWave1)

            If tmrBullet.Enabled = True Then

                If Bullets > 0 Then

                    For i = 0 To Shots.Length - 1

                        If Me.Shots(i).Bounds.IntersectsWith(AlienWave1(j).Bounds) And Shots(i).Visible = True Then

                            WaveLevelComplete += 1
                            Score += 10
                            Shots(i).Visible = False
                            AlienWave1(j).Top -= 10000
                            AlienWave1(j).Visible = False

                        End If

                    Next

                End If

            End If

        Next


        REM Bullet Collision for Alien Wave 2

        For j = 0 To UBound(AlienWave2)

            If tmrBullet.Enabled = True Then

                If Bullets > 0 Then

                    For i = 0 To Shots.Length - 1

                        If Me.Shots(i).Bounds.IntersectsWith(AlienWave2(j).Bounds) And Shots(i).Visible = True Then

                            WaveLevelComplete += 1
                            Score += 10
                            Shots(i).Visible = False
                            AlienWave2(j).Top -= 10000
                            AlienWave2(j).Visible = False

                        End If

                    Next

                End If

            End If

        Next


        REM Bullet Collision for Alien Wave 3

        For j = 0 To UBound(AlienWave3)

            If tmrBullet.Enabled = True Then

                If Bullets > 0 Then

                    For i = 0 To Shots.Length - 1

                        If Me.Shots(i).Bounds.IntersectsWith(AlienWave3(j).Bounds) And Shots(i).Visible = True Then

                            WaveLevelComplete += 1
                            Score += 20
                            Shots(i).Visible = False
                            AlienWave3(j).Top -= 10000
                            AlienWave3(j).Visible = False

                        End If

                    Next

                End If

            End If

        Next


        REM Bullet Collision for Alien Wave 4

        For j = 0 To UBound(AlienWave4)

            If tmrBullet.Enabled = True Then

                If Bullets > 0 Then

                    For i = 0 To Shots.Length - 1

                        If Me.Shots(i).Bounds.IntersectsWith(AlienWave4(j).Bounds) And Shots(i).Visible = True Then

                            WaveLevelComplete += 1
                            Score += 20
                            Shots(i).Visible = False
                            AlienWave4(j).Top -= 10000
                            AlienWave4(j).Visible = False

                        End If

                    Next

                End If

            End If

        Next


        REM Bullet Collision for Alien Wave 5

        For j = 0 To UBound(AlienWave5)

            If tmrBullet.Enabled = True Then

                If Bullets > 0 Then

                    For i = 0 To Shots.Length - 1

                        If Me.Shots(i).Bounds.IntersectsWith(AlienWave5(j).Bounds) And Shots(i).Visible = True Then

                            WaveLevelComplete += 1
                            Score += 30
                            Shots(i).Visible = False
                            AlienWave5(j).Top -= 10000
                            AlienWave5(j).Visible = False

                        End If

                    Next

                End If

            End If

        Next

        '----------------------------------------------------------------------------------------------------------------------------------'



        REM *******************************************************************************************************
        REM     When aliens come in contact with the cannon
        REM *******************************************************************************************************

        For i = 0 To (AlienNum - 1)

            REM wave 1

            If AlienWave1(i).Bounds.IntersectsWith(picCannon.Bounds) Or AlienWave1(i).Top >= picCannon.Top + picCannon.Height Then

                If Life1.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave1(i).Visible = False
                    AlienWave1(i).Top -= 10000
                    Life1.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave1(i).Visible = False
                    AlienWave1(i).Top -= 10000
                    Life2.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave1(i).Visible = False
                    AlienWave1(i).Top -= 10000
                    Life3.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = False And Lives = 0 Then

                    lblGameOver.Visible = True
                    Paused = True

                End If

            End If


            REM wave 2

            If AlienWave2(i).Bounds.IntersectsWith(picCannon.Bounds) Or AlienWave2(i).Top >= picCannon.Top + picCannon.Height Then

                If Life1.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave2(i).Visible = False
                    AlienWave2(i).Top -= 10000
                    Life1.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave2(i).Visible = False
                    AlienWave2(i).Top -= 10000
                    Life2.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave2(i).Visible = False
                    AlienWave2(i).Top -= 10000
                    Life3.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = False And Lives = 0 Then

                    lblGameOver.Visible = True
                    Paused = True

                End If

            End If



            REM wave 3

            If AlienWave3(i).Bounds.IntersectsWith(picCannon.Bounds) Or AlienWave3(i).Top >= picCannon.Top + picCannon.Height Then

                If Life1.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave3(i).Visible = False
                    AlienWave3(i).Top -= 10000
                    WaveLevelComplete += 1
                    Life1.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave3(i).Visible = False
                    AlienWave3(i).Top -= 10000
                    Life2.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave3(i).Visible = False
                    AlienWave3(i).Top -= 10000
                    Life3.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = False And Lives = 0 Then

                    lblGameOver.Visible = True
                    Paused = True

                End If

            End If


            REM wave 4

            If AlienWave4(i).Bounds.IntersectsWith(picCannon.Bounds) Or AlienWave4(i).Top >= picCannon.Top + picCannon.Height Then

                If Life1.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave4(i).Visible = False
                    AlienWave4(i).Top -= 10000
                    Life1.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave4(i).Visible = False
                    AlienWave4(i).Top -= 10000
                    Life2.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave4(i).Visible = False
                    AlienWave4(i).Top -= 10000
                    Life3.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = False And Lives = 0 Then

                    lblGameOver.Visible = True
                    Paused = True

                End If

            End If


            REM wave 5

            If AlienWave5(i).Bounds.IntersectsWith(picCannon.Bounds) Or AlienWave5(i).Top >= picCannon.Top + picCannon.Height Then

                If Life1.Visible = True Then
                    WaveLevelComplete += 1
                    AlienWave5(i).Visible = False
                    AlienWave5(i).Top -= 10000
                    Life1.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave5(i).Visible = False
                    AlienWave5(i).Top -= 10000
                    Life2.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = True Then

                    WaveLevelComplete += 1
                    AlienWave5(i).Visible = False
                    AlienWave5(i).Top -= 10000
                    Life3.Visible = False
                    Lives -= 1

                ElseIf Life1.Visible = False And Life2.Visible = False And Life3.Visible = False And Lives = 0 Then

                    lblGameOver.Visible = True
                    Paused = True

                End If

            End If

        Next

        If Lives <= 0 Then

            lblGameOver.Visible = True
            Paused = True

        End If

        REM *******************************************************************************************************
        REM     Outputs the score, and prompts the user to play again or retunr to main menu.
        REM *******************************************************************************************************

        If lblGameOver.Visible = True Then

            Paused = True

            tmrCollisionDetect.Enabled = False



            REM ********************************************************************************************************
            REM     Saving the score to a file after prompting the player to input their names
            REM ********************************************************************************************************


            Player = InputBox("Enter your name :", "GAME OVER", "Name")

            Do Until Player.Count() > 0 And Player.Count() < 10

                MsgBox("Your name must be between 1 and 9 characters", MsgBoxStyle.Critical, "Name Error")

                Player = InputBox("Enter your name :", "GAME OVER", "Name")

            Loop

            FileOpen(1, Path, OpenMode.Append)

            PrintLine(1, Player)

            PrintLine(1, Score)

            Select Case MsgBox("Would you like to play again?", MsgBoxStyle.YesNo, "Game Over")

                Case vbYes

                    Dim frm As New frmHorizontal
                    Me.Close()
                    frm.Show()

                Case vbNo

                    Me.Close()
                    frmMainMenu.Show()

            End Select

        End If

        FileClose(1)

        Exit Sub

Here:   MsgBox("Error #" & Err.Number & " : " & Err.Description)

    End Sub

    Private Sub tmrScore_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScore.Tick

        lblScore.Text = Score

    End Sub

    Private Sub tmrWaveComplete_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWaveComplete.Tick

        REM *******************************************************************************************************
        REM     Keeps the wave complete sign on for about a second
        REM *******************************************************************************************************

        lblWaveComplete.Visible = True

        ticks += 1

        If ticks = 10 Then

            tmrWaveComplete.Enabled = False

        End If

    End Sub

    Private Sub frmHorizontal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

        REM *******************************************************************************************************
        REM     Pauses the game when the form is not in focus
        REM *******************************************************************************************************

        Paused = True

        lblPause.Visible = True


    End Sub

End Class