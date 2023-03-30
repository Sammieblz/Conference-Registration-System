Public Class Form1
    Public totalCost As Integer = 0

    Private Sub btnSelcetConference_Click(sender As Object, e As EventArgs) Handles btnSelectConference.Click
        Dim name, company, state, zip, email, phone, address, city As String
        name = txtName.Text
        company = txtCompany.Text
        state = txtState.Text
        zip = txtZip.Text
        email = txtEmail.Text
        phone = txtPhone.Text
        address = txtAddress.Text
        city = txtCity.Text
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblTotalPrice.Text = ""
        txtCity.Clear()
        txtCompany.Clear()
        txtEmail.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtState.Clear()
        txtZip.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class