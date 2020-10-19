Public Class FrmSearchPO
    Private Sub LoadGrid(where As String)
        dtPoDetails.Rows.Clear()
        'SQL.AddParams("@where", where)
        SQL.ExecQuery("SELECT DISTINCT p.PoNo,p.SupplierID,SupplierName,IssuedDate,
            CASE WHEN p.DeletedDate IS NULL THEN 0 ELSE 1 END Cancelled FROM poheaders p
            INNER JOIN Suppliers s ON p.SupplierID=s.SupplierId INNER JOIN PoDetails pd
            ON pd.PoNo=p.PONo " & where)
        If SQL.RecordCount = 0 Then
            MsgBox("No Record Found", MsgBoxStyle.Information)
            Exit Sub
        End If

        dtPoDetails.Rows.Clear()

        For index As Integer = 0 To SQL.DBDT.Rows.Count - 1
            Dim row As ArrayList = New ArrayList
            row.Add(SQL.DBDT.Rows(index).Item(0))
            row.Add(SQL.DBDT.Rows(index).Item(1))
            row.Add(SQL.DBDT.Rows(index).Item(2))
            row.Add(SQL.DBDT.Rows(index).Item(3))
            row.Add(SQL.DBDT.Rows(index).Item(4))
            dtPoDetails.Rows.Add(row.ToArray())
        Next

    End Sub
    Private Sub FrmSearchPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub


    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        formname = "SearchPo"
        SelectionItem.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrEmpty(txtPONo.Text) Then
            where += AddingWhere(where)
            where += "p.PoNo='" & txtPONo.Text & "'"
        End If
        If Not String.IsNullOrEmpty(txtSupplier.Text) Then
            where += AddingWhere(where)
            where += "p.SupplierID='" & txtSupplier.Text & "'"
        End If
        If Not String.IsNullOrEmpty(txtItems.Text) Then
            where += AddingWhere(where)
            where += "pd.ItemId='" & txtItems.Text & "'"
        End If
        If dtIssuedFrom.Checked = True And dtIssuedTo.Checked = True Then
            where += AddingWhere(where)
            where += "p.IssuedDate BETWEEN'" & dtIssuedFrom.Value.ToShortDateString() & "' AND '" & dtIssuedFrom.Value.ToShortDateString() & "'"
        End If
        If radYes.Checked = True Then
            where += AddingWhere(where)
            where += "p.DeletedDate is not null"
        Else
            where += AddingWhere(where)
            where += "p.DeletedDate is null"
        End If
        LoadGrid(where)
    End Sub


    Private Sub dtPoDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPoDetails.CellDoubleClick
        'HINDI PA TAPOS HINDI KO PA ALAM IPAPASA SA FORM "ADDPURCHASEORDER"
        With FrmPurchaseOrderEntry
            .txtPONo.Text = dtPoDetails.SelectedRows(0).Cells(0).Value.ToString()
            .Text = "Purchase Order Details"
            .btnSave.Text = "UPDATE P.O."
            .Show()
        End With
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "FrmSearchPO"
        SupplierList.ShowDialog()
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupplier.Text)
        If row.Count = 0 Then
            txtSupplierName.Text = ""
            Exit Sub
        End If
        txtSupplierName.Text = row.Item(0)
        'txtCliUnit.Text = row.Item(1)
        'txtSupUnit.Text = row.Item(2)
        'coefficient = row.Item(3)
        'txtUnit.Text = Format(Val(row.Item(4)), "0.00")
    End Sub

    Private Sub txtItems_TextChanged(sender As Object, e As EventArgs) Handles txtItems.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItems.Text)
        If row.Count = 0 Then
            txtItemsName.Text = ""
            Exit Sub
        End If
        txtItemsName.Text = row.Item(0)
    End Sub

End Class