Imports MySql.Data.MySqlClient

Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Public idselected As String
    Public selectednik As String

    Sub konek()
        Try
            Dim str As String = "Server=localhost;user=root;password=12345;database=laundry"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Gagal Connect")
        End Try
    End Sub

End Module
