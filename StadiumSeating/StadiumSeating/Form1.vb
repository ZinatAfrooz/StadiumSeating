Public Class Form1

    Dim decTotalRev As Decimal
    Private Sub btnCalRev_Click(sender As Object, e As EventArgs) Handles btnCalRev.Click
        Try
            lblClassA.Text = (CDec(txtClassA.Text) * 15.0).ToString("C")
            lblClassB.Text = (CDec(txtClassB.Text) * 12.0).ToString("C")
            lblClassC.Text = (CDec(txtClassC.Text) * 9.0).ToString("C")
            decTotalRev = CDec(lblClassA.Text) + CDec(lblClassB.Text) + CDec(lblClassC.Text)
            lblTotlRevVal.Text = decTotalRev.ToString("C")
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotlRevVal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
