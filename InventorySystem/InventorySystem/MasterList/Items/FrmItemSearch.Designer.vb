<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemSearch
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
        Me.dtItems = New System.Windows.Forms.DataGridView()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disused = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeletedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtItems
        '
        Me.dtItems.AllowUserToAddRows = False
        Me.dtItems.AllowUserToDeleteRows = False
        Me.dtItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemId, Me.ItemName, Me.RegisteredDate, Me.Disused, Me.DeletedDate})
        Me.dtItems.Location = New System.Drawing.Point(18, 132)
        Me.dtItems.Name = "dtItems"
        Me.dtItems.ReadOnly = True
        Me.dtItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtItems.Size = New System.Drawing.Size(730, 368)
        Me.dtItems.TabIndex = 0
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "Item Id"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Width = 70
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 131
        '
        'RegisteredDate
        '
        Me.RegisteredDate.HeaderText = "Registered Date"
        Me.RegisteredDate.Name = "RegisteredDate"
        Me.RegisteredDate.ReadOnly = True
        Me.RegisteredDate.Width = 133
        '
        'Disused
        '
        Me.Disused.HeaderText = "Disused"
        Me.Disused.Name = "Disused"
        Me.Disused.ReadOnly = True
        Me.Disused.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Disused.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Disused.Width = 89
        '
        'DeletedDate
        '
        Me.DeletedDate.HeaderText = "DeletedDate"
        Me.DeletedDate.Name = "DeletedDate"
        Me.DeletedDate.ReadOnly = True
        Me.DeletedDate.Width = 120
        '
        'txtItemID
        '
        Me.txtItemID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemID.Location = New System.Drawing.Point(119, 17)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(198, 26)
        Me.txtItemID.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Item:"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(623, 512)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 30)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(482, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 30)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDes.Location = New System.Drawing.Point(118, 46)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(353, 26)
        Me.txtDes.TabIndex = 22
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.LightBlue
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(118, 76)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(352, 29)
        Me.cmbCategory.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 21)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "*Category:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Location = New System.Drawing.Point(348, 18)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(76, 22)
        Me.chkDisuse.TabIndex = 67
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(18, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 19)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "*NOTE: CLICK TO VIEW/UPDATE"
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(482, 50)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(116, 30)
        Me.btnclear.TabIndex = 78
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Description:"
        '
        'FrmItemSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(757, 550)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtItems)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmItemSearch"
        Me.Text = "Search Item"
        CType(Me.dtItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtItems As DataGridView
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtDes As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkDisuse As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents RegisteredDate As DataGridViewTextBoxColumn
    Friend WithEvents Disused As DataGridViewCheckBoxColumn
    Friend WithEvents DeletedDate As DataGridViewTextBoxColumn
    Friend WithEvents btnclear As Button
    Friend WithEvents Label1 As Label
End Class
