Public Class FrmLocationEntry
    Public id As Integer
    Private Sub ExecuteQueries(Query As String)
        Try
            SQL.AddParams("@Location", txtQtyunit.Text)
            SQL.AddParams("@Description", txtDes.Text)
            SQL.AddParams("@UpdatedBy", moduleId)
            SQL.AddParams("@disuse", chkDisuse.Checked)

            If Query = "SAVE" Then
                SQL.ExecQuery("
                INSERT INTO Locations 
                (Location,Description,DeletedDate,UpdatedBy)
                VALUES
                (@Location,@description,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
            Else
                SQL.AddParams("@LocationId", id)
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
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If String.IsNullOrWhiteSpace(txtQtyunit.Text) Then
            msgboxDisplay("Please input Location!", 2)
            Exit Sub
        End If
        ExecuteQueries(btnInsert.Text)
        Me.Close()
    End Sub

    Private Sub FrmLocationEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class