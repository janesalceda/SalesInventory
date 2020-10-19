Public Class FrmDeliveryPlacesEntry
    Private Sub FrmDeliveryPlaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@DeliveryPlace", txtQtyunit.Text)
        SQL.AddParams("@Description", txtDes.Text)
        SQL.AddParams("@UpdatedBy", moduleId)
        SQL.AddParams("@disuse", chkDisuse.Checked)

        If Query = "INSERT" Then
            SQL.ExecQuery("
                INSERT INTO DeliveryPlaces 
                (DeliveryPlace,Description,DeletedDate,UpdatedBy)
                VALUES
                (@DeliveryPlace,@description,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
        Else
            SQL.AddParams("@DeliveryPlaceId", FrmDeliveryPlacesSearch.dtItems.SelectedRows(0).Cells(0).Value.ToString())
            SQL.ExecQuery("update DeliveryPlaces set DeliveryPlace=@DeliveryPlace,updatedDate=getdate(), 
                UpdatedBy=@UpdatedBy,
                deletedDate=(select case when @disuse=1 then getdate() else null end),
                Description=@Description where DeliveryPlaceId=@DeliveryPlaceId")
        End If
        If SQL.HasException(True) Then
            MsgBox("Error in Saving", MsgBoxStyle.Critical)
            Exit Sub
        End If
        MsgBox("Successfully Saved", MsgBoxStyle.Information)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ExecuteQueries(btnInsert.Text)
        Me.Close()
    End Sub
End Class