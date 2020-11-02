
Public Class FrmSearchInvoice
    Private Sub LoadGrid(where As String)
        Try
            dtPoDetails.Rows.Clear()
            SQL.ExecQuery("SELECT count(*) as a from (SELECT distinct i.InvoiceNo,i.SupplierId,SupplierName,InvoiceDate,TotalAmount
                FROM InvoiceHeaders i INNER	JOIN suppliers s
                ON i.SupplierId=s.SupplierId INNER join  InvoiceDetails  id  ON
                id.InvoiceNo=i.InvoiceNo	" & where & ") a")
            If SQL.DBDT.Rows.Count = 0 Then
                If SQL.RecordCount = 0 Then
                    MsgBox("No Record Found", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
            ElseIf SQL.DBDT.Rows(0).Item(0) > 1000 Then
                If SQL.RecordCount = 0 Then
                    MsgBox("Your Data exceeded to 1000 please set condition", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            Else
                SQL.ExecQuery("SELECT distinct i.InvoiceNo,i.SupplierId,SupplierName,InvoiceDate,TotalAmount
                    FROM InvoiceHeaders i INNER	JOIN suppliers s
                    ON i.SupplierId=s.SupplierId INNER join  InvoiceDetails  id  ON
                    id.InvoiceNo=i.InvoiceNo	" & where)

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
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub FrmSearchInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
    Private Sub reLoad()
        txtSupplier.Clear()
        txtItemCode.Clear()
        txtPO.Clear()
        txtinvoice.Clear()
        dtInvoiceFrom.Checked = False
        dtInvoiceFrom.Value = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
        dtInvoiceTo.Checked = False
        dtInvoiceTo.Value = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
        dtPoDetails.Rows.Clear()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        If Application.OpenForms().OfType(Of SupplierList).Any Then SupplierList.Close()
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
        If Application.OpenForms().OfType(Of SelectionItem).Any Then SelectionItem.Close()
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
        reLoad()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrEmpty(txtPO.Text) Then
            where += AddingWhere(where)
            where += "id.PoNo='" & txtPO.Text & "'"
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
            where += "i.InvoiceDate BETWEEN'" & dtInvoiceFrom.Value.ToString("yyyy/MM/dd") & "' AND '" & dtInvoiceTo.Value.ToString("yyyy/MM/dd") & "'"
        End If
        LoadGrid(where)
    End Sub


    Private Sub dtPoDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPoDetails.CellDoubleClick
        Try
            If Application.OpenForms().OfType(Of FrmInvoiceEntry).Any Then FrmInvoiceEntry.Close()

            With FrmInvoiceEntry
                .txtInvoiceNo.Text = dtPoDetails.SelectedRows(0).Cells(0).Value.ToString
                .Text = "Invoice Details"
                .btnSave.Text = "UPDATE"
                .Show()
            End With
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

End Class