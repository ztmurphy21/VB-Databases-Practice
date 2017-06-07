' Name:         Adalene Project
' Purpose:      Displays the records stored in a dataset
'               Displays the total sales for all stores,
'               company-owned stores, and franchisees
' Programmer:   Zach Murphy on 6-6-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub TblStoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblStoresBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TblStoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StoresDataSet)
            MessageBox.Show("Changes saved", "Adalene Fashions",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Adalene Fashions",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoresDataSet.tblStores' table. You can move, or remove it, as needed.
        Me.TblStoresTableAdapter.Fill(Me.StoresDataSet.tblStores)

    End Sub

    Private Sub mnuAll_Click(sender As Object, e As EventArgs) Handles mnuAll.Click
        'display the total sales for all stores
        Dim intTotal As Integer =
            Aggregate store In StoresDataSet.tblStores
        Select store.Sales Into Sum

        MessageBox.Show("Total sales for all stores: " &
                        intTotal.ToString("C0"),
                        "Adalene Fashions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub mnuCompany_Click(sender As Object, e As EventArgs) Handles mnuCompany.Click
        'displays the total sales for company-owned stores
        Dim intTotal As Integer =
            Aggregate store In StoresDataSet.tblStores
            Where store.Ownership.ToUpper = "C"
            Select store.Sales Into Sum

        MessageBox.Show("Total sales for comapny-woned stores: " &
                        intTotal.ToString("C0"),
                        "Adalene Fashions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub mnuFranchisee_Click(sender As Object, e As EventArgs) Handles mnuFranchisee.Click
        'displays total sales for franchisees
        Dim intTotal As Integer =
            Aggregate store In StoresDataSet.tblStores
                Where store.Ownership.ToUpper = "F"
                    Select store.Sales Into Sum
        MessageBox.Show("Total sales for franchisees:" &
                        intTotal.ToString("C0"),
                        "Adalene Fashions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
