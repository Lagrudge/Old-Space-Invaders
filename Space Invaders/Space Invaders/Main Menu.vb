Public Class frmMainMenu

    REM *****************************************************************************************************************************************************************
    REM Title of Program : Space Invaders : Muhammad Edition
    REM Purpose : After sending out probes and discovering aliens, humanity also discovered that they are not friendly. You are sent as one of the many guardians
    REM          of the galaxies (You heard it here first, folks!) to fend agaisnt these monsters and protect the earth. The aliens are accustomed to attacking
    REM          in waves, so your goal is to survive as many as possible before being inevitably replaced!
    REM Programmer : Muhammad Al Manhsor
    REM Last Edited : 22/01/18
    REM *****************************************************************************************************************************************************************


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        REM **********************************************************************************
        REM     Maximizes the form when loaded
        REM **********************************************************************************


        Me.WindowState = FormWindowState.Maximized

        butStart.Top = (Me.Height / 2) - (butStart.Height / 2) - 100
        butStart.Left = (Me.Width / 2) - (butStart.Width / 2)

        butOptions.Top = (Me.Height / 2) - (butOptions.Height / 2) + (butStart.Height - 30) - 100
        butOptions.Left = (Me.Width / 2) - (butOptions.Width / 2)

        butScore.Top = (Me.Height / 2) - (butScore.Height / 2) + (butStart.Height - 30) + (butOptions.Height - 30) - 100
        butScore.Left = (Me.Width / 2) - (butScore.Width / 2)

    End Sub

    Private Sub butStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butStart.Click

        REM **********************************************************************************
        REM     Checks which game mode is selected and opens the apporpriate form
        REM **********************************************************************************

        If mnuRetro.Checked = True Then

            MsgBox("Coming Soon!")

        End If

        If mnuHorizontal.Checked = True Then

            frmHorizontal.Show()

            Me.Hide()

        End If

        If mnuHorizontal.Checked = False And mnuRetro.Checked = False Then

            MsgBox("Please select a gamemode.", MsgBoxStyle.OkOnly, "What're you playin'?")

        End If

    End Sub

    Private Sub mnuRetro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRetro.Click

        REM **********************************************************************************
        REM     Checks only the "Retro" option
        REM **********************************************************************************

        mnuRetro.Checked = True

        mnuHorizontal.Checked = False

    End Sub


    Private Sub mnuHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHorizontal.Click

        REM **********************************************************************************
        REM     Checks only the "Horizontal" option
        REM **********************************************************************************

        mnuRetro.Checked = False

        mnuHorizontal.Checked = True

    End Sub

    Private Sub butOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOptions.Click

        REM **********************************************************************************
        REM     Shows the options form
        REM **********************************************************************************

        frmOptions.Show()

    End Sub

    Private Sub butScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butScore.Click

        REM **********************************************************************************
        REM     Shows the scoreboard
        REM **********************************************************************************

        frmScoreBoard.Show()

    End Sub

    Private Sub mnuInputScoreBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInputScoreBoard.Click
        Dim ofdScoreBoard As OpenFileDialog = New OpenFileDialog()

        ofdScoreBoard.Title = "Open File Dialog"
        ofdScoreBoard.InitialDirectory = "E:\Space Invaders\Score.txt"
        ofdScoreBoard.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        ofdScoreBoard.FilterIndex = 2
        ofdScoreBoard.RestoreDirectory = True

        If ofdScoreBoard.ShowDialog() = DialogResult.OK Then
            Path = ofdScoreBoard.FileName
        End If
    End Sub

End Class
