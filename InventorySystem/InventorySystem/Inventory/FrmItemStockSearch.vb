Public Class FrmItemStockSearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtitem.Text) Then
            MsgBox("Please input itemid!", MsgBoxStyle.Exclamation, "Warning")
        End If
        SQL.AddParams("@from", dtFrom.Value.ToShortDateString)
        SQL.AddParams("@ItemId", txtitem.Text)
        SQL.ExecQuery("SELECT * FROM dbo.GetStockBalance (@from) where itemid=@itemId")
        If SQL.DBDT.Rows.Count = 0 Then
            MsgBox("No record found!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        Dim row = SQL.DBDT
        SQL.AddParams("@ItemId", txtitem.Text)
        SQL.ExecQuery("SELECT * FROM items itemid=@itemid")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        dgvData.Rows.Add(row.Rows.Item(0), SQL.DBDT.Rows.Item(0), row.Rows.Item(2))
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtitem.Clear()
        dtFrom.Checked = False
        dtFrom.Value = Today
        dgvData.Rows.Clear()
    End Sub
End Class