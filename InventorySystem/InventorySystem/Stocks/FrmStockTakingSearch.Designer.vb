﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockTakingSearch
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSTID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtableStockTaking = New System.Windows.Forms.DataGridView()
        Me.dtCountedFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtCountedTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkApproved = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtableStockTaking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSearch.Location = New System.Drawing.Point(372, 10)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 23)
        Me.btnSearch.TabIndex = 38
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(665, 398)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 25)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add Stock Taking"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSTID
        '
        Me.txtSTID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSTID.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSTID.Location = New System.Drawing.Point(114, 9)
        Me.txtSTID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSTID.Name = "txtSTID"
        Me.txtSTID.Size = New System.Drawing.Size(250, 23)
        Me.txtSTID.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(9, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 16)
        Me.Label7.TabIndex = 33
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
        Me.dtableStockTaking.BackgroundColor = System.Drawing.Color.White
        Me.dtableStockTaking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtableStockTaking.Location = New System.Drawing.Point(11, 67)
        Me.dtableStockTaking.Margin = New System.Windows.Forms.Padding(2)
        Me.dtableStockTaking.Name = "dtableStockTaking"
        Me.dtableStockTaking.ReadOnly = True
        Me.dtableStockTaking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtableStockTaking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtableStockTaking.Size = New System.Drawing.Size(779, 328)
        Me.dtableStockTaking.TabIndex = 32
        '
        'dtCountedFrom
        '
        Me.dtCountedFrom.Checked = False
        Me.dtCountedFrom.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtCountedFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCountedFrom.Location = New System.Drawing.Point(114, 35)
        Me.dtCountedFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dtCountedFrom.Name = "dtCountedFrom"
        Me.dtCountedFrom.ShowCheckBox = True
        Me.dtCountedFrom.Size = New System.Drawing.Size(124, 23)
        Me.dtCountedFrom.TabIndex = 118
        '
        'dtCountedTo
        '
        Me.dtCountedTo.Checked = False
        Me.dtCountedTo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtCountedTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCountedTo.Location = New System.Drawing.Point(242, 36)
        Me.dtCountedTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dtCountedTo.Name = "dtCountedTo"
        Me.dtCountedTo.ShowCheckBox = True
        Me.dtCountedTo.Size = New System.Drawing.Size(124, 23)
        Me.dtCountedTo.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Counted Date:"
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.chkApproved.Location = New System.Drawing.Point(466, 38)
        Me.chkApproved.Margin = New System.Windows.Forms.Padding(2)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(88, 20)
        Me.chkApproved.TabIndex = 122
        Me.chkApproved.Text = "Approved"
        Me.chkApproved.UseVisualStyleBackColor = True
        Me.chkApproved.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnClear.Location = New System.Drawing.Point(372, 36)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 23)
        Me.btnClear.TabIndex = 128
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(9, 408)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 16)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "*NOTE: DOUBLE CLICK TO VIEW"
        '
        'FrmStockTakingSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 428)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkApproved)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtCountedTo)
        Me.Controls.Add(Me.dtCountedFrom)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSTID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtableStockTaking)
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Name = "FrmStockTakingSearch"
        Me.Text = "Search StockTaking "
        CType(Me.dtableStockTaking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSTID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtableStockTaking As DataGridView
    Friend WithEvents dtCountedFrom As DateTimePicker
    Friend WithEvents dtCountedTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents chkApproved As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
End Class
