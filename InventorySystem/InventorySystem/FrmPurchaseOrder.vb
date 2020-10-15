Public Class FrmPurchaseOrder
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddPurchaseOrder.Show()

    End Sub

    Private Sub FrmPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class