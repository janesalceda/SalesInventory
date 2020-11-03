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
        Try
            Dim Tablename As String = ""
            If rights = 4 Then
                Tablename = "itemsForApproval"
            Else
                Tablename = "Items"
            End If
            For i As Integer = 0 To DataGridview1.Rows.Count - 1
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
	            ((SELECT CASE WHEN GItemID IS NULL 
                    THEN 'IT' + replace(convert(VARCHAR(10),getdate(),111),'/','') +'-01' ELSE
	                CASE when (GItemID + 1)<10
	                THEN 'IT' + replace(convert(VARCHAR(10),getdate(),111),'/','') + '-0'+  cast(GItemID +1 as varchar)
	                ELSE 'IT' + replace(convert(VARCHAR(10),getdate(),111),'/','')+ '-' + cast(GItemID +1 as varchar)
	                END END AS 'pomax' from(
	    	            select
		                    case when
		                    isnull((select right(max(ITEMID),len(max(ITEMID))-CHARINDEX('-',max(ITEMID))) from items),0)>
		                    isnull((select right(max(ITEMID),len(max(ITEMID))-CHARINDEX('-',max(ITEMID))) from itemsforapproval),0)
		                    then (select right(max(ITEMID),len(max(ITEMID))-CHARINDEX('-',max(ITEMID))) from items) else 
		                    (select right(max(ITEMID),len(max(ITEMID))-CHARINDEX('-',max(ITEMID))) 
		                    from itemsforapproval) end 'GItemID')a
                                        ),
                @description,@convertingcoefficient,
                (Select CategoryID from categories where categoryname=@categoryid),
                (Select QtyUnitID from QtyUnits where QtyUnit=@clientqtyunit),
                (Select QtyUnitID from QtyUnits where QtyUnit=@supplierqtyunit),
	            (Select LocationID from Locations where Location=@location),
                @maxorderqty,@orderingpointqty,@minimumorderqty,@remarks,@updatedby);

            INSERT INTO dbo.SupplierItemPrices
	            (ItemId,
                SupplierId,
                SupplierItemId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
            VALUES 
	            ((SELECT max(Itemid) FROM " & Tablename & "),
                (Select SupplierId from suppliers where supplierid=@supplierid),@supplieritemid,@supapplieddate,@supunitprice,NULL,@updatedby);
            INSERT INTO dbo.ClientItemPrices
	            (ItemId,AppliedDate,UnitPrice,LeadTime,UpdatedBy)
            VALUES 
	            ((SELECT max(Itemid) FROM " & Tablename & "),@cliapplieddate,@cliunitprice,NULL,@updatedby)")
            Next
            If SQL.HasException Then
                msgboxDisplay("Error in saving data please check csv data", 3)
                Exit Sub
            End If
        Catch ex As Exception
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