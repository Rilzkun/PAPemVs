<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblTelp = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblKonfirmasi = New System.Windows.Forms.Label()
        Me.txtKonfirmasi = New System.Windows.Forms.TextBox()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()

        Me.pnlHeader.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.SuspendLayout()

        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(360, 70)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(206, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "📝  Daftar Akun Baru"
        '
        ' pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.White
        Me.pnlForm.Controls.Add(Me.lblNama)
        Me.pnlForm.Controls.Add(Me.txtNama)
        Me.pnlForm.Controls.Add(Me.lblUsername)
        Me.pnlForm.Controls.Add(Me.txtUsername)
        Me.pnlForm.Controls.Add(Me.lblTelp)
        Me.pnlForm.Controls.Add(Me.txtTelp)
        Me.pnlForm.Controls.Add(Me.lblPassword)
        Me.pnlForm.Controls.Add(Me.txtPassword)
        Me.pnlForm.Controls.Add(Me.lblKonfirmasi)
        Me.pnlForm.Controls.Add(Me.txtKonfirmasi)
        Me.pnlForm.Controls.Add(Me.btnDaftar)
        Me.pnlForm.Controls.Add(Me.btnBatal)
        Me.pnlForm.Controls.Add(Me.lblError)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(0, 70)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.pnlForm.Size = New System.Drawing.Size(360, 390)
        Me.pnlForm.TabIndex = 1
        '
        ' lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblNama.Location = New System.Drawing.Point(30, 20)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(87, 15)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama Lengkap"
        '
        ' txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNama.Location = New System.Drawing.Point(30, 38)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(300, 25)
        Me.txtNama.TabIndex = 1
        '
        ' lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblUsername.Location = New System.Drawing.Point(30, 70)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(60, 15)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        ' txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(30, 88)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(300, 25)
        Me.txtUsername.TabIndex = 3
        '
        ' lblTelp
        '
        Me.lblTelp.AutoSize = True
        Me.lblTelp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTelp.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblTelp.Location = New System.Drawing.Point(30, 120)
        Me.lblTelp.Name = "lblTelp"
        Me.lblTelp.Size = New System.Drawing.Size(71, 15)
        Me.lblTelp.TabIndex = 4
        Me.lblTelp.Text = "No. Telepon"
        '
        ' txtTelp
        '
        Me.txtTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTelp.Location = New System.Drawing.Point(30, 138)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(300, 25)
        Me.txtTelp.TabIndex = 5
        '
        ' lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblPassword.Location = New System.Drawing.Point(30, 170)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 15)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        ' txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(30, 188)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(300, 25)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        ' lblKonfirmasi
        '
        Me.lblKonfirmasi.AutoSize = True
        Me.lblKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKonfirmasi.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblKonfirmasi.Location = New System.Drawing.Point(30, 220)
        Me.lblKonfirmasi.Name = "lblKonfirmasi"
        Me.lblKonfirmasi.Size = New System.Drawing.Size(122, 15)
        Me.lblKonfirmasi.TabIndex = 8
        Me.lblKonfirmasi.Text = "Konfirmasi Password"
        '
        ' txtKonfirmasi
        '
        Me.txtKonfirmasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtKonfirmasi.Location = New System.Drawing.Point(30, 238)
        Me.txtKonfirmasi.Name = "txtKonfirmasi"
        Me.txtKonfirmasi.Size = New System.Drawing.Size(300, 25)
        Me.txtKonfirmasi.TabIndex = 9
        Me.txtKonfirmasi.UseSystemPasswordChar = True
        '
        ' lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(30, 275)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(300, 20)
        Me.lblError.TabIndex = 10
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        ' btnDaftar
        '
        Me.btnDaftar.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.btnDaftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDaftar.FlatAppearance.BorderSize = 0
        Me.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDaftar.ForeColor = System.Drawing.Color.White
        Me.btnDaftar.Location = New System.Drawing.Point(30, 300)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(300, 38)
        Me.btnDaftar.TabIndex = 11
        Me.btnDaftar.Text = "DAFTAR SEKARANG"
        Me.btnDaftar.UseVisualStyleBackColor = False
        '
        ' btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.White
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.Gray
        Me.btnBatal.Location = New System.Drawing.Point(30, 345)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(300, 30)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal / Kembali"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        ' FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(360, 460)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registrasi - Sistem Kost"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblTelp As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblKonfirmasi As Label
    Friend WithEvents txtKonfirmasi As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblError As Label

End Class