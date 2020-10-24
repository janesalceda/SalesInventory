Public Class FrmChangeUOM
    Private Sub LoadCliUnit()
        cmbCliQtyUnit.DataSource = GetQtyUnit()
        cmbCliQtyUnit.DisplayMember = "QtyUnit"
        cmbCliQtyUnit.ValueMember = "QtyUnitId"
    End Sub

    Private Sub FrmChangeUOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCliUnit()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SQL.ExecQuery("UPDATE items ")
    End Sub
End Class