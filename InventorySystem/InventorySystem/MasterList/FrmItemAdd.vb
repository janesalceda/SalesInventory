Public Class FrmItemAdd
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadCliUnit()
        LoadSupUnit()
        LoadLocation()
        LoadCategories()
        ViewItemData()
        ViewSupplierPriceData()
        txtConCoe.Text = 1
        dtItemPrices.Rows.Clear()
    End Sub
    Private Sub LoadCliUnit()
        cmbCliQtyUnit.DataSource = GetQtyUnit()
        cmbCliQtyUnit.DisplayMember = "QtyUnit"
        cmbCliQtyUnit.ValueMember = "QtyUnitId"
    End Sub

    Private Sub LoadSupUnit()
        cmbSupQtyUnit.DataSource = GetQtyUnit()
        cmbSupQtyUnit.DisplayMember = "QtyUnit"
        cmbSupQtyUnit.ValueMember = "QtyUnitId"
    End Sub
    Private Sub LoadLocation()
        cmbLocation.DataSource = getLocation()
        cmbLocation.DisplayMember = "Location"
        cmbLocation.ValueMember = "LocationId"
    End Sub
    Private Sub LoadCategories()
        cmbCategory.DataSource = getCategories()
        cmbCategory.DisplayMember = "CategoryName"
        cmbCategory.ValueMember = "CategoryID"
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "SAVE" Then
            txtItemId.Text = GetItemcode()
            SQL.AddParams("@itemid", txtItemId.Text)
            SQL.AddParams("@description", txtDes.Text)
            SQL.AddParams("@convertingcoefficient", txtConCoe.Text)
            SQL.AddParams("@clientqtyunit", cmbCliQtyUnit.SelectedValue)
            SQL.AddParams("@supplierqtyunit", cmbSupQtyUnit.SelectedValue)
            SQL.AddParams("@category", cmbCategory.SelectedValue)
            'SQL.AddParams("@supplierid", "")
            SQL.AddParams("@location", cmbLocation.SelectedValue)
            SQL.AddParams("@maxorderqty", txtMax.Text)
            SQL.AddParams("@orderingpointqty", txtOrderPoint.Text)
            SQL.AddParams("@minimumorderqty", txtMinQty.Text)
            SQL.AddParams("@remarks", txtRemarks.Text)
            SQL.AddParams("@updatedby", moduleId)
            SQL.ExecQuery("INSERT INTO dbo.Items
	        (ItemId,Description,ConvertingCoefficient,CategoryID,ClientQtyUnit,SupplierQtyUnit,
	        Location,MaxOrderQty,OrderingPointQty,MinimumOrderQty,Remarks,UpdatedBy)
        VALUES 
	        (@itemid,@description,@convertingcoefficient,@category,@clientqtyunit,@supplierqtyunit,
	        @location,@maxorderqty,@orderingpointqty,@minimumorderqty,@remarks,@updatedby)")

            If SQL.HasException Then Exit Sub

            '            SQL.AddParams("@itemid", txtItemId.Text)
            '            SQL.AddParams("@UnitPrice", 1)
            '            SQL.AddParams("@updatedby", moduleId)
            '            SQL.ExecQuery("INSERT INTO SupplierItemPrices(ItemId,UnitPrice,UpdatedBy)
            '                VALUES(SELECT CASE WHEN max(ITEMID) IS NULL 
            '                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') +'-01' ELSE
            '                    CASE WHEN Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1<10
            '                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') + '-0'+ cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
            '                    ELSE 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','')+ '-' +cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
            '                    END END AS 'pomax' from ITEMS
            ',@UnitPrice,@updatedby)")
            '            If SQL.HasException Then Exit Sub
            FrmItemSearch.LoadDataGrid()

        End If
        For i As Integer = 0 To dtItemPrices.Rows.Count - 1
            If String.IsNullOrEmpty(dtItemPrices.Rows(i).Cells(3).Value.ToString) Then
                SQL.AddParams("@ItemId", txtItemId.Text)
                SQL.AddParams("@SupplierID", dtItemPrices.Rows(i).Cells(0).Value.ToString)
                SQL.AddParams("@ItemPrice", dtItemPrices.Rows(i).Cells(2).Value.ToString)
                SQL.AddParams("@AppliedDate", dtItemPrices.Rows(i).Cells(1).Value.ToString)
                SQL.AddParams("@UpdatedBy", moduleId)
                SQL.ExecQuery("INSERT INTO SupplierItemPrices 
                    (ItemId,SupplierId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
                    VALUES(@ItemId,@SupplierID,@AppliedDate,@ItemPrice,NULL,@UpdatedBy)")
            End If
        Next

        MsgBox("Successfully saved!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs)
        formname = "AddItem"
        SupplierList.ShowDialog()
    End Sub

    'Private Sub txtSupplierID_TextChanged(sender As Object, e As EventArgs)
    '    Dim row As ArrayList = New ArrayList
    '    row = GetSupplierName(txtSupplierID.Text)
    '    If row.Count = 0 Then
    '        txtSupDes.Text = ""
    '        Exit Sub
    '    End If
    '    txtSupDes.Text = row.Item(0)
    'End Sub


    Private Sub dtItemPrices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItemPrices.CellClick
        If e.ColumnIndex = 5 Then

        End If
    End Sub

    Private Sub txtItemId_TextChanged(sender As Object, e As EventArgs) Handles txtItemId.TextChanged
        ViewSupplierPriceData()
    End Sub
    Public Sub ViewSupplierPriceData()
        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery("SELECT SupplierId,AppliedDate,UnitPrice,ItemPriceId,CreatedDate 
        FROM SupplierItemPrices where ItemID=@ItemId ")
        dtItemPrices.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItemPrices.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1),
                                  SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3),
                                    SQL.DBDT.Rows(i).Item(0), "Edit")
        Next
    End Sub
    Public Sub ViewItemData()
        If String.IsNullOrEmpty(txtItemId.Text) Then Exit Sub

        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery(" select * from ITEMS where ItemID=@ItemId ")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        txtItemId.Text = SQL.DBDT.Rows(0).Item(0)
        txtDes.Text = SQL.DBDT.Rows(0).Item(1)
        cmbCliQtyUnit.Text = SQL.DBDT.Rows(0).Item(4)
        cmbSupQtyUnit.Text = SQL.DBDT.Rows(0).Item(5)
        txtConCoe.Text = SQL.DBDT.Rows(0).Item(2)
        cmbLocation.Text = SQL.DBDT.Rows(0).Item(6)
        cmbCategory.Text = SQL.DBDT.Rows(0).Item(3)
        txtMax.Text = SQL.DBDT.Rows(0).Item(7)
        txtMinQty.Text = SQL.DBDT.Rows(0).Item(9)
        txtOrderPoint.Text = SQL.DBDT.Rows(0).Item(8)
        txtRemarks.Text = SQL.DBDT.Rows(0).Item(10)
    End Sub
    Public Sub refreshData()
        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery("SELECT SupplierId,AppliedDate,UnitPrice,ItemPriceId,CreatedDate 
        FROM SupplierItemPrices where ItemID=@ItemId ")
        dtItemPrices.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItemPrices.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1),
                                  SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3),
                                    SQL.DBDT.Rows(i).Item(0), "Edit")
        Next
    End Sub
    Private Sub btnAddItemPrice_Click(sender As Object, e As EventArgs) Handles btnAddItemPrice.Click
        FrmItemPriceAdd.ItemId = txtItemId.Text
        FrmItemPriceAdd.Show()
    End Sub

    Private Sub dtItemPrices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItemPrices.CellContentClick
        If e.ColumnIndex = 5 Then
            FrmItemPriceAdd.ItemId = txtItemId.Text
            FrmItemPriceAdd.Text = "View Item Price"
            FrmItemPriceAdd.Show()
        End If
    End Sub

    Private Sub AddSupplierPrices()

    End Sub
End Class