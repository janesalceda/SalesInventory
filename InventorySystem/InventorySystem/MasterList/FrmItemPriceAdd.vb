Public Class FrmItemPriceAdd
    Public ItemId As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtSupplierID.Text) Or
            String.IsNullOrEmpty(txtUnitPrice.Text) Then
            MsgBox("Please Complete Important Fields!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        FrmItemAdd.dtItemPrices.Rows.Add(txtSupplierID.Text,
         dtAppliedDate.Value, txtUnitPrice.Text, "", "", "Edit")

        'SQL.AddParams("@ItemId", ItemId)
        'SQL.AddParams("@SupplierID", txtSupplierID.Text)
        'SQL.AddParams("@ItemPrice", txtUnitPrice.Text)
        'SQL.AddParams("@AppliedDate", dtAppliedDate.Value)
        'SQL.AddParams("@UpdatedBy", moduleId)
        'SQL.ExecQuery("INSERT INTO SupplierItemPrices 
        '    (ItemId,SupplierId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
        '    VALUES(@ItemId,@SupplierID,@AppliedDate,@ItemPrice,NULL,@UpdatedBy)")
        'If SQL.HasException Then
        '    MsgBox("Error in Saving Please check fields!", MsgBoxStyle.Critical)
        'End If
        'MsgBox("Successfully Saved!", MsgBoxStyle.Information)
        'FrmItemAdd.refreshData()
        FrmItemAdd.btnSave.Text = "UPDATE"
        FrmItemAdd.btnSave.Visible = True
        Me.Close()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "AddItem"
        SupplierList.ShowDialog()
    End Sub

    Private Sub txtSupplierID_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierID.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupplierID.Text)
        If row.Count = 0 Then
            txtSupDes.Text = ""
            Exit Sub
        End If
        txtSupDes.Text = row.Item(0)
    End Sub
End Class