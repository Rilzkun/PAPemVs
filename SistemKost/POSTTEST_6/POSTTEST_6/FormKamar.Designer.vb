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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblTitle = New Label()
        btnTutup = New Button()
        pnlInput = New Panel()
        grpData = New GroupBox()
        lblNomor = New Label()
        txtNomor = New TextBox()
        lblTipe = New Label()
        cmbTipe = New ComboBox()
        lblHarga = New Label()
        txtHarga = New TextBox()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        grpDesk = New GroupBox()
        lblDeskripsi = New Label()
        txtDeskripsi = New TextBox()
        grpAksi = New GroupBox()
        btnTambah = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        grpCari = New GroupBox()
        lblCari = New Label()
        txtCari = New TextBox()
        dgvKamar = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlInput.SuspendLayout()
        grpData.SuspendLayout()
        grpDesk.SuspendLayout()
        grpAksi.SuspendLayout()
        grpCari.SuspendLayout()
        CType(dgvKamar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(btnTutup)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1029, 73)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(17, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(250, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "🏠  Manajemen Kamar"
        ' 
        ' btnTutup
        ' 
        btnTutup.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTutup.BackColor = Color.FromArgb(CByte(200), CByte(60), CByte(60))
        btnTutup.Cursor = Cursors.Hand
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(926, 17)
        btnTutup.Margin = New Padding(3, 4, 3, 4)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(80, 37)
        btnTutup.TabIndex = 1
        btnTutup.Text = "✕  Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlInput
        ' 
        pnlInput.BackColor = Color.White
        pnlInput.Controls.Add(grpData)
        pnlInput.Controls.Add(grpDesk)
        pnlInput.Controls.Add(grpAksi)
        pnlInput.Controls.Add(grpCari)
        pnlInput.Dock = DockStyle.Left
        pnlInput.Location = New Point(0, 73)
        pnlInput.Margin = New Padding(3, 4, 3, 4)
        pnlInput.Name = "pnlInput"
        pnlInput.Padding = New Padding(11, 13, 11, 13)
        pnlInput.Size = New Size(320, 727)
        pnlInput.TabIndex = 1
        ' 
        ' grpData
        ' 
        grpData.Controls.Add(lblNomor)
        grpData.Controls.Add(txtNomor)
        grpData.Controls.Add(lblTipe)
        grpData.Controls.Add(cmbTipe)
        grpData.Controls.Add(lblHarga)
        grpData.Controls.Add(txtHarga)
        grpData.Controls.Add(lblStatus)
        grpData.Controls.Add(cmbStatus)
        grpData.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        grpData.ForeColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        grpData.Location = New Point(11, 13)
        grpData.Margin = New Padding(3, 4, 3, 4)
        grpData.Name = "grpData"
        grpData.Padding = New Padding(3, 4, 3, 4)
        grpData.Size = New Size(291, 320)
        grpData.TabIndex = 0
        grpData.TabStop = False
        grpData.Text = "Data Kamar"
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.Font = New Font("Segoe UI", 9F)
        lblNomor.Location = New Point(11, 29)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(103, 20)
        lblNomor.TabIndex = 0
        lblNomor.Text = "Nomor Kamar"
        ' 
        ' txtNomor
        ' 
        txtNomor.BorderStyle = BorderStyle.FixedSingle
        txtNomor.CharacterCasing = CharacterCasing.Upper
        txtNomor.Font = New Font("Segoe UI", 10F)
        txtNomor.Location = New Point(11, 53)
        txtNomor.Margin = New Padding(3, 4, 3, 4)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(263, 30)
        txtNomor.TabIndex = 1
        ' 
        ' lblTipe
        ' 
        lblTipe.AutoSize = True
        lblTipe.Font = New Font("Segoe UI", 9F)
        lblTipe.Location = New Point(11, 103)
        lblTipe.Name = "lblTipe"
        lblTipe.Size = New Size(200, 20)
        lblTipe.TabIndex = 2
        lblTipe.Text = "Tipe Kamar (harga otomatis)"
        ' 
        ' cmbTipe
        ' 
        cmbTipe.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipe.Font = New Font("Segoe UI", 10F)
        cmbTipe.Location = New Point(11, 127)
        cmbTipe.Margin = New Padding(3, 4, 3, 4)
        cmbTipe.Name = "cmbTipe"
        cmbTipe.Size = New Size(262, 31)
        cmbTipe.TabIndex = 3
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 9F)
        lblHarga.Location = New Point(11, 176)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(149, 20)
        lblHarga.TabIndex = 4
        lblHarga.Text = "Harga per Bulan (Rp)"
        ' 
        ' txtHarga
        ' 
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.Font = New Font("Segoe UI", 10F)
        txtHarga.Location = New Point(11, 200)
        txtHarga.Margin = New Padding(3, 4, 3, 4)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(263, 30)
        txtHarga.TabIndex = 5
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9F)
        lblStatus.Location = New Point(11, 249)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(96, 20)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status Kamar"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Font = New Font("Segoe UI", 10F)
        cmbStatus.Location = New Point(11, 273)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(262, 31)
        cmbStatus.TabIndex = 7
        ' 
        ' grpDesk
        ' 
        grpDesk.Controls.Add(lblDeskripsi)
        grpDesk.Controls.Add(txtDeskripsi)
        grpDesk.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        grpDesk.ForeColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        grpDesk.Location = New Point(11, 344)
        grpDesk.Margin = New Padding(3, 4, 3, 4)
        grpDesk.Name = "grpDesk"
        grpDesk.Padding = New Padding(3, 4, 3, 4)
        grpDesk.Size = New Size(291, 87)
        grpDesk.TabIndex = 1
        grpDesk.TabStop = False
        grpDesk.Text = "Deskripsi"
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.Font = New Font("Segoe UI", 9F)
        lblDeskripsi.Location = New Point(11, 24)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(0, 20)
        lblDeskripsi.TabIndex = 0
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Font = New Font("Segoe UI", 9F)
        txtDeskripsi.Location = New Point(11, 33)
        txtDeskripsi.Margin = New Padding(3, 4, 3, 4)
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(263, 27)
        txtDeskripsi.TabIndex = 1
        ' 
        ' grpAksi
        ' 
        grpAksi.Controls.Add(btnTambah)
        grpAksi.Controls.Add(btnUbah)
        grpAksi.Controls.Add(btnHapus)
        grpAksi.Controls.Add(btnBatal)
        grpAksi.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        grpAksi.ForeColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        grpAksi.Location = New Point(11, 440)
        grpAksi.Margin = New Padding(3, 4, 3, 4)
        grpAksi.Name = "grpAksi"
        grpAksi.Padding = New Padding(3, 4, 3, 4)
        grpAksi.Size = New Size(291, 160)
        grpAksi.TabIndex = 2
        grpAksi.TabStop = False
        grpAksi.Text = "Aksi"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        btnTambah.Cursor = Cursors.Hand
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(11, 29)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(123, 47)
        btnTambah.TabIndex = 0
        btnTambah.Text = "➕  Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(180), CByte(120), CByte(0))
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(149, 29)
        btnUbah.Margin = New Padding(3, 4, 3, 4)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(123, 47)
        btnUbah.TabIndex = 1
        btnUbah.Text = "✏️  Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(180), CByte(40), CByte(40))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(11, 91)
        btnHapus.Margin = New Padding(3, 4, 3, 4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(123, 47)
        btnHapus.TabIndex = 2
        btnHapus.Text = "🗑️  Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.White
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderColor = Color.Gray
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F)
        btnBatal.ForeColor = Color.Gray
        btnBatal.Location = New Point(149, 91)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(123, 47)
        btnBatal.TabIndex = 3
        btnBatal.Text = "✖  Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' grpCari
        ' 
        grpCari.Controls.Add(lblCari)
        grpCari.Controls.Add(txtCari)
        grpCari.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        grpCari.ForeColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        grpCari.Location = New Point(11, 613)
        grpCari.Margin = New Padding(3, 4, 3, 4)
        grpCari.Name = "grpCari"
        grpCari.Padding = New Padding(3, 4, 3, 4)
        grpCari.Size = New Size(291, 87)
        grpCari.TabIndex = 3
        grpCari.TabStop = False
        grpCari.Text = "Pencarian"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI", 9F)
        lblCari.Location = New Point(11, 37)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(38, 20)
        lblCari.TabIndex = 0
        lblCari.Text = "Cari:"
        ' 
        ' txtCari
        ' 
        txtCari.BorderStyle = BorderStyle.FixedSingle
        txtCari.Font = New Font("Segoe UI", 10F)
        txtCari.Location = New Point(55, 33)
        txtCari.Margin = New Padding(3, 4, 3, 4)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(219, 30)
        txtCari.TabIndex = 1
        ' 
        ' dgvKamar
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(245), CByte(248), CByte(255))
        dgvKamar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvKamar.BackgroundColor = Color.White
        dgvKamar.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvKamar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvKamar.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvKamar.DefaultCellStyle = DataGridViewCellStyle3
        dgvKamar.Dock = DockStyle.Fill
        dgvKamar.EnableHeadersVisualStyles = False
        dgvKamar.GridColor = Color.FromArgb(CByte(220), CByte(228), CByte(240))
        dgvKamar.Location = New Point(320, 73)
        dgvKamar.Margin = New Padding(6, 7, 6, 7)
        dgvKamar.Name = "dgvKamar"
        dgvKamar.RowHeadersVisible = False
        dgvKamar.RowHeadersWidth = 51
        dgvKamar.Size = New Size(709, 727)
        dgvKamar.TabIndex = 0
        ' 
        ' FormKamar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 800)
        Controls.Add(dgvKamar)
        Controls.Add(pnlInput)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(912, 718)
        Name = "FormKamar"
        StartPosition = FormStartPosition.CenterParent
        Text = "Manajemen Kamar - Sistem Kost"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlInput.ResumeLayout(False)
        grpData.ResumeLayout(False)
        grpData.PerformLayout()
        grpDesk.ResumeLayout(False)
        grpDesk.PerformLayout()
        grpAksi.ResumeLayout(False)
        grpCari.ResumeLayout(False)
        grpCari.PerformLayout()
        CType(dgvKamar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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