﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbUserLevel = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtUsers = New System.Windows.Forms.DataGridView()
        Me.EmpId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeletedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSearch.Location = New System.Drawing.Point(318, 14)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 25)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(444, 422)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add User"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmbUserLevel
        '
        Me.cmbUserLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserLevel.FormattingEnabled = True
        Me.cmbUserLevel.Location = New System.Drawing.Point(-298, 40)
        Me.cmbUserLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbUserLevel.Name = "cmbUserLevel"
        Me.cmbUserLevel.Size = New System.Drawing.Size(160, 23)
        Me.cmbUserLevel.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-379, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "UserLevel"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(93, 14)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(217, 23)
        Me.txtSearch.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(9, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Name:"
        '
        'dtUsers
        '
        Me.dtUsers.AllowUserToAddRows = False
        Me.dtUsers.AllowUserToDeleteRows = False
        Me.dtUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpId, Me.EmployeeName, Me.UserLevel, Me.Delete, Me.DeletedDate})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtUsers.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtUsers.Location = New System.Drawing.Point(11, 67)
        Me.dtUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.dtUsers.Name = "dtUsers"
        Me.dtUsers.ReadOnly = True
        Me.dtUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtUsers.Size = New System.Drawing.Size(523, 350)
        Me.dtUsers.TabIndex = 22
        '
        'EmpId
        '
        Me.EmpId.HeaderText = "EmpId"
        Me.EmpId.Name = "EmpId"
        Me.EmpId.ReadOnly = True
        Me.EmpId.Width = 68
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 114
        '
        'UserLevel
        '
        Me.UserLevel.HeaderText = "User Level"
        Me.UserLevel.Name = "UserLevel"
        Me.UserLevel.ReadOnly = True
        Me.UserLevel.Width = 84
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Width = 68
        '
        'DeletedDate
        '
        Me.DeletedDate.HeaderText = "DeletedDate"
        Me.DeletedDate.Name = "DeletedDate"
        Me.DeletedDate.ReadOnly = True
        Me.DeletedDate.Width = 101
        '
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 449)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbUserLevel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtUsers)
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmUser"
        Me.Text = "Search User"
        CType(Me.dtUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbUserLevel As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtUsers As DataGridView
    Friend WithEvents EmpId As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents UserLevel As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewCheckBoxColumn
    Friend WithEvents DeletedDate As DataGridViewTextBoxColumn
End Class
