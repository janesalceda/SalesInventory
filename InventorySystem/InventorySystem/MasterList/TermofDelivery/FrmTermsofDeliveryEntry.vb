Public Class FrmTermsofDeliveryEntry

    Public id As Integer
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@description", txtDes.Text)
        SQL.AddParams("@termdelivery", txtTD.Text)
        SQL.AddParams("@disuse", chkDisuse.Checked)
        SQL.AddParams("@updatedby", moduleId)

        If Query = "SAVE" Then
            SQL.ExecQuery("
                INSERT INTO TermsOfDelivery 
                (TermOfDelivery,Description,DeletedDate,UpdatedBy)
                VALUES
                (@termdelivery,@description,(select case when @disuse=1 then getdate() else null end),@updatedby)")
        Else
            SQL.AddParams("@id", id)
            SQL.ExecQuery("UPDATE TermsOfDelivery SET TermOfDelivery=@termdelivery,Description=@description,DeletedDate=(select case when @disuse=1 then getdate() else null end),updateddate=getdate(),updatedby=@updatedby WHERE TermOfDeliveryId=@id")
        End If
        If SQL.HasException(True) Then
            MsgBox("Error in Saving", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        MsgBox("Successfully Saved", MsgBoxStyle.Information, "Information")
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ExecuteQueries(btnSave.Text)
        Me.Close()
    End Sub
    Private Sub txtTD_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTD.KeyUp
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Or Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtDes_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDes.KeyUp
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Or Not String.IsNullOrWhiteSpace(txtTD.Text) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub chkDisuse_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisuse.CheckedChanged
        btnSave.Enabled = True
    End Sub
End Class