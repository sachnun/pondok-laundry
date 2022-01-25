Public Class Utama

    Private Sub Utama_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub Utama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Jam()
        ' show message
        MsgBox("Fitur belum sepenuhnya berfungsi, masih akan terus dikembangkan..", MsgBoxStyle.Information, "Informasi")
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
    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Pesanan.ShowDialog()
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
End Class