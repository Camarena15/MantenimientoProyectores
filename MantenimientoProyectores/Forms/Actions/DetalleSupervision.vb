'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.IO
Imports System.Runtime.InteropServices
Public Class DetalleSupervision
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim MP As New MPTools
    ' Se utilizan librerias de Windows para el funcionamiento de la interfaz, se recomienda NO TOCAR
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub DetalleSupervision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        command.CommandText = "SELECT `ObservaCajaConex`, `ImagenCajaConex`, `ObservaConectorElect`, `ImagenConectorElect`, 
            `ObservaPintarrón`, `ImagenPintarrón`, `ObservaElectricidad`, `ImagenElect`, `ObservaLámparas`, `ImagenLamparas`, 
            `ObservaVentanas`, `ImagenVentanas` FROM `SUPERVISION` WHERE `IdSupervision`=" & indiceSupervision
        lector = command.ExecuteReader
        lector.Read()
        txtCajaCon.Text = lector.GetValue(0)
        MP.obtImagen(lector.GetValue(1))
        pctCajaCon.Image = image
        txtConElec.Text = lector.GetValue(2)
        MP.obtImagen(lector.GetValue(3))
        pctConElect.Image = image
        txtPinta.Text = lector.GetValue(4)
        MP.obtImagen(lector.GetValue(5))
        pctPinta.Image = image
        txtElec.Text = lector.GetValue(6)
        MP.obtImagen(lector.GetValue(7))
        pctElect.Image = image
        txtLamp.Text = lector.GetValue(8)
        MP.obtImagen(lector.GetValue(9))
        pctLamp.Image = image
        txtVent.Text = lector.GetValue(10)
        MP.obtImagen(lector.GetValue(11))
        pctVent.Image = image
        lector.Close()
        connection.Close()
        Timer1.Stop()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        txtCajaCon.Text = ""
        txtConElec.Text = ""
        txtPinta.Text = ""
        txtElec.Text = ""
        txtLamp.Text = ""
        txtVent.Text = ""
        pctCajaCon.Image = Nothing
        pctConElect.Image = Nothing
        pctPinta.Image = Nothing
        pctElect.Image = Nothing
        pctLamp.Image = Nothing
        pctVent.Image = Nothing
        Close()
    End Sub
End Class