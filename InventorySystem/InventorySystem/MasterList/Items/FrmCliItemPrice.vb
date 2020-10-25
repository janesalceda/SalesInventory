Public Class FrmCliItemPrice
    Public ItemId As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtUnitPrice.Text) Then
            MsgBox("Please input Unit Price!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If btnSave.Text = "INSERT PRICE" Then
            FrmItemEntry.dtableCliPrice.Rows.Add(dtAppliedDate.Value, txtUnitPrice.Text, "", "")
            If Not String.IsNullOrWhiteSpace(FrmItemEntry.txtItemId.Text) Then
                FrmItemEntry.btnSave.Text = "UPDATE"
                FrmItemEntry.btnSave.Visible = True
            End If
        Else
            FrmItemEntry.dtableCliPrice.SelectedRows(0).Cells(1).Value = dtAppliedDate.Value.ToString("yyyy/MM/dd")
            FrmItemEntry.dtableCliPrice.SelectedRows(0).Cells(2).Value = txtUnitPrice.Text
        End If
        Me.Close()
    End Sub
    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub
End Class