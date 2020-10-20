Imports System.Drawing.Printing

Public Class FrmItemEntry

    Dim ppd As New PrintPreviewDialog
    Public Sub AddRow(supplierid As String, unitprice As Decimal, applieddate As Date)
        dtItemPrices.Rows.Add(supplierid, applieddate, unitprice, "", "", "Edit")
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
        If btnSave.Text = "SAVE" Then dtItemPrices.Rows.Clear()
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
        If String.IsNullOrWhiteSpace(txtDes.Text) Or
                cmbCliQtyUnit.SelectedIndex = -1 Or
                cmbSupQtyUnit.SelectedIndex = -1 Or
                String.IsNullOrWhiteSpace(txtConCoe.Text) Or
                cmbLocation.SelectedIndex = -1 Or
                cmbCategory.SelectedIndex = -1 Or
                String.IsNullOrWhiteSpace(txtMax.Text) Or
                String.IsNullOrWhiteSpace(txtMinQty.Text) Or
                String.IsNullOrWhiteSpace(txtOrderPoint.Text) Or
                dtItemPrices.Rows.Count = 0 Then
            MsgBox("Please comple all * important fields!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If btnSave.Text = "SAVE" Then
            'txtItemId.Text = GetItemcode()
            'SQL.AddParams("@itemid", txtItemId.Text)
            SQL.AddParams("@description", txtDes.Text)
            SQL.AddParams("@convertingcoefficient", txtConCoe.Text)
            SQL.AddParams("@clientqtyunit", cmbCliQtyUnit.SelectedValue)
            SQL.AddParams("@supplierqtyunit", cmbSupQtyUnit.SelectedValue)
            SQL.AddParams("@category", cmbCategory.SelectedValue)
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
	        (
            (SELECT CASE WHEN max(ITEMID) IS NULL 
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') +'-01' ELSE
                    CASE WHEN Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1<10
                    THEN 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','') + '-0'+ cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    ELSE 'IT' + replace(convert(VARCHAR(12),getdate(),111),'/','')+ '-' +cast(Cast(right(max(ITEMID),len(max(ITEMID))-12) AS INT) +1 AS VARCHAR	)
                    END END AS 'pomax' from ITEMS)
            ,@description,@convertingcoefficient,@category,@clientqtyunit,@supplierqtyunit,
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

        End If
        'MsgBox(dtItemPrices.Rows(0).Cells(3).Value.ToString)
        For i As Integer = 0 To dtItemPrices.Rows.Count - 1
            If String.IsNullOrEmpty(dtItemPrices.Rows(i).Cells(3).Value.ToString) Then
                SQL.AddParams("@ItemId", txtItemId.Text)
                SQL.AddParams("@SupplierID", dtItemPrices.Rows(i).Cells(0).Value.ToString)
                SQL.AddParams("@ItemPrice", dtItemPrices.Rows(i).Cells(2).Value.ToString)
                SQL.AddParams("@AppliedDate", Convert.ToDateTime(dtItemPrices.Rows(i).Cells(1).Value.ToString))
                SQL.AddParams("@UpdatedBy", moduleId)
                SQL.ExecQuery("INSERT INTO SupplierItemPrices 
                    (ItemId,SupplierId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
                    VALUES((select max(itemid) from items),@SupplierID,@AppliedDate,@ItemPrice,NULL,@UpdatedBy)")
            End If
        Next
        FrmItemSearch.LoadDataGrid()

        MsgBox("Successfully saved!", MsgBoxStyle.Information, "Information")
        Me.Close()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs)
        formname = "AddItem"
        SupplierList.Show()
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


    Private Sub dtItemPrices_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 5 Then
            FrmItemPriceAdd.ItemId = txtItemId.Text
            FrmItemPriceAdd.Text = "View Item Price"
            FrmItemPriceAdd.Show()
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
                                    SQL.DBDT.Rows(i).Item(0))
        Next
    End Sub
    Public Sub ViewItemData()
        If String.IsNullOrEmpty(txtItemId.Text) Then Exit Sub

        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery(" select * from ITEMS i INNER JOIN SupplierItemPrices s
            ON  i.itemid=s.ItemId	
            where i.ItemID=@ItemId ORDER BY applieddate ASC")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        txtItemId.Text = SQL.DBDT.Rows(0).Item(0)
        txtDes.Text = SQL.DBDT.Rows(0).Item(1)
        cmbCliQtyUnit.SelectedValue = SQL.DBDT.Rows(0).Item(4)
        cmbSupQtyUnit.SelectedValue = SQL.DBDT.Rows(0).Item(5)
        txtConCoe.Text = SQL.DBDT.Rows(0).Item(2)
        cmbLocation.SelectedValue = SQL.DBDT.Rows(0).Item(6)
        cmbCategory.SelectedValue = SQL.DBDT.Rows(0).Item(3)
        txtMax.Text = SQL.DBDT.Rows(0).Item(7)
        txtMinQty.Text = SQL.DBDT.Rows(0).Item(9)
        txtOrderPoint.Text = SQL.DBDT.Rows(0).Item(8)
        txtRemarks.Text = SQL.DBDT.Rows(0).Item(10)
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtItemPrices.Rows.Add(SQL.DBDT.Rows(i).Item(17), SQL.DBDT.Rows(i).Item(18), SQL.DBDT.Rows(i).Item(19), SQL.DBDT.Rows(i).Item(15), SQL.DBDT.Rows(i).Item(21))
        Next
        picprint.Visible = True
        picBar.Visible = True
        picQR.Visible = True
        PictureBox4.Visible = True
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
        FrmItemPriceAdd.btnSave.Text = "INSERT PRICE"
        FrmItemPriceAdd.Text = "Insert Item Price"
        FrmItemPriceAdd.Show()
    End Sub

    Private Sub dtItemPrices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 5 Then
            'FrmItemPriceAdd.ItemId = txtItemId.Text
            FrmItemPriceAdd.btnSave.Text = "UPDATE PRICE"
            FrmItemPriceAdd.Text = "View Item Price"
            FrmItemPriceAdd.Show()
        End If
    End Sub

    Private Sub picQR_Click(sender As Object, e As EventArgs) Handles picQR.Click
        FrmPrintingItemBarcode.formname = "QR"
        FrmPrintingItemBarcode.Show()
    End Sub

    Private Sub picBar_Click(sender As Object, e As EventArgs) Handles picBar.Click
        FrmPrintingItemBarcode.formname = "Bar"
        FrmPrintingItemBarcode.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class