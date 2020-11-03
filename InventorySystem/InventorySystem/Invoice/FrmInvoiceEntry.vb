Public Class FrmInvoiceEntry
    Public InvoiceSeq As Integer = 0
    Private DTCount1 As Integer = 0
    Private ClientPrice As Decimal = 0.00
    Public Sub getInvoiceNo()
        Try
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
                id.SupplierUnitPrice,(id.SupplierUnitPrice*id.EquivalentQty)'TotalPrice',
                id.DeliveryCompletedDate,id.Remarks,id.ClientUnitPrice,Received,OK
                FROM InvoiceDetails id
                INNER JOIN Items i ON id.ItemId	=i.ItemId	
                INNER JOIN POHeaders poh ON poh.PONo=id.PoNo
                INNER JOIN PoDetails pod ON id.PONo=pod.PoNo AND id.PoDetailSeq	=pod.PoDetailSeq
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
                row.Rows(i).Item(14).ToString,
                row.Rows(i).Item(15).ToString,
                row.Rows(i).Item(11).ToString,
                row.Rows(i).Item(12).ToString, "NO", row.Rows(i).Item(13).ToString)
            Next

            SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
            SQL.ExecQuery("SELECT id.InvoiceDetailSeq,DeliveryId,DeliveryDate,idd.ItemId,
	                i.Description,QtyExpected,idd.PoNo,idd.PoDetailSeq	,QtyReceived,QtyOk,
	                (QtyExpected-QtyOk)'QtyBalance'
	                FROM  InvoiceDeliveryDetails id
	                INNER JOIN InvoiceDetails idd ON idd.InvoiceDetailSeq=id.InvoiceDetailSeq
                    and idd.InvoiceNo=id.InvoiceNo
	                INNER JOIN Items i ON idd.ItemId=i.ItemId	
	                INNER JOIN POHeaders poh ON poh.PONo=idd.PoNo
	                INNER JOIN PoDetails pod ON idd.PONo=pod.PoNo AND idd.PoDetailSeq=pod.PoDetailSeq
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
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
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
        If Application.OpenForms().OfType(Of SupplierList).Any Then SupplierList.Close()

        If dtableInvoice.Rows.Count > 0 Or dtableDelivery.Rows.Count > 0 Then
            msgboxDisplay("Cannot modify already have Invoice Details!", 2)
            Exit Sub
        End If
        formname = "AddInvoice"
        SupplierList.Show()
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        If dtableInvoice.Rows.Count > 0 Or dtableDelivery.Rows.Count > 0 Then
            msgboxDisplay("Cannot modify already have Invoice Details!", 2)
            Exit Sub
        End If
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
        If Application.OpenForms().OfType(Of SelectionItem).Any Then SelectionItem.Close()
        If txtSupplier.Text = "" Then
            MsgBox("Choose Supplier First", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If dtableInvoice.Rows.Count > 0 Then
            If btnAddItem.Text = "UPDATE INVOICE" And
                    dtableInvoice.SelectedRows(0).Cells(11).Value = True Or
                    dtableInvoice.SelectedRows(0).Cells(12).Value = True Then
                MsgBox("Cannot modify already a received", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
        End If
        SelectionItem.txtSupplier.Text = txtSupplier.Text
        formname = "AddInvoice"
        SelectionItem.Show()
    End Sub

    Private Sub btnPo_Click(sender As Object, e As EventArgs) Handles btnPo.Click
        If Application.OpenForms().OfType(Of PurchaseOrderList).Any Then PurchaseOrderList.Close()
        If dtableDelivery.Rows.Count > 0 Then
            If dtableInvoice.SelectedRows(0).Cells(11).Value = True And dtableInvoice.SelectedRows(0).Cells(12).Value = True Then
                msgboxDisplay("Cannot modify already received!", 2)
                Exit Sub
            End If
        End If
        formname = "AddInvoice"
        PurchaseOrderList.txtItems.Text = txtItemCode.Text
        PurchaseOrderList.txtSupplier.Text = txtSupplier.Text
        PurchaseOrderList.Show()
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        If dtableInvoice.Rows.Count > 0 Then
            If dtableInvoice.SelectedRows(0).Cells(11).Value = True And
                dtableInvoice.SelectedRows(0).Cells(12).Value = True And
                Not String.IsNullOrWhiteSpace(txtItemCode.Text) Then
                msgboxDisplay("Cannot modify already received!", 2)
                Exit Sub
            End If
        End If
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
        Try
            Dim strcomplete As String = "Please complete the ff:" & vbNewLine
            If String.IsNullOrEmpty(txtSupplier.Text) Then
                strcomplete += "*Supplier" & vbNewLine
            End If
            If String.IsNullOrEmpty(txtInvoiceNo.Text) Then
                strcomplete += "*Invoice No" & vbNewLine
            End If
            If dtableDelivery.Rows.Count = 0 Then
                strcomplete += "*Delivery Details" & vbNewLine
            End If
            If dtableInvoice.Rows.Count = 0 Then
                strcomplete += "*Invoice Details" & vbNewLine
            End If
            If strcomplete <> "Please complete the ff:" & vbNewLine Then
                msgboxDisplay(strcomplete, 2)
                Exit Sub
            End If
            If MsgBox("Are sure you want to save?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then InvoiceStoreData(btnSave.Text)
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub InvoiceStoreData(Query As String)
        Try
            SQL.params.Clear()

            SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
            SQL.ExecQuery("Select * from InvoiceHeaders where InvoiceNo=@InvoiceNo")
            If SQL.DBDT.Rows.Count > 0 Then
                msgboxDisplay("Invoice already exists!", 3)
                Exit Sub
            End If
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
                btnSave.Text = "Please wait ..."
                btnSave.Enabled = False
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
                If SQL.HasException Then
                    btnSave.Enabled = True
                    btnSave.Text = "SAVE INVOICE"
                    msgboxDisplay("Error in saving", 3)
                    Exit Sub
                End If
                For i As Integer = 0 To dtableInvoice.Rows.Count - 1
                    SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                    SQL.AddParams("@SupplierId", txtSupplier.Text)
                    SQL.AddParams("@InvoiceDetailSeq", dtableInvoice.Rows(i).Cells(0).Value.ToString)
                    SQL.AddParams("@ItemId", dtableInvoice.Rows(i).Cells(1).Value.ToString)
                    SQL.AddParams("@PONo", dtableInvoice.Rows(i).Cells(3).Value.ToString)
                    SQL.AddParams("@PODetailSeq", dtableInvoice.Rows(i).Cells(4).Value.ToString)
                    SQL.AddParams("@Qty", dtableInvoice.Rows(i).Cells(5).Value.ToString)
                    SQL.AddParams("@EquivalentQty", dtableInvoice.Rows(i).Cells(7).Value.ToString)
                    SQL.AddParams("@SupplierUnitPrice", dtableInvoice.Rows(i).Cells(9).Value.ToString)
                    SQL.AddParams("@Received", dtableInvoice.Rows(i).Cells(11).Value)
                    SQL.AddParams("@OK", dtableInvoice.Rows(i).Cells(12).Value)
                    SQL.AddParams("@DeliveryCompletedDate", Convert.ToDateTime(dtableInvoice.Rows(i).Cells(13).Value.ToString()))
                    SQL.AddParams("@Remarks", dtableInvoice.Rows(i).Cells(14).Value.ToString)
                    SQL.AddParams("@ClientUnitPrice", dtableInvoice.Rows(i).Cells(16).Value.ToString)
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
                SupplierUnitPrice,
                ClientUnitPrice,
                OK,
                Received,
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
                @SupplierUnitPrice,
                @ClientUnitPrice,
                @Received,
                @OK,
                @UpdatedBy)")
                    If SQL.HasException Then
                        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                        SQL.ExecQuery("DELETE FROM InvoiceHeaders WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDetails WHERE InvoiceNo=@InvoiceNo")
                        btnSave.Enabled = True
                        btnSave.Text = "SAVE INVOICE"
                        msgboxDisplay("Error in saving", 3)
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
                    (select case when @QtyOk='' then '0.0' else @QtyOk end),@UpdatedBy)"
                    )
                    If SQL.HasException Then
                        SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                        SQL.ExecQuery("DELETE FROM InvoiceHeaders WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDetails WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDeliveryDetails WHERE InvoiceNo=@InvoiceNo")
                        btnSave.Enabled = True
                        btnSave.Text = "SAVE INVOICE"
                        msgboxDisplay("Error in saving", 3)
                        Exit Sub
                    End If

                Next

            Else
                btnSave.Text = "Please wait ..."
                btnSave.Enabled = False
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
                If SQL.HasException Then
                    btnSave.Enabled = True
                    btnSave.Text = "SAVE INVOICE"
                    msgboxDisplay("Error in saving", 3)
                    Exit Sub
                End If

                For i As Integer = 0 To dtableInvoice.Rows.Count - 1
                    SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                    SQL.AddParams("@SupplierId", txtSupplier.Text)
                    SQL.AddParams("@InvoiceDetailSeq", dtableInvoice.Rows(i).Cells(0).Value)
                    SQL.AddParams("@ItemId", dtableInvoice.Rows(i).Cells(1).Value.ToString)
                    SQL.AddParams("@PONo", dtableInvoice.Rows(i).Cells(3).Value.ToString)
                    SQL.AddParams("@PODetailSeq", dtableInvoice.Rows(i).Cells(4).Value)
                    SQL.AddParams("@Remarks", dtableInvoice.Rows(i).Cells(14).Value.ToString)
                    SQL.AddParams("@DeliveryCompletedDate", Convert.ToDateTime(dtableInvoice.Rows(i).Cells(13).Value.ToString()))
                    SQL.AddParams("@Qty", dtableInvoice.Rows(i).Cells(5).Value)
                    SQL.AddParams("@EquivalentQty", dtableInvoice.Rows(i).Cells(7).Value)
                    SQL.AddParams("@SupplierUnitPrice", dtableInvoice.Rows(i).Cells(9).Value)
                    SQL.AddParams("@OK", dtableInvoice.Rows(i).Cells(12).Value)
                    SQL.AddParams("@Received", dtableInvoice.Rows(i).Cells(11).Value)
                    SQL.AddParams("@ClientUnitPrice", dtableInvoice.Rows(i).Cells(16).Value)
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
	                            SupplierUnitPrice = @SupplierUnitPrice,
	                            ClientUnitPrice = @ClientUnitPrice,
                                Received=@Received,
                                OK=@OK,
	                            DeletedDate =(select case when @deleteddate=1 then getdate() else NULL end),
	                            UpdatedDate = getdate(),
	                            UpdatedBy = @updatedby
	                            WHERE InvoiceNo = @invoiceno AND InvoiceDetailSeq = @invoicedetailseq")
                        If SQL.HasException Then
                            MsgBox("Error in Updating Data!", MsgBoxStyle.Critical, "Error")
                            btnSave.Enabled = True
                            btnSave.Text = "SAVE INVOICE"
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
                        SupplierUnitPrice,
                        ClientUnitPrice,
                        Received,
                        OK,
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
                        @SupplierUnitPrice,
                        @ClientUnitPrice,
                        @Received,
                        @OK,
                        @UpdatedBy)")
                        If SQL.HasException Then
                            SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                            SQL.ExecQuery("DELETE FROM InvoiceHeaders WHERE InvoiceNo=@InvoiceNo;DELETE FROM InvoiceDetails WHERE InvoiceNo=@InvoiceNo")
                            btnSave.Enabled = True
                            btnSave.Text = "SAVE INVOICE"
                            msgboxDisplay("Error in saving", 3)
                            Exit Sub
                        End If
                    End If
                Next

                For i As Integer = 0 To dtableDelivery.Rows.Count - 1
                    SQL.AddParams("@deleteddate", chkcancelPO.Checked)
                    SQL.AddParams("@InvoiceNo", txtInvoiceNo.Text)
                    SQL.AddParams("@SupplierId", txtSupplier.Text)
                    SQL.AddParams("@InvoiceDetailSeq", dtableDelivery.Rows(i).Cells(0).Value)
                    SQL.AddParams("@DeliveryId", dtableDelivery.Rows(i).Cells(1).Value.ToString)
                    SQL.AddParams("@DeliveryDate", Convert.ToDateTime(dtableDelivery.Rows(i).Cells(2).Value.ToString()))
                    SQL.AddParams("@QtyExpected", dtableDelivery.Rows(i).Cells(5).Value)
                    SQL.AddParams("@QtyReceived", dtableDelivery.Rows(i).Cells(8).Value)
                    SQL.AddParams("@QtyOk", dtableDelivery.Rows(i).Cells(9).Value)
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
                            btnSave.Enabled = True
                            btnSave.Text = "SAVE INVOICE"
                            msgboxDisplay("Error in saving", 3)
                            Exit Sub
                        End If
                    End If

                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Information")
            btnSave.Text = "SAVE INVOICE"
            btnSave.Enabled = False
            Exit Sub
        End Try
        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
        Me.Close()
    End Sub

    Private Sub txtPoSeq_TextChanged(sender As Object, e As EventArgs) Handles txtPoSeq.TextChanged
        SQL.AddParams("@PoNo", txtPo.Text)
        SQL.AddParams("@PoDetailSeq", txtPoSeq.Text)
        SQL.ExecQuery("SELECT Qty,
                ( select dbo.getUnit(p.QtyUnit)) 'Client',
                EquivalentQty,
                (select dbo.getUnit(p.EquivalentQtyUnit)) 'Supplier',
                SupplierUnitPrice,ClientUnitPrice FROM PoDetails p 
                WHERE p.PoNo=@PoNo AND p.PoDetailSeq=@PoDetailSeq")
        If SQL.HasException Then Exit Sub
        If SQL.RecordCount = 0 Then Exit Sub
        txtCliUnit.Text = SQL.DBDT.Rows(0).Item(1)
        txtSupUnit.Text = SQL.DBDT.Rows(0).Item(3)
        txtUnit.Text = SQL.DBDT.Rows(0).Item(4)
        ClientPrice = SQL.DBDT.Rows(0).Item(5)
        txtTotalPrice.Text = Val(txtUnit.Text) * Val(txtSupQty.Text)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            If String.IsNullOrEmpty(txtItemCode.Text) Or String.IsNullOrEmpty(txtPo.Text) Or
        String.IsNullOrEmpty(txtCliQty.Text) Or String.IsNullOrEmpty(txtSupQty.Text) Then
            MsgBox("Please complete * important fields!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
            If btnAddItem.Text = "INSERT INVOICE" Then
                Dim row As ArrayList = New ArrayList
                btnAddItem.Text = "Please wait ..."
                btnAddItem.Enabled = False
                txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + Val(txtTotalPrice.Text), "0.00")
                dtableInvoice.Rows.Add(dtableInvoice.Rows.Count + 1, txtItemCode.Text,
                txtItemName.Text,
                txtPo.Text,
                txtPoSeq.Text,
                txtCliQty.Text,
                txtCliUnit.Text,
                txtSupQty.Text,
                txtSupUnit.Text,
                txtUnit.Text,
                txtTotalPrice.Text,
                chkReceived.Checked,
                chkOk.Checked, dtDate.Value, txtInvoiceRemarks.Text, "", ClientPrice)
                InvoicesClear()

            Else
                btnAddItem.Text = "Please wait ..."
                btnAddItem.Enabled = False
                txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + (Val(txtTotalPrice.Text) - dtableInvoice.SelectedRows(0).Cells(10).Value), "0.00")
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
                dtableInvoice.SelectedRows(0).Cells(12).Value = chkOk.Checked
                dtableInvoice.SelectedRows(0).Cells(11).Value = chkReceived.Checked
                dtableInvoice.SelectedRows(0).Cells(13).Value = dtDate.Value
                dtableInvoice.SelectedRows(0).Cells(14).Value = txtInvoiceRemarks.Text
                dtableInvoice.SelectedRows(0).Cells(16).Value = ClientPrice
                InvoicesClear()
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
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
        chkOk.Checked = False
        chkOk.Enabled = False
        chkReceived.Checked = False
        chkReceived.Enabled = False
        'dtDate.Checked = False
        ClientPrice = 0.00
        btnAddItem.Text = "INSERT INVOICE"
        btnAddItem.Enabled = True
    End Sub

    Private Sub btnItemInv_Click(sender As Object, e As EventArgs) Handles btnItemInv.Click
        'If txtSupplier.Text = "" Then
        '    MsgBox("Choose Supplier First")
        '    Exit Sub
        'End If
        'SelectionItem.txtSupplier.Text = txtSupplier.Text
        'formname = "AddDelivery"
        'SelectionItem.show()
        If Application.OpenForms().OfType(Of FrmInvoiceSelection).Any Then
                    FrmInvoiceSelection.Close()
                    FrmInvoiceSelection.Show()
                Else
                    FrmInvoiceSelection.Show()
                End If
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
        If Application.OpenForms().OfType(Of PurchaseOrderList).Any Then PurchaseOrderList.Close()
        formname = "AddDelivery"
        PurchaseOrderList.txtItems.Text = txtItemDel.Text
        PurchaseOrderList.txtSupplier.Text = txtSupplier.Text
        PurchaseOrderList.Show()
    End Sub


    Private Sub btnInsertDel_Click(sender As Object, e As EventArgs) Handles btnInsertDel.Click
        Try
            If String.IsNullOrEmpty(txtItemDel.Text) Or String.IsNullOrEmpty(txtPoDel.Text) Then
                MsgBox("Please complete all * important fields!", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            If btnInsertDel.Text = "INSERT DELIVERY" Then
                Dim row As ArrayList = New ArrayList
                btnInsertDel.Text = "Please wait ..."
                btnInsertDel.Enabled = False
                dtableDelivery.Rows.Add(dtableDelivery.Rows.Count + 1,
               txtDeliveryID.Text,
               dtDeliveryDate.Value,
                txtItemDel.Text,
                txtIteamNameDel.Text,
                txtExp.Text,
                txtPoDel.Text,
                txtposeqdel.Text,
                txtRec.Text,
                txtqtyok.Text,
                txtBal.Text, "")
                DeliveryClear()
            Else
                btnInsertDel.Text = "Please wait ..."
                btnInsertDel.Enabled = False
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
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
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
        btnInsertDel.Enabled = True
    End Sub


    Private Sub txtRec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRec.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub


    Private Sub txtqtyok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqtyok.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub

    Private Sub dtableDelivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableDelivery.CellClick
        Try
            If dtableDelivery.Rows.Count > 0 Then
                If Val(txtBal.Text) = 0 Then
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
                End If
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub dtableInvoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableInvoice.CellClick
        If dtableInvoice.SelectedRows(0).Cells(11).Value = False Or dtableInvoice.SelectedRows(0).Cells(12).Value = False Then
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
            chkOk.Checked = dtableInvoice.SelectedRows(0).Cells(12).Value.ToString()
            chkOk.Enabled = True
            chkReceived.Enabled = True
            btnAddItem.Text = "UPDATE INVOICE"
            btnAddItem.Enabled = True
        Else
            MsgBox("Cannot modify Already Received !", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub txtqtyok_TextChanged(sender As Object, e As EventArgs) Handles txtqtyok.TextChanged
        If Val(txtqtyok.Text) > Val(txtExp.Text) Then
            txtqtyok.Text = ""
            MsgBox("Please input <=ExpectedQty!", MsgBoxStyle.Critical, "Error")
        End If
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

    Private Sub txtCliQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub


    Private Sub txtSupQty_TextChanged(sender As Object, e As EventArgs) Handles txtSupQty.TextChanged
        If dtableInvoice.Rows.Count > 0 Then
            If dtableInvoice.SelectedRows(0).Cells(11).Value = True And dtableInvoice.SelectedRows(0).Cells(12).Value = True Then
                msgboxDisplay("Cannot modify already received!", 2)
                Exit Sub
            End If
        End If
        txtCliQty.Text = Val(txtSupQty.Text) / coefficient
        txtTotalPrice.Text = Format(Val(txtSupQty.Text) * Val(txtUnit.Text), "0.00")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = vbYes Then dtableDelivery.Rows.RemoveAt(dtableDelivery.SelectedRows(0).Index)
    End Sub

    Private Sub dtableInvoice_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtableInvoice.CellFormatting
        dtableInvoice.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    End Sub


    Private Sub dtableDelivery_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtableDelivery.CellFormatting
        dtableDelivery.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub dtDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        chkOk.Checked = dtDate.Checked
    End Sub

    Private Sub btnDelDelete_Click(sender As Object, e As EventArgs)
        If dtableInvoice.SelectedRows(0).Cells(11).Value = False Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
                dtableInvoice.Rows.RemoveAt(dtableInvoice.SelectedRows(0).Index)
            End If
        End If
    End Sub

    Private Sub dtableInvoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableInvoice.CellContentClick

    End Sub

    Private Sub txtCliQty_TextChanged(sender As Object, e As EventArgs) Handles txtCliQty.TextChanged
        If dtableInvoice.Rows.Count > 0 Then
            If dtableInvoice.SelectedRows(0).Cells(11).Value = True And dtableInvoice.SelectedRows(0).Cells(12).Value = True Then
                msgboxDisplay("Cannot modify already received!", 2)
                Exit Sub
            End If
        End If
        txtSupQty.Text = Val(txtCliQty.Text) * coefficient
        txtTotalPrice.Text = Format(Val(txtSupQty.Text) * Val(txtUnit.Text), "0.00")
    End Sub

    Private Sub dtableDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableDelivery.CellContentClick

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