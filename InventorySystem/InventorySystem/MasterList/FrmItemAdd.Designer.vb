<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmItemAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtConCoe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMinQty = New System.Windows.Forms.TextBox()
        Me.txtOrderPoint = New System.Windows.Forms.TextBox()
        Me.cmbCliQtyUnit = New System.Windows.Forms.ComboBox()
        Me.cmbSupQtyUnit = New System.Windows.Forms.ComboBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.grpItemDetails = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtItemPrices = New System.Windows.Forms.DataGridView()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppliedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPriceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAddItemPrice = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpItemDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtItemPrices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.White
        Me.txtDes.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtDes.Location = New System.Drawing.Point(124, 75)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(571, 29)
        Me.txtDes.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Description:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(564, 544)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 36)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'txtConCoe
        '
        Me.txtConCoe.BackColor = System.Drawing.Color.White
        Me.txtConCoe.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtConCoe.Location = New System.Drawing.Point(605, 112)
        Me.txtConCoe.Name = "txtConCoe"
        Me.txtConCoe.Size = New System.Drawing.Size(88, 29)
        Me.txtConCoe.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Converting coefficient:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Location:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMax
        '
        Me.txtMax.BackColor = System.Drawing.Color.White
        Me.txtMax.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMax.Location = New System.Drawing.Point(124, 184)
        Me.txtMax.Multiline = True
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(62, 56)
        Me.txtMax.TabIndex = 6
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(124, 246)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(418, 54)
        Me.txtRemarks.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 21)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Remarks:"
        '
        'txtMinQty
        '
        Me.txtMinQty.BackColor = System.Drawing.Color.White
        Me.txtMinQty.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMinQty.Location = New System.Drawing.Point(300, 184)
        Me.txtMinQty.Multiline = True
        Me.txtMinQty.Name = "txtMinQty"
        Me.txtMinQty.Size = New System.Drawing.Size(62, 56)
        Me.txtMinQty.TabIndex = 7
        '
        'txtOrderPoint
        '
        Me.txtOrderPoint.BackColor = System.Drawing.Color.White
        Me.txtOrderPoint.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtOrderPoint.Location = New System.Drawing.Point(480, 186)
        Me.txtOrderPoint.Multiline = True
        Me.txtOrderPoint.Name = "txtOrderPoint"
        Me.txtOrderPoint.Size = New System.Drawing.Size(62, 52)
        Me.txtOrderPoint.TabIndex = 8
        '
        'cmbCliQtyUnit
        '
        Me.cmbCliQtyUnit.BackColor = System.Drawing.Color.White
        Me.cmbCliQtyUnit.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbCliQtyUnit.FormattingEnabled = True
        Me.cmbCliQtyUnit.Location = New System.Drawing.Point(124, 113)
        Me.cmbCliQtyUnit.Name = "cmbCliQtyUnit"
        Me.cmbCliQtyUnit.Size = New System.Drawing.Size(75, 29)
        Me.cmbCliQtyUnit.TabIndex = 2
        '
        'cmbSupQtyUnit
        '
        Me.cmbSupQtyUnit.BackColor = System.Drawing.Color.White
        Me.cmbSupQtyUnit.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbSupQtyUnit.FormattingEnabled = True
        Me.cmbSupQtyUnit.Location = New System.Drawing.Point(352, 113)
        Me.cmbSupQtyUnit.Name = "cmbSupQtyUnit"
        Me.cmbSupQtyUnit.Size = New System.Drawing.Size(75, 29)
        Me.cmbSupQtyUnit.TabIndex = 3
        '
        'cmbLocation
        '
        Me.cmbLocation.BackColor = System.Drawing.Color.White
        Me.cmbLocation.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(123, 148)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(225, 29)
        Me.cmbLocation.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item ID:"
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.Color.White
        Me.txtItemId.Enabled = False
        Me.txtItemId.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtItemId.Location = New System.Drawing.Point(124, 42)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(218, 29)
        Me.txtItemId.TabIndex = 0
        '
        'grpItemDetails
        '
        Me.grpItemDetails.Controls.Add(Me.cmbCategory)
        Me.grpItemDetails.Controls.Add(Me.PictureBox4)
        Me.grpItemDetails.Controls.Add(Me.Label6)
        Me.grpItemDetails.Controls.Add(Me.PictureBox3)
        Me.grpItemDetails.Controls.Add(Me.PictureBox2)
        Me.grpItemDetails.Controls.Add(Me.PictureBox1)
        Me.grpItemDetails.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!)
        Me.grpItemDetails.Location = New System.Drawing.Point(8, 10)
        Me.grpItemDetails.Name = "grpItemDetails"
        Me.grpItemDetails.Size = New System.Drawing.Size(698, 298)
        Me.grpItemDetails.TabIndex = 55
        Me.grpItemDetails.TabStop = False
        Me.grpItemDetails.Text = "Item Details"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Qty Unit:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 25)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Supplier Qty Unit:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 52)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Max Order Qty:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(196, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 52)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Min. Order Qty:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(374, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 52)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Ordering Point:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtItemPrices)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 224)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Item Prices"
        '
        'dtItemPrices
        '
        Me.dtItemPrices.AllowUserToAddRows = False
        Me.dtItemPrices.AllowUserToDeleteRows = False
        Me.dtItemPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtItemPrices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierID, Me.AppliedDate, Me.UnitPrice, Me.ItemPriceID, Me.RegisteredDate, Me.Edit})
        Me.dtItemPrices.Location = New System.Drawing.Point(12, 32)
        Me.dtItemPrices.Name = "dtItemPrices"
        Me.dtItemPrices.ReadOnly = True
        Me.dtItemPrices.Size = New System.Drawing.Size(676, 184)
        Me.dtItemPrices.TabIndex = 10
        '
        'SupplierID
        '
        Me.SupplierID.HeaderText = "SupplierID"
        Me.SupplierID.Name = "SupplierID"
        '
        'AppliedDate
        '
        Me.AppliedDate.HeaderText = "Applied Date"
        Me.AppliedDate.Name = "AppliedDate"
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Width = 120
        '
        'ItemPriceID
        '
        Me.ItemPriceID.HeaderText = "Item Price ID"
        Me.ItemPriceID.Name = "ItemPriceID"
        '
        'RegisteredDate
        '
        Me.RegisteredDate.HeaderText = "Registered Date"
        Me.RegisteredDate.Name = "RegisteredDate"
        Me.RegisteredDate.Width = 150
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Width = 50
        '
        'btnAddItemPrice
        '
        Me.btnAddItemPrice.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAddItemPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddItemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItemPrice.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAddItemPrice.ForeColor = System.Drawing.Color.Black
        Me.btnAddItemPrice.Location = New System.Drawing.Point(8, 544)
        Me.btnAddItemPrice.Name = "btnAddItemPrice"
        Me.btnAddItemPrice.Size = New System.Drawing.Size(192, 36)
        Me.btnAddItemPrice.TabIndex = 11
        Me.btnAddItemPrice.Text = "Add Supplier Item Price"
        Me.btnAddItemPrice.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.InventorySystem.My.Resources.Resources.QRCode
        Me.PictureBox1.Location = New System.Drawing.Point(556, 238)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.InventorySystem.My.Resources.Resources.Barcode
        Me.PictureBox2.Location = New System.Drawing.Point(616, 238)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.InventorySystem.My.Resources.Resources.Print
        Me.PictureBox3.Location = New System.Drawing.Point(638, 262)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.InventorySystem.My.Resources.Resources.Print
        Me.PictureBox4.Location = New System.Drawing.Point(578, 262)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.White
        Me.cmbCategory.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(454, 138)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(230, 29)
        Me.cmbCategory.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Category:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmItemAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 588)
        Me.Controls.Add(Me.btnAddItemPrice)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.cmbSupQtyUnit)
        Me.Controls.Add(Me.cmbCliQtyUnit)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMinQty)
        Me.Controls.Add(Me.txtOrderPoint)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtConCoe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.txtItemId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpItemDetails)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmItemAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Items Entry"
        Me.TopMost = True
        Me.grpItemDetails.ResumeLayout(False)
        Me.grpItemDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtItemPrices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtConCoe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMax As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMinQty As TextBox
    Friend WithEvents txtOrderPoint As TextBox
    Friend WithEvents cmbCliQtyUnit As ComboBox
    Friend WithEvents cmbSupQtyUnit As ComboBox
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents grpItemDetails As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtItemPrices As DataGridView
    Friend WithEvents SupplierID As DataGridViewTextBoxColumn
    Friend WithEvents AppliedDate As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents ItemPriceID As DataGridViewTextBoxColumn
    Friend WithEvents RegisteredDate As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents btnAddItemPrice As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label6 As Label
End Class
