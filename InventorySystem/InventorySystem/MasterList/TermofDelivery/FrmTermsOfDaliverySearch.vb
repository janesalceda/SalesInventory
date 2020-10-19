Public Class FrmTermsOfDaliverySearch
    Public Sub LoadDataGrid(Optional Query As String = "")
        SQL.ExecQuery("SELECT TermOfDeliveryId,TermOfDelivery,Description,CreatedDate,DeletedDate FROM TermsOfDelivery " & Query)
        If SQL.HasException(True) Then Exit Sub
        dtItems.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItems.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(3), "X")
        Next
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrWhiteSpace(txtCatID.Text) Then
            where += AddingWhere(where)
            where += "TermOfDeliveryId = '" & txtCatID.Text & "'"
        End If
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            where += AddingWhere(where)
            where += "TermOfDelivery LIKE '%" & txtDelPlace.Text & "%'"
        End If
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            where += AddingWhere(where)
            where += "Description LIKE '%" & txtDes.Text & "%'"
        End If
        If Not String.IsNullOrWhiteSpace(chkDisuse.Checked) Then
            where += AddingWhere(where)
            If chkDisuse.Checked = True Then
                where += "DeletedDate is not null"
            Else
                where += "DeletedDate is null"
            End If
        End If
        LoadDataGrid(where)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmTermsofDeliveryEntry.Text = "Terms of Delivery  Entry"
        FrmTermsofDeliveryEntry.Show()
    End Sub
    Private Sub dtItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellClick
        With FrmTermsofDeliveryEntry
            .Text = "Terms of Delivery Details"
            .btnSave.Text = "UPDATE"
            .txtTD.Text = dtItems.SelectedRows(0).Cells(1).Value.ToString
            .txtDes.Text = dtItems.SelectedRows(0).Cells(1).Value.ToString
            .Show()
        End With
    End Sub
    Private Sub FrmTermsOfDaliverySearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class