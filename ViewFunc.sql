CREATE function [dbo].[GetStockBalance](@endDate VARCHAR(10)) returns Table
as RETURN
(
select CalculatedView.ItemId,CalculatedView.Qty
from
(select ItemId,
Sum( case TransactionTypeID when 1 then Qty when 2 then 0-Qty  when 3 then Qty Else 0 End ) Qty 
from
	(select SAMPLEINV.*,CountedDateView1.MaxCountedDate from SAMPLEINV 
		Left Join
			(select ItemId,Max(TransactedDate) MaxCountedDate
			from SAMPLEINV 
			where 
			convert(VARCHAR(10),TransactedDate,111)<=@endDate and TransactionTypeId=3
			group by ItemId) CountedDateView1 
		On
	SAMPLEINV.ItemId = CountedDateView1.ItemId
	where 
	SAMPLEINV.TransactedDate >= isnull(CountedDateView1.MaxCountedDate,'2000-01-01') 
	and  convert(VARCHAR(10),TransactedDate,111)<=@endDate
	) ValidView
	group by ItemId

) CalculatedView
)





GOCREATE FUNCTION GenerateItemCode() RETURNS
VARCHAR(30)
AS
BEGIN
DECLARE @ItemCode VARCHAR(20)
SET @ItemCode= (SELECT CASE WHEN max(ITEMID) IS NULL 
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') +'-01' ELSE
                    CASE WHEN Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1<10
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') + '-0'+ cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    ELSE 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','')+ '-' +cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    END END AS 'pomax' from ITEMS)
                    RETURN @ItemCode
                END

 
GO

CREATE VIEW  SAMPLEINV  AS
		SELECT * FROM (	
			
			--IN ITEMS BASED ON DELIVERY OK
			SELECT 
			TOP 100 PERCENT  dbo.InvoiceDeliveryDetails.DeliveryDate AS TransactedDate, 
			PoDetails.PoNo AS TransID,
			dbo.InvoiceDetails.ItemId AS ItemId, dbo.InvoiceDeliveryDetails.QtyOk AS Qty, 
			1 AS TransactionTypeId  
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
 			FROM StockOutHeaders 
			INNER JOIN StockOutDetails ON 
			StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
			GROUP BY StockOutDate,StockOutHeaders.StockOutCode,ItemID
			
			UNION ALL
			--AC ITEMS
			SELECT CountedDate,StockTakingHeaders.STID,ItemID,SUM(Qty) AS QTY, 3 AS TransactionTypeID 
 			FROM StockTakingHeaders 
			INNER JOIN StockTakingDetails ON 
			StockTakingHeaders.STID = StockTakingDetails.STID
			GROUP BY CountedDate,StockTakingHeaders.STID,ItemID) TEST
	
			


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


