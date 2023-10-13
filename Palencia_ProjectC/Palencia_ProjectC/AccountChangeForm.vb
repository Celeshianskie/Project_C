Imports System.Data.OleDb

Public Class AccountChangeForm
    Private Sub CustomerAccountBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerAccountBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerAccountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectCDataSet)

    End Sub

    Private Sub AccountChangeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectCDataSet.CustomerAccount' table. You can move, or remove it, as needed.
        Me.CustomerAccountTableAdapter.Fill(Me.ProjectCDataSet.CustomerAccount)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Downloads\ProjectC.mdb;"


        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE CustomerAccount SET [Username] ='" & txtUsername.Text & "', [Password]='" & txtPassword.Text & "'"
                Using command As New OleDbCommand(query, connection)

                    ' Use parameters to avoid SQL injection and improve security
                    command.Parameters.AddWithValue("Username", txtUsername)
                    command.Parameters.AddWithValue("Password", txtPassword)
                    ' Execute the SQL command
                    command.ExecuteNonQuery()

                    MessageBox.Show("Account Updated successfully.")
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub
End Class