Public Class AddUser

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ExecuteQueries("Insert")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ExecuteQueries("Update")
    End Sub
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@username", txtUserName.Text)
        SQL.ExecQuery("SELECT * FROM Users where Username=@username")
        If SQL.RecordCount > 0 Then
            MsgBox("Username has been used!")
            Exit Sub
        End If

        SQL.AddParams("@username", txtUserName.Text)
        SQL.AddParams("@usertype", cmbUserType.Text)
        SQL.AddParams("@pass", txtPassword.Text)
        SQL.AddParams("@updatedby", "35593")

        If Query = "Insert" Then
            SQL.ExecQuery("
                INSERT INTO Users 
                VALUES
                (@username,@pass,@usertype,GETDATE(),GETDATE(),NULL,@updatedby)")

            SQL.AddParams("@empname", txtName.Text)
            SQL.AddParams("@gender", txtUserName.Text)
            SQL.AddParams("@age", txtPassword.Text)
            SQL.AddParams("@position", cmbUserType.Text)
            SQL.AddParams("@updatedby", "35593")

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub txtVPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtVPassword.KeyUp
        If txtPassword.Text <> txtVPassword.Text Then
            lblnmatch.Visible = True
        End If
    End Sub

End Class