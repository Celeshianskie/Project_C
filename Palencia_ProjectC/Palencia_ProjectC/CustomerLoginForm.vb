Imports System.Data.OleDb

Public Class CustomerLoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New OleDbConnection
        Dim connetionString As String

        connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Downloads\ProjectC.mdb;"
        con = New OleDbConnection(connetionString)

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM CustomerAccount WHERE Username = '" & txtCustomerUser.Text & "' AND Password = '" & txtCustomerPassword.Text & "' ", con)

        Dim user As String = ""

        Dim pass As String = ""


        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            user = sdr("Username")

            pass = sdr("Password")

            MessageBox.Show("Login Successfully!")

            Me.Hide()
            CustomerMenuForm.Show()
        Else

            MessageBox.Show("Invalid username or password!")

        End If




        Me.Hide()
        CustomerMenuForm.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        RegisterForm.Show()

    End Sub


End Class