Public Class FrmPrintingBarcode
    Private Sub FrmPrintingBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub loadSupplier()
        SQL.ExecQuery("Select * from Suppliers where deleteddate is null")
        If SQL.HasException Then Exit Sub
        cmbSupplier.DataSource = SQL.DBDT
        cmbSupplier.DisplayMember = "SupplierId"
        cmbSupplier.ValueMember = "SupplierName"
    End Sub

    Private Sub cmbSupplier_GotFocus(sender As Object, e As EventArgs) Handles cmbSupplier.GotFocus
        loadSupplier()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SQL.ExecQuery("Select * from Suppliers where deleteddate is null")
        If SQL.HasException Then Exit Sub
        If SQL.DBDT.Rows.Count = 0 Then
            msgboxDisplay("No Record Found!", 1)
            Exit Sub
        End If
    End Sub
End Class