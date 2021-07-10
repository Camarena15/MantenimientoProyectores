<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtencionReportes_Consultar
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTipoReporte = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIdReporte = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEstadoReporte = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtFechaS = New System.Windows.Forms.TextBox()
        Me.txtAtiende = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.idAtencion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvRecursos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(1197, 524)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 23)
        Me.Label25.TabIndex = 279
        Me.Label25.Text = "Salir"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(1199, 460)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(65, 62)
        Me.cmdSalir.TabIndex = 278
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdInicio
        '
        Me.cmdInicio.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Inicio
        Me.cmdInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdInicio.Location = New System.Drawing.Point(335, 764)
        Me.cmdInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(100, 28)
        Me.cmdInicio.TabIndex = 274
        Me.cmdInicio.Text = " "
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(464, 764)
        Me.cmdAnterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(100, 28)
        Me.cmdAnterior.TabIndex = 275
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Ultimo
        Me.cmdUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUltimo.Location = New System.Drawing.Point(727, 764)
        Me.cmdUltimo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(100, 28)
        Me.cmdUltimo.TabIndex = 277
        Me.cmdUltimo.Text = " "
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(593, 764)
        Me.cmdSiguiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(100, 28)
        Me.cmdSiguiente.TabIndex = 276
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(399, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(396, 25)
        Me.Label2.TabIndex = 273
        Me.Label2.Text = "CONSULTA DE ATENCION A REPORTES"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(76, 524)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 234)
        Me.GroupBox2.TabIndex = 272
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONSULTA INDIVIDUAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, -5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 28)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "CONSULTA GENERAL"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.TipoR, Me.Column4, Me.Column5, Me.Column8})
        Me.dgv.Location = New System.Drawing.Point(107, 27)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(788, 190)
        Me.dgv.TabIndex = 202
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Atencion"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID Reporte"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 65
        '
        'TipoR
        '
        Me.TipoR.HeaderText = "Tipo Reporte"
        Me.TipoR.MinimumWidth = 6
        Me.TipoR.Name = "TipoR"
        Me.TipoR.ReadOnly = True
        Me.TipoR.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Encargado"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Estado"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtFechaS)
        Me.GroupBox1.Controls.Add(Me.txtAtiende)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.idAtencion)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(76, 102)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 207)
        Me.GroupBox1.TabIndex = 271
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA INDIVIDUAL"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(177, 38)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(88, 35)
        Me.txtId.TabIndex = 308
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtTipoReporte)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtFecha)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtIdReporte)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtEstadoReporte)
        Me.Panel2.Location = New System.Drawing.Point(637, 28)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 168)
        Me.Panel2.TabIndex = 307
        '
        'txtTipoReporte
        '
        Me.txtTipoReporte.Enabled = False
        Me.txtTipoReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoReporte.Location = New System.Drawing.Point(171, 44)
        Me.txtTipoReporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTipoReporte.Name = "txtTipoReporte"
        Me.txtTipoReporte.ReadOnly = True
        Me.txtTipoReporte.Size = New System.Drawing.Size(161, 31)
        Me.txtTipoReporte.TabIndex = 310
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 309
        Me.Label3.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(171, 82)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(161, 31)
        Me.txtFecha.TabIndex = 308
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 23)
        Me.Label10.TabIndex = 307
        Me.Label10.Text = "Tipo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(7, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 23)
        Me.Label15.TabIndex = 297
        Me.Label15.Text = "ID Reporte"
        '
        'txtIdReporte
        '
        Me.txtIdReporte.Enabled = False
        Me.txtIdReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdReporte.Location = New System.Drawing.Point(171, 6)
        Me.txtIdReporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdReporte.Name = "txtIdReporte"
        Me.txtIdReporte.ReadOnly = True
        Me.txtIdReporte.Size = New System.Drawing.Size(161, 31)
        Me.txtIdReporte.TabIndex = 298
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 55)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "Estado de Reporte"
        '
        'txtEstadoReporte
        '
        Me.txtEstadoReporte.Enabled = False
        Me.txtEstadoReporte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoReporte.Location = New System.Drawing.Point(171, 121)
        Me.txtEstadoReporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstadoReporte.Name = "txtEstadoReporte"
        Me.txtEstadoReporte.ReadOnly = True
        Me.txtEstadoReporte.Size = New System.Drawing.Size(161, 31)
        Me.txtEstadoReporte.TabIndex = 303
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtEstado.Location = New System.Drawing.Point(437, 89)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(177, 31)
        Me.txtEstado.TabIndex = 295
        '
        'txtFechaS
        '
        Me.txtFechaS.Enabled = False
        Me.txtFechaS.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaS.Location = New System.Drawing.Point(177, 89)
        Me.txtFechaS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFechaS.Name = "txtFechaS"
        Me.txtFechaS.ReadOnly = True
        Me.txtFechaS.Size = New System.Drawing.Size(141, 31)
        Me.txtFechaS.TabIndex = 293
        '
        'txtAtiende
        '
        Me.txtAtiende.Enabled = False
        Me.txtAtiende.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtiende.Location = New System.Drawing.Point(177, 139)
        Me.txtAtiende.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAtiende.Name = "txtAtiende"
        Me.txtAtiende.ReadOnly = True
        Me.txtAtiende.Size = New System.Drawing.Size(439, 31)
        Me.txtAtiende.TabIndex = 291
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(344, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 286
        Me.Label5.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 53)
        Me.Label9.TabIndex = 289
        Me.Label9.Text = "Fecha de seguimiento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 58)
        Me.Label8.TabIndex = 288
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
        Me.cmdBuscar.Location = New System.Drawing.Point(308, 38)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(143, 33)
        Me.cmdBuscar.TabIndex = 285
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'idAtencion
        '
        Me.idAtencion.AutoSize = True
        Me.idAtencion.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.idAtencion.ForeColor = System.Drawing.Color.Black
        Me.idAtencion.Location = New System.Drawing.Point(13, 43)
        Me.idAtencion.Name = "idAtencion"
        Me.idAtencion.Size = New System.Drawing.Size(131, 23)
        Me.idAtencion.TabIndex = 203
        Me.idAtencion.Text = "ID ATENCIÓN"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.dgvRecursos)
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(76, 314)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1000, 203)
        Me.GroupBox3.TabIndex = 280
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DETALLES ATENCIÓN A REPORTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, -1)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(376, 28)
        Me.Label6.TabIndex = 260
        Me.Label6.Text = "DETALLES ATENCIÓN A REPORTES"
        '
        'dgvRecursos
        '
        Me.dgvRecursos.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Categoria, Me.TipoAtencion, Me.Observaciones, Me.EstadoRecurso})
        Me.dgvRecursos.Location = New System.Drawing.Point(96, 34)
        Me.dgvRecursos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvRecursos.Name = "dgvRecursos"
        Me.dgvRecursos.ReadOnly = True
        Me.dgvRecursos.RowHeadersWidth = 51
        Me.dgvRecursos.RowTemplate.Height = 24
        Me.dgvRecursos.Size = New System.Drawing.Size(808, 150)
        Me.dgvRecursos.TabIndex = 202
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
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 200
        '
        'EstadoRecurso
        '
        Me.EstadoRecurso.HeaderText = "Estado Recurso"
        Me.EstadoRecurso.MinimumWidth = 6
        Me.EstadoRecurso.Name = "EstadoRecurso"
        Me.EstadoRecurso.ReadOnly = True
        Me.EstadoRecurso.Width = 90
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.White
        Me.btnAyuda.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.AYUDA
        Me.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAyuda.Location = New System.Drawing.Point(41, 18)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(48, 45)
        Me.btnAyuda.TabIndex = 281
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'AtencionReportes_Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1413, 837)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AtencionReportes_Consultar"
        Me.Text = "AtencionReportes_Consultar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents idAtencion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtFechaS As TextBox
    Friend WithEvents txtAtiende As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIdReporte As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEstadoReporte As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtTipoReporte As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvRecursos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents TipoAtencion As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents EstadoRecurso As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TipoR As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
