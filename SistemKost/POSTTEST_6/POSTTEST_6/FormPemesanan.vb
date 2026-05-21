Imports System.Data

Public Class FormPemesanan

    Dim idKamarTerpilih As Integer = 0
    Dim hargaKamarTerpilih As Integer = 0

    Private Sub FormPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilKamarTersedia()
        nudDurasi.Minimum = 1
        nudDurasi.Maximum = 24
        nudDurasi.Value = 1
        dtpMulai.MinDate = DateTime.Today
        dtpMulai.Value = DateTime.Today
        HitungTotal()
    End Sub

    Private Sub TampilKamarTersedia()
        Dim dt As DataTable = GetKamarTersedia()
        dgvKamar.DataSource = dt
        dgvKamar.ReadOnly = True
        dgvKamar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKamar.AllowUserToAddRows = False
        dgvKamar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKamar.MultiSelect = False

        If dgvKamar.Columns.Contains("idKamar") Then dgvKamar.Columns("idKamar").Visible = False
        If dgvKamar.Columns.Contains("nomorKamar") Then dgvKamar.Columns("nomorKamar").HeaderText = "No. Kamar"
        If dgvKamar.Columns.Contains("tipeKamar") Then dgvKamar.Columns("tipeKamar").HeaderText = "Tipe"
        If dgvKamar.Columns.Contains("hargaKamar") Then dgvKamar.Columns("hargaKamar").HeaderText = "Harga/Bulan (Rp)"
        If dgvKamar.Columns.Contains("statusKamar") Then dgvKamar.Columns("statusKamar").Visible = False
        If dgvKamar.Columns.Contains("deskripsi") Then dgvKamar.Columns("deskripsi").HeaderText = "Deskripsi"
        If dgvKamar.Columns.Contains("createdAt") Then dgvKamar.Columns("createdAt").Visible = False
    End Sub

    ' ---- Pilih kamar dari DGV ----
    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)
        idKamarTerpilih = CInt(row.Cells("idKamar").Value)
        hargaKamarTerpilih = CInt(row.Cells("hargaKamar").Value)
        lblKamarDipilih.Text = String.Format("Kamar {0} ({1}) — Rp {2:N0}/bulan",
                                             row.Cells("nomorKamar").Value,
                                             row.Cells("tipeKamar").Value,
                                             hargaKamarTerpilih)
        HitungTotal()
    End Sub

    ' ---- Hitung total harga otomatis ----
    Private Sub HitungTotal()
        Dim durasi As Integer = CInt(nudDurasi.Value)
        Dim total As Long = CLng(hargaKamarTerpilih) * durasi
        lblTotal.Text = "Rp " & String.Format("{0:N0}", total)
    End Sub

    Private Sub nudDurasi_ValueChanged(sender As Object, e As EventArgs) Handles nudDurasi.ValueChanged
        HitungTotal()
    End Sub

    ' ---- Tombol Pesan ----
    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        If idKamarTerpilih = 0 Then
            MessageBox.Show("Pilih kamar yang ingin dipesan terlebih dahulu!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim durasi As Integer = CInt(nudDurasi.Value)
        Dim total As Integer = hargaKamarTerpilih * durasi
        Dim tglMulai As Date = dtpMulai.Value.Date

        Dim konfirm As String = String.Format(
            "Konfirmasi Pemesanan:{0}" &
            "Kamar : {1}{0}" &
            "Durasi : {2} bulan{0}" &
            "Mulai  : {3}{0}" &
            "Selesai: {4}{0}" &
            "Total  : Rp {5:N0}{0}{0}" &
            "Lanjutkan?",
            vbCrLf,
            lblKamarDipilih.Text,
            durasi,
            tglMulai.ToString("dd MMM yyyy"),
            tglMulai.AddMonths(durasi).ToString("dd MMM yyyy"),
            total)

        If MessageBox.Show(konfirm, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If SimpanPemesanan(SessionModule.IdUser, idKamarTerpilih, durasi, total, tglMulai) Then
                MessageBox.Show("Pemesanan berhasil! Selamat menikmati kamar Anda.",
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    ' ---- Tombol Batal ----
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class
