'Author: @Theki
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class RecursoIndividual_Seleccionar
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
        Me.Close()
    End Sub

    Private Sub RecursoIndividual_Seleccionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.Rows.Clear()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        conexion.Open()
        comando = conexion.CreateCommand
        If formSelected.Equals("RepRecInd") Then
            obtieneRecursosIndividuales(recursoCat, "Disponible")
        ElseIf formSelected.Equals("Preventivo") Then
            obtieneRecursosIndividuales(recursoCat, "Disponible")
            obtieneRecursosIndividuales(recursoCat, "Asignado")
        End If
        If DGV.Rows.Count - 2 < 0 Then
            MsgBox("No hay registros Asociados a la busqueda", MsgBoxStyle.Critical, "ERROR")
            conexion.Close()
            Close()
        End If
        Timer1.Stop()
    End Sub
    Private Sub obtieneRecursosIndividuales(ByVal cat As String, ByVal edo As String)
        comando.CommandText = "SELECT R.IdRecurso, R.INVCAPECE, C.idCategoria, C.Concepto, R.Estado, R.Modelo, R.Marca FROM " & cat &
                    " AS R INNER JOIN RECURSOS AS RE ON RE.idRecursos = R.IdRecurso INNER JOIN CATEGORIA AS C ON 
                    RE.idCategoria = C.idCategoria WHERE R.Estado='" & edo & "'"
        lector = comando.ExecuteReader
        While lector.Read
            DGV.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5), lector.GetValue(6))
        End While
        lector.Close()
    End Sub
    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.CellClick
        idRecurso_1 = DGV(0, DGV.CurrentCell.RowIndex).Value
        estado_1 = DGV(4, DGV.CurrentCell.RowIndex).Value
        idcat_1 = DGV(2, DGV.CurrentCell.RowIndex).Value
        invcapece_1 = DGV(1, DGV.CurrentCell.RowIndex).Value
        modelo_1 = DGV(5, DGV.CurrentCell.RowIndex).Value
        marca_1 = DGV(6, DGV.CurrentCell.RowIndex).Value
        obtainedInfoRec = True
        conexion.Close()
        Me.Close()
    End Sub
End Class