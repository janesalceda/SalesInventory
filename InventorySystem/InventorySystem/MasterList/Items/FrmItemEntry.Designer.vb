﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmItemEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemEntry))
        Me.txtItemId = New System.Windows.Forms.TextBox()
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
        Me.grpItemDetails = New System.Windows.Forms.GroupBox()
        Me.chkApproved = New System.Windows.Forms.CheckBox()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.picprint = New System.Windows.Forms.PictureBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.picBar = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddItemPrice = New System.Windows.Forms.Button()
        Me.dtableItemPrices = New System.Windows.Forms.DataGridView()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppliedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPriceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAddPrice = New System.Windows.Forms.Button()
        Me.dtableCliPrice = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpItemDetails.SuspendLayout()
        CType(Me.picprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtableItemPrices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtableCliPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.Color.White
        Me.txtItemId.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtItemId.Location = New System.Drawing.Point(87, 20)
        Me.txtItemId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemId.MaxLength = 20
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(164, 23)
        Me.txtItemId.TabIndex = 0
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtDes.Location = New System.Drawing.Point(93, 55)
        Me.txtDes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDes.MaxLength = 255
        Me.txtDes.Multiline = True
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(429, 24)
        Me.txtDes.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "*Description:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(534, 435)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 27)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = " "
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'txtConCoe
        '
        Me.txtConCoe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtConCoe.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtConCoe.Location = New System.Drawing.Point(524, 80)
        Me.txtConCoe.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConCoe.MaxLength = 18
        Me.txtConCoe.Name = "txtConCoe"
        Me.txtConCoe.Size = New System.Drawing.Size(67, 23)
        Me.txtConCoe.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(352, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "*Converting coefficient:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(11, 112)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "*Location:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMax
        '
        Me.txtMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMax.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtMax.Location = New System.Drawing.Point(86, 128)
        Me.txtMax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMax.MaxLength = 18
        Me.txtMax.Multiline = True
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(72, 42)
        Me.txtMax.TabIndex = 6
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(93, 181)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemarks.MaxLength = 150
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(411, 41)
        Me.txtRemarks.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(9, 181)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Remarks:"
        '
        'txtMinQty
        '
        Me.txtMinQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMinQty.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtMinQty.Location = New System.Drawing.Point(254, 128)
        Me.txtMinQty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMinQty.MaxLength = 18
        Me.txtMinQty.Multiline = True
        Me.txtMinQty.Name = "txtMinQty"
        Me.txtMinQty.Size = New System.Drawing.Size(68, 42)
        Me.txtMinQty.TabIndex = 7
        '
        'txtOrderPoint
        '
        Me.txtOrderPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrderPoint.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtOrderPoint.Location = New System.Drawing.Point(428, 130)
        Me.txtOrderPoint.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrderPoint.MaxLength = 18
        Me.txtOrderPoint.Multiline = True
        Me.txtOrderPoint.Name = "txtOrderPoint"
        Me.txtOrderPoint.Size = New System.Drawing.Size(60, 39)
        Me.txtOrderPoint.TabIndex = 8
        '
        'cmbCliQtyUnit
        '
        Me.cmbCliQtyUnit.BackColor = System.Drawing.Color.LightBlue
        Me.cmbCliQtyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliQtyUnit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbCliQtyUnit.FormattingEnabled = True
        Me.cmbCliQtyUnit.Location = New System.Drawing.Point(93, 83)
        Me.cmbCliQtyUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCliQtyUnit.Name = "cmbCliQtyUnit"
        Me.cmbCliQtyUnit.Size = New System.Drawing.Size(57, 24)
        Me.cmbCliQtyUnit.TabIndex = 1
        '
        'cmbSupQtyUnit
        '
        Me.cmbSupQtyUnit.BackColor = System.Drawing.Color.LightBlue
        Me.cmbSupQtyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupQtyUnit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbSupQtyUnit.FormattingEnabled = True
        Me.cmbSupQtyUnit.Location = New System.Drawing.Point(292, 83)
        Me.cmbSupQtyUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSupQtyUnit.Name = "cmbSupQtyUnit"
        Me.cmbSupQtyUnit.Size = New System.Drawing.Size(57, 24)
        Me.cmbSupQtyUnit.TabIndex = 2
        '
        'cmbLocation
        '
        Me.cmbLocation.BackColor = System.Drawing.Color.LightBlue
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(92, 109)
        Me.cmbLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(170, 24)
        Me.cmbLocation.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item ID:"
        '
        'grpItemDetails
        '
        Me.grpItemDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItemDetails.Controls.Add(Me.chkApproved)
        Me.grpItemDetails.Controls.Add(Me.chkDisuse)
        Me.grpItemDetails.Controls.Add(Me.Label14)
        Me.grpItemDetails.Controls.Add(Me.Label15)
        Me.grpItemDetails.Controls.Add(Me.picprint)
        Me.grpItemDetails.Controls.Add(Me.cmbCategory)
        Me.grpItemDetails.Controls.Add(Me.PictureBox4)
        Me.grpItemDetails.Controls.Add(Me.Label6)
        Me.grpItemDetails.Controls.Add(Me.picQR)
        Me.grpItemDetails.Controls.Add(Me.txtItemId)
        Me.grpItemDetails.Controls.Add(Me.txtMax)
        Me.grpItemDetails.Controls.Add(Me.Label1)
        Me.grpItemDetails.Controls.Add(Me.picBar)
        Me.grpItemDetails.Controls.Add(Me.txtMinQty)
        Me.grpItemDetails.Controls.Add(Me.txtOrderPoint)
        Me.grpItemDetails.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItemDetails.Location = New System.Drawing.Point(6, 7)
        Me.grpItemDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.grpItemDetails.Name = "grpItemDetails"
        Me.grpItemDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.grpItemDetails.Size = New System.Drawing.Size(635, 220)
        Me.grpItemDetails.TabIndex = 55
        Me.grpItemDetails.TabStop = False
        Me.grpItemDetails.Text = "Item Details"
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Location = New System.Drawing.Point(532, 21)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(80, 20)
        Me.chkApproved.TabIndex = 66
        Me.chkApproved.Text = "Approved"
        Me.chkApproved.UseVisualStyleBackColor = True
        Me.chkApproved.Visible = False
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Enabled = False
        Me.chkDisuse.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.chkDisuse.Location = New System.Drawing.Point(457, 21)
        Me.chkDisuse.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(70, 20)
        Me.chkDisuse.TabIndex = 65
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(160, 130)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 38)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "*Min. Order Qty:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(326, 130)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 38)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "*Ordering Point:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picprint
        '
        Me.picprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picprint.Image = Global.InventorySystem.My.Resources.Resources.Print
        Me.picprint.Location = New System.Drawing.Point(564, 196)
        Me.picprint.Margin = New System.Windows.Forms.Padding(2)
        Me.picprint.Name = "picprint"
        Me.picprint.Size = New System.Drawing.Size(20, 18)
        Me.picprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picprint.TabIndex = 2
        Me.picprint.TabStop = False
        Me.picprint.Visible = False
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.LightBlue
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(340, 102)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(174, 24)
        Me.cmbCategory.TabIndex = 5
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.InventorySystem.My.Resources.Resources.Print
        Me.PictureBox4.Location = New System.Drawing.Point(525, 196)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(260, 104)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "*Category:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picQR
        '
        Me.picQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQR.Image = Global.InventorySystem.My.Resources.Resources.QRCode
        Me.picQR.Location = New System.Drawing.Point(508, 178)
        Me.picQR.Margin = New System.Windows.Forms.Padding(2)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(36, 36)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQR.TabIndex = 0
        Me.picQR.TabStop = False
        Me.picQR.Visible = False
        '
        'picBar
        '
        Me.picBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBar.Image = Global.InventorySystem.My.Resources.Resources.Barcode
        Me.picBar.Location = New System.Drawing.Point(548, 178)
        Me.picBar.Margin = New System.Windows.Forms.Padding(2)
        Me.picBar.Name = "picBar"
        Me.picBar.Size = New System.Drawing.Size(36, 36)
        Me.picBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBar.TabIndex = 1
        Me.picBar.TabStop = False
        Me.picBar.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "*Qty Unit:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(152, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 18)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "*Supplier Qty Unit:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 38)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "*Max Order Qty:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddItemPrice
        '
        Me.btnAddItemPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddItemPrice.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAddItemPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddItemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItemPrice.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnAddItemPrice.ForeColor = System.Drawing.Color.Black
        Me.btnAddItemPrice.Location = New System.Drawing.Point(8, 152)
        Me.btnAddItemPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddItemPrice.Name = "btnAddItemPrice"
        Me.btnAddItemPrice.Size = New System.Drawing.Size(144, 27)
        Me.btnAddItemPrice.TabIndex = 10
        Me.btnAddItemPrice.Text = "Add Supplier Item Price"
        Me.btnAddItemPrice.UseVisualStyleBackColor = False
        '
        'dtableItemPrices
        '
        Me.dtableItemPrices.AllowUserToAddRows = False
        Me.dtableItemPrices.AllowUserToDeleteRows = False
        Me.dtableItemPrices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableItemPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtableItemPrices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtableItemPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableItemPrices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierID, Me.AppliedDate, Me.UnitPrice, Me.ItemPriceID, Me.SupplierItemCode, Me.RegisteredDate})
        Me.dtableItemPrices.Location = New System.Drawing.Point(8, 4)
        Me.dtableItemPrices.Margin = New System.Windows.Forms.Padding(2)
        Me.dtableItemPrices.Name = "dtableItemPrices"
        Me.dtableItemPrices.ReadOnly = True
        Me.dtableItemPrices.Size = New System.Drawing.Size(623, 142)
        Me.dtableItemPrices.TabIndex = 63
        '
        'SupplierID
        '
        Me.SupplierID.HeaderText = "SupplierID"
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.ReadOnly = True
        Me.SupplierID.Width = 90
        '
        'AppliedDate
        '
        Me.AppliedDate.HeaderText = "Applied Date"
        Me.AppliedDate.Name = "AppliedDate"
        Me.AppliedDate.ReadOnly = True
        Me.AppliedDate.Width = 96
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        Me.UnitPrice.Width = 78
        '
        'ItemPriceID
        '
        Me.ItemPriceID.HeaderText = "Item Price ID"
        Me.ItemPriceID.Name = "ItemPriceID"
        Me.ItemPriceID.ReadOnly = True
        Me.ItemPriceID.Width = 82
        '
        'SupplierItemCode
        '
        Me.SupplierItemCode.HeaderText = "SupplierItemCode"
        Me.SupplierItemCode.Name = "SupplierItemCode"
        Me.SupplierItemCode.ReadOnly = True
        Me.SupplierItemCode.Width = 130
        '
        'RegisteredDate
        '
        Me.RegisteredDate.HeaderText = "Registered Date"
        Me.RegisteredDate.Name = "RegisteredDate"
        Me.RegisteredDate.ReadOnly = True
        Me.RegisteredDate.Width = 110
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(9, 451)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 15)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "*NOTE: ALL * ARE IMPORTANT"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(6, 225)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(641, 206)
        Me.TabControl1.TabIndex = 66
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAddPrice)
        Me.TabPage2.Controls.Add(Me.dtableCliPrice)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(633, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Item Price"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAddPrice
        '
        Me.btnAddPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddPrice.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAddPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPrice.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAddPrice.ForeColor = System.Drawing.Color.Black
        Me.btnAddPrice.Location = New System.Drawing.Point(7, 149)
        Me.btnAddPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddPrice.Name = "btnAddPrice"
        Me.btnAddPrice.Size = New System.Drawing.Size(144, 27)
        Me.btnAddPrice.TabIndex = 65
        Me.btnAddPrice.Text = "Add Item Price"
        Me.btnAddPrice.UseVisualStyleBackColor = False
        '
        'dtableCliPrice
        '
        Me.dtableCliPrice.AllowUserToAddRows = False
        Me.dtableCliPrice.AllowUserToDeleteRows = False
        Me.dtableCliPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableCliPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtableCliPrice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtableCliPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtableCliPrice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.dtableCliPrice.Location = New System.Drawing.Point(6, 9)
        Me.dtableCliPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.dtableCliPrice.Name = "dtableCliPrice"
        Me.dtableCliPrice.ReadOnly = True
        Me.dtableCliPrice.Size = New System.Drawing.Size(622, 132)
        Me.dtableCliPrice.TabIndex = 64
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Applied Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 96
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 78
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item Price ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 82
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Registered Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtableItemPrices)
        Me.TabPage1.Controls.Add(Me.btnAddItemPrice)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(633, 179)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Supplier Item Price"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FrmItemEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(651, 467)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.cmbSupQtyUnit)
        Me.Controls.Add(Me.cmbCliQtyUnit)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtConCoe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpItemDetails)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmItemEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Items Entry"
        Me.TopMost = True
        Me.grpItemDetails.ResumeLayout(False)
        Me.grpItemDetails.PerformLayout()
        CType(Me.picprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtableItemPrices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtableCliPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
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
    Friend WithEvents grpItemDetails As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnAddItemPrice As Button
    Friend WithEvents picQR As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents picprint As PictureBox
    Friend WithEvents picBar As PictureBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtableItemPrices As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents SupplierID As DataGridViewTextBoxColumn
    Friend WithEvents AppliedDate As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents ItemPriceID As DataGridViewTextBoxColumn
    Friend WithEvents SupplierItemCode As DataGridViewTextBoxColumn
    Friend WithEvents RegisteredDate As DataGridViewTextBoxColumn
    Friend WithEvents chkDisuse As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dtableCliPrice As DataGridView
    Friend WithEvents btnAddPrice As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents chkApproved As CheckBox
End Class
