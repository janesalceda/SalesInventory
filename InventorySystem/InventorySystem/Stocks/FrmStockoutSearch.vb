Public Class FrmStockoutSearch
    Public Sub getAllData(where As String)
        Try
            SQL.ExecQuery("SELECT StockOutCode,StockOutDate,st.IssuedByStaff,
                CASE WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',
                Remarks,st.UpdatedDate
                from StockOutHeaders st INNER JOIN Employees e ON e.EmpId=st.EncodedStaff	" & where & " order by st.createddate")

            If SQL.HasException Then Exit Sub

            dtableStockOut.DataSource = SQL.DBDT
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
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
            where += "convert(VARCHAR(10),StockOutDate,111) BETWEEN '" & dtCountedFrom.Value.ToString("yyyy/MM/dd") & "' AND '" & dtCountedFrom.Value.ToString("yyyy/MM/dd") & "'"
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
        btnClear.PerformClick()
    End Sub

    Private Sub dtableStockTaking_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockOut.CellDoubleClick
        FrmStockOutEntry.btnSave.Text = "UPDATE"
        FrmStockOutEntry.Text = "Stock Out Details"
        FrmStockOutEntry.txtStockOutID.Text = dtableStockOut.SelectedRows(0).Cells(0).Value
        FrmStockOutEntry.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSTID.Clear()
        dtCountedFrom.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtCountedTo.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtCountedFrom.Checked = False
        dtCountedTo.Checked = False
        chkApproved.Checked = False
        dtableStockOut.DataSource = Nothing
    End Sub

    Private Sub dtableStockOut_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockOut.CellContentClick

    End Sub
End Class