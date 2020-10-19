﻿Public Class AppForm

    Private Sub miItems_Click(sender As Object, e As EventArgs) Handles miItems.Click
        FrmItemSearch.Show()
    End Sub

    Private Sub checkInventory_Click(sender As Object, e As EventArgs) Handles checkInventory.Click

    End Sub
    Private Sub DeliveryPlacesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveryPlacesToolStripMenuItem.Click
        FrmDeliveryPlacesSearch.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginForm.txtUsername.Focus()
        LoginForm.Show()
    End Sub

    Private Sub EntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntryToolStripMenuItem.Click
        With FrmPurchaseOrderEntry
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
        FrmInvoiceEntry.Show()
    End Sub

    Private Sub miCategory_Click(sender As Object, e As EventArgs) Handles miCategory.Click
        FrmCategorySearch.Show()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        FrmQtyUnitSearch.Show()
    End Sub

    Private Sub TermsofDelivery_Click(sender As Object, e As EventArgs) Handles TermsofDelivery.Click
        FrmTermsOfDaliverySearch.Show()
    End Sub

    Private Sub TermsofPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TermsofPaymentToolStripMenuItem.Click
        FrmTermofPaymentSearch.Show()
    End Sub

    Private Sub StockTakingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockTakingToolStripMenuItem.Click
        FrmStockTakingSearch.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem.Click
        FrmStockoutSearch.Show()
    End Sub

    Private Sub LocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationsToolStripMenuItem.Click
        FrmLocationSearch.Show()
    End Sub

    Private Sub ChangSupplierNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangSupplierNameToolStripMenuItem.Click
        EditSupplierName.ShowDialog()
    End Sub

    Private Sub StockOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem1.Click
        FrmStockoutSearch.btnAdd.Visible = False
        FrmStockoutSearch.chkApproved.Checked = False
        FrmStockoutSearch.search()
        FrmStockoutSearch.Show()
    End Sub

    Private Sub StockTakingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockTakingToolStripMenuItem1.Click
        FrmStockTakingSearch.btnAdd.Visible = False
        FrmStockTakingSearch.chkApproved.Checked = False
        FrmStockTakingSearch.Search()
        FrmStockTakingSearch.Show()
    End Sub

    Private Sub ReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivedToolStripMenuItem.Click
        frmInventory.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        FrmSupplierSearch.Show()
    End Sub
End Class