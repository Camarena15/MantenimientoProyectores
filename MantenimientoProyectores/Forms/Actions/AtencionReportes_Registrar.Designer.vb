<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AtencionReportes_Registrar
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GBAtencion = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.txtAtiende = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RBNO = New System.Windows.Forms.RadioButton()
        Me.RBSI = New System.Windows.Forms.RadioButton()
        Me.lblCambioLampara = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtObservacionRecursos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GBTipoReporte = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdBuscarReporte = New System.Windows.Forms.Button()
        Me.DTPPeriodoFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPPeriodoInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoReporte = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEdificio = New System.Windows.Forms.TextBox()
        Me.txtAula = New System.Windows.Forms.TextBox()
        Me.txtidRecurso = New System.Windows.Forms.TextBox()
        Me.lblAula = New System.Windows.Forms.Label()
        Me.lblEdificio = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtinvcapece = New System.Windows.Forms.TextBox()
        Me.txtEstadoRecurso = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdBuscarRecurso = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GBReporte = New System.Windows.Forms.GroupBox()
        Me.txtEstadoReporte = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtObservacionesRep = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdReporte = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.idAtencion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GBRecursos = New System.Windows.Forms.GroupBox()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdAgregaD = New System.Windows.Forms.Button()
        Me.LV = New System.Windows.Forms.ListView()
        Me.IdRecurso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.INVCAPECE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoAtencion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Observaciones = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CambioLampara = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GBAtencion.SuspendLayout()
        Me.GBTipoReporte.SuspendLayout()
        Me.GBReporte.SuspendLayout()
        Me.GBRecursos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(337, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "REGISTRO DE ATENCIÓN A FALLAS"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(912, 547)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 191
        Me.Label25.Text = "Salir"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(913, 454)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 19)
        Me.Label24.TabIndex = 208
        Me.Label24.Text = "Grabar"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(913, 362)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 19)
        Me.Label23.TabIndex = 207
        Me.Label23.Text = "Nuevo"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.White
        Me.cmdGrabar.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Grabar
        Me.cmdGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabar.Location = New System.Drawing.Point(916, 397)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(49, 54)
        Me.cmdGrabar.TabIndex = 206
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.Color.White
        Me.cmdNuevo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Nuevo
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNuevo.Location = New System.Drawing.Point(916, 310)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(49, 50)
        Me.cmdNuevo.TabIndex = 205
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(916, 492)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 54)
        Me.cmdSalir.TabIndex = 212
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'GBAtencion
        '
        Me.GBAtencion.Controls.Add(Me.txtEstado)
        Me.GBAtencion.Controls.Add(Me.DTP)
        Me.GBAtencion.Controls.Add(Me.txtAtiende)
        Me.GBAtencion.Controls.Add(Me.Label5)
        Me.GBAtencion.Controls.Add(Me.Label9)
        Me.GBAtencion.Controls.Add(Me.Label8)
        Me.GBAtencion.Enabled = False
        Me.GBAtencion.Location = New System.Drawing.Point(52, 548)
        Me.GBAtencion.Name = "GBAtencion"
        Me.GBAtencion.Size = New System.Drawing.Size(770, 122)
        Me.GBAtencion.TabIndex = 227
        Me.GBAtencion.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(376, 20)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(100, 25)
        Me.txtEstado.TabIndex = 232
        Me.txtEstado.Text = "Pendiente"
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(134, 22)
        Me.DTP.Margin = New System.Windows.Forms.Padding(2)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(129, 26)
        Me.DTP.TabIndex = 230
        '
        'txtAtiende
        '
        Me.txtAtiende.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtiende.Location = New System.Drawing.Point(137, 68)
        Me.txtAtiende.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAtiende.Name = "txtAtiende"
        Me.txtAtiende.Size = New System.Drawing.Size(279, 26)
        Me.txtAtiende.TabIndex = 227
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(267, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 40)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Estado de Atención"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 43)
        Me.Label9.TabIndex = 225
        Me.Label9.Text = "Fecha de seguimiento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 41)
        Me.Label8.TabIndex = 224
        Me.Label8.Text = "Encargado de seguimiento"
        '
        'RBNO
        '
        Me.RBNO.AutoSize = True
        Me.RBNO.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RBNO.Location = New System.Drawing.Point(605, 68)
        Me.RBNO.Name = "RBNO"
        Me.RBNO.Size = New System.Drawing.Size(37, 17)
        Me.RBNO.TabIndex = 235
        Me.RBNO.TabStop = True
        Me.RBNO.Text = "No"
        Me.RBNO.UseVisualStyleBackColor = True
        Me.RBNO.Visible = False
        '
        'RBSI
        '
        Me.RBSI.AutoSize = True
        Me.RBSI.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RBSI.Location = New System.Drawing.Point(565, 68)
        Me.RBSI.Name = "RBSI"
        Me.RBSI.Size = New System.Drawing.Size(37, 17)
        Me.RBSI.TabIndex = 234
        Me.RBSI.TabStop = True
        Me.RBSI.Text = "Si"
        Me.RBSI.UseVisualStyleBackColor = True
        Me.RBSI.Visible = False
        '
        'lblCambioLampara
        '
        Me.lblCambioLampara.BackColor = System.Drawing.Color.White
        Me.lblCambioLampara.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCambioLampara.ForeColor = System.Drawing.Color.Black
        Me.lblCambioLampara.Location = New System.Drawing.Point(494, 57)
        Me.lblCambioLampara.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCambioLampara.Name = "lblCambioLampara"
        Me.lblCambioLampara.Size = New System.Drawing.Size(117, 29)
        Me.lblCambioLampara.TabIndex = 233
        Me.lblCambioLampara.Text = "¿Registrar cambio de Lámpara?"
        Me.lblCambioLampara.Visible = False
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"INTERNO", "EXTERNO"})
        Me.cboTipo.Location = New System.Drawing.Point(61, 95)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(90, 27)
        Me.cboTipo.TabIndex = 231
        '
        'txtObservacionRecursos
        '
        Me.txtObservacionRecursos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionRecursos.Location = New System.Drawing.Point(304, 95)
        Me.txtObservacionRecursos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservacionRecursos.Name = "txtObservacionRecursos"
        Me.txtObservacionRecursos.Size = New System.Drawing.Size(265, 26)
        Me.txtObservacionRecursos.TabIndex = 228
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(11, 98)
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
        Me.Label6.Location = New System.Drawing.Point(174, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 19)
        Me.Label6.TabIndex = 223
        Me.Label6.Text = "Observaciones"
        '
        'GBTipoReporte
        '
        Me.GBTipoReporte.Controls.Add(Me.Label16)
        Me.GBTipoReporte.Controls.Add(Me.Label2)
        Me.GBTipoReporte.Controls.Add(Me.cmdBuscarReporte)
        Me.GBTipoReporte.Controls.Add(Me.DTPPeriodoFin)
        Me.GBTipoReporte.Controls.Add(Me.DTPPeriodoInicio)
        Me.GBTipoReporte.Controls.Add(Me.cboTipoReporte)
        Me.GBTipoReporte.Controls.Add(Me.Label15)
        Me.GBTipoReporte.Enabled = False
        Me.GBTipoReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTipoReporte.Location = New System.Drawing.Point(52, 116)
        Me.GBTipoReporte.Name = "GBTipoReporte"
        Me.GBTipoReporte.Size = New System.Drawing.Size(770, 64)
        Me.GBTipoReporte.TabIndex = 226
        Me.GBTipoReporte.TabStop = False
        Me.GBTipoReporte.Text = "SELECCIONE EL TIPO DE REPORTE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(424, 28)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 19)
        Me.Label16.TabIndex = 238
        Me.Label16.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(233, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Fecha"
        '
        'cmdBuscarReporte
        '
        Me.cmdBuscarReporte.BackColor = System.Drawing.Color.Navy
        Me.cmdBuscarReporte.FlatAppearance.BorderSize = 0
        Me.cmdBuscarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdBuscarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdBuscarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscarReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarReporte.ForeColor = System.Drawing.Color.White
        Me.cmdBuscarReporte.Location = New System.Drawing.Point(605, 24)
        Me.cmdBuscarReporte.Name = "cmdBuscarReporte"
        Me.cmdBuscarReporte.Size = New System.Drawing.Size(107, 27)
        Me.cmdBuscarReporte.TabIndex = 216
        Me.cmdBuscarReporte.Text = "Buscar"
        Me.cmdBuscarReporte.UseVisualStyleBackColor = False
        '
        'DTPPeriodoFin
        '
        Me.DTPPeriodoFin.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPPeriodoFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPPeriodoFin.Location = New System.Drawing.Point(446, 25)
        Me.DTPPeriodoFin.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPPeriodoFin.Name = "DTPPeriodoFin"
        Me.DTPPeriodoFin.Size = New System.Drawing.Size(129, 26)
        Me.DTPPeriodoFin.TabIndex = 236
        '
        'DTPPeriodoInicio
        '
        Me.DTPPeriodoInicio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPPeriodoInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPPeriodoInicio.Location = New System.Drawing.Point(291, 26)
        Me.DTPPeriodoInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPPeriodoInicio.Name = "DTPPeriodoInicio"
        Me.DTPPeriodoInicio.Size = New System.Drawing.Size(129, 26)
        Me.DTPPeriodoInicio.TabIndex = 235
        '
        'cboTipoReporte
        '
        Me.cboTipoReporte.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.cboTipoReporte.FormattingEnabled = True
        Me.cboTipoReporte.Items.AddRange(New Object() {"---", "DOCENTE", "INDIVIDUAL"})
        Me.cboTipoReporte.Location = New System.Drawing.Point(121, 25)
        Me.cboTipoReporte.Name = "cboTipoReporte"
        Me.cboTipoReporte.Size = New System.Drawing.Size(107, 27)
        Me.cboTipoReporte.TabIndex = 234
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(5, 29)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 19)
        Me.Label15.TabIndex = 233
        Me.Label15.Text = "Tipo Reporte"
        '
        'txtEdificio
        '
        Me.txtEdificio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdificio.Location = New System.Drawing.Point(119, 60)
        Me.txtEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.ReadOnly = True
        Me.txtEdificio.Size = New System.Drawing.Size(59, 26)
        Me.txtEdificio.TabIndex = 304
        Me.txtEdificio.Visible = False
        '
        'txtAula
        '
        Me.txtAula.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAula.Location = New System.Drawing.Point(245, 60)
        Me.txtAula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAula.Name = "txtAula"
        Me.txtAula.ReadOnly = True
        Me.txtAula.Size = New System.Drawing.Size(55, 26)
        Me.txtAula.TabIndex = 303
        Me.txtAula.Visible = False
        '
        'txtidRecurso
        '
        Me.txtidRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidRecurso.Location = New System.Drawing.Point(119, 23)
        Me.txtidRecurso.Name = "txtidRecurso"
        Me.txtidRecurso.ReadOnly = True
        Me.txtidRecurso.Size = New System.Drawing.Size(59, 26)
        Me.txtidRecurso.TabIndex = 237
        '
        'lblAula
        '
        Me.lblAula.AutoSize = True
        Me.lblAula.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAula.ForeColor = System.Drawing.Color.Black
        Me.lblAula.Location = New System.Drawing.Point(190, 63)
        Me.lblAula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAula.Name = "lblAula"
        Me.lblAula.Size = New System.Drawing.Size(45, 19)
        Me.lblAula.TabIndex = 234
        Me.lblAula.Text = "Aula"
        Me.lblAula.Visible = False
        '
        'lblEdificio
        '
        Me.lblEdificio.AutoSize = True
        Me.lblEdificio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdificio.ForeColor = System.Drawing.Color.Black
        Me.lblEdificio.Location = New System.Drawing.Point(11, 63)
        Me.lblEdificio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(81, 19)
        Me.lblEdificio.TabIndex = 233
        Me.lblEdificio.Text = "Edificio"
        Me.lblEdificio.Visible = False
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Items.AddRange(New Object() {"---", "CAÑONES", "COMPUTADORAS", "PANTALLAS", "CONTACTOS", "LAMPARAS"})
        Me.cboCategoria.Location = New System.Drawing.Point(470, 22)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(99, 27)
        Me.cboCategoria.TabIndex = 224
        '
        'txtinvcapece
        '
        Me.txtinvcapece.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvcapece.Location = New System.Drawing.Point(286, 23)
        Me.txtinvcapece.Name = "txtinvcapece"
        Me.txtinvcapece.ReadOnly = True
        Me.txtinvcapece.Size = New System.Drawing.Size(83, 26)
        Me.txtinvcapece.TabIndex = 223
        '
        'txtEstadoRecurso
        '
        Me.txtEstadoRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoRecurso.Location = New System.Drawing.Point(386, 60)
        Me.txtEstadoRecurso.Name = "txtEstadoRecurso"
        Me.txtEstadoRecurso.ReadOnly = True
        Me.txtEstadoRecurso.Size = New System.Drawing.Size(99, 26)
        Me.txtEstadoRecurso.TabIndex = 222
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(190, 26)
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
        Me.Label18.Location = New System.Drawing.Point(376, 26)
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
        Me.Label19.Location = New System.Drawing.Point(320, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 19)
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
        Me.cmdBuscarRecurso.Location = New System.Drawing.Point(644, 26)
        Me.cmdBuscarRecurso.Name = "cmdBuscarRecurso"
        Me.cmdBuscarRecurso.Size = New System.Drawing.Size(101, 46)
        Me.cmdBuscarRecurso.TabIndex = 217
        Me.cmdBuscarRecurso.Text = "Buscar Recurso"
        Me.cmdBuscarRecurso.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(11, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 19)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "ID Recurso"
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
        Me.GBReporte.Location = New System.Drawing.Point(52, 184)
        Me.GBReporte.Name = "GBReporte"
        Me.GBReporte.Size = New System.Drawing.Size(770, 116)
        Me.GBReporte.TabIndex = 224
        Me.GBReporte.TabStop = False
        Me.GBReporte.Text = "INFORMACIÓN DEL REPORTE:"
        '
        'txtEstadoReporte
        '
        Me.txtEstadoReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoReporte.Location = New System.Drawing.Point(150, 66)
        Me.txtEstadoReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstadoReporte.Name = "txtEstadoReporte"
        Me.txtEstadoReporte.ReadOnly = True
        Me.txtEstadoReporte.Size = New System.Drawing.Size(119, 26)
        Me.txtEstadoReporte.TabIndex = 214
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(250, 23)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(119, 26)
        Me.txtFecha.TabIndex = 213
        '
        'txtObservacionesRep
        '
        Me.txtObservacionesRep.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesRep.Location = New System.Drawing.Point(474, 23)
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
        Me.Label14.Location = New System.Drawing.Point(389, 27)
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
        Me.Label12.Location = New System.Drawing.Point(11, 69)
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
        Me.Label7.Location = New System.Drawing.Point(192, 26)
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
        Me.Label10.Location = New System.Drawing.Point(11, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 19)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "ID Reporte"
        '
        'txtIdReporte
        '
        Me.txtIdReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReporte.Location = New System.Drawing.Point(119, 23)
        Me.txtIdReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdReporte.Name = "txtIdReporte"
        Me.txtIdReporte.ReadOnly = True
        Me.txtIdReporte.Size = New System.Drawing.Size(59, 26)
        Me.txtIdReporte.TabIndex = 201
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtId.Location = New System.Drawing.Point(212, 85)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(60, 24)
        Me.txtId.TabIndex = 223
        '
        'idAtencion
        '
        Me.idAtencion.AutoSize = True
        Me.idAtencion.BackColor = System.Drawing.Color.White
        Me.idAtencion.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idAtencion.ForeColor = System.Drawing.Color.Black
        Me.idAtencion.Location = New System.Drawing.Point(51, 85)
        Me.idAtencion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idAtencion.Name = "idAtencion"
        Me.idAtencion.Size = New System.Drawing.Size(142, 24)
        Me.idAtencion.TabIndex = 222
        Me.idAtencion.Text = "ID Atención"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'GBRecursos
        '
        Me.GBRecursos.BackColor = System.Drawing.Color.White
        Me.GBRecursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GBRecursos.Controls.Add(Me.RBNO)
        Me.GBRecursos.Controls.Add(Me.cmdBack)
        Me.GBRecursos.Controls.Add(Me.RBSI)
        Me.GBRecursos.Controls.Add(Me.cmdAgregaD)
        Me.GBRecursos.Controls.Add(Me.lblCambioLampara)
        Me.GBRecursos.Controls.Add(Me.txtAula)
        Me.GBRecursos.Controls.Add(Me.txtEdificio)
        Me.GBRecursos.Controls.Add(Me.txtObservacionRecursos)
        Me.GBRecursos.Controls.Add(Me.cboTipo)
        Me.GBRecursos.Controls.Add(Me.txtEstadoRecurso)
        Me.GBRecursos.Controls.Add(Me.lblAula)
        Me.GBRecursos.Controls.Add(Me.Label19)
        Me.GBRecursos.Controls.Add(Me.Label6)
        Me.GBRecursos.Controls.Add(Me.cmdBuscarRecurso)
        Me.GBRecursos.Controls.Add(Me.LV)
        Me.GBRecursos.Controls.Add(Me.Label11)
        Me.GBRecursos.Controls.Add(Me.txtinvcapece)
        Me.GBRecursos.Controls.Add(Me.cboCategoria)
        Me.GBRecursos.Controls.Add(Me.Label20)
        Me.GBRecursos.Controls.Add(Me.Label17)
        Me.GBRecursos.Controls.Add(Me.txtidRecurso)
        Me.GBRecursos.Controls.Add(Me.lblEdificio)
        Me.GBRecursos.Controls.Add(Me.Label18)
        Me.GBRecursos.Enabled = False
        Me.GBRecursos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GBRecursos.ForeColor = System.Drawing.Color.Black
        Me.GBRecursos.Location = New System.Drawing.Point(52, 299)
        Me.GBRecursos.Name = "GBRecursos"
        Me.GBRecursos.Size = New System.Drawing.Size(770, 250)
        Me.GBRecursos.TabIndex = 228
        Me.GBRecursos.TabStop = False
        Me.GBRecursos.Text = "DETALLES DE RECURSOS:"
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdBack.Enabled = False
        Me.cmdBack.FlatAppearance.BorderSize = 0
        Me.cmdBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBack.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.ForeColor = System.Drawing.Color.White
        Me.cmdBack.Location = New System.Drawing.Point(587, 95)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(69, 27)
        Me.cmdBack.TabIndex = 306
        Me.cmdBack.Text = "Atras"
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'cmdAgregaD
        '
        Me.cmdAgregaD.BackColor = System.Drawing.Color.Navy
        Me.cmdAgregaD.Enabled = False
        Me.cmdAgregaD.FlatAppearance.BorderSize = 0
        Me.cmdAgregaD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdAgregaD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdAgregaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregaD.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregaD.ForeColor = System.Drawing.Color.White
        Me.cmdAgregaD.Location = New System.Drawing.Point(662, 95)
        Me.cmdAgregaD.Name = "cmdAgregaD"
        Me.cmdAgregaD.Size = New System.Drawing.Size(83, 27)
        Me.cmdAgregaD.TabIndex = 305
        Me.cmdAgregaD.Text = "Agregar"
        Me.cmdAgregaD.UseVisualStyleBackColor = False
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdRecurso, Me.INVCAPECE, Me.Categoria, Me.TipoAtencion, Me.Observaciones, Me.CambioLampara})
        Me.LV.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(22, 129)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(723, 113)
        Me.LV.TabIndex = 22
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'IdRecurso
        '
        Me.IdRecurso.Text = "ID Recurso"
        Me.IdRecurso.Width = 82
        '
        'INVCAPECE
        '
        Me.INVCAPECE.Text = "INVCAPECE"
        Me.INVCAPECE.Width = 76
        '
        'Categoria
        '
        Me.Categoria.Text = "Categoría"
        Me.Categoria.Width = 126
        '
        'TipoAtencion
        '
        Me.TipoAtencion.Text = "Tipo de Atención"
        Me.TipoAtencion.Width = 131
        '
        'Observaciones
        '
        Me.Observaciones.Text = "Observaciones"
        Me.Observaciones.Width = 283
        '
        'CambioLampara
        '
        Me.CambioLampara.Text = "CambioLampara"
        Me.CambioLampara.Width = 0
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.White
        Me.btnAyuda.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.AYUDA
        Me.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAyuda.Location = New System.Drawing.Point(33, 15)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(48, 45)
        Me.btnAyuda.TabIndex = 229
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'AtencionReportes_Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.GBRecursos)
        Me.Controls.Add(Me.GBAtencion)
        Me.Controls.Add(Me.GBTipoReporte)
        Me.Controls.Add(Me.GBReporte)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.idAtencion)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AtencionReportes_Registrar"
        Me.Text = "AtencionReportes_Registrar"
        Me.GBAtencion.ResumeLayout(False)
        Me.GBAtencion.PerformLayout()
        Me.GBTipoReporte.ResumeLayout(False)
        Me.GBTipoReporte.PerformLayout()
        Me.GBReporte.ResumeLayout(False)
        Me.GBReporte.PerformLayout()
        Me.GBRecursos.ResumeLayout(False)
        Me.GBRecursos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents GBAtencion As GroupBox
    Friend WithEvents RBNO As RadioButton
    Friend WithEvents RBSI As RadioButton
    Friend WithEvents lblCambioLampara As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtObservacionRecursos As TextBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents txtAtiende As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GBTipoReporte As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdBuscarReporte As Button
    Friend WithEvents DTPPeriodoFin As DateTimePicker
    Friend WithEvents DTPPeriodoInicio As DateTimePicker
    Friend WithEvents cboTipoReporte As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents txtinvcapece As TextBox
    Friend WithEvents txtEstadoRecurso As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmdBuscarRecurso As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents GBReporte As GroupBox
    Friend WithEvents txtEstadoReporte As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtObservacionesRep As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdReporte As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents idAtencion As Label
    Friend WithEvents lblAula As Label
    Friend WithEvents lblEdificio As Label
    Friend WithEvents txtidRecurso As TextBox
    Friend WithEvents txtEdificio As TextBox
    Friend WithEvents txtAula As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GBRecursos As GroupBox
    Friend WithEvents LV As ListView
    Friend WithEvents IdRecurso As ColumnHeader
    Friend WithEvents Categoria As ColumnHeader
    Friend WithEvents TipoAtencion As ColumnHeader
    Friend WithEvents Observaciones As ColumnHeader
    Friend WithEvents INVCAPECE As ColumnHeader
    Friend WithEvents cmdBack As Button
    Friend WithEvents cmdAgregaD As Button
    Friend WithEvents CambioLampara As ColumnHeader
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
