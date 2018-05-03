Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn()
    End Sub
    
    Sub MysqlConn()
        Dim ConnString As String = "server=localhost;user=root;password=;port=3306;database=tutorial88_vbnet;sslmode=none"
        conn = New MySqlConnection(ConnString)

        Try
            conn.Open()
            MsgBox("Success")
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
