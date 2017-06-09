' Name:         Oscars Project
' Purpose:      Displays the records stored in a dataset. Allows the user
'               to add records to and delete records from a dataset.
' Programmer:   Zach Murphy on 6-8-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OscarsDataSet.tblOscars' table. You can move, or remove it, as needed.
        Me.TblOscarsTableAdapter.Fill(Me.OscarsDataSet.tblOscars)
        TblOscarsBindingSource.Sort = "YearWon"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' add a record to the dataset
        Dim intYear As Integer
        Integer.TryParse(txtAddYear.Text, intYear)


        'try/catch is for duplicates
        Try
            OscarsDataSet.tblOscars.AddtblOscarsRow(intYear, txtActor.Text, txtActress.Text, txtPicture.Text, txtAnimated.Text)

            'try-->catch for error catching when changes to dataset are to be permanent 
            Try
                Validate()
                TblOscarsBindingSource.EndEdit()
                TblOscarsTableAdapter.Update(OscarsDataSet.tblOscars)
                MessageBox.Show("Record saved", "Oscar Winners", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Oscar Winners", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try

        Catch ex As Exception
            MessageBox.Show("Duplicate record", "Oscar Winners", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' delete a record from the dataset
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Delete record for " & lstDeleteYear.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If dlgButton = DialogResult.Yes Then
            Dim row As DataRow
            Dim intYear As Integer
            Integer.TryParse(lstDeleteYear.Text, intYear)
            row = OscarsDataSet.tblOscars.FindByYearWon(intYear)
            row.Delete()
            Try
                Validate()
                TblOscarsBindingSource.EndEdit()
                TblOscarsTableAdapter.Update(OscarsDataSet.tblOscars)
                MessageBox.Show("Record deleted", "Oscar Winners", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Oscar Winners", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtActor_Enter(sender As Object, e As EventArgs) Handles txtActor.Enter
        txtActor.SelectAll()
    End Sub

    Private Sub txtActress_Enter(sender As Object, e As EventArgs) Handles txtActress.Enter
        txtActress.SelectAll()
    End Sub

    Private Sub txtAddYear_Enter(sender As Object, e As EventArgs) Handles txtAddYear.Enter
        txtAddYear.SelectAll()
    End Sub

    Private Sub txtAnimated_Enter(sender As Object, e As EventArgs) Handles txtAnimated.Enter
        txtAnimated.SelectAll()
    End Sub

    Private Sub txtPicture_Enter(sender As Object, e As EventArgs) Handles txtPicture.Enter
        txtPicture.SelectAll()
    End Sub

    Private Sub txtAddYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddYear.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
