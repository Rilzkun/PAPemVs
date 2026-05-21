Imports MySqlConnector

Module ConnectionModule

    Public ReadOnly connStr As String =
        "server=localhost;user id=root;password=;database=db_kost"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connStr)
    End Function

End Module