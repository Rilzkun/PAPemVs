Imports System.Data

Public Class FormKelolaP

    Dim idPesanTerpilih As Integer = 0
    Dim idKamarTerpilih As Integer = 0
    Dim statusPesanTerpilih As String = ""

    ' ---- Load ----
    Private Sub FormKelolaP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudDurasi.Minimum = 1
        nudDurasi.Maximum = 24
        TampilData()
    End Sub

    ' ---- Tampil data pesanan milik user yang login ----
    Private Sub TampilData()
        Dim dt As DataTable = GetPemesananByUser(SessionModule.IdUser)
        dgvPesan.DataSource = dt
        dgvPesan.ReadOnly = True
        dgvPesan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPesan.AllowUserToAddRows = False
        dgvPesan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPesan.MultiSelect = False

        If dgvPesan.Columns.Contains("idPesan") Then dgvPesan.Columns("idPesan").HeaderText = "ID"
        If dgvPesan.Columns.Contains("nomorKamar") Then dgvPesan.Columns("nomorKamar").HeaderText = "No. Kamar"
        If dgvPesan.Columns.Contains("tipeKamar") Then dgvPesan.Columns("tipeKamar").HeaderText = "Tipe"
        If dgvPesan.Columns.Contains("hargaKamar") Then dgvPesan.Columns("hargaKamar").HeaderText = "Harga/Bln"
        If dgvPesan.Columns.Contains("durasi") Then dgvPesan.Columns("durasi").HeaderText = "Durasi (Bln)"
        If dgvPesan.Columns.Contains("totalHarga") Then dgvPesan.Columns("totalHarga").HeaderText = "Total Harga"
        If dgvPesan.Columns.Contains("tanggalMulai") Then dgvPesan.Columns("tanggalMulai").HeaderText = "Tgl Mulai"
        If dgvPesan.Columns.Contains("tanggalSelesai") Then dgvPesan.Columns("tanggalSelesai").HeaderText = "Tgl Selesai"
        If dgvPesan.Columns.Contains("statusPesan") Then dgvPesan.Columns("statusPesan").HeaderText = "Status"

        ' Reset panel aksi
        pnlAksi.Enabled = False
        lblInfoTerpilih.Text = "Pilih pesanan dari tabel di atas"
        idPesanTerpilih = 0
        idKamarTerpilih = 0
        statusPesanTerpilih = ""
    End Sub

    ' ---- Pilih baris ----
    Private Sub dgvPesan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesan.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvPesan.Rows(e.RowIndex)

        idPesanTerpilih = CInt(row.Cells("idPesan").Value)
        statusPesanTerpilih = row.Cells("statusPesan").Value.ToString()

        ' Ambil idKamar dari DB
        Dim dtP As DataTable = GetPemesananById(idPesanTerpilih)
        If dtP.Rows.Count > 0 Then
            idKamarTerpilih = CInt(dtP.Rows(0)("idKamar"))
        End If

        Dim durasi As Integer = CInt(row.Cells("durasi").Value)
        nudDurasi.Value = If(durasi >= 1, durasi, 1)

        lblInfoTerpilih.Text = String.Format("ID #{0} | Kamar {1} ({2}) | Durasi: {3} bln | Status: {4}",
                                             idPesanTerpilih,
                                             row.Cells("nomorKamar").Value,
                                             row.Cells("tipeKamar").Value,
                                             durasi,
                                             statusPesanTerpilih)

        ' Hanya pesanan Aktif yang bisa diedit/dibatalkan
        pnlAksi.Enabled = (statusPesanTerpilih = "Aktif")
        If statusPesanTerpilih <> "Aktif" Then
            lblInfoTerpilih.Text &= " — (hanya pesanan Aktif yang bisa diubah)"
        End If
    End Sub

    ' ---- Edit Durasi ----
    Private Sub btnEditDurasi_Click(sender As Object, e As EventArgs) Handles btnEditDurasi.Click
        If idPesanTerpilih = 0 Then
            MessageBox.Show("Pilih pesanan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim durasiBaru As Integer = CInt(nudDurasi.Value)

        ' Hitung ulang preview total
        Dim dtK As DataTable = GetKamarById(idKamarTerpilih)
        Dim harga As Integer = 0
        If dtK.Rows.Count > 0 Then harga = CInt(dtK.Rows(0)("hargaKamar"))
        Dim totalBaru As Integer = harga * durasiBaru

        Dim msg As String = String.Format("Ubah durasi menjadi {0} bulan?{1}Total baru: Rp {2:N0}",
                                          durasiBaru, vbCrLf, totalBaru)
        If MessageBox.Show(msg, "Konfirmasi Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If UbahDurasiPemesanan(idPesanTerpilih, durasiBaru) Then
                MessageBox.Show("Durasi berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
            End If
        End If
    End Sub

    ' ---- Batalkan Pesanan ----
    Private Sub btnBatalkan_Click(sender As Object, e As EventArgs) Handles btnBatalkan.Click
        If idPesanTerpilih = 0 Then
            MessageBox.Show("Pilih pesanan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("Batalkan pesanan ini? Status kamar akan kembali Tersedia.",
                           "Konfirmasi Batalkan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If BatalkanPemesanan(idPesanTerpilih, idKamarTerpilih) Then
                MessageBox.Show("Pesanan berhasil dibatalkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
            End If
        End If
    End Sub

    ' ---- Tutup ----
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class