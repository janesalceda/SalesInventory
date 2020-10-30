
CREATE TABLE dbo.Categories
	(
	CategoryID INT IDENTITY NOT NULL,
	CategoryName NCHAR(50) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL
	)
GO

CREATE TABLE dbo.ClientItemPrices
	(
	ItemPriceId INT IDENTITY NOT NULL,
	ItemId VARCHAR(20) NOT NULL,
	AppliedDate DATETIME NOT NULL,
	UnitPrice DECIMAL(18,8) NOT NULL,
	LeadTime NUMERIC(3,0) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__ClientIt__7E70A26223F3538A PRIMARY KEY (ItemPriceId)
	)
GO

CREATE TABLE dbo.CompanyInfo
	(
	CompanyName VARCHAR(50) NOT NULL,
	StreetAdress VARCHAR(50) NULL,
	CityZip VARCHAR(50) NULL,
	Phone VARCHAR(20) NULL,
	Fax VARCHAR(10) NULL,
	website VARCHAR(100) NULL,
	CompanyLogo VARBINARY(max) NULL,
	CONSTRAINT PK__CompanyI__9BCE05DD13BCEBC1 PRIMARY KEY (CompanyName)
	)
GO

CREATE TABLE dbo.CurrencyUnits
	(
	CurrencyUnitId INT IDENTITY NOT NULL,
	CurrencyUnit VARCHAR(10) NOT NULL,
	AmountRoundType INT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Currency__13E497052EDAF651 PRIMARY KEY (CurrencyUnitId)
	)
GO

CREATE TABLE dbo.DeliveryPlaces
	(
	DeliveryPlaceId INT IDENTITY NOT NULL,
	DeliveryPlace VARCHAR(50) NOT NULL,
	Description VARCHAR(50) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Delivery__E86E97A7373B3228 PRIMARY KEY (DeliveryPlaceId)
	)
GO

CREATE TABLE dbo.Employees
	(
	EmpId INT IDENTITY NOT NULL,
	EmployeeName VARCHAR(100) NULL,
	Position VARCHAR(10) NULL,
	Gender VARCHAR(1) NULL,
	Age INT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Employee__AF2DBB9922AA2996 PRIMARY KEY (EmpId)
	)
GO

CREATE TABLE dbo.InvoiceDeliveryDetails
	(
	InvoiceNo VARCHAR(50) NOT NULL,
	SupplierId VARCHAR(25) NOT NULL,
	InvoiceDetailSeq INT NOT NULL,
	DeliveryId VARCHAR(50) NOT NULL,
	DeliveryDate DATETIME NULL,
	QtyExpected DECIMAL(18,8) NULL,
	QtyReceived DECIMAL(18,8) NULL,
	QtyOk DECIMAL(18,8) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__InvoiceD__A1562E52625A9A57 PRIMARY KEY (InvoiceNo,SupplierId,InvoiceDetailSeq,DeliveryId)
	)
GO

CREATE TABLE dbo.InvoiceDetails
	(
	InvoiceNo VARCHAR(50) NOT NULL,
	SupplierId VARCHAR(25) NOT NULL,
	InvoiceDetailSeq INT NOT NULL,
	ItemId VARCHAR(20) NOT NULL,
	PoNo VARCHAR(20) NULL,
	PoDetailSeq INT NULL,
	Remarks VARCHAR(200) NULL,
	DeliveryCompletedDate DATETIME NULL,
	Qty DECIMAL(18,10) NULL,
	EquivalentQty DECIMAL(18,10) NULL,
	ClientUnitPrice DECIMAL(19,4) NULL,
	SupplierUnitPrice DECIMAL(19,4) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__InvoiceD__5DA0088A6DCC4D03 PRIMARY KEY (InvoiceNo,SupplierId,InvoiceDetailSeq)
	)
GO

CREATE TABLE dbo.InvoiceHeaders
	(
	InvoiceNo VARCHAR(50) NOT NULL,
	SupplierId VARCHAR(25) NOT NULL,
	ReceivedDate DATETIME NOT NULL,
	Remarks VARCHAR(2500) NULL,
	EncodedStaff INT NULL,
	TotalAmount NUMERIC(10,2) NULL,
	InvoiceDate DATETIME NOT NULL,
	ActualETDDate DATETIME NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__InvoiceH__8328D44D681373AD PRIMARY KEY (InvoiceNo,SupplierId)
	)
GO

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

CREATE TABLE dbo.Locations
	(
	LocationId INT IDENTITY NOT NULL,
	Location VARCHAR(50) NOT NULL,
	Description VARCHAR(50) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Location__E7FEA49722401542 PRIMARY KEY (LocationId)
	)
GO

CREATE TABLE dbo.PoDetails
	(
	PoNo VARCHAR(20) DEFAULT ((0)) NOT NULL,
	ItemId VARCHAR(20) NOT NULL,
	EtdDate DATETIME NULL,
	EtaDate DATETIME NULL,
	FtryDate DATETIME NULL,
	ReceivedAllInvoices BIT DEFAULT ((0)) NOT NULL,
	Canceled BIT DEFAULT ((0)) NOT NULL,
	PoDetailSeq INT NOT NULL,
	Qty DECIMAL(18,8) NULL,
	QtyUnit INT NULL,
	EquivalentQty DECIMAL(18,8) NULL,
	EquivalentQtyUnit INT NULL,
	SupplierUnitPrice DECIMAL(19,4) NULL,
	ClientUnitPrice DECIMAL(19,4) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NOT NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NOT NULL,
	UpdatedBy INT NOT NULL,
	CONSTRAINT PK__PoDetail__AA40E05973852659 PRIMARY KEY (PoNo,PoDetailSeq)
	)
GO

CREATE TABLE dbo.POHeaders
	(
	PONo VARCHAR(20) NOT NULL,
	SupplierID VARCHAR(25) NULL,
	CurrencyUnitId INT NULL,
	IssuedDate DATETIME NULL,
	TermOfDeliveryId INT NULL,
	TermOfPaymentId INT NULL,
	DeliveryPlaceId INT NULL,
	TotalAmount NUMERIC(10,2) NULL,
	Remarks VARCHAR(200) NULL,
	EncodedStaff INT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__POHeader__5F02AA877C1A6C5A PRIMARY KEY (PONo)
	)
GO

CREATE TABLE dbo.QtyUnits
	(
	QtyUnitId INT IDENTITY NOT NULL,
	QtyUnit VARCHAR(10) NOT NULL,
	Description VARCHAR(50) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK_M_QUANTITY PRIMARY KEY (QtyUnitId)
	)
GO

CREATE TABLE dbo.ReturnDetails
	(
	ReturnID VARCHAR(20) NOT NULL,
	ItemID VARCHAR(20) NOT NULL,
	Qty DECIMAL(18,8) NULL,
	Remarks VARCHAR(200) NULL,
	SupplierUnitPrice DECIMAL(19,4) NULL,
	ClientUnitPrice DECIMAL(19,4) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__ReturnDe__536201B60D0FEE32 PRIMARY KEY (ReturnID,ItemID)
	)
GO

CREATE TABLE dbo.ReturnHeaders
	(
	ReturnID VARCHAR(20) NOT NULL,
	CountedDate DATETIME NOT NULL,
	EncodedStaff INT NOT NULL,
	Remarks VARCHAR(200) NULL,
	ApprovedBy INT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__ReturnHe__F445E988075714DC PRIMARY KEY (ReturnID)
	)
GO

CREATE TABLE dbo.StockOutDetails
	(
	StockOutCode VARCHAR(20) NOT NULL,
	ItemSeq NUMERIC(3,0) NOT NULL,
	ItemID VARCHAR(20) NOT NULL,
	Qty DECIMAL(18,8) NULL,
	SupplierUnitPrice DECIMAL(19,4) NULL,
	ClientUnitPrice DECIMAL(19,4) NULL,
	Remarks VARCHAR(200) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy VARCHAR(8) NULL,
	CONSTRAINT PK__StockOut__B19D7D6A078C1F06 PRIMARY KEY (StockOutCode,ItemSeq,ItemID)
	)
GO

CREATE TABLE dbo.StockOutHeaders
	(
	StockOutCode VARCHAR(20) NOT NULL,
	StockOutDate DATETIME NULL,
	TotalAmount NUMERIC(19,4) NULL,
	EncodedStaff INT NULL,
	IssuedByStaff VARCHAR(100) NULL,
	ApprovedBy INT NULL,
	Remarks VARCHAR(200) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__StockOut__C9B8C85601D345B0 PRIMARY KEY (StockOutCode)
	)
GO

CREATE TABLE dbo.StockTakingDetails
	(
	STID VARCHAR(20) NOT NULL,
	ItemID VARCHAR(20) NOT NULL,
	Qty DECIMAL(18,8) NULL,
	SupplierUnitPrice DECIMAL(19,4) NULL,
	ClientUnitPrice DECIMAL(19,4) NULL,
	Remarks VARCHAR(200) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__StockTak__012CF4A611158940 PRIMARY KEY (STID,ItemID)
	)
GO

CREATE TABLE dbo.StockTakingHeaders
	(
	STID VARCHAR(20) NOT NULL,
	CountedDate DATETIME NOT NULL,
	TotalAmount NUMERIC(10,2) NULL,
	EncodedStaff INT NOT NULL,
	Remarks VARCHAR(200) NULL,
	ApprovedBy INT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__StockTak__A60B1C980B5CAFEA PRIMARY KEY (STID)
	)
GO

CREATE TABLE dbo.SupplierItemPrices
	(
	ItemPriceId INT IDENTITY NOT NULL,
	ItemId VARCHAR(20) NOT NULL,
	SupplierId VARCHAR(25) NOT NULL,
	SupplierItemId VARCHAR(20) NOT NULL,
	AppliedDate DATETIME NOT NULL,
	UnitPrice DECIMAL(18,8) NOT NULL,
	LeadTime NUMERIC(3,0) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Supplier__7E70A2621A69E950 PRIMARY KEY (ItemPriceId)
	)
GO

CREATE TABLE dbo.Suppliers
	(
	SupplierId VARCHAR(25) NOT NULL,
	SupplierName VARCHAR(100) NOT NULL,
	Attention VARCHAR(50) NULL,
	Address VARCHAR(200) NULL,
	Phone VARCHAR(50) NULL,
	Fax VARCHAR(50) NULL,
	Remarks VARCHAR(200) NULL,
	AccountsName VARCHAR(100) NULL,
	TermOfDeliveryId INT NULL,
	TermOfPaymentId INT NULL,
	CurrencyUnitId INT NOT NULL,
	ImportSupplier BIT DEFAULT ((1)) NOT NULL,
	EmailAddress VARCHAR(100) DEFAULT ((0)) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Supplier__4BE666B43493CFA7 PRIMARY KEY (SupplierId)
	)
GO

CREATE TABLE dbo.TermsOfDelivery
	(
	TermOfDeliveryId INT IDENTITY NOT NULL,
	TermOfDelivery VARCHAR(20) NOT NULL,
	Description VARCHAR(50) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__TermsOfD__496D5D2751300E55 PRIMARY KEY (TermOfDeliveryId)
	)
GO

CREATE TABLE dbo.TermsOfPayment
	(
	TermOfPaymentId INT IDENTITY NOT NULL,
	TermOfPayment VARCHAR(150) NOT NULL,
	Description VARCHAR(150) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__TermsOfP__F2298D6856E8E7AB PRIMARY KEY (TermOfPaymentId)
	)
GO

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

CREATE TABLE dbo.Users
	(
	UserID INT IDENTITY NOT NULL,
	Username VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	UserLevelId INT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Users__536C85E55CA1C101 PRIMARY KEY (Username)
	)
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

