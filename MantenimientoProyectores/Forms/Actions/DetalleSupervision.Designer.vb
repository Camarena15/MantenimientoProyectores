<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleSupervision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleSupervision))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pctVent = New System.Windows.Forms.PictureBox()
        Me.pctLamp = New System.Windows.Forms.PictureBox()
        Me.pctElect = New System.Windows.Forms.PictureBox()
        Me.pctPinta = New System.Windows.Forms.PictureBox()
        Me.pctConElect = New System.Windows.Forms.PictureBox()
        Me.pctCajaCon = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVent = New System.Windows.Forms.TextBox()
        Me.txtLamp = New System.Windows.Forms.TextBox()
        Me.txtElec = New System.Windows.Forms.TextBox()
        Me.txtPinta = New System.Windows.Forms.TextBox()
        Me.txtConElec = New System.Windows.Forms.TextBox()
        Me.txtCajaCon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctVent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctElect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctConElect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCajaCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 40)
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
        Me.btnCerrar.Location = New System.Drawing.Point(630, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 219
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Venus Rising", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(177, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 21)
        Me.Label1.TabIndex = 289
        Me.Label1.Text = "CONSULTA DE SUPERVISIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pctVent)
        Me.GroupBox1.Controls.Add(Me.pctLamp)
        Me.GroupBox1.Controls.Add(Me.pctElect)
        Me.GroupBox1.Controls.Add(Me.pctPinta)
        Me.GroupBox1.Controls.Add(Me.pctConElect)
        Me.GroupBox1.Controls.Add(Me.pctCajaCon)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtVent)
        Me.GroupBox1.Controls.Add(Me.txtLamp)
        Me.GroupBox1.Controls.Add(Me.txtElec)
        Me.GroupBox1.Controls.Add(Me.txtPinta)
        Me.GroupBox1.Controls.Add(Me.txtConElec)
        Me.GroupBox1.Controls.Add(Me.txtCajaCon)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(51, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 575)
        Me.GroupBox1.TabIndex = 290
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OBSERVACIONES SECUNDARIAS SUPERVISIÓN"
        '
        'pctVent
        '
        Me.pctVent.Location = New System.Drawing.Point(413, 480)
        Me.pctVent.Name = "pctVent"
        Me.pctVent.Size = New System.Drawing.Size(128, 72)
        Me.pctVent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctVent.TabIndex = 23
        Me.pctVent.TabStop = False
        '
        'pctLamp
        '
        Me.pctLamp.Location = New System.Drawing.Point(413, 394)
        Me.pctLamp.Name = "pctLamp"
        Me.pctLamp.Size = New System.Drawing.Size(128, 72)
        Me.pctLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLamp.TabIndex = 22
        Me.pctLamp.TabStop = False
        '
        'pctElect
        '
        Me.pctElect.Location = New System.Drawing.Point(413, 308)
        Me.pctElect.Name = "pctElect"
        Me.pctElect.Size = New System.Drawing.Size(128, 72)
        Me.pctElect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctElect.TabIndex = 21
        Me.pctElect.TabStop = False
        '
        'pctPinta
        '
        Me.pctPinta.Location = New System.Drawing.Point(413, 222)
        Me.pctPinta.Name = "pctPinta"
        Me.pctPinta.Size = New System.Drawing.Size(128, 72)
        Me.pctPinta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPinta.TabIndex = 20
        Me.pctPinta.TabStop = False
        '
        'pctConElect
        '
        Me.pctConElect.Location = New System.Drawing.Point(413, 136)
        Me.pctConElect.Name = "pctConElect"
        Me.pctConElect.Size = New System.Drawing.Size(128, 72)
        Me.pctConElect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctConElect.TabIndex = 19
        Me.pctConElect.TabStop = False
        '
        'pctCajaCon
        '
        Me.pctCajaCon.Location = New System.Drawing.Point(413, 49)
        Me.pctCajaCon.Name = "pctCajaCon"
        Me.pctCajaCon.Size = New System.Drawing.Size(128, 72)
        Me.pctCajaCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCajaCon.TabIndex = 18
        Me.pctCajaCon.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(351, 468)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 18)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Imagen"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(351, 382)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Imagen"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(351, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Imagen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(351, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Imagen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(351, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Imagen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(351, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Imagen"
        '
        'txtVent
        '
        Me.txtVent.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtVent.Location = New System.Drawing.Point(27, 489)
        Me.txtVent.Multiline = True
        Me.txtVent.Name = "txtVent"
        Me.txtVent.ReadOnly = True
        Me.txtVent.Size = New System.Drawing.Size(303, 63)
        Me.txtVent.TabIndex = 11
        '
        'txtLamp
        '
        Me.txtLamp.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtLamp.Location = New System.Drawing.Point(27, 403)
        Me.txtLamp.Multiline = True
        Me.txtLamp.Name = "txtLamp"
        Me.txtLamp.ReadOnly = True
        Me.txtLamp.Size = New System.Drawing.Size(303, 63)
        Me.txtLamp.TabIndex = 10
        '
        'txtElec
        '
        Me.txtElec.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtElec.Location = New System.Drawing.Point(27, 317)
        Me.txtElec.Multiline = True
        Me.txtElec.Name = "txtElec"
        Me.txtElec.ReadOnly = True
        Me.txtElec.Size = New System.Drawing.Size(303, 63)
        Me.txtElec.TabIndex = 9
        '
        'txtPinta
        '
        Me.txtPinta.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtPinta.Location = New System.Drawing.Point(27, 231)
        Me.txtPinta.Multiline = True
        Me.txtPinta.Name = "txtPinta"
        Me.txtPinta.ReadOnly = True
        Me.txtPinta.Size = New System.Drawing.Size(303, 63)
        Me.txtPinta.TabIndex = 8
        '
        'txtConElec
        '
        Me.txtConElec.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtConElec.Location = New System.Drawing.Point(27, 145)
        Me.txtConElec.Multiline = True
        Me.txtConElec.Name = "txtConElec"
        Me.txtConElec.ReadOnly = True
        Me.txtConElec.Size = New System.Drawing.Size(303, 63)
        Me.txtConElec.TabIndex = 7
        '
        'txtCajaCon
        '
        Me.txtCajaCon.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.txtCajaCon.Location = New System.Drawing.Point(27, 58)
        Me.txtCajaCon.Multiline = True
        Me.txtCajaCon.Name = "txtCajaCon"
        Me.txtCajaCon.ReadOnly = True
        Me.txtCajaCon.Size = New System.Drawing.Size(303, 63)
        Me.txtCajaCon.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 468)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Observaciones Ventanas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Observaciones Lámparas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Observaciones Electricidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Observaciones Pintarrón"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Observaciones Conector Eléctrico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Observaciones Caja de Conexión"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'DetalleSupervision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 700)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DetalleSupervision"
        Me.Text = "DetalleSupervision"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctVent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctElect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctConElect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCajaCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtVent As TextBox
    Friend WithEvents txtLamp As TextBox
    Friend WithEvents txtElec As TextBox
    Friend WithEvents txtPinta As TextBox
    Friend WithEvents txtConElec As TextBox
    Friend WithEvents txtCajaCon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pctVent As PictureBox
    Friend WithEvents pctLamp As PictureBox
    Friend WithEvents pctElect As PictureBox
    Friend WithEvents pctPinta As PictureBox
    Friend WithEvents pctConElect As PictureBox
    Friend WithEvents pctCajaCon As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Timer1 As Timer
End Class
