'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.IO
Public Class Supervision_Consultar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim tabla As String = "SUPERVISION"
    Dim idtabla As String = "idSupervision"
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
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        DGVSupervision.RowTemplate.Height = 78
        updateDgv()
        If DGV.Rows.Count > 1 Then
            SelectedRowChanged()
        End If
        Timer1.Stop()
    End Sub
    Private Sub updateDgv()
        DGV.Rows.Clear()
        command.CommandText = "SELECT `IdSupervision`, `Fecha`, `Responsable`, `Edificio`, `Aula` FROM " & tabla
        lector = command.ExecuteReader()
        While lector.Read
            DGV.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4))
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
        btnDatosSecundarios.Visible = False
        txtId.Value = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(0).Value
        txtFecha.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(1).Value
        txtResponsable.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(2).Value
        txtEdificio.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(3).Value
        txtAula.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(4).Value
        DGVSupervision.Rows.Clear()
        command.CommandText = "SELECT * FROM `DETALLE-SUP-RECURSO` WHERE IdSupervision= " & txtId.Value
        lector = command.ExecuteReader
        While lector.Read()
            Dim idRec As Integer = lector.GetValue(1)
            Dim obs As String = lector.GetValue(2)
            Dim HT As String
            Dim img As String = lector.GetValue(4)
            MP.obtImagen(img)
            If IsDBNull(lector.GetValue(3)) Then
                HT = ""
            Else
                HT = lector.GetValue(3)
            End If
            DGVSupervision.Rows.Add(idRec, obs, HT, image)
        End While
        lector.Close()
        command.CommandText = "SELECT `ObservaCajaConex` FROM SUPERVISION WHERE `IdSupervision`=" & txtId.Value
        lector = command.ExecuteReader
        lector.Read()
        If IsDBNull(lector.GetValue(0)) = False Then
            indiceSupervision = txtId.Value()
            btnDatosSecundarios.Visible = True
        Else
            btnDatosSecundarios.Visible = False
        End If
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Close()
    End Sub

    Private Sub btnDatosSecundarios_Click(sender As Object, e As EventArgs) Handles btnDatosSecundarios.Click
        DetalleSupervision.ShowDialog()
    End Sub
End Class