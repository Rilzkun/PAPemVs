<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboardAdmin
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
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKamar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPenghuni = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Dim mnuSep As New System.Windows.Forms.ToolStripSeparator()

        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()

        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.pnlCard4 = New System.Windows.Forms.Panel()
        Me.lblTotalKamar = New System.Windows.Forms.Label()
        Me.lblKamarTersedia = New System.Windows.Forms.Label()
        Me.lblTotalPelanggan = New System.Windows.Forms.Label()
        Me.lblPemesananAktif = New System.Windows.Forms.Label()

        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnKamar = New System.Windows.Forms.Button()
        Me.btnPenghuni = New System.Windows.Forms.Button()

        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblPreviewKamar = New System.Windows.Forms.Label()
        Me.lblPreviewPesan = New System.Windows.Forms.Label()
        Me.dgvKamar = New System.Windows.Forms.DataGridView()
        Me.dgvPemesanan = New System.Windows.Forms.DataGridView()

        Me.MainMenu.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard4.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPemesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ---- MenuStrip ----
        Me.MainMenu.BackColor = System.Drawing.Color.FromArgb(25, 70, 140)
        Me.MainMenu.ForeColor = System.Drawing.Color.White
        Me.MainMenu.Items.Add(Me.mnuData)
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.Top

        Me.mnuData.Text = "≡  Menu"
        Me.mnuData.ForeColor = System.Drawing.Color.White
        Me.mnuData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuKamar, Me.mnuPenghuni, mnuSep, Me.mnuLogout})

        Me.mnuKamar.Text = "🏠  Manajemen Kamar"
        Me.mnuPenghuni.Text = "👥  Manajemen Penghuni"
        Me.mnuLogout.Text = "🚪  Logout"
        Me.mnuLogout.ForeColor = System.Drawing.Color.Red

        ' ---- pnlHeader ----
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 70
        Me.pnlHeader.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblWelcome, Me.lblRole, Me.btnRefresh, Me.btnLogout})

        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(15, 10)
        Me.lblWelcome.Text = "Selamat datang, Admin!"

        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255)
        Me.lblRole.Location = New System.Drawing.Point(17, 38)
        Me.lblRole.Text = "🔑  Role: Administrator"

        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(50, 100, 180)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(820, 20)
        Me.btnRefresh.Size = New System.Drawing.Size(90, 30)
        Me.btnRefresh.Text = "🔄  Refresh"
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(200, 60, 60)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(920, 20)
        Me.btnLogout.Size = New System.Drawing.Size(75, 30)
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        ' ---- pnlStats ----
        Me.pnlStats.BackColor = System.Drawing.Color.FromArgb(240, 244, 250)
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStats.Height = 110
        Me.pnlStats.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStats.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlCard1, Me.pnlCard2, Me.pnlCard3, Me.pnlCard4})

        ' Card 1
        Dim lblIcon1 As New System.Windows.Forms.Label()
        lblIcon1.AutoSize = True
        lblIcon1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        lblIcon1.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255)
        lblIcon1.Location = New System.Drawing.Point(10, 10)
        lblIcon1.Text = "🏠"

        Dim lblCaption1 As New System.Windows.Forms.Label()
        lblCaption1.AutoSize = True
        lblCaption1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        lblCaption1.ForeColor = System.Drawing.Color.FromArgb(210, 255, 255, 255)
        lblCaption1.Location = New System.Drawing.Point(65, 12)
        lblCaption1.Text = "Total Kamar"

        Me.lblTotalKamar.AutoSize = True
        Me.lblTotalKamar.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalKamar.ForeColor = System.Drawing.Color.White
        Me.lblTotalKamar.Location = New System.Drawing.Point(62, 28)
        Me.lblTotalKamar.Text = "0"

        Me.pnlCard1.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.pnlCard1.Location = New System.Drawing.Point(10, 10)
        Me.pnlCard1.Size = New System.Drawing.Size(225, 80)
        Me.pnlCard1.Controls.AddRange(New System.Windows.Forms.Control() {lblIcon1, lblCaption1, Me.lblTotalKamar})

        ' Card 2
        Dim lblIcon2 As New System.Windows.Forms.Label()
        lblIcon2.AutoSize = True
        lblIcon2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        lblIcon2.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255)
        lblIcon2.Location = New System.Drawing.Point(10, 10)
        lblIcon2.Text = "✅"

        Dim lblCaption2 As New System.Windows.Forms.Label()
        lblCaption2.AutoSize = True
        lblCaption2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        lblCaption2.ForeColor = System.Drawing.Color.FromArgb(210, 255, 255, 255)
        lblCaption2.Location = New System.Drawing.Point(65, 12)
        lblCaption2.Text = "Kamar Tersedia"

        Me.lblKamarTersedia.AutoSize = True
        Me.lblKamarTersedia.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblKamarTersedia.ForeColor = System.Drawing.Color.White
        Me.lblKamarTersedia.Location = New System.Drawing.Point(62, 28)
        Me.lblKamarTersedia.Text = "0"

        Me.pnlCard2.BackColor = System.Drawing.Color.FromArgb(40, 160, 80)
        Me.pnlCard2.Location = New System.Drawing.Point(245, 10)
        Me.pnlCard2.Size = New System.Drawing.Size(225, 80)
        Me.pnlCard2.Controls.AddRange(New System.Windows.Forms.Control() {lblIcon2, lblCaption2, Me.lblKamarTersedia})

        ' Card 3
        Dim lblIcon3 As New System.Windows.Forms.Label()
        lblIcon3.AutoSize = True
        lblIcon3.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        lblIcon3.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255)
        lblIcon3.Location = New System.Drawing.Point(10, 10)
        lblIcon3.Text = "👥"

        Dim lblCaption3 As New System.Windows.Forms.Label()
        lblCaption3.AutoSize = True
        lblCaption3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        lblCaption3.ForeColor = System.Drawing.Color.FromArgb(210, 255, 255, 255)
        lblCaption3.Location = New System.Drawing.Point(65, 12)
        lblCaption3.Text = "Total Pelanggan"

        Me.lblTotalPelanggan.AutoSize = True
        Me.lblTotalPelanggan.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPelanggan.ForeColor = System.Drawing.Color.White
        Me.lblTotalPelanggan.Location = New System.Drawing.Point(62, 28)
        Me.lblTotalPelanggan.Text = "0"

        Me.pnlCard3.BackColor = System.Drawing.Color.FromArgb(160, 100, 30)
        Me.pnlCard3.Location = New System.Drawing.Point(480, 10)
        Me.pnlCard3.Size = New System.Drawing.Size(225, 80)
        Me.pnlCard3.Controls.AddRange(New System.Windows.Forms.Control() {lblIcon3, lblCaption3, Me.lblTotalPelanggan})

        ' Card 4
        Dim lblIcon4 As New System.Windows.Forms.Label()
        lblIcon4.AutoSize = True
        lblIcon4.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        lblIcon4.ForeColor = System.Drawing.Color.FromArgb(200, 255, 255, 255)
        lblIcon4.Location = New System.Drawing.Point(10, 10)
        lblIcon4.Text = "📋"

        Dim lblCaption4 As New System.Windows.Forms.Label()
        lblCaption4.AutoSize = True
        lblCaption4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        lblCaption4.ForeColor = System.Drawing.Color.FromArgb(210, 255, 255, 255)
        lblCaption4.Location = New System.Drawing.Point(65, 12)
        lblCaption4.Text = "Pesanan Aktif"

        Me.lblPemesananAktif.AutoSize = True
        Me.lblPemesananAktif.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblPemesananAktif.ForeColor = System.Drawing.Color.White
        Me.lblPemesananAktif.Location = New System.Drawing.Point(62, 28)
        Me.lblPemesananAktif.Text = "0"

        Me.pnlCard4.BackColor = System.Drawing.Color.FromArgb(160, 40, 80)
        Me.pnlCard4.Location = New System.Drawing.Point(715, 10)
        Me.pnlCard4.Size = New System.Drawing.Size(225, 80)
        Me.pnlCard4.Controls.AddRange(New System.Windows.Forms.Control() {lblIcon4, lblCaption4, Me.lblPemesananAktif})

        ' ---- pnlNav ----
        Me.pnlNav.BackColor = System.Drawing.Color.FromArgb(240, 244, 250)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNav.Height = 50
        Me.pnlNav.Padding = New System.Windows.Forms.Padding(10, 8, 10, 0)

        Me.btnKamar.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKamar.FlatAppearance.BorderSize = 0
        Me.btnKamar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKamar.ForeColor = System.Drawing.Color.White
        Me.btnKamar.Location = New System.Drawing.Point(10, 8)
        Me.btnKamar.Size = New System.Drawing.Size(180, 35)
        Me.btnKamar.Text = "🏠  Manajemen Kamar"
        Me.btnKamar.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnPenghuni.BackColor = System.Drawing.Color.FromArgb(40, 120, 80)
        Me.btnPenghuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenghuni.FlatAppearance.BorderSize = 0
        Me.btnPenghuni.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPenghuni.ForeColor = System.Drawing.Color.White
        Me.btnPenghuni.Location = New System.Drawing.Point(200, 8)
        Me.btnPenghuni.Size = New System.Drawing.Size(190, 35)
        Me.btnPenghuni.Text = "👥  Manajemen Penghuni"
        Me.btnPenghuni.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlNav.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnKamar, Me.btnPenghuni})

        ' ---- pnlBody ----
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(240, 244, 250)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)

        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Location = New System.Drawing.Point(10, 5)
        Me.pnlLeft.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right

        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right

        Me.lblPreviewKamar.AutoSize = True
        Me.lblPreviewKamar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPreviewKamar.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.lblPreviewKamar.Location = New System.Drawing.Point(10, 8)
        Me.lblPreviewKamar.Text = "🏠  5 Kamar Terbaru"

        Me.dgvKamar.Location = New System.Drawing.Point(10, 30)
        Me.dgvKamar.BackgroundColor = System.Drawing.Color.White
        Me.dgvKamar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKamar.RowHeadersVisible = False
        Me.dgvKamar.EnableHeadersVisualStyles = False
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvKamar.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKamar.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 255)

        Me.pnlLeft.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPreviewKamar, Me.dgvKamar})

        Me.lblPreviewPesan.AutoSize = True
        Me.lblPreviewPesan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPreviewPesan.ForeColor = System.Drawing.Color.FromArgb(160, 40, 80)
        Me.lblPreviewPesan.Location = New System.Drawing.Point(10, 8)
        Me.lblPreviewPesan.Text = "📋  5 Pesanan Aktif"

        Me.dgvPemesanan.Location = New System.Drawing.Point(10, 30)
        Me.dgvPemesanan.BackgroundColor = System.Drawing.Color.White
        Me.dgvPemesanan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPemesanan.RowHeadersVisible = False
        Me.dgvPemesanan.EnableHeadersVisualStyles = False
        Me.dgvPemesanan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(160, 40, 80)
        Me.dgvPemesanan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPemesanan.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvPemesanan.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvPemesanan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 248)

        Me.pnlRight.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPreviewPesan, Me.dgvPemesanan})
        Me.pnlBody.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlLeft, Me.pnlRight})

        ' ---- Form ----
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 650)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlBody, Me.pnlNav, Me.pnlStats, Me.pnlHeader, Me.MainMenu})
        Me.MainMenuStrip = Me.MainMenu
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "FormDashboardAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Admin - Sistem Kost"

        Me.MainMenu.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlCard1.PerformLayout()
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard2.PerformLayout()
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard3.PerformLayout()
        Me.pnlCard4.ResumeLayout(False)
        Me.pnlCard4.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPemesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKamar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPenghuni As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents pnlCard1 As System.Windows.Forms.Panel
    Friend WithEvents pnlCard2 As System.Windows.Forms.Panel
    Friend WithEvents pnlCard3 As System.Windows.Forms.Panel
    Friend WithEvents pnlCard4 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalKamar As System.Windows.Forms.Label
    Friend WithEvents lblKamarTersedia As System.Windows.Forms.Label
    Friend WithEvents lblTotalPelanggan As System.Windows.Forms.Label
    Friend WithEvents lblPemesananAktif As System.Windows.Forms.Label
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents btnKamar As System.Windows.Forms.Button
    Friend WithEvents btnPenghuni As System.Windows.Forms.Button
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblPreviewKamar As System.Windows.Forms.Label
    Friend WithEvents lblPreviewPesan As System.Windows.Forms.Label
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPemesanan As System.Windows.Forms.DataGridView

End Class