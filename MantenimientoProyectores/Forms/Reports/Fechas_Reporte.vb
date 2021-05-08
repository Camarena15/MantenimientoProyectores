Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Fechas_Reporte
    Dim comando As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim f1 As String
    Dim f2, f11, f22 As String
    Private Sub Fechas_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        'Try

        Dim conStr As String
        conStr = "Server=mysql-sistemamediosav.alwaysdata.net;database=sistemamediosav_db;user id=230400_db;password=W*eH0EBY%7oH;port=3306"
        Dim con As New MySqlConnection(conStr)
        con.Open()
        f1 = DTP1.Value.Year & "-" & DTP1.Value.Month & "-" & DTP1.Value.Day
        f2 = DTP2.Value.Year & "-" & DTP2.Value.Month & "-" & DTP2.Value.Day



        Dim Adaptador As New MySqlDataAdapter
        If Menu_Reportes.opcion = 1 Then
            DTP1.CustomFormat = "yyyy-MM-dd"
            ' f11 = String.Format(f1, "yyyy-M-d")
            f22 = String.Format(f2, "yyyy-M-d")
            f11 = DTP1.Value
            MsgBox(f11)
            Adaptador.SelectCommand = New MySqlCommand
            Adaptador.SelectCommand.Connection = con
            Adaptador.SelectCommand.CommandText = "SupervicionReporte"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New MySqlParameter("@FF", MySqlDbType.Date)
            Dim param2 = New MySqlParameter("@FI", MySqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)

            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)

            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("FF", f1)
            Dim p2 As New ReportParameter("FI", f2)

            Reporte_Form.ReportViewer1.LocalReport.DataSources.Clear()
            Reporte_Form.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            Reporte_Form.ReportViewer1.LocalReport.ReportPath = "C:\MantenimientoProyectores\Forms\SupervisionReporte.rdlc"
            Reporte_Form.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            Reporte_Form.ReportViewer1.RefreshReport()
            Reporte_Form.Show()
            con.Close()
        ElseIf Menu_Reportes.opcion = 3 Then
            DTP1.CustomFormat = "yyyy-MM-dd"
            ' f11 = String.Format(f1, "yyyy-M-d")
            f22 = String.Format(f2, "yyyy-M-d")
            f11 = DTP1.Value
            MsgBox(f11)
            Adaptador.SelectCommand = New MySqlCommand
            Adaptador.SelectCommand.Connection = con
            Adaptador.SelectCommand.CommandText = "ReportePeriodoGnral"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New MySqlParameter("@FF", MySqlDbType.Date)
            Dim param2 = New MySqlParameter("@FI", MySqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)

            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)

            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("FF", f1)
            Dim p2 As New ReportParameter("FI", f2)

            Reporte_Form.ReportViewer1.LocalReport.DataSources.Clear()
            Reporte_Form.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            Reporte_Form.ReportViewer1.LocalReport.ReportPath = "C:\MantenimientoProyectores\Forms\ReporteGeneral.rdlc"
            Reporte_Form.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            Reporte_Form.ReportViewer1.RefreshReport()
            Reporte_Form.Show()
            con.Close()
        End If

    End Sub
End Class