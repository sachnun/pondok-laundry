Imports MySql.Data.MySqlClient
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
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'vServer = "127.0.0.1"
        'vUser = "root"
        'vPass = ""
        'vDatabase = "pondok_laundry"

        vServer = Koneksi.txtKoneksiServer.Text
        vUser = Koneksi.txtKoneksiUsername.Text
        vPass = Koneksi.txtKoneksiPassword.Text
        vDatabase = Koneksi.txtKoneksiDatabase.Text

        StrCN = "Database='" & vDatabase & "'; " & _
                "Data Source='" & vServer & "'; " & _
                "User id='" & vUser & "'; " & _
                "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        Dim username = txtLoginUsername.Text
        Dim password = txtLoginPassword.Text

        StrSQL = "SELECT * FROM user WHERE username = '" & username & "' AND password = '" & password & "'"
        Dim MyCommand As New MySqlCommand(StrSQL, CN)
        RdData = MyCommand.ExecuteReader

        If RdData.Read = False Then
            MsgBox("Maaf, username atau password salah!", vbOKOnly, "Login")
            txtLoginPassword.Text = ""
            txtLoginPassword.Focus()
        Else
            'MsgBox("Login berhasil!", vbOKOnly, "Login")
            Utama.Show()
            Me.Close()
        End If
    End Sub
End Class