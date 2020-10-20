Public Class FrmQtyUnitEntry
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@QtyUnit", txtQtyunit.Text)
        SQL.AddParams("@Description", txtDes.Text)
        SQL.AddParams("@UpdatedBy", moduleId)
        SQL.AddParams("@disuse", chkDisuse.Checked)

        If Query = "INSERT" Then
            SQL.ExecQuery("
                INSERT INTO QtyUnits 
                (QtyUnit,Description,DeletedDate,UpdatedBy)
                VALUES
                (@QtyUnit,@description,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
        Else
            SQL.AddParams("@QtyUnitId", FrmQtyUnitSearch.dtItems.SelectedRows(0).Cells(0).Value.ToString())
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
        ExecuteQueries(btnInsert.Text)
        Me.Close()
    End Sub
End Class