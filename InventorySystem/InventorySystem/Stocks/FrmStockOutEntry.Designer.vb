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
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        CType(Me.dtableStockout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtSOutDate
        '
        Me.dtSOutDate.Checked = False
        Me.dtSOutDate.Enabled = False
        Me.dtSOutDate.Location = New System.Drawing.Point(133, 49)
        Me.dtSOutDate.Name = "dtSOutDate"
        Me.dtSOutDate.Size = New System.Drawing.Size(150, 26)
        Me.dtSOutDate.TabIndex = 0
        Me.dtSOutDate.Value = New Date(2020, 10, 25, 13, 58, 33, 0)
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(783, 427)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 30)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.Gainsboro
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Location = New System.Drawing.Point(302, 63)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(36, 26)
        Me.btnItems.TabIndex = 4
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.White
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Location = New System.Drawing.Point(228, 288)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(116, 30)
        Me.btnAddItem.TabIndex = 7
        Me.btnAddItem.Text = "INSERT"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 18)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Remarks:"
        '
        'txtSTRemarks
        '
        Me.txtSTRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSTRemarks.Location = New System.Drawing.Point(94, 172)
        Me.txtSTRemarks.Name = "txtSTRemarks"
        Me.txtSTRemarks.Size = New System.Drawing.Size(244, 26)
        Me.txtSTRemarks.TabIndex = 6
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQty.Location = New System.Drawing.Point(94, 131)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(130, 26)
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
        Me.dtableStockout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableStockout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.PO, Me.UnitPrice, Me.Unit})
        Me.dtableStockout.Location = New System.Drawing.Point(349, 30)
        Me.dtableStockout.Name = "dtableStockout"
        Me.dtableStockout.ReadOnly = True
        Me.dtableStockout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableStockout.Size = New System.Drawing.Size(544, 294)
        Me.dtableStockout.TabIndex = 69
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        Me.Seq.Width = 60
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Width = 60
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 111
        '
        'PO
        '
        Me.PO.HeaderText = "Qty"
        Me.PO.Name = "PO"
        Me.PO.ReadOnly = True
        Me.PO.Width = 54
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        Me.UnitPrice.Width = 95
        '
        'Unit
        '
        Me.Unit.HeaderText = "Remarks"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.Width = 94
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Location = New System.Drawing.Point(720, 12)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(181, 49)
        Me.txtRemarks.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(607, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Remaks:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "StockOut Date:"
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(14, 96)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(324, 26)
        Me.txtItemName.TabIndex = 65
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 18)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "*Item:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 18)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "*Qty:"
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.LightBlue
        Me.txtItemCode.Location = New System.Drawing.Point(90, 63)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(242, 26)
        Me.txtItemCode.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 330)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Out Details"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(8, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 30)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "SCAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtStockOutID
        '
        Me.txtStockOutID.Enabled = False
        Me.txtStockOutID.Location = New System.Drawing.Point(133, 15)
        Me.txtStockOutID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockOutID.Name = "txtStockOutID"
        Me.txtStockOutID.Size = New System.Drawing.Size(150, 26)
        Me.txtStockOutID.TabIndex = 108
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "StockOut ID"
        '
        'txtIssuedBy
        '
        Me.txtIssuedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIssuedBy.Location = New System.Drawing.Point(407, 15)
        Me.txtIssuedBy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIssuedBy.Name = "txtIssuedBy"
        Me.txtIssuedBy.Size = New System.Drawing.Size(192, 26)
        Me.txtIssuedBy.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "*Issued By:"
        '
        'txtEncodedStaff
        '
        Me.txtEncodedStaff.Enabled = False
        Me.txtEncodedStaff.Location = New System.Drawing.Point(407, 49)
        Me.txtEncodedStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEncodedStaff.Name = "txtEncodedStaff"
        Me.txtEncodedStaff.Size = New System.Drawing.Size(192, 26)
        Me.txtEncodedStaff.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Encoded Staff:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(4, 442)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 19)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "*NOTE: ALL * ARE IMPORTANT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(607, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Total Amount:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(720, 69)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(180, 26)
        Me.txtTotalAmount.TabIndex = 127
        '
        'FrmStockOutEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 462)
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
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents PO As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
End Class
