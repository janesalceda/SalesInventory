Public Class FrmCategoryEntry
    Private Sub FrmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ExecQuery(btnInsert.Text)
        Me.Close()
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
            SQL.AddParams("@CategoryID", FrmCategorySearch.dtItems.SelectedRows(0).Cells(0).Value.ToString())
            SQL.ExecQuery("UPDATE categories set CategoryName=@categoryname,DeletedDate=(select case when @disuse=1 then getdate() else null end),updatedDate=getdate() where CategoryID=@CategoryID")
        End If

        If SQL.HasException Then
            MsgBox("Error in saving category", MsgBoxStyle.Critical)
            Exit Sub
        End If

        MsgBox("Successfully save", MsgBoxStyle.Information)
    End Sub

    Private Sub txtCategoryname_TextChanged(sender As Object, e As EventArgs) Handles txtCategoryname.TextChanged
        If Not String.IsNullOrEmpty(Trim(txtCategoryname.Text)) Then
            btnclear.Enabled = True
            btnInsert.Enabled = True
        End If
    End Sub
End Class