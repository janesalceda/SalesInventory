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

CREATE PROCEDURE [dbo].[TotalCostIn]
		@TransactionDate DATETIME,
		@ItemId VARCHAR(20)
		AS
		
SELECT 
isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.ClientUnitPrice),0) 'ClientCost',
isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.SupplierUnitPrice),0) 'SupplierCost'
FROM  InvoiceDeliveryDetails
INNER JOIN InvoiceDetails ON 
InvoiceDeliveryDetails.InvoiceDetailSeq =InvoiceDetails.InvoiceDetailSeq
AND InvoiceDeliveryDetails.InvoiceNo=InvoiceDetails.InvoiceNo
INNER JOIN Items ON Items.ItemId=InvoiceDetails.ItemId
INNER JOIN POHeaders ON POHeaders.PONo=InvoiceDetails.PoNo
AND InvoiceDetails.SupplierId=POHeaders.SupplierId
INNER JOIN PoDetails ON PoDetails.PoNo=POHeaders.PONo
AND PoDetails.ItemId=InvoiceDetails.ItemId	
AND PoDetailS.PoNo=InvoiceDetails.PoNo
AND PoDetails.PoDetailSeq=InvoiceDetails.PoDetailSeq
where InvoiceDeliveryDetails.QtyOK is not NULL AND InvoiceDeliveryDetails.QtyOK <>0
AND convert(VARCHAR(10),dbo.InvoiceDeliveryDetails.DeliveryDate,111)
 =@TransactionDate 
AND dbo.InvoiceDetails.ItemId =@ItemId


GO

CREATE PROCEDURE [dbo].[TotalCostOut]
		@TransactionDate DATETIME,
		@ItemId VARCHAR(20)
		AS
		-- TOTAL OUT ITEMS
		SELECT 
		isnull(sum(StockOutDetails.ClientUnitPrice * StockOutDetails.Qty),0) AS 'ClientCost',
		isnull(sum(StockOutDetails.SupplierUnitPrice * StockOutDetails.Qty),0) AS 'SupplierCost'
		FROM StockOutHeaders 
		INNER JOIN StockOutDetails ON 
		StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
		WHERE StockOutHeaders.StockOutDate>=@TransactionDate AND ItemID=@ItemId 
		



GO

CREATE PROCEDURE [dbo].[TotalIn]
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
		AND  dbo.InvoiceDeliveryDetails.DeliveryDate>=@TransactionDate AND dbo.InvoiceDetails.ItemId =@ItemId


GO

CREATE PROCEDURE [dbo].[TotalOut]
		@TransactionDate DATETIME,
		@ItemId VARCHAR(20)
		AS
		-- TOTAL OUT ITEMS
		SELECT isnull(SUM(Qty),0) AS QTY
		FROM StockOutHeaders 
		INNER JOIN StockOutDetails ON 
		StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
		WHERE StockOutDate>=@TransactionDate AND ItemID=@ItemId 


GO

CREATE procedure
[dbo].[UpdateItemDescription](@itemid varchar(20),@oldDescription  varchar(255),@newdescription varchar(255),@updatedid int) as
BEGIN
update items set 
description = @newdescription,
UpdatedDate = getdate(),
UpdatedBy = @updatedid
where itemid=@itemid


INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Item Description'
           ,'Update description item id: ' +@itemid+' from '+@oldDescription+' to '+@newdescription
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)
END

GO

CREATE procedure [dbo].[UpdateSupplierName] (@SupplierID VARCHAR(25),@SupplierName varchar(100),@updatedid int)
as
BEGIN
declare @OldSupplierName varchar(100)
set @OldSupplierName =(select SupplierName from suppliers where SupplierID=@SupplierID)

update Suppliers set 
SupplierName = @SupplierName,
UpdatedDate = getdate(),
UpdatedBy = @updatedid
where SupplierID=@SupplierID
--add to logs
	INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Supplier Name of Supplier'
           ,'Update Supplier Name supplier id: ' +@SupplierID+' from '+@OldSupplierName+' to '+@SupplierName
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)
END
GO

CREATE procedure 
[dbo].[UpdateUOM](@itemid varchar(20),@uomtype int,@QtyUnitVal int,@ConvertingCoefficient decimal(18,12),@updatedid int) as
declare @OldClientQtyUnit int
declare @OldSupplierQtyUnit int
declare @OldConvertingCoefficient decimal(18,12)

set @OldClientQtyUnit = (select ClientQtyUnit from items where itemid=@itemid)
set @OldSupplierQtyUnit = (select SupplierQtyUnit from items where itemid=@itemid)
set @OldConvertingCoefficient = (select ConvertingCoefficient from items where itemid=@itemid)

--client qty
if @uomtype = 1 
BEGIN
	update items set 
	ClientQtyUnit =  @QtyUnitVal,
	UpdatedDate = getdate(),
	UpdatedBy = @updatedid
	where itemid=@itemid
--add to logs
	INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Item Client Qty Unit'
           ,'Update Client Qty Unit item id: ' +@itemid+' from '
           +cast(@OldClientQtyUnit AS NVARCHAR(6))+' to '+cast(@QtyUnitVal AS NVARCHAR(6))
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)
		   
END
--supplierqty
else if @uomtype = 2 
BEGIN
	update items set 
	SupplierQtyUnit =  @QtyUnitVal,
	UpdatedDate = getdate(),
	UpdatedBy = @updatedid
	where itemid=@itemid
--add to logs
	INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Item Supplier Qty Unit'
           ,'Update Supplier Qty Unit item id: ' +@itemid+' from '        
           +cast(@OldSupplierQtyUnit AS NVARCHAR(6))+' to '+cast(@QtyUnitVal AS NVARCHAR(6))
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)
		   
END
--converting coefficient
else if @uomtype = 3 
BEGIN
	update items set 
	ConvertingCoefficient =  @ConvertingCoefficient,
	UpdatedDate = getdate(),
	UpdatedBy = @updatedid
	where itemid=@itemid
--add to logs
	INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Item Converting Coefficient'
           ,'Update Converting Coefficient item id: ' +@itemid+' from '
           +cast(@OldConvertingCoefficient AS NVARCHAR(6))+' to '+cast(@ConvertingCoefficient AS NVARCHAR(6))
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)
END




GO

