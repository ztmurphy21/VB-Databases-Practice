' Name:         Adalene Project
' Purpose:      Displays the records stored in a dataset
' Programmer:   Zach Murphy on 5-31-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub TblStoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblStoresBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TblStoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StoresDataSet)
            MessageBox.Show("Changes saved", "Adalene Fashions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Adalene Fashions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoresDataSet.tblStores' table. You can move, or remove it, as needed.
        Me.TblStoresTableAdapter.Fill(Me.StoresDataSet.tblStores)

    End Sub
End Class
