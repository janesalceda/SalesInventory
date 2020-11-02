Public Class DashBoard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQL.ExecQuery("SELECT count(*) from items i  Where i.deletedDate Is null")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        Label1.Text = SQL.DBDT.Rows(0).Item(0)
        SQL.AddParams("@currentdate", DateTime.Now().ToString("yyyy/MM/dd"))
        SQL.ExecQuery("SELECT count(*) from getstockbalance(@currentdate) where qty>=1")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        Label2.Text = SQL.DBDT.Rows(0).Item(0)
        SQL.AddParams("@currentdate", DateTime.Now().ToString("yyyy/MM/dd"))
        SQL.ExecQuery("SELECT sum(qty) from getstockbalance(@currentdate)  where qty>=1")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        Label3.Text = Math.Floor(SQL.DBDT.Rows(0).Item(0))
        SQL.AddParams("@currentdate", DateTime.Now().ToString("yyyy/MM/dd"))
        SQL.ExecQuery("SELECT count(*) From Items i
             Where i.deletedDate Is null and 
                isnull((SELECT qty FROM GetStockBalance(@currentdate) WHERE itemid=i.ItemId),0)<=MinimumOrderQty 
            or  isnull((SELECT qty FROM GetStockBalance(@currentdate) WHERE itemid=i.ItemId),0)<=OrderingPointQty")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        Label4.Text = SQL.DBDT.Rows(0).Item(0)
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class