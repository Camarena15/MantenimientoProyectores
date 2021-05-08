Imports MySql.Data.MySqlClient
Module bitacora
    Public Function InsertarError(ByVal opcion As String, ByVal descripcion As String, ByVal num As Integer, ByVal fecha As String)
        Dim conexion As New MySqlConnection("Server=mysql-sistemamediosav.alwaysdata.net;database=sistemamediosav_db;user id=230400_db;password=W*eH0EBY%7oH;port=3306")
        Dim comando As New MySqlCommand
        Dim R As String
        Dim cadena As String
        cadena = " "
        For i = 1 To Len(descripcion)
            If Mid(descripcion, i, 1) <> Chr(39) Then
                cadena = cadena + Mid(descripcion, i, 1)
            End If
        Next
        conexion.Open()
        comando = conexion.CreateCommand
        R = "insert into bitacora values(" & 0 & ",'" & opcion & "','" & cadena & "'," & num & ",'" & fecha & "')"
        comando.CommandText = R
        'MsgBox(R)
        comando.ExecuteNonQuery()
        conexion.Close()
    End Function
End Module
