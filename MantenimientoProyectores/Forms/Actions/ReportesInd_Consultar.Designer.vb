<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesInd_Consultar
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBRecurso = New System.Windows.Forms.GroupBox()
        Me.txtidRecurso = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtinvcapece = New System.Windows.Forms.TextBox()
        Me.txtEstadoRecurso = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRecurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(940, 370)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 288
        Me.Label25.Text = "Salir"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(941, 318)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 50)
        Me.cmdSalir.TabIndex = 287
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdInicio
        '
        Me.cmdInicio.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Inicio
        Me.cmdInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdInicio.Location = New System.Drawing.Point(256, 599)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 283
        Me.cmdInicio.Text = " "
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(353, 599)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 284
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Ultimo
        Me.cmdUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUltimo.Location = New System.Drawing.Point(550, 599)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 286
        Me.cmdUltimo.Text = " "
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(450, 599)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 285
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 424)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(750, 179)
        Me.GroupBox2.TabIndex = 282
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONSULTA GENERAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(5, -4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(170, 22)
        Me.Label13.TabIndex = 266
        Me.Label13.Text = "CONSULTA GENERAL"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column9})
        Me.DGV.Location = New System.Drawing.Point(91, 33)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(564, 133)
        Me.DGV.TabIndex = 207
        '
        'Column1
        '
        Me.Column1.HeaderText = "idReporte"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.HeaderText = "idRecurso"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 65
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 85
        '
        'Column8
        '
        Me.Column8.HeaderText = "Concepto"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 185
        '
        'Column9
        '
        Me.Column9.HeaderText = "Estado"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(66, 113)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(750, 192)
        Me.GroupBox1.TabIndex = 281
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA INDIVIDUAL"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(508, 76)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(100, 26)
        Me.txtEstado.TabIndex = 323
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(110, 110)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(309, 71)
        Me.txtObservaciones.TabIndex = 322
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(440, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 321
        Me.Label11.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(5, 110)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 19)
        Me.Label12.TabIndex = 320
        Me.Label12.Text = "Concepto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 19)
        Me.Label5.TabIndex = 318
        Me.Label5.Text = "Fecha de Reporte"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(162, 76)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(121, 26)
        Me.txtFecha.TabIndex = 317
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(288, 33)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(76, 30)
        Me.txtId.TabIndex = 294
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
        Me.cmdBuscar.Location = New System.Drawing.Point(375, 33)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(107, 27)
        Me.cmdBuscar.TabIndex = 285
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 19)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "INGRESE EL ID QUE DESEE BUSCAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(307, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 25)
        Me.Label1.TabIndex = 289
        Me.Label1.Text = "CONSULTA DE REPORTES INDIVIDUALES"
        '
        'GBRecurso
        '
        Me.GBRecurso.Controls.Add(Me.txtidRecurso)
        Me.GBRecurso.Controls.Add(Me.txtCategoria)
        Me.GBRecurso.Controls.Add(Me.txtMarca)
        Me.GBRecurso.Controls.Add(Me.Label2)
        Me.GBRecurso.Controls.Add(Me.txtModelo)
        Me.GBRecurso.Controls.Add(Me.Label14)
        Me.GBRecurso.Controls.Add(Me.txtinvcapece)
        Me.GBRecurso.Controls.Add(Me.txtEstadoRecurso)
        Me.GBRecurso.Controls.Add(Me.Label17)
        Me.GBRecurso.Controls.Add(Me.Label18)
        Me.GBRecurso.Controls.Add(Me.Label19)
        Me.GBRecurso.Controls.Add(Me.Label20)
        Me.GBRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GBRecurso.ForeColor = System.Drawing.Color.Black
        Me.GBRecurso.Location = New System.Drawing.Point(66, 310)
        Me.GBRecurso.Name = "GBRecurso"
        Me.GBRecurso.Size = New System.Drawing.Size(750, 110)
        Me.GBRecurso.TabIndex = 290
        Me.GBRecurso.TabStop = False
        Me.GBRecurso.Text = "INFORMACIÓN DEL RECURSO:"
        '
        'txtidRecurso
        '
        Me.txtidRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidRecurso.Location = New System.Drawing.Point(111, 29)
        Me.txtidRecurso.Name = "txtidRecurso"
        Me.txtidRecurso.ReadOnly = True
        Me.txtidRecurso.Size = New System.Drawing.Size(101, 26)
        Me.txtidRecurso.TabIndex = 230
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(111, 65)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(101, 26)
        Me.txtCategoria.TabIndex = 229
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(506, 61)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(101, 26)
        Me.txtMarca.TabIndex = 228
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(441, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Marca"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(505, 29)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(101, 26)
        Me.txtModelo.TabIndex = 226
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(440, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 19)
        Me.Label14.TabIndex = 225
        Me.Label14.Text = "Modelo"
        '
        'txtinvcapece
        '
        Me.txtinvcapece.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvcapece.Location = New System.Drawing.Point(319, 29)
        Me.txtinvcapece.Name = "txtinvcapece"
        Me.txtinvcapece.ReadOnly = True
        Me.txtinvcapece.Size = New System.Drawing.Size(101, 26)
        Me.txtinvcapece.TabIndex = 223
        '
        'txtEstadoRecurso
        '
        Me.txtEstadoRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoRecurso.Location = New System.Drawing.Point(319, 65)
        Me.txtEstadoRecurso.Name = "txtEstadoRecurso"
        Me.txtEstadoRecurso.ReadOnly = True
        Me.txtEstadoRecurso.Size = New System.Drawing.Size(101, 26)
        Me.txtEstadoRecurso.TabIndex = 222
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(223, 33)
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
        Me.Label19.Location = New System.Drawing.Point(223, 68)
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
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.White
        Me.btnAyuda.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.AYUDA
        Me.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAyuda.Location = New System.Drawing.Point(56, 27)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(36, 37)
        Me.btnAyuda.TabIndex = 291
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'ReportesInd_Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.GBRecurso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportesInd_Consultar"
        Me.Text = "ReportesInd_Consultar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRecurso.ResumeLayout(False)
        Me.GBRecurso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents GBRecurso As GroupBox
    Friend WithEvents txtidRecurso As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtinvcapece As TextBox
    Friend WithEvents txtEstadoRecurso As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
