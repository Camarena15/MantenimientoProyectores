<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes_Buscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes_Buscar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipoReporte = New System.Windows.Forms.TextBox()
        Me.txtPInicio = New System.Windows.Forms.TextBox()
        Me.txtPFin = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtAula = New System.Windows.Forms.ComboBox()
        Me.txtEdificio = New System.Windows.Forms.ComboBox()
        Me.lblAula = New System.Windows.Forms.Label()
        Me.lblEdificio = New System.Windows.Forms.Label()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        Me.IdReporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesGrales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1.Size = New System.Drawing.Size(601, 40)
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
        Me.btnCerrar.Location = New System.Drawing.Point(561, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 217
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Venus Rising", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(154, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SELECCIONE EL REPORTE"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdReporte, Me.Tipo, Me.Fecha, Me.ObservacionesGrales, Me.Estado, Me.E, Me.A})
        Me.DGV.Location = New System.Drawing.Point(22, 195)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(568, 135)
        Me.DGV.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(452, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 43)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "Haga clic sobre el reporte que desee seleccionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 19)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "Buscando Reportes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(202, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "Periodo: De"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(409, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 19)
        Me.Label6.TabIndex = 219
        Me.Label6.Text = "A"
        '
        'txtTipoReporte
        '
        Me.txtTipoReporte.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoReporte.ForeColor = System.Drawing.Color.Black
        Me.txtTipoReporte.Location = New System.Drawing.Point(97, 122)
        Me.txtTipoReporte.Name = "txtTipoReporte"
        Me.txtTipoReporte.ReadOnly = True
        Me.txtTipoReporte.Size = New System.Drawing.Size(100, 25)
        Me.txtTipoReporte.TabIndex = 220
        '
        'txtPInicio
        '
        Me.txtPInicio.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPInicio.ForeColor = System.Drawing.Color.Black
        Me.txtPInicio.Location = New System.Drawing.Point(315, 122)
        Me.txtPInicio.Name = "txtPInicio"
        Me.txtPInicio.ReadOnly = True
        Me.txtPInicio.Size = New System.Drawing.Size(89, 25)
        Me.txtPInicio.TabIndex = 221
        '
        'txtPFin
        '
        Me.txtPFin.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPFin.ForeColor = System.Drawing.Color.Black
        Me.txtPFin.Location = New System.Drawing.Point(432, 122)
        Me.txtPFin.Name = "txtPFin"
        Me.txtPFin.ReadOnly = True
        Me.txtPFin.Size = New System.Drawing.Size(89, 25)
        Me.txtPFin.TabIndex = 222
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'txtAula
        '
        Me.txtAula.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtAula.FormattingEnabled = True
        Me.txtAula.Items.AddRange(New Object() {"---", "1", "2", "3", "4", "5", "6", "7", "8", "*"})
        Me.txtAula.Location = New System.Drawing.Point(253, 153)
        Me.txtAula.Name = "txtAula"
        Me.txtAula.Size = New System.Drawing.Size(62, 27)
        Me.txtAula.TabIndex = 226
        Me.txtAula.Visible = False
        '
        'txtEdificio
        '
        Me.txtEdificio.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtEdificio.FormattingEnabled = True
        Me.txtEdificio.Items.AddRange(New Object() {"---", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "M.V.O.", "INGLES", "LAB"})
        Me.txtEdificio.Location = New System.Drawing.Point(136, 153)
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.Size = New System.Drawing.Size(62, 27)
        Me.txtEdificio.TabIndex = 225
        Me.txtEdificio.Visible = False
        '
        'lblAula
        '
        Me.lblAula.AutoSize = True
        Me.lblAula.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAula.ForeColor = System.Drawing.Color.Black
        Me.lblAula.Location = New System.Drawing.Point(203, 156)
        Me.lblAula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAula.Name = "lblAula"
        Me.lblAula.Size = New System.Drawing.Size(45, 19)
        Me.lblAula.TabIndex = 224
        Me.lblAula.Text = "Aula"
        Me.lblAula.Visible = False
        '
        'lblEdificio
        '
        Me.lblEdificio.AutoSize = True
        Me.lblEdificio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdificio.ForeColor = System.Drawing.Color.Black
        Me.lblEdificio.Location = New System.Drawing.Point(41, 156)
        Me.lblEdificio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(81, 19)
        Me.lblEdificio.TabIndex = 223
        Me.lblEdificio.Text = "Edificio"
        Me.lblEdificio.Visible = False
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.BackColor = System.Drawing.Color.Navy
        Me.cmdFiltrar.FlatAppearance.BorderSize = 0
        Me.cmdFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltrar.ForeColor = System.Drawing.Color.White
        Me.cmdFiltrar.Location = New System.Drawing.Point(340, 152)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(107, 27)
        Me.cmdFiltrar.TabIndex = 227
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.UseVisualStyleBackColor = False
        Me.cmdFiltrar.Visible = False
        '
        'IdReporte
        '
        Me.IdReporte.HeaderText = "ID Reporte"
        Me.IdReporte.Name = "IdReporte"
        Me.IdReporte.ReadOnly = True
        Me.IdReporte.Width = 60
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
        'ObservacionesGrales
        '
        Me.ObservacionesGrales.HeaderText = "Concepto"
        Me.ObservacionesGrales.Name = "ObservacionesGrales"
        Me.ObservacionesGrales.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'E
        '
        Me.E.HeaderText = "E"
        Me.E.Name = "E"
        Me.E.Visible = False
        Me.E.Width = 30
        '
        'A
        '
        Me.A.HeaderText = "A"
        Me.A.Name = "A"
        Me.A.Visible = False
        Me.A.Width = 30
        '
        'Reportes_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(601, 343)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.txtAula)
        Me.Controls.Add(Me.txtEdificio)
        Me.Controls.Add(Me.lblAula)
        Me.Controls.Add(Me.lblEdificio)
        Me.Controls.Add(Me.txtPFin)
        Me.Controls.Add(Me.txtPInicio)
        Me.Controls.Add(Me.txtTipoReporte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reportes_Buscar"
        Me.Text = "Reportes_Buscar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTipoReporte As TextBox
    Friend WithEvents txtPInicio As TextBox
    Friend WithEvents txtPFin As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtAula As ComboBox
    Friend WithEvents txtEdificio As ComboBox
    Friend WithEvents lblAula As Label
    Friend WithEvents lblEdificio As Label
    Friend WithEvents cmdFiltrar As Button
    Friend WithEvents IdReporte As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesGrales As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents E As DataGridViewTextBoxColumn
    Friend WithEvents A As DataGridViewTextBoxColumn
End Class
