Public Class FrmDeliveryPlacesEntry
    Public id As Integer
    Private Sub ExecuteQueries(Query As String)
        Try
            SQL.AddParams("@DeliveryPlace", txtQtyunit.Text)
            SQL.AddParams("@Description", txtDes.Text)
            SQL.AddParams("@UpdatedBy", moduleId)
            SQL.AddParams("@disuse", chkDisuse.Checked)

            If Query = "SAVE" Then
                SQL.ExecQuery("
                INSERT INTO DeliveryPlaces 
                (DeliveryPlace,Description,DeletedDate,UpdatedBy)
                VALUES
                (@DeliveryPlace,@description,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
            Else
                SQL.AddParams("@DeliveryPlaceId", id)
                SQL.ExecQuery("update DeliveryPlaces set DeliveryPlace=@DeliveryPlace,updatedDate=getdate(), 
                UpdatedBy=@UpdatedBy,
                deletedDate=(select case when @disuse=1 then getdate() else null end),
                Description=@Description where DeliveryPlaceId=@DeliveryPlaceId")
            End If
            If SQL.HasException(True) Then
                MsgBox("Error in Saving", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If String.IsNullOrWhiteSpace(txtQtyunit.Text) Then
            msgboxDisplay("Please input DeliveryPlace!", 2)
            Exit Sub
        End If
        ExecuteQueries(btnInsert.Text)
        Me.Close()
    End Sub

    Private Sub FrmDeliveryPlacesEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class