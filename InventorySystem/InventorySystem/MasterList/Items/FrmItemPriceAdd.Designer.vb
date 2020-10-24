<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemPriceAdd
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
        Me.txtUnitPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(154, 78)
        Me.txtUnitPrice.MaxLength = 19
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(328, 26)
        Me.txtUnitPrice.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Unit Price:"
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Location = New System.Drawing.Point(236, 12)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(32, 26)
        Me.btnSupplier.TabIndex = 0
        Me.btnSupplier.Text = "..."
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'txtSupDes
        '
        Me.txtSupDes.BackColor = System.Drawing.Color.White
        Me.txtSupDes.Enabled = False
        Me.txtSupDes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupDes.Location = New System.Drawing.Point(272, 12)
        Me.txtSupDes.Name = "txtSupDes"
        Me.txtSupDes.Size = New System.Drawing.Size(255, 26)
        Me.txtSupDes.TabIndex = 56
        '
        'txtSupplierID
        '
        Me.txtSupplierID.BackColor = System.Drawing.Color.LightBlue
        Me.txtSupplierID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierID.Location = New System.Drawing.Point(154, 12)
        Me.txtSupplierID.MaxLength = 25
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(114, 26)
        Me.txtSupplierID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Supplier ID:"
        '
        'dtAppliedDate
        '
        Me.dtAppliedDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAppliedDate.Location = New System.Drawing.Point(154, 110)
        Me.dtAppliedDate.Name = "dtAppliedDate"
        Me.dtAppliedDate.Size = New System.Drawing.Size(328, 26)
        Me.dtAppliedDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Applied Date:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(224, 142)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "INSERT PRICE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtSupItemCode
        '
        Me.txtSupItemCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupItemCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupItemCode.Location = New System.Drawing.Point(154, 44)
        Me.txtSupItemCode.MaxLength = 19
        Me.txtSupItemCode.Name = "txtSupItemCode"
        Me.txtSupItemCode.Size = New System.Drawing.Size(328, 26)
        Me.txtSupItemCode.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Supplier Item Code"
        '
        'FrmItemPriceAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 180)
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
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmItemPriceAdd"
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
