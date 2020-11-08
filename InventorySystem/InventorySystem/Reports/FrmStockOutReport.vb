Imports Microsoft.Reporting.WinForms
Public Class FrmStockOutReport
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Text = "Please Wait ..."
        btnPrint.Enabled = False
        loadReport()
    End Sub
    Private Sub loadReport()
        PrintPreviewStockout.ReportViewer1.RefreshReport()
        Try

            SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
            SQL.AddParams("@to", dtTo.Value.ToString("yyyy/MM/dd"))
            SQL.ExecQuery("SELECT *,@from as 'DateFrom',@to as 'DateTo',(select Companylogo from companyinfo)'CompanyLogo' FROM dbo.GetStockOut ( @from,@to) ")
            If SQL.DBDT.Rows.Count = 0 Then
                msgboxDisplay("No Record Found", 1)
                Exit Sub
            End If
            DataSet51.Clear()
            For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
                DataSet51.DataTable1.AddDataTable1Row(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1),
                    SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(4), SQL.DBDT.Rows(i).Item(5),
                    SQL.DBDT.Rows(i).Item(6), SQL.DBDT.Rows(i).Item(7))
            Next
            PrintPreviewStockout.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            PrintPreviewStockout.ReportViewer1.ZoomMode = ZoomMode.Percent
            PrintPreviewStockout.ReportViewer1.ZoomPercent = 100
            PrintPreviewStockout.barcode = DataSet51.DataTable1
            PrintPreviewStockout.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
            Exit Sub
        Finally
            btnPrint.Text = "PRINT"
            btnPrint.Enabled = True
        End Try

    End Sub

    Private Sub FrmStockOutReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFrom.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtTo.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtFrom.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtTo.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub
End Class