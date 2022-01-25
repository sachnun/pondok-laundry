Imports MySql.Data.MySqlClient
Public Class PesananBaruBarang
    Dim nota As String
    Dim id_barang As Integer
    Dim harga_satuan As Integer
    Dim harga_total As Integer
    Dim nama_barang As String

    Private Sub PesananBaruBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nota = PesananBaru.lbNota.Text
        clearInput()
        loadBarang()
    End Sub

    Private Sub btnTambahPesananBarang_Click(sender As System.Object, e As System.EventArgs) Handles btnTambahPesananBarang.Click
        pemesananBarang()
        Me.Close()
    End Sub

    ' txtJumlah onchange only number
    Private Sub txtJumlah_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    ' txtJumlah onkeyup hargaTotal
    Private Sub txtJumlah_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtJumlah.KeyUp
        hargaTotal()
    End Sub

    ' DataGridView1 selected index changed
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            id_barang = selectedRow.Cells(0).Value.ToString()
            harga_satuan = CInt(selectedRow.Cells(2).Value.ToString())
            nama_barang = selectedRow.Cells(1).Value.ToString()
            hargaTotal()
        End If
    End Sub

    ' harga total
    Private Sub hargaTotal()
        If txtJumlah.Text = "" Then
            harga_total = harga_satuan * CInt(1)
            lbHargaTotal.Text = "Rp. " + CStr(harga_total)
        Else
            harga_total = harga_satuan * CInt(txtJumlah.Text)
            lbHargaTotal.Text = "Rp. " + CStr(harga_total)
        End If
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

        ' check data is empty
        If DataGridView1.RowCount = 0 Then
            MsgBox("Data barang kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Me.Close()
        End If

        With DataGridView1
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Harga Satuan"
        End With

    End Sub

    ' tambah pemesanan barang
    Private Sub pemesananBarang()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' simpan data
        StrSQL = "INSERT INTO pemesanan_barang (nota_pemesanan, id_barang, jumlah, keterangan) VALUES ('" & nota & "', '" & id_barang & "', '" & txtJumlah.Text & "' , '" & txtKeterangan.Text & "')"
        Dim cmd As MySqlCommand = New MySqlCommand(StrSQL, CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Pemesanan Barang berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' clear all input
    Private Sub clearInput()
        txtJumlah.Text = "1"
        txtKeterangan.Text = ""
    End Sub
End Class