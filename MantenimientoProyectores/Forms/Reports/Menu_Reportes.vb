Public Class Menu_Reportes
    Public opcion As Integer
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opcion = 1
        Fechas_Reporte.Show()
    End Sub

    Private Sub btnReporteDocente_Click(sender As Object, e As EventArgs) Handles btnReporteDocente.Click
        opcion = 2
        Fechas_Estado_Reporte.Show()
    End Sub

    Private Sub ReportePeriodo_Click(sender As Object, e As EventArgs) Handles ReportePeriodo.Click
        opcion = 3
        Fechas_Reporte.Show()
    End Sub

    Private Sub Menu_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        opcion = 4
        Fechas_Estado_Reporte2.Show()
    End Sub
End Class