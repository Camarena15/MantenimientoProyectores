<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantallas_Consultar
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.IdRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Invcapece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dimension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtDimension = New System.Windows.Forms.TextBox()
        Me.txtINVCAPECE = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctCargando = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCargando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRecurso, Me.Tipo, Me.Invcapece, Me.Marca, Me.Modelo, Me.Dimension, Me.Estado})
        Me.dgv.Location = New System.Drawing.Point(12, 28)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(722, 194)
        Me.dgv.TabIndex = 256
        '
        'IdRecurso
        '
        Me.IdRecurso.HeaderText = "ID Recurso"
        Me.IdRecurso.Name = "IdRecurso"
        Me.IdRecurso.ReadOnly = True
        Me.IdRecurso.Width = 80
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 80
        '
        'Invcapece
        '
        Me.Invcapece.HeaderText = "INVCAPECE"
        Me.Invcapece.Name = "Invcapece"
        Me.Invcapece.ReadOnly = True
        Me.Invcapece.Width = 75
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 110
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 110
        '
        'Dimension
        '
        Me.Dimension.HeaderText = "Dimensión"
        Me.Dimension.Name = "Dimension"
        Me.Dimension.ReadOnly = True
        Me.Dimension.Width = 75
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(380, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(301, 25)
        Me.Label8.TabIndex = 255
        Me.Label8.Text = "CONSULTA DE PANTALLAS"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(914, 342)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 50)
        Me.cmdSalir.TabIndex = 252
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(57, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 240)
        Me.GroupBox2.TabIndex = 258
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, -5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 22)
        Me.Label9.TabIndex = 259
        Me.Label9.Text = "CONSULTA GENERAL"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtDimension)
        Me.GroupBox1.Controls.Add(Me.txtINVCAPECE)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(57, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 240)
        Me.GroupBox1.TabIndex = 257
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA INDIVIDUAL"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(121, 35)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(76, 30)
        Me.txtId.TabIndex = 287
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
        Me.cmdBuscar.Location = New System.Drawing.Point(217, 35)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(107, 27)
        Me.cmdBuscar.TabIndex = 284
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(487, 187)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(185, 26)
        Me.txtEstado.TabIndex = 283
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(487, 139)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(185, 26)
        Me.txtModelo.TabIndex = 282
        '
        'txtDimension
        '
        Me.txtDimension.Enabled = False
        Me.txtDimension.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimension.Location = New System.Drawing.Point(287, 139)
        Me.txtDimension.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDimension.Name = "txtDimension"
        Me.txtDimension.ReadOnly = True
        Me.txtDimension.Size = New System.Drawing.Size(94, 26)
        Me.txtDimension.TabIndex = 281
        '
        'txtINVCAPECE
        '
        Me.txtINVCAPECE.Enabled = False
        Me.txtINVCAPECE.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtINVCAPECE.Location = New System.Drawing.Point(120, 92)
        Me.txtINVCAPECE.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINVCAPECE.Name = "txtINVCAPECE"
        Me.txtINVCAPECE.ReadOnly = True
        Me.txtINVCAPECE.Size = New System.Drawing.Size(76, 26)
        Me.txtINVCAPECE.TabIndex = 280
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(287, 92)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(94, 26)
        Me.txtTipo.TabIndex = 279
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(487, 92)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(185, 26)
        Me.txtMarca.TabIndex = 278
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(420, 190)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 19)
        Me.Label7.TabIndex = 276
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(186, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 275
        Me.Label6.Text = "Dimensión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(420, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 274
        Me.Label5.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(429, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 273
        Me.Label4.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(231, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 272
        Me.Label3.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "INVCAPECE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "ID Pantalla"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(913, 394)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 260
        Me.Label25.Text = "Salir"
        '
        'cmdInicio
        '
        Me.cmdInicio.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Inicio
        Me.cmdInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdInicio.Location = New System.Drawing.Point(234, 588)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 261
        Me.cmdInicio.Text = " "
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(331, 588)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 262
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Ultimo
        Me.cmdUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUltimo.Location = New System.Drawing.Point(528, 588)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 264
        Me.cmdUltimo.Text = " "
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(428, 588)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 263
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
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
        'Pantallas_Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.pctCargando)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pantallas_Consultar"
        Me.Text = "Pantallas_Consulta"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCargando, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtDimension As TextBox
    Friend WithEvents txtINVCAPECE As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pctCargando As PictureBox
    Friend WithEvents IdRecurso As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Invcapece As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Dimension As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
