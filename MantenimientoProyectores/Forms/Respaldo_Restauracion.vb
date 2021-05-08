Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Respaldo_Restauracion
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Private Sub btnRespaldo_Click(sender As Object, e As EventArgs) Handles btnRespaldo.Click
        Try
            Dim guardar As New SaveFileDialog
            Dim cadena As String
            guardar.FileName = " "
            guardar.ShowDialog()
            cadena = guardar.FileName
            Dim mb As MySqlBackup = New MySqlBackup(command)
            mb.ExportToFile(cadena)
            MessageBox.Show("Respaldo Exitoso...")
        Catch ex As Exception
            MsgBox("Recuerda poner un nombre a tu respaldo")
        End Try
    End Sub

    Private Sub Respaldo_Restauracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        command = connection.CreateCommand
    End Sub

    Private Sub btnRestauracion_Click(sender As Object, e As EventArgs) Handles btnRestauracion.Click
        Try
            Dim abrir As New OpenFileDialog
            Dim cadena As String
            abrir.FileName = " "
            abrir.Filter = "|*.sql"
            abrir.ShowDialog()
            cadena = abrir.FileName
            Dim mb As MySqlBackup = New MySqlBackup(command)
            mb.ImportFromFile(cadena)
            MessageBox.Show("Respaldo Exitoso...")
        Catch ex As Exception
            MsgBox("Recuerda elegir un nombre para restaurar la base de datos")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class