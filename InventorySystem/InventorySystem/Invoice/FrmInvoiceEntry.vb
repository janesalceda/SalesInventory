Public Class FrmInvoiceEntry
    Public InvoiceSeq As Integer = 0
    Private DTCount1 As Integer = 0
    Public Sub getInvoiceNo()
        'SQL.ExecQuery("SELECT ih.InvoiceNo,ih.SupplierID,CurrencyUnit,ActualETDDate,InvoiceDate,ih.TotalAmount,
        '        ih.CreatedDate,ReceivedDate,ih.Remarks,e.EmployeeName,ih.UpdatedDate,id.InvoiceDetailSeq,
        '        id.ItemId,i.Description,id.PoNo,pod.PoDetailSeq,pod.Qty,
        '        (select dbo.getunit(pod.QtyUnit))'Cli',pod.EquivalentQty,
        '        (select dbo.getunit(pod.EquivalentQtyUnit)) 'Sup',
        '        pod.UnitPrice,(pod.UnitPrice*pod.EquivalentQty) AS 'Total Price',
        '        CASE WHEN QtyReceived>0 THEN 1 ELSE 0 end AS 'rec',
        '        CASE WHEN QtyOk>0 THEN 1 ELSE 0  end AS 'ok',
        '        DeliveryCompletedDate,id.Remarks,
        '        idd.DeliveryId,idd.DeliveryDate,idd.QtyExpected,QtyReceived,QtyOk,
        '        (QtyExpected-QtyOk) AS 'QtyBalance', ih.deleteddate
        '        FROM InvoiceHeaders	 ih 
        '        INNER	JOIN InvoiceDetails	id
        '        ON ih.InvoiceNo	=id.InvoiceNo	

        '        INNER JOIN POHeaders poh ON poh.PONo=id.PoNo
        '        INNER JOIN PoDetails pod ON id.PONo=pod.PoNo
        '        AND pod.PoDetailSeq	=id.PoDetailSeq	

        '        INNER JOIN CurrencyUnits c ON poh.CurrencyUnitId=c.CurrencyUnitId
        '        INNER JOIN InvoiceDeliveryDetails idd ON ih.Invoiceno=idd.InvoiceNo	 and idd.InvoiceDetailSeq=id.InvoiceDetailSeq
        '        INNER JOIN Employees e ON ih.EncodedStaff=e.EmpId
        '        INNER JOIN Items i ON i.ItemId=id.ItemId	

        '        where ih.InvoiceNo=@InvoiceNo order by id.InvoiceDetailSeq")

        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
        SQL.ExecQuery("SELECT InvoiceNo,SupplierId,ActualETDDate,InvoiceDate,TotalAmount,CreatedDate
	                ,ReceivedDate,Remarks,EncodedStaff,
	                (SELECT e.EmployeeName from Employees e WHERE e.empId=ih.UpdatedBy),ih.deleteddate
	                FROM InvoiceHeaders ih where ih.InvoiceNo=@InvoiceNo")
        If SQL.HasException Then Exit Sub
        Dim row As New DataTable
        row = SQL.DBDT

        txtSupplier.Text = row.Rows(0).Item(1).ToString
        dtActualETD.Value = row.Rows(0).Item(2).ToString
        DtInvoiceDate.Value = row.Rows(0).Item(3).ToString
        txtTotalAmount.Text = row.Rows(0).Item(4).ToString
        txtEncoded.Text = row.Rows(0).Item(5).ToString
        dtReceived.Value = row.Rows(0).Item(6).ToString
        txtRemarks.Text = row.Rows(0).Item(7).ToString
        txtStaffName.Text = row.Rows(0).Item(8).ToString
        txtUpdated.Text = row.Rows(0).Item(9).ToString
        If String.IsNullOrEmpty(row.Rows(0).Item(10).ToString) Then
            chkcancelPO.Checked = False
        Else
            chkcancelPO.Checked = True
        End If

        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
        SQL.ExecQuery("SELECT InvoiceDetailSeq,id.ItemId,i.Description,id.PoNo	,
                id.PoDetailSeq,id.Qty,
                (select dbo.getunit(pod.QtyUnit))'Cli',
                id.EquivalentQty,
                (select dbo.getunit(pod.EquivalentQtyUnit))'Sup',
                id.UnitPrice,(id.UnitPrice*id.EquivalentQty)'TotalPrice',
                id.DeliveryCompletedDate,id.Remarks
                FROM InvoiceDetails id
                INNER JOIN Items i ON id.ItemId	=i.ItemId	
                INNER JOIN POHeaders poh ON poh.PONo=id.PoNo
                INNER JOIN PoDetails pod ON id.PONo=pod.PoNo
                where  id.InvoiceNo=@InvoiceNo")
        If SQL.HasException Then Exit Sub

        row = SQL.DBDT
        For i As Integer = 0 To row.Rows.Count - 1
            dtableInvoice.Rows.Add(
            row.Rows(i).Item(0).ToString,
            row.Rows(i).Item(1).ToString,
            row.Rows(i).Item(2).ToString,
            row.Rows(i).Item(3).ToString,
            row.Rows(i).Item(4).ToString,
            row.Rows(i).Item(5).ToString,
            row.Rows(i).Item(6).ToString,
            row.Rows(i).Item(7).ToString,
            row.Rows(i).Item(8).ToString,
            row.Rows(i).Item(9).ToString,
            row.Rows(i).Item(10).ToString,
            0,
            0,
            row.Rows(i).Item(11).ToString,
            row.Rows(i).Item(12).ToString, "NO")
        Next

        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
        SQL.ExecQuery("SELECT id.InvoiceDetailSeq,DeliveryId,DeliveryDate,idd.ItemId,
	                i.Description,QtyExpected,idd.PoNo,idd.PoDetailSeq	,QtyReceived,QtyOk,
	                (QtyExpected-QtyOk)'QtyBalance'
	                FROM  InvoiceDeliveryDetails id
	                INNER JOIN InvoiceDetails idd ON idd.InvoiceDetailSeq=id.InvoiceDetailSeq
	                INNER JOIN Items i ON idd.ItemId	=i.ItemId	
	                INNER JOIN POHeaders poh ON poh.PONo=idd.PoNo
	                INNER JOIN PoDetails pod ON idd.PONo=pod.PoNo
	                where id.InvoiceNo=@InvoiceNo")
        If SQL.HasException Then Exit Sub
        row = SQL.DBDT
        For i As Integer = 0 To row.Rows.Count - 1
            dtableDelivery.Rows.Add(row.Rows(i).Item(0).ToString,
            row.Rows(i).Item(1).ToString,
            row.Rows(i).Item(2).ToString,
            row.Rows(i).Item(3).ToString,
            row.Rows(i).Item(4).ToString,
            row.Rows(i).Item(5).ToString,
            row.Rows(i).Item(6).ToString,
            row.Rows(i).Item(7).ToString,
            row.Rows(i).Item(8).ToString,
            row.Rows(i).Item(9).ToString,
            row.Rows(i).Item(10).ToString, "NO")
        Next
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
            result = result.Substring(8, 2)
            result = Format(Val(result + 1), "000")
        End If

        txtDeliveryID.Text = System.DateTime.Today
        txtDeliveryID.Text = "DEL" & Replace(txtDeliveryID.Text, "/", "", 3) & "-" & result
    End Sub

    Private Sub AddInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        TabControl1.SelectedIndex = 1
        getDelivery()
        txtStaffName.Text = moduleName
        If Not String.IsNullOrEmpty(txtInvoiceNo.Text) Then
            getInvoiceNo()
        Else
            txtEncoded.Text = Today
            txtUpdated.Text = Today
        End If
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "AddInvoice"
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
            coefficient = 0.0
            Exit Sub
        End If
        txtItemName.Text = row.Item(0)

        coefficient = row.Item(3)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtSupplier.Text) Or
                dtableDelivery.Rows.Count = 0 Or
                dtableInvoice.Rows.Count = 0 Then
            MsgBox("PLEASE COMPLETE ALL *IMPORTANT FIELDS!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If MsgBox("Are sure you want to save?", vbYesNo, "Information") = vbYes Then InvoiceStoreData(btnSave.Text)
    End Sub
    Private Sub InvoiceStoreData(Query As String)
        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
        SQL.AddParams("@SupplierId", txtSupplier.Text)
        SQL.AddParams("@ReceivedDate", dtReceived.Value)
        SQL.AddParams("@Remarks", txtRemarks.Text)
        SQL.AddParams("@EncodedStaff", moduleId)
        SQL.AddParams("@InvoiceDate", DtInvoiceDate.Value)
        SQL.AddParams("@TotalAmount", txtTotalAmount.Text)
        SQL.AddParams("@ActualETDDate", dtActualETD.Value)
        SQL.AddParams("@UpdatedBy", moduleId)
        If btnSave.Text = "SAVE INVOICE" Then
            SQL.ExecQuery("INSERT INTO InvoiceHeaders
                (InvoiceNo,
                SupplierId,
                ReceivedDate,
                Remarks,
                EncodedStaff,
                TotalAmount,
                InvoiceDate,
                ActualETDDate,
                UpdatedBy)
            VALUES(
                @InvoiceNo,
                @SupplierId,
                @ReceivedDate,
                @Remarks,
                @EncodedStaff, 
                @TotalAmount,
                @InvoiceDate,
                @ActualETDDate,
                @UpdatedBy);")
            If SQL.HasException Then Exit Sub
            For i As Integer = 0 To dtableInvoice.Rows.Count - 1
                SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                SQL.AddParams("@SupplierId", txtSupplier.Text)
                SQL.AddParams("@InvoiceDetailSeq", dtableInvoice.Rows(i).Cells(0).Value.ToString)
                SQL.AddParams("@ItemId", dtableInvoice.Rows(i).Cells(1).Value.ToString)
                SQL.AddParams("@PONo", dtableInvoice.Rows(i).Cells(3).Value.ToString)
                SQL.AddParams("@PODetailSeq", dtableInvoice.Rows(i).Cells(4).Value.ToString)
                SQL.AddParams("@Remarks", dtableInvoice.Rows(i).Cells(14).Value.ToString)
                SQL.AddParams("@DeliveryCompletedDate", Convert.ToDateTime(dtableInvoice.Rows(i).Cells(13).Value.ToString()))
                SQL.AddParams("@Qty", dtableInvoice.Rows(i).Cells(5).Value.ToString)
                SQL.AddParams("@EquivalentQty", dtableInvoice.Rows(i).Cells(7).Value.ToString)
                SQL.AddParams("@UnitPrice", dtableInvoice.Rows(i).Cells(9).Value.ToString)
                SQL.AddParams("@UpdatedBy", moduleId)
                SQL.ExecQuery("INSERT INTO InvoiceDetails
                (InvoiceNo,
                SupplierId,
                InvoiceDetailSeq,
                ItemId,
                PONo,
                PODetailSeq,
                Remarks,
                DeliveryCompletedDate,
                Qty,
                EquivalentQty,
                UnitPrice,
                UpdatedBy)
            VALUES(@InvoiceNo,
                @SupplierId,
                @InvoiceDetailSeq,
                @ItemId,
                @PONo,
                @PODetailSeq,
                @Remarks,
                @DeliveryCompletedDate,
                @Qty,
                @EquivalentQty,
                @UnitPrice,
                @UpdatedBy)")
                If SQL.HasException Then
                    SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                    SQL.ExecQuery("DELETE FROM InvoiceHeaders WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDetails WHERE InvoiceNo=@InvoiceNo")
                    Exit Sub
                End If
            Next
            For i As Integer = 0 To dtableDelivery.Rows.Count - 1
                SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                SQL.AddParams("@SupplierId", txtSupplier.Text)
                SQL.AddParams("@InvoiceDetailSeq", dtableDelivery.Rows(i).Cells(0).Value)
                SQL.AddParams("@DeliveryId", txtDeliveryID.Text)
                SQL.AddParams("@DeliveryDate", Convert.ToDateTime(dtableDelivery.Rows(i).Cells(2).Value.ToString()))
                SQL.AddParams("@QtyExpected", dtableDelivery.Rows(i).Cells(5).Value)
                SQL.AddParams("@QtyReceived", dtableDelivery.Rows(i).Cells(8).Value)
                SQL.AddParams("@QtyOk", dtableDelivery.Rows(i).Cells(9).Value)
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

            Next

            MsgBox("SUCCESSFULLY SAVED!", MsgBoxStyle.Information)

            Me.Close()

        Else
            SQL.AddParams("@deleteddate", chkcancelPO.Checked)
            SQL.ExecQuery("UPDATE dbo.InvoiceHeaders
                SET 
	                SupplierId = @supplierid,
	                ReceivedDate = @receiveddate,
	                Remarks = @remarks,
	                TotalAmount = @totalamount,
	                InvoiceDate = @invoicedate,
	                ActualETDDate = @actualetddate,
	                DeletedDate = (select case when @deleteddate=1 then getdate() else NULL end),
	                UpdatedDate = getdate(),
	                UpdatedBy = @updatedby
	                WHERE InvoiceNo = @invoiceno")
            If SQL.HasException Then Exit Sub

            For i As Integer = 0 To dtableInvoice.Rows.Count - 1
                SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                SQL.AddParams("@SupplierId", txtSupplier.Text)
                SQL.AddParams("@InvoiceDetailSeq", dtableInvoice.Rows(i).Cells(0).Value.ToString)
                SQL.AddParams("@ItemId", dtableInvoice.Rows(i).Cells(1).Value.ToString)
                SQL.AddParams("@PONo", dtableInvoice.Rows(i).Cells(3).Value.ToString)
                SQL.AddParams("@PODetailSeq", dtableInvoice.Rows(i).Cells(4).Value.ToString)
                SQL.AddParams("@Remarks", dtableInvoice.Rows(i).Cells(14).Value.ToString)
                SQL.AddParams("@DeliveryCompletedDate", Convert.ToDateTime(dtableInvoice.Rows(i).Cells(13).Value.ToString()))
                SQL.AddParams("@Qty", dtableInvoice.Rows(i).Cells(5).Value.ToString)
                SQL.AddParams("@EquivalentQty", dtableInvoice.Rows(i).Cells(7).Value.ToString)
                SQL.AddParams("@UnitPrice", dtableInvoice.Rows(i).Cells(9).Value.ToString)
                SQL.AddParams("@UpdatedBy", moduleId)
                SQL.AddParams("@deleteddate", chkcancelPO.Checked)
                If Not String.IsNullOrWhiteSpace(dtableInvoice.Rows(i).Cells(15).Value.ToString) Then
                    SQL.ExecQuery("UPDATE dbo.InvoiceDetails
                SET 
	                SupplierId = @supplierid,
	                ItemId = @itemid,
	                PoNo = @pono,
	                PoDetailSeq = @podetailseq,
	                Remarks = @remarks,
	                DeliveryCompletedDate = @deliverycompleteddate,
	                Qty = @qty,
	                EquivalentQty = @equivalentqty,
	                UnitPrice = @unitprice,
	                DeletedDate =(select case when @deleteddate=1 then getdate() else NULL end),
	                UpdatedDate = getdate(),
	                UpdatedBy = @updatedby
	                WHERE InvoiceNo = @invoiceno AND InvoiceDetailSeq = @invoicedetailseq")
                    If SQL.HasException Then
                        MsgBox("Error in Updating Data!", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                Else
                    SQL.ExecQuery("INSERT INTO InvoiceDetails
                        (InvoiceNo,
                        SupplierId,
                        InvoiceDetailSeq,
                        ItemId,
                        PONo,
                        PODetailSeq,
                        Remarks,
                        DeliveryCompletedDate,
                        Qty,
                        EquivalentQty,
                        UnitPrice,
                        UpdatedBy)
                    VALUES(@InvoiceNo,
                        @SupplierId,
                        @InvoiceDetailSeq,
                        @ItemId,
                        @PONo,
                        @PODetailSeq,
                        @Remarks,
                        @DeliveryCompletedDate,
                        @Qty,
                        @EquivalentQty,
                        @UnitPrice,
                        @UpdatedBy)")
                    If SQL.HasException Then
                        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                        SQL.ExecQuery("DELETE FROM InvoiceHeaders WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDetails WHERE InvoiceNo=@InvoiceNo")
                        Exit Sub
                    End If
                End If
            Next

            For i As Integer = 0 To dtableDelivery.Rows.Count - 1
                SQL.AddParams("@deleteddate", chkcancelPO.Checked)
                SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                SQL.AddParams("@SupplierId", txtSupplier.Text)
                SQL.AddParams("@InvoiceDetailSeq", dtableDelivery.Rows(i).Cells(0).Value.ToString)
                SQL.AddParams("@DeliveryId", dtableDelivery.Rows(i).Cells(1).Value.ToString)
                SQL.AddParams("@DeliveryDate", Convert.ToDateTime(dtableDelivery.Rows(i).Cells(2).Value.ToString()))
                SQL.AddParams("@QtyExpected", dtableDelivery.Rows(i).Cells(5).Value.ToString)
                SQL.AddParams("@QtyReceived", dtableDelivery.Rows(i).Cells(8).Value.ToString)
                SQL.AddParams("@QtyOk", dtableDelivery.Rows(i).Cells(9).Value.ToString)
                SQL.AddParams("@UpdatedBy", moduleId)

                If Not String.IsNullOrWhiteSpace(dtableDelivery.Rows(i).Cells(11).Value.ToString) Then
                    SQL.ExecQuery("UPDATE dbo.InvoiceDeliveryDetails

                SET 
	                SupplierId = @supplierid,
	                InvoiceDetailSeq = @invoicedetailseq,	
	                DeliveryDate = @deliverydate,
	                QtyExpected = @qtyexpected,
	                QtyReceived = @qtyreceived,
	                QtyOk = @qtyok,
	                UpdatedDate = getdate(),
	                DeletedDate = (select case when @deleteddate=1 then getdate() else NULL end),
	                UpdatedBy = @updatedby
	                WHERE InvoiceNo = @invoiceno AND InvoiceDetailSeq = @invoicedetailseq 
	                AND DeliveryId = @deliveryid")
                    If SQL.HasException Then Exit Sub
                Else
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
                End If

            Next
            MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
            Me.Close()
        End If
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
        txtCliUnit.Text = SQL.DBDT.Rows(0).Item(1)
        txtSupUnit.Text = SQL.DBDT.Rows(0).Item(3)
        txtUnit.Text = SQL.DBDT.Rows(0).Item(4)
        txtTotalPrice.Text = Val(txtUnit.Text) * Val(txtSupQty.Text)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If String.IsNullOrEmpty(txtItemCode.Text) Or String.IsNullOrEmpty(txtPo.Text) Or
        String.IsNullOrEmpty(txtCliQty.Text) Or String.IsNullOrEmpty(txtSupQty.Text) Then
            MsgBox("PLEASE COMPLETE ALL *IMPORTANT FIELDS!", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        If btnAddItem.Text = "INSERT INVOICE" Then
            Dim row As ArrayList = New ArrayList
            txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + Val(txtTotalPrice.Text), "0.00")
            row.Add(dtableInvoice.Rows.Count + 1)
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
            row.Add("")
            dtableInvoice.Rows.Add(row.ToArray())
            InvoicesClear()

        Else
            dtableInvoice.SelectedRows(0).Cells(1).Value = txtItemCode.Text
            dtableInvoice.SelectedRows(0).Cells(2).Value = txtItemName.Text
            dtableInvoice.SelectedRows(0).Cells(3).Value = txtPo.Text
            dtableInvoice.SelectedRows(0).Cells(4).Value = txtPoSeq.Text
            dtableInvoice.SelectedRows(0).Cells(5).Value = txtCliQty.Text
            dtableInvoice.SelectedRows(0).Cells(6).Value = txtCliUnit.Text
            dtableInvoice.SelectedRows(0).Cells(7).Value = txtSupQty.Text
            dtableInvoice.SelectedRows(0).Cells(8).Value = txtSupUnit.Text
            dtableInvoice.SelectedRows(0).Cells(9).Value = txtUnit.Text
            dtableInvoice.SelectedRows(0).Cells(10).Value = txtTotalPrice.Text
            dtableInvoice.SelectedRows(0).Cells(11).Value = chkCancel.Checked
            dtableInvoice.SelectedRows(0).Cells(12).Value = chkReceived.Checked
            dtableInvoice.SelectedRows(0).Cells(13).Value = dtDate.Value
            dtableInvoice.SelectedRows(0).Cells(14).Value = txtInvoiceRemarks.Text
            btnAddItem.Text = "INSERT INVOICE"
            InvoicesClear()
        End If
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
        dtDate.Checked = False
    End Sub

    Private Sub btnItemInv_Click(sender As Object, e As EventArgs) Handles btnItemInv.Click
        'If txtSupplier.Text = "" Then
        '    MsgBox("Choose Supplier First")
        '    Exit Sub
        'End If
        'SelectionItem.txtSupplier.Text = txtSupplier.Text
        'formname = "AddDelivery"
        'SelectionItem.ShowDialog()
        FrmInvoiceSelection.ShowDialog()
    End Sub

    Private Sub txtItemDel_TextChanged(sender As Object, e As EventArgs) Handles txtItemDel.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemDel.Text)
        If row.Count = 0 Then
            txtIteamNameDel.Text = ""
            coefficient = 0.0
            Exit Sub
        End If
        txtIteamNameDel.Text = row.Item(0)
        coefficient = row.Item(3)
    End Sub

    Private Sub btnPOInv_Click(sender As Object, e As EventArgs)
        formname = "AddDelivery"
        PurchaseOrderList.txtItems.Text = txtItemDel.Text
        PurchaseOrderList.txtSupplier.Text = txtSupplier.Text
        PurchaseOrderList.ShowDialog()
    End Sub


    Private Sub btnInsertDel_Click(sender As Object, e As EventArgs) Handles btnInsertDel.Click
        If String.IsNullOrEmpty(txtItemDel.Text) Or String.IsNullOrEmpty(txtPoDel.Text) Then
            MsgBox("PLEASE COMPLETE ALL *IMPORTANT FIELDS!", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        If btnInsertDel.Text = "INSERT DELIVERY" Then
            Dim row As ArrayList = New ArrayList
            'txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + Val(txtTotalPrice.Text), "0.00")
            row.Add(InvoiceSeq)
            row.Add(txtDeliveryID.Text)
            row.Add(dtDeliveryDate.Value)
            row.Add(txtItemDel.Text)
            row.Add(txtIteamNameDel.Text)
            row.Add(txtExp.Text)
            row.Add(txtPoDel.Text)
            row.Add(txtposeqdel.Text)
            row.Add(txtRec.Text)
            row.Add(txtqtyok.Text)
            row.Add(txtBal.Text)
            row.Add("")
            'row.Add(dtDeliveryDate.Value)
            dtableDelivery.Rows.Add(row.ToArray())
            DeliveryClear()
        Else
            dtableDelivery.SelectedRows(0).Cells(1).Value = txtDeliveryID.Text
            dtableDelivery.SelectedRows(0).Cells(2).Value = dtDeliveryDate.Value
            dtableDelivery.SelectedRows(0).Cells(3).Value = txtItemDel.Text
            dtableDelivery.SelectedRows(0).Cells(4).Value = txtIteamNameDel.Text
            dtableDelivery.SelectedRows(0).Cells(5).Value = txtExp.Text
            dtableDelivery.SelectedRows(0).Cells(6).Value = txtPoDel.Text
            dtableDelivery.SelectedRows(0).Cells(7).Value = txtposeqdel.Text
            dtableDelivery.SelectedRows(0).Cells(8).Value = txtRec.Text
            dtableDelivery.SelectedRows(0).Cells(9).Value = txtqtyok.Text
            dtableDelivery.SelectedRows(0).Cells(10).Value = txtBal.Text
            btnInsertDel.Text = "INSERT DELIVERY"
            DeliveryClear()
        End If
    End Sub
    Private Sub DeliveryClear()
        txtItemDel.Clear()
        txtIteamNameDel.Clear()
        txtExp.Clear()
        txtPoDel.Clear()
        txtposeqdel.Clear()
        txtRec.Clear()
        txtBal.Clear()
        txtqtyok.Clear()
        btnInsertDel.Text = "INSERT DELIVERY"
    End Sub


    Private Sub txtRec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRec.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub


    Private Sub txtqtyok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqtyok.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub

    Private Sub dtableDelivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableDelivery.CellClick
        txtDeliveryID.Text = dtableDelivery.SelectedRows(0).Cells(1).Value.ToString()
        dtDeliveryDate.Value = Convert.ToDateTime(dtableDelivery.SelectedRows(0).Cells(2).Value.ToString())
        txtItemDel.Text = dtableDelivery.SelectedRows(0).Cells(3).Value.ToString()
        txtIteamNameDel.Text = dtableDelivery.SelectedRows(0).Cells(4).Value.ToString()
        txtExp.Text = dtableDelivery.SelectedRows(0).Cells(5).Value.ToString()
        txtPoDel.Text = dtableDelivery.SelectedRows(0).Cells(6).Value.ToString()
        txtposeqdel.Text = dtableDelivery.SelectedRows(0).Cells(7).Value.ToString()
        txtRec.Text = dtableDelivery.SelectedRows(0).Cells(8).Value.ToString()
        txtqtyok.Text = dtableDelivery.SelectedRows(0).Cells(9).Value.ToString()
        txtBal.Text = dtableDelivery.SelectedRows(0).Cells(10).Value.ToString()
        btnInsertDel.Text = "UPDATE DELIVERY"
    End Sub

    Private Sub dtableInvoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableInvoice.CellClick
        txtItemCode.Text = dtableInvoice.SelectedRows(0).Cells(1).Value.ToString()
        txtItemName.Text = dtableInvoice.SelectedRows(0).Cells(2).Value.ToString()
        txtPo.Text = dtableInvoice.SelectedRows(0).Cells(3).Value.ToString()
        txtPoSeq.Text = dtableInvoice.SelectedRows(0).Cells(4).Value.ToString()
        txtCliQty.Text = dtableInvoice.SelectedRows(0).Cells(5).Value.ToString()
        txtCliUnit.Text = dtableInvoice.SelectedRows(0).Cells(6).Value.ToString()
        txtSupQty.Text = dtableInvoice.SelectedRows(0).Cells(7).Value.ToString()
        txtSupUnit.Text = dtableInvoice.SelectedRows(0).Cells(8).Value.ToString()
        txtUnit.Text = dtableInvoice.SelectedRows(0).Cells(9).Value.ToString()
        txtTotalPrice.Text = dtableInvoice.SelectedRows(0).Cells(10).Value.ToString()
        dtDate.Value = Convert.ToDateTime(dtableInvoice.SelectedRows(0).Cells(13).Value.ToString())
        txtInvoiceRemarks.Text = dtableInvoice.SelectedRows(0).Cells(14).Value.ToString()
        chkReceived.Checked = dtableInvoice.SelectedRows(0).Cells(11).Value.ToString()
        chkCancel.Checked = dtableInvoice.SelectedRows(0).Cells(12).Value.ToString()
        btnAddItem.Text = "UPDATE INVOICE"
    End Sub

    Private Sub txtqtyok_TextChanged(sender As Object, e As EventArgs) Handles txtqtyok.TextChanged
        txtBal.Text = Val(txtExp.Text) - Val(txtqtyok.Text)
    End Sub

    'Private Sub dtableDelivery_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtableDelivery.CellFormatting
    '    dtableDelivery.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    'End Sub

    Private Sub txtCliQty_LostFocus(sender As Object, e As EventArgs) Handles txtCliQty.LostFocus
        txtSupQty.Text = Val(txtCliQty.Text) * coefficient
        txtTotalPrice.Text = Format(Val(txtSupQty.Text) * Val(txtUnit.Text), "0.00")
    End Sub

    Private Sub txtSupQty_LostFocus(sender As Object, e As EventArgs) Handles txtSupQty.LostFocus
        txtCliQty.Text = Val(txtSupQty.Text) / coefficient
        txtTotalPrice.Text = Format(Val(txtSupQty.Text) * Val(txtUnit.Text), "0.00")
    End Sub

    Private Sub dtableDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableDelivery.CellContentClick

    End Sub

    Private Sub txtRec_TextChanged(sender As Object, e As EventArgs) Handles txtRec.TextChanged

    End Sub

    Private Sub txtCliQty_TextChanged(sender As Object, e As EventArgs) Handles txtCliQty.TextChanged

    End Sub

    Private Sub txtCliQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub


    Private Sub txtSupQty_TextChanged(sender As Object, e As EventArgs) Handles txtSupQty.TextChanged

    End Sub

    Private Sub txtSupQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub

    Private Sub btndelclear_Click(sender As Object, e As EventArgs) Handles btndelclear.Click
        DeliveryClear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        InvoicesClear()
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