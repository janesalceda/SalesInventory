Public Class FrmInvoiceSelection

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        save()
    End Sub

    Private Sub FrmInvoiceSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtitems.Rows.Clear()

        For i As Integer = 0 To FrmInvoiceEntry.dtableInvoice.Rows.Count - 1
            dtitems.Rows.Add(
                FrmInvoiceEntry.dtableInvoice.Rows(i).Cells(0).Value.ToString,
                FrmInvoiceEntry.dtableInvoice.Rows(i).Cells(1).Value.ToString,
                FrmInvoiceEntry.dtableInvoice.Rows(i).Cells(2).Value.ToString,
                FrmInvoiceEntry.dtableInvoice.Rows(i).Cells(3).Value.ToString,
                FrmInvoiceEntry.dtableInvoice.Rows(i).Cells(4).Value.ToString,
                FrmInvoiceEntry.dtableInvoice.Rows(i).Cells(7).Value.ToString)
        Next
    End Sub
    Private Sub save()
        If dtitems.Rows.Count = 0 Then Exit Sub
        FrmInvoiceEntry.InvoiceSeq = dtitems.SelectedRows(0).Cells(0).Value.ToString
        FrmInvoiceEntry.txtItemDel.Text = dtitems.SelectedRows(0).Cells(1).Value.ToString
        FrmInvoiceEntry.txtIteamNameDel.Text = dtitems.SelectedRows(0).Cells(2).Value.ToString
        FrmInvoiceEntry.txtPoDel.Text = dtitems.SelectedRows(0).Cells(3).Value.ToString
        FrmInvoiceEntry.txtposeqdel.Text = dtitems.SelectedRows(0).Cells(4).Value.ToString
        FrmInvoiceEntry.txtExp.Text = dtitems.SelectedRows(0).Cells(5).Value.ToString
        Me.Close()
    End Sub

    Private Sub dtitems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtitems.CellDoubleClick
        save
    End Sub
End Class