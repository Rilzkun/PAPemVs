Public Class FormRegister

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Focus()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        lblError.Visible = False

        Dim nama As String = txtNama.Text.Trim()
        Dim uname As String = txtUsername.Text.Trim()
        Dim pass As String = txtPassword.Text.Trim()
        Dim konfPass As String = txtKonfirmasi.Text.Trim()
        Dim telp As String = txtTelp.Text.Trim()

        If nama = "" OrElse uname = "" OrElse pass = "" OrElse telp = "" Then
            ShowError("Semua field harus diisi!")
            Return
        End If

        If uname.Length < 4 Then
            ShowError("Username minimal 4 karakter!")
            Return
        End If

        If pass.Length < 6 Then
            ShowError("Password minimal 6 karakter!")
            Return
        End If

        If pass <> konfPass Then
            ShowError("Password dan konfirmasi tidak cocok!")
            txtKonfirmasi.Clear()
            txtKonfirmasi.Focus()
            Return
        End If

        If Register(uname, pass, nama, telp, "user") Then
            MessageBox.Show("Registrasi berhasil! Silakan login dengan akun baru Anda.",
                            "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ShowError(msg As String)
        lblError.Text = msg
        lblError.Visible = True
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class