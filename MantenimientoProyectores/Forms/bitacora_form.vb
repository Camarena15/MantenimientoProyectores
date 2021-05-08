Imports MySql.Data.MySqlClient
Public Class bitacora_form
    Private Sub bitacora_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DG.Rows.Clear()
        Dim connection As New MySqlConnection("Server=mysql-sistemamediosav.alwaysdata.net;database=sistemamediosav_db;user id=230400_db;password=W*eH0EBY%7oH;port=3306")
        connection.Open()
        Dim comando As New MySqlCommand
        Dim R As String
        Dim lector As MySqlDataReader
        comando = connection.CreateCommand
        R = "select * from bitacora"
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read
            DG.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        connection.Close()
    End Sub
End Class