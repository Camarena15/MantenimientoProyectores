<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supervision_Consultar
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
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IDSupervision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edificio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGVSupervision = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtAula = New System.Windows.Forms.TextBox()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtEdificio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.lblSecundarios = New System.Windows.Forms.Label()
        Me.lblBtnSecundarios = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenRcs = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVSupervision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(910, 366)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 300
        Me.Label25.Text = "Salir"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(912, 314)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 50)
        Me.cmdSalir.TabIndex = 299
        Me.cmdSalir.UseVisualStyleBackColor = False
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
        Me.cmdBuscar.Location = New System.Drawing.Point(343, 62)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(107, 27)
        Me.cmdBuscar.TabIndex = 298
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 396)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(750, 199)
        Me.GroupBox1.TabIndex = 297
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA GENERAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, -4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 22)
        Me.Label9.TabIndex = 260
        Me.Label9.Text = "CONSULTA GENERAL"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSupervision, Me.Fecha, Me.Responsable, Me.Edificio, Me.Aula})
        Me.DGV.Location = New System.Drawing.Point(117, 30)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(523, 153)
        Me.DGV.TabIndex = 212
        '
        'IDSupervision
        '
        Me.IDSupervision.HeaderText = "ID Supervisión"
        Me.IDSupervision.Name = "IDSupervision"
        Me.IDSupervision.ReadOnly = True
        Me.IDSupervision.Width = 80
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 85
        '
        'Responsable
        '
        Me.Responsable.HeaderText = "Responsable"
        Me.Responsable.Name = "Responsable"
        Me.Responsable.ReadOnly = True
        Me.Responsable.Width = 150
        '
        'Edificio
        '
        Me.Edificio.HeaderText = "Edificio"
        Me.Edificio.Name = "Edificio"
        Me.Edificio.ReadOnly = True
        Me.Edificio.Width = 65
        '
        'Aula
        '
        Me.Aula.HeaderText = "Aula"
        Me.Aula.Name = "Aula"
        Me.Aula.ReadOnly = True
        Me.Aula.Width = 65
        '
        'cmdInicio
        '
        Me.cmdInicio.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Inicio
        Me.cmdInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdInicio.Location = New System.Drawing.Point(246, 600)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 292
        Me.cmdInicio.Text = " "
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(343, 600)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 293
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Ultimo
        Me.cmdUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUltimo.Location = New System.Drawing.Point(540, 600)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 295
        Me.cmdUltimo.Text = " "
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(440, 600)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 294
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGVSupervision)
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(57, 222)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 169)
        Me.GroupBox3.TabIndex = 291
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DETALLES SUPERVISIÓN"
        '
        'DGVSupervision
        '
        Me.DGVSupervision.BackgroundColor = System.Drawing.Color.White
        Me.DGVSupervision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSupervision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.ImagenRcs})
        Me.DGVSupervision.Location = New System.Drawing.Point(21, 27)
        Me.DGVSupervision.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVSupervision.MultiSelect = False
        Me.DGVSupervision.Name = "DGVSupervision"
        Me.DGVSupervision.ReadOnly = True
        Me.DGVSupervision.RowHeadersWidth = 51
        Me.DGVSupervision.RowTemplate.Height = 24
        Me.DGVSupervision.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVSupervision.Size = New System.Drawing.Size(689, 126)
        Me.DGVSupervision.TabIndex = 213
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(103, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 290
        Me.Label3.Text = "ID Supervisión"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFecha)
        Me.GroupBox2.Controls.Add(Me.txtAula)
        Me.GroupBox2.Controls.Add(Me.txtResponsable)
        Me.GroupBox2.Controls.Add(Me.txtEdificio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(57, 105)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(750, 111)
        Me.GroupBox2.TabIndex = 289
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONSULTA INDIVIDUAL- DATOS GENERALES"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(470, 31)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(200, 32)
        Me.txtFecha.TabIndex = 9
        '
        'txtAula
        '
        Me.txtAula.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAula.Location = New System.Drawing.Point(299, 71)
        Me.txtAula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAula.Name = "txtAula"
        Me.txtAula.ReadOnly = True
        Me.txtAula.Size = New System.Drawing.Size(76, 26)
        Me.txtAula.TabIndex = 8
        '
        'txtResponsable
        '
        Me.txtResponsable.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.Location = New System.Drawing.Point(118, 35)
        Me.txtResponsable.Margin = New System.Windows.Forms.Padding(2)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.ReadOnly = True
        Me.txtResponsable.Size = New System.Drawing.Size(281, 26)
        Me.txtResponsable.TabIndex = 7
        '
        'txtEdificio
        '
        Me.txtEdificio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdificio.Location = New System.Drawing.Point(117, 71)
        Me.txtEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.ReadOnly = True
        Me.txtEdificio.Size = New System.Drawing.Size(76, 26)
        Me.txtEdificio.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(229, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Aula"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(417, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Responsable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Edificio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Venus Rising", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(372, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 21)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "CONSULTA DE SUPERVISIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(64, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 22)
        Me.Label2.TabIndex = 261
        Me.Label2.Text = "DETALLES SUPERVISIÓN"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(255, 62)
        Me.txtId.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(76, 26)
        Me.txtId.TabIndex = 301
        '
        'lblSecundarios
        '
        Me.lblSecundarios.AutoSize = True
        Me.lblSecundarios.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecundarios.ForeColor = System.Drawing.Color.Black
        Me.lblSecundarios.Location = New System.Drawing.Point(233, 642)
        Me.lblSecundarios.Name = "lblSecundarios"
        Me.lblSecundarios.Size = New System.Drawing.Size(396, 19)
        Me.lblSecundarios.TabIndex = 302
        Me.lblSecundarios.Text = "HAZ CLIC      PARA VER DETALLES SECUNDARIOS"
        Me.lblSecundarios.Visible = False
        '
        'lblBtnSecundarios
        '
        Me.lblBtnSecundarios.AutoSize = True
        Me.lblBtnSecundarios.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBtnSecundarios.ForeColor = System.Drawing.Color.Red
        Me.lblBtnSecundarios.Location = New System.Drawing.Point(313, 642)
        Me.lblBtnSecundarios.Name = "lblBtnSecundarios"
        Me.lblBtnSecundarios.Size = New System.Drawing.Size(45, 19)
        Me.lblBtnSecundarios.TabIndex = 304
        Me.lblBtnSecundarios.Text = "AQUI"
        Me.lblBtnSecundarios.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID Recurso"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Horas Trabajadas (Cañon)"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'ImagenRcs
        '
        Me.ImagenRcs.HeaderText = "Imagen"
        Me.ImagenRcs.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ImagenRcs.Name = "ImagenRcs"
        Me.ImagenRcs.ReadOnly = True
        Me.ImagenRcs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ImagenRcs.Width = 160
        '
        'Supervision_Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.lblBtnSecundarios)
        Me.Controls.Add(Me.lblSecundarios)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supervision_Consultar"
        Me.Text = "Supervision_Consultar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGVSupervision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label25 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtAula As TextBox
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents txtEdificio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVSupervision As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents IDSupervision As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Responsable As DataGridViewTextBoxColumn
    Friend WithEvents Edificio As DataGridViewTextBoxColumn
    Friend WithEvents Aula As DataGridViewTextBoxColumn
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents lblSecundarios As Label
    Friend WithEvents lblBtnSecundarios As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ImagenRcs As DataGridViewImageColumn
End Class
