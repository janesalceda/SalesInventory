Imports Microsoft.Reporting.WinForms
Public Class FrmInventoryStockReport
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        loadgrid()
        loadReport()
    End Sub
    Private Sub loadgrid()
        dgvData.Rows.Clear()

        If String.IsNullOrEmpty(txtitem.Text) Then
            MsgBox("Please input itemId!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        Dim row As New DataTable
        Dim lastbalance As Decimal
        Dim currentbalance As Decimal
        Dim strTransactionDate As Date
        SQL.AddParams("@from", dtFrom.Value.ToShortDateString)
        SQL.AddParams("@to", dtTo.Value.ToShortDateString)
        SQL.AddParams("@itemid", txtitem.Text)
        SQL.ExecQuery("SELECT * FROM SAMPLEINV WHERE 
            convert(VARCHAR(10),TransactedDate,111) >= @from
            AND convert(VARCHAR(10),TransactedDate,111) <=@to
            AND ItemID=@itemid
            ORDER BY TransactedDate asc, TransactionTypeID DESC")
        If SQL.HasException Then Exit Sub

        row = SQL.DBDT

        SQL.AddParams("@from", (DateAdd("D", -1, dtFrom.Value.ToShortDateString)).ToShortDateString)
        SQL.AddParams("@itemid", txtitem.Text)
        SQL.ExecQuery("SELECT Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
        If SQL.HasException Then Exit Sub
        If SQL.DBDT.Rows.Count = 0 Then
            lastbalance = 0
        Else
            lastbalance = SQL.DBDT.Rows(0).Item(0)
        End If
        currentbalance = lastbalance

        With row
            For i As Integer = 0 To row.Rows.Count - 1
                SQL.params.Clear()
                dgvData.Rows.Add()

                Select Case .Rows(i).Item(4)
                    'In items based on Invoice
                    Case 1
                        If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                            'get the stockbalance based on transaction date row  -1 and add the qty row
                            SQL.params.Clear()
                            SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToShortDateString)
                            SQL.AddParams("@itemid", txtitem.Text)
                            SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
                            If SQL.DBDT.Rows.Count = 0 Then
                                currentbalance = 0 + .Rows(i).Item(3)
                            Else
                                currentbalance = SQL.DBDT.Rows(0).Item(0) + .Rows(i).Item(3)
                            End If
                        Else
                            'add the qty row to the currentbalance
                            currentbalance += .Rows(i).Item(3)
                        End If
                        dgvData.Rows(i).Cells(2).Value = .Rows(i).Item(3)
                        'Out items based on stock out
                    Case 2
                        If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                            SQL.params.Clear()
                            SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToShortDateString)
                            SQL.AddParams("@itemid", txtitem.Text)
                            'get the stockbalance based on transaction date row  -1 And minus the qty row
                            SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
                            If SQL.DBDT.Rows.Count = 0 Then
                                currentbalance = 0 - .Rows(i).Item(3)
                            Else

                                currentbalance = SQL.DBDT.Rows(0).Item(0) - .Rows(i).Item(3)
                            End If
                        Else
                            'minus the qty row to the currentbalance
                            currentbalance -= .Rows(i).Item(3)
                        End If
                        dgvData.Rows(i).Cells(3).Value = .Rows(i).Item(3)
                        'AC of items in Stock Taking
                    Case 3
                        If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                            'Get the current balance based on row
                            currentbalance = .Rows(i).Item(3)
                        Else
                            SQL.AddParams("@transdate", .Rows(i).Item(0))
                            SQL.AddParams("@item", txtitem.Text)
                            'Get the current balance based on row and (- the total sum of in and out based on row
                            'transaction date)
                            SQL.ExecQuery("EXECUTE dbo.TotalOut @TransactionDate = @transdate, @ItemId =@item ")
                            Dim totalin As Integer = SQL.DBDT.Rows(0).Item(0)
                            If SQL.HasException Then Exit Sub
                            SQL.AddParams("@transdate", .Rows(i).Item(0))
                            SQL.AddParams("@item", txtitem.Text)
                            SQL.ExecQuery("EXECUTE dbo.TotalIn @TransactionDate = @transdate, @ItemId =@item ")
                            Dim totalout As Integer = SQL.DBDT.Rows(0).Item(0)

                            currentbalance = .Rows(i).Item(3) - (totalout + totalin)
                        End If
                        dgvData.Rows(i).Cells(4).Value = .Rows(i).Item(3)
                End Select
                'Get latest transactiondate
                'strTransactionDate
                'Add other columns data
                strTransactionDate = Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString
                dgvData.Rows(i).Cells(0).Value = .Rows(i).Item(0)
                dgvData.Rows(i).Cells(1).Value = .Rows(i).Item(1)
                dgvData.Rows(i).Cells(6).Value = .Rows(i).Item(5)
                'dgvdata.Rows(i).Cells(2).Value = .Rows(i).Item(3)
                dgvData.Rows(i).Cells(5).Value = currentbalance

                'dgvdata.Rows.Add(row.Rows(i).Item(0), row.Rows(i).Item(1), currentbalance, "")
            Next
        End With
    End Sub
    Private Sub loadReport()
        Dim rptDs As ReportDataSource
        PrintPreview.ReportViewer1.RefreshReport()
        Try
            With PrintPreview.ReportViewer1.LocalReport
                '.ReportPath = "C:\temp\SalesandInventory\Report2.rdlc"
                .ReportPath = "C:\temp\SalesandInventory\Reportdlc\Report4.rdlc"
                .DataSources.Clear()
                Dim dt As New DataTable
                Dim ds As New DataSet2
                dt = ds.Tables("StockMonitoringDataSet")
                'SQL.AddParams("@from", DateTimePicker1.Value.ToShortDateString)
                'SQL.ExecQuery("SELECT i.itemid,i.Description,
                'isnull(test.qty,0) AS 'QTY',i.MinimumOrderQty AS 'MinStocks',
                'i.OrderingPointQty	AS 'OrderPoint'
                'FROM Items i
                ' LEFT JOIN (SELECT * FROM GetStockBalance(@from)) AS test
                ' ON test.ItemId = i.ItemId where i.deletedDate is null")
                For i = 0 To dgvData.Rows.Count - 1
                    dt.Rows.Add(txtitem.Text, Convert.ToDateTime(dgvData.Rows(i).Cells(0).Value).ToShortDateString,
                                dgvData.Rows(i).Cells(1).Value, dgvData.Rows(i).Cells(2).Value,
                                dgvData.Rows(i).Cells(3).Value, dgvData.Rows(i).Cells(4).Value,
                                dgvData.Rows(i).Cells(5).Value, dgvData.Rows(i).Cells(6).Value)
                Next
                If dgvData.Rows.Count = 0 Then
                    MsgBox("No data found!0", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
                rptDs = New ReportDataSource("DataSet1", dt)
                PrintPreview.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                PrintPreview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                PrintPreview.ReportViewer1.ZoomMode = ZoomMode.Percent
                PrintPreview.ReportViewer1.ZoomPercent = 100
                PrintPreview.Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
            'End With
        End Try

        'dt = ds.Tables("PODetails")
        'For i = 0 To dtablePoDetails.Rows.Count - 1
        '    dt.Rows.Add(dtablePoDetails.Rows(i).Cells(1).Value, dtablePoDetails.Rows(i).Cells(2).Value, dtablePoDetails.Rows(i).Cells(5).Value, dtablePoDetails.Rows(i).Cells(7).Value, dtablePoDetails.Rows(i).Cells(8).Value)
        'Next
        'With SaleReports.ReportViewer1.LocalReport
        '    .ReportPath = "C:\Users\smd255\Documents\GitHub\SalesInventory\InventorySystem\InventorySystem\Report1.rdlc"
        '    .DataSources.Clear()
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("PODataset", dt))
        'End With
        '
        'SaleReports.ReportViewer1.RefreshReport()

    End Sub
End Class