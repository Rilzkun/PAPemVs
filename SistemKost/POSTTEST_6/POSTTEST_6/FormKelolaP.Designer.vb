<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKelolaP
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblListPesan = New System.Windows.Forms.Label()
        Me.dgvPesan = New System.Windows.Forms.DataGridView()
        Me.lblInfoTerpilih = New System.Windows.Forms.Label()
        Me.pnlAksi = New System.Windows.Forms.Panel()
        Me.lblDurasi = New System.Windows.Forms.Label()
        Me.nudDurasi = New System.Windows.Forms.NumericUpDown()
        Me.lblBulan = New System.Windows.Forms.Label()
        Me.btnEditDurasi = New System.Windows.Forms.Button()
        Me.btnBatalkan = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()

        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvPesan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAksi.SuspendLayout()
        CType(Me.nudDurasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(142, 68, 173)
        Me.pnlTop.Controls.Add(Me.lblSub)
        Me.pnlTop.Controls.Add(Me.lblJudul)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Height = 70
        Me.pnlTop.Padding = New System.Windows.Forms.Padding(15, 10, 10, 5)

        ' lblJudul
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.Location = New System.Drawing.Point(15, 10)
        Me.lblJudul.Text = "Kelola Pesanan Saya"

        ' lblSub
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSub.ForeColor = System.Drawing.Color.FromArgb(220, 200, 240)
        Me.lblSub.Location = New System.Drawing.Point(17, 40)
        Me.lblSub.Text = "Edit durasi atau batalkan pesanan Anda"

        ' pnlMain
        Me.pnlMain.Controls.Add(Me.lblListPesan)
        Me.pnlMain.Controls.Add(Me.dgvPesan)
        Me.pnlMain.Controls.Add(Me.lblInfoTerpilih)
        Me.pnlMain.Controls.Add(Me.pnlAksi)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)

        ' lblListPesan
        Me.lblListPesan.AutoSize = True
        Me.lblListPesan.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.lblListPesan.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.lblListPesan.Location = New System.Drawing.Point(10, 12)
        Me.lblListPesan.Text = "Riwayat Pesanan Saya"

        ' dgvPesan
        Me.dgvPesan.Location = New System.Drawing.Point(10, 36)
        Me.dgvPesan.Size = New System.Drawing.Size(820, 240)
        Me.dgvPesan.BackgroundColor = System.Drawing.Color.White
        Me.dgvPesan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvPesan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesan.RowHeadersVisible = False
        Me.dgvPesan.Font = New System.Drawing.Font("Segoe UI", 9)

        ' lblInfoTerpilih
        Me.lblInfoTerpilih.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic)
        Me.lblInfoTerpilih.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblInfoTerpilih.Location = New System.Drawing.Point(10, 284)
        Me.lblInfoTerpilih.Size = New System.Drawing.Size(820, 22)
        Me.lblInfoTerpilih.Text = "Pilih pesanan dari tabel di atas"

        ' pnlAksi
        Me.pnlAksi.BackColor = System.Drawing.Color.FromArgb(245, 248, 252)
        Me.pnlAksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAksi.Controls.Add(Me.lblDurasi)
        Me.pnlAksi.Controls.Add(Me.nudDurasi)
        Me.pnlAksi.Controls.Add(Me.lblBulan)
        Me.pnlAksi.Controls.Add(Me.btnEditDurasi)
        Me.pnlAksi.Controls.Add(Me.btnBatalkan)
        Me.pnlAksi.Enabled = False
        Me.pnlAksi.Location = New System.Drawing.Point(10, 312)
        Me.pnlAksi.Size = New System.Drawing.Size(820, 60)
        Me.pnlAksi.Padding = New System.Windows.Forms.Padding(8)

        ' lblDurasi
        Me.lblDurasi.AutoSize = True
        Me.lblDurasi.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblDurasi.Location = New System.Drawing.Point(10, 18)
        Me.lblDurasi.Text = "Ubah Durasi:"

        ' nudDurasi
        Me.nudDurasi.Location = New System.Drawing.Point(100, 14)
        Me.nudDurasi.Size = New System.Drawing.Size(70, 26)
        Me.nudDurasi.Font = New System.Drawing.Font("Segoe UI", 10)

        ' lblBulan
        Me.lblBulan.AutoSize = True
        Me.lblBulan.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblBulan.Location = New System.Drawing.Point(176, 18)
        Me.lblBulan.Text = "bulan"

        ' btnEditDurasi
        Me.btnEditDurasi.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnEditDurasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditDurasi.FlatAppearance.BorderSize = 0
        Me.btnEditDurasi.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnEditDurasi.ForeColor = System.Drawing.Color.White
        Me.btnEditDurasi.Location = New System.Drawing.Point(236, 12)
        Me.btnEditDurasi.Size = New System.Drawing.Size(140, 34)
        Me.btnEditDurasi.Text = "✏ Simpan Durasi"
        Me.btnEditDurasi.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnBatalkan
        Me.btnBatalkan.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnBatalkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatalkan.FlatAppearance.BorderSize = 0
        Me.btnBatalkan.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnBatalkan.ForeColor = System.Drawing.Color.White
        Me.btnBatalkan.Location = New System.Drawing.Point(384, 12)
        Me.btnBatalkan.Size = New System.Drawing.Size(140, 34)
        Me.btnBatalkan.Text = "✕ Batalkan Pesanan"
        Me.btnBatalkan.Cursor = System.Windows.Forms.Cursors.Hand

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.pnlBottom.Controls.Add(Me.btnTutup)
        Me.pnlBottom.Controls.Add(Me.btnRefresh)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Height = 50
        Me.pnlBottom.Padding = New System.Windows.Forms.Padding(8)

        ' btnRefresh
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(8, 8)
        Me.btnRefresh.Size = New System.Drawing.Size(100, 32)
        Me.btnRefresh.Text = "↻ Refresh"
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnTutup
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(116, 8)
        Me.btnTutup.Size = New System.Drawing.Size(100, 32)
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand

        ' FormKelolaP
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(860, 510)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kelola Pesanan Saya"

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.dgvPesan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAksi.ResumeLayout(False)
        Me.pnlAksi.PerformLayout()
        CType(Me.nudDurasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblListPesan As System.Windows.Forms.Label
    Friend WithEvents dgvPesan As System.Windows.Forms.DataGridView
    Friend WithEvents lblInfoTerpilih As System.Windows.Forms.Label
    Friend WithEvents pnlAksi As System.Windows.Forms.Panel
    Friend WithEvents lblDurasi As System.Windows.Forms.Label
    Friend WithEvents nudDurasi As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBulan As System.Windows.Forms.Label
    Friend WithEvents btnEditDurasi As System.Windows.Forms.Button
    Friend WithEvents btnBatalkan As System.Windows.Forms.Button
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class
