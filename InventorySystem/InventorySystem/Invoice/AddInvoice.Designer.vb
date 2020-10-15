<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInvoice
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.chkcancelPO = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtReceived = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUpdated = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtActualETD = New System.Windows.Forms.DateTimePicker()
        Me.txtEncoded = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Delivery = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtqtyok = New System.Windows.Forms.TextBox()
        Me.txtposeqdel = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtBal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtRec = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.dtableDelivery = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label17 = New System.Windows.Forms.Label()
        Me.txtDeliveryID = New System.Windows.Forms.TextBox()
        Me.btnInsertDel = New System.Windows.Forms.Button()
        Me.btnPOInv = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPoDel = New System.Windows.Forms.TextBox()
        Me.btnItemInv = New System.Windows.Forms.Button()
        Me.txtIteamNameDel = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtItemDel = New System.Windows.Forms.TextBox()
        Me.Invoice = New System.Windows.Forms.TabPage()
        Me.txtPoSeq = New System.Windows.Forms.TextBox()
        Me.dtableInvoice = New System.Windows.Forms.DataGridView()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientQUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ETD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPo = New System.Windows.Forms.Button()
        Me.txtInvoiceRemarks = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPo = New System.Windows.Forms.TextBox()
        Me.btnUpdateItems = New System.Windows.Forms.Button()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.chkReceived = New System.Windows.Forms.CheckBox()
        Me.chkCancel = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtCliUnit = New System.Windows.Forms.TextBox()
        Me.txtCliQty = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtSupUnit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtSupQty = New System.Windows.Forms.TextBox()
        Me.dtDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Delivery.SuspendLayout()
        CType(Me.dtableDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Invoice.SuspendLayout()
        CType(Me.dtableInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(870, 606)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 32)
        Me.btnSave.TabIndex = 116
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtStaffName
        '
        Me.txtStaffName.Enabled = False
        Me.txtStaffName.Location = New System.Drawing.Point(853, 78)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(230, 27)
        Me.txtStaffName.TabIndex = 114
        '
        'chkcancelPO
        '
        Me.chkcancelPO.AutoSize = True
        Me.chkcancelPO.Location = New System.Drawing.Point(16, 612)
        Me.chkcancelPO.Name = "chkcancelPO"
        Me.chkcancelPO.Size = New System.Drawing.Size(72, 23)
        Me.chkcancelPO.TabIndex = 118
        Me.chkcancelPO.Text = "Cancel"
        Me.chkcancelPO.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(739, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 19)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Encoded By:"
        '
        'DtInvoiceDate
        '
        Me.DtInvoiceDate.Location = New System.Drawing.Point(512, 12)
        Me.DtInvoiceDate.Name = "DtInvoiceDate"
        Me.DtInvoiceDate.Size = New System.Drawing.Size(221, 27)
        Me.DtInvoiceDate.TabIndex = 103
        '
        'txtCurrency
        '
        Me.txtCurrency.Enabled = False
        Me.txtCurrency.Location = New System.Drawing.Point(143, 78)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(262, 27)
        Me.txtCurrency.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Currency:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(328, 45)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(405, 27)
        Me.txtSupplierName.TabIndex = 100
        '
        'btnSupplier
        '
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Location = New System.Drawing.Point(290, 45)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(32, 27)
        Me.btnSupplier.TabIndex = 99
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(143, 45)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(179, 27)
        Me.txtSupplier.TabIndex = 98
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(979, 606)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 32)
        Me.btnCancel.TabIndex = 96
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(418, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Invoice Date:"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(143, 12)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(262, 27)
        Me.txtInvoiceNo.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "*Invoice No:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(852, 45)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(230, 27)
        Me.txtRemarks.TabIndex = 112
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(527, 78)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(206, 27)
        Me.txtTotalAmount.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(418, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Total Amount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(739, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Remarks:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "*Supplier:"
        '
        'dtReceived
        '
        Me.dtReceived.Location = New System.Drawing.Point(852, 12)
        Me.dtReceived.Name = "dtReceived"
        Me.dtReceived.Size = New System.Drawing.Size(230, 27)
        Me.dtReceived.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(739, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Received Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "*Actual ETD Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Encoded Date:"
        '
        'txtUpdated
        '
        Me.txtUpdated.Enabled = False
        Me.txtUpdated.Location = New System.Drawing.Point(853, 111)
        Me.txtUpdated.Name = "txtUpdated"
        Me.txtUpdated.Size = New System.Drawing.Size(230, 27)
        Me.txtUpdated.TabIndex = 126
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(739, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 19)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Updated Date:"
        '
        'dtActualETD
        '
        Me.dtActualETD.Location = New System.Drawing.Point(143, 111)
        Me.dtActualETD.Name = "dtActualETD"
        Me.dtActualETD.Size = New System.Drawing.Size(262, 27)
        Me.dtActualETD.TabIndex = 127
        '
        'txtEncoded
        '
        Me.txtEncoded.Enabled = False
        Me.txtEncoded.Location = New System.Drawing.Point(527, 111)
        Me.txtEncoded.Name = "txtEncoded"
        Me.txtEncoded.Size = New System.Drawing.Size(206, 27)
        Me.txtEncoded.TabIndex = 128
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Delivery)
        Me.TabControl1.Controls.Add(Me.Invoice)
        Me.TabControl1.Location = New System.Drawing.Point(12, 150)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1075, 456)
        Me.TabControl1.TabIndex = 116
        '
        'Delivery
        '
        Me.Delivery.Controls.Add(Me.dtDeliveryDate)
        Me.Delivery.Controls.Add(Me.Label21)
        Me.Delivery.Controls.Add(Me.Label27)
        Me.Delivery.Controls.Add(Me.Label26)
        Me.Delivery.Controls.Add(Me.txtqtyok)
        Me.Delivery.Controls.Add(Me.txtposeqdel)
        Me.Delivery.Controls.Add(Me.Label25)
        Me.Delivery.Controls.Add(Me.txtBal)
        Me.Delivery.Controls.Add(Me.Label23)
        Me.Delivery.Controls.Add(Me.txtRec)
        Me.Delivery.Controls.Add(Me.Label22)
        Me.Delivery.Controls.Add(Me.txtExp)
        Me.Delivery.Controls.Add(Me.dtableDelivery)
        Me.Delivery.Controls.Add(Me.label17)
        Me.Delivery.Controls.Add(Me.txtDeliveryID)
        Me.Delivery.Controls.Add(Me.btnInsertDel)
        Me.Delivery.Controls.Add(Me.btnPOInv)
        Me.Delivery.Controls.Add(Me.Label20)
        Me.Delivery.Controls.Add(Me.txtPoDel)
        Me.Delivery.Controls.Add(Me.btnItemInv)
        Me.Delivery.Controls.Add(Me.txtIteamNameDel)
        Me.Delivery.Controls.Add(Me.Label24)
        Me.Delivery.Controls.Add(Me.txtItemDel)
        Me.Delivery.Location = New System.Drawing.Point(4, 28)
        Me.Delivery.Name = "Delivery"
        Me.Delivery.Padding = New System.Windows.Forms.Padding(3)
        Me.Delivery.Size = New System.Drawing.Size(1067, 424)
        Me.Delivery.TabIndex = 0
        Me.Delivery.Text = "Delivery Details"
        Me.Delivery.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(303, 396)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(178, 19)
        Me.Label27.TabIndex = 129
        Me.Label27.Text = "*NOTE: CLICK TO UPDATE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 240)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 19)
        Me.Label26.TabIndex = 198
        Me.Label26.Text = "Qty OK:"
        '
        'txtqtyok
        '
        Me.txtqtyok.Enabled = False
        Me.txtqtyok.Location = New System.Drawing.Point(110, 237)
        Me.txtqtyok.Name = "txtqtyok"
        Me.txtqtyok.Size = New System.Drawing.Size(191, 27)
        Me.txtqtyok.TabIndex = 199
        '
        'txtposeqdel
        '
        Me.txtposeqdel.Enabled = False
        Me.txtposeqdel.Location = New System.Drawing.Point(239, 139)
        Me.txtposeqdel.Name = "txtposeqdel"
        Me.txtposeqdel.Size = New System.Drawing.Size(62, 27)
        Me.txtposeqdel.TabIndex = 197
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 276)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(92, 19)
        Me.Label25.TabIndex = 195
        Me.Label25.Text = "Qty Balance:"
        '
        'txtBal
        '
        Me.txtBal.Enabled = False
        Me.txtBal.Location = New System.Drawing.Point(110, 273)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(191, 27)
        Me.txtBal.TabIndex = 196
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 207)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 19)
        Me.Label23.TabIndex = 193
        Me.Label23.Text = "*Qty Received:"
        '
        'txtRec
        '
        Me.txtRec.Location = New System.Drawing.Point(110, 203)
        Me.txtRec.Name = "txtRec"
        Me.txtRec.Size = New System.Drawing.Size(191, 27)
        Me.txtRec.TabIndex = 194
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 19)
        Me.Label22.TabIndex = 191
        Me.Label22.Text = "Qty Expected:"
        '
        'txtExp
        '
        Me.txtExp.Enabled = False
        Me.txtExp.Location = New System.Drawing.Point(110, 171)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(191, 27)
        Me.txtExp.TabIndex = 192
        '
        'dtableDelivery
        '
        Me.dtableDelivery.AllowUserToAddRows = False
        Me.dtableDelivery.AllowUserToDeleteRows = False
        Me.dtableDelivery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableDelivery.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.POSeq, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dtableDelivery.Location = New System.Drawing.Point(308, 38)
        Me.dtableDelivery.Name = "dtableDelivery"
        Me.dtableDelivery.ReadOnly = True
        Me.dtableDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableDelivery.Size = New System.Drawing.Size(750, 351)
        Me.dtableDelivery.TabIndex = 188
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Seq"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Qty Expected"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "PONo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'POSeq
        '
        Me.POSeq.HeaderText = "POSeq"
        Me.POSeq.Name = "POSeq"
        Me.POSeq.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty Received"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Qty Ok"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty Balance"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(308, 9)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(78, 19)
        Me.label17.TabIndex = 186
        Me.label17.Text = "Delivery Id"
        '
        'txtDeliveryID
        '
        Me.txtDeliveryID.Enabled = False
        Me.txtDeliveryID.Location = New System.Drawing.Point(414, 6)
        Me.txtDeliveryID.Name = "txtDeliveryID"
        Me.txtDeliveryID.Size = New System.Drawing.Size(191, 27)
        Me.txtDeliveryID.TabIndex = 187
        '
        'btnInsertDel
        '
        Me.btnInsertDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertDel.Location = New System.Drawing.Point(194, 322)
        Me.btnInsertDel.Name = "btnInsertDel"
        Me.btnInsertDel.Size = New System.Drawing.Size(103, 32)
        Me.btnInsertDel.TabIndex = 184
        Me.btnInsertDel.Text = "INSERT"
        Me.btnInsertDel.UseVisualStyleBackColor = True
        Me.btnInsertDel.Visible = False
        '
        'btnPOInv
        '
        Me.btnPOInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOInv.Location = New System.Drawing.Point(203, 139)
        Me.btnPOInv.Name = "btnPOInv"
        Me.btnPOInv.Size = New System.Drawing.Size(32, 27)
        Me.btnPOInv.TabIndex = 183
        Me.btnPOInv.Text = "..."
        Me.btnPOInv.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(4, 142)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 19)
        Me.Label20.TabIndex = 181
        Me.Label20.Text = "*PO No:"
        '
        'txtPoDel
        '
        Me.txtPoDel.Location = New System.Drawing.Point(110, 139)
        Me.txtPoDel.Name = "txtPoDel"
        Me.txtPoDel.Size = New System.Drawing.Size(125, 27)
        Me.txtPoDel.TabIndex = 182
        '
        'btnItemInv
        '
        Me.btnItemInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemInv.Location = New System.Drawing.Point(270, 72)
        Me.btnItemInv.Name = "btnItemInv"
        Me.btnItemInv.Size = New System.Drawing.Size(32, 28)
        Me.btnItemInv.TabIndex = 180
        Me.btnItemInv.Text = "..."
        Me.btnItemInv.UseVisualStyleBackColor = True
        '
        'txtIteamNameDel
        '
        Me.txtIteamNameDel.Enabled = False
        Me.txtIteamNameDel.Location = New System.Drawing.Point(10, 106)
        Me.txtIteamNameDel.Name = "txtIteamNameDel"
        Me.txtIteamNameDel.Size = New System.Drawing.Size(291, 27)
        Me.txtIteamNameDel.TabIndex = 179
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 19)
        Me.Label24.TabIndex = 177
        Me.Label24.Text = "*Item"
        '
        'txtItemDel
        '
        Me.txtItemDel.Location = New System.Drawing.Point(110, 73)
        Me.txtItemDel.Name = "txtItemDel"
        Me.txtItemDel.Size = New System.Drawing.Size(191, 27)
        Me.txtItemDel.TabIndex = 178
        '
        'Invoice
        '
        Me.Invoice.Controls.Add(Me.txtPoSeq)
        Me.Invoice.Controls.Add(Me.dtableInvoice)
        Me.Invoice.Controls.Add(Me.btnPo)
        Me.Invoice.Controls.Add(Me.txtInvoiceRemarks)
        Me.Invoice.Controls.Add(Me.Label15)
        Me.Invoice.Controls.Add(Me.Label19)
        Me.Invoice.Controls.Add(Me.txtPo)
        Me.Invoice.Controls.Add(Me.btnUpdateItems)
        Me.Invoice.Controls.Add(Me.dtDate)
        Me.Invoice.Controls.Add(Me.btnItems)
        Me.Invoice.Controls.Add(Me.btnAddItem)
        Me.Invoice.Controls.Add(Me.chkReceived)
        Me.Invoice.Controls.Add(Me.chkCancel)
        Me.Invoice.Controls.Add(Me.Label16)
        Me.Invoice.Controls.Add(Me.Label14)
        Me.Invoice.Controls.Add(Me.txtTotalPrice)
        Me.Invoice.Controls.Add(Me.Label12)
        Me.Invoice.Controls.Add(Me.txtUnit)
        Me.Invoice.Controls.Add(Me.txtCliUnit)
        Me.Invoice.Controls.Add(Me.txtCliQty)
        Me.Invoice.Controls.Add(Me.txtItemName)
        Me.Invoice.Controls.Add(Me.txtSupUnit)
        Me.Invoice.Controls.Add(Me.Label13)
        Me.Invoice.Controls.Add(Me.Label11)
        Me.Invoice.Controls.Add(Me.txtItemCode)
        Me.Invoice.Controls.Add(Me.txtSupQty)
        Me.Invoice.Location = New System.Drawing.Point(4, 28)
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Padding = New System.Windows.Forms.Padding(3)
        Me.Invoice.Size = New System.Drawing.Size(1067, 424)
        Me.Invoice.TabIndex = 1
        Me.Invoice.Text = "Invoice"
        Me.Invoice.UseVisualStyleBackColor = True
        '
        'txtPoSeq
        '
        Me.txtPoSeq.Enabled = False
        Me.txtPoSeq.Location = New System.Drawing.Point(240, 82)
        Me.txtPoSeq.Name = "txtPoSeq"
        Me.txtPoSeq.Size = New System.Drawing.Size(62, 27)
        Me.txtPoSeq.TabIndex = 173
        '
        'dtableInvoice
        '
        Me.dtableInvoice.AllowUserToAddRows = False
        Me.dtableInvoice.AllowUserToDeleteRows = False
        Me.dtableInvoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.PONo, Me.PONo1, Me.ClientQUnit, Me.ClientQty, Me.PO, Me.Unit, Me.UnitPrice, Me.TotalPrice, Me.Rec, Me.Cancel, Me.ETD, Me.ETA})
        Me.dtableInvoice.Location = New System.Drawing.Point(312, 6)
        Me.dtableInvoice.Name = "dtableInvoice"
        Me.dtableInvoice.ReadOnly = True
        Me.dtableInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableInvoice.Size = New System.Drawing.Size(750, 370)
        Me.dtableInvoice.TabIndex = 172
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
        'PONo
        '
        Me.PONo.HeaderText = "PONo"
        Me.PONo.Name = "PONo"
        Me.PONo.ReadOnly = True
        '
        'PONo1
        '
        Me.PONo1.HeaderText = "POSeq"
        Me.PONo1.Name = "PONo1"
        Me.PONo1.ReadOnly = True
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
        'Rec
        '
        Me.Rec.HeaderText = "Rec"
        Me.Rec.Name = "Rec"
        Me.Rec.ReadOnly = True
        Me.Rec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Cancel
        '
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ReadOnly = True
        Me.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ETD
        '
        Me.ETD.HeaderText = "Date"
        Me.ETD.Name = "ETD"
        Me.ETD.ReadOnly = True
        '
        'ETA
        '
        Me.ETA.HeaderText = "Remarks"
        Me.ETA.Name = "ETA"
        Me.ETA.ReadOnly = True
        '
        'btnPo
        '
        Me.btnPo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPo.Location = New System.Drawing.Point(207, 82)
        Me.btnPo.Name = "btnPo"
        Me.btnPo.Size = New System.Drawing.Size(32, 27)
        Me.btnPo.TabIndex = 171
        Me.btnPo.Text = "..."
        Me.btnPo.UseVisualStyleBackColor = True
        '
        'txtInvoiceRemarks
        '
        Me.txtInvoiceRemarks.Location = New System.Drawing.Point(92, 249)
        Me.txtInvoiceRemarks.Name = "txtInvoiceRemarks"
        Me.txtInvoiceRemarks.Size = New System.Drawing.Size(213, 27)
        Me.txtInvoiceRemarks.TabIndex = 170
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 169
        Me.Label15.Text = "Remarks:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 19)
        Me.Label19.TabIndex = 167
        Me.Label19.Text = "*PO No:"
        '
        'txtPo
        '
        Me.txtPo.Enabled = False
        Me.txtPo.Location = New System.Drawing.Point(90, 82)
        Me.txtPo.Name = "txtPo"
        Me.txtPo.Size = New System.Drawing.Size(149, 27)
        Me.txtPo.TabIndex = 168
        '
        'btnUpdateItems
        '
        Me.btnUpdateItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateItems.Location = New System.Drawing.Point(93, 321)
        Me.btnUpdateItems.Name = "btnUpdateItems"
        Me.btnUpdateItems.Size = New System.Drawing.Size(103, 32)
        Me.btnUpdateItems.TabIndex = 166
        Me.btnUpdateItems.Text = "UPDATE"
        Me.btnUpdateItems.UseVisualStyleBackColor = True
        Me.btnUpdateItems.Visible = False
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(92, 216)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(213, 27)
        Me.dtDate.TabIndex = 165
        '
        'btnItems
        '
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Location = New System.Drawing.Point(273, 16)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(32, 27)
        Me.btnItems.TabIndex = 164
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Location = New System.Drawing.Point(202, 321)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(103, 32)
        Me.btnAddItem.TabIndex = 163
        Me.btnAddItem.Text = "INSERT"
        Me.btnAddItem.UseVisualStyleBackColor = True
        Me.btnAddItem.Visible = False
        '
        'chkReceived
        '
        Me.chkReceived.AutoSize = True
        Me.chkReceived.Location = New System.Drawing.Point(208, 282)
        Me.chkReceived.Name = "chkReceived"
        Me.chkReceived.Size = New System.Drawing.Size(87, 23)
        Me.chkReceived.TabIndex = 162
        Me.chkReceived.Text = "Received"
        Me.chkReceived.UseVisualStyleBackColor = True
        '
        'chkCancel
        '
        Me.chkCancel.AutoSize = True
        Me.chkCancel.Location = New System.Drawing.Point(104, 282)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.Size = New System.Drawing.Size(72, 23)
        Me.chkCancel.TabIndex = 161
        Me.chkCancel.Text = "Cancel"
        Me.chkCancel.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 19)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "*Date:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 19)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "*TotalPrice"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(92, 183)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(213, 27)
        Me.txtTotalPrice.TabIndex = 159
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 19)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "*Unit Price:"
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.Location = New System.Drawing.Point(92, 150)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(213, 27)
        Me.txtUnit.TabIndex = 157
        '
        'txtCliUnit
        '
        Me.txtCliUnit.Enabled = False
        Me.txtCliUnit.Location = New System.Drawing.Point(150, 116)
        Me.txtCliUnit.Name = "txtCliUnit"
        Me.txtCliUnit.Size = New System.Drawing.Size(46, 27)
        Me.txtCliUnit.TabIndex = 155
        '
        'txtCliQty
        '
        Me.txtCliQty.Enabled = False
        Me.txtCliQty.Location = New System.Drawing.Point(99, 116)
        Me.txtCliQty.Name = "txtCliQty"
        Me.txtCliQty.Size = New System.Drawing.Size(46, 27)
        Me.txtCliQty.TabIndex = 154
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(12, 49)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(293, 27)
        Me.txtItemName.TabIndex = 150
        '
        'txtSupUnit
        '
        Me.txtSupUnit.Enabled = False
        Me.txtSupUnit.Location = New System.Drawing.Point(255, 116)
        Me.txtSupUnit.Name = "txtSupUnit"
        Me.txtSupUnit.Size = New System.Drawing.Size(46, 27)
        Me.txtSupUnit.TabIndex = 153
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 19)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "*Item"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 19)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "*Qty:"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(64, 16)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(241, 27)
        Me.txtItemCode.TabIndex = 149
        '
        'txtSupQty
        '
        Me.txtSupQty.Location = New System.Drawing.Point(202, 116)
        Me.txtSupQty.Name = "txtSupQty"
        Me.txtSupQty.Size = New System.Drawing.Size(46, 27)
        Me.txtSupQty.TabIndex = 151
        '
        'dtDeliveryDate
        '
        Me.dtDeliveryDate.Location = New System.Drawing.Point(722, 6)
        Me.dtDeliveryDate.Name = "dtDeliveryDate"
        Me.dtDeliveryDate.Size = New System.Drawing.Size(189, 27)
        Me.dtDeliveryDate.TabIndex = 201
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(614, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 19)
        Me.Label21.TabIndex = 200
        Me.Label21.Text = "*Delivery Date:"
        '
        'AddInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 650)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtEncoded)
        Me.Controls.Add(Me.dtActualETD)
        Me.Controls.Add(Me.txtUpdated)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtReceived)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.chkcancelPO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DtInvoiceDate)
        Me.Controls.Add(Me.txtCurrency)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddInvoice"
        Me.TabControl1.ResumeLayout(False)
        Me.Delivery.ResumeLayout(False)
        Me.Delivery.PerformLayout()
        CType(Me.dtableDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Invoice.ResumeLayout(False)
        Me.Invoice.PerformLayout()
        CType(Me.dtableInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents chkcancelPO As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DtInvoiceDate As DateTimePicker
    Friend WithEvents txtCurrency As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents btnSupplier As Button
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtReceived As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUpdated As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dtActualETD As DateTimePicker
    Friend WithEvents txtEncoded As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Delivery As TabPage
    Friend WithEvents Invoice As TabPage
    Friend WithEvents dtableDelivery As DataGridView
    Friend WithEvents label17 As Label
    Friend WithEvents txtDeliveryID As TextBox
    Friend WithEvents btnInsertDel As Button
    Friend WithEvents btnPOInv As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPoDel As TextBox
    Friend WithEvents btnItemInv As Button
    Friend WithEvents txtIteamNameDel As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtItemDel As TextBox
    Friend WithEvents dtableInvoice As DataGridView
    Friend WithEvents btnPo As Button
    Friend WithEvents txtInvoiceRemarks As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPo As TextBox
    Friend WithEvents btnUpdateItems As Button
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents btnItems As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents chkReceived As CheckBox
    Friend WithEvents chkCancel As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtCliUnit As TextBox
    Friend WithEvents txtCliQty As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtSupUnit As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtSupQty As TextBox
    Friend WithEvents txtPoSeq As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtBal As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtRec As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtExp As TextBox
    Friend WithEvents txtposeqdel As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents POSeq As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label26 As Label
    Friend WithEvents txtqtyok As TextBox
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents PONo As DataGridViewTextBoxColumn
    Friend WithEvents PONo1 As DataGridViewTextBoxColumn
    Friend WithEvents ClientQUnit As DataGridViewTextBoxColumn
    Friend WithEvents ClientQty As DataGridViewTextBoxColumn
    Friend WithEvents PO As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents Rec As DataGridViewCheckBoxColumn
    Friend WithEvents Cancel As DataGridViewCheckBoxColumn
    Friend WithEvents ETD As DataGridViewTextBoxColumn
    Friend WithEvents ETA As DataGridViewTextBoxColumn
    Friend WithEvents Label27 As Label
    Friend WithEvents dtDeliveryDate As DateTimePicker
    Friend WithEvents Label21 As Label
End Class
