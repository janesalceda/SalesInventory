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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim i As Integer
        With dtUsers
            i = .CurrentRow.Index
            With AddUser
                '.txtTitle.Text = "EDIT USER"
                .btnUpdate.Visible = True
                .cmbUserType.Enabled = True
                '.txtEmpCode.Text = dtUsers.Rows(i).Cells(1).Value.ToString
                .txtPassword.Text = dtUsers.Rows(i).Cells(4).Value.ToString
                .txtUserName.Text = dtUsers.Rows(i).Cells(3).Value.ToString
                .cmbUserType.Text = dtUsers.Rows(i).Cells(5).Value.ToString
                .Show()
            End With
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rslt As New System.Windows.Forms.DialogResult
        rslt = MessageBox.Show("Do you really want to delete this user?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rslt = Windows.Forms.DialogResult.Yes Then
            'FrmMessageBox.Show("Delete")
        End If
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadDataGrid()
    End Sub
    Private Sub FindItem()
        SQL.AddParams("@user", "'%" & txtSearch.Text & "%'")
        LoadDataGrid("SELECT EmployeeNo, EmployeeName, Username, Password, UserLevelId FROM u INNER JOIN Employees e ON u.EmployeeNo=e.EmployeeCode where employeeName like @user;")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FindItem()
    End Sub
End Class