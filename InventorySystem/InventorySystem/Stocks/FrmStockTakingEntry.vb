﻿Public Class FrmStockTakingEntry
    Private DTCount As Integer
    Public cliprice As Decimal
    Public confirm As Boolean = False
    Private Sub getSTID()
        Try
            SQL.AddParams("@stid", txtStockTakingID.Text)
            SQL.ExecQuery("SELECT st.STID,CountedDate,st.Remarks,
            CASE WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',st.UpdatedDate,
            sd.ItemID,Description,sd.Qty,sd.Remarks, st.ApprovedBy
            from StockTakingHeaders st INNER JOIN StockTakingDetails sd ON
            st.STID=sd.STID INNER JOIN Employees e ON e.EmpId=st.EncodedStaff 
            INNER JOIN Items i ON i.ItemId=sd.ItemID	 
            WHERE st.STID=@stid")

            If SQL.HasException Or SQL.DBDT.Rows.Count = 0 Then Exit Sub

            dtCountedDate.Text = SQL.DBDT.Rows(0).Item(1).ToString
            txtRemarks.Text = SQL.DBDT.Rows(0).Item(2).ToString
            txtEncodedStaff.Text = SQL.DBDT.Rows(0).Item(3).ToString

            For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
                dtableStockTaking.Rows.Add(dtableStockTaking.Rows.Count + 1, SQL.DBDT.Rows(i).Item(4).ToString, SQL.DBDT.Rows(i).Item(5).ToString,
                                     SQL.DBDT.Rows(i).Item(6).ToString, SQL.DBDT.Rows(i).Item(7).ToString,
                                     SQL.DBDT.Rows(i).Item(6).ToString, SQL.DBDT.Rows(i).Item(8).ToString)
            Next
            If Not String.IsNullOrEmpty(SQL.DBDT.Rows(0).Item(9).ToString) Then
                chkApprove.Checked = True
            Else
                chkApprove.Checked = False
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        If Application.OpenForms().OfType(Of SupplierList).Any Then SupplierList.Close()
        formname = "AddStockTaking"
        SelectionItem.Show()
    End Sub
    Private Sub UpdatingData()
        txtItemCode.Enabled = False
        dtCountedDate.Enabled = False
        txtQty.Enabled = False
        txtSTRemarks.Enabled = False
        btnAddItem.Enabled = False
        'dtableStockTaking.Enabled = False
        Label27.Visible = False
        If rights > 2 Or rights = 0 Then
            chkApprove.Enabled = False
            btnSave.Visible = False
            txtRemarks.Enabled = False
        Else
            chkApprove.Enabled = True
        End If
    End Sub
    Private Sub AddingData()
        txtItemCode.Enabled = True
        dtCountedDate.Enabled = True
        txtQty.Enabled = True
        txtSTRemarks.Enabled = True
        dtCountedDate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ' dtCountedDate.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        btnAddItem.Enabled = True
        dtableStockTaking.Enabled = True
        btnSave.Visible = True
        txtRemarks.Enabled = True
        chkApprove.Enabled = False
    End Sub

    Private Sub AddStockTaking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        txtEncodedStaff.Text = moduleName
        If btnSave.Text = "UPDATE" Then
            UpdatingData()
            getSTID()
        Else
            AddingData()
        End If
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemCode.Text)
        If row.Count = 0 Then
            txtItemName.Text = ""
            Exit Sub
        End If
        txtItemName.Text = row.Item(0)
        cliprice = getClientPrice(txtItemCode.Text, dtCountedDate.Value)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            If String.IsNullOrEmpty(txtItemCode.Text) Or
            String.IsNullOrEmpty(txtQty.Text) Then
                MsgBox("Please complete all * important details!", MsgBoxStyle.Exclamation, "Warning")
            End If
            If btnAddItem.Text = "INSERT" Then
                Dim row As ArrayList = New ArrayList

                DTCount += 1
                txtTotalAmount.Text = Val(txtTotalAmount.Text) + (Val(txtQty.Text) * cliprice)
                row.Add(DTCount)
                row.Add(txtItemCode.Text)
                row.Add(txtItemName.Text)
                row.Add(txtQty.Text)
                row.Add(getClientPrice(txtItemCode.Text, dtCountedDate.Value))
                row.Add(Val(txtQty.Text) * getClientPrice(txtItemCode.Text, dtCountedDate.Value))
                row.Add(txtSTRemarks.Text)
                row.Add(getSupplierPrice(txtItemCode.Text, dtCountedDate.Value, ""))
                dtableStockTaking.Rows.Add(row.ToArray())
                StockTakingdetailsClear()
            Else
                FrmConfirmation.ShowDialog()
                If confirm = True Then
                    txtTotalAmount.Text = Val(txtTotalAmount.Text) + ((Val(txtQty.Text) - dtableStockTaking.SelectedRows(0).Cells(3).Value) * cliprice)
                    dtableStockTaking.SelectedRows(0).Cells(1).Value = txtItemCode.Text
                    dtableStockTaking.SelectedRows(0).Cells(2).Value = txtItemName.Text
                    dtableStockTaking.SelectedRows(0).Cells(3).Value = txtQty.Text
                    dtableStockTaking.SelectedRows(0).Cells(4).Value = getClientPrice(txtItemCode.Text, dtCountedDate.Value)
                    dtableStockTaking.SelectedRows(0).Cells(5).Value = Val(txtQty.Text) * getClientPrice(txtItemCode.Text, dtCountedDate.Value)
                    dtableStockTaking.SelectedRows(0).Cells(6).Value = txtRemarks.Text
                    dtableStockTaking.SelectedRows(0).Cells(7).Value = getSupplierPrice(txtItemCode.Text, dtCountedDate.Value, "")
                    StockTakingdetailsClear()
                    btnAddItem.Text = "INSERT"
                    confirm = False
                End If
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub StockTakingdetailsClear()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtQty.Clear()
        txtSTRemarks.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If dtableStockTaking.Rows.Count = 0 Or
            String.IsNullOrWhiteSpace(dtCountedDate.Checked) Then
                MsgBox("Please complete all * important detils", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                If btnSave.Text = "UPDATE" Then
                    If chkApprove.Checked = True Then
                        SQL.AddParams("@approve", moduleId)
                    Else
                        SQL.AddParams("@approve", "")
                    End If
                    SQL.AddParams("@remarks", txtRemarks.Text)
                    SQL.AddParams("@stid", txtStockTakingID.Text)
                    SQL.ExecQuery("UPDATE StockTakingHeaders
	            SET ApprovedBy=(select CASE WHEN @approve='' THEN NULL ELSE @approve end),
                Remarks=@remarks where stid=@stid")
                    If SQL.HasException Then
                        MsgBox("Error in Updating", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                Else
                    SQL.AddParams("@counteddate", dtCountedDate.Value)
                    SQL.AddParams("@encodedstaff", moduleId)
                    SQL.AddParams("@totalamount", txtTotalAmount.Text)
                    SQL.AddParams("@remarks", txtRemarks.Text)
                    SQL.ExecQuery("INSERT INTO dbo.StockTakingHeaders
	                    (STID,CountedDate,EncodedStaff,TotalAmount,Remarks,ApprovedBy,UpdatedBy)
                                VALUES((select 'ST'+replace(convert(date,GETDATE()),'-','') +'-'+ NUM AS 'pomax' FROM
                                (select CASE WHEN (count(*)+1)<10 THEN '0' + CAST(COUNT(*)+1 AS VARCHAR) 
                                ELSE CAST(COUNT(*)+1 AS VARCHAR) END 'num' 
                                from StockTakingHeaders where convert(date,createddate)=convert(date,getdate()))A),@counteddate,@encodedstaff,@totalamount,@remarks,NULL,@encodedstaff)")
                    If SQL.HasException Then
                        MsgBox("Error in saving", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    Dim itemids As String = ""
                    If String.IsNullOrWhiteSpace(txtStockTakingID.Text) Then
                        SQL.ExecQuery("select top 1 STID from StockTakingHeaders order by createddate desc ")
                        itemids = SQL.DBDT.Rows(0).Item(0)
                    Else
                        itemids = txtStockTakingID.Text
                    End If
                    For i As Integer = 0 To dtableStockTaking.Rows.Count - 1
                        SQL.AddParams("@stid", itemids)
                        SQL.AddParams("@itemid", dtableStockTaking.Rows(i).Cells(1).Value.ToString())
                        SQL.AddParams("@qty", dtableStockTaking.Rows(i).Cells(3).Value.ToString())
                        SQL.AddParams("@ClientUnitprice", dtableStockTaking.Rows(i).Cells(4).Value.ToString())
                        SQL.AddParams("@SupplierUnitprice", dtableStockTaking.Rows(i).Cells(4).Value.ToString())
                        SQL.AddParams("@remarks", dtableStockTaking.Rows(i).Cells(5).Value.ToString())
                        SQL.AddParams("@updatedby", moduleId)
                        SQL.ExecQuery("INSERT INTO dbo.StockTakingDetails
	                        (STID,ItemID,Qty,ClientUnitprice,SupplierUnitprice,Remarks,UpdatedBy)
                        VALUES(@stid,
                            @itemid,
                            @qty,
                            @ClientUnitprice,
                            @SupplierUnitprice,
                            @remarks,
                            @updatedby)")
                        If SQL.HasException Then
                            SQL.AddParams("@stid", txtStockTakingID.Text)
                            SQL.ExecQuery("delete from StockTakingDetails where where STID=(SELECT max(STID) from StockTakingHeaders);delete from StockTakingHeaders where STID=(SELECT max(STID) from StockTakingHeaders);")
                            Exit Sub
                        End If
                    Next

                End If
                MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
                Me.Close()
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub chkApprove_CheckedChanged(sender As Object, e As EventArgs) Handles chkApprove.CheckedChanged
        btnSave.Enabled = True
    End Sub

    Private Sub dtPoDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtableStockTaking.CellFormatting
        dtableStockTaking.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Application.OpenForms().OfType(Of ScanItem).Any Then ScanItem.Close()
        formname = "StockTaking"
        ScanItem.Show()
    End Sub

    Private Sub txtStockTakingID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockTakingID.KeyPress
        e.Handled = True
    End Sub

    Private Sub dtableStockTaking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockTaking.CellContentClick

    End Sub

    Private Sub dtableStockTaking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockTaking.CellClick

        Try
            If btnSave.Text = "SAVE" Then
                txtItemCode.Text = dtableStockTaking.SelectedRows(0).Cells(1).Value
                txtItemName.Text = dtableStockTaking.SelectedRows(0).Cells(2).Value
                txtQty.Text = dtableStockTaking.SelectedRows(0).Cells(3).Value
                txtSTRemarks.Text = dtableStockTaking.SelectedRows(0).Cells(6).Value
                btnAddItem.Text = "UPDATE"
            End If
        Catch EX As Exception
            msgboxDisplay(EX.Message, 3)
        End Try
    End Sub
End Class