Imports System.Data

Public Class FormDashboardAdmin

    Private Sub FormDashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Selamat datang, " & SessionModule.NamaLengkap & "!"
        RefreshDashboard()
    End Sub

    Private Sub RefreshDashboard()
        MuatStatistik()
        MuatPreview()
    End Sub

    Private Sub FormDashboardAdmin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlBody IsNot Nothing AndAlso pnlLeft IsNot Nothing AndAlso pnlRight IsNot Nothing Then
            Dim w As Integer = pnlBody.Width - 25
            Dim h As Integer = pnlBody.Height - 20
            pnlLeft.Size = New Size(CInt(w * 0.45), h)
            dgvKamar.Size = New Size(pnlLeft.Width - 20, h - 40)
            pnlRight.Location = New Point(CInt(w * 0.45) + 15, 5)
            pnlRight.Size = New Size(CInt(w * 0.55), h)
            dgvPemesanan.Size = New Size(pnlRight.Width - 20, h - 40)
        End If
    End Sub

    Private Sub MuatStatistik()
        Try
            Dim stats As Dictionary(Of String, Integer) = GetStatistik()
            lblTotalKamar.Text = stats("totalKamar").ToString()
            lblKamarTersedia.Text = stats("kamarTersedia").ToString()
            lblTotalPelanggan.Text = stats("totalPelanggan").ToString()
            lblPemesananAktif.Text = stats("pemesananAktif").ToString()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat statistik: " & ex.Message)
        End Try
    End Sub

    Private Sub MuatPreview()
        dgvKamar.DataSource = Get5KamarTerbaru()
        dgvPemesanan.DataSource = Get5PemesananAktif()
    End Sub

    ' ---- Navigasi Menu ----
    Private Sub btnKamar_Click(sender As Object, e As EventArgs) Handles btnKamar.Click, mnuKamar.Click
        Dim frm As New FormKamar()
        frm.ShowDialog(Me)
        RefreshDashboard()
    End Sub

    Private Sub btnPenghuni_Click(sender As Object, e As EventArgs) Handles btnPenghuni.Click, mnuPenghuni.Click
        Dim frm As New FormPenghuni()
        frm.ShowDialog(Me)
        RefreshDashboard()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click, mnuLogout.Click
        If MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            SessionModule.Logout()
            Dim frm As New FormLogin()
            frm.Show()
            Me.Close()
        End If
    End Sub
End Class