Public Class frmInventory

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Users; ")
        Else
            SQL.ExecQuery(Query)
        End If
        If SQL.HasException(True) Then Exit Sub
        dgvData.DataSource = SQL.DBDT
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadGrid()
    End Sub
    Private Sub FindItem()
        SQL.AddParams("@user", "%" & txtSearch.Text & "%")
        LoadGrid("SELECT * FROM users where employeecode like @user;")
    End Sub
End Class