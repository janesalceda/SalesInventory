Imports Microsoft.Reporting.WinForms
Public Class DailyTransaction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Please wait ..."
        Button1.Enabled = False
        If Application.OpenForms().OfType(Of PrintingPreviewDaily).Any Then PrintingPreviewDaily.Close()
        PrintingPreviewDaily.ReportViewer1.RefreshReport()
        Try
            SQL.AddParams("@from", DateTimePicker1.Value.ToString("yyyy/MM/dd"))
            SQL.ExecQuery("SELECT *,@from as 'TransactionDate',(select Companylogo from companyinfo)'Companylogo'
                     FROM dbo.GetDailyTransaction (@from)")
            If SQL.HasException Or SQL.DBDT.Rows.Count = 0 Then
                msgboxDisplay("No Record Found", 1)
                Exit Sub
            End If
            DataSet31.Clear()
            For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
                DataSet31.DailyTransaction.AddDailyTransactionRow(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1),
                    SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(4), SQL.DBDT.Rows(i).Item(5),
                    SQL.DBDT.Rows(i).Item(6), SQL.DBDT.Rows(i).Item(7))
            Next
            PrintingPreviewDaily.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            PrintingPreviewDaily.ReportViewer1.ZoomMode = ZoomMode.Percent
            PrintingPreviewDaily.ReportViewer1.ZoomPercent = 100
            PrintingPreviewDaily.barcode = DataSet31.DailyTransaction
            PrintingPreviewDaily.ShowDialog()
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