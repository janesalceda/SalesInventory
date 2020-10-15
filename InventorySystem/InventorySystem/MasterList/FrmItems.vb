Public Class FrmItems

    Public Sub LoadDataGrid(Optional Query As String = "")
        If Query <> "" Then
            SQL.ExecQuery(Query)
        Else
            SQL.ExecQuery("SELECT * FROM items")
        End If
        If SQL.HasException(True) Then Exit Sub
        dtItems.DataSource = SQL.DBDT
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'FrmMessageBox.Show("HI")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddItem.btnSave.Visible = True
        AddItem.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AddItem.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rslt As New System.Windows.Forms.DialogResult
        rslt = MsgBox("Do you really want to delete this item ?", "Delete Data", MessageBoxButtons.YesNo)
        If rslt = Windows.Forms.DialogResult.Yes Then
            'FrmMessageBox.Show("Delete")
        End If
    End Sub

    Private Sub FormItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadDataGrid()
    End Sub
End Class