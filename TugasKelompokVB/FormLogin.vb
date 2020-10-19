Public Class FormLogin
    Private Sub btnmember_Click(sender As Object, e As EventArgs) Handles btnmember.Click
        Me.Hide()
        FormMember.Show()
    End Sub

    Private Sub btnguest_Click(sender As Object, e As EventArgs) Handles btnguest.Click
        Me.Hide()
        FormPesan.Show()

    End Sub
End Class