Public Class Login

    Private Sub checkLoginPassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkLoginPassword.CheckedChanged
        If checkLoginPassword.Checked = True Then
            txtLoginPassword.PasswordChar = ""
        Else
            txtLoginPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLoginDatabase_Click(sender As System.Object, e As System.EventArgs) Handles btnLoginDatabase.Click
        Koneksi.Show()
    End Sub
End Class