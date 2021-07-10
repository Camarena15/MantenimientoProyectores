Imports System.ComponentModel
Imports System.Runtime.InteropServices
Public Class Ayuda
    Dim a, b As Integer


    Private Sub cmdSiguiente2_Click(sender As Object, e As EventArgs) Handles cmdSiguiente2.Click
        If a = 2 Then
            ' SENTENCIA IF PARA EL FUNCIONAMIENTO DE PREVENTIVO
            ' MsgBox("hola2")
            imagen.Image = My.Resources.preventivo3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 3
            b = 1
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        'TERMINA
        'SENTENCIA IF PARA EL FUNCIONAMIENTO DE TERMINACIÓN PREVENTIVO
        If a = 5 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.TerminoPreventivo2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 5
            b = 4
            '  cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        'SENTENCIA IF PARA EL FUNCIONAMIENTO DE TERMINACIÓN PREVENTIVO

        'TERMINA
        'INICIA SUPERVISION 
        If a = 8 Then
            imagen.Image = My.Resources.supervision3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 9
            b = 7
            '  cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If a = 10 Then
            imagen.Image = My.Resources.supervision5
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            ' a = 9
            b = 9
            '  cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If a = 16 Then
            imagen.Image = My.Resources.individual3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            ' a = 9
            b = 15
            '  cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        'atencion 
        If a = 21 Then
            imagen.Image = My.Resources.Atencion3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 22
            b = 20
            '  cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If a = 23 Then
            imagen.Image = My.Resources.Atencion5
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 24
            b = 22
            '  cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If a = 31 Then
            imagen.Image = My.Resources.TerminacionAtencion3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            'a = 24
            b = 30
            '  cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        ' SENTENCIA IF PARA EL FUNCIONAMIENTO DE PREVENTIVO
        If a = 1 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.Preventivo2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 0
            a = 2
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If a = 3 Then
            MsgBox("hola3")
            imagen.Image = My.Resources.preventivo4
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        'TERMINA
        'SENTENCIA IF PARA EL FUNCIONAMIENTO DE TERMINACIÓN PREVENTIVO
        If a = 4 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.TerminoPreventivo3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 3
            a = 5
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        'INICIO SUPERVISION
        If a = 7 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.supervision2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 6
            a = 8
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If a = 9 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.supervision4
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 8
            a = 10
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If a = 15 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.individual2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 14
            a = 16
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        'Atencion a fallas
        If a = 20 Then
            imagen.Image = My.Resources.Atencion2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 19
            a = 21
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If a = 22 Then
            imagen.Image = My.Resources.Atencion4
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 21
            a = 23
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If a = 24 Then
            imagen.Image = My.Resources.Atencion6
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 23
            'a = 23
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If a = 30 Then
            imagen.Image = My.Resources.TerminacionAtencion2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 29
            a = 31
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        If b = 0 Then
            imagen.Image = My.Resources.Preventivo1
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 1
        End If
        If b = 1 Then
            '  MsgBox("hola")
            imagen.Image = My.Resources.Preventivo2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 0
            a = 2
            cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 3 Then
            imagen.Image = My.Resources.TerminoPreventivo1
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 4
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 4 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.TerminoPreventivo3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 4
            b = 3

            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        'INICIO SUPERVISION
        If b = 6 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.supervision1
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 7
            '  b = 3

            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 7 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.supervision2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 6
            a = 8
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If b = 8 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.supervision3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 7
            a = 9
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If b = 9 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.supervision4
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            b = 8
            a = 10
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = True
            cmdSiguiente.Visible = False
        End If
        If b = 14 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.Individual1
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 15
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 15 Then
            'MsgBox("hola")
            imagen.Image = My.Resources.individual2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 15
            b = 14
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 19 Then
            imagen.Image = My.Resources.Atencion1
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 20
            ' b = 20
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 20 Then
            imagen.Image = My.Resources.Atencion2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 20
            b = 19
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 21 Then
            imagen.Image = My.Resources.Atencion3
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 22
            b = 20
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 22 Then
            imagen.Image = My.Resources.Atencion4
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 23
            b = 21
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 23 Then
            imagen.Image = My.Resources.Atencion5
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 24
            b = 22
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 29 Then
            imagen.Image = My.Resources.TerminacionAtencion1
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 30
            '  b = 22
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
        If b = 30 Then
            imagen.Image = My.Resources.TerminacionAtencion2
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            a = 31
            b = 29
            '   cmdAnterior.Enabled = True
            cmdSiguiente2.Visible = False
            cmdSiguiente.Visible = True
        End If
    End Sub
    Private Sub Ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case opcion
            Case "Reporte"
                imagen.Image = My.Resources.reportes1
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
            Case "Menu"
                imagen.Image = My.Resources.menu
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
            Case "PreventivoRegistrar"
                imagen.Image = My.Resources.Preventivo1
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
                cmdAnterior.Visible = True
                cmdSiguiente.Visible = True
                '  cmdSiguiente.Enabled = True
                ' cmdAnterior.Enabled = True
                a = 1

            Case "ReporteDocente"
                imagen.Image = My.Resources.ReporteDocente
                imagen.SizeMode = PictureBoxSizeMode.StretchImage

            Case "PreventivoTerminar"
                imagen.Image = My.Resources.TerminoPreventivo1
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
                cmdAnterior.Visible = True
                cmdSiguiente.Visible = True
                a = 4
                '  cmdSiguiente.Enabled = True
                ' cmdAnterior.Enabled = True
            Case "Supervision"
                imagen.Image = My.Resources.supervision1
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
                cmdAnterior.Visible = True
                cmdSiguiente.Visible = True
                a = 7
            Case "Individual"
                imagen.Image = My.Resources.Individual1
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
                cmdAnterior.Visible = True
                cmdSiguiente.Visible = True
                a = 15
            Case "Atencion"
                imagen.Image = My.Resources.Atencion1
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
                cmdAnterior.Visible = True
                cmdSiguiente.Visible = True
                a = 20
            Case "Termina"
                imagen.Image = My.Resources.TerminacionAtencion1
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
                cmdAnterior.Visible = True
                cmdSiguiente.Visible = True
                a = 30
            Case "AtencionRConsulta"
                imagen.Image = My.Resources.Diapositiva3
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
            Case "AtencionPreventivoCon"
                imagen.Image = My.Resources.Diapositiva4
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
            Case "ReportesDocenteCon"
                imagen.Image = My.Resources.docente
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
            Case "ReportesIndividualCon"
                imagen.Image = My.Resources.Diapositiva5
                imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End Select
    End Sub
End Class