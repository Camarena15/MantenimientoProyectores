<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtencionPreventivo_Seleccionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AtencionPreventivo_Seleccionar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.cmdSeleccionar = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Encargado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPFin = New System.Windows.Forms.TextBox()
        Me.txtPInicio = New System.Windows.Forms.TextBox()
        Me.txtTipoRegistro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 40)
        Me.Panel1.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.MantenimientoProyectores.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(498, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 217
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.BackColor = System.Drawing.Color.Navy
        Me.cmdSeleccionar.FlatAppearance.BorderSize = 0
        Me.cmdSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSeleccionar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSeleccionar.ForeColor = System.Drawing.Color.White
        Me.cmdSeleccionar.Location = New System.Drawing.Point(210, 315)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(118, 27)
        Me.cmdSeleccionar.TabIndex = 291
        Me.cmdSeleccionar.Text = "Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = False
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(184, 286)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 289
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(280, 286)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 290
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Tipo, Me.Fecha, Me.Encargado, Me.Estado})
        Me.DGV.Location = New System.Drawing.Point(15, 142)
        Me.DGV.Name = "DGV"
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(508, 135)
        Me.DGV.TabIndex = 288
        '
        'Id
        '
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 60
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 80
        '
        'Encargado
        '
        Me.Encargado.HeaderText = "Encargado"
        Me.Encargado.Name = "Encargado"
        Me.Encargado.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(124, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 287
        Me.Label1.Text = "SELECCIONE EL REGISTRO"
        '
        'txtPFin
        '
        Me.txtPFin.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPFin.ForeColor = System.Drawing.Color.Black
        Me.txtPFin.Location = New System.Drawing.Point(402, 84)
        Me.txtPFin.Name = "txtPFin"
        Me.txtPFin.ReadOnly = True
        Me.txtPFin.Size = New System.Drawing.Size(89, 25)
        Me.txtPFin.TabIndex = 297
        '
        'txtPInicio
        '
        Me.txtPInicio.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPInicio.ForeColor = System.Drawing.Color.Black
        Me.txtPInicio.Location = New System.Drawing.Point(285, 84)
        Me.txtPInicio.Name = "txtPInicio"
        Me.txtPInicio.ReadOnly = True
        Me.txtPInicio.Size = New System.Drawing.Size(89, 25)
        Me.txtPInicio.TabIndex = 296
        '
        'txtTipoRegistro
        '
        Me.txtTipoRegistro.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoRegistro.ForeColor = System.Drawing.Color.Black
        Me.txtTipoRegistro.Location = New System.Drawing.Point(67, 84)
        Me.txtTipoRegistro.Name = "txtTipoRegistro"
        Me.txtTipoRegistro.ReadOnly = True
        Me.txtTipoRegistro.Size = New System.Drawing.Size(100, 25)
        Me.txtTipoRegistro.TabIndex = 295
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(379, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 19)
        Me.Label6.TabIndex = 294
        Me.Label6.Text = "A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(172, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 293
        Me.Label5.Text = "Periodo: De"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 292
        Me.Label4.Text = "Tipo:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'AtencionPreventivo_Seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(538, 365)
        Me.Controls.Add(Me.txtPFin)
        Me.Controls.Add(Me.txtPInicio)
        Me.Controls.Add(Me.txtTipoRegistro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdSeleccionar)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AtencionPreventivo_Seleccionar"
        Me.Text = "AtencionPreventivo_Seleccionar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents cmdSeleccionar As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Encargado As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPFin As TextBox
    Friend WithEvents txtPInicio As TextBox
    Friend WithEvents txtTipoRegistro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
End Class
