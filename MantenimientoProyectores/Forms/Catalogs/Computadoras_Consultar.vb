﻿'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class Computadoras_Consultar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim tabla As String = "COMPUTADORAS"
    Dim idtabla As String = "idRecurso"
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
        pctCargando.Visible = True
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        updateDgv()
        If dgv.Rows.Count > 1 Then
            SelectedRowChanged()
        End If
        pctCargando.Visible = False
        Timer1.Stop()
    End Sub
    Private Sub updateDgv()
        dgv.Rows.Clear()
        command.CommandText = "Select * From " & tabla
        lector = command.ExecuteReader()
        While lector.Read
            dgv.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5),
                lector.GetValue(6), lector.GetValue(7), lector.GetValue(8), lector.GetValue(9), lector.GetValue(10))
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
        txtId.Value = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(0).Value
        txtInvcapece.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(1).Value
        txtFechaAdq.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(2).Value
        txtFechaMant.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(3).Value
        txtModelo.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(4).Value
        txtMarca.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(5).Value
        txtSerie.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(6).Value
        txtProcesador.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(7).Value
        txtMemoria.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(8).Value
        txtHDD.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(9).Value
        txtEstado.Text = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(10).Value
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Close()
    End Sub
End Class