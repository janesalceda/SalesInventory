﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OUTQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANCE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(542, 42)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 32)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "VIEW"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtitem
        '
        Me.txtitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitem.Location = New System.Drawing.Point(70, 12)
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(210, 27)
        Me.txtitem.TabIndex = 1
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionDate, Me.TRANSID, Me.INQTY, Me.OUTQTY, Me.ACQTY, Me.BALANCE})
        Me.dgvData.Location = New System.Drawing.Point(12, 82)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(643, 495)
        Me.dgvData.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Items:"
        '
        'dtFrom
        '
        Me.dtFrom.Location = New System.Drawing.Point(336, 12)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(150, 27)
        Me.dtFrom.TabIndex = 5
        '
        'dtTo
        '
        Me.dtTo.Location = New System.Drawing.Point(510, 12)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(150, 27)
        Me.dtTo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "~"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date:"
        '
        'TransactionDate
        '
        Me.TransactionDate.HeaderText = "Transaction Date"
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.ReadOnly = True
        '
        'TRANSID
        '
        Me.TRANSID.HeaderText = "TRANSID"
        Me.TRANSID.Name = "TRANSID"
        Me.TRANSID.ReadOnly = True
        '
        'INQTY
        '
        Me.INQTY.HeaderText = "IN QTY"
        Me.INQTY.Name = "INQTY"
        Me.INQTY.ReadOnly = True
        '
        'OUTQTY
        '
        Me.OUTQTY.HeaderText = "OUT QTY"
        Me.OUTQTY.Name = "OUTQTY"
        Me.OUTQTY.ReadOnly = True
        '
        'ACQTY
        '
        Me.ACQTY.HeaderText = "AC QTY"
        Me.ACQTY.Name = "ACQTY"
        Me.ACQTY.ReadOnly = True
        '
        'BALANCE
        '
        Me.BALANCE.HeaderText = "BALANCE"
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.ReadOnly = True
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(667, 589)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.btnSearch)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInventory"
        Me.Text = "Inventory"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtitem As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents TRANSID As DataGridViewTextBoxColumn
    Friend WithEvents INQTY As DataGridViewTextBoxColumn
    Friend WithEvents OUTQTY As DataGridViewTextBoxColumn
    Friend WithEvents ACQTY As DataGridViewTextBoxColumn
    Friend WithEvents BALANCE As DataGridViewTextBoxColumn
End Class
