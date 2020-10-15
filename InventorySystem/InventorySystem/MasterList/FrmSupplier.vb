Public Class Suppliers
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddSupplier.Show()
    End Sub
    Public Sub LoadGrid()
        SQL.ExecQuery("SELECT * FROM SUPPLIERS")
        If SQL.HasException Then Exit Sub
        dtSuppliers.DataSource = SQL.DBDT
    End Sub
    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click


    End Sub
    Private Sub dtSuppliers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSuppliers.CellClick
        With AddSupplier
            .txtSupplierId.Text = dtSuppliers.SelectedRows(0).Cells(0).Value.ToString
            .btnSave.Text = "UPDATE"
            .Show()
        End With
    End Sub
End Class