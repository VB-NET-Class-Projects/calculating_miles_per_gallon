Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGallons.Text = ""
        txtMiles.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim calculatedMPG As Decimal
        Dim gallons As Decimal
        Dim miles As Decimal
        Try
            gallons = CDec(txtGallons.Text)
            miles = CDec(txtMiles.Text)

            calculatedMPG = Math.Round(CDec(miles / gallons), 2)
            lblResults.Text = CStr(calculatedMPG)
        Catch
            MessageBox.Show("Please enter numbers. Do not include any other character.")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtGallons.Clear()
        txtMiles.Clear()
        lblResults.Text = ""
    End Sub
End Class
