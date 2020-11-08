<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRejectReturnEntry
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtCountedDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSTRemarks = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.dtableStockTaking = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtEncodedStaff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkApprove = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStockTakingID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dtableStockTaking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(5, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 19)
        Me.Label5.TabIndex = 930
        Me.Label5.Text = "*NOTE: ALL * ARE IMPORTANT"
        '
        'dtCountedDate
        '
        Me.dtCountedDate.Checked = False
        Me.dtCountedDate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtCountedDate.Location = New System.Drawing.Point(112, 42)
        Me.dtCountedDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtCountedDate.Name = "dtCountedDate"
        Me.dtCountedDate.Size = New System.Drawing.Size(177, 23)
        Me.dtCountedDate.TabIndex = 920
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(677, 352)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.TabIndex = 921
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Unit
        '
        Me.Unit.HeaderText = "Remarks"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'PO
        '
        Me.PO.HeaderText = "Qty"
        Me.PO.Name = "PO"
        Me.PO.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        Me.Seq.Width = 40
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.Gainsboro
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Location = New System.Drawing.Point(235, 52)
        Me.btnItems.Margin = New System.Windows.Forms.Padding(2)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(28, 22)
        Me.btnItems.TabIndex = 3
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.White
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnAddItem.Location = New System.Drawing.Point(173, 228)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(90, 25)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "INSERT"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(8, 146)
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
        Me.txtSTRemarks.Location = New System.Drawing.Point(79, 143)
        Me.txtSTRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSTRemarks.MaxLength = 200
        Me.txtSTRemarks.Multiline = True
        Me.txtSTRemarks.Name = "txtSTRemarks"
        Me.txtSTRemarks.Size = New System.Drawing.Size(184, 53)
        Me.txtSTRemarks.TabIndex = 5
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQty.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtQty.Location = New System.Drawing.Point(79, 109)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(97, 23)
        Me.txtQty.TabIndex = 4
        '
        'dtableStockTaking
        '
        Me.dtableStockTaking.AllowUserToAddRows = False
        Me.dtableStockTaking.AllowUserToDeleteRows = False
        Me.dtableStockTaking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableStockTaking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableStockTaking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.PO, Me.Unit})
        Me.dtableStockTaking.Location = New System.Drawing.Point(271, 23)
        Me.dtableStockTaking.Margin = New System.Windows.Forms.Padding(2)
        Me.dtableStockTaking.Name = "dtableStockTaking"
        Me.dtableStockTaking.ReadOnly = True
        Me.dtableStockTaking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableStockTaking.Size = New System.Drawing.Size(486, 236)
        Me.dtableStockTaking.TabIndex = 69
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
        Me.GroupBox1.Controls.Add(Me.dtableStockTaking)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 82)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(762, 262)
        Me.GroupBox1.TabIndex = 928
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Taking Details"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(6, 228)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 25)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "SCAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtItemName.Location = New System.Drawing.Point(8, 80)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(256, 23)
        Me.txtItemName.TabIndex = 65
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(8, 55)
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
        Me.Label11.Location = New System.Drawing.Point(8, 112)
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
        Me.txtItemCode.Location = New System.Drawing.Point(79, 52)
        Me.txtItemCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCode.MaxLength = 20
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(181, 23)
        Me.txtItemCode.TabIndex = 2
        '
        'txtEncodedStaff
        '
        Me.txtEncodedStaff.Enabled = False
        Me.txtEncodedStaff.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtEncodedStaff.Location = New System.Drawing.Point(403, 42)
        Me.txtEncodedStaff.Name = "txtEncodedStaff"
        Me.txtEncodedStaff.Size = New System.Drawing.Size(217, 23)
        Me.txtEncodedStaff.TabIndex = 927
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(304, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 926
        Me.Label3.Text = "Encoded Staff:"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(403, 14)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(300, 23)
        Me.txtRemarks.TabIndex = 931
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(305, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 925
        Me.Label2.Text = "Remaks:"
        '
        'chkApprove
        '
        Me.chkApprove.AutoSize = True
        Me.chkApprove.Enabled = False
        Me.chkApprove.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.chkApprove.Location = New System.Drawing.Point(624, 44)
        Me.chkApprove.Margin = New System.Windows.Forms.Padding(2)
        Me.chkApprove.Name = "chkApprove"
        Me.chkApprove.Size = New System.Drawing.Size(80, 20)
        Me.chkApprove.TabIndex = 929
        Me.chkApprove.Text = "Approve"
        Me.chkApprove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 924
        Me.Label1.Text = "*Return Date:"
        '
        'txtStockTakingID
        '
        Me.txtStockTakingID.Enabled = False
        Me.txtStockTakingID.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtStockTakingID.Location = New System.Drawing.Point(112, 14)
        Me.txtStockTakingID.Name = "txtStockTakingID"
        Me.txtStockTakingID.Size = New System.Drawing.Size(177, 23)
        Me.txtStockTakingID.TabIndex = 923
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(13, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 922
        Me.Label7.Text = "Return ID:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(583, 352)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 25)
        Me.Button2.TabIndex = 932
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmRejectReturnEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 382)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtCountedDate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEncodedStaff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkApprove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStockTakingID)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Name = "FrmRejectReturnEntry"
        Me.Text = "FrmRejectReturnEntry"
        CType(Me.dtableStockTaking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents dtCountedDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents PO As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents btnItems As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSTRemarks As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents dtableStockTaking As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtEncodedStaff As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkApprove As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStockTakingID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
