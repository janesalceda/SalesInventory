<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.Account = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAccountDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoicePurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestRefundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miStocks = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTaking = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryStocks = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductRanking = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrencyUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveryPlaces = New System.Windows.Forms.ToolStripMenuItem()
        Me.miItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.miLocations = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsofDelivery = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsofPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miUtilities = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangSupplierNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.AutoSize = False
        Me.msMain.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Account, Me.PurchasesToolStripMenuItem, Me.InvoicesToolStripMenuItem, Me.RequestReturn, Me.miStocks, Me.MiInventory, Me.miSettings, Me.miUtilities, Me.ReturnsToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.DashBoardToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.msMain.Size = New System.Drawing.Size(1231, 27)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "MenuStrip1"
        '
        'Account
        '
        Me.Account.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAccountDetails})
        Me.Account.Name = "Account"
        Me.Account.Size = New System.Drawing.Size(73, 21)
        Me.Account.Text = "Account"
        '
        'miAccountDetails
        '
        Me.miAccountDetails.Name = "miAccountDetails"
        Me.miAccountDetails.Size = New System.Drawing.Size(178, 22)
        Me.miAccountDetails.Text = "Account Details"
        '
        'PurchasesToolStripMenuItem
        '
        Me.PurchasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseEntry, Me.PurchaseSearch})
        Me.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem"
        Me.PurchasesToolStripMenuItem.Size = New System.Drawing.Size(91, 21)
        Me.PurchasesToolStripMenuItem.Text = "Purchases"
        '
        'PurchaseEntry
        '
        Me.PurchaseEntry.Name = "PurchaseEntry"
        Me.PurchaseEntry.Size = New System.Drawing.Size(123, 22)
        Me.PurchaseEntry.Text = "Entry"
        '
        'PurchaseSearch
        '
        Me.PurchaseSearch.Name = "PurchaseSearch"
        Me.PurchaseSearch.Size = New System.Drawing.Size(123, 22)
        Me.PurchaseSearch.Text = "Search"
        '
        'InvoicesToolStripMenuItem
        '
        Me.InvoicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceEntry, Me.InvoicePurchase})
        Me.InvoicesToolStripMenuItem.Name = "InvoicesToolStripMenuItem"
        Me.InvoicesToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.InvoicesToolStripMenuItem.Text = "Invoices"
        '
        'InvoiceEntry
        '
        Me.InvoiceEntry.Name = "InvoiceEntry"
        Me.InvoiceEntry.Size = New System.Drawing.Size(123, 22)
        Me.InvoiceEntry.Text = "Entry"
        '
        'InvoicePurchase
        '
        Me.InvoicePurchase.Name = "InvoicePurchase"
        Me.InvoicePurchase.Size = New System.Drawing.Size(123, 22)
        Me.InvoicePurchase.Text = "Search"
        '
        'RequestReturn
        '
        Me.RequestReturn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestRefundToolStripMenuItem})
        Me.RequestReturn.Name = "RequestReturn"
        Me.RequestReturn.Size = New System.Drawing.Size(75, 21)
        Me.RequestReturn.Text = "Request"
        '
        'RequestRefundToolStripMenuItem
        '
        Me.RequestRefundToolStripMenuItem.Name = "RequestRefundToolStripMenuItem"
        Me.RequestRefundToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RequestRefundToolStripMenuItem.Text = "Request for Return"
        '
        'miStocks
        '
        Me.miStocks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockOut, Me.StockTaking})
        Me.miStocks.Name = "miStocks"
        Me.miStocks.Size = New System.Drawing.Size(65, 21)
        Me.miStocks.Text = "Stocks"
        '
        'StockOut
        '
        Me.StockOut.Name = "StockOut"
        Me.StockOut.Size = New System.Drawing.Size(158, 22)
        Me.StockOut.Text = "Stock Out"
        '
        'StockTaking
        '
        Me.StockTaking.Name = "StockTaking"
        Me.StockTaking.Size = New System.Drawing.Size(158, 22)
        Me.StockTaking.Text = "Stock Taking"
        '
        'MiInventory
        '
        Me.MiInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryStocks, Me.InventoryRecord, Me.ProductRanking})
        Me.MiInventory.Name = "MiInventory"
        Me.MiInventory.Size = New System.Drawing.Size(78, 21)
        Me.MiInventory.Text = "Inventory"
        '
        'InventoryStocks
        '
        Me.InventoryStocks.Name = "InventoryStocks"
        Me.InventoryStocks.Size = New System.Drawing.Size(184, 22)
        Me.InventoryStocks.Text = "Item Stocks"
        '
        'InventoryRecord
        '
        Me.InventoryRecord.Name = "InventoryRecord"
        Me.InventoryRecord.Size = New System.Drawing.Size(184, 22)
        Me.InventoryRecord.Text = "InventoryRecord"
        '
        'ProductRanking
        '
        Me.ProductRanking.Name = "ProductRanking"
        Me.ProductRanking.Size = New System.Drawing.Size(184, 22)
        Me.ProductRanking.Text = "Product Ranking"
        '
        'miSettings
        '
        Me.miSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCategory, Me.CompanyInformation, Me.CurrencyUnits, Me.DeliveryPlaces, Me.miItems, Me.miLocations, Me.SalesToolStripMenuItem1, Me.SuppliersToolStripMenuItem, Me.UsersToolStripMenuItem, Me.TermsofDelivery, Me.TermsofPaymentToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.miSettings.Name = "miSettings"
        Me.miSettings.Size = New System.Drawing.Size(73, 21)
        Me.miSettings.Text = "Settings"
        '
        'miCategory
        '
        Me.miCategory.Name = "miCategory"
        Me.miCategory.Size = New System.Drawing.Size(215, 22)
        Me.miCategory.Text = "Categories"
        '
        'CompanyInformation
        '
        Me.CompanyInformation.Name = "CompanyInformation"
        Me.CompanyInformation.Size = New System.Drawing.Size(215, 22)
        Me.CompanyInformation.Text = "Company Information"
        '
        'CurrencyUnits
        '
        Me.CurrencyUnits.Name = "CurrencyUnits"
        Me.CurrencyUnits.Size = New System.Drawing.Size(215, 22)
        Me.CurrencyUnits.Text = "Currency Units"
        '
        'DeliveryPlaces
        '
        Me.DeliveryPlaces.Name = "DeliveryPlaces"
        Me.DeliveryPlaces.Size = New System.Drawing.Size(215, 22)
        Me.DeliveryPlaces.Text = "Delivery Places"
        '
        'miItems
        '
        Me.miItems.Name = "miItems"
        Me.miItems.Size = New System.Drawing.Size(215, 22)
        Me.miItems.Text = "Items"
        '
        'miLocations
        '
        Me.miLocations.Name = "miLocations"
        Me.miLocations.Size = New System.Drawing.Size(215, 22)
        Me.miLocations.Text = "Locations"
        '
        'SalesToolStripMenuItem1
        '
        Me.SalesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem2, Me.StocksToolStripMenuItem1, Me.StockMonitoringToolStripMenuItem, Me.StockOutToolStripMenuItem2, Me.SalesReportToolStripMenuItem})
        Me.SalesToolStripMenuItem1.Name = "SalesToolStripMenuItem1"
        Me.SalesToolStripMenuItem1.Size = New System.Drawing.Size(215, 22)
        Me.SalesToolStripMenuItem1.Text = "Reports"
        '
        'SalesToolStripMenuItem2
        '
        Me.SalesToolStripMenuItem2.Name = "SalesToolStripMenuItem2"
        Me.SalesToolStripMenuItem2.Size = New System.Drawing.Size(211, 22)
        Me.SalesToolStripMenuItem2.Text = "Daily Transaction"
        '
        'StocksToolStripMenuItem1
        '
        Me.StocksToolStripMenuItem1.Name = "StocksToolStripMenuItem1"
        Me.StocksToolStripMenuItem1.Size = New System.Drawing.Size(211, 22)
        Me.StocksToolStripMenuItem1.Text = "Inventory Record"
        '
        'StockMonitoringToolStripMenuItem
        '
        Me.StockMonitoringToolStripMenuItem.Name = "StockMonitoringToolStripMenuItem"
        Me.StockMonitoringToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.StockMonitoringToolStripMenuItem.Text = "Stock Monitoring"
        '
        'StockOutToolStripMenuItem2
        '
        Me.StockOutToolStripMenuItem2.Name = "StockOutToolStripMenuItem2"
        Me.StockOutToolStripMenuItem2.Size = New System.Drawing.Size(211, 22)
        Me.StockOutToolStripMenuItem2.Text = "Stock Out Monitoring"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SuppliersToolStripMenuItem.Text = "Qty/Unit"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.UsersToolStripMenuItem.Text = "Suppliers"
        '
        'TermsofDelivery
        '
        Me.TermsofDelivery.Name = "TermsofDelivery"
        Me.TermsofDelivery.Size = New System.Drawing.Size(215, 22)
        Me.TermsofDelivery.Text = "TermsofDelivery"
        '
        'TermsofPaymentToolStripMenuItem
        '
        Me.TermsofPaymentToolStripMenuItem.Name = "TermsofPaymentToolStripMenuItem"
        Me.TermsofPaymentToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.TermsofPaymentToolStripMenuItem.Text = "TermsofPayment"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'miUtilities
        '
        Me.miUtilities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemsToolStripMenuItem, Me.SuppliersToolStripMenuItem1})
        Me.miUtilities.Name = "miUtilities"
        Me.miUtilities.Size = New System.Drawing.Size(66, 21)
        Me.miUtilities.Text = "Utilities"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeDescriptionToolStripMenuItem, Me.ChangeToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'ChangeDescriptionToolStripMenuItem
        '
        Me.ChangeDescriptionToolStripMenuItem.Name = "ChangeDescriptionToolStripMenuItem"
        Me.ChangeDescriptionToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ChangeDescriptionToolStripMenuItem.Text = "Change Description"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ChangeToolStripMenuItem.Text = "Change UOM"
        '
        'SuppliersToolStripMenuItem1
        '
        Me.SuppliersToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangSupplierNameToolStripMenuItem})
        Me.SuppliersToolStripMenuItem1.Name = "SuppliersToolStripMenuItem1"
        Me.SuppliersToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.SuppliersToolStripMenuItem1.Text = "Suppliers"
        '
        'ChangSupplierNameToolStripMenuItem
        '
        Me.ChangSupplierNameToolStripMenuItem.Name = "ChangSupplierNameToolStripMenuItem"
        Me.ChangSupplierNameToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ChangSupplierNameToolStripMenuItem.Text = "Change Supplier Name"
        '
        'ReturnsToolStripMenuItem
        '
        Me.ReturnsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManulaToolStripMenuItem})
        Me.ReturnsToolStripMenuItem.Name = "ReturnsToolStripMenuItem"
        Me.ReturnsToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.ReturnsToolStripMenuItem.Text = "Help"
        '
        'ManulaToolStripMenuItem
        '
        Me.ManulaToolStripMenuItem.Name = "ManulaToolStripMenuItem"
        Me.ManulaToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ManulaToolStripMenuItem.Text = "Manual"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(64, 21)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DashBoardToolStripMenuItem
        '
        Me.DashBoardToolStripMenuItem.Name = "DashBoardToolStripMenuItem"
        Me.DashBoardToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.DashBoardToolStripMenuItem.Text = "DashBoard"
        '
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 662)
        Me.Controls.Add(Me.msMain)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMain
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AppForm"
        Me.Text = "Sales and Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents miSettings As ToolStripMenuItem
    Friend WithEvents miCategory As ToolStripMenuItem
    Friend WithEvents miItems As ToolStripMenuItem
    Friend WithEvents miLocations As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiInventory As ToolStripMenuItem
    Friend WithEvents miStocks As ToolStripMenuItem
    Friend WithEvents miUtilities As ToolStripMenuItem
    Friend WithEvents Account As ToolStripMenuItem
    Friend WithEvents miAccountDetails As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventoryStocks As ToolStripMenuItem
    Friend WithEvents StockOut As ToolStripMenuItem
    Friend WithEvents StockTaking As ToolStripMenuItem
    Friend WithEvents InventoryRecord As ToolStripMenuItem
    Friend WithEvents ChangeDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestReturn As ToolStripMenuItem
    Friend WithEvents RequestRefundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeliveryPlaces As ToolStripMenuItem
    Friend WithEvents TermsofDelivery As ToolStripMenuItem
    Friend WithEvents TermsofPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseEntry As ToolStripMenuItem
    Friend WithEvents PurchaseSearch As ToolStripMenuItem
    Friend WithEvents InvoicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceEntry As ToolStripMenuItem
    Friend WithEvents InvoicePurchase As ToolStripMenuItem
    Friend WithEvents ReturnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManulaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangSupplierNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrencyUnits As ToolStripMenuItem
    Friend WithEvents StockMonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CompanyInformation As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProductRanking As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashBoardToolStripMenuItem As ToolStripMenuItem
End Class
