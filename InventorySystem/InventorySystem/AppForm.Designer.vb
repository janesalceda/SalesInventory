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
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.Account = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnRefundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestRefundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTakingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.miStocks = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTakingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.checkInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrencyUnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveryPlacesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsofDelivery = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsofPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miUtilities = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangSupplierNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Account, Me.PurchasesToolStripMenuItem, Me.InvoicesToolStripMenuItem, Me.ReturnRefundToolStripMenuItem, Me.miStocks, Me.MiInventory, Me.miMaster, Me.miUtilities, Me.ReturnsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.msMain.Size = New System.Drawing.Size(1231, 27)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "MenuStrip1"
        '
        'Account
        '
        Me.Account.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountDetails})
        Me.Account.Name = "Account"
        Me.Account.Size = New System.Drawing.Size(73, 21)
        Me.Account.Text = "Account"
        '
        'AccountDetails
        '
        Me.AccountDetails.Name = "AccountDetails"
        Me.AccountDetails.Size = New System.Drawing.Size(178, 22)
        Me.AccountDetails.Text = "Account Details"
        '
        'PurchasesToolStripMenuItem
        '
        Me.PurchasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem"
        Me.PurchasesToolStripMenuItem.Size = New System.Drawing.Size(91, 21)
        Me.PurchasesToolStripMenuItem.Text = "Purchases"
        '
        'EntryToolStripMenuItem
        '
        Me.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem"
        Me.EntryToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.EntryToolStripMenuItem.Text = "Entry"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'InvoicesToolStripMenuItem
        '
        Me.InvoicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryToolStripMenuItem1, Me.SearchToolStripMenuItem1})
        Me.InvoicesToolStripMenuItem.Name = "InvoicesToolStripMenuItem"
        Me.InvoicesToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.InvoicesToolStripMenuItem.Text = "Invoices"
        '
        'EntryToolStripMenuItem1
        '
        Me.EntryToolStripMenuItem1.Name = "EntryToolStripMenuItem1"
        Me.EntryToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.EntryToolStripMenuItem1.Text = "Entry"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'ReturnRefundToolStripMenuItem
        '
        Me.ReturnRefundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestRefundToolStripMenuItem, Me.RequestApprovalToolStripMenuItem})
        Me.ReturnRefundToolStripMenuItem.Name = "ReturnRefundToolStripMenuItem"
        Me.ReturnRefundToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.ReturnRefundToolStripMenuItem.Text = "Returns"
        '
        'RequestRefundToolStripMenuItem
        '
        Me.RequestRefundToolStripMenuItem.Name = "RequestRefundToolStripMenuItem"
        Me.RequestRefundToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RequestRefundToolStripMenuItem.Text = "Request for Return"
        '
        'RequestApprovalToolStripMenuItem
        '
        Me.RequestApprovalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockOutToolStripMenuItem1, Me.StockTakingToolStripMenuItem1})
        Me.RequestApprovalToolStripMenuItem.Name = "RequestApprovalToolStripMenuItem"
        Me.RequestApprovalToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RequestApprovalToolStripMenuItem.Text = "Request for Approval"
        '
        'StockOutToolStripMenuItem1
        '
        Me.StockOutToolStripMenuItem1.Name = "StockOutToolStripMenuItem1"
        Me.StockOutToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.StockOutToolStripMenuItem1.Text = "Stock Out"
        '
        'StockTakingToolStripMenuItem1
        '
        Me.StockTakingToolStripMenuItem1.Name = "StockTakingToolStripMenuItem1"
        Me.StockTakingToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.StockTakingToolStripMenuItem1.Text = "Stock Taking"
        '
        'miStocks
        '
        Me.miStocks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockOutToolStripMenuItem, Me.StockTakingToolStripMenuItem})
        Me.miStocks.Name = "miStocks"
        Me.miStocks.Size = New System.Drawing.Size(65, 21)
        Me.miStocks.Text = "Stocks"
        '
        'StockOutToolStripMenuItem
        '
        Me.StockOutToolStripMenuItem.Name = "StockOutToolStripMenuItem"
        Me.StockOutToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.StockOutToolStripMenuItem.Text = "Stock Out"
        '
        'StockTakingToolStripMenuItem
        '
        Me.StockTakingToolStripMenuItem.Name = "StockTakingToolStripMenuItem"
        Me.StockTakingToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.StockTakingToolStripMenuItem.Text = "Stock Taking"
        '
        'MiInventory
        '
        Me.MiInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.checkInventory, Me.ReceivedToolStripMenuItem})
        Me.MiInventory.Name = "MiInventory"
        Me.MiInventory.Size = New System.Drawing.Size(78, 21)
        Me.MiInventory.Text = "Inventory"
        '
        'checkInventory
        '
        Me.checkInventory.Name = "checkInventory"
        Me.checkInventory.Size = New System.Drawing.Size(182, 22)
        Me.checkInventory.Text = "Item Stocks"
        '
        'ReceivedToolStripMenuItem
        '
        Me.ReceivedToolStripMenuItem.Name = "ReceivedToolStripMenuItem"
        Me.ReceivedToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ReceivedToolStripMenuItem.Text = "InventoryRecord"
        '
        'miMaster
        '
        Me.miMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCategory, Me.CurrencyUnitsToolStripMenuItem, Me.DeliveryPlacesToolStripMenuItem, Me.miItems, Me.LocationsToolStripMenuItem, Me.SuppliersToolStripMenuItem, Me.UsersToolStripMenuItem, Me.TermsofDelivery, Me.TermsofPaymentToolStripMenuItem, Me.SalesToolStripMenuItem1, Me.UserToolStripMenuItem})
        Me.miMaster.Name = "miMaster"
        Me.miMaster.Size = New System.Drawing.Size(73, 21)
        Me.miMaster.Text = "Settings"
        '
        'miCategory
        '
        Me.miCategory.Name = "miCategory"
        Me.miCategory.Size = New System.Drawing.Size(187, 22)
        Me.miCategory.Text = "Categories"
        '
        'CurrencyUnitsToolStripMenuItem
        '
        Me.CurrencyUnitsToolStripMenuItem.Name = "CurrencyUnitsToolStripMenuItem"
        Me.CurrencyUnitsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CurrencyUnitsToolStripMenuItem.Text = "Currency Units"
        '
        'DeliveryPlacesToolStripMenuItem
        '
        Me.DeliveryPlacesToolStripMenuItem.Name = "DeliveryPlacesToolStripMenuItem"
        Me.DeliveryPlacesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DeliveryPlacesToolStripMenuItem.Text = "Delivery Places"
        '
        'miItems
        '
        Me.miItems.Name = "miItems"
        Me.miItems.Size = New System.Drawing.Size(187, 22)
        Me.miItems.Text = "Items"
        '
        'LocationsToolStripMenuItem
        '
        Me.LocationsToolStripMenuItem.Name = "LocationsToolStripMenuItem"
        Me.LocationsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LocationsToolStripMenuItem.Text = "Locations"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SuppliersToolStripMenuItem.Text = "Qty/Unit"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.UsersToolStripMenuItem.Text = "Suppliers"
        '
        'TermsofDelivery
        '
        Me.TermsofDelivery.Name = "TermsofDelivery"
        Me.TermsofDelivery.Size = New System.Drawing.Size(187, 22)
        Me.TermsofDelivery.Text = "TermsofDelivery"
        '
        'TermsofPaymentToolStripMenuItem
        '
        Me.TermsofPaymentToolStripMenuItem.Name = "TermsofPaymentToolStripMenuItem"
        Me.TermsofPaymentToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TermsofPaymentToolStripMenuItem.Text = "TermsofPayment"
        '
        'SalesToolStripMenuItem1
        '
        Me.SalesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem2, Me.StocksToolStripMenuItem1})
        Me.SalesToolStripMenuItem1.Name = "SalesToolStripMenuItem1"
        Me.SalesToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.SalesToolStripMenuItem1.Text = "Reports"
        '
        'SalesToolStripMenuItem2
        '
        Me.SalesToolStripMenuItem2.Name = "SalesToolStripMenuItem2"
        Me.SalesToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.SalesToolStripMenuItem2.Text = "sales"
        '
        'StocksToolStripMenuItem1
        '
        Me.StocksToolStripMenuItem1.Name = "StocksToolStripMenuItem1"
        Me.StocksToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.StocksToolStripMenuItem1.Text = "Stocks"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
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
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeDescriptionToolStripMenuItem, Me.ChangePriceToolStripMenuItem, Me.ChangeToolStripMenuItem})
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
        'ChangePriceToolStripMenuItem
        '
        Me.ChangePriceToolStripMenuItem.Name = "ChangePriceToolStripMenuItem"
        Me.ChangePriceToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ChangePriceToolStripMenuItem.Text = "Change SupplierId"
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
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents miMaster As ToolStripMenuItem
    Friend WithEvents miCategory As ToolStripMenuItem
    Friend WithEvents miItems As ToolStripMenuItem
    Friend WithEvents LocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiInventory As ToolStripMenuItem
    Friend WithEvents miStocks As ToolStripMenuItem
    Friend WithEvents miUtilities As ToolStripMenuItem
    Friend WithEvents Account As ToolStripMenuItem
    Friend WithEvents AccountDetails As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents checkInventory As ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockTakingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceivedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePriceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnRefundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestRefundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeliveryPlacesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TermsofDelivery As ToolStripMenuItem
    Friend WithEvents TermsofPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReturnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManulaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangSupplierNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StockTakingToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CurrencyUnitsToolStripMenuItem As ToolStripMenuItem
End Class
