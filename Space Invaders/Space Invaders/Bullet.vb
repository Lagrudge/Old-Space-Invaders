
Public Class Bullet

    Inherits PictureBox
    REM Bullet Creation
    Public Sub New()

        REM *******************************************************************************************************
        REM     Creates a new bullet
        REM *******************************************************************************************************

        With Me

            .BackgroundImageLayout = ImageLayout.Stretch
            .Size = New Size(10, 40)
            .Location = New Point((theCannon.Left + 75), theCannon.Top)
            .Visible = True
            .BackColor = Color.Green
            .Image = My.Resources.Image1

        End With

    End Sub
    Public Sub Shoot()

        REM *******************************************************************************************************
        REM     Makes the bullet go up
        REM *******************************************************************************************************

        Me.Top -= 25

    End Sub


End Class
