Imports Microsoft.Reporting.WinForms
Public Class ItemStockReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Please wait ..."
        Button1.Enabled = False
        loadReport()
        Button1.Text = "PRINT"
        Button1.Enabled = True
    End Sub
    Private Sub loadReport()
        Dim rptDs As ReportDataSource
        Dim where As String = ""
        PrintPreview.ReportViewer1.RefreshReport()
        Try
            With PrintPreview.ReportViewer1.LocalReport
                .ReportPath = "C:\temp\SalesandInventory\Reportdlc\Report2.rdlc"
                .DataSources.Clear()
                Dim dt As New DataTable
                Dim ds As New DataSet1

                SQL.AddParams("@from", DateTimePicker1.Value.ToShortDateString)
                If Not String.IsNullOrEmpty(ComboBox1.Text) Then
                    where += " order by " & ComboBox1.Text
                End If
                SQL.ExecQuery("
                    SELECT i.itemid,i.Description,
                    isnull((SELECT qty FROM GetStockBalance(@from) WHERE itemid=i.ItemId),0)'qty',
                    MinimumOrderQty,OrderingPointQty, (select Companylogo from companyinfo) 'Companylogo'
                    FROM Items i
                                     where i.deletedDate is null " & where)
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

    End Sub

    Private Sub ItemStockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ' DateTimePicker1.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub
End Class