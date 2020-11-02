Public Class FrmUser

    Public Sub LoadDataGrid(Optional Query As String = "")
        Try
            If Query <> "" Then
                SQL.ExecQuery(Query)
            Else
                SQL.ExecQuery("SELECT EmpId, EmployeeName, ul.UserLevel,case when u.deletedDate is null then 0 else 1 end ,u.deletedDate FROM Users u 
                INNER Join Employees e ON u.UserID=e.EmpId
                inner Join UserLevel ul on ul.UserLevelId=u.UserLevelId")
            End If
            If SQL.HasException() Then Exit Sub
            dtUsers.Rows.Clear()
            Try
                For i = 0 To SQL.DBDT.Rows.Count - 1
                    dtUsers.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), SQL.DBDT.Rows(i).Item(2),
                                     SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(4))
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With AddUser
            .btnSave.Visible = True
            .txtPassword.Enabled = True
            .cmbUserLevel.Enabled = True
            .txtUserName.Enabled = True
            .Show()
        End With
    End Sub
    Private Sub LoadUserLevel()
        cmbUserLevel.DataSource = GetUserLevel()
        cmbUserLevel.DisplayMember = "UserLevel"
        cmbUserLevel.ValueMember = "UserLevelId"
        cmbUserLevel.SelectedIndex = -1
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadUserLevel()
        LoadDataGrid()
    End Sub
    Private Sub FindItem()
        SQL.AddParams("@user", "'%" & txtSearch.Text & "%'")
        LoadDataGrid("SELECT EmpId, EmployeeName, ul.UserLevel,u.deletedDate FROM Users u 
            INNER JOIN Employees e ON u.UserID=e.EmpId
            inner join UserLevel ul on ul.UserLevelId=u.UserLevelId where employeeName like @user;")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadDataGrid()
    End Sub

    Private Sub dtUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtUsers.CellDoubleClick
        Dim i As Integer
        With dtUsers
            i = .CurrentRow.Index
            With AddUser
                .Text = "User Details"
                .btnSave.Text = "UPDATE"
                .cmbUserLevel.Enabled = True
                '.txtPassword.Text = dtUsers.Rows(i).Cells(4).Value.ToString
                .txtUserName.Text = dtUsers.Rows(i).Cells(3).Value.ToString
                .cmbUserLevel.Text = dtUsers.Rows(i).Cells(2).Value.ToString
                .Show()
            End With
        End With
    End Sub

    Private Sub dtUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtUsers.CellClick
        Try
            If e.ColumnIndex = 3 Then
                If MsgBox("Are you sure to edit this user?", MessageBoxButtons.YesNo + MessageBoxIcon.Question, "Delete Data") = vbYes Then
                    If dtUsers.SelectedRows(0).Cells(3).Value = False Then
                        dtUsers.SelectedRows(0).Cells(3).Value = True
                    Else
                        dtUsers.SelectedRows(0).Cells(3).Value = False
                    End If
                    SQL.AddParams("@deleted", dtUsers.SelectedRows(0).Cells(3).Value)
                    SQL.AddParams("@userid", dtUsers.SelectedRows(0).Cells(0).Value)
                    SQL.ExecQuery("Update Users set deleteddate=(select case when @deleted=1 then getdate() else null end) 
                where userid=@userid")
                    If SQL.HasException Then Exit Sub
                    MsgBox("Successfully saved!", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

End Class