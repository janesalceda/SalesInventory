Public Class FrmItemStockSearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        'If String.IsNullOrWhiteSpace(txtitem.Text) Then
        '    MsgBox("Please input itemid!", MsgBoxStyle.Exclamation, "Warning")
        '    Exit Sub
        'End If
        SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
        If Not String.IsNullOrEmpty(txtitem.Text) Then
            SQL.AddParams("@ItemId", txtitem.Text)
            where = " and itemid=@itemId"
        End If
        'If Not String.IsNullOrEmpty(cmbSort.Text) Then
        '    where += " order by " & cmbSort.Text
        'End If
        SQL.ExecQuery("SELECT i.itemid,i.Description,
            isnull((SELECT qty FROM GetStockBalance(@from) WHERE itemid=i.ItemId),0)'qty',
            case when isnull((SELECT qty FROM GetStockBalance(@from) WHERE itemid=i.ItemId),0)<=MinimumOrderQty 
            OR isnull((SELECT qty FROM GetStockBalance(@from) WHERE itemid=i.ItemId),0)<=OrderingPointQty then 'TO RE-ORDER'
            ELSE 'NO' end 'Status'
            FROM Items i
             where i.deletedDate is null " & where)
        If SQL.DBDT.Rows.Count = 0 Then
            MsgBox("No record found!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        Dim row As New DataTable
        row = SQL.DBDT
        dgvData.Rows.Clear()
        For i As Integer = 0 To row.Rows.Count - 1
            dgvData.Rows.Add(row.Rows(i).Item(0), row.Rows(i).Item(1), row.Rows(i).Item(2), row.Rows(i).Item(3))
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtitem.Clear()
        dtFrom.Checked = False
        dtFrom.Value = Today
        dgvData.Rows.Clear()
    End Sub

    Private Sub FrmItemStockSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub
    'Private Sub loadReport()
    '    Dim rptDs As ReportDataSource
    '    SaleReports.ReportViewer1.RefreshReport()
    '    Try
    '        With SaleReports.ReportViewer1.LocalReport
    '            .ReportPath = "C:\temp\SalesandInventory\Report1.rdlc"
    '            .DataSources.Clear()
    '            Dim dt As New DataTable
    '            Dim ds As New DataSet1

    '            SQL.AddParams("@from", DateTimePicker1.Value.ToShortDateString)
    '            SQL.ExecQuery("SELECT i.itemid,i.Description,isnull(test.qty,0) AS 'QTY' FROM Items i
    '             LEFT JOIN (SELECT * FROM GetStockBalance(@from)) AS test
    '             ON test.ItemId = i.ItemId where i.deletedDate is null")
    '            rptDs = New ReportDataSource("PODataSet", SQL.DBDT)
    '            SaleReports.ReportViewer1.LocalReport.DataSources.Add(rptDs)
    '            SaleReports.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '            SaleReports.ReportViewer1.ZoomMode = ZoomMode.Percent
    '            SaleReports.ReportViewer1.ZoomPercent = 100
    '            SaleReports.Show()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Exception")
    '        'End With
    '    End Try

    '    'dt = ds.Tables("PODetails")
    '    'For i = 0 To dtablePoDetails.Rows.Count - 1
    '    '    dt.Rows.Add(dtablePoDetails.Rows(i).Cells(1).Value, dtablePoDetails.Rows(i).Cells(2).Value, dtablePoDetails.Rows(i).Cells(5).Value, dtablePoDetails.Rows(i).Cells(7).Value, dtablePoDetails.Rows(i).Cells(8).Value)
    '    'Next
    '    'With SaleReports.ReportViewer1.LocalReport
    '    '    .ReportPath = "C:\Users\smd255\Documents\GitHub\SalesInventory\InventorySystem\InventorySystem\Report1.rdlc"
    '    '    .DataSources.Clear()
    '    '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("PODataset", dt))
    '    'End With
    '    '
    '    'SaleReports.ReportViewer1.RefreshReport()

    'End Sub
End Class