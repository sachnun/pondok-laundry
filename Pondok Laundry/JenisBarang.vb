Imports MySql.Data.MySqlClient
Public Class JenisBarang

    Private Sub JenisBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadBarang()

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DataGridView1.AllowUserToResizeRows = False
    End Sub

    ' load data barang ke DataGridView
    Private Sub loadBarang()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' load data
        StrSQL = "SELECT id, nama_barang, harga_satuan FROM barang"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
        Dim dt As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        dt.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)

        With DataGridView1
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Biaya Satuan"
        End With

    End Sub

    ' simpan data barang
    Private Sub simpanBarang()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' simpan data
        StrSQL = "INSERT INTO barang (nama_barang, harga_satuan) VALUES ('" & txtNamaBarang.Text & "', '" & txtHargaSatuan.Text & "')"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Barang berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearInput()
    End Sub

    ' clear input
    Private Sub clearInput()
        txtNamaBarang.Text = ""
        txtHargaSatuan.Text = ""
    End Sub

    Private Sub btnSimpanBarang_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpanBarang.Click
        ' check input empty
        If txtNamaBarang.Text = "" Or txtHargaSatuan.Text = "" Then
            MsgBox("Data tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            ' check txtHargaSatuan is number
            If IsNumeric(txtHargaSatuan.Text) = False Then
                MsgBox("Biaya harus berupa angka", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                simpanBarang()
                loadBarang()
            End If
        End If
    End Sub

    ' DataGridView1 double click delete data
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' confirm delete
        If MsgBox("Apakah anda yakin akan menghapus data ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            ' delete data
            StrCN = "Database='" & vDatabase & "'; " & _
                "Data Source='" & vServer & "'; " & _
                "User id='" & vUser & "'; " & _
                "Password='" & vPass & "'"

            CN = New MySqlConnection(StrCN)
            CN.Open()

            ' delete data
            StrSQL = "DELETE FROM barang WHERE id = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadBarang()
        End If
    End Sub
End Class