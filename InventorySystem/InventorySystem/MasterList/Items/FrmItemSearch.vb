﻿Public Class FrmItemSearch
    Private Sub LoadCategories()
        cmbCategory.DataSource = getCategories()
        cmbCategory.DisplayMember = "CategoryName"
        cmbCategory.ValueMember = "CategoryID"
    End Sub
    Public Sub LoadDataGrid(Optional Query As String = "")
        SQL.ExecQuery("SELECT ItemId,Description,CreatedDate ,DeletedDate FROM items i " & Query)
        If SQL.HasException(True) Then Exit Sub
        dtItems.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItems.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(3), "X")
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmItemEntry.btnSave.Visible = True
        FrmItemEntry.Show()
    End Sub

    Private Sub FormItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadCategories()
    End Sub
    Private Sub dtItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellDoubleClick

        FrmItemEntry.txtItemId.Text = dtItems.SelectedRows(0).Cells(0).Value.ToString
        FrmItemEntry.btnSave.Text = "UPDATE"
        FrmItemEntry.Text = "Item Details"
        FrmItemEntry.Show()
        'Add viewing of data
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
        If Not String.IsNullOrWhiteSpace(chkDisuse.Checked) Then
            where += AddingWhere(where)
            If chkDisuse.Checked = True Then
                where += "i.DeletedDate is not null"
            Else
                where += "i.DeletedDate is null"
            End If
        End If
        LoadDataGrid(where)
    End Sub

    Private Sub dtItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellClick
        If e.ColumnIndex = 5 Then
            If MsgBox("Do you really want to delete this item ?", MsgBoxStyle.YesNo, "Delete Data") Then
            End If
        End If
    End Sub
End Class