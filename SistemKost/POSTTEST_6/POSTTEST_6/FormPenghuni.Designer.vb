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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lblInfoTerpilih = New System.Windows.Forms.Label()
        Me.grpAksi = New System.Windows.Forms.GroupBox()
        Me.lblDurasi = New System.Windows.Forms.Label()
        Me.nudDurasi = New System.Windows.Forms.NumericUpDown()
        Me.btnEditDurasi = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.dgvPenghuni = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.grpAksi.SuspendLayout()
        CType(Me.nudDurasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPenghuni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CByte(40), CByte(120), CByte(80))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnTutup)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1097, 73)
        Me.pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(17, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "👥  Manajemen Penghuni"
        ' 
        ' btnTutup
        ' 
        Me.btnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CByte(200), CByte(60), CByte(60))
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(994, 17)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(80, 37)
        Me.btnTutup.TabIndex = 1
        Me.btnTutup.Text = "✕  Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        ' 
        ' pnlBottom
        ' 
        Me.pnlBottom.BackColor = System.Drawing.Color.White
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottom.Controls.Add(Me.lblInfoTerpilih)
        Me.pnlBottom.Controls.Add(Me.grpAksi)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 641)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Padding = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.pnlBottom.Size = New System.Drawing.Size(1097, 159)
        Me.pnlBottom.TabIndex = 1
        ' 
        ' lblInfoTerpilih
        ' 
        Me.lblInfoTerpilih.AutoSize = True
        Me.lblInfoTerpilih.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblInfoTerpilih.ForeColor = System.Drawing.Color.FromArgb(CByte(80), CByte(80), CByte(80))
        Me.lblInfoTerpilih.Location = New System.Drawing.Point(11, 11)
        Me.lblInfoTerpilih.Name = "lblInfoTerpilih"
        Me.lblInfoTerpilih.Size = New System.Drawing.Size(213, 20)
        Me.lblInfoTerpilih.TabIndex = 0
        Me.lblInfoTerpilih.Text = "Pilih penghuni dari tabel di atas"
        ' 
        ' grpAksi
        ' 
        Me.grpAksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAksi.Controls.Add(Me.lblDurasi)
        Me.grpAksi.Controls.Add(Me.nudDurasi)
        Me.grpAksi.Controls.Add(Me.btnEditDurasi)
        Me.grpAksi.Controls.Add(Me.btnCheckout)
        Me.grpAksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpAksi.ForeColor = System.Drawing.Color.FromArgb(CByte(40), CByte(120), CByte(80))
        Me.grpAksi.Location = New System.Drawing.Point(11, 33)
        Me.grpAksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAksi.Name = "grpAksi"
        Me.grpAksi.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAksi.Size = New System.Drawing.Size(1063, 107)
        Me.grpAksi.TabIndex = 1
        Me.grpAksi.TabStop = False
        Me.grpAksi.Text = "Aksi Penghuni"
        ' 
        ' lblDurasi
        ' 
        Me.lblDurasi.AutoSize = True
        Me.lblDurasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDurasi.Location = New System.Drawing.Point(11, 33)
        Me.lblDurasi.Name = "lblDurasi"
        Me.lblDurasi.Size = New System.Drawing.Size(144, 20)
        Me.lblDurasi.TabIndex = 0
        Me.lblDurasi.Text = "Ubah Durasi (bulan):"
        ' 
        ' nudDurasi
        ' 
        Me.nudDurasi.Location = New System.Drawing.Point(171, 29)
        Me.nudDurasi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudDurasi.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.nudDurasi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDurasi.Name = "nudDurasi"
        Me.nudDurasi.Size = New System.Drawing.Size(69, 27)
        Me.nudDurasi.TabIndex = 1
        Me.nudDurasi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnEditDurasi
        ' 
        Me.btnEditDurasi.BackColor = System.Drawing.Color.FromArgb(CByte(180), CByte(120), CByte(0))
        Me.btnEditDurasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDurasi.FlatAppearance.BorderSize = 0
        Me.btnEditDurasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditDurasi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditDurasi.ForeColor = System.Drawing.Color.White
        Me.btnEditDurasi.Location = New System.Drawing.Point(257, 24)
        Me.btnEditDurasi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditDurasi.Name = "btnEditDurasi"
        Me.btnEditDurasi.Size = New System.Drawing.Size(149, 47)
        Me.btnEditDurasi.TabIndex = 2
        Me.btnEditDurasi.Text = "✏️  Edit Durasi"
        Me.btnEditDurasi.UseVisualStyleBackColor = False
        ' 
        ' btnCheckout
        ' 
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CByte(160), CByte(40), CByte(40))
        Me.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(417, 24)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(149, 47)
        Me.btnCheckout.TabIndex = 3
        Me.btnCheckout.Text = "🚪  Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' dgvPenghuni
        ' 
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CByte(245), CByte(255), CByte(250))
        Me.dgvPenghuni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPenghuni.BackgroundColor = System.Drawing.Color.White
        Me.dgvPenghuni.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CByte(40), CByte(120), CByte(80))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPenghuni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPenghuni.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPenghuni.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPenghuni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPenghuni.EnableHeadersVisualStyles = False
        Me.dgvPenghuni.GridColor = System.Drawing.Color.FromArgb(CByte(220), CByte(240), CByte(228))
        Me.dgvPenghuni.Location = New System.Drawing.Point(0, 73)
        Me.dgvPenghuni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPenghuni.Name = "dgvPenghuni"
        Me.dgvPenghuni.RowHeadersVisible = False
        Me.dgvPenghuni.RowHeadersWidth = 51
        Me.dgvPenghuni.Size = New System.Drawing.Size(1097, 568)
        Me.dgvPenghuni.TabIndex = 0
        ' 
        ' FormPenghuni
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 800)
        Me.Controls.Add(Me.dgvPenghuni)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlHeader)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(912, 651)
        Me.Name = "FormPenghuni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manajemen Penghuni - Sistem Kost"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.grpAksi.ResumeLayout(False)
        Me.grpAksi.PerformLayout()
        CType(Me.nudDurasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPenghuni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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

End Class