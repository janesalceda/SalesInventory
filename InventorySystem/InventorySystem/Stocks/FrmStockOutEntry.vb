Public Class FrmStockOutEntry
    Private DTCount As Integer
    Private Sub UpdatingData()
        txtItemCode.Enabled = False
        dtSOutDate.Enabled = False
        txtQty.Enabled = False
        txtSTRemarks.Enabled = False
        btnAddItem.Enabled = False
        txtIssuedBy.Enabled = False
        dtableStockout.Enabled = False
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
        dtSOutDate.Enabled = True
        txtQty.Enabled = True
        txtSTRemarks.Enabled = True
        btnAddItem.Enabled = True
        txtIssuedBy.Enabled = True
        dtableStockout.Enabled = True
        btnSave.Visible = True
        txtRemarks.Enabled = True
        chkApprove.Enabled = False
    End Sub
    Private Sub getSCID()
        SQL.AddParams("@stid", txtStockOutID.Text)
        SQL.ExecQuery("SELECT st.StockOutCode,StockOutDate,st.Remarks,
            CASE WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',st.UpdatedDate,
            sd.ItemID,Description,sd.Qty,sd.Remarks, st.ApprovedBy,IssuedByStaff
            from StockOutHeaders st INNER JOIN StockOutDetails sd ON
            st.StockOutCode=sd.StockOutCode INNER JOIN Employees e ON e.EmpId=st.EncodedStaff 
            INNER JOIN Items i ON i.ItemId=sd.ItemID	 
            WHERE st.StockOutCode=@stid")

        If SQL.HasException Or SQL.DBDT.Rows.Count = 0 Then Exit Sub

        dtSOutDate.Text = SQL.DBDT.Rows(0).Item(1).ToString
        txtRemarks.Text = SQL.DBDT.Rows(0).Item(2).ToString
        txtEncodedStaff.Text = SQL.DBDT.Rows(0).Item(3).ToString
        txtIssuedBy.Text = SQL.DBDT.Rows(0).Item(10).ToString

        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtableStockout.Rows.Add(SQL.DBDT.Rows(i).Item(4).ToString, SQL.DBDT.Rows(i).Item(5).ToString,
                                 SQL.DBDT.Rows(i).Item(6).ToString, SQL.DBDT.Rows(i).Item(7).ToString,
                                 SQL.DBDT.Rows(i).Item(6).ToString, SQL.DBDT.Rows(i).Item(8).ToString)
        Next
        If Not String.IsNullOrEmpty(SQL.DBDT.Rows(0).Item(9).ToString) Then
            chkApprove.Checked = True
        Else
            chkApprove.Checked = False
        End If

    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If String.IsNullOrWhiteSpace(txtQty.Text) Or
                String.IsNullOrWhiteSpace(txtItemCode.Text) Then
            MsgBox("Please complete all * import details!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        Dim row As ArrayList = New ArrayList
        DTCount += 1
        row.Add(DTCount)
        row.Add(txtItemCode.Text)
        row.Add(txtItemName.Text)
        row.Add(txtQty.Text)
        row.Add(txtSTRemarks.Text)
        dtableStockout.Rows.Add(row.ToArray())
        StockOutdetailsClear()
    End Sub
    Private Sub StockOutdetailsClear()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtQty.Clear()
        txtSTRemarks.Clear()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        formname = "AddStockOut"
        SelectionItem.Show()
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemCode.Text)
        If row.Count = 0 Then
            txtItemName.Text = ""
            Exit Sub
        End If
        txtItemName.Text = row.Item(0)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dtableStockout.Rows.Count = 0 Or
            String.IsNullOrWhiteSpace(txtIssuedBy.Text) Or
            dtSOutDate.Checked = False Then
            MsgBox("Please complete all * import details!", MsgBoxStyle.Exclamation, "Warning")
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
                SQL.AddParams("@issuedbystaff", txtIssuedBy.Text)
                SQL.AddParams("@remarks", txtRemarks.Text)
                SQL.ExecQuery("INSERT INTO dbo.StockOutHeaders
	        (StockOutCode,StockOutDate,EncodedStaff,IssuedByStaff,ApprovedBy,Remarks,UpdatedBy)
        VALUES((SELECT CASE WHEN max(StockOutCode) IS NULL 
                    THEN 'SC' + replace(convert(VARCHAR(12),getdate(),111),'/','') +'-01' ELSE
                    CASE WHEN Cast(right(max(StockOutCode),len(max(StockOutCode))-12) AS INT) +1<10
                    THEN 'SC' + replace(convert(VARCHAR(12),getdate(),111),'/','') + '-0'+ cast(Cast(right(max(StockOutCode),len(max(StockOutCode))-12) AS INT) +1 AS VARCHAR	)
                    ELSE 'SC' + replace(convert(VARCHAR(12),getdate(),111),'/','')+ '-' +cast(Cast(right(max(StockOutCode),len(max(StockOutCode))-12) AS INT) +1 AS VARCHAR	)
                    END END AS 'pomax' from StockOutHeaders),@stockoutdate,@encodedstaff,@issuedbystaff,NULL,@remarks,@encodedstaff)")
                If SQL.HasException Then Exit Sub
                For i As Integer = 0 To dtableStockout.Rows.Count - 1
                    SQL.AddParams("@stockoutcode", txtStockOutID.Text)
                    SQL.AddParams("@itemseq", dtableStockout.Rows(i).Cells(0).Value.ToString())
                    SQL.AddParams("@itemid", dtableStockout.Rows(i).Cells(1).Value.ToString())
                    SQL.AddParams("@qty", dtableStockout.Rows(i).Cells(3).Value.ToString())
                    SQL.AddParams("@remarks", dtableStockout.Rows(i).Cells(4).Value.ToString())
                    SQL.AddParams("@updatedby", moduleId)
                    SQL.ExecQuery("INSERT INTO dbo.StockOutDetails
	            (StockOutCode,ItemSeq,ItemID,Qty,Remarks,UpdatedBy)
            VALUES((SELECT max(StockOutCode) from StockOutHeaders),@itemseq,@itemid,@qty,@remarks,@updatedby)")
                    If SQL.HasException Then
                        SQL.AddParams("@stockoutcode", txtStockOutID.Text)
                        SQL.ExecQuery("delete from StockOutDetails where StockOutCode=(SELECT max(STID) from StockTakingHeaders);delete from StockOutHeaders where StockOutCode=(SELECT max(STID) from StockTakingHeaders);")
                        Exit Sub
                    End If
                Next
            End If
            MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
            FrmStockoutSearch.btnSearch.PerformClick()
            Me.Close()
        End If
    End Sub

    Private Sub AddStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
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

End Class