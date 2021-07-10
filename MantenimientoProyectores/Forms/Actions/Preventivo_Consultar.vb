'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class Preventivo_Consultar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim tabla As String = "PREVENTIVO"
    Dim idtabla As String = "idPreventivo"
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
            DGV.Rows.Add(lector.GetString(0), lector.GetString(4), lector.GetString(1), lector.GetString(2), lector.GetString(3), lector.GetString(5),
                lector.GetString(6), lector.GetString(7), lector.GetString(8))
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
        txtTipoS.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(2).Value
        Dim fechai, fechaf As Date
        fechai = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(3).Value
        fechaf = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(4).Value
        txtFechaI.Text = fechai.ToString("dd/MM/yyyy")
        txtIdRecurso.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(1).Value
        txtConcepto.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(5).Value
        txtAtiende.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(6).Value
        txtObservaciones.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(7).Value
        txtEstado.Text = DGV.Rows(DGV.CurrentCell.RowIndex).Cells(8).Value
        If txtEstado.Text.Equals("Terminado") Then
            txtFechaF.Text = fechaf.ToString("dd/MM/yyyy")
        Else
            txtFechaF.Text = ""
        End If
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
        command.CommandText = "SELECT R.idCategoria, C.Concepto FROM RECURSOS AS R INNER JOIN CATEGORIA AS C ON R.idCategoria=C.idCategoria WHERE idRecursos=" & txtIdRecurso.Text
        lector = command.ExecuteReader
        lector.Read()
        txtidcat.Text = lector.GetValue(0)
        txtCategoria.Text = lector.GetValue(1)
        lector.Close()
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Close()
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        opcion = "AtencionPreventivoCon"
        Ayuda.ShowDialog()
    End Sub
End Class