<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKamar
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
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.lblNomor = New System.Windows.Forms.Label()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.cmbTipe = New System.Windows.Forms.ComboBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.grpDesk = New System.Windows.Forms.GroupBox()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.grpAksi = New System.Windows.Forms.GroupBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.grpCari = New System.Windows.Forms.GroupBox()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.dgvKamar = New System.Windows.Forms.DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.grpDesk.SuspendLayout()
        Me.grpAksi.SuspendLayout()
        Me.grpCari.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ---- pnlHeader ----
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(900, 55)
        Me.pnlHeader.TabIndex = 0
        Me.pnlHeader.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblTitle, Me.btnTutup})

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblTitle.Text = "🏠  Manajemen Kamar"

        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(200, 60, 60)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(810, 13)
        Me.btnTutup.Size = New System.Drawing.Size(70, 28)
        Me.btnTutup.Text = "✕  Tutup"
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        ' ---- pnlInput ----
        Me.pnlInput.BackColor = System.Drawing.Color.White
        Me.pnlInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInput.Location = New System.Drawing.Point(0, 55)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlInput.Size = New System.Drawing.Size(280, 545)
        Me.pnlInput.TabIndex = 1
        Me.pnlInput.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpData, Me.grpDesk, Me.grpAksi, Me.grpCari})

        ' ---- grpData ----
        Me.grpData.Text = "Data Kamar"
        Me.grpData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpData.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.grpData.Location = New System.Drawing.Point(10, 10)
        Me.grpData.Size = New System.Drawing.Size(255, 240)
        Me.grpData.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblNomor, Me.txtNomor, Me.lblTipe, Me.cmbTipe, Me.lblHarga, Me.txtHarga, Me.lblStatus, Me.cmbStatus})

        Me.lblNomor.AutoSize = True
        Me.lblNomor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNomor.Location = New System.Drawing.Point(10, 22)
        Me.lblNomor.Text = "Nomor Kamar"

        Me.txtNomor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNomor.Location = New System.Drawing.Point(10, 40)
        Me.txtNomor.Size = New System.Drawing.Size(230, 25)
        Me.txtNomor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper

        Me.lblTipe.AutoSize = True
        Me.lblTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipe.Location = New System.Drawing.Point(10, 77)
        Me.lblTipe.Text = "Tipe Kamar (harga otomatis)"

        Me.cmbTipe.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTipe.Location = New System.Drawing.Point(10, 95)
        Me.cmbTipe.Size = New System.Drawing.Size(230, 25)
        Me.cmbTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHarga.Location = New System.Drawing.Point(10, 132)
        Me.lblHarga.Text = "Harga per Bulan (Rp)"

        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtHarga.Location = New System.Drawing.Point(10, 150)
        Me.txtHarga.Size = New System.Drawing.Size(230, 25)
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(10, 187)
        Me.lblStatus.Text = "Status Kamar"

        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.Location = New System.Drawing.Point(10, 205)
        Me.cmbStatus.Size = New System.Drawing.Size(230, 25)
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        ' ---- grpDesk ----
        Me.grpDesk.Text = "Deskripsi"
        Me.grpDesk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpDesk.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.grpDesk.Location = New System.Drawing.Point(10, 258)
        Me.grpDesk.Size = New System.Drawing.Size(255, 65)
        Me.grpDesk.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDeskripsi, Me.txtDeskripsi})

        Me.lblDeskripsi.AutoSize = True
        Me.lblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDeskripsi.Location = New System.Drawing.Point(10, 18)

        Me.txtDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDeskripsi.Location = New System.Drawing.Point(10, 25)
        Me.txtDeskripsi.Size = New System.Drawing.Size(230, 23)
        Me.txtDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' ---- grpAksi ----
        Me.grpAksi.Text = "Aksi"
        Me.grpAksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpAksi.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.grpAksi.Location = New System.Drawing.Point(10, 330)
        Me.grpAksi.Size = New System.Drawing.Size(255, 120)
        Me.grpAksi.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnTambah, Me.btnUbah, Me.btnHapus, Me.btnBatal})

        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(10, 22)
        Me.btnTambah.Size = New System.Drawing.Size(108, 35)
        Me.btnTambah.Text = "➕  Tambah"
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(180, 120, 0)
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(130, 22)
        Me.btnUbah.Size = New System.Drawing.Size(108, 35)
        Me.btnUbah.Text = "✏️  Ubah"
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(180, 40, 40)
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(10, 68)
        Me.btnHapus.Size = New System.Drawing.Size(108, 35)
        Me.btnHapus.Text = "🗑️  Hapus"
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnBatal.BackColor = System.Drawing.Color.White
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.Gray
        Me.btnBatal.Location = New System.Drawing.Point(130, 68)
        Me.btnBatal.Size = New System.Drawing.Size(108, 35)
        Me.btnBatal.Text = "✖  Batal"
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand

        ' ---- grpCari ----
        Me.grpCari.Text = "Pencarian"
        Me.grpCari.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpCari.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.grpCari.Location = New System.Drawing.Point(10, 460)
        Me.grpCari.Size = New System.Drawing.Size(255, 65)
        Me.grpCari.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCari, Me.txtCari})

        Me.lblCari.AutoSize = True
        Me.lblCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCari.Location = New System.Drawing.Point(10, 28)
        Me.lblCari.Text = "Cari:"

        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCari.Location = New System.Drawing.Point(40, 25)
        Me.txtCari.Size = New System.Drawing.Size(200, 25)
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' ---- dgvKamar ----
        Me.dgvKamar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKamar.BackgroundColor = System.Drawing.Color.White
        Me.dgvKamar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKamar.RowHeadersVisible = False
        Me.dgvKamar.EnableHeadersVisualStyles = False
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 80, 160)
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvKamar.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKamar.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 255)
        Me.dgvKamar.GridColor = System.Drawing.Color.FromArgb(220, 228, 240)
        Me.dgvKamar.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvKamar.Location = New System.Drawing.Point(280, 55)
        Me.dgvKamar.Size = New System.Drawing.Size(620, 545)

        ' ---- Form ----
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.dgvKamar)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlHeader)
        Me.MinimumSize = New System.Drawing.Size(800, 550)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manajemen Kamar - Sistem Kost"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpDesk.ResumeLayout(False)
        Me.grpDesk.PerformLayout()
        Me.grpAksi.ResumeLayout(False)
        Me.grpCari.ResumeLayout(False)
        Me.grpCari.PerformLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents grpData As System.Windows.Forms.GroupBox
    Friend WithEvents lblNomor As System.Windows.Forms.Label
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents lblTipe As System.Windows.Forms.Label
    Friend WithEvents cmbTipe As System.Windows.Forms.ComboBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents grpDesk As System.Windows.Forms.GroupBox
    Friend WithEvents lblDeskripsi As System.Windows.Forms.Label
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents grpAksi As System.Windows.Forms.GroupBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents grpCari As System.Windows.Forms.GroupBox
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView

End Class