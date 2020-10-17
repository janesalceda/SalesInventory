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
    End Sub
    Private Sub FindItem()
        SQL.AddParams("@user", "%" & txtitem.Text & "%")
        LoadGrid("SELECT * FROM users where employeecode like @user;")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim row As New DataTable
        Dim lastbalance As Decimal
        Dim currentbalance As Decimal
        Dim strTransactionDate As Date
        If String.IsNullOrEmpty(txtitem.Text) Then
            MsgBox("Please input itemId!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        SQL.AddParams("@from", dtFrom.Value.ToShortDateString)
        SQL.AddParams("@to", dtTo.Value.ToShortDateString)
        SQL.AddParams("@itemid", txtitem.Text)
        SQL.ExecQuery("SELECT * FROM SAMPLEINV WHERE 
            convert(VARCHAR(10),TransactedDate,111) >= @from
            AND convert(VARCHAR(10),TransactedDate,111) <=@to
            AND ItemID=@itemid
            ORDER BY TransactedDate asc, TransactionTypeID DESC")
        If SQL.HasException Then Exit Sub
        row = SQL.DBDT
        SQL.AddParams("@from", dtFrom.Value.ToShortDateString)
        SQL.AddParams("@itemid", txtitem.Text)
        SQL.ExecQuery("SELECT Qty FROM GetStockBalance(DATEADD(DAY,-1,@from)) WHERE ItemID=@itemid")
        If SQL.HasException Then Exit Sub
        lastbalance = SQL.DBDT.Rows(0).ItemArray(0)
        currentbalance = lastbalance

        With row
            For i As Integer = 0 To row.Rows.Count - 1
                SQL.params.Clear()
                SQL.AddParams("@from", dtFrom.Value.ToShortDateString)
                SQL.AddParams("@itemid", txtitem.Text)
                dgvData.Rows.Add()

                Select Case .Rows(i).Item(4)
                    'In items based on Invoice
                    Case 1
                        If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                            'get the stockbalance based on transaction date row  -1 and add the qty row
                            SQL.params.Clear()
                            SQL.AddParams("@from", .Rows(i).Item(0))
                            SQL.AddParams("@itemid", txtitem.Text)
                            SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(DATEADD(DAY,-1,@from)) WHERE ItemID=@itemid")
                            If SQL.DBDT.Rows.Count = 0 Then currentbalance = 0 + .Rows(i).Item(3)
                            currentbalance = SQL.DBDT.Rows(0).Item(0) + .Rows(i).Item(3)
                        Else
                            'add the qty row to the currentbalance
                            currentbalance += .Rows(i).Item(3)
                        End If
                        dgvData.Rows(i).Cells(2).Value = .Rows(i).Item(3)
                        'Out items based on stock out
                    Case 2
                        If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                            SQL.params.Clear()
                            SQL.AddParams("@from", .Rows(i).Item(0))
                            SQL.AddParams("@itemid", txtitem.Text)
                            'get the stockbalance based on transaction date row  -1 And minus the qty row
                            SQL.ExecQuery("SELECT top 1 Qty FROM GetStockBalance(DATEADD(DAY,-1,@from)) WHERE ItemID=@itemid")
                            If SQL.DBDT.Rows.Count = 0 Then currentbalance = 0 - .Rows(i).Item(3)
                            currentbalance = SQL.DBDT.Rows(0).Item(0) - .Rows(i).Item(3)
                        Else
                            'minus the qty row to the currentbalance
                            currentbalance -= .Rows(i).Item(3)
                        End If
                        dgvData.Rows(i).Cells(3).Value = .Rows(i).Item(3)
                        'AC of items in Stock Taking
                    Case 3
                        If strTransactionDate <> Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString Then
                            'Get the current balance based on row
                            currentbalance = .Rows(i).Item(3)
                        Else
                            SQL.AddParams("@transdate", .Rows(0).Item(0))
                            SQL.AddParams("@item", txtitem.Text)
                            'Get the current balance based on row and (- the total sum of in and out based on row
                            'transaction date)
                            SQL.ExecQuery("EXECUTE dbo.TotalOut @TransactionDate = @transdate, @ItemId =@item ")
                            Dim totalin As Integer = SQL.DBDT.Rows(0).Item(0)
                            If SQL.HasException Then Exit Sub
                            SQL.AddParams("@transdate", .Rows(0).Item(0))
                            SQL.AddParams("@item", txtitem.Text)
                            SQL.ExecQuery("EXECUTE dbo.TotalIn @TransactionDate = @transdate, @ItemId =@item ")
                            Dim totalout As Integer = SQL.DBDT.Rows(0).Item(0)

                            currentbalance = .Rows(i).Item(3) - (totalout + totalin)
                        End If
                        dgvData.Rows(i).Cells(4).Value = .Rows(i).Item(3)
                End Select
                'Get latest transactiondate
                'strTransactionDate
                'Add other columns data
                strTransactionDate = Convert.ToDateTime(.Rows(i).Item(0).ToString).ToShortDateString
                dgvData.Rows(i).Cells(0).Value = .Rows(i).Item(0)
                dgvData.Rows(i).Cells(1).Value = .Rows(i).Item(1)
                'dgvData.Rows(i).Cells(2).Value = .Rows(i).Item(3)
                dgvData.Rows(i).Cells(5).Value = currentbalance

                'dgvData.Rows.Add(row.Rows(i).Item(0), row.Rows(i).Item(1), currentbalance, "")
            Next
        End With
    End Sub

    'Private Sub dgvData_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvData.CellFormatting
    '    dgvData.Rows(e.RowIndex).Cells(0).Value = CStr(e.RowIndex + 1)
    'End Sub
End Class