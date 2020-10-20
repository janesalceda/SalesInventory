Public Class FrmDeliveryPlacesSearch
    Public Sub LoadDataGrid(Optional Query As String = "")
        SQL.ExecQuery("SELECT DeliveryPlaceId,DeliveryPlace,Description,CreatedDate,case when DeletedDate is null then 0 else 1 end,DeletedDate FROM DeliveryPlaces D " & Query)
        If SQL.HasException(True) Then Exit Sub
        dtItems.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItems.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(4))
        Next
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrWhiteSpace(txtCatID.Text) Then
            where += AddingWhere(where)
            where += "D.DeliveryPlaceId = '" & txtCatID.Text & "'"
        End If
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            where += AddingWhere(where)
            where += "D.DeliveryPlace LIKE '%" & txtDelPlace.Text & "%'"
        End If
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            where += AddingWhere(where)
            where += "D.Description LIKE '%" & txtDes.Text & "%'"
        End If
        If Not String.IsNullOrWhiteSpace(chkDisuse.Checked) Then
            where += AddingWhere(where)
            If chkDisuse.Checked = True Then
                where += "D.DeletedDate is not null"
            Else
                where += "D.DeletedDate is null"
            End If
        End If
        LoadDataGrid(where)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmDeliveryPlacesEntry.Text = "Delivery Place Entry"
        FrmDeliveryPlacesEntry.Show()
    End Sub
    Private Sub FrmDeliveryPlacesSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
    Private Sub dtItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellClick
        If e.ColumnIndex = 4 Then
            If dtItems.SelectedRows(0).Cells(4).Value = -2 Then
                dtItems.SelectedRows(0).Cells(4).Value = 0
            ElseIf dtItems.SelectedRows(0).Cells(4).Value = 0 Then
                dtItems.SelectedRows(0).Cells(4).Value = 1
            Else
                dtItems.SelectedRows(0).Cells(4).Value = 0
            End If
            'dtItems.SelectedRows(0).Cells(3).Value = False
            SQL.AddParams("@disuse", dtItems.SelectedRows(0).Cells(4).Value)
            SQL.AddParams("@DeliveryPlaceId", dtItems.SelectedRows(0).Cells(0).Value)
            SQL.ExecQuery("UPDATE DeliveryPlaces set 
                DeletedDate=(select case when @disuse=0 then null else getdate() end) where DeliveryPlaceId=@DeliveryPlaceId")
            If SQL.HasException Then
                Exit Sub
            End If
        Else
            With FrmDeliveryPlacesEntry
                .Text = "Delivery Place  Details"
                .btnInsert.Text = "UPDATE"
                .txtQtyunit.Text = dtItems.SelectedRows(0).Cells(1).Value.ToString
                .txtDes.Text = dtItems.SelectedRows(0).Cells(2).Value.ToString
                .Show()
            End With
        End If
    End Sub

End Class