Imports MySql.Data.MySqlClient
Public Class PesananBaru
    Dim nota As String
    Dim total_harga As Integer
    Private Sub btnTambahBarangPesanan_Click(sender As System.Object, e As System.EventArgs) Handles btnTambahBarangPesanan.Click
        PesananBaruBarang.ShowDialog()
    End Sub

    Private Sub PesananBaru_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        clearInput()
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
        deletePesanan()
        Me.close()
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
        ' select id, barang.nama_barang, pemesanan_barang.jumlah, pemesanan_barang.keterangan
        StrSQL = "SELECT pemesanan_barang.id, barang.nama_barang,  barang.harga_satuan, pemesanan_barang.jumlah, pemesanan_barang.keterangan FROM pemesanan_barang, barang WHERE pemesanan_barang.id_barang = barang.id AND pemesanan_barang.nota_pemesanan = '" & nota & "'"
        Dim da As New MySqlDataAdapter(StrSQL, CN)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        With DataGridView1
            .Columns(0).HeaderText = "ID"
            ' hide columns 0
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Harga Satuan"
            .Columns(3).HeaderText = "Jumlah"
            .Columns(4).HeaderText = "Keterangan"
        End With

        hitungTotalHarga()
    End Sub

    ' form on focus
    Private Sub PesananBaru_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        loadPemesananBarang()
        ' deselect datagridview
        DataGridView1.ClearSelection()
    End Sub

    ' hitung total harga satuan * jumlah dari DataGridView
    Private Sub hitungTotalHarga()
        Dim total As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            total += DataGridView1.Rows(i).Cells(2).Value * DataGridView1.Rows(i).Cells(3).Value
        Next
        total_harga = total
        ' Rp format
        If total_harga = 0 Then
            lbTotalHarga.Text = "Rp. 0"
        Else 
            lbTotalHarga.Text = "Rp. " & Format(total_harga, "###,###,###")
        End If
    End Sub

    Private Sub btnOrderPesanan_Click(sender As System.Object, e As System.EventArgs) Handles btnOrderPesanan.Click
        ' check input not empty
        If txtNama.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Or total_harga = 0 Then
            MsgBox("Data tidak boleh kosong", MsgBoxStyle.Exclamation, "Pesan")
        Else
            simpanPesanan()
            ' send to detail pesanan
            Pesanan.lbNota.Text = nota

            Me.Hide()
            Pesanan.ShowDialog()
        End If
    End Sub

    ' simpan pesanan
    Private Sub simpanPesanan()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' update data nama_pemesan, telepon, alamat, total_harga, status
        StrSQL = "UPDATE pemesanan SET nama_pemesan = '" & txtNama.Text & "', telepon = '" & txtTelepon.Text & "', alamat = '" & txtAlamat.Text & "', total_harga = '" & total_harga & "', status = 'proses', tanggal_masuk = now() WHERE nota = '" & nota & "'"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
        cmd.ExecuteNonQuery()
        ' show message
        MsgBox("Pemesanan berhasil ditambahkan", MsgBoxStyle.Information, "Pemesanan")
        Me.Close()
    End Sub

    ' clear all input
    Private Sub clearInput()
        txtNama.Text = ""
        txtTelepon.Text = ""
        txtAlamat.Text = ""
        total_harga = 0
        lbTotalHarga.Text = "Rp. " + CStr(total_harga)
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
            StrSQL = "DELETE FROM pemesanan_barang WHERE id = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
            cmd.ExecuteNonQuery()
            ' load data
            loadPemesananBarang()
        End If
    End Sub
End Class