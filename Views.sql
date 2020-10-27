CREATE VIEW CostInv AS 
-- tocal cost ni STOCK IN
SELECT 
InvoiceDetails.CreatedDate AS 'TransactedDate',
InvoiceDeliveryDetails.DeliveryId AS 'TransID',
InvoiceDetails.ItemId,sum(InvoiceDeliveryDetails.QtyOk)'Qty',
1 AS TransactionTypeID,InvoiceDetails.Remarks,
sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.UnitPrice) 'Cost',
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
SELECT 
StockOutHeaders.StockOutDate AS 'TransactedDate',

StockOutHeaders.StockOutCode AS 'TransID',
SAMPLEINV.ItemId,sum(SAMPLEINV.qty)'Qty',
2 AS TransactionTypeID,StockOutHeaders.Remarks,
sum(StockOutDetails.UnitPrice * StockOutDetails.Qty)'Cost'
, Items.Description
FROM SAMPLEINV	
INNER JOIN StockOutHeaders ON 
StockOutHeaders.StockOutCode=SAMPLEINV.TransID 
INNER JOIN StockOutDetails	
ON 	SAMPLEINV.ItemId=StockOutDetails.ItemID
AND SAMPLEINV.TransID=StockOutDetails.StockOutCode
AND StockOutHeaders.StockOutCode=StockOutDetails.StockOutCode
INNER JOIN Items ON Items.ItemId=SAMPLEINV.ItemId
GROUP BY SAMPLEINV.ItemId,Items.Description,StockOutHeaders.StockOutDate,
StockOutHeaders.StockOutCode , StockOutHeaders.Remarks
UNION ALL
--AC
SELECT 
StockTakingHeaders.CountedDate	 AS 'TransactedDate',
StockTakingHeaders.STID AS 'TransID',
SAMPLEINV.ItemId,sum(SAMPLEINV.qty)'Qty',
3 AS TransactionTypeID, StockTakingHeaders.Remarks,
sum(StockTakingDetails.UnitPrice * StockTakingDetails.Qty)'Cost',
Items.Description
FROM SAMPLEINV	
INNER JOIN StockTakingHeaders ON 
StockTakingHeaders.STID=SAMPLEINV.TransID 
INNER JOIN StockTakingDetails	
ON 	SAMPLEINV.ItemId=StockTakingDetails.ItemID
AND SAMPLEINV.TransID=StockTakingDetails.STID
AND StockTakingHeaders.STID=StockTakingDetails.STID
INNER JOIN Items ON Items.ItemId=SAMPLEINV.ItemId
GROUP BY SAMPLEINV.ItemId,Items.Description,StockTakingHeaders.CountedDate,
StockTakingHeaders.STID , StockTakingHeaders.Remarks




GO

CREATE VIEW  SAMPLEINV  AS
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

