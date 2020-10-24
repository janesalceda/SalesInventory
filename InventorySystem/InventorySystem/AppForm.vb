Public Class AppForm
    Dim newForm As New List(Of FrmSearchPO)

    Private Sub miItems_Click(sender As Object, e As EventArgs) Handles miItems.Click
        FrmItemSearch.Show()
    End Sub
    Private Sub DeliveryPlacesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveryPlacesToolStripMenuItem.Click
        FrmDeliveryPlacesSearch.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        LoginForm.txtUsername.Focus()
        Close()
    End Sub

    Private Sub EntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntryToolStripMenuItem.Click
        ' Dim FrmPurchaseOrderEntry = New FrmPurchaseOrderEntry
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
        FrmSearchPO.Show()

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
        EditSupplierName.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem1.Click
        With FrmStockoutSearch
            .btnAdd.Visible = False
            .chkApproved.Checked = False
            .chkApproved.Visible = False
            .Text = "Search Request for approval in Stock Out"
            .search()
            .Show()
        End With
    End Sub

    Private Sub StockTakingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockTakingToolStripMenuItem1.Click
        With FrmStockTakingSearch
            .btnAdd.Visible = False
            .chkApproved.Checked = False
            .chkApproved.Visible = False
            .Text = "Search Request for approval in Stock Taking"
            .Search()
            .Show()
        End With
    End Sub

    Private Sub ReceivedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivedToolStripMenuItem.Click
        frmInventory.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        FrmSupplierSearch.Show()
    End Sub

    Private Sub CurrencyUnitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrencyUnitsToolStripMenuItem.Click
        FrmCurrencyUnitSearch.Show()
    End Sub

    Private Sub checkInventory_Click(sender As Object, e As EventArgs) Handles checkInventory.Click
        FrmItemStockSearch.Show()
    End Sub

    Private Sub SalesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem2.Click
        DailyTransaction.Show()
    End Sub

    Private Sub StockMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMonitoringToolStripMenuItem.Click
        ItemStockReport.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem2.Click
        FrmStockOutReport.Show()
    End Sub

    Private Sub StocksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem1.Click
        FrmInventoryStockReport.Show()
    End Sub

    Private Sub RequestRefundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestRefundToolStripMenuItem.Click
        FrmRejectReturnSearch.Show()
    End Sub

    Private Sub CompanyInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyInformationToolStripMenuItem.Click
        FrmCompanyInfo.ShowDialog()
    End Sub

    Private Sub ReturnsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReturnsToolStripMenuItem1.Click
        FrmRejectReturnSearch.Show()
    End Sub

    Private Sub AppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rights > 2 Then
            miSettings.Visible = False
            miUtilities.Visible = False
            RequestApprovalToolStripMenuItem.Visible = False
        End If
    End Sub
End Class