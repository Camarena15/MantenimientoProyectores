Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Runtime.InteropServices
Public Class Fechas_Estado_Reporte2
    Dim f1 As String
    Dim f2, f22, f11 As String
    Dim edo As String

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim conStr As String
        conStr = "Server=mysql-sistemamediosav.alwaysdata.net;database=sistemamediosav_db;user id=230400_db;password=W*eH0EBY%7oH;port=3306"
        Dim con As New MySqlConnection(conStr)
        con.Open()
        'MsgBox(cboEstado.Text)
        f1 = DTP1.Value.Year & "-" & DTP1.Value.Month & "-" & DTP1.Value.Day
        f2 = DTP2.Value.Year & "-" & DTP2.Value.Month & "-" & DTP2.Value.Day
        If Menu_Reportes.opcion = 4 Then


            If cboEstado.Text = "Terminado" Then
                '  f1 = DTP1.Value.Day & "/" & DTP1.Value.Month & "/" & DTP1.Value.Year
                ' f2 = DTP2.Value.Day & "/" & DTP2.Value.Month & "/" & DTP2.Value.Year
                DTP1.CustomFormat = "yyyy-MM-dd"
                ' f11 = String.Format(f1, "yyyy-M-d")
                f22 = String.Format(f2, "yyyy-M-d")
                f11 = DTP1.Value
                edo = "Terminado"
                'Dim Adaptador As New SqlDataAdapter
                Adaptador.SelectCommand = New MySqlCommand
                Adaptador.SelectCommand.Connection = con
                Adaptador.SelectCommand.CommandText = "PreventivoReporte"
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New MySqlParameter("@FI", MySqlDbType.Date)
                Dim param2 = New MySqlParameter("@FF", MySqlDbType.Date)
                Dim param3 = New MySqlParameter("@EDO", MySqlDbType.VarChar)
                param1.Direction = ParameterDirection.Input
                param2.Direction = ParameterDirection.Input
                param3.Direction = ParameterDirection.Input
                param1.Value = CDate(f1)
                param2.Value = CDate(f2)
                param3.Value = edo

                Adaptador.SelectCommand.Parameters.Add(param1)
                Adaptador.SelectCommand.Parameters.Add(param2)
                Adaptador.SelectCommand.Parameters.Add(param3)
                Dim Data As New DataSet
                Adaptador.Fill(Data)
                Data.DataSetName = "Data1"
                Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

                Datasource.Name = "DataSet1"
                Datasource.Value = Data.Tables(0)
                Dim p1 As New ReportParameter("FI", f1)
                Dim p2 As New ReportParameter("FF", f2)
                Dim ee As New ReportParameter("EDO", edo)

                Reporte_Form.ReportViewer1.LocalReport.DataSources.Clear()

                Reporte_Form.ReportViewer1.LocalReport.DataSources.Add(Datasource)

                Reporte_Form.ReportViewer1.LocalReport.ReportPath = "C:\MantenimientoProyectores\Forms\ReporteTerminado1.rdlc"
                Reporte_Form.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, ee})
                Reporte_Form.ReportViewer1.RefreshReport()
                Reporte_Form.ShowDialog()
                con.Close()
            ElseIf cboEstado.Text = "Reparacion" Then
                '  f1 = DTP1.Value.Day & "/" & DTP1.Value.Month & "/" & DTP1.Value.Year
                ' f2 = DTP2.Value.Day & "/" & DTP2.Value.Month & "/" & DTP2.Value.Year
                DTP1.CustomFormat = "yyyy-MM-dd"
                ' f11 = String.Format(f1, "yyyy-M-d")
                f22 = String.Format(f2, "yyyy-M-d")
                f11 = DTP1.Value
                edo = "Reparacion"
                'Dim Adaptador As New SqlDataAdapter
                Adaptador.SelectCommand = New MySqlCommand
                Adaptador.SelectCommand.Connection = con
                Adaptador.SelectCommand.CommandText = "PreventivoReporte2"
                Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New MySqlParameter("@FI", MySqlDbType.Date)
                Dim param2 = New MySqlParameter("@FF", MySqlDbType.Date)
                Dim param3 = New MySqlParameter("@EDO", MySqlDbType.VarChar)
                param1.Direction = ParameterDirection.Input
                param2.Direction = ParameterDirection.Input
                param3.Direction = ParameterDirection.Input
                param1.Value = CDate(f1)
                param2.Value = CDate(f2)
                param3.Value = edo

                Adaptador.SelectCommand.Parameters.Add(param1)
                Adaptador.SelectCommand.Parameters.Add(param2)
                Adaptador.SelectCommand.Parameters.Add(param3)
                Dim Data As New DataSet
                Adaptador.Fill(Data)
                Data.DataSetName = "Data1"
                Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))

                Datasource.Name = "DataSet1"
                Datasource.Value = Data.Tables(0)
                Dim p1 As New ReportParameter("FI", f1)
                Dim p2 As New ReportParameter("FF", f2)
                Dim ee As New ReportParameter("EDO", edo)

                Reporte_Form.ReportViewer1.LocalReport.DataSources.Clear()

                Reporte_Form.ReportViewer1.LocalReport.DataSources.Add(Datasource)

                Reporte_Form.ReportViewer1.LocalReport.ReportPath = "C:\MantenimientoProyectores\Forms\ReporteTerminado2.rdlc"
                Reporte_Form.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, ee})
                Reporte_Form.ReportViewer1.RefreshReport()
                Reporte_Form.ShowDialog()
                con.Close()
            End If
        End If
    End Sub

    Dim Adaptador As New MySqlDataAdapter
    ' Dim cbo As String
    Private Sub Fechas_Estado_Reporte2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEstado.Items.Add("Terminado")
        'cboEstado.Items.Add("Pendiente")
        cboEstado.Items.Add("Reparacion")
    End Sub
End Class