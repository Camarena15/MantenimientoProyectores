'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class Preventivo_Terminar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim RecAsigTrue As Integer
    Dim MP As New MPTools
    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If cboEstadoRecurso.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un Estado para el Recurso!", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim transaction As MySqlTransaction
            transaction = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = transaction
            Try
                command.CommandText = "UPDATE `PREVENTIVO` SET `Estado`= 'Terminado', `FechaFin`='" & txtFechaFinal.Value.ToString("yyyy-MM-dd") & "',`Observacion`='" & txtObservaciones.Text & "'  WHERE IdPreventivo= " & txtId.Value
                command.ExecuteNonQuery()
                If (MP.busquedaIdRecurso("CAÑONES", txtIdRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `CAÑONES` SET `Estado`= '" & cboEstadoRecurso.SelectedItem & "' WHERE IdRecurso= " & txtIdRecurso.Text
                ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", txtIdRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `COMPUTADORAS` SET `Estado`= '" & cboEstadoRecurso.SelectedItem & "' WHERE IdRecurso= " & txtIdRecurso.Text
                ElseIf (MP.busquedaIdRecurso("PANTALLAS", txtIdRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `PANTALLAS` SET `Estado`= '" & cboEstadoRecurso.SelectedItem & "' WHERE IdRecurso= " & txtIdRecurso.Text
                End If
                command.ExecuteNonQuery()
                transaction.Commit()
            Catch ex As Exception
                MsgBox("Commit Exception Type: {0} no se pudo insertar por error")
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error RollBack")
                End Try
            End Try
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            cmdGrabar.Enabled = False
            Limpiartxt()
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Me.Close()
    End Sub

    Private Sub Limpiartxt()
        txtId.Value = 0
        txtIdRecurso.Text = ""
        txtCategoria.Text = ""
        txtinvcapece.Text = ""
        cboEstadoRecurso.SelectedIndex = 0
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtAtiende.Text = ""
        txtConcepto.Text = ""
        txtCategoria.Text = ""
        txtObservaciones.Text = ""
        txtObservaciones.Enabled = False
        txtTipoServicio.Text = ""
        txtFechaInicial.Text = ""
        txtFechaFinal.Value = Date.Today
    End Sub

    Private Sub Reportes_Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        cboEstadoRecurso.SelectedIndex = 0
        txtFechaFinal.Value = Date.Today
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        command.CommandText = "SELECT count(*) FROM `PREVENTIVO` WHERE `IdPreventivo`=" & txtId.Value
        lector = command.ExecuteReader
        lector.Read()
        Dim n As Integer = lector.GetInt32(0)
        lector.Close()
        If n <> 0 Then
            command.CommandText = "SELECT * FROM `PREVENTIVO` WHERE `IdPreventivo`=" & txtId.Value
            lector = command.ExecuteReader
            lector.Read()
            txtTipoServicio.Text = lector.GetValue(1)
            txtFechaInicial.Text = lector.GetValue(2)
            txtFechaFinal.Text = lector.GetValue(3)
            txtIdRecurso.Text = lector.GetValue(4)
            txtConcepto.Text = lector.GetValue(5)
            txtAtiende.Text = lector.GetValue(6)
            txtObservaciones.Text = lector.GetValue(7)
            lector.Close()
            If MP.busquedaIdRecurso("CAÑONES", txtIdRecurso.Text) = 1 Then
                txtCategoria.Text = "CAÑONES"
            ElseIf MP.busquedaIdRecurso("COMPUTADORAS", txtIdRecurso.Text) = 1 Then
                txtCategoria.Text = "COMPUTADORAS"
            ElseIf MP.busquedaIdRecurso("PANTALLAS", txtIdRecurso.Text) = 1 Then
                txtCategoria.Text = "PANTALLAS"
            End If
            command.CommandText = "SELECT INVCAPECE, Modelo, Marca FROM " & txtCategoria.Text & " WHERE IdRecurso=" & txtIdRecurso.Text
            lector = command.ExecuteReader
            lector.Read()
            txtinvcapece.Text = lector.GetValue(0)
            txtModelo.Text = lector.GetValue(1)
            txtMarca.Text = lector.GetValue(2)
            lector.Close()
            cmdGrabar.Enabled = True
            txtObservaciones.Enabled = True
            cboEstadoRecurso.Items.Clear()
            cboEstadoRecurso.Items.Add("---")
            command.CommandText = "SELECT count(*) FROM RECURSOSASIGNADOS WHERE Estado = 'Vigente' AND IdRecurso=" & txtIdRecurso.Text
            lector = command.ExecuteReader
            lector.Read()
            If lector.GetInt32(0) <> 0 Then
                cboEstadoRecurso.Items.Add("Asignado")
            Else
                cboEstadoRecurso.Items.Add("Disponible")
            End If
            lector.Close()
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            cmdGrabar.Enabled = True
        Else
            MsgBox("No hay un registro de Preventivo con la ID ingresada!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
End Class