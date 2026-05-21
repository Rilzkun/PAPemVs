<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboardUser
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPesan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKelola = New System.Windows.Forms.ToolStripMenuItem()
        Dim mnuSep As New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblRoleInfo = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.btnKelolaP = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlKamarInfo = New System.Windows.Forms.Panel()
        Me.lblKamarTitle = New System.Windows.Forms.Label()
        Me.lblNoKamar = New System.Windows.Forms.Label()
        Me.lblTipeKamar = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblDurasi = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTglMulai = New System.Windows.Forms.Label()
        Me.lblTglSelesai = New System.Windows.Forms.Label()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.pnlTidakAdaPesan = New System.Windows.Forms.Panel()
        Me.lblTidakAda = New System.Windows.Forms.Label()
        Me.lblSaran = New System.Windows.Forms.Label()
        Me.docPrint = New System.Drawing.Printing.PrintDocument()
        Me.dialogPrint = New System.Windows.Forms.PrintPreviewDialog()

        Me.MainMenu.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlKamarInfo.SuspendLayout()
        Me.pnlTidakAdaPesan.SuspendLayout()
        Me.SuspendLayout()

        ' ---- MenuStrip ----
        Me.MainMenu.BackColor = System.Drawing.Color.FromArgb(40, 100, 180)
        Me.MainMenu.ForeColor = System.Drawing.Color.White
        Me.MainMenu.Items.Add(Me.mnuData)
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.mnuData.Text = "≡  Menu"
        Me.mnuData.ForeColor = System.Drawing.Color.White
        Me.mnuData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPesan, Me.mnuKelola, mnuSep, Me.mnuLogout})
        Me.mnuPesan.Text = "📋  Pesan Kamar Baru"
        Me.mnuKelola.Text = "📁  Kelola Pesanan Saya"
        Me.mnuLogout.Text = "🚪  Logout"
        Me.mnuLogout.ForeColor = System.Drawing.Color.Red

        ' ---- pnlHeader ----
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(40, 100, 180)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 70
        Me.pnlHeader.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblWelcome, Me.lblRoleInfo, Me.btnLogout})

        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(15, 10)
        Me.lblWelcome.Text = "Halo, Penghuni!"

        Me.lblRoleInfo.AutoSize = True
        Me.lblRoleInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRoleInfo.ForeColor = System.Drawing.Color.FromArgb(200, 225, 255)
        Me.lblRoleInfo.Location = New System.Drawing.Point(17, 38)
        Me.lblRoleInfo.Text = "👤  Role: Penghuni / User"

        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(200, 60, 60)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(600, 20)
        Me.btnLogout.Size = New System.Drawing.Size(75, 30)
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        ' ---- pnlNav ----
        Me.pnlNav.BackColor = System.Drawing.Color.FromArgb(240, 244, 250)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNav.Height = 50
        Me.pnlNav.Padding = New System.Windows.Forms.Padding(10, 8, 10, 0)
        Me.pnlNav.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPesan, Me.btnKelolaP})

        Me.btnPesan.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesan.FlatAppearance.BorderSize = 0
        Me.btnPesan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPesan.ForeColor = System.Drawing.Color.White
        Me.btnPesan.Location = New System.Drawing.Point(10, 8)
        Me.btnPesan.Size = New System.Drawing.Size(170, 35)
        Me.btnPesan.Text = "📋  Pesan Kamar"
        Me.btnPesan.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnKelolaP.BackColor = System.Drawing.Color.FromArgb(100, 60, 160)
        Me.btnKelolaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKelolaP.FlatAppearance.BorderSize = 0
        Me.btnKelolaP.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKelolaP.ForeColor = System.Drawing.Color.White
        Me.btnKelolaP.Location = New System.Drawing.Point(190, 8)
        Me.btnKelolaP.Size = New System.Drawing.Size(180, 35)
        Me.btnKelolaP.Text = "📁  Pesanan Saya"
        Me.btnKelolaP.Cursor = System.Windows.Forms.Cursors.Hand

        ' ---- pnlContent ----
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(240, 244, 250)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlContent.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlKamarInfo, Me.pnlTidakAdaPesan})

        ' ---- pnlKamarInfo ----
        Me.pnlKamarInfo.BackColor = System.Drawing.Color.White
        Me.pnlKamarInfo.Location = New System.Drawing.Point(20, 20)
        Me.pnlKamarInfo.Size = New System.Drawing.Size(580, 420)
        Me.pnlKamarInfo.Padding = New System.Windows.Forms.Padding(20)

        Me.lblKamarTitle.AutoSize = True
        Me.lblKamarTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblKamarTitle.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.lblKamarTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblKamarTitle.Text = "🏠  Kamar Yang Sedang Disewa"
        Me.pnlKamarInfo.Controls.Add(Me.lblKamarTitle)

        Dim lblKey0 As New System.Windows.Forms.Label()
        lblKey0.AutoSize = True : lblKey0.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey0.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey0.Location = New System.Drawing.Point(20, 60) : lblKey0.Text = "Nomor Kamar:" : Me.pnlKamarInfo.Controls.Add(lblKey0)
        Me.lblNoKamar.AutoSize = True : Me.lblNoKamar.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblNoKamar.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblNoKamar.Location = New System.Drawing.Point(170, 60) : Me.lblNoKamar.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblNoKamar)

        Dim lblKey1 As New System.Windows.Forms.Label()
        lblKey1.AutoSize = True : lblKey1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey1.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey1.Location = New System.Drawing.Point(20, 93) : lblKey1.Text = "Tipe Kamar:" : Me.pnlKamarInfo.Controls.Add(lblKey1)
        Me.lblTipeKamar.AutoSize = True : Me.lblTipeKamar.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblTipeKamar.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblTipeKamar.Location = New System.Drawing.Point(170, 93) : Me.lblTipeKamar.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblTipeKamar)

        Dim lblKey2 As New System.Windows.Forms.Label()
        lblKey2.AutoSize = True : lblKey2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey2.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey2.Location = New System.Drawing.Point(20, 126) : lblKey2.Text = "Harga/Bulan:" : Me.pnlKamarInfo.Controls.Add(lblKey2)
        Me.lblHarga.AutoSize = True : Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblHarga.Location = New System.Drawing.Point(170, 126) : Me.lblHarga.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblHarga)

        Dim lblKey3 As New System.Windows.Forms.Label()
        lblKey3.AutoSize = True : lblKey3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey3.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey3.Location = New System.Drawing.Point(20, 159) : lblKey3.Text = "Durasi Sewa:" : Me.pnlKamarInfo.Controls.Add(lblKey3)
        Me.lblDurasi.AutoSize = True : Me.lblDurasi.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblDurasi.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblDurasi.Location = New System.Drawing.Point(170, 159) : Me.lblDurasi.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblDurasi)

        Dim lblKey4 As New System.Windows.Forms.Label()
        lblKey4.AutoSize = True : lblKey4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey4.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey4.Location = New System.Drawing.Point(20, 192) : lblKey4.Text = "Total Harga:" : Me.pnlKamarInfo.Controls.Add(lblKey4)
        Me.lblTotal.AutoSize = True : Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblTotal.Location = New System.Drawing.Point(170, 192) : Me.lblTotal.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblTotal)

        Dim lblKey5 As New System.Windows.Forms.Label()
        lblKey5.AutoSize = True : lblKey5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey5.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey5.Location = New System.Drawing.Point(20, 225) : lblKey5.Text = "Tanggal Mulai:" : Me.pnlKamarInfo.Controls.Add(lblKey5)
        Me.lblTglMulai.AutoSize = True : Me.lblTglMulai.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblTglMulai.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblTglMulai.Location = New System.Drawing.Point(170, 225) : Me.lblTglMulai.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblTglMulai)

        Dim lblKey6 As New System.Windows.Forms.Label()
        lblKey6.AutoSize = True : lblKey6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey6.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey6.Location = New System.Drawing.Point(20, 258) : lblKey6.Text = "Tanggal Selesai:" : Me.pnlKamarInfo.Controls.Add(lblKey6)
        Me.lblTglSelesai.AutoSize = True : Me.lblTglSelesai.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblTglSelesai.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblTglSelesai.Location = New System.Drawing.Point(170, 258) : Me.lblTglSelesai.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblTglSelesai)

        Dim lblKey7 As New System.Windows.Forms.Label()
        lblKey7.AutoSize = True : lblKey7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey7.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey7.Location = New System.Drawing.Point(20, 291) : lblKey7.Text = "Deskripsi:" : Me.pnlKamarInfo.Controls.Add(lblKey7)
        Me.lblDeskripsi.AutoSize = True : Me.lblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30) : Me.lblDeskripsi.Location = New System.Drawing.Point(170, 291) : Me.lblDeskripsi.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblDeskripsi)

        Dim lblKey8 As New System.Windows.Forms.Label()
        lblKey8.AutoSize = True : lblKey8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold) : lblKey8.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80) : lblKey8.Location = New System.Drawing.Point(20, 324) : lblKey8.Text = "Status:" : Me.pnlKamarInfo.Controls.Add(lblKey8)
        Me.lblStatus.AutoSize = True : Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!) : Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(40, 160, 80) : Me.lblStatus.Location = New System.Drawing.Point(170, 324) : Me.lblStatus.Text = "-" : Me.pnlKamarInfo.Controls.Add(Me.lblStatus)

        ' Tombol Cetak Struk
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(40, 160, 80)
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(24, 365)
        Me.btnCetak.Size = New System.Drawing.Size(160, 35)
        Me.btnCetak.Text = "🖨️ Cetak Struk"
        Me.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlKamarInfo.Controls.Add(Me.btnCetak)

        ' ---- pnlTidakAdaPesan ----
        Me.pnlTidakAdaPesan.BackColor = System.Drawing.Color.White
        Me.pnlTidakAdaPesan.Location = New System.Drawing.Point(20, 20)
        Me.pnlTidakAdaPesan.Size = New System.Drawing.Size(450, 180)
        Me.pnlTidakAdaPesan.Padding = New System.Windows.Forms.Padding(20)

        Me.lblTidakAda.AutoSize = True
        Me.lblTidakAda.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTidakAda.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Me.lblTidakAda.Location = New System.Drawing.Point(20, 30)
        Me.lblTidakAda.Text = "🏠  Belum Ada Kamar Aktif"

        Me.lblSaran.AutoSize = True
        Me.lblSaran.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSaran.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120)
        Me.lblSaran.Location = New System.Drawing.Point(20, 75)
        Me.lblSaran.Text = "Klik tombol 'Pesan Kamar' untuk menyewa kamar."
        Me.pnlTidakAdaPesan.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblTidakAda, Me.lblSaran})

        ' ---- Form ----
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 560)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlContent, Me.pnlNav, Me.pnlHeader, Me.MainMenu})
        Me.MainMenuStrip = Me.MainMenu
        Me.MinimumSize = New System.Drawing.Size(650, 500)
        Me.Name = "FormDashboardUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard - Sistem Kost"

        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
        Me.pnlKamarInfo.ResumeLayout(False)
        Me.pnlKamarInfo.PerformLayout()
        Me.pnlTidakAdaPesan.ResumeLayout(False)
        Me.pnlTidakAdaPesan.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPesan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKelola As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblRoleInfo As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents btnPesan As System.Windows.Forms.Button
    Friend WithEvents btnKelolaP As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlKamarInfo As System.Windows.Forms.Panel
    Friend WithEvents lblKamarTitle As System.Windows.Forms.Label
    Friend WithEvents lblNoKamar As System.Windows.Forms.Label
    Friend WithEvents lblTipeKamar As System.Windows.Forms.Label
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents lblDurasi As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTglMulai As System.Windows.Forms.Label
    Friend WithEvents lblTglSelesai As System.Windows.Forms.Label
    Friend WithEvents lblDeskripsi As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents pnlTidakAdaPesan As System.Windows.Forms.Panel
    Friend WithEvents lblTidakAda As System.Windows.Forms.Label
    Friend WithEvents lblSaran As System.Windows.Forms.Label

    Friend WithEvents docPrint As System.Drawing.Printing.PrintDocument
    Friend WithEvents dialogPrint As System.Windows.Forms.PrintPreviewDialog

End Class