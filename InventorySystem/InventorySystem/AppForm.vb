Public Class AppForm

    Private Sub miItems_Click(sender As Object, e As EventArgs) Handles miItems.Click
        FrmItemSearch.Show()
    End Sub

    Private Sub checkInventory_Click(sender As Object, e As EventArgs) Handles checkInventory.Click

    End Sub
    Private Sub DeliveryPlacesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveryPlacesToolStripMenuItem.Click
        FrmDeliveryPlaces.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginForm.txtUsername.Focus()
        LoginForm.Show()
    End Sub

    Private Sub EntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntryToolStripMenuItem.Click
        With AddPurchaseOrder
            .Text = "Add Purchase Order"
            .btnSave.Visible = True
            .Show()
        End With
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        FrmUser.Show()
    End Sub

    Private Sub AccountDetails_Click(sender As Object, e As EventArgs) Handles AccountDetails.Click
        FrmAccountDetails.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        FrmSearchPO.show()
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        FrmSearchInvoice.Show()
    End Sub

    Private Sub EntryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntryToolStripMenuItem1.Click
        AddInvoice.Show()
    End Sub

    Private Sub miCategory_Click(sender As Object, e As EventArgs) Handles miCategory.Click
        FrmCategory.Show()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        FrmQtyUnit.Show()
    End Sub

    Private Sub TermsofDelivery_Click(sender As Object, e As EventArgs) Handles TermsofDelivery.Click
        FrmTermsofDelivery.Show()
    End Sub

    Private Sub TermsofPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TermsofPaymentToolStripMenuItem.Click
        FrmTermsofPayment.Show()
    End Sub

    Private Sub StockTakingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockTakingToolStripMenuItem.Click
        FrmStockTaking.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem.Click
        FrmStockout.Show()
    End Sub

    Private Sub LocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationsToolStripMenuItem.Click
        FrmLocation.Show()
    End Sub

    Private Sub ChangSupplierNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangSupplierNameToolStripMenuItem.Click
        EditSupplierName.ShowDialog()
    End Sub

    Private Sub StockOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem1.Click
        FrmStockout.btnAdd.Visible = False
        FrmStockout.chkApproved.Checked = False
        FrmStockout.search()
        FrmStockout.Show()
    End Sub

    Private Sub StockTakingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockTakingToolStripMenuItem1.Click
        FrmStockTaking.btnAdd.Visible = False
        FrmStockTaking.chkApproved.Checked = False
        FrmStockTaking.Search()
        FrmStockTaking.Show()
    End Sub

    Private Sub ReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivedToolStripMenuItem.Click
        frmInventory.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Suppliers.Show()
    End Sub
End Class