CREATE TABLE dbo.SupplierItemPrices
	(
	ItemPriceId INT IDENTITY NOT NULL,
	ItemId VARCHAR(20) NOT NULL,
	SupplierId VARCHAR(10) NOT NULL,
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


INSERT INTO dbo.SupplierItemPrices (ItemPriceId, ItemId, SupplierId, AppliedDate, UnitPrice, LeadTime, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'SSAMPLE', 'DALI KOTO', '2020/10/12 10:23:03', 1000.05000000, NULL, '2020/10/12 10:23:03', NULL, '2020/10/12 10:23:03', 1)
GO

INSERT INTO dbo.SupplierItemPrices (ItemPriceId, ItemId, SupplierId, AppliedDate, UnitPrice, LeadTime, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'samp', 'DALI KOTO', '2020/10/12 10:23:03', 1000.05000000, NULL, '2020/10/12 10:23:03', NULL, '2020/10/12 10:23:03', 1)
GO


CREATE TABLE dbo.InvoiceHeaders
	(
	InvoiceNo VARCHAR(50) NOT NULL,
	SupplierId VARCHAR(10) NOT NULL,
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


INSERT INTO dbo.InvoiceHeaders (InvoiceNo, SupplierId, ReceivedDate, Remarks, EncodedStaff, TotalAmount, InvoiceDate, ActualETDDate, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('INV201012-001', 'DALI KOTO', '2020/10/12 0:00:00', 'sample', 1, 3000.15, '2020/10/12 0:00:00', '2020/10/12 0:00:00', '2020/10/12 14:22:57', NULL, '2020/10/12 14:22:57', 1)
GO



INSERT INTO dbo.InvoiceDetails (InvoiceNo, SupplierId, InvoiceDetailSeq, ItemId, PoNo, PoDetailSeq, Remarks, DeliveryCompletedDate, Qty, EquivalentQty, UnitPrice, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('INV201012-001', 'DALI KOTO', 1, 'samp', '20201012-01', 1, 'sample', '2020/10/12 0:00:00', 1000.0000000000, 3.0000000000, 1000.0500, '2020/10/12 13:46:16', '2020/10/12 13:46:16', NULL, 1)
GO

INSERT INTO dbo.InvoiceDeliveryDetails (InvoiceNo, SupplierId, InvoiceDetailSeq, DeliveryId, DeliveryDate, QtyExpected, QtyReceived, QtyOk, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('INV201012-001', 'DALI KOTO', 1, 'DEL201012-001', '2020/10/12 0:00:00', 1000.00000000, 500.00000000, 0.00000000, '2020/10/12 13:46:16', '2020/10/12 13:46:16', NULL, 1)
GO


