Public Class FrmQtyUnitEntry
    Public id As Integer
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@QtyUnit", txtQtyunit.Text)
        SQL.AddParams("@Description", txtDes.Text)
        SQL.AddParams("@UpdatedBy", moduleId)
        SQL.AddParams("@disuse", chkDisuse.Checked)

        If Query = "SAVE" Then
            SQL.ExecQuery("
                INSERT INTO QtyUnits 
                (QtyUnit,Description,DeletedDate,UpdatedBy)
                VALUES
                (@QtyUnit,@description,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
        Else
            SQL.AddParams("@QtyUnitId", id)
            SQL.ExecQuery("update QtyUnits set QtyUnit=@QtyUnit,updatedDate=getdate(), 
                UpdatedBy=@UpdatedBy,
                deletedDate=(select case when @disuse=1 then getdate() else null end),
                Description=@Description where QtyUnitId=@QtyUnitId")
        End If
        If SQL.HasException(True) Then
            MsgBox("Error in Saving", MsgBoxStyle.Critical, "Information")
            Exit Sub
        End If
        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If String.IsNullOrWhiteSpace(txtQtyunit.Text) Then
            msgboxDisplay("Please input Qty Unit!", 2)
            Exit Sub
        End If
        ExecuteQueries(btnInsert.Text)
        Me.Close()
    End Sub

    Private Sub FrmQtyUnitEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class