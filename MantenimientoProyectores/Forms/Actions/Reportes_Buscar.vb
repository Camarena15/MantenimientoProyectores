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
        txtEdificio.SelectedIndex = 0
        txtAula.SelectedIndex = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        conexion.Open()
        txtTipoReporte.Text = tipoReporte
        txtPInicio.Text = pFechaInicio
        txtPFin.Text = pFechaFin
        Dim r As String = ""
        If tipoReporte.Equals("DOCENTE") Then
            DGV.Columns.Item(5).Visible = True
            DGV.Columns.Item(6).Visible = True
            lblAula.Visible = True
            lblEdificio.Visible = True
            txtAula.Visible = True
            txtEdificio.Visible = True
            cmdFiltrar.Visible = True
            r = "SELECT IdReporte, Fecha, ObservacionesGrales, Estado, Edificio, Aula FROM REPORTEDOCENTES WHERE Fecha BETWEEN '" & pFechaInicio &
            "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
        ElseIf tipoReporte.Equals("INDIVIDUAL") Then
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

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.CellClick
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

    Private Sub cmdFiltrar_Click(sender As Object, e As EventArgs) Handles cmdFiltrar.Click
        If txtEdificio.SelectedIndex = 0 Or txtAula.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un Edificio y un Aula!", MsgBoxStyle.Critical, "Error")
        Else
            DGV.Rows.Clear()
            Dim r As String = "SELECT count(*) FROM REPORTEDOCENTES WHERE Fecha BETWEEN '" & pFechaInicio &
            "' AND '" & pFechaFin & "' AND Estado='Pendiente' AND Edificio='" & txtEdificio.SelectedItem & "' AND Aula= '" & txtAula.SelectedItem & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            lector.Read()
            Dim nRes As Integer = lector.GetValue(0)
            lector.Close()
            If nRes <> 0 Then
                r = "SELECT IdReporte, Fecha, ObservacionesGrales, Estado, Edificio, Aula FROM REPORTEDOCENTES WHERE Fecha BETWEEN '" & pFechaInicio &
            "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
                comando.CommandText = r
                lector = comando.ExecuteReader
                While lector.Read
                    DGV.Rows.Add(lector.GetString(0), tipoReporte, lector.GetString(1), lector.GetString(2), lector.GetString(3), lector.GetValue(4), lector.GetValue(5))
                End While
                lector.Close()
            Else
                MsgBox("No hay Reportes de Docentes del Edificio y Aula Seleccionados!", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub
    Private Sub txtEdificio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtEdificio.SelectedIndexChanged
        If txtEdificio.SelectedIndex >= 27 Then
            txtAula.SelectedIndex = 9
            txtAula.Enabled = False
        Else
            txtAula.Enabled = True
            txtAula.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtAula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAula.SelectedIndexChanged
        If txtEdificio.SelectedIndex < 27 Then

            If txtAula.SelectedIndex = 9 Then
                MsgBox("Un Edificio con A-Z no puede llevar un '*' como Aula!", MsgBoxStyle.Information, "ATENCIÓN")
                txtAula.SelectedIndex = 0
            End If
        End If
    End Sub
End Class