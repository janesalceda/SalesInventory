Imports System.Drawing.Printing

Public Class FrmItemEntry

    'Dim ppd As New PrintPreviewDialog
    Public Sub AddRow(supplierid As String, unitprice As Decimal, applieddate As Date)
        dtableItemPrices.Rows.Add(supplierid, applieddate, unitprice, "", "", "Edit")
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
        If btnSave.Text = "SAVE" Then dtableItemPrices.Rows.Clear()
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
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim TableName As String
        Try
            Dim completefields As String = "Please input the ff:" & vbNewLine
            If String.IsNullOrWhiteSpace(txtItemId.Text) Then completefields += "*ItemId" & vbNewLine
            If String.IsNullOrWhiteSpace(txtDes.Text) Then completefields += "*Description" & vbNewLine
            If cmbCliQtyUnit.SelectedIndex = -1 Then completefields += "*QtyUnit" & vbNewLine
            If cmbLocation.SelectedIndex = -1 Then completefields += "*Location" & vbNewLine
            If cmbCategory.SelectedIndex = -1 Then completefields += "*Category" & vbNewLine
            If cmbSupQtyUnit.SelectedIndex = -1 Then completefields += "*Supplier QtyUnit" & vbNewLine
            If String.IsNullOrWhiteSpace(txtConCoe.Text) Then completefields += "*Converting Coefficient" & vbNewLine
            If String.IsNullOrWhiteSpace(txtMax.Text) Then completefields += "*Max Ordering Point" & vbNewLine
            If String.IsNullOrWhiteSpace(txtMinQty.Text) Then completefields += "*Minimum Qty" & vbNewLine
            If String.IsNullOrWhiteSpace(txtOrderPoint.Text) Then completefields += "*Ordering Point" & vbNewLine
            If dtableCliPrice.Rows.Count = 0 Then completefields += "*Item Price" & vbNewLine
            If dtableItemPrices.Rows.Count = 0 Then completefields += "*Supplier ItemPrice"
            If completefields <> "Please input the ff:" & vbNewLine Then
                msgboxDisplay(completefields, 2)
                Exit Sub
            End If
            If MsgBox("Are you sure you want to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = vbYes Then
                If btnSave.Text = "SAVE" Then
                    If String.IsNullOrWhiteSpace(txtDes.Text) Or
                        cmbCliQtyUnit.SelectedIndex = -1 Or
                        cmbSupQtyUnit.SelectedIndex = -1 Or
                        String.IsNullOrWhiteSpace(txtConCoe.Text) Or
                        cmbLocation.SelectedIndex = -1 Or
                        cmbCategory.SelectedIndex = -1 Or
                        String.IsNullOrWhiteSpace(txtMax.Text) Or
                        String.IsNullOrWhiteSpace(txtMinQty.Text) Or
                        String.IsNullOrWhiteSpace(txtOrderPoint.Text) Or
                        dtableItemPrices.Rows.Count = 0 Then
                        MsgBox("Please comple all * important fields!", MsgBoxStyle.Exclamation, "Warning")
                        Exit Sub
                    End If
                    SQL.AddParams("@itemid", txtItemId.Text)
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
                    If rights = 4 Then
                        TableName = "ItemsForApproval"
                    Else
                        TableName = "Items"
                    End If
                    SQL.ExecQuery("INSERT INTO " & TableName & "
	                        (ItemId,Description,ConvertingCoefficient,CategoryID,ClientQtyUnit,SupplierQtyUnit,
	                        Location,MaxOrderQty,OrderingPointQty,MinimumOrderQty,Remarks,UpdatedBy)
                        VALUES 
	                            (@itemid,@description,@convertingcoefficient,@category,@clientqtyunit,@supplierqtyunit,
	                        @location,@maxorderqty,@orderingpointqty,@minimumorderqty,@remarks,@updatedby)")
                    '(select 'IT'+replace(convert(date,GETDATE()),'-','') +'-' + 
                    '           CASE WHEN num+1<10 THEN '0' + CAST(num+1 AS VARCHAR) 
                    '              ELSE CAST(num+1 AS VARCHAR) END 'num' from
                    '              (SELECT(select count(*) from items where convert(date,createddate)=convert(date,getdate())) +
                    '              (select count(*) from ItemsForApproval where convert(date,createddate)=convert(date,getdate()))
                    '              'num')a
                    '          )
                    '(SELECT CASE WHEN max(ITEMID) IS NULL 
                    '    THEN 'IT' + replace(convert(VARCHAR(10),getdate(),111),'/','') +'-01' ELSE
                    '    CASE WHEN right(max(ITEMID),len(max(ITEMID))-CHARINDEX('-',max(ITEMID))) + 1<10
                    '    THEN 'IT' + replace(convert(VARCHAR(10),getdate(),111),'/','') + '-0'+  cast(right(max(ITEMID),len(max(ITEMID))-CHARINDEX('-',max(ITEMID))) +1 as varchar)
                    '    ELSE 'IT' + replace(convert(VARCHAR(10),getdate(),111),'/','')+ '-' + cast(right(max(ITEMID),len(max(ITEMID))-CHARINDEX('-',max(ITEMID))) +1 as varchar)
                    '    END END AS 'pomax' from ITEMS)
                    If SQL.HasException Then Exit Sub

                End If
                Dim itemids As String = ""
                If String.IsNullOrWhiteSpace(txtItemId.Text) Then
                    SQL.ExecQuery("select top 1 itemid from items order by createddate desc ")
                    itemids = SQL.DBDT.Rows(0).Item(0)
                Else
                    itemids = txtItemId.Text
                End If
                For i As Integer = 0 To dtableItemPrices.Rows.Count - 1
                    If String.IsNullOrEmpty(dtableItemPrices.Rows(i).Cells(3).Value.ToString) Then
                        SQL.AddParams("@ItemId", itemids)
                        SQL.AddParams("@SupplierID", dtableItemPrices.Rows(i).Cells(0).Value.ToString)
                        SQL.AddParams("@ItemPrice", dtableItemPrices.Rows(i).Cells(2).Value.ToString)
                        SQL.AddParams("@AppliedDate", Convert.ToDateTime(dtableItemPrices.Rows(i).Cells(1).Value.ToString))
                        SQL.AddParams("@SupplierItemCode", dtableItemPrices.Rows(i).Cells(4).Value.ToString)
                        SQL.AddParams("@UpdatedBy", moduleId)
                        SQL.ExecQuery("INSERT INTO SupplierItemPrices 
                            (ItemId,SupplierId,SupplierItemId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
                            VALUES(@ItemId ,
                            @SupplierID,@SupplierItemCode,@AppliedDate,@ItemPrice,NULL,@UpdatedBy)")
                    End If
                    If SQL.HasException Then Exit Sub
                Next
                For i As Integer = 0 To dtableCliPrice.Rows.Count - 1
                    If String.IsNullOrEmpty(dtableCliPrice.Rows(i).Cells(2).Value.ToString) Then
                        SQL.AddParams("@ItemId", itemids)
                        SQL.AddParams("@ItemPrice", dtableCliPrice.Rows(i).Cells(1).Value.ToString)
                        SQL.AddParams("@AppliedDate", Convert.ToDateTime(dtableCliPrice.Rows(i).Cells(0).Value.ToString))
                        SQL.AddParams("@UpdatedBy", moduleId)
                        SQL.ExecQuery("INSERT INTO ClientItemPrices 
                            (ItemId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
                            VALUES( @ItemId,
                            @AppliedDate,@ItemPrice,NULL,@UpdatedBy)")
                    End If
                    If SQL.HasException Then Exit Sub
                Next
                FrmItemSearch.LoadDataGrid()

                MsgBox("Successfully saved!", MsgBoxStyle.Information, "Information")
                Me.Close()
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs)
        formname = "AddItem"
        SupplierList.Show()
    End Sub

    Private Sub DtItemPrices_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 5 Then
            FrmSupplierItemPriceEntry.ItemId = txtItemId.Text
            FrmSupplierItemPriceEntry.Text = "View Item Price"
            FrmSupplierItemPriceEntry.Show()
        End If
    End Sub

    Private Sub TxtItemId_TextChanged(sender As Object, e As EventArgs) Handles txtItemId.TextChanged
        ViewSupplierPriceData()
    End Sub
    Public Sub ViewSupplierPriceData()
        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery("SELECT SupplierId,AppliedDate,UnitPrice,ItemPriceId,CreatedDate 
        FROM SupplierItemPrices where ItemID=@ItemId ")
        dtableItemPrices.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtableItemPrices.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1),
                                  SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3),
                                    SQL.DBDT.Rows(i).Item(0))
        Next
    End Sub
    Public Sub ViewItemData()
        If String.IsNullOrEmpty(txtItemId.Text) Then Exit Sub

        SQL.AddParams("@ItemId", txtItemId.Text)
        If chkApproved.Visible = False Then
            SQL.ExecQuery(" select * from ITEMS i where i.ItemID=@ItemId")
        Else
            SQL.ExecQuery(" select * from ITEMSforapproval i where i.ItemID=@ItemId")
        End If
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
        If Not String.IsNullOrWhiteSpace(SQL.DBDT.Rows(0).Item(11)) Then
            chkDisuse.Checked = False
        Else
            chkDisuse.Checked = True
        End If
        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery(" select SupplierId,AppliedDate,UnitPrice,ItemPriceId,SupplierItemId,CreatedDate
            from SupplierItemPrices where ItemID=@ItemId ORDER BY applieddate ASC")
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtableItemPrices.Rows.Add(SQL.DBDT.Rows(i).Item("SupplierId"), SQL.DBDT.Rows(i).Item("AppliedDate"),
                                  SQL.DBDT.Rows(i).Item("UnitPrice"), SQL.DBDT.Rows(i).Item("ItemPriceId"),
                                  SQL.DBDT.Rows(i).Item("SupplierItemId"), SQL.DBDT.Rows(i).Item("CreatedDate"))
        Next
        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery(" select * from clientitemprices where ItemID=@ItemId ORDER BY applieddate ASC")
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtableCliPrice.Rows.Add(SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3),
                                  SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(5))
        Next
        picprint.Visible = True
        picBar.Visible = True
        picQR.Visible = True
        PictureBox4.Visible = True
    End Sub
    Public Sub RefreshData()
        SQL.AddParams("@ItemId", txtItemId.Text)
        SQL.ExecQuery("SELECT SupplierId,AppliedDate,UnitPrice,ItemPriceId,CreatedDate 
        FROM SupplierItemPrices where ItemID=@ItemId ")
        dtableItemPrices.Rows.Clear()
        For i As Integer = 0 To SQL.DBDT.Rows.Count - 1
            dtableItemPrices.Rows.Add(SQL.DBDT.Rows(i).Item(0), SQL.DBDT.Rows(i).Item(1),
                                  SQL.DBDT.Rows(i).Item(2), SQL.DBDT.Rows(i).Item(3),
                                    SQL.DBDT.Rows(i).Item(0), "Edit")
        Next
    End Sub
    Private Sub BtnAddItemPrice_Click(sender As Object, e As EventArgs) Handles btnAddItemPrice.Click
        If Application.OpenForms().OfType(Of FrmSupplierItemPriceEntry).Any Then FrmSupplierItemPriceEntry.Close()
        FrmSupplierItemPriceEntry.ItemId = txtItemId.Text
        FrmSupplierItemPriceEntry.btnSave.Text = "INSERT PRICE"
        FrmSupplierItemPriceEntry.Text = "Insert Item Price"
        FrmSupplierItemPriceEntry.Show()
    End Sub

    Private Sub DtItemPrices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 5 Then
            FrmSupplierItemPriceEntry.btnSave.Text = "UPDATE PRICE"
            FrmSupplierItemPriceEntry.Text = "View Item Price"
            FrmSupplierItemPriceEntry.Show()
        End If
    End Sub

    Private Sub PicQR_Click(sender As Object, e As EventArgs) Handles picQR.Click
        printQR()
    End Sub

    Private Sub PicBar_Click(sender As Object, e As EventArgs) Handles picBar.Click
        printbar()
    End Sub
    Private Sub PrintQR()
        If Application.OpenForms().OfType(Of FrmPrintingItemBarcode).Any Then FrmPrintingItemBarcode.Close()
        FrmPrintingItemBarcode.formname = "QR"
        FrmPrintingItemBarcode.Show()
    End Sub
    Private Sub Printbar()
        FrmPrintingItemBarcode.formname = "Bar"
        FrmPrintingItemBarcode.Show()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        printQR()
    End Sub

    Private Sub Picprint_Click(sender As Object, e As EventArgs) Handles picprint.Click
        Printbar()
    End Sub
    Private Sub TxtMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMax.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
    End Sub
    Private Sub TxtMinQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinQty.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub TxtOrderPoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrderPoint.KeyPress
        If Not ((e.KeyChar <= "9" And e.KeyChar >= "0") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub BtnAddPrice_Click(sender As Object, e As EventArgs) Handles btnAddPrice.Click
        If Application.OpenForms().OfType(Of FrmCliItemPrice).Any Then FrmCliItemPrice.Close()

        FrmCliItemPrice.Show()
    End Sub

    Private Sub CmbCategory_GotFocus(sender As Object, e As EventArgs) Handles cmbCategory.GotFocus
        LoadCategories()
    End Sub

    Private Sub CmbCliQtyUnit_GotFocus(sender As Object, e As EventArgs) Handles cmbCliQtyUnit.GotFocus
        LoadCliUnit()
    End Sub

    Private Sub CmbSupQtyUnit_GotFocus(sender As Object, e As EventArgs) Handles cmbSupQtyUnit.GotFocus
        LoadSupUnit()
    End Sub

    Private Sub CmbLocation_GotFocus(sender As Object, e As EventArgs) Handles cmbLocation.GotFocus
        LoadLocation()
    End Sub

    Private Sub TxtItemId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemId.KeyPress
        'e.Handled = False
    End Sub

    Private Sub ChkApproved_CheckedChanged(sender As Object, e As EventArgs) Handles chkApproved.CheckedChanged
        If MsgBox("Are you sure you want to approved this item?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            SQL.AddParams("@ItemId", txtItemId.Text)
            SQL.ExecQuery("INSERT INTO ITEMS
                            SELECT * FROM ITEMSFORAPPROVAL WHERE ITEMID=@ItemId;
                            DELETE FROM ITEMSFORAPPROVAL WHERE ITEMID=@ItemId")
            msgboxDisplay("Successfully saved!", 1)
            Close()
        End If
    End Sub
End Class