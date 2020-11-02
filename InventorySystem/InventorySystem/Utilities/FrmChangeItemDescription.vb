Public Class FrmChangeItemDescription
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtNewDescription.Text) Then
                MsgBox("Please input new Description!", MsgBoxStyle.Information, "Information")
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
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
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

    Private Sub txtItemId_TextChanged(sender As Object, e As EventArgs) Handles txtItemId.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemId.Text)
        If row.Count = 0 Then
            txtCurDescription.Text = ""
            'coefficient = 0.0
            Exit Sub
        End If
        txtCurDescription.Text = row.Item(0)
        'coefficient = row.Item(3)
    End Sub
End Class