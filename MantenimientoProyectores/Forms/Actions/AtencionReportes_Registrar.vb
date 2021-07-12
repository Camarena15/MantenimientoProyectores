'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class AtencionReportes_Registrar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim MP As New MPTools
     Dim Fecha As String

    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Fecha = DTP.Value.Year & "/" & DTP.Value.Month & "/" & DTP.Value.Day
        Dim transaction As MySqlTransaction
        transaction = connection.BeginTransaction()
        command.Connection = connection
        command.Transaction = transaction
        Dim tipoReporte As String = ""
        If cboTipoReporte.SelectedIndex = 1 Then
            tipoReporte = "D"
        ElseIf cboTipoReporte.SelectedIndex = 2 Then
            tipoReporte = "I"
        End If
        Try

            command.CommandText = "INSERT INTO `ATENCIONFALLAS`(`IdReporte`, `TipoReporte`, `FechaSeguimiento`, `QuienAtiende`, `Estado`) VALUES (" &
                txtIdReporte.Text & ",'" & tipoReporte & "','" & DTP.Value.ToString("yyyy-MM-dd") & "','" & txtAtiende.Text & "','" & txtEstado.Text & "')"
            command.ExecuteNonQuery()
            '********************************************************************************************************************
            'OBTENER EL ULTIMO REGISTRO DE LA ATENCION QUE SE ACABA DE INSERTAR
            Dim idc As Integer
            If txtId.Text = "" Then 'PRIMER REGISTRO DESPUES DEL TRASPASO, SIN PRESENCIA DE REGISTROS EN LA TABLA
                command.CommandText = "SELECT IdAtencion FROM ATENCIONFALLAS ORDER BY IdAtencion DESC LIMIT 1"
                lector = command.ExecuteReader
                lector.Read()
                idc = lector.GetInt32(0)
                lector.Close()
            Else
                idc = txtId.Text
            End If
            '********************************************************************************************************************
            For i = 0 To LV.Items.Count - 1
                Dim r As String = "INSERT INTO `DETALLEATENCIONFALLAS`(`IdAtencion`, `IdRecurso`, `TipoAtencion`, `Observaciones`) 
                    VALUES (" & idc & "," & LV.Items.Item(i).SubItems.Item(0).Text & ",'" & LV.Items.Item(i).SubItems.Item(3).Text & "','" &
                    LV.Items.Item(i).SubItems.Item(4).Text & "')"
                command.CommandText = r
                command.ExecuteNonQuery()
            Next
            '**************************************************************************************************************
            If cboTipoReporte.SelectedItem.Equals("DOCENTE") Then
                command.CommandText = "UPDATE `REPORTEDOCENTES` SET `Estado`= 'Atendido' WHERE IdReporte=" & txtIdReporte.Text

            Else
                command.CommandText = "UPDATE `REPORTESRECURSOSINDIVIDUALES` SET `Estado`= 'Atendido' WHERE IdReporteRecursos=" & txtIdReporte.Text
            End If
            command.ExecuteNonQuery()
            For i = 0 To LV.Items.Count - 1
                If (MP.busquedaIdRecurso("CAÑONES", LV.Items.Item(i).SubItems.Item(0).Text) = 1) Then
                    If LV.Items.Item(i).SubItems.Item(5).Text.Equals("True") Then
                        command.CommandText = "UPDATE `CAÑONES` SET `Estado`= 'Reparacion', `HorasLampara` = 0 WHERE IdRecurso= " & LV.Items.Item(i).SubItems.Item(0).Text
                    Else
                        command.CommandText = "UPDATE `CAÑONES` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & LV.Items.Item(i).SubItems.Item(0).Text
                    End If
                ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", LV.Items.Item(i).SubItems.Item(0).Text) = 1) Then
                    command.CommandText = "UPDATE `COMPUTADORAS` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & LV.Items.Item(i).SubItems.Item(0).Text
                ElseIf (MP.busquedaIdRecurso("PANTALLAS", LV.Items.Item(i).SubItems.Item(0).Text) = 1) Then
                    command.CommandText = "UPDATE `PANTALLAS` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & LV.Items.Item(i).SubItems.Item(0).Text
                End If
                command.ExecuteNonQuery()
            Next
            transaction.Commit()
        Catch ex As Exception
            bitacora.InsertarError("GUARDAR ATENCIÓN REPORTES", ex.Message, ex.HResult, Fecha)
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
            n = lector(0) + 1
            txtId.Text = n
            lector.Close()
        Else
            txtId.Text = ""
        End If
        GBTipoReporte.Enabled = True
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
        txtEstadoRecurso.Text = ""
        cboTipo.SelectedIndex = 0
        DTP.Value = Date.Today
        txtObservacionRecursos.Text = ""
        txtAtiende.Text = ""
        RBNO.Checked = True
        lblEdificio.Visible = False
        lblAula.Visible = False
        txtEdificio.Visible = False
        txtAula.Visible = False
        GBRecursos.Enabled = False
        GBAtencion.Enabled = False
        GBTipoReporte.Enabled = False
        cmdAgregaD.Enabled = False
        cmdBack.Enabled = False
        LV.Items.Clear()
    End Sub

    Private Sub Reportes_Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DTP.Value = Date.Today
        DTPPeriodoInicio.Value = Date.Today
        DTPPeriodoFin.Value = Date.Today
        RBNO.Checked = True
        cboTipoReporte.SelectedIndex = 0
        cboTipo.SelectedIndex = 0
        cboCategoria.SelectedIndex = 0
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btnAyuda, "¿Necesitas ayuda?")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
    End Sub
    Private Sub RB_CheckedChanged(sender As Object, e As EventArgs) Handles RBNO.CheckedChanged
        If RBNO.Checked = True Then
            RBSI.Checked = False
        End If
        If RBSI.Checked = True Then
            RBNO.Checked = False
        End If
    End Sub

    Private Sub cmdBuscarReporte_Click(sender As Object, e As EventArgs) Handles cmdBuscarReporte.Click
        Dim itemsSaver As New ArrayList
        itemsSaver.Add(cboTipoReporte.SelectedIndex)
        itemsSaver.Add(DTPPeriodoInicio.Value)
        itemsSaver.Add(DTPPeriodoFin.Value)
        Limpiartxt()
        GBTipoReporte.Enabled = True
        cboTipoReporte.SelectedIndex = itemsSaver(0)
        DTPPeriodoInicio.Value = itemsSaver(1)
        DTPPeriodoFin.Value = itemsSaver(2)
        If cboTipoReporte.SelectedIndex = 0 Then
            MsgBox("¡No se ha seleccionado el tipo de Reporte!", MsgBoxStyle.Critical, "ERROR")
        Else
            tipoReporte = cboTipoReporte.SelectedItem
            pFechaInicio = DTPPeriodoInicio.Value.ToString("yyyy-MM-dd")
            pFechaFin = DTPPeriodoFin.Value.ToString("yyyy-MM-dd")
            If cboTipoReporte.SelectedIndex = 1 Then
                cboCategoria.Enabled = True
                command.CommandText = "SELECT count(*) FROM REPORTEDOCENTES WHERE Fecha BETWEEN '" & pFechaInicio &
                "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
                lector = command.ExecuteReader
                lector.Read()
                Dim n As Integer = lector.GetInt32(0)
                If n = 0 Then
                    MsgBox("¡No hay un Reporte Docente Pendiente registrado en ese periodo!", MsgBoxStyle.Critical, "ERROR")
                Else
                    lblEdificio.Visible = True
                    lblAula.Visible = True
                    txtEdificio.Visible = True
                    txtAula.Visible = True
                    Reportes_Buscar.ShowDialog()
                    If obtainedInfoRep = True Then
                        obtainedInfoRep = False
                        GBRecursos.Enabled = True
                        cmdBuscarRecurso.Enabled = True
                        txtEdificio.Text = recursoasignadoEdificio
                        txtAula.Text = recursoasignadoAula
                        txtIdReporte.Text = idReporte_1
                        txtFecha.Text = fecha_1
                        txtObservacionesRep.Text = observaciones_1
                        txtEstadoReporte.Text = estadoreporte_1
                    End If
                End If
                lector.Close()
            ElseIf cboTipoReporte.SelectedIndex = 2 Then
                cboCategoria.Enabled = False
                command.CommandText = "SELECT count(*) FROM REPORTESRECURSOSINDIVIDUALES WHERE Fecha BETWEEN '" & pFechaInicio &
            "' AND '" & pFechaFin & "' AND Estado='Pendiente'"
                lector = command.ExecuteReader
                lector.Read()
                Dim n As Integer = lector.GetInt32(0)
                lector.Close()
                If n = 0 Then
                    MsgBox("¡No hay un Reporte Individual Pendiente registrado en ese periodo!", MsgBoxStyle.Critical, "ERROR")
                Else
                    lblEdificio.Visible = False
                    lblAula.Visible = False
                    txtEdificio.Visible = False
                    txtAula.Visible = False
                    GBRecursos.Enabled = True
                    cmdBuscarRecurso.Enabled = False
                    Reportes_Buscar.ShowDialog()
                    If obtainedInfoRep = True Then
                        obtainedInfoRep = False
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
                        command.CommandText = "SELECT INVCAPECE, Estado FROM " & cboCategoria.SelectedItem & " WHERE IdRecurso=" & txtidRecurso.Text
                        lector = command.ExecuteReader
                        lector.Read()
                        txtinvcapece.Text = lector.GetValue(0)
                        txtEstadoRecurso.Text = lector.GetValue(1)
                        lector.Close()
                        cmdAgregaD.Enabled = True
                        GBAtencion.Enabled = True
                        cmdGrabar.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cmdBuscarRecurso_Click(sender As Object, e As EventArgs) Handles cmdBuscarRecurso.Click
        If cboCategoria.SelectedIndex = 0 Then
            MsgBox("¡Debe seleccionar una categoría de Recurso!", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim n As Integer
            If cboCategoria.SelectedIndex = 1 Or cboCategoria.SelectedIndex = 2 Or cboCategoria.SelectedIndex = 3 Then
                command.CommandText = "SELECT count(*) FROM RECURSOSASIGNADOS AS RA INNER JOIN " & cboCategoria.SelectedItem &
                    " AS R ON RA.IdRecurso = R.IdRecurso WHERE RA.Estado='Vigente' AND R.Estado='Asignado' AND RA.Edificio='" &
                    txtEdificio.Text & "' AND RA.Aula='" & txtAula.Text & "'"
                lector = command.ExecuteReader
                lector.Read()
                n = lector.GetValue(0)
                lector.Close()
            ElseIf cboCategoria.SelectedIndex = 4 Or cboCategoria.SelectedIndex = 5 Then
                n = 1
            End If
            If n = 0 Then
                MsgBox("¡NO hay recursos Asignados actualmente en el Edificio y Aula Seleccionados!", MsgBoxStyle.Critical, "ERROR")
            Else
                    If cboCategoria.SelectedIndex = 1 Then
                        lblCambioLampara.Visible = True
                        RBNO.Visible = True
                        RBSI.Visible = True
                    End If
                    recursoasignadoEdificio = txtEdificio.Text
                    recursoasignadoAula = txtAula.Text
                    recursoCat = cboCategoria.SelectedItem
                    RecursoAsignado_Seleccionar.ShowDialog()
                    If obtainedInfoRec = True Then
                        obtainedInfoRec = False
                        txtinvcapece.Text = invcapece_1
                        txtEstadoRecurso.Text = estado_1
                        txtidRecurso.Text = idRecurso_1
                        GBAtencion.Enabled = True
                        cmdAgregaD.Enabled = True
                    End If
                End If
            End If
    End Sub

    Private Sub cmdAgregaD_Click(sender As Object, e As EventArgs) Handles cmdAgregaD.Click
        Dim verificaRejillas As Boolean
        For x As Integer = 0 To LV.Items.Count - 1
            If txtidRecurso.Text.Equals(LV.Items.Item(x).SubItems.Item(0).Text) Then
                verificaRejillas = True
            End If
        Next
        If verificaRejillas = False Then
            Dim fila As New ListViewItem(txtidRecurso.Text)
            fila.SubItems.Add(txtinvcapece.Text)
            fila.SubItems.Add(cboCategoria.SelectedItem)
            fila.SubItems.Add(cboTipo.SelectedItem)
            fila.SubItems.Add(txtObservacionRecursos.Text)
            If cboCategoria.SelectedIndex = 1 Then
                fila.SubItems.Add(RBSI.Checked)
            Else
                fila.SubItems.Add("")
            End If
            LV.Items.Add(fila)
            txtidRecurso.Text = ""
            txtinvcapece.Text = ""
            txtEstadoRecurso.Text = ""
            cboCategoria.SelectedIndex = 0
            cboTipo.SelectedIndex = 0
            txtObservacionRecursos.Text = ""
            If cboTipoReporte.SelectedIndex = 1 Then
                cmdBack.Enabled = True
            End If
            lblCambioLampara.Visible = False
            RBNO.Checked = True
            RBNO.Visible = False
            RBSI.Visible = False
            cmdGrabar.Enabled = True
            cmdAgregaD.Enabled = False
        Else
            MsgBox("¡Este registro ya se ha seleccionado previamente!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        If LV.Items.Count > 0 Then
            Dim ultimo As Integer = LV.Items.Count - 1
            LV.Items.RemoveAt(ultimo)
            If ultimo = 0 Then
                cmdBack.Enabled = False
                cmdGrabar.Enabled = False
            End If
        End If

    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged

    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        opcion = "Atencion"
        Ayuda.ShowDialog()
    End Sub
End Class