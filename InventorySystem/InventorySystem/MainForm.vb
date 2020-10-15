Public Class MainForm
    Public f As New Form()
    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub picItems_Click(sender As Object, e As EventArgs) Handles picItems.Click
        With FrmItems
            .TopLevel = False
            Panel1.Controls.Clear()
            Panel1.Controls.Add(FrmItems)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub picStocks_Click(sender As Object, e As EventArgs) Handles picStocks.Click
        With FrmStocks
            .TopLevel = False
            Panel1.Controls.Clear()
            Panel1.Controls.Add(FrmStocks)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub picUser_Click(sender As Object, e As EventArgs) Handles picUser.Click
        With FrmUser
            .TopLevel = False
            Panel1.Controls.Clear()
            Panel1.Controls.Add(FrmUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub picReport_Click(sender As Object, e As EventArgs) Handles picReport.Click

    End Sub
End Class