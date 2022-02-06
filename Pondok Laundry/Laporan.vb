Imports MySql.Data.MySqlClient
Public Class Laporan
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Private Sub Laporan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' max selection MonthCalendar1
        MonthCalendar1.MaxSelectionCount = 90

        loadPemesanan()

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DataGridView1.AllowUserToResizeRows = False
    End Sub

    Private Sub loadPemesanan()
        StrCN = "Database='" & vDatabase & "'; " & _
            "Data Source='" & vServer & "'; " & _
            "User id='" & vUser & "'; " & _
            "Password='" & vPass & "'"

        CN = New MySqlConnection(StrCN)
        CN.Open()

        ' show data to dataGridView
        StrSQL = "SELECT * FROM pemesanan WHERE tanggal_masuk BETWEEN '" & Format(MonthCalendar1.SelectionStart, "yyyy-MM-dd") & "' AND '" & Format(MonthCalendar1.SelectionEnd, "yyyy-MM-dd") & "'"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(StrSQL, CN)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        With DataGridView1
            .Columns(0).HeaderText = "No. Nota"
            .Columns(1).HeaderText = "Nama Pemesan"
            .Columns(2).HeaderText = "Telepon"
            .Columns(3).HeaderText = "Alamat"
            .Columns(4).HeaderText = "Total Harga"
            .Columns(5).HeaderText = "Tanggal Masuk"
            .Columns(6).HeaderText = "Tanggal Keluar"
            .Columns(7).HeaderText = "ID Karyawan"
            .Columns(8).HeaderText = "Status"
        End With

        DataGridView1.ClearSelection()
    End Sub

    'MonthCalendar1 change
    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        loadPemesanan()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' messagebox oke
        MsgBox("Fitur Print Laporan masih tahap uji coba!", MsgBoxStyle.Exclamation, "Warning")

        ' print preview
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized

        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' header text
        Dim header As String = "Laporan Nota Pesanan / Transaksi"
        ' create font and brush
        Dim font As New Font("Arial", 14, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        ' draw the text in center page
        e.Graphics.DrawString(header, font, brush, _
            e.MarginBounds.Left + (e.MarginBounds.Width - _
            e.Graphics.MeasureString(header, font).Width) / 2, _
            e.MarginBounds.Top)

        With DataGridView1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top + font.GetHeight(e.Graphics) + 20
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                If newpage Then
                    newpage = False
                Else
                    mRow += 1
                End If
                y += h
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub
End Class