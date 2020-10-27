﻿Public Class ScanItem
    Dim int As Integer = 0
    Private Sub ScanItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If int = 0 Then
            Label1.ForeColor = Color.Red
            int = 1
        Else
            Label1.ForeColor = Color.Black
            int = 0
        End If
    End Sub

    Private Sub txtItemID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemID.KeyDown
        If e.KeyCode = Keys.Enter Then
            SQL.AddParams("@ItemID", txtItemID.Text)
            SQL.ExecQuery("Select * from items where deleteddate is null and ItemID=@ItemID")
            If SQL.DBDT.Rows.Count = 0 Then
                MsgBox("Item does not exist", MsgBoxStyle.Information, "Information")
                txtItemID.Clear()
                Exit Sub
            End If

            FrmScanItems.ItemCode = txtItemID.Text
            txtItemID.Clear()
            FrmScanItems.Show()
        End If
    End Sub

End Class