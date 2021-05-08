'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class AtencionReportes_Registrar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim MP As New MPTools
    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim transaction As MySqlTransaction
        transaction = connection.BeginTransaction()
        command.Connection = connection
        command.Transaction = transaction
        Try
            command.CommandText = "INSERT INTO `ATENCIONFALLAS` (IdReporte, IdRecurso, Tipo, FechaSeguimiento, QuienAtiende, 
                Observacion, Estado) VALUES (" & txtIdReporte.Text & "," & txtidRecurso.Text & ",'" & cboTipo.Text & "','" &
                DTP.Value.ToString("yyyy-MM-dd") & "','" & txtAtiende.Text & "','" & txtObservacion.Text & "','" & txtEstado.Text & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE `REPORTEDOCENTES` SET `Estado`= 'Atendido' WHERE IdReporte=" & txtIdReporte.Text
            command.ExecuteNonQuery()
            If (MP.busquedaIdRecurso("CAÑONES", txtidRecurso.Text) = 1) Then
                If RBSI.Checked = True Then
                    command.CommandText = "UPDATE `CAÑONES` SET `Estado`= 'Reparacion', `HorasLampara` = 0 WHERE IdRecurso= " & txtidRecurso.Text
                Else
                    command.CommandText = "UPDATE `CAÑONES` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & txtidRecurso.Text
                End If
            ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", txtidRecurso.Text) = 1) Then
                command.CommandText = "UPDATE `COMPUTADORAS` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & txtidRecurso.Text
            ElseIf (MP.busquedaIdRecurso("PANTALLAS", txtidRecurso.Text) = 1) Then
                command.CommandText = "UPDATE `PANTALLAS` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & txtidRecurso.Text
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
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        Limpiartxt()
    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        command.CommandText = "SELECT count(*) FROM ATENCIONFALLAS" 'SELECT TOP, SELECT BOTTOM 
        lector = command.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector.GetInt32(0)
        lector.Close()
        If aux > 0 Then
            command.CommandText = "SELECT IdAtencion FROM ATENCIONFALLAS ORDER BY IdAtencion DESC LIMIT 1"
            lector = command.ExecuteReader
            lector.Read()
            n = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
            ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
            txtId.Text = n
            lector.Close()
        Else
            txtId.Text = ""
        End If
        GroupBox1.Enabled = True
        cmdNuevo.Enabled = False
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Me.Close()
    End Sub

    Private Sub Limpiartxt()
        txtId.Text = ""
        cboTipoReporte.SelectedIndex = 0
        DTPPeriodoInicio.Value = Date.Today
        DTPPeriodoFin.Value = Date.Today
        txtIdReporte.Text = ""
        txtFecha.Text = ""
        txtObservacionesRep.Text = ""
        txtEstadoReporte.Text = ""
        txtidRecurso.Text = ""
        cboCategoria.SelectedIndex = 0
        txtEdificio.Text = ""
        txtAula.Text = ""
        txtinvcapece.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtEstadoRecurso.Text = ""
        cboTipo.SelectedIndex = 0
        DTP.Value = Date.Today
        txtObservacion.Text = ""
        txtAtiende.Text = ""
        RBNO.Checked = True
        lblEdificio.Visible = False
        lblAula.Visible = False
        txtEdificio.Visible = False
        txtAula.Visible = False
        GBRecurso.Enabled = False
        GBAtencion.Enabled = False
    End Sub

    Private Sub Reportes_Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DTP.Value = Date.Today
        DTPPeriodoInicio.Value = Date.Today
        DTPPeriodoFin.Value = Date.Today
        RBNO.Checked = True
        cboTipoReporte.SelectedIndex = 0
        cboTipo.SelectedIndex = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
    End Sub
    Private Sub RB_CheckedChanged(sender As Object, e As EventArgs)
        If RBNO.Checked = True Then
            RBSI.Checked = False
        End If
        If RBSI.Checked = True Then
            RBNO.Checked = False
        End If
    End Sub

    Private Sub cmdBuscarReporte_Click(sender As Object, e As EventArgs) Handles cmdBuscarReporte.Click
        If cboTipoReporte.SelectedIndex = 0 Then
            MsgBox("No se ha seleccionado el tipo de Reporte!", MsgBoxStyle.Critical, "ERROR")
        Else
            tipoReporte = cboTipoReporte.SelectedItem
            pFechaInicio = DTPPeriodoInicio.Value.ToString("yyyy-MM-dd")
            pFechaFin = DTPPeriodoFin.Value.ToString("yyyy-MM-dd")
            If cboTipoReporte.SelectedIndex = 1 Then
                command.CommandText = "SELECT count(*) FROM REPORTEDOCENTES WHERE Fecha BETWEEN '" & pFechaInicio &
                "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
                lector = command.ExecuteReader
                lector.Read()
                Dim n As Integer = lector.GetInt32(0)
                If n = 0 Then
                    MsgBox("No hay un Reporte Docente Pendiente registrado en ese periodo!", MsgBoxStyle.Critical, "ERROR")
                Else
                    lblEdificio.Visible = True
                    lblAula.Visible = True
                    txtEdificio.Visible = True
                    txtAula.Visible = True
                    Reportes_Buscar.ShowDialog()
                    GBRecurso.Enabled = True
                    GBReporte.Enabled = True
                    txtEdificio.Text = recursoasignadoEdificio
                    txtAula.Text = recursoasignadoAula
                    txtIdReporte.Text = idReporte_1
                    txtFecha.Text = fecha_1
                    txtObservacionesRep.Text = observaciones_1
                    txtEstadoReporte.Text = estadoreporte_1
                End If
                lector.Close()
            ElseIf cboTipoReporte.SelectedIndex = 2 Then
                command.CommandText = "SELECT count(*) FROM REPORTESRECURSOSINDIVIDUALES WHERE Fecha BETWEEN '" & pFechaInicio &
            "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
                lector = command.ExecuteReader
                lector.Read()
                Dim n As Integer = lector.GetInt32(0)
                lector.Close()
                If n = 0 Then
                    MsgBox("No hay un Reporte Individual Pendiente registrado en ese periodo!", MsgBoxStyle.Critical, "ERROR")
                Else
                    lblEdificio.Visible = False
                    lblAula.Visible = False
                    txtEdificio.Visible = False
                    txtAula.Visible = False
                    GBRecurso.Enabled = False
                    Reportes_Buscar.ShowDialog()
                    txtIdReporte.Text = idReporte_1
                    txtFecha.Text = fecha_1
                    txtObservacionesRep.Text = observaciones_1
                    txtEstadoReporte.Text = estadoreporte_1
                    command.CommandText = "SELECT IdRecurso FROM REPORTESRECURSOSINDIVIDUALES WHERE IdReporteRecursos = " & idReporte_1
                    lector = command.ExecuteReader
                    lector.Read()
                    txtidRecurso.Text = lector.GetValue(0)
                    lector.Close()
                    If MP.busquedaIdRecurso("CAÑONES", txtidRecurso.Text) = 1 Then
                        cboCategoria.SelectedIndex = 1
                        lblCambioLampara.Visible = True
                        RBNO.Visible = True
                        RBSI.Visible = True
                    ElseIf MP.busquedaIdRecurso("COMPUTADORAS", txtidRecurso.Text) = 1 Then
                        cboCategoria.SelectedIndex = 2
                    ElseIf MP.busquedaIdRecurso("PANTALLAS", txtidRecurso.Text) = 1 Then
                        cboCategoria.SelectedIndex = 3
                    End If
                    command.CommandText = "SELECT INVCAPECE, Modelo, Marca, Estado FROM " & cboCategoria.SelectedItem & " WHERE IdRecurso=" & txtidRecurso.Text
                    lector = command.ExecuteReader
                    lector.Read()
                    txtinvcapece.Text = lector.GetValue(0)
                    txtModelo.Text = lector.GetValue(1)
                    txtMarca.Text = lector.GetValue(2)
                    txtEstado.Text = lector.GetValue(3)
                    lector.Close()
                    GBAtencion.Enabled = True
                    cmdGrabar.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub cmdBuscarRecurso_Click(sender As Object, e As EventArgs) Handles cmdBuscarRecurso.Click
        If cboCategoria.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar una categoría de Recurso!", MsgBoxStyle.Critical, "ERROR")
        Else
            command.CommandText = "SELECT count(*) FROM RECURSOSASIGNADOS AS RA INNER JOIN " & cboCategoria.SelectedItem &
                    " AS R ON RA.IdRecurso = R.IdRecurso WHERE RA.Estado='Vigente' AND R.Estado='Asignado' AND RA.Edificio='" &
                    txtEdificio.Text & "' AND RA.Aula='" & txtAula.Text & "'"
            lector = command.ExecuteReader
            lector.Read()
            Dim n As Integer = lector.GetValue(0)
            lector.Close()
            If n = 0 Then
                MsgBox("NO hay recursos Asignados actualmente en el Edificio y Aula Seleccionados!", MsgBoxStyle.Critical, "ERROR")
            Else
                If cboCategoria.SelectedIndex = 1 Then
                    lblCambioLampara.Visible = True
                    RBNO.Visible = True
                    RBSI.Visible = True
                End If
                recursoasignadoEdificio = txtEdificio.Text
                recursoasignadoAula = txtAula.Text
                recursoAsignadoCat = cboCategoria.SelectedItem
                RecursoAsignado_Seleccionar.ShowDialog()
                txtinvcapece.Text = invcapece_1
                txtModelo.Text = modelo_1
                txtMarca.Text = marca_1
                txtEstadoRecurso.Text = estado_1
                txtidRecurso.Text = idRecurso_1
                GBAtencion.Enabled = True
                cmdGrabar.Enabled = True
            End If
        End If
    End Sub
End Class