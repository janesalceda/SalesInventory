USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[TotalCostIn]    Script Date: 27/10/2020 10:06:24 PM ******/
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

/****** Object:  StoredProcedure [dbo].[TotalCostOut]    Script Date: 27/10/2020 10:10:09 PM ******/
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
		WHERE convert(VARCHAR(10),StockOutDate,111)=@TransactionDate AND ItemID=@ItemId 
		



GO
USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[TotalIn]    Script Date: 27/10/2020 10:10:28 PM ******/
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
		AND convert(VARCHAR(10),dbo.InvoiceDeliveryDetails.DeliveryDate,111) =@TransactionDate AND dbo.InvoiceDetails.ItemId =@ItemId

GO
USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[TotalOut]    Script Date: 27/10/2020 10:10:42 PM ******/
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

/****** Object:  StoredProcedure [dbo].[UpdateItemDescription]    Script Date: 27/10/2020 10:10:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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
USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[UpdateSupplierName]    Script Date: 27/10/2020 10:11:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[UpdateSupplierName] (@SupplierID VARCHAR(25),@SupplierName varchar(100),@updatedid int)
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

USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[UpdateUOM]    Script Date: 27/10/2020 10:11:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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







