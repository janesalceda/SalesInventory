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

CREATE TABLE dbo.UtilitiesLogs
	(
	UtilityLogID INT IDENTITY NOT NULL,
	UtilityCategory NVARCHAR(1000) NOT NULL,
	Remarks NVARCHAR(1000) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NOT NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NOT NULL,
	UpdatedBy INT NOT NULL,
	CONSTRAINT PK__Utilitie__ECBD44BC29AC2CE0 PRIMARY KEY (UtilityLogID)
	)
GO

