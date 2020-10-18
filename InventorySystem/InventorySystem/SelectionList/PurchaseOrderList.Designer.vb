<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderList
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpo = New System.Windows.Forms.TextBox()
        Me.dtitems = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.White
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(296, 368)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 29)
        Me.btnOk.TabIndex = 82
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(286, 113)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 29)
        Me.btnClear.TabIndex = 81
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(189, 113)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 29)
        Me.btnSearch.TabIndex = 80
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Supplier:"
        '
        'txtSupplier
        '
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.Location = New System.Drawing.Point(92, 83)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplier.MaxLength = 25
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(277, 26)
        Me.txtSupplier.TabIndex = 79
        '
        'txtItems
        '
        Me.txtItems.Enabled = False
        Me.txtItems.Location = New System.Drawing.Point(92, 50)
        Me.txtItems.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItems.MaxLength = 20
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(277, 26)
        Me.txtItems.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "PO No:"
        '
        'txtpo
        '
        Me.txtpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpo.Location = New System.Drawing.Point(92, 17)
        Me.txtpo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpo.MaxLength = 20
        Me.txtpo.Name = "txtpo"
        Me.txtpo.Size = New System.Drawing.Size(277, 26)
        Me.txtpo.TabIndex = 76
        '
        'dtitems
        '
        Me.dtitems.AllowUserToAddRows = False
        Me.dtitems.AllowUserToDeleteRows = False
        Me.dtitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.Column2, Me.Column1, Me.Column3})
        Me.dtitems.Location = New System.Drawing.Point(4, 150)
        Me.dtitems.Margin = New System.Windows.Forms.Padding(4)
        Me.dtitems.Name = "dtitems"
        Me.dtitems.ReadOnly = True
        Me.dtitems.RowHeadersVisible = False
        Me.dtitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtitems.Size = New System.Drawing.Size(379, 210)
        Me.dtitems.TabIndex = 74
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "PO No"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Seq"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "POQty"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Balance Qty"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "InvQty"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "ItemId:"
        '
        'PurchaseOrderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 401)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.txtItems)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpo)
        Me.Controls.Add(Me.dtitems)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(409, 440)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(409, 440)
        Me.Name = "PurchaseOrderList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PurchaseOrderList"
        Me.TopMost = True
        CType(Me.dtitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents txtItems As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpo As TextBox
    Friend WithEvents dtitems As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
