Public Class FrmItemPriceAdd
    Public ItemId As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtSupplierID.Text) Or
            String.IsNullOrEmpty(txtUnitPrice.Text) Then
            MsgBox("Please Complete Important Fields!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If btnSave.Text = "INSERT PRICE" Then
            FrmItemAdd.AddRow(txtSupplierID.Text, txtUnitPrice.Text, dtAppliedDate.Value)
            If Not String.IsNullOrWhiteSpace(FrmItemAdd.txtItemId.Text) Then
                FrmItemAdd.btnSave.Text = "UPDATE"
                FrmItemAdd.btnSave.Visible = True
            End If
        Else
            FrmItemAdd.dtItemPrices.SelectedRows(0).Cells(0).Value = txtSupplierID.Text
            FrmItemAdd.dtItemPrices.SelectedRows(0).Cells(1).Value = dtAppliedDate.Value.ToShortDateString
            FrmItemAdd.dtItemPrices.SelectedRows(0).Cells(2).Value = txtUnitPrice.Text
        End If
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

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged

    End Sub
End Class