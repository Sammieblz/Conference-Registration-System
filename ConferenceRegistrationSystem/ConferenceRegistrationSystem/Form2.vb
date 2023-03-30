Public Class Form2
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If chkRegistration.Checked = True Then
            Form1.totalCost += 895
        End If
        If chkOpeningNight.Checked = True Then
            Form1.totalCost += 30
        End If
        Dim selectedIndex As Integer
        selectedIndex = lstWorkshops.SelectedIndex
        If (selectedIndex = 1 Or selectedIndex = 0) Then
            Form1.totalCost += 295
        End If
        If (selectedIndex = 2 Or selectedIndex = 3) Then
            Form1.totalCost += 395
        End If
        Me.Hide()
        Form1.lblTotalPrice.Text = Form1.totalCost.ToString("c")
        Form1.Show()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        chkOpeningNight.Checked = False
        chkRegistration.Checked = False
        chkOpeningNight.Enabled = False
        lstWorkshops.SelectedIndex = -1
    End Sub
    Private Sub chkRegistration_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegistration.CheckedChanged
        If chkRegistration.Checked = True Then
            chkOpeningNight.Enabled = True
        End If
    End Sub
End Class