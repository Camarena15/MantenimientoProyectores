'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class Preventivo_Registrar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim MP As New MPTools
    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If cboTipo.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar el Tipo de Servicio!", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim transaction As MySqlTransaction
            transaction = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = transaction
            Try
                command.CommandText = "INSERT INTO `PREVENTIVO` (`Tipo`, `FechaInicio`, `FechaFin`, `IdRecurso`, `Concepto`, 
            `QuienAtiende`, `Observacion`, `Estado`) VALUES ('" & cboTipo.Text & "','" & DTP.Value.ToString("yyyy-MM-dd") & "','" &
                Date.Today.ToString("yyyy-MM-dd") & "'," & txtidRecurso.Text & ",'" & txtConcepto.Text & "','" & txtAtiende.Text & "','" &
                txtObservaciones.Text & "','" & txtEstado.Text & "')"
                command.ExecuteNonQuery()
                If (MP.busquedaIdRecurso("CAÑONES", txtidRecurso.Text) = 1) Then
                    If RBSI.Checked = True Then
                        command.CommandText = "UPDATE `CAÑONES` SET `Estado`= 'Reparacion', `HorasLampara` = 0 WHERE IdRecurso= " & txtidRecurso.Text
                    Else
                        command.CommandText = "UPDATE `CAÑONES` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & txtidRecurso.Text
                    End If
                    lblCambioLampara.Visible = False
                    RBSI.Visible = False
                    RBNO.Visible = False
                ElseIf (MP.busquedaIdRecurso("COMPUTADORAS", txtidRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `COMPUTADORAS` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & txtidRecurso.Text
                ElseIf (MP.busquedaIdRecurso("PANTALLAS", txtidRecurso.Text) = 1) Then
                    command.CommandText = "UPDATE `PANTALLAS` SET `Estado`= 'Reparacion' WHERE IdRecurso= " & txtidRecurso.Text
                End If
                command.ExecuteNonQuery()
                transaction.Commit()
            Catch ex As Exception
                MsgBox("Commit Exception Type: {0} no se pudo insertar por error" & ex.ToString)
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error RollBack")
                End Try
            End Try
            GBRecurso.Enabled = False
            GBPreventivo.Enabled = False
            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            Limpiartxt()
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        command.CommandText = "SELECT count(*) FROM PREVENTIVO" 'SELECT TOP, SELECT BOTTOM 
        lector = command.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector.GetInt32(0)
        lector.Close()
        If aux > 0 Then
            command.CommandText = "SELECT IdPreventivo FROM PREVENTIVO ORDER BY IdPreventivo DESC LIMIT 1 "
            lector = command.ExecuteReader
            lector.Read()
            n = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
            ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
            txtId.Text = n
            lector.Close()
        Else
            txtId.Text = ""
        End If
        GBRecurso.Enabled = True
        cmdNuevo.Enabled = False
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Me.Close()
    End Sub

    Private Sub Limpiartxt()
        txtId.Text = ""
        txtIdRecurso.Text = ""
        cboCategoria.SelectedIndex = 0
        txtinvcapece.Text = ""
        txtEstadoRecurso.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtConcepto.Text = ""
        cboTipo.SelectedIndex = 0
        DTP.Value = Date.Today
        DTP2.Text = Date.Today.ToString("dd/MM/yyyy")
        txtAtiende.Text = ""
        txtObservaciones.Text = ""
        RBNO.Checked = True
    End Sub

    Private Sub Reportes_Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        cboCategoria.SelectedIndex = 0
        cboTipo.SelectedIndex = 0
        DTP.Value = Date.Today
        DTP2.Text = Date.Today.ToString("dd/MM/yyyy")
        RBNO.Checked = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
    End Sub
    Private Sub RB_CheckedChanged(sender As Object, e As EventArgs) Handles RBSI.CheckedChanged, RBNO.CheckedChanged
        If RBNO.Checked = True Then
            RBSI.Checked = False
        End If
        If RBSI.Checked = True Then
            RBNO.Checked = False
        End If
    End Sub
    Private Sub cmdBuscarRecurso_Click(sender As Object, e As EventArgs) Handles cmdBuscarRecurso.Click
        If cboCategoria.SelectedIndex = 0 Then
            MsgBox("No se ha seleccionado la categoría del recurso!", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim n As Integer
            command.CommandText = "SELECT count(*) FROM " & cboCategoria.SelectedItem & " WHERE Estado='Disponible' OR Estado='Asignado'"
            lector = command.ExecuteReader
            lector.Read()
            n = lector.GetInt32(0)
            lector.Close()
            If n = 0 Then
                MsgBox("No se encontro un Registro DISPONIBLE o ASIGNADO en la categoría " & cboCategoria.SelectedItem, MsgBoxStyle.Critical, "ERROR")
            Else
                recursoCat = cboCategoria.SelectedItem
                RecursoIndividual_Seleccionar.ShowDialog()
                If obtainedInfoRec = True Then
                    obtainedInfoRec = False
                    txtIdRecurso.Text = idRecurso_1
                    txtinvcapece.Text = invcapece_1
                    txtModelo.Text = modelo_1
                    txtMarca.Text = marca_1
                    txtEstadoRecurso.Text = estado_1
                    If cboCategoria.SelectedIndex = 1 Then
                        lblCambioLampara.Visible = True
                        RBNO.Visible = True
                        RBSI.Visible = True
                    End If
                    GBPreventivo.Enabled = True
                    cmdGrabar.Enabled = True
                End If
            End If
        End If
    End Sub
End Class