
Public Class FrmSearchInvoice
    Private Sub LoadGrid(where As String)
        ' HINDI PA TAPOS DI KO PA ALAM KUKUNIN
        dtPoDetails.Rows.Clear()
        'SQL.AddParams("@where", where)
        SQL.ExecQuery("SELECT i.InvoiceNo,i.SupplierId,SupplierName,InvoiceDate,TotalAmount
             FROM InvoiceHeaders i INNER	JOIN suppliers s
            ON i.SupplierId=s.SupplierId INNER join  InvoiceDetails  id  ON
id.InvoiceNo=i.InvoiceNo	" & where)
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
    Private Sub FrmSearchInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "SearchInvoice"
        SupplierList.Show()
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemCode.Text)
        If row.Count = 0 Then
            txtItemName.Text = ""
            Exit Sub
        End If
        txtItemName.Text = row.Item(0)
    End Sub

    Private Sub btnitems_Click(sender As Object, e As EventArgs) Handles btnitems.Click
        'If txtSupplier.Text = "" Then
        '    MsgBox("Choose Supplier First")
        '    Exit Sub
        'End If
        SelectionItem.txtSupplier.Text = txtSupplier.Text
        formname = "SearchInvoice"
        SelectionItem.Show()
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupplier.Text)
        If row.Count = 0 Then
            txtSupplierName.Text = ""
            Exit Sub
        End If
        txtSupplierName.Text = row.Item(0)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSupplier.Clear()
        txtItemCode.Clear()
        txtPO.Clear()
        txtinvoice.Clear()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrEmpty(txtPO.Text) Then
            where += AddingWhere(where)
            where += "i.PoNo='" & txtPO.Text & "'"
        End If
        If Not String.IsNullOrEmpty(txtSupplier.Text) Then
            where += AddingWhere(where)
            where += "i.SupplierID='" & txtSupplier.Text & "'"
        End If
        If Not String.IsNullOrEmpty(txtItemCode.Text) Then
            where += AddingWhere(where)
            where += "id.ItemId='" & txtItemCode.Text & "'"
        End If
        If dtInvoiceFrom.Checked = True And dtInvoiceTo.Checked = True Then
            where += AddingWhere(where)
            where += "i.InvoiceDate BETWEEN'" & dtInvoiceFrom.Value.ToShortDateString() & "' AND '" & dtInvoiceTo.Value.ToShortDateString() & "'"
        End If
        LoadGrid(where)
    End Sub


    Private Sub dtPoDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPoDetails.CellDoubleClick
        With AddInvoice
            .txtInvoiceNo.Text = dtPoDetails.SelectedRows(0).Cells(0).Value.ToString
            .btnSave.Text = "UPDATE"
            .Show()
        End With
    End Sub
End Class