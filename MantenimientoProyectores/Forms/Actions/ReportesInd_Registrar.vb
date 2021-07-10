'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class ReportesInd_Registrar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim Fecha As String
    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim transaction As MySqlTransaction
        transaction = connection.BeginTransaction()
        command.Connection = connection
        command.Transaction = transaction
        Try
            Fecha = DTP.Value.Year & "/" & DTP.Value.Month & "/" & DTP.Value.Day
            command.CommandText = "INSERT INTO `REPORTESRECURSOSINDIVIDUALES`(`IdRecurso`, `Fecha`, `Concepto`, `Estado`) VALUES  (" & txtIdRecurso.Text & ",'" & DTP.Value.ToString("yyyy-MM-dd") & "','" &
                txtObservaciones.Text & "','Pendiente')"
            command.ExecuteNonQuery()
            transaction.Commit()
        Catch ex As Exception
            bitacora.InsertarError("GUARDAR REPORTE INDIVIDUAL", ex.Message, ex.HResult, Fecha)
            MsgBox("Commit Exception Type: {0} no se pudo insertar por error " & ex.ToString)
            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MsgBox("Error RollBack")
            End Try
        End Try
        GBRecurso.Enabled = False
        GroupBox1.Enabled = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        Limpiartxt()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        command.CommandText = "SELECT count(*) FROM REPORTESRECURSOSINDIVIDUALES" 'SELECT TOP, SELECT BOTTOM 
        lector = command.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector.GetInt32(0)
        lector.Close()
        If aux > 0 Then
            command.CommandText = "SELECT IdReporteRecursos FROM REPORTESRECURSOSINDIVIDUALES ORDER BY IdReporteRecursos DESC LIMIT 1"
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
        DTP.Value = Date.Today
        txtId.Text = ""
        txtIdRecurso.Text = ""
        cboCategoria.SelectedIndex = 0
        txtinvcapece.Text = ""
        txtEstadoRecurso.Text = ""
        txtModelo.Text = ""
        txtMarca.Text = ""
        txtObservaciones.Text = ""
    End Sub

    Private Sub Reportes_Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DTP.Value = Date.Today
        cboCategoria.SelectedIndex = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btnAyuda, "¿Necesitas ayuda?")
    End Sub
    Private Sub cmdBuscarRecurso_Click(sender As Object, e As EventArgs) Handles cmdBuscarRecurso.Click
        If cboCategoria.SelectedIndex = 0 Then
            MsgBox("No se ha seleccionado la categoría del recurso!", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim n As Integer
            command.CommandText = "SELECT count(*) FROM " & cboCategoria.SelectedItem & " WHERE Estado='Disponible'"
            lector = command.ExecuteReader
            lector.Read()
            n = lector.GetInt32(0)
            lector.Close()
            If n = 0 Then
                MsgBox("No se encontro un Registro DISPONIBLE en la categoría " & cboCategoria.SelectedItem, MsgBoxStyle.Critical, "ERROR")
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
                    GroupBox1.Enabled = True
                    cmdGrabar.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        opcion = "Individual"
        Ayuda.ShowDialog()
    End Sub
End Class