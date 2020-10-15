Public Class AddInvoice
    Private DTCount As Integer = 0
    Private DTCount1 As Integer = 0
    Private Sub getInvoiceNo()
        'del091020-01
        SQL.ExecQuery("SELECT isnull(max(InvoiceNo),0) 'InvoiceNomax' from InvoiceDetails")
        If SQL.HasException Then Exit Sub
        Dim result As String
        If SQL.DBDT.Rows(0).Item(0) = "0" Then
            result = "001"
        Else
            result = SQL.DBDT.Rows(0).Item(0)
            result = result.Substring(7, 3)
            result = Format(Val(result + 1), "000")
        End If

        txtInvoiceNo.Text = System.DateTime.Today
        txtInvoiceNo.Text = "INV" & Replace(txtInvoiceNo.Text, "/", "", 3) & "-" & result
    End Sub
    Private Sub getDelivery()
        'del091020-01
        SQL.ExecQuery("SELECT isnull(max(DeliveryId),0) 'DeliveryIdmax' from InvoiceDeliveryDetails")
        If SQL.HasException Then Exit Sub
        Dim result As String
        If SQL.DBDT.Rows(0).Item(0) = "0" Then
            result = "001"
        Else
            result = SQL.DBDT.Rows(0).Item(0)
            result = result.Substring(7, 3)
            result = Format(Val(result + 1), "000")
        End If

        txtDeliveryID.Text = System.DateTime.Today
        txtDeliveryID.Text = "DEL" & Replace(txtDeliveryID.Text, "/", "", 3) & "-" & result
    End Sub

    Private Sub AddInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        TabControl1.SelectedIndex = 1
        getInvoiceNo()
        getDelivery()
        txtStaffName.Text = moduleName
        txtEncoded.Text = Today
        txtUpdated.Text = Today
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "AddInvoice"
        SupplierList.Show()
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupplier.Text)
        If row.Count = 0 Then
            txtSupplierName.Text = ""
            Exit Sub
        End If
        txtSupplierName.Text = row.Item(0)
        txtCurrency.Text = row.Item(1)
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        If txtSupplier.Text = "" Then
            MsgBox("Choose Supplier First")
            Exit Sub
        End If
        SelectionItem.txtSupplier.Text = txtSupplier.Text
        formname = "AddInvoice"
        SelectionItem.Show()
    End Sub

    Private Sub btnPo_Click(sender As Object, e As EventArgs) Handles btnPo.Click
        formname = "AddInvoice"
        PurchaseOrderList.txtItems.Text = txtItemCode.Text
        PurchaseOrderList.txtSupplier.Text = txtSupplier.Text
        PurchaseOrderList.Show()
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemCode.Text)
        If row.Count = 0 Then
            txtItemName.Text = ""
            'txtCliUnit.Text = ""
            'txtSupUnit.Text = ""
            'coefficient = ""
            'txtUnit.Text = ""
            Exit Sub
        End If
        'dtPoDetails.SelectedRows(0).Cells(2).Value = row.Item(0)
        txtItemName.Text = row.Item(0)
        'txtCliUnit.Text = row.Item(1)
        'txtSupUnit.Text = row.Item(2)
        'coefficient = row.Item(3)
        'txtUnit.Text = Format(Val(row.Item(4)), "0.00")
    End Sub

    Private Sub dtPoDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableInvoice.CellClick
        If e.ColumnIndex = 3 Then
            If txtSupplier.Text = "" Then
                MsgBox("Choose Supplier First")
                Exit Sub
            End If
            SelectionItem.txtSupplier.Text = txtSupplier.Text
            formname = "AddInvoice"
            SelectionItem.Show()
            '1dtPoDetails.SelectedRows(0).Cells(2).Value = row.Item(0)
        End If
    End Sub

    Private Sub dtPoDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtableInvoice.CellFormatting
        ' dtableInvoice.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
        ' dtPoDetails.Rows(e.RowIndex).Cells(3).Value = "..."
    End Sub


    Private Sub dtPoDetails_TextChanged(sender As Object, e As EventArgs) Handles dtableInvoice.TextChanged
        MsgBox("hi")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InvoiceStoreData(btnSave.Text)
    End Sub
    Private Sub InvoiceStoreData(Query As String)
        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
        SQL.AddParams("@SupplierId", txtSupplier.Text)
        SQL.AddParams("@ReceivedDate", dtReceived.Value.ToShortDateString)
        SQL.AddParams("@Remarks", txtRemarks.Text)
        SQL.AddParams("@EncodedStaff", moduleId)
        SQL.AddParams("@InvoiceDate", DtInvoiceDate.Value.ToShortDateString)
        SQL.AddParams("@TotalAmount", txtTotalAmount.Text)
        SQL.AddParams("@ActualETDDate", dtActualETD.Value.ToShortDateString)
        SQL.AddParams("@UpdatedBy", moduleId)

        SQL.ExecQuery("INSERT INTO InvoiceHeaders
                (InvoiceNo,SupplierId,ReceivedDate,Remarks,EncodedStaff, InvoiceDate,ActualETDDate,UpdatedBy)
                VALUES(@InvoiceNo,@SupplierId,@ReceivedDate,@Remarks,
                @EncodedStaff, @InvoiceDate,@ActualETDDate,@UpdatedBy);")
        If SQL.HasException Then Exit Sub

        For i As Integer = 0 To dtableInvoice.Rows.Count - 1
            SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
            SQL.AddParams("@SupplierId", txtSupplier.Text)
            SQL.AddParams("@InvoiceDetailSeq", dtableInvoice.Rows(i).Cells(0).Value.ToString)
            SQL.AddParams("@ItemId", dtableInvoice.Rows(i).Cells(1).Value.ToString)
            SQL.AddParams("@PONo", dtableInvoice.Rows(i).Cells(3).Value.ToString)
            SQL.AddParams("@PODetailSeq", dtableInvoice.Rows(i).Cells(4).Value.ToString)
            SQL.AddParams("@Remarks", dtableInvoice.Rows(i).Cells(14).Value.ToString)
            SQL.AddParams("@DeliveryCompletedDate", dtDate.Value.ToShortDateString)
            SQL.AddParams("@Qty", dtableInvoice.Rows(i).Cells(5).Value.ToString)
            SQL.AddParams("@EquivalentQty", dtableInvoice.Rows(i).Cells(7).Value.ToString)
            SQL.AddParams("@UnitPrice", dtableInvoice.Rows(i).Cells(9).Value.ToString)
            SQL.AddParams("@UpdatedBy", moduleId)
            SQL.ExecQuery("INSERT INTO InvoiceDetails
                (InvoiceNo,SupplierId,InvoiceDetailSeq,ItemId,PONo,PODetailSeq,Remarks,DeliveryCompletedDate, Qty
                ,EquivalentQty,UnitPrice,UpdatedBy)
                VALUES(@InvoiceNo,@SupplierId,@InvoiceDetailSeq,@ItemId,@PONo,@PODetailSeq,@Remarks,@DeliveryCompletedDate,@Qty
                ,@EquivalentQty,@UnitPrice,@UpdatedBy)")
            If SQL.HasException Then
                SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                SQL.ExecQuery("DELETE FROM InvoiceHeaders WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDetails WHERE InvoiceNo=@InvoiceNo")
                Exit Sub
            End If
        Next
        For i As Integer = 0 To dtableDelivery.Rows.Count - 1
            SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
            SQL.AddParams("@SupplierId", txtSupplier.Text)
            SQL.AddParams("@InvoiceDetailSeq", dtableInvoice.Rows(i).Cells(0).Value.ToString)
            SQL.AddParams("@DeliveryId", txtDeliveryID.Text)
            SQL.AddParams("@DeliveryDate", dtDeliveryDate.Value.ToShortDateString)
            SQL.AddParams("@QtyExpected", dtableDelivery.Rows(i).Cells(3).Value.ToString)
            SQL.AddParams("@QtyReceived", dtableDelivery.Rows(i).Cells(6).Value.ToString)
            SQL.AddParams("@QtyOk", dtableDelivery.Rows(i).Cells(7).Value.ToString)
            SQL.AddParams("@UpdatedBy", moduleId)

            SQL.ExecQuery("INSERT INTO InvoiceDeliveryDetails
            (InvoiceNo,SupplierId,InvoiceDetailSeq,DeliveryId,DeliveryDate,QtyExpected,QtyReceived,QtyOk,UpdatedBy)
            VALUES(@InvoiceNo,@SupplierId,@InvoiceDetailSeq,@DeliveryId,@DeliveryDate,@QtyExpected,@QtyReceived,
            (select case when @QtyOk='' then 0 else @QtyOk end),@UpdatedBy)"
            )
            If SQL.HasException Then
                SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                SQL.ExecQuery("DELETE FROM InvoiceHeaders WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDetails WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDeliveryDetails WHERE InvoiceNo=@InvoiceNo")
                Exit Sub
            End If
            MsgBox("SUCCESSFULLY SAVED!", MsgBoxStyle.Information)
            Me.Close()
        Next
    End Sub

    Private Sub txtPoSeq_TextChanged(sender As Object, e As EventArgs) Handles txtPoSeq.TextChanged
        SQL.AddParams("@PoNo", txtPo.Text)
        SQL.AddParams("@PoDetailSeq", txtPoSeq.Text)
        SQL.ExecQuery("SELECT DISTINCT Qty,
                ( SELECT  q.QtyUnit FROM PoDetails p, QtyUnits q WHERE q.QtyUnitId=p.QtyUnit and p.PoNo=@PoNo AND p.PoDetailSeq=@PoDetailSeq) 'Client',
                EquivalentQty,( SELECT  q.QtyUnit FROM PoDetails p, QtyUnits q WHERE q.QtyUnitId=p.EquivalentQtyUnit and p.PoNo=@PoNo AND p.PoDetailSeq=@PoDetailSeq) 'Supplier',
                UnitPrice FROM PoDetails p ,QtyUnits q WHERE p.PoNo=@PoNo AND p.PoDetailSeq=@PoDetailSeq")
        If SQL.HasException Then Exit Sub
        If SQL.RecordCount = 0 Then Exit Sub
        txtCliQty.Text = SQL.DBDT.Rows(0).Item(0)
        txtCliUnit.Text = SQL.DBDT.Rows(0).Item(1)
        txtSupQty.Text = SQL.DBDT.Rows(0).Item(2)
        txtSupUnit.Text = SQL.DBDT.Rows(0).Item(3)
        txtUnit.Text = SQL.DBDT.Rows(0).Item(4)
        txtTotalPrice.Text = Val(txtUnit.Text) * Val(txtSupQty.Text)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim row As ArrayList = New ArrayList
        DTCount += 1
        txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + Val(txtTotalPrice.Text), "0.00")
        row.Add(DTCount)
        row.Add(txtItemCode.Text)
        row.Add(txtItemName.Text)
        row.Add(txtPo.Text)
        row.Add(txtPoSeq.Text)
        row.Add(txtCliQty.Text)
        row.Add(txtCliUnit.Text)
        row.Add(txtSupQty.Text)
        row.Add(txtSupUnit.Text)
        row.Add(txtUnit.Text)
        row.Add(txtTotalPrice.Text)
        row.Add(chkCancel.Checked)
        row.Add(chkReceived.Checked)
        row.Add(dtDate.Value)
        row.Add(txtInvoiceRemarks.Text)
        dtableInvoice.Rows.Add(row.ToArray())
        InvoicesClear()
    End Sub
    Private Sub InvoicesClear()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtPo.Clear()
        txtPoSeq.Clear()
        txtSupQty.Clear()
        txtSupUnit.Clear()
        txtCliQty.Clear()
        txtCliUnit.Clear()
        txtUnit.Clear()
        txtTotalPrice.Clear()
        dtDate.Value = Today
        txtInvoiceRemarks.Clear()
        chkCancel.Checked = False
        chkReceived.Checked = False
    End Sub

    Private Sub btnItemInv_Click(sender As Object, e As EventArgs) Handles btnItemInv.Click
        If txtSupplier.Text = "" Then
            MsgBox("Choose Supplier First")
            Exit Sub
        End If
        SelectionItem.txtSupplier.Text = txtSupplier.Text
        formname = "AddDelivery"
        SelectionItem.Show()
    End Sub

    Private Sub txtItemDel_TextChanged(sender As Object, e As EventArgs) Handles txtItemDel.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemDel.Text)
        If row.Count = 0 Then
            txtIteamNameDel.Text = ""
            'txtCliUnit.Text = ""
            'txtSupUnit.Text = ""
            'coefficient = ""
            'txtUnit.Text = ""
            Exit Sub
        End If
        'dtPoDetails.SelectedRows(0).Cells(2).Value = row.Item(0)
        txtIteamNameDel.Text = row.Item(0)
        'txtCliUnit.Text = row.Item(1)
        'txtSupUnit.Text = row.Item(2)
        'coefficient = row.Item(3)
        'txtUnit.Text = Format(Val(row.Item(4)), "0.00")
    End Sub

    Private Sub btnPOInv_Click(sender As Object, e As EventArgs) Handles btnPOInv.Click
        formname = "AddDelivery"
        PurchaseOrderList.txtItems.Text = txtItemDel.Text
        PurchaseOrderList.txtSupplier.Text = txtSupplier.Text
        PurchaseOrderList.Show()
    End Sub

    Private Sub txtRec_TextChanged(sender As Object, e As EventArgs) Handles txtRec.TextChanged
        txtBal.Text = Val(txtExp.Text) - Val(txtRec.Text)
    End Sub

    Private Sub btnInsertDel_Click(sender As Object, e As EventArgs) Handles btnInsertDel.Click
        Dim row As ArrayList = New ArrayList
        DTCount1 += 1
        'txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + Val(txtTotalPrice.Text), "0.00")
        row.Add(DTCount1)
        row.Add(txtItemDel.Text)
        row.Add(txtIteamNameDel.Text)
        row.Add(txtExp.Text)
        row.Add(txtPoDel.Text)
        row.Add(txtposeqdel.Text)
        row.Add(txtRec.Text)
        row.Add(txtqtyok.Text)
        row.Add(txtBal.Text)
        'row.Add(dtDeliveryDate.Value)
        dtableDelivery.Rows.Add(row.ToArray())
        InvoicesClear()
    End Sub
    Private Sub DeliveryClear()
        txtItemDel.Clear()
        txtIteamNameDel.Clear()
        txtExp.Clear()
        txtPoDel.Clear()
        txtposeqdel.Clear()
        txtRec.Clear()
        txtBal.Clear()
        dtDeliveryDate.Value = Today
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub


    'Private Sub dtPoDetails_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtPoDetails.CellValueChanged
    '    If e.ColumnIndex = 1 Then
    '        If dtPoDetails.SelectedRows.Count = 0 Then Exit Sub
    '        If dtPoDetails.SelectedRows(0).Cells(0).Value = "" Then Exit Sub
    '        Dim row As ArrayList = New ArrayList
    '        row = GetItemDetails(dtPoDetails.SelectedRows1(0).Cells(1).Value)
    '        If row.Count = 0 Then
    '            txtItemName.Text = ""
    '            txtCliUnit.Text = ""
    '            txtSupUnit.Text = ""
    '            coefficient = 0
    '            txtUnit.Text = ""
    '            Exit Sub
    '        End If
    '        dtPoDetails.SelectedRows(0).Cells(2).Value = row.Item(0)
    '        ' dtPoDetails.Rows.Add()
    '    End If
    'End Sub
End Class