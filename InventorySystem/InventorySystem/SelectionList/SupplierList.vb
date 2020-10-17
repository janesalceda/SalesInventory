Public Class SupplierList
    Private Sub SupplierList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MdiParent = AppForm
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
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
        dtSupplier.DataSource = SQL.DBDT
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        With dtSupplier
            If formname = "AddPurchaseOrder" Then
                AddPurchaseOrder.txtSupplier.Text = .SelectedRows(0).Cells(0).Value.ToString
            ElseIf formname = "AddInvoice" Then
                AddInvoice.txtSupplier.Text = .SelectedRows(0).Cells(0).Value.ToString
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
End Class