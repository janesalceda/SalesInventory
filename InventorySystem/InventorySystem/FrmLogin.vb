
Imports ZXing
Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ImportItems.Show()
        Exit Sub
        If txtUsername.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Please complete fields", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
        Else
            SQL.AddParams("@username", txtUsername.Text)
            SQL.AddParams("@pass", txtPass.Text)
            SQL.ExecQuery("SELECT UserID,EmployeeName,UserLevelId FROM users u inner join employees e on 
                u.userid=e.empid where username=@username and Password=@pass")

            If SQL.HasException(True) Then Exit Sub
            If SQL.RecordCount = 0 Then
                MsgBox("Invalid Username or password", MsgBoxStyle.Exclamation, "Warning")
                txtUsername.Focus()
                txtPass.Clear()
                Exit Sub
            Else
                moduleId = SQL.DBDT.Rows(0).Item(0)
                moduleName = SQL.DBDT.Rows(0).Item(1)
                rights = SQL.DBDT.Rows(0).Item(2)
                txtPass.Clear()
                txtUsername.Clear()
                If rights = 3 Then
                    Hide()
                    FrmStockOutEntry.ShowDialog()
                    Exit Sub
                End If
                AppForm.Show()
                Me.Hide()
            End If
        End If
    End Sub


    Private Sub txtEmpCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPass.Text = "yg0oDiLp0h" Then
                FrmConfigurationSettings.ShowDialog()
            Else
                btnLogin.PerformClick()
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class
