'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class AtencionReportes_Terminar
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
                command.CommandText = "UPDATE `ATENCIONFALLAS` SET `Estado`='Terminado',`Observacion`='" & txtObservacion.Text & "' WHERE `IdAtencion`=" & txtId.Value
                command.ExecuteNonQuery()
                If (MP.busquedaIdRecurso("CAÑONES", txtidRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `CAÑONES` SET `Estado`= '" & cboEstadoRecurso.SelectedItem & "' WHERE IdRecurso= " & txtidRecurso.Text
                ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", txtidRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `COMPUTADORAS` SET `Estado`= '" & cboEstadoRecurso.SelectedItem & "' WHERE IdRecurso= " & txtidRecurso.Text
                ElseIf (MP.busquedaIdRecurso("PANTALLAS", txtidRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `PANTALLAS` SET `Estado`= '" & cboEstadoRecurso.SelectedItem & "' WHERE IdRecurso= " & txtidRecurso.Text
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
            cmdGrabar.Enabled = False
            lblGraba.Visible = False
            Limpiartxt()
            connection.Close()
        End If
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Me.Close()
    End Sub
    Private Sub Limpiartxt()
        txtId.Value = 0
        txtTipo.Text = ""
        txtFechaS.Text = ""
        txtAtiende.Text = ""
        txtObservacion.Text = ""
        txtObservacion.Enabled = False
        txtIdReporte.Text = ""
        txtFecha.Text = ""
        txtObservacionesRep.Text = ""
        txtEstadoReporte.Text = ""
        txtidRecurso.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtCategoria.Text = ""
        txtinvcapece.Text = ""
        cboEstadoRecurso.SelectedIndex = 0
    End Sub
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        command.CommandText = "SELECT count(*) FROM `ATENCIONFALLAS` WHERE Estado='Pendiente' AND IdAtencion=" & txtId.Value
        lector = command.ExecuteReader
        lector.Read()
        Dim n As Integer = lector.GetInt32(0)
        lector.Close()
        If n <> 0 Then
            cmdGrabar.Enabled = True
            lblGraba.Visible = True
            txtObservacion.Enabled = True
            command.CommandText = "SELECT * FROM `ATENCIONFALLAS` WHERE IdAtencion=" & txtId.Value
            lector = command.ExecuteReader
            lector.Read()
            txtTipo.Text = lector.GetValue(3)
            txtFechaS.Text = lector.GetValue(4)
            txtAtiende.Text = lector.GetValue(5)
            txtObservacion.Text = lector.GetValue(6)
            txtIdReporte.Text = lector.GetValue(1)
            txtidRecurso.Text = lector.GetValue(2)
            lector.Close()
            Dim nRep As Integer
            command.CommandText = "SELECT count(*), R.Fecha, R.ObservacionesGrales, R.Estado FROM REPORTEDOCENTES AS R INNER JOIN ATENCIONFALLAS AS A ON A.IdReporte = R.IdReporte WHERE A.IdAtencion=" & txtId.Value & " AND R.Estado='Atendido'"
            lector = command.ExecuteReader
            lector.Read()
            nRep = lector.GetValue(0)
            If nRep <> 0 Then
                txtFecha.Text = lector.GetValue(1)
                txtObservacionesRep.Text = lector.GetValue(2)
                txtEstadoReporte.Text = lector.GetValue(3)
                lector.Close()
            Else
                lector.Close()
                command.CommandText = "SELECT count(*), R.Fecha, R.Concepto, R.Estado FROM REPORTESRECURSOSINDIVIDUALES AS R INNER JOIN ATENCIONFALLAS AS A ON A.IdReporte = R.IdReporteRecursos WHERE A.IdAtencion=" & txtId.Value & " AND R.Estado='Atendido'"
                lector = command.ExecuteReader
                lector.Read()
                nRep = lector.GetValue(0)
                If nRep <> 0 Then
                    txtFecha.Text = lector.GetValue(1)
                    txtObservacionesRep.Text = lector.GetValue(2)
                    txtEstadoReporte.Text = lector.GetValue(3)
                Else
                    MsgBox("Ocurrio un error durante la carga de Informacion del reporte", MsgBoxStyle.Critical, "ERROR")
                End If
                lector.Close()
            End If
            If MP.busquedaIdRecurso("CAÑONES", txtidRecurso.Text) = 1 Then
                txtCategoria.Text = "CAÑONES"
            ElseIf MP.busquedaIdRecurso("COMPUTADORAS", txtidRecurso.Text) = 1 Then
                txtCategoria.Text = "COMPUTADORAS"
            ElseIf MP.busquedaIdRecurso("PANTALLAS", txtidRecurso.Text) = 1 Then
                txtCategoria.Text = "PANTALLAS"
            End If
            command.CommandText = "SELECT INVCAPECE, Modelo, Marca FROM " & txtCategoria.Text & " WHERE IdRecurso=" & txtidRecurso.Text
            lector = command.ExecuteReader
            lector.Read()
            txtinvcapece.Text = lector.GetValue(0)
            txtModelo.Text = lector.GetValue(1)
            txtMarca.Text = lector.GetValue(2)
            lector.Close()
            cboEstadoRecurso.Items.Clear()
            cboEstadoRecurso.Items.Add("---")
            command.CommandText = "SELECT count(*) FROM RECURSOSASIGNADOS WHERE Estado = 'Vigente' AND IdRecurso=" & txtidRecurso.Text
            lector = command.ExecuteReader
            lector.Read()
            If lector.GetInt32(0) <> 0 Then
                cboEstadoRecurso.Items.Add("Asignado")
            Else
                cboEstadoRecurso.Items.Add("Disponible")
            End If
            lector.Close()
            cboEstadoRecurso.Items.Add("Irreparable")
            GroupBox1.Enabled = True
            cmdGrabar.Enabled = True
        Else
            MsgBox("No hay un registro de Atencion a Fallas Pendiente con la ID ingresada!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
    Private Sub AtencionReportes_Terminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        cboEstadoRecurso.SelectedIndex = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
    End Sub
End Class