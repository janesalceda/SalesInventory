Public Class FrmLocationEntry

    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@Location", txtQtyunit.Text)
        SQL.AddParams("@Description", txtDes.Text)
        SQL.AddParams("@UpdatedBy", moduleId)
        SQL.AddParams("@disuse", chkDisuse.Checked)

        If Query = "INSERT" Then
            SQL.ExecQuery("
                INSERT INTO Locations 
                (Location,Description,DeletedDate,UpdatedBy)
                VALUES
                (@Location,@description,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
        Else
            SQL.AddParams("@LocationId", FrmLocationSearch.dtItems.SelectedRows(0).Cells(0).Value.ToString())
            SQL.ExecQuery("update Locations set Location=@Location,updatedDate=getdate(), 
                UpdatedBy=@UpdatedBy,
                deletedDate=(select case when @disuse=1 then getdate() else null end),
                Description=@Description where LocationId=@LocationId")
        End If
        If SQL.HasException(True) Then
            MsgBox("Error in Saving", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ExecuteQueries(btnInsert.Text)
        Me.Close()
    End Sub

End Class