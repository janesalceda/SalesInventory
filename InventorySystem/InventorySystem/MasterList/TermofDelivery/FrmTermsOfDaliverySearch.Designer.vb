﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTermsOfDaliverySearch
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDelPlace = New System.Windows.Forms.TextBox()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCatID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtItems = New System.Windows.Forms.DataGridView()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryPlace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disused = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeletedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dtItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "TermofDelivery"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 19)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "*NOTE: CLICK TO VIEW/UPDATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Decription:"
        '
        'txtDelPlace
        '
        Me.txtDelPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDelPlace.Location = New System.Drawing.Point(488, 6)
        Me.txtDelPlace.Name = "txtDelPlace"
        Me.txtDelPlace.Size = New System.Drawing.Size(284, 26)
        Me.txtDelPlace.TabIndex = 110
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Location = New System.Drawing.Point(468, 42)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(76, 22)
        Me.chkDisuse.TabIndex = 107
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDes.Location = New System.Drawing.Point(110, 40)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(353, 26)
        Me.txtDes.TabIndex = 106
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(554, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 30)
        Me.btnSearch.TabIndex = 105
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(677, 516)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 30)
        Me.btnAdd.TabIndex = 104
        Me.btnAdd.Text = "Add Delivery Places"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCatID
        '
        Me.txtCatID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCatID.Location = New System.Drawing.Point(156, 8)
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.Size = New System.Drawing.Size(198, 26)
        Me.txtCatID.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 18)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "TermofDeliveryId:"
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
        Me.dtItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemId, Me.DeliveryPlace, Me.ItemName, Me.RegisteredDate, Me.Disused, Me.DeletedDate, Me.Delete})
        Me.dtItems.Location = New System.Drawing.Point(16, 100)
        Me.dtItems.Name = "dtItems"
        Me.dtItems.ReadOnly = True
        Me.dtItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtItems.Size = New System.Drawing.Size(831, 412)
        Me.dtItems.TabIndex = 101
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "TermofDeliveryId"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Width = 146
        '
        'DeliveryPlace
        '
        Me.DeliveryPlace.HeaderText = "TermofDelivery"
        Me.DeliveryPlace.Name = "DeliveryPlace"
        Me.DeliveryPlace.ReadOnly = True
        Me.DeliveryPlace.Width = 134
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 111
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
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Text = ""
        Me.Delete.Width = 58
        '
        'FrmTermsOfDaliverySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 550)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDelPlace)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCatID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtItems)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTermsOfDaliverySearch"
        Me.Text = "FrmTermsOfDaliverySearch"
        CType(Me.dtItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDelPlace As TextBox
    Friend WithEvents chkDisuse As CheckBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtCatID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtItems As DataGridView
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryPlace As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents RegisteredDate As DataGridViewTextBoxColumn
    Friend WithEvents Disused As DataGridViewCheckBoxColumn
    Friend WithEvents DeletedDate As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class