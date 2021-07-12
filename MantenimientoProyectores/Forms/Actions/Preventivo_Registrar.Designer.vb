<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preventivo_Registrar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBPreventivo = New System.Windows.Forms.GroupBox()
        Me.DTP2 = New System.Windows.Forms.TextBox()
        Me.RBNO = New System.Windows.Forms.RadioButton()
        Me.RBSI = New System.Windows.Forms.RadioButton()
        Me.lblCambioLampara = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
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
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GBRecurso = New System.Windows.Forms.GroupBox()
        Me.txtIdRecurso = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtinvcapece = New System.Windows.Forms.TextBox()
        Me.txtEstadoRecurso = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdBuscarRecurso = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GBPreventivo.SuspendLayout()
        Me.GBRecurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(315, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "REGISTRO DE SERVICIOS PREVENTIVOS"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(229, 75)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(76, 26)
        Me.txtId.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(57, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "ID Preventivo"
        '
        'GBPreventivo
        '
        Me.GBPreventivo.Controls.Add(Me.DTP2)
        Me.GBPreventivo.Controls.Add(Me.RBNO)
        Me.GBPreventivo.Controls.Add(Me.RBSI)
        Me.GBPreventivo.Controls.Add(Me.lblCambioLampara)
        Me.GBPreventivo.Controls.Add(Me.txtEstado)
        Me.GBPreventivo.Controls.Add(Me.cboTipo)
        Me.GBPreventivo.Controls.Add(Me.DTP)
        Me.GBPreventivo.Controls.Add(Me.txtConcepto)
        Me.GBPreventivo.Controls.Add(Me.txtAtiende)
        Me.GBPreventivo.Controls.Add(Me.txtObservaciones)
        Me.GBPreventivo.Controls.Add(Me.Label10)
        Me.GBPreventivo.Controls.Add(Me.Label9)
        Me.GBPreventivo.Controls.Add(Me.Label8)
        Me.GBPreventivo.Controls.Add(Me.Label7)
        Me.GBPreventivo.Controls.Add(Me.Label6)
        Me.GBPreventivo.Controls.Add(Me.Label5)
        Me.GBPreventivo.Controls.Add(Me.Label4)
        Me.GBPreventivo.Enabled = False
        Me.GBPreventivo.Location = New System.Drawing.Point(57, 227)
        Me.GBPreventivo.Name = "GBPreventivo"
        Me.GBPreventivo.Size = New System.Drawing.Size(763, 261)
        Me.GBPreventivo.TabIndex = 46
        Me.GBPreventivo.TabStop = False
        '
        'DTP2
        '
        Me.DTP2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP2.Location = New System.Drawing.Point(278, 137)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.ReadOnly = True
        Me.DTP2.Size = New System.Drawing.Size(116, 26)
        Me.DTP2.TabIndex = 239
        '
        'RBNO
        '
        Me.RBNO.AutoSize = True
        Me.RBNO.Location = New System.Drawing.Point(648, 186)
        Me.RBNO.Name = "RBNO"
        Me.RBNO.Size = New System.Drawing.Size(45, 23)
        Me.RBNO.TabIndex = 238
        Me.RBNO.TabStop = True
        Me.RBNO.Text = "No"
        Me.RBNO.UseVisualStyleBackColor = True
        Me.RBNO.Visible = False
        '
        'RBSI
        '
        Me.RBSI.AutoSize = True
        Me.RBSI.Location = New System.Drawing.Point(589, 188)
        Me.RBSI.Name = "RBSI"
        Me.RBSI.Size = New System.Drawing.Size(45, 23)
        Me.RBSI.TabIndex = 237
        Me.RBSI.TabStop = True
        Me.RBSI.Text = "Si"
        Me.RBSI.UseVisualStyleBackColor = True
        Me.RBSI.Visible = False
        '
        'lblCambioLampara
        '
        Me.lblCambioLampara.BackColor = System.Drawing.Color.White
        Me.lblCambioLampara.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambioLampara.ForeColor = System.Drawing.Color.Black
        Me.lblCambioLampara.Location = New System.Drawing.Point(419, 169)
        Me.lblCambioLampara.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCambioLampara.Name = "lblCambioLampara"
        Me.lblCambioLampara.Size = New System.Drawing.Size(165, 38)
        Me.lblCambioLampara.TabIndex = 236
        Me.lblCambioLampara.Text = "¿Registrar cambio de Lámpara?"
        Me.lblCambioLampara.Visible = False
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(487, 29)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 26)
        Me.txtEstado.TabIndex = 229
        Me.txtEstado.Text = "Pendiente"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"---", "INTERNO", "EXTERNO"})
        Me.cboTipo.Location = New System.Drawing.Point(165, 63)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 27)
        Me.cboTipo.TabIndex = 74
        '
        'DTP
        '
        Me.DTP.CustomFormat = "dd/MM/yyyy"
        Me.DTP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(278, 97)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(116, 26)
        Me.DTP.TabIndex = 72
        '
        'txtConcepto
        '
        Me.txtConcepto.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(93, 29)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(301, 26)
        Me.txtConcepto.TabIndex = 70
        '
        'txtAtiende
        '
        Me.txtAtiende.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtiende.Location = New System.Drawing.Point(10, 204)
        Me.txtAtiende.Name = "txtAtiende"
        Me.txtAtiende.Size = New System.Drawing.Size(290, 26)
        Me.txtAtiende.TabIndex = 69
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(413, 97)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(334, 69)
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
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Salir
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(916, 492)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(49, 54)
        Me.cmdSalir.TabIndex = 218
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
        Me.Label24.TabIndex = 217
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
        Me.Label23.TabIndex = 216
        Me.Label23.Text = "Nuevo"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.Color.White
        Me.cmdGrabar.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Grabar
        Me.cmdGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGrabar.Location = New System.Drawing.Point(916, 401)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(49, 54)
        Me.cmdGrabar.TabIndex = 215
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
        Me.cmdNuevo.TabIndex = 214
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
        Me.Label25.TabIndex = 213
        Me.Label25.Text = "Salir"
        '
        'GBRecurso
        '
        Me.GBRecurso.Controls.Add(Me.txtIdRecurso)
        Me.GBRecurso.Controls.Add(Me.txtMarca)
        Me.GBRecurso.Controls.Add(Me.Label2)
        Me.GBRecurso.Controls.Add(Me.txtModelo)
        Me.GBRecurso.Controls.Add(Me.Label11)
        Me.GBRecurso.Controls.Add(Me.cboCategoria)
        Me.GBRecurso.Controls.Add(Me.txtinvcapece)
        Me.GBRecurso.Controls.Add(Me.txtEstadoRecurso)
        Me.GBRecurso.Controls.Add(Me.Label17)
        Me.GBRecurso.Controls.Add(Me.Label18)
        Me.GBRecurso.Controls.Add(Me.Label19)
        Me.GBRecurso.Controls.Add(Me.cmdBuscarRecurso)
        Me.GBRecurso.Controls.Add(Me.Label20)
        Me.GBRecurso.Enabled = False
        Me.GBRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GBRecurso.ForeColor = System.Drawing.Color.Black
        Me.GBRecurso.Location = New System.Drawing.Point(57, 115)
        Me.GBRecurso.Name = "GBRecurso"
        Me.GBRecurso.Size = New System.Drawing.Size(763, 110)
        Me.GBRecurso.TabIndex = 226
        Me.GBRecurso.TabStop = False
        Me.GBRecurso.Text = "INFORMACIÓN DEL RECURSO:"
        '
        'txtIdRecurso
        '
        Me.txtIdRecurso.Location = New System.Drawing.Point(103, 29)
        Me.txtIdRecurso.Name = "txtIdRecurso"
        Me.txtIdRecurso.ReadOnly = True
        Me.txtIdRecurso.Size = New System.Drawing.Size(100, 26)
        Me.txtIdRecurso.TabIndex = 229
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(506, 61)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(101, 26)
        Me.txtMarca.TabIndex = 228
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(441, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Marca"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(505, 29)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(101, 26)
        Me.txtModelo.TabIndex = 226
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(440, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 225
        Me.Label11.Text = "Modelo"
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Items.AddRange(New Object() {"---", "CAÑONES", "COMPUTADORAS", "PANTALLAS"})
        Me.cboCategoria.Location = New System.Drawing.Point(102, 62)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(101, 27)
        Me.cboCategoria.TabIndex = 224
        '
        'txtinvcapece
        '
        Me.txtinvcapece.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvcapece.Location = New System.Drawing.Point(319, 29)
        Me.txtinvcapece.Name = "txtinvcapece"
        Me.txtinvcapece.ReadOnly = True
        Me.txtinvcapece.Size = New System.Drawing.Size(101, 26)
        Me.txtinvcapece.TabIndex = 223
        '
        'txtEstadoRecurso
        '
        Me.txtEstadoRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoRecurso.Location = New System.Drawing.Point(319, 65)
        Me.txtEstadoRecurso.Name = "txtEstadoRecurso"
        Me.txtEstadoRecurso.ReadOnly = True
        Me.txtEstadoRecurso.Size = New System.Drawing.Size(101, 26)
        Me.txtEstadoRecurso.TabIndex = 222
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(223, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 19)
        Me.Label17.TabIndex = 220
        Me.Label17.Text = "INVCAPECE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 19)
        Me.Label18.TabIndex = 219
        Me.Label18.Text = "Categoría"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(223, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 19)
        Me.Label19.TabIndex = 218
        Me.Label19.Text = "Estado"
        '
        'cmdBuscarRecurso
        '
        Me.cmdBuscarRecurso.BackColor = System.Drawing.Color.Navy
        Me.cmdBuscarRecurso.FlatAppearance.BorderSize = 0
        Me.cmdBuscarRecurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.cmdBuscarRecurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue
        Me.cmdBuscarRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscarRecurso.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarRecurso.ForeColor = System.Drawing.Color.White
        Me.cmdBuscarRecurso.Location = New System.Drawing.Point(642, 33)
        Me.cmdBuscarRecurso.Name = "cmdBuscarRecurso"
        Me.cmdBuscarRecurso.Size = New System.Drawing.Size(105, 47)
        Me.cmdBuscarRecurso.TabIndex = 217
        Me.cmdBuscarRecurso.Text = "Buscar Recurso"
        Me.cmdBuscarRecurso.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(6, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 19)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "ID Recurso"
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
        Me.btnAyuda.Location = New System.Drawing.Point(24, 15)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(48, 45)
        Me.btnAyuda.TabIndex = 227
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'Preventivo_Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MantenimientoProyectores.My.Resources.Resources.Bckgnd2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 680)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.GBRecurso)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GBPreventivo)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Preventivo_Registrar"
        Me.Text = "Preventivo_Registrar"
        Me.GBPreventivo.ResumeLayout(False)
        Me.GBPreventivo.PerformLayout()
        Me.GBRecurso.ResumeLayout(False)
        Me.GBRecurso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GBPreventivo As GroupBox
    Friend WithEvents DTP As DateTimePicker
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
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents RBNO As RadioButton
    Friend WithEvents RBSI As RadioButton
    Friend WithEvents lblCambioLampara As Label
    Friend WithEvents DTP2 As TextBox
    Friend WithEvents GBRecurso As GroupBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents txtinvcapece As TextBox
    Friend WithEvents txtEstadoRecurso As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmdBuscarRecurso As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtIdRecurso As TextBox
    Friend WithEvents btnAyuda As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
