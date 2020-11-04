Public Class FrmCurrencyEntry
    Public id As Integer
    Private Sub ExecuteQueries(Query As String)
        Try
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
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim strcomplete As String = "Please complete the ff: " & vbNewLine
        If String.IsNullOrWhiteSpace(txtQtyunit.Text) Then
            strcomplete += "*Currency" & vbNewLine
        End If
        If String.IsNullOrWhiteSpace(txtDes.Text) Then
            strcomplete += "*AmountRound"

        End If
        If strcomplete = "Please complete the ff: " & vbNewLine Then
            ExecuteQueries(btnInsert.Text)
            Me.Close()
        Else
            msgboxDisplay(strcomplete, 2)
            Exit Sub
        End If
    End Sub

    Private Sub FrmCurrencyEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class