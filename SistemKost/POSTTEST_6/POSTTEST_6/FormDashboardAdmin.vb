Imports System.Data

Public Class FormDashboardAdmin

    ' ---- Event Load (Saat Form Dibuka) ----
    Private Sub FormDashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Selamat datang, " & SessionModule.NamaLengkap & "!"
        MuatStatistik()
        MuatPreview()
    End Sub

    ' ---- Pengaturan Layout Responsif (Dari perbaikan sebelumnya) ----
    Private Sub FormDashboardAdmin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlBody IsNot Nothing AndAlso pnlLeft IsNot Nothing AndAlso pnlRight IsNot Nothing Then
            Dim w As Integer = pnlBody.Width - 25
            Dim h As Integer = pnlBody.Height - 20

            pnlLeft.Location = New Point(5, 5)
            pnlLeft.Size = New Size(CInt(w * 0.45), h)
            dgvKamar.Size = New Size(pnlLeft.Width - 20, h - 40)

            pnlRight.Location = New Point(CInt(w * 0.45) + 15, 5)
            pnlRight.Size = New Size(CInt(w * 0.55), h)
            dgvPemesanan.Size = New Size(pnlRight.Width - 20, h - 40)
        End If
    End Sub

    ' ---- Modul Muat Data ----
    Private Sub MuatStatistik()
        Try
            Dim stats As Dictionary(Of String, Integer) = GetStatistik()
            lblTotalKamar.Text = stats("totalKamar").ToString()
            lblKamarTersedia.Text = stats("kamarTersedia").ToString()
            lblTotalPelanggan.Text = stats("totalPelanggan").ToString()
            lblPemesananAktif.Text = stats("pemesananAktif").ToString()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat statistik: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MuatPreview()
        ' 5 kamar terbaru
        Dim dtK As DataTable = Get5KamarTerbaru()
        dgvKamar.DataSource = dtK
        FormatDGV(dgvKamar)
        If dgvKamar.Columns.Contains("nomorKamar") Then dgvKamar.Columns("nomorKamar").HeaderText = "No. Kamar"
        If dgvKamar.Columns.Contains("tipeKamar") Then dgvKamar.Columns("tipeKamar").HeaderText = "Tipe"
        If dgvKamar.Columns.Contains("hargaKamar") Then dgvKamar.Columns("hargaKamar").HeaderText = "Harga/Bln"
        If dgvKamar.Columns.Contains("statusKamar") Then dgvKamar.Columns("statusKamar").HeaderText = "Status"

        ' 5 pesanan aktif
        Dim dtP As DataTable = Get5PemesananAktif()
        dgvPemesanan.DataSource = dtP
        FormatDGV(dgvPemesanan)
        If dgvPemesanan.Columns.Contains("namaLengkap") Then dgvPemesanan.Columns("namaLengkap").HeaderText = "Nama"
        If dgvPemesanan.Columns.Contains("nomorKamar") Then dgvPemesanan.Columns("nomorKamar").HeaderText = "No. Kamar"
        If dgvPemesanan.Columns.Contains("tipeKamar") Then dgvPemesanan.Columns("tipeKamar").HeaderText = "Tipe"
        If dgvPemesanan.Columns.Contains("durasi") Then dgvPemesanan.Columns("durasi").HeaderText = "Durasi (Bln)"
        If dgvPemesanan.Columns.Contains("totalHarga") Then dgvPemesanan.Columns("totalHarga").HeaderText = "Total Harga"
        If dgvPemesanan.Columns.Contains("tanggalMulai") Then dgvPemesanan.Columns("tanggalMulai").HeaderText = "Tgl Mulai"
        If dgvPemesanan.Columns.Contains("tanggalSelesai") Then dgvPemesanan.Columns("tanggalSelesai").HeaderText = "Tgl Selesai"
    End Sub

    Private Sub FormatDGV(dgv As DataGridView)
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' ---- Navigasi Menu ----
    Private Sub btnKamar_Click(sender As Object, e As EventArgs) Handles btnKamar.Click
        Dim frm As New FormKamar()
        frm.ShowDialog(Me)
        ' Setelah form ditutup (modal dialog), refresh data dashboard
        MuatStatistik()
        MuatPreview()
    End Sub

    Private Sub btnPenghuni_Click(sender As Object, e As EventArgs) Handles btnPenghuni.Click
        Dim frm As New FormPenghuni()
        frm.ShowDialog(Me)
        ' Setelah form ditutup (modal dialog), refresh data dashboard
        MuatStatistik()
        MuatPreview()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        MuatStatistik()
        MuatPreview()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SessionModule.Logout()
            Dim frm As New FormLogin()
            frm.Show()
            Me.Close()
        End If
    End Sub

    ' ---- Handler untuk MenuStrip (Mengarah ke tombol yang sama) ----
    Private Sub mnuKamar_Click(sender As Object, e As EventArgs) Handles mnuKamar.Click
        btnKamar_Click(sender, e)
    End Sub

    Private Sub mnuPenghuni_Click(sender As Object, e As EventArgs) Handles mnuPenghuni.Click
        btnPenghuni_Click(sender, e)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        btnLogout_Click(sender, e)
    End Sub

End Class