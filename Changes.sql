USE [SalesAndInventory]
GO

/****** Object:  StoredProcedure [dbo].[UpdateItemDescription]    Script Date: 26/10/2020 5:29:59 AM ******/
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

/****** Object:  StoredProcedure [dbo].[UpdateSupplierName]    Script Date: 26/10/2020 5:30:18 AM ******/
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

/****** Object:  StoredProcedure [dbo].[UpdateUOM]    Script Date: 26/10/2020 5:30:35 AM ******/
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
	/*INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Item Client Qty Unit'
           ,'Update Client Qty Unit item id: ' +@itemid+' from '+@OldClientQtyUnit+' to '+@QtyUnitVal
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)
		   */
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
	/*INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Item Supplier Qty Unit'
           ,'Update Supplier Qty Unit item id: ' +@itemid+' from '+@OldSupplierQtyUnit+' to '+@QtyUnitVal
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)
		   */
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
	/*INSERT INTO [dbo].[UtilitiesLogs]
           ([UtilityCategory]
           ,[Remarks]
           ,[CreatedDate]
           ,[DeletedDate]
           ,[UpdatedDate]
           ,[UpdatedBy])
     VALUES
           ('Change Item Converting Coefficient'
           ,'Update Converting Coefficient item id: ' +@itemid+' from '+@OldConvertingCoefficient+' to '+@ConvertingCoefficient
           ,getdate()
           ,null
           ,getdate()
           ,@updatedid)*/
END
GO
USE [SalesAndInventory]
GO

/****** Object:  Table [dbo].[ClientItemPrices]    Script Date: 26/10/2020 5:31:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClientItemPrices](
	[ItemPriceId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [varchar](20) NOT NULL,
	[AppliedDate] [datetime] NOT NULL,
	[UnitPrice] [decimal](18, 8) NOT NULL,
	[LeadTime] [numeric](3, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemPriceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [SalesAndInventory]
GO

/****** Object:  Table [dbo].[UtilitiesLogs]    Script Date: 26/10/2020 5:31:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UtilitiesLogs](
	[UtilityLogID] [int] IDENTITY(1,1) NOT NULL,
	[UtilityCategory] [nvarchar](255) NOT NULL,
	[Remarks] [nvarchar](1000) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UtilityLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UtilitiesLogs] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[UtilitiesLogs] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO





