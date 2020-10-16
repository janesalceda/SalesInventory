<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPurchaseOrder
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtIssued = New System.Windows.Forms.DateTimePicker()
        Me.cmbTDelivery = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTPayment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbDeliveryPlace = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSupUnit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSupQty = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtETA = New System.Windows.Forms.DateTimePicker()
        Me.dtETD = New System.Windows.Forms.DateTimePicker()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.DTFtry = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkReceived = New System.Windows.Forms.CheckBox()
        Me.chkCancel = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtCliUnit = New System.Windows.Forms.TextBox()
        Me.txtCliQty = New System.Windows.Forms.TextBox()
        Me.dtablePoDetails = New System.Windows.Forms.DataGridView()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientQUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FTRY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Rec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chkcancelPO = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtablePoDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(365, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "*Issued Date:"
        '
        'txtPONo
        '
        Me.txtPONo.Enabled = False
        Me.txtPONo.Location = New System.Drawing.Point(82, 12)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(277, 27)
        Me.txtPONo.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "PO No:"
        '
        'btnSupplier
        '
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Location = New System.Drawing.Point(327, 45)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(32, 27)
        Me.btnSupplier.TabIndex = 41
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(82, 45)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(277, 27)
        Me.txtSupplier.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "*Supplier:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(14, 79)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(345, 27)
        Me.txtSupplierName.TabIndex = 43
        '
        'txtCurrency
        '
        Me.txtCurrency.Enabled = False
        Me.txtCurrency.Location = New System.Drawing.Point(86, 112)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(273, 27)
        Me.txtCurrency.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Currency:"
        '
        'dtIssued
        '
        Me.dtIssued.Checked = False
        Me.dtIssued.Location = New System.Drawing.Point(498, 12)
        Me.dtIssued.Name = "dtIssued"
        Me.dtIssued.ShowCheckBox = True
        Me.dtIssued.Size = New System.Drawing.Size(221, 27)
        Me.dtIssued.TabIndex = 46
        '
        'cmbTDelivery
        '
        Me.cmbTDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTDelivery.FormattingEnabled = True
        Me.cmbTDelivery.Location = New System.Drawing.Point(498, 45)
        Me.cmbTDelivery.Name = "cmbTDelivery"
        Me.cmbTDelivery.Size = New System.Drawing.Size(221, 27)
        Me.cmbTDelivery.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Terms of Delivery:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Terms of Payment:"
        '
        'cmbTPayment
        '
        Me.cmbTPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTPayment.FormattingEnabled = True
        Me.cmbTPayment.Location = New System.Drawing.Point(498, 78)
        Me.cmbTPayment.Name = "cmbTPayment"
        Me.cmbTPayment.Size = New System.Drawing.Size(221, 27)
        Me.cmbTPayment.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(365, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 19)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "*Delivery Place:"
        '
        'cmbDeliveryPlace
        '
        Me.cmbDeliveryPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeliveryPlace.FormattingEnabled = True
        Me.cmbDeliveryPlace.Location = New System.Drawing.Point(498, 111)
        Me.cmbDeliveryPlace.Name = "cmbDeliveryPlace"
        Me.cmbDeliveryPlace.Size = New System.Drawing.Size(221, 27)
        Me.cmbDeliveryPlace.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(737, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Total Amount:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(842, 111)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(156, 27)
        Me.txtTotalAmount.TabIndex = 54
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(843, 12)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(232, 60)
        Me.txtRemarks.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(737, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Remarks:"
        '
        'txtStaffName
        '
        Me.txtStaffName.Enabled = False
        Me.txtStaffName.Location = New System.Drawing.Point(842, 78)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(233, 27)
        Me.txtStaffName.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(737, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 19)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Encoded Staff:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(974, 644)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 32)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSupUnit
        '
        Me.txtSupUnit.Enabled = False
        Me.txtSupUnit.Location = New System.Drawing.Point(253, 122)
        Me.txtSupUnit.Name = "txtSupUnit"
        Me.txtSupUnit.Size = New System.Drawing.Size(46, 27)
        Me.txtSupUnit.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 19)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "*Qty:"
        '
        'txtSupQty
        '
        Me.txtSupQty.Location = New System.Drawing.Point(200, 122)
        Me.txtSupQty.Name = "txtSupQty"
        Me.txtSupQty.Size = New System.Drawing.Size(46, 27)
        Me.txtSupQty.TabIndex = 66
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(6, 89)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(293, 27)
        Me.txtItemName.TabIndex = 65
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(98, 56)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(201, 27)
        Me.txtItemCode.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 19)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "*Item"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.dtETA)
        Me.GroupBox1.Controls.Add(Me.dtETD)
        Me.GroupBox1.Controls.Add(Me.btnItems)
        Me.GroupBox1.Controls.Add(Me.btnAddItem)
        Me.GroupBox1.Controls.Add(Me.DTFtry)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.chkReceived)
        Me.GroupBox1.Controls.Add(Me.chkCancel)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtUnit)
        Me.GroupBox1.Controls.Add(Me.txtCliUnit)
        Me.GroupBox1.Controls.Add(Me.txtCliQty)
        Me.GroupBox1.Controls.Add(Me.dtablePoDetails)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.txtSupUnit)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.txtSupQty)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(14, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 488)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(308, 464)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(219, 19)
        Me.Label18.TabIndex = 92
        Me.Label18.Text = "*NOTE: CLICK ROW TO UPDATE"
        '
        'dtETA
        '
        Me.dtETA.Checked = False
        Me.dtETA.Location = New System.Drawing.Point(98, 254)
        Me.dtETA.Name = "dtETA"
        Me.dtETA.ShowCheckBox = True
        Me.dtETA.Size = New System.Drawing.Size(201, 27)
        Me.dtETA.TabIndex = 89
        Me.dtETA.Value = New Date(2020, 10, 14, 21, 28, 4, 0)
        '
        'dtETD
        '
        Me.dtETD.Checked = False
        Me.dtETD.Location = New System.Drawing.Point(98, 221)
        Me.dtETD.Name = "dtETD"
        Me.dtETD.ShowCheckBox = True
        Me.dtETD.Size = New System.Drawing.Size(201, 27)
        Me.dtETD.TabIndex = 88
        Me.dtETD.Value = New Date(2020, 10, 14, 21, 28, 4, 0)
        '
        'btnItems
        '
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Location = New System.Drawing.Point(267, 56)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(32, 27)
        Me.btnItems.TabIndex = 87
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Enabled = False
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Location = New System.Drawing.Point(196, 364)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(103, 32)
        Me.btnAddItem.TabIndex = 86
        Me.btnAddItem.Text = "INSERT ITEM"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'DTFtry
        '
        Me.DTFtry.Checked = False
        Me.DTFtry.Location = New System.Drawing.Point(98, 287)
        Me.DTFtry.Name = "DTFtry"
        Me.DTFtry.ShowCheckBox = True
        Me.DTFtry.Size = New System.Drawing.Size(201, 27)
        Me.DTFtry.TabIndex = 85
        Me.DTFtry.Value = New Date(2020, 10, 14, 21, 28, 4, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 293)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 19)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "*FTRY:"
        '
        'chkReceived
        '
        Me.chkReceived.AutoSize = True
        Me.chkReceived.Enabled = False
        Me.chkReceived.Location = New System.Drawing.Point(202, 325)
        Me.chkReceived.Name = "chkReceived"
        Me.chkReceived.Size = New System.Drawing.Size(87, 23)
        Me.chkReceived.TabIndex = 83
        Me.chkReceived.Text = "Received"
        Me.chkReceived.UseVisualStyleBackColor = True
        '
        'chkCancel
        '
        Me.chkCancel.AutoSize = True
        Me.chkCancel.Enabled = False
        Me.chkCancel.Location = New System.Drawing.Point(98, 325)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.Size = New System.Drawing.Size(72, 23)
        Me.chkCancel.TabIndex = 82
        Me.chkCancel.Text = "Cancel"
        Me.chkCancel.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 19)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "*ETA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 227)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 19)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "*ETD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 19)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "TotalPrice"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(98, 188)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(201, 27)
        Me.txtTotalPrice.TabIndex = 75
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 19)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Unit Price:"
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.Location = New System.Drawing.Point(98, 155)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(201, 27)
        Me.txtUnit.TabIndex = 73
        '
        'txtCliUnit
        '
        Me.txtCliUnit.Enabled = False
        Me.txtCliUnit.Location = New System.Drawing.Point(149, 122)
        Me.txtCliUnit.Name = "txtCliUnit"
        Me.txtCliUnit.Size = New System.Drawing.Size(46, 27)
        Me.txtCliUnit.TabIndex = 71
        '
        'txtCliQty
        '
        Me.txtCliQty.Location = New System.Drawing.Point(98, 122)
        Me.txtCliQty.Name = "txtCliQty"
        Me.txtCliQty.Size = New System.Drawing.Size(46, 27)
        Me.txtCliQty.TabIndex = 70
        '
        'dtablePoDetails
        '
        Me.dtablePoDetails.AllowUserToAddRows = False
        Me.dtablePoDetails.AllowUserToDeleteRows = False
        Me.dtablePoDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtablePoDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtablePoDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.ClientQUnit, Me.ClientQty, Me.PO, Me.Unit, Me.UnitPrice, Me.TotalPrice, Me.ETD, Me.ETA, Me.FTRY, Me.Cancel, Me.Rec})
        Me.dtablePoDetails.Location = New System.Drawing.Point(310, 15)
        Me.dtablePoDetails.Name = "dtablePoDetails"
        Me.dtablePoDetails.ReadOnly = True
        Me.dtablePoDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtablePoDetails.Size = New System.Drawing.Size(751, 445)
        Me.dtablePoDetails.TabIndex = 69
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        Me.Seq.Width = 40
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'ClientQUnit
        '
        Me.ClientQUnit.HeaderText = "ClientQty"
        Me.ClientQUnit.Name = "ClientQUnit"
        Me.ClientQUnit.ReadOnly = True
        '
        'ClientQty
        '
        Me.ClientQty.HeaderText = "Unit"
        Me.ClientQty.Name = "ClientQty"
        Me.ClientQty.ReadOnly = True
        '
        'PO
        '
        Me.PO.HeaderText = "SupplierQty"
        Me.PO.Name = "PO"
        Me.PO.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "TotalPrice"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        '
        'ETD
        '
        Me.ETD.HeaderText = "ETD"
        Me.ETD.Name = "ETD"
        Me.ETD.ReadOnly = True
        '
        'ETA
        '
        Me.ETA.HeaderText = "ETA"
        Me.ETA.Name = "ETA"
        Me.ETA.ReadOnly = True
        '
        'FTRY
        '
        Me.FTRY.HeaderText = "FTRY"
        Me.FTRY.Name = "FTRY"
        Me.FTRY.ReadOnly = True
        '
        'Cancel
        '
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ReadOnly = True
        Me.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Rec
        '
        Me.Rec.HeaderText = "Rec"
        Me.Rec.Name = "Rec"
        Me.Rec.ReadOnly = True
        Me.Rec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'chkcancelPO
        '
        Me.chkcancelPO.AutoSize = True
        Me.chkcancelPO.Enabled = False
        Me.chkcancelPO.Location = New System.Drawing.Point(1002, 114)
        Me.chkcancelPO.Name = "chkcancelPO"
        Me.chkcancelPO.Size = New System.Drawing.Size(72, 23)
        Me.chkcancelPO.TabIndex = 91
        Me.chkcancelPO.Text = "Cancel"
        Me.chkcancelPO.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(6, 658)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(217, 19)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "*NOTE: ALL * ARE IMPORTANT"
        '
        'AddPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 681)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.chkcancelPO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbDeliveryPlace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTPayment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtIssued)
        Me.Controls.Add(Me.txtCurrency)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTDelivery)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPONo)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddPurchaseOrder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtablePoDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPONo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSupplier As Button
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents txtCurrency As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtIssued As DateTimePicker
    Friend WithEvents cmbTDelivery As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTPayment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbDeliveryPlace As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSupUnit As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSupQty As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtCliUnit As TextBox
    Friend WithEvents txtCliQty As TextBox
    Friend WithEvents dtablePoDetails As DataGridView
    Friend WithEvents btnItems As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents DTFtry As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents chkReceived As CheckBox
    Friend WithEvents chkCancel As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dtETA As DateTimePicker
    Friend WithEvents dtETD As DateTimePicker
    Friend WithEvents chkcancelPO As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ClientQUnit As DataGridViewTextBoxColumn
    Friend WithEvents ClientQty As DataGridViewTextBoxColumn
    Friend WithEvents PO As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents ETD As DataGridViewTextBoxColumn
    Friend WithEvents ETA As DataGridViewTextBoxColumn
    Friend WithEvents FTRY As DataGridViewTextBoxColumn
    Friend WithEvents Cancel As DataGridViewCheckBoxColumn
    Friend WithEvents Rec As DataGridViewCheckBoxColumn
    Friend WithEvents Label19 As Label
End Class
