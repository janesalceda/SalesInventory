<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearchInvoice
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
        Me.dtPoDetails = New System.Windows.Forms.DataGridView()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnitems = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.dtInvoiceTo = New System.Windows.Forms.DateTimePicker()
        Me.txtinvoice = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtInvoiceFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtPoDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtPoDetails
        '
        Me.dtPoDetails.AllowUserToAddRows = False
        Me.dtPoDetails.AllowUserToDeleteRows = False
        Me.dtPoDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtPoDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtPoDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemId, Me.ItemName, Me.PO, Me.Unit})
        Me.dtPoDetails.Location = New System.Drawing.Point(4, 251)
        Me.dtPoDetails.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtPoDetails.Name = "dtPoDetails"
        Me.dtPoDetails.ReadOnly = True
        Me.dtPoDetails.RowHeadersVisible = False
        Me.dtPoDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtPoDetails.Size = New System.Drawing.Size(664, 293)
        Me.dtPoDetails.TabIndex = 75
        '
        'Seq
        '
        Me.Seq.HeaderText = "Invoice No"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "SupplierId"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'PO
        '
        Me.PO.HeaderText = "Invoice Date"
        Me.PO.Name = "PO"
        Me.PO.ReadOnly = True
        Me.PO.Width = 150
        '
        'Unit
        '
        Me.Unit.HeaderText = "Total Price"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(479, 218)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 28)
        Me.btnSearch.TabIndex = 74
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.LightCoral
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(575, 218)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 28)
        Me.btnClear.TabIndex = 73
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnitems
        '
        Me.btnitems.BackColor = System.Drawing.Color.Gainsboro
        Me.btnitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnitems.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnitems.Location = New System.Drawing.Point(296, 22)
        Me.btnitems.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnitems.Name = "btnitems"
        Me.btnitems.Size = New System.Drawing.Size(28, 23)
        Me.btnitems.TabIndex = 51
        Me.btnitems.Text = "..."
        Me.btnitems.UseVisualStyleBackColor = False
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(328, 22)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(306, 23)
        Me.txtItemName.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Items:"
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.LightBlue
        Me.txtItemCode.Location = New System.Drawing.Point(94, 22)
        Me.txtItemCode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(230, 23)
        Me.txtItemCode.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtPO)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnitems)
        Me.GroupBox2.Controls.Add(Me.txtItemName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtItemCode)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 133)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(660, 79)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invoice Details Information"
        '
        'txtPO
        '
        Me.txtPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPO.Location = New System.Drawing.Point(94, 50)
        Me.txtPO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(230, 23)
        Me.txtPO.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "PO No:"
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSupplier.Location = New System.Drawing.Point(296, 52)
        Me.btnSupplier.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(28, 23)
        Me.btnSupplier.TabIndex = 51
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'dtInvoiceTo
        '
        Me.dtInvoiceTo.Checked = False
        Me.dtInvoiceTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInvoiceTo.Location = New System.Drawing.Point(328, 80)
        Me.dtInvoiceTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtInvoiceTo.Name = "dtInvoiceTo"
        Me.dtInvoiceTo.ShowCheckBox = True
        Me.dtInvoiceTo.Size = New System.Drawing.Size(230, 23)
        Me.dtInvoiceTo.TabIndex = 50
        '
        'txtinvoice
        '
        Me.txtinvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtinvoice.Location = New System.Drawing.Point(94, 22)
        Me.txtinvoice.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtinvoice.Name = "txtinvoice"
        Me.txtinvoice.Size = New System.Drawing.Size(230, 23)
        Me.txtinvoice.TabIndex = 43
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(328, 52)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(303, 23)
        Me.txtSupplierName.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Invoice No:"
        '
        'dtInvoiceFrom
        '
        Me.dtInvoiceFrom.Checked = False
        Me.dtInvoiceFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInvoiceFrom.Location = New System.Drawing.Point(94, 80)
        Me.dtInvoiceFrom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtInvoiceFrom.Name = "dtInvoiceFrom"
        Me.dtInvoiceFrom.ShowCheckBox = True
        Me.dtInvoiceFrom.Size = New System.Drawing.Size(230, 23)
        Me.dtInvoiceFrom.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Supplier:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 85)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Invoice Date:"
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightBlue
        Me.txtSupplier.Location = New System.Drawing.Point(94, 52)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(230, 23)
        Me.txtSupplier.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnSupplier)
        Me.GroupBox1.Controls.Add(Me.dtInvoiceTo)
        Me.GroupBox1.Controls.Add(Me.txtinvoice)
        Me.GroupBox1.Controls.Add(Me.txtSupplierName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtInvoiceFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(660, 118)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Headers Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(11, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 19)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "*NOTE: DOUBLE CLICK TO VIEW/UPDATE"
        '
        'FrmSearchInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtPoDetails)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSearchInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Invoice"
        CType(Me.dtPoDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtPoDetails As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnitems As Button
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSupplier As Button
    Friend WithEvents dtInvoiceTo As DateTimePicker
    Friend WithEvents txtinvoice As TextBox
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtInvoiceFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents PO As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents txtPO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
