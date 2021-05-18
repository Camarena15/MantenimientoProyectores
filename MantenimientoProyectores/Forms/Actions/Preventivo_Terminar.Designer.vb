<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preventivo_Terminar
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtTipoServicio = New System.Windows.Forms.TextBox()
        Me.txtFechaInicial = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.txtAtiende = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtinvcapece = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboEstadoRecurso = New System.Windows.Forms.ComboBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdRecurso = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(236, -21)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(333, 19)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "TERMINACION DE SERVICIOS PREVENTIVOS"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(928, 495)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 54)
        Me.cmdSalir.TabIndex = 227
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(925, 457)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 19)
        Me.Label24.TabIndex = 226
        Me.Label24.Text = "Grabar"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.White
        Me.cmdGrabar.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Grabar
        Me.cmdGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabar.Location = New System.Drawing.Point(928, 404)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(49, 54)
        Me.cmdGrabar.TabIndex = 225
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(924, 550)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 224
        Me.Label25.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFechaFinal)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.txtTipoServicio)
        Me.GroupBox2.Controls.Add(Me.txtFechaInicial)
        Me.GroupBox2.Controls.Add(Me.txtConcepto)
        Me.GroupBox2.Controls.Add(Me.txtAtiende)
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(69, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 261)
        Me.GroupBox2.TabIndex = 223
        Me.GroupBox2.TabStop = False
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFinal.Location = New System.Drawing.Point(264, 134)
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.Size = New System.Drawing.Size(130, 26)
        Me.txtFechaFinal.TabIndex = 236
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(476, 29)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(100, 26)
        Me.txtEstado.TabIndex = 234
        Me.txtEstado.Text = "Terminado"
        '
        'txtTipoServicio
        '
        Me.txtTipoServicio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoServicio.Location = New System.Drawing.Point(165, 63)
        Me.txtTipoServicio.Name = "txtTipoServicio"
        Me.txtTipoServicio.ReadOnly = True
        Me.txtTipoServicio.Size = New System.Drawing.Size(130, 26)
        Me.txtTipoServicio.TabIndex = 233
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicial.Location = New System.Drawing.Point(264, 100)
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.ReadOnly = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(130, 26)
        Me.txtFechaInicial.TabIndex = 231
        '
        'txtConcepto
        '
        Me.txtConcepto.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(93, 29)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(301, 26)
        Me.txtConcepto.TabIndex = 70
        '
        'txtAtiende
        '
        Me.txtAtiende.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtiende.Location = New System.Drawing.Point(10, 204)
        Me.txtAtiende.Name = "txtAtiende"
        Me.txtAtiende.ReadOnly = True
        Me.txtAtiende.Size = New System.Drawing.Size(290, 26)
        Me.txtAtiende.TabIndex = 69
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(413, 97)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(334, 143)
        Me.txtObservaciones.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Concepto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 19)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Tipo de Servicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 19)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Fecha Final de Preventivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 19)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Fecha Inicial de Preventivo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(342, 19)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Encargado de Mantenimiento Preventivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(409, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 19)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Observaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(409, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Estado "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtinvcapece)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cboEstadoRecurso)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtIdRecurso)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(69, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 109)
        Me.GroupBox1.TabIndex = 222
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN DEL RECURSO:"
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(541, 67)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(101, 26)
        Me.txtMarca.TabIndex = 236
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(476, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "Marca"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(540, 35)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(101, 26)
        Me.txtModelo.TabIndex = 234
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(475, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 19)
        Me.Label13.TabIndex = 233
        Me.Label13.Text = "Modelo"
        '
        'txtinvcapece
        '
        Me.txtinvcapece.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvcapece.Location = New System.Drawing.Point(354, 35)
        Me.txtinvcapece.Name = "txtinvcapece"
        Me.txtinvcapece.ReadOnly = True
        Me.txtinvcapece.Size = New System.Drawing.Size(101, 26)
        Me.txtinvcapece.TabIndex = 232
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(258, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 19)
        Me.Label17.TabIndex = 230
        Me.Label17.Text = "INVCAPECE"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(258, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 19)
        Me.Label19.TabIndex = 229
        Me.Label19.Text = "Estado"
        '
        'cboEstadoRecurso
        '
        Me.cboEstadoRecurso.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.cboEstadoRecurso.FormattingEnabled = True
        Me.cboEstadoRecurso.Items.AddRange(New Object() {"---", "Disponible"})
        Me.cboEstadoRecurso.Location = New System.Drawing.Point(331, 71)
        Me.cboEstadoRecurso.Name = "cboEstadoRecurso"
        Me.cboEstadoRecurso.Size = New System.Drawing.Size(121, 27)
        Me.cboEstadoRecurso.TabIndex = 226
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(111, 71)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(113, 26)
        Me.txtCategoria.TabIndex = 223
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 19)
        Me.Label14.TabIndex = 220
        Me.Label14.Text = "Categoría"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 19)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "ID Recurso"
        '
        'txtIdRecurso
        '
        Me.txtIdRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRecurso.Location = New System.Drawing.Point(111, 36)
        Me.txtIdRecurso.Name = "txtIdRecurso"
        Me.txtIdRecurso.ReadOnly = True
        Me.txtIdRecurso.Size = New System.Drawing.Size(113, 26)
        Me.txtIdRecurso.TabIndex = 41
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
        Me.cmdBuscar.Location = New System.Drawing.Point(292, 68)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(107, 27)
        Me.cmdBuscar.TabIndex = 217
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(69, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 64)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "Escriba el ID del Registro de Preventivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Venus Rising", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(321, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(487, 21)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "TERMINACIÓN DE SERVICIOS PREVENTIVOS"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(210, 70)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(76, 26)
        Me.txtId.TabIndex = 228
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Preventivo_Terminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Preventivo_Terminar"
        Me.Text = "Preventivo_Terminar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents txtAtiende As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdRecurso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTipoServicio As TextBox
    Friend WithEvents txtFechaInicial As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtFechaFinal As DateTimePicker
    Friend WithEvents cboEstadoRecurso As ComboBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtinvcapece As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Timer1 As Timer
End Class
