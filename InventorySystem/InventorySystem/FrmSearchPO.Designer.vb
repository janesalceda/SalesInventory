<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSearchPO
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
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtIssuedFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.dtIssuedTo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.txtItemsName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dtPoDetails = New System.Windows.Forms.DataGridView()
        Me.PONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancelled = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtPoDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(78, 63)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(277, 27)
        Me.txtSupplier.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Supplier:"
        '
        'txtPONo
        '
        Me.txtPONo.Location = New System.Drawing.Point(78, 28)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(277, 27)
        Me.txtPONo.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "PO No:"
        '
        'dtIssuedFrom
        '
        Me.dtIssuedFrom.Checked = False
        Me.dtIssuedFrom.CustomFormat = "YYYY/MM/DD"
        Me.dtIssuedFrom.Location = New System.Drawing.Point(96, 95)
        Me.dtIssuedFrom.Name = "dtIssuedFrom"
        Me.dtIssuedFrom.ShowCheckBox = True
        Me.dtIssuedFrom.Size = New System.Drawing.Size(221, 27)
        Me.dtIssuedFrom.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Issued Date:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(361, 63)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(345, 27)
        Me.txtSupplierName.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radNo)
        Me.GroupBox1.Controls.Add(Me.radYes)
        Me.GroupBox1.Controls.Add(Me.btnSupplier)
        Me.GroupBox1.Controls.Add(Me.dtIssuedTo)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Controls.Add(Me.txtSupplierName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtIssuedFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 160)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO Headers Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Cancelled:"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Location = New System.Drawing.Point(492, 31)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(45, 23)
        Me.radNo.TabIndex = 53
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(440, 30)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(49, 23)
        Me.radYes.TabIndex = 52
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Location = New System.Drawing.Point(323, 63)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(32, 27)
        Me.btnSupplier.TabIndex = 51
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'dtIssuedTo
        '
        Me.dtIssuedTo.Checked = False
        Me.dtIssuedTo.CustomFormat = "YYYY/MM/DD"
        Me.dtIssuedTo.Location = New System.Drawing.Point(323, 95)
        Me.dtIssuedTo.Name = "dtIssuedTo"
        Me.dtIssuedTo.ShowCheckBox = True
        Me.dtIssuedTo.Size = New System.Drawing.Size(221, 27)
        Me.dtIssuedTo.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnItems)
        Me.GroupBox2.Controls.Add(Me.txtItemsName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtItems)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(715, 71)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PO Details Information"
        '
        'btnItems
        '
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Location = New System.Drawing.Point(323, 26)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(32, 27)
        Me.btnItems.TabIndex = 51
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'txtItemsName
        '
        Me.txtItemsName.Enabled = False
        Me.txtItemsName.Location = New System.Drawing.Point(364, 26)
        Me.txtItemsName.Name = "txtItemsName"
        Me.txtItemsName.Size = New System.Drawing.Size(345, 27)
        Me.txtItemsName.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Items:"
        '
        'txtItems
        '
        Me.txtItems.Location = New System.Drawing.Point(78, 26)
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(277, 27)
        Me.txtItems.TabIndex = 45
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(515, 256)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 34)
        Me.btnSearch.TabIndex = 62
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(624, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 34)
        Me.btnClear.TabIndex = 61
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dtPoDetails
        '
        Me.dtPoDetails.AllowUserToAddRows = False
        Me.dtPoDetails.AllowUserToDeleteRows = False
        Me.dtPoDetails.AllowUserToResizeColumns = False
        Me.dtPoDetails.AllowUserToResizeRows = False
        Me.dtPoDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtPoDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtPoDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtPoDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtPoDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONO, Me.SupplierId, Me.SupplierName, Me.IssuedDate, Me.Cancelled})
        Me.dtPoDetails.Location = New System.Drawing.Point(9, 297)
        Me.dtPoDetails.Name = "dtPoDetails"
        Me.dtPoDetails.ReadOnly = True
        Me.dtPoDetails.RowHeadersVisible = False
        Me.dtPoDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtPoDetails.Size = New System.Drawing.Size(718, 348)
        Me.dtPoDetails.TabIndex = 70
        '
        'PONO
        '
        Me.PONO.HeaderText = "PONO"
        Me.PONO.Name = "PONO"
        Me.PONO.ReadOnly = True
        Me.PONO.Width = 72
        '
        'SupplierId
        '
        Me.SupplierId.HeaderText = "SupplierId"
        Me.SupplierId.Name = "SupplierId"
        Me.SupplierId.ReadOnly = True
        Me.SupplierId.Width = 96
        '
        'SupplierName
        '
        Me.SupplierName.HeaderText = "SupplierName"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.ReadOnly = True
        Me.SupplierName.Width = 122
        '
        'IssuedDate
        '
        Me.IssuedDate.HeaderText = "Issued Date"
        Me.IssuedDate.Name = "IssuedDate"
        Me.IssuedDate.ReadOnly = True
        Me.IssuedDate.Width = 109
        '
        'Cancelled
        '
        Me.Cancelled.HeaderText = "Cancelled"
        Me.Cancelled.Name = "Cancelled"
        Me.Cancelled.ReadOnly = True
        Me.Cancelled.Width = 77
        '
        'FrmSearchPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 658)
        Me.Controls.Add(Me.dtPoDetails)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSearchPO"
        Me.Text = "Search Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtPoDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPONo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtIssuedFrom As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents btnSupplier As Button
    Friend WithEvents dtIssuedTo As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnItems As Button
    Friend WithEvents txtItemsName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItems As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dtPoDetails As DataGridView
    Friend WithEvents PONO As DataGridViewTextBoxColumn
    Friend WithEvents SupplierId As DataGridViewTextBoxColumn
    Friend WithEvents SupplierName As DataGridViewTextBoxColumn
    Friend WithEvents IssuedDate As DataGridViewTextBoxColumn
    Friend WithEvents Cancelled As DataGridViewCheckBoxColumn
End Class
