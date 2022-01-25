Imports MySql.Data.MySqlClient
Public Class PesananBaru
    Dim nota As String
    Private Sub btnTambahBarangPesanan_Click(sender As System.Object, e As System.EventArgs) Handles btnTambahBarangPesanan.Click
        PesananBaruBarang.ShowDialog()
    End Sub

    Private Sub PesananBaru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        createPesanan()
    End Sub

    ' create new pesanan
    Private Sub createPesanan()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' simpan data
        StrSQL = "INSERT INTO pemesanan (id_user) VALUES ('" & vIdUser & "')"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)

        ' get result id
        cmd.ExecuteNonQuery()
        Dim cmd2 As MySqlCommand = New MySqlCommand("SELECT LAST_INSERT_ID()", CN)
        nota = cmd2.ExecuteScalar()

        lbNota.Text = nota
    End Sub

    ' delete pesanan
    Private Sub deletePesanan()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' simpan data
        StrSQL = "DELETE FROM pemesanan WHERE nota = '" & nota & "'"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnBatalPesanan_Click(sender As System.Object, e As System.EventArgs) Handles btnBatalPesanan.Click
        Me.Close()
    End Sub

    ' on close delete pesanan
    Private Sub PesananBaru_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        deletePesanan()
    End Sub

    ' load pemesanan barang
    Private Sub loadPemesananBarang()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' load data to DataGridView
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM pemesanan_barang WHERE nota_pemesanan = '" & nota & "'", CN)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    ' form on focus
    Private Sub PesananBaru_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        loadPemesananBarang()
    End Sub
End Class