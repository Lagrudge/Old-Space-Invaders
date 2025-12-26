Public Class frmOptions

    Private Sub tmrCanSens_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCanSens.Tick

        REM *******************************************************************************************************
        REM     Shows the speed of the cannon
        REM *******************************************************************************************************


        lblCanSens.Text = hsbCannonSensitivity.Value

    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        REM *******************************************************************************************************
        REM     Enables the timer that shows the cannon sensitivity in the label next to the scroll bar
        REM *******************************************************************************************************

        tmrCanSens.Enabled = True

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBack.Click

        REM *******************************************************************************************************
        REM     Sets the difficulty level for when the player comes back to the menu
        REM *******************************************************************************************************

        Me.Hide()

        If Baby = True Then

            TrackBar1.Value = 0

        ElseIf Easy = True Then

            TrackBar1.Value = 1

        ElseIf Medium = True Then

            TrackBar1.Value = 2

        ElseIf Hard = True Then

            TrackBar1.Value = 3

        ElseIf Insane = True Then

            TrackBar1.Value = 4

        End If

        hsbCannonSensitivity.Value = CanSens

    End Sub

    Private Sub hsbCannonSensitivity_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbCannonSensitivity.Scroll

        REM *******************************************************************************************************
        REM     Sets the speed of the cannon
        REM *******************************************************************************************************

        CanSens = hsbCannonSensitivity.Value

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        REM *******************************************************************************************************
        REM     Sets the Difficulty.
        REM *******************************************************************************************************

        If TrackBar1.Value = 0 Then

            Baby = True
            Easy = False
            Medium = False
            Hard = False
            Insane = False

        ElseIf TrackBar1.Value = 1 Then

            Baby = False
            Easy = True
            Medium = False
            Hard = False
            Insane = False

        ElseIf TrackBar1.Value = 2 Then

            Baby = False
            Easy = False
            Medium = True
            Hard = False
            Insane = False

        ElseIf TrackBar1.Value = 3 Then

            Baby = False
            Easy = False
            Medium = False
            Hard = True
            Insane = False

        ElseIf TrackBar1.Value = 4 Then

            Baby = False
            Easy = False
            Medium = False
            Hard = False
            Insane = True

        End If

    End Sub



    Private Sub nudLives_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudLives.ValueChanged

        Lives = nudLives.Value

        nudLives.Value = Lives

    End Sub

    Private Sub nudWave_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudWave.ValueChanged

        REM *******************************************************************************************************
        REM     Changes the amount of aliens per wave
        REM *******************************************************************************************************

        AlienNum = nudWave.Value
        nudWave.Value = AlienNum


    End Sub

    Private Sub chkInvert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInvert.CheckedChanged

        REM *******************************************************************************************************
        REM     Inverts (reverses) controls
        REM *******************************************************************************************************

        If chkInvert.Checked Then

            Inverted = True

        Else

            Inverted = False

        End If

    End Sub


    Private Sub butTextColour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butTextColour.Click

        REM *******************************************************************************************************
        REM     Changes the colour of all text
        REM *******************************************************************************************************

        cdgAll.ShowDialog()

        frmMainMenu.mnuFile.ForeColor = cdgAll.Color

        frmMainMenu.mnuGameMode.ForeColor = cdgAll.Color

        frmMainMenu.butStart.ForeColor = cdgAll.Color

        frmMainMenu.butOptions.ForeColor = cdgAll.Color

        frmMainMenu.mnuGameMode.ForeColor = cdgAll.Color

        frmMainMenu.butScore.ForeColor = cdgAll.Color

        lblBack.ForeColor = cdgAll.Color

        Options.ForeColor = cdgAll.Color

        TabPage1.ForeColor = cdgAll.Color

        TabPage2.ForeColor = cdgAll.Color

        gpbMovement.ForeColor = cdgAll.Color

        chkInvert.ForeColor = cdgAll.Color

        lblCannonSensitivity.ForeColor = cdgAll.Color

        lblCanSens.ForeColor = cdgAll.Color

        Label1.ForeColor = cdgAll.Color

        Label2.ForeColor = cdgAll.Color

        Label3.ForeColor = cdgAll.Color

        Label4.ForeColor = cdgAll.Color

        Label5.ForeColor = cdgAll.Color

        Label6.ForeColor = cdgAll.Color

        Label7.ForeColor = cdgAll.Color

        Label8.ForeColor = cdgAll.Color

        Me.BackColor = cdgAll.Color

        frmHorizontal.lblWaveComplete.ForeColor = cdgAll.Color

        frmHorizontal.lblScore.ForeColor = cdgAll.Color

        frmHorizontal.lblPause.ForeColor = cdgAll.Color

        frmHorizontal.lblGameOver.ForeColor = cdgAll.Color

        frmHorizontal.Label1.ForeColor = cdgAll.Color

        frmHorizontal.Label2.ForeColor = cdgAll.Color

        frmMainMenu.mnuRetro.ForeColor = cdgAll.Color

        frmMainMenu.mnuHorizontal.ForeColor = cdgAll.Color

        frmMainMenu.mnuInputScoreBoard.ForeColor = cdgAll.Color

        rtbInstructions.ForeColor = cdgAll.Color

        radMinView.ForeColor = cdgAll.Color

        radOptimal.ForeColor = cdgAll.Color

    End Sub

    Private Sub butFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFont.Click

        REM *******************************************************************************************************
        REM     Changes the font of all text
        REM *******************************************************************************************************

        fdgAll.ShowDialog()

        frmMainMenu.mnuFile.Font = fdgAll.Font

        frmMainMenu.mnuGameMode.Font = fdgAll.Font

        frmMainMenu.butStart.Font = fdgAll.Font

        frmMainMenu.butOptions.Font = fdgAll.Font

        frmMainMenu.mnuGameMode.Font = fdgAll.Font

        frmMainMenu.butScore.Font = fdgAll.Font

        lblBack.Font = fdgAll.Font

        Options.Font = fdgAll.Font

        TabPage1.Font = fdgAll.Font

        TabPage2.Font = fdgAll.Font

        gpbMovement.Font = fdgAll.Font

        chkInvert.Font = fdgAll.Font

        lblCannonSensitivity.Font = fdgAll.Font

        lblCanSens.Font = fdgAll.Font

        Label1.Font = fdgAll.Font

        Label2.Font = fdgAll.Font

        Label3.Font = fdgAll.Font

        Label4.Font = fdgAll.Font

        Label5.Font = fdgAll.Font

        Label6.Font = fdgAll.Font

        Label7.Font = fdgAll.Font

        Label8.Font = fdgAll.Font

        frmHorizontal.lblWaveComplete.Font = fdgAll.Font

        frmHorizontal.lblScore.Font = fdgAll.Font

        frmHorizontal.lblPause.Font = fdgAll.Font

        frmHorizontal.lblGameOver.Font = fdgAll.Font

        frmHorizontal.Label1.Font = fdgAll.Font

        frmHorizontal.Label2.Font = fdgAll.Font

        frmMainMenu.mnuRetro.Font = fdgAll.Font

        frmMainMenu.mnuHorizontal.Font = fdgAll.Font

        frmMainMenu.mnuInputScoreBoard.Font = fdgAll.Font

        rtbInstructions.Font = fdgAll.Font

        radMinView.Font = fdgAll.Font

        radOptimal.Font = fdgAll.Font

    End Sub


    Private Sub radOptimal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOptimal.CheckedChanged

        REM *******************************************************************************************************
        REM     
        REM *******************************************************************************************************

        If radOptimal.Checked = True Then

            Optimal = True

        Else

            Optimal = False

        End If

    End Sub

    Private Sub radMinView_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMinView.CheckedChanged

        If radMinView.Checked = True Then

            MinView = True

        Else

            MinView = False

        End If

    End Sub
End Class