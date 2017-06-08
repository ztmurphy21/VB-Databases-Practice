' Name:         Games Project
' Purpose:      Displays all records or only those
'               for a specific platform. Also displays
'               the total value of the games in the store.
' Programmer:   Zach Murphy on 6-7-2017

Option Explicit On
Option Strict On
Option Infer On  ' using LINQ

Public Class frmMain
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'display records for a specific platform
        Dim records = From game In GamesDataSet.tblGames
                      Where game.Platform.ToUpper Like
                          txtPlatform.Text.ToUpper & "*"
                      Select game
        TblGamesBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'display the total value of the games
        Dim dblTotal As Double =
                                Aggregate game In GamesDataSet.tblGames
                                    Select game.Quantity * game.Price
                                    Into Sum
        MessageBox.Show("Total Vale: " & dblTotal.ToString("C2"), "Game Galore", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GamesDataSet.tblGames' table. You can move, or remove it, as needed.
        Me.TblGamesTableAdapter.Fill(Me.GamesDataSet.tblGames)

    End Sub
End Class
