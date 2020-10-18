Public Class EditSupplierName
    Private SupplierCode As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SQL.AddParams("@suppliername", txtSupplierName)
        'SQL.AddParams("@supplierid", txtSupplierName)
        SQL.ExecQuery("UPDATE Suppliers SET SupplierName=@suppliername where SupplierId=@supplierid")
    End Sub

End Class