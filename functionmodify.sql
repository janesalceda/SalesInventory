USE [SalesAndInventory]
GO

/****** Object:  UserDefinedFunction [dbo].[GetCostBalance]    Script Date: 27/10/2020 10:12:43 PM ******/
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

/****** Object:  UserDefinedFunction [dbo].[GetDailyTransaction]    Script Date: 27/10/2020 10:13:03 PM ******/
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

/****** Object:  UserDefinedFunction [dbo].[GetStockBalance]    Script Date: 27/10/2020 10:13:18 PM ******/
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

/****** Object:  UserDefinedFunction [dbo].[GetStockOut]    Script Date: 27/10/2020 10:13:35 PM ******/
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

