Imports Microsoft.Reporting.WinForms
Public Class DailyTransaction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Please wait ..."
        Button1.Enabled = False
        Dim rptDs As ReportDataSource
        PrintPreview.ReportViewer1.RefreshReport()
        Try
            With PrintPreview.ReportViewer1.LocalReport
                .ReportPath = "C:\temp\SalesandInventory\Reportdlc\Report3.rdlc"
                .DataSources.Clear()
                Dim dt As New DataTable
                Dim ds As New DataSet1

                SQL.AddParams("@from", DateTimePicker1.Value.ToString("yyyy/MM/dd"))
                SQL.ExecQuery("SELECT *,@from as 'TransactionDate',(select Companylogo from companyinfo)'Companylogo'
                     FROM dbo.GetDailyTransaction (@from)")
                If SQL.DBDT.Rows.Count = 0 Then
                    msgboxDisplay("No Record Found", 1)
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
        Finally
            Button1.Text = "PRINT"
            Button1.Enabled = True
        End Try
        Button1.Text = "PRINT"
        Button1.Enabled = True

    End Sub

    Private Sub DailyTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class