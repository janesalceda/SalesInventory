Imports Microsoft.Reporting.WinForms

Public Class PrintPreviewBarcode
    Public barcode
    Private Sub PrintPreviewBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim barcode = DataSet8.DataTable1
        Dim reportDataSource = New ReportDataSource()
        reportDataSource.Name = "DataSet1"
        reportDataSource.Value = barcode
        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(reportDataSource)

        'reportDataSource.Value = DataSet8.DataTable1.ImageColumn
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class