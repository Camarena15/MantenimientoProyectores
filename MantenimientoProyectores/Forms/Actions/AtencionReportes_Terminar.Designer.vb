<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AtencionReportes_Terminar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.idAtencion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtFechaS = New System.Windows.Forms.TextBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtAtiende = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.lblGraba = New System.Windows.Forms.Label()
        Me.GBReporte = New System.Windows.Forms.GroupBox()
        Me.txtEstadoReporte = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtObservacionesRep = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdReporte = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboEstadoRecurso = New System.Windows.Forms.ComboBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtidRecurso = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtinvcapece = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBReporte.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Venus Rising", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(284, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TERMINACIÓN DE ATENCIÓN DE REPORTES."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(860, 421)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 16)
        Me.Label25.TabIndex = 189
        Me.Label25.Text = "Salir"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(860, 325)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 16)
        Me.Label24.TabIndex = 188
        Me.Label24.Text = "Grabar"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(860, 364)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 50)
        Me.cmdSalir.TabIndex = 187
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.White
        Me.cmdGrabar.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Grabar
        Me.cmdGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabar.Location = New System.Drawing.Point(860, 268)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(49, 54)
        Me.cmdGrabar.TabIndex = 186
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'idAtencion
        '
        Me.idAtencion.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idAtencion.ForeColor = System.Drawing.Color.Black
        Me.idAtencion.Location = New System.Drawing.Point(47, 61)
        Me.idAtencion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idAtencion.Name = "idAtencion"
        Me.idAtencion.Size = New System.Drawing.Size(145, 59)
        Me.idAtencion.TabIndex = 171
        Me.idAtencion.Text = "Ingrese la ID de la Atención: a Reporte"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.txtTipo)
        Me.GroupBox2.Controls.Add(Me.txtFechaS)
        Me.GroupBox2.Controls.Add(Me.txtObservacion)
        Me.GroupBox2.Controls.Add(Me.txtAtiende)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(57, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(762, 186)
        Me.GroupBox2.TabIndex = 215
        Me.GroupBox2.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.Brown
        Me.txtEstado.Location = New System.Drawing.Point(228, 24)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(135, 26)
        Me.txtEstado.TabIndex = 235
        Me.txtEstado.Text = "Terminado"
        '
        'txtTipo
        '
        Me.txtTipo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(59, 24)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(97, 26)
        Me.txtTipo.TabIndex = 234
        '
        'txtFechaS
        '
        Me.txtFechaS.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaS.Location = New System.Drawing.Point(137, 75)
        Me.txtFechaS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaS.Name = "txtFechaS"
        Me.txtFechaS.ReadOnly = True
        Me.txtFechaS.Size = New System.Drawing.Size(107, 26)
        Me.txtFechaS.TabIndex = 232
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(456, 56)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.Size = New System.Drawing.Size(290, 111)
        Me.txtObservacion.TabIndex = 228
        '
        'txtAtiende
        '
        Me.txtAtiende.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtiende.Location = New System.Drawing.Point(137, 126)
        Me.txtAtiende.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAtiende.Name = "txtAtiende"
        Me.txtAtiende.ReadOnly = True
        Me.txtAtiende.Size = New System.Drawing.Size(279, 26)
        Me.txtAtiende.TabIndex = 227
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(158, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 27)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 19)
        Me.Label11.TabIndex = 226
        Me.Label11.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(452, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 19)
        Me.Label6.TabIndex = 223
        Me.Label6.Text = "Observaciones"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 66)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 43)
        Me.Label9.TabIndex = 225
        Me.Label9.Text = "Fecha de seguimiento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 120)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 47)
        Me.Label8.TabIndex = 224
        Me.Label8.Text = "Encargado de seguimiento:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.Navy
        Me.cmdBuscar.FlatAppearance.BorderSize = 0
        Me.cmdBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.ForeColor = System.Drawing.Color.White
        Me.cmdBuscar.Location = New System.Drawing.Point(272, 76)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(107, 27)
        Me.cmdBuscar.TabIndex = 216
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(197, 76)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(69, 26)
        Me.txtId.TabIndex = 217
        '
        'lblGraba
        '
        Me.lblGraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGraba.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraba.ForeColor = System.Drawing.Color.Black
        Me.lblGraba.Location = New System.Drawing.Point(931, 245)
        Me.lblGraba.Name = "lblGraba"
        Me.lblGraba.Size = New System.Drawing.Size(137, 88)
        Me.lblGraba.TabIndex = 218
        Me.lblGraba.Text = "Para dar por terminada la Atención a Fallas, pulse el boton Grabar             <-" &
    "---"
        Me.lblGraba.Visible = False
        '
        'GBReporte
        '
        Me.GBReporte.BackColor = System.Drawing.Color.White
        Me.GBReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GBReporte.Controls.Add(Me.txtEstadoReporte)
        Me.GBReporte.Controls.Add(Me.txtFecha)
        Me.GBReporte.Controls.Add(Me.txtObservacionesRep)
        Me.GBReporte.Controls.Add(Me.Label14)
        Me.GBReporte.Controls.Add(Me.Label12)
        Me.GBReporte.Controls.Add(Me.Label7)
        Me.GBReporte.Controls.Add(Me.Label10)
        Me.GBReporte.Controls.Add(Me.txtIdReporte)
        Me.GBReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GBReporte.ForeColor = System.Drawing.Color.Black
        Me.GBReporte.Location = New System.Drawing.Point(56, 312)
        Me.GBReporte.Name = "GBReporte"
        Me.GBReporte.Size = New System.Drawing.Size(385, 192)
        Me.GBReporte.TabIndex = 237
        Me.GBReporte.TabStop = False
        Me.GBReporte.Text = "INFORMACIÓN DEL REPORTE:"
        '
        'txtEstadoReporte
        '
        Me.txtEstadoReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoReporte.Location = New System.Drawing.Point(250, 157)
        Me.txtEstadoReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstadoReporte.Name = "txtEstadoReporte"
        Me.txtEstadoReporte.ReadOnly = True
        Me.txtEstadoReporte.Size = New System.Drawing.Size(119, 26)
        Me.txtEstadoReporte.TabIndex = 214
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(250, 37)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(119, 26)
        Me.txtFecha.TabIndex = 213
        '
        'txtObservacionesRep
        '
        Me.txtObservacionesRep.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesRep.Location = New System.Drawing.Point(96, 72)
        Me.txtObservacionesRep.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservacionesRep.Multiline = True
        Me.txtObservacionesRep.Name = "txtObservacionesRep"
        Me.txtObservacionesRep.ReadOnly = True
        Me.txtObservacionesRep.Size = New System.Drawing.Size(273, 81)
        Me.txtObservacionesRep.TabIndex = 212
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 76)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 19)
        Me.Label14.TabIndex = 208
        Me.Label14.Text = "Concepto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(111, 164)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 19)
        Me.Label12.TabIndex = 206
        Me.Label12.Text = "Estado Reporte"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(192, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 19)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "ID Reporte"
        '
        'txtIdReporte
        '
        Me.txtIdReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReporte.Location = New System.Drawing.Point(119, 37)
        Me.txtIdReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdReporte.Name = "txtIdReporte"
        Me.txtIdReporte.ReadOnly = True
        Me.txtIdReporte.Size = New System.Drawing.Size(59, 26)
        Me.txtIdReporte.TabIndex = 201
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboEstadoRecurso)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.txtidRecurso)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtinvcapece)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(447, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 192)
        Me.GroupBox1.TabIndex = 238
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN DEL RECURSO:"
        '
        'cboEstadoRecurso
        '
        Me.cboEstadoRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoRecurso.FormattingEnabled = True
        Me.cboEstadoRecurso.Items.AddRange(New Object() {"---"})
        Me.cboEstadoRecurso.Location = New System.Drawing.Point(274, 98)
        Me.cboEstadoRecurso.Name = "cboEstadoRecurso"
        Me.cboEstadoRecurso.Size = New System.Drawing.Size(102, 27)
        Me.cboEstadoRecurso.TabIndex = 239
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(102, 65)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(101, 26)
        Me.txtCategoria.TabIndex = 238
        '
        'txtidRecurso
        '
        Me.txtidRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidRecurso.Location = New System.Drawing.Point(102, 30)
        Me.txtidRecurso.Name = "txtidRecurso"
        Me.txtidRecurso.ReadOnly = True
        Me.txtidRecurso.Size = New System.Drawing.Size(101, 26)
        Me.txtidRecurso.TabIndex = 237
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(274, 65)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(101, 26)
        Me.txtMarca.TabIndex = 228
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(210, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Marca"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(274, 29)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(101, 26)
        Me.txtModelo.TabIndex = 226
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(209, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "Modelo"
        '
        'txtinvcapece
        '
        Me.txtinvcapece.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvcapece.Location = New System.Drawing.Point(102, 99)
        Me.txtinvcapece.Name = "txtinvcapece"
        Me.txtinvcapece.ReadOnly = True
        Me.txtinvcapece.Size = New System.Drawing.Size(101, 26)
        Me.txtinvcapece.TabIndex = 223
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 19)
        Me.Label17.TabIndex = 220
        Me.Label17.Text = "INVCAPECE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 19)
        Me.Label18.TabIndex = 219
        Me.Label18.Text = "Categoría"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(205, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 19)
        Me.Label19.TabIndex = 218
        Me.Label19.Text = "Estado"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(6, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 19)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "ID Recurso"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'AtencionReportes_Terminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBReporte)
        Me.Controls.Add(Me.lblGraba)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.idAtencion)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AtencionReportes_Terminar"
        Me.Text = "AtencionReportes_Terminar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBReporte.ResumeLayout(False)
        Me.GBReporte.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents idAtencion As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents txtAtiende As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtFechaS As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents lblGraba As Label
    Friend WithEvents GBReporte As GroupBox
    Friend WithEvents txtEstadoReporte As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtObservacionesRep As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdReporte As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtidRecurso As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtinvcapece As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cboEstadoRecurso As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
