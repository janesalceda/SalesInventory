Imports Microsoft.Reporting.WinForms

Public Class PrintPreviewStockMonitoring
    Public barcode
    Private Sub PrintPreviewStockMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportDataSource = New ReportDataSource()
        reportDataSource.Name = "DataSet1"
        reportDataSource.Value = barcode
        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(reportDataSource)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class