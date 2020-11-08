Imports Microsoft.Reporting.WinForms
Public Class SalesRecord


    Private Sub SalesRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        dtFrom.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ' dtFrom.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        dtTo.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ' dtTo.MaxDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        btnSearch.Text = "PRINT"
        btnSearch.Enabled = False
        SQL.params.Clear()

        PrintPreviewIncomeStatement.ReportViewer1.RefreshReport()
        Try
            SQL.params.Clear()
            SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
            SQL.AddParams("@to", dtTo.Value.ToString("yyyy/MM/dd"))
            SQL.ExecQuery("EXECUTE dbo.DiplayIncomeStatement 
                     @TransactedFrom = @from, @TransactedTo =@to ")
            If SQL.DBDT.Rows.Count = 0 Then
                msgboxDisplay("No Record Found!", 1)
                Exit Sub
            End If

            For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
                DataSet61.DataTable1.AddDataTable1Row(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1),
                    SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(4), SQL.DBDT.Rows(i).Item(5),
                    SQL.DBDT.Rows(i).Item(6), SQL.DBDT.Rows(i).Item(7), SQL.DBDT.Rows(i).Item(8),
                    SQL.DBDT.Rows(i).Item(9))
            Next
            PrintPreviewIncomeStatement.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            PrintPreviewIncomeStatement.ReportViewer1.ZoomMode = ZoomMode.Percent
            PrintPreviewIncomeStatement.ReportViewer1.ZoomPercent = 100
            PrintPreviewIncomeStatement.barcode = DataSet61.DataTable1
            PrintPreviewIncomeStatement.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
            Exit Sub
        Finally
            btnSearch.Text = "PRINT"
            btnSearch.Enabled = True
        End Try
    End Sub
End Class