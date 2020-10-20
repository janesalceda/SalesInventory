Public Class FrmItemStockSearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtitem.Clear()
        dtFrom.Checked = False
        dtTo.Checked = False
        dgvData.Rows.Clear()
    End Sub
End Class