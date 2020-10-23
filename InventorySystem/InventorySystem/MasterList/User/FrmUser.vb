Public Class FrmUser

    Public Sub LoadDataGrid(Optional Query As String = "")
        If Query <> "" Then
            SQL.ExecQuery(Query)
        Else
            SQL.ExecQuery("SELECT EmpId, EmployeeName, Username, Password, UserLevelId FROM Users u INNER JOIN Employees e ON u.UserID=e.EmpId")
        End If
        If SQL.HasException(True) Then Exit Sub
        dtUsers.DataSource = SQL.DBDT

        Dim btn As New DataGridViewButtonColumn()
        dtUsers.Columns.Add(btn)
        btn.HeaderText = "Delete"
        btn.Text = "X"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With AddUser
            '.txtTitle.Text = "ADD USER"
            .btnSave.Visible = True
            '.txtEmpCode.Enabled = True
            .txtPassword.Enabled = True
            '.txtTitle.Enabled = True
            .cmbUserType.Enabled = True
            .txtUserName.Enabled = True
            .Show()
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Do you really want to delete this user?", MessageBoxButtons.YesNo + MessageBoxIcon.Question, "Delete Data") = vbYes Then
            SQL.ExecQuery("Update Users set deleted where userid=@useid")
            MsgBox("Deleted User")
        End If
    End Sub
    Private Sub LoadDeliveryPlaces()
        cmbUserLevel.DataSource = getDeliveryPlaces()
        cmbUserLevel.DisplayMember = "UserLevel"
        cmbUserLevel.ValueMember = "UserLevelId"
        cmbUserLevel.SelectedIndex = -1
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadDataGrid()
    End Sub
    Private Sub FindItem()
        SQL.AddParams("@user", "'%" & txtSearch.Text & "%'")
        LoadDataGrid("SELECT EmployeeNo, EmployeeName, Username, UserLevelId FROM users u INNER JOIN Employees e ON u.EmployeeNo=e.EmployeeCode
            inner join userlevel ul on u.UserLevelId=ul.UserLevelId where employeeName like @user;")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FindItem()
    End Sub

    Private Sub dtUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtUsers.CellDoubleClick
        Dim i As Integer
        With dtUsers
            i = .CurrentRow.Index
            With AddUser
                .Text = "User Details"
                .btnUpdate.Visible = True
                .cmbUserType.Enabled = True
                .txtPassword.Text = dtUsers.Rows(i).Cells(4).Value.ToString
                .txtUserName.Text = dtUsers.Rows(i).Cells(3).Value.ToString
                .cmbUserType.Text = dtUsers.Rows(i).Cells(5).Value.ToString
                .Show()
            End With
        End With
    End Sub
End Class