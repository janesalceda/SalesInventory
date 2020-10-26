Public Class SalesRecord
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
        SQL.AddParams("@to", dtTo.Value.ToString("yyyy/MM/dd"))
        Dim where As String = ""
        If Not String.IsNullOrWhiteSpace(txtitem.Text) Then
            SQL.AddParams("@itemid", txtitem.Text)
            where = " and itemid=@itemid "
        End If
        SQL.ExecQuery("SELECT TransactionTypeId,s.ItemId,sum(qty) 'Qty' ,
            CASE WHEN TransactionTypeId=2 THEN sum(qty) * unitprice
            WHEN TransactionTypeId=3 THEN sum(qty) * unitprice END 'Cost'
            FROM SAMPLEINV s
            INNER JOIN ClientItemPrices c ON s.ItemId=c.ItemId
            WHERE convert(VARCHAR(10),TransactedDate,111) BETWEEN @from AND @to " & where &
            "GROUP BY TransactionTypeId,s.ItemId,unitprice")
        If SQL.HasException Then Exit Sub
        If SQL.DBDT.Rows.Count = 0 Then
            msgboxDisplay("No Record Found", 1)
            Exit Sub
        End If
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dgvData.Rows.Add(SQL.DBDT.Rows(i).Item("TransactionTypeId"), SQL.DBDT.Rows(i).Item("ItemId"),
            SQL.DBDT.Rows(i).Item("Qty"), SQL.DBDT.Rows(i).Item("Cost"))
        Next


    End Sub
End Class