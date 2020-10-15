Public Class FrmStockout
    Private Sub getAllData(where As String)
        SQL.ExecQuery("SELECT StockOutCode,StockOutDate,st.IssuedByStaff,
        CASE WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',
        Remarks,st.UpdatedDate,
        CASE WHEN st.UpdatedBy=e.EmpId THEN e.EmployeeName ELSE '' END AS 'UpdatedBy',
        CASE WHEN st.ApprovedBy=e.EmpId THEN e.EmployeeName ELSE '' END as 'ApprovedBy' 
        from StockOutHeaders st , Employees e" & where)
        If SQL.HasException Then Exit Sub
        dtableStockTaking.DataSource = SQL.DBDT
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddStockOut.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim where As String = ""
        If Not String.IsNullOrEmpty(txtSTID.Text) Then
            where += AddingWhere(where)
            where += "StockOutCode='" & txtSTID.Text & "'"
        End If
        If dtCountedFrom.Checked = True And dtCountedTo.Checked = True Then
            where += AddingWhere(where)
            where += "convert(VARCHAR(10),StockOutDate,111) BETWEEN '" & dtCountedFrom.Value.ToShortDateString & "' AND '" & dtCountedFrom.Value.ToShortDateString & "'"
        End If
        If chkApproved.Checked = True Then
            where += AddingWhere(where)
            where += "APPROVEDBY IS NOT NULL"
        Else
            where += AddingWhere(where)
            where += "APPROVEDBY IS NULL"
        End If
        getAllData(where)
    End Sub
End Class