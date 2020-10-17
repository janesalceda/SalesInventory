Public Class FrmItemSearch

    Public Sub LoadDataGrid(Optional Query As String = "")
        If Query <> "" Then
            SQL.ExecQuery(Query)
        Else
            SQL.ExecQuery("SELECT * FROM items")
        End If
        If SQL.HasException(True) Then Exit Sub
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItems.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1), "X")
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'FrmMessageBox.Show("HI")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmItemAdd.btnSave.Visible = True
        FrmItemAdd.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim rslt As New System.Windows.Forms.DialogResult
        If MsgBox("Do you really want to delete this item ?", MessageBoxButtons.YesNo, "Delete Data") Then
            'FrmMessageBox.Show("Delete")

        End If
    End Sub

    Private Sub FormItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadDataGrid()
    End Sub
    Private Sub dtItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellDoubleClick

        FrmItemAdd.txtItemId.Text = dtItems.SelectedRows(0).Cells(0).Value.ToString

        FrmItemAdd.Text = "Item Details"
        FrmItemAdd.Show()
        'Add viewing of data
    End Sub

    Private Sub dtItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItems.CellContentClick

    End Sub
End Class