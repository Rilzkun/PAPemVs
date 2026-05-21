<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPemesanan
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
        Me.dgvKamar = New System.Windows.Forms.DataGridView()
        Me.pnlOrder = New System.Windows.Forms.Panel()
        Me.lblKamarDipilihTitle = New System.Windows.Forms.Label()
        Me.lblKamarDipilih = New System.Windows.Forms.Label()
        Me.lblDurasiTitle = New System.Windows.Forms.Label()
        Me.nudDurasi = New System.Windows.Forms.NumericUpDown()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.lblTglMulaiTitle = New System.Windows.Forms.Label()
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.lblListKamar = New System.Windows.Forms.Label()

        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrder.SuspendLayout()
        CType(Me.nudDurasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
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
        Me.lblJudul.Text = "Pemesanan Kamar Baru"

        ' lblSub
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSub.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255)
        Me.lblSub.Location = New System.Drawing.Point(17, 40)
        Me.lblSub.Text = "Pilih kamar tersedia, atur durasi, lalu konfirmasi pesanan"

        ' pnlMain
        Me.pnlMain.Controls.Add(Me.pnlOrder)
        Me.pnlMain.Controls.Add(Me.dgvKamar)
        Me.pnlMain.Controls.Add(Me.lblListKamar)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)

        ' lblListKamar
        Me.lblListKamar.AutoSize = True
        Me.lblListKamar.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.lblListKamar.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.lblListKamar.Location = New System.Drawing.Point(10, 15)
        Me.lblListKamar.Text = "Daftar Kamar Tersedia"

        ' dgvKamar
        Me.dgvKamar.Location = New System.Drawing.Point(10, 38)
        Me.dgvKamar.Size = New System.Drawing.Size(560, 320)
        Me.dgvKamar.BackgroundColor = System.Drawing.Color.White
        Me.dgvKamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKamar.RowHeadersVisible = False
        Me.dgvKamar.Font = New System.Drawing.Font("Segoe UI", 9)

        ' pnlOrder
        Me.pnlOrder.BackColor = System.Drawing.Color.FromArgb(245, 248, 252)
        Me.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrder.Controls.Add(Me.lblKamarDipilihTitle)
        Me.pnlOrder.Controls.Add(Me.lblKamarDipilih)
        Me.pnlOrder.Controls.Add(Me.lblDurasiTitle)
        Me.pnlOrder.Controls.Add(Me.nudDurasi)
        Me.pnlOrder.Controls.Add(Me.lblSatuan)
        Me.pnlOrder.Controls.Add(Me.lblTglMulaiTitle)
        Me.pnlOrder.Controls.Add(Me.dtpMulai)
        Me.pnlOrder.Controls.Add(Me.lblTotalTitle)
        Me.pnlOrder.Controls.Add(Me.lblTotal)
        Me.pnlOrder.Controls.Add(Me.btnPesan)
        Me.pnlOrder.Controls.Add(Me.btnBatal)
        Me.pnlOrder.Location = New System.Drawing.Point(580, 38)
        Me.pnlOrder.Size = New System.Drawing.Size(270, 320)
        Me.pnlOrder.Padding = New System.Windows.Forms.Padding(12)

        ' lblKamarDipilihTitle
        Me.lblKamarDipilihTitle.AutoSize = True
        Me.lblKamarDipilihTitle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblKamarDipilihTitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblKamarDipilihTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblKamarDipilihTitle.Text = "KAMAR DIPILIH"

        ' lblKamarDipilih
        Me.lblKamarDipilih.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblKamarDipilih.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.lblKamarDipilih.Location = New System.Drawing.Point(12, 30)
        Me.lblKamarDipilih.Size = New System.Drawing.Size(245, 40)
        Me.lblKamarDipilih.Text = "(Pilih kamar dari tabel)"

        ' lblDurasiTitle
        Me.lblDurasiTitle.AutoSize = True
        Me.lblDurasiTitle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblDurasiTitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblDurasiTitle.Location = New System.Drawing.Point(12, 78)
        Me.lblDurasiTitle.Text = "DURASI SEWA"

        ' nudDurasi
        Me.nudDurasi.Location = New System.Drawing.Point(12, 96)
        Me.nudDurasi.Size = New System.Drawing.Size(80, 26)
        Me.nudDurasi.Font = New System.Drawing.Font("Segoe UI", 10)

        ' lblSatuan
        Me.lblSatuan.AutoSize = True
        Me.lblSatuan.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSatuan.Location = New System.Drawing.Point(98, 99)
        Me.lblSatuan.Text = "bulan (maks. 24)"

        ' lblTglMulaiTitle
        Me.lblTglMulaiTitle.AutoSize = True
        Me.lblTglMulaiTitle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblTglMulaiTitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblTglMulaiTitle.Location = New System.Drawing.Point(12, 132)
        Me.lblTglMulaiTitle.Text = "TANGGAL MULAI"

        ' dtpMulai
        Me.dtpMulai.Location = New System.Drawing.Point(12, 150)
        Me.dtpMulai.Size = New System.Drawing.Size(245, 26)
        Me.dtpMulai.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short

        ' lblTotalTitle
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblTotalTitle.Location = New System.Drawing.Point(12, 186)
        Me.lblTotalTitle.Text = "TOTAL HARGA"

        ' lblTotal
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.lblTotal.Location = New System.Drawing.Point(10, 204)
        Me.lblTotal.Size = New System.Drawing.Size(245, 32)
        Me.lblTotal.Text = "Rp 0"

        ' btnPesan
        Me.btnPesan.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesan.FlatAppearance.BorderSize = 0
        Me.btnPesan.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnPesan.ForeColor = System.Drawing.Color.White
        Me.btnPesan.Location = New System.Drawing.Point(12, 248)
        Me.btnPesan.Size = New System.Drawing.Size(120, 36)
        Me.btnPesan.Text = "✓ Pesan"
        Me.btnPesan.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnBatal
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(189, 195, 199)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(140, 248)
        Me.btnBatal.Size = New System.Drawing.Size(117, 36)
        Me.btnBatal.Text = "✕ Batal"
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand

        ' FormPemesanan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(870, 430)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pemesanan Kamar"

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrder.ResumeLayout(False)
        Me.pnlOrder.PerformLayout()
        CType(Me.nudDurasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView
    Friend WithEvents pnlOrder As System.Windows.Forms.Panel
    Friend WithEvents lblKamarDipilihTitle As System.Windows.Forms.Label
    Friend WithEvents lblKamarDipilih As System.Windows.Forms.Label
    Friend WithEvents lblDurasiTitle As System.Windows.Forms.Label
    Friend WithEvents nudDurasi As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSatuan As System.Windows.Forms.Label
    Friend WithEvents lblTglMulaiTitle As System.Windows.Forms.Label
    Friend WithEvents dtpMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnPesan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblListKamar As System.Windows.Forms.Label
End Class
