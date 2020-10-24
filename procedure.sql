CREATE PROCEDURE TotalIn
		@TransactionDate DATETIME,
		@ItemId VARCHAR(20)
		AS
		
		SELECT 
		isnull(SUM(dbo.InvoiceDeliveryDetails.QtyOk),0) AS Qty
		FROM dbo.InvoiceDeliveryDetails INNER JOIN
		dbo.InvoiceDetails ON 
		dbo.InvoiceDetails.InvoiceNo = dbo.InvoiceDeliveryDetails.InvoiceNo AND 
		dbo.InvoiceDetails.SupplierId = dbo.InvoiceDeliveryDetails.SupplierId AND 
		dbo.InvoiceDetails.InvoiceDetailSeq = dbo.InvoiceDeliveryDetails.InvoiceDetailSeq 
		INNER JOIN
		dbo.Items ON dbo.Items.ItemId = dbo.InvoiceDetails.ItemId
		Left Join PoDetails On
		InvoiceDetails.PoNo =PoDetails.PoNo and InvoiceDetails.PoDetailSeq = PoDetails.PoDetailSeq
		where InvoiceDeliveryDetails.QtyOK is not NULL AND InvoiceDeliveryDetails.QtyOK <>0
		AND dbo.InvoiceDeliveryDetails.DeliveryDate =@TransactionDate AND dbo.InvoiceDetails.ItemId =@ItemId
GO

CREATE PROCEDURE TotalOut
		@TransactionDate DATETIME,
		@ItemId VARCHAR(20)
		AS
		-- TOTAL OUT ITEMS
		SELECT isnull(SUM(Qty),0) AS QTY
		FROM StockOutHeaders 
		INNER JOIN StockOutDetails ON 
		StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
		WHERE StockOutDate=@TransactionDate AND ItemID=@ItemId 
GO

CREATE	PROCEDURE PurchaseOrderList
@ItemId VARCHAR(20),
@SupplierId  VARCHAR(10)
as
SELECT     PurchaseOrder.SupplierID,
PoDetails.PoNo,
PoDetails.ItemID,PoDetails.PoDetailSeq,  
PoDetails.Qty as POQty,isnull(A.InvoiceQty,0)as InvoiceQty, 	
PoDetails.Qty - isnull(A.InvoiceQty,0)  as BalQty 	
FROM       PurchaseOrder  	INNER JOIN PoDetails  	
ON         PurchaseOrder.PoNo = PoDetails.PoNo  	
INNER JOIN Suppliers  	ON         
PurchaseOrder.SupplierId = Suppliers.SupplierId   	
Left Join  (  
Select   SupplierID,PONO,PODetailSeq,ItemID,Sum(InvoiceDetails.QTY) as InvoiceQty  
From InvoiceDetails  Where ItemId = @ItemId  And SupplierId = @SupplierId 
Group by SupplierID,PONO,PODetailSeq,ItemID  )A  On PurchaseOrder.SupplierID = A.SupplierID    
And PoDetails.PONO = A.PONO    And PoDetails.PoDetailSeq = A.PoDetailSeq    And PoDetails.ItemID = A.ItemID    
WHERE      PurchaseOrder.SupplierId =@SupplierId AND        PoDetails.ItemId = @ItemId 
AND PoDetails.ReceivedAllInvoices = 0 
AND PoDetails.Canceled = 0  Group by PurchaseOrder.SupplierID,  
PoDetails.PoNo,PoDetails.ItemID,PoDetails.PoDetailSeq,A.InvoiceQty,PoDetails.Qty
GO

