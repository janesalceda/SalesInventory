Imports System.Linq
Public Class AppForm
    Dim newForm As New List(Of FrmSearchPO)

    Private Sub miItems_Click(sender As Object, e As EventArgs) Handles miItems.Click
        If Application.OpenForms().OfType(Of FrmItemSearch).Any Then
            FrmItemSearch.Close()
            FrmItemSearch.Show()
        Else
            FrmItemSearch.Show()
        End If
    End Sub
    Private Sub DeliveryPlaces_Click(sender As Object, e As EventArgs) Handles DeliveryPlaces.Click
        If Application.OpenForms().OfType(Of FrmDeliveryPlacesSearch).Any Then
            FrmDeliveryPlacesSearch.Close()
            FrmDeliveryPlacesSearch.Show()
        Else
            FrmDeliveryPlacesSearch.Show()
        End If
        FrmDeliveryPlacesSearch.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        LoginForm.txtUsername.Focus()
        Close()
    End Sub

    Private Sub PurchaseEntry_Click(sender As Object, e As EventArgs) Handles PurchaseEntry.Click
        ' Dim FrmPurchaseOrderEntry = New FrmPurchaseOrderEntry
        If Application.OpenForms().OfType(Of FrmPurchaseOrderEntry).Any Then
            FrmPurchaseOrderEntry.Close()
            FrmPurchaseOrderEntry.Show()
            With FrmPurchaseOrderEntry
                .Text = "Add Purchase Order"
                .btnSave.Visible = True
                .Show()
            End With
        Else
            With FrmPurchaseOrderEntry
                .Text = "Add Purchase Order"
                .btnSave.Visible = True
                .Show()
            End With
        End If
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmUser).Any Then
            FrmUser.Close()
            FrmUser.Show()
        Else
            FrmUser.Show()
        End If
    End Sub

    Private Sub miAccountDetails_Click(sender As Object, e As EventArgs) Handles miAccountDetails.Click
        If Application.OpenForms().OfType(Of FrmAccountDetails).Any Then
            FrmAccountDetails.Close()
            FrmAccountDetails.Show()
        Else
            FrmAccountDetails.Show()
        End If
    End Sub

    Private Sub PurchaseSearch_Click(sender As Object, e As EventArgs) Handles PurchaseSearch.Click
        If Application.OpenForms().OfType(Of FrmSearchPO).Any Then
            FrmSearchPO.Close()
            FrmSearchPO.Show()
        Else
            FrmSearchPO.Show()
        End If
    End Sub


    Private Sub InvoicePurchase_Click(sender As Object, e As EventArgs) Handles InvoicePurchase.Click
        If Application.OpenForms().OfType(Of FrmSearchInvoice).Any Then
            FrmSearchInvoice.Close()
            FrmSearchInvoice.Show()
        Else
            FrmSearchInvoice.Show()
        End If
    End Sub

    Private Sub InvoiceEntry_Click(sender As Object, e As EventArgs) Handles InvoiceEntry.Click
        If Application.OpenForms().OfType(Of FrmInvoiceEntry).Any Then
            FrmInvoiceEntry.Close()
            FrmInvoiceEntry.Show()
        Else
            FrmInvoiceEntry.Show()
        End If
    End Sub

    Private Sub miCategory_Click(sender As Object, e As EventArgs) Handles miCategory.Click
        If Application.OpenForms().OfType(Of FrmCategorySearch).Any Then
            FrmCategorySearch.Close()
            FrmCategorySearch.Show()
        Else
            FrmCategorySearch.Show()
        End If
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmQtyUnitSearch).Any Then
            FrmQtyUnitSearch.Close()
            FrmQtyUnitSearch.Show()
        Else
            FrmQtyUnitSearch.Show()
        End If
    End Sub

    Private Sub TermsofDelivery_Click(sender As Object, e As EventArgs) Handles TermsofDelivery.Click
        If Application.OpenForms().OfType(Of FrmTermsOfDaliverySearch).Any Then
            FrmTermsOfDaliverySearch.Close()
            FrmTermsOfDaliverySearch.Show()
        Else
            FrmTermsOfDaliverySearch.Show()
        End If
    End Sub

    Private Sub TermsofPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TermsofPaymentToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmTermofPaymentSearch).Any Then
            FrmTermofPaymentSearch.Close()
            FrmTermofPaymentSearch.Show()
        Else
            FrmTermofPaymentSearch.Show()
        End If
        FrmTermofPaymentSearch.Show()
    End Sub

    Private Sub StockTaking_Click(sender As Object, e As EventArgs) Handles StockTaking.Click

        If Application.OpenForms().OfType(Of FrmStockTakingSearch).Any Then
            FrmStockTakingSearch.Close()
            FrmStockTakingSearch.Show()
        Else
            FrmStockTakingSearch.Show()
        End If
    End Sub

    Private Sub StockOut_Click(sender As Object, e As EventArgs) Handles StockOut.Click
        If Application.OpenForms().OfType(Of FrmStockoutSearch).Any Then
            FrmStockoutSearch.Close()
            FrmStockoutSearch.Show()
        Else
            FrmStockoutSearch.Show()
        End If
    End Sub

    Private Sub miLocations_Click(sender As Object, e As EventArgs) Handles miLocations.Click
        If Application.OpenForms().OfType(Of FrmLocationSearch).Any Then
            FrmLocationSearch.Close()
            FrmLocationSearch.Show()
        Else
            FrmLocationSearch.Show()
        End If
    End Sub

    Private Sub ChangSupplierNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangSupplierNameToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmChangeSupplierName).Any Then
            FrmChangeSupplierName.Close()
            FrmChangeSupplierName.Show()
        Else
            FrmChangeSupplierName.Show()
        End If
    End Sub

    'Private Sub StockOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem1.Click
    '    With FrmStockoutSearch
    '        .btnAdd.Visible = False
    '        .chkApproved.Checked = False
    '        .chkApproved.Visible = False
    '        .Text = "Search Request for approval in Stock Out"
    '        .search()
    '        .Show()
    '    End With
    'End Sub

    'Private Sub StockTakingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockTakingToolStripMenuItem1.Click
    '    With FrmStockTakingSearch
    '        .btnAdd.Visible = False
    '        .chkApproved.Checked = False
    '        .chkApproved.Visible = False
    '        .Text = "Search Request for approval in Stock Taking"
    '        .Search()
    '        .Show()
    '    End With
    'End Sub

    Private Sub InventoryRecord_Click(sender As Object, e As EventArgs) Handles InventoryRecord.Click
        If Application.OpenForms().OfType(Of frmInventory).Any Then
            frmInventory.Close()
            frmInventory.Show()
        Else
            frmInventory.Show()
        End If
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmSupplierSearch).Any Then
            FrmSupplierSearch.Close()
            FrmSupplierSearch.Show()
        Else
            FrmSupplierSearch.Show()
        End If
    End Sub

    Private Sub CurrencyUnits_Click(sender As Object, e As EventArgs) Handles CurrencyUnits.Click
        If Application.OpenForms().OfType(Of FrmCurrencyUnitSearch).Any Then
            FrmCurrencyUnitSearch.Close()
            FrmCurrencyUnitSearch.Show()
        Else
            FrmCurrencyUnitSearch.Show()
        End If
    End Sub

    Private Sub InventoryStocks_Click(sender As Object, e As EventArgs) Handles InventoryStocks.Click
        If Application.OpenForms().OfType(Of FrmItemStockSearch).Any Then
            FrmItemStockSearch.Close()
            FrmItemStockSearch.Show()
        Else
            FrmItemStockSearch.Show()
        End If
    End Sub

    Private Sub SalesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem2.Click
        If Application.OpenForms().OfType(Of DailyTransaction).Any Then
            DailyTransaction.Close()
            DailyTransaction.Show()
        Else
            DailyTransaction.Show()
        End If
    End Sub

    Private Sub StockMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMonitoringToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of ItemStockReport).Any Then
            ItemStockReport.Close()
            ItemStockReport.Show()
        Else
            ItemStockReport.Show()
        End If
        ItemStockReport.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem2.Click
        If Application.OpenForms().OfType(Of FrmStockOutReport).Any Then
            FrmStockOutReport.Close()
            FrmStockOutReport.Show()
        Else
            FrmStockOutReport.Show()
        End If
    End Sub

    Private Sub StocksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem1.Click
        If Application.OpenForms().OfType(Of FrmInventoryStockReport).Any Then
            FrmInventoryStockReport.Close()
            FrmInventoryStockReport.Show()
        Else
            FrmInventoryStockReport.Show()
        End If
    End Sub

    Private Sub RequestReturn_Click(sender As Object, e As EventArgs) Handles RequestRefundToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmRejectReturnSearch).Any Then
            FrmRejectReturnSearch.Close()
            FrmRejectReturnSearch.Show()
        Else
            FrmRejectReturnSearch.Show()
        End If
    End Sub

    Private Sub CompanyInformation_Click(sender As Object, e As EventArgs) Handles CompanyInformation.Click
        If Application.OpenForms().OfType(Of FrmCompanyInfo).Any Then
            FrmCompanyInfo.Close()
            FrmCompanyInfo.Show()
        Else
            FrmCompanyInfo.Show()
        End If
    End Sub

    Private Sub AppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rights = 4 Then
            miCategory.Visible = False
            CurrencyUnits.Visible = False
            DeliveryPlaces.Visible = False
            miLocations.Visible = False
            SuppliersToolStripMenuItem.Visible = False
            UsersToolStripMenuItem.Visible = False
            TermsofDelivery.Visible = False
            TermsofPaymentToolStripMenuItem.Visible = False
            SalesToolStripMenuItem1.Visible = False
            UserToolStripMenuItem.Visible = False
            CompanyInformation.Visible = False
            miStocks.Visible = False
            miUtilities.Visible = False
            MiInventory.Visible = False
            RequestReturn.Visible = False
            'RequestApprovalToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmChangeUOM).Any Then
            FrmChangeUOM.Close()
            FrmChangeUOM.Show()
        Else
            FrmChangeUOM.Show()
        End If
    End Sub

    Private Sub ChangeDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeDescriptionToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmChangeItemDescription).Any Then
            FrmChangeItemDescription.Close()
            FrmChangeItemDescription.Show()
        Else
            FrmChangeItemDescription.Show()
        End If
    End Sub


    Private Sub ProductRanking_Click(sender As Object, e As EventArgs) Handles ProductRanking.Click
        If Application.OpenForms().OfType(Of SalesRecord).Any Then
            FrmProductRanking.Close()
            FrmProductRanking.Show()
        Else
            FrmProductRanking.Show()
        End If
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of SalesRecord).Any Then
            SalesRecord.Close()
            SalesRecord.Show()
        Else
            SalesRecord.Show()
        End If
    End Sub

    Private Sub DashBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashBoardToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of DashBoard).Any Then
            DashBoard.Close()
            DashBoard.Show()
        Else
            DashBoard.Show()
        End If
    End Sub
End Class