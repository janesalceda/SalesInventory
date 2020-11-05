Public Class FrmSearchPO
    Private Sub LoadGrid(where As String)
        dtPoDetails.Rows.Clear()
        'SQL.AddParams("@where", where)
        SQL.ExecQuery("SELECT count(*) as a from (select DISTINCT p.PoNo,p.SupplierID,SupplierName,IssuedDate,
            CASE WHEN p.DeletedDate IS NULL THEN 0 ELSE 1 END Cancelled FROM poheaders p
            INNER JOIN Suppliers s ON p.SupplierID=s.SupplierId INNER JOIN PoDetails pd
            ON pd.PoNo=p.PONo " & where & ") a")
        If SQL.DBDT.Rows.Count = 0 Then
            If SQL.RecordCount = 0 Then
                MsgBox("No Record Found", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If
        ElseIf SQL.DBDT.Rows(0).Item(0) > 1000 Then
            If SQL.RecordCount = 0 Then
                MsgBox("Your Data exceeded to 1000 please set condition", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Else
            SQL.ExecQuery("SELECT p.PoNo,p.SupplierID,SupplierName,IssuedDate,
            CASE WHEN p.DeletedDate IS NULL THEN 0 ELSE 1 END Cancelled FROM poheaders p
            INNER JOIN Suppliers s ON p.SupplierID=s.SupplierId " & where & " order by p.createddate")
            dtPoDetails.Rows.Clear()
            If SQL.RecordCount = 0 Then
                MsgBox("No Record Found", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If
            For index As Integer = 0 To SQL.DBDT.Rows.Count - 1
                Dim row As ArrayList = New ArrayList
                row.Add(SQL.DBDT.Rows(index).Item(0))
                row.Add(SQL.DBDT.Rows(index).Item(1))
                row.Add(SQL.DBDT.Rows(index).Item(2))
                row.Add(SQL.DBDT.Rows(index).Item(3))
                row.Add(SQL.DBDT.Rows(index).Item(4))
                dtPoDetails.Rows.Add(row.ToArray())
            Next
        End If
    End Sub
    Private Sub FrmSearchPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub


    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        formname = "SearchPo"
        SelectionItem.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim where As String = ""
        If Not String.IsNullOrEmpty(txtPONo.Text) Then
            where += AddingWhere(where)
            where += "p.PoNo='" & txtPONo.Text & "'"
        End If
        If Not String.IsNullOrEmpty(txtSupplier.Text) Then
            where += AddingWhere(where)
            where += "p.SupplierID='" & txtSupplier.Text & "'"
        End If
        If Not String.IsNullOrEmpty(txtItems.Text) Then
            where += AddingWhere(where)
            where += "pd.ItemId='" & txtItems.Text & "'"
        End If
        If dtIssuedFrom.Checked = True And dtIssuedTo.Checked = True Then
            where += AddingWhere(where)
            where += "p.IssuedDate BETWEEN'" & dtIssuedFrom.Value.ToString("yyyy/MM/dd") & "' AND '" & dtIssuedTo.Value.ToString("yyyy/MM/dd") & "'"
        End If
        If radYes.Checked = True Then
            where += AddingWhere(where)
            where += "p.DeletedDate is not null"
        Else
            where += AddingWhere(where)
            where += "p.DeletedDate is null"
        End If
        LoadGrid(where)
    End Sub


    Private Sub dtPoDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPoDetails.CellDoubleClick
        'HINDI PA TAPOS HINDI KO PA ALAM IPAPASA SA FORM "ADDPURCHASEORDER"
        With FrmPurchaseOrderEntry
            .txtPONo.Text = dtPoDetails.SelectedRows(0).Cells(0).Value.ToString()
            .Text = "Purchase Order Details"
            .btnSave.Text = "UPDATE P.O."
            .Button1.Visible = True
            .Show()
        End With
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "FrmSearchPO"
        SupplierList.Show()
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupplier.Text)
        If row.Count = 0 Then
            txtSupplierName.Text = ""
            Exit Sub
        End If
        txtSupplierName.Text = row.Item(0)
        'txtCliUnit.Text = row.Item(1)
        'txtSupUnit.Text = row.Item(2)
        'coefficient = row.Item(3)
        'txtUnit.Text = Format(Val(row.Item(4)), "0.00")
    End Sub

    Private Sub txtItems_TextChanged(sender As Object, e As EventArgs) Handles txtItems.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetItemDetails(txtItems.Text)
        If row.Count = 0 Then
            txtItemsName.Text = ""
            Exit Sub
        End If
        txtItemsName.Text = row.Item(0)
    End Sub

    Private Sub dtPoDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPoDetails.CellContentClick

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dtPoDetails.Rows.Clear()
        txtItems.Clear()
        txtItemsName.Clear()
        txtPONo.Clear()
        txtSupplier.Clear()
        txtSupplierName.Clear()
        dtIssuedFrom.Value = Today
        dtIssuedFrom.Checked = False
        dtIssuedTo.Value = Today
        dtIssuedTo.Checked = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged

    End Sub

    Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged

    End Sub

    Private Sub dtIssuedTo_ValueChanged(sender As Object, e As EventArgs) Handles dtIssuedTo.ValueChanged

    End Sub

    Private Sub txtPONo_TextChanged(sender As Object, e As EventArgs) Handles txtPONo.TextChanged

    End Sub

    Private Sub txtSupplierName_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierName.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub dtIssuedFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtIssuedFrom.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtItemsName_TextChanged(sender As Object, e As EventArgs) Handles txtItemsName.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class