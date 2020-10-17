CREATE TABLE dbo.Items
	(
	ItemId VARCHAR(20) NOT NULL,
	Description VARCHAR(255) NOT NULL,
	ConvertingCoefficient DECIMAL(18,12) DEFAULT ((1)) NOT NULL,
	CategoryID INT NULL,
	ClientQtyUnit INT NULL,
	SupplierQtyUnit INT NULL,
	Location VARCHAR(15) NULL,
	MaxOrderQty INT NULL,
	OrderingPointQty INT NULL,
	MinimumOrderQty INT NULL,
	Remarks VARCHAR(150) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Items__727E838B5F492382 PRIMARY KEY (ItemId)
	)
GO

