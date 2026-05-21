Module ValidationModule

    ''' <summary>Hanya izinkan huruf dan spasi pada TextBox</summary>
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ''' <summary>Hanya izinkan angka pada TextBox</summary>
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ''' <summary>Hanya izinkan angka dan tanda + pada nomor telepon</summary>
    Public Sub HanyaTelp(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse
           e.KeyChar = "+"c OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ''' <summary>Validasi TextBox tidak boleh kosong, tampilkan error di ErrorProvider</summary>
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    ''' <summary>Validasi ComboBox harus dipilih</summary>
    Public Function ValidasiComboBox(ep As ErrorProvider, cmb As ComboBox, pesan As String) As Boolean
        If cmb.SelectedIndex = -1 Then
            ep.SetError(cmb, pesan)
            Return False
        Else
            ep.SetError(cmb, "")
            Return True
        End If
    End Function

    ''' <summary>Validasi DateTimePicker agar tanggal keluar >= tanggal masuk</summary>
    Public Function ValidasiTanggal(ep As ErrorProvider,
                                    dtpMasuk As DateTimePicker,
                                    dtpKeluar As DateTimePicker,
                                    cbKeluar As CheckBox) As Boolean
        If cbKeluar.Checked AndAlso dtpKeluar.Value.Date < dtpMasuk.Value.Date Then
            ep.SetError(dtpKeluar, "Tanggal keluar tidak boleh sebelum tanggal masuk!")
            Return False
        Else
            ep.SetError(dtpKeluar, "")
            Return True
        End If
    End Function

    ''' <summary>Validasi lengkap untuk data kamar</summary>
    Public Function ValidasiDataKamar(ep As ErrorProvider,
                                      txtJenis As TextBox,
                                      txtNomor As TextBox,
                                      txtHarga As TextBox,
                                      cmbStatus As ComboBox) As Boolean
        Dim jenisOk As Boolean = ValidasiTextBox(ep, txtJenis, "Jenis kamar wajib diisi!")
        Dim nomorOk As Boolean = ValidasiTextBox(ep, txtNomor, "Nomor kamar wajib diisi!")
        Dim hargaOk As Boolean = ValidasiTextBox(ep, txtHarga, "Harga kamar wajib diisi!")
        Dim statusOk As Boolean = ValidasiComboBox(ep, cmbStatus, "Status kamar wajib dipilih!")
        Return jenisOk And nomorOk And hargaOk And statusOk
    End Function

    ''' <summary>Validasi lengkap untuk data penyewa</summary>
    Public Function ValidasiDataPenyewa(ep As ErrorProvider,
                                        cmbKamar As ComboBox,
                                        txtNama As TextBox,
                                        txtTelp As TextBox,
                                        cmbStatus As ComboBox) As Boolean
        Dim kamarOk As Boolean = ValidasiComboBox(ep, cmbKamar, "Kamar wajib dipilih!")
        Dim namaOk As Boolean = ValidasiTextBox(ep, txtNama, "Nama penyewa wajib diisi!")
        Dim telpOk As Boolean = ValidasiTextBox(ep, txtTelp, "No. Telepon wajib diisi!")
        Dim statusOk As Boolean = ValidasiComboBox(ep, cmbStatus, "Status sewa wajib dipilih!")
        Return kamarOk And namaOk And telpOk And statusOk
    End Function

    ''' <summary>Cek apakah key yang ditekan adalah Enter</summary>
    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module
