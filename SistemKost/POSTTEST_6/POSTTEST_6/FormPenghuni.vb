Imports System.Data

Public Class FormPenghuni

    Dim idPesanTerpilih As Integer = 0
    Dim idKamarTerpilih As Integer = 0

    ' ---- Event Load ----
    Private Sub FormPenghuni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    ' ---- Pengaturan Layout Responsif ----
    Private Sub FormPenghuni_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Memastikan tombol tutup selalu berada di pojok kanan atas saat form diubah ukurannya
        If btnTutup IsNot Nothing Then
            btnTutup.Location = New Point(Me.ClientSize.Width - 90, 13)
        End If
    End Sub

    ' ---- Modul Muat Data ----
    Private Sub TampilData()
        Dim dt As DataTable = GetAllUsersRole()
        dgvPenghuni.DataSource = dt
        dgvPenghuni.ReadOnly = True
        dgvPenghuni.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPenghuni.AllowUserToAddRows = False
        dgvPenghuni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        If dgvPenghuni.Columns.Contains("idUser") Then dgvPenghuni.Columns("idUser").HeaderText = "ID User"
        If dgvPenghuni.Columns.Contains("namaLengkap") Then dgvPenghuni.Columns("namaLengkap").HeaderText = "Nama Lengkap"
        If dgvPenghuni.Columns.Contains("username") Then dgvPenghuni.Columns("username").HeaderText = "Username"
        If dgvPenghuni.Columns.Contains("noTelp") Then dgvPenghuni.Columns("noTelp").HeaderText = "No. Telp"
        If dgvPenghuni.Columns.Contains("role") Then dgvPenghuni.Columns("role").Visible = False
        If dgvPenghuni.Columns.Contains("idPesan") Then dgvPenghuni.Columns("idPesan").HeaderText = "ID Pesan"
        If dgvPenghuni.Columns.Contains("nomorKamar") Then dgvPenghuni.Columns("nomorKamar").HeaderText = "No. Kamar"
        If dgvPenghuni.Columns.Contains("tipeKamar") Then dgvPenghuni.Columns("tipeKamar").HeaderText = "Tipe"
        If dgvPenghuni.Columns.Contains("durasi") Then dgvPenghuni.Columns("durasi").HeaderText = "Durasi (Bln)"
        If dgvPenghuni.Columns.Contains("totalHarga") Then dgvPenghuni.Columns("totalHarga").HeaderText = "Total Harga"
        If dgvPenghuni.Columns.Contains("tanggalMulai") Then dgvPenghuni.Columns("tanggalMulai").HeaderText = "Tgl Mulai"
        If dgvPenghuni.Columns.Contains("tanggalSelesai") Then dgvPenghuni.Columns("tanggalSelesai").HeaderText = "Tgl Selesai"
        If dgvPenghuni.Columns.Contains("statusPesan") Then dgvPenghuni.Columns("statusPesan").HeaderText = "Status Sewa"
    End Sub

    ' ---- Pilih Baris dari DataGridView ----
    Private Sub dgvPenghuni_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPenghuni.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvPenghuni.Rows(e.RowIndex)

        ' Cek apakah field idPesan bernilai DBNull atau tidak
        If IsDBNull(row.Cells("idPesan").Value) Then
            idPesanTerpilih = 0
        Else
            idPesanTerpilih = CInt(row.Cells("idPesan").Value)
        End If

        If idPesanTerpilih = 0 Then
            lblInfoTerpilih.Text = "Penghuni ini belum memiliki pemesanan aktif."
            Return
        End If

        Dim durasi As Integer = CInt(row.Cells("durasi").Value)
        nudDurasi.Value = If(durasi > 0, durasi, 1)
        lblInfoTerpilih.Text = String.Format("Dipilih: {0} | Kamar: {1} | Durasi: {2} bulan",
                                              row.Cells("namaLengkap").Value,
                                              row.Cells("nomorKamar").Value,
                                              durasi)
    End Sub

    ' ---- Edit Durasi ----
    Private Sub btnEditDurasi_Click(sender As Object, e As EventArgs) Handles btnEditDurasi.Click
        If idPesanTerpilih = 0 Then
            MessageBox.Show("Pilih penghuni yang memiliki pesanan aktif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim durasiBaru As Integer = CInt(nudDurasi.Value)
        If UbahDurasiPemesanan(idPesanTerpilih, durasiBaru) Then
            MessageBox.Show("Durasi berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
        End If
    End Sub

    ' ---- Checkout Penghuni ----
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If idPesanTerpilih = 0 Then
            MessageBox.Show("Pilih penghuni yang akan di-checkout!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("Checkout penghuni ini? Status kamar akan kembali menjadi Tersedia.",
                           "Konfirmasi Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Ambil idKamar dari row terpilih
            Dim dtP As DataTable = GetPemesananById(idPesanTerpilih)
            If dtP.Rows.Count > 0 Then
                Dim idKamar As Integer = CInt(dtP.Rows(0)("idKamar"))
                If CheckoutPenghuni(idPesanTerpilih, idKamar) Then
                    MessageBox.Show("Checkout berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    idPesanTerpilih = 0
                    lblInfoTerpilih.Text = "Pilih penghuni dari tabel"
                    TampilData()
                End If
            End If
        End If
    End Sub

    ' ---- Tombol Tutup ----
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class