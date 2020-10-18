﻿Module Globals
    Public moduleId As Integer
    Public moduleName As String
    Public rights As Integer = 0
    Public formname As String
    Public price As Integer
    Public coefficient As Decimal
    Public SupplierId As String
    Public SQL As New SQLControl
    Public Function AddingWhere(where As String) As String
        If where <> "" Then
            Return " AND "
        Else
            Return " WHERE "
        End If
    End Function
    Public Function GetSupplierName(SupplierId As String) As ArrayList
        Dim Globalrow As ArrayList = New ArrayList
        SQL.AddParams("@supplierid", SupplierId)
        SQL.ExecQuery("SELECT SupplierId,SupplierName,CurrencyUnit,TermOfDelivery,TermOfPayment FROM Suppliers s 
            INNER join TermsOfDelivery td ON s.TermOfDeliveryId=td.TermOfDeliveryId
            INNER join TermsOfPayment tp ON s.TermOfPaymentId=tp.TermOfPaymentId
            INNER join CurrencyUnits c ON s.CurrencyUnitId=c.CurrencyUnitId where supplierid= @supplierid")

        If SQL.HasException Then Return Globalrow
        If SQL.RecordCount = 0 Then Return Globalrow
        Globalrow.Add(SQL.DBDT.Rows(0).Item(1))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(2))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(3))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(4))
        Return Globalrow
    End Function
    Public Function GetItemDetails(ItemId As String) As ArrayList
        Dim Globalrow As ArrayList = New ArrayList
        SQL.AddParams("@ItemId", ItemId)
        SQL.ExecQuery("SELECT DISTINCT i.Description,
            ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.ClientQtyUnit and i.ItemId=@ItemId) 'Client',
            ( SELECT  q.QtyUnit FROM Items i, QtyUnits q WHERE q.QtyUnitId=i.SupplierQtyUnit and i.ItemId=@ItemId) 'Supplier',
            ConvertingCoefficient,
            UnitPrice FROM Items i INNER JOIN SupplierItemPrices s ON i.ItemId=s.ItemId, QtyUnits q 
            where i.ItemId=@ItemId")
        If SQL.HasException Then Return Globalrow
        If SQL.RecordCount = 0 Then Return Globalrow
        Globalrow.Add(SQL.DBDT.Rows(0).Item(0))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(1))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(2))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(3))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(4))
        Return Globalrow
    End Function
    Public Function GetPODetails(PONo As String) As ArrayList
        Dim Globalrow As ArrayList = New ArrayList
        SQL.AddParams("@PONo", PONo)
        SQL.ExecQuery("SELECT SupplierId,SupplierName,CurrencyUnit,TermOfDelivery,TermOfPayment FROM Suppliers s 
            INNER join TermsOfDelivery td ON s.TermOfDeliveryId=td.TermOfDeliveryId
            INNER join TermsOfPayment tp ON s.TermOfPaymentId=tp.TermOfPaymentId
            INNER join CurrencyUnits c ON s.CurrencyUnitId=c.CurrencyUnitId where supplierid= @supplierid")

        If SQL.HasException Then Return Globalrow
        If SQL.RecordCount = 0 Then Return Globalrow
        Globalrow.Add(SQL.DBDT.Rows(0).Item(1))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(2))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(3))
        Globalrow.Add(SQL.DBDT.Rows(0).Item(4))
        Return Globalrow
    End Function
    Public Function getDelivery()
        SQL.ExecQuery("select * from TermsOfDelivery")
        'cmbTDelivery.Items.Add(SQL.DBDT.Rows(index).Item(0))
        Return SQL.DBDT
    End Function
    Public Function GetQtyUnit()
        SQL.ExecQuery("select * from QtyUnits")
        If SQL.HasException Then Return False
        Return SQL.DBDT
    End Function
    Public Function getPayment()
        SQL.ExecQuery("select * from TermsOfPayment")
        If SQL.HasException Then Return False
        Return SQL.DBDT
    End Function
    Public Function getDeliveryPlaces()
        SQL.ExecQuery("select * from DeliveryPlaces")
        If SQL.HasException Then Return False
        Return SQL.DBDT
    End Function
    Public Function getLocation()
        SQL.ExecQuery("select * from Locations")
        If SQL.HasException Then Return False
        Return SQL.DBDT
    End Function
    Public Function getCategories()
        SQL.ExecQuery("select * from Categories")
        If SQL.HasException Then Return False
        Return SQL.DBDT
    End Function
    Public Function GetCurrency()
        SQL.ExecQuery("select * from CurrencyUnits")
        If SQL.HasException Then Return False
        Return SQL.DBDT
    End Function

    Public Function GetItemcode()
        SQL.ExecQuery("SELECT dbo.GenerateItemCode()")
        If SQL.HasException Then Return False
        Return SQL.DBDT.Rows(0).Item(0)
    End Function
End Module
