Imports System.Data.OleDb
Public Class ReservationForm

    Dim TourPrice, Pax, Total As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim minDate As DateTime = DateTime.Today.AddDays(3)
        DTDate.MinDate = minDate

        Dim DateSelected As DateTime = DTDate.Value

        If CusUser.Text = "" Or CusAddress.Text = "" Or PhoneNum.Text = "" Or PaxNum.Text = "" Or DateSelected < minDate Or CBMod.SelectedIndex = -1 Then
            MessageBox.Show("Please fill Integer the necessary information needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SummaryForm.lblname.Text = CusUser.Text
            SummaryForm.lbladd.Text = CusAddress.Text
            SummaryForm.lblPhone.Text = PhoneNum.Text
            SummaryForm.lblPax.Text = PaxNum.Text
            SummaryForm.lblPay.Text = CBMod.SelectedItem.ToString
            SummaryForm.SumDate.Value = DTDate.Value
            SummaryForm.lblCost.Text = lblTotal.Text

            Me.Hide()
            SummaryForm.Show()
        End If
    End Sub

    Private Sub DTDate_ValueChanged(sender As Object, e As EventArgs) Handles DTDate.ValueChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbTour.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedTour As String = LbTour.SelectedItem.ToString()
        Dim atLeastOneRadioButtonChecked As Boolean = False


        If RBSeven.Checked Then
            atLeastOneRadioButtonChecked = True
            Select Case selectedTour
                Case "Caribbean"
                    TourPrice = 3500
                Case "Mediterranean"
                    TourPrice = 4250
                Case "Alaska"
                    TourPrice = 3300
                Case "Europe"
                    TourPrice = 5000
            End Select
        ElseIf RBFour.Checked Then
            atLeastOneRadioButtonChecked = True
            Select Case selectedTour
                Case "Caribbean"
                    TourPrice = 6000
                Case "Mediterranean"
                    TourPrice = 7999
                Case "Alaska"
                    TourPrice = 7200
                Case "Europe"
                    TourPrice = 9000
            End Select
        End If

        Double.TryParse(PaxNum.Text, Pax)

        Total = Pax * TourPrice

        lblPax.Text = TourPrice
        lblTotal.Text = Total
        lblPax.Show()
        lblTotal.Show()
        Button2.Show()

    End Sub
End Class