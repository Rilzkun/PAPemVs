Imports System.Data

Public Class FormKamar

    Dim idKamarTerpilih As Integer = 0
    Private Sub FormKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipe.Items.AddRange(New Object() {"Biasa", "Eksekutif", "VIP"})
        cmbStatus.Items.AddRange(New Object() {"Tersedia", "Dipesan", "Maintenance"})
        TampilData()
        KosongForm()
    End Sub

    Private Sub FormKamar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If btnTutup IsNot Nothing Then
            btnTutup.Location = New Point(Me.ClientSize.Width - 90, 13)
        End If
    End Sub

    Private Sub TampilData()
        Dim dt As DataTable = GetAllKamar()
        dgvKamar.DataSource = dt
        dgvKamar.ReadOnly = True
        dgvKamar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKamar.AllowUserToAddRows = False
        dgvKamar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        If dgvKamar.Columns.Contains("idKamar") Then
            dgvKamar.Columns("idKamar").HeaderText = "ID"
            dgvKamar.Columns("idKamar").Width = 50
            dgvKamar.Columns("idKamar").FillWeight = 5
        End If
        If dgvKamar.Columns.Contains("nomorKamar") Then dgvKamar.Columns("nomorKamar").HeaderText = "No. Kamar"
        If dgvKamar.Columns.Contains("tipeKamar") Then dgvKamar.Columns("tipeKamar").HeaderText = "Tipe"
        If dgvKamar.Columns.Contains("hargaKamar") Then dgvKamar.Columns("hargaKamar").HeaderText = "Harga/Bulan (Rp)"
        If dgvKamar.Columns.Contains("statusKamar") Then dgvKamar.Columns("statusKamar").HeaderText = "Status"
        If dgvKamar.Columns.Contains("deskripsi") Then dgvKamar.Columns("deskripsi").HeaderText = "Deskripsi"
    End Sub

    Private Sub KosongForm()
        txtNomor.Clear()
        cmbTipe.SelectedIndex = -1
        txtHarga.Clear()
        cmbStatus.SelectedIndex = -1
        txtDeskripsi.Clear()
        idKamarTerpilih = 0
        txtNomor.Focus()
    End Sub

    ' ---- Harga berdasarkan Tipe ----
    Private Sub cmbTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipe.SelectedIndexChanged
        If cmbTipe.SelectedItem IsNot Nothing Then
            txtHarga.Text = GetHargaDefault(cmbTipe.SelectedItem.ToString()).ToString()
        End If
    End Sub

    ' ---- Pilih baris dari DGV ----
    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)
        idKamarTerpilih = CInt(row.Cells("idKamar").Value)
        txtNomor.Text = row.Cells("nomorKamar").Value.ToString()
        cmbTipe.Text = row.Cells("tipeKamar").Value.ToString()
        txtHarga.Text = row.Cells("hargaKamar").Value.ToString()
        cmbStatus.Text = row.Cells("statusKamar").Value.ToString()
        txtDeskripsi.Text = If(row.Cells("deskripsi").Value Is Nothing OrElse IsDBNull(row.Cells("deskripsi").Value), "", row.Cells("deskripsi").Value.ToString())
    End Sub

    ' ---- Pencarian ----
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvKamar.DataSource = SearchKamar(txtCari.Text.Trim())
        End If
    End Sub

    ' ---- Validasi ----
    Private Function Validasi() As Boolean
        If txtNomor.Text.Trim() = "" Then
            MessageBox.Show("Nomor kamar harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomor.Focus() : Return False
        End If
        If cmbTipe.SelectedIndex = -1 Then
            MessageBox.Show("Tipe kamar harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTipe.Focus() : Return False
        End If
        If txtHarga.Text.Trim() = "" OrElse Not IsNumeric(txtHarga.Text) Then
            MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus() : Return False
        End If
        If cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Status kamar harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatus.Focus() : Return False
        End If
        Return True
    End Function

    ' ---- Tombol Tambah ----
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not Validasi() Then Return
        Dim nomor As String = txtNomor.Text.Trim().ToUpper()
        If NomorKamarExists(nomor) Then
            MessageBox.Show("Nomor kamar sudah digunakan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SimpanKamar(nomor, cmbTipe.Text, CInt(txtHarga.Text), cmbStatus.Text, txtDeskripsi.Text.Trim()) Then
            MessageBox.Show("Data kamar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongForm()
        End If
    End Sub

    ' ---- Tombol Ubah ----
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idKamarTerpilih = 0 Then
            MessageBox.Show("Pilih kamar yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Validasi() Then Return
        Dim nomor As String = txtNomor.Text.Trim().ToUpper()
        If NomorKamarExists(nomor, idKamarTerpilih) Then
            MessageBox.Show("Nomor kamar sudah digunakan kamar lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If UbahKamar(idKamarTerpilih, nomor, cmbTipe.Text, CInt(txtHarga.Text), cmbStatus.Text, txtDeskripsi.Text.Trim()) Then
            MessageBox.Show("Data kamar berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongForm()
        End If
    End Sub

    ' ---- Tombol Hapus ----
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idKamarTerpilih = 0 Then
            MessageBox.Show("Pilih kamar yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("Hapus kamar ini? Kamar yang masih memiliki pemesanan aktif tidak bisa dihapus.",
                           "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If HapusKamar(idKamarTerpilih) Then
                MessageBox.Show("Data kamar berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongForm()
            End If
        End If
    End Sub

    ' ---- Tombol Batal ----
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongForm()
        TampilData()
    End Sub

    ' ---- Tombol Tutup ----
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    ' ---- Input Selain Angka Pada Field Harga ----
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class