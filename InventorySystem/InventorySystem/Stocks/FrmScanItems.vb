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
        row.Add(txtremarks.Text)
        If formname = "StockOut" Then
            FrmStockOutEntry.dtableStockout.Rows.Add(row.ToArray())
            FrmStockOutEntry.txtTotalAmount.Text = Val(FrmStockOutEntry.txtTotalAmount.Text) + Val(txtQty.Text) * FrmStockOutEntry.cliprice
        ElseIf formname = "StockTaking" Then
            FrmStockTakingEntry.dtableStockTaking.Rows.Add(row.ToArray())
        Else
            FrmRejectReturnEntry.dtableStockTaking.Rows.Add(row.ToArray())
        End If
        Me.Close()
    End Sub
End Class