Public Class Reporte_Form
    Private Sub Reporte_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.Size = New System.Drawing.Size(1400, 750)
        Me.Controls.Add(Me.ReportViewer1)
    End Sub
End Class