
INSERT INTO dbo.PoDetails (PoNo, ItemId, EtdDate, EtaDate, FtryDate, ReceivedAllInvoices, Canceled, PoDetailSeq, Qty, QtyUnit, EquivalentQty, EquivalentQtyUnit, UnitPrice, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('20201012-01', 'samp', '2020/10/12 12:00:30', '2020/10/12 12:00:30', '2020/10/12 12:00:30', 0, 0, 1, 1000.00000000, 1, 3.00000000, 1, 1000.0500, '2020/10/12 12:01:07', NULL, '2020/10/12 12:01:07', 1)
GO

INSERT INTO dbo.PoDetails (PoNo, ItemId, EtdDate, EtaDate, FtryDate, ReceivedAllInvoices, Canceled, PoDetailSeq, Qty, QtyUnit, EquivalentQty, EquivalentQtyUnit, UnitPrice, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('20201012-01', 'SSAMPLE', '2020/10/12 0:00:00', '2020/10/12 0:00:00', '2020/10/12 0:00:00', 0, 0, 2, 1000.00000000, 1, 2.00000000, 1, 1000.0500, '2020/10/12 12:01:07', NULL, '2020/10/12 12:01:07', 1)
GO

INSERT INTO dbo.POHeaders (PONo, SupplierID, CurrencyUnitId, IssuedDate, TermOfDeliveryId, TermOfPaymentId, DeliveryPlaceId, TotalAmount, Remarks, EncodedStaff, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('20201012-01', 'DALI KOTO', 1, '2020/10/12 0:00:00', 1, 1, 1, 5000.25, '', 1, '2020/10/12 12:01:07', NULL, '2020/10/12 12:01:07', 1)
GO



INSERT INTO dbo.TermsOfDelivery (TermOfDeliveryId, TermOfDelivery, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'GCASH', 'GCASH', '2020/10/12 8:00:21', NULL, '2020/10/12 8:00:21', 1)
GO


INSERT INTO dbo.TermsOfPayment (TermOfPaymentId, TermOfPayment, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'COD', 'Cash On Delivery', '2020/10/12 8:00:39', '2020/10/12 8:00:39', '2020/10/12 8:00:39', 1)
GO



INSERT INTO dbo.Suppliers (SupplierId, SupplierName, Attention, Address, Phone, Fax, Remarks, AccountsName, TermOfDeliveryId, TermOfPaymentId, CurrencyUnitId, ImportSupplier, EmailAddress, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('DALI KOTO', 'DALI STORES', 'Lou Arvic Gabiola', 'Bucandala, Imus City Cavite', '09555648356', '', 'sample ko', 'BDO', 1, 1, 1, 0, 'lou@pogi.com', '2020/10/12 8:46:57', NULL, '2020/10/12 8:46:57', 1)
GO


