Public Class FrmDeliveryPlacesSearch
    Public Sub LoadDataGrid(Optional Query As String = "")
        SQL.ExecQuery("SELECT DeliveryPlaceId,DeliveryPlace,Description,CreatedDate,DeletedDate FROM DeliveryPlaces D " & Query)
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

    Private Sub dtItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellDoubleClick
        With FrmDeliveryPlacesEntry
            .Text = "Delivery Place  Details"
            .btnInsert.Text = "UPDATE"
            .txtQtyunit.Text = dtItems.SelectedRows(0).Cells(1).Value.ToString
            .txtDes.Text = dtItems.SelectedRows(0).Cells(2).Value.ToString
            .Show()
        End With
    End Sub
    Private Sub FrmDeliveryPlacesSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub
End Class