Imports MySqlConnector
Imports System.Data

Module DataModule

    ' ================================================================
    '  HARGA DEFAULT PER TIPE KAMAR
    ' ================================================================
    Public Function GetHargaDefault(tipe As String) As Integer
        Select Case tipe
            Case "Biasa" : Return 500000
            Case "Eksekutif" : Return 800000
            Case "VIP" : Return 1200000
            Case Else : Return 0
        End Select
    End Function

    ' ================================================================
    '  MODUL: USERS (Login, Register, CRUD)
    ' ================================================================

    Public Function Login(username As String, password As String) As DataRow
        Try
            Dim query As String = "SELECT * FROM users WHERE username=@u AND password=@p LIMIT 1"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@u", username)
                    da.SelectCommand.Parameters.AddWithValue("@p", password)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then Return dt.Rows(0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Public Function Register(username As String, password As String, namaLengkap As String,
                              noTelp As String, Optional role As String = "user") As Boolean
        Try
            ' Cek username sudah ada
            If UsernameExists(username) Then
                MessageBox.Show("Username sudah digunakan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            Dim query As String = "INSERT INTO users (username, password, namaLengkap, noTelp, role) " &
                                  "VALUES (@u, @p, @n, @t, @r)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    cmd.Parameters.AddWithValue("@n", namaLengkap)
                    cmd.Parameters.AddWithValue("@t", noTelp)
                    cmd.Parameters.AddWithValue("@r", role)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal register: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UsernameExists(username As String, Optional excludeId As Integer = 0) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@u AND idUser<>@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@id", excludeId)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True
        End Try
    End Function

    Public Function GetAllUsers() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idUser, username, namaLengkap, noTelp, role, createdAt FROM users ORDER BY idUser ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetAllPenghuni() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT u.idUser, u.namaLengkap, u.username, u.noTelp, " &
                "       k.nomorKamar, k.tipeKamar, " &
                "       p.idPesan, p.durasi, p.totalHarga, p.tanggalMulai, p.tanggalSelesai, p.statusPesan " &
                "FROM users u " &
                "INNER JOIN pemesanan p ON u.idUser = p.idUser " &
                "INNER JOIN kamar k ON p.idKamar = k.idKamar " &
                "WHERE u.role='user' AND p.statusPesan='Aktif' " &
                "ORDER BY u.idUser ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data penghuni: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetAllUsersRole() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT u.idUser, u.namaLengkap, u.username, u.noTelp, u.role, " &
                "       IFNULL(p.idPesan, 0) AS idPesan, " &
                "       IFNULL(k.nomorKamar, '-') AS nomorKamar, " &
                "       IFNULL(k.tipeKamar, '-') AS tipeKamar, " &
                "       IFNULL(p.durasi, 0) AS durasi, " &
                "       IFNULL(p.totalHarga, 0) AS totalHarga, " &
                "       p.tanggalMulai, p.tanggalSelesai, " &
                "       IFNULL(p.statusPesan, '-') AS statusPesan " &
                "FROM users u " &
                "LEFT JOIN pemesanan p ON u.idUser = p.idUser AND p.statusPesan='Aktif' " &
                "LEFT JOIN kamar k ON p.idKamar = k.idKamar " &
                "WHERE u.role='user' " &
                "ORDER BY u.idUser ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data penghuni: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function UbahDurasiPenghuni(idPesan As Integer, durasiBaru As Integer) As Boolean
        Try
            ' Ambil data pemesanan untuk hitung ulang
            Dim dtP As DataTable = GetPemesananById(idPesan)
            If dtP.Rows.Count = 0 Then Return False
            Dim tglMulai As Date = CDate(dtP.Rows(0)("tanggalMulai"))
            Dim idKamar As Integer = CInt(dtP.Rows(0)("idKamar"))

            ' Ambil harga kamar
            Dim dtK As DataTable = GetKamarById(idKamar)
            If dtK.Rows.Count = 0 Then Return False
            Dim harga As Integer = CInt(dtK.Rows(0)("hargaKamar"))

            Dim totalBaru As Integer = harga * durasiBaru
            Dim tglSelesai As Date = tglMulai.AddMonths(durasiBaru)

            Dim query As String = "UPDATE pemesanan SET durasi=@d, totalHarga=@t, tanggalSelesai=@ts WHERE idPesan=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@d", durasiBaru)
                    cmd.Parameters.AddWithValue("@t", totalBaru)
                    cmd.Parameters.AddWithValue("@ts", tglSelesai.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@id", idPesan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah durasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function CheckoutPenghuni(idPesan As Integer, idKamar As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using tran As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Update status pemesanan
                        Using cmd As New MySqlCommand("UPDATE pemesanan SET statusPesan='Selesai' WHERE idPesan=@id", conn, tran)
                            cmd.Parameters.AddWithValue("@id", idPesan)
                            cmd.ExecuteNonQuery()
                        End Using
                        ' Update status kamar jadi Tersedia
                        Using cmd2 As New MySqlCommand("UPDATE kamar SET statusKamar='Tersedia' WHERE idKamar=@id", conn, tran)
                            cmd2.Parameters.AddWithValue("@id", idKamar)
                            cmd2.ExecuteNonQuery()
                        End Using
                        tran.Commit()
                        Return True
                    Catch
                        tran.Rollback()
                        Return False
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal checkout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ================================================================
    '  MODUL: KAMAR (CRUD)
    ' ================================================================

    Public Function GetAllKamar() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idKamar, nomorKamar, tipeKamar, hargaKamar, statusKamar, deskripsi FROM kamar ORDER BY nomorKamar ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data kamar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetKamarTersedia() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idKamar, nomorKamar, tipeKamar, hargaKamar, statusKamar, deskripsi FROM kamar WHERE statusKamar='Tersedia' ORDER BY nomorKamar ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan kamar tersedia: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetKamarById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT * FROM kamar WHERE idKamar=@id", conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch : End Try
        Return dt
    End Function

    Public Function SearchKamar(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idKamar, nomorKamar, tipeKamar, hargaKamar, statusKamar, deskripsi " &
                                  "FROM kamar WHERE nomorKamar LIKE @kw OR tipeKamar LIKE @kw OR statusKamar LIKE @kw ORDER BY nomorKamar ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari kamar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function NomorKamarExists(nomor As String, Optional excludeId As Integer = 0) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM kamar WHERE nomorKamar=@n AND idKamar<>@id", conn)
                    cmd.Parameters.AddWithValue("@n", nomor)
                    cmd.Parameters.AddWithValue("@id", excludeId)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch : Return True
        End Try
    End Function

    Public Function SimpanKamar(nomor As String, tipe As String, harga As Integer,
                                 status As String, deskripsi As String) As Boolean
        Try
            Dim query As String = "INSERT INTO kamar (nomorKamar, tipeKamar, hargaKamar, statusKamar, deskripsi) " &
                                  "VALUES (@n, @t, @h, @s, @d)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@n", nomor)
                    cmd.Parameters.AddWithValue("@t", tipe)
                    cmd.Parameters.AddWithValue("@h", harga)
                    cmd.Parameters.AddWithValue("@s", status)
                    cmd.Parameters.AddWithValue("@d", deskripsi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan kamar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahKamar(id As Integer, nomor As String, tipe As String, harga As Integer,
                               status As String, deskripsi As String) As Boolean
        Try
            Dim query As String = "UPDATE kamar SET nomorKamar=@n, tipeKamar=@t, hargaKamar=@h, statusKamar=@s, deskripsi=@d WHERE idKamar=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@n", nomor)
                    cmd.Parameters.AddWithValue("@t", tipe)
                    cmd.Parameters.AddWithValue("@h", harga)
                    cmd.Parameters.AddWithValue("@s", status)
                    cmd.Parameters.AddWithValue("@d", deskripsi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah kamar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusKamar(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM kamar WHERE idKamar=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus kamar: " & ex.Message & vbCrLf &
                            "Pastikan tidak ada pemesanan aktif pada kamar ini.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ================================================================
    '  MODUL: PEMESANAN (CRUD)
    ' ================================================================

    Public Function GetAllPemesanan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.idPesan, u.namaLengkap, u.username, k.nomorKamar, k.tipeKamar, " &
                "       FORMAT(k.hargaKamar, 0) AS hargaKamar, p.durasi, " &
                "       FORMAT(p.totalHarga, 0) AS totalHarga, " &
                "       p.tanggalMulai, p.tanggalSelesai, p.statusPesan " &
                "FROM pemesanan p " &
                "INNER JOIN users u ON p.idUser = u.idUser " &
                "INNER JOIN kamar k ON p.idKamar = k.idKamar " &
                "ORDER BY p.createdAt DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan pemesanan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPemesananByUser(idUser As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.idPesan, k.nomorKamar, k.tipeKamar, k.hargaKamar, " &
                "       p.durasi, p.totalHarga, p.tanggalMulai, p.tanggalSelesai, p.statusPesan " &
                "FROM pemesanan p " &
                "INNER JOIN kamar k ON p.idKamar = k.idKamar " &
                "WHERE p.idUser=@id ORDER BY p.createdAt DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idUser)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan pesanan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPemesananAktifByUser(idUser As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.idPesan, k.nomorKamar, k.tipeKamar, k.hargaKamar, k.deskripsi, " &
                "       p.durasi, p.totalHarga, p.tanggalMulai, p.tanggalSelesai, p.statusPesan " &
                "FROM pemesanan p " &
                "INNER JOIN kamar k ON p.idKamar = k.idKamar " &
                "WHERE p.idUser=@id AND p.statusPesan='Aktif' LIMIT 1"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idUser)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan pesanan aktif: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPemesananById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT * FROM pemesanan WHERE idPesan=@id", conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch : End Try
        Return dt
    End Function

    Public Function SimpanPemesanan(idUser As Integer, idKamar As Integer, durasi As Integer,
                                     totalHarga As Integer, tglMulai As Date) As Boolean
        Try
            Dim tglSelesai As Date = tglMulai.AddMonths(durasi)
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using tran As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Insert pemesanan
                        Dim query As String = "INSERT INTO pemesanan (idUser, idKamar, durasi, totalHarga, tanggalMulai, tanggalSelesai, statusPesan) " &
                                              "VALUES (@u, @k, @d, @t, @tm, @ts, 'Aktif')"
                        Using cmd As New MySqlCommand(query, conn, tran)
                            cmd.Parameters.AddWithValue("@u", idUser)
                            cmd.Parameters.AddWithValue("@k", idKamar)
                            cmd.Parameters.AddWithValue("@d", durasi)
                            cmd.Parameters.AddWithValue("@t", totalHarga)
                            cmd.Parameters.AddWithValue("@tm", tglMulai.ToString("yyyy-MM-dd"))
                            cmd.Parameters.AddWithValue("@ts", tglSelesai.ToString("yyyy-MM-dd"))
                            cmd.ExecuteNonQuery()
                        End Using
                        ' Update status kamar jadi Dipesan
                        Using cmd2 As New MySqlCommand("UPDATE kamar SET statusKamar='Dipesan' WHERE idKamar=@id", conn, tran)
                            cmd2.Parameters.AddWithValue("@id", idKamar)
                            cmd2.ExecuteNonQuery()
                        End Using
                        tran.Commit()
                        Return True
                    Catch ex As Exception
                        tran.Rollback()
                        MessageBox.Show("Gagal menyimpan pemesanan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pemesanan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahDurasiPemesanan(idPesan As Integer, durasiBaru As Integer) As Boolean
        Try
            Dim dtP As DataTable = GetPemesananById(idPesan)
            If dtP.Rows.Count = 0 Then Return False
            Dim tglMulai As Date = CDate(dtP.Rows(0)("tanggalMulai"))
            Dim idKamar As Integer = CInt(dtP.Rows(0)("idKamar"))
            Dim dtK As DataTable = GetKamarById(idKamar)
            If dtK.Rows.Count = 0 Then Return False
            Dim harga As Integer = CInt(dtK.Rows(0)("hargaKamar"))
            Dim totalBaru As Integer = harga * durasiBaru
            Dim tglSelesai As Date = tglMulai.AddMonths(durasiBaru)

            Dim query As String = "UPDATE pemesanan SET durasi=@d, totalHarga=@t, tanggalSelesai=@ts WHERE idPesan=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@d", durasiBaru)
                    cmd.Parameters.AddWithValue("@t", totalBaru)
                    cmd.Parameters.AddWithValue("@ts", tglSelesai.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@id", idPesan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah durasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function BatalkanPemesanan(idPesan As Integer, idKamar As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using tran As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Using cmd As New MySqlCommand("UPDATE pemesanan SET statusPesan='Dibatalkan' WHERE idPesan=@id", conn, tran)
                            cmd.Parameters.AddWithValue("@id", idPesan)
                            cmd.ExecuteNonQuery()
                        End Using
                        Using cmd2 As New MySqlCommand("UPDATE kamar SET statusKamar='Tersedia' WHERE idKamar=@id", conn, tran)
                            cmd2.Parameters.AddWithValue("@id", idKamar)
                            cmd2.ExecuteNonQuery()
                        End Using
                        tran.Commit()
                        Return True
                    Catch
                        tran.Rollback()
                        Return False
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal membatalkan pesanan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ================================================================
    '  STATISTIK DASHBOARD ADMIN
    ' ================================================================

    Public Function GetStatistik() As Dictionary(Of String, Integer)
        Dim stats As New Dictionary(Of String, Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                ' Total kamar
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM kamar", conn)
                    stats("totalKamar") = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                ' Kamar tersedia
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM kamar WHERE statusKamar='Tersedia'", conn)
                    stats("kamarTersedia") = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                ' Kamar dipesan
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM kamar WHERE statusKamar='Dipesan'", conn)
                    stats("kamarDipesan") = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                ' Total pelanggan (user role)
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE role='user'", conn)
                    stats("totalPelanggan") = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                ' Pemesanan aktif
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM pemesanan WHERE statusPesan='Aktif'", conn)
                    stats("pemesananAktif") = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil statistik: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return stats
    End Function

    Public Function Get5KamarTerbaru() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT nomorKamar, tipeKamar, FORMAT(hargaKamar,0) AS hargaKamar, statusKamar FROM kamar ORDER BY idKamar DESC LIMIT 5"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch : End Try
        Return dt
    End Function

    Public Function Get5PemesananAktif() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT u.namaLengkap, k.nomorKamar, k.tipeKamar, p.durasi, FORMAT(p.totalHarga,0) AS totalHarga, p.tanggalMulai, p.tanggalSelesai " &
                "FROM pemesanan p " &
                "INNER JOIN users u ON p.idUser=u.idUser " &
                "INNER JOIN kamar k ON p.idKamar=k.idKamar " &
                "WHERE p.statusPesan='Aktif' ORDER BY p.createdAt DESC LIMIT 5"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch : End Try
        Return dt
    End Function

    Public Function UserPunyaPesananAktif(idUser As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM pemesanan WHERE idUser=@id AND statusPesan='Aktif'", conn)
                    cmd.Parameters.AddWithValue("@id", idUser)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch : Return False
        End Try
    End Function

End Module