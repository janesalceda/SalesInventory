﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtPoDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightBlue
        Me.txtSupplier.Location = New System.Drawing.Point(108, 60)
        Me.txtSupplier.MaxLength = 25
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(291, 26)
        Me.txtSupplier.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Supplier:"
        '
        'txtPONo
        '
        Me.txtPONo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPONo.Location = New System.Drawing.Point(108, 27)
        Me.txtPONo.MaxLength = 20
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(291, 26)
        Me.txtPONo.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 18)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "PO No:"
        '
        'dtIssuedFrom
        '
        Me.dtIssuedFrom.Checked = False
        Me.dtIssuedFrom.CustomFormat = "YYYY/MM/DD"
        Me.dtIssuedFrom.Location = New System.Drawing.Point(108, 92)
        Me.dtIssuedFrom.Name = "dtIssuedFrom"
        Me.dtIssuedFrom.ShowCheckBox = True
        Me.dtIssuedFrom.Size = New System.Drawing.Size(291, 26)
        Me.dtIssuedFrom.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Issued Date:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(406, 60)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(388, 26)
        Me.txtSupplierName.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 152)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO Headers Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Cancelled:"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Location = New System.Drawing.Point(554, 29)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(46, 22)
        Me.radNo.TabIndex = 53
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(495, 28)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(51, 22)
        Me.radYes.TabIndex = 52
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Location = New System.Drawing.Point(363, 60)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(36, 26)
        Me.btnSupplier.TabIndex = 51
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'dtIssuedTo
        '
        Me.dtIssuedTo.Checked = False
        Me.dtIssuedTo.CustomFormat = "YYYY/MM/DD"
        Me.dtIssuedTo.Location = New System.Drawing.Point(410, 92)
        Me.dtIssuedTo.Name = "dtIssuedTo"
        Me.dtIssuedTo.ShowCheckBox = True
        Me.dtIssuedTo.Size = New System.Drawing.Size(293, 26)
        Me.dtIssuedTo.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnItems)
        Me.GroupBox2.Controls.Add(Me.txtItemsName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtItems)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 67)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PO Details Information"
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.Gainsboro
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Location = New System.Drawing.Point(363, 25)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(36, 26)
        Me.btnItems.TabIndex = 51
        Me.btnItems.Text = "..."
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'txtItemsName
        '
        Me.txtItemsName.Enabled = False
        Me.txtItemsName.Location = New System.Drawing.Point(410, 25)
        Me.txtItemsName.Name = "txtItemsName"
        Me.txtItemsName.Size = New System.Drawing.Size(388, 26)
        Me.txtItemsName.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Items:"
        '
        'txtItems
        '
        Me.txtItems.BackColor = System.Drawing.Color.LightBlue
        Me.txtItems.Location = New System.Drawing.Point(108, 25)
        Me.txtItems.MaxLength = 20
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(291, 26)
        Me.txtItems.TabIndex = 45
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(579, 243)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 32)
        Me.btnSearch.TabIndex = 62
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(702, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 32)
        Me.btnClear.TabIndex = 61
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
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
        Me.dtPoDetails.Location = New System.Drawing.Point(10, 281)
        Me.dtPoDetails.Name = "dtPoDetails"
        Me.dtPoDetails.ReadOnly = True
        Me.dtPoDetails.RowHeadersVisible = False
        Me.dtPoDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtPoDetails.Size = New System.Drawing.Size(808, 330)
        Me.dtPoDetails.TabIndex = 70
        '
        'PONO
        '
        Me.PONO.HeaderText = "PONO"
        Me.PONO.Name = "PONO"
        Me.PONO.ReadOnly = True
        Me.PONO.Width = 77
        '
        'SupplierId
        '
        Me.SupplierId.HeaderText = "SupplierId"
        Me.SupplierId.Name = "SupplierId"
        Me.SupplierId.ReadOnly = True
        Me.SupplierId.Width = 101
        '
        'SupplierName
        '
        Me.SupplierName.HeaderText = "SupplierName"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.ReadOnly = True
        Me.SupplierName.Width = 131
        '
        'IssuedDate
        '
        Me.IssuedDate.HeaderText = "Issued Date"
        Me.IssuedDate.Name = "IssuedDate"
        Me.IssuedDate.ReadOnly = True
        Me.IssuedDate.Width = 114
        '
        'Cancelled
        '
        Me.Cancelled.HeaderText = "Cancelled"
        Me.Cancelled.Name = "Cancelled"
        Me.Cancelled.ReadOnly = True
        Me.Cancelled.Width = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(9, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 19)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "*NOTE: DOUBLE CLICK TO VIEW/UPDATE"
        '
        'FrmSearchPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 623)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtPoDetails)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSearchPO"
        Me.Text = "Search Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtPoDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label3 As Label
End Class
