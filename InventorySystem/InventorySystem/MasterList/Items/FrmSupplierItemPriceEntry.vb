Public Class FrmSupplierItemPriceEntry
    Public ItemId As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(txtSupplierID.Text) Or
            String.IsNullOrEmpty(txtUnitPrice.Text) Then
                MsgBox("Please complete all * important fields!", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            If btnSave.Text = "INSERT PRICE" Then
                FrmItemEntry.dtableItemPrices.Rows.Add(txtSupplierID.Text, dtAppliedDate.Value, txtUnitPrice.Text, "", txtSupItemCode.Text, "")
                If FrmItemEntry.dtableItemPrices.Rows.Count <> 0 Or
                    Not String.IsNullOrWhiteSpace(FrmItemEntry.dtableItemPrices.Rows(0).Cells(3).Value) Then
                    FrmItemEntry.btnSave.Text = "UPDATE"
                    FrmItemEntry.btnSave.Visible = True

                Else
                    FrmItemEntry.btnSave.Text = "SAVE"
                End If
            Else
                FrmItemEntry.dtableItemPrices.SelectedRows(0).Cells(0).Value = txtSupplierID.Text
                FrmItemEntry.dtableItemPrices.SelectedRows(0).Cells(1).Value = dtAppliedDate.Value.ToShortDateString
                FrmItemEntry.dtableItemPrices.SelectedRows(0).Cells(2).Value = txtUnitPrice.Text
                FrmItemEntry.dtableItemPrices.SelectedRows(0).Cells(4).Value = txtSupItemCode.Text
            End If
            Me.Close()

        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        If Application.OpenForms().OfType(Of SupplierList).Any Then SupplierList.Close()

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
    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True

    End Sub
End Class