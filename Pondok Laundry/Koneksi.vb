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

    Private Sub checkDev_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkDev.CheckedChanged
        If checkDev.Checked = True Then
            txtKoneksiServer.Text = "sql6.freemysqlhosting.net"
            txtKoneksiUsername.Text = "sql6470901"
            txtKoneksiPassword.Text = "hQsHQrMR7I"
            txtKoneksiDatabase.Text = "sql6470901"
            Login.ToolStripLabel1.visible = True
        Else
            txtKoneksiServer.Text = "localhost"
            txtKoneksiUsername.Text = "root"
            txtKoneksiPassword.Text = ""
            txtKoneksiDatabase.Text = "pondok_laundry"
            Login.ToolStripLabel1.visible = False
        End If
    End Sub
End Class