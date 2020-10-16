Public Class AddItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadCliUnit()
        LoadSupUnit()
        LoadLocation()
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "SAVE" Then
            SQL.AddParams("@itemid", txtItemId.Text)
            SQL.AddParams("@description", txtDes.Text)
            SQL.AddParams("@convertingcoefficient", txtConCoe.Text)
            SQL.AddParams("@clientqtyunit", cmbCliQtyUnit.SelectedValue)
            SQL.AddParams("@supplierqtyunit", cmbSupQtyUnit.SelectedValue)
            SQL.AddParams("@supplierid", txtSupplierID.Text)
            SQL.AddParams("@location", cmbLocation.SelectedValue)
            SQL.AddParams("@maxorderqty", txtMax.Text)
            SQL.AddParams("@orderingpointqty", txtOrderPoint.Text)
            SQL.AddParams("@minimumorderqty", txtMinQty.Text)
            SQL.AddParams("@remarks", txtRemarks.Text)
            SQL.AddParams("@updatedby", moduleId)
            SQL.ExecQuery("INSERT INTO dbo.Items
	        (ItemId,Description,ConvertingCoefficient,ClientQtyUnit,SupplierQtyUnit,SupplierID,
	        Location,MaxOrderQty,OrderingPointQty,MinimumOrderQty,Remarks,UpdatedBy)
        VALUES 
	        (SELECT CASE WHEN max(ITEMID) IS NULL 
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') +'-01' ELSE
                    CASE WHEN Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1<10
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') + '-0'+ cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    ELSE 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','')+ '-' +cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    END END AS 'pomax' from ITEMS
,@description,@convertingcoefficient,@clientqtyunit,@supplierqtyunit,@supplierid,
	        @location,@maxorderqty,@orderingpointqty,@minimumorderqty,@remarks,@updatedby)")

            If SQL.HasException Then Exit Sub

            SQL.AddParams("@itemid", txtItemId.Text)
            SQL.AddParams("@UnitPrice", txtUnitPrice.Text)
            SQL.AddParams("@updatedby", moduleId)
            SQL.ExecQuery("INSERT INTO SupplierItemPrices(ItemId,UnitPrice,UpdatedBy)
                VALUES(SELECT CASE WHEN max(ITEMID) IS NULL 
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') +'-01' ELSE
                    CASE WHEN Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1<10
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') + '-0'+ cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    ELSE 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','')+ '-' +cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    END END AS 'pomax' from ITEMS
,@UnitPrice,@updatedby)")
            If SQL.HasException Then Exit Sub

            FrmItems.LoadDataGrid()
            MsgBox("Successfully saved!", MsgBoxStyle.Information)
            Me.Close()

        End If
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        formname = "AddItem"
        SupplierList.ShowDialog()
    End Sub

    Private Sub txtSupplierID_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierID.TextChanged
        Dim row As ArrayList = New ArrayList
        row = GetSupplierName(txtSupplierID.Text)
        If row.Count = 0 Then
            txtSupDes.Text = ""
            Exit Sub
        End If
        txtSupDes.Text = row.Item(0)
    End Sub
End Class