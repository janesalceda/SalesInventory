Imports Microsoft.Reporting.WinForms

Public Class FrmPurchaseOrderEntry

    Public boolUpdate As Boolean = False

    Private Sub getPODetails()
        Try
            SQL.AddParams("@PONo", txtPONo.Text)
            SQL.ExecQuery("SELECT poh.PONo,poh.SupplierID,CurrencyUnit,IssuedDate,
                TermOfDeliveryId,TermOfPaymentId,DeliveryPlaceId,poh.Remarks,
                e.EmployeeName,
				poh.TotalAmount,pod.ItemId,i.Description,pod.Qty,
               (select dbo.getUnit(pod.QtyUnit)) AS 'Cli',
				pod.EquivalentQty,
                (select dbo.getUnit(pod.EquivalentQtyUnit)) 'Sup',
				pod.SupplierUnitPrice,EtdDate,
                EtaDate,FtryDate,Canceled,ReceivedAllInvoices,
                CASE WHEN poh.DeletedDate IS NULL THEN 0 ELSE 1 END POCancelled,
                pod.PoDetailSeq,
                isnull((SELECT                  
                SUM(Qty) AS Expr1
				FROM                     
				dbo.InvoiceDetails
				WHERE                   
				(PoNo = Pod.PoNo) 
				AND (PoDetailSeq = pod.PoDetailSeq)),0) AS InvoiceQty,pod.ClientUnitPrice
                FROM POHeaders poh 
                INNER	JOIN PoDetails pod 
                ON poh.PONo=pod.PoNo
                INNER JOIN CurrencyUnits c ON poh.CurrencyUnitId=c.CurrencyUnitId
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
            cmbTDelivery.SelectedValue = row.Rows(0).Item(4)
            cmbTPayment.SelectedValue = row.Rows(0).Item(5)
            cmbDeliveryPlace.SelectedValue = row.Rows(0).Item(6)
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
                    row.Rows(i).Item("Canceled"),
                    row.Rows(i).Item("ReceivedAllInvoices"), "No", row.Rows(i).Item("InvoiceQty"), row.Rows(i).Item("ClientUnitPrice"))
            Next
            chkcancelPO.Checked = row.Rows(0).Item(22)
        Catch ex As Exception
            'CAPTURE ERROR
            MsgBox("ExecuteQuery Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' CLOSE CONNECTION
        End Try
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
        dtETD.Value = Today
        dtETA.Value = Today
        DTFtry.Value = Today
        chkCancel.Checked = False
        chkCancel.Enabled = False
        chkReceived.Enabled = False
        chkReceived.Checked = False
        btnAddItem.Enabled = True
        btnAddItem.Text = "INSERT ITEM"
    End Sub
    Private Sub HeaderClear()
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
        Button1.Visible = False
        dtETA.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtETD.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        DTFtry.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtIssued.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
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
        Else
            chkCancel.Enabled = True
            chkReceived.Enabled = True
            chkcancelPO.Enabled = True
            getPODetails()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim strcomplete As String = "Please complete the ff:" & vbNewLine
        If String.IsNullOrEmpty(txtSupplier.Text) Then
            strcomplete += "*Supplier" & vbNewLine
        End If
        If cmbDeliveryPlace.SelectedIndex = -1 Then
                strcomplete += "*Delivery Places" & vbNewLine
            End If
        If dtablePoDetails.Rows.Count = 0 Then
            strcomplete += "*Purchase Details" & vbNewLine
        End If
        If strcomplete <> "Please complete the ff:" & vbNewLine Then
            msgboxDisplay(strcomplete, 2)
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
                    btnSave.Enabled = False
                    btnSave.Text = "Please wait ..."
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
                    If SQL.HasException Then
                        btnSave.Enabled = True
                        btnSave.Text = "SAVE P.O."
                        msgboxDisplay("Error in saving", 3)
                        Exit Sub
                    End If

                    For i As Integer = 0 To dtablePoDetails.Rows.Count - 1
                        If Not String.IsNullOrWhiteSpace(dtablePoDetails.Rows(i).Cells(14).Value.ToString()) Then
                            SQL.AddParams("@pono", txtPONo.Text)
                            SQL.AddParams("@itemid", dtablePoDetails.Rows(i).Cells(1).Value.ToString())
                            SQL.AddParams("@etddate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(9).Value.ToString()))
                            SQL.AddParams("@etadate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(10).Value.ToString()))
                            SQL.AddParams("@ftrydate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(11).Value.ToString()))
                            SQL.AddParams("@receivedallinvoices", dtablePoDetails.Rows(i).Cells(13).Value)
                            SQL.AddParams("@canceled", dtablePoDetails.Rows(i).Cells(12).Value)
                            SQL.AddParams("@podetailseq", dtablePoDetails.Rows(i).Cells(0).Value)
                            SQL.AddParams("@qty", dtablePoDetails.Rows(i).Cells(3).Value.ToString())
                            SQL.AddParams("@qtyunit", dtablePoDetails.Rows(i).Cells(4).Value.ToString())
                            SQL.AddParams("@equivalentqty", dtablePoDetails.Rows(i).Cells(5).Value.ToString())
                            SQL.AddParams("@equivalentqtyunit", dtablePoDetails.Rows(i).Cells(6).Value.ToString())
                            SQL.AddParams("@supunitprice", dtablePoDetails.Rows(i).Cells(7).Value.ToString())
                            SQL.AddParams("@cliunitprice", dtablePoDetails.Rows(i).Cells(16).Value.ToString())
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
	                            SupplierUnitPrice = @supunitprice,
	                            ClientUnitPrice = @cliunitprice,
	                            UpdatedDate = getdate(),
	                            UpdatedBy = @updatedby
                            WHERE PoNo=@pono and PoDetailSeq = @podetailseq")
                            If SQL.HasException Then
                                MsgBox("Error in Editing!", MsgBoxStyle.Critical, "Error")
                                btnSave.Enabled = True
                                btnSave.Text = "SAVE P.O."
                                Exit Sub
                            End If
                        Else
                            SQL.AddParams("@itemid", dtablePoDetails.Rows(i).Cells(1).Value.ToString())
                            SQL.AddParams("@etddate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(9).Value.ToString()))
                            SQL.AddParams("@etadate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(10).Value.ToString()))
                            SQL.AddParams("@ftrydate", Convert.ToDateTime(dtablePoDetails.Rows(i).Cells(11).Value.ToString()))
                            SQL.AddParams("@receivedallinvoices", dtablePoDetails.Rows(i).Cells(13).Value)
                            SQL.AddParams("@canceled", dtablePoDetails.Rows(i).Cells(12).Value)
                            SQL.AddParams("@podetailseq", dtablePoDetails.Rows(i).Cells(0).Value)
                            SQL.AddParams("@qty", dtablePoDetails.Rows(i).Cells(3).Value.ToString())
                            SQL.AddParams("@qtyunit", dtablePoDetails.Rows(i).Cells(4).Value.ToString())
                            SQL.AddParams("@equivalentqty", dtablePoDetails.Rows(i).Cells(5).Value.ToString())
                            SQL.AddParams("@equivalentqtyunit", dtablePoDetails.Rows(i).Cells(6).Value.ToString())
                            SQL.AddParams("@supunitprice", dtablePoDetails.Rows(i).Cells(7).Value.ToString())
                            SQL.AddParams("@cliunitprice", dtablePoDetails.Rows(i).Cells(16).Value.ToString())
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
	                    SupplierUnitPrice,
	                    ClientUnitPrice,
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
	                    @supunitprice,
                        @cliunitprice,
	                    @updatedby
	                    )")
                            If SQL.HasException Then
                                btnSave.Enabled = True
                                btnSave.Text = "SAVE P.O."
                                msgboxDisplay("Error in saving", 3)
                                Exit Sub
                            End If
                        End If
                    Next
                Else
                    btnSave.Enabled = False
                    btnSave.Text = "Please wait ..."
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
                    THEN 'PO' + replace(convert(VARCHAR(10),getdate(),111),'/','') +'-01' ELSE
                    CASE WHEN right(max(PONo),len(max(PONo))-CHARINDEX('-',max(PONo))) + 1<10
                    THEN 'PO' + replace(convert(VARCHAR(10),getdate(),111),'/','') + '-0'+  cast(right(max(PONo),len(max(PONo))-CHARINDEX('-',max(PONo))) +1 as varchar)
                    ELSE 'PO' + replace(convert(VARCHAR(10),getdate(),111),'/','')+ '-' + cast(right(max(PONo),len(max(PONo))-CHARINDEX('-',max(PONo))) +1 as varchar)
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

                    If SQL.HasException Then
                        btnSave.Enabled = True
                        btnSave.Text = "SAVE P.O."
                        msgboxDisplay("Error in saving", 3)
                        Exit Sub
                    End If

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
                        SQL.AddParams("@supunitprice", dtablePoDetails.Rows(i).Cells(7).Value.ToString())
                        SQL.AddParams("@cliunitprice", dtablePoDetails.Rows(i).Cells(16).Value.ToString())
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
	                    SupplierUnitPrice,
	                    ClientUnitPrice,
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
	                    @supunitprice,
	                    @cliunitprice,
	                    @updatedby
	                    )")
                        If SQL.HasException Then
                            SQL.ExecQuery("delete from PoDetails where PONo=(select max(pono) from poheaders);delete from POHeaders where PONo=(select max(pono) from poheaders);")
                            btnSave.Enabled = True
                            btnSave.Text = "SAVE P.O."
                            msgboxDisplay("Error in saving", 3)
                            Exit Sub
                        End If
                    Next
                End If
                MsgBox("Successfully Save", MsgBoxStyle.Information, "Information")
                ' HeaderClear()
                Me.Close()
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        If Application.OpenForms().OfType(Of SupplierList).Any Then SupplierList.Close()
        If dtablePoDetails.Rows.Count = 0 Then
            formname = "AddPurchaseOrder"
            SupplierList.Show()
        Else
            msgboxDisplay("Cannot be modified already have Purchase Details", 2)
        End If
    End Sub
    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        If Application.OpenForms().OfType(Of SelectionItem).Any Then SelectionItem.Close()
        If dtablePoDetails.Rows.Count > 0 Then
            If dtablePoDetails.SelectedRows(0).Cells(15).Value > 0 And
                dtablePoDetails.SelectedRows(0).Cells(13).Value > 0 And
                btnAddItem.Text = "UPDATE ITEM" Then
                msgboxDisplay("Cannot be modify because it has Invoice", 2)
            End If
        End If
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
        Try
            If String.IsNullOrEmpty(txtItemCode.Text) Or
                String.IsNullOrEmpty(txtCliQty.Text) Or
                String.IsNullOrEmpty(txtSupQty.Text) Then
                MsgBox("Please complete all * important fields!", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            Dim row As ArrayList = New ArrayList
            If btnAddItem.Text = "INSERT ITEM" Then
                btnAddItem.Text = "Please wait ..."
                btnAddItem.Enabled = False
                txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + Val(txtTotalPrice.Text), "0.00")
                dtablePoDetails.Rows.Add(dtablePoDetails.Rows.Count + 1,
                                     txtItemCode.Text, txtItemName.Text,
                                     txtCliQty.Text,
                                     txtCliUnit.Text,
                                     txtSupQty.Text,
                                     txtSupUnit.Text,
                                     getSupplierPrice(txtItemCode.Text, dtIssued.Value, txtSupplier.Text),
                                     txtTotalPrice.Text,
                                     dtETD.Value,
                                     dtETA.Value,
                                     DTFtry.Value,
                                     chkCancel.Checked,
                                     chkReceived.Checked,
                                     "",
                                     "0.00",
                                     getClientPrice(txtItemCode.Text, dtIssued.Value))
            Else
                btnAddItem.Text = "Please wait ..."
                btnAddItem.Enabled = False
                txtTotalAmount.Text = Format(Val(txtTotalAmount.Text) + (Val(txtTotalPrice.Text) - dtablePoDetails.SelectedRows(0).Cells(8).Value), "0.00")
                dtablePoDetails.SelectedRows(0).Cells(1).Value = txtItemCode.Text
                dtablePoDetails.SelectedRows(0).Cells(2).Value = txtItemName.Text
                dtablePoDetails.SelectedRows(0).Cells(3).Value = txtCliQty.Text
                dtablePoDetails.SelectedRows(0).Cells(4).Value = txtCliUnit.Text
                dtablePoDetails.SelectedRows(0).Cells(5).Value = txtSupQty.Text
                dtablePoDetails.SelectedRows(0).Cells(6).Value = txtSupUnit.Text
                dtablePoDetails.SelectedRows(0).Cells(7).Value = getSupplierPrice(txtItemCode.Text, dtIssued.Value, txtSupplier.Text)
                dtablePoDetails.SelectedRows(0).Cells(8).Value = txtTotalPrice.Text
                dtablePoDetails.SelectedRows(0).Cells(9).Value = dtETD.Value
                dtablePoDetails.SelectedRows(0).Cells(10).Value = dtETA.Value
                dtablePoDetails.SelectedRows(0).Cells(11).Value = DTFtry.Value
                dtablePoDetails.SelectedRows(0).Cells(12).Value = chkCancel.Checked
                dtablePoDetails.SelectedRows(0).Cells(13).Value = chkReceived.Checked
                dtablePoDetails.SelectedRows(0).Cells(16).Value = getClientPrice(txtItemCode.Text, dtIssued.Value)

            End If

        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        Finally
            PurchDetailsClear()
        End Try
    End Sub

    Private Sub txtCliQty_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCliQty.KeyUp
        txtSupQty.Text = Val(txtCliQty.Text) * coefficient
        txtTotalPrice.Text = Format(Val(txtSupQty.Text) * Val(txtUnit.Text), "0.00")
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        If dtablePoDetails.Rows.Count > 0 Then
            msgboxDisplay("Cannot be modified already have Purchase Details", 2)
            Exit Sub
        End If
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
        Try
            If dtablePoDetails.SelectedRows(0).Cells(15).Value <= 0 Or
                dtablePoDetails.SelectedRows(0).Cells(13).Value = False Then
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
                chkReceived.Checked = dtablePoDetails.SelectedRows(0).Cells(13).Value.ToString()
                chkReceived.Enabled = True
                chkCancel.Enabled = True
                chkCancel.Checked = dtablePoDetails.SelectedRows(0).Cells(12).Value.ToString()
                btnAddItem.Text = "UPDATE ITEM"
                btnAddItem.Enabled = True
                btnClear.Enabled = True
            Else
                MsgBox("Cannot modify, already received!", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
        End Try
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
        If dtablePoDetails.Rows.Count > 0 Then
            If dtablePoDetails.SelectedRows(0).Cells(15).Value > 0 And
                btnAddItem.Text = "UPDATE ITEM" Then
                msgboxDisplay("Cannot be modify because it has Invoice", 2)
            End If
        End If
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
            where convert(VARCHAR(10),s.AppliedDate,111)<=@IssuedDate and i.ItemId=@ItemId order by AppliedDate desc")
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
        btnAddItem.Text = "INSERT ITEM"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "PRINT"
        Button1.Enabled = False
        loadReport()
    End Sub
    Private Sub loadReport()
        Try
            Dim rptDs As ReportDataSource
            If Application.OpenForms().OfType(Of PrintPreview).Any Then PrintPreview.Close()
            PrintPreview.ReportViewer1.RefreshReport()
            Try
                With PrintPreview.ReportViewer1.LocalReport
                    .ReportPath = "C:\temp\SalesandInventory\Reportdlc\Report1.rdlc"
                    .DataSources.Clear()
                    '.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("PODataset", dt))
                    Dim dt As New DataTable
                    Dim ds As New DataSet1
                    SQL.AddParams("@PONo", txtPONo.Text)
                    SQL.ExecQuery("SELECT pod.ItemId ,i.Description,pod.SupplierUnitPrice,pod.EquivalentQty,(pod.EquivalentQty*pod.SupplierUnitPrice) AS 'Total',
                    poh.PONo,convert(varchar(10),poh.IssuedDate,111) 'IssuedDate',pod.SupplierUnitPrice,poh.TotalAmount,s.SupplierName,s.Phone,s.Fax,s.Address,poh.Remarks,
                    dp.Description AS DeliveryPlaces,td.Description AS TermsOfDelivery,tp.Description AS TermsOfPayment	
                    ,e.EmployeeName 'Encoder', CompanyName,StreetAdress,CityZip,a.Phone 'CompPhone',a.Fax'CompFax',website,CompanyLogo	
                    FROM POHeaders poh 
                    INNER	JOIN PoDetails pod 
                    ON poh.PONo=pod.PoNo
                    INNER JOIN TermsOfDelivery td ON poh.TermOfDeliveryId=td.TermOfDeliveryId
                    INNER JOIN TermsOfPayment tp ON tp.TermOfPaymentId=poh.TermOfPaymentId
                    INNER JOIN DeliveryPlaces dp ON dp.DeliveryPlaceId=poh.DeliveryPlaceId
                    INNER JOIN Employees e ON poh.EncodedStaff=e.EmpId
                    INNER JOIN Items i ON i.ItemId=pod.ItemId 
                    INNER JOIN Suppliers s ON s.SupplierId=poh.SupplierID,
                    companyinfo a
                    where poh.PONo=@PONo")
                    If SQL.HasException Or SQL.DBDT.Rows.Count = 0 Then Exit Sub
                    rptDs = New ReportDataSource("PODataSet", SQL.DBDT)
                    'SQL.ExecQuery("Select * from Companyinfo")
                    'PrintPreview.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                    'rptDs = New ReportDataSource("DataSet1", SQL.DBDT)
                    PrintPreview.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                    PrintPreview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                    PrintPreview.ReportViewer1.ZoomMode = ZoomMode.Percent
                    PrintPreview.ReportViewer1.ZoomPercent = 100
                    PrintPreview.Show()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
                'End With
            Finally
                Button1.Text = "PRINT"
                Button1.Enabled = False
            End Try

            'dt = ds.Tables("PODetails")
            'For i = 0 To dtablePoDetails.Rows.Count - 1
            '    dt.Rows.Add(dtablePoDetails.Rows(i).Cells(1).Value, dtablePoDetails.Rows(i).Cells(2).Value, dtablePoDetails.Rows(i).Cells(5).Value, dtablePoDetails.Rows(i).Cells(7).Value, dtablePoDetails.Rows(i).Cells(8).Value)
            'Next
            'With SaleReports.ReportViewer1.LocalReport
            '    .ReportPath = "C:\Users\smd255\Documents\GitHub\SalesInventory\InventorySystem\InventorySystem\Report1.rdlc"
            '    .DataSources.Clear()
            '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("PODataset", dt))
            'End With
            '
            'SaleReports.ReportViewer1.RefreshReport()
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If dtablePoDetails.SelectedRows(0).Cells(15).Value > 0 Then
            msgboxDisplay("Cannot be deleted it has already have Invoice", 2)
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
                dtablePoDetails.Rows.RemoveAt(dtablePoDetails.SelectedRows(0).Index)
            End If
        End If
    End Sub

    Private Sub cmbTDelivery_GotFocus(sender As Object, e As EventArgs) Handles cmbTDelivery.GotFocus
        LoadDelivery()
    End Sub

    Private Sub cmbDeliveryPlace_GotFocus(sender As Object, e As EventArgs) Handles cmbDeliveryPlace.GotFocus
        LoadDeliveryPlaces()
    End Sub

    Private Sub cmbTPayment_GotFocus(sender As Object, e As EventArgs) Handles cmbTPayment.GotFocus
        LoadPayment()
    End Sub
    Private Sub txtPONo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPONo.KeyPress
        e.Handled = True
    End Sub
    Private Sub dtIssued_KeyDown(sender As Object, e As KeyEventArgs) Handles dtIssued.KeyDown
        If dtablePoDetails.Rows.Count > 0 Then
            msgboxDisplay("Cannot modify IssuedDate there is already a POdetails", 2)
            e.Handled = True
        End If
    End Sub

    Private Sub dtIssued_Click(sender As Object, e As EventArgs) Handles dtIssued.Click
        ' dtIssued.MouseDown()
        If dtablePoDetails.Rows.Count > 0 Then
            msgboxDisplay("Cannot modify IssuedDate already a POdetails", 2)
            cmbTDelivery.Focus()
        End If
    End Sub

    'Private Sub dtIssued_MouseClick(sender As Object, e As MouseEventArgs) Handles dtIssued.MouseClick
    '    If dtablePoDetails.Rows.Count > 0 Then
    '        msgboxDisplay("Cannot modify IssuedDate there is already a POdetails", 2)
    '        cmbTDelivery.Focus()
    '    End If
    'End Sub

    'Private Sub dtIssued_ValueChanged(sender As Object, e As EventArgs) Handles dtIssued.ValueChanged
    '    If dtablePoDetails.Rows.Count > 0 Then
    '        msgboxDisplay("Cannot modify IssuedDate there is already a POdetails", 2)
    '        cmbTDelivery.Focus()
    '    End If
    'End Sub

    Private Sub dtIssued_GotFocus(sender As Object, e As EventArgs) Handles dtIssued.GotFocus
        'issuedVal.Value = dtIssued.Value
        If dtablePoDetails.Rows.Count > 0 Then
            'btnAddItem.Focus()
            dtIssued.Enabled = False
            'msgboxDisplay("Cannot modify IssuedDate there is already a POdetails", 2)
            Exit Sub
        Else
            dtIssued.Enabled = False
        End If
    End Sub

    Private Sub chkReceived_CheckedChanged(sender As Object, e As EventArgs) Handles chkReceived.CheckedChanged
        If dtablePoDetails.SelectedRows(0).Cells(15).Value = 0 And chkReceived.Checked = True Then
            msgboxDisplay("Cannot check received, it does not have invoice", 2)
            chkReceived.Checked = False
        End If
    End Sub

    Private Sub dtIssued_ValueChanged(sender As Object, e As EventArgs) Handles dtIssued.ValueChanged
        Me.Text = dtIssued.Value.ToString
        'dtablePoDetails.Rows.Clear()
    End Sub

    Private Sub dtIssued_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles dtIssued.GiveFeedback

    End Sub

    Private Sub dtablePoDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtablePoDetails.CellContentClick

    End Sub

    'Private Sub chkCancel_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancel.CheckedChanged
    '    If dtablePoDetails.SelectedRows(0).Cells(15).Value > 0 And chkCancel.Checked = True Then
    '        msgboxDisplay("Cannot check cancel, already have invoice", 2)
    '        chkCancel.Checked = False
    '    End If
    'End Sub
End Class