'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class AtencionReportes_Terminar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim lector2 As MySqlDataReader
    Dim RecAsigTrue As Integer
    Dim MP As New MPTools
    Dim Fecha As String
    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If verificaRejilla() = False Then
            MsgBox("Debe seleccionar un Estado para los Recursos que sean CAÑONES, COMPUTADORAS O PANTALLAS", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim transaction As MySqlTransaction
            transaction = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = transaction
            Try
                Fecha = DTP.Value.Year & "/" & DTP.Value.Month & "/" & DTP.Value.Day
                command.CommandText = "UPDATE ATENCIONFALLAS SET Estado='Terminado' WHERE IdAtencion=" & txtId.Value
                command.ExecuteNonQuery()

                For i = 0 To dgv.Rows.Count - 2
                    If (MP.busquedaIdRecurso("CAÑONES", dgv(0, i).Value) = 1) Then
                        command.CommandText = "UPDATE `CAÑONES` SET `Estado`= '" & dgv(4, i).Value & "' WHERE IdRecurso= " & dgv(0, i).Value
                    ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", dgv(0, i).Value) = 1) Then
                        command.CommandText = "UPDATE `COMPUTADORAS` SET `Estado`= '" & dgv(4, i).Value & "' WHERE IdRecurso= " & dgv(0, i).Value
                    ElseIf (MP.busquedaIdRecurso("PANTALLAS", dgv(0, i).Value) = 1) Then
                        command.CommandText = "UPDATE `PANTALLAS` SET `Estado`= '" & dgv(4, i).Value & "' WHERE IdRecurso= " & dgv(0, i).Value
                    End If
                    command.ExecuteNonQuery()
                Next
                For i = 0 To dgv.Rows.Count - 2
                    command.CommandText = "UPDATE DETALLEATENCIONFALLAS SET Observaciones='" & dgv(3, i).Value & "' WHERE IdAtencion=" & txtId.Value &
                        " AND IdRecurso=" & dgv(0, i).Value
                    command.ExecuteNonQuery()
                Next
                transaction.Commit()
            Catch ex As Exception
                bitacora.InsertarError("GUARDAR ATENCIÓN REPORTES TERMINAR", ex.Message, ex.HResult, Fecha)
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
        End If
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Me.Close()
    End Sub
    Private Sub Limpiartxt()
        dgv.Rows.Clear()
        txtId.Value = 0
        txtFechaS.Text = ""
        txtAtiende.Text = ""
        txtIdReporte.Text = ""
        txtTipoReporte.Text = ""
        DTPPeriodoInicio.Value = Date.Today
        DTPPeriodoFin.Value = Date.Today
        txtFecha.Text = ""
        txtObservacionesRep.Text = ""
        txtEstadoReporte.Text = ""
    End Sub
    Private Function verificaRejilla() As Boolean
        For i = 0 To dgv.Rows.Count - 2
            If dgv(1, i).Value.Equals("CAÑONES") Or dgv(1, i).Value.Equals("COMPUTADORAS") Or dgv(1, i).Value.Equals("PANTALLAS") Then
                If dgv(4, i).Value.Equals("---") Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        pFechaInicio = DTPPeriodoInicio.Value.ToString("yyyy-MM-dd")
        pFechaFin = DTPPeriodoFin.Value.ToString("yyyy-MM-dd")
        command.CommandText = "SELECT count(*) FROM `ATENCIONFALLAS` WHERE Estado='Pendiente' AND FechaSeguimiento Between '" & pFechaInicio & "' AND '" & pFechaFin & "'"
        lector = command.ExecuteReader
        lector.Read()
        Dim n As Integer = lector.GetInt32(0)
        lector.Close()
        If n <> 0 Then
            AtencionPreventivo_Seleccionar.ShowDialog()
            If obtainedInfoMov = True Then
                cmdGrabar.Enabled = True
                lblGraba.Visible = True
                obtainedInfoMov = False
                txtId.Value = idMov_1
                txtFechaS.Text = fecha_1
                txtAtiende.Text = encargado_1
                command.CommandText = "SELECT IdReporte, TipoReporte FROM ATENCIONFALLAS WHERE IdAtencion=" & txtId.Value
                lector = command.ExecuteReader
                lector.Read()
                txtIdReporte.Text = lector.GetValue(0)
                txtTipoReporte.Text = lector.GetValue(1)
                lector.Close()
                '***************************************************
                command.CommandText = "SELECT * FROM DETALLEATENCIONFALLAS WHERE IdAtencion=" & txtId.Value
                lector = command.ExecuteReader
                While lector.Read()
                    dgv.Rows.Add(lector.GetValue(1), "", lector.GetValue(2), lector.GetValue(3))
                End While
                lector.Close()

                Dim categoria As String = ""
                For i = 0 To dgv.Rows.Count - 2
                    If (MP.busquedaIdRecurso("CAÑONES", dgv(0, i).Value) = 1) Then
                        categoria = "CAÑONES"
                        command.CommandText = "SELECT Estado FROM CAÑONES WHERE IdRecurso=" & dgv(0, i).Value
                        lector = command.ExecuteReader
                        lector.Read()
                        dgv(4, i).Value = lector.GetValue(0)
                        lector.Close()
                    ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", dgv(0, i).Value) = 1) Then
                        categoria = "COMPUTADORAS"
                        command.CommandText = "SELECT Estado FROM COMPUTADORAS WHERE IdRecurso=" & dgv(0, i).Value
                        lector = command.ExecuteReader
                        lector.Read()
                        dgv(4, i).Value = lector.GetValue(0)
                        lector.Close()
                    ElseIf (MP.busquedaIdRecurso("PANTALLAS", dgv(0, i).Value) = 1) Then
                        categoria = "PANTALLAS"
                        command.CommandText = "SELECT Estado FROM PANTALLAS WHERE IdRecurso=" & dgv(0, i).Value
                        lector = command.ExecuteReader
                        lector.Read()
                        dgv(4, i).Value = lector.GetValue(0)
                        lector.Close()
                    Else
                        command.CommandText = "SELECT C.Concepto FROM CATEGORIA AS C INNER JOIN RECURSOS AS R ON C.idCategoria = R.idCategoria WHERE R.idRecursos=" & dgv(0, i).Value
                        lector = command.ExecuteReader
                        lector.Read()
                        categoria = lector.GetValue(0)
                        lector.Close()
                        dgv(4, i).Value = "---"
                    End If
                    dgv(1, i).Value = categoria
                Next

                For i = 0 To dgv.Rows.Count - 2
                    If dgv(1, i).Value.Equals("CAÑONES") Or dgv(1, i).Value.Equals("COMPUTADORAS") Or dgv(1, i).Value.Equals("PANTALLAS") Then
                        Dim cboEstadoRecurso As New DataGridViewComboBoxCell
                        cboEstadoRecurso.Items.Add("---")
                        command.CommandText = "SELECT count(*) FROM RECURSOSASIGNADOS WHERE Estado = 'Vigente' AND IdRecurso=" & dgv(0, i).Value
                        lector = command.ExecuteReader
                        lector.Read()
                        If lector.GetInt32(0) <> 0 Then
                            cboEstadoRecurso.Items.Add("Asignado")
                        Else
                            cboEstadoRecurso.Items.Add("Disponible")
                        End If
                        lector.Close()
                        cboEstadoRecurso.Items.Add("Irreparable")
                        cboEstadoRecurso.Value = "---"
                        dgv.Item(4, i) = cboEstadoRecurso
                    ElseIf dgv(1, i).Value.Equals("CONTACTOS") Or dgv(1, i).Value.Equals("LAMPARAS") Then
                        Dim cboEstadoRecurso As New DataGridViewComboBoxCell
                        cboEstadoRecurso.Items.Add("---")
                        cboEstadoRecurso.Value = "---"
                        dgv.Item(4, i) = cboEstadoRecurso
                    End If
                Next

                Dim r As String = ""
                If txtTipoReporte.Text.Equals("D") Then
                    txtTipoReporte.Text = "DOCENTE"
                    r = "SELECT Fecha, Estado, ObservacionesGrales FROM REPORTEDOCENTES WHERE IdReporte=" & txtIdReporte.Text
                Else txtTipoReporte.Text.Equals("I")
                    txtTipoReporte.Text = "INDIVIDUAL"
                    r = "SELECT Fecha, Estado, Concepto FROM REPORTESRECURSOSINDIVIDUALES WHERE IdReporteRecursos=" & txtIdReporte.Text
                End If
                command.CommandText = r
                lector = command.ExecuteReader
                lector.Read()
                txtFecha.Text = lector.GetValue(0)
                txtEstadoReporte.Text = lector.GetValue(1)
                txtObservacionesRep.Text = lector.GetValue(2)
                lector.Close()
                '***************************************************
                GroupBox1.Enabled = True
                cmdGrabar.Enabled = True
            End If
        Else
            MsgBox("No hay un registro de Atencion a Fallas Pendiente con la ID ingresada!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
    Private Sub AtencionReportes_Terminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPPeriodoInicio.Value = Date.Today
        DTPPeriodoFin.Value = Date.Today
        Timer1.Start()
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btnAyuda, "¿Necesitas ayuda?")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        opcion = "Termina"
        Ayuda.ShowDialog()
    End Sub
End Class