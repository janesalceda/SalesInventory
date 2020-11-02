Public Class FrmConfirmation

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPass.Text = "yg0oDiLp0h" Then
                FrmStockOutEntry.confirm = True
                txtPass.Clear()
                Me.Close()
            End If
        End If
    End Sub
End Class