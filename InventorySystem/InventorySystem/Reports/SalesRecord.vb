Imports Microsoft.Reporting.WinForms
Public Class SalesRecord


    Private Sub SalesRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFrom.Value = DateTime.Now.ToLongDateString
        dtTo.Value = DateTime.Now.ToLongDateString
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SQL.params.Clear()

        Dim rptDs As ReportDataSource
        PrintPreview.ReportViewer1.RefreshReport()
        Try
            With PrintPreview.ReportViewer1.LocalReport
                .ReportPath = "C:\temp\SalesandInventory\Reportdlc\Report6.rdlc"
                .DataSources.Clear()
                Dim dt As New DataTable
                Dim ds As New DataSet1
                SQL.params.Clear()
                SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
                SQL.AddParams("@to", dtTo.Value.ToString("yyyy/MM/dd"))
                SQL.ExecQuery("EXECUTE dbo.DiplayIncomeStatement 
                     @TransactedFrom = @from, @TransactedTo =@to ")
                If SQL.DBDT.Rows.Count = 0 Then
                    msgboxDisplay("No Record Found!", 1)
                    Exit Sub
                End If
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
End Class