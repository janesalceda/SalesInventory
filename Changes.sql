CREATE TABLE dbo.UserLevel
	(
	UserLevelId INT IDENTITY NOT NULL,
	UserLevel VARCHAR(50) NOT NULL,
	Description VARCHAR(50) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__UserLeve__0C81DE8F7DCDAAA2 PRIMARY KEY (UserLevelId)
	)
GO

create function [dbo].[getUnit](@QtyUnit Int)
				returns varchar(10) 
				as
				begin
				DECLARE @UNIT varchar(10)
					 SET @UNIT=(select qtyunit from qtyunits where QtyUnitId=@QtyUnit)
					 return @UNIT
				end
GO
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




