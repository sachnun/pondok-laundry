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
        Koneksi.ShowDialog()
    End Sub
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Try
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
                vPetugas = RdData("nama")
                vIdUser = RdData("id")

                Utama.lbUtamaWelcome.Text = "Hi, " & vPetugas & "."
                Utama.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class