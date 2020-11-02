Public Class FrmChangeSupplierName
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtnewSupName.Text) Then
            MsgBox("Please input new Supplier Name!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtCurSupname.Text) Then
            MsgBox("Please input valid Supplier id!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = vbYes Then

            SQL.AddParams("@SupID", txtSupid.Text)
            SQL.AddParams("@SupName", txtnewSupName.Text)
            SQL.AddParams("@UpdateID", moduleId)
            SQL.ExecQuery("execute dbo.UpdateSupplierName @SupplierID=@SupID ,@SupplierName=@SupName,@UpdatedID=@UpdateID")
            If SQL.HasException Then Exit Sub
            MsgBox("Successfully saved!", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub txtSupid_LostFocus(sender As Object, e As EventArgs) Handles txtSupid.LostFocus
        SQL.AddParams("@Supplierid", Trim(txtSupid.Text))
        SQL.ExecQuery("Select Suppliername from suppliers where Supplierid=@Supplierid")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        txtCurSupname.Text = SQL.DBDT.Rows(0).Item("Suppliername")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtSupid_TextChanged(sender As Object, e As EventArgs) Handles txtSupid.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupid.Text)
        If row.Count = 0 Then
            txtCurSupname.Text = ""
            Exit Sub
        End If
        txtCurSupname.Text = row.Item(0)
    End Sub
End Class