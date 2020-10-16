Public Class SelectionItem
    'Public formname As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = ""
        If txtItems.Text <> "" Then
            SQL.AddParams("@ItemId", txtItems.Text)
            query += AddingWhere(query)
            query += "i.ItemId=@ItemId"
        End If
        If txtItemsName.Text <> "" Then
            SQL.AddParams("@Description", "%" & txtItemsName.Text & "%")
            query += AddingWhere(query)
            query += "i.Description=@Description"
        End If
        If txtSupplier.Text <> "" Then
            SQL.AddParams("@SupplierID", txtSupplier.Text)
            query += AddingWhere(query)
            query += "i.SupplierID=@SupplierID"
        End If
        SQL.ExecQuery("SELECT i.itemid,description FROM Items i " & query)

        'SQL.ExecQuery("SELECT DISTINCT i.itemid,i.Description,
        '        ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.ClientQtyUnit) 'Client',
        '        ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.SupplierQtyUnit) 'Supplier',ConvertingCoefficient,
        '        UnitPrice FROM Items i INNER JOIN SupplierItemPrices s ON i.ItemId=s.ItemId, QtyUnits q where " & query)
        If SQL.RecordCount = 0 Then
            MsgBox("No Record Found")
            Exit Sub
        End If
        For index As Integer = 0 To SQL.DBDT.Rows.Count - 1
            Dim row As ArrayList = New ArrayList
            row.Add(SQL.DBDT.Rows(index).Item(0))
            row.Add(SQL.DBDT.Rows(index).Item(1))
            'row.Add(SQL.DBDT.Rows(index).Item(2))
            'row.Add(SQL.DBDT.Rows(index).Item(3))
            'row.Add(SQL.DBDT.Rows(index).Item(4))
            'row.Add(SQL.DBDT.Rows(index).Item(5))
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

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If dtitems.SelectedRows.Count > 0 Then
            If formname = "SearchPo" Then
                FrmSearchPO.txtItems.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                FrmSearchPO.txtItemsName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()

            ElseIf formname = "AddPurchaseOrder" Then
                With AddPurchaseOrder
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    '.txtItemName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    '.txtCliUnit.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    '.txtSupUnit.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    'coefficient = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    '.txtUnit.Text = Format(Val(dtitems.SelectedRows(0).Cells(5).Value.ToString()), "0.00")
                    .btnAddItem.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddInvoice" Then
                With AddInvoice
                    ' .dtPoDetails.SelectedRows(0).Cells(1).Value = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    '.txtItemName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    '.txtCliUnit.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    '.txtSupUnit.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    'coefficient = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    '.txtUnit.Text = Format(Val(dtitems.SelectedRows(0).Cells(5).Value.ToString()), "0.00")
                    .btnAddItem.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddDelivery" Then
                With AddInvoice
                    ' .dtPoDetails.SelectedRows(0).Cells(1).Value = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtItemDel.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    '.txtItemName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    '.txtCliUnit.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    '.txtSupUnit.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    'coefficient = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    '.txtUnit.Text = Format(Val(dtitems.SelectedRows(0).Cells(5).Value.ToString()), "0.00")
                    .btnInsertDel.Visible = True
                    Me.Close()
                End With

            ElseIf formname = "SearchInvoice" Then
                With FrmSearchInvoice
                    ' .dtPoDetails.SelectedRows(0).Cells(1).Value = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    '.txtItemName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    '.txtCliUnit.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    '.txtSupUnit.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    'coefficient = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    '.txtUnit.Text = Format(Val(dtitems.SelectedRows(0).Cells(5).Value.ToString()), "0.00")
                    '.btnInsertDel.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddStockTaking" Then
                With AddStockTaking
                    ' .dtPoDetails.SelectedRows(0).Cells(1).Value = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    '.txtItemName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    '.txtCliUnit.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    '.txtSupUnit.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    'coefficient = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    '.txtUnit.Text = Format(Val(dtitems.SelectedRows(0).Cells(5).Value.ToString()), "0.00")
                    '.btnInsertDel.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddStockOut" Then
                With AddStockOut
                    ' .dtPoDetails.SelectedRows(0).Cells(1).Value = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    '.txtItemName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    '.txtCliUnit.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    '.txtSupUnit.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    'coefficient = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    '.txtUnit.Text = Format(Val(dtitems.SelectedRows(0).Cells(5).Value.ToString()), "0.00")
                    '.btnInsertDel.Visible = True
                    Me.Close()
                End With
            End If
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItems.Clear()
        txtItemsName.Clear()
    End Sub

    Private Sub SelectionItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class