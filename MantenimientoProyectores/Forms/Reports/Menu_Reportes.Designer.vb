<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Reportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReporteDocente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportePeriodo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.PanelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(837, 10)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(47, 39)
        Me.btnCerrar.TabIndex = 146
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Navy
        Me.PanelCabecera.Controls.Add(Me.btnCerrar)
        Me.PanelCabecera.Controls.Add(Me.Label15)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(896, 57)
        Me.PanelCabecera.TabIndex = 254
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Navy
        Me.Label15.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(287, 11)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(195, 29)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Menu reportes"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.SUPERVISION
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(45, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 231)
        Me.Button1.TabIndex = 255
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(41, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 23)
        Me.Label1.TabIndex = 256
        Me.Label1.Text = "SUPERVISIÓN DE REPORTES"
        '
        'btnReporteDocente
        '
        Me.btnReporteDocente.BackColor = System.Drawing.Color.White
        Me.btnReporteDocente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.SUPERVISION
        Me.btnReporteDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReporteDocente.Location = New System.Drawing.Point(542, 84)
        Me.btnReporteDocente.Name = "btnReporteDocente"
        Me.btnReporteDocente.Size = New System.Drawing.Size(264, 231)
        Me.btnReporteDocente.TabIndex = 257
        Me.btnReporteDocente.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(510, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 23)
        Me.Label2.TabIndex = 258
        Me.Label2.Text = "REPORTE DE DOCENTE POR ESTADO"
        '
        'ReportePeriodo
        '
        Me.ReportePeriodo.BackColor = System.Drawing.Color.White
        Me.ReportePeriodo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.SUPERVISION
        Me.ReportePeriodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ReportePeriodo.Location = New System.Drawing.Point(40, 391)
        Me.ReportePeriodo.Name = "ReportePeriodo"
        Me.ReportePeriodo.Size = New System.Drawing.Size(264, 231)
        Me.ReportePeriodo.TabIndex = 259
        Me.ReportePeriodo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(63, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 23)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "REPORTE DE DOCENTE "
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.White
        Me.btnReporte.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.SUPERVISION
        Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReporte.Location = New System.Drawing.Point(514, 391)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(264, 231)
        Me.btnReporte.TabIndex = 261
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'Menu_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.ClientSize = New System.Drawing.Size(896, 715)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReportePeriodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReporteDocente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu_Reportes"
        Me.Text = "Menu_Reportes"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReporteDocente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ReportePeriodo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReporte As Button
End Class
