<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Koneksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Koneksi))
        Me.txtKoneksiServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKoneksiUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKoneksiPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKoneksiDatabase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnKoneksiOk = New System.Windows.Forms.Button()
        Me.btnKoneksiReset = New System.Windows.Forms.Button()
        Me.checkKoneksiPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtKoneksiServer
        '
        Me.txtKoneksiServer.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKoneksiServer.Location = New System.Drawing.Point(15, 32)
        Me.txtKoneksiServer.Name = "txtKoneksiServer"
        Me.txtKoneksiServer.Size = New System.Drawing.Size(226, 25)
        Me.txtKoneksiServer.TabIndex = 5
        Me.txtKoneksiServer.Text = "localhost"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server"
        '
        'txtKoneksiUsername
        '
        Me.txtKoneksiUsername.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKoneksiUsername.Location = New System.Drawing.Point(15, 89)
        Me.txtKoneksiUsername.Name = "txtKoneksiUsername"
        Me.txtKoneksiUsername.Size = New System.Drawing.Size(226, 25)
        Me.txtKoneksiUsername.TabIndex = 7
        Me.txtKoneksiUsername.Text = "root"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'txtKoneksiPassword
        '
        Me.txtKoneksiPassword.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKoneksiPassword.Location = New System.Drawing.Point(15, 146)
        Me.txtKoneksiPassword.Name = "txtKoneksiPassword"
        Me.txtKoneksiPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKoneksiPassword.Size = New System.Drawing.Size(202, 25)
        Me.txtKoneksiPassword.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'txtKoneksiDatabase
        '
        Me.txtKoneksiDatabase.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKoneksiDatabase.Location = New System.Drawing.Point(16, 206)
        Me.txtKoneksiDatabase.Name = "txtKoneksiDatabase"
        Me.txtKoneksiDatabase.Size = New System.Drawing.Size(226, 25)
        Me.txtKoneksiDatabase.TabIndex = 11
        Me.txtKoneksiDatabase.Text = "pondok_laundry"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Database"
        '
        'btnKoneksiOk
        '
        Me.btnKoneksiOk.Location = New System.Drawing.Point(177, 244)
        Me.btnKoneksiOk.Name = "btnKoneksiOk"
        Me.btnKoneksiOk.Size = New System.Drawing.Size(65, 23)
        Me.btnKoneksiOk.TabIndex = 12
        Me.btnKoneksiOk.Text = "OK"
        Me.btnKoneksiOk.UseVisualStyleBackColor = True
        '
        'btnKoneksiReset
        '
        Me.btnKoneksiReset.Location = New System.Drawing.Point(96, 244)
        Me.btnKoneksiReset.Name = "btnKoneksiReset"
        Me.btnKoneksiReset.Size = New System.Drawing.Size(75, 23)
        Me.btnKoneksiReset.TabIndex = 13
        Me.btnKoneksiReset.Text = "Reset"
        Me.btnKoneksiReset.UseVisualStyleBackColor = True
        '
        'checkKoneksiPassword
        '
        Me.checkKoneksiPassword.AutoSize = True
        Me.checkKoneksiPassword.Location = New System.Drawing.Point(223, 152)
        Me.checkKoneksiPassword.Name = "checkKoneksiPassword"
        Me.checkKoneksiPassword.Size = New System.Drawing.Size(15, 14)
        Me.checkKoneksiPassword.TabIndex = 14
        Me.checkKoneksiPassword.UseVisualStyleBackColor = True
        '
        'Koneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(255, 287)
        Me.Controls.Add(Me.checkKoneksiPassword)
        Me.Controls.Add(Me.btnKoneksiReset)
        Me.Controls.Add(Me.btnKoneksiOk)
        Me.Controls.Add(Me.txtKoneksiDatabase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKoneksiPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKoneksiUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKoneksiServer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Koneksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Koneksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKoneksiServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKoneksiUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKoneksiPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKoneksiDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnKoneksiOk As System.Windows.Forms.Button
    Friend WithEvents btnKoneksiReset As System.Windows.Forms.Button
    Friend WithEvents checkKoneksiPassword As System.Windows.Forms.CheckBox
End Class
