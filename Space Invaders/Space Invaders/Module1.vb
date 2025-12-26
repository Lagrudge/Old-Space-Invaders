Module Module1

    REM **********************************************************************************************************************
    REM     theCannon (PictureBox) = A universal position for the cannon on each form
    REM     Baby (Boolean) Game difficulty determining the aliens' speed. The easiest gamemode.
    REM     Easy (Boolean) Game difficulty determining the aliens' speed. Slightly harder than the previous gamemode.
    REM     Medium (Boolean) Game difficulty determining the aliens' speed. Standard difficulty.
    REM     Hard (Boolean) Game difficulty determining the aliens' speed. Harder than the previous gamemode.
    REM     Insane (Boolean) Game difficulty determining the aliens' speed. Legends only.
    REM     Inverted (Boolean) = Flips the controls (True)
    REM     CanSens (Integer) = The cannon's speed.
    REM     AlienNum (Integer) = Number of aliens per wave.
    REM     Lives (integer) = Number of lives per wave.
    REM     Optimal (Boolean) = A way to view the game better
    REM     MinView (Boolean) = A minimalistic view of the game, simplified for performance
    REM     Path (String) = Path for the scoreboard
    REM **********************************************************************************************************************

    Public theCannon As PictureBox

    Public Baby As Boolean = False
    Public Easy As Boolean = False
    Public Medium As Boolean = True
    Public Hard As Boolean = False
    Public Insane As Boolean = False

    Public Inverted As Boolean = False

    Public CanSens As Integer = 10
    Public AlienNum As Integer = 15
    Public Lives As Integer = 3

    Public Optimal As Boolean
    Public MinView As Boolean

    Public Path As String = "M:\Space Invaders\Score.txt"

End Module
