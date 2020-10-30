CREATE PROCEDURE DiplayIncomeStatement
@TransactedFrom DATETIME,
@TransactedTo DATETIME
AS 
SELECT d.CompanyLogo,A.* FROM (
SELECT isnull(SUM(c.NetSales),'0.00')'NetSales',isnull(SUM(a.BeginningInventory),'0.00')'BeginningInventory'
,isnull(SUM(b.NetPurchase),'0.00')'NetPurchase',
(isnull(SUM(a.BeginningInventory),'0.00')+isnull(SUM(b.NetPurchase),'0.00'))'CostOfGoodsAvailSale',
((isnull(SUM(a.BeginningInventory),'0.00')+isnull(SUM(b.NetPurchase),'0.00'))-isnull(SUM(c.CostGoodSold),'0.00'))'Inventory',(isnull(SUM(c.NetSales),'0.00')-isnull(SUM(c.CostGoodSold),'0.00') )'GrossProfit',
convert(VARCHAR(10),@TransactedFrom,111)'From', convert(VARCHAR(10),@TransactedTo,111)'To',SUM(c.CostGoodSold)'CostGoodSold'
 FROM Items LEFT JOIN	
  (
	SELECT StockTakingDetails.ItemID,
	sum(StockTakingDetails.Qty*StockTakingDetails.SupplierUnitPrice) 'BeginningInventory'
	from
	StockTakingHeaders
	INNER JOIN StockTakingDetails	ON
	StockTakingHeaders.STID=StockTakingDetails.STID
	WHERE convert(VARCHAR(10),StockTakingHeaders.CountedDate,111)BETWEEN convert(VARCHAR(10),@TransactedFrom,111) AND convert(VARCHAR(10),@TransactedTo,111)
	GROUP BY StockTakingDetails.ItemId
	) a
ON a.itemid=Items.ItemId
LEFT join
	(SELECT InvoiceDetails.ItemId, sum(qtyreceived*supplierunitprice) AS 'NetPurchase'FROM InvoiceDeliveryDetails
	iNNER JOIN InvoiceDetails ON 
	InvoiceDeliveryDetails.InvoiceNo = InvoiceDetails.InvoiceNo AND 
	InvoiceDeliveryDetails.InvoiceDetailSeq = InvoiceDetails.InvoiceDetailSeq
	WHERE convert(VARCHAR(10),InvoiceDeliveryDetails.DeliveryDate,111)BETWEEN convert(VARCHAR(10),@TransactedFrom,111) AND convert(VARCHAR(10),@TransactedTo,111)
	GROUP BY InvoiceDetails.ItemId)b
ON Items.ItemId=b.ItemId
LEFT join
	(SELECT StockOutDetails.ItemID,
	sum(StockOutDetails.Qty*StockOutDetails.SupplierUnitPrice)'CostGoodSold',
	sum(StockOutDetails.Qty*StockOutDetails.ClientUnitPrice)'NetSales'
	FROM StockOutHeaders
	INNER JOIN StockOutDetails	ON
	StockOutHeaders.StockOutCode=StockOutDetails.StockOutCode
	WHERE convert(VARCHAR(10),StockOutHeaders.StockOutDate,111)BETWEEN convert(VARCHAR(10),@TransactedFrom,111) AND convert(VARCHAR(10),@TransactedTo,111)
	GROUP BY StockOutDetails.ItemId) c
ON Items.ItemId=c.ItemId)A,
CompanyInfo	d



GO

