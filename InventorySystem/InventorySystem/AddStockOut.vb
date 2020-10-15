Public Class AddStockOut
    Private DTCount As Integer
    Private Sub getSCID()
        SQL.ExecQuery("SELECT isnull(max(StockOutCode),0) 'SCmax' from StockOutHeaders")
        If SQL.HasException Then Exit Sub
        Dim result As String
        If SQL.DBDT.Rows(0).Item(0) = "0" Then
            result = "01"
        Else
            result = SQL.DBDT.Rows(0).Item(0)
            result = result.Substring(11, result.Length - 11)
            result = Format(Val(result + 1), "00")
        End If

        txtStockOutID.Text = System.DateTime.Today
        txtStockOutID.Text = "SC" & Replace(txtStockOutID.Text, "/", "", 1) & "-" & result

    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim row As ArrayList = New ArrayList
        DTCount += 1
        row.Add(DTCount)
        row.Add(txtItemCode.Text)
        row.Add(txtItemName.Text)
        row.Add(txtQty.Text)
        row.Add(txtSTRemarks.Text)
        dtPoDetails.Rows.Add(row.ToArray())
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
        SQL.AddParams("@stockoutcode", txtStockOutID.Text)
        SQL.AddParams("@stockoutdate", dtSOutDate.Value)
        SQL.AddParams("@encodedstaff", moduleId)
        SQL.AddParams("@issuedbystaff", txtIssuedBy.Text)
        SQL.AddParams("@remarks", txtRemarks.Text)
        SQL.ExecQuery("INSERT INTO dbo.StockOutHeaders
	        (StockOutCode,StockOutDate,EncodedStaff,IssuedByStaff,ApprovedBy,Remarks,UpdatedBy)
        VALUES(@stockoutcode,@stockoutdate,@encodedstaff,@issuedbystaff,NULL,@remarks,@encodedstaff)")
        If SQL.HasException Then Exit Sub
        For i As Integer = 0 To dtPoDetails.Rows.Count - 1
            SQL.AddParams("@stockoutcode", txtStockOutID.Text)
            SQL.AddParams("@itemseq", dtPoDetails.Rows(i).Cells(0).Value.ToString())
            SQL.AddParams("@itemid", dtPoDetails.Rows(i).Cells(1).Value.ToString())
            SQL.AddParams("@qty", dtPoDetails.Rows(i).Cells(3).Value.ToString())
            SQL.AddParams("@remarks", dtPoDetails.Rows(i).Cells(4).Value.ToString())
            SQL.AddParams("@updatedby", moduleId)
            SQL.ExecQuery("INSERT INTO dbo.StockOutDetails
	            (StockOutCode,ItemSeq,ItemID,Qty,Remarks,UpdatedBy)
            VALUES(@stockoutcode,@itemseq,@itemid,@qty,@remarks,@updatedby)")
            If SQL.HasException Then
                SQL.AddParams("@stockoutcode", txtStockOutID.Text)
                SQL.ExecQuery("delete from StockOutHeaders where StockOutCode=@stockoutcode;delete from StockOutDetails where StockOutCode=@stockoutcode")
                Exit Sub
            End If
        Next
        MsgBox("Successfully Saved", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub AddStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        getSCID()
    End Sub
End Class