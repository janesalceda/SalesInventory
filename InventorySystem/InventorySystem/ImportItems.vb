Imports System.IO
Imports System.Text
Imports ExcelDataReader
Public Class ImportItems
    Dim tables As DataTableCollection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Try
            If String.IsNullOrWhiteSpace(TextBox1.Text) Then Exit Sub
            Dim filepath As String = TextBox1.Text
            Dim fi As New IO.FileInfo(filepath)
            Dim extn As String = fi.Extension

            If extn = ".csv" Then
                Dim textreader As New StreamReader(filepath, Encoding.Default)
                Dim sline As String

                DataGridView1.Rows.Clear()
                Dim counterLoop As Integer = 0
                Do
                    sline = textreader.ReadLine
                    If sline Is Nothing Then Exit Do
                    Dim words() As String = sline.Split(",")
                    If counterLoop > 0 Then
                        DataGridView1.Rows.Add("")
                        For ix As Integer = 0 To words.Length - 1
                            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(ix).Value = words(ix)
                        Next
                    End If
                    counterLoop += 1
                Loop
                textreader.Close()
            Else
                Using stream = File.Open(TextBox1.Text, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(
                            New ExcelDataSetConfiguration() With {
                            .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                            .UseHeaderRow = True}})
                        tables = result.Tables
                        cboSheet.Items.Clear()
                        For Each table As DataTable In tables
                            cboSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
        End Try
    End Sub


    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        ' DataGridView1.DataSource = dt
        If dt IsNot Nothing Then
            Dim list As List(Of Items) = New List(Of Items)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim item As Items = New Items
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Tablename As String = ""
        Dim strItems As String = ""
        Try
            If MsgBox("Are you sure you want to save?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                If rights = 4 Then
                    Tablename = "itemsForApproval"
                Else
                    Tablename = "Items"
                End If
                Dim strSTID As String = ""
                SQL.ExecQuery("select 'ST'+replace(convert(date,GETDATE()),'-','') +'-'+ NUM AS 'pomax' FROM
                    (select CASE WHEN (count(*)+1)<10 THEN '0' + CAST(COUNT(*)+1 AS VARCHAR) 
                    ELSE CAST(COUNT(*)+1 AS VARCHAR) END 'num' 
                    from StockTakingHeaders where convert(date,createddate)=convert(date,getdate()))A")
                If SQL.HasException Or SQL.DBDT.Rows.Count = 0 Then Exit Sub
                strSTID = SQL.DBDT.Rows(0).Item(0)

                SQL.ExecQuery("select 'IT'+replace(convert(date,GETDATE()),'-','') +'-' + 
	                CASE WHEN num+1<10 THEN '0' + CAST(num+1 AS VARCHAR) 
                    ELSE CAST(num+1 AS VARCHAR) END 'num' from
                    (SELECT(select count(*) from items where convert(date,createddate)=convert(date,getdate())) +
                    (select count(*) from ItemsForApproval where convert(date,createddate)=convert(date,getdate()))
                    'num')a")
                strItems = SQL.DBDT.Rows(0).Item(0)


                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    SQL.AddParams("@Tablename", Tablename)
                    SQL.AddParams("@description", DataGridView1.Rows(i).Cells(0).Value)
                    SQL.AddParams("@convertingcoefficient", DataGridView1.Rows(i).Cells(1).Value)
                    SQL.AddParams("@location", DataGridView1.Rows(i).Cells(2).Value)
                    SQL.AddParams("@categoryid", DataGridView1.Rows(i).Cells(3).Value)
                    SQL.AddParams("@maxorderqty", DataGridView1.Rows(i).Cells(4).Value)
                    SQL.AddParams("@minimumorderqty", DataGridView1.Rows(i).Cells(5).Value)
                    SQL.AddParams("@orderingpointqty", DataGridView1.Rows(i).Cells(6).Value)
                    SQL.AddParams("@remarks", DataGridView1.Rows(i).Cells(7).Value)
                    SQL.AddParams("@cliunitprice", DataGridView1.Rows(i).Cells(8).Value)
                    SQL.AddParams("@clientqtyunit", DataGridView1.Rows(i).Cells(9).Value)
                    SQL.AddParams("@cliapplieddate", DataGridView1.Rows(i).Cells(10).Value)
                    SQL.AddParams("@supplierid", DataGridView1.Rows(i).Cells(11).Value)
                    SQL.AddParams("@supplieritemid", DataGridView1.Rows(i).Cells(12).Value)
                    SQL.AddParams("@supunitprice", DataGridView1.Rows(i).Cells(13).Value)
                    SQL.AddParams("@supplierqtyunit", DataGridView1.Rows(i).Cells(14).Value)
                    SQL.AddParams("@supapplieddate", DataGridView1.Rows(i).Cells(15).Value)
                    SQL.AddParams("@updatedby", moduleId)
                    SQL.ExecQuery("
    
            INSERT INTO " & Tablename & "
	            (ItemId,Description,ConvertingCoefficient,CategoryID,ClientQtyUnit,SupplierQtyUnit,
	            Location,MaxOrderQty,OrderingPointQty,MinimumOrderQty,Remarks,UpdatedBy)
            VALUES 
	            ((select 'IT'+replace(convert(date,GETDATE()),'-','') +'-' + 
	                CASE WHEN num+1<10 THEN '0' + CAST(num+1 AS VARCHAR)    
                    ELSE CAST(num+1 AS VARCHAR) END 'num' from
                    (SELECT(select count(*) from items where convert(date,createddate)=convert(date,getdate())) +
                    (select count(*) from ItemsForApproval where convert(date,createddate)=convert(date,getdate()))
                    'num')a
                                        ),
                @description,@convertingcoefficient,
                (Select CategoryID from categories where categoryname=@categoryid and deleteddate is null),
                (Select QtyUnitID from QtyUnits where QtyUnit=@clientqtyunit and deleteddate is null),
                (Select QtyUnitID from QtyUnits where QtyUnit=@supplierqtyunit and deleteddate is null),
	            (Select LocationID from Locations where Location=@location and deleteddate is null),
                @maxorderqty,@orderingpointqty,@minimumorderqty,@remarks,@updatedby);

            INSERT INTO dbo.ClientItemPrices
	            (ItemId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
            VALUES 
	            ((select top 1 itemid from " & Tablename & " order by createddate desc ),@cliapplieddate,@cliunitprice,NULL,@updatedby)")

                    If Not String.IsNullOrWhiteSpace(DataGridView1.Rows(i).Cells(11).Value) Then
                        SQL.AddParams("@Tablename", Tablename)
                        SQL.AddParams("@description", DataGridView1.Rows(i).Cells(0).Value)
                        SQL.AddParams("@convertingcoefficient", DataGridView1.Rows(i).Cells(1).Value)
                        SQL.AddParams("@location", DataGridView1.Rows(i).Cells(2).Value)
                        SQL.AddParams("@categoryid", DataGridView1.Rows(i).Cells(3).Value)
                        SQL.AddParams("@maxorderqty", DataGridView1.Rows(i).Cells(4).Value)
                        SQL.AddParams("@minimumorderqty", DataGridView1.Rows(i).Cells(5).Value)
                        SQL.AddParams("@orderingpointqty", DataGridView1.Rows(i).Cells(6).Value)
                        SQL.AddParams("@remarks", DataGridView1.Rows(i).Cells(7).Value)
                        SQL.AddParams("@cliunitprice", DataGridView1.Rows(i).Cells(8).Value)
                        SQL.AddParams("@clientqtyunit", DataGridView1.Rows(i).Cells(9).Value)
                        SQL.AddParams("@cliapplieddate", DataGridView1.Rows(i).Cells(10).Value)
                        SQL.AddParams("@supplierid", DataGridView1.Rows(i).Cells(11).Value)
                        SQL.AddParams("@supplieritemid", DataGridView1.Rows(i).Cells(12).Value)
                        SQL.AddParams("@supunitprice", DataGridView1.Rows(i).Cells(13).Value)
                        SQL.AddParams("@supplierqtyunit", DataGridView1.Rows(i).Cells(14).Value)
                        SQL.AddParams("@supapplieddate", DataGridView1.Rows(i).Cells(15).Value)
                        SQL.AddParams("@updatedby", moduleId)
                        SQL.ExecQuery("INSERT INTO dbo.SupplierItemPrices
	                (ItemId,
                    SupplierId,
                    SupplierItemId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
                VALUES 
	                ((select top 1 itemid from " & Tablename & " order by createddate desc ),
                    (Select SupplierId from suppliers where supplierid=@supplierid),@supplieritemid,@supapplieddate,@supunitprice,NULL,@updatedby);
                ")


                        '    SQL.AddParams("@stid", strSTID)
                        '    SQL.AddParams("@qty", DataGridView1.Rows(i).Cells(16).Value)
                        '    SQL.AddParams("@SupplierUnitprice", DataGridView1.Rows(i).Cells(13).Value)
                        '    SQL.AddParams("@cliunitprice", DataGridView1.Rows(i).Cells(8).Value)
                        '    SQL.AddParams("@remarks", DataGridView1.Rows(i).Cells(7).Value)
                        '    SQL.AddParams("@updatedby", moduleId)
                        '    SQL.ExecQuery("INSERT INTO dbo.StockTakingDetails
                        ' (STID,ItemID,Qty,ClientUnitprice,SupplierUnitprice,Remarks,UpdatedBy)
                        'VALUES(@stid,
                        '    (SELECT max(Itemid) FROM " & Tablename & "),
                        '    @qty,
                        '    @ClientUnitprice,
                        '    @SupplierUnitprice,
                        '    @remarks,
                        '    @updatedby)")
                    End If
                    If SQL.HasException Then
                        SQL.ExecQuery("DELETE FROM " & Tablename & " WHERE CreatedDate>=(
                            SELECT CreatedDate FROM " & Tablename & " WHERE ITEMID='" & strItems & "')")
                        Exit Sub
                    End If
                Next
                'SQL.AddParams("@Stid", strSTID)
                'SQL.AddParams("@encodedstaff", moduleId)
                'SQL.AddParams("@totalamount", txtTotalAmount.Text)
                'SQL.ExecQuery("INSERT INTO dbo.StockTakingHeaders
                ' (STID,CountedDate,EncodedStaff,TotalAmount,Remarks,ApprovedBy,UpdatedBy)
                'VALUES(@Stid,getdate(),@encodedstaff,@totalamount,NULL,NULL,@encodedstaff)")
                If SQL.HasException Then
                    Exit Sub
                End If
                msgboxDisplay("Successfully Saved", 1)
            End If
        Catch ex As Exception
            SQL.ExecQuery("DELETE FROM " & Tablename & " WHERE CreatedDate>=(
            SELECT CreatedDate FROM Items	WHERE ITEMID=" & strItems)
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = OpenFileDialog1.FileName
        Else
            TextBox1.Clear()
        End If
    End Sub

    Private Sub ImportItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm

    End Sub
End Class