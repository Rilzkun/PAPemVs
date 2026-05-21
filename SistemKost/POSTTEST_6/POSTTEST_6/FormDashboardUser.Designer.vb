﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboardUser))
        MainMenu = New MenuStrip()
        mnuData = New ToolStripMenuItem()
        mnuPesan = New ToolStripMenuItem()
        mnuKelola = New ToolStripMenuItem()
        mnuSep = New ToolStripSeparator()
        mnuLogout = New ToolStripMenuItem()
        pnlHeader = New Panel()
        lblWelcome = New Label()
        lblRoleInfo = New Label()
        btnLogout = New Button()
        pnlNav = New Panel()
        btnPesan = New Button()
        btnKelolaP = New Button()
        pnlContent = New Panel()
        pnlKamarInfo = New Panel()
        lblKamarTitle = New Label()
        lblKey0 = New Label()
        lblNoKamar = New Label()
        lblKey1 = New Label()
        lblTipeKamar = New Label()
        lblKey2 = New Label()
        lblHarga = New Label()
        lblKey3 = New Label()
        lblDurasi = New Label()
        lblKey4 = New Label()
        lblTotal = New Label()
        lblKey5 = New Label()
        lblTglMulai = New Label()
        lblKey6 = New Label()
        lblTglSelesai = New Label()
        lblKey7 = New Label()
        lblDeskripsi = New Label()
        lblKey8 = New Label()
        lblStatus = New Label()
        btnCetak = New Button()
        pnlTidakAdaPesan = New Panel()
        lblTidakAda = New Label()
        lblSaran = New Label()
        docPrint = New Printing.PrintDocument()
        dialogPrint = New PrintPreviewDialog()
        MainMenu.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlNav.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlKamarInfo.SuspendLayout()
        pnlTidakAdaPesan.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainMenu
        ' 
        MainMenu.BackColor = Color.FromArgb(CByte(40), CByte(100), CByte(180))
        MainMenu.ForeColor = Color.White
        MainMenu.ImageScalingSize = New Size(20, 20)
        MainMenu.Items.AddRange(New ToolStripItem() {mnuData})
        MainMenu.Location = New Point(0, 0)
        MainMenu.Name = "MainMenu"
        MainMenu.Padding = New Padding(7, 3, 0, 3)
        MainMenu.Size = New Size(800, 30)
        MainMenu.TabIndex = 3
        ' 
        ' mnuData
        ' 
        mnuData.DropDownItems.AddRange(New ToolStripItem() {mnuPesan, mnuKelola, mnuSep, mnuLogout})
        mnuData.ForeColor = Color.White
        mnuData.Name = "mnuData"
        mnuData.Size = New Size(78, 24)
        mnuData.Text = "≡  Menu"
        ' 
        ' mnuPesan
        ' 
        mnuPesan.Name = "mnuPesan"
        mnuPesan.Size = New Size(255, 26)
        mnuPesan.Text = "📋  Pesan Kamar Baru"
        ' 
        ' mnuKelola
        ' 
        mnuKelola.Name = "mnuKelola"
        mnuKelola.Size = New Size(255, 26)
        mnuKelola.Text = "📁  Kelola Pesanan Saya"
        ' 
        ' mnuSep
        ' 
        mnuSep.Name = "mnuSep"
        mnuSep.Size = New Size(252, 6)
        ' 
        ' mnuLogout
        ' 
        mnuLogout.ForeColor = Color.Red
        mnuLogout.Name = "mnuLogout"
        mnuLogout.Size = New Size(255, 26)
        mnuLogout.Text = "🚪  Logout"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(40), CByte(100), CByte(180))
        pnlHeader.Controls.Add(lblWelcome)
        pnlHeader.Controls.Add(lblRoleInfo)
        pnlHeader.Controls.Add(btnLogout)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 30)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(800, 93)
        pnlHeader.TabIndex = 2
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(17, 13)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(177, 30)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Halo, Penghuni!"
        ' 
        ' lblRoleInfo
        ' 
        lblRoleInfo.AutoSize = True
        lblRoleInfo.Font = New Font("Segoe UI", 9.0F)
        lblRoleInfo.ForeColor = Color.FromArgb(CByte(200), CByte(225), CByte(255))
        lblRoleInfo.Location = New Point(19, 51)
        lblRoleInfo.Name = "lblRoleInfo"
        lblRoleInfo.Size = New Size(178, 20)
        lblRoleInfo.TabIndex = 1
        lblRoleInfo.Text = "👤  Role: Penghuni / User"
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.FromArgb(CByte(200), CByte(60), CByte(60))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.0F)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(1257, 27)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(86, 40)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(250))
        pnlNav.Controls.Add(btnPesan)
        pnlNav.Controls.Add(btnKelolaP)
        pnlNav.Dock = DockStyle.Top
        pnlNav.Location = New Point(0, 123)
        pnlNav.Margin = New Padding(3, 4, 3, 4)
        pnlNav.Name = "pnlNav"
        pnlNav.Padding = New Padding(11, 11, 11, 0)
        pnlNav.Size = New Size(800, 67)
        pnlNav.TabIndex = 1
        ' 
        ' btnPesan
        ' 
        btnPesan.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        btnPesan.Cursor = Cursors.Hand
        btnPesan.FlatAppearance.BorderSize = 0
        btnPesan.FlatStyle = FlatStyle.Flat
        btnPesan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnPesan.ForeColor = Color.White
        btnPesan.Location = New Point(11, 11)
        btnPesan.Margin = New Padding(3, 4, 3, 4)
        btnPesan.Name = "btnPesan"
        btnPesan.Size = New Size(194, 47)
        btnPesan.TabIndex = 0
        btnPesan.Text = "📋  Pesan Kamar"
        btnPesan.UseVisualStyleBackColor = False
        ' 
        ' btnKelolaP
        ' 
        btnKelolaP.BackColor = Color.FromArgb(CByte(100), CByte(60), CByte(160))
        btnKelolaP.Cursor = Cursors.Hand
        btnKelolaP.FlatAppearance.BorderSize = 0
        btnKelolaP.FlatStyle = FlatStyle.Flat
        btnKelolaP.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnKelolaP.ForeColor = Color.White
        btnKelolaP.Location = New Point(217, 11)
        btnKelolaP.Margin = New Padding(3, 4, 3, 4)
        btnKelolaP.Name = "btnKelolaP"
        btnKelolaP.Size = New Size(206, 47)
        btnKelolaP.TabIndex = 1
        btnKelolaP.Text = "📁  Pesanan Saya"
        btnKelolaP.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(250))
        pnlContent.Controls.Add(pnlKamarInfo)
        pnlContent.Controls.Add(pnlTidakAdaPesan)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 190)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(23, 27, 23, 27)
        pnlContent.Size = New Size(800, 557)
        pnlContent.TabIndex = 0
        ' 
        ' pnlKamarInfo
        ' 
        pnlKamarInfo.BackColor = Color.White
        pnlKamarInfo.Controls.Add(lblKamarTitle)
        pnlKamarInfo.Controls.Add(lblKey0)
        pnlKamarInfo.Controls.Add(lblNoKamar)
        pnlKamarInfo.Controls.Add(lblKey1)
        pnlKamarInfo.Controls.Add(lblTipeKamar)
        pnlKamarInfo.Controls.Add(lblKey2)
        pnlKamarInfo.Controls.Add(lblHarga)
        pnlKamarInfo.Controls.Add(lblKey3)
        pnlKamarInfo.Controls.Add(lblDurasi)
        pnlKamarInfo.Controls.Add(lblKey4)
        pnlKamarInfo.Controls.Add(lblTotal)
        pnlKamarInfo.Controls.Add(lblKey5)
        pnlKamarInfo.Controls.Add(lblTglMulai)
        pnlKamarInfo.Controls.Add(lblKey6)
        pnlKamarInfo.Controls.Add(lblTglSelesai)
        pnlKamarInfo.Controls.Add(lblKey7)
        pnlKamarInfo.Controls.Add(lblDeskripsi)
        pnlKamarInfo.Controls.Add(lblKey8)
        pnlKamarInfo.Controls.Add(lblStatus)
        pnlKamarInfo.Controls.Add(btnCetak)
        pnlKamarInfo.Location = New Point(23, 27)
        pnlKamarInfo.Margin = New Padding(3, 4, 3, 4)
        pnlKamarInfo.Name = "pnlKamarInfo"
        pnlKamarInfo.Padding = New Padding(23, 27, 23, 27)
        pnlKamarInfo.Size = New Size(663, 560)
        pnlKamarInfo.TabIndex = 0
        ' 
        ' lblKamarTitle
        ' 
        lblKamarTitle.AutoSize = True
        lblKamarTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblKamarTitle.ForeColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        lblKamarTitle.Location = New Point(23, 20)
        lblKamarTitle.Name = "lblKamarTitle"
        lblKamarTitle.Size = New Size(342, 30)
        lblKamarTitle.TabIndex = 0
        lblKamarTitle.Text = "🏠  Kamar Yang Sedang Disewa"
        ' 
        ' lblKey0
        ' 
        lblKey0.AutoSize = True
        lblKey0.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey0.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey0.Location = New Point(23, 80)
        lblKey0.Name = "lblKey0"
        lblKey0.Size = New Size(129, 23)
        lblKey0.TabIndex = 1
        lblKey0.Text = "Nomor Kamar:"
        ' 
        ' lblNoKamar
        ' 
        lblNoKamar.AutoSize = True
        lblNoKamar.Font = New Font("Segoe UI", 10.0F)
        lblNoKamar.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblNoKamar.Location = New Point(194, 80)
        lblNoKamar.Name = "lblNoKamar"
        lblNoKamar.Size = New Size(17, 23)
        lblNoKamar.TabIndex = 2
        lblNoKamar.Text = "-"
        ' 
        ' lblKey1
        ' 
        lblKey1.AutoSize = True
        lblKey1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey1.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey1.Location = New Point(23, 124)
        lblKey1.Name = "lblKey1"
        lblKey1.Size = New Size(108, 23)
        lblKey1.TabIndex = 3
        lblKey1.Text = "Tipe Kamar:"
        ' 
        ' lblTipeKamar
        ' 
        lblTipeKamar.AutoSize = True
        lblTipeKamar.Font = New Font("Segoe UI", 10.0F)
        lblTipeKamar.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTipeKamar.Location = New Point(194, 124)
        lblTipeKamar.Name = "lblTipeKamar"
        lblTipeKamar.Size = New Size(17, 23)
        lblTipeKamar.TabIndex = 4
        lblTipeKamar.Text = "-"
        ' 
        ' lblKey2
        ' 
        lblKey2.AutoSize = True
        lblKey2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey2.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey2.Location = New Point(23, 168)
        lblKey2.Name = "lblKey2"
        lblKey2.Size = New Size(117, 23)
        lblKey2.TabIndex = 5
        lblKey2.Text = "Harga/Bulan:"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 10.0F)
        lblHarga.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblHarga.Location = New Point(194, 168)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(17, 23)
        lblHarga.TabIndex = 6
        lblHarga.Text = "-"
        ' 
        ' lblKey3
        ' 
        lblKey3.AutoSize = True
        lblKey3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey3.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey3.Location = New Point(23, 212)
        lblKey3.Name = "lblKey3"
        lblKey3.Size = New Size(113, 23)
        lblKey3.TabIndex = 7
        lblKey3.Text = "Durasi Sewa:"
        ' 
        ' lblDurasi
        ' 
        lblDurasi.AutoSize = True
        lblDurasi.Font = New Font("Segoe UI", 10.0F)
        lblDurasi.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDurasi.Location = New Point(194, 212)
        lblDurasi.Name = "lblDurasi"
        lblDurasi.Size = New Size(17, 23)
        lblDurasi.TabIndex = 8
        lblDurasi.Text = "-"
        ' 
        ' lblKey4
        ' 
        lblKey4.AutoSize = True
        lblKey4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey4.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey4.Location = New Point(23, 256)
        lblKey4.Name = "lblKey4"
        lblKey4.Size = New Size(108, 23)
        lblKey4.TabIndex = 9
        lblKey4.Text = "Total Harga:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10.0F)
        lblTotal.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTotal.Location = New Point(194, 256)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(17, 23)
        lblTotal.TabIndex = 10
        lblTotal.Text = "-"
        ' 
        ' lblKey5
        ' 
        lblKey5.AutoSize = True
        lblKey5.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey5.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey5.Location = New Point(23, 300)
        lblKey5.Name = "lblKey5"
        lblKey5.Size = New Size(129, 23)
        lblKey5.TabIndex = 11
        lblKey5.Text = "Tanggal Mulai:"
        ' 
        ' lblTglMulai
        ' 
        lblTglMulai.AutoSize = True
        lblTglMulai.Font = New Font("Segoe UI", 10.0F)
        lblTglMulai.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTglMulai.Location = New Point(194, 300)
        lblTglMulai.Name = "lblTglMulai"
        lblTglMulai.Size = New Size(17, 23)
        lblTglMulai.TabIndex = 12
        lblTglMulai.Text = "-"
        ' 
        ' lblKey6
        ' 
        lblKey6.AutoSize = True
        lblKey6.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey6.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey6.Location = New Point(23, 344)
        lblKey6.Name = "lblKey6"
        lblKey6.Size = New Size(138, 23)
        lblKey6.TabIndex = 13
        lblKey6.Text = "Tanggal Selesai:"
        ' 
        ' lblTglSelesai
        ' 
        lblTglSelesai.AutoSize = True
        lblTglSelesai.Font = New Font("Segoe UI", 10.0F)
        lblTglSelesai.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTglSelesai.Location = New Point(194, 344)
        lblTglSelesai.Name = "lblTglSelesai"
        lblTglSelesai.Size = New Size(17, 23)
        lblTglSelesai.TabIndex = 14
        lblTglSelesai.Text = "-"
        ' 
        ' lblKey7
        ' 
        lblKey7.AutoSize = True
        lblKey7.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey7.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey7.Location = New Point(23, 388)
        lblKey7.Name = "lblKey7"
        lblKey7.Size = New Size(89, 23)
        lblKey7.TabIndex = 15
        lblKey7.Text = "Deskripsi:"
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.Font = New Font("Segoe UI", 10.0F)
        lblDeskripsi.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDeskripsi.Location = New Point(194, 388)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(17, 23)
        lblDeskripsi.TabIndex = 16
        lblDeskripsi.Text = "-"
        ' 
        ' lblKey8
        ' 
        lblKey8.AutoSize = True
        lblKey8.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblKey8.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblKey8.Location = New Point(23, 432)
        lblKey8.Name = "lblKey8"
        lblKey8.Size = New Size(65, 23)
        lblKey8.TabIndex = 17
        lblKey8.Text = "Status:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.0F)
        lblStatus.ForeColor = Color.FromArgb(CByte(40), CByte(160), CByte(80))
        lblStatus.Location = New Point(194, 432)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(17, 23)
        lblStatus.TabIndex = 18
        lblStatus.Text = "-"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(40), CByte(160), CByte(80))
        btnCetak.Cursor = Cursors.Hand
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(27, 487)
        btnCetak.Margin = New Padding(3, 4, 3, 4)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(183, 47)
        btnCetak.TabIndex = 19
        btnCetak.Text = "🖨️ Cetak Struk"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' pnlTidakAdaPesan
        ' 
        pnlTidakAdaPesan.BackColor = Color.White
        pnlTidakAdaPesan.Controls.Add(lblTidakAda)
        pnlTidakAdaPesan.Controls.Add(lblSaran)
        pnlTidakAdaPesan.Location = New Point(23, 27)
        pnlTidakAdaPesan.Margin = New Padding(3, 4, 3, 4)
        pnlTidakAdaPesan.Name = "pnlTidakAdaPesan"
        pnlTidakAdaPesan.Padding = New Padding(23, 27, 23, 27)
        pnlTidakAdaPesan.Size = New Size(514, 240)
        pnlTidakAdaPesan.TabIndex = 1
        ' 
        ' lblTidakAda
        ' 
        lblTidakAda.AutoSize = True
        lblTidakAda.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTidakAda.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        lblTidakAda.Location = New Point(23, 40)
        lblTidakAda.Name = "lblTidakAda"
        lblTidakAda.Size = New Size(329, 32)
        lblTidakAda.TabIndex = 0
        lblTidakAda.Text = "🏠  Belum Ada Kamar Aktif"
        ' 
        ' lblSaran
        ' 
        lblSaran.AutoSize = True
        lblSaran.Font = New Font("Segoe UI", 10.0F)
        lblSaran.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        lblSaran.Location = New Point(23, 100)
        lblSaran.Name = "lblSaran"
        lblSaran.Size = New Size(389, 23)
        lblSaran.TabIndex = 1
        lblSaran.Text = "Klik tombol 'Pesan Kamar' untuk menyewa kamar."
        ' 
        ' docPrint
        ' 
        ' 
        ' dialogPrint
        ' 
        dialogPrint.AutoScrollMargin = New Size(0, 0)
        dialogPrint.AutoScrollMinSize = New Size(0, 0)
        dialogPrint.ClientSize = New Size(400, 300)
        dialogPrint.Enabled = True
        dialogPrint.Icon = CType(resources.GetObject("dialogPrint.Icon"), Icon)
        dialogPrint.Name = "dialogPrint"
        dialogPrint.Visible = False
        ' 
        ' FormDashboardUser
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 747)
        Controls.Add(pnlContent)
        Controls.Add(pnlNav)
        Controls.Add(pnlHeader)
        Controls.Add(MainMenu)
        MainMenuStrip = MainMenu
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(740, 651)
        Name = "FormDashboardUser"
        StartPosition = FormStartPosition.CenterParent
        Text = "Dashboard - Sistem Kost"
        MainMenu.ResumeLayout(False)
        MainMenu.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlNav.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlKamarInfo.ResumeLayout(False)
        pnlKamarInfo.PerformLayout()
        pnlTidakAdaPesan.ResumeLayout(False)
        pnlTidakAdaPesan.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents mnuSep As ToolStripSeparator
    Friend WithEvents lblKey0 As Label
    Friend WithEvents lblKey1 As Label
    Friend WithEvents lblKey2 As Label
    Friend WithEvents lblKey3 As Label
    Friend WithEvents lblKey4 As Label
    Friend WithEvents lblKey5 As Label
    Friend WithEvents lblKey6 As Label
    Friend WithEvents lblKey7 As Label
    Friend WithEvents lblKey8 As Label

End Class