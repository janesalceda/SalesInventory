﻿Public Class FrmStockTaking
    Private Sub getAllData(where As String)
        SQL.ExecQuery("SELECT STID,CountedDate,
            CASE WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',
            Remarks,st.UpdatedDate,
            CASE WHEN st.UpdatedBy=e.EmpId THEN e.EmployeeName ELSE '' END AS 'UpdatedBy',
            CASE WHEN st.ApprovedBy=e.EmpId THEN e.EmployeeName ELSE 'NOT YET APPROVED' END as 'ApprovedBy' 
            from StockTakingHeaders st INNER JOIN Employees e ON e.EmpId=st.EncodedStaff	" & where)
        If SQL.HasException Then Exit Sub
        dtableStockTaking.DataSource = SQL.DBDT
    End Sub
    Private Sub FrmStockTaking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        'getAllData("")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddStockTaking.Show()
    End Sub
    Public Sub Search()
        Dim where As String = ""
        If Not String.IsNullOrEmpty(txtSTID.Text) Then
            where += AddingWhere(where)
            where += "STID='" & txtSTID.Text & "'"
        End If
        If dtCountedFrom.Checked = True And dtCountedTo.Checked = True Then
            where += AddingWhere(where)
            where += "convert(VARCHAR(10),CountedDate,111) BETWEEN '" & dtCountedFrom.Value.ToShortDateString & "' AND '" & dtCountedFrom.Value.ToShortDateString & "'"
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub dtableStockTaking_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtableStockTaking.CellDoubleClick
        AddStockTaking.btnSave.Text = "UPDATE"
        AddStockTaking.txtStockTakingID.Text = dtableStockTaking.SelectedRows(0).Cells(0).Value
        AddStockTaking.Show()
    End Sub

End Class