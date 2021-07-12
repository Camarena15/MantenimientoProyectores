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
            MsgBox("¡No hay un registro con la ID ingresada!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
    Private Sub Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btnAyuda, "¿Necesitas ayuda?")
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
            Dim TipoReporte As String = ""
            If lector.GetString(2).Equals("D") Then
                TipoReporte = "DOCENTE"
            ElseIf lector.GetString(2).Equals("I") Then
                TipoReporte = "INDIVIDUAL"
            End If
            dgv.Rows.Add(lector.GetValue(0), lector.GetValue(1), TipoReporte, lector.GetValue(3), lector.GetValue(4), lector.GetValue(5))
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
        dgvRecursos.Rows.Clear()
        txtId.Value = dgv(0, dgv.CurrentCell.RowIndex).Value
        txtIdReporte.Text = dgv(1, dgv.CurrentCell.RowIndex).Value
        txtTipoReporte.Text = dgv(2, dgv.CurrentCell.RowIndex).Value
        txtFechaS.Text = dgv(3, dgv.CurrentCell.RowIndex).Value
        txtAtiende.Text = dgv(4, dgv.CurrentCell.RowIndex).Value
        txtEstado.Text = dgv(5, dgv.CurrentCell.RowIndex).Value

        command.CommandText = "SELECT * FROM DETALLEATENCIONFALLAS WHERE IdAtencion=" & txtId.Value
        lector = command.ExecuteReader
        While lector.Read()
            dgvRecursos.Rows.Add(lector.GetValue(1), "", lector.GetValue(2), lector.GetValue(3), "")
        End While
        lector.Close()

        Dim categoria As String = ""
        For i = 0 To dgvRecursos.Rows.Count - 2
            If (MP.busquedaIdRecurso("CAÑONES", dgvRecursos(0, i).Value) = 1) Then
                categoria = "CAÑONES"
                command.CommandText = "SELECT Estado FROM CAÑONES WHERE IdRecurso=" & dgvRecursos(0, i).Value
                lector = command.ExecuteReader
                lector.Read()
                dgvRecursos(4, i).Value = lector.GetValue(0)
                lector.Close()
            ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", dgvRecursos(0, i).Value) = 1) Then
                categoria = "COMPUTADORAS"
                command.CommandText = "SELECT Estado FROM COMPUTADORAS WHERE IdRecurso=" & dgvRecursos(0, i).Value
                lector = command.ExecuteReader
                lector.Read()
                dgvRecursos(4, i).Value = lector.GetValue(0)
                lector.Close()
            ElseIf (MP.busquedaIdRecurso("PANTALLAS", dgvRecursos(0, i).Value) = 1) Then
                categoria = "PANTALLAS"
                command.CommandText = "SELECT Estado FROM PANTALLAS WHERE IdRecurso=" & dgvRecursos(0, i).Value
                lector = command.ExecuteReader
                lector.Read()
                dgvRecursos(4, i).Value = lector.GetValue(0)
                lector.Close()
            Else
                command.CommandText = "SELECT C.Concepto FROM CATEGORIA AS C INNER JOIN RECURSOS AS R ON C.idCategoria = R.idCategoria WHERE R.idRecursos=" & dgvRecursos(0, i).Value
                lector = command.ExecuteReader
                lector.Read()
                categoria = lector.GetValue(0)
                lector.Close()
                dgvRecursos(4, i).Value = "---"
            End If
            dgvRecursos(1, i).Value = categoria
        Next
        Dim r As String = ""
        If txtTipoReporte.Text.Equals("DOCENTE") Then
            r = "SELECT Fecha, Estado FROM REPORTEDOCENTES WHERE IdReporte=" & txtIdReporte.Text
        Else
            r = "SELECT Fecha, Estado FROM REPORTESRECURSOSINDIVIDUALES WHERE IdReporteRecursos=" & txtIdReporte.Text
        End If
        command.CommandText = r
        lector = command.ExecuteReader
        lector.Read()
        txtFecha.Text = lector.GetValue(0)
        txtEstadoReporte.Text = lector.GetValue(1)
        lector.Close()
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Close()
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        opcion = "AtencionRConsulta"
        Ayuda.ShowDialog()
    End Sub
End Class