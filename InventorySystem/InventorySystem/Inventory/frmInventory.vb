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
        'LoadGrid()
        dtFrom.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        dtTo.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub
    Private Sub FindItem()
        SQL.AddParams("@user", "%" & txtitem.Text & "%")
        LoadGrid("SELECT * FROM users where employeecode like @user;")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            dgvData.Rows.Clear()

            If String.IsNullOrEmpty(txtitem.Text) Then
                MsgBox("Please input itemId!", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            Dim row As New DataTable
            Dim lastbalance As Decimal
            Dim currentbalance As Decimal
            Dim lastclicost As Decimal
            Dim currentclicost As Decimal
            Dim lastsupcost As Decimal
            Dim currentsupcost As Decimal
            Dim strTransactionDate As Date
            SQL.AddParams("@from", dtFrom.Value.ToString("yyyy/MM/dd"))
            SQL.AddParams("@to", dtTo.Value.ToString("yyyy/MM/dd"))
            SQL.AddParams("@itemid", txtitem.Text)
            SQL.ExecQuery("SELECT * FROM CostInv WHERE 
            convert(VARCHAR(10),TransactedDate,111) >= @from
            AND convert(VARCHAR(10),TransactedDate,111) <=@to
            AND ItemID=@itemid
            ORDER BY TransactedDate asc, TransactionTypeID DESC")
            If SQL.HasException Then Exit Sub
            If SQL.DBDT.Rows.Count = 0 Then
                msgboxDisplay("No record", 1)
                Exit Sub
            End If
            row = SQL.DBDT

            SQL.AddParams("@from", DateAdd("D", -1, dtFrom.Value.ToString("yyyy/MM/dd")))
            SQL.AddParams("@itemid", txtitem.Text)
            SQL.ExecQuery("SELECT Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
            If SQL.HasException Then Exit Sub
            If SQL.DBDT.Rows.Count = 0 Then
                lastbalance = 0
            Else
                lastbalance = SQL.DBDT.Rows(0).Item(0)
            End If
            currentbalance = lastbalance

            SQL.AddParams("@from", DateAdd("D", -1, dtFrom.Value.ToString("yyyy/MM/dd")))
            SQL.AddParams("@itemid", txtitem.Text)
            SQL.ExecQuery("SELECT ClientCost,SupplierCost FROM GetcostBalance(@from) WHERE ItemID=@itemid")
            If SQL.HasException Then Exit Sub
            If SQL.DBDT.Rows.Count = 0 Then
                lastclicost = 0
                lastsupcost = 0
            Else
                lastclicost = SQL.DBDT.Rows(0).Item(0)
                lastsupcost = SQL.DBDT.Rows(0).Item(1)
            End If
            currentclicost = lastclicost
            currentsupcost = lastsupcost

            With row
                For i As Integer = 0 To row.Rows.Count - 1
                    SQL.params.Clear()
                    dgvData.Rows.Add()

                    Select Case .Rows(i).Item(4)
                    'In items based on Invoice
                        Case 1
                            If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                                'get the stockbalance based on transaction date row  -1 and add the qty row
                                SQL.params.Clear()
                                SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToString("yyyy/MM/dd"))
                                SQL.AddParams("@itemid", txtitem.Text)
                                SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
                                If SQL.DBDT.Rows.Count = 0 Then
                                    currentbalance = 0 + .Rows(i).Item(3)
                                Else
                                    currentbalance = SQL.DBDT.Rows(0).Item(0) + .Rows(i).Item(3)
                                End If
                                SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToString("yyyy/MM/dd"))
                                SQL.AddParams("@itemid", txtitem.Text)
                                SQL.ExecQuery("SELECT top 1 ClientCost,SupplierCost FROM GetCostBalance(@from) WHERE ItemID=@itemid")
                                If SQL.DBDT.Rows.Count = 0 Then
                                    currentclicost = 0 + .Rows(i).Item(6)
                                    currentsupcost = 0 + .Rows(i).Item(7)
                                Else
                                    currentclicost = SQL.DBDT.Rows(0).Item(0) + .Rows(i).Item(6)
                                    currentsupcost = SQL.DBDT.Rows(0).Item(1) + .Rows(i).Item(7)
                                End If
                            Else
                                'add the qty row to the currentbalance
                                currentbalance += .Rows(i).Item(3)
                                currentclicost += .Rows(i).Item(6)
                                currentsupcost += .Rows(i).Item(7)
                            End If
                            dgvData.Rows(i).Cells(2).Value = .Rows(i).Item(3)
                        'Out items based on stock out
                        Case 2
                            If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                                SQL.params.Clear()
                                SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToShortDateString)
                                SQL.AddParams("@itemid", txtitem.Text)
                                'get the stockbalance based on transaction date row  -1 And minus the qty row
                                SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(@from) WHERE ItemID=@itemid")
                                If SQL.DBDT.Rows.Count = 0 Then
                                    currentbalance = 0 - .Rows(i).Item(3)
                                Else
                                    currentbalance = SQL.DBDT.Rows(0).Item(0) - .Rows(i).Item(3)
                                End If
                                SQL.AddParams("@from", (DateAdd("D", -1, .Rows(i).Item(0))).ToShortDateString)
                                SQL.AddParams("@itemid", txtitem.Text)
                                SQL.ExecQuery("SELECT top 1 ClientCost,SupplierCost FROM GetCostBalance(@from) WHERE ItemID=@itemid")
                                If SQL.DBDT.Rows.Count = 0 Then
                                    currentclicost = 0 - .Rows(i).Item(6)
                                    currentsupcost = 0 - .Rows(i).Item(7)
                                Else
                                    currentclicost = SQL.DBDT.Rows(0).Item(0) - .Rows(i).Item(6)
                                    currentsupcost = SQL.DBDT.Rows(0).Item(1) - .Rows(i).Item(7)
                                End If
                            Else
                                'minus the qty row to the currentbalance
                                currentbalance -= .Rows(i).Item(3)
                                currentclicost -= .Rows(i).Item(6)
                                currentsupcost -= .Rows(i).Item(7)
                            End If
                            dgvData.Rows(i).Cells(3).Value = .Rows(i).Item(3)
                        'AC of items in Stock Taking
                        Case 3
                            If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                                'Get the current balance based on row
                                currentbalance = .Rows(i).Item(3)
                            Else
                                SQL.AddParams("@transdate", .Rows(i).Item(0))
                                SQL.AddParams("@item", txtitem.Text)
                                'Get the current balance based on row and (- the total sum of in and out based on row
                                'transaction date)
                                SQL.ExecQuery("EXECUTE dbo.TotalOut @TransactionDate = @transdate, @ItemId =@item ")
                                Dim totalin As Integer = SQL.DBDT.Rows(0).Item(0)
                                If SQL.HasException Then Exit Sub
                                SQL.AddParams("@transdate", .Rows(i).Item(0))
                                SQL.AddParams("@item", txtitem.Text)
                                SQL.ExecQuery("EXECUTE dbo.TotalIn @TransactionDate = @transdate, @ItemId =@item ")
                                Dim totalout As Integer = SQL.DBDT.Rows(0).Item(0)

                                currentbalance = .Rows(i).Item(3) - (totalout + totalin)

                                'FOR COST
                                SQL.AddParams("@transdate", .Rows(i).Item(0))
                                SQL.AddParams("@item", txtitem.Text)
                                'Get the current balance based on row and (- the total sum of in and out based on row
                                'transaction date)
                                SQL.ExecQuery("EXECUTE dbo.TotalCostOut @TransactionDate = @transdate, @ItemId =@item ")
                                If SQL.HasException Then Exit Sub
                                totalin = SQL.DBDT.Rows(0).Item(0)
                                Dim supin As Integer = SQL.DBDT.Rows(0).Item(1)

                                SQL.AddParams("@transdate", .Rows(i).Item(0))
                                SQL.AddParams("@item", txtitem.Text)
                                SQL.ExecQuery("EXECUTE dbo.TotalCostIn @TransactionDate = @transdate, @ItemId =@item ")
                                totalout = SQL.DBDT.Rows(0).Item(0)
                                Dim supout As Integer = SQL.DBDT.Rows(0).Item(1)

                                currentclicost = .Rows(i).Item(6) - (totalout + totalin)
                                currentsupcost = .Rows(i).Item(7) - (supout + supin)
                            End If
                            dgvData.Rows(i).Cells(4).Value = .Rows(i).Item(3)
                    End Select
                    'Get latest transactiondate
                    'strTransactionDate
                    'Add other columns data
                    strTransactionDate = Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString
                    dgvData.Rows(i).Cells(0).Value = .Rows(i).Item(0)
                    dgvData.Rows(i).Cells(1).Value = .Rows(i).Item(1)
                    dgvData.Rows(i).Cells(5).Value = currentbalance
                    dgvData.Rows(i).Cells(6).Value = currentclicost
                    dgvData.Rows(i).Cells(7).Value = currentsupcost
                Next
            End With
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtitem.Clear()
        dtFrom.Value = Today
        dtTo.Value = Today
        dgvData.Rows.Clear()
    End Sub

    Private Sub txtitem_TextChanged(sender As Object, e As EventArgs) Handles txtitem.TextChanged

    End Sub
End Class