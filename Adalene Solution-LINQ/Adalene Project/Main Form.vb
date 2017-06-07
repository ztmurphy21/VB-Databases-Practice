' Name:         Adalene Project
' Purpose:      Displays specific records from a dataset
' Programmer:   Zach Murphy on 6-6-2017

Option Explicit On
Option Strict On
Option Infer On     'using LINQ

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoresDataSet.tblStores' table. You can move, or remove it, as needed.
        Me.TblStoresTableAdapter.Fill(Me.StoresDataSet.tblStores)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ' displays records whose State field 
        ' begins with the user's entry

        Const strPROMPT As String = "First letter(s) in the " &
            "state ID (leave empty to retrieve all records):"
        Dim strState As String

        ' get letters
        strState = InputBox(strPROMPT, "Find State").ToUpper

        ' select and display records
        Dim records = From store In StoresDataSet.tblStores
                      Where store.State.ToUpper Like strState & "*"
                      Select store

        'display contents of the records variable in the data grid view
        TblStoresBindingSource.DataSource = records.AsDataView
    End Sub
End Class
