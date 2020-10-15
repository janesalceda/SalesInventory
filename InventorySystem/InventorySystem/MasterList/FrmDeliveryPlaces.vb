Public Class FrmDeliveryPlaces
    Private Sub FrmDeliveryPlaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadGrid()
    End Sub
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@DeliveryPlace", txtQtyunit.Text)
        SQL.AddParams("@Description", txtDes.Text)
        SQL.AddParams("@UpdatedBy", moduleId)
        SQL.AddParams("@disuse", chkDisuse.Checked)

        If Query = "INSERT" Then
            SQL.ExecQuery("
                INSERT INTO DeliveryPlaces 
                (DeliveryPlace,Description,DeletedDate,UpdatedBy)
                VALUES
                (@DeliveryPlace,@description,(select case when @disuse=1 then getdate() else null end),@UpdatedBy)")
        Else
            SQL.AddParams("@DeliveryPlaceId", dtqtyunit.SelectedRows(0).Cells(0).Value.ToString())
            SQL.ExecQuery("update DeliveryPlaces set DeliveryPlace=@DeliveryPlace,updatedDate=getdate(), 
                UpdatedBy=@UpdatedBy,
                deletedDate=(select case when @disuse=1 then getdate() else null end),
                Description=@Description where DeliveryPlaceId=@DeliveryPlaceId")
        End If
        If SQL.HasException(True) Then
            MsgBox("Error in Saving", MsgBoxStyle.Critical)
            Exit Sub
        End If
        MsgBox("Successfully Saved", MsgBoxStyle.Information)
    End Sub
    Private Sub LoadGrid()
        SQL.ExecQuery("SELECT * FROM DeliveryPlaces")

        If SQL.DBDT.Rows.Count = 0 Then Exit Sub

        dtqtyunit.DataSource = False
        'For index As Integer = 0 To SQL.DBDT.Rows.Count - 1
        dtqtyunit.DataSource = SQL.DBDT
        '.Rows.Add(SQL.DBDT.Rows(index).Item(0), SQL.DBDT.Rows(index).Item(1), SQL.DBDT.Rows(index).Item(2))
        ' Next
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ExecuteQueries(btnInsert.Text)
        ClearFields()
    End Sub
    Private Sub ClearFields()
        txtQtyunit.Clear()
        txtDes.Clear()
        chkDisuse.Checked = False
        LoadGrid()
    End Sub
    Private Sub dtqtyunit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtqtyunit.CellClick
        btnInsert.Text = "UPDATE"
        txtQtyunit.Text = dtqtyunit.SelectedRows(0).Cells(1).Value.ToString()
        txtDes.Text = dtqtyunit.SelectedRows(0).Cells(2).Value.ToString()
        If Not String.IsNullOrEmpty(dtqtyunit.SelectedRows(0).Cells(4).Value.ToString()) Then
            chkDisuse.Checked = True
        Else
            chkDisuse.Checked = False
        End If
    End Sub
End Class