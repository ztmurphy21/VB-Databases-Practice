' Name:         Adalene Project
' Purpose:      Displays the records stored in a dataset
' Programmer:   Zach Murphy on 6-4-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'point to next data record
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TblStoresBindingSource.MoveNext()
    End Sub

    'point to previous data record
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        TblStoresBindingSource.MovePrevious()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoresDataSet.tblStores' table. You can move, or remove it, as needed.
        Me.TblStoresTableAdapter.Fill(Me.StoresDataSet.tblStores)

    End Sub
End Class
