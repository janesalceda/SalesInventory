Public Class FrmCategorySearch
    Public Sub LoadDataGrid(Optional Query As String = "")
        SQL.ExecQuery("SELECT CategoryID,CategoryName,CreatedDate,case when DeletedDate is null then 0 else 1 end,DeletedDate FROM categories c " & Query)
        If SQL.HasException(True) Then Exit Sub

        dtItems.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItems.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(4))
        Next
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrWhiteSpace(txtCatID.Text) Then
            where += AddingWhere(where)
            where += "c.CategoryID = '" & txtCatID.Text & "'"
        End If
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            where += AddingWhere(where)
            where += "c.CategoryName LIKE '%" & txtDes.Text & "%'"
        End If
        If Not String.IsNullOrWhiteSpace(chkDisuse.Checked) Then
            where += AddingWhere(where)
            If chkDisuse.Checked = True Then
                where += "c.DeletedDate is not null"
            Else
                where += "c.DeletedDate is null"
            End If
        End If
        LoadDataGrid(where)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmCategoryEntry.Text = "Category Entry"
        FrmCategoryEntry.Show()
    End Sub


    Private Sub FrmCategorySearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub dtItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellClick
        If e.ColumnIndex = 3 Then
            If dtItems.SelectedRows(0).Cells(3).Value = -2 Then
                dtItems.SelectedRows(0).Cells(3).Value = 0
            ElseIf dtItems.SelectedRows(0).Cells(3).Value = 0 Then
                dtItems.SelectedRows(0).Cells(3).Value = 1
            Else
                dtItems.SelectedRows(0).Cells(3).Value = 0
            End If
            'dtItems.SelectedRows(0).Cells(3).Value = False
            SQL.AddParams("@disuse", dtItems.SelectedRows(0).Cells(3).Value)
            SQL.AddParams("@categoryid", dtItems.SelectedRows(0).Cells(0).Value)
            SQL.ExecQuery("UPDATE Categories set 
                DeletedDate=(select case when @disuse=0 then null else getdate() end) where categoryid=@categoryid")
            If SQL.HasException Then
                Exit Sub
            End If
        Else
            With FrmCategoryEntry
                .Text = "Category Details"
                .btnInsert.Text = "UPDATE"
                .txtCategoryname.Text = dtItems.SelectedRows(0).Cells(1).Value.ToString
                .Show()
            End With
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCatID.Clear()
        txtDes.Clear()
        dtItems.Rows.Clear()
        chkDisuse.Checked = False
    End Sub
End Class