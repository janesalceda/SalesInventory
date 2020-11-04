<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockOutEntry
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
        Me.dtSOutDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSTRemarks = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.dtableStockout = New System.Windows.Forms.DataGridView()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtStockOutID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIssuedBy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEncodedStaff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.BTNLogout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        CType(Me.dtableStockout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtSOutDate
        '
        Me.dtSOutDate.Checked = False
        Me.dtSOutDate.Enabled = False
        Me.dtSOutDate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtSOutDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSOutDate.Location = New System.Drawing.Point(113, 57)
        Me.dtSOutDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtSOutDate.Name = "dtSOutDate"
        Me.dtSOutDate.Size = New System.Drawing.Size(139, 23)
        Me.dtSOutDate.TabIndex = 0
        Me.dtSOutDate.Value = New Date(2020, 10, 25, 13, 58, 33, 0)
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(819, 380)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.Gainsboro
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnItems.Location = New System.Drawing.Point(232, 52)
        Me.btnItems.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(31, 23)
        Me.btnItems.TabIndex = 4
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnAddItem.Location = New System.Drawing.Point(174, 174)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(90, 25)
        Me.btnAddItem.TabIndex = 7
        Me.btnAddItem.Text = "INSERT"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(6, 147)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 16)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Remarks:"
        '
        'txtSTRemarks
        '
        Me.txtSTRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSTRemarks.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSTRemarks.Location = New System.Drawing.Point(76, 143)
        Me.txtSTRemarks.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSTRemarks.Name = "txtSTRemarks"
        Me.txtSTRemarks.Size = New System.Drawing.Size(191, 23)
        Me.txtSTRemarks.TabIndex = 6
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQty.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtQty.Location = New System.Drawing.Point(76, 109)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(102, 23)
        Me.txtQty.TabIndex = 5
        '
        'dtableStockout
        '
        Me.dtableStockout.AllowUserToAddRows = False
        Me.dtableStockout.AllowUserToDeleteRows = False
        Me.dtableStockout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableStockout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtableStockout.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtableStockout.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtableStockout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableStockout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.PO, Me.UnitPrice, Me.TotalPrice, Me.Unit, Me.SupplierItemPrice})
        Me.dtableStockout.Location = New System.Drawing.Point(271, 25)
        Me.dtableStockout.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtableStockout.Name = "dtableStockout"
        Me.dtableStockout.ReadOnly = True
        Me.dtableStockout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableStockout.Size = New System.Drawing.Size(633, 230)
        Me.dtableStockout.TabIndex = 69
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        Me.Seq.Width = 58
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Width = 59
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 104
        '
        'PO
        '
        Me.PO.HeaderText = "Qty"
        Me.PO.Name = "PO"
        Me.PO.ReadOnly = True
        Me.PO.Width = 55
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        Me.UnitPrice.Width = 89
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "TotalPrice"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Width = 95
        '
        'Unit
        '
        Me.Unit.HeaderText = "Remarks"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.Width = 89
        '
        'SupplierItemPrice
        '
        Me.SupplierItemPrice.HeaderText = "SupplierItemPrice"
        Me.SupplierItemPrice.Name = "SupplierItemPrice"
        Me.SupplierItemPrice.ReadOnly = True
        Me.SupplierItemPrice.Visible = False
        Me.SupplierItemPrice.Width = 143
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(610, 12)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(142, 42)
        Me.txtRemarks.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(512, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Remaks:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "StockOut Date:"
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtItemName.Location = New System.Drawing.Point(6, 80)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(258, 23)
        Me.txtItemName.TabIndex = 65
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(7, 56)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 16)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "*Item:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(6, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "*Qty:"
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.LightBlue
        Me.txtItemCode.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtItemCode.Location = New System.Drawing.Point(70, 52)
        Me.txtItemCode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(189, 23)
        Me.txtItemCode.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnItems)
        Me.GroupBox1.Controls.Add(Me.btnAddItem)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSTRemarks)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.dtableStockout)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 88)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(908, 284)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Out Details"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(270, 261)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(180, 19)
        Me.Label27.TabIndex = 130
        Me.Label27.Text = "*NOTE: CLICK TO UPDATE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(76, 174)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 25)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "SCAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtStockOutID
        '
        Me.txtStockOutID.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtStockOutID.Location = New System.Drawing.Point(113, 12)
        Me.txtStockOutID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStockOutID.Name = "txtStockOutID"
        Me.txtStockOutID.Size = New System.Drawing.Size(139, 23)
        Me.txtStockOutID.TabIndex = 108
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "StockOut ID"
        '
        'txtIssuedBy
        '
        Me.txtIssuedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIssuedBy.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtIssuedBy.Location = New System.Drawing.Point(354, 12)
        Me.txtIssuedBy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIssuedBy.Name = "txtIssuedBy"
        Me.txtIssuedBy.Size = New System.Drawing.Size(150, 23)
        Me.txtIssuedBy.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(258, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "*Issued By:"
        '
        'txtEncodedStaff
        '
        Me.txtEncodedStaff.Enabled = False
        Me.txtEncodedStaff.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtEncodedStaff.Location = New System.Drawing.Point(356, 57)
        Me.txtEncodedStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEncodedStaff.Name = "txtEncodedStaff"
        Me.txtEncodedStaff.Size = New System.Drawing.Size(150, 23)
        Me.txtEncodedStaff.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(256, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Encoded Staff:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(3, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 19)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "*NOTE: ALL * ARE IMPORTANT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(512, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Total Amount:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtTotalAmount.Location = New System.Drawing.Point(610, 57)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(144, 23)
        Me.txtTotalAmount.TabIndex = 127
        '
        'BTNLogout
        '
        Me.BTNLogout.BackColor = System.Drawing.Color.DarkGray
        Me.BTNLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLogout.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.BTNLogout.Location = New System.Drawing.Point(821, 47)
        Me.BTNLogout.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.Size = New System.Drawing.Size(90, 25)
        Me.BTNLogout.TabIndex = 128
        Me.BTNLogout.Text = "LOGOUT"
        Me.BTNLogout.UseVisualStyleBackColor = False
        Me.BTNLogout.Visible = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.DarkGray
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnReport.Location = New System.Drawing.Point(821, 16)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(90, 25)
        Me.btnReport.TabIndex = 130
        Me.btnReport.Text = "REPRINT"
        Me.btnReport.UseVisualStyleBackColor = False
        Me.btnReport.Visible = False
        '
        'FrmStockOutEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 409)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.BTNLogout)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIssuedBy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEncodedStaff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtSOutDate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStockOutID)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmStockOutEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockOut Entry"
        CType(Me.dtableStockout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtSOutDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSTRemarks As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents dtableStockout As DataGridView
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtStockOutID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIssuedBy As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEncodedStaff As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents BTNLogout As Button
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents PO As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents SupplierItemPrice As DataGridViewTextBoxColumn
    Friend WithEvents btnReport As Button
End Class
