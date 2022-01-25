Imports MySql.Data.MySqlClient
Public Class Utama
    Dim tanggal As Date
    Private Sub Utama_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub Utama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tanggal = Date.Now
        Jam()
        loadPemesanan()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Jam()
    End Sub
    Public Sub Jam()
        ToolStripStatusLabel1.Text = Format(Now, "F")
    End Sub
    Private Sub toolstripBtnExit_Click(sender As System.Object, e As System.EventArgs) Handles toolstripBtnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUtamaPesananBaru_Click(sender As System.Object, e As System.EventArgs) Handles btnUtamaPesananBaru.Click
        PesananBaru.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnUtamaJenisBarang_Click(sender As System.Object, e As System.EventArgs) Handles btnUtamaJenisBarang.Click
        JenisBarang.ShowDialog()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        Akun.ShowDialog()
    End Sub

    Private Sub DaftarBaruToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DaftarBaruToolStripMenuItem.Click
        AkunBaru.ShowDialog()
    End Sub

    Private Sub BulananToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BulananToolStripMenuItem.Click
        ' show message
        MessageBox.Show("Belum Tersedia", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MingguanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MingguanToolStripMenuItem.Click
        ' show message
        MessageBox.Show("Belum Tersedia", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub HarianToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HarianToolStripMenuItem.Click
        ' show message
        MessageBox.Show("Belum Tersedia", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' load data pemesanan DataGridView bedasarkan tanggal_masuk hari ini
    Private Sub loadPemesanan()
        StrCN = "Database='" & vDatabase & "'; " & _
           "Data Source='" & vServer & "'; " & _
           "User id='" & vUser & "'; " & _
           "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        Dim sql As String = "SELECT nota, status, nama_pemesan, tanggal_selesai FROM pemesanan WHERE tanggal_masuk = '" & Format(tanggal, "yyyy-MM-dd") & "' ORDER BY status"
        Dim cmd As New MySqlCommand(sql, CN)
        Dim da As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "pemesanan")
        DataGridView1.DataSource = ds.Tables("pemesanan")
        CN.Close()

        With DataGridView1
            .Columns(0).HeaderText = "Nota"
            .Columns(1).HeaderText = "Status"
            .Columns(2).HeaderText = "Nama Pemesan"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Tanggal Selesai"
        End With
    End Sub


    ' DataGridView1_CellClick
    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' get nota
        Dim nota As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString

        ' send to detail pesanan
        Pesanan.lbNota.Text = nota

        Pesanan.ShowDialog()
    End Sub

    ' form focus
    Private Sub Utama_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        loadPemesanan()
        countStatusProses()
    End Sub

    ' DateTimePicker1_ValueChanged
    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        tanggal = DateTimePicker1.Value
        loadPemesanan()
    End Sub

    ' count status proses
    Private Sub countStatusProses()
        StrCN = "Database='" & vDatabase & "'; " & _
           "Data Source='" & vServer & "'; " & _
           "User id='" & vUser & "'; " & _
           "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        Dim sql As String = "SELECT COUNT(*) FROM pemesanan WHERE status = 'Proses'"
        Dim cmd As New MySqlCommand(sql, CN)
        Dim da As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "pemesanan")
        Dim count As Integer = ds.Tables("pemesanan").Rows(0).Item(0)
        CN.Close()

        lbProsesCount.Text = count
    End Sub
End Class