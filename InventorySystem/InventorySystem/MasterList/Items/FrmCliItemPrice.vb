﻿Public Class FrmCliItemPrice
    Public ItemId As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(txtUnitPrice.Text) Then
            MsgBox("Please input Unit Price!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If btnSave.Text = "INSERT PRICE" Then
            FrmItemEntry.dtableCliPrice.Rows.Add(dtAppliedDate.Value, txtUnitPrice.Text, "", "")
                If FrmItemEntry.dtableItemPrices.Rows.Count <> 0 Or
                    Not String.IsNullOrWhiteSpace(FrmItemEntry.dtableItemPrices.Rows(0).Cells(3).Value) Then
                    FrmItemEntry.btnSave.Text = "UPDATE"
                    FrmItemEntry.btnSave.Visible = True
                Else
                    FrmItemEntry.btnSave.Text = "SAVE"

                End If
        Else
            FrmItemEntry.dtableCliPrice.SelectedRows(0).Cells(1).Value = dtAppliedDate.Value.ToString("yyyy/MM/dd")
            FrmItemEntry.dtableCliPrice.SelectedRows(0).Cells(2).Value = txtUnitPrice.Text
        End If
            Me.Close()
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub

    Private Sub FrmCliItemPrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtAppliedDate.Value = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
    End Sub
End Class