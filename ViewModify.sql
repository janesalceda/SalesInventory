USE [SalesAndInventory]
GO

/****** Object:  View [dbo].[CostInv]    Script Date: 27/10/2020 10:05:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[CostInv] AS 
-- tocal cost ni STOCK IN
SELECT 
InvoiceDetails.CreatedDate AS 'TransactedDate',
InvoiceDeliveryDetails.DeliveryId AS 'TransID',
InvoiceDetails.ItemId,sum(InvoiceDeliveryDetails.QtyOk)'Qty',
1 AS TransactionTypeID,InvoiceDetails.Remarks,
isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.ClientUnitPrice),0) 'ClientCost',
isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.SupplierUnitPrice),0) 'SupplierCost',
Items.Description
FROM  InvoiceDeliveryDetails
INNER JOIN InvoiceDetails ON 
InvoiceDeliveryDetails.InvoiceDetailSeq =InvoiceDetails.InvoiceDetailSeq
AND InvoiceDeliveryDetails.InvoiceNo	=InvoiceDetails.InvoiceNo
INNER JOIN Items ON Items.ItemId=InvoiceDetails.ItemId
INNER JOIN POHeaders ON POHeaders.PONo=InvoiceDetails.PoNo
AND InvoiceDetails.SupplierId=POHeaders.SupplierId
INNER JOIN PoDetails ON PoDetails.PoNo=POHeaders.PONo
AND PoDetails.ItemId=InvoiceDetails.ItemId	
AND PoDetailS.PoNo=InvoiceDetails.PoNo
AND PoDetails.PoDetailSeq=InvoiceDetails.PoDetailSeq
GROUP BY InvoiceDetails.ItemId,Items.Description,InvoiceDetails.CreatedDate,
InvoiceDeliveryDetails.DeliveryId,InvoiceDetails.Remarks
UNION ALL

--STOCK OUT
SELECT StockOutDate AS 'TransactedDate',StockOutHeaders.StockOutCode AS 'TransID',
Items.ItemID,SUM(Qty) AS QTY, 2 AS TransactionTypeID,StockOutHeaders.Remarks,
isnull(sum(StockOutDetails.ClientUnitPrice * StockOutDetails.Qty),0)'ClientCost',
isnull(sum(StockOutDetails.SupplierUnitPrice * StockOutDetails.Qty),0)'SupplierCost'
, Items.Description
FROM StockOutHeaders 
INNER JOIN StockOutDetails ON 
StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
INNER JOIN ITEMS ON
ITEMS.ItemID = StockOutDetails.ItemID
GROUP BY StockOutDate,StockOutHeaders.StockOutCode,Items.ItemID, StockOutHeaders.Remarks, Items.Description
UNION ALL
--AC

SELECT CountedDate  AS 'TransactedDate',StockTakingHeaders.STID AS 'TransID',
Items.ItemID,SUM(Qty) AS QTY, 
3 AS TransactionTypeID ,StockTakingHeaders.Remarks,
isnull(sum(StockTakingDetails.ClientUnitPrice * StockTakingDetails.Qty),0)'ClientCost',
isnull(sum(StockTakingDetails.SupplierUnitPrice * StockTakingDetails.Qty),0)'SupplierCost',
Items.Description
FROM StockTakingHeaders 
INNER JOIN StockTakingDetails ON 
StockTakingHeaders.STID = StockTakingDetails.STID
INNER JOIN ITEMS ON
ITEMS.ItemID = StockTakingDetails.ItemID
GROUP BY CountedDate,StockTakingHeaders.STID,Items.ItemID, StockTakingHeaders.Remarks, Items.Description




GO


USE [SalesAndInventory]
GO

/****** Object:  View [dbo].[SAMPLEINV]    Script Date: 27/10/2020 10:05:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW  [dbo].[SAMPLEINV]  AS
		SELECT * FROM (	
			
			--IN ITEMS BASED ON DELIVERY OK
			SELECT 
			TOP 100 PERCENT  dbo.InvoiceDeliveryDetails.DeliveryDate AS TransactedDate, 
			PoDetails.PoNo AS TransID,
			dbo.InvoiceDetails.ItemId AS ItemId, dbo.InvoiceDeliveryDetails.QtyOk AS Qty, 
			1 AS TransactionTypeId, InvoiceDetails.Remarks
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

			UNION ALL	
			--OUT ITEMS
 			SELECT StockOutDate,StockOutHeaders.StockOutCode,ItemID,SUM(Qty) AS QTY, 2 AS TransactionTypeID 
 			, StockOutHeaders.Remarks
 			FROM StockOutHeaders 
			INNER JOIN StockOutDetails ON 
			StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
			GROUP BY StockOutDate,StockOutHeaders.StockOutCode,ItemID, StockOutHeaders.Remarks
			
			UNION ALL
			--AC ITEMS
			SELECT CountedDate,StockTakingHeaders.STID,ItemID,SUM(Qty) AS QTY, 3 AS TransactionTypeID 	, StockTakingHeaders.Remarks
 			FROM StockTakingHeaders 
			INNER JOIN StockTakingDetails ON 
			StockTakingHeaders.STID = StockTakingDetails.STID
			GROUP BY CountedDate,StockTakingHeaders.STID,ItemID, StockTakingHeaders.Remarks) TEST
	
			



GO

