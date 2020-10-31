SELECT InvoiceDeliveryDetails.DeliveryDate, 
InvoiceDetails.ItemId,items.Description,InvoiceDeliveryDetails.QtyReceived,
InvoiceDeliveryDetails.InvoiceNo,InvoiceDetails.PoNo,InvoiceDetails.PoDetailSeq,
Suppliers.SupplierName,InvoiceDetails.SupplierUnitPrice
FROM InvoiceDeliveryDetails INNER JOIN InvoiceDetails 
ON InvoiceDeliveryDetails.InvoiceNo=InvoiceDetails.InvoiceNo
AND InvoiceDetails.InvoiceDetailSeq=InvoiceDeliveryDetails.InvoiceDetailSeq
INNER JOIN InvoiceHeaders ON InvoiceDeliveryDetails.InvoiceNo=InvoiceHeaders.InvoiceNo
INNER JOIN Items	ON items.ItemId	=InvoiceDetails.ItemId
INNER JOIN Suppliers ON Suppliers.SupplierId=InvoiceHeaders.SupplierId