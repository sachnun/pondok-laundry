Imports MySql.Data.MySqlClient
Public Class Akun
    Private Sub Akun_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        clearInput()
        tampilData()
    End Sub

    Private Sub bntUpdateProfile_Click(sender As System.Object, e As System.EventArgs) Handles bntUpdateProfile.Click
        ' check txtPassword empty
        If txtPassword.Text = "" Then
            changeUsername()
        Else
            changePassword()
        End If

    End Sub

    ' tampil data
    Private Sub tampilData()
        StrCN = "Database='" & vDatabase & "'; " & _
                "Data Source='" & vServer & "'; " & _
                "User id='" & vUser & "'; " & _
                "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        StrSQL = "SELECT * FROM user WHERE id = '" & vIdUser & "'"
        Dim MyCommand As New MySqlCommand(StrSQL, CN)
        RdData = MyCommand.ExecuteReader

        If RdData.Read Then
            txtUsername.Text = RdData("username")
            txtNama.Text = RdData("nama")
        End If
    End Sub

    ' clear input
    Private Sub clearInput()
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
    End Sub

    ' change password
    Private Sub changePassword()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' check txtPassword and txtConfirmPassword
        If txtPassword.Text = txtConfirmPassword.Text Then
            ' update data
            StrSQL = "UPDATE user SET password = '" & txtPassword.Text & "' WHERE id = '" & vIdUser & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Password dan Data Lain berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            vPetugas = txtUsername.Text
            Utama.lbUtamaWelcome.Text = "Hi, " & vPetugas & "."
            Me.Close()
        Else
            MessageBox.Show("Password tidak sama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearInput()
        End If
    End Sub

    ' change username and nama
    Private Sub changeUsername()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' update data
        StrSQL = "UPDATE user SET username = '" & txtUsername.Text & "', nama = '" & txtNama.Text & "' WHERE id = '" & vIdUser & "'"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Username dan Nama berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        vPetugas = txtNama.Text
        Utama.lbUtamaWelcome.Text = "Hi, " & vPetugas & "."
        Me.Close()
    End Sub
End Class