<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        ' ---- Deklarasi kontrol ----
        pnlHeader = New Panel()
        lblAppName = New Label()
        lblSubtitle = New Label()

        pnlForm = New Panel()
        lblJudul = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        chkShowPass = New CheckBox()
        btnLogin = New Button()
        btnRegister = New Button()
        lblError = New Label()
        lblVersion = New Label()

        pnlHeader.SuspendLayout()
        pnlForm.SuspendLayout()
        SuspendLayout()

        ' =============== pnlHeader ===============
        pnlHeader.BackColor = Color.FromArgb(30, 80, 160)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Height = 120
        pnlHeader.Controls.AddRange(New Control() {lblAppName, lblSubtitle})

        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.Location = New Point(30, 25)
        lblAppName.Text = "🏠  SISTEM KOST"

        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10)
        lblSubtitle.ForeColor = Color.FromArgb(200, 220, 255)
        lblSubtitle.Location = New Point(34, 72)
        lblSubtitle.Text = "Manajemen & Pemesanan Kamar Kost"

        ' =============== pnlForm ===============
        pnlForm.BackColor = Color.White
        pnlForm.Padding = New Padding(40, 20, 40, 20)
        pnlForm.Dock = DockStyle.Fill
        pnlForm.Controls.AddRange(New Control() {
            lblJudul, lblUsername, txtUsername, lblPassword, txtPassword,
            chkShowPass, btnLogin, btnRegister, lblError, lblVersion})

        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblJudul.ForeColor = Color.FromArgb(30, 80, 160)
        lblJudul.Location = New Point(90, 30)
        lblJudul.Text = "Masuk ke Akun Anda"

        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10)
        lblUsername.ForeColor = Color.FromArgb(80, 80, 80)
        lblUsername.Location = New Point(40, 80)
        lblUsername.Text = "Username"

        txtUsername.Font = New Font("Segoe UI", 11)
        txtUsername.Location = New Point(40, 100)
        txtUsername.Size = New Size(280, 35)
        txtUsername.BorderStyle = BorderStyle.FixedSingle

        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10)
        lblPassword.ForeColor = Color.FromArgb(80, 80, 80)
        lblPassword.Location = New Point(40, 148)
        lblPassword.Text = "Password"

        txtPassword.Font = New Font("Segoe UI", 11)
        txtPassword.Location = New Point(40, 168)
        txtPassword.Size = New Size(280, 35)
        txtPassword.UseSystemPasswordChar = True
        txtPassword.BorderStyle = BorderStyle.FixedSingle

        chkShowPass.AutoSize = True
        chkShowPass.Font = New Font("Segoe UI", 9)
        chkShowPass.ForeColor = Color.Gray
        chkShowPass.Location = New Point(40, 210)
        chkShowPass.Text = "Tampilkan Password"

        btnLogin.BackColor = Color.FromArgb(30, 80, 160)
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(40, 245)
        btnLogin.Size = New Size(280, 42)
        btnLogin.Text = "MASUK"
        btnLogin.Cursor = Cursors.Hand

        lblError.AutoSize = False
        lblError.Font = New Font("Segoe UI", 9)
        lblError.ForeColor = Color.Red
        lblError.Location = New Point(40, 295)
        lblError.Size = New Size(280, 20)
        lblError.TextAlign = ContentAlignment.MiddleCenter
        lblError.Visible = False

        btnRegister.BackColor = Color.White
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.FlatAppearance.BorderColor = Color.FromArgb(30, 80, 160)
        btnRegister.Font = New Font("Segoe UI", 10)
        btnRegister.ForeColor = Color.FromArgb(30, 80, 160)
        btnRegister.Location = New Point(40, 320)
        btnRegister.Size = New Size(280, 38)
        btnRegister.Text = "Belum punya akun? Daftar"
        btnRegister.Cursor = Cursors.Hand

        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Segoe UI", 8)
        lblVersion.ForeColor = Color.LightGray
        lblVersion.Location = New Point(115, 370)
        lblVersion.Text = "v1.0.0 - SistemKost 2025"

        ' =============== Form ===============
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(360, 490)
        Me.Controls.AddRange(New Control() {pnlForm, pnlHeader})
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Login - Sistem Kost"
        Me.BackColor = Color.White

        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        ResumeLayout(False)
    End Sub

    ' ---- Kontrol ----
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lblVersion As Label

End Class