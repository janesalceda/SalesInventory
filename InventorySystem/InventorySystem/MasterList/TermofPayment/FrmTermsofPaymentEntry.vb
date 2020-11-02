Public Class FrmTermsofPaymentEntry
    Public id As Integer
    Private Sub ExecuteQueries(Query As String)
        Try
            SQL.AddParams("@description", txtDes.Text)
            SQL.AddParams("@termpayment", txtTD.Text)
            SQL.AddParams("@disuse", chkDisuse.Checked)
            SQL.AddParams("@updatedby", moduleId)

            If Query = "SAVE" Then
                SQL.ExecQuery("
                    INSERT INTO TermsofPayment 
                    (TermOfPayment,Description,DeletedDate,UpdatedBy)
                    VALUES
                    (@termpayment,@description,(select case when @disuse=1 then getdate() else null end),@updatedby)")
            Else
                SQL.AddParams("@id", id)
                SQL.ExecQuery("UPDATE TermsOfPayment SET TermOfPayment=@termdelivery,Description=@description,DeltedDate=s(select case when @disuse='getdate()' then getdate() else null end),updateddate=getdate(),updatedby=@updatedby WHERE TermOfPaymentId=@id")
                'Username=@username,Password=@pass,
            End If
            If SQL.HasException(True) Then Exit Sub
            MsgBox("Successfuly Saved", MsgBoxStyle.Information, "Information")
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtTD.Text) Then
            msgboxDisplay("Please input Terms of Payment!", 2)
            Exit Sub
        End If
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

    Private Sub FrmTermsofPaymentEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class