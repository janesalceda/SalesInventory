Imports Microsoft.Reporting.WinForms
Public Class FrmInventoryStockReport
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Text = "Please wait ..."
        btnPrint.Enabled = False
        loadgrid()
        loadReport()
        btnPrint.Text = "PRINT"
        btnPrint.Enabled = True
    End Sub
    Private Sub loadgrid()
        Try
            dgvData.Rows.Clear()
            If String.IsNullOrEmpty(txtitem.Text) Then
                MsgBox("Please input itemId!", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            If dtFrom.Value.ToString("yyyy/MM/dd") > dtTo.Value.ToString("yyyy/MM/dd") Then
                msgboxDisplay("Date From cannot be late than Date To ", 3)
                Exit Sub
            End If
            Dim row As New DataTable
            Dim lastbalance As Decimal
            Dim currentbalance As Decimal
            'Dim lastclicost As Decimal
            'Dim currentclicost As Decimal
            ' Dim lastsupcost As Decimal
            ' Dim currentsupcost As Decimal
            Dim strTransactionDate As Date
            SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
            SQL.AddParams("@to", dtTo.Value.ToString("yyyy/MM/dd"))
            SQL.AddParams("@itemid", txtitem.Text)
            SQL.ExecQuery("SELECT * FROM SampleInv WHERE 
            convert(VARCHAR(10),TransactedDate,111) >= @from
            AND convert(VARCHAR(10),TransactedDate,111) <=@to
            AND ItemID=@itemid
            ORDER BY TransactedDate asc, TransactionTypeID DESC")
            If SQL.HasException Then Exit Sub
            If SQL.DBDT.Rows.Count = 0 Then
                msgboxDisplay("No record", 1)
                Exit Sub
            End If
            row = SQL.DBDT

            SQL.AddParams("@from", DateAdd("D", -1, dtFrom.Value.ToString("yyyy/MM/dd")))
            SQL.AddParams("@itemid", txtitem.Text)
            SQL.ExecQuery("SELECT Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
            If SQL.HasException Then Exit Sub
            If SQL.DBDT.Rows.Count = 0 Then
                lastbalance = 0
            Else
                lastbalance = SQL.DBDT.Rows(0).Item(0)
            End If
            currentbalance = lastbalance

            'SQL.AddParams("@from", DateAdd("D", -1, dtFrom.Value.ToString("yyyy/MM/dd")))
            'SQL.AddParams("@itemid", txtitem.Text)
            'SQL.ExecQuery("SELECT ClientCost,SupplierCost FROM GetcostBalance(@from) WHERE ItemID=@itemid")
            'If SQL.HasException Then Exit Sub
            'If SQL.DBDT.Rows.Count = 0 Then
            '    lastclicost = 0
            '    lastsupcost = 0
            'Else
            '    lastclicost = SQL.DBDT.Rows(0).Item(0)
            '    lastsupcost = SQL.DBDT.Rows(0).Item(1)
            'End If
            'currentclicost = lastclicost
            'currentsupcost = lastsupcost

            With row
                For i As Integer = 0 To row.Rows.Count - 1
                    SQL.params.Clear()
                    dgvData.Rows.Add()

                    Select Case .Rows(i).Item(4)
                    'In items based on Invoice
                        Case 1
                            If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToString("yyyy/MM/dd") Then
                                'get the stockbalance based on transaction date row  -1 and add the qty row
                                SQL.params.Clear()
                                SQL.AddParams("@from", Convert.ToDateTime(DateAdd("D", -1, .Rows(i).Item(0).ToString)).ToString("yyyy/MM/dd"))
                                SQL.AddParams("@itemid", txtitem.Text)
                                SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
                                If SQL.DBDT.Rows.Count = 0 Then
                                    currentbalance = 0 + .Rows(i).Item(3)
                                Else
                                    currentbalance = SQL.DBDT.Rows(0).Item(0) + .Rows(i).Item(3)
                                End If
                                row.Rows(i).Item(0).ToString()
                                'SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToString("yyyy/MM/dd"))
                                'SQL.AddParams("@itemid", txtitem.Text)
                                'SQL.ExecQuery("SELECT top 1 ClientCost,SupplierCost FROM GetBalance(@from) WHERE ItemID=@itemid")
                                'If SQL.DBDT.Rows.Count = 0 Then
                                '    currentclicost = 0 + .Rows(i).Item(6)
                                '    currentsupcost = 0 + .Rows(i).Item(7)
                                'Else
                                '    currentclicost = SQL.DBDT.Rows(0).Item(0) + .Rows(i).Item(6)
                                '    currentsupcost = SQL.DBDT.Rows(0).Item(1) + .Rows(i).Item(7)
                                'End If
                            Else
                                'add the qty row to the currentbalance
                                currentbalance += .Rows(i).Item(3)
                                'currentclicost += .Rows(i).Item(6)
                                'currentsupcost += .Rows(i).Item(7)
                            End If
                            dgvData.Rows(i).Cells(2).Value = .Rows(i).Item(3)
                        'Out items based on stock out
                        Case 2
                            If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToString("yyyy/MM/dd") Then
                                SQL.params.Clear()
                                SQL.AddParams("@from", Convert.ToDateTime(DateAdd("D", -1, .Rows(i).Item(0).ToString)).ToString("yyyy/MM/dd"))
                                SQL.AddParams("@itemid", txtitem.Text)
                                'get the stockbalance based on transaction date row  -1 And minus the qty row
                                SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
                                If SQL.DBDT.Rows.Count = 0 Then
                                    currentbalance = 0 - .Rows(i).Item(3)
                                Else
                                    currentbalance = SQL.DBDT.Rows(0).Item(0) - .Rows(i).Item(3)
                                End If
                                'SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToShortDateString)
                                'SQL.AddParams("@itemid", txtitem.Text)
                                'SQL.ExecQuery("SELECT top 1 ClientCost,SupplierCost FROM GetCostBalance(@from) WHERE ItemID=@itemid")
                                'If SQL.DBDT.Rows.Count = 0 Then
                                '    currentclicost = 0 - .Rows(i).Item(6)
                                '    currentsupcost = 0 - .Rows(i).Item(7)
                                'Else
                                '    currentclicost = SQL.DBDT.Rows(0).Item(0) - .Rows(i).Item(6)
                                '    currentsupcost = SQL.DBDT.Rows(0).Item(1) - .Rows(i).Item(7)
                                'End If
                            Else
                                'minus the qty row to the currentbalance
                                currentbalance -= .Rows(i).Item(3)
                                'currentclicost -= .Rows(i).Item(6)
                                'currentsupcost -= .Rows(i).Item(7)
                            End If
                            dgvData.Rows(i).Cells(3).Value = .Rows(i).Item(3)
                        'AC of items in Stock Taking
                        Case 3
                            If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToString("yyyy/MM/dd HH:mm:ss") Then
                                'Get the current balance based on row
                                currentbalance = .Rows(i).Item(3)
                            Else
                                SQL.AddParams("@transdate", Convert.ToDateTime(.Rows(i).Item(0).ToString).ToString("yyyy/MM/dd HH:mm:ss"))
                                SQL.AddParams("@item", txtitem.Text)
                                'Get the current balance based on row and (- the total sum of in and out based on row
                                'transaction date)
                                SQL.ExecQuery("EXECUTE dbo.TotalOut @TransactionDate = @transdate, @ItemId =@item ")
                                Dim totalin As Integer = SQL.DBDT.Rows(0).Item(0)
                                If SQL.HasException Then Exit Sub
                                SQL.AddParams("@transdate", Convert.ToDateTime(.Rows(i).Item(0).ToString).ToString("yyyy/MM/dd HH:mm:ss"))
                                SQL.AddParams("@item", txtitem.Text)
                                SQL.ExecQuery("EXECUTE dbo.TotalIn @TransactionDate = @transdate, @ItemId =@item ")
                                Dim totalout As Integer = SQL.DBDT.Rows(0).Item(0)

                                currentbalance = .Rows(i).Item(3) - (totalout + totalin)

                                ''FOR COST
                                'SQL.AddParams("@transdate", .Rows(i).Item(0))
                                'SQL.AddParams("@item", txtitem.Text)
                                ''Get the current balance based on row and (- the total sum of in and out based on row
                                ''transaction date)
                                'SQL.ExecQuery("EXECUTE dbo.TotalCostOut @TransactionDate = @transdate, @ItemId =@item ")
                                'If SQL.HasException Then Exit Sub
                                'totalin = SQL.DBDT.Rows(0).Item(0)
                                'Dim supin As Integer = SQL.DBDT.Rows(0).Item(1)

                                'SQL.AddParams("@transdate", .Rows(i).Item(0))
                                'SQL.AddParams("@item", txtitem.Text)
                                'SQL.ExecQuery("EXECUTE dbo.TotalCostIn @TransactionDate = @transdate, @ItemId =@item ")
                                'totalout = SQL.DBDT.Rows(0).Item(0)
                                'Dim supout As Integer = SQL.DBDT.Rows(0).Item(1)

                                'currentclicost = .Rows(i).Item(6) - (totalout + totalin)
                                'currentsupcost = .Rows(i).Item(7) - (supout + supin)
                            End If
                            dgvData.Rows(i).Cells(4).Value = .Rows(i).Item(3)
                    End Select
                    'Get latest transactiondate
                    'strTransactionDate
                    'Add other columns data
                    strTransactionDate = Convert.ToDateTime(.Rows(i).Item(0).ToString).ToString("yyyy/MM/dd")
                    dgvData.Rows(i).Cells(0).Value = .Rows(i).Item(0)
                    dgvData.Rows(i).Cells(1).Value = .Rows(i).Item(1)
                    dgvData.Rows(i).Cells(5).Value = currentbalance
                    dgvData.Rows(i).Cells(6).Value = .Rows(i).Item(5)
                    'dgvData.Rows(i).Cells(6).Value = currentclicost
                    'dgvData.Rows(i).Cells(7).Value = currentsupcost
                Next
            End With
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
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
                    MsgBox("No data found!", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
                rptDs = New ReportDataSource("DataSet1", dt)
                PrintPreview.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                SQL.ExecQuery("SELECT * FROM CompanyInfo")
                rptDs = New ReportDataSource("DataSet2", SQL.DBDT)
                PrintPreview.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                PrintPreview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                PrintPreview.ReportViewer1.ZoomMode = ZoomMode.Percent
                PrintPreview.ReportViewer1.ZoomPercent = 100
                PrintPreview.Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
            'End With
        Finally
            btnPrint.Text = "PRINT"
            btnPrint.Enabled = False
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

    Private Sub FrmInventoryStockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        dtFrom.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtTo.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtFrom.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtTo.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub
End Class