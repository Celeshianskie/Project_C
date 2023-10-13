Public Class CustomerAccountForm
    Private Sub CustomerAccountBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerAccountBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerAccountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectCDataSet)

    End Sub

    Private Sub CustomerAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectCDataSet.CustomerAccount' table. You can move, or remove it, as needed.
        Me.CustomerAccountTableAdapter.Fill(Me.ProjectCDataSet.CustomerAccount)

    End Sub

    Private Sub BackToMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMenuToolStripMenuItem.Click
        Me.Hide()
        AdminMenuForm.Show()
    End Sub
End Class