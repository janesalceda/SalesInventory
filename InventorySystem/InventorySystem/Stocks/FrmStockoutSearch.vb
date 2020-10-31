Public Class FrmStockoutSearch
    Public Sub getAllData(where As String)
        SQL.ExecQuery("SELECT StockOutCode,StockOutDate,st.IssuedByStaff,
        CASE WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',
        Remarks,st.UpdatedDate
        from StockOutHeaders st INNER JOIN Employees e ON e.EmpId=st.EncodedStaff	" & where)

        If SQL.HasException Then Exit Sub

        dtableStockOut.DataSource = SQL.DBDT
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmStockOutEntry.Text = "Stock Out Entry"
        FrmStockOutEntry.Show()
    End Sub
    Public Sub search()
        Dim where As String = ""
        If Not String.IsNullOrEmpty(txtSTID.Text) Then
            where += AddingWhere(where)
            where += "StockOutCode='" & txtSTID.Text & "'"
        End If
        If dtCountedFrom.Checked = True And dtCountedTo.Checked = True Then
            where += AddingWhere(where)
            where += "convert(VARCHAR(10),StockOutDate,111) BETWEEN '" & dtCountedFrom.Value.ToShortDateString & "' AND '" & dtCountedFrom.Value.ToShortDateString & "'"
        End If
        'If chkApproved.Checked = True Then
        '    where += AddingWhere(where)
        '    where += "APPROVEDBY IS NOT NULL"
        'Else
        '    where += AddingWhere(where)
        '    where += "APPROVEDBY IS NULL"
        'End If
        getAllData(where)
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search()
    End Sub

    Private Sub FrmStockout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub dtableStockTaking_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockOut.CellDoubleClick
        FrmStockOutEntry.btnSave.Text = "UPDATE"
        FrmStockOutEntry.Text = "Stock Out Details"
        FrmStockOutEntry.txtStockOutID.Text = dtableStockOut.SelectedRows(0).Cells(0).Value
        FrmStockOutEntry.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSTID.Clear()
        dtCountedFrom.Checked = False
        dtCountedTo.Checked = False
        chkApproved.Checked = False
        dtableStockOut.DataSource = Nothing
    End Sub
End Class