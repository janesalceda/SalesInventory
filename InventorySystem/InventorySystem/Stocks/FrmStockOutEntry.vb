﻿Imports Microsoft.Reporting.WinForms
Public Class FrmStockOutEntry
    Private DTCount As Integer
    Public cliprice As Decimal
    Public confirm As Boolean = False
    Private Sub UpdatingData()
        txtItemCode.Enabled = False
        dtSOutDate.Enabled = False
        txtQty.Enabled = False
        txtSTRemarks.Enabled = False
        btnAddItem.Enabled = False
        txtIssuedBy.Enabled = False
        Label27.Visible = False
        'dtableStockout.Enabled = False
        ' If rights > 2 Or rights = 0 Then
        'chkApprove.Enabled = False
        btnSave.Visible = False
        btnAddItem.Visible = False
        ' txtRemarks.Enabled = False
        'Else
        'chkApprove.Enabled = True
        'End If
    End Sub
    Private Sub AddingData()
        txtItemCode.Enabled = True
        dtSOutDate.Enabled = True
        txtQty.Enabled = True
        txtSTRemarks.Enabled = True
        btnAddItem.Enabled = True
        txtIssuedBy.Enabled = True
        dtableStockout.Enabled = True
        btnSave.Visible = True
        txtRemarks.Enabled = True
        dtableStockout.Rows.Clear()
        txtItemCode.Clear()
        dtSOutDate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtSOutDate.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        txtQty.Clear()
        txtSTRemarks.Clear()
        txtIssuedBy.Text = moduleName
        txtRemarks.Clear()
        'chkApprove.Enabled = False
    End Sub
    Private Sub getSCID()
        SQL.AddParams("@stid", txtStockOutID.Text)
        SQL.ExecQuery("SELECT st.StockOutCode,StockOutDate,st.Remarks,
            CASE WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',st.UpdatedDate,
            sd.ItemID,Description,sd.Qty,sd.Remarks, st.ApprovedBy,IssuedByStaff,st.TotalAmount,sd.ClientUnitprice,sd.SupplierUnitprice
            from StockOutHeaders st INNER JOIN StockOutDetails sd ON
            st.StockOutCode=sd.StockOutCode INNER JOIN Employees e ON e.EmpId=st.EncodedStaff 
            INNER JOIN Items i ON i.ItemId=sd.ItemID	 
            WHERE st.StockOutCode=@stid")

        If SQL.HasException Or SQL.DBDT.Rows.Count = 0 Then Exit Sub

        dtSOutDate.Text = SQL.DBDT.Rows(0).Item(1).ToString
        txtRemarks.Text = SQL.DBDT.Rows(0).Item(2).ToString
        txtEncodedStaff.Text = SQL.DBDT.Rows(0).Item(3).ToString
        txtIssuedBy.Text = SQL.DBDT.Rows(0).Item(10).ToString
        txtTotalAmount.Text = SQL.DBDT.Rows(0).Item(11)

        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtableStockout.Rows.Add(dtableStockout.Rows.Count + 1, SQL.DBDT.Rows(i).Item("ItemID").ToString, SQL.DBDT.Rows(i).Item("Description"),
                                 SQL.DBDT.Rows(i).Item("Qty").ToString, SQL.DBDT.Rows(i).Item("ClientUnitprice"),
                                 (SQL.DBDT.Rows(i).Item("Qty") * SQL.DBDT.Rows(i).Item("ClientUnitprice")), SQL.DBDT.Rows(i).Item("Remarks"), SQL.DBDT.Rows(i).Item("SupplierUnitprice"))
        Next
    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            If String.IsNullOrWhiteSpace(txtQty.Text) Or
                String.IsNullOrWhiteSpace(txtItemCode.Text) Then
                MsgBox("Please complete all * import details!", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            If btnAddItem.Text = "INSERT" Then
                Dim row As ArrayList = New ArrayList
                DTCount += 1
                txtTotalAmount.Text = Val(txtTotalAmount.Text) + (Val(txtQty.Text) * cliprice)
                row.Add(dtableStockout.Rows.Count + 1)
                row.Add(txtItemCode.Text)
                row.Add(txtItemName.Text)
                row.Add(txtQty.Text)
                row.Add(getClientPrice(txtItemCode.Text, dtSOutDate.Value))
                row.Add(Val(txtQty.Text) * getClientPrice(txtItemCode.Text, dtSOutDate.Value))
                row.Add(txtSTRemarks.Text)
                row.Add(getSupplierPrice(txtItemCode.Text, dtSOutDate.Value, ""))
                dtableStockout.Rows.Add(row.ToArray())
                StockOutdetailsClear()
            Else
                FrmConfirmation.ShowDialog()
                If confirm = True Then
                    txtTotalAmount.Text = Val(txtTotalAmount.Text) + ((Val(txtQty.Text) - dtableStockout.SelectedRows(0).Cells(3).Value) * cliprice)
                    dtableStockout.SelectedRows(0).Cells(1).Value = txtItemCode.Text
                    dtableStockout.SelectedRows(0).Cells(2).Value = txtItemName.Text
                    dtableStockout.SelectedRows(0).Cells(3).Value = txtQty.Text
                    dtableStockout.SelectedRows(0).Cells(4).Value = getClientPrice(txtItemCode.Text, dtSOutDate.Value)
                    dtableStockout.SelectedRows(0).Cells(5).Value = Val(txtQty.Text) * getClientPrice(txtItemCode.Text, dtSOutDate.Value)
                    dtableStockout.SelectedRows(0).Cells(6).Value = txtSTRemarks.Text
                    dtableStockout.SelectedRows(0).Cells(7).Value = getSupplierPrice(txtItemCode.Text, dtSOutDate.Value, "")
                    btnAddItem.Text = "INSERT"
                    confirm = False
                    StockOutdetailsClear()
                End If
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub StockOutdetailsClear()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtQty.Clear()
        txtSTRemarks.Clear()
        btnAddItem.Text = "INSERT"
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        If Application.OpenForms().OfType(Of SelectionItem).Any Then SelectionItem.Close()
        formname = "AddStockOut"
        SelectionItem.Show()
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        Dim row As New ArrayList
        row = GetItemDetails(txtItemCode.Text)
        If row.Count = 0 Then
            txtItemName.Text = ""
            Exit Sub
        End If
        txtItemName.Text = row.Item(0)
        cliprice = getClientPrice(txtItemCode.Text, dtSOutDate.Value)
    End Sub
    Private Function checkingSaving() As String
        Dim msg As String
        msg = "Please complete required fields: " & vbNewLine
        If dtableStockout.Rows.Count = 0 Then
            msg += "*Items" & vbNewLine
        End If
        If String.IsNullOrWhiteSpace(txtIssuedBy.Text) Then
            msg += "*IssuedBy"
        End If
        Return msg
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If dtableStockout.Rows.Count = 0 Or
            String.IsNullOrWhiteSpace(txtIssuedBy.Text) Then
                MsgBox(checkingSaving, MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If


            If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                If btnSave.Text = "UPDATE" Then
                    SQL.AddParams("@remarks", txtRemarks.Text)
                    SQL.AddParams("@StockOutCode", txtStockOutID.Text)
                    SQL.ExecQuery("UPDATE StockOutHeaders
	            SET ApprovedBy=(select CASE WHEN @approve='' THEN NULL ELSE @approve end),
                Remarks=@remarks where StockOutCode=@stockoutcode")
                    If SQL.HasException Then
                        MsgBox("Error in Updating", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                Else
                    SQL.AddParams("@stockoutdate", dtSOutDate.Value)
                    SQL.AddParams("@encodedstaff", moduleId)
                    SQL.AddParams("@totalamount", txtTotalAmount.Text)
                    SQL.AddParams("@issuedbystaff", txtIssuedBy.Text)
                    SQL.AddParams("@remarks", txtRemarks.Text)
                    SQL.ExecQuery("INSERT INTO dbo.StockOutHeaders
	                    (StockOutCode,StockOutDate,TotalAmount,EncodedStaff,IssuedByStaff,ApprovedBy,Remarks,UpdatedBy)
                        VALUES((select 'SC'+replace(convert(date,GETDATE()),'-','') +'-'+ NUM AS 'pomax' FROM
                            (select CASE WHEN (count(*)+1)<10 THEN '0' + CAST(COUNT(*)+1 AS VARCHAR) 
                            ELSE CAST(COUNT(*)+1 AS VARCHAR) END 'num' 
                            from StockOutHeaders where convert(date,createddate)=convert(date,getdate()))A
                        ),@stockoutdate,@totalamount,@encodedstaff,@issuedbystaff,NULL,@remarks,@encodedstaff)")
                    If SQL.HasException Then Exit Sub
                    Dim itemids As String = ""
                    If String.IsNullOrWhiteSpace(txtStockOutID.Text) Then
                        SQL.ExecQuery("select top 1 StockOutCode from StockOutHeaders order by createddate desc ")
                        itemids = SQL.DBDT.Rows(0).Item(0)
                    Else
                        itemids = txtStockOutID.Text
                    End If
                    For i As Integer = 0 To dtableStockout.Rows.Count - 1
                        SQL.AddParams("@stockoutcode", itemids)
                        SQL.AddParams("@itemseq", dtableStockout.Rows(i).Cells(0).Value)
                        SQL.AddParams("@itemid", dtableStockout.Rows(i).Cells(1).Value.ToString())
                        SQL.AddParams("@qty", dtableStockout.Rows(i).Cells(3).Value)
                        SQL.AddParams("@SupplierUnitprice", dtableStockout.Rows(i).Cells(7).Value)
                        SQL.AddParams("@ClientUnitprice", dtableStockout.Rows(i).Cells(4).Value)
                        SQL.AddParams("@remarks", dtableStockout.Rows(i).Cells(6).Value.ToString())
                        SQL.AddParams("@updatedby", moduleId)
                        SQL.ExecQuery("INSERT INTO dbo.StockOutDetails
	                    (StockOutCode,ItemSeq,ItemID,Qty,ClientUnitprice,SupplierUnitprice,Remarks,UpdatedBy)
                        VALUES(@stockoutcode,
                        @itemseq,@itemid,@qty,@ClientUnitprice,@SupplierUnitprice,
                        @remarks,@updatedby)")
                        If SQL.HasException Then
                            SQL.AddParams("@stockoutcode", txtStockOutID.Text)
                            SQL.ExecQuery("delete from StockOutDetails where StockOutCode=(SELECT max(STID) from StockTakingHeaders);delete from StockOutHeaders where StockOutCode=(SELECT max(STID) from StockTakingHeaders);")
                            Exit Sub
                        End If
                    Next
                End If
                MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
                If MsgBox("Do you want to print delivery receipt?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                    printDeliveryReceipt()
                End If
                If rights = 3 Then
                    AddingData()
                Else
                    FrmStockoutSearch.btnSearch.PerformClick()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub printDeliveryReceipt()
        btnSave.Text = "Please wait ..."
        btnSave.Enabled = False
        SQL.params.Clear()
        PrintingDeliveryReceipt.ReportViewer1.RefreshReport()
        Try
            SQL.ExecQuery("SELECT CompanyLogo FROM CompanyInfo")
            For i = 0 To dtableStockout.Rows.Count - 1
                DataSet71.DataTable1.AddDataTable1Row(dtableStockout.Rows(i).Cells(1).Value, dtableStockout.Rows(i).Cells(2).Value,
                            dtableStockout.Rows(i).Cells(3).Value, dtableStockout.Rows(i).Cells(4).Value,
                            dtableStockout.Rows(i).Cells(5).Value, SQL.DBDT.Rows(0).Item(0), dtSOutDate.Value, "")
            Next
            PrintingDeliveryReceipt.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            PrintingDeliveryReceipt.ReportViewer1.ZoomMode = ZoomMode.Percent
            PrintingDeliveryReceipt.ReportViewer1.ZoomPercent = 100
            PrintingDeliveryReceipt.barcode = DataSet71.DataTable1
            PrintingDeliveryReceipt.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
            Exit Sub
        Finally
            btnSave.Text = "SAVE"
            btnSave.Enabled = True
        End Try
    End Sub

    Private Sub AddStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MdiParent = AppForm
        txtEncodedStaff.Text = moduleName
        If btnSave.Text = "UPDATE" Then
            UpdatingData()
            getSCID()
        Else
            AddingData()
        End If
    End Sub


    Private Sub dtPoDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtableStockout.CellFormatting
        dtableStockout.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Application.OpenForms().OfType(Of ScanItem).Any Then ScanItem.Close()

        formname = "StockOut"
        ScanItem.Show()
    End Sub
    Private Sub dtableStockout_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockout.CellClick
        Try
            If btnSave.Text = "SAVE" Then
                txtItemCode.Text = dtableStockout.SelectedRows(0).Cells(1).Value
                txtItemName.Text = dtableStockout.SelectedRows(0).Cells(2).Value
                txtQty.Text = dtableStockout.SelectedRows(0).Cells(3).Value
                txtSTRemarks.Text = dtableStockout.SelectedRows(0).Cells(6).Value
                btnAddItem.Text = "UPDATE"
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub txtStockOutID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockOutID.KeyPress
        e.Handled = True
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        LoginForm.txtUsername.Focus()
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub txtStockOutID_TextChanged(sender As Object, e As EventArgs) Handles txtStockOutID.TextChanged

    End Sub


    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        printDeliveryReceipt()
    End Sub

    Private Sub dtableStockout_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockout.CellContentClick

    End Sub
End Class