Public Class FrmCategory
    Private Sub FrmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        SQL.ExecQuery("SELECT * FROM CATEGORIES")

        If SQL.DBDT.Rows.Count = 0 Then Exit Sub

        If dtableCategory.Rows.Count <> 0 Then dtableCategory.DataSource = False


        dtableCategory.DataSource = SQL.DBDT
        'For index As Integer = 0 To SQL.DBDT.Rows.Count - 1
        '    dtCategory.Rows.Add(SQL.DBDT.Rows(index).Item(0), SQL.DBDT.Rows(index).Item(1))
        'Next
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ExecQuery("SAVE")
        LoadGrid()
        ClearFields()
    End Sub

    'Private Sub dtCategory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCategory.CellDoubleClick
    '    btnUpdate.Visible = True
    '    txtCategoryname.Text = dtCategory.SelectedRows(0).Cells(1).Value.ToString()
    'End Sub

    Private Sub ClearFields()
        txtCategoryname.Clear()
        chkDisuse.Checked = False
        btnclear.Enabled = False
        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        LoadGrid()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ExecQuery("UPDATE")
        ClearFields()
        btnUpdate.Visible = False
    End Sub
    Private Sub ExecQuery(Query As String)
        SQL.AddParams("@categoryname", txtCategoryname.Text)
        SQL.AddParams("@UpdatedBy", moduleId)
        SQL.AddParams("@disuse", chkDisuse.Checked)

        If Query = "SAVE" Then
            SQL.ExecQuery("INSERT INTO Categories
	        (CategoryName,DeletedDate,UpdatedBy)
            VALUES (@categoryname,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
        Else
            SQL.AddParams("@CategoryID", dtableCategory.SelectedRows(0).Cells(0).Value.ToString())
            SQL.ExecQuery("UPDATE categories set CategoryName=@categoryname,DeletedDate=(select case when @disuse=1 then getdate() else null end),updatedDate=getdate() where CategoryID=@CategoryID")
        End If

        If SQL.HasException Then
            MsgBox("Error in saving category", MsgBoxStyle.Critical)
            Exit Sub
        End If

        MsgBox("Successfully save", MsgBoxStyle.Information)
    End Sub

    Private Sub dtCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableCategory.CellClick
        btnUpdate.Visible = True
        txtCategoryname.Text = Trim(dtableCategory.SelectedRows(0).Cells(1).Value.ToString())
        If Not String.IsNullOrEmpty(Trim(dtableCategory.SelectedRows(0).Cells(3).Value.ToString())) Then
            chkDisuse.Checked = True
        Else
            chkDisuse.Checked = False
        End If
    End Sub

    Private Sub txtCategoryname_TextChanged(sender As Object, e As EventArgs) Handles txtCategoryname.TextChanged
        If Not String.IsNullOrEmpty(Trim(txtCategoryname.Text)) Then
            btnclear.Enabled = True
            btnInsert.Enabled = True
            btnUpdate.Enabled = True
        End If
    End Sub
    'Private Sub dtCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles dtCategory.KeyDown
    '    If e.KeyCode = Keys.F4 Then

    '    End If
    'End Sub
End Class