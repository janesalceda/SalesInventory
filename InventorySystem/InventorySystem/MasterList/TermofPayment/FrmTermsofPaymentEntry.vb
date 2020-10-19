﻿Public Class FrmTermsofPaymentEntry
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@description", txtDes.Text)
        SQL.AddParams("@termpayment", txtTD.Text)
        If chkDisuse.Checked = True Then
            SQL.AddParams("@disuse", "getdate()")
        Else
            SQL.AddParams("@disuse", "getdate()")
        End If
        SQL.AddParams("@updatedby", moduleId)

        If Query = "SAVE" Then
            SQL.ExecQuery("
                INSERT INTO TermsofPayment 
                (TermOfPayment,Description,DeletedDate,UpdatedBy)
                VALUES
                (@termpayment,@description,(select case when @disuse='getdate()' then getdate() else null end),@updatedby)")
        Else
            SQL.AddParams("@id", FrmTermofPaymentSearch.dtItems.SelectedRows(0).Cells(0))
            SQL.ExecQuery("UPDATE TermsOfPayment SET TermOfPayment=@termdelivery,Description=@description,DeltedDate=s(select case when @disuse='getdate()' then getdate() else null end),updateddate=getdate(),updatedby=@updatedby WHERE TermOfPaymentId=@id")
            'Username=@username,Password=@pass,
        End If
        If SQL.HasException(True) Then Exit Sub
        MsgBox("Successfuly Saved", MsgBoxStyle.Information)
    End Sub
    Private Sub FrmDeliveryPlaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
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