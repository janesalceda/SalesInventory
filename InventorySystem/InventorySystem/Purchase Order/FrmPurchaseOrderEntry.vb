Public Class FrmPurchaseOrderEntry

    Public boolUpdate As Boolean = False

    Private Sub getPODetails()
        SQL.AddParams("@PONo", txtPONo.Text)
        SQL.ExecQuery("SELECT poh.PONo,poh.SupplierID,CurrencyUnit,IssuedDate,TermOfDelivery,TermOfPayment,DeliveryPlace,poh.Remarks,
                e.EmployeeName,
				poh.TotalAmount,pod.ItemId,i.Description,Qty,
               (select dbo.getUnit(pod.QtyUnit)) AS 'Cli',
				EquivalentQty,
                (select dbo.getUnit(pod.EquivalentQtyUnit)) 'Sup',
				UnitPrice,EtdDate,
                EtaDate,FtryDate,Canceled,ReceivedAllInvoices,
                CASE WHEN poh.DeletedDate IS NULL THEN 0 ELSE 1 END POCancelled,PoDetailSeq
                FROM POHeaders poh 
                INNER	JOIN PoDetails pod 
                ON poh.PONo=pod.PoNo
                INNER JOIN CurrencyUnits c ON poh.CurrencyUnitId=c.CurrencyUnitId
                INNER JOIN TermsOfDelivery td ON poh.TermOfDeliveryId=td.TermOfDeliveryId
                INNER JOIN TermsOfPayment tp ON tp.TermOfPaymentId=poh.TermOfPaymentId
                INNER JOIN DeliveryPlaces dp ON dp.DeliveryPlaceId=poh.DeliveryPlaceId
                INNER JOIN Employees e ON poh.EncodedStaff=e.EmpId
                INNER JOIN Items i ON i.ItemId=pod.ItemId	
                INNER JOIN QtyUnits q ON q.QtyUnitid=pod.QtyUnit	
                where poh.PONo=@PONo")
        Dim row As New DataTable
        row = SQL.DBDT
        If SQL.HasException Or SQL.DBDT.Rows.Count = 0 Then Exit Sub
        txtSupplier.Text = row.Rows(0).Item(1)
        txtCurrency.Text = row.Rows(0).Item(2)
        dtIssued.Value = row.Rows(0).Item(3)
        cmbTDelivery.Text = row.Rows(0).Item(4)
        cmbTPayment.Text = row.Rows(0).Item(5)
        cmbDeliveryPlace.Text = row.Rows(0).Item(6)
        txtRemarks.Text = row.Rows(0).Item(7)
        txtStaffName.Text = row.Rows(0).Item(8)
        txtTotalAmount.Text = row.Rows(0).Item(9)
        For i As Integer = 0 To row.Rows.Count - 1
            dtablePoDetails.Rows.Add(
                row.Rows(i).Item(23),
                row.Rows(i).Item(10),
                row.Rows(i).Item(11),
                row.Rows(i).Item(12),
                row.Rows(i).Item(13),
                row.Rows(i).Item(14),
                row.Rows(i).Item(15),
                row.Rows(i).Item(16),
                Val(row.Rows(i).Item(16)) * Val(row.Rows(i).Item(14)),
                row.Rows(i).Item(17),
                row.Rows(i).Item(18),
                row.Rows(i).Item(19),
                row.Rows(i).Item(20),
                row.Rows(0).Item(21), "No")
        Next
        chkcancelPO.Checked = row.Rows(0).Item(22)
    End Sub
    Private Sub PurchDetailsClear()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtSupQty.Clear()
        txtSupUnit.Clear()
        txtCliQty.Clear()
        txtCliUnit.Clear()
        txtUnit.Clear()
        txtTotalPrice.Clear()
        dtETD.Checked = False
        dtETA.Checked = False
        DTFtry.Checked = False
        chkCancel.Checked = False
        chkReceived.Checked = False
        btnAddItem.Enabled = True
    End Sub
    Private Sub HeaderClear()
        'txtPONo.Clear()
        txtSupplier.Clear()
        txtCurrency.Clear()
        dtIssued.Value = Today
        cmbTDelivery.SelectedIndex = -1
        cmbTPayment.SelectedIndex = -1
        cmbDeliveryPlace.SelectedIndex = -1
        txtRemarks.Clear()
        txtSupplierName.Clear()
        txtTotalAmount.Clear()
        dtablePoDetails.Rows.Clear()
        btnAddItem.Visible = True
    End Sub
    Private Sub LoadDelivery()
        cmbTDelivery.DataSource = getDelivery()
        cmbTDelivery.DisplayMember = "TermOfDelivery"
        cmbTDelivery.ValueMember = "TermOfDeliveryId"
        cmbTDelivery.SelectedIndex = -1
    End Sub

    Private Sub LoadPayment()
        cmbTPayment.DataSource = getPayment()
        cmbTPayment.DisplayMember = "TermOfPayment"
        cmbTPayment.ValueMember = "TermOfPaymentId"
        cmbTPayment.SelectedIndex = -1
    End Sub
    Private Sub LoadDeliveryPlaces()
        cmbDeliveryPlace.DataSource = getDeliveryPlaces()
        cmbDeliveryPlace.DisplayMember = "DeliveryPlace"
        cmbDeliveryPlace.ValueMember = "DeliveryPlaceId"
        cmbDeliveryPlace.SelectedIndex = -1
    End Sub
    Private Sub AddPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        txtStaffName.Text = moduleName
        LoadPayment()
        LoadDelivery()
        LoadDeliveryPlaces()
        If String.IsNullOrEmpty(txtPONo.Text) Then
            HeaderClear()
            dtablePoDetails.ColumnCount = 15
        Else
            chkCancel.Enabled = True
            chkReceived.Enabled = True
            chkcancelPO.Enabled = True
            getPODetails()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrEmpty(txtSupplier.Text) Or
            cmbDeliveryPlace.SelectedIndex = -1 Or
            dtablePoDetails.Rows.Count = 0 Then
            MsgBox("Please complete all * important fields!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            SQL.AddParams("@supplierid", txtSupplier.Text)
            SQL.AddParams("@currencyunitid", txtCurrency.Text)
            SQL.AddParams("@issueddate", dtIssued.Value)
            SQL.AddParams("@termofdeliveryid", cmbTDelivery.SelectedValue)
            SQL.AddParams("@termofpaymentid", cmbTPayment.SelectedValue)
            SQL.AddParams("@deliveryplaceid", cmbDeliveryPlace.SelectedValue)
            SQL.AddParams("@totalamount", Val(txtTotalAmount.Text))
            SQL.AddParams("@remarks", txtRemarks.Text)
            SQL.AddParams("@encodedstaff", moduleId)
            SQL.AddParams("@deletedDate", chkcancelPO.Checked)

            If btnSave.Text = "UPDATE P.O." Then
                SQL.AddParams("@pono", txtPONo.Text)
                SQL.AddParams("@UpdatedBy", moduleId)
                SQL.ExecQuery("UPDATE dbo.POHeaders
                SET SupplierID = @supplierid,
	                CurrencyUnitId =(select CurrencyUnitId from CurrencyUnits where CurrencyUnit=@currencyunitid),
	                IssuedDate = @issueddate,
	                TermOfDeliveryId = @termofdeliveryid,
	                TermOfPaymentId = @termofpaymentid,
	                DeliveryPlaceId = @deliveryplaceid,
	                TotalAmount = @totalamount,
	                Remarks = @remarks,
                    DeletedDate=(select case when @deletedDate=0 then null else getdate() end ),
	                UpdatedDate = getdate(),
	                UpdatedBy = @updatedby
                WHERE PoNo=@pono")
                If SQL.HasException Then Exit Sub

                For i As Integer = 0 To dtablePoDetails.Rows.Count - 1
                    If Not String.IsNullOrWhiteSpace(dtablePoDetails.Rows(i).Cells(14).Value.ToString()) Then
                        SQL.AddParams("@pono", txtPONo.Text)
                        SQL.AddParams("@itemid", dtablePoDetails.Rows(i).Cells(1).Value.ToString())
                        SQL.AddParams("@etddate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(9).Value.ToString()))
                        SQL.AddParams("@etadate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(10).Value.ToString()))
                        SQL.AddParams("@ftrydate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(11).Value.ToString()))
                        SQL.AddParams("@receivedallinvoices", dtablePoDetails.Rows(i).Cells(13).Value.ToString())
                        SQL.AddParams("@canceled", dtablePoDetails.Rows(i).Cells(12).Value.ToString())
                        SQL.AddParams("@podetailseq", dtablePoDetails.Rows(i).Cells(0).Value)
                        SQL.AddParams("@qty", dtablePoDetails.Rows(i).Cells(3).Value.ToString())
                        SQL.AddParams("@qtyunit", dtablePoDetails.Rows(i).Cells(4).Value.ToString())
                        SQL.AddParams("@equivalentqty", dtablePoDetails.Rows(i).Cells(5).Value.ToString())
                        SQL.AddParams("@equivalentqtyunit", dtablePoDetails.Rows(i).Cells(6).Value.ToString())
                        SQL.AddParams("@unitprice", dtablePoDetails.Rows(i).Cells(7).Value.ToString())
                        SQL.AddParams("@updatedby", moduleId)

                        SQL.ExecQuery("UPDATE dbo.PoDetails
                    SET ItemId = @itemid,
	                    EtdDate = @etddate,
	                    EtaDate = @etadate,
	                    FtryDate = @ftrydate,
	                    ReceivedAllInvoices = @receivedallinvoices,
	                    Canceled = @canceled,
	                    Qty = @qty,
	                    QtyUnit = (select QtyUnitId from QtyUnits where QtyUnit=@qtyunit),
	                    EquivalentQty = @equivalentqty,
	                    EquivalentQtyUnit = (select QtyUnitId from QtyUnits where QtyUnit=@equivalentqtyunit),
	                    UnitPrice = @unitprice,
	                    UpdatedDate = getdate(),
	                    UpdatedBy = @updatedby
                    WHERE PoNo=@pono and PoDetailSeq = @podetailseq")
                        If SQL.HasException Then
                            MsgBox("Error in Editing!", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If
                    Else
                        SQL.AddParams("@itemid", dtablePoDetails.Rows(i).Cells(1).Value.ToString())
                        SQL.AddParams("@etddate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(9).Value.ToString()))
                        SQL.AddParams("@etadate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(10).Value.ToString()))
                        SQL.AddParams("@ftrydate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(11).Value.ToString()))
                        SQL.AddParams("@receivedallinvoices", dtablePoDetails.Rows(i).Cells(13).Value.ToString())
                        SQL.AddParams("@canceled", dtablePoDetails.Rows(i).Cells(12).Value.ToString())
                        SQL.AddParams("@podetailseq", dtablePoDetails.Rows(i).Cells(0).Value)
                        SQL.AddParams("@qty", dtablePoDetails.Rows(i).Cells(3).Value.ToString())
                        SQL.AddParams("@qtyunit", dtablePoDetails.Rows(i).Cells(4).Value.ToString())
                        SQL.AddParams("@equivalentqty", dtablePoDetails.Rows(i).Cells(5).Value.ToString())
                        SQL.AddParams("@equivalentqtyunit", dtablePoDetails.Rows(i).Cells(6).Value.ToString())
                        SQL.AddParams("@unitprice", dtablePoDetails.Rows(i).Cells(7).Value.ToString())
                        SQL.AddParams("@updatedby", moduleId)
                        SQL.ExecQuery("
                    INSERT INTO dbo.PoDetails
	                    (
	                    PoNo,
	                    ItemId,
	                    EtdDate,
	                    EtaDate,
	                    FtryDate,
	                    ReceivedAllInvoices,
	                    Canceled,
	                    PoDetailSeq,
	                    Qty,
	                    QtyUnit,
	                    EquivalentQty,
	                    EquivalentQtyUnit,
	                    UnitPrice,
	                    UpdatedBy
	                    )
                    VALUES 
	                    (
	                    (select max(pono) from poheaders),
	                    @itemid,
	                    @etddate,
	                    @etadate,
	                    @ftrydate,
	                    @receivedallinvoices,
	                    @canceled,
	                    @podetailseq,
	                    @qty,
	                    (select QtyUnitId from QtyUnits where QtyUnit=@qtyunit),
	                    @equivalentqty,
	                    (select QtyUnitId from QtyUnits where QtyUnit=@equivalentqtyunit),
	                    @unitprice,
	                    @updatedby
	                    )")
                        If SQL.HasException Then
                            'SQL.AddParams("@pono", txtPONo.Text)
                            'SQL.ExecQuery("delete from POHeaders where PONo=@pono;delete from PoDetails where PONo=@pono;")
                            Exit Sub
                        End If
                    End If
                Next
            Else
                SQL.ExecQuery("INSERT INTO dbo.POHeaders
	                (
	                PONo,
	                SupplierID,
	                CurrencyUnitId,
	                IssuedDate,
	                TermOfDeliveryId,
	                TermOfPaymentId,
	                DeliveryPlaceId,
	                TotalAmount,
	                Remarks,
	                EncodedStaff,
	                UpdatedBy
	                )
                VALUES 
	                ((SELECT CASE WHEN max(PONo) IS NULL 
                    THEN replace(convert(VARCHAR(10),getdate(),111),'/','') +'-01' ELSE
                    CASE WHEN Cast(right(max(PONo),len(max(PONo))-10) AS INT) +1<10 
                    THEN replace(convert(VARCHAR(10),getdate(),111),'/','') + '-0'+ cast(Cast(right(max(PONo),len(max(PONo))-10) AS INT) +1 AS VARCHAR	)
                    ELSE replace(convert(VARCHAR(10),getdate(),111),'/','')+ '-' +cast(Cast(right(max(PONo),len(max(PONo))-10) AS INT) +1 AS VARCHAR	)
                    END END AS 'pomax' from POHeaders),
	                @supplierid,
                    (select CurrencyUnitId from CurrencyUnits where CurrencyUnit=@currencyunitid),
	                @issueddate,
	                @termofdeliveryid,
	                @termofpaymentid,
	                @deliveryplaceid,
	                @totalamount,
	                @remarks,
                    @encodedstaff,
	                @encodedstaff)"
                        )

                If SQL.HasException Then Exit Sub

                For i As Integer = 0 To dtablePoDetails.Rows.Count - 1
                    SQL.AddParams("@itemid", dtablePoDetails.Rows(i).Cells(1).Value.ToString())
                    SQL.AddParams("@etddate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(9).Value.ToString()))
                    SQL.AddParams("@etadate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(10).Value.ToString()))
                    SQL.AddParams("@ftrydate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(11).Value.ToString()))
                    SQL.AddParams("@receivedallinvoices", dtablePoDetails.Rows(i).Cells(13).Value.ToString())
                    SQL.AddParams("@canceled", dtablePoDetails.Rows(i).Cells(12).Value.ToString())
                    SQL.AddParams("@podetailseq", dtablePoDetails.Rows(i).Cells(0).Value)
                    SQL.AddParams("@qty", dtablePoDetails.Rows(i).Cells(3).Value.ToString())
                    SQL.AddParams("@qtyunit", dtablePoDetails.Rows(i).Cells(4).Value.ToString())
                    SQL.AddParams("@equivalentqty", dtablePoDetails.Rows(i).Cells(5).Value.ToString())
                    SQL.AddParams("@equivalentqtyunit", dtablePoDetails.Rows(i).Cells(6).Value.ToString())
                    SQL.AddParams("@unitprice", dtablePoDetails.Rows(i).Cells(7).Value.ToString())
                    SQL.AddParams("@updatedby", moduleId)
                    SQL.ExecQuery("
                    INSERT INTO dbo.PoDetails
	                    (
	                    PoNo,
	                    ItemId,
	                    EtdDate,
	                    EtaDate,
	                    FtryDate,
	                    ReceivedAllInvoices,
	                    Canceled,
	                    PoDetailSeq,
	                    Qty,
	                    QtyUnit,
	                    EquivalentQty,
	                    EquivalentQtyUnit,
	                    UnitPrice,
	                    UpdatedBy
	                    )
                    VALUES 
	                    (
	                    (select max(pono) from poheaders),
	                    @itemid,
	                    @etddate,
	                    @etadate,
	                    @ftrydate,
	                    @receivedallinvoices,
	                    @canceled,
	                    @podetailseq,
	                    @qty,
	                    (select QtyUnitId from QtyUnits where QtyUnit=@qtyunit),
	                    @equivalentqty,
	                    (select QtyUnitId from QtyUnits where QtyUnit=@equivalentqtyunit),
	                    @unitprice,
	                    @updatedby
	                    )")
                    If SQL.HasException Then
                        'SQL.AddParams("@pono", txtPONo.Text)
                        'SQL.ExecQuery("delete from POHeaders where PONo=@pono;delete from PoDetails where PONo=@pono;")
                        Exit Sub
                    End If
                Next
            End If
            HeaderClear()
            'Me.Close()
            MsgBox("Successfully Save", MsgBoxStyle.Information, "Information")
            Me.Close()
        End If
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "AddPurchaseOrder"
        SupplierList.Show()
    End Sub
    Private Sub dtPoDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        dtablePoDetails.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    End Sub
    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        If txtSupplier.Text = "" Then
            MsgBox("Choose Supplier First", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        SelectionItem.txtSupplier.Text = txtSupplier.Text
        SelectionItem.IssuedDate = dtIssued.Value
        formname = "AddPurchaseOrder"
        SelectionItem.Show()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If String.IsNullOrEmpty(txtItemCode.Text) Or
                String.IsNullOrEmpty(txtCliQty.Text) Or
                String.IsNullOrEmpty(txtSupQty.Text) Then
            MsgBox("Please complete all * important fields!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        Dim row As ArrayList = New ArrayList
        If btnAddItem.Text = "INSERT ITEM" Then
            txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + Val(txtTotalPrice.Text), "0.00")
            dtablePoDetails.Rows.Add(dtablePoDetails.Rows.Count + 1,
            txtItemCode.Text,
            txtItemName.Text,
            txtCliQty.Text,
            txtCliUnit.Text,
            txtSupQty.Text,
            txtSupUnit.Text,
            txtUnit.Text,
            txtTotalPrice.Text,
            dtETD.Value,
            dtETA.Value,
            DTFtry.Value,
            chkCancel.Checked,
            chkReceived.Checked, "")
            PurchDetailsClear()
        Else
            dtablePoDetails.SelectedRows(0).Cells(1).Value = txtItemCode.Text
            dtablePoDetails.SelectedRows(0).Cells(2).Value = txtItemName.Text
            dtablePoDetails.SelectedRows(0).Cells(3).Value = txtCliQty.Text
            dtablePoDetails.SelectedRows(0).Cells(4).Value = txtCliUnit.Text
            dtablePoDetails.SelectedRows(0).Cells(5).Value = txtSupQty.Text
            dtablePoDetails.SelectedRows(0).Cells(6).Value = txtSupUnit.Text
            dtablePoDetails.SelectedRows(0).Cells(7).Value = txtUnit.Text
            dtablePoDetails.SelectedRows(0).Cells(8).Value = txtTotalPrice.Text
            dtablePoDetails.SelectedRows(0).Cells(9).Value = dtETD.Value
            dtablePoDetails.SelectedRows(0).Cells(10).Value = dtETA.Value
            dtablePoDetails.SelectedRows(0).Cells(11).Value = DTFtry.Value
            dtablePoDetails.SelectedRows(0).Cells(12).Value = chkCancel.Checked
            dtablePoDetails.SelectedRows(0).Cells(13).Value = chkReceived.Checked
            btnAddItem.Text = "INSERT ITEM"
            PurchDetailsClear()
        End If



    End Sub

    Private Sub txtCliQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCliQty.KeyUp
        txtSupQty.Text = Val(txtCliQty.Text) * coefficient
        txtTotalPrice.Text = Format(Val(txtSupQty.Text) * Val(txtUnit.Text), "0.00")
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupplier.Text)
        If row.Count = 0 Then
            txtSupplierName.Text = ""
            cmbTPayment.SelectedIndex = -1
            cmbTDelivery.SelectedIndex = -1
            Exit Sub
        End If
        txtSupplierName.Text = row.Item(0)
        txtCurrency.Text = row.Item(1)
        cmbTPayment.Text = row.Item(3)
        cmbTDelivery.Text = row.Item(2)
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        txtCliQty.Clear()
        txtSupQty.Clear()
        Dim row As ArrayList = New ArrayList
        row = GetItemDetailsforPO(txtItemCode.Text, dtIssued.Value.ToShortDateString)
        If row.Count = 0 Then
            txtItemName.Text = ""
            txtCliUnit.Text = ""
            txtSupUnit.Text = ""
            coefficient = 0.0
            txtUnit.Text = ""
            btnAddItem.Enabled = False
            Exit Sub
        End If
        txtItemName.Text = row.Item(0)
        txtCliUnit.Text = row.Item(1)
        txtSupUnit.Text = row.Item(2)
        coefficient = row.Item(3)
        btnAddItem.Enabled = True
        txtUnit.Text = Format(Val(row.Item(4)), "0.00")
    End Sub
    Private Sub dtablePoDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtablePoDetails.CellClick
        txtItemCode.Text = dtablePoDetails.SelectedRows(0).Cells(1).Value.ToString()
        txtItemName.Text = dtablePoDetails.SelectedRows(0).Cells(2).Value.ToString()
        txtCliQty.Text = dtablePoDetails.SelectedRows(0).Cells(3).Value.ToString()
        txtCliUnit.Text = dtablePoDetails.SelectedRows(0).Cells(4).Value.ToString()
        txtSupQty.Text = dtablePoDetails.SelectedRows(0).Cells(5).Value.ToString()
        txtSupUnit.Text = dtablePoDetails.SelectedRows(0).Cells(6).Value.ToString()
        txtUnit.Text = dtablePoDetails.SelectedRows(0).Cells(7).Value.ToString()
        txtTotalPrice.Text = dtablePoDetails.SelectedRows(0).Cells(8).Value.ToString()
        dtETD.Value = Convert.ToDateTime(dtablePoDetails.SelectedRows(0).Cells(9).Value.ToString())
        dtETA.Value = Convert.ToDateTime(dtablePoDetails.SelectedRows(0).Cells(10).Value.ToString())
        DTFtry.Value = Convert.ToDateTime(dtablePoDetails.SelectedRows(0).Cells(11).Value.ToString())
        chkCancel.Checked = dtablePoDetails.SelectedRows(0).Cells(12).Value.ToString()
        chkReceived.Checked = dtablePoDetails.SelectedRows(0).Cells(13).Value.ToString()
        btnAddItem.Text = "UPDATE ITEM"
        btnClear.Enabled = True
    End Sub

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

    Private Sub txtSupQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub
    Private Function GetItemDetailsforPO(ItemId As String, IssuedDate As Date) As ArrayList
        Dim Globalrow As ArrayList = New ArrayList
        SQL.AddParams("@ItemId", ItemId)
        SQL.AddParams("@IssuedDate", IssuedDate)
        SQL.ExecQuery("SELECT top 1 i.Description,
            ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.ClientQtyUnit and i.ItemId=@ItemId) 'Client',
            ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.SupplierQtyUnit and i.ItemId=@ItemId) 'Supplier',
            ConvertingCoefficient,
            UnitPrice FROM Items i INNER JOIN SupplierItemPrices s ON i.ItemId=s.ItemId, QtyUnits q 
            where s.AppliedDate<=@IssuedDate and i.ItemId=@ItemId order by AppliedDate")
        If SQL.HasException Then Return Globalrow
        If SQL.RecordCount = 0 Then Return Globalrow
        Globalrow.Add(SQL.DBDT.Rows(0).Item(0))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(1))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(2))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(3))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(4))
        Return Globalrow
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        PurchDetailsClear()
        btnAddItem.Enabled = True
    End Sub

    Private Sub dtablePoDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtablePoDetails.CellContentClick

    End Sub
End Class