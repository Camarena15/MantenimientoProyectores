'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class AtencionPreventivo_Seleccionar
    Dim conexion As New MySqlConnection(s)
    Dim comando As New MySqlCommand
    Dim lector As MySqlDataReader
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
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        conexion.Close()
        Me.Close()
    End Sub

    Private Sub AtencionPreventivo_Seleccionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.Rows.Clear()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        conexion.Open()
        If formSelected.Equals("Preventivo") Then
            txtTipoRegistro.Text = formSelected
        Else
            txtTipoRegistro.Text = "Atención a Fallas"
        End If
        Dim fechai, fechaf As Date
        fechai = pFechaInicio
        fechaf = pFechaFin
        txtPInicio.Text = fechai.ToString("dd/MM/yyyy")
        txtPFin.Text = fechaf.ToString("dd/MM/yyyy")
        Dim r As String = ""
        If formSelected.Equals("Preventivo") Then
            r = "SELECT IdPreventivo, FechaInicio, QuienAtiende, Estado FROM `PREVENTIVO` WHERE Estado='Pendiente' AND FechaInicio Between '" & pFechaInicio & "' AND '" & pFechaFin & "'"
        ElseIf formSelected.Equals("AtencionReportes") Then
            r = "SELECT IdAtencion, FechaSeguimiento, QuienAtiende, Estado FROM `ATENCIONFALLAS` WHERE Estado='Pendiente' AND FechaSeguimiento Between '" & pFechaInicio & "' AND '" & pFechaFin & "'"
        End If
        comando = conexion.CreateCommand
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            DGV.Rows.Add(lector.GetValue(0), txtTipoRegistro.Text, lector.GetValue(1), lector.GetValue(2), lector.GetValue(3))
        End While
        lector.Close()
        Timer1.Stop()
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click
        idMov_1 = DGV(0, DGV.CurrentCell.RowIndex).Value
        fecha_1 = DGV(2, DGV.CurrentCell.RowIndex).Value
        encargado_1 = DGV(3, DGV.CurrentCell.RowIndex).Value
        estado_1 = DGV(4, DGV.CurrentCell.RowIndex).Value
        obtainedInfoMov = True
        conexion.Close()
        Me.Close()
    End Sub
    Private Sub cmbSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        If DGV.CurrentCell.RowIndex <> DGV.Rows.Count - 2 Then
            Dim index As Integer = DGV.CurrentCell.RowIndex
            DGV.ClearSelection()
            DGV.CurrentCell = DGV(0, index + 1)
        End If
    End Sub

    Private Sub cmbAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        If DGV.CurrentCell.RowIndex <> 0 Then
            Dim index As Integer = DGV.CurrentCell.RowIndex
            DGV.ClearSelection()
            DGV.CurrentCell = DGV(0, index - 1)
        End If
    End Sub
End Class