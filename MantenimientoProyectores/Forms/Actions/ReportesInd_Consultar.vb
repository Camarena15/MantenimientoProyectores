'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class ReportesInd_Consultar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim tabla As String = "REPORTESRECURSOSINDIVIDUALES"
    Dim idtabla As String = "IdReporteRecursos"
    Dim MP As New MPTools
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        command.CommandText = "Select count(*) From " & tabla & " WHERE " & idtabla & "=" & txtId.Value
        lector = command.ExecuteReader
        lector.Read()
        Dim res As Integer = lector.GetInt32(0)
        lector.Close()
        If res = 1 Then
            Dim index As Integer = txtId.Value
            DGV.CurrentCell = DGV(0, index - 1)
            SelectedRowChanged()
        Else
            MsgBox("No hay un registro con la ID ingresada!", MsgBoxStyle.Critical, "ERROR")
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
        If DGV.Rows.Count > 1 Then
            SelectedRowChanged()
        End If
        Timer1.Stop()
    End Sub
    Private Sub updateDgv()
        DGV.Rows.Clear()
        command.CommandText = "Select * From " & tabla
        lector = command.ExecuteReader()
        While lector.Read
            DGV.Rows.Add(lector.GetString(0), lector.GetString(1), lector.GetString(2), lector.GetString(3), lector.GetString(4))
        End While
        lector.Close()
    End Sub
    Private Sub cmbInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        DGV.ClearSelection()
        DGV.CurrentCell = DGV(0, 0)
        SelectedRowChanged()
    End Sub

    Private Sub cmbSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        If DGV.CurrentCell.RowIndex <> DGV.Rows.Count - 2 Then
            Dim index As Integer = DGV.CurrentCell.RowIndex
            DGV.ClearSelection()
            DGV.CurrentCell = DGV(0, index + 1)
            SelectedRowChanged()
        End If
    End Sub

    Private Sub cmbAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        If DGV.CurrentCell.RowIndex <> 0 Then
            Dim index As Integer = DGV.CurrentCell.RowIndex
            DGV.ClearSelection()
            DGV.CurrentCell = DGV(0, index - 1)
            SelectedRowChanged()
        End If
    End Sub

    Private Sub cmbUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        DGV.ClearSelection()
        DGV.CurrentCell = DGV(0, DGV.Rows.Count - 2)
        SelectedRowChanged()
    End Sub
    Private Sub SelectedRowChanged()
        txtId.Value = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(0).Value
        txtidRecurso.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(1).Value
        txtFecha.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(2).Value
        txtObservaciones.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(3).Value
        txtEstado.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(4).Value
        If MP.busquedaIdRecurso("CAÑONES", txtidRecurso.Text) = 1 Then
            command.CommandText = "SELECT INVCAPECE, Modelo, Marca, Estado FROM CAÑONES WHERE IdRecurso=" & txtidRecurso.Text
            txtCategoria.Text = "CAÑONES"
        ElseIf MP.busquedaIdRecurso("COMPUTADORAS", txtidRecurso.Text) = 1 Then
            command.CommandText = "SELECT INVCAPECE, Modelo, Marca, Estado FROM COMPUTADORAS WHERE IdRecurso=" & txtidRecurso.Text
            txtCategoria.Text = "COMPUTADORAS"
        ElseIf MP.busquedaIdRecurso("PANTALLAS", txtidRecurso.Text) = 1 Then
            command.CommandText = "SELECT INVCAPECE, Modelo, Marca, Estado FROM PANTALLAS WHERE IdRecurso=" & txtidRecurso.Text
            txtCategoria.Text = "PANTALLAS"
        End If
        lector = command.ExecuteReader
        lector.Read()
        txtinvcapece.Text = lector.GetValue(0)
        txtModelo.Text = lector.GetValue(1)
        txtMarca.Text = lector.GetValue(2)
        txtEstadoRecurso.Text = lector.GetValue(3)
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Close()
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        opcion = "ReportesIndividualCon"
        Ayuda.ShowDialog()
    End Sub
End Class