Public Class FrmProductRanking
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If dtFrom.Value.ToString("yyyy/MM/dd") > dtTo.Value.ToString("yyyy/MM/dd") Then
                msgboxDisplay("Date From cannot be late than Date To ", 3)
                Exit Sub
            End If
            SQL.params.Clear()
            Dim where As String = ""
            If cmbOrderType.SelectedIndex = -1 Then
                msgboxDisplay("Please choose Order type!", 2)
            End If
            If cmbAmount.SelectedIndex >= 0 And cmbAsc.SelectedIndex >= 0 Then
                If cmbAmount.SelectedIndex = 0 Then
                    where = " ORDER BY TotalClient " & cmbAsc.Text
                ElseIf cmbAmount.SelectedIndex = 1 Then
                    where = " ORDER BY TotalSupplier " & cmbAsc.Text
                Else
                    where = " ORDER BY Quantity " & cmbAsc.Text
                End If
            End If
            dgvData.Rows.Clear()

            SQL.AddParams("@From", dtFrom.Value.ToString("yyyy/MM/dd"))
            SQL.AddParams("@To", dtTo.Value.ToString("yyyy/MM/dd"))
            If cmbOrderType.SelectedIndex = 0 Then
                '      SQL.ExecQuery("SELECT itemId,description,sum(Quantity)'Quantity',sum(TotalSupplier)'TotalSupplier',
                '      sum(TotalClient)'TotalClient' FROM (
                'select i.ItemId,i.Description,isnull(sum(idd.QtyOk),0)'Quantity',
                '      isnull(sum(idd.QtyOk*id.SupplierUnitPrice),0)'TotalSupplier',
                '      isnull(sum(idd.QtyOk*id.ClientUnitPrice),0)'TotalClient' from
                '      items i left join InvoiceDetails id on i.ItemId=id.ItemId
                '      INNER JOIN InvoiceDeliveryDetails idd ON
                '      id.InvoiceNo=idd.InvoiceNo	AND 
                '      id.InvoiceDetailSeq=idd.InvoiceDetailSeq

                '      group by i.ItemId,i.Description
                '      union all

                '    select i.ItemId,i.Description,isnull(sum(sod.qty),0)'Quantity',
                '      isnull(sum(sod.Qty*sod.SupplierUnitPrice),0)'TotalSupplier',
                '      isnull(sum(sod.Qty*sod.ClientUnitPrice),0)'TotalClient' from
                '      items i left join StockOutDetails sod on i.ItemId=sod.ItemId
                '      group by i.ItemId,i.Description) a
                '      GROUP BY itemId,description" & where)
                SQL.ExecQuery("select itemId,description,sum(Quantity)'Quantity',sum(TotalSupplier)'TotalSupplier',
                    sum(TotalClient)'TotalClient' FROM (
                    select i.ItemId,i.Description,isnull(sum(InvoiceDeliveryDetails.QtyOk),0)'Quantity',
                    isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.SupplierUnitPrice),0)'TotalSupplier',
                    isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.ClientUnitPrice),0)'TotalClient' 
                    from items i left join InvoiceDetails
                    on InvoiceDetails.ItemId=i.itemid
                    left join InvoiceHeaders on InvoiceHeaders.InvoiceNo=InvoiceDetails.InvoiceNo
                    left join InvoiceDeliveryDetails
                    on InvoiceDeliveryDetails.InvoiceNo=InvoiceDetails.InvoiceNo
                    and InvoiceDeliveryDetails.InvoiceDetailSeq=InvoiceDetails.InvoiceDetailSeq
                    where InvoiceHeaders.InvoiceDate between @from and @to
                    group by i.ItemId,i.Description
                    union all
                    select i.ItemId,i.Description,isnull(sum(sod.qty),0)'Quantity',
                    isnull(sum(sod.Qty*sod.SupplierUnitPrice),0)'TotalSupplier',
                    isnull(sum(sod.Qty*sod.ClientUnitPrice),0)'TotalClient' from
                    items i left join StockOutDetails sod on i.ItemId=sod.ItemId
                    left join StockOutHeaders on sod.StockOutCode=StockOutHeaders.StockOutCode
                    where StockOutHeaders.StockOutDate between @from and @to
                    group by i.ItemId,i.Description) a
                    GROUP BY itemId,description" & where)
                If SQL.HasException Then
                    msgboxDisplay("Error in Viewing Data", 3)
                    Exit Sub
                ElseIf SQL.DBDT.Rows.Count = 0 Then
                    msgboxDisplay("No record found", 1)
                    Exit Sub
                End If
                For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
                    dgvData.Rows.Add(dgvData.Rows.Count + 1, SQL.DBDT.Rows(i).Item("ItemId"),
                                 SQL.DBDT.Rows(i).Item("Description"), SQL.DBDT.Rows(i).Item("Quantity"),
                                 SQL.DBDT.Rows(i).Item("TotalSupplier"), SQL.DBDT.Rows(i).Item("TotalClient"))
                Next
            ElseIf cmbOrderType.SelectedIndex = 1 Then
                'SQL.ExecQuery("	select i.ItemId,i.Description,isnull(sum(id.QtyOk),0)'Quantity',
                'isnull(sum(id.QtyOk*id.SupplierUnitPrice),0)'TotalSupplier',
                'isnull(sum(id.QtyOk*id.ClientUnitPrice),0)'TotalClient' from
                'items i left join (SELECT id.ItemId,idd.QtyOk,id.SupplierUnitPrice,id.ClientUnitPrice 
                'FROM InvoiceDetails id 
                'INNER JOIN InvoiceDeliveryDetails idd ON
                'id.InvoiceNo=idd.InvoiceNo	AND 
                'id.InvoiceDetailSeq=idd.InvoiceDetailSeq) AS id on

                'i.ItemId=id.ItemId
                'group by i.ItemId,i.Description " & where)
                SQL.ExecQuery(" select i.ItemId,i.Description,isnull(sum(InvoiceDeliveryDetails.QtyOk),0)'Quantity',
                    isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.SupplierUnitPrice),0)'TotalSupplier',
                    isnull(sum(InvoiceDeliveryDetails.QtyOk*InvoiceDetails.ClientUnitPrice),0)'TotalClient' 
                    from items i left join InvoiceDetails
                    on InvoiceDetails.ItemId=i.itemid
                    left join InvoiceHeaders on InvoiceHeaders.InvoiceNo=InvoiceDetails.InvoiceNo
                    left join InvoiceDeliveryDetails
                    on InvoiceDeliveryDetails.InvoiceNo=InvoiceDetails.InvoiceNo
                    and InvoiceDeliveryDetails.InvoiceDetailSeq=InvoiceDetails.InvoiceDetailSeq
                    where InvoiceHeaders.InvoiceDate between @from and @to
                    group by i.ItemId,i.Description" & where)
                If SQL.HasException Then
                    msgboxDisplay("Error in Viewing Data", 3)
                    Exit Sub
                ElseIf SQL.DBDT.Rows.Count = 0 Then
                    msgboxDisplay("No record found", 1)
                    Exit Sub
                End If
                For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
                    dgvData.Rows.Add(dgvData.Rows.Count + 1, SQL.DBDT.Rows(i).Item("ItemId"),
                                 SQL.DBDT.Rows(i).Item("Description"), SQL.DBDT.Rows(i).Item("Quantity"),
                                 SQL.DBDT.Rows(i).Item("TotalSupplier"), SQL.DBDT.Rows(i).Item("TotalClient"))
                Next
            ElseIf cmbOrderType.SelectedIndex = 2 Then
                'SQL.ExecQuery("select i.ItemId,i.Description,isnull(sum(sod.qty),0)'Quantity',
                '    isnull(sum(sod.Qty*sod.SupplierUnitPrice),0)'TotalSupplier',
                '    isnull(sum(sod.Qty*sod.ClientUnitPrice),0)'TotalClient' from
                '    items i left join StockOutDetails sod on i.ItemId=sod.ItemId
                '    group by i.ItemId,i.Description" & where)
                SQL.ExecQuery(" select i.ItemId,i.Description,isnull(sum(sod.qty),0)'Quantity',
                    isnull(sum(sod.Qty*sod.SupplierUnitPrice),0)'TotalSupplier',
                    isnull(sum(sod.Qty*sod.ClientUnitPrice),0)'TotalClient' from
                    items i left join StockOutDetails sod on i.ItemId=sod.ItemId
                    left join StockOutHeaders on sod.StockOutCode=StockOutHeaders.StockOutCode
                    where StockOutHeaders.StockOutDate between @from and @to
                    group by i.ItemId,i.Description" & where)

                If SQL.HasException Then
                    msgboxDisplay("Error in Viewing Data", 3)
                    Exit Sub
                ElseIf SQL.DBDT.Rows.Count = 0 Then
                    msgboxDisplay("No record found", 1)
                    Exit Sub
                End If
                For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
                    dgvData.Rows.Add(dgvData.Rows.Count + 1, SQL.DBDT.Rows(i).Item("ItemId"),
                                 SQL.DBDT.Rows(i).Item("Description"), SQL.DBDT.Rows(i).Item("Quantity"),
                                 SQL.DBDT.Rows(i).Item("TotalSupplier"), SQL.DBDT.Rows(i).Item("TotalClient"))
                Next
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmProductRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reLoad()
    End Sub
    Private Sub reLoad()
        cmbAmount.SelectedIndex = -1
        cmbOrderType.SelectedIndex = -1
        cmbAsc.SelectedIndex = -1
        dtFrom.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtTo.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ' dtTo.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtFrom.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dgvData.Rows.Clear()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        reLoad()
    End Sub
End Class