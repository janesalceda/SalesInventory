Public Class FrmChangeItemDescription
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtNewDescription.Text) Then
            MsgBox("Please input Description!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtItemId.Text) Then
            MsgBox("Input Item Id!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
            SQL.AddParams("@itemsid", txtItemId.Text)
            SQL.AddParams("@oldDes", txtCurDescription.Text)
            SQL.AddParams("@newDes", txtNewDescription.Text)
            SQL.AddParams("@updateid", moduleId)
            SQL.ExecQuery("execute dbo.UpdateItemDescription @itemid=@itemsid,
                 @oldDescription=@oldDes,@newDescription=@newDes,@updatedid=@updateid")
            If SQL.HasException Then Exit Sub

            MsgBox("Successfully saved!", MsgBoxStyle.Information, "Information")
            Close()

        End If
    End Sub

    Private Sub txtItemId_LostFocus(sender As Object, e As EventArgs) Handles txtItemId.LostFocus
        SQL.AddParams("@itemid", Trim(txtItemId.Text))
        SQL.ExecQuery("Select Description from items where itemid=@itemid")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        txtCurDescription.Text = SQL.DBDT.Rows(0).Item("Description")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class