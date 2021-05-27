'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.IO
Public Class MPTools
    Dim finalPath As String
    Dim laps As Integer
    Public Sub obtImagen(ByVal path As String)
        Dim ftpuser As String = "sistemamediosav_01"
        Dim ftppass As String = "W*eH0EBY%7oH"
        'Get the object used to communicate with the server.
        Dim request As FtpWebRequest = WebRequest.Create(path)
        request.Method = WebRequestMethods.Ftp.DownloadFile
        'This example assumes the FTP site uses anonymous logon.
        request.Credentials = New NetworkCredential(ftpuser, ftppass)
        Dim response As FtpWebResponse = request.GetResponse()
        Dim responseStream As Stream
        responseStream = response.GetResponseStream()
        image = Image.FromStream(responseStream)
        response.Close()
    End Sub

    Public Function busquedaIdRecurso(ByVal tabla As String, ByVal idRecurso As String) As Integer
        Dim connection As New MySqlConnection(s)
        Dim command As New MySqlCommand
        Dim lector As MySqlDataReader
        connection.Open()
        command = connection.CreateCommand
        Dim t As String = "SELECT count(*) FROM `" & tabla & "` WHERE IdRecurso=" & idRecurso
        Dim n As Integer
        command.CommandText = t
        lector = command.ExecuteReader()
        lector.Read()
        n = lector.GetInt32(0)
        lector.Close()
        connection.Close()
        Return n
    End Function
End Class
