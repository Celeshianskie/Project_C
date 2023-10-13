Imports System.Data.OleDb

Public Class RegisterForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Downloads\ProjectC.mdb;"

        Dim username As String = CusUser.Text
        Dim password As String = CusPass.Text
        Dim completeName As String = ComName.Text

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO CustomerAccount (Username, [Password], ComName) VALUES (?, ?, ?)"
                Using command As New OleDbCommand(query, connection)

                    ' Use parameters to avoid SQL injection and improve security
                    command.Parameters.AddWithValue("Username", username)
                    command.Parameters.AddWithValue("Password", password)
                    command.Parameters.AddWithValue("CompleteName", completeName)

                    ' Execute the SQL command
                    command.ExecuteNonQuery()

                    MessageBox.Show("Data inserted successfully.")
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        CustomerMenuForm.Show()

    End Sub
End Class