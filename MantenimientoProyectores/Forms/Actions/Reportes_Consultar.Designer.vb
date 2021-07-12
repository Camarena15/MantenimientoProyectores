<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes_Consultar
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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtHoraF = New System.Windows.Forms.TextBox()
        Me.txtHoraI = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDocente = New System.Windows.Forms.TextBox()
        Me.txtEdificio = New System.Windows.Forms.TextBox()
        Me.txtAula = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(940, 364)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 280
        Me.Label25.Text = "Salir"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(941, 312)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 50)
        Me.cmdSalir.TabIndex = 279
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(307, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 25)
        Me.Label1.TabIndex = 278
        Me.Label1.Text = "CONSULTA DE REPORTES DE DOCENTES"
        '
        'cmdInicio
        '
        Me.cmdInicio.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Inicio
        Me.cmdInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdInicio.Location = New System.Drawing.Point(256, 530)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 274
        Me.cmdInicio.Text = " "
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(353, 530)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 275
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Ultimo
        Me.cmdUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUltimo.Location = New System.Drawing.Point(550, 530)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 277
        Me.cmdUltimo.Text = " "
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(450, 530)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 276
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 355)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(832, 179)
        Me.GroupBox2.TabIndex = 273
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DGV.Location = New System.Drawing.Point(7, 33)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(819, 133)
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
        Me.Column2.HeaderText = "Docente"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 85
        '
        'Column4
        '
        Me.Column4.HeaderText = "Edificio"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 65
        '
        'Column5
        '
        Me.Column5.HeaderText = "Aula"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 65
        '
        'Column6
        '
        Me.Column6.HeaderText = "Hora de inicio de clases"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 65
        '
        'Column7
        '
        Me.Column7.HeaderText = "Hora final de clases"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 65
        '
        'Column8
        '
        Me.Column8.HeaderText = "Observaciones generales"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
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
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtHoraF)
        Me.GroupBox1.Controls.Add(Me.txtHoraI)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtDocente)
        Me.GroupBox1.Controls.Add(Me.txtEdificio)
        Me.GroupBox1.Controls.Add(Me.txtAula)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(66, 107)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(750, 231)
        Me.GroupBox1.TabIndex = 272
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA INDIVIDUAL"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(201, 112)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(121, 26)
        Me.txtFecha.TabIndex = 317
        '
        'txtHoraF
        '
        Me.txtHoraF.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraF.Location = New System.Drawing.Point(347, 147)
        Me.txtHoraF.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHoraF.Name = "txtHoraF"
        Me.txtHoraF.ReadOnly = True
        Me.txtHoraF.Size = New System.Drawing.Size(80, 26)
        Me.txtHoraF.TabIndex = 316
        '
        'txtHoraI
        '
        Me.txtHoraI.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraI.Location = New System.Drawing.Point(139, 147)
        Me.txtHoraI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHoraI.Name = "txtHoraI"
        Me.txtHoraI.ReadOnly = True
        Me.txtHoraI.Size = New System.Drawing.Size(77, 26)
        Me.txtHoraI.TabIndex = 315
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(327, 187)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(100, 26)
        Me.txtEstado.TabIndex = 314
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(484, 109)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(262, 109)
        Me.txtObservaciones.TabIndex = 307
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(259, 190)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 306
        Me.Label11.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(484, 78)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(216, 19)
        Me.Label12.TabIndex = 305
        Me.Label12.Text = "Observaciones generales"
        '
        'txtDocente
        '
        Me.txtDocente.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocente.Location = New System.Drawing.Point(200, 75)
        Me.txtDocente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDocente.Name = "txtDocente"
        Me.txtDocente.ReadOnly = True
        Me.txtDocente.Size = New System.Drawing.Size(266, 26)
        Me.txtDocente.TabIndex = 303
        '
        'txtEdificio
        '
        Me.txtEdificio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdificio.Location = New System.Drawing.Point(90, 188)
        Me.txtEdificio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.ReadOnly = True
        Me.txtEdificio.Size = New System.Drawing.Size(55, 26)
        Me.txtEdificio.TabIndex = 302
        '
        'txtAula
        '
        Me.txtAula.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAula.Location = New System.Drawing.Point(200, 188)
        Me.txtAula.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAula.Name = "txtAula"
        Me.txtAula.ReadOnly = True
        Me.txtAula.Size = New System.Drawing.Size(55, 26)
        Me.txtAula.TabIndex = 301
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 19)
        Me.Label9.TabIndex = 300
        Me.Label9.Text = "Hora inicial"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(149, 191)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 299
        Me.Label8.Text = "Aula"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(244, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 298
        Me.Label7.Text = "Hora final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 297
        Me.Label6.Text = "Edificio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 19)
        Me.Label5.TabIndex = 296
        Me.Label5.Text = "Fecha que reporta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 19)
        Me.Label4.TabIndex = 295
        Me.Label4.Text = "Docente que reporta"
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
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.White
        Me.btnAyuda.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.AYUDA
        Me.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAyuda.Location = New System.Drawing.Point(45, 22)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(36, 37)
        Me.btnAyuda.TabIndex = 283
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'Reportes_Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reportes_Consultar"
        Me.Text = "Reportes_Consultar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtHoraF As TextBox
    Friend WithEvents txtHoraI As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDocente As TextBox
    Friend WithEvents txtEdificio As TextBox
    Friend WithEvents txtAula As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
