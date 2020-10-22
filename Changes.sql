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
	UnitPrice DECIMAL(18,4) NULL,
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
	UnitPrice DECIMAL(19,4) NULL,
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

CREATE TABLE dbo.StockOutDetails
	(
	StockOutCode VARCHAR(20) NOT NULL,
	ItemSeq NUMERIC(3,0) NOT NULL,
	ItemID VARCHAR(20) NOT NULL,
	Qty DECIMAL(18,8) NULL,
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
	AppliedDate DATETIME NOT NULL,
	UnitPrice DECIMAL(18,8) NOT NULL,
	LeadTime NUMERIC(3,0) NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Supplier__7E70A262318258D2 PRIMARY KEY (ItemPriceId)
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
	UserLevelId VARCHAR(1) NOT NULL,
	CreatedDate DATETIME DEFAULT (getdate()) NULL,
	DeletedDate DATETIME NULL,
	UpdatedDate DATETIME DEFAULT (getdate()) NULL,
	UpdatedBy INT NULL,
	CONSTRAINT PK__Users__536C85E55CA1C101 PRIMARY KEY (Username)
	)
GO

CREATE	PROCEDURE PurchaseOrderList
@ItemId VARCHAR(20),
@SupplierId  VARCHAR(10)
as
SELECT     PurchaseOrder.SupplierID,
PoDetails.PoNo,
PoDetails.ItemID,PoDetails.PoDetailSeq,  
PoDetails.Qty as POQty,isnull(A.InvoiceQty,0)as InvoiceQty, 	
PoDetails.Qty - isnull(A.InvoiceQty,0)  as BalQty 	
FROM       PurchaseOrder  	INNER JOIN PoDetails  	
ON         PurchaseOrder.PoNo = PoDetails.PoNo  	
INNER JOIN Suppliers  	ON         
PurchaseOrder.SupplierId = Suppliers.SupplierId   	
Left Join  (  
Select   SupplierID,PONO,PODetailSeq,ItemID,Sum(InvoiceDetails.QTY) as InvoiceQty  
From InvoiceDetails  Where ItemId = @ItemId  And SupplierId = @SupplierId 
Group by SupplierID,PONO,PODetailSeq,ItemID  )A  On PurchaseOrder.SupplierID = A.SupplierID    
And PoDetails.PONO = A.PONO    And PoDetails.PoDetailSeq = A.PoDetailSeq    And PoDetails.ItemID = A.ItemID    
WHERE      PurchaseOrder.SupplierId =@SupplierId AND        PoDetails.ItemId = @ItemId 
AND PoDetails.ReceivedAllInvoices = 0 
AND PoDetails.Canceled = 0  Group by PurchaseOrder.SupplierID,  
PoDetails.PoNo,PoDetails.ItemID,PoDetails.PoDetailSeq,A.InvoiceQty,PoDetails.Qty
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

