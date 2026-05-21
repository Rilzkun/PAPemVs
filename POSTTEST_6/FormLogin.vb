Imports System.Data

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname As String = txtUsername.Text.Trim()
        Dim pass As String = txtPassword.Text.Trim()

        If uname = "" OrElse pass = "" Then
            lblError.Text = "Username dan password harus diisi!"
            lblError.Visible = True
            Return
        End If

        Dim row As DataRow = Login(uname, pass)
        If row Is Nothing Then
            lblError.Text = "Username atau password salah!"
            lblError.Visible = True
            txtPassword.Clear()
            txtPassword.Focus()
            Return
        End If

        ' Simpan session
        SessionModule.IdUser = CInt(row("idUser"))
        SessionModule.Username = row("username").ToString()
        SessionModule.NamaLengkap = row("namaLengkap").ToString()
        SessionModule.Role = row("role").ToString()

        lblError.Visible = False

        If SessionModule.Role = "admin" Then
            Dim frm As New FormDashboardAdmin()
            frm.Show()
        Else
            Dim frm As New FormDashboardUser()
            frm.Show()
        End If

        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim frm As New FormRegister()
        frm.ShowDialog(Me)
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin_Click(sender, e)
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPass.Checked
    End Sub

End Class