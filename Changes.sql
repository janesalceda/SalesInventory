USE [SalesAndInventory]
GO

/****** Object:  Table [dbo].[ItemsForApproval]    Script Date: 3/11/2020 5:11:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ItemsForApproval](
	[ItemId] [varchar](20) NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[ConvertingCoefficient] [decimal](18, 12) NOT NULL,
	[CategoryID] [int] NULL,
	[ClientQtyUnit] [int] NULL,
	[SupplierQtyUnit] [int] NULL,
	[Location] [varchar](15) NULL,
	[MaxOrderQty] [int] NULL,
	[OrderingPointQty] [int] NULL,
	[MinimumOrderQty] [int] NULL,
	[Remarks] [varchar](150) NULL,
	[CreatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ItemsForApproval] ADD  DEFAULT ((1)) FOR [ConvertingCoefficient]
GO

ALTER TABLE [dbo].[ItemsForApproval] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[ItemsForApproval] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO

USE [SalesAndInventory]
GO

/****** Object:  View [dbo].[SAMPLEINV]    Script Date: 3/11/2020 5:12:27 AM ******/
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

USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[DiplayIncomeStatement]    Script Date: 3/11/2020 5:12:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[DiplayIncomeStatement]
@TransactedFrom DATETIME,
@TransactedTo DATETIME
AS 
SELECT b.CompanyLogo,a.* FROM (
SELECT isnull(SUM(c.NetSales),'0.00')'NetSales',isnull(SUM(a.BeginningInventory),'0.00')'BeginningInventory'
,isnull(SUM(b.NetPurchase),'0.00')'NetPurchase',
(isnull(SUM(a.BeginningInventory),'0.00')+isnull(SUM(b.NetPurchase),'0.00'))'CostOfGoodsAvailSale',
((isnull(SUM(a.BeginningInventory),'0.00')+isnull(SUM(b.NetPurchase),'0.00'))-isnull(SUM(c.CostGoodSold),'0.00'))'Inventory',
(isnull(SUM(c.NetSales),'0.00')-isnull(SUM(c.CostGoodSold),'0.00') )'GrossProfit',
convert(VARCHAR(10),@TransactedFrom,111)'From', convert(VARCHAR(10),@TransactedTo,111)'To',
SUM(c.CostGoodSold)'CostGoodSold'
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
companyinfo b


GO

USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[TotalCostIn]    Script Date: 3/11/2020 5:13:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[TotalCostOut]    Script Date: 3/11/2020 5:13:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
		WHERE StockOutHeaders.StockOutDate>=@TransactionDate
		AND ItemID=@ItemId
GO

USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[TotalIn]    Script Date: 3/11/2020 5:14:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
		AND dbo.InvoiceDeliveryDetails.DeliveryDate>=@TransactionDate AND dbo.InvoiceDetails.ItemId =@ItemId

GO

USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[TotalOut]    Script Date: 3/11/2020 5:14:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
		WHERE StockOutDate=@TransactionDate AND ItemID=@ItemId 

GO
USE [SalesAndInventory]
GO

/****** Object:  UserDefinedFunction [dbo].[GetStockBalance]    Script Date: 3/11/2020 5:14:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
USE [SalesAndInventory]
GO

/****** Object:  UserDefinedFunction [dbo].[GetDailyTransaction]    Script Date: 3/11/2020 5:14:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[GetDailyTransaction] (@Date AS VARCHAR(10)) RETURNS TABLE AS RETURN
	SELECT DISTINCT Items.itemid,Items.Description,OP.qty AS 'OpeningTransaction',
	STCKOUT.StockOut,INCDel.Qty AS 'IncomingDelivery',
	CASE WHEN INCDel.Qty IS NULL AND STCKOUT.StockOut IS NULL THEN OP.Qty
	WHEN INCDel.Qty IS NULL THEN OP.Qty-STCKOUT.StockOut
	WHEN STCKOUT.StockOut IS NULL THEN OP.Qty+INCDel.Qty
	ELSE 
	OP.Qty+(INCDel.Qty-STCKOUT.StockOut) END 'ClosingTransaction'
	FROM Items 
	--
	LEFT JOIN (SELECT * FROM GetStockBalance(convert(VARCHAR(10),dateadd(d,-1,@Date),111)) 
	WHERE itemid IN (SELECT itemid FROM Items)) AS OP
	ON OP.ItemId = Items.ItemId
	LEFT JOIN 
	(SELECT DISTINCT SUM(Qty) AS StockOut,Itemid
 			FROM StockOutHeaders 
			INNER JOIN StockOutDetails ON 
			StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
			WHERE convert(VARCHAR(10),StockOutDate,111) =@Date
			GROUP BY Itemid
			) AS STCKOUT
	ON STCKOUT.ItemId = Items.ItemId
	LEFT JOIN
	(SELECT DISTINCT dbo.InvoiceDetails.ItemId AS ItemId, sum(dbo.InvoiceDeliveryDetails.QtyOk) AS Qty 
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
			AND convert(VARCHAR(10),InvoiceDeliveryDetails.DeliveryDate,111)	=@Date
			GROUP BY InvoiceDetails.Itemid)
			AS INCDel
			ON INCDel.ItemId = Items.ItemId
	
	
	

GO


USE [SalesAndInventory]
GO

/****** Object:  UserDefinedFunction [dbo].[GetStockOut]    Script Date: 3/11/2020 5:15:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[GetStockOut] (@DateFrom AS VARCHAR(10),@DateTo AS VARCHAR(10)) RETURNS TABLE AS RETURN
	SELECT DISTINCT StockOutDetails.Itemid,Items.Description, StockOutHeaders.StockOutCode,
	StockOutDetails.ItemSeq,SUM(Qty) AS QtyOut
	FROM StockOutHeaders 
	INNER JOIN StockOutDetails ON 
	StockOutHeaders.StockOutCode = StockOutDetails.StockOutCode
	INNER JOIN Items ON
	Items.ItemId =StockOutDetails.ItemID
	WHERE convert(VARCHAR(10),StockOutDate,111) BETWEEN @DateFrom AND @DateTo
	GROUP BY StockOutDetails.Itemid,Items.Description, StockOutHeaders.StockOutCode,
	StockOutDetails.ItemSeq



GO
USE [SalesAndInventory]
GO

/****** Object:  UserDefinedFunction [dbo].[GetCostBalance]    Script Date: 3/11/2020 5:15:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE function [dbo].[GetCostBalance](@endDate VARCHAR(10)) returns Table
as RETURN
(
select CalculatedView.ItemId,CalculatedView.ClientCost,CalculatedView.SupplierCost
from
(select ItemId,
Sum( case TransactionTypeID when 1 then ClientCost when 2 then 0-ClientCost  when 3 then ClientCost Else 0 End ) ClientCost,
Sum( case TransactionTypeID when 1 then SupplierCost when 2 then 0-SupplierCost  when 3 then SupplierCost Else 0 End ) SupplierCost 
from
	(select CostInv.*,CountedDateView1.MaxCountedDate from CostInv 
		Left Join
			(select ItemId,Max(TransactedDate) MaxCountedDate
			from CostInv 
			where 
			convert(VARCHAR(10),TransactedDate,111)<=@endDate and TransactionTypeId=3
			group by ItemId) CountedDateView1 
		On
	CostInv.ItemId = CountedDateView1.ItemId
	where 
	CostInv.TransactedDate >= isnull(CountedDateView1.MaxCountedDate,'2000-01-01') 
	and  convert(VARCHAR(10),TransactedDate,111)<=@endDate
	) ValidView
	group by ItemId

) CalculatedView
)

GO

USE [SalesAndInventory]
GO

/****** Object:  UserDefinedFunction [dbo].[getUnit]    Script Date: 3/11/2020 5:16:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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




