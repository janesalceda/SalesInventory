
CREATE TABLE [dbo].[InvoiceDetails](
	[InvoiceNo] [varchar](50) NOT NULL,
	[SupplierId] [varchar](25) NOT NULL,
	[InvoiceDetailSeq] [int] NOT NULL,
	[ItemId] [varchar](20) NOT NULL,
	[PoNo] [varchar](20) NULL,
	[PoDetailSeq] [int] NULL,
	[Remarks] [varchar](200) NULL,
	[DeliveryCompletedDate] [datetime] NULL,
	[Qty] [decimal](18, 10) NULL,
	[EquivalentQty] [decimal](18, 10) NULL,
	[ClientUnitPrice] [decimal](19, 4) NULL,
	[SupplierUnitPrice] [decimal](19, 4) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK__InvoiceD__5DA0088A6DCC4D03] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC,
	[SupplierId] ASC,
	[InvoiceDetailSeq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[InvoiceDetails] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[InvoiceDetails] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO

USE [SalesAndInventory]
GO

/****** Object:  Table [dbo].[PoDetails]    Script Date: 27/10/2020 10:03:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PoDetails](
	[PoNo] [varchar](20) NOT NULL,
	[ItemId] [varchar](20) NOT NULL,
	[EtdDate] [datetime] NULL,
	[EtaDate] [datetime] NULL,
	[FtryDate] [datetime] NULL,
	[ReceivedAllInvoices] [bit] NOT NULL,
	[Canceled] [bit] NOT NULL,
	[PoDetailSeq] [int] NOT NULL,
	[Qty] [decimal](18, 8) NULL,
	[QtyUnit] [int] NULL,
	[EquivalentQty] [decimal](18, 8) NULL,
	[EquivalentQtyUnit] [int] NULL,
	[SupplierUnitPrice] [decimal](19, 4) NULL,
	[ClientUnitPrice] [decimal](19, 4) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
 CONSTRAINT [PK__PoDetail__AA40E05973852659] PRIMARY KEY CLUSTERED 
(
	[PoNo] ASC,
	[PoDetailSeq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PoDetails] ADD  DEFAULT ((0)) FOR [PoNo]
GO

ALTER TABLE [dbo].[PoDetails] ADD  DEFAULT ((0)) FOR [ReceivedAllInvoices]
GO

ALTER TABLE [dbo].[PoDetails] ADD  DEFAULT ((0)) FOR [Canceled]
GO

ALTER TABLE [dbo].[PoDetails] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[PoDetails] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO


USE [SalesAndInventory]
GO

/****** Object:  Table [dbo].[ReturnDetails]    Script Date: 27/10/2020 10:03:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ReturnDetails](
	[ReturnID] [varchar](20) NOT NULL,
	[ItemID] [varchar](20) NOT NULL,
	[Qty] [decimal](18, 8) NULL,
	[Remarks] [varchar](200) NULL,
	[SupplierUnitPrice] [decimal](19, 4) NULL,
	[ClientUnitPrice] [decimal](19, 4) NULL,
	[CreatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK__ReturnDe__536201B60D0FEE32] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ReturnDetails] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[ReturnDetails] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO

USE [SalesAndInventory]
GO

/****** Object:  Table [dbo].[StockOutDetails]    Script Date: 27/10/2020 10:03:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StockOutDetails](
	[StockOutCode] [varchar](20) NOT NULL,
	[ItemSeq] [numeric](3, 0) NOT NULL,
	[ItemID] [varchar](20) NOT NULL,
	[Qty] [decimal](18, 8) NULL,
	[SupplierUnitPrice] [decimal](19, 4) NULL,
	[ClientUnitPrice] [decimal](19, 4) NULL,
	[Remarks] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](8) NULL,
 CONSTRAINT [PK__StockOut__B19D7D6A078C1F06] PRIMARY KEY CLUSTERED 
(
	[StockOutCode] ASC,
	[ItemSeq] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StockOutDetails] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[StockOutDetails] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO

USE [SalesAndInventory]
GO

/****** Object:  Table [dbo].[StockTakingDetails]    Script Date: 27/10/2020 10:03:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StockTakingDetails](
	[STID] [varchar](20) NOT NULL,
	[ItemID] [varchar](20) NOT NULL,
	[Qty] [decimal](18, 8) NULL,
	[SupplierUnitPrice] [decimal](19, 4) NULL,
	[ClientUnitPrice] [decimal](19, 4) NULL,
	[Remarks] [varchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[DeletedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK__StockTak__012CF4A611158940] PRIMARY KEY CLUSTERED 
(
	[STID] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StockTakingDetails] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[StockTakingDetails] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO

