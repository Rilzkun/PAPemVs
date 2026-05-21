<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenghuni
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
        pnlBottom = New Panel()
        lblInfoTerpilih = New Label()
        grpAksi = New GroupBox()
        lblDurasi = New Label()
        nudDurasi = New NumericUpDown()
        btnEditDurasi = New Button()
        btnCheckout = New Button()
        btnRefresh = New Button()
        dgvPenghuni = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlBottom.SuspendLayout()
        grpAksi.SuspendLayout()
        CType(nudDurasi, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPenghuni, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(40), CByte(120), CByte(80))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(btnTutup)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1097, 73)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(17, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(280, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "👥  Manajemen Penghuni"
        ' 
        ' btnTutup
        ' 
        btnTutup.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTutup.BackColor = Color.FromArgb(CByte(200), CByte(60), CByte(60))
        btnTutup.Cursor = Cursors.Hand
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(994, 17)
        btnTutup.Margin = New Padding(3, 4, 3, 4)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(80, 37)
        btnTutup.TabIndex = 1
        btnTutup.Text = "✕  Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlBottom
        ' 
        pnlBottom.BackColor = Color.White
        pnlBottom.BorderStyle = BorderStyle.FixedSingle
        pnlBottom.Controls.Add(lblInfoTerpilih)
        pnlBottom.Controls.Add(grpAksi)
        pnlBottom.Dock = DockStyle.Bottom
        pnlBottom.Location = New Point(0, 641)
        pnlBottom.Margin = New Padding(3, 4, 3, 4)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Padding = New Padding(11, 7, 11, 7)
        pnlBottom.Size = New Size(1097, 159)
        pnlBottom.TabIndex = 1
        ' 
        ' lblInfoTerpilih
        ' 
        lblInfoTerpilih.AutoSize = True
        lblInfoTerpilih.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblInfoTerpilih.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblInfoTerpilih.Location = New Point(11, 11)
        lblInfoTerpilih.Name = "lblInfoTerpilih"
        lblInfoTerpilih.Size = New Size(213, 20)
        lblInfoTerpilih.TabIndex = 0
        lblInfoTerpilih.Text = "Pilih penghuni dari tabel di atas"
        ' 
        ' grpAksi
        ' 
        grpAksi.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpAksi.Controls.Add(lblDurasi)
        grpAksi.Controls.Add(nudDurasi)
        grpAksi.Controls.Add(btnEditDurasi)
        grpAksi.Controls.Add(btnCheckout)
        grpAksi.Controls.Add(btnRefresh)
        grpAksi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        grpAksi.ForeColor = Color.FromArgb(CByte(40), CByte(120), CByte(80))
        grpAksi.Location = New Point(11, 33)
        grpAksi.Margin = New Padding(3, 4, 3, 4)
        grpAksi.Name = "grpAksi"
        grpAksi.Padding = New Padding(3, 4, 3, 4)
        grpAksi.Size = New Size(1063, 107)
        grpAksi.TabIndex = 1
        grpAksi.TabStop = False
        grpAksi.Text = "Aksi Penghuni"
        ' 
        ' lblDurasi
        ' 
        lblDurasi.AutoSize = True
        lblDurasi.Font = New Font("Segoe UI", 9.0F)
        lblDurasi.Location = New Point(11, 33)
        lblDurasi.Name = "lblDurasi"
        lblDurasi.Size = New Size(144, 20)
        lblDurasi.TabIndex = 0
        lblDurasi.Text = "Ubah Durasi (bulan):"
        ' 
        ' nudDurasi
        ' 
        nudDurasi.Location = New Point(171, 29)
        nudDurasi.Margin = New Padding(3, 4, 3, 4)
        nudDurasi.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        nudDurasi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudDurasi.Name = "nudDurasi"
        nudDurasi.Size = New Size(69, 27)
        nudDurasi.TabIndex = 1
        nudDurasi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnEditDurasi
        ' 
        btnEditDurasi.BackColor = Color.FromArgb(CByte(180), CByte(120), CByte(0))
        btnEditDurasi.Cursor = Cursors.Hand
        btnEditDurasi.FlatAppearance.BorderSize = 0
        btnEditDurasi.FlatStyle = FlatStyle.Flat
        btnEditDurasi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEditDurasi.ForeColor = Color.White
        btnEditDurasi.Location = New Point(257, 24)
        btnEditDurasi.Margin = New Padding(3, 4, 3, 4)
        btnEditDurasi.Name = "btnEditDurasi"
        btnEditDurasi.Size = New Size(149, 47)
        btnEditDurasi.TabIndex = 2
        btnEditDurasi.Text = "✏️  Edit Durasi"
        btnEditDurasi.UseVisualStyleBackColor = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.FromArgb(CByte(160), CByte(40), CByte(40))
        btnCheckout.Cursor = Cursors.Hand
        btnCheckout.FlatAppearance.BorderSize = 0
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnCheckout.ForeColor = Color.White
        btnCheckout.Location = New Point(417, 24)
        btnCheckout.Margin = New Padding(3, 4, 3, 4)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(149, 47)
        btnCheckout.TabIndex = 3
        btnCheckout.Text = "🚪  Checkout"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(160))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.0F)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(577, 24)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(114, 47)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "🔄  Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvPenghuni
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(245), CByte(255), CByte(250))
        dgvPenghuni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPenghuni.BackgroundColor = Color.White
        dgvPenghuni.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(40), CByte(120), CByte(80))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPenghuni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPenghuni.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvPenghuni.DefaultCellStyle = DataGridViewCellStyle3
        dgvPenghuni.Dock = DockStyle.Fill
        dgvPenghuni.EnableHeadersVisualStyles = False
        dgvPenghuni.GridColor = Color.FromArgb(CByte(220), CByte(240), CByte(228))
        dgvPenghuni.Location = New Point(0, 73)
        dgvPenghuni.Margin = New Padding(3, 4, 3, 4)
        dgvPenghuni.Name = "dgvPenghuni"
        dgvPenghuni.RowHeadersVisible = False
        dgvPenghuni.RowHeadersWidth = 51
        dgvPenghuni.Size = New Size(1097, 568)
        dgvPenghuni.TabIndex = 0
        ' 
        ' FormPenghuni
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1097, 800)
        Controls.Add(dgvPenghuni)
        Controls.Add(pnlBottom)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(912, 651)
        Name = "FormPenghuni"
        StartPosition = FormStartPosition.CenterParent
        Text = "Manajemen Penghuni - Sistem Kost"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBottom.ResumeLayout(False)
        pnlBottom.PerformLayout()
        grpAksi.ResumeLayout(False)
        grpAksi.PerformLayout()
        CType(nudDurasi, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPenghuni, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents dgvPenghuni As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents lblInfoTerpilih As System.Windows.Forms.Label
    Friend WithEvents grpAksi As System.Windows.Forms.GroupBox
    Friend WithEvents lblDurasi As System.Windows.Forms.Label
    Friend WithEvents nudDurasi As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnEditDurasi As System.Windows.Forms.Button
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button

End Class