Imports Microsoft.Reporting.WinForms
Public Class ItemStockReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadReport()
    End Sub
    Private Sub loadReport()
        Dim rptDs As ReportDataSource
        PrintPreview.ReportViewer1.RefreshReport()
        Try
            With PrintPreview.ReportViewer1.LocalReport
                .ReportPath = "C:\temp\SalesandInventory\Reportdlc\Report2.rdlc"
                .DataSources.Clear()
                Dim dt As New DataTable
                Dim ds As New DataSet1

                SQL.AddParams("@from", DateTimePicker1.Value.ToShortDateString)
                SQL.ExecQuery("SELECT i.itemid,i.Description,
                isnull(test.qty,0) AS 'QTY',i.MinimumOrderQty AS 'MinStocks'	,
                i.OrderingPointQty	AS 'OrderPoint'
                FROM Items i
	                LEFT JOIN (SELECT * FROM GetStockBalance(@from)) AS test
	                ON test.ItemId = i.ItemId where i.deletedDate is null")
                rptDs = New ReportDataSource("DataSet1", SQL.DBDT)
                PrintPreview.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                PrintPreview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                PrintPreview.ReportViewer1.ZoomMode = ZoomMode.Percent
                PrintPreview.ReportViewer1.ZoomPercent = 100
                PrintPreview.Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
            Exit Sub
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class