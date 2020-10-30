<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierItemPriceEntry
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
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.txtSupDes = New System.Windows.Forms.TextBox()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtAppliedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSupItemCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUnitPrice.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtUnitPrice.Location = New System.Drawing.Point(136, 68)
        Me.txtUnitPrice.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUnitPrice.MaxLength = 19
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(298, 23)
        Me.txtUnitPrice.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(4, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Unit Price:"
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSupplier.Location = New System.Drawing.Point(238, 10)
        Me.btnSupplier.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(31, 23)
        Me.btnSupplier.TabIndex = 0
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'txtSupDes
        '
        Me.txtSupDes.BackColor = System.Drawing.Color.White
        Me.txtSupDes.Enabled = False
        Me.txtSupDes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupDes.Location = New System.Drawing.Point(270, 10)
        Me.txtSupDes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSupDes.Name = "txtSupDes"
        Me.txtSupDes.Size = New System.Drawing.Size(199, 23)
        Me.txtSupDes.TabIndex = 56
        '
        'txtSupplierID
        '
        Me.txtSupplierID.BackColor = System.Drawing.Color.LightBlue
        Me.txtSupplierID.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupplierID.Location = New System.Drawing.Point(136, 10)
        Me.txtSupplierID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSupplierID.MaxLength = 25
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(132, 23)
        Me.txtSupplierID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(4, 13)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Supplier ID:"
        '
        'dtAppliedDate
        '
        Me.dtAppliedDate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtAppliedDate.Location = New System.Drawing.Point(136, 97)
        Me.dtAppliedDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtAppliedDate.Name = "dtAppliedDate"
        Me.dtAppliedDate.Size = New System.Drawing.Size(298, 23)
        Me.dtAppliedDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Applied Date:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(232, 126)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 25)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "INSERT PRICE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtSupItemCode
        '
        Me.txtSupItemCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupItemCode.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupItemCode.Location = New System.Drawing.Point(136, 38)
        Me.txtSupItemCode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSupItemCode.MaxLength = 19
        Me.txtSupItemCode.Name = "txtSupItemCode"
        Me.txtSupItemCode.Size = New System.Drawing.Size(298, 23)
        Me.txtSupItemCode.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Supplier Item Code"
        '
        'FrmSupplierItemPriceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(473, 160)
        Me.Controls.Add(Me.txtSupItemCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtAppliedDate)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.txtSupDes)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmSupplierItemPriceEntry"
        Me.Text = "Item Price Entry"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSupplier As Button
    Friend WithEvents txtSupDes As TextBox
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtAppliedDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSupItemCode As TextBox
    Friend WithEvents Label2 As Label
End Class
