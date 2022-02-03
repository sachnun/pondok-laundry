Imports MySql.Data.MySqlClient
Public Class Pesanan
    Dim nota As String
    Private Sub Pesanan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nota = lbNota.Text
        loadPemesananBarang()
        loadPemesanan()
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
        ' select barang.nama_barang, pemesanan_barang.jumlah, pemesanan_barang.keterangan
        StrSQL = "SELECT barang.nama_barang,  barang.harga_satuan, pemesanan_barang.jumlah, pemesanan_barang.keterangan FROM pemesanan_barang, barang WHERE pemesanan_barang.id_barang = barang.id AND pemesanan_barang.nota_pemesanan = '" & nota & "'"
        Dim da As New MySqlDataAdapter(StrSQL, CN)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        With DataGridView1
            .Columns(0).HeaderText = "Nama Barang"
            .Columns(1).HeaderText = "Harga Satuan"
            .Columns(2).HeaderText = "Jumlah"
            .Columns(3).HeaderText = "Keterangan"
        End With
    End Sub

    ' load pemesanan
    Private Sub loadPemesanan()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' select data to RdData
        StrSQL = "SELECT * FROM pemesanan WHERE nota = '" & nota & "'"
        Dim MyCommand As New MySqlCommand(StrSQL, CN)
        RdData = MyCommand.ExecuteReader

        ' read data
        If RdData.Read Then
            lbNama.Text = RdData("nama_pemesan")
            lbTelepon.Text = RdData("telepon")
            lbAlamat.Text = RdData("alamat")
            lbTotalHarga.Text = "Rp. " & Format(RdData("total_harga"), "###,###,###")
            lbTanggalMasuk.Text = RdData("tanggal_masuk")
            If Not IsDBNull(RdData("tanggal_selesai")) Then
                lbTanggalKeluar.Text = RdData("tanggal_selesai")
            Else
                lbTanggalKeluar.Text = "-"
            End If

            If RdData("status") = "proses" Then
                lbStatus.Text = "Proses"
                lbStatus.ForeColor = Color.Orange
                btnSelesaiPesanan.Enabled = True
            ElseIf RdData("status") = "selesai" Then
                lbStatus.Text = "Selesai"
                lbStatus.ForeColor = Color.Green
                btnSelesaiPesanan.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSelesaiPesanan_Click(sender As System.Object, e As System.EventArgs) Handles btnSelesaiPesanan.Click
        'confirm message
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menyelesaikan pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            updateStatusPesanan()
        End If
    End Sub

    ' update status pesanan
    Private Sub updateStatusPesanan()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' update status pesanan
        StrSQL = "UPDATE pemesanan SET status = 'selesai', tanggal_selesai = now() WHERE nota = '" & nota & "'"
        Dim MyCommand As New MySqlCommand(StrSQL, CN)
        MyCommand.ExecuteNonQuery()
        ' show message
        MsgBox("Pesanan telah selesai", MsgBoxStyle.Information, "Pesanan Selesai")
        loadPemesanan()
    End Sub

    Private Sub btnPrintNota_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintNota.Click
        ' message box
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin mencetak nota ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            printNota()
        End If
    End Sub

    Private Sub printNota()
        ' message box segera datang
        Dim result As DialogResult = MessageBox.Show("Fitur Nota akan segera datang", "Konfirmasi", MessageBoxButtons.OK)
    End Sub
End Class