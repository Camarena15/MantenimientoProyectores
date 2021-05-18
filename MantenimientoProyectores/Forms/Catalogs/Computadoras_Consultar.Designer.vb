<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Computadoras_Consultar
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtFechaMant = New System.Windows.Forms.TextBox()
        Me.txtFechaAdq = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtHDD = New System.Windows.Forms.TextBox()
        Me.txtMemoria = New System.Windows.Forms.TextBox()
        Me.txtInvcapece = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtProcesador = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctCargando = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCargando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(973, 357)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 282
        Me.Label25.Text = "Salir"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(975, 305)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 50)
        Me.cmdSalir.TabIndex = 281
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdInicio
        '
        Me.cmdInicio.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Inicio
        Me.cmdInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdInicio.Location = New System.Drawing.Point(268, 586)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 277
        Me.cmdInicio.Text = " "
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(365, 586)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 278
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Ultimo
        Me.cmdUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUltimo.Location = New System.Drawing.Point(562, 586)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 280
        Me.cmdUltimo.Text = " "
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(462, 586)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 279
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(33, 374)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(842, 207)
        Me.GroupBox2.TabIndex = 276
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONSULTA GENERAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, -4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(170, 22)
        Me.Label13.TabIndex = 267
        Me.Label13.Text = "CONSULTA GENERAL"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgv.Location = New System.Drawing.Point(9, 30)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(824, 160)
        Me.dgv.TabIndex = 266
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txtFechaMant)
        Me.GroupBox1.Controls.Add(Me.txtFechaAdq)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtHDD)
        Me.GroupBox1.Controls.Add(Me.txtMemoria)
        Me.GroupBox1.Controls.Add(Me.txtInvcapece)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.txtSerie)
        Me.GroupBox1.Controls.Add(Me.txtProcesador)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(33, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(842, 271)
        Me.GroupBox1.TabIndex = 275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA INDIVIDUAL"
        '
        'txtId
        '
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(240, 41)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(76, 30)
        Me.txtId.TabIndex = 289
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
        Me.cmdBuscar.Location = New System.Drawing.Point(332, 41)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(107, 27)
        Me.cmdBuscar.TabIndex = 285
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtFechaMant
        '
        Me.txtFechaMant.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtFechaMant.ForeColor = System.Drawing.Color.Black
        Me.txtFechaMant.Location = New System.Drawing.Point(601, 127)
        Me.txtFechaMant.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaMant.Name = "txtFechaMant"
        Me.txtFechaMant.ReadOnly = True
        Me.txtFechaMant.Size = New System.Drawing.Size(185, 26)
        Me.txtFechaMant.TabIndex = 288
        '
        'txtFechaAdq
        '
        Me.txtFechaAdq.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtFechaAdq.ForeColor = System.Drawing.Color.Black
        Me.txtFechaAdq.Location = New System.Drawing.Point(239, 127)
        Me.txtFechaAdq.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaAdq.Name = "txtFechaAdq"
        Me.txtFechaAdq.ReadOnly = True
        Me.txtFechaAdq.Size = New System.Drawing.Size(185, 26)
        Me.txtFechaAdq.TabIndex = 287
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtEstado.ForeColor = System.Drawing.Color.Black
        Me.txtEstado.Location = New System.Drawing.Point(592, 86)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(194, 26)
        Me.txtEstado.TabIndex = 284
        '
        'txtHDD
        '
        Me.txtHDD.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtHDD.ForeColor = System.Drawing.Color.Black
        Me.txtHDD.Location = New System.Drawing.Point(345, 203)
        Me.txtHDD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHDD.Name = "txtHDD"
        Me.txtHDD.ReadOnly = True
        Me.txtHDD.Size = New System.Drawing.Size(140, 26)
        Me.txtHDD.TabIndex = 283
        '
        'txtMemoria
        '
        Me.txtMemoria.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtMemoria.ForeColor = System.Drawing.Color.Black
        Me.txtMemoria.Location = New System.Drawing.Point(588, 203)
        Me.txtMemoria.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMemoria.Name = "txtMemoria"
        Me.txtMemoria.ReadOnly = True
        Me.txtMemoria.Size = New System.Drawing.Size(198, 26)
        Me.txtMemoria.TabIndex = 282
        '
        'txtInvcapece
        '
        Me.txtInvcapece.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtInvcapece.ForeColor = System.Drawing.Color.Black
        Me.txtInvcapece.Location = New System.Drawing.Point(239, 86)
        Me.txtInvcapece.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvcapece.Name = "txtInvcapece"
        Me.txtInvcapece.ReadOnly = True
        Me.txtInvcapece.Size = New System.Drawing.Size(76, 26)
        Me.txtInvcapece.TabIndex = 281
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtModelo.ForeColor = System.Drawing.Color.Black
        Me.txtModelo.Location = New System.Drawing.Point(141, 165)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(137, 26)
        Me.txtModelo.TabIndex = 280
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtMarca.ForeColor = System.Drawing.Color.Black
        Me.txtMarca.Location = New System.Drawing.Point(345, 165)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(198, 26)
        Me.txtMarca.TabIndex = 279
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtSerie.ForeColor = System.Drawing.Color.Black
        Me.txtSerie.Location = New System.Drawing.Point(643, 165)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(143, 26)
        Me.txtSerie.TabIndex = 278
        '
        'txtProcesador
        '
        Me.txtProcesador.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtProcesador.ForeColor = System.Drawing.Color.Black
        Me.txtProcesador.Location = New System.Drawing.Point(141, 203)
        Me.txtProcesador.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProcesador.Name = "txtProcesador"
        Me.txtProcesador.ReadOnly = True
        Me.txtProcesador.Size = New System.Drawing.Size(137, 26)
        Me.txtProcesador.TabIndex = 277
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(531, 89)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 275
        Me.Label11.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(305, 210)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 19)
        Me.Label10.TabIndex = 274
        Me.Label10.Text = "HDD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(512, 210)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 19)
        Me.Label9.TabIndex = 273
        Me.Label9.Text = "Memoria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(549, 172)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 272
        Me.Label8.Text = "No. serie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(46, 210)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 271
        Me.Label7.Text = "Procesador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(287, 172)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 19)
        Me.Label6.TabIndex = 270
        Me.Label6.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(46, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 269
        Me.Label5.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(432, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 43)
        Me.Label4.TabIndex = 268
        Me.Label4.Text = "Fecha de último mantenimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(46, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 19)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "Fecha de adquisición"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(145, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = "INVCAPECE"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(97, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 265
        Me.Label1.Text = "ID Computadora"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Venus Rising", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(337, 15)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(386, 22)
        Me.Label12.TabIndex = 274
        Me.Label12.Text = "CONSULTA DE COMPUTADORAS"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'pctCargando
        '
        Me.pctCargando.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctCargando.BackColor = System.Drawing.Color.White
        Me.pctCargando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctCargando.Image = Global.MantenimientoProyectores.My.Resources.Resources.Sequence
        Me.pctCargando.Location = New System.Drawing.Point(290, 205)
        Me.pctCargando.Name = "pctCargando"
        Me.pctCargando.Size = New System.Drawing.Size(480, 270)
        Me.pctCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctCargando.TabIndex = 303
        Me.pctCargando.TabStop = False
        Me.pctCargando.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Recurso"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.HeaderText = "INVCAPECE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 65
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha de adquisición "
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 85
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha de último mantenimiento"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.HeaderText = "Modelo"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "Marca"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 40
        '
        'Column7
        '
        Me.Column7.HeaderText = "NO. serie"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "Procesador"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 85
        '
        'Column9
        '
        Me.Column9.HeaderText = "Memoria"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 75
        '
        'Column10
        '
        Me.Column10.HeaderText = "HDD"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 50
        '
        'Column11
        '
        Me.Column11.HeaderText = "Estado"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Computadoras_Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.pctCargando)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Computadoras_Consultar"
        Me.Text = "Computadoras_Consulta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCargando, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtFechaMant As TextBox
    Friend WithEvents txtFechaAdq As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtHDD As TextBox
    Friend WithEvents txtMemoria As TextBox
    Friend WithEvents txtInvcapece As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtProcesador As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pctCargando As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
