<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supervision_Registrar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAula = New System.Windows.Forms.ComboBox()
        Me.txtEdificio = New System.Windows.Forms.ComboBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtImgVentanas = New System.Windows.Forms.TextBox()
        Me.txtImgLamparas = New System.Windows.Forms.TextBox()
        Me.txtImgElectri = New System.Windows.Forms.TextBox()
        Me.txtImgPintarron = New System.Windows.Forms.TextBox()
        Me.txtImgElect = New System.Windows.Forms.TextBox()
        Me.txtImgConexiones = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtObsVentanas = New System.Windows.Forms.TextBox()
        Me.txtObsLamparas = New System.Windows.Forms.TextBox()
        Me.txtObsElectri = New System.Windows.Forms.TextBox()
        Me.txtObsPintarron = New System.Windows.Forms.TextBox()
        Me.txtObsElect = New System.Windows.Forms.TextBox()
        Me.txtObsconex = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NupHorasT = New System.Windows.Forms.NumericUpDown()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdSeleccionar = New System.Windows.Forms.Button()
        Me.cmdAgregaD = New System.Windows.Forms.Button()
        Me.LV = New System.Windows.Forms.ListView()
        Me.IdRecurso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HorasTrabajadas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Observaciones = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Imagen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtImgRuta = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtIdRecurso = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chkDatosSecundarios = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NupHorasT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(378, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "REGISTRO DE SUPERVISIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAula)
        Me.GroupBox1.Controls.Add(Me.txtEdificio)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(57, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(750, 111)
        Me.GroupBox1.TabIndex = 175
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS GENERALES"
        '
        'txtAula
        '
        Me.txtAula.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtAula.FormattingEnabled = True
        Me.txtAula.Items.AddRange(New Object() {"---", "01", "02", "03", "04", "05", "06", "07", "08"})
        Me.txtAula.Location = New System.Drawing.Point(218, 75)
        Me.txtAula.Name = "txtAula"
        Me.txtAula.Size = New System.Drawing.Size(62, 27)
        Me.txtAula.TabIndex = 11
        '
        'txtEdificio
        '
        Me.txtEdificio.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtEdificio.FormattingEnabled = True
        Me.txtEdificio.Items.AddRange(New Object() {"---", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.txtEdificio.Location = New System.Drawing.Point(101, 75)
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.Size = New System.Drawing.Size(62, 27)
        Me.txtEdificio.TabIndex = 10
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(484, 35)
        Me.DTP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(114, 26)
        Me.DTP.TabIndex = 9
        '
        'txtResponsable
        '
        Me.txtResponsable.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.Location = New System.Drawing.Point(118, 35)
        Me.txtResponsable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtResponsable.MaxLength = 100
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(281, 26)
        Me.txtResponsable.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(168, 78)
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
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(239, 49)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(76, 26)
        Me.txtId.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtImgVentanas)
        Me.GroupBox3.Controls.Add(Me.txtImgLamparas)
        Me.GroupBox3.Controls.Add(Me.txtImgElectri)
        Me.GroupBox3.Controls.Add(Me.txtImgPintarron)
        Me.GroupBox3.Controls.Add(Me.txtImgElect)
        Me.GroupBox3.Controls.Add(Me.txtImgConexiones)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtObsVentanas)
        Me.GroupBox3.Controls.Add(Me.txtObsLamparas)
        Me.GroupBox3.Controls.Add(Me.txtObsElectri)
        Me.GroupBox3.Controls.Add(Me.txtObsPintarron)
        Me.GroupBox3.Controls.Add(Me.txtObsElect)
        Me.GroupBox3.Controls.Add(Me.txtObsconex)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(57, 429)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 239)
        Me.GroupBox3.TabIndex = 188
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS SECUNDARIOS"
        '
        'txtImgVentanas
        '
        Me.txtImgVentanas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgVentanas.ForeColor = System.Drawing.Color.Black
        Me.txtImgVentanas.Location = New System.Drawing.Point(575, 210)
        Me.txtImgVentanas.MaxLength = 225
        Me.txtImgVentanas.Name = "txtImgVentanas"
        Me.txtImgVentanas.ReadOnly = True
        Me.txtImgVentanas.Size = New System.Drawing.Size(158, 20)
        Me.txtImgVentanas.TabIndex = 23
        Me.txtImgVentanas.Text = "Haz clic para Seleccionar"
        '
        'txtImgLamparas
        '
        Me.txtImgLamparas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgLamparas.ForeColor = System.Drawing.Color.Black
        Me.txtImgLamparas.Location = New System.Drawing.Point(575, 175)
        Me.txtImgLamparas.MaxLength = 225
        Me.txtImgLamparas.Name = "txtImgLamparas"
        Me.txtImgLamparas.ReadOnly = True
        Me.txtImgLamparas.Size = New System.Drawing.Size(158, 20)
        Me.txtImgLamparas.TabIndex = 22
        Me.txtImgLamparas.Text = "Haz clic para Seleccionar"
        '
        'txtImgElectri
        '
        Me.txtImgElectri.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgElectri.ForeColor = System.Drawing.Color.Black
        Me.txtImgElectri.Location = New System.Drawing.Point(575, 140)
        Me.txtImgElectri.MaxLength = 225
        Me.txtImgElectri.Name = "txtImgElectri"
        Me.txtImgElectri.ReadOnly = True
        Me.txtImgElectri.Size = New System.Drawing.Size(158, 20)
        Me.txtImgElectri.TabIndex = 21
        Me.txtImgElectri.Text = "Haz clic para Seleccionar"
        '
        'txtImgPintarron
        '
        Me.txtImgPintarron.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgPintarron.ForeColor = System.Drawing.Color.Black
        Me.txtImgPintarron.Location = New System.Drawing.Point(575, 106)
        Me.txtImgPintarron.MaxLength = 225
        Me.txtImgPintarron.Name = "txtImgPintarron"
        Me.txtImgPintarron.ReadOnly = True
        Me.txtImgPintarron.Size = New System.Drawing.Size(158, 20)
        Me.txtImgPintarron.TabIndex = 20
        Me.txtImgPintarron.Text = "Haz clic para Seleccionar"
        '
        'txtImgElect
        '
        Me.txtImgElect.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgElect.ForeColor = System.Drawing.Color.Black
        Me.txtImgElect.Location = New System.Drawing.Point(575, 72)
        Me.txtImgElect.MaxLength = 225
        Me.txtImgElect.Name = "txtImgElect"
        Me.txtImgElect.ReadOnly = True
        Me.txtImgElect.Size = New System.Drawing.Size(158, 20)
        Me.txtImgElect.TabIndex = 19
        Me.txtImgElect.Text = "Haz clic para Seleccionar"
        '
        'txtImgConexiones
        '
        Me.txtImgConexiones.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgConexiones.ForeColor = System.Drawing.Color.Black
        Me.txtImgConexiones.Location = New System.Drawing.Point(575, 38)
        Me.txtImgConexiones.MaxLength = 225
        Me.txtImgConexiones.Name = "txtImgConexiones"
        Me.txtImgConexiones.ReadOnly = True
        Me.txtImgConexiones.Size = New System.Drawing.Size(158, 20)
        Me.txtImgConexiones.TabIndex = 18
        Me.txtImgConexiones.Text = "Haz clic para Seleccionar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(506, 208)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 19)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Imagen"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(506, 173)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 19)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Imagen"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(506, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 19)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Imagen"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(506, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 19)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Imagen"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(506, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 19)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Imagen"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(506, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 19)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Imagen"
        '
        'txtObsVentanas
        '
        Me.txtObsVentanas.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsVentanas.Location = New System.Drawing.Point(258, 205)
        Me.txtObsVentanas.MaxLength = 225
        Me.txtObsVentanas.Name = "txtObsVentanas"
        Me.txtObsVentanas.Size = New System.Drawing.Size(242, 26)
        Me.txtObsVentanas.TabIndex = 11
        '
        'txtObsLamparas
        '
        Me.txtObsLamparas.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsLamparas.Location = New System.Drawing.Point(258, 170)
        Me.txtObsLamparas.MaxLength = 225
        Me.txtObsLamparas.Name = "txtObsLamparas"
        Me.txtObsLamparas.Size = New System.Drawing.Size(242, 26)
        Me.txtObsLamparas.TabIndex = 10
        '
        'txtObsElectri
        '
        Me.txtObsElectri.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsElectri.Location = New System.Drawing.Point(258, 135)
        Me.txtObsElectri.MaxLength = 225
        Me.txtObsElectri.Name = "txtObsElectri"
        Me.txtObsElectri.Size = New System.Drawing.Size(242, 26)
        Me.txtObsElectri.TabIndex = 9
        '
        'txtObsPintarron
        '
        Me.txtObsPintarron.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsPintarron.Location = New System.Drawing.Point(258, 101)
        Me.txtObsPintarron.MaxLength = 225
        Me.txtObsPintarron.Name = "txtObsPintarron"
        Me.txtObsPintarron.Size = New System.Drawing.Size(242, 26)
        Me.txtObsPintarron.TabIndex = 8
        '
        'txtObsElect
        '
        Me.txtObsElect.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsElect.Location = New System.Drawing.Point(258, 67)
        Me.txtObsElect.MaxLength = 225
        Me.txtObsElect.Name = "txtObsElect"
        Me.txtObsElect.Size = New System.Drawing.Size(242, 26)
        Me.txtObsElect.TabIndex = 7
        '
        'txtObsconex
        '
        Me.txtObsconex.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsconex.Location = New System.Drawing.Point(258, 33)
        Me.txtObsconex.MaxLength = 225
        Me.txtObsconex.Name = "txtObsconex"
        Me.txtObsconex.Size = New System.Drawing.Size(242, 26)
        Me.txtObsconex.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(207, 19)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Observaciones Ventanas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 19)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Observaciones Lámparas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(243, 19)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Observaciones Electricidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Observaciones Pintarrón"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(234, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Observaciones Con. Elect."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Observaciones Caja Conexión"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(57, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 24)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "ID SUPERVISION"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NupHorasT)
        Me.GroupBox2.Controls.Add(Me.cmdBack)
        Me.GroupBox2.Controls.Add(Me.cmdSeleccionar)
        Me.GroupBox2.Controls.Add(Me.cmdAgregaD)
        Me.GroupBox2.Controls.Add(Me.LV)
        Me.GroupBox2.Controls.Add(Me.txtImgRuta)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtIdRecurso)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(57, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 225)
        Me.GroupBox2.TabIndex = 221
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLES SUPERVISIÓN"
        '
        'NupHorasT
        '
        Me.NupHorasT.Enabled = False
        Me.NupHorasT.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NupHorasT.Location = New System.Drawing.Point(463, 40)
        Me.NupHorasT.Name = "NupHorasT"
        Me.NupHorasT.Size = New System.Drawing.Size(49, 20)
        Me.NupHorasT.TabIndex = 220
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdBack.Enabled = False
        Me.cmdBack.FlatAppearance.BorderSize = 0
        Me.cmdBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBack.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.ForeColor = System.Drawing.Color.White
        Me.cmdBack.Location = New System.Drawing.Point(518, 37)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(69, 27)
        Me.cmdBack.TabIndex = 219
        Me.cmdBack.Text = "Atras"
        Me.cmdBack.UseVisualStyleBackColor = False
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
        Me.cmdSeleccionar.Location = New System.Drawing.Point(234, 37)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(118, 27)
        Me.cmdSeleccionar.TabIndex = 218
        Me.cmdSeleccionar.Text = "Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = False
        '
        'cmdAgregaD
        '
        Me.cmdAgregaD.BackColor = System.Drawing.Color.Navy
        Me.cmdAgregaD.FlatAppearance.BorderSize = 0
        Me.cmdAgregaD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdAgregaD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdAgregaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregaD.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregaD.ForeColor = System.Drawing.Color.White
        Me.cmdAgregaD.Location = New System.Drawing.Point(593, 37)
        Me.cmdAgregaD.Name = "cmdAgregaD"
        Me.cmdAgregaD.Size = New System.Drawing.Size(83, 27)
        Me.cmdAgregaD.TabIndex = 217
        Me.cmdAgregaD.Text = "Agregar"
        Me.cmdAgregaD.UseVisualStyleBackColor = False
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdRecurso, Me.HorasTrabajadas, Me.Observaciones, Me.Imagen})
        Me.LV.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(10, 106)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(723, 113)
        Me.LV.TabIndex = 21
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'IdRecurso
        '
        Me.IdRecurso.Text = "ID Recurso"
        Me.IdRecurso.Width = 145
        '
        'HorasTrabajadas
        '
        Me.HorasTrabajadas.Text = "Horas Trabajadas"
        Me.HorasTrabajadas.Width = 126
        '
        'Observaciones
        '
        Me.Observaciones.Text = "Observaciones"
        Me.Observaciones.Width = 231
        '
        'Imagen
        '
        Me.Imagen.Text = "Ruta Imagen"
        Me.Imagen.Width = 203
        '
        'txtImgRuta
        '
        Me.txtImgRuta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgRuta.ForeColor = System.Drawing.Color.Black
        Me.txtImgRuta.Location = New System.Drawing.Point(518, 80)
        Me.txtImgRuta.MaxLength = 225
        Me.txtImgRuta.Name = "txtImgRuta"
        Me.txtImgRuta.ReadOnly = True
        Me.txtImgRuta.Size = New System.Drawing.Size(158, 20)
        Me.txtImgRuta.TabIndex = 20
        Me.txtImgRuta.Text = "Haz clic para Seleccionar"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(449, 78)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 19)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Imagen"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(204, 75)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 225
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(240, 26)
        Me.txtObservaciones.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(73, 78)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 19)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Observaciones"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(361, 29)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 49)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Horas Trabajadas"
        '
        'txtIdRecurso
        '
        Me.txtIdRecurso.Enabled = False
        Me.txtIdRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRecurso.Location = New System.Drawing.Point(177, 38)
        Me.txtIdRecurso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIdRecurso.Name = "txtIdRecurso"
        Me.txtIdRecurso.ReadOnly = True
        Me.txtIdRecurso.Size = New System.Drawing.Size(42, 26)
        Me.txtIdRecurso.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(73, 40)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 38)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "ID Recurso "
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(916, 492)
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
        Me.Label24.Location = New System.Drawing.Point(913, 454)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 19)
        Me.Label24.TabIndex = 226
        Me.Label24.Text = "Grabar"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(913, 362)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 19)
        Me.Label23.TabIndex = 225
        Me.Label23.Text = "Nuevo"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.White
        Me.cmdGrabar.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Grabar
        Me.cmdGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabar.Location = New System.Drawing.Point(916, 397)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(49, 54)
        Me.cmdGrabar.TabIndex = 224
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.Color.White
        Me.cmdNuevo.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Nuevo
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNuevo.Location = New System.Drawing.Point(916, 310)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(49, 50)
        Me.cmdNuevo.TabIndex = 223
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(912, 547)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 19)
        Me.Label25.TabIndex = 222
        Me.Label25.Text = "Salir"
        '
        'chkDatosSecundarios
        '
        Me.chkDatosSecundarios.AutoSize = True
        Me.chkDatosSecundarios.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatosSecundarios.Location = New System.Drawing.Point(279, 435)
        Me.chkDatosSecundarios.Name = "chkDatosSecundarios"
        Me.chkDatosSecundarios.Size = New System.Drawing.Size(15, 14)
        Me.chkDatosSecundarios.TabIndex = 228
        Me.chkDatosSecundarios.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1500
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.White
        Me.btnAyuda.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.AYUDA
        Me.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAyuda.Location = New System.Drawing.Point(9, 8)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(34, 36)
        Me.btnAyuda.TabIndex = 247
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'Supervision_Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.chkDatosSecundarios)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supervision_Registrar"
        Me.Text = "Supervision_Registrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NupHorasT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtImgVentanas As TextBox
    Friend WithEvents txtImgLamparas As TextBox
    Friend WithEvents txtImgElectri As TextBox
    Friend WithEvents txtImgPintarron As TextBox
    Friend WithEvents txtImgElect As TextBox
    Friend WithEvents txtImgConexiones As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtObsVentanas As TextBox
    Friend WithEvents txtObsLamparas As TextBox
    Friend WithEvents txtObsElectri As TextBox
    Friend WithEvents txtObsPintarron As TextBox
    Friend WithEvents txtObsElect As TextBox
    Friend WithEvents txtObsconex As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents LV As ListView
    Friend WithEvents IdRecurso As ColumnHeader
    Friend WithEvents HorasTrabajadas As ColumnHeader
    Friend WithEvents Observaciones As ColumnHeader
    Friend WithEvents Imagen As ColumnHeader
    Friend WithEvents txtImgRuta As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtIdRecurso As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmdSeleccionar As Button
    Friend WithEvents cmdAgregaD As Button
    Friend WithEvents cmdBack As Button
    Friend WithEvents chkDatosSecundarios As CheckBox
    Friend WithEvents NupHorasT As NumericUpDown
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtAula As ComboBox
    Friend WithEvents txtEdificio As ComboBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
