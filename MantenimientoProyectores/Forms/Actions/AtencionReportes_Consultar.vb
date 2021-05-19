'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class AtencionReportes_Consultar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim tabla As String = "ATENCIONFALLAS"
    Dim idtabla As String = "idAtencion"
    Dim MP As New MPTools
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        command.CommandText = "Select count(*) From " & tabla & " WHERE " & idtabla & "=" & txtId.Value
        lector = command.ExecuteReader
        lector.Read()
        Dim res As Integer = lector.GetInt32(0)
        lector.Close()
        If res = 1 Then
            Dim index As Integer = txtId.Value
            dgv.CurrentCell = dgv(0, index - 1)
            SelectedRowChanged()
        Else
            MsgBox("No hay un registro con la ID ingresada!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
    Private Sub Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        updateDgv()
        If dgv.Rows.Count > 1 Then
            SelectedRowChanged()
        End If
        Timer1.Stop()
    End Sub
    Private Sub updateDgv()
        dgv.Rows.Clear()
        command.CommandText = "Select * From " & tabla
        lector = command.ExecuteReader()
        While lector.Read
            dgv.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5), lector.GetValue(7), lector.GetValue(6))
        End While
        lector.Close()

    End Sub
    Private Sub cmbInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        dgv.ClearSelection()
        dgv.CurrentCell = dgv(0, 0)
        SelectedRowChanged()
    End Sub
    Private Sub cmbSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        If dgv.CurrentCell.RowIndex <> dgv.Rows.Count - 2 Then
            Dim index As Integer = dgv.CurrentCell.RowIndex
            dgv.ClearSelection()
            dgv.CurrentCell = dgv(0, index + 1)
            SelectedRowChanged()
        End If
    End Sub

    Private Sub cmbAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        If dgv.CurrentCell.RowIndex <> 0 Then
            Dim index As Integer = dgv.CurrentCell.RowIndex
            dgv.ClearSelection()
            dgv.CurrentCell = dgv(0, index - 1)
            SelectedRowChanged()
        End If
    End Sub

    Private Sub cmbUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        dgv.ClearSelection()
        dgv.CurrentCell = dgv(0, dgv.Rows.Count - 2)
        SelectedRowChanged()
    End Sub
    Private Sub SelectedRowChanged()
        txtId.Value = dgv(0, dgv.CurrentCell.RowIndex).Value
        txtIdReporte.Text = dgv(1, dgv.CurrentCell.RowIndex).Value
        txtIdRecurso.Text = dgv(2, dgv.CurrentCell.RowIndex).Value
        txtTipo.Text = dgv(3, dgv.CurrentCell.RowIndex).Value
        txtFechaS.Text = dgv(4, dgv.CurrentCell.RowIndex).Value
        txtAtiende.Text = dgv(5, dgv.CurrentCell.RowIndex).Value
        txtObservacion.Text = dgv(7, dgv.CurrentCell.RowIndex).Value
        txtEstado.Text = dgv(6, dgv.CurrentCell.RowIndex).Value
        If (MP.busquedaIdRecurso("CAÑONES", txtIdRecurso.Text) = 1) Then
            command.CommandText = "SELECT Estado FROM CAÑONES WHERE IdRecurso=" & txtIdRecurso.Text
        ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", txtIdRecurso.Text) = 1) Then
            command.CommandText = "SELECT Estado FROM COMPUTADORAS WHERE IdRecurso=" & txtIdRecurso.Text
        ElseIf (MP.busquedaIdRecurso("PANTALLAS", txtIdRecurso.Text) = 1) Then
            command.CommandText = "SELECT Estado FROM PANTALLAS WHERE IdRecurso=" & txtIdRecurso.Text
        End If
        lector = command.ExecuteReader()
        lector.Read()
        txtEdoRecurso.Text = lector.GetValue(0)
        lector.Close()
        command.CommandText = "SELECT idCategoria FROM RECURSOS WHERE idRecursos=" & txtIdRecurso.Text
        lector = command.ExecuteReader
        lector.Read()
        txtidcat.Text = lector.GetValue(0)
        lector.Close()
        command.CommandText = "SELECT count(*), R.Fecha, R.Estado FROM REPORTEDOCENTES AS R INNER JOIN ATENCIONFALLAS AS A ON A.IdReporte = R.IdReporte WHERE A.IdAtencion=" & txtId.Value & " AND R.Estado='Atendido'"
        lector = command.ExecuteReader
        lector.Read()
        Dim nRep As Integer
        nRep = lector.GetValue(0)
        If nRep <> 0 Then
            txtFecha.Text = lector.GetValue(1)
            txtEstadoReporte.Text = lector.GetValue(2)
            lector.Close()
        Else
            lector.Close()
            command.CommandText = "SELECT count(*), R.Fecha, R.Estado FROM REPORTESRECURSOSINDIVIDUALES AS R INNER JOIN ATENCIONFALLAS AS A ON A.IdReporte = R.IdReporteRecursos WHERE A.IdAtencion=" & txtId.Value & " AND R.Estado='Atendido'"
            lector = command.ExecuteReader
            lector.Read()
            nRep = lector.GetValue(0)
            If nRep <> 0 Then
                txtFecha.Text = lector.GetValue(1)
                txtEstadoReporte.Text = lector.GetValue(2)
            Else
                MsgBox("Ocurrio un error durante la carga de Informacion del reporte", MsgBoxStyle.Critical, "ERROR")
            End If
            lector.Close()
        End If
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Close()
    End Sub
End Class