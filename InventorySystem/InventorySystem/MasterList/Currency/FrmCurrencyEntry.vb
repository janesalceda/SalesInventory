Public Class FrmCurrencyEntry
    Public id As Integer
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@CurrencyUnit", txtQtyunit.Text)
        SQL.AddParams("@AmountRoundType", txtDes.Text)
        SQL.AddParams("@UpdatedBy", moduleId)
        SQL.AddParams("@disuse", chkDisuse.Checked)

        If Query = "SAVE" Then
            SQL.ExecQuery("
                INSERT INTO CurrencyUnits 
                (CurrencyUnit,AmountRoundType,DeletedDate,UpdatedBy)
                VALUES
                (@CurrencyUnit,@AmountRoundType,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
        Else
            SQL.AddParams("@CurrencyUnitId", id)
            SQL.ExecQuery("update CurrencyUnits set CurrencyUnit=@CurrencyUnit,updatedDate=getdate(), 
                UpdatedBy=@UpdatedBy,
                deletedDate=(select case when @disuse=1 then getdate() else null end),
                AmountRoundType=@AmountRoundType where CurrencyUnitId=@CurrencyUnitId")
        End If
        If SQL.HasException(True) Then
            MsgBox("Error in Saving", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        MsgBox("Successfully saved", MsgBoxStyle.Information, "Information")
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ExecuteQueries(btnInsert.Text)
        Me.Close()
    End Sub
End Class