﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTermsofPayment
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTDeliveryPlaces = New System.Windows.Forms.DataGridView()
        CType(Me.DTDeliveryPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(370, 91)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 32)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Location = New System.Drawing.Point(401, 19)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(72, 23)
        Me.chkDisuse.TabIndex = 2
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(252, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 32)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(142, 58)
        Me.txtDes.MaxLength = 150
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(332, 27)
        Me.txtDes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Description:"
        '
        'txtTD
        '
        Me.txtTD.Location = New System.Drawing.Point(142, 20)
        Me.txtTD.MaxLength = 100
        Me.txtTD.Name = "txtTD"
        Me.txtTD.Size = New System.Drawing.Size(253, 27)
        Me.txtTD.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 19)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Terms Of Payment"
        '
        'DTDeliveryPlaces
        '
        Me.DTDeliveryPlaces.AllowUserToAddRows = False
        Me.DTDeliveryPlaces.AllowUserToDeleteRows = False
        Me.DTDeliveryPlaces.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTDeliveryPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DTDeliveryPlaces.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DTDeliveryPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTDeliveryPlaces.Location = New System.Drawing.Point(4, 130)
        Me.DTDeliveryPlaces.Name = "DTDeliveryPlaces"
        Me.DTDeliveryPlaces.ReadOnly = True
        Me.DTDeliveryPlaces.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTDeliveryPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTDeliveryPlaces.Size = New System.Drawing.Size(480, 454)
        Me.DTDeliveryPlaces.TabIndex = 51
        '
        'FrmTermsofPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 584)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTDeliveryPlaces)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTermsofPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmTermsofPayment"
        CType(Me.DTDeliveryPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents chkDisuse As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DTDeliveryPlaces As DataGridView
End Class
