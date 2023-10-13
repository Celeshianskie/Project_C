Imports System.Data.OleDb
Public Class AdminLoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New OleDbConnection
        Dim connetionString As String

        connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Downloads\ProjectC.mdb;"
        con = New OleDbConnection(connetionString)

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM AdminAccount WHERE AdminUsername = '" & txtAdminUser.Text & "' AND AdminPassword = '" & txtAdminPass.Text & "' ", con)

        Dim user As String = ""

        Dim pass As String = ""


        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            user = sdr("AdminUsername")

            pass = sdr("AdminPassword")

            MessageBox.Show("Login Successfully!")

            Me.Hide()
            AdminMenuForm.Show()
        Else

            MessageBox.Show("Invalid username or password!")

        End If




        Me.Hide()
        AdminMenuForm.Show()

    End Sub
End Class