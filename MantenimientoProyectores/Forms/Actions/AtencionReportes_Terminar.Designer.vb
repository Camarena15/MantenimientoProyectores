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
        Me.txtTipoReporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtFechaS = New System.Windows.Forms.TextBox()
        Me.txtAtiende = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.lblGraba = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPPeriodoFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPPeriodoInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoRecurso = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GBReporte.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(379, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TERMINACIÓN DE ATENCIÓN DE REPORTES."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(1147, 518)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 20)
        Me.Label25.TabIndex = 189
        Me.Label25.Text = "Salir"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(1147, 400)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 20)
        Me.Label24.TabIndex = 188
        Me.Label24.Text = "Grabar"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(1147, 448)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(65, 62)
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
        Me.cmdGrabar.Location = New System.Drawing.Point(1147, 330)
        Me.cmdGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(65, 66)
        Me.cmdGrabar.TabIndex = 186
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'idAtencion
        '
        Me.idAtencion.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idAtencion.ForeColor = System.Drawing.Color.Black
        Me.idAtencion.Location = New System.Drawing.Point(15, 20)
        Me.idAtencion.Name = "idAtencion"
        Me.idAtencion.Size = New System.Drawing.Size(236, 53)
        Me.idAtencion.TabIndex = 171
        Me.idAtencion.Text = "Ingrese el periodo de la Atención:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTipoReporte)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.txtFechaS)
        Me.GroupBox2.Controls.Add(Me.txtAtiende)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(76, 181)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1029, 134)
        Me.GroupBox2.TabIndex = 215
        Me.GroupBox2.TabStop = False
        '
        'txtTipoReporte
        '
        Me.txtTipoReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoReporte.ForeColor = System.Drawing.Color.Brown
        Me.txtTipoReporte.Location = New System.Drawing.Point(808, 22)
        Me.txtTipoReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoReporte.Name = "txtTipoReporte"
        Me.txtTipoReporte.ReadOnly = True
        Me.txtTipoReporte.Size = New System.Drawing.Size(179, 31)
        Me.txtTipoReporte.TabIndex = 237
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(645, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 23)
        Me.Label6.TabIndex = 236
        Me.Label6.Text = "Tipo Reporte"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.Brown
        Me.txtEstado.Location = New System.Drawing.Point(424, 22)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(179, 31)
        Me.txtEstado.TabIndex = 235
        Me.txtEstado.Text = "Terminado"
        '
        'txtFechaS
        '
        Me.txtFechaS.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaS.Location = New System.Drawing.Point(183, 22)
        Me.txtFechaS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFechaS.Name = "txtFechaS"
        Me.txtFechaS.ReadOnly = True
        Me.txtFechaS.Size = New System.Drawing.Size(141, 31)
        Me.txtFechaS.TabIndex = 232
        '
        'txtAtiende
        '
        Me.txtAtiende.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtiende.Location = New System.Drawing.Point(183, 85)
        Me.txtAtiende.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAtiende.Name = "txtAtiende"
        Me.txtAtiende.ReadOnly = True
        Me.txtAtiende.Size = New System.Drawing.Size(371, 31)
        Me.txtAtiende.TabIndex = 227
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(331, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 53)
        Me.Label9.TabIndex = 225
        Me.Label9.Text = "Fecha de seguimiento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(19, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 52)
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
        Me.cmdBuscar.Location = New System.Drawing.Point(732, 25)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(143, 33)
        Me.cmdBuscar.TabIndex = 216
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(233, 65)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(92, 31)
        Me.txtId.TabIndex = 217
        '
        'lblGraba
        '
        Me.lblGraba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGraba.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraba.ForeColor = System.Drawing.Color.Black
        Me.lblGraba.Location = New System.Drawing.Point(1241, 302)
        Me.lblGraba.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGraba.Name = "lblGraba"
        Me.lblGraba.Size = New System.Drawing.Size(183, 108)
        Me.lblGraba.TabIndex = 218
        Me.lblGraba.Text = "Para dar por terminada la Atención a Fallas, pulse el boton Grabar             <-" &
    "---"
        Me.lblGraba.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(501, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 23)
        Me.Label16.TabIndex = 242
        Me.Label16.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(247, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "Fecha"
        '
        'DTPPeriodoFin
        '
        Me.DTPPeriodoFin.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPPeriodoFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPPeriodoFin.Location = New System.Drawing.Point(531, 25)
        Me.DTPPeriodoFin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPPeriodoFin.Name = "DTPPeriodoFin"
        Me.DTPPeriodoFin.Size = New System.Drawing.Size(171, 31)
        Me.DTPPeriodoFin.TabIndex = 240
        '
        'DTPPeriodoInicio
        '
        Me.DTPPeriodoInicio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPPeriodoInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPPeriodoInicio.Location = New System.Drawing.Point(324, 26)
        Me.DTPPeriodoInicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPPeriodoInicio.Name = "DTPPeriodoInicio"
        Me.DTPPeriodoInicio.Size = New System.Drawing.Size(171, 31)
        Me.DTPPeriodoInicio.TabIndex = 239
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(71, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 23)
        Me.Label13.TabIndex = 243
        Me.Label13.Text = "ID ATENCIÓN:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTP)
        Me.GroupBox3.Controls.Add(Me.idAtencion)
        Me.GroupBox3.Controls.Add(Me.cmdBuscar)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.DTPPeriodoInicio)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DTPPeriodoFin)
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(75, 105)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1031, 76)
        Me.GroupBox3.TabIndex = 244
        Me.GroupBox3.TabStop = False
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
        Me.GBReporte.Location = New System.Drawing.Point(76, 322)
        Me.GBReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.GBReporte.Name = "GBReporte"
        Me.GBReporte.Padding = New System.Windows.Forms.Padding(4)
        Me.GBReporte.Size = New System.Drawing.Size(1029, 143)
        Me.GBReporte.TabIndex = 245
        Me.GBReporte.TabStop = False
        Me.GBReporte.Text = "INFORMACIÓN DEL REPORTE:"
        '
        'txtEstadoReporte
        '
        Me.txtEstadoReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoReporte.Location = New System.Drawing.Point(200, 81)
        Me.txtEstadoReporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstadoReporte.Name = "txtEstadoReporte"
        Me.txtEstadoReporte.ReadOnly = True
        Me.txtEstadoReporte.Size = New System.Drawing.Size(157, 31)
        Me.txtEstadoReporte.TabIndex = 214
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(333, 28)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(157, 31)
        Me.txtFecha.TabIndex = 213
        '
        'txtObservacionesRep
        '
        Me.txtObservacionesRep.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesRep.Location = New System.Drawing.Point(632, 28)
        Me.txtObservacionesRep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtObservacionesRep.Multiline = True
        Me.txtObservacionesRep.Name = "txtObservacionesRep"
        Me.txtObservacionesRep.ReadOnly = True
        Me.txtObservacionesRep.Size = New System.Drawing.Size(363, 99)
        Me.txtObservacionesRep.TabIndex = 212
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(519, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 23)
        Me.Label14.TabIndex = 208
        Me.Label14.Text = "Concepto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(15, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 23)
        Me.Label12.TabIndex = 206
        Me.Label12.Text = "Estado Reporte"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(256, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 23)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 23)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "ID Reporte"
        '
        'txtIdReporte
        '
        Me.txtIdReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReporte.Location = New System.Drawing.Point(159, 28)
        Me.txtIdReporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdReporte.Name = "txtIdReporte"
        Me.txtIdReporte.ReadOnly = True
        Me.txtIdReporte.Size = New System.Drawing.Size(77, 31)
        Me.txtIdReporte.TabIndex = 201
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(76, 473)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1027, 257)
        Me.GroupBox1.TabIndex = 246
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETALLES DE RECURSOS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, -4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 23)
        Me.Label4.TabIndex = 309
        Me.Label4.Text = "DETALLES DE RECURSOS:"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Categoria, Me.TipoAtencion, Me.Observaciones, Me.EstadoRecurso})
        Me.dgv.Location = New System.Drawing.Point(96, 25)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(808, 213)
        Me.dgv.TabIndex = 308
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID Recurso"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoría"
        Me.Categoria.MinimumWidth = 6
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.Width = 90
        '
        'TipoAtencion
        '
        Me.TipoAtencion.HeaderText = "Tipo de Atención"
        Me.TipoAtencion.MinimumWidth = 6
        Me.TipoAtencion.Name = "TipoAtencion"
        Me.TipoAtencion.ReadOnly = True
        Me.TipoAtencion.Width = 90
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.MinimumWidth = 6
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 200
        '
        'EstadoRecurso
        '
        Me.EstadoRecurso.HeaderText = "Estado Recurso"
        Me.EstadoRecurso.MinimumWidth = 6
        Me.EstadoRecurso.Name = "EstadoRecurso"
        Me.EstadoRecurso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoRecurso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EstadoRecurso.Width = 90
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.White
        Me.btnAyuda.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.AYUDA
        Me.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAyuda.Location = New System.Drawing.Point(29, 12)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(48, 45)
        Me.btnAyuda.TabIndex = 247
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'DTP
        '
        Me.DTP.Enabled = False
        Me.DTP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(324, 26)
        Me.DTP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(171, 31)
        Me.DTP.TabIndex = 243
        Me.DTP.Visible = False
        '
        'AtencionReportes_Terminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1413, 837)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBReporte)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblGraba)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AtencionReportes_Terminar"
        Me.Text = "AtencionReportes_Terminar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBReporte.ResumeLayout(False)
        Me.GBReporte.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtAtiende As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtFechaS As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents lblGraba As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPPeriodoFin As DateTimePicker
    Friend WithEvents DTPPeriodoInicio As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GBReporte As GroupBox
    Friend WithEvents txtEstadoReporte As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtObservacionesRep As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdReporte As TextBox
    Friend WithEvents txtTipoReporte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents TipoAtencion As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents EstadoRecurso As DataGridViewComboBoxColumn
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DTP As DateTimePicker
End Class
