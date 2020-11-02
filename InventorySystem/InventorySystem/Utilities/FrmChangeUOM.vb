Public Class FrmChangeUOM
    Private Sub LoadCliUnit()
        cmbOldCliQtyUnit.DataSource = GetQtyUnit()
        cmbOldCliQtyUnit.DisplayMember = "QtyUnit"
        cmbOldCliQtyUnit.ValueMember = "QtyUnitId"
        cmbNewCliQtyUnit.DataSource = GetQtyUnit()
        cmbNewCliQtyUnit.DisplayMember = "QtyUnit"
        cmbNewCliQtyUnit.ValueMember = "QtyUnitId"
        cmbNewSupQtyUnit.DataSource = GetQtyUnit()
        cmbNewSupQtyUnit.DisplayMember = "QtyUnit"
        cmbNewSupQtyUnit.ValueMember = "QtyUnitId"
        cmbOldSupQtyUnit.DataSource = GetQtyUnit()
        cmbOldSupQtyUnit.DisplayMember = "QtyUnit"
        cmbOldSupQtyUnit.ValueMember = "QtyUnitId"
    End Sub

    Private Sub FrmChangeUOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCliUnit()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbCliQtyUnit.SelectedIndex = -1 Then
            MsgBox("Please choose UOM!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtOldConCoe.Text) Or
            cmbOldCliQtyUnit.SelectedIndex = -1 Or cmbOldSupQtyUnit.SelectedIndex = -1 Then
            MsgBox("Please input valid ItemID!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtNewConCoe.Text) And
            cmbOldCliQtyUnit.SelectedIndex = -1 And cmbOldSupQtyUnit.SelectedIndex = -1 Then
            MsgBox("Please input valid Changes!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = vbYes Then

            SQL.AddParams("@itemsid", txtItemid.Text)
            If cmbCliQtyUnit.SelectedIndex = 0 Then
                SQL.AddParams("@uomstype", 1)
            ElseIf cmbCliQtyUnit.SelectedIndex = 1 Then
                SQL.AddParams("@uomstype", 2)
            ElseIf cmbCliQtyUnit.SelectedIndex = 2 Then
                SQL.AddParams("@uomstype", 3)
            End If
            If cmbCliQtyUnit.SelectedIndex = 0 Then
                SQL.AddParams("@QtyUnitVals", cmbNewCliQtyUnit.SelectedValue)
            ElseIf cmbCliQtyUnit.SelectedIndex = 1 Then
                SQL.AddParams("@QtyUnitVals", cmbNewCliQtyUnit.SelectedValue)
            End If
            SQL.AddParams("@ConCoe", Val(txtNewConCoe.Text))
            SQL.AddParams("@updateid", moduleId)
            SQL.ExecQuery("execute dbo.UpdateUOM @itemid=@itemsid,@uomtype=@uomstype,@QtyUnitVal=@QtyUnitVals,
                @ConvertingCoefficient=@ConCoe,@updatedid=@updateid")

            If SQL.HasException Then Exit Sub

            MsgBox("Successfully saved!", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub cmbCliQtyUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliQtyUnit.SelectedIndexChanged
        If cmbCliQtyUnit.SelectedIndex = 0 Then
            cmbNewCliQtyUnit.Enabled = True
            cmbNewSupQtyUnit.Enabled = False
            txtNewConCoe.Enabled = False
            cmbNewSupQtyUnit.BackColor = Color.White
            txtNewConCoe.BackColor = Color.White
            cmbNewCliQtyUnit.BackColor = Color.FromArgb(192, 255, 192)
            txtNewConCoe.Clear()
        ElseIf cmbCliQtyUnit.SelectedIndex = 1 Then
            cmbNewCliQtyUnit.Enabled = False
            cmbNewSupQtyUnit.Enabled = False
            txtNewConCoe.Enabled = True
            cmbNewSupQtyUnit.BackColor = Color.White
            cmbNewCliQtyUnit.BackColor = Color.White
            txtNewConCoe.BackColor = Color.FromArgb(192, 255, 192)
        Else
            cmbNewCliQtyUnit.Enabled = False
            cmbNewSupQtyUnit.Enabled = True
            txtNewConCoe.Enabled = False
            cmbNewSupQtyUnit.BackColor = Color.FromArgb(192, 255, 192)
            cmbNewCliQtyUnit.BackColor = Color.White
            txtNewConCoe.BackColor = Color.White
            txtNewConCoe.Clear()
        End If
    End Sub

    Private Sub txtItemid_LostFocus(sender As Object, e As EventArgs) Handles txtItemid.LostFocus
        SQL.AddParams("@itemid", Trim(txtItemid.Text))
        SQL.ExecQuery("Select ClientQtyUnit,SupplierQtyUnit,ConvertingCoefficient from items where itemid=@itemid")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        cmbOldCliQtyUnit.SelectedValue = SQL.DBDT.Rows(0).Item("ClientQtyUnit")
        cmbOldSupQtyUnit.SelectedValue = SQL.DBDT.Rows(0).Item("SupplierQtyUnit")
        txtOldConCoe.Text = SQL.DBDT.Rows(0).Item("ConvertingCoefficient")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtItemid_TextChanged(sender As Object, e As EventArgs) Handles txtItemid.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItemid.Text)
        If row.Count = 0 Then
            cmbOldCliQtyUnit.Text = ""
            cmbOldSupQtyUnit.Text = ""
            txtOldConCoe.Text = ""
            Exit Sub
        End If
        cmbOldCliQtyUnit.Text = row.Item(1)
        cmbOldSupQtyUnit.Text = row.Item(2)
        txtOldConCoe = row.Item(3)
    End Sub


    Private Sub txtNewConCoe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewConCoe.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True

    End Sub
End Class