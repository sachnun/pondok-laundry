Imports MySql.Data.MySqlClient
Public Class NotaHasil
    Dim nota As String
    Private Sub Nota_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' minimize the form
        nota = lbNota.Text
        tampilDataPemesanan()
        tampilData()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        ' full page
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = False
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 10
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 10
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 10
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 10
        PrintForm1.Print()
        ' open full screen
        Me.Hide()
    End Sub

    Private Sub tampilData()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        StrSQL = "SELECT * FROM pemesanan WHERE nota = '" & nota & "'"
        Dim CMD = New MySqlCommand(StrSQL, CN)
        Dim DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            lbNota.Text = DR.Item("nota")
            lbNama.Text = DR.Item("nama_pemesan")
            lbTelepon.Text = DR.Item("telepon")
            lbAlamat.Text = DR.Item("alamat")
            lbTanggalMasuk.Text = DR.Item("tanggal_masuk")
            If Not IsDBNull(RdData("tanggal_selesai")) Then
                lbTanggalKeluar.Text = DR.Item("tanggal_selesai")
            Else
                lbTanggalKeluar.Text = "-"
            End If
            lbStatus.Text = DR.Item("status")
            lbTotalBiaya.Text = "Rp." + Format(DR.Item("total_harga"), "###,###,###")
        End If
    End Sub

    Private Sub tampilDataPemesanan()
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
            .Columns(0).Width = 200
            .Columns(1).HeaderText = "Harga Satuan"
            .Columns(2).HeaderText = "Jumlah"
            .Columns(3).HeaderText = "Keterangan"
            .Columns(3).Width = 300
        End With

        DataGridView1.ClearSelection()
    End Sub
End Class