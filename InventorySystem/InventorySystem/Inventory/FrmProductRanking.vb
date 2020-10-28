Public Class FrmProductRanking
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SQL.ExecQuery("select i.ItemId,i.Description,isnull(sum(pod.EquivalentQty),0)'Quantity',
            isnull(sum(pod.EquivalentQty*pod.SupplierUnitPrice),0)'TotalSupplier',
            isnull(sum(pod.Qty*pod.ClientUnitPrice),0)'TotalClient' from
            items i left join PoDetails pod on i.ItemId=pod.ItemId
            group by i.ItemId,i.Description

            select i.ItemId,i.Description,isnull(sum(sod.qty),0)'Quantity',
            isnull(sum(sod.Qty*sod.SupplierUnitPrice),0)'TotalSupplier',
            isnull(sum(sod.Qty*sod.ClientUnitPrice),0)'TotalClient' from
            items i left join StockOutDetails sod on i.ItemId=sod.ItemId
            group by i.ItemId,i.Description")
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub
End Class