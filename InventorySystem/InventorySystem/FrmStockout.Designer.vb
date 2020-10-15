<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockout
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
        Me.chkApproved = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtCountedTo = New System.Windows.Forms.DateTimePicker()
        Me.dtCountedFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSTID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtableStockTaking = New System.Windows.Forms.DataGridView()
        CType(Me.dtableStockTaking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Location = New System.Drawing.Point(302, 12)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(89, 23)
        Me.chkApproved.TabIndex = 131
        Me.chkApproved.Text = "Approved"
        Me.chkApproved.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Counted Date:"
        '
        'dtCountedTo
        '
        Me.dtCountedTo.Checked = False
        Me.dtCountedTo.Location = New System.Drawing.Point(262, 40)
        Me.dtCountedTo.Name = "dtCountedTo"
        Me.dtCountedTo.ShowCheckBox = True
        Me.dtCountedTo.Size = New System.Drawing.Size(150, 27)
        Me.dtCountedTo.TabIndex = 129
        '
        'dtCountedFrom
        '
        Me.dtCountedFrom.Checked = False
        Me.dtCountedFrom.Location = New System.Drawing.Point(110, 40)
        Me.dtCountedFrom.Name = "dtCountedFrom"
        Me.dtCountedFrom.ShowCheckBox = True
        Me.dtCountedFrom.Size = New System.Drawing.Size(150, 27)
        Me.dtCountedFrom.TabIndex = 128
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(398, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(99, 30)
        Me.btnSearch.TabIndex = 127
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(756, 503)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 32)
        Me.btnAdd.TabIndex = 126
        Me.btnAdd.Text = "Add Stock Taking"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSTID
        '
        Me.txtSTID.Location = New System.Drawing.Point(121, 10)
        Me.txtSTID.Name = "txtSTID"
        Me.txtSTID.Size = New System.Drawing.Size(176, 27)
        Me.txtSTID.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 19)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Stock Taking ID:"
        '
        'dtableStockTaking
        '
        Me.dtableStockTaking.AllowUserToAddRows = False
        Me.dtableStockTaking.AllowUserToDeleteRows = False
        Me.dtableStockTaking.AllowUserToResizeColumns = False
        Me.dtableStockTaking.AllowUserToResizeRows = False
        Me.dtableStockTaking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtableStockTaking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtableStockTaking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtableStockTaking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtableStockTaking.Location = New System.Drawing.Point(8, 82)
        Me.dtableStockTaking.Name = "dtableStockTaking"
        Me.dtableStockTaking.ReadOnly = True
        Me.dtableStockTaking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtableStockTaking.Size = New System.Drawing.Size(891, 416)
        Me.dtableStockTaking.TabIndex = 123
        '
        'FrmStockout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 540)
        Me.Controls.Add(Me.chkApproved)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtCountedTo)
        Me.Controls.Add(Me.dtCountedFrom)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSTID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtableStockTaking)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmStockout"
        Me.Text = "FrmStockout"
        CType(Me.dtableStockTaking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkApproved As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtCountedTo As DateTimePicker
    Friend WithEvents dtCountedFrom As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSTID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtableStockTaking As DataGridView
End Class
