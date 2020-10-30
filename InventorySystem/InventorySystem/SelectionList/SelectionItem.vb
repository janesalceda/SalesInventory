Public Class SelectionItem
    Public IssuedDate As Date
    'Public formname As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = ""
        query += AddingWhere(query)
        query += " i.deletedDate is null"
        If formname = "AddPurchaseOrder" Then
            SQL.AddParams("@issuedDate", IssuedDate.ToString("yyyy/MM/dd"))
            query += AddingWhere(query)
            query += " convert(VARCHAR(10),ip.AppliedDate,111)<=@issuedDate"
        End If
        If txtItems.Text <> "" Then
            SQL.AddParams("@ItemId", txtItems.Text)
            query += AddingWhere(query)
            query += " i.ItemId=@ItemId"
        End If
        If txtItemsName.Text <> "" Then
            SQL.AddParams("@Description", "%" & txtItemsName.Text & "%")
            query += AddingWhere(query)
            query += " i.Description=@Description"
        End If
        If txtSupplier.Text <> "" Then
            SQL.AddParams("@SupplierID", txtSupplier.Text)
            query += AddingWhere(query)
            query += " ip.SupplierID=@SupplierID"
        End If
        Dim exequery As String
        exequery = "SELECT distinct i.itemid,description FROM Items i Left Join supplieritemprices ip  On i.ItemId=ip.ItemId"
        exequery += query
        SQL.ExecQuery(exequery)
        If SQL.HasException Then Exit Sub
        'SQL.ExecQuery("Select DISTINCT i.itemid, i.Description,
        '        ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.ClientQtyUnit) 'Client',
        '        ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.SupplierQtyUnit) 'Supplier',ConvertingCoefficient,
        '        UnitPrice FROM Items i INNER JOIN SupplierItemPrices s ON i.ItemId=s.ItemId, QtyUnits q where " & query)
        If SQL.RecordCount = 0 Then
            MsgBox("No Record Found", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        dtitems.Rows.Clear()

        For index As Integer = 0 To SQL.DBDT.Rows.Count - 1
            Dim row As ArrayList = New ArrayList
            row.Add(SQL.DBDT.Rows(index).Item(0))
            row.Add(SQL.DBDT.Rows(index).Item(1))
            dtitems.Rows.Add(row.ToArray())
        Next
    End Sub
    Private Function AddingWhere(where As String) As String
        If where <> "" Then
            Return " AND "
        Else Return " where "
        End If
        Return ""
    End Function
    Private Sub save()
        If dtitems.SelectedRows.Count > 0 Then
            If formname = "SearchPo" Then
                FrmSearchPO.txtItems.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                FrmSearchPO.txtItemsName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()

            ElseIf formname = "AddPurchaseOrder" Then
                With FrmPurchaseOrderEntry
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .btnAddItem.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddInvoice" Then
                With FrmInvoiceEntry
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .btnAddItem.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddDelivery" Then
                With FrmInvoiceEntry
                    .txtItemDel.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .btnInsertDel.Visible = True
                    Me.Close()
                End With

            ElseIf formname = "SearchInvoice" Then
                With FrmSearchInvoice
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    Me.Close()
                End With
            ElseIf formname = "AddStockTaking" Then
                With FrmStockTakingEntry
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    Me.Close()
                End With

            ElseIf formname = "AddStockOut" Then
                With FrmStockOutEntry
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    Me.Close()
                End With
            ElseIf formname = "AddReturn" Then
                With FrmRejectReturnEntry
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    Me.Close()
                End With
            End If
            Me.Close()
        End If

    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        save()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItems.Clear()
        txtItemsName.Clear()
        dtitems.Rows.Clear()
    End Sub

    Private Sub dtitems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtitems.CellDoubleClick
        save()
    End Sub

    Private Sub SelectionItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtitems.Rows.Clear()
    End Sub
End Class