Public Class SpeedFtp
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If trigger = True Then
            If PB.Maximum = 0 Then
                PB.Maximum = CInt(BufferLength) / 1024
                lblKBMAX.Text = PB.Maximum
            End If
            PB.Value = CInt(offset) / 1024
            lblKBMIN.Text = PB.Value + (filecount * 2)
            If (PB.Value + (filecount * 2)) = PB.Maximum Then
                Close()
            End If
        End If
    End Sub

    Private Sub SpeedFtp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim workingArea As Rectangle = Screen.GetWorkingArea(MyBase.Size)
        Location = New Point(workingArea.Width - 377,
            workingArea.Height - 199)
        MyBase.WindowState = FormWindowState.Normal
        PB.Value = 0
        Timer1.Start()
    End Sub
End Class