<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoiceEntry
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
        Me.btndelclear = New System.Windows.Forms.Button()
        Me.dtDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
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
        Me.DeliveryId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecAdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label17 = New System.Windows.Forms.Label()
        Me.txtDeliveryID = New System.Windows.Forms.TextBox()
        Me.btnInsertDel = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPoDel = New System.Windows.Forms.TextBox()
        Me.btnItemInv = New System.Windows.Forms.Button()
        Me.txtIteamNameDel = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtItemDel = New System.Windows.Forms.TextBox()
        Me.Invoice = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
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
        Me.AddRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPo = New System.Windows.Forms.Button()
        Me.txtInvoiceRemarks = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPo = New System.Windows.Forms.TextBox()
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
        Me.Label28 = New System.Windows.Forms.Label()
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
        Me.btnSave.Location = New System.Drawing.Point(1064, 580)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(156, 30)
        Me.btnSave.TabIndex = 116
        Me.btnSave.Text = "SAVE INVOICE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtStaffName
        '
        Me.txtStaffName.Enabled = False
        Me.txtStaffName.Location = New System.Drawing.Point(960, 74)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(258, 26)
        Me.txtStaffName.TabIndex = 114
        '
        'chkcancelPO
        '
        Me.chkcancelPO.AutoSize = True
        Me.chkcancelPO.Location = New System.Drawing.Point(1136, 108)
        Me.chkcancelPO.Name = "chkcancelPO"
        Me.chkcancelPO.Size = New System.Drawing.Size(76, 22)
        Me.chkcancelPO.TabIndex = 118
        Me.chkcancelPO.Text = "Cancel"
        Me.chkcancelPO.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(828, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 18)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Encoded By:"
        '
        'DtInvoiceDate
        '
        Me.DtInvoiceDate.Checked = False
        Me.DtInvoiceDate.Location = New System.Drawing.Point(576, 11)
        Me.DtInvoiceDate.Name = "DtInvoiceDate"
        Me.DtInvoiceDate.Size = New System.Drawing.Size(248, 26)
        Me.DtInvoiceDate.TabIndex = 103
        '
        'txtCurrency
        '
        Me.txtCurrency.Enabled = False
        Me.txtCurrency.Location = New System.Drawing.Point(161, 74)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(294, 26)
        Me.txtCurrency.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Currency:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(369, 43)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(455, 26)
        Me.txtSupplierName.TabIndex = 100
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Location = New System.Drawing.Point(326, 43)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(36, 26)
        Me.btnSupplier.TabIndex = 99
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightBlue
        Me.txtSupplier.Location = New System.Drawing.Point(161, 43)
        Me.txtSupplier.MaxLength = 25
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(201, 26)
        Me.txtSupplier.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(461, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "*Invoice Date:"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(161, 11)
        Me.txtInvoiceNo.MaxLength = 50
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(294, 26)
        Me.txtInvoiceNo.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "*Invoice No:"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Location = New System.Drawing.Point(958, 43)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(258, 26)
        Me.txtRemarks.TabIndex = 112
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(593, 74)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(231, 26)
        Me.txtTotalAmount.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(464, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Total Amount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(828, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 18)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Remarks:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "*Supplier:"
        '
        'dtReceived
        '
        Me.dtReceived.Checked = False
        Me.dtReceived.Location = New System.Drawing.Point(958, 11)
        Me.dtReceived.Name = "dtReceived"
        Me.dtReceived.Size = New System.Drawing.Size(258, 26)
        Me.dtReceived.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(828, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "*Received Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 18)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "*Actual ETD Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 18)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Encoded Date:"
        '
        'txtUpdated
        '
        Me.txtUpdated.Enabled = False
        Me.txtUpdated.Location = New System.Drawing.Point(960, 105)
        Me.txtUpdated.Name = "txtUpdated"
        Me.txtUpdated.Size = New System.Drawing.Size(169, 26)
        Me.txtUpdated.TabIndex = 126
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(828, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 18)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Updated Date:"
        '
        'dtActualETD
        '
        Me.dtActualETD.Checked = False
        Me.dtActualETD.Location = New System.Drawing.Point(161, 105)
        Me.dtActualETD.Name = "dtActualETD"
        Me.dtActualETD.Size = New System.Drawing.Size(294, 26)
        Me.dtActualETD.TabIndex = 127
        '
        'txtEncoded
        '
        Me.txtEncoded.Enabled = False
        Me.txtEncoded.Location = New System.Drawing.Point(593, 105)
        Me.txtEncoded.Name = "txtEncoded"
        Me.txtEncoded.Size = New System.Drawing.Size(231, 26)
        Me.txtEncoded.TabIndex = 128
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Delivery)
        Me.TabControl1.Controls.Add(Me.Invoice)
        Me.TabControl1.Location = New System.Drawing.Point(14, 142)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1209, 432)
        Me.TabControl1.TabIndex = 116
        '
        'Delivery
        '
        Me.Delivery.BackColor = System.Drawing.Color.White
        Me.Delivery.Controls.Add(Me.btndelclear)
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
        Me.Delivery.Controls.Add(Me.Label20)
        Me.Delivery.Controls.Add(Me.txtPoDel)
        Me.Delivery.Controls.Add(Me.btnItemInv)
        Me.Delivery.Controls.Add(Me.txtIteamNameDel)
        Me.Delivery.Controls.Add(Me.Label24)
        Me.Delivery.Controls.Add(Me.txtItemDel)
        Me.Delivery.Location = New System.Drawing.Point(4, 27)
        Me.Delivery.Name = "Delivery"
        Me.Delivery.Padding = New System.Windows.Forms.Padding(3)
        Me.Delivery.Size = New System.Drawing.Size(1201, 401)
        Me.Delivery.TabIndex = 0
        Me.Delivery.Text = "Delivery Details"
        '
        'btndelclear
        '
        Me.btndelclear.BackColor = System.Drawing.Color.White
        Me.btndelclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelclear.Location = New System.Drawing.Point(176, 318)
        Me.btndelclear.Name = "btndelclear"
        Me.btndelclear.Size = New System.Drawing.Size(161, 30)
        Me.btndelclear.TabIndex = 202
        Me.btndelclear.Text = "CLEAR"
        Me.btndelclear.UseVisualStyleBackColor = False
        '
        'dtDeliveryDate
        '
        Me.dtDeliveryDate.Checked = False
        Me.dtDeliveryDate.Location = New System.Drawing.Point(128, 51)
        Me.dtDeliveryDate.Name = "dtDeliveryDate"
        Me.dtDeliveryDate.Size = New System.Drawing.Size(212, 26)
        Me.dtDeliveryDate.TabIndex = 201
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 18)
        Me.Label21.TabIndex = 200
        Me.Label21.Text = "*Delivery Date:"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(341, 378)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(180, 19)
        Me.Label27.TabIndex = 129
        Me.Label27.Text = "*NOTE: CLICK TO UPDATE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 241)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 18)
        Me.Label26.TabIndex = 198
        Me.Label26.Text = "Qty OK:"
        '
        'txtqtyok
        '
        Me.txtqtyok.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtqtyok.Location = New System.Drawing.Point(124, 238)
        Me.txtqtyok.MaxLength = 18
        Me.txtqtyok.Name = "txtqtyok"
        Me.txtqtyok.Size = New System.Drawing.Size(214, 26)
        Me.txtqtyok.TabIndex = 199
        '
        'txtposeqdel
        '
        Me.txtposeqdel.Enabled = False
        Me.txtposeqdel.Location = New System.Drawing.Point(269, 146)
        Me.txtposeqdel.Name = "txtposeqdel"
        Me.txtposeqdel.Size = New System.Drawing.Size(69, 26)
        Me.txtposeqdel.TabIndex = 197
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 275)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 18)
        Me.Label25.TabIndex = 195
        Me.Label25.Text = "Qty Balance:"
        '
        'txtBal
        '
        Me.txtBal.Enabled = False
        Me.txtBal.Location = New System.Drawing.Point(124, 272)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(214, 26)
        Me.txtBal.TabIndex = 196
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 209)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 18)
        Me.Label23.TabIndex = 193
        Me.Label23.Text = "Qty Received:"
        '
        'txtRec
        '
        Me.txtRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRec.Location = New System.Drawing.Point(124, 206)
        Me.txtRec.MaxLength = 18
        Me.txtRec.Name = "txtRec"
        Me.txtRec.Size = New System.Drawing.Size(214, 26)
        Me.txtRec.TabIndex = 194
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 178)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 18)
        Me.Label22.TabIndex = 191
        Me.Label22.Text = "Qty Expected:"
        '
        'txtExp
        '
        Me.txtExp.Enabled = False
        Me.txtExp.Location = New System.Drawing.Point(124, 175)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(214, 26)
        Me.txtExp.TabIndex = 192
        '
        'dtableDelivery
        '
        Me.dtableDelivery.AllowUserToAddRows = False
        Me.dtableDelivery.AllowUserToDeleteRows = False
        Me.dtableDelivery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtableDelivery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtableDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableDelivery.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DeliveryId, Me.DeliveryDate, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.POSeq, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.RecAdd})
        Me.dtableDelivery.Location = New System.Drawing.Point(346, 8)
        Me.dtableDelivery.Name = "dtableDelivery"
        Me.dtableDelivery.ReadOnly = True
        Me.dtableDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableDelivery.Size = New System.Drawing.Size(844, 362)
        Me.dtableDelivery.TabIndex = 188
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "InvoiceSeq"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 108
        '
        'DeliveryId
        '
        Me.DeliveryId.HeaderText = "DeliveryId"
        Me.DeliveryId.Name = "DeliveryId"
        Me.DeliveryId.ReadOnly = True
        Me.DeliveryId.Width = 99
        '
        'DeliveryDate
        '
        Me.DeliveryDate.HeaderText = "DeliveryDate"
        Me.DeliveryDate.Name = "DeliveryDate"
        Me.DeliveryDate.ReadOnly = True
        Me.DeliveryDate.Width = 121
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 111
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Qty Expected"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.Width = 124
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "PONo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 74
        '
        'POSeq
        '
        Me.POSeq.HeaderText = "POSeq"
        Me.POSeq.Name = "POSeq"
        Me.POSeq.ReadOnly = True
        Me.POSeq.Width = 83
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty Received"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 124
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Qty Ok"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty Balance"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 115
        '
        'RecAdd
        '
        Me.RecAdd.HeaderText = "RecAdd"
        Me.RecAdd.Name = "RecAdd"
        Me.RecAdd.ReadOnly = True
        Me.RecAdd.Width = 88
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(11, 24)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(80, 18)
        Me.label17.TabIndex = 186
        Me.label17.Text = "Delivery Id"
        '
        'txtDeliveryID
        '
        Me.txtDeliveryID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDeliveryID.Location = New System.Drawing.Point(130, 21)
        Me.txtDeliveryID.MaxLength = 50
        Me.txtDeliveryID.Name = "txtDeliveryID"
        Me.txtDeliveryID.Size = New System.Drawing.Size(210, 26)
        Me.txtDeliveryID.TabIndex = 187
        '
        'btnInsertDel
        '
        Me.btnInsertDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertDel.Location = New System.Drawing.Point(9, 318)
        Me.btnInsertDel.Name = "btnInsertDel"
        Me.btnInsertDel.Size = New System.Drawing.Size(160, 30)
        Me.btnInsertDel.TabIndex = 184
        Me.btnInsertDel.Text = "INSERT DELIVERY"
        Me.btnInsertDel.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(4, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 18)
        Me.Label20.TabIndex = 181
        Me.Label20.Text = "*PO No:"
        '
        'txtPoDel
        '
        Me.txtPoDel.BackColor = System.Drawing.Color.White
        Me.txtPoDel.Enabled = False
        Me.txtPoDel.Location = New System.Drawing.Point(124, 146)
        Me.txtPoDel.MaxLength = 20
        Me.txtPoDel.Name = "txtPoDel"
        Me.txtPoDel.Size = New System.Drawing.Size(140, 26)
        Me.txtPoDel.TabIndex = 182
        '
        'btnItemInv
        '
        Me.btnItemInv.BackColor = System.Drawing.Color.Gainsboro
        Me.btnItemInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemInv.Location = New System.Drawing.Point(304, 81)
        Me.btnItemInv.Name = "btnItemInv"
        Me.btnItemInv.Size = New System.Drawing.Size(36, 27)
        Me.btnItemInv.TabIndex = 180
        Me.btnItemInv.Text = "..."
        Me.btnItemInv.UseVisualStyleBackColor = False
        '
        'txtIteamNameDel
        '
        Me.txtIteamNameDel.Enabled = False
        Me.txtIteamNameDel.Location = New System.Drawing.Point(11, 114)
        Me.txtIteamNameDel.Name = "txtIteamNameDel"
        Me.txtIteamNameDel.Size = New System.Drawing.Size(327, 26)
        Me.txtIteamNameDel.TabIndex = 179
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 18)
        Me.Label24.TabIndex = 177
        Me.Label24.Text = "*Item"
        '
        'txtItemDel
        '
        Me.txtItemDel.BackColor = System.Drawing.Color.LightBlue
        Me.txtItemDel.Location = New System.Drawing.Point(128, 82)
        Me.txtItemDel.MaxLength = 20
        Me.txtItemDel.Name = "txtItemDel"
        Me.txtItemDel.Size = New System.Drawing.Size(210, 26)
        Me.txtItemDel.TabIndex = 178
        '
        'Invoice
        '
        Me.Invoice.BackColor = System.Drawing.Color.White
        Me.Invoice.Controls.Add(Me.btnClear)
        Me.Invoice.Controls.Add(Me.Label29)
        Me.Invoice.Controls.Add(Me.txtPoSeq)
        Me.Invoice.Controls.Add(Me.dtableInvoice)
        Me.Invoice.Controls.Add(Me.btnPo)
        Me.Invoice.Controls.Add(Me.txtInvoiceRemarks)
        Me.Invoice.Controls.Add(Me.Label15)
        Me.Invoice.Controls.Add(Me.Label19)
        Me.Invoice.Controls.Add(Me.txtPo)
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
        Me.Invoice.Location = New System.Drawing.Point(4, 27)
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Padding = New System.Windows.Forms.Padding(3)
        Me.Invoice.Size = New System.Drawing.Size(1201, 401)
        Me.Invoice.TabIndex = 1
        Me.Invoice.Text = "Invoice"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(187, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 30)
        Me.btnClear.TabIndex = 175
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(351, 378)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(180, 19)
        Me.Label29.TabIndex = 174
        Me.Label29.Text = "*NOTE: CLICK TO UPDATE"
        '
        'txtPoSeq
        '
        Me.txtPoSeq.Enabled = False
        Me.txtPoSeq.Location = New System.Drawing.Point(270, 78)
        Me.txtPoSeq.Name = "txtPoSeq"
        Me.txtPoSeq.Size = New System.Drawing.Size(69, 26)
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
        Me.dtableInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.PONo, Me.PONo1, Me.ClientQUnit, Me.ClientQty, Me.PO, Me.Unit, Me.UnitPrice, Me.TotalPrice, Me.Rec, Me.Cancel, Me.ETD, Me.ETA, Me.AddRec})
        Me.dtableInvoice.Location = New System.Drawing.Point(351, 6)
        Me.dtableInvoice.Name = "dtableInvoice"
        Me.dtableInvoice.ReadOnly = True
        Me.dtableInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableInvoice.Size = New System.Drawing.Size(844, 352)
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
        Me.Cancel.HeaderText = "Ok"
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
        'AddRec
        '
        Me.AddRec.HeaderText = "AddRec"
        Me.AddRec.Name = "AddRec"
        Me.AddRec.ReadOnly = True
        Me.AddRec.Visible = False
        '
        'btnPo
        '
        Me.btnPo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPo.Location = New System.Drawing.Point(233, 78)
        Me.btnPo.Name = "btnPo"
        Me.btnPo.Size = New System.Drawing.Size(36, 26)
        Me.btnPo.TabIndex = 171
        Me.btnPo.Text = "..."
        Me.btnPo.UseVisualStyleBackColor = False
        '
        'txtInvoiceRemarks
        '
        Me.txtInvoiceRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInvoiceRemarks.Location = New System.Drawing.Point(104, 236)
        Me.txtInvoiceRemarks.Name = "txtInvoiceRemarks"
        Me.txtInvoiceRemarks.Size = New System.Drawing.Size(239, 26)
        Me.txtInvoiceRemarks.TabIndex = 170
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 18)
        Me.Label15.TabIndex = 169
        Me.Label15.Text = "Remarks:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 18)
        Me.Label19.TabIndex = 167
        Me.Label19.Text = "*PO No:"
        '
        'txtPo
        '
        Me.txtPo.BackColor = System.Drawing.Color.LightBlue
        Me.txtPo.Location = New System.Drawing.Point(101, 78)
        Me.txtPo.Name = "txtPo"
        Me.txtPo.Size = New System.Drawing.Size(167, 26)
        Me.txtPo.TabIndex = 168
        '
        'dtDate
        '
        Me.dtDate.Checked = False
        Me.dtDate.Location = New System.Drawing.Point(104, 205)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.ShowCheckBox = True
        Me.dtDate.Size = New System.Drawing.Size(239, 26)
        Me.dtDate.TabIndex = 165
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.Gainsboro
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Location = New System.Drawing.Point(307, 15)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(36, 26)
        Me.btnItems.TabIndex = 164
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.White
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Location = New System.Drawing.Point(18, 305)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(161, 30)
        Me.btnAddItem.TabIndex = 163
        Me.btnAddItem.Text = "INSERT INVOICE"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'chkReceived
        '
        Me.chkReceived.AutoSize = True
        Me.chkReceived.Enabled = False
        Me.chkReceived.Location = New System.Drawing.Point(234, 267)
        Me.chkReceived.Name = "chkReceived"
        Me.chkReceived.Size = New System.Drawing.Size(93, 22)
        Me.chkReceived.TabIndex = 162
        Me.chkReceived.Text = "Received"
        Me.chkReceived.UseVisualStyleBackColor = True
        '
        'chkCancel
        '
        Me.chkCancel.AutoSize = True
        Me.chkCancel.Enabled = False
        Me.chkCancel.Location = New System.Drawing.Point(104, 268)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.Size = New System.Drawing.Size(47, 22)
        Me.chkCancel.TabIndex = 161
        Me.chkCancel.Text = "Ok"
        Me.chkCancel.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 18)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "Date:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 18)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "TotalPrice"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(104, 173)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(239, 26)
        Me.txtTotalPrice.TabIndex = 159
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Unit Price:"
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.Location = New System.Drawing.Point(104, 142)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(239, 26)
        Me.txtUnit.TabIndex = 157
        '
        'txtCliUnit
        '
        Me.txtCliUnit.Enabled = False
        Me.txtCliUnit.Location = New System.Drawing.Point(165, 110)
        Me.txtCliUnit.Name = "txtCliUnit"
        Me.txtCliUnit.Size = New System.Drawing.Size(51, 26)
        Me.txtCliUnit.TabIndex = 155
        '
        'txtCliQty
        '
        Me.txtCliQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliQty.Location = New System.Drawing.Point(105, 110)
        Me.txtCliQty.Name = "txtCliQty"
        Me.txtCliQty.Size = New System.Drawing.Size(51, 26)
        Me.txtCliQty.TabIndex = 154
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(14, 46)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(329, 26)
        Me.txtItemName.TabIndex = 150
        '
        'txtSupUnit
        '
        Me.txtSupUnit.Enabled = False
        Me.txtSupUnit.Location = New System.Drawing.Point(287, 110)
        Me.txtSupUnit.Name = "txtSupUnit"
        Me.txtSupUnit.Size = New System.Drawing.Size(51, 26)
        Me.txtSupUnit.TabIndex = 153
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 18)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "*Item"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 18)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "*Qty:"
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.LightBlue
        Me.txtItemCode.Location = New System.Drawing.Point(72, 15)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(271, 26)
        Me.txtItemCode.TabIndex = 149
        '
        'txtSupQty
        '
        Me.txtSupQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupQty.Location = New System.Drawing.Point(226, 110)
        Me.txtSupQty.Name = "txtSupQty"
        Me.txtSupQty.Size = New System.Drawing.Size(51, 26)
        Me.txtSupQty.TabIndex = 151
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(0, 595)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(217, 19)
        Me.Label28.TabIndex = 129
        Me.Label28.Text = "*NOTE: ALL * ARE IMPORTANT"
        '
        'FrmInvoiceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 616)
        Me.Controls.Add(Me.Label28)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmInvoiceEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Invoice Entry"
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
    Friend WithEvents Label26 As Label
    Friend WithEvents txtqtyok As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents dtDeliveryDate As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryId As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents POSeq As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents RecAdd As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
    Friend WithEvents btndelclear As Button
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
    Friend WithEvents AddRec As DataGridViewTextBoxColumn
End Class
