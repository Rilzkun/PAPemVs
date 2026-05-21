Imports System.Data
Imports System.Drawing.Printing

Public Class FormDashboardUser
    Private Sub FormDashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Halo, " & SessionModule.NamaLengkap & "!"
        MuatInfoKamar()
    End Sub

    ' ---- Pengaturan Layout Responsif ----
    Private Sub FormDashboardUser_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlContent IsNot Nothing Then
            If pnlKamarInfo.Visible Then
                pnlKamarInfo.Location = New Point((pnlContent.Width - pnlKamarInfo.Width) \ 2, 20)
            End If
            If pnlTidakAdaPesan.Visible Then
                pnlTidakAdaPesan.Location = New Point((pnlContent.Width - pnlTidakAdaPesan.Width) \ 2, 20)
            End If
        End If
    End Sub

    ' ---- Modul Muat Data Kamar ----
    Private Sub MuatInfoKamar()
        Dim dt As DataTable = GetPemesananAktifByUser(SessionModule.IdUser)

        If dt.Rows.Count = 0 Then
            pnlKamarInfo.Visible = False
            pnlTidakAdaPesan.Visible = True
            pnlTidakAdaPesan.Location = New Point((pnlContent.Width - pnlTidakAdaPesan.Width) \ 2, 20)
        Else
            pnlKamarInfo.Visible = True
            pnlTidakAdaPesan.Visible = False
            pnlKamarInfo.Location = New Point((pnlContent.Width - pnlKamarInfo.Width) \ 2, 20)

            Dim row As DataRow = dt.Rows(0)
            lblNoKamar.Text = row("nomorKamar").ToString()
            lblTipeKamar.Text = row("tipeKamar").ToString()
            lblHarga.Text = "Rp " & String.Format("{0:N0}", CInt(row("hargaKamar")))
            lblDurasi.Text = row("durasi").ToString() & " bulan"
            lblTotal.Text = "Rp " & String.Format("{0:N0}", CInt(row("totalHarga")))
            lblTglMulai.Text = CDate(row("tanggalMulai")).ToString("dd MMM yyyy")
            lblTglSelesai.Text = CDate(row("tanggalSelesai")).ToString("dd MMM yyyy")
            lblDeskripsi.Text = If(row("deskripsi") Is Nothing OrElse IsDBNull(row("deskripsi")), "-", row("deskripsi").ToString())
            lblStatus.Text = row("statusPesan").ToString()
        End If
    End Sub

    ' ---- Tombol Aksi: Pesan Kamar Baru ----
    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        If UserPunyaPesananAktif(SessionModule.IdUser) Then
            MessageBox.Show("Anda sudah memiliki pemesanan aktif. Selesaikan atau batalkan pesanan lama terlebih dahulu.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frm As New FormPemesanan()
        frm.ShowDialog(Me)
        MuatInfoKamar()
    End Sub

    ' ---- Tombol Aksi: Kelola Pesanan ----
    Private Sub btnKelolaP_Click(sender As Object, e As EventArgs) Handles btnKelolaP.Click
        Dim frm As New FormKelolaP()
        frm.ShowDialog(Me)
        MuatInfoKamar()
    End Sub

    ' ---- Tombol Aksi: Cetak Struk ----
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        dialogPrint.Document = docPrint
        dialogPrint.StartPosition = FormStartPosition.CenterScreen
        dialogPrint.WindowState = FormWindowState.Normal
        dialogPrint.Width = 600
        dialogPrint.Height = 700
        dialogPrint.ShowDialog()
    End Sub

    ' ---- Struk ----
    Private Sub docPrint_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docPrint.PrintPage
        Dim fontJudul As New Font("Courier New", 16, FontStyle.Bold)
        Dim fontSub As New Font("Courier New", 11, FontStyle.Regular)
        Dim fontIsi As New Font("Courier New", 10, FontStyle.Regular)
        Dim fontTebal As New Font("Courier New", 10, FontStyle.Bold)
        Dim brush As Brush = Brushes.Black

        Dim marginKiri As Integer = 50
        Dim yPos As Integer = 50

        e.Graphics.DrawString("STRUK PEMESANAN KOST", fontJudul, brush, marginKiri, yPos)
        yPos += 30
        e.Graphics.DrawString("Tanda Bukti Sewa Kamar Resmi", fontSub, brush, marginKiri, yPos)
        yPos += 30
        e.Graphics.DrawString("------------------------------------------------", fontIsi, brush, marginKiri, yPos)
        yPos += 20

        e.Graphics.DrawString("Nama Penyewa : " & SessionModule.NamaLengkap, fontIsi, brush, marginKiri, yPos)
        yPos += 25
        e.Graphics.DrawString("Nomor Kamar  : " & lblNoKamar.Text, fontIsi, brush, marginKiri, yPos)
        yPos += 25
        e.Graphics.DrawString("Tipe Kamar   : " & lblTipeKamar.Text, fontIsi, brush, marginKiri, yPos)
        yPos += 25
        e.Graphics.DrawString("Durasi Sewa  : " & lblDurasi.Text, fontIsi, brush, marginKiri, yPos)
        yPos += 25
        e.Graphics.DrawString("Tanggal Masuk: " & lblTglMulai.Text, fontIsi, brush, marginKiri, yPos)
        yPos += 25
        e.Graphics.DrawString("Tgl Selesai  : " & lblTglSelesai.Text, fontIsi, brush, marginKiri, yPos)
        yPos += 30

        e.Graphics.DrawString("------------------------------------------------", fontIsi, brush, marginKiri, yPos)
        yPos += 20

        e.Graphics.DrawString("TOTAL BAYAR  : " & lblTotal.Text, fontTebal, brush, marginKiri, yPos)
        yPos += 30
        e.Graphics.DrawString("------------------------------------------------", fontIsi, brush, marginKiri, yPos)
        yPos += 40

        e.Graphics.DrawString("Terima kasih telah mempercayakan", fontIsi, brush, marginKiri, yPos)
        yPos += 20
        e.Graphics.DrawString("kenyamanan hunian Anda kepada kami.", fontIsi, brush, marginKiri, yPos)

        e.HasMorePages = False
    End Sub

    ' ---- Tombol Aksi: Logout ----
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SessionModule.Logout()
            Dim frm As New FormLogin()
            frm.Show()
            Me.Close()
        End If
    End Sub

    ' ---- Handler MenuStrip ----
    Private Sub mnuPesan_Click(sender As Object, e As EventArgs) Handles mnuPesan.Click
        btnPesan_Click(sender, e)
    End Sub
    Private Sub mnuKelola_Click(sender As Object, e As EventArgs) Handles mnuKelola.Click
        btnKelolaP_Click(sender, e)
    End Sub
    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        btnLogout_Click(sender, e)
    End Sub

End Class