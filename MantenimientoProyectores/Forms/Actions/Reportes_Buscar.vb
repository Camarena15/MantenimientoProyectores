'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Reportes_Buscar
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

    Private Sub Reportes_Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.Rows.Clear()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        conexion.Open()
        txtTipoReporte.Text = tipoReporte
        Dim fechai, fechaf As Date
        fechai = pFechaInicio
        fechaf = pFechaFin
        txtPInicio.Text = fechai.ToString("dd/MM/yyyy")
        txtPFin.Text = fechaf.ToString("dd/MM/yyyy")
        Dim r As String = ""
        If tipoReporte.Equals("DOCENTE") Then
            DGV.Columns.Item(5).Visible = True
            DGV.Columns.Item(6).Visible = True
            r = "SELECT IdReporte, Fecha, ObservacionesGrales, Estado, Edificio, Aula FROM REPORTEDOCENTES WHERE Fecha BETWEEN '" & pFechaInicio &
            "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
        ElseIf tipoReporte.Equals("INDIVIDUAL") Then
            DGV.Columns.Item(5).Visible = False
            DGV.Columns.Item(6).Visible = False
            r = "SELECT IdReporteRecursos, Fecha, Concepto, Estado FROM REPORTESRECURSOSINDIVIDUALES WHERE Fecha BETWEEN '" & pFechaInicio &
            "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
        End If
        comando = conexion.CreateCommand
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            If tipoReporte = "DOCENTE" Then
                DGV.Rows.Add(lector.GetString(0), tipoReporte, lector.GetString(1), lector.GetString(2), lector.GetString(3), lector.GetValue(4), lector.GetValue(5))

            Else
                DGV.Rows.Add(lector.GetString(0), tipoReporte, lector.GetString(1), lector.GetString(2), lector.GetString(3), "", "")

            End If
        End While
        lector.Close()
        Timer1.Stop()
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click
        idReporte_1 = DGV(0, DGV.CurrentCell.RowIndex).Value
        fecha_1 = DGV(2, DGV.CurrentCell.RowIndex).Value
        observaciones_1 = DGV(3, DGV.CurrentCell.RowIndex).Value
        estadoreporte_1 = DGV(4, DGV.CurrentCell.RowIndex).Value
        If tipoReporte = "DOCENTE" Then
            recursoasignadoEdificio = DGV(5, DGV.CurrentCell.RowIndex).Value
            recursoasignadoAula = DGV(6, DGV.CurrentCell.RowIndex).Value
        End If
        obtainedInfoRep = True
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