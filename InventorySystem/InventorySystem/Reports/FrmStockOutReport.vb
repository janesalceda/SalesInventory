Imports Microsoft.Reporting.WinForms
Public Class FrmStockOutReport
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Text = "Please Wait ..."
        btnPrint.Enabled = False
        loadReport()
    End Sub
    Private Sub loadReport()
        Dim rptDs As ReportDataSource
        PrintPreview.ReportViewer1.RefreshReport()
        Try
            With PrintPreview.ReportViewer1.LocalReport
                .ReportPath = "C:\temp\SalesandInventory\Reportdlc\Report5.rdlc"
                .DataSources.Clear()
                Dim dt As New DataTable
                Dim ds As New DataSet1

                SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
                SQL.AddParams("@to", dtTo.Value.ToString("yyyy/MM/dd"))
                SQL.ExecQuery("SELECT *,@from as 'DateFrom',@to as 'DateTo',(select Companylogo from companyinfo)a FROM dbo.GetStockOut ( @from,@to) ")
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
        Finally
            btnPrint.Text = "PRINT"
            btnPrint.Enabled = False
        End Try

    End Sub

    Private Sub FrmStockOutReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFrom.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtTo.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtFrom.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'dtTo.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub
End Class