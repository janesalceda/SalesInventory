Public Class FrmItemPriceAdd
    Public ItemId As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtSupplierID.Text) Or
            String.IsNullOrEmpty(txtUnitPrice.Text) Then
            MsgBox("Please complete all * important fields!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If btnSave.Text = "INSERT PRICE" Then
            FrmItemEntry.AddRow(txtSupplierID.Text, txtUnitPrice.Text, dtAppliedDate.Value)
            If Not String.IsNullOrWhiteSpace(FrmItemEntry.txtItemId.Text) Then
                FrmItemEntry.btnSave.Text = "UPDATE"
                FrmItemEntry.btnSave.Visible = True
            End If
        Else
            FrmItemEntry.dtItemPrices.SelectedRows(0).Cells(0).Value = txtSupplierID.Text
            FrmItemEntry.dtItemPrices.SelectedRows(0).Cells(1).Value = dtAppliedDate.Value.ToShortDateString
            FrmItemEntry.dtItemPrices.SelectedRows(0).Cells(2).Value = txtUnitPrice.Text
        End If
        Me.Close()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "AddItem"
        SupplierList.Show()
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