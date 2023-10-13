Public Class CustomerDataForm
    Private Sub CustomerDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectCDataSet)

    End Sub

    Private Sub CustomerDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectCDataSet.CustomerData' table. You can move, or remove it, as needed.
        Me.CustomerDataTableAdapter.Fill(Me.ProjectCDataSet.CustomerData)

    End Sub

    Private Sub BackToMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMenuToolStripMenuItem.Click
        Me.Hide()
        AdminMenuForm.Show()
    End Sub
End Class