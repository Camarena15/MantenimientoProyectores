<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecursoIndividual_Seleccionar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IDRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVCAPECE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edificio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCartelito = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdSeleccionar = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(800, 40)
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
        Me.btnCerrar.Location = New System.Drawing.Point(760, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 218
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.Color.Black
        Me.txtCategoria.Location = New System.Drawing.Point(107, 121)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(117, 26)
        Me.txtCategoria.TabIndex = 236
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.ForeColor = System.Drawing.Color.Black
        Me.lblCat.Location = New System.Drawing.Point(12, 126)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(90, 19)
        Me.lblCat.TabIndex = 235
        Me.lblCat.Text = "Categoría"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRecurso, Me.INVCAPECE, Me.idCategoria, Me.Categoria, Me.Estado, Me.Edificio, Me.Aula})
        Me.DGV.Location = New System.Drawing.Point(12, 168)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(765, 174)
        Me.DGV.TabIndex = 233
        '
        'IDRecurso
        '
        Me.IDRecurso.HeaderText = "ID Recurso"
        Me.IDRecurso.Name = "IDRecurso"
        Me.IDRecurso.ReadOnly = True
        '
        'INVCAPECE
        '
        Me.INVCAPECE.HeaderText = "INVCAPECE"
        Me.INVCAPECE.Name = "INVCAPECE"
        Me.INVCAPECE.ReadOnly = True
        '
        'idCategoria
        '
        Me.idCategoria.HeaderText = "ID Categoría"
        Me.idCategoria.Name = "idCategoria"
        Me.idCategoria.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoría"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Edificio
        '
        Me.Edificio.HeaderText = "Modelo"
        Me.Edificio.Name = "Edificio"
        Me.Edificio.ReadOnly = True
        '
        'Aula
        '
        Me.Aula.HeaderText = "Marca"
        Me.Aula.Name = "Aula"
        Me.Aula.ReadOnly = True
        '
        'lblCartelito
        '
        Me.lblCartelito.AutoSize = True
        Me.lblCartelito.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartelito.ForeColor = System.Drawing.Color.Black
        Me.lblCartelito.Location = New System.Drawing.Point(11, 89)
        Me.lblCartelito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCartelito.Name = "lblCartelito"
        Me.lblCartelito.Size = New System.Drawing.Size(297, 19)
        Me.lblCartelito.TabIndex = 232
        Me.lblCartelito.Text = "Mostrando Recursos Individuales:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(188, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 25)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "SELECCIONE EL RECURSO INDIVIDUAL"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmdAnterior
        '
        Me.cmdAnterior.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Anterior
        Me.cmdAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAnterior.Location = New System.Drawing.Point(315, 348)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 277
        Me.cmdAnterior.Text = " "
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Siguiente
        Me.cmdSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSiguiente.Location = New System.Drawing.Point(411, 348)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 278
        Me.cmdSiguiente.Text = " "
        Me.cmdSiguiente.UseVisualStyleBackColor = True
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
        Me.cmdSeleccionar.Location = New System.Drawing.Point(341, 377)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(118, 27)
        Me.cmdSeleccionar.TabIndex = 279
        Me.cmdSeleccionar.Text = "Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = False
        '
        'RecursoIndividual_Seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 415)
        Me.Controls.Add(Me.cmdSeleccionar)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.lblCartelito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecursoIndividual_Seleccionar"
        Me.Text = "RecursoIndividual_Seleccionar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents lblCat As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents IDRecurso As DataGridViewTextBoxColumn
    Friend WithEvents INVCAPECE As DataGridViewTextBoxColumn
    Friend WithEvents idCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Edificio As DataGridViewTextBoxColumn
    Friend WithEvents Aula As DataGridViewTextBoxColumn
    Friend WithEvents lblCartelito As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdSeleccionar As Button
End Class
