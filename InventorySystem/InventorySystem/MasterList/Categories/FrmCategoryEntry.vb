Public Class FrmCategoryEntry
    Public id As Integer
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
            SQL.AddParams("@CategoryID", id)
            SQL.ExecQuery("UPDATE categories set CategoryName=@categoryname,DeletedDate=(select case when @disuse=1 then getdate() else null end),updatedDate=getdate() where CategoryID=@CategoryID")
        End If

        If SQL.HasException Then
            MsgBox("Error in saving category", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        MsgBox("Successfully saved", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub txtCategoryname_TextChanged(sender As Object, e As EventArgs) Handles txtCategoryname.TextChanged
        If Not String.IsNullOrEmpty(Trim(txtCategoryname.Text)) Then
            btnInsert.Enabled = True
        End If
    End Sub

    Private Sub FrmCategoryEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class