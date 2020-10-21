Public Class SupplierList
    Private Sub SupplierList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MdiParent = AppForm
        dtSupplier.Rows.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        where += AddingWhere(where)
        where += "s.DeletedDate is null"
        If Not String.IsNullOrEmpty(txtSupplier.Text) Then
            where += AddingWhere(where)
            where += "s.SupplierId='" & txtSupplier.Text & "'"
        End If
        If Not String.IsNullOrEmpty(txtSupplierName.Text) Then
            where += AddingWhere(where)
            where += "s.SupplierId like '%" & txtSupplierName.Text & "%'"
        End If
        SQL.ExecQuery("SELECT SupplierId,SupplierName FROM Suppliers s" & where)
        If SQL.HasException Then Exit Sub
        If SQL.DBDT.Rows.Count = 0 Then
            MsgBox("No Record Found!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        dtSupplier.DataSource = Nothing
        dtSupplier.DataSource = SQL.DBDT
    End Sub
    Private Sub save()
        If dtSupplier.Rows.Count = 0 Then Exit Sub
        With dtSupplier
            If formname = "AddPurchaseOrder" Then
                FrmPurchaseOrderEntry.txtSupplier.Text = .SelectedRows(0).Cells(0).Value.ToString
            ElseIf formname = "AddInvoice" Then
                FrmInvoiceEntry.txtSupplier.Text = .SelectedRows(0).Cells(0).Value.ToString
            ElseIf formname = "SearchInvoice" Then
                FrmSearchInvoice.txtSupplier.Text = .SelectedRows(0).Cells(0).Value.ToString
            ElseIf formname = "FrmSearchPO" Then
                FrmSearchPO.txtSupplier.Text = .SelectedRows(0).Cells(0).Value.ToString
            ElseIf formname = "AddItem" Then
                FrmItemPriceAdd.txtSupplierID.Text = .SelectedRows(0).Cells(0).Value.ToString
            End If
        End With
        Me.Close()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        save()
    End Sub

    Private Sub dtSupplier_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSupplier.CellDoubleClick
        save()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSupplier.Clear()
        txtSupplierName.Clear()
        dtSupplier.DataSource = Nothing
    End Sub
End Class