'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class RecursoAsignado_Seleccionar
    Dim conexion As New MySqlConnection(s)
    Dim comando As New MySqlCommand
    Dim lector As MySqlDataReader
    Dim MP As New MPTools
    ' Se utilizan librerias de Windows para el funcionamiento de la interfaz, se recomienda NO TOCAR
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        conexion.Close()
        Me.Close()
    End Sub

    Private Sub RecursoAsignado_Seleccionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.Rows.Clear()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        conexion.Open()
        comando = conexion.CreateCommand
        txtAula.Text = recursoasignadoAula
        txtEdificio.Text = recursoasignadoEdificio
        If formSelected.Equals("AtencionReportes") Then
            lblCat.Visible = True
            txtCategoria.Visible = True
            txtCategoria.Text = recursoCat
            obtieneRecursosAsignados(recursoCat)
            If DGV.Rows.Count - 2 < 0 Then
                MsgBox("¡No hay registros Asociados a la búsqueda!", MsgBoxStyle.Critical, "ERROR")
                conexion.Close()
                Me.Close()
            End If
        ElseIf formSelected.Equals("Supervision") Then
            obtieneRecursosAsignados("CAÑONES")
            obtieneRecursosAsignados("COMPUTADORAS")
            obtieneRecursosAsignados("PANTALLAS")
            If DGV.Rows.Count - 2 < 0 Then
                MsgBox("¡No hay registros Asociados a la búsqueda!", MsgBoxStyle.Critical, "ERROR")
                conexion.Close()
                Me.Close()
            End If
        End If
        Timer1.Stop()
    End Sub
    Private Sub obtieneRecursosAsignados(ByVal cat As String)
        If cat.Equals("CAÑONES") Or cat.Equals("COMPUTADORAS") Or cat.Equals("PANTALLAS") Then
            comando.CommandText = "SELECT R.IdRecurso, R.INVCAPECE, C.idCategoria, C.Concepto, R.Estado, R.Modelo, R.Marca FROM RECURSOSASIGNADOS AS RA INNER JOIN " & cat &
                    " AS R ON RA.IdRecurso = R.IdRecurso INNER JOIN RECURSOS AS RE ON RE.idRecursos = R.IdRecurso INNER JOIN CATEGORIA AS C ON 
                    RE.idCategoria = C.idCategoria WHERE RA.Estado='Vigente' AND R.Estado='Asignado' AND RA.Edificio='" &
                    txtEdificio.Text & "' AND RA.Aula='" & txtAula.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                DGV.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5), lector.GetValue(6))
            End While
            lector.Close()
        ElseIf cat.Equals("CONTACTOS") Or cat.Equals("LAMPARAS") Then
            comando.CommandText = "SELECT R.idRecursos, R.descripcion, R.idCategoria, C.Concepto FROM RECURSOS AS R INNER JOIN CATEGORIA AS C ON R.idCategoria = C.idCategoria WHERE C.Concepto='" & cat & "'"
            lector = comando.ExecuteReader
            While lector.Read()
                DGV.Rows.Add(lector.GetValue(0), "---", lector.GetValue(2), lector.GetValue(3), "---", lector.GetValue(1), "---")
            End While
            lector.Close()
        End If

    End Sub
    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click
        If formSelected.Equals("AtencionReportes") Then
            idRecurso_1 = DGV(0, DGV.CurrentCell.RowIndex).Value
            estado_1 = DGV(4, DGV.CurrentCell.RowIndex).Value
            idcat_1 = DGV(2, DGV.CurrentCell.RowIndex).Value
            invcapece_1 = DGV(1, DGV.CurrentCell.RowIndex).Value
            modelo_1 = DGV(5, DGV.CurrentCell.RowIndex).Value
            marca_1 = DGV(6, DGV.CurrentCell.RowIndex).Value
        ElseIf formSelected.Equals("Supervision") Then
            idRecurso_1 = DGV(0, DGV.CurrentCell.RowIndex).Value
            idcat_1 = DGV(2, DGV.CurrentCell.RowIndex).Value
        End If
        obtainedInfoRec = True
        conexion.Close()
        Me.Close()
    End Sub
    Private Sub cmbSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        If DGV.CurrentCell.RowIndex <> DGV.Rows.Count - 2 Then
            Dim index As Integer = DGV.CurrentCell.RowIndex
            DGV.ClearSelection()
            DGV.CurrentCell = DGV(0, index + 1)
        End If
    End Sub

    Private Sub cmbAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        If DGV.CurrentCell.RowIndex <> 0 Then
            Dim index As Integer = DGV.CurrentCell.RowIndex
            DGV.ClearSelection()
            DGV.CurrentCell = DGV(0, index - 1)
        End If
    End Sub
End Class