Public Class FrmItemsForApproval
    Private Sub LoadCategories()
        cmbCategory.DataSource = getCategories()
        cmbCategory.DisplayMember = "CategoryName"
        cmbCategory.ValueMember = "CategoryID"
        cmbCategory.SelectedIndex = -1
    End Sub
    Public Sub LoadDataGrid(Optional Query As String = "")
        SQL.ExecQuery("SELECT ItemId,Description,e.employeename ,i.createddate FROM itemsforapproval i 
            inner join employees e on e.empid=i.updatedby" & Query)
        If SQL.HasException(True) Then Exit Sub
        dtItems.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItems.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3))
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        FrmItemEntry.btnSave.Visible = True
        FrmItemEntry.Show()
    End Sub

    Private Sub FormItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        ' LoadCategories()
    End Sub
    Private Sub dtItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellDoubleClick
        Try
            With FrmItemEntry
                .txtItemId.Text = dtItems.SelectedRows(0).Cells(0).Value.ToString
                .btnSave.Text = "UPDATE"
                '.Text = "Item Details"
                '.chkDisuse.Enabled = True
                .chkApproved.Visible = True
            End With
            FrmItemEntry.Show()
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrWhiteSpace(txtItemID.Text) Then
            where += AddingWhere(where)
            where += "i.ItemId = '" & txtItemID.Text & "'"
        End If
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            where += AddingWhere(where)
            where += "i.Description LIKE '%" & txtDes.Text & "%'"
        End If
        If cmbCategory.SelectedIndex <> -1 Then
            where += AddingWhere(where)
            where += "i.CategoryID = " & cmbCategory.ValueMember
        End If

        LoadDataGrid(where)
    End Sub
    Private Sub dtItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellClick
        'Try
        '    If e.ColumnIndex = 3 Then
        '        If dtItems.SelectedRows(0).Cells(3).Value = -2 Then
        '            dtItems.SelectedRows(0).Cells(3).Value = 0
        '        ElseIf dtItems.SelectedRows(0).Cells(3).Value = 0 Then
        '            dtItems.SelectedRows(0).Cells(3).Value = 1
        '        Else
        '            dtItems.SelectedRows(0).Cells(3).Value = 0
        '        End If
        '        'dtItems.SelectedRows(0).Cells(3).Value = False
        '        SQL.AddParams("@disuse", dtItems.SelectedRows(0).Cells(3).Value)
        '        SQL.AddParams("@ItemId", dtItems.SelectedRows(0).Cells(0).Value)
        '        SQL.ExecQuery("UPDATE items set 
        '        DeletedDate=(select case when @disuse=0 then null else getdate() end) where ItemId=@ItemId")
        '        If SQL.HasException Then
        '            Exit Sub
        '        End If
        '    End If
        'Catch ex As Exception
        '    msgboxDisplay(ex.Message, 3)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtDes.Clear()
        txtItemID.Clear()
        dtItems.Rows.Clear()
    End Sub
    Private Sub cmbCategory_GotFocus(sender As Object, e As EventArgs) Handles cmbCategory.GotFocus
        LoadCategories()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class