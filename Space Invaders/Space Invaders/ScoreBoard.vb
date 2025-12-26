Imports System.IO

Public Class frmScoreBoard

    REM *******************************************************************************************************
    REM     Variable Dictionary :
    REM     theVar (Integer) = Number of Names and Scores
    REM     thiss (Integer) = The row value of the arrays
    REM     thatt (Integer) = The column value of the arrays
    REM     Scores (Array of String) = An array with all the scores
    REM     Names (Array of String) = An array with all the player names
    REM     Scored (2 Dimensional Array of String) = An array containing the names and scores
    REM *******************************************************************************************************


  
    Dim theVar As Integer = 1

    Dim thiss As Integer = 9

    Dim thatt As Integer = 1

    Dim Scores(thiss) As String

    Dim Names(thiss) As String

    Dim Scored(thiss, thatt) As String

    Private Sub frmScoreBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        REM ********************************************************************************************************
        REM     Loads the form, then fills the datagridview with the names and scores of the players
        REM ********************************************************************************************************


        On Error GoTo here

        Me.WindowState = FormWindowState.Maximized

        dgvScore.RowCount = 10
        dgvScore.ColumnCount = 2

        REM Get rid of the headers
        dgvScore.RowHeadersVisible = False
        dgvScore.ColumnHeadersVisible = False

        REM Change row height and column width
        For i = 0 To 9
            dgvScore.Rows(i).Height = 90
        Next

        For i = 0 To 1

            dgvScore.Columns(i).Width = 600

        Next

        REM Setting the alignment for the whole grid
        dgvScore.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        REM Get rid of the background grey area
        dgvScore.Width = 1230
        dgvScore.Height = Me.Height - 100

        REM Centering dgv
        dgvScore.Left = (Me.Width / 2) - (dgvScore.Width / 2)
        dgvScore.Top = (Me.Height / 2) - (dgvScore.Height / 2)



        REM Set the font
        dgvScore.DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Bold)




        FileOpen(2, Path, OpenMode.Input)


        Do Until EOF(2)

            Names(theVar) = LineInput(2)

            Scores(theVar) = LineInput(2)

            theVar += 1

        Loop

        dgvScore.RowCount += theVar

        For i = 0 To theVar + 9

            dgvScore.Rows(i).Height = 90

        Next


        thiss = theVar

        For i = 0 To thiss

            dgvScore.Rows(i).Cells(0).Value = Names(i)

        Next

        For i = 0 To thiss

            dgvScore.Rows(i).Cells(1).Value = Scores(i)

        Next

        dgvScore.Rows(0).Cells(0).Value = "Name"

        dgvScore.Rows(0).Cells(1).Value = "Score"

        FileClose(2)





        Exit Sub

here:   MsgBox("Error #" & Err.Number & " : " & Err.Description)


    End Sub

End Class