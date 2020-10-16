Public Class ViewStockTaking
    Private Sub ViewStockTaking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.ExecQuery("Select Case st.STID,CountedDate,
            Case WHEN st.EncodedStaff=e.EmpId THEN e.EmployeeName ELSE '' END AS 'EncodedStaff',
            st.Remarks, st.UpdatedDate,
            CASE WHEN st.UpdatedBy=e.EmpId THEN e.EmployeeName ELSE '' END AS 'UpdatedBy',
            Case WHEN st.ApprovedBy=e.EmpId THEN e.EmployeeName ELSE 'NOT YET APPROVED' END as 'ApprovedBy' 
            From StockTakingHeaders st INNER Join StockTakingDetails sd ON
            st.STID = sd.STID INNER JOIN Employees e On e.EmpId=st.EncodedStaff	")
    End Sub
End Class