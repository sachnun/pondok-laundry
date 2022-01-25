Imports MySql.Data.MySqlClient
Public Class AkunBaru

    Private Sub AkunBaru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAkunBaruSave_Click(sender As System.Object, e As System.EventArgs) Handles btnAkunBaruSave.Click
        If txtUsername.Text = "" Or txtNama.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Data tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            saveUser()
        End If
    End Sub

    ' save user
    Private Sub saveUser()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' simpan data
        StrSQL = "INSERT INTO user (username, nama, password) VALUES ('" & txtUsername.Text & "', '" & txtNama.Text & "', '" & txtPassword.Text & "')"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("User Baru berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class