Module SessionModule

    Public IdUser As Integer = 0
    Public Username As String = ""
    Public NamaLengkap As String = ""
    Public Role As String = ""

    Public Sub Logout()
        IdUser = 0
        Username = ""
        NamaLengkap = ""
        Role = ""
    End Sub

    Public ReadOnly Property IsAdmin As Boolean
        Get
            Return Role = "admin"
        End Get
    End Property

End Module