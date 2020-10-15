Public Class FrmTermsofDelivery

    Private TermsOfDeliveryID As String
    Private Sub LoadDataGrid(Optional Query As String = "")
        If Query <> "" Then
            SQL.ExecQuery(Query)
        Else
            SQL.ExecQuery("SELECT * FROM TermsOfDelivery")
        End If
        If SQL.HasException(True) Then Exit Sub
        DTDeliveryPlaces.DataSource = SQL.DBDT
        ' For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
        ''Dim DataType() As String = myTableData.Rows(i).Item(1)
        'MsgBox(SQL.DBDT.Rows(i)(1))
        'Next
    End Sub
    Private Sub ExecuteQueries(Query As String)
        SQL.AddParams("@description", txtDes.Text)
        SQL.AddParams("@termdelivery", txtTD.Text)
        SQL.AddParams("@disuse", chkDisuse.Checked)
        SQL.AddParams("@updatedby", moduleId)

        If Query = "SAVE" Then
            SQL.ExecQuery("
                INSERT INTO TermsOfDelivery 
                (TermOfDelivery,Description,DeletedDate,UpdatedBy)
                VALUES
                (@termdelivery,@description,(select case when @disuse=1 then getdate() else null end),@updatedby)")
        Else
            SQL.AddParams("@id", DTDeliveryPlaces.SelectedRows(0).Cells(0))
            SQL.ExecQuery("UPDATE TermsOfDelivery SET TermOfDelivery=@termdelivery,Description=@description,DeletedDate=(select case when @disuse=1 then getdate() else null end),updateddate=getdate(),updatedby=@updatedby WHERE TermOfDeliveryId=@id")
        End If
        If SQL.HasException(True) Then
            MsgBox("Error in Saving", MsgBoxStyle.Critical)
            Exit Sub
        End If
        MsgBox("Successfully Saved", MsgBoxStyle.Information)
    End Sub
    Private Sub Clear()
        txtDes.Text = ""
        txtTD.Text = ""
        chkDisuse.Checked = False
        btnSave.Text = "SAVE"
        btnClear.Enabled = False
        btnSave.Enabled = False
        txtTD.Focus()
    End Sub
    Private Sub FrmDeliveryPlaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadDataGrid()
    End Sub
    Private Sub DTDeliveryPlaces_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTDeliveryPlaces.CellDoubleClick
        btnSave.Text = "UPDATE"
        btnSave.Enabled = True
        btnClear.Enabled = True
        txtTD.Text = DTDeliveryPlaces.SelectedRows(0).Cells(1).Value.ToString
        txtDes.Text = DTDeliveryPlaces.SelectedRows(0).Cells(2).Value.ToString
        If Not String.IsNullOrEmpty(DTDeliveryPlaces.SelectedRows(0).Cells(4).Value.ToString) Then
            chkDisuse.Checked = True
        Else
            chkDisuse.Checked = False
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ExecuteQueries(btnSave.Text)
        LoadDataGrid()
        Clear()
    End Sub
    Private Sub txtTD_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTD.KeyUp
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Or Not String.IsNullOrWhiteSpace(txtDes.Text) Then
            btnClear.Enabled = True
            btnSave.Enabled = True
        Else
            btnClear.Enabled = False
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtDes_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDes.KeyUp
        If Not String.IsNullOrWhiteSpace(txtDes.Text) Or Not String.IsNullOrWhiteSpace(txtTD.Text) Then
            btnClear.Enabled = True
            btnSave.Enabled = True
        Else
            btnClear.Enabled = False
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub chkDisuse_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisuse.CheckedChanged
        btnClear.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub DTDeliveryPlaces_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTDeliveryPlaces.CellClick
        btnSave.Text = "UPDATE"
        btnSave.Enabled = True
        btnClear.Enabled = True
        txtTD.Text = DTDeliveryPlaces.SelectedRows(0).Cells(1).Value.ToString
        txtDes.Text = DTDeliveryPlaces.SelectedRows(0).Cells(2).Value.ToString
        If Not String.IsNullOrEmpty(DTDeliveryPlaces.SelectedRows(0).Cells(4).Value.ToString) Then
            chkDisuse.Checked = True
        Else
            chkDisuse.Checked = False
        End If
    End Sub
End Class