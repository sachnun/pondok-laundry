Public Class Koneksi

    Private Sub btnKoneksiOk_Click(sender As System.Object, e As System.EventArgs) Handles btnKoneksiOk.Click
        Me.Hide()
    End Sub

    Private Sub btnKoneksiReset_Click(sender As System.Object, e As System.EventArgs) Handles btnKoneksiReset.Click
        txtKoneksiServer.Text = "localhost"
        txtKoneksiUsername.Text = "root"
        txtKoneksiPassword.Text = ""
        txtKoneksiDatabase.Text = "pondok_laundry"
    End Sub

    Private Sub checkKoneksiPassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkKoneksiPassword.CheckedChanged
        If checkKoneksiPassword.Checked = True Then
            txtKoneksiPassword.PasswordChar = ""
        Else
            txtKoneksiPassword.PasswordChar = "*"
        End If
    End Sub
End Class