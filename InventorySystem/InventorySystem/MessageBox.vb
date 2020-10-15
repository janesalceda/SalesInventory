Public Class FrmMessageBox

    Dim seconds As Integer = 0
    Private Sub MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        MsgTimer.Start()
    End Sub

    Private Sub MsgTimer_Tick(sender As Object, e As EventArgs) Handles MsgTimer.Tick
        If seconds = 2 Then
            Me.Close()
        Else
            seconds += 1
        End If
    End Sub
End Class