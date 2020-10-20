<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemStockSearch
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
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtitem
        '
        Me.txtitem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitem.Location = New System.Drawing.Point(60, 25)
        Me.txtitem.MaxLength = 20
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(274, 26)
        Me.txtitem.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(365, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(132, 30)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "VIEW"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionDate, Me.TRANSID, Me.INQTY})
        Me.dgvData.Location = New System.Drawing.Point(10, 112)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(643, 430)
        Me.dgvData.TabIndex = 10
        '
        'TransactionDate
        '
        Me.TransactionDate.HeaderText = "Item Id"
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.ReadOnly = True
        '
        'TRANSID
        '
        Me.TRANSID.HeaderText = "Description"
        Me.TRANSID.Name = "TRANSID"
        Me.TRANSID.ReadOnly = True
        '
        'INQTY
        '
        Me.INQTY.HeaderText = "QTY"
        Me.INQTY.Name = "INQTY"
        Me.INQTY.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ItemId:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "~"
        '
        'dtTo
        '
        Me.dtTo.Location = New System.Drawing.Point(365, 58)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(268, 26)
        Me.dtTo.TabIndex = 6
        '
        'dtFrom
        '
        Me.dtFrom.Location = New System.Drawing.Point(60, 58)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(274, 26)
        Me.dtFrom.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtitem)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtTo)
        Me.GroupBox1.Controls.Add(Me.dtFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Details"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(500, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 30)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'FrmItemStockSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 558)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmItemStockSearch"
        Me.Text = "Search ItemStock"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtitem As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents TRANSID As DataGridViewTextBoxColumn
    Friend WithEvents INQTY As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
End Class
