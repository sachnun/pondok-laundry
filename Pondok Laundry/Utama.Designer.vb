﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utama))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolstripBtnAkun = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripBtnLaporan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripBtnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbProsesCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnUtamaPesananBaru = New System.Windows.Forms.Button()
        Me.btnUtamaJenisBarang = New System.Windows.Forms.Button()
        Me.lbUtamaWelcome = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 371)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel1.Text = "Loading.."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripBtnAkun, Me.toolstripBtnLaporan, Me.ToolStripSeparator1, Me.toolstripBtnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(766, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolstripBtnAkun
        '
        Me.toolstripBtnAkun.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.DaftarBaruToolStripMenuItem, Me.ToolStripSeparator2, Me.LogoutToolStripMenuItem})
        Me.toolstripBtnAkun.Image = Global.Pondok_Laundry.My.Resources.Resources.icon_user
        Me.toolstripBtnAkun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripBtnAkun.Name = "toolstripBtnAkun"
        Me.toolstripBtnAkun.Size = New System.Drawing.Size(64, 22)
        Me.toolstripBtnAkun.Text = "Akun"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'DaftarBaruToolStripMenuItem
        '
        Me.DaftarBaruToolStripMenuItem.Name = "DaftarBaruToolStripMenuItem"
        Me.DaftarBaruToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DaftarBaruToolStripMenuItem.Text = "Daftar Baru"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(130, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'toolstripBtnLaporan
        '
        Me.toolstripBtnLaporan.Image = Global.Pondok_Laundry.My.Resources.Resources.icon_chart
        Me.toolstripBtnLaporan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripBtnLaporan.Name = "toolstripBtnLaporan"
        Me.toolstripBtnLaporan.Size = New System.Drawing.Size(70, 22)
        Me.toolstripBtnLaporan.Text = "Laporan"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripBtnExit
        '
        Me.toolstripBtnExit.Image = Global.Pondok_Laundry.My.Resources.Resources.icon_close
        Me.toolstripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripBtnExit.Name = "toolstripBtnExit"
        Me.toolstripBtnExit.Size = New System.Drawing.Size(60, 22)
        Me.toolstripBtnExit.Text = "Keluar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbProsesCount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(253, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 301)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesanan Saat Ini"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "klik row untuk lihat detail lengkap"
        '
        'lbProsesCount
        '
        Me.lbProsesCount.Location = New System.Drawing.Point(420, 33)
        Me.lbProsesCount.Name = "lbProsesCount"
        Me.lbProsesCount.Size = New System.Drawing.Size(44, 16)
        Me.lbProsesCount.TabIndex = 3
        Me.lbProsesCount.Text = "999"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dalam Proses :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(21, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(443, 205)
        Me.DataGridView1.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(21, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(245, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'btnUtamaPesananBaru
        '
        Me.btnUtamaPesananBaru.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtamaPesananBaru.Location = New System.Drawing.Point(29, 220)
        Me.btnUtamaPesananBaru.Name = "btnUtamaPesananBaru"
        Me.btnUtamaPesananBaru.Size = New System.Drawing.Size(193, 52)
        Me.btnUtamaPesananBaru.TabIndex = 4
        Me.btnUtamaPesananBaru.Text = "Pesanan Baru"
        Me.btnUtamaPesananBaru.UseVisualStyleBackColor = True
        '
        'btnUtamaJenisBarang
        '
        Me.btnUtamaJenisBarang.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtamaJenisBarang.Location = New System.Drawing.Point(29, 284)
        Me.btnUtamaJenisBarang.Name = "btnUtamaJenisBarang"
        Me.btnUtamaJenisBarang.Size = New System.Drawing.Size(193, 42)
        Me.btnUtamaJenisBarang.TabIndex = 5
        Me.btnUtamaJenisBarang.Text = "Jenis Barang"
        Me.btnUtamaJenisBarang.UseVisualStyleBackColor = True
        '
        'lbUtamaWelcome
        '
        Me.lbUtamaWelcome.AutoSize = True
        Me.lbUtamaWelcome.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUtamaWelcome.Location = New System.Drawing.Point(26, 187)
        Me.lbUtamaWelcome.Name = "lbUtamaWelcome"
        Me.lbUtamaWelcome.Size = New System.Drawing.Size(99, 17)
        Me.lbUtamaWelcome.TabIndex = 0
        Me.lbUtamaWelcome.Text = "Hi, username."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pondok_Laundry.My.Resources.Resources.logo_solid
        Me.PictureBox1.Location = New System.Drawing.Point(29, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(122, 22)
        Me.ToolStripLabel1.Text = "Developer Mode ON"
        Me.ToolStripLabel1.Visible = False
        '
        'Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(766, 393)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUtamaJenisBarang)
        Me.Controls.Add(Me.btnUtamaPesananBaru)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbUtamaWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pondok Laundry"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripBtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUtamaPesananBaru As System.Windows.Forms.Button
    Friend WithEvents btnUtamaJenisBarang As System.Windows.Forms.Button
    Friend WithEvents lbUtamaWelcome As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents toolstripBtnAkun As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents DaftarBaruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbProsesCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toolstripBtnLaporan As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
