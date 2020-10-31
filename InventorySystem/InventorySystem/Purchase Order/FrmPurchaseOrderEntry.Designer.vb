<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPurchaseOrderEntry
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
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
        Me.SupplierUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FTRY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Rec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RecAdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkcancelPO = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtablePoDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(327, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "*Issued Date:"
        '
        'txtPONo
        '
        Me.txtPONo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtPONo.Location = New System.Drawing.Point(79, 10)
        Me.txtPONo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(243, 23)
        Me.txtPONo.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(9, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "PO No:"
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSupplier.Location = New System.Drawing.Point(294, 35)
        Me.btnSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(28, 23)
        Me.btnSupplier.TabIndex = 41
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightBlue
        Me.txtSupplier.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupplier.Location = New System.Drawing.Point(79, 35)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupplier.MaxLength = 25
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(243, 23)
        Me.txtSupplier.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "*Supplier:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupplierName.Location = New System.Drawing.Point(8, 62)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(314, 23)
        Me.txtSupplierName.TabIndex = 43
        '
        'txtCurrency
        '
        Me.txtCurrency.Enabled = False
        Me.txtCurrency.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCurrency.Location = New System.Drawing.Point(82, 88)
        Me.txtCurrency.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(240, 23)
        Me.txtCurrency.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Currency:"
        '
        'dtIssued
        '
        Me.dtIssued.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtIssued.Checked = False
        Me.dtIssued.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtIssued.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIssued.Location = New System.Drawing.Point(453, 10)
        Me.dtIssued.Margin = New System.Windows.Forms.Padding(2)
        Me.dtIssued.Name = "dtIssued"
        Me.dtIssued.Size = New System.Drawing.Size(194, 23)
        Me.dtIssued.TabIndex = 46
        '
        'cmbTDelivery
        '
        Me.cmbTDelivery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTDelivery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTDelivery.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbTDelivery.FormattingEnabled = True
        Me.cmbTDelivery.Location = New System.Drawing.Point(453, 35)
        Me.cmbTDelivery.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTDelivery.Name = "cmbTDelivery"
        Me.cmbTDelivery.Size = New System.Drawing.Size(194, 24)
        Me.cmbTDelivery.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(327, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Terms of Delivery:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(327, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Terms of Payment:"
        '
        'cmbTPayment
        '
        Me.cmbTPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTPayment.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbTPayment.FormattingEnabled = True
        Me.cmbTPayment.Location = New System.Drawing.Point(453, 62)
        Me.cmbTPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTPayment.Name = "cmbTPayment"
        Me.cmbTPayment.Size = New System.Drawing.Size(194, 24)
        Me.cmbTPayment.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(327, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "*Delivery Place:"
        '
        'cmbDeliveryPlace
        '
        Me.cmbDeliveryPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDeliveryPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDeliveryPlace.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbDeliveryPlace.FormattingEnabled = True
        Me.cmbDeliveryPlace.Location = New System.Drawing.Point(453, 89)
        Me.cmbDeliveryPlace.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDeliveryPlace.Name = "cmbDeliveryPlace"
        Me.cmbDeliveryPlace.Size = New System.Drawing.Size(194, 24)
        Me.cmbDeliveryPlace.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(654, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Total Amount:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtTotalAmount.Location = New System.Drawing.Point(754, 87)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(137, 23)
        Me.txtTotalAmount.TabIndex = 54
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(756, 10)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(203, 48)
        Me.txtRemarks.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(654, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Remarks:"
        '
        'txtStaffName
        '
        Me.txtStaffName.Enabled = False
        Me.txtStaffName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtStaffName.Location = New System.Drawing.Point(754, 62)
        Me.txtStaffName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(204, 23)
        Me.txtStaffName.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(654, 63)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Encoded Staff:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(873, 508)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 26)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "SAVE P.O."
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtSupUnit
        '
        Me.txtSupUnit.Enabled = False
        Me.txtSupUnit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupUnit.Location = New System.Drawing.Point(222, 96)
        Me.txtSupUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupUnit.Name = "txtSupUnit"
        Me.txtSupUnit.Size = New System.Drawing.Size(41, 23)
        Me.txtSupUnit.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(5, 99)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "*Qty:"
        '
        'txtSupQty
        '
        Me.txtSupQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupQty.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupQty.Location = New System.Drawing.Point(175, 96)
        Me.txtSupQty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSupQty.MaxLength = 18
        Me.txtSupQty.Name = "txtSupQty"
        Me.txtSupQty.Size = New System.Drawing.Size(41, 23)
        Me.txtSupQty.TabIndex = 66
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtItemName.Location = New System.Drawing.Point(5, 71)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(257, 23)
        Me.txtItemName.TabIndex = 65
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.LightBlue
        Me.txtItemCode.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtItemCode.Location = New System.Drawing.Point(86, 44)
        Me.txtItemCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCode.MaxLength = 20
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(177, 23)
        Me.txtItemCode.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(5, 47)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "*Item"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnClear)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(954, 390)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Details"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnDelete.Location = New System.Drawing.Point(144, 320)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 26)
        Me.btnDelete.TabIndex = 177
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnClear.Location = New System.Drawing.Point(144, 290)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 26)
        Me.btnClear.TabIndex = 93
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(269, 368)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(219, 19)
        Me.Label18.TabIndex = 92
        Me.Label18.Text = "*NOTE: CLICK ROW TO UPDATE"
        '
        'dtETA
        '
        Me.dtETA.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtETA.Checked = False
        Me.dtETA.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtETA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtETA.Location = New System.Drawing.Point(86, 200)
        Me.dtETA.Margin = New System.Windows.Forms.Padding(2)
        Me.dtETA.Name = "dtETA"
        Me.dtETA.Size = New System.Drawing.Size(177, 23)
        Me.dtETA.TabIndex = 89
        Me.dtETA.Value = New Date(2020, 10, 21, 12, 15, 39, 0)
        '
        'dtETD
        '
        Me.dtETD.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtETD.Checked = False
        Me.dtETD.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtETD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtETD.Location = New System.Drawing.Point(86, 175)
        Me.dtETD.Margin = New System.Windows.Forms.Padding(2)
        Me.dtETD.Name = "dtETD"
        Me.dtETD.Size = New System.Drawing.Size(177, 23)
        Me.dtETD.TabIndex = 88
        Me.dtETD.Value = New Date(2020, 10, 21, 12, 15, 39, 0)
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.Gainsboro
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnItems.Location = New System.Drawing.Point(236, 44)
        Me.btnItems.Margin = New System.Windows.Forms.Padding(2)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(28, 23)
        Me.btnItems.TabIndex = 87
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddItem.Enabled = False
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnAddItem.Location = New System.Drawing.Point(18, 290)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(124, 26)
        Me.btnAddItem.TabIndex = 86
        Me.btnAddItem.Text = "INSERT ITEM"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'DTFtry
        '
        Me.DTFtry.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTFtry.Checked = False
        Me.DTFtry.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.DTFtry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFtry.Location = New System.Drawing.Point(86, 227)
        Me.DTFtry.Margin = New System.Windows.Forms.Padding(2)
        Me.DTFtry.Name = "DTFtry"
        Me.DTFtry.Size = New System.Drawing.Size(177, 23)
        Me.DTFtry.TabIndex = 85
        Me.DTFtry.Value = New Date(2020, 10, 21, 12, 15, 39, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(5, 231)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 16)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "*FTRY:"
        '
        'chkReceived
        '
        Me.chkReceived.AutoSize = True
        Me.chkReceived.Enabled = False
        Me.chkReceived.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.chkReceived.Location = New System.Drawing.Point(177, 257)
        Me.chkReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.chkReceived.Name = "chkReceived"
        Me.chkReceived.Size = New System.Drawing.Size(86, 20)
        Me.chkReceived.TabIndex = 83
        Me.chkReceived.Text = "Received"
        Me.chkReceived.UseVisualStyleBackColor = True
        '
        'chkCancel
        '
        Me.chkCancel.AutoSize = True
        Me.chkCancel.Enabled = False
        Me.chkCancel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.chkCancel.Location = New System.Drawing.Point(86, 257)
        Me.chkCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.Size = New System.Drawing.Size(71, 20)
        Me.chkCancel.TabIndex = 82
        Me.chkCancel.Text = "Cancel"
        Me.chkCancel.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(5, 206)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 16)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "*ETA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(5, 179)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 16)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "*ETD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(5, 151)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "TotalPrice"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtTotalPrice.Location = New System.Drawing.Point(86, 148)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(177, 23)
        Me.txtTotalPrice.TabIndex = 75
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(5, 124)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Unit Price:"
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtUnit.Location = New System.Drawing.Point(86, 122)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(177, 23)
        Me.txtUnit.TabIndex = 73
        '
        'txtCliUnit
        '
        Me.txtCliUnit.Enabled = False
        Me.txtCliUnit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCliUnit.Location = New System.Drawing.Point(131, 96)
        Me.txtCliUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCliUnit.Name = "txtCliUnit"
        Me.txtCliUnit.Size = New System.Drawing.Size(41, 23)
        Me.txtCliUnit.TabIndex = 71
        '
        'txtCliQty
        '
        Me.txtCliQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliQty.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCliQty.Location = New System.Drawing.Point(86, 96)
        Me.txtCliQty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCliQty.MaxLength = 18
        Me.txtCliQty.Name = "txtCliQty"
        Me.txtCliQty.Size = New System.Drawing.Size(41, 23)
        Me.txtCliQty.TabIndex = 70
        '
        'dtablePoDetails
        '
        Me.dtablePoDetails.AllowUserToAddRows = False
        Me.dtablePoDetails.AllowUserToDeleteRows = False
        Me.dtablePoDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtablePoDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtablePoDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtablePoDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtablePoDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.ClientQUnit, Me.ClientQty, Me.PO, Me.Unit, Me.SupplierUnitPrice, Me.TotalPrice, Me.ETD, Me.ETA, Me.FTRY, Me.Cancel, Me.Rec, Me.RecAdd, Me.InvQty, Me.ClientUnitPrice})
        Me.dtablePoDetails.Location = New System.Drawing.Point(270, 20)
        Me.dtablePoDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.dtablePoDetails.Name = "dtablePoDetails"
        Me.dtablePoDetails.ReadOnly = True
        Me.dtablePoDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtablePoDetails.Size = New System.Drawing.Size(678, 344)
        Me.dtablePoDetails.TabIndex = 69
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        Me.Seq.Width = 56
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Width = 57
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 102
        '
        'ClientQUnit
        '
        Me.ClientQUnit.HeaderText = "ClientQty"
        Me.ClientQUnit.Name = "ClientQUnit"
        Me.ClientQUnit.ReadOnly = True
        Me.ClientQUnit.Width = 89
        '
        'ClientQty
        '
        Me.ClientQty.HeaderText = "Unit"
        Me.ClientQty.Name = "ClientQty"
        Me.ClientQty.ReadOnly = True
        Me.ClientQty.Width = 55
        '
        'PO
        '
        Me.PO.HeaderText = "SupplierQty"
        Me.PO.Name = "PO"
        Me.PO.ReadOnly = True
        Me.PO.Width = 105
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.Width = 55
        '
        'SupplierUnitPrice
        '
        Me.SupplierUnitPrice.HeaderText = "Unit Price"
        Me.SupplierUnitPrice.Name = "SupplierUnitPrice"
        Me.SupplierUnitPrice.ReadOnly = True
        Me.SupplierUnitPrice.Width = 91
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "TotalPrice"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Width = 93
        '
        'ETD
        '
        Me.ETD.HeaderText = "ETD"
        Me.ETD.Name = "ETD"
        Me.ETD.ReadOnly = True
        Me.ETD.Width = 59
        '
        'ETA
        '
        Me.ETA.HeaderText = "ETA"
        Me.ETA.Name = "ETA"
        Me.ETA.ReadOnly = True
        Me.ETA.Width = 57
        '
        'FTRY
        '
        Me.FTRY.HeaderText = "FTRY"
        Me.FTRY.Name = "FTRY"
        Me.FTRY.ReadOnly = True
        Me.FTRY.Width = 68
        '
        'Cancel
        '
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ReadOnly = True
        Me.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Cancel.Width = 75
        '
        'Rec
        '
        Me.Rec.HeaderText = "Rec"
        Me.Rec.Name = "Rec"
        Me.Rec.ReadOnly = True
        Me.Rec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Rec.Width = 56
        '
        'RecAdd
        '
        Me.RecAdd.HeaderText = "RecAdd"
        Me.RecAdd.Name = "RecAdd"
        Me.RecAdd.ReadOnly = True
        Me.RecAdd.Visible = False
        Me.RecAdd.Width = 73
        '
        'InvQty
        '
        Me.InvQty.HeaderText = "Invoice Qty"
        Me.InvQty.Name = "InvQty"
        Me.InvQty.ReadOnly = True
        Me.InvQty.Width = 101
        '
        'ClientUnitPrice
        '
        Me.ClientUnitPrice.HeaderText = "ClientUnitPrice"
        Me.ClientUnitPrice.Name = "ClientUnitPrice"
        Me.ClientUnitPrice.ReadOnly = True
        Me.ClientUnitPrice.Visible = False
        Me.ClientUnitPrice.Width = 112
        '
        'chkcancelPO
        '
        Me.chkcancelPO.AutoSize = True
        Me.chkcancelPO.Enabled = False
        Me.chkcancelPO.Location = New System.Drawing.Point(894, 90)
        Me.chkcancelPO.Margin = New System.Windows.Forms.Padding(2)
        Me.chkcancelPO.Name = "chkcancelPO"
        Me.chkcancelPO.Size = New System.Drawing.Size(65, 19)
        Me.chkcancelPO.TabIndex = 91
        Me.chkcancelPO.Text = "Cancel"
        Me.chkcancelPO.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(5, 516)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(217, 19)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "*NOTE: ALL * ARE IMPORTANT"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(780, 508)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 26)
        Me.Button1.TabIndex = 128
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'FrmPurchaseOrderEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(970, 537)
        Me.Controls.Add(Me.Button1)
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
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Name = "FrmPurchaseOrderEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PurchaseOrder Entry"
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
    Friend WithEvents Label19 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ClientQUnit As DataGridViewTextBoxColumn
    Friend WithEvents ClientQty As DataGridViewTextBoxColumn
    Friend WithEvents PO As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents SupplierUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents ETD As DataGridViewTextBoxColumn
    Friend WithEvents ETA As DataGridViewTextBoxColumn
    Friend WithEvents FTRY As DataGridViewTextBoxColumn
    Friend WithEvents Cancel As DataGridViewCheckBoxColumn
    Friend WithEvents Rec As DataGridViewCheckBoxColumn
    Friend WithEvents RecAdd As DataGridViewTextBoxColumn
    Friend WithEvents InvQty As DataGridViewTextBoxColumn
    Friend WithEvents ClientUnitPrice As DataGridViewTextBoxColumn
End Class
