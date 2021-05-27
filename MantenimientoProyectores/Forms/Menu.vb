Imports System.Runtime.InteropServices
Public Class Menu
    ' CODIFICACION PARA LA INTERFAZ DEL SISTEMA
    Dim triggerPaneles As Boolean = False
    Dim formTargetName As String
    Dim formTarget As Windows.Forms.Form
    ' Se utilizan librerias de Windows para el funcionamiento de la interfaz, se recomienda NO TOCAR
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        cambiarBarraLateral()
    End Sub

    Private Sub cambiarBarraLateral()
        If PanelMenu.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub

    Public Sub AbrirFomEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            triggerPaneles = True
            Me.PanelContenedor.Controls.RemoveAt(0)
            triggerPaneles = False
        End If
        Dim fh As Windows.Forms.Form = TryCast(Formhijo, Windows.Forms.Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
        PanelCatalogos.Visible = False
        PanelMovimientos.Visible = False
        PanelMenuReportes.Visible = False
        PanelUtilerias.Visible = False
    End Sub
    Private Sub PanelContenedor_ControlRemoved(sender As Object, e As ControlEventArgs) Handles PanelContenedor.ControlRemoved
        If triggerPaneles = False Then
            AbrirFomEnPanel(New Inicio)
        End If
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        AbrirFomEnPanel(New Inicio)
    End Sub

    'SUBPANELES
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        AbrirFomEnPanel(New Inicio)
    End Sub
    Private Sub btnCatalogos_Click(sender As Object, e As EventArgs) Handles btnCatalogos.Click
        PanelCatalogos.Visible = Not PanelCatalogos.Visible
    End Sub
    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        PanelMovimientos.Visible = Not PanelMovimientos.Visible
    End Sub
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        PanelMenuReportes.Visible = Not PanelMenuReportes.Visible
    End Sub
    Private Sub btnUtilerias_Click(sender As Object, e As EventArgs) Handles btnUtilerias.Click
        PanelUtilerias.Visible = Not PanelUtilerias.Visible

    End Sub
    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click

    End Sub
    Private Sub panelmenu_mousemove(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseMove
        PanelCatalogos.Visible = False
        PanelMovimientos.Visible = False
        PanelMenuReportes.Visible = False
        PanelUtilerias.Visible = False
        PanelSeleccion.Visible = False
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        formTarget = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ProductName & "." & formTargetName & "Registrar")
        pctCargando.Visible = True
        AbrirFomEnPanel(formTarget)
        cambiarBarraLateral()
        pctCargando.Visible = False
        PanelSeleccion.Visible = False
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        formTarget = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ProductName & "." & formTargetName & "Consultar")
        pctCargando.Visible = True
        AbrirFomEnPanel(formTarget)
        cambiarBarraLateral()
        pctCargando.Visible = False
        PanelSeleccion.Visible = False
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        formTarget = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ProductName & "." & formTargetName & "Terminar")
        pctCargando.Visible = True
        AbrirFomEnPanel(formTarget)
        cambiarBarraLateral()
        pctCargando.Visible = False
        PanelSeleccion.Visible = False
    End Sub

    'CATALOGOS
    Private Sub btnRecursos_MouseMove(sender As Object, e As MouseEventArgs) Handles btnRecursos.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 265)
        btnRegistrar.Enabled = False
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Recursos_"
        LineaRegistrar.Visible = True
        LineaTerminar.Visible = True
    End Sub

    Private Sub btnCategorias_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCategorias.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 320)
        btnRegistrar.Enabled = False
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Categorias_"
        LineaRegistrar.Visible = True
        LineaTerminar.Visible = True
    End Sub

    Private Sub btnPantallas_MouseMove(sender As Object, e As MouseEventArgs) Handles btnPantallas.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 375)
        btnRegistrar.Enabled = False
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Pantallas_"
        LineaRegistrar.Visible = True
        LineaTerminar.Visible = True
    End Sub

    Private Sub btnComputadoras_MouseMove(sender As Object, e As MouseEventArgs) Handles btnComputadoras.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 430)
        btnRegistrar.Enabled = False
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Computadoras_"
        LineaRegistrar.Visible = True
        LineaTerminar.Visible = True
    End Sub

    Private Sub btnCanones_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCanones.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 485)
        btnRegistrar.Enabled = False
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Canones_"
        LineaRegistrar.Visible = True
        LineaTerminar.Visible = True
    End Sub

    Private Sub btnLugar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnLugar.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 540)
        btnRegistrar.Enabled = False
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Lugar_"
        LineaRegistrar.Visible = True
        LineaTerminar.Visible = True
    End Sub

    'MOVIMIENTOS
    Private Sub btnSupervision_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSupervision.MouseMove
        formSelected = "Supervision"
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 320)
        btnRegistrar.Enabled = True
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Supervision_"
        LineaRegistrar.Visible = False
        LineaTerminar.Visible = True
    End Sub

    Private Sub btnActReportes_MouseMove(sender As Object, e As MouseEventArgs) Handles btnActReportes.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 375)
        btnRegistrar.Enabled = True
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "Reportes_"
        LineaRegistrar.Visible = False
        LineaTerminar.Visible = True
    End Sub

    Private Sub btnAtencionRep_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAtencionRep.MouseMove
        formSelected = "AtencionReportes"
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 430)
        btnRegistrar.Enabled = True
        btnConsultar.Enabled = True
        btnTerminar.Enabled = True
        PanelSeleccion.Visible = True
        formTargetName = "AtencionReportes_"
        LineaRegistrar.Visible = False
        LineaTerminar.Visible = False
    End Sub

    Private Sub btnPreventivo_MouseMove(sender As Object, e As MouseEventArgs) Handles btnPreventivo.MouseMove
        formSelected = "Preventivo"
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 485)
        btnRegistrar.Enabled = True
        btnConsultar.Enabled = True
        btnTerminar.Enabled = True
        PanelSeleccion.Visible = True
        formTargetName = "Preventivo_"
        LineaRegistrar.Visible = False
        LineaTerminar.Visible = False
    End Sub
    Private Sub btnReportesIndividuales_MouseMove(sender As Object, e As MouseEventArgs) Handles btnReportesIndividuales.MouseMove
        PanelSeleccion.Location = New Point(PanelSeleccion.Location.X, 540)
        formSelected = "RepRecInd"
        btnRegistrar.Enabled = True
        btnConsultar.Enabled = True
        btnTerminar.Enabled = False
        PanelSeleccion.Visible = True
        formTargetName = "ReportesInd_"
        LineaRegistrar.Visible = False
        LineaTerminar.Visible = True
    End Sub

    'REPORTES
    Private Sub btnRepSup_Click(sender As Object, e As EventArgs) Handles btnRepSup.Click
        opcion = 1
        Fechas_Reporte.Show()
    End Sub

    Private Sub btnRelRep_Click(sender As Object, e As EventArgs) Handles btnRelRep.Click
        opcion = 2
        Fechas_Estado_Reporte.Show()
    End Sub

    Private Sub btnRelAteRep_Click(sender As Object, e As EventArgs) Handles btnRelAteRep.Click
        opcion = 3
        Fechas_Reporte.Show()
    End Sub

    Private Sub btnRelPrev_Click(sender As Object, e As EventArgs) Handles btnRelPrev.Click
        opcion = 4
        Fechas_Estado_Reporte2.Show()
    End Sub

    'UTILERIAS
    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        Respaldo_Restauracion.Show()
    End Sub

    Private Sub btnInformeErrores_Click(sender As Object, e As EventArgs) Handles btnInformeErrores.Click
        bitacora_form.Show()
    End Sub

    Private Sub btnHistoricos_Click(sender As Object, e As EventArgs) Handles btnHistoricos.Click

    End Sub

    Private Sub btnSupervision_Click(sender As Object, e As EventArgs) Handles btnSupervision.Click
        opcion = 1
        Fechas_Reporte.Show()
    End Sub

    Private Sub btnActReportes_Click(sender As Object, e As EventArgs) Handles btnActReportes.Click
        opcion = 2
        Fechas_Estado_Reporte.Show()
    End Sub

    Private Sub btnReportesIndividuales_Click(sender As Object, e As EventArgs) Handles btnReportesIndividuales.Click
        opcion = 3
        Fechas_Reporte.Show()
    End Sub

    Private Sub pctCargando_Click(sender As Object, e As EventArgs) Handles pctCargando.Click

    End Sub

    Public Sub btnPreventivo_Click(sender As Object, e As EventArgs) Handles btnPreventivo.Click
        opcion = 4
        Fechas_Estado_Reporte2.Show()
    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        AcercaDe.ShowDialog()
    End Sub
End Class
