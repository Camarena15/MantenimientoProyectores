'Author: @Theki
Imports MySql.Data.MySqlClient
Public Class Reportes_Registrar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim Fecha As String
    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If txtEdificio.SelectedIndex = 0 Or txtAula.SelectedIndex = 0 Or cboHHF.SelectedIndex = 0 Or cboHHI.SelectedIndex = 0 Or
            cboMMF.SelectedIndex = 0 Or cboMMI.SelectedIndex = 0 Then
            MsgBox("¡Asegurese de haber seleccionado parámetros correctos!", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim transaction As MySqlTransaction
            transaction = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = transaction
            Try
                Fecha = DTP.Value.Year & "/" & DTP.Value.Month & "/" & DTP.Value.Day
                command.CommandText = "INSERT INTO `REPORTEDOCENTES` (`Docente`, `Fecha`, `Edificio`, `Aula`,
            `HoraIC`, `HoraFC`, `ObservacionesGrales`, `Estado`) VALUES ('" & txtDocente.Text & "','" & DTP.Value.ToString("yyyy-MM-dd") & "','" & txtEdificio.Text &
                "','" & txtAula.Text & "','" & cboHHI.Text & ":" & cboMMI.Text & "','" & cboHHF.Text & ":" & cboMMF.Text & "','" &
                txtObservaciones.Text & "','" & txtEstado.Text & "')"
                command.ExecuteNonQuery()

                transaction.Commit()
            Catch ex As Exception
                MsgBox("Commit Exception Type: {0} no se pudo insertar por error")
                bitacora.InsertarError("GUARDAR REPORTE DOCENTE", ex.Message, ex.HResult, Fecha)
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error RollBack")
                End Try
            End Try
            GroupBox1.Enabled = False
            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            Limpiartxt()
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        command.CommandText = "SELECT count(*) FROM REPORTEDOCENTES" 'SELECT TOP, SELECT BOTTOM 
        lector = command.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector.GetInt32(0)
        lector.Close()
        If aux > 0 Then
            command.CommandText = "SELECT IdReporte FROM REPORTEDOCENTES ORDER BY IdReporte DESC LIMIT 1"
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
        cmdGrabar.Enabled = True
        cmdNuevo.Enabled = False
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Me.Close()
    End Sub

    Private Sub Limpiartxt()
        cboHHI.SelectedIndex = 0
        cboHHF.SelectedIndex = 0
        cboMMI.SelectedIndex = 0
        cboMMF.SelectedIndex = 0
        DTP.Value = Date.Today
        txtDocente.Text = ""
        txtEdificio.SelectedIndex = 0
        txtAula.SelectedIndex = 0
        txtId.Text = ""
        txtObservaciones.Text = ""
    End Sub

    Private Sub Reportes_Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        cboHHI.SelectedIndex = 0
        cboHHF.SelectedIndex = 0
        cboMMI.SelectedIndex = 0
        cboMMF.SelectedIndex = 0
        txtAula.SelectedIndex = 0
        txtEdificio.SelectedIndex = 0
        DTP.Value = Date.Today
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btnAyuda, "¿Necesitas ayuda?")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer1.Stop()
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        opcion = "ReporteDocente"
        Ayuda.ShowDialog()
    End Sub
End Class