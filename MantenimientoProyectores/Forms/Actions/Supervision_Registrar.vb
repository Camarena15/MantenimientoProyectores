'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.IO
Public Class Supervision_Registrar
    Dim connection As New MySqlConnection(s)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim ftppath As String = "ftp://ftp-sistemamediosav.alwaysdata.net:21"
    Protected Sub GRABAR(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim transaction As MySqlTransaction
        transaction = connection.BeginTransaction()
        command.Connection = connection
        command.Transaction = transaction
        Dim r As String
        Try
            r = "INSERT INTO `SUPERVISION`( `Fecha`, `Responsable`, `Edificio`, `Aula`"
            If chkDatosSecundarios.Checked = True Then
                r += ", `ObservaCajaConex`, `ImagenCajaConex`, `ObservaConectorElect`, `ImagenConectorElect`, `ObservaPintarrón`, 
                `ImagenPintarrón`, `ObservaElectricidad`, `ImagenElect`, `ObservaLámparas`, `ImagenLamparas`, 
                `ObservaVentanas`, `ImagenVentanas`"
            End If
            r += ") VALUES ('" & DTP.Value.ToString("yyyy-MM-dd") & "','" & txtResponsable.Text & "','" & txtEdificio.Text & "','" &
                txtAula.Text & "'"
            If chkDatosSecundarios.Checked = True Then
                r += ",'" & txtObsconex.Text & "','" & txtImgConexiones.Text & "','" & txtObsElect.Text & "','" & txtImgElect.Text & "','" &
                    txtObsPintarron.Text & "','" & txtImgPintarron.Text & "','" & txtObsElectri.Text & "','" & txtImgElectri.Text & "','" &
                    txtObsLamparas.Text & "','" & txtImgLamparas.Text & "','" & txtObsVentanas.Text & "','" & txtImgVentanas.Text & "'"
            End If
            r += ")"
            command.CommandText = r
            command.ExecuteNonQuery()
            '********************************************************************************************************************
            'OBTENER EL ULTIMO REGISTRO DE LA COMPRA QUE SE ACABA DE INSERTAR
            Dim idc As Integer
            If txtId.Text = "" Then 'PRIMERA COMPRA DESPUES DEL TRASPASO, SIN PRESENCIA DE REGISTROS EN LA TABLA
                command.CommandText = "SELECT idSupervision FROM SUPERVISION ORDER BY idSupervision DESC LIMIT 1"
                lector = command.ExecuteReader
                lector.Read()
                idc = lector.GetInt32(0)
                lector.Close()
            Else
                idc = txtId.Text
            End If
            '********************************************************************************************************************
            For i = 0 To LV.Items.Count - 1
                If idsCat(i) = "1" Then
                    r = "INSERT INTO `DETALLE-SUP-RECURSO` (`IdSupervision`, `IdRecursoAsignado`, `ObservaRecurso`, 
                    `HorasTrabajadas`, `ImagenRecurso`) VALUES (" & idc & "," & LV.Items.Item(i).SubItems.Item(0).Text &
                ",'" & LV.Items.Item(i).SubItems.Item(2).Text & "','" & LV.Items.Item(i).SubItems.Item(1).Text &
                "','" & ftppath & "/ITCG/" & getNameFile(LV.Items(i).SubItems.Item(3).Text) & "')"
                    command.CommandText = r
                    command.ExecuteNonQuery()
                    r = "UPDATE `CAÑONES` SET `HorasLampara` = " & LV.Items(i).SubItems.Item(1).Text & " WHERE `IdRecurso`=" &
                         LV.Items(i).SubItems.Item(0).Text
                    command.CommandText = r
                    command.ExecuteNonQuery()
                Else
                    r = "INSERT INTO `DETALLE-SUP-RECURSO`(`IdSupervision`, `IdRecursoAsignado`, `ObservaRecurso`, 
                     `ImagenRecurso`) VALUES (" & idc & "," & LV.Items.Item(i).SubItems.Item(0).Text &
                ",'" & LV.Items.Item(i).SubItems.Item(2).Text & "','" & ftppath & "/ITCG/" & getNameFile(LV.Items(i).SubItems.Item(3).Text) & "')"
                    command.CommandText = r
                    command.ExecuteNonQuery()
                End If
            Next
            transaction.Commit()
            '*********************************************************************************************************************
        Catch ex As Exception
            MsgBox("Commit Exception Type: {0} no se pudo insertar por error" & ex.ToString)
            Try
                transaction.Rollback()
            Catch ex2 As Exception
                MsgBox("Error RollBack")
            End Try
        End Try
        Dim t As New Thread(AddressOf subirArchivos)
        t.IsBackground = True
        t.Start()
        SpeedFtp.Show()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        chkDatosSecundarios.Checked = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        Limpiartxt()
    End Sub

    Private Sub subirArchivos()
        Try
            Dim ftpuser As String = "sistemamediosav_01"
            Dim ftppass As String = "W*eH0EBY%7oH"
            'Dim ftppath As String = "\\26.176.23.206:21"
            'Dim ftpuser As String = "Cama"
            'Dim ftppass As String = "Cama1598"
            CheckForIllegalCrossThreadCalls = False
            Dim ftp As New Ftp(ftppath, ftpuser, ftppass)
            filecount = LV.Items.Count
            For i = 0 To LV.Items.Count - 1
                Dim file As New FileInfo(LV.Items(i).SubItems.Item(3).Text)
                BufferLength += file.Length
            Next
            If chkDatosSecundarios.Checked = True Then
                Dim f1 As New FileInfo(txtImgConexiones.Text)
                Dim f2 As New FileInfo(txtImgElect.Text)
                Dim f3 As New FileInfo(txtImgElectri.Text)
                Dim f4 As New FileInfo(txtImgLamparas.Text)
                Dim f5 As New FileInfo(txtImgPintarron.Text)
                BufferLength += (f1.Length + f2.Length + f3.Length + f4.Length + f5.Length)
            End If
            trigger = True
            For i = 0 To LV.Items.Count - 1
                ftp.subirFichero(LV.Items(i).SubItems.Item(3).Text, ftppath & "/ITCG/" & getNameFile(LV.Items(i).SubItems.Item(3).Text), ftppath & "/ITCG")
            Next
            If chkDatosSecundarios.Checked = True Then
                If validaImagenes() = True Then
                    ftp.subirFichero(txtImgConexiones.Text, ftppath & "/ITCG/" & getNameFile(txtImgConexiones.Text), ftppath & "/ITCG")
                    ftp.subirFichero(txtImgElect.Text, ftppath & "/ITCG/" & getNameFile(txtImgElect.Text), ftppath & "/ITCG")
                    ftp.subirFichero(txtImgElectri.Text, ftppath & "/ITCG/" & getNameFile(txtImgElectri.Text), ftppath & "/ITCG")
                    ftp.subirFichero(txtImgLamparas.Text, ftppath & "/ITCG/" & getNameFile(txtImgLamparas.Text), ftppath & "/ITCG")
                    ftp.subirFichero(txtImgPintarron.Text, ftppath & "/ITCG/" & getNameFile(txtImgPintarron.Text), ftppath & "/ITCG")
                Else
                    MsgBox("No se encontro una ruta en una de las imagenes secundarias!", MsgBoxStyle.Critical, "ERROR")
                End If
            End If
            LV.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            LV.Items.Clear()
        End Try
    End Sub
    Private Function validaImagenes() As Boolean
        If txtImgConexiones.Text.Equals("Haz clic para Seleccionar") Or txtImgElect.Text.Equals("Haz clic para Seleccionar") Or
         txtImgElectri.Text.Equals("Haz clic para Seleccionar") Or txtImgLamparas.Text.Equals("Haz clic para Seleccionar") Or
         txtImgPintarron.Text.Equals("Haz clic para Seleccionar") Then
            Return False
        End If
        Return True
    End Function
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        command.CommandText = "SELECT count(*) FROM SUPERVISION" 'SELECT TOP, SELECT BOTTOM 
        lector = command.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector.GetInt32(0)
        lector.Close()
        If aux > 0 Then
            command.CommandText = "SELECT IdSupervision FROM SUPERVISION ORDER BY IdSupervision DESC LIMIT 1 "
            lector = command.ExecuteReader
            lector.Read()
            n = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
            ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
            txtId.Text = n
            lector.Close()
        Else
            txtId.Text = ""
        End If
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdNuevo.Enabled = False
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        connection.Close()
        Me.Close()
    End Sub

    Private Sub Limpiartxt()
        txtId.Text = ""
        txtResponsable.Text = ""
        txtEdificio.SelectedIndex = 0
        txtAula.SelectedIndex = 0
        DTP.Value = Date.Today
        txtObsconex.Text = ""
        txtObsElect.Text = ""
        txtObsElectri.Text = ""
        txtObsPintarron.Text = ""
        txtObsVentanas.Text = ""
        txtObsLamparas.Text = ""
        txtImgConexiones.Text = "Haz clic para Seleccionar"
        txtImgElect.Text = "Haz clic para Seleccionar"
        txtImgElectri.Text = "Haz clic para Seleccionar"
        txtImgPintarron.Text = "Haz clic para Seleccionar"
        txtImgVentanas.Text = "Haz clic para Seleccionar"
        txtImgLamparas.Text = "Haz clic para Seleccionar"
    End Sub

    Private Sub Reportes_Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        txtEdificio.SelectedIndex = 0
        txtAula.SelectedIndex = 0
        DTP.Value = Date.Today
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        connection.Open()
        command = connection.CreateCommand
        Timer2.Stop()
    End Sub

    Private Sub chkDatosSecundarios_CheckedChanged(sender As Object, e As EventArgs) Handles chkDatosSecundarios.CheckedChanged
        If chkDatosSecundarios.Checked = True Then
            GroupBox3.Enabled = True
        Else
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub cmdSeleccionar_Click(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click
        If txtEdificio.SelectedIndex = 0 Or txtAula.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar el Edificio y el Aula!", MsgBoxStyle.Critical, "ERROR")
        Else
            RecursoAsignadoAula = txtAula.Text
            recursoasignadoEdificio = txtEdificio.Text
            command.CommandText = "SELECT count(*) FROM RECURSOSASIGNADOS WHERE Edificio='" & recursoasignadoEdificio & "' AND Aula='" &
                recursoasignadoAula & "'"
            lector = command.ExecuteReader
            lector.Read()
            Dim n As Integer = lector.GetValue(0)
            lector.Close()
            If n <> 0 Then
                RecursoAsignado_Seleccionar.ShowDialog()
                txtIdRecurso.Text = idRecurso_1
                If idcat_1.Equals("1") Then
                    command.CommandText = "SELECT HorasLampara FROM `CAÑONES` WHERE IdRecurso=" & idRecurso_1
                    lector = command.ExecuteReader
                    lector.Read()
                    NupHorasT.Value = lector.GetInt32(0)
                    NupHorasT.Minimum = NupHorasT.Value
                    NupHorasT.Enabled = True
                    lector.Close()
                End If
                GroupBox2.Enabled = True
                cmdGrabar.Enabled = True
            Else
                MsgBox("No Existen Recursos Asignados al Edificio y Aula seleccionadas!", MsgBoxStyle.Critical)
            End If

        End If
    End Sub

    Private Function OpenFile() As String
        OpenFileDialog1.InitialDirectory = "C:\\"
        'filtro de archivos.
        OpenFileDialog1.Filter = "Archivos de Imagen (*.jpg)|*.jpg"
        'codigo para abrir el cuadro de dialogo
        Dim Str_RutaArchivo As String
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Str_RutaArchivo = OpenFileDialog1.FileName
            If getNameFile(Str_RutaArchivo).Length <= 150 Then
                Return Str_RutaArchivo
            Else
                MsgBox("El nombre de la imagen es demasiado largo!", MsgBoxStyle.Critical, "ERROR")
                Return "Haz clic para Seleccionar"
            End If
        Else
            Return ""
        End If
    End Function
    Private Function getNameFile(ByVal Str_RutaArchivo As String) As String
        Dim name As String = ""
        For i = Str_RutaArchivo.Length - 1 To 0 Step -1
            If Str_RutaArchivo.Chars(i) = "\" Then
                name = Str_RutaArchivo.Substring(i + 1)
                i = 0
            End If
        Next
        Return name
    End Function
    Private Sub cmdAgregaD_Click(sender As Object, e As EventArgs) Handles cmdAgregaD.Click
        NupHorasT.Enabled = False
        Dim fila As New ListViewItem(txtIdRecurso.Text)
        fila.SubItems.Add(NupHorasT.Value.ToString)
        fila.SubItems.Add(txtObservaciones.Text)
        fila.SubItems.Add(txtImgRuta.Text)
        LV.Items.Add(fila)
        idsCat.Add(idcat_1)
        txtIdRecurso.Text = ""
        NupHorasT.Minimum = 0
        NupHorasT.Value = 0
        txtObservaciones.Text = ""
        txtImgRuta.Text = "Haz clic para Seleccionar"
        cmdBack.Enabled = True
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        If LV.Items.Count > 0 Then
            Dim ultimo As Integer = LV.Items.Count - 1
            LV.Items.RemoveAt(ultimo)
            idsCat.RemoveAt(ultimo)
            If ultimo = 0 Then
                cmdBack.Enabled = False
            End If
        End If

    End Sub
    Private Sub txtImgRuta_Click(sender As Object, e As EventArgs) Handles txtImgRuta.Click
        Dim name As String = OpenFile()
        txtImgRuta.Text = name
    End Sub
    Private Sub txtImgConexiones_Click(sender As Object, e As EventArgs) Handles txtImgConexiones.Click
        Dim name As String = OpenFile()
        txtImgConexiones.Text = name
    End Sub

    Private Sub txtImgElect_Click(sender As Object, e As EventArgs) Handles txtImgElect.Click
        Dim name As String = OpenFile()
        txtImgElect.Text = name
    End Sub

    Private Sub txtImgPintarron_Click(sender As Object, e As EventArgs) Handles txtImgPintarron.Click
        Dim name As String = OpenFile()
        txtImgPintarron.Text = name
    End Sub

    Private Sub txtImgElectri_Click(sender As Object, e As EventArgs) Handles txtImgElectri.Click
        Dim name As String = OpenFile()
        txtImgElectri.Text = name
    End Sub

    Private Sub txtImgLamparas_Click(sender As Object, e As EventArgs) Handles txtImgLamparas.Click
        Dim name As String = OpenFile()
        txtImgLamparas.Text = name
    End Sub

    Private Sub txtEdificio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtEdificio.SelectedIndexChanged
        If txtEdificio.SelectedIndex >= 27 Then
            txtAula.SelectedIndex = 9
            txtAula.Enabled = False
        Else
            txtAula.Enabled = True
            txtAula.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtAula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAula.SelectedIndexChanged
        If txtEdificio.SelectedIndex < 27 Then

            If txtAula.SelectedIndex = 9 Then
                MsgBox("Un Edificio con A-Z no puede llevar un '*' como Aula!", MsgBoxStyle.Information, "ATENCIÓN")
                txtAula.SelectedIndex = 0
            End If
        End If
    End Sub
End Class