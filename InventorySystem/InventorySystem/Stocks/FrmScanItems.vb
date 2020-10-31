Public Class FrmScanItems
    Public ItemCode As String
    Dim DTCount As Integer
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemname As String
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(ItemCode)
        If row.Count = 0 Then
            Exit Sub
        End If
        itemname = row.Item(0)
        row.Clear()
        DTCount += 1
        row.Add(DTCount)
        row.Add(ItemCode)
        row.Add(itemname)
        row.Add(txtQty.Text)

        If formname = "StockOut" Then
            FrmStockOutEntry.cliprice = getClientPrice(ItemCode, FrmStockOutEntry.dtSOutDate.Value)
            row.Add(FrmStockOutEntry.cliprice)
            row.Add(Val(txtQty.Text) * FrmStockOutEntry.cliprice)
            row.Add(txtremarks.Text)
            row.Add(getSupplierPrice(ItemCode, FrmStockOutEntry.dtSOutDate.Value, ""))
            FrmStockOutEntry.dtableStockout.Rows.Add(row.ToArray())
            FrmStockOutEntry.txtTotalAmount.Text = Val(FrmStockOutEntry.txtTotalAmount.Text) + Val(txtQty.Text) * FrmStockOutEntry.cliprice
        ElseIf formname = "StockTaking" Then
            FrmStockTakingEntry.cliprice = getClientPrice(ItemCode, FrmStockTakingEntry.dtCountedDate.Value)
            row.Add(FrmStockTakingEntry.cliprice)
            row.Add(Val(txtQty.Text) * FrmStockTakingEntry.cliprice)
            row.Add(txtremarks.Text)
            row.Add(getSupplierPrice(ItemCode, FrmStockOutEntry.dtSOutDate.Value, ""))
            FrmStockTakingEntry.dtableStockTaking.Rows.Add(row.ToArray())
            FrmStockTakingEntry.txtTotalAmount.Text = Val(FrmStockTakingEntry.txtTotalAmount.Text) + Val(txtQty.Text) * FrmStockTakingEntry.cliprice
        Else
            'FrmRejectReturnEntry.cliprice = getClientPrice(ItemCode, FrmRejectReturnEntry.dtSOutDate.Value)
            'row.Add(FrmStockOutEntry.cliprice)
            row.Add(txtremarks.Text)
            FrmRejectReturnEntry.dtableStockTaking.Rows.Add(row.ToArray())
        End If
        Me.Close()
    End Sub
End Class