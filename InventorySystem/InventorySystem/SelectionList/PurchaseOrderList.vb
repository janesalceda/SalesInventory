Public Class PurchaseOrderList
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SQL.AddParams("@itemid", txtItems.Text)
        SQL.AddParams("@supplierid", txtSupplier.Text)
        'SQL.ExecQuery("SELECT DISTINCT p.PoNo,p.SupplierID,SupplierName,IssuedDate,
        '    CASE WHEN p.DeletedDate IS NULL THEN 0 ELSE 1 END Cancelled FROM PurchaseOrder p
        '    INNER JOIN Suppliers s ON p.SupplierID=s.SupplierId INNER JOIN PoDetails pd
        '    ON pd.PoNo=p.PONo WHERE p.itemid=@itemid and p.supplierid=@supplierid")
        SQL.ExecQuery("SELECT     po.SupplierID,
            pod.PoNo,
            pod.ItemID, pod.PoDetailSeq,
            pod.Qty As POQty, isnull(A.InvoiceQty, 0)As InvoiceQty,     
            pod.Qty -isnull(A.InvoiceQty, 0)  as BalQty 	
            From POHeaders  po  INNER Join PoDetails pod
            On po.PoNo = pod.PoNo  	
            INNER Join Suppliers  	ON         
            po.SupplierId = Suppliers.SupplierId
                    Left Join(
            Select   SupplierID, PONO, PODetailSeq, ItemID, Sum(InvoiceDetails.QTY) as InvoiceQty  
            From InvoiceDetails  Where ItemId = @ItemId   And SupplierId = @SupplierId
            Group by SupplierID,PONO,PODetailSeq,ItemID  )A  On po.SupplierID = A.SupplierID
            And pod.PONO = A.PONO    And pod.PoDetailSeq = A.PoDetailSeq    And pod.ItemID = A.ItemID    
            WHERE      po.SupplierId =@SupplierId AND        pod.ItemId = @ItemId
            And pod.ReceivedAllInvoices = 0 
            And pod.Canceled = 0  Group by po.SupplierID,  
            pod.PoNo, pod.ItemID, pod.PoDetailSeq, A.InvoiceQty, pod.Qty"
)
        If SQL.RecordCount = 0 Then
            MsgBox("No Record Found")
            Exit Sub
        End If
        dtitems.Rows.Clear()

        For index As Integer = 0 To SQL.DBDT.Rows.Count - 1
            Dim row As ArrayList = New ArrayList
            row.Add(SQL.DBDT.Rows(index).Item(1))
            row.Add(SQL.DBDT.Rows(index).Item(3))
            row.Add(SQL.DBDT.Rows(index).Item(4))
            'row.Add(SQL.DBDT.Rows(index).Item(3))
            row.Add(SQL.DBDT.Rows(index).Item(6))
            row.Add(SQL.DBDT.Rows(index).Item(5))
            'row.Add(SQL.DBDT.Rows(index).Item(5))
            dtitems.Rows.Add(row.ToArray())
        Next
    End Sub

    Private Sub PurchaseOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtitems.Rows.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
    Private Sub save()
        If dtitems.Rows.Count = 0 Then Exit Sub
        If dtitems.SelectedRows.Count > 0 Then
            If formname = "SearchPo" Then
                FrmSearchPO.txtItems.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                FrmSearchPO.txtItemsName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()

            ElseIf formname = "AddPurchaseOrder" Then
                With FrmPurchaseOrderEntry
                    .txtItemCode.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtItemName.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    .txtCliUnit.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    .txtSupUnit.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    coefficient = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    .txtUnit.Text = Format(Val(dtitems.SelectedRows(0).Cells(5).Value.ToString()), "0.00")
                    .btnAddItem.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddInvoice" Then
                With FrmInvoiceEntry
                    .txtPo.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtPoSeq.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    '.btnAddItem.Visible = True
                    Me.Close()
                End With
            ElseIf formname = "AddDelivery" Then
                With FrmInvoiceEntry
                    .txtPoDel.Text = dtitems.SelectedRows(0).Cells(0).Value.ToString()
                    .txtposeqdel.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString()
                    .txtExp.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString()
                    .txtBal.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString()
                    .txtRec.Text = dtitems.SelectedRows(0).Cells(4).Value.ToString()
                    '.btnAddItem.Visible = True
                    Me.Close()
                End With
            End If
            Me.Close()
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        save()
    End Sub


    Private Sub dtitems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtitems.CellDoubleClick
        save()
    End Sub
End Class