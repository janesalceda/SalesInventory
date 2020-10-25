Public Class AddUser

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtVPassword.Text Then ExecuteQueries(btnSave.Text)
    End Sub
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@username", txtUserName.Text)
        SQL.ExecQuery("SELECT * FROM Users where Username=@username")
        If SQL.RecordCount > 0 Then
            MsgBox("Username has been used!")
            Exit Sub
        End If

        SQL.AddParams("@username", txtUserName.Text)
        SQL.AddParams("@usertype", cmbUserLevel.SelectedValue)
        SQL.AddParams("@pass", txtPassword.Text)
        SQL.AddParams("@updatedby", moduleId)

        If Query = "SAVE" Then
            SQL.ExecQuery("
                INSERT INTO Users 
                VALUES
                (@username,@pass,@usertype,GETDATE(),GETDATE(),NULL,@updatedby)")

            SQL.AddParams("@empname", txtName.Text)
            If radMale.Checked = True Then
                SQL.AddParams("@gender", "M")
            Else radFemale.Checked = True
                SQL.AddParams("@gender", "F")
            End If
            SQL.AddParams("@age", txtAge.Text)
            SQL.AddParams("@position", cmbUserLevel.Text)
            SQL.AddParams("@updatedby", moduleId)

            SQL.ExecQuery("
                INSERT INTO employees 
                (EmployeeName,Position,Gender,Age,CreatedDate,UpdatedDate,DeletedDate,UpdatedBy)
                VALUES
                (@empname,@position,@gender,@age,GETDATE(),GETDATE(),NULL,@updatedby)")

        Else
            SQL.ExecQuery("UPDATE Users SET UserLevelId=@usertype,UpdatedDate=GETDATE(),UpdatedBy=@updatedby WHERE EmployeeNo=@empcode")
            'Username=@username,Password=@pass,
        End If
        If SQL.HasException(True) Then Exit Sub
        MsgBox("Successfully saved", MsgBoxStyle.Information, "Information")
        FrmUser.LoadDataGrid()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub txtVPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtVPassword.KeyUp
        If txtPassword.Text <> txtVPassword.Text Then
            lblnmatch.Visible = True
        End If
    End Sub
    Private Sub LoadUserLevel()
        cmbUserLevel.DataSource = GetUserLevel()
        cmbUserLevel.DisplayMember = "UserLevel"
        cmbUserLevel.ValueMember = "UserLevelId"
        cmbUserLevel.SelectedIndex = -1
    End Sub
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserLevel()
    End Sub
End Class