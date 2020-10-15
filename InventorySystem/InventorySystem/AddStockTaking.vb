﻿Public Class AddStockTaking
    Private DTCount As Integer
    Private Sub getSTID()
        SQL.ExecQuery("SELECT isnull(max(STID),0) 'STmax' from StockTakingHeaders")
        If SQL.HasException Then Exit Sub
        Dim result As String
        If SQL.DBDT.Rows(0).Item(0) = "0" Then
            result = "01"
        Else
            result = SQL.DBDT.Rows(0).Item(0)
            result = result.Substring(11, result.Length - 11)
            result = Format(Val(result + 1), "00")
        End If

        txtStockTakingID.Text = System.DateTime.Today
        txtStockTakingID.Text = "ST" & Replace(txtStockTakingID.Text, "/", "", 1) & "-" & result

    End Sub
    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        formname = "AddStockTaking"
        SelectionItem.Show()
    End Sub

    Private Sub AddStockTaking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        txtEncodedStaff.Text = moduleName
        getSTID()
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

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim row As ArrayList = New ArrayList
        DTCount += 1
        row.Add(DTCount)
        row.Add(txtItemCode.Text)
        row.Add(txtItemName.Text)
        row.Add(txtQty.Text)
        row.Add(txtSTRemarks.Text)
        dtPoDetails.Rows.Add(row.ToArray())
        StockTakingdetailsClear()
    End Sub
    Private Sub StockTakingdetailsClear()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtQty.Clear()
        txtSTRemarks.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SQL.AddParams("@stid", txtStockTakingID.Text)
        SQL.AddParams("@counteddate", dtCountedDate.Value)
        SQL.AddParams("@encodedstaff", moduleId)
        SQL.AddParams("@remarks", txtRemarks.Text)
        SQL.ExecQuery("INSERT INTO dbo.StockTakingHeaders
	            (STID,CountedDate,EncodedStaff,Remarks,ApprovedBy,UpdatedBy)
            VALUES(@stid,@counteddate,@encodedstaff,@remarks,NULL,@encodedstaff)")
        If SQL.HasException Then Exit Sub
        For i As Integer = 0 To dtPoDetails.Rows.Count - 1

            SQL.AddParams("@stid", txtStockTakingID.Text)
            SQL.AddParams("@itemid", dtPoDetails.Rows(i).Cells(1).Value.ToString())
            SQL.AddParams("@qty", dtPoDetails.Rows(i).Cells(3).Value.ToString())
            SQL.AddParams("@remarks", dtPoDetails.Rows(i).Cells(4).Value.ToString())
            SQL.AddParams("@updatedby", moduleId)
            SQL.ExecQuery("INSERT INTO dbo.StockTakingDetails
	                (STID,ItemID,Qty,Remarks,UpdatedBy)
                VALUES(@stid,@itemid,@qty,@remarks,@updatedby)")
            If SQL.HasException Then
                SQL.AddParams("@stid", txtStockTakingID.Text)
                SQL.ExecQuery("delete from StockTakingHeaders where STID=@stid;delete from StockTakingDetails where where STID=@stid")
                Exit Sub
            End If
        Next
        MsgBox("Successfully Saved", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class