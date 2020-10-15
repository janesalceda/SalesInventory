<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddItem
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
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtConCoe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMinQty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOrderPoint = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbCliQtyUnit = New System.Windows.Forms.ComboBox()
        Me.cmbSupQtyUnit = New System.Windows.Forms.ComboBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtSupDes = New System.Windows.Forms.TextBox()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(302, 8)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(248, 27)
        Me.txtDes.TabIndex = 1
        '
        'txtItemId
        '
        Me.txtItemId.Location = New System.Drawing.Point(74, 10)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(142, 27)
        Me.txtItemId.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Unit Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Client Qty Unit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item ID:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(472, 282)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 36)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'txtConCoe
        '
        Me.txtConCoe.Location = New System.Drawing.Point(164, 104)
        Me.txtConCoe.Name = "txtConCoe"
        Me.txtConCoe.Size = New System.Drawing.Size(148, 27)
        Me.txtConCoe.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Converting Coefficient:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(242, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Supplier Qty Unit:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 19)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Location"
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(112, 170)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(58, 27)
        Me.txtMax.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Max Order Qty:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(80, 209)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(462, 27)
        Me.txtRemarks.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 19)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Remarks"
        '
        'txtMinQty
        '
        Me.txtMinQty.Location = New System.Drawing.Point(452, 172)
        Me.txtMinQty.Name = "txtMinQty"
        Me.txtMinQty.Size = New System.Drawing.Size(58, 27)
        Me.txtMinQty.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(338, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 19)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Min. Order Qty."
        '
        'txtOrderPoint
        '
        Me.txtOrderPoint.Location = New System.Drawing.Point(276, 172)
        Me.txtOrderPoint.Name = "txtOrderPoint"
        Me.txtOrderPoint.Size = New System.Drawing.Size(58, 27)
        Me.txtOrderPoint.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(170, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 19)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Ordering Point"
        '
        'cmbCliQtyUnit
        '
        Me.cmbCliQtyUnit.FormattingEnabled = True
        Me.cmbCliQtyUnit.Location = New System.Drawing.Point(114, 72)
        Me.cmbCliQtyUnit.Name = "cmbCliQtyUnit"
        Me.cmbCliQtyUnit.Size = New System.Drawing.Size(126, 27)
        Me.cmbCliQtyUnit.TabIndex = 4
        '
        'cmbSupQtyUnit
        '
        Me.cmbSupQtyUnit.FormattingEnabled = True
        Me.cmbSupQtyUnit.Location = New System.Drawing.Point(366, 72)
        Me.cmbSupQtyUnit.Name = "cmbSupQtyUnit"
        Me.cmbSupQtyUnit.Size = New System.Drawing.Size(144, 27)
        Me.cmbSupQtyUnit.TabIndex = 5
        '
        'cmbLocation
        '
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(82, 137)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(464, 27)
        Me.cmbLocation.TabIndex = 10
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(390, 104)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(152, 27)
        Me.txtUnitPrice.TabIndex = 8
        '
        'txtSupDes
        '
        Me.txtSupDes.Location = New System.Drawing.Point(246, 40)
        Me.txtSupDes.Name = "txtSupDes"
        Me.txtSupDes.Size = New System.Drawing.Size(304, 27)
        Me.txtSupDes.TabIndex = 3
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Location = New System.Drawing.Point(96, 40)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(144, 27)
        Me.txtSupplierID.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Supplier ID"
        '
        'btnSupplier
        '
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Location = New System.Drawing.Point(208, 40)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(32, 27)
        Me.btnSupplier.TabIndex = 54
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 326)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.txtSupDes)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.cmbSupQtyUnit)
        Me.Controls.Add(Me.cmbCliQtyUnit)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMinQty)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtOrderPoint)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtConCoe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.txtItemId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddItem"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDes As TextBox
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtConCoe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMax As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMinQty As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtOrderPoint As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbCliQtyUnit As ComboBox
    Friend WithEvents cmbSupQtyUnit As ComboBox
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtSupDes As TextBox
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSupplier As Button
End Class
