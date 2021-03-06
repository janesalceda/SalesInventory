﻿Public Class FrmSupplierSearch
    Public Sub LoadDataGrid(Optional Query As String = "")
        SQL.ExecQuery("SELECT SupplierID,SupplierName,CreatedDate,case when DeletedDate is null then 0 else 1 end,DeletedDate FROM Suppliers " & Query & " order by createddate")
        If SQL.HasException(True) Then Exit Sub
        dtItems.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItems.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3), SQL.DBDT.Rows(i).Item(4))
        Next
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrWhiteSpace(txtCatID.Text) Then
            where += AddingWhere(where)
            where += "SupplierID = '" & txtCatID.Text & "'"
        End If
        If Not String.IsNullOrWhiteSpace(txtDelPlace.Text) Then
            where += AddingWhere(where)
            where += "SupplierName LIKE '%" & txtDelPlace.Text & "%'"
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

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmSupplierEntry.Text = "Supplier  Entry"
        FrmSupplierEntry.Show()
    End Sub
    Private Sub DtItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellClick
        If e.ColumnIndex = 3 Then
            If dtItems.SelectedRows(0).Cells(3).Value = -2 Then
                dtItems.SelectedRows(0).Cells(3).Value = 0
            ElseIf dtItems.SelectedRows(0).Cells(3).Value = 0 Then
                dtItems.SelectedRows(0).Cells(3).Value = 1
            Else
                dtItems.SelectedRows(0).Cells(3).Value = 0
            End If
            'dtItems.SelectedRows(0).Cells(3).Value = False
            SQL.AddParams("@disuse", dtItems.SelectedRows(0).Cells(3).Value)
            SQL.AddParams("@SupplierId", dtItems.SelectedRows(0).Cells(0).Value)
            SQL.ExecQuery("UPDATE Suppliers set 
                DeletedDate=(select case when @disuse=0 then null else getdate() end) where SupplierId=@SupplierId")
            If SQL.HasException Then
                Exit Sub
            End If
        Else
            With FrmSupplierEntry
                .Text = "Supplier Details"
                .btnSave.Visible = False
                .btnSave.Text = "UPDATE"
                .txtSupplierId.Text = dtItems.SelectedRows(0).Cells(1).Value.ToString
                .Show()
            End With
        End If
    End Sub

    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDelPlace.Clear()
        txtCatID.Clear()
        dtItems.Rows.Clear()
        chkDisuse.Checked = False
    End Sub
End Class