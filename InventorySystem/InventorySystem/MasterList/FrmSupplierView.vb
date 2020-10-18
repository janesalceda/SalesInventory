Public Class Suppliers
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddSupplier.Show()
    End Sub
    Public Sub LoadGrid()
        SQL.ExecQuery("SELECT SupplierId,SupplierName FROM SUPPLIERS")
        If SQL.HasException Then Exit Sub
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtSuppliers.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), "X")
        Next
    End Sub
    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadGrid()
    End Sub

    'Private Sub btnEdit_Click(sender As Object, e As EventArgs) 
    '    With AddSupplier
    '        .txtSupplierId.Text = dtSuppliers.SelectedRows(0).Cells(0).Value.ToString
    '        .btnSave.Text = "UPDATE"
    '        .ShowDialog()
    '    End With
    'End Sub
    Private Sub dtSuppliers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSuppliers.CellClick
        If e.ColumnIndex = 2 Then
            If MsgBox("Do you want to delete?", MsgBoxStyle.YesNo, "Delete") = vbYes Then
                SQL.AddParams("@SupplierId", dtSuppliers.SelectedRows(0).Cells(0).Value.ToString)
                SQL.ExecQuery("UPDATE SUPPLIERS SET DELETEDDATE=GETDATE() where SupplierId=@SupplierId")
            End If
        Else
            With AddSupplier
                .txtSupplierId.Text = dtSuppliers.SelectedRows(0).Cells(0).Value.ToString
                .btnSave.Text = "UPDATE"
                .Show()
            End With
        End If
    End Sub
End Class