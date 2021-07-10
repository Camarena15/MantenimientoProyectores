<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesInd_Registrar
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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBRecurso = New System.Windows.Forms.GroupBox()
        Me.txtIdRecurso = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtinvcapece = New System.Windows.Forms.TextBox()
        Me.txtEstadoRecurso = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdBuscarRecurso = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GBRecurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(75, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 32)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "ID Reporte"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(1220, 604)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(65, 66)
        Me.cmdSalir.TabIndex = 228
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(1216, 558)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 23)
        Me.Label24.TabIndex = 227
        Me.Label24.Text = "Grabar"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(1216, 444)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 23)
        Me.Label23.TabIndex = 226
        Me.Label23.Text = "Nuevo"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.White
        Me.cmdGrabar.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Grabar
        Me.cmdGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabar.Location = New System.Drawing.Point(1220, 487)
        Me.cmdGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(65, 66)
        Me.cmdGrabar.TabIndex = 225
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.Color.White
        Me.cmdNuevo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Nuevo
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNuevo.Location = New System.Drawing.Point(1220, 380)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(65, 62)
        Me.cmdNuevo.TabIndex = 224
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(1215, 672)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 23)
        Me.Label25.TabIndex = 223
        Me.Label25.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(80, 292)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 191)
        Me.GroupBox1.TabIndex = 222
        Me.GroupBox1.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(679, 33)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(132, 31)
        Me.txtEstado.TabIndex = 226
        Me.txtEstado.Text = "Pendiente"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(148, 75)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(411, 86)
        Me.txtObservaciones.TabIndex = 193
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(588, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 23)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 23)
        Me.Label12.TabIndex = 191
        Me.Label12.Text = "Concepto"
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(216, 30)
        Me.DTP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(148, 31)
        Me.DTP.TabIndex = 188
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 23)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "Fecha de Reporte"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(255, 91)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 31)
        Me.txtId.TabIndex = 221
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(415, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 24)
        Me.Label1.TabIndex = 220
        Me.Label1.Text = "REGISTRO DE REPORTES INDIVIDUALES"
        '
        'GBRecurso
        '
        Me.GBRecurso.Controls.Add(Me.txtIdRecurso)
        Me.GBRecurso.Controls.Add(Me.txtMarca)
        Me.GBRecurso.Controls.Add(Me.Label2)
        Me.GBRecurso.Controls.Add(Me.txtModelo)
        Me.GBRecurso.Controls.Add(Me.Label14)
        Me.GBRecurso.Controls.Add(Me.cboCategoria)
        Me.GBRecurso.Controls.Add(Me.txtinvcapece)
        Me.GBRecurso.Controls.Add(Me.txtEstadoRecurso)
        Me.GBRecurso.Controls.Add(Me.Label17)
        Me.GBRecurso.Controls.Add(Me.Label18)
        Me.GBRecurso.Controls.Add(Me.Label19)
        Me.GBRecurso.Controls.Add(Me.cmdBuscarRecurso)
        Me.GBRecurso.Controls.Add(Me.Label20)
        Me.GBRecurso.Enabled = False
        Me.GBRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GBRecurso.ForeColor = System.Drawing.Color.Black
        Me.GBRecurso.Location = New System.Drawing.Point(80, 149)
        Me.GBRecurso.Margin = New System.Windows.Forms.Padding(4)
        Me.GBRecurso.Name = "GBRecurso"
        Me.GBRecurso.Padding = New System.Windows.Forms.Padding(4)
        Me.GBRecurso.Size = New System.Drawing.Size(1017, 135)
        Me.GBRecurso.TabIndex = 230
        Me.GBRecurso.TabStop = False
        Me.GBRecurso.Text = "INFORMACIÓN DEL RECURSO:"
        '
        'txtIdRecurso
        '
        Me.txtIdRecurso.Location = New System.Drawing.Point(143, 37)
        Me.txtIdRecurso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdRecurso.Name = "txtIdRecurso"
        Me.txtIdRecurso.ReadOnly = True
        Me.txtIdRecurso.Size = New System.Drawing.Size(132, 31)
        Me.txtIdRecurso.TabIndex = 0
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(675, 75)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(133, 31)
        Me.txtMarca.TabIndex = 228
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(588, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Marca"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(673, 36)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(133, 31)
        Me.txtModelo.TabIndex = 226
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(587, 41)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 23)
        Me.Label14.TabIndex = 225
        Me.Label14.Text = "Modelo"
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Items.AddRange(New Object() {"---", "CAÑONES", "COMPUTADORAS", "PANTALLAS"})
        Me.cboCategoria.Location = New System.Drawing.Point(136, 76)
        Me.cboCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(133, 31)
        Me.cboCategoria.TabIndex = 224
        '
        'txtinvcapece
        '
        Me.txtinvcapece.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvcapece.Location = New System.Drawing.Point(425, 36)
        Me.txtinvcapece.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinvcapece.Name = "txtinvcapece"
        Me.txtinvcapece.ReadOnly = True
        Me.txtinvcapece.Size = New System.Drawing.Size(133, 31)
        Me.txtinvcapece.TabIndex = 223
        '
        'txtEstadoRecurso
        '
        Me.txtEstadoRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoRecurso.Location = New System.Drawing.Point(425, 80)
        Me.txtEstadoRecurso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstadoRecurso.Name = "txtEstadoRecurso"
        Me.txtEstadoRecurso.ReadOnly = True
        Me.txtEstadoRecurso.Size = New System.Drawing.Size(133, 31)
        Me.txtEstadoRecurso.TabIndex = 222
        Me.txtEstadoRecurso.Text = "Disponible"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(297, 41)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 23)
        Me.Label17.TabIndex = 220
        Me.Label17.Text = "INVCAPECE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 84)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 23)
        Me.Label18.TabIndex = 219
        Me.Label18.Text = "Categoría"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(297, 84)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 23)
        Me.Label19.TabIndex = 218
        Me.Label19.Text = "Estado"
        '
        'cmdBuscarRecurso
        '
        Me.cmdBuscarRecurso.BackColor = System.Drawing.Color.Navy
        Me.cmdBuscarRecurso.FlatAppearance.BorderSize = 0
        Me.cmdBuscarRecurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdBuscarRecurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdBuscarRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscarRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarRecurso.ForeColor = System.Drawing.Color.White
        Me.cmdBuscarRecurso.Location = New System.Drawing.Point(856, 41)
        Me.cmdBuscarRecurso.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarRecurso.Name = "cmdBuscarRecurso"
        Me.cmdBuscarRecurso.Size = New System.Drawing.Size(140, 58)
        Me.cmdBuscarRecurso.TabIndex = 217
        Me.cmdBuscarRecurso.Text = "Buscar Recurso"
        Me.cmdBuscarRecurso.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(8, 41)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 23)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "ID Recurso"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.White
        Me.btnAyuda.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.AYUDA
        Me.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAyuda.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAyuda.Location = New System.Drawing.Point(30, 12)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(56, 58)
        Me.btnAyuda.TabIndex = 248
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'ReportesInd_Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1413, 837)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.GBRecurso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReportesInd_Registrar"
        Me.Text = "ReportesInd_Registrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBRecurso.ResumeLayout(False)
        Me.GBRecurso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBRecurso As GroupBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents txtinvcapece As TextBox
    Friend WithEvents txtEstadoRecurso As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmdBuscarRecurso As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtIdRecurso As TextBox
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
