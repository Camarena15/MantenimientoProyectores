<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecursoAsignado_Seleccionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecursoAsignado_Seleccionar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAula = New System.Windows.Forms.TextBox()
        Me.txtEdificio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCartelito = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IDRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVCAPECE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edificio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCat = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(915, 40)
        Me.Panel1.TabIndex = 0
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
        Me.btnCerrar.Location = New System.Drawing.Point(875, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 218
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Venus Rising", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(250, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SELECCIONE EL RECURSO ASIGNADO"
        '
        'txtAula
        '
        Me.txtAula.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAula.Location = New System.Drawing.Point(260, 124)
        Me.txtAula.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtAula.Name = "txtAula"
        Me.txtAula.ReadOnly = True
        Me.txtAula.Size = New System.Drawing.Size(60, 26)
        Me.txtAula.TabIndex = 12
        '
        'txtEdificio
        '
        Me.txtEdificio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdificio.Location = New System.Drawing.Point(118, 124)
        Me.txtEdificio.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.ReadOnly = True
        Me.txtEdificio.Size = New System.Drawing.Size(60, 26)
        Me.txtEdificio.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(205, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Aula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Edificio"
        '
        'lblCartelito
        '
        Me.lblCartelito.AutoSize = True
        Me.lblCartelito.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartelito.ForeColor = System.Drawing.Color.Black
        Me.lblCartelito.Location = New System.Drawing.Point(32, 86)
        Me.lblCartelito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCartelito.Name = "lblCartelito"
        Me.lblCartelito.Size = New System.Drawing.Size(297, 19)
        Me.lblCartelito.TabIndex = 13
        Me.lblCartelito.Text = "Mostrando Recursos Asignados en:"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRecurso, Me.INVCAPECE, Me.idCategoria, Me.Categoria, Me.Estado, Me.Edificio, Me.Aula})
        Me.DGV.Location = New System.Drawing.Point(75, 169)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(765, 174)
        Me.DGV.TabIndex = 15
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(747, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 43)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "Haga clic sobre el recurso que desee seleccionar"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.ForeColor = System.Drawing.Color.Black
        Me.lblCat.Location = New System.Drawing.Point(355, 127)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(90, 19)
        Me.lblCat.TabIndex = 225
        Me.lblCat.Text = "Categoría"
        Me.lblCat.Visible = False
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.Color.Black
        Me.txtCategoria.Location = New System.Drawing.Point(450, 122)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(117, 26)
        Me.txtCategoria.TabIndex = 226
        Me.txtCategoria.Visible = False
        '
        'RecursoAsignado_Seleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 353)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.lblCartelito)
        Me.Controls.Add(Me.txtAula)
        Me.Controls.Add(Me.txtEdificio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecursoAsignado_Seleccionar"
        Me.Text = "RecursoAsignado_Seleccionar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAula As TextBox
    Friend WithEvents txtEdificio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCartelito As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents IDRecurso As DataGridViewTextBoxColumn
    Friend WithEvents INVCAPECE As DataGridViewTextBoxColumn
    Friend WithEvents idCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Edificio As DataGridViewTextBoxColumn
    Friend WithEvents Aula As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblCat As Label
    Friend WithEvents txtCategoria As TextBox
End Class
