
Imports ZXing
Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Please complete fields", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
        Else
            SQL.AddParams("@username", txtUsername.Text)
            SQL.AddParams("@pass", txtPass.Text)
            SQL.ExecQuery("SELECT UserID,EmployeeName FROM users u inner join employees e on 
                u.userid=e.empid where username=@username and Password=@pass")

            If SQL.HasException(True) Then Exit Sub
            If SQL.RecordCount = 0 Then
                MsgBox("Invalid Username or password", MsgBoxStyle.Critical, "Error")
                txtUsername.Focus()
                txtPass.Clear()
                Exit Sub
            Else
                'FrmMessageBox.Show()
                moduleId = SQL.DBDT.Rows(0).Item(0)
                moduleName = SQL.DBDT.Rows(0).Item(1)
                txtPass.Clear()
                txtUsername.Clear()
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
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtEmpCode_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        'Dim writer As New BarcodeWriter
        'writer.Format = BarcodeFormat.CODE_128
        'pic.Image = writer.Write(txtEmpCode.Text)
        'Label3.Text = txtEmpCode.Text
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label3.Font = New Font("EAN-13", 50, FontStyle.Regular)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class
