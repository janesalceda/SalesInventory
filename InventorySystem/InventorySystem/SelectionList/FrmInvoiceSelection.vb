Public Class FrmInvoiceSelection

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If dtitems.Rows.Count = 0 Then Exit Sub
        AddInvoice.InvoiceSeq = dtitems.SelectedRows(0).Cells(0).Value.ToString
        AddInvoice.txtItemDel.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString
        AddInvoice.txtIteamNameDel.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString
        AddInvoice.txtPoDel.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString
        AddInvoice.txtposeqdel.Text = dtitems.SelectedRows(0).Cells(4).Value.ToString
        AddInvoice.txtExp.Text = dtitems.SelectedRows(0).Cells(5).Value.ToString
        Me.Close()
    End Sub

    Private Sub FrmInvoiceSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtitems.Rows.Clear()

        For i As Integer = 0 To AddInvoice.dtableInvoice.Rows.Count - 1
            dtitems.Rows.Add(
                AddInvoice.dtableInvoice.Rows(i).Cells(0).Value.ToString,
                AddInvoice.dtableInvoice.Rows(i).Cells(1).Value.ToString,
                AddInvoice.dtableInvoice.Rows(i).Cells(2).Value.ToString,
                AddInvoice.dtableInvoice.Rows(i).Cells(3).Value.ToString,
                AddInvoice.dtableInvoice.Rows(i).Cells(4).Value.ToString,
                AddInvoice.dtableInvoice.Rows(i).Cells(7).Value.ToString)
        Next
    End Sub
End Class